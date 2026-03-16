Option Strict On
Option Infer On

Imports System
Imports System.Windows.Forms

' Nota: prototipo para ModuloGestion.Next (no integrado al proyecto legado)
Public Class FrmLoginNext

    Private ReadOnly _authService As IAuthAppService

    Public Sub New(authService As IAuthAppService)
        InitializeComponent()
        _authService = authService
    End Sub

    Private Sub FrmLoginNext_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarEstadoBoton()
        TxtUsuario.Focus()
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Try
            Dim request As New LoginRequest With {
                .Usuario = TxtUsuario.Text.Trim(),
                .Clave = TxtClave.Text
            }

            Dim result As LoginResult = _authService.Login(request)

            If Not result.Exitoso Then
                MessageBox.Show(result.Mensaje, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtClave.Clear()
                TxtClave.Focus()
                Exit Sub
            End If

            Dim mainForm As New FrmMainShellNext(result)
            mainForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        ActualizarEstadoBoton()
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles TxtClave.TextChanged
        ActualizarEstadoBoton()
    End Sub

    Private Sub ActualizarEstadoBoton()
        BtnEntrar.Enabled = (TxtUsuario.TextLength > 0 AndAlso TxtClave.TextLength > 0)
    End Sub

End Class

Public Interface IAuthAppService
    Function Login(request As LoginRequest) As LoginResult
End Interface

Public Class LoginRequest
    Public Property Usuario As String = String.Empty
    Public Property Clave As String = String.Empty
End Class

Public Class LoginResult
    Public Property Exitoso As Boolean
    Public Property Mensaje As String = String.Empty
    Public Property IdUsuario As Integer
    Public Property Usuario As String = String.Empty
    Public Property Categoria As Integer
    Public Property NombreCompleto As String = String.Empty
End Class

' Stub de shell principal para compilar el prototipo de forma aislada
Public Class FrmMainShellNext
    Inherits Form

    Private ReadOnly _session As LoginResult

    Public Sub New(session As LoginResult)
        _session = session
        Me.Text = "ModuloGestion.Next - Principal"
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
