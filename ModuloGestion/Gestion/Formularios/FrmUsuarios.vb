Public Class FrmUsuarios
    Public Sub CambioContrasena()
        Dim idUsuario As String = My.Forms.FrmGestion.Label2.Text
        Me.UsuariosBindingNavigator.Visible = False
        Me.UsuariosTableAdapter.FillByIdUsuario(Me.DsUsuarios.Usuarios, idUsuario)
        Me.Id_UsuarioTextBox.Enabled = False
        Me.CategoriaUsarioTextBox.Enabled = False
        Me.NombreUsuaarioTextBox.Enabled = False
        Me.ComboBox1.Enabled = False
    End Sub
    Public Sub Mantenimientousuarios()



    End Sub
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsUsuarios)

    End Sub

    Private Sub FrmUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCategoriasUsuarios.CategoriaUsuarios' Puede moverla o quitarla según sea necesario.
        Me.CategoriaUsuariosTableAdapter.Fill(Me.DsCategoriasUsuarios.CategoriaUsuarios)
        'TODO: esta línea de código carga datos en la tabla 'DsUsuarios.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DsUsuarios.Usuarios)
        Me.Label2.Visible = False
        CategoriaUsarioTextBox.Visible = False
    End Sub

    Private Sub Btnacaptar_Click(sender As System.Object, e As System.EventArgs) Handles btnacaptar.Click
        Try


            If Me.ConrasenaTextBox.Text = Me.txtverificar.Text Then
                Me.Validate()
                Me.UsuariosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsUsuarios)
                MsgBox("Cambio contraseña correcto")
                Me.Close()
            Else
                MsgBox("las contraseña no coinciden")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub




    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Me.Label2.Text = Me.ComboBox1.SelectedValue
    End Sub
End Class