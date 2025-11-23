Public Class FrmPagarMontaje

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            Me.PagoMontajeTableAdapter.Pagar(Me.TextBox1.Text, Me.TextBox2.Text, Label3.Text)
            My.Forms.FrmPagosMomtajeResumen.PagoMontajeTableAdapter.Fill(My.Forms.FrmPagosMomtajeResumen.DsPagosMontaje.PagoMontaje)
        End If
    End Sub

    Private Sub PagoMontajeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PagoMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmPagarMontaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontaje' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)

    End Sub
End Class