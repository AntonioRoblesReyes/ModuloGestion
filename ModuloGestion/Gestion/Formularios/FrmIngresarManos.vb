Public Class FrmIngresarManos

    Private Sub PresupuestoDetalleBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestoDetalleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

    End Sub

    Private Sub FrmIngresarManos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsArticulos.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetalle.PresupuestoDetalle' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)
    End Sub
End Class