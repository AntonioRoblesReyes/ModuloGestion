Option Strict On
Option Infer On

Imports System.Windows.Forms

Namespace Forms.Auth

    Partial Public Class FrmLoginNext

        Private ReadOnly _authService As IAuthAppService

        Public Sub New(authService As IAuthAppService)

            InitializeComponent()
            _authService = authService

        End Sub

        Public ReadOnly Property Usuario As String
            Get
                Return txtUsuario.Text.Trim()
            End Get
        End Property

        Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

            Dim request As New LoginRequest With {
                .Usuario = txtUsuario.Text,
                .Clave = txtClave.Text
            }

            Dim result = _authService.Login(request)

            If Not result.Exitoso Then
                MessageBox.Show(result.Mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        End Sub

        Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub

    End Class

End Namespace