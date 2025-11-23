Public Class FrmVerProyectos

    Private Sub ProyectosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProyectosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProyectos)

    End Sub

    Private Sub FrmVerProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProyectos.ProyectoActivos' Puede moverla o quitarla según sea necesario.
        Me.ProyectoActivosTableAdapter.Fill(Me.DsProyectos.ProyectoActivos)
        'TODO: esta línea de código carga datos en la tabla 'DsClientes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.MdiParent = My.Forms.FrmGestion
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        Me.TxtBuscar.Select()

    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        Try
            Me.ProyectosTableAdapter.FillByRazonSocial(Me.DsProyectos.Proyectos, "%" & TxtBuscar.Text & "%")
        Catch ex As Exception

        End Try


    End Sub






    Private Sub CmdNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub BtnIrProyecto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            MsgBox("presionó enter", MsgBoxStyle.Information)
            My.Forms.FrmProyectos.Close()
            My.Forms.FrmProyectos.Show()
            Dim IdProyecto As String
            IdProyecto = Me.DsProyectos.Proyectos(ProyectosBindingSource.Position).Id_Proyecto
            My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, IdProyecto)
            My.Forms.FrmProyectos.ProyectosBindingNavigator.Visible = False
            My.Forms.FrmProyectos.TotalesProyecto()
            Close()

        End If



    End Sub

    Private Sub ProyectosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProyectosDataGridView.CellClick
        If e.ColumnIndex = 4 Then

            My.Forms.FrmProyectos.Close()

            Dim IdProyecto As String = DsProyectos.Proyectos(ProyectosBindingSource.Position).Id_Proyecto

            My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, IdProyecto)

            My.Forms.FrmProyectos.ProyectosBindingNavigator.Visible = False
            My.Forms.FrmProyectos.GroupBox1.Text = UCase("Presupuestos de la empresa ")
            'My.Forms.FrmProyectos.CmbBuscarEmpresa.Text = TxtRazonSocial.Text
            My.Forms.FrmProyectos.PresupuestoTableAdapter.FillByEmpresa(My.Forms.FrmProyectos.DsPresupuestos.Presupuesto, My.Forms.FrmProyectos.TxtIdProyecto.Text, My.Forms.FrmProyectos.Id_EmpresaTextBox.Text)
            My.Forms.FrmProyectos.Show()
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProyectosTableAdapter.ProyectosActivos()
    End Sub
End Class