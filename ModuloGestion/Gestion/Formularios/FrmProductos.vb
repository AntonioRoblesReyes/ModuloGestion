Public Class FrmProductos

    Sub ParaNuevacompra()

        Me.ProveedoresBindingNavigator.Visible = False
        Me.Show()
      

    End Sub




    Sub Paracompra()

        Me.ProveedoresBindingNavigator.Visible = False
        Me.Show()


    End Sub
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProveedores)

    End Sub

    Private Sub FrmProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)


    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBuscar.TextChanged
        Me.ProveedoresProductoTableAdapter.FillByBuscar(Me.DsProveedoresProducto.ProveedoresProducto, "%" & TxtBuscar.Text & "%", Id_ProveedorTextBox.Text)
    End Sub

    Private Sub BtnNuevoArticulo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevoArticulo.Click
        My.Forms.FrmProvedoresProductos.Close()
        My.Forms.FrmProvedoresProductos.TxtIdUnico.Text = My.Forms.FrmProvedoresProductos.ProveedoresProductoTableAdapter.Siguiente(Id_ProveedorTextBox.Text)
        My.Forms.FrmProvedoresProductos.TxtIdProvedore.Text = Me.Id_ProveedorTextBox.Text
        My.Forms.FrmProvedoresProductos.TxtArticuloProvveedor.Text = Me.TxtBuscar.Text
        My.Forms.FrmProvedoresProductos.Show()
    End Sub

    Private Sub BtnAñadirAcompra_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadirAcompra.Click

        My.Forms.FrmIngresoCompras.AñadirItm()

    End Sub


End Class