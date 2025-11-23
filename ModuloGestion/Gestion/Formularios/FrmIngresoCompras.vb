Public Class FrmIngresoCompras
    Sub Tasa()

    End Sub
    Sub ValidarDetalle()
        Me.Validate()
        Me.CompraMaterialesDetalleBindingSource.EndEdit()
        Me.CompraMaterialesDetalleTableAdapter.Update(DsCompras)

    End Sub


    Sub ActulizarFechaFactura()
        Dim FechaPago As Date
        FechaPago = DateAdd("m", 1, Me.DateTimePicker1.Value)
        Me.CompraMaterialesTableAdapter.ActulizarFechaFactura(DateTimePicker1.Value, FechaPago, Id_CompraTextBox.Text)
    End Sub




    Sub Totales()
        Try
            ' Calcular totales de Tus y Trd

            Dim SubtotalTus As Double = 0
            Dim SUBtotalTrd As Double = 0
            Dim ItbisUs As Double = 0
            Dim ItbisRD As Double = 0

            For Each row As DataGridViewRow In Me.CompraMaterialesDetalleDataGridView.Rows
                Dim TotalUS As Object = row.Cells("TotalUS").Value
                Dim TotalRD As Object = row.Cells("TotalRD").Value
                Dim IUS As Object = row.Cells("ItebisUS").Value
                Dim IRD As Object = row.Cells("ItebisRD").Value

                If TotalUS IsNot Nothing AndAlso Double.TryParse(TotalUS.ToString(), 0) Then
                    SubtotalTus += Convert.ToDouble(TotalUS)
                End If

                If TotalRD IsNot Nothing AndAlso Double.TryParse(TotalRD.ToString(), 0) Then
                    SUBtotalTrd += Convert.ToDouble(TotalRD)
                End If
                If IUS IsNot Nothing AndAlso Double.TryParse(IUS.ToString(), 0) Then
                    ItbisUs += Convert.ToDouble(IUS)
                End If

                If IRD IsNot Nothing AndAlso Double.TryParse(IRD.ToString(), 0) Then
                    ItbisRD += Convert.ToDouble(IRD)
                End If



            Next

            ' Calcular totales y mostrar en TextBoxes
            Dim subTotalUs As Double = SubtotalTus
            Dim subTotalRd As Double = SUBtotalTrd
            Dim impuestoUS As Double = ItbisUs
            Dim impuestoRD As Double = ItbisRD


            SubTotalCompraUSTextBox.Text = RoundAndFormat(subTotalUs)
            SubTotalCompraRDTextBox.Text = RoundAndFormat(subTotalRd)

            ImpuestoCompraUSTextBox.Text = RoundAndFormat(impuestoUS)
            ImpuestoCompraRDTextBox.Text = RoundAndFormat(impuestoRD)

            TotalCompraUSTextBox.Text = RoundAndFormat(subTotalUs + impuestoUS)
            TotalCompraRDTextBox.Text = RoundAndFormat(subTotalRd + impuestoRD)

            ' Actualizar valores en la base de datos

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub




    ' Función para redondear y formatear un número
    Function RoundAndFormat(value As Double) As String
        Return String.Format("{0:#,##0.00}", Math.Round(value, 2))
    End Function


    Sub NuevaCompra()
        Utilidades.VerificarDatosFechaActual(DsTasa, TasaTableAdapter)

        Dim tasa As Double = Me.DsTasa.Tasa(Me.TasaBindingSource.Position).Media
        Try


            Dim siguienteCompra As String = Me.CompraMaterialesTableAdapter.Siguiente(Id_EmpresaTextBox.Text)
            Me.Id_CompraTextBox.Text = siguienteCompra

            If MonedaTextBox.Text = "RD$" Then
                TasaTextBox.Text = tasa
            ElseIf MonedaTextBox.Text = "US$" Then
                TasaTextBox.Text = tasa

            End If



            Dim fecha As Date = Date.Now
            Dim fechaPago As Date = DateAdd("m", 1, Date.Now)


            DataGrid()



            Me.Show()


        Catch ex As Exception
            MsgBox(ex.Message & "   aqui")
        End Try


    End Sub
    Sub AsignarIdCompraDetalleATodasLasFilas()
        Dim idCompra As String = Id_CompraTextBox.Text
        For i As Integer = 0 To CompraMaterialesDetalleDataGridView.Rows.Count - 1
            Dim correlativo As Integer = i + 1
            Dim idDetalleCompra As String = idCompra & "-" & correlativo.ToString("D3")
            CompraMaterialesDetalleDataGridView.Rows(i).Cells("IdCompraDetalle").Value = idDetalleCompra
        Next
    End Sub

    Sub AñadirItm()
        Try
            ' === Recuperar valores del producto seleccionado ===
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

            ' === Obtener el siguiente Id_Detalle_compra único (formato Id_Compra-XXX) ===
            Dim nuevoIdDetalleCompra As String = ObtenerSiguienteIdDetalleCompra(idCompra)

            ' === Añadir fila nueva al BindingSource (NO a BD) ===
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

            ' === Campos opcionales ===
            If Not String.IsNullOrWhiteSpace(idPresupuesto) Then
                nuevaFila("Id_Presupuesto") = idPresupuesto
            End If
            If Not String.IsNullOrWhiteSpace(codigoUnico) Then
                nuevaFila("IdDetalle") = codigoUnico
            End If

            ' Puedes inicializar aquí los demás campos opcionales si tu DataSet lo requiere:
            nuevaFila("fecha") = Date.Now
            nuevaFila("TSubtotalRD") = 0D
            nuevaFila("TItbisRD") = 0D
            nuevaFila("TTotalRD") = 0D
            nuevaFila("TSubtotaUS") = 0D
            nuevaFila("TItbisUS") = 0D
            nuevaFila("TTotalus") = 0D
            'nuevaFila("TipodeGasto") = ""
            'nuevaFila("EmpresaGasto") = "IN"
            'nuevaFila("Descuento") = 0D
            'nuevaFila("DescuentoUS") = 0D
            'nuevaFila("DescuentoRD") = 0D
            'nuevaFila("DescuentoEU") = 0D

            CompraMaterialesDetalleBindingSource.EndEdit()

            ' Selecciona la última fila y cierra el formulario de productos
            If CompraMaterialesDetalleDataGridView.Rows.Count > 0 Then
                CompraMaterialesDetalleDataGridView.CurrentCell = CompraMaterialesDetalleDataGridView.Rows(CompraMaterialesDetalleDataGridView.Rows.Count - 1).Cells(0)
            End If
            My.Forms.FrmProductos.Close()

        Catch ex As Exception
            MsgBox("Error al añadir ítem: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub










    Sub Nuevodetallecompra()
        My.Forms.FrmProductos.Close()
        My.Forms.FrmProductos.ProveedoresTableAdapter.FillByIdProveedor(My.Forms.FrmProductos.DsProveedores.Proveedores, Id_ProveedorTextBox.Text)
        My.Forms.FrmProductos.ProveedoresProductoTableAdapter.FillByIdProveedor(My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto, Id_ProveedorTextBox.Text)
        My.Forms.FrmProductos.Paracompra()


    End Sub

    Sub DataGrid()
        ' Primero, mostrar todo (para no acumular residuos de visibilidad en memoria)
        With Me.CompraMaterialesDetalleDataGridView
            .Columns("Itebis").Visible = True
            .Columns("PrecioUS").Visible = True
            .Columns("ItebisUS").Visible = True
            .Columns("TotalUS").Visible = True
            .Columns("PrecioRD").Visible = True
            .Columns("ItebisRD").Visible = True
            .Columns("TotalRD").Visible = True
        End With
        SubTotalCompraUSTextBox.Visible = True
        ImpuestoCompraUSTextBox.Visible = True
        TotalCompraUSTextBox.Visible = True
        SubTotalCompraRDTextBox.Visible = True
        ImpuestoCompraRDTextBox.Visible = True
        TotalCompraRDTextBox.Visible = True

        ' Ahora, ocultar las columnas y totales que no corresponden
        Dim moneda As String = MonedaTextBox.Text.Trim().ToUpper()

        If moneda = "US$" Then
            Me.CompraMaterialesDetalleDataGridView.Columns("PrecioRD").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("ItebisRD").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("TotalRD").Visible = False

            SubTotalCompraRDTextBox.Visible = False
            ImpuestoCompraRDTextBox.Visible = False
            TotalCompraRDTextBox.Visible = False

            SubTotalCompraUSTextBox.Visible = True
            ImpuestoCompraUSTextBox.Visible = True
            TotalCompraUSTextBox.Visible = True

        ElseIf moneda = "RD$" Then
            Me.CompraMaterialesDetalleDataGridView.Columns("PrecioUS").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("ItebisUS").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("TotalUS").Visible = False

            SubTotalCompraUSTextBox.Visible = False
            ImpuestoCompraUSTextBox.Visible = False
            TotalCompraUSTextBox.Visible = False

            SubTotalCompraRDTextBox.Visible = True
            ImpuestoCompraRDTextBox.Visible = True
            TotalCompraRDTextBox.Visible = True

        Else
            ' Por si acaso detectas EUR u otro, puedes agregar lógica extra o dejar todo visible/oculto
            Me.CompraMaterialesDetalleDataGridView.Columns("PrecioUS").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("ItebisUS").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("TotalUS").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("PrecioRD").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("ItebisRD").Visible = False
            Me.CompraMaterialesDetalleDataGridView.Columns("TotalRD").Visible = False

            SubTotalCompraUSTextBox.Visible = False
            ImpuestoCompraUSTextBox.Visible = False
            TotalCompraUSTextBox.Visible = False
            SubTotalCompraRDTextBox.Visible = False
            ImpuestoCompraRDTextBox.Visible = False
            TotalCompraRDTextBox.Visible = False
        End If

        Me.CompraMaterialesDetalleDataGridView.Refresh()
    End Sub

    Sub ModificarCompra()

        Me.CompraMaterialesTableAdapter.FillByIdCompra(Me.DsCompras.CompraMateriales, Label1.Text)

        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, Label1.Text)
        Me.Show()


        DataGrid()







    End Sub

    Private Sub FrmIngresoCompras_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.FrmComprasProyecto.Totales()

        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

    Private Sub FrmIngresoCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Closing

        Me.CompraMaterialesTableAdapter.ActulizarFactura(Me.FacturaProveedorTextBox.Text, Me.ObservacionesTextBox.Text, Me.Id_CompraTextBox.Text)





    End Sub
    Private Sub CompraMaterialesDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellEndEdit
        ' --- Nombres exactos de las columnas según tu Designer ---
        Const COL_ITBIS As String = "Itebis"
        Const COL_CANTIDAD As String = "Cantidad"
        Const COL_PRECIOUS As String = "PrecioUS"
        Const COL_PRECIORD As String = "PrecioRD"
        Const COL_TOTALUS As String = "TotalUS"
        Const COL_TOTALRD As String = "TotalRD"
        Const COL_ITBISUS As String = "ItebisUS"
        Const COL_ITBISRD As String = "ItebisRD"

        Try
            ' --- Validación rápida de nombres de columnas en tiempo de desarrollo (puedes comentar esto después de probar) ---
            'Dim colNombres As String = ""
            'For Each col As DataGridViewColumn In CompraMaterialesDetalleDataGridView.Columns
            '    colNombres &= col.Index & ": " & col.Name & vbCrLf
            'Next
            'MsgBox("Nombres de columnas en DGV:" & vbCrLf & colNombres)

            Dim colName As String = CompraMaterialesDetalleDataGridView.Columns(e.ColumnIndex).Name

            ' Solo si la columna editada es relevante
            If colName = COL_ITBIS OrElse colName = COL_CANTIDAD OrElse colName = COL_PRECIOUS OrElse colName = COL_PRECIORD Then
                Dim row As DataGridViewRow = CompraMaterialesDetalleDataGridView.CurrentRow
                If row Is Nothing Then Exit Sub

                ' --- Recuperar valores ---
                Dim tasa As Double = 1
                Double.TryParse(Me.TasaTextBox.Text, tasa)

                Dim moneda As String = Me.MonedaTextBox.Text.Trim().ToUpper() ' <-- .ToUpper para evitar fallos por minúsculas
                Dim cantidad As Double, itbis As Double, precioUS As Double, precioRD As Double

                Double.TryParse(Convert.ToString(row.Cells(COL_CANTIDAD).Value), cantidad)
                Double.TryParse(Convert.ToString(row.Cells(COL_ITBIS).Value), itbis)
                Double.TryParse(Convert.ToString(row.Cells(COL_PRECIOUS).Value), precioUS)
                Double.TryParse(Convert.ToString(row.Cells(COL_PRECIORD).Value), precioRD)

                ' --- Validaciones ---
                If tasa <= 0 Then
                    MessageBox.Show("La tasa de cambio debe ser mayor que cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If


                ' --- Cálculos y asignaciones ---
                If moneda = "RD$" Then
                    row.Cells(COL_TOTALRD).Value = Math.Round(precioRD * cantidad, 4)
                    row.Cells(COL_PRECIOUS).Value = Math.Round(precioRD / tasa, 4)
                    row.Cells(COL_TOTALUS).Value = Math.Round((precioRD / tasa) * cantidad, 4)
                    row.Cells(COL_ITBISRD).Value = Math.Round(precioRD * cantidad * itbis, 4)
                    row.Cells(COL_ITBISUS).Value = Math.Round((precioRD / tasa) * cantidad * itbis, 4)

                ElseIf moneda = "US$" Then
                    row.Cells(COL_PRECIORD).Value = Math.Round(precioUS * tasa, 4)
                    row.Cells(COL_TOTALRD).Value = Math.Round(precioUS * tasa * cantidad, 4)
                    row.Cells(COL_TOTALUS).Value = Math.Round(precioUS * cantidad, 4)
                    row.Cells(COL_ITBISRD).Value = Math.Round(precioUS * tasa * cantidad * itbis, 4)
                    row.Cells(COL_ITBISUS).Value = Math.Round(precioUS * cantidad * itbis, 4)

                Else
                    MessageBox.Show("La moneda debe ser 'US$' o 'RD$'. Valor actual: " & moneda, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' --- Guardar cambios en la base de datos ---
                'Me.Validate()
                'Me.CompraMaterialesDetalleBindingSource.EndEdit()
                'Me.CompraMaterialesDetalleTableAdapter.Update(DsCompras)

                ' --- Actualizar totales generales ---
                Totales()
            End If

        Catch ex As Exception
            MessageBox.Show("Error en el cálculo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        My.Forms.ImpCompras.Close()

        My.Forms.ImpCompras.ImprimirCompra()
    End Sub

    Private Sub TasaTextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        Try



            Dim Moneda As String = Me.MonedaTextBox.Text

            Dim valor As Double = Me.TasaTextBox.Text
            Me.CompraMaterialesTableAdapter.ActulizarTasa(Me.TasaTextBox.Text, Me.Id_CompraTextBox.Text)
            If Moneda = "RD$" Then
                Me.CompraMaterialesDetalleTableAdapter.ActualizarTasaRD(valor, Me.Id_CompraTextBox.Text)
                Totales()
            ElseIf Moneda = "eur" Then
                Me.CompraMaterialesDetalleTableAdapter.ActualizarTasaEU(valor, Me.Id_CompraTextBox.Text)
                Totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevoArticulo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevoArticulo.Click

        Nuevodetallecompra()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.FrmPresopuestosAprobados.Close()

        My.Forms.FrmPresopuestosAprobados.Button2.Visible = False
        My.Forms.FrmPresopuestosAprobados.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ActulizarFechaFactura()
    End Sub

    Private Sub FacturaProveedorTextBox_TextChanged(sender As Object, e As EventArgs) Handles FacturaProveedorTextBox.TextChanged
        'Me.CompraMaterialesTableAdapter.ActulizarFactura(Me.FacturaProveedorTextBox.Text, Me.ObservacionesTextBox.Text, Me.Id_CompraTextBox.Text)
    End Sub

    Private Sub FrmIngresoCompras_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)

        Me.PorcientoImpuestoTextBox.Text = 0.18
        Me.SubTotalCompraRDTextBox.Text = 0
        Me.ImpuestoCompraRDTextBox.Text = 0
        Me.TotalCompraRDTextBox.Text = 0
        Me.SubTotalCompraUSTextBox.Text = 0
        Me.ImpuestoCompraUSTextBox.Text = 0
        Me.TotalCompraUSTextBox.Text = 0

    End Sub

    Private Sub ObservacionesTextBox_Leave(sender As Object, e As EventArgs) Handles ObservacionesTextBox.Leave
        Me.CompraMaterialesTableAdapter.Observaviones(Me.ObservacionesTextBox.Text, Me.Id_CompraTextBox.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Verificar si el contenido de TextBox1 es un número válido
        If Double.TryParse(TextBox1.Text, Nothing) AndAlso Double.TryParse(PorcientoImpuestoTextBox.Text, Nothing) Then
            ' Convertir los valores de texto a números
            Dim valorOriginal As Double = Convert.ToDouble(TextBox1.Text)
            Dim porcentajeImpuesto As Double = Convert.ToDouble(PorcientoImpuestoTextBox.Text)

            ' Calcular el nuevo valor después de aplicar el impuesto y redondear a dos decimales
            Dim nuevoValor As Double = Math.Round(valorOriginal / (1 + porcentajeImpuesto), 4)

            ' Mostrar el nuevo valor redondeado en TextBox2
            TextBox2.Text = nuevoValor.ToString()
        Else
            ' Mostrar un mensaje de error si los valores no son numéricos
            TextBox2.Text = "Error: Ingrese números válidos"
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Totales()
    End Sub

    Private Sub FacturaProveedorTextBox_Leave(sender As Object, e As EventArgs) Handles FacturaProveedorTextBox.Leave
        ' Llenar el DataTable con los resultados de la consulta
        'Me.CompraMaterialesTableAdapter.FillByCodigoVerificacion(Me.DsCompras.CompraMateriales, Me.FacturaProveedorTextBox.Text)

        ' Obtener el DataTable llenado por la consulta
        Dim dataTable As DataTable = Me.DsCompras.CompraMateriales

        ' Contar los registros en el DataTable
        Dim count As Integer = dataTable.Rows.Count

        ' Verificar la cantidad de registros
        If count = 1 Then
            ' Mostrar mensaje de NCF correcto
            'MessageBox.Show("NCF correcto.")
        ElseIf count > 1 Then
            ' Mostrar mensaje de comprobante existente
            MessageBox.Show("Este comprobante ya existe. Revise por favor.")
        Else
            ' Si no se encuentra ningún registro
            MessageBox.Show("No se encontraron registros para el NCF proporcionado.")
        End If
    End Sub
    'Sub AñadirItmModificar()


    '    Try
    '        Dim codigoUnico As String = My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto(My.Forms.FrmProductos.ProveedoresProductoBindingSource.Position).IdDetalle
    '        Dim idCompra As String = Id_CompraTextBox.Text
    '        Dim siguiente As String = Me.CompraMaterialesDetalleTableAdapter.SiguienteDetalleCompra(idCompra)
    '        Dim idmaterial As String = My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto(My.Forms.FrmProductos.ProveedoresProductoBindingSource.Position).IdProductoProveedor
    '        Dim idmedida As String = My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto(My.Forms.FrmProductos.ProveedoresProductoBindingSource.Position).Id_Medida
    '        Dim Descripcion As String = My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto(My.Forms.FrmProductos.ProveedoresProductoBindingSource.Position).DescripcionProveedor
    '        Dim Itbis As Double = PorcientoImpuestoTextBox.Text
    '        Me.CompraMaterialesDetalleTableAdapter.NuevaCompra(siguiente, idCompra, idmaterial, idmedida, MonedaTextBox.Text, TasaTextBox.Text, Descripcion, LblPresupuesto.Text, codigoUnico, Itbis)
    '        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, idCompra)

    '        Me.CompraMaterialesDetalleBindingSource.MoveLast()
    '        My.Forms.FrmProductos.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try


    'End Sub
    Function ObtenerSiguienteIdDetalleCompra(idCompra As String) As String
        Dim maxCorrelativo As Integer = 0
        For Each fila As DataGridViewRow In CompraMaterialesDetalleDataGridView.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("IdDetallecompra").Value IsNot Nothing Then
                Dim idDetalle As String = fila.Cells("IdDetallecompra").Value.ToString()
                If idDetalle.StartsWith(idCompra & "-") Then
                    Dim partes() = idDetalle.Split("-"c)
                    Dim correlativo As Integer
                    If partes.Length > 1 AndAlso Integer.TryParse(partes.Last, correlativo) Then
                        If correlativo > maxCorrelativo Then
                            maxCorrelativo = correlativo
                        End If
                    End If
                End If
            End If
        Next
        Return idCompra & "-" & (maxCorrelativo + 1).ToString("000")
    End Function
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim errores As Integer = 0

        Try
            GuardarCompra()
        Catch ex As Exception
            errores += 1
            MessageBox.Show("Error al guardar la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        errores += GuardarDetalle()

        If errores = 0 Then
            Dim respuesta = MessageBox.Show("Compra y detalles guardados correctamente." & vbCrLf &
                                        "¿Desea registrar el pago ahora?",
                                        "Guardar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                FrmPagarCompra.ShowDialog()
            End If
        End If
    End Sub

    Sub GuardarCompra()
        Try
            Me.CompraMaterialesTableAdapter.NuevaCompra(
                Id_CompraTextBox.Text,
                Id_ProveedorTextBox.Text,
                Id_EmpresaTextBox.Text,
                DateTimePicker1.Value,
                DateTimePicker1.Value.AddMonths(1),
                FacturaProveedorTextBox.Text,
                MonedaTextBox.Text,
                Convert.ToDecimal(TasaTextBox.Text),
                Convert.ToDecimal(SubTotalCompraUSTextBox.Text),
                Convert.ToDecimal(ImpuestoCompraUSTextBox.Text),
                Convert.ToDecimal(TotalCompraUSTextBox.Text),
                Convert.ToDecimal(SubTotalCompraRDTextBox.Text),
                Convert.ToDecimal(ImpuestoCompraRDTextBox.Text),
                Convert.ToDecimal(TotalCompraRDTextBox.Text),
                Convert.ToDecimal(PorcientoImpuestoTextBox.Text),
                LblPresupuesto.Text,
                LblProyecto.Text,
                0,  'PagadoUS
                Convert.ToDecimal(TotalCompraUSTextBox.Text), 'PendienteUS
                0,  'PagadoRD
                Convert.ToDecimal(TotalCompraRDTextBox.Text) 'PendienteRD
            )

        Catch ex As Exception
            MessageBox.Show("Error al guardar la compra: " & ex.Message)
        End Try

    End Sub
    Function GuardarDetalle() As Integer
        Dim errores As Integer = 0

        For Each row As DataGridViewRow In CompraMaterialesDetalleDataGridView.Rows
            If Not row.IsNewRow Then
                Try
                    Dim idDetalle As String = row.Cells("IdDetallecompra").Value?.ToString()
                    Dim Descripcion As String = row.Cells("DescripcionProveedor").Value?.ToString()
                    Dim IdDetalleProveedor As String = row.Cells("IdDetalleP").Value?.ToString()
                    Dim idCompra As String = Id_CompraTextBox.Text
                    Dim IdMaterial As String = row.Cells("Id_Material").Value?.ToString()
                    Dim IdMedida As Decimal = Val(row.Cells("Id_Medida").Value)
                    Dim Cantidad As Decimal = Val(row.Cells("Cantidad").Value)
                    Dim PrecioUS As Decimal = Val(row.Cells("PrecioUS").Value)
                    Dim ItebisUS As Decimal = Val(row.Cells("ItebisUS").Value)
                    Dim TotalUS As Decimal = Val(row.Cells("TotalUS").Value)
                    Dim Moneda As String = MonedaTextBox.Text
                    Dim Tasa As Decimal = Val(row.Cells("Tasa1").Value)
                    Dim PrecioRD As Decimal = Val(row.Cells("PrecioRD").Value)
                    Dim ItebisRD As Decimal = Val(row.Cells("ItebisRD").Value)
                    Dim TotalRD As Decimal = Val(row.Cells("TotalRD").Value)
                    Dim Itbis As Decimal = Val(PorcientoImpuestoTextBox.Text)
                    Dim IdPresupuesto As String = LblPresupuesto.Text

                    Me.CompraMaterialesDetalleTableAdapter.NuevaCompra(
                    idDetalle,
                    idCompra,
                    IdMaterial,
                    Cantidad,
                    PrecioUS,
                    TotalUS,
                    IdMedida,
                    PrecioRD,
                    TotalRD,
                    Moneda,
                    Tasa,
                    Descripcion,
                    IdPresupuesto,
                    IdDetalleProveedor,
                    ItebisUS,
                    ItebisRD,
                    Itbis
                )
                Catch ex As Exception
                    errores += 1
                    MessageBox.Show("Error al guardar una fila: " & ex.Message, "Error en detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next

        Return errores
    End Function

End Class