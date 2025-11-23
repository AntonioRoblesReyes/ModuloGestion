Public Class FrmCargarProyecto

    Private Sub FrmCargarProyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProyectoPendienteAsignar.ProyectoPendienteAsignar' Puede moverla o quitarla según sea necesario.


        Dim empresa As String = My.Forms.FrmEmpresa.TxtIdEmpresa.Text
        Me.ProyectoPendienteAsignarTableAdapter.Fill(Me.DsProyectoPendienteAsignar.ProyectoPendienteAsignar)
        Me.ProyectoPendienteAsignarTableAdapter.FillByIdEmpresa(Me.DsProyectoPendienteAsignar.ProyectoPendienteAsignar, empresa)

    End Sub


    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Dim Proyecto As String = Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(0).Value
        Dim Descripcion As String = Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(1).Value
        Dim IdProyectoEmpresa As String = Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(2).Value
        Dim Empresa As String = Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(3).Value
        Dim Respuesta As Integer
        Respuesta = MsgBox("Va a cargar el proyecto " & Descripcion, MsgBoxStyle.YesNo, "Nuevo Proyecto a Empresa")
        If Respuesta = vbYes Then

            My.Forms.FrmEmpresa.ProyectosDetalleTableAdapter.AgregarProyecto(IdProyectoEmpresa, Proyecto, Empresa, Descripcion)
            My.Forms.FrmEmpresa.ProyectosDetalleTableAdapter.FillByEmpresa(My.Forms.FrmEmpresa.DsProyectosDetalle.ProyectosDetalle, Empresa)
            Me.Close()


        End If

    End Sub

    Private Sub ProyectoPendienteAsignarDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProyectoPendienteAsignarDataGridView.CellClick
        'MsgBox(Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(0).Value)
        'MsgBox(Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(1).Value)
        'MsgBox(Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(2).Value)
        'MsgBox(Me.ProyectoPendienteAsignarDataGridView.CurrentRow.Cells(3).Value)
    End Sub
End Class