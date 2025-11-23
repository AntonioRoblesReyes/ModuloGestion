Public Class FrmMaterialesCompra

    Private Sub FrmMaterialesCompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsUnionMaterialesNombre.UnionNombreMateriales' Puede moverla o quitarla según sea necesario.
        Me.UnionNombreMaterialesTableAdapter.Fill(Me.DsUnionMaterialesNombre.UnionNombreMateriales)

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBuscar.TextChanged
        Try


            Me.UnionNombreMaterialesTableAdapter.FillByBuscar(Me.DsUnionMaterialesNombre.UnionNombreMateriales, "%" & TxtBuscar.Text & "%")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadir.Click
        Dim Idmaterial As String = Me.DsUnionMaterialesNombre.UnionNombreMateriales(Me.UnionNombreMaterialesBindingSource.Position).Id_Material_Detalle

        'My.Forms.FrmIngresoCompras.idDetalleCompra()

        'My.Forms.FrmIngresoCompras.CompraMaterialesDetalleDataGridView.CurrentRow.Cells(1).Value = Idmaterial
        'My.Forms.FrmIngresoCompras.CompraMaterialesDetalleDataGridView.CurrentRow.Cells(2).Value = 1
        'My.Forms.FrmIngresoCompras.CompraMaterialesDetalleDataGridView.CurrentRow.Cells(3).Value = My.Forms.FrmIngresoCompras.PorcientoImpuestoTextBox.Text
        Me.Close()
    End Sub

End Class