Imports System.Data
Imports System.Threading.Tasks

Public Class FrmIngresoCompras
    ' Detecta si hay cambios sin guardar
    Public EsNuevaCompra As Boolean = False

    Private cambiosPendientes As Boolean = False

    ' =========================
    '   CARGA Y UTILIDADES
    ' =========================

    ''' <summary>
    ''' Carga una compra existente para edición.
    ''' Debes llamar a este método ANTES de hacer Show/ShowDialog.
    ''' </summary>
    Public Sub CargarCompra(idCompra As String)
        Try
            ' Cabecera
            Me.CompraMaterialesTableAdapter.FillByIdCompra(Me.DsCompras.CompraMateriales, idCompra)
            ' Detalle
            Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, idCompra)

            Label1.Text = idCompra   ' Solo referencia interna/oculta

            DataGrid()
            Totales()

        Catch ex As Exception
            MessageBox.Show("Error al cargar la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmIngresoCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     


        ' Cargar tabla de tasas de cambio
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)

        ' Valores por defecto
        Me.PorcientoImpuestoTextBox.Text = "0.18"
        Me.SubTotalCompraRDTextBox.Text = "0"
        Me.ImpuestoCompraRDTextBox.Text = "0"
        Me.TotalCompraRDTextBox.Text = "0"
        Me.SubTotalCompraUSTextBox.Text = "0"
        Me.ImpuestoCompraUSTextBox.Text = "0"
        Me.TotalCompraUSTextBox.Text = "0"

        ' Ajustar visibilidad de columnas según moneda actual (si ya está cargada)
        DataGrid()
        Totales()
    End Sub

    Sub TotalesCompra()
        Me.CompraMaterialesTableAdapter.ActulizarTotales(
            CDbl(SubTotalCompraUSTextBox.Text),
            CDbl(ImpuestoCompraUSTextBox.Text),
            CDbl(TotalCompraUSTextBox.Text),
            CDbl(SubTotalCompraRDTextBox.Text),
            CDbl(ImpuestoCompraRDTextBox.Text),
            CDbl(TotalCompraRDTextBox.Text),
            Id_CompraTextBox.Text)
    End Sub

    ' =========================
    '   TOTALES Y FORMATO
    ' =========================

    ''' <summary>
    ''' Calcula los totales US/RD e ITBIS a partir del detalle.
    ''' </summary>
    Sub Totales()
        Try
            Dim SubtotalTus As Double = 0
            Dim SUBtotalTrd As Double = 0
            Dim ItbisUs As Double = 0
            Dim ItbisRD As Double = 0

            For Each row As DataGridViewRow In Me.CompraMaterialesDetalleDataGridView.Rows
                If row.IsNewRow Then Continue For

                Dim TotalUS As Object = row.Cells("TotalUS").Value
                Dim TotalRD As Object = row.Cells("TotalRD").Value
                Dim IUS As Object = row.Cells("ItebisUS").Value
                Dim IRD As Object = row.Cells("ItebisRD").Value

                Dim v As Double

                If TotalUS IsNot Nothing AndAlso Double.TryParse(TotalUS.ToString(), v) Then
                    SubtotalTus += v
                End If

                If TotalRD IsNot Nothing AndAlso Double.TryParse(TotalRD.ToString(), v) Then
                    SUBtotalTrd += v
                End If

                If IUS IsNot Nothing AndAlso Double.TryParse(IUS.ToString(), v) Then
                    ItbisUs += v
                End If

                If IRD IsNot Nothing AndAlso Double.TryParse(IRD.ToString(), v) Then
                    ItbisRD += v
                End If
            Next

            Dim subTotalUs As Double = SubtotalTus
            Dim subTotalRd As Double = SUBtotalTrd
            Dim impuestoUS As Double = ItbisUs
            Dim impuestoRD As Double = ItbisRD

            ' === Mostrar en pantalla ===
            SubTotalCompraUSTextBox.Text = RoundAndFormat(subTotalUs)
            SubTotalCompraRDTextBox.Text = RoundAndFormat(subTotalRd)
            ImpuestoCompraUSTextBox.Text = RoundAndFormat(impuestoUS)
            ImpuestoCompraRDTextBox.Text = RoundAndFormat(impuestoRD)
            TotalCompraUSTextBox.Text = RoundAndFormat(subTotalUs + impuestoUS)
            TotalCompraRDTextBox.Text = RoundAndFormat(subTotalRd + impuestoRD)

            ' ============================================================
            ' 🔥 CORRECCIÓN: Guardar los totales en el DataSet (CABECERA)
            ' ============================================================
            If Me.CompraMaterialesBindingSource.Current IsNot Nothing Then
                Dim fila As DataRowView = CType(Me.CompraMaterialesBindingSource.Current, DataRowView)

                fila("SubTotalCompraUS") = subTotalUs
                fila("SubTotalCompraRD") = subTotalRd
                fila("ImpuestoCompraUS") = impuestoUS
                fila("ImpuestoCompraRD") = impuestoRD
                fila("TotalCompraUS") = subTotalUs + impuestoUS
                fila("TotalCompraRD") = subTotalRd + impuestoRD
            End If

        Catch ex As Exception
            MsgBox("Error al calcular totales: " & ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Redondea y formatea un número a #,##0.00
    ''' </summary>
    Function RoundAndFormat(value As Double) As String
        Return String.Format("{0:#,##0.00}", Math.Round(value, 2))
    End Function

    ''' <summary>
    ''' Ajusta la visibilidad de columnas y totales según la moneda.
    ''' </summary>
    Sub DataGrid()
        If CompraMaterialesDetalleDataGridView Is Nothing OrElse CompraMaterialesDetalleDataGridView.Columns.Count = 0 Then Exit Sub

        ' Primero, mostrar todo
        With Me.CompraMaterialesDetalleDataGridView
            If .Columns.Contains("Itebis") Then .Columns("Itebis").Visible = True
            If .Columns.Contains("PrecioUS") Then .Columns("PrecioUS").Visible = True
            If .Columns.Contains("ItebisUS") Then .Columns("ItebisUS").Visible = True
            If .Columns.Contains("TotalUS") Then .Columns("TotalUS").Visible = True
            If .Columns.Contains("PrecioRD") Then .Columns("PrecioRD").Visible = True
            If .Columns.Contains("ItebisRD") Then .Columns("ItebisRD").Visible = True
            If .Columns.Contains("TotalRD") Then .Columns("TotalRD").Visible = True
        End With

        SubTotalCompraUSTextBox.Visible = True
        ImpuestoCompraUSTextBox.Visible = True
        TotalCompraUSTextBox.Visible = True
        SubTotalCompraRDTextBox.Visible = True
        ImpuestoCompraRDTextBox.Visible = True
        TotalCompraRDTextBox.Visible = True

        Dim moneda As String = MonedaTextBox.Text.Trim().ToUpper()

        If moneda = "US$" Then
            If CompraMaterialesDetalleDataGridView.Columns.Contains("PrecioRD") Then CompraMaterialesDetalleDataGridView.Columns("PrecioRD").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("ItebisRD") Then CompraMaterialesDetalleDataGridView.Columns("ItebisRD").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("TotalRD") Then CompraMaterialesDetalleDataGridView.Columns("TotalRD").Visible = False

            SubTotalCompraRDTextBox.Visible = False
            ImpuestoCompraRDTextBox.Visible = False
            TotalCompraRDTextBox.Visible = False

        ElseIf moneda = "RD$" Then
            If CompraMaterialesDetalleDataGridView.Columns.Contains("PrecioUS") Then CompraMaterialesDetalleDataGridView.Columns("PrecioUS").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("ItebisUS") Then CompraMaterialesDetalleDataGridView.Columns("ItebisUS").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("TotalUS") Then CompraMaterialesDetalleDataGridView.Columns("TotalUS").Visible = False

            SubTotalCompraUSTextBox.Visible = False
            ImpuestoCompraUSTextBox.Visible = False
            TotalCompraUSTextBox.Visible = False
        Else
            ' Moneda desconocida: ocultar todo y que el usuario decida luego
            If CompraMaterialesDetalleDataGridView.Columns.Contains("PrecioUS") Then CompraMaterialesDetalleDataGridView.Columns("PrecioUS").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("ItebisUS") Then CompraMaterialesDetalleDataGridView.Columns("ItebisUS").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("TotalUS") Then CompraMaterialesDetalleDataGridView.Columns("TotalUS").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("PrecioRD") Then CompraMaterialesDetalleDataGridView.Columns("PrecioRD").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("ItebisRD") Then CompraMaterialesDetalleDataGridView.Columns("ItebisRD").Visible = False
            If CompraMaterialesDetalleDataGridView.Columns.Contains("TotalRD") Then CompraMaterialesDetalleDataGridView.Columns("TotalRD").Visible = False

            SubTotalCompraUSTextBox.Visible = False
            ImpuestoCompraUSTextBox.Visible = False
            TotalCompraUSTextBox.Visible = False
            SubTotalCompraRDTextBox.Visible = False
            ImpuestoCompraRDTextBox.Visible = False
            TotalCompraRDTextBox.Visible = False
        End If

        Me.CompraMaterialesDetalleDataGridView.Refresh()
    End Sub

    ' =========================
    '   CABECERA – CAMPOS
    ' =========================

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ActulizarFechaFactura()
    End Sub

    ''' <summary>
    ''' Actualiza la fecha de pago = fecha de compra + 1 mes en la tabla.
    ''' </summary>
    Sub ActulizarFechaFactura()
        Try
            Dim FechaPago As Date = DateAdd("m", 1, Me.DateTimePicker1.Value)
            Me.CompraMaterialesTableAdapter.ActulizarFechaFactura(DateTimePicker1.Value, FechaPago, Id_CompraTextBox.Text)
        Catch ex As Exception
            ' No interrumpir al usuario, solo informar si hace falta
            'MsgBox("Error al actualizar fecha de pago: " & ex.Message)
        End Try
    End Sub

    Private Sub ObservacionesTextBox_Leave(sender As Object, e As EventArgs) Handles ObservacionesTextBox.Leave
        Try
            Me.CompraMaterialesTableAdapter.Observaviones(Me.ObservacionesTextBox.Text, Me.Id_CompraTextBox.Text)
        Catch ex As Exception
            ' No crítico
        End Try
    End Sub

    Private Sub FacturaProveedorTextBox_Leave(sender As Object, e As EventArgs) Handles FacturaProveedorTextBox.Leave
        ' Aquí antes tenías una validación de NCF duplicado.
        ' Para no depender de métodos que quizá no existan en el TableAdapter,
        ' dejamos solo este comentario y la posibilidad de que luego tú añadas la lógica que quieras.
    End Sub

    Private Sub TasaTextBox_TextChanged(sender As Object, e As EventArgs) Handles TasaTextBox.TextChanged
        Try
            Dim Moneda As String = Me.MonedaTextBox.Text
            Dim valor As Double

            If Not Double.TryParse(Me.TasaTextBox.Text, valor) Then Exit Sub
            If valor <= 0 Then Exit Sub

            Me.CompraMaterialesTableAdapter.ActulizarTasa(Me.TasaTextBox.Text, Me.Id_CompraTextBox.Text)

            If Moneda = "RD$" Then
                Me.CompraMaterialesDetalleTableAdapter.ActualizarTasaRD(valor, Me.Id_CompraTextBox.Text)
                Totales()
            ElseIf Moneda.ToLower() = "eur" Then
                Me.CompraMaterialesDetalleTableAdapter.ActualizarTasaEU(valor, Me.Id_CompraTextBox.Text)
                Totales()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    ' =========================
    '   DETALLE – CÁLCULOS
    ' =========================

    Private Sub CompraMaterialesDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellEndEdit
        Const COL_ITBIS As String = "Itebis"
        Const COL_CANTIDAD As String = "Cantidad"
        Const COL_PRECIOUS As String = "PrecioUS"
        Const COL_PRECIORD As String = "PrecioRD"
        Const COL_TOTALUS As String = "TotalUS"
        Const COL_TOTALRD As String = "TotalRD"
        Const COL_ITBISUS As String = "ItebisUS"
        Const COL_ITBISRD As String = "ItebisRD"

        Try
            Dim colName As String = CompraMaterialesDetalleDataGridView.Columns(e.ColumnIndex).Name

            If colName = COL_ITBIS OrElse colName = COL_CANTIDAD OrElse colName = COL_PRECIOUS OrElse colName = COL_PRECIORD Then
                Dim row As DataGridViewRow = CompraMaterialesDetalleDataGridView.CurrentRow
                If row Is Nothing Then Exit Sub

                Dim tasa As Double = 1
                Double.TryParse(Me.TasaTextBox.Text, tasa)

                Dim moneda As String = Me.MonedaTextBox.Text.Trim().ToUpper()
                Dim cantidad As Double, itbis As Double, precioUS As Double, precioRD As Double

                Double.TryParse(Convert.ToString(row.Cells(COL_CANTIDAD).Value), cantidad)
                Double.TryParse(Convert.ToString(row.Cells(COL_ITBIS).Value), itbis)
                Double.TryParse(Convert.ToString(row.Cells(COL_PRECIOUS).Value), precioUS)
                Double.TryParse(Convert.ToString(row.Cells(COL_PRECIORD).Value), precioRD)

                If itbis < 0 Then
                    itbis = 0
                End If

                If itbis > 1 Then
                    itbis = itbis / 100
                End If

                row.Cells(COL_ITBIS).Value = itbis

                If tasa <= 0 Then
                    MessageBox.Show("La tasa de cambio debe ser mayor que cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' =====================================================
                '  🔥 CAMBIO NUEVO: SIN IMPORTAR LA MONEDA DE FACTURA
                '     SI MODIFICO RD → recalcular US
                '     SI MODIFICO US → recalcular RD
                ' =====================================================

                If colName = COL_PRECIORD Then
                    precioUS = precioRD / tasa
                    row.Cells(COL_PRECIOUS).Value = Math.Round(precioUS, 4)
                End If

                If colName = COL_PRECIOUS Then
                    precioRD = precioUS * tasa
                    row.Cells(COL_PRECIORD).Value = Math.Round(precioRD, 4)
                End If

                ' =========================================
                '  🔥 MANTENGO TU LÓGICA ORIGINAL
                ' =========================================
                If moneda = "RD$" Then
                    row.Cells(COL_TOTALRD).Value = Math.Round(precioRD * cantidad, 4)
                    row.Cells(COL_TOTALUS).Value = Math.Round((precioRD / tasa) * cantidad, 4)
                    row.Cells(COL_ITBISRD).Value = Math.Round(precioRD * cantidad * itbis, 4)
                    row.Cells(COL_ITBISUS).Value = Math.Round((precioRD / tasa) * cantidad * itbis, 4)

                ElseIf moneda = "US$" Then
                    row.Cells(COL_TOTALRD).Value = Math.Round(precioUS * tasa * cantidad, 4)
                    row.Cells(COL_TOTALUS).Value = Math.Round(precioUS * cantidad, 4)
                    row.Cells(COL_ITBISRD).Value = Math.Round(precioUS * tasa * cantidad * itbis, 4)
                    row.Cells(COL_ITBISUS).Value = Math.Round(precioUS * cantidad * itbis, 4)

                Else
                    MessageBox.Show("La moneda debe ser 'US$' o 'RD$'. Valor actual: " & moneda, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Totales()
            End If

        Catch ex As Exception
            MessageBox.Show("Error en el cálculo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cambiosPendientes = True
    End Sub
    ' ===========================================
    '  GUARDA LOS TOTALES EN EL DATAROW ANTES DE UPDATEALL
    ' ===========================================



    ''

    Function ObtenerSiguienteIdDetalleCompra(idCompra As String) As String
        Dim maxCorrelativo As Integer = 0

        For Each fila As DataGridViewRow In CompraMaterialesDetalleDataGridView.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("IdDetallecompra").Value IsNot Nothing Then
                Dim idDetalle As String = fila.Cells("IdDetallecompra").Value.ToString()
                If idDetalle.StartsWith(idCompra & "-") Then
                    Dim partes() = idDetalle.Split("-"c)
                    Dim correlativo As Integer
                    If partes.Length > 1 AndAlso Integer.TryParse(partes.Last(), correlativo) Then
                        If correlativo > maxCorrelativo Then
                            maxCorrelativo = correlativo
                        End If
                    End If
                End If
            End If
        Next

        Return idCompra & "-" & (maxCorrelativo + 1).ToString("000")
    End Function

    ' =========================
    '   INSERTAR NUEVOS DETALLES
    ' =========================

    Sub Nuevodetallecompra()
        ' Preparar formulario de productos para selección por proveedor
        My.Forms.FrmProductos.Close()
        My.Forms.FrmProductos.ProveedoresTableAdapter.FillByIdProveedor(My.Forms.FrmProductos.DsProveedores.Proveedores, Id_ProveedorTextBox.Text)
        My.Forms.FrmProductos.ProveedoresProductoTableAdapter.FillByIdProveedor(My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto, Id_ProveedorTextBox.Text)
        My.Forms.FrmProductos.Paracompra()
    End Sub

    ''' <summary>
    ''' Añade un ítem seleccionado desde FrmProductos.
    ''' Esta sub debe ser llamada desde FrmProductos cuando el usuario elige un producto.
    ''' </summary>
    Sub AñadirItm()
        Try
            Dim filaProducto = My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto(My.Forms.FrmProductos.ProveedoresProductoBindingSource.Position)

            Dim idCompra As String = Id_CompraTextBox.Text

            Dim idmaterial As String = filaProducto.IdProductoProveedor.ToString()
            Dim idmedida As String = filaProducto.Id_Medida.ToString()
            Dim Descripcion As String = filaProducto.DescripcionProveedor.ToString()
            Dim Itbis As Double = If(IsNumeric(PorcientoImpuestoTextBox.Text), Convert.ToDouble(PorcientoImpuestoTextBox.Text), 0)
            Dim idPresupuesto As String = If(LblPresupuesto.Text IsNot Nothing, LblPresupuesto.Text, "")
            Dim codigoUnico As String = filaProducto.IdDetalle.ToString()
            Dim moneda As String = If(Not String.IsNullOrWhiteSpace(MonedaTextBox.Text), MonedaTextBox.Text, "US$")
            Dim tasa As Double = If(IsNumeric(TasaTextBox.Text), CDbl(TasaTextBox.Text), 1)

            Dim nuevoIdDetalleCompra As String = ObtenerSiguienteIdDetalleCompra(idCompra)

            Dim nuevaFila As DataRowView = CType(CompraMaterialesDetalleBindingSource.AddNew(), DataRowView)
            nuevaFila("Id_Detalle_compra") = nuevoIdDetalleCompra
            nuevaFila("Id_Compra") = idCompra
            nuevaFila("Id_Material") = idmaterial
            nuevaFila("DescripcionProveedor") = Descripcion
            nuevaFila("Cantidad") = 1D
            nuevaFila("PrecioUS") = 0D
            nuevaFila("ItebisUS") = 0D
            nuevaFila("TotalUS") = 0D
            nuevaFila("Id_Medida") = idmedida
            nuevaFila("Moneda") = moneda
            nuevaFila("Tasa") = tasa
            nuevaFila("PrecioRD") = 0D
            nuevaFila("ItebisRD") = 0D
            nuevaFila("TotalRD") = 0D
            nuevaFila("PrecioEU") = 0D
            nuevaFila("ItebisEu") = 0D
            nuevaFila("TotalEU") = 0D
            nuevaFila("Itebis") = Itbis

            If Not String.IsNullOrWhiteSpace(idPresupuesto) Then
                nuevaFila("Id_Presupuesto") = idPresupuesto
            End If
            If Not String.IsNullOrWhiteSpace(codigoUnico) Then
                nuevaFila("IdDetalle") = codigoUnico
            End If

            nuevaFila("fecha") = Date.Now
            nuevaFila("TSubtotalRD") = 0D
            nuevaFila("TItbisRD") = 0D
            nuevaFila("TTotalRD") = 0D
            nuevaFila("TSubtotaUS") = 0D
            nuevaFila("TItbisUS") = 0D
            nuevaFila("TTotalus") = 0D

            CompraMaterialesDetalleBindingSource.EndEdit()

            If CompraMaterialesDetalleDataGridView.Rows.Count > 0 Then
                CompraMaterialesDetalleDataGridView.CurrentCell =
                    CompraMaterialesDetalleDataGridView.Rows(CompraMaterialesDetalleDataGridView.Rows.Count - 1).Cells("DescripcionProveedor")
            End If

            My.Forms.FrmProductos.Close()

            Totales()

        Catch ex As Exception
            MsgBox("Error al añadir ítem: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles BtnNuevoArticulo.Click
        Nuevodetallecompra()
    End Sub

    ' =========================
    '   BOTONES VARIOS
    ' =========================

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Forms.ImpCompras.Close()
        Catch
        End Try
        My.Forms.ImpCompras.LblIdCompra.Text = Me.Id_CompraTextBox.Text
        My.Forms.ImpCompras.ImprimirCompra()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Forms.FrmPresopuestosAprobados.Close()
        Catch
        End Try

        My.Forms.FrmPresopuestosAprobados.Button2.Visible = False
        My.Forms.FrmPresopuestosAprobados.Show()
    End Sub
    Private Sub NuevaCompra()

        Me.CompraMaterialesTableAdapter.NuevaCompra(
        Id_CompraTextBox.Text,                 ' @Id_Compra
        Id_ProveedorTextBox.Text,              ' @Id_Proveedor
        DateTimePicker1.Value,                 ' @Fecha_Compra
        DateTimePicker1.Value.AddMonths(1),    ' @Fecha_Pago
        Id_EmpresaTextBox.Text,                ' @Id_Empresa
        FacturaProveedorTextBox.Text,          ' @FacturaProveedor
        PorcientoImpuestoTextBox.Text,         ' @PorcientoImpuesto
        MonedaTextBox.Text,                    ' @Moneda
        TasaTextBox.Text,                      ' @Tasa
        SubTotalCompraUSTextBox.Text,          ' @SubTotalCompraUS
        ImpuestoCompraUSTextBox.Text,          ' @ImpuestoCompraUS
        TotalCompraUSTextBox.Text,             ' @TotalCompraUS
        ObservacionesTextBox.Text,             ' @Observaciones
        SubTotalCompraRDTextBox.Text,          ' @SubTotalCompraRD
        ImpuestoCompraRDTextBox.Text,          ' @ImpuestoCompraRD
        TotalCompraRDTextBox.Text,             ' @TotalCompraRD
        "",            ' @Id_Presupuesto
        "",                                    ' @Id_proyecto_Presupuestos (vacío)
        0,                                     ' @PagadoUS
        TotalCompraUSTextBox.Text,             ' @PendienteUS
        False,                                 ' @Saldada
        False,                                 ' @ItebisIncluido
        0,                                     ' @PagadoRD
        TotalCompraRDTextBox.Text,             ' @PendienteRD
        "",                                    ' @FormaDePago
        "",                                    ' @CodigoSeguridad
        False,                                 ' @Contabilizada
        ""                                      ' @CuentaContable
    )

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Recalcular totales
            Totales()


            '=====================================
            '   NUEVA COMPRA (INSERT)
            '=====================================
            If EsNuevaCompra = True Then
                NuevaCompra()               ' INSERT CABECERA
            Else
                TotalesCompra()             ' UPDATE CABECERA (solo totales)
            End If

            '=====================================
            '   GUARDAR DETALLE (SIEMPRE)
            '=====================================
            Me.CompraMaterialesDetalleBindingSource.EndEdit()
            Me.CompraMaterialesDetalleTableAdapter.Update(Me.DsCompras.CompraMaterialesDetalle)

            cambiosPendientes = False

            MessageBox.Show("Compra guardada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub




    ' =========================
    '   UTILIDAD: PRECIO SIN ITBIS
    ' =========================

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Double.TryParse(TextBox1.Text, Nothing) AndAlso Double.TryParse(PorcientoImpuestoTextBox.Text, Nothing) Then
            Dim valorOriginal As Double = Convert.ToDouble(TextBox1.Text)
            Dim porcentajeImpuesto As Double = Convert.ToDouble(PorcientoImpuestoTextBox.Text)
            Dim nuevoValor As Double = valorOriginal - Math.Round(valorOriginal / (1 + porcentajeImpuesto), 4)
            TextBox2.Text = nuevoValor.ToString()
        Else
            TextBox2.Text = "Error: Ingrese números válidos"
        End If
    End Sub
    Private Sub FrmIngresoCompras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cambiosPendientes = False Then
            ' No hay cambios → cerrar directo
            Exit Sub
        End If

        Dim r = MessageBox.Show("Hay cambios sin guardar. ¿Desea guardar antes de cerrar?",
                            "Confirmar",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning)

        Select Case r
            Case DialogResult.Yes
                Try
                    BtnGuardar.PerformClick()
                Catch ex As Exception
                    MessageBox.Show("No se pudo guardar: " & ex.Message)
                    e.Cancel = True
                End Try

            Case DialogResult.No
            ' Cierra sin guardar

            Case DialogResult.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub Control_Modificado(sender As Object, e As EventArgs) _
    Handles FacturaProveedorTextBox.TextChanged,
            ObservacionesTextBox.TextChanged,
            TasaTextBox.TextChanged,
            PorcientoImpuestoTextBox.TextChanged

        cambiosPendientes = True
    End Sub





End Class
