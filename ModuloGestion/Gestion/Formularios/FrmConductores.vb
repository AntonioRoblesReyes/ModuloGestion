Public Class FrmConductores

    Private Sub ConductoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ConductoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsConductores)

    End Sub


    Private Sub ConductoresBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ConductoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConductoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsConductores)

    End Sub

    Private Sub FrmConductores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsConductores.Conductores' Puede moverla o quitarla según sea necesario.
        Me.ConductoresTableAdapter.Fill(Me.DsConductores.Conductores)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.FrmNuevoConductor.Close()
        My.Forms.FrmNuevoConductor.Show()
    End Sub

    Private Sub ConductoresDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ConductoresDataGridView.CellEndEdit
        Me.Validate()
        Me.ConductoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsConductores)
    End Sub
End Class