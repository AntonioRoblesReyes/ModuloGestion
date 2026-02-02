Public Class FrmProveedores

    ' --- MÉTODOS PRINCIPALES ---

    Sub Mantenimiento()
        Try
            ProveedoresTableAdapter.Fill(DsProveedores.Proveedores)
            ComprasPorMesTableAdapter.Fill(DsCompras.ComprasPorMes)
            Show()
            FiltrarCuenta()
        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    Sub Totales()
        Dim Subtotal, Itebis, Total, SubRd, ItbisRd, TotalRD As Double

        For Each row As DataGridViewRow In CompraMaterialesDataGridView.Rows
            If Not row.IsNewRow Then
                Subtotal += Val(row.Cells(5).Value)
                Itebis += Val(row.Cells(6).Value)
                Total += Val(row.Cells(7).Value)
                SubRd += Val(row.Cells(9).Value)
                ItbisRd += Val(row.Cells(10).Value)
                TotalRD += Val(row.Cells(11).Value)
            End If
        Next

        LblSubtotal.Text = Format(Subtotal, "##,##0.00")
        LblItebis.Text = Format(Itebis, "##,##0.00")
        LblTotal.Text = Format(Total, "##,##0.00")
        Me.SubRd.Text = Format(SubRd, "##,##0.00")
        Me.ItbisRd.Text = Format(ItbisRd, "##,##0.00")
        Me.TotalRD.Text = Format(TotalRD, "##,##0.00")

    End Sub

    Sub FiltrarCuenta()
        Try

            CompraMaterialesTableAdapter.FillByIdProveedor(DsCompras.CompraMateriales, Id_ProveedorTextBox.Text)
            Totales()
        Catch ex As Exception
            MsgBox("Error al filtrar cuenta: " & ex.Message)
        End Try
    End Sub

    Sub VerProveedorContabilidad()
        MdiParent = My.Forms.FrmContabilidad
        ProveedoresTableAdapter.Fill(DsProveedores.Proveedores)
        Show()
        FiltrarCuenta()
    End Sub

    Sub Nuevo()
        ProveedoresBindingSource.AddNew()
        ProveedoresBindingNavigator.Visible = False
        PaisTextBox.Text = "REPUBLICA DOMINICANA"
        Show()
    End Sub

    Sub VerProveedor()
        Show()
        ProveedoresTableAdapter.FillByIdProveedor(DsProveedores.Proveedores, LblIdProveedor.Text)
        Button1.Visible = Not ValorFiscalCheckBox.Checked
        FiltrarCuenta()
    End Sub

    ' --- EVENTOS PRINCIPALES ---

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización si es necesaria
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Validate()
            ProveedoresBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsProveedores)
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        Validate()
        ProveedoresBindingSource.EndEdit()
        ProveedoresTableAdapter.Update(DsProveedores)
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem1.Click
        Validate()
        ProveedoresBindingSource.EndEdit()
        ProveedoresTableAdapter.Update(DsProveedores)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            Dim Pregunta As Integer = MsgBox("Vas a eliminar al proveedor " & RazonSocialTextBox.Text, MsgBoxStyle.YesNo + vbExclamation + vbDefaultButton2, "Eliminar Proveedor")
            If Pregunta = vbYes Then
                ProveedoresTableAdapter.Eliminar(Id_ProveedorTextBox.Text)
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar proveedor: " & ex.Message)
        End Try
    End Sub


    Private Sub ProveedoresBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigator.RefreshItems
        FiltrarCuenta()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With My.Forms.FrmProductos
            .Close()
            .ProveedoresTableAdapter.FillByIdProveedor(.DsProveedores.Proveedores, Id_ProveedorTextBox.Text)
            .ProveedoresProductoTableAdapter.FillByIdProveedor(.DsProveedoresProducto.ProveedoresProducto, Id_ProveedorTextBox.Text)
            '.Paracompra()
        End With
    End Sub

    Private Sub CompraMaterialesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDataGridView.CellClick
        Dim Compra As String = DsCompras.CompraMateriales(CompraMaterialesBindingSource.Position).Id_Compra
        CompraMaterialesDetalleTableAdapter.FillByIdCompra(DsCompras.CompraMaterialesDetalle, Compra)
    End Sub



    Private Sub Id_ProveedorTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_ProveedorTextBox.TextChanged
        ComprasPorMesTableAdapter.FillByIdPoveedor(DsCompras.ComprasPorMes, Id_ProveedorTextBox.Text)
    End Sub

    Private Sub CompraMaterialesDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellEndEdit
        Validate()
        CompraMaterialesDetalleBindingSource.EndEdit()
        CompraMaterialesDetalleTableAdapter.Update(DsCompras)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ValorFiscalCheckBox.Checked Then
            Dim IdProveedor As String = Id_ProveedorTextBox.Text
            CompraMaterialesTableAdapter.FillByIdProveedor(DsCompras.CompraMateriales, IdProveedor)

            For i As Integer = 0 To CompraMaterialesDataGridView.RowCount - 1
                Dim valorActual As Object = CompraMaterialesDataGridView.Rows(i).Cells(1).Value
                Dim IdFactura As Object = CompraMaterialesDataGridView.Rows(i).Cells(0).Value
                Dim codigoGenerado As String = (10000 + (CompraMaterialesDataGridView.RowCount - i)).ToString().Substring(1)
                Dim codigoCompleto As String = IdProveedor & "-" & codigoGenerado

                CompraMaterialesDataGridView.Rows(i).Cells(1).Value = codigoCompleto
                CompraMaterialesTableAdapter.ActualizarIdFactura(codigoCompleto, IdFactura)
                CompraMaterialesBindingSource.MoveNext()
            Next
        Else
            MsgBox("Los comprobantes no se pueden autogenerar con este proveedor")
        End If
    End Sub

End Class
