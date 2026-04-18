Public Class FrmProductos

    '=========================================================
    ' Propiedades públicas para devolver el producto seleccionado
    '=========================================================

    Public Property IdProductoSeleccionado As String
    Public Property DescripcionSeleccionada As String
    Public Property PrecioSeleccionado As Decimal
    Public Property IdMedidaSeleccionada As String
    Public Property IdDetalleSeleccionado As String

    '=========================================================
    ' Inicialización del formulario
    '=========================================================
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.ProveedoresBindingNavigator.Visible = False

            Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)

            ' Si ya viene un proveedor cargado, refrescar sus productos
            If Not String.IsNullOrWhiteSpace(Id_ProveedorTextBox.Text) Then

                Me.ProveedoresTableAdapter.FillByIdProveedor(
                    Me.DsProveedores.Proveedores,
                    Id_ProveedorTextBox.Text)

                Me.ProveedoresProductoTableAdapter.FillByIdProveedor(
                    Me.DsProveedoresProducto.ProveedoresProducto,
                    Id_ProveedorTextBox.Text)

            End If

        Catch ex As Exception

            MessageBox.Show("Error cargando productos: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    '=========================================================
    ' Buscar artículos del proveedor actual
    '=========================================================
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        Try

            If String.IsNullOrWhiteSpace(Id_ProveedorTextBox.Text) Then Exit Sub

            Me.ProveedoresProductoTableAdapter.FillByBuscar(
                Me.DsProveedoresProducto.ProveedoresProducto,
                "%" & TxtBuscar.Text.Trim() & "%",
                Id_ProveedorTextBox.Text)

        Catch ex As Exception

            MessageBox.Show("Error buscando artículos: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    '=========================================================
    ' Crear nuevo artículo para el proveedor
    '=========================================================
    Private Sub BtnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles BtnNuevoArticulo.Click

        Try

            Dim frm As FrmProvedoresProductos = My.Forms.FrmProvedoresProductos

            If frm.Visible Then frm.Close()

            frm.TxtIdUnico.Text =
                frm.ProveedoresProductoTableAdapter.Siguiente(
                    Me.Id_ProveedorTextBox.Text)

            frm.TxtIdProvedore.Text = Me.Id_ProveedorTextBox.Text
            frm.TxtArticuloProvveedor.Text = Me.TxtBuscar.Text.Trim()

            frm.ShowDialog()

            ' Recargar productos después de guardar uno nuevo
            Me.ProveedoresProductoTableAdapter.FillByIdProveedor(
                Me.DsProveedoresProducto.ProveedoresProducto,
                Me.Id_ProveedorTextBox.Text)

            ' Volver a filtrar si el usuario había escrito algo
            If TxtBuscar.Text.Trim() <> "" Then
                Me.ProveedoresProductoTableAdapter.FillByBuscar(
                    Me.DsProveedoresProducto.ProveedoresProducto,
                    "%" & TxtBuscar.Text.Trim() & "%",
                    Me.Id_ProveedorTextBox.Text)
            End If

        Catch ex As Exception

            MessageBox.Show("Error al crear el artículo: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    '=========================================================
    ' Seleccionar producto y devolverlo al formulario de compra
    '=========================================================
    '=========================================================
    ' FrmProductos.vb
    ' Reemplazar completo BtnAñadirAcompra_Click
    '=========================================================
    Private Sub BtnAñadirAcompra_Click(sender As Object, e As EventArgs) Handles BtnAñadirAcompra.Click

        Try

            If Me.ProveedoresProductoBindingSource.Current Is Nothing Then
                MessageBox.Show("Debe seleccionar un artículo.",
                            "Seleccionar artículo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim fila As DataRowView =
            CType(Me.ProveedoresProductoBindingSource.Current, DataRowView)

            IdProductoSeleccionado = fila("IdProductoProveedor").ToString()
            DescripcionSeleccionada = fila("DescripcionProveedor").ToString()

            If fila.Row.Table.Columns.Contains("Id_Medida") AndAlso
           Not IsDBNull(fila("Id_Medida")) Then
                IdMedidaSeleccionada = fila("Id_Medida").ToString()
            Else
                IdMedidaSeleccionada = ""
            End If

            If fila.Row.Table.Columns.Contains("IdDetalle") AndAlso
           Not IsDBNull(fila("IdDetalle")) Then
                IdDetalleSeleccionado = fila("IdDetalle").ToString()
            Else
                IdDetalleSeleccionado = ""
            End If

            If fila.Row.Table.Columns.Contains("Precio") AndAlso
           Not IsDBNull(fila("Precio")) Then
                PrecioSeleccionado = Convert.ToDecimal(fila("Precio"))
            ElseIf fila.Row.Table.Columns.Contains("PrecioCompra") AndAlso
               Not IsDBNull(fila("PrecioCompra")) Then
                PrecioSeleccionado = Convert.ToDecimal(fila("PrecioCompra"))
            Else
                PrecioSeleccionado = 0D
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Error al seleccionar el artículo: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub
    '=========================================================
    ' Doble clic en el grid = seleccionar artículo
    '=========================================================
    Private Sub ProveedoresProductoDataGridView_CellDoubleClick(
        sender As Object,
        e As DataGridViewCellEventArgs) _
        Handles ProveedoresProductoDataGridView.CellDoubleClick

        If e.RowIndex >= 0 Then
            BtnAñadirAcompra.PerformClick()
        End If

    End Sub

    '=========================================================
    ' Enter en el buscador selecciona si solo hay un resultado
    '=========================================================
    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Me.ProveedoresProductoBindingSource.Count = 1 Then
                BtnAñadirAcompra.PerformClick()
            ElseIf Me.ProveedoresProductoBindingSource.Count > 1 Then
                ProveedoresProductoDataGridView.Focus()
            End If

            e.SuppressKeyPress = True

        End If

    End Sub

    '=========================================================
    ' Escape cierra el formulario
    '=========================================================
    Private Sub FrmProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

    End Sub

End Class