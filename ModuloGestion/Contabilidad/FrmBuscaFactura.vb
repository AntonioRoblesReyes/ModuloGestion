Public Class FrmBuscaFactura

    Private Sub FacturaProveedorBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturaProveedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsContabilidad)

    End Sub

    Private Sub FrmBuscaFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load





        'TODO: esta línea de código carga datos en la tabla 'DsProveedores.Proveedores' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.FacturaProveedor' Puede moverla o quitarla según sea necesario.
        Me.FacturaProveedorTableAdapter.Fill(Me.DsContabilidad.FacturaProveedor)
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
    End Sub
End Class