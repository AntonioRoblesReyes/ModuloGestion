Public Class FrmPagoMontaje
    Sub ModificarPago()
        Me.PagoMontajeTableAdapter.FillByIdPago(DsPagosMontaje.PagoMontaje, IdPagoMontajeTextBox.Text)
        Me.Button1.Visible = False
        Me.Show()

    End Sub
    Private Sub PagoMontajeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PagoMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)


    End Sub
    Sub NuevoPago()
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.Button2.Visible = False
        Me.Show()
    End Sub
    Private Sub FrmPagoMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub EmpresasContratadasMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasContratadasMontajeDataGridView.CellClick
        Me.IdEmpresaMontajeTextBox.Text = Me.DsPagosMontaje.EmpresasContratadasMontaje(Me.EmpresasContratadasMontajeBindingSource.Position).IdEmpresaMontaje
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.PagoMontajeTableAdapter.Eliminar(IdPagoMontajeTextBox.Text)
            Me.PagoMontajeTableAdapter.NuevoPago(IdPagoMontajeTextBox.Text, IdEmpresaMontajeTextBox.Text, FechaDateTimePicker.Value, ValorTextBox.Text, 0, ValorTextBox.Text, "IN", FormaDePagoTextBox.Text, ObservacionesTextBox.Text, MonedaTextBox.Text)
            My.Forms.FrmPagosMomtajeResumen.PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ValorTextBox_MouseLeave(sender As Object, e As EventArgs) Handles ValorTextBox.MouseLeave
        Me.ValorTextBox.Text = Format(Val(Me.ValorTextBox.Text), "#,##0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Asignado As Double = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).Asignado
        Dim PendienteAsignar As Double = ValorTextBox.Text - Asignado
        Me.PagoMontajeTableAdapter.Actualizar(IdEmpresaMontajeTextBox.Text, FechaDateTimePicker.Value, ValorTextBox.Text, Asignado, PendienteAsignar, IdEmpresaMontajeTextBox.Text, FormaDePagoTextBox.Text, ObservacionesTextBox.Text, MonedaTextBox.Text, IdPagoMontajeTextBox.Text)
        My.Forms.FrmPagosMomtajeResumen.PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)
        Me.Close()

    End Sub
End Class