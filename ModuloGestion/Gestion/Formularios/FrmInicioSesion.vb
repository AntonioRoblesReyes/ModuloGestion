Option Strict On
Option Infer On
Imports System

Public Class FrmInicioSesion

    ' ======== Opciones de autorrelleno por equipo (inseguro; úsalo solo si realmente lo necesitas) ========
    Private Const AutoLoginHabilitado As Boolean = True   ' Ponlo en False para desactivar
    Private Const AutoLoginRellenaPassword As Boolean = True ' True: también llena la contraseña (no recomendado)
    Private ReadOnly EquiposPermitidos As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
        "PCShernia",
        "TABLET"
    }

    ' ======== Helpers ========
    Private Sub ActualizarBotonOK()
        Me.OK.Enabled = (txtusuario.TextLength > 0 AndAlso txtcontrasena.TextLength > 0)
    End Sub

    Private Sub Pc()
        If Not AutoLoginHabilitado Then Exit Sub

        Dim nombrePc As String = My.Computer.Name
        If EquiposPermitidos.Contains(nombrePc) Then
            Me.txtusuario.Text = "ANTONIO"
            If AutoLoginRellenaPassword Then
                Me.txtcontrasena.Text = "2007"
            Else
                Me.txtcontrasena.Clear()
            End If
        Else
            Me.txtusuario.Clear()
            Me.txtcontrasena.Clear()
        End If

        ActualizarBotonOK()
    End Sub

    ' ======== Eventos del formulario ========
    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pc()
        ActualizarBotonOK()
    End Sub

    Private Sub FrmInicioSesion_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Evitar la llamada duplicada
        CerrarGrill(Me)
    End Sub

    ' ======== Botones ========
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        Try
            Dim usuario As String = txtusuario.Text.Trim()
            Dim contrasena As String = txtcontrasena.Text ' Nota: idealmente validar hash en BD

            ' Solo usamos el Fill filtrado para validar credenciales
            Me.UsuariosTableAdapter.FillByAccceso(Me.DsUsuarios.Usuarios, usuario, contrasena)

            Dim dt = Me.DsUsuarios.Usuarios
            If dt IsNot Nothing AndAlso dt.Count > 0 Then
                ' Guardar usuario actual (variable global existente en tu solución)
                UsuarioActual = usuario

                ' Obtener la fila autenticada
                Dim row = If(Me.UsuariosBindingSource IsNot Nothing AndAlso Me.UsuariosBindingSource.Position >= 0 AndAlso
                             Me.UsuariosBindingSource.Position < dt.Count,
                             dt(Me.UsuariosBindingSource.Position),
                             dt(0))

                ' Copiar datos básicos a los formularios destino
                My.Forms.FrmGestion.Label1.Text = row.CategoriaUsario.ToString()
                My.Forms.FrmGestion.Label2.Text = row.Id_Usuario.ToString()

                ' Determinar categoría como entero
                Dim categoria As Integer
                If Not Integer.TryParse(row.CategoriaUsario.ToString(), categoria) Then
                    categoria = 0
                End If

                ' Enrutar según categoría
                Select Case categoria
                    Case 1, 2, 3
                        FrmGestion.Show()
                    Case 4
                        FrmContabilidad.Show()
                    Case Else
                        ' Valor no esperado: por defecto enviamos a Gestión
                        FrmGestion.Show()
                End Select

                Me.Hide()
            Else
                MsgBox("Usuario / Contraseña incorrecta. Intenta de nuevo.", MsgBoxStyle.Information, "Acceso denegado")
                txtusuario.Clear()
                txtcontrasena.Clear()
                txtusuario.Focus()
                ActualizarBotonOK()
            End If

        Catch ex As Exception
            ' Puedes especializar (SqlException, InvalidOperationException, etc.) si lo necesitas
            MsgBox("Ocurrió un problema al validar las credenciales." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "Error")
            txtcontrasena.Clear()
            txtcontrasena.Focus()
            ActualizarBotonOK()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    ' ======== BindingNavigator (guardar cambios en la tabla de usuarios) ========
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsUsuarios)
    End Sub

    ' ======== Interacción de UI ========
    Private Sub Txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        ActualizarBotonOK()
    End Sub

    Private Sub Txtcontrasena_TextChanged(sender As Object, e As EventArgs) Handles txtcontrasena.TextChanged
        ActualizarBotonOK()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        Pc()
    End Sub

End Class
