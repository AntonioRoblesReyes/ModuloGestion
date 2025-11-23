Public Class FrmProveedoresListado
    Sub NuevaFactura()
        Try


            BtnVerProveedor.Visible = True
            Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)

            Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
            Me.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Nuevacompra()
        Try


            BtnVerProveedor.Visible = True
            Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)

            Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
            Me.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Listado()
        Me.BtnAceptarProveedor.Visible = False

        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Me.CompraMaterialesTableAdapter.Totales()
        Me.Show()
    End Sub
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProveedores)

    End Sub

    Private Sub FrmProveedoresListado_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub FrmProveedoresListado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)

    End Sub

    Sub BtnVerProveedor_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerProveedor.Click

        My.Forms.FrmProveedores.LblIdProveedor.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).Id_Proveedor
        My.Forms.FrmProveedores.VerProveedor()
    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        My.Forms.FrmProveedores.Nuevo()
    End Sub

    Private Sub BtnAceptarProveedor_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptarProveedor.Click
        Try
            My.Forms.FrmIngresoCompras.LblProveedor.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).Id_Proveedor

            'My.Forms.FrmIngresoCompras.PorcientoImpuestoTextBox.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).Itebis
            My.Forms.FrmIngresoCompras.Id_EmpresaTextBox.Text = "IN"

            My.Forms.FrmIngresoCompras.Id_ProveedorTextBox.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).Id_Proveedor

            My.Forms.FrmIngresoCompras.PorcientoImpuestoTextBox.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).Itebis1
            'My.Forms.FrmIngresoCompras.LblProveedor.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).RazonSocial

            My.Forms.FrmIngresoCompras.MonedaTextBox.Text = Me.DsProveedores.Proveedores(Me.ProveedoresBindingSource.Position).Moneda
            My.Forms.FrmIngresoCompras.LblPresupuesto.Text = LblPresupuesto.Text
            My.Forms.FrmIngresoCompras.LblProyecto.Text = LblProyecto.Text
            My.Forms.FrmIngresoCompras.NuevaCompra()


            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub TxtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBuscar.TextChanged
        Me.ProveedoresTableAdapter.FillByBuscar(Me.DsProveedores.Proveedores, "%" & TxtBuscar.Text & "%")
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem1_Click(sender As System.Object, e As System.EventArgs) Handles ProveedoresBindingNavigatorSaveItem1.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProveedores)

    End Sub

    Private Sub ProveedoresDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellEndEdit
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProveedores)
    End Sub

    Private Sub ProveedoresDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellClick

    End Sub
End Class