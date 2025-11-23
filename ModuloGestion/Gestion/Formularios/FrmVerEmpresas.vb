Public Class FrmVerEmpresas
    Dim IdEmpresa As String
    Private Sub FrmEmpresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpresas.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)
        Me.MdiParent = My.Forms.FrmGestion
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        My.Forms.FrmEmpresa.Close()
        My.Forms.FrmEmpresa.Show()
        IdEmpresa = DsEmpresas.Empresas(EmpresasBindingSource.Position).Id_Empresa
        My.Forms.FrmEmpresa.EmpresasTableAdapter.FillByIdEmpresa(My.Forms.FrmEmpresa.DsEmpresas.Empresas, IdEmpresa)
        My.Forms.FrmEmpresa.EmpresasBindingNavigator.Visible = False
    End Sub

    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCerrar.Click
        My.Forms.FrmEmpresa.Close()
        My.Forms.FrmEmpresa.Show()
        IdEmpresa = DsEmpresas.Empresas(EmpresasBindingSource.Position).Id_Empresa
        My.Forms.FrmEmpresa.EmpresasTableAdapter.FillByIdEmpresa(My.Forms.FrmEmpresa.DsEmpresas.Empresas, IdEmpresa)
        My.Forms.FrmEmpresa.EmpresasBindingNavigator.Visible = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class