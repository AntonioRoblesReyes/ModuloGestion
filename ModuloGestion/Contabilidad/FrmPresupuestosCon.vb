Public Class FrmPresupuestosCon
    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PresupuestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)

    End Sub

    Private Sub FrmPresupuestosCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)

    End Sub
End Class