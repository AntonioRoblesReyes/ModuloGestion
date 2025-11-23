Public Class FrmTipoHerraje

    Private Sub HerrajesFamiliaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles HerrajesFamiliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HerrajesFamiliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsHerrajesFamilia)

    End Sub

    Private Sub FrmTipoHerraje_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        My.Forms.FrmIngresoHerrajes.HerrajesFamiliaTableAdapter.Fill(My.Forms.FrmIngresoHerrajes.DsHerrajesFamilia.HerrajesFamilia)
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub FrmTipoHerraje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsHerrajesFamilia.HerrajesFamilia' Puede moverla o quitarla según sea necesario.
        Me.HerrajesFamiliaTableAdapter.Fill(Me.DsHerrajesFamilia.HerrajesFamilia)

    End Sub
End Class