Public Class FrmConsultaPrecios




    Private Sub FrmConsultaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMateriales' Puede moverla o quitarla según sea necesario.
        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        'TODO: esta línea de código carga datos en la tabla 'DsProveedores.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

        Me.CompraMaterialesDetalleTableAdapter.Fill(Me.DsCompras.CompraMaterialesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsFacturaProveedor.FacturaProveedor' Puede moverla o quitarla según sea necesario.
        Me.CompraMaterialesDetalleTableAdapter.ActulizarFecha()
    End Sub

    Private Sub CompraMaterialesDetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellClick
        If e.ColumnIndex <> 10 Then
            Dim Compra As String = Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).Id_Compra
            Me.CompraMaterialesTableAdapter.FillByIdCompra(Me.DsCompras.CompraMateriales, Compra)

            Dim Proveedor As String = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Proveedor
            Me.ProveedoresTableAdapter.FillByIdProveedor(Me.DsProveedores.Proveedores, Proveedor)
            Me.Label2.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).RazonSocial
        ElseIf e.ColumnIndex = 10 Then

            Dim Compra As String = Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).Id_Compra
            Me.CompraMaterialesTableAdapter.FillByIdCompra(Me.DsCompras.CompraMateriales, Compra)

            Dim Proveedor As String = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Proveedor
            Me.ProveedoresTableAdapter.FillByIdProveedor(Me.DsProveedores.Proveedores, Proveedor)
            Me.Label2.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).RazonSocial


            My.Forms.FrmIngresoCompras.Close()
            My.Forms.FrmIngresoCompras.Label1.Text = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Compra
            My.Forms.FrmIngresoCompras.LblPresupuesto.Text = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Presupuesto
            My.Forms.FrmIngresoCompras.LblProyecto.Text = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_proyecto_Presupuestos


        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try


            Me.CompraMaterialesDetalleTableAdapter.FillByBuscar(Me.DsCompras.CompraMaterialesDetalle, "%" & TextBox1.Text & "%")

        Catch ex As Exception

        End Try
    End Sub
End Class