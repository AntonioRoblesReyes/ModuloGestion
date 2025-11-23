Public Class FrmEdificio
    Private Sub EdificiosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EdificiosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EdificiosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)

    End Sub

    Private Sub FrmEdificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelesDataSet.Edificios' Puede moverla o quitarla según sea necesario.
        Me.EdificiosTableAdapter.Fill(Me.HotelesDataSet.Edificios)

    End Sub
End Class