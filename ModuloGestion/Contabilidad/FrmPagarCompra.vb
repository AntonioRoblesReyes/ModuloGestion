Public Class FrmPagarCompra

    ' Variables públicas para recibir información desde otro formulario
    Public MontoPago As Double
    Public MonedaPago As String
    Public TablaFacturasSeleccionadas As New DataTable
    Sub CargarCombo()
        Me.CuentasTableAdapter.Fill(Me.DsContabilidad.Cuentas)

        ' Crear una nueva tabla con columna combinada
        Dim tablaCuentasConDescripcion As New DataTable
        tablaCuentasConDescripcion = Me.DsContabilidad.Cuentas.Copy()

        ' Añadir columna combinada
        tablaCuentasConDescripcion.Columns.Add("DescripcionCompleta", GetType(String))

        ' Rellenar columna combinada
        For Each fila As DataRow In tablaCuentasConDescripcion.Rows
            fila("DescripcionCompleta") = $"{fila("Institucion")} {fila("TipodeCuenta")} {fila("NumeroDeCuenta")}"
        Next

        ' Asignar al ComboBox
        With CmbFormaPago
            .DataSource = tablaCuentasConDescripcion
            .DisplayMember = "DescripcionCompleta"
            .ValueMember = "IdContable" ' o el campo clave que uses

            CmbFormaPago.SelectedValue = "111-01"
        End With
    End Sub
    Public Function ParseDecimalFlexible(texto As String) As Decimal
        Dim limpio As String = texto.Trim()

        ' 1. Intenta parsear con la cultura actual (normal)
        Dim valor As Decimal
        If Decimal.TryParse(limpio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, valor) Then
            Return valor
        End If

        ' 2. Si falla, prueba cambiando punto por coma
        If limpio.Contains(".") AndAlso System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = "," Then
            Dim intento2 = limpio.Replace(".", ",")
            If Decimal.TryParse(intento2, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, valor) Then
                Return valor
            End If
        End If

        ' 3. Si aún así falla, prueba con cultura "en-US"
        If Decimal.TryParse(limpio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, valor) Then
            Return valor
        End If

        ' 4. Si todo falla, lanza excepción o muestra mensaje y devuelve 0
        MessageBox.Show("El valor '" & texto & "' no es un número válido. Escribe el monto con punto o coma como separador decimal.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return 0
    End Function

    Private Sub FrmPagarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AplicarEstiloFormulario(Me)

        CargarTasaMedia()


        Me.CuentasTableAdapter.Fill(Me.DsContabilidad.Cuentas)
        ' Mostrar el monto de pago formateado
        TxtMonto.Text = MontoPago.ToString("N2")
        CargarCombo()
        ' Configurar moneda y bloquear la opción contraria
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

        ' Asignar la tabla al DataGridView
        DgvFacturasSeleccionadas.DataSource = TablaFacturasSeleccionadas
        DgvFacturasSeleccionadas.ReadOnly = False ' Permitir edición general
        DgvFacturasSeleccionadas.AllowUserToAddRows = False
        DgvFacturasSeleccionadas.AllowUserToDeleteRows = False

        ' Marcar solo MontoAPagar como editable
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
    Private Sub CargarTasaMedia()
        Dim fechaPago As Date = DateTimePicker1.Value.Date
        Dim tasaEncontrada As Boolean = False

        ' Recargar todas las tasas en el DataSet
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)

        ' Buscar tasa exacta
        Dim tasaExacta = DsTasa.Tasa.AsEnumerable().
        FirstOrDefault(Function(r) CDate(r("IdFecha")) = fechaPago)

        If tasaExacta IsNot Nothing Then
            MediaTextBox.Text = Format(CDec(tasaExacta("Media")), "N4")
            tasaEncontrada = True
        Else
            ' Si no existe, buscar la tasa más cercana anterior
            Dim tasaAnterior = DsTasa.Tasa.AsEnumerable().
            Where(Function(r) CDate(r("IdFecha")) < fechaPago).
            OrderByDescending(Function(r) CDate(r("IdFecha"))).
            FirstOrDefault()

            If tasaAnterior IsNot Nothing Then
                MediaTextBox.Text = Format(CDec(tasaAnterior("Media")), "N4")
                tasaEncontrada = True
                MessageBox.Show("No hay tasa para el día seleccionado. Se usó la tasa anterior del " &
                            CDate(tasaAnterior("IdFecha")).ToShortDateString() & ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If Not tasaEncontrada Then
            MediaTextBox.Text = ""
            MessageBox.Show("No se encontró ninguna tasa para esta fecha ni anteriores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CargarTasaMedia()
    End Sub
    Public Sub RegistrarPagoCompleto()
        Try
            Dim idProveedor As String = FrmCuentasPorPagar.ProveedoresDataGridView.CurrentRow.Cells("Id_Proveedor").Value.ToString()
            Dim fechaPago As Date = DateTimePicker1.Value
            Dim monto As Decimal = ParseDecimalFlexible(TxtMonto.Text)
            Dim tasaCambio As Decimal = ParseDecimalFlexible(MediaTextBox.Text)
            Dim formaDePago As String = ""
            If CmbFormaPago.SelectedValue IsNot Nothing Then
                formaDePago = CmbFormaPago.SelectedValue.ToString()
            End If

            ' Protege longitudes máximas
            idProveedor = If(idProveedor.Length > 50, idProveedor.Substring(0, 50), idProveedor)
            formaDePago = If(formaDePago.Length > 10, formaDePago.Substring(0, 10), formaDePago)
            Dim moneda As String = If(RbRD.Checked, "RD$", "US$")
            moneda = If(moneda.Length > 3, moneda.Substring(0, 3), moneda)

            ' Calcula valores
            Dim valorUS As Decimal = 0
            Dim valorRD As Decimal = 0
            If RbRD.Checked Then
                valorRD = monto
                valorUS = If(tasaCambio <> 0, monto / tasaCambio, 0)
            ElseIf RbUS.Checked Then
                valorUS = monto
                valorRD = monto * tasaCambio
            End If

            ' Insertar el encabezado del pago
            Me.PagoProveedorTableAdapter.Insert(
            idProveedor,
            fechaPago,
            valorUS,
            valorRD,
            valorUS,
            valorRD,
            0, 0,
            formaDePago,
            moneda,
            ""
        )

            ' Obtener el IdPagoProveedor recién insertado
            Me.PagoProveedorTableAdapter.Fill(Me.DsCompras.PagoProveedor)
            Dim ultimaFila = Me.DsCompras.PagoProveedor.Rows(Me.DsCompras.PagoProveedor.Rows.Count - 1)
            Dim idPagoProveedor As Integer = Convert.ToInt32(ultimaFila("IdPagoProveedor"))

            ' Insertar los detalles y actualizar saldos en CompraMateriales
            For Each fila As DataGridViewRow In DgvFacturasSeleccionadas.Rows
                If Not fila.IsNewRow Then
                    Dim idCompra As String = fila.Cells("Id_Compra").Value.ToString()
                    Dim montoAPagar As Decimal = ParseDecimalFlexible(fila.Cells("MontoAPagar").Value.ToString())
                    Dim monedaFactura As String = fila.Cells("Moneda").Value.ToString()
                    Dim monedaPago As String = If(RbRD.Checked, "RD$", "US$")
                    Dim fechaPagoDetalle As Date = fechaPago

                    ' Calcula valores de pago en ambas monedas para el detalle
                    Dim pagoUS As Decimal = 0
                    Dim pagoRD As Decimal = 0

                    If monedaPago = "RD$" Then
                        pagoRD = montoAPagar
                        pagoUS = If(tasaCambio <> 0, montoAPagar / tasaCambio, 0)
                    ElseIf monedaPago = "US$" Then
                        pagoUS = montoAPagar
                        pagoRD = montoAPagar * tasaCambio
                    End If

                    ' Inserta detalle de pago
                    Me.PagoProveedorDetalleTableAdapter.Insert(
                    idPagoProveedor,
                    idCompra,
                    pagoUS,
                    pagoRD,
                    fechaPagoDetalle,
                    Nothing
                )

                    ' === ACTUALIZA LOS SALDOS DE LA FACTURA ===
                    Dim sql As String = ""

                    If monedaFactura = "RD$" And monedaPago = "RD$" Then
                        sql = "
                        UPDATE CompraMateriales
                        SET
                            PagadoRD = ISNULL(PagadoRD,0) + @PagoRD,
                            PendienteRD = ISNULL(PendienteRD,0) - @PagoRD,
                            PendienteUS = ISNULL(PendienteUS,0) - (@PagoRD / @TasaCambio),
                            Saldada = CASE WHEN ISNULL(PendienteRD,0) - @PagoRD <= 0 THEN 1 ELSE 0 END
                        WHERE Id_Compra = @IdCompra
                    "
                    ElseIf monedaFactura = "US$" And monedaPago = "US$" Then
                        sql = "
                        UPDATE CompraMateriales
                        SET
                            PagadoUS = ISNULL(PagadoUS,0) + @PagoUS,
                            PendienteUS = ISNULL(PendienteUS,0) - @PagoUS,
                            PendienteRD = ISNULL(PendienteRD,0) - (@PagoUS * @TasaCambio),
                            Saldada = CASE WHEN ISNULL(PendienteUS,0) - @PagoUS <= 0 THEN 1 ELSE 0 END
                        WHERE Id_Compra = @IdCompra
                    "
                    ElseIf monedaFactura = "RD$" And monedaPago = "US$" Then
                        sql = "
                        UPDATE CompraMateriales
                        SET
                            PagadoUS = ISNULL(PagadoUS,0) + @PagoUS,
                            PagadoRD = ISNULL(PagadoRD,0) + (@PagoUS * @TasaCambio),
                            PendienteRD = ISNULL(PendienteRD,0) - (@PagoUS * @TasaCambio),
                            PendienteUS = ISNULL(PendienteUS,0) - @PagoUS,
                            Saldada = CASE WHEN ISNULL(PendienteRD,0) - (@PagoUS * @TasaCambio) <= 0 THEN 1 ELSE 0 END
                        WHERE Id_Compra = @IdCompra
                    "
                    ElseIf monedaFactura = "US$" And monedaPago = "RD$" Then
                        sql = "
                        UPDATE CompraMateriales
                        SET
                            PagadoRD = ISNULL(PagadoRD,0) + @PagoRD,
                            PagadoUS = ISNULL(PagadoUS,0) + (@PagoRD / @TasaCambio),
                            PendienteUS = ISNULL(PendienteUS,0) - (@PagoRD / @TasaCambio),
                            PendienteRD = ISNULL(PendienteRD,0) - @PagoRD,
                            Saldada = CASE WHEN ISNULL(PendienteUS,0) - (@PagoRD / @TasaCambio) <= 0 THEN 1 ELSE 0 END
                        WHERE Id_Compra = @IdCompra
                    "
                    End If

                    Using cn As New SqlClient.SqlConnection(Me.PagoProveedorTableAdapter.Connection.ConnectionString)
                        cn.Open()
                        Using cmd As New SqlClient.SqlCommand(sql, cn)
                            cmd.Parameters.AddWithValue("@IdCompra", idCompra)
                            cmd.Parameters.AddWithValue("@PagoRD", montoAPagar)
                            cmd.Parameters.AddWithValue("@PagoUS", montoAPagar)
                            cmd.Parameters.AddWithValue("@TasaCambio", tasaCambio)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    ' === FIN ACTUALIZA SALDOS ===

                End If
            Next

            MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al registrar el pago: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DgvFacturasSeleccionadas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFacturasSeleccionadas.CellEndEdit
        If e.RowIndex >= 0 AndAlso DgvFacturasSeleccionadas.Columns(e.ColumnIndex).Name = "MontoAPagar" Then
            CalcularTotalMontoAPagar()
        End If
    End Sub

    Private Sub CalcularTotalMontoAPagar()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In DgvFacturasSeleccionadas.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("MontoAPagar").Value IsNot Nothing Then
                Dim valor As Decimal
                If Decimal.TryParse(fila.Cells("MontoAPagar").Value.ToString(), valor) Then
                    total += valor
                End If
            End If
        Next

        TxtMonto.Text = total.ToString("N2")
    End Sub





    Private Sub BtnRegistrarPago_Click(sender As Object, e As EventArgs) Handles BtnRegistrarPago.Click
        RegistrarPagoCompleto()
    End Sub
End Class
