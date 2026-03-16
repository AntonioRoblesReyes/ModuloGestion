Imports System.Drawing
Imports System.Windows.Forms

Namespace Forms.Auth
    Public Class FrmLogin
        Inherits Form

        Private ReadOnly _txtUsuario As TextBox
        Private ReadOnly _txtClave As TextBox

        Public ReadOnly Property Usuario As String
            Get
                Return _txtUsuario.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property Clave As String
            Get
                Return _txtClave.Text
            End Get
        End Property

        Public Sub New()
            Me.Text = "Iniciar sesión"
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.ShowInTaskbar = False
            Me.ClientSize = New Size(380, 190)

            Dim lblUsuario As New Label() With {
                .Text = "Usuario",
                .AutoSize = True,
                .Location = New Point(24, 28)
            }

            _txtUsuario = New TextBox() With {
                .Location = New Point(120, 24),
                .Width = 220,
                .TabIndex = 0
            }

            Dim lblClave As New Label() With {
                .Text = "Clave",
                .AutoSize = True,
                .Location = New Point(24, 72)
            }

            _txtClave = New TextBox() With {
                .Location = New Point(120, 68),
                .Width = 220,
                .UseSystemPasswordChar = True,
                .TabIndex = 1
            }

            Dim btnEntrar As New Button() With {
                .Text = "Entrar",
                .DialogResult = DialogResult.OK,
                .Location = New Point(184, 125),
                .Width = 75,
                .TabIndex = 2
            }

            Dim btnCancelar As New Button() With {
                .Text = "Cancelar",
                .DialogResult = DialogResult.Cancel,
                .Location = New Point(265, 125),
                .Width = 75,
                .TabIndex = 3
            }

            AddHandler btnEntrar.Click, AddressOf OnEntrarClick

            Me.Controls.Add(lblUsuario)
            Me.Controls.Add(_txtUsuario)
            Me.Controls.Add(lblClave)
            Me.Controls.Add(_txtClave)
            Me.Controls.Add(btnEntrar)
            Me.Controls.Add(btnCancelar)

            Me.AcceptButton = btnEntrar
            Me.CancelButton = btnCancelar
        End Sub

        Private Sub OnEntrarClick(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(Usuario) Then
                MessageBox.Show(Me, "Debe indicar el usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.DialogResult = DialogResult.None
                _txtUsuario.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(Clave) Then
                MessageBox.Show(Me, "Debe indicar la clave.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.DialogResult = DialogResult.None
                _txtClave.Focus()
                Return
            End If
        End Sub
    End Class
End Namespace
