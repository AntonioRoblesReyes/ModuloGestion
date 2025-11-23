Public Class FrmCambioProyecto
    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)

    End Sub

    Private Sub FrmCambioProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try


            Me.PresupuestoTableAdapter.CambioProyecto(Me.Id_proyecto_PresupuestosTextBox.Text, Me.Id_FiscalTextBox.Text, Me.Id_PresupuestoTextBox.Text)
            My.Forms.FrmPresupuestos.Close()
            My.Forms.FrmPresupuestos.Label10.Text = Me.Id_PresupuestoTextBox.Text
            My.Forms.FrmPresupuestos.PorPresupuesto()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class