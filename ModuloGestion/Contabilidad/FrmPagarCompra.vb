Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Globalization

Public Class FrmPagarCompra

    ' ==========
    '  PÚBLICO
    ' ==========

    ' Monto total sugerido al abrir el formulario (se recalcula según edición en la grilla)
    Public MontoPago As Double

    ' Moneda base del pago: "RD$" o "US$"
    Public MonedaPago As String

    ' Tabla con las facturas seleccionadas (se asigna desde FrmCuentasPorPagar)
    Public TablaFacturasSeleccionadas As New DataTable

    ' ==========
    '  LOAD
    ' ==========

    Private Sub FrmPagarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     

        ' Tasa del día
        CargarTasaMedia()

        ' Cuentas (forma de pago)
        CargarCombo()

        ' Monto inicial
        TxtMonto.Text = MontoPago.ToString("N2")

        ' Configurar moneda del pago
        Select Case MonedaPago
            Case "RD$"
                RbRD.Checked = True
                RbRD.Enabled = True
                RbUS.Enabled = False

            Case "US$"
                RbUS.Checked = True
                RbUS.Enabled = True
                RbRD.Enabled = False

            Case Else
                RbRD.Enabled = False
                RbUS.Enabled = False
                MessageBox.Show("Moneda no reconocida: " & MonedaPago,
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select

        ' Cargar cuentas contables
        Me.CuentasTableAdapter.Fill(Me.DsContabilidad.Cuentas)

        ' Asignar tabla de facturas al DGV
        DgvFacturasSeleccionadas.DataSource = TablaFacturasSeleccionadas
        DgvFacturasSeleccionadas.ReadOnly = False
        DgvFacturasSeleccionadas.AllowUserToAddRows = False
        DgvFacturasSeleccionadas.AllowUserToDeleteRows = False

        ' Solo "MontoAPagar" editable
        For Each col As DataGridViewColumn In DgvFacturasSeleccionadas.Columns
            If col.Name = "MontoAPagar" Then
                col.ReadOnly = False
                col.DefaultCellStyle.Format = "N2"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.HeaderText = "Monto a Pagar"
            Else
                col.ReadOnly = True
            End If
        Next
    End Sub

    ' ==========
    '  COMBOS
    ' ==========

    Private Sub CargarCombo()
        Me.CuentasTableAdapter.Fill(Me.DsContabilidad.Cuentas)

        Dim tablaCuentasConDescripcion As DataTable = Me.DsContabilidad.Cuentas.Copy()
        If Not tablaCuentasConDescripcion.Columns.Contains("DescripcionCompleta") Then
            tablaCuentasConDescripcion.Columns.Add("DescripcionCompleta", GetType(String))
        End If

        For Each fila As DataRow In tablaCuentasConDescripcion.Rows
            fila("DescripcionCompleta") = $"{fila("Institucion")} {fila("TipodeCuenta")} {fila("NumeroDeCuenta")}"
        Next

        With CmbFormaPago
            .DataSource = tablaCuentasConDescripcion
            .DisplayMember = "DescripcionCompleta"
            .ValueMember = "IdContable"
        End With

        ' Valor por defecto (si existe ese IdContable)
        Try
            CmbFormaPago.SelectedValue = "111-01"
        Catch
        End Try
    End Sub

    ' ==========
    '  TASA
    ' ==========

    Private Sub CargarTasaMedia()
        Dim fechaPago As Date = DateTimePicker1.Value.Date
        Dim tasaEncontrada As Boolean = False

        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)

        ' Tasa exacta
        Dim tasaExacta = DsTasa.Tasa.AsEnumerable().
            FirstOrDefault(Function(r) CDate(r("IdFecha")) = fechaPago)

        If tasaExacta IsNot Nothing Then
            MediaTextBox.Text = Format(CDec(tasaExacta("Media")), "N4")
            tasaEncontrada = True
        Else
            ' Última anterior
            Dim tasaAnterior = DsTasa.Tasa.AsEnumerable().
                Where(Function(r) CDate(r("IdFecha")) < fechaPago).
                OrderByDescending(Function(r) CDate(r("IdFecha"))).
                FirstOrDefault()

            If tasaAnterior IsNot Nothing Then
                MediaTextBox.Text = Format(CDec(tasaAnterior("Media")), "N4")
                tasaEncontrada = True
                MessageBox.Show("No hay tasa para el día seleccionado. Se usó la tasa anterior del " &
                                CDate(tasaAnterior("IdFecha")).ToShortDateString() & ".",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If Not tasaEncontrada Then
            MediaTextBox.Text = ""
            MessageBox.Show("No se encontró ninguna tasa para esta fecha ni anteriores.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CargarTasaMedia()
    End Sub

    ' ==========
    '  PARSEO NÚMEROS
    ' ==========

    Public Function ParseDecimalFlexible(texto As String) As Decimal
        Dim limpio As String = If(texto, "").Trim()
        If limpio = "" Then Return 0D

        Dim valor As Decimal

        ' 1. Cultura actual
        If Decimal.TryParse(limpio, NumberStyles.Any,
                            CultureInfo.CurrentCulture, valor) Then
            Return valor
        End If

        ' 2. Cambiando punto/coma si aplica
        If limpio.Contains(".") AndAlso
           CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = "," Then

            Dim intento2 = limpio.Replace(".", ",")
            If Decimal.TryParse(intento2, NumberStyles.Any,
                                CultureInfo.CurrentCulture, valor) Then
                Return valor
            End If
        End If

        ' 3. Cultura invariable (en-US)
        If Decimal.TryParse(limpio, NumberStyles.Any,
                            CultureInfo.InvariantCulture, valor) Then
            Return valor
        End If

        ' 4. Error
        MessageBox.Show("El valor '" & texto & "' no es un número válido. " &
                        "Escribe el monto con punto o coma como separador decimal.",
                        "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return 0D
    End Function

    Public Sub RegistrarPagoCompleto()
        Try
            ' PROVEEDOR
            Dim idProveedor As String = FrmCuentasPorPagar.ProveedoresDataGridView.CurrentRow.
                                    Cells("Id_Proveedor").Value.ToString()

            Dim fechaPago As Date = DateTimePicker1.Value
            Dim monto As Decimal = ParseDecimalFlexible(TxtMonto.Text)
            Dim tasaCambio As Decimal = ParseDecimalFlexible(MediaTextBox.Text)

            ' FORMA DE PAGO
            Dim formaDePago As String = If(CmbFormaPago.SelectedValue IsNot Nothing,
                                       CmbFormaPago.SelectedValue.ToString(), "")

            ' MONEDA DEL PAGO
            Dim monedaPago As String = If(RbRD.Checked, "RD$", "US$")

            ' ===== VALORES ENCABEZADO =====
            Dim valorRD As Decimal = If(monedaPago = "RD$", monto, monto * tasaCambio)
            Dim valorUS As Decimal = If(monedaPago = "US$", monto, monto / tasaCambio)

            ' ===== INSERTAR ENCABEZADO =====
            Me.PagoProveedorTableAdapter.Insert(
            idProveedor,
            fechaPago,
            valorUS,
            valorRD,
            valorUS, 'AsignadoUS
            valorRD, 'AsignadoRD
            0D,      'PendienteAsignarUS
            0D,      'PendienteAsignarRD
            formaDePago,
            monedaPago,
            ""
        )

            ' RECUPERAR ID INSERTADO
            Me.PagoProveedorTableAdapter.Fill(Me.DsCompras.PagoProveedor)
            Dim idPagoProveedor As Integer =
            CInt(Me.DsCompras.PagoProveedor.Rows(Me.DsCompras.PagoProveedor.Rows.Count - 1)("IdPagoProveedor"))

            ' ===== RECORRER FACTURAS =====
            For Each fila As DataGridViewRow In DgvFacturasSeleccionadas.Rows
                If fila.IsNewRow Then Continue For

                Dim idCompra As String = fila.Cells("Id_Compra").Value.ToString()
                Dim monedaFactura As String = fila.Cells("Moneda").Value.ToString()
                Dim pendiente As Decimal = ParseDecimalFlexible(fila.Cells("Pendiente").Value.ToString())
                Dim montoAPagar As Decimal = ParseDecimalFlexible(fila.Cells("MontoAPagar").Value.ToString())

                If montoAPagar <= 0 Then Continue For

                ' AJUSTAR para no pagar de más
                If montoAPagar > pendiente Then
                    montoAPagar = pendiente
                    fila.Cells("MontoAPagar").Value = pendiente.ToString("N2")
                End If

                ' CALCULAR valores según moneda del pago
                Dim pagoRD As Decimal = If(monedaPago = "RD$", montoAPagar, montoAPagar * tasaCambio)
                Dim pagoUS As Decimal = If(monedaPago = "US$", montoAPagar, montoAPagar / tasaCambio)

                ' INSERTAR DETALLE
                Me.PagoProveedorDetalleTableAdapter.Insert(
                idPagoProveedor,
                idCompra,
                pagoUS,
                pagoRD,
                fechaPago,
                monedaPago
            )

                ' SQL PARA ACTUALIZAR FACTURA
                Dim sql As String = ""

                If monedaFactura = "RD$" Then
                    sql = "
UPDATE CompraMateriales SET
    PagadoRD    = ISNULL(PagadoRD,0) + @PagoRD,
    PendienteRD = ISNULL(PendienteRD,0) - @PagoRD,
    PagadoUS    = ISNULL(PagadoUS,0) + @PagoUS,
    PendienteUS = ISNULL(PendienteUS,0) - @PagoUS,
    Saldada     = CASE WHEN (ISNULL(PendienteRD,0) - @PagoRD) <= 0 THEN 1 ELSE 0 END
WHERE Id_Compra = @IdCompra"
                Else
                    sql = "
UPDATE CompraMateriales SET
    PagadoUS    = ISNULL(PagadoUS,0) + @PagoUS,
    PendienteUS = ISNULL(PendienteUS,0) - @PagoUS,
    PagadoRD    = ISNULL(PagadoRD,0) + @PagoRD,
    PendienteRD = ISNULL(PendienteRD,0) - @PagoRD,
    Saldada     = CASE WHEN (ISNULL(PendienteUS,0) - @PagoUS) <= 0 THEN 1 ELSE 0 END
WHERE Id_Compra = @IdCompra"
                End If

                ' EJECUTAR SQL
                Using cn As New SqlConnection(Me.PagoProveedorTableAdapter.Connection.ConnectionString)
                    cn.Open()
                    Using cmd As New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@IdCompra", idCompra)
                        cmd.Parameters.AddWithValue("@PagoRD", pagoRD)
                        cmd.Parameters.AddWithValue("@PagoUS", pagoUS)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

            Next

            MessageBox.Show("Pago registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al registrar el pago: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    ' ==========
    '  DGV EDICIÓN MONTOAPAGAR
    ' ==========

    Private Sub DgvFacturasSeleccionadas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFacturasSeleccionadas.CellEndEdit
        If e.RowIndex >= 0 AndAlso
           DgvFacturasSeleccionadas.Columns(e.ColumnIndex).Name = "MontoAPagar" Then
            CalcularTotalMontoAPagar()
        End If
    End Sub

    Private Sub CalcularTotalMontoAPagar()
        Dim total As Decimal = 0D

        For Each fila As DataGridViewRow In DgvFacturasSeleccionadas.Rows
            If fila.IsNewRow Then Continue For

            If fila.Cells("MontoAPagar").Value IsNot Nothing Then
                Dim valor As Decimal
                If Decimal.TryParse(fila.Cells("MontoAPagar").Value.ToString(), valor) Then
                    total += valor
                End If
            End If
        Next

        TxtMonto.Text = total.ToString("N2")
    End Sub


    ' ==========
    '  BOTÓN REGISTRAR
    ' ==========

    Private Sub BtnRegistrarPago_Click(sender As Object, e As EventArgs) Handles BtnRegistrarPago.Click
        RegistrarPagoCompleto()
    End Sub

End Class
