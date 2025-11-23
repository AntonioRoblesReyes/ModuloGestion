Public Class FrmIntroducirEmpresa

    Private Sub CmdCAmcelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCAmcelar.Click
        Me.Close()
    End Sub

    Private Sub FrmIntroducirEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion
        Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)

    End Sub

    Private Sub CmsAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmsAceptar.Click
        My.Forms.FrmProyectos.Id_EmpresaTextBox.Text = Me.CmbEmpresa.Text

        Me.Close()
    End Sub



End Class