Public Class FrmPintura


    Private Sub PinturaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PinturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PinturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPintura)

    End Sub

    Private Sub FrmPintura_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)

    End Sub

    Private Sub FrmPintura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DsPintura.Pintura' Puede moverla o quitarla según sea necesario.
        Me.PinturaTableAdapter.Fill(Me.DsPintura.Pintura)

    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        Dim Siguiente As String = Me.PinturaTableAdapter.Siguiente
        Me.PinturaTableAdapter.NuevaPintura(Siguiente)
        Me.PinturaTableAdapter.Fill(Me.DsPintura.Pintura)
    End Sub

    Private Sub PinturaDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaDataGridView.CellEndEdit
        Me.Validate()
        Me.PinturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPintura)
    End Sub

    Private Sub PinturaDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PinturaDataGridView.RowsRemoved
        Me.Validate()
        Me.PinturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPintura)
    End Sub

    Private Sub BtnAnadirAplicacion_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnadirAplicacion.Click

        My.Forms.FrmPinturaAplicacoon.siguientePinturadetalles()

    End Sub

End Class