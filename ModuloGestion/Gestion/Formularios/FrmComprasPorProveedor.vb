Public Class FrmComprasPorProveedor
    Public Sub Actulizar()

        Dim Proveedor As String = Me.DsComprasPorProyecto.ComprasPorProyecto(Me.ComprasPorProyectoBindingSource.Position).Id_Proveedor
        Me.ComprasProyectoDetalleTableAdapter.FillByIdProveedor(Me.DsComprasProyectoDetalle.ComprasProyectoDetalle, Label1.Text, Proveedor)
    End Sub

    Private Sub CompraMaterialesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub FrmComprasPorProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProveedores.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)


        Me.ComprasPorProyectoTableAdapter.Fill(Me.DsComprasPorProyecto.ComprasPorProyecto)
        Me.ComprasPorProyectoTableAdapter.FillByPorProyecto(Me.DsComprasPorProyecto.ComprasPorProyecto, Label1.Text)
        Me.ComprasProyectoDetalleTableAdapter.FillByIdProyecto(Me.DsComprasProyectoDetalle.ComprasProyectoDetalle, Label1.Text)
    End Sub




    Private Sub ComprasPorProyectoDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim Proveedor As String = Me.DsComprasPorProyecto.ComprasPorProyecto(Me.ComprasPorProyectoBindingSource.Position).Id_Proveedor
        Me.ComprasProyectoDetalleTableAdapter.FillByIdProveedor(Me.DsComprasProyectoDetalle.ComprasProyectoDetalle, Label1.Text, Proveedor)
    End Sub




End Class