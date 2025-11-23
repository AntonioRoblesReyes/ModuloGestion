Public Class FrmMntajeYDescuento



    Private Sub FrmMntajeYDescuento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetalle.PresupuestoDetalle' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)






    End Sub

    Private Sub PresupuestoDetalleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

    End Sub

    Private Sub PorcientoMontajeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)
    End Sub


    Private Sub PresupuestoDetalleBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoDetalleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

    End Sub

    'Private Sub CmdAceptarCambios_Click(sender As System.Object, e As System.EventArgs) Handles CmdAceptarCambios.Click
    '    Me.Validate()
    '    Me.PresupuestoDetalleBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

    '    My.Forms.FrmPresupuestos.Validate()
    '    My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.EndEdit()
    '    My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.Update(Me.DsPresupuestoDetalle)

    '    PresupuestoDetalleTableAdapter.FillByIdPresupuesto(DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
    '    My.Forms.FrmPresupuestos.Totales()

    'End Sub
End Class