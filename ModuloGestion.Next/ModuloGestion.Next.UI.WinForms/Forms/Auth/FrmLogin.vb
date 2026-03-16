Namespace Forms.Auth
    Public Class FrmLogin
        Inherits Global.System.Windows.Forms.Form

        Private ReadOnly _txtUsuario As Global.System.Windows.Forms.TextBox
        Private ReadOnly _txtClave As Global.System.Windows.Forms.TextBox

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
            Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.ShowInTaskbar = False
            Me.ClientSize = New Global.System.Drawing.Size(380, 190)

            Dim lblUsuario As New Global.System.Windows.Forms.Label() With {
                .Text = "Usuario",
                .AutoSize = True,
                .Location = New Global.System.Drawing.Point(24, 28)
            }

            _txtUsuario = New Global.System.Windows.Forms.TextBox() With {
                .Location = New Global.System.Drawing.Point(120, 24),
                .Width = 220,
                .TabIndex = 0
            }

            Dim lblClave As New Global.System.Windows.Forms.Label() With {
                .Text = "Clave",
                .AutoSize = True,
                .Location = New Global.System.Drawing.Point(24, 72)
            }

            _txtClave = New Global.System.Windows.Forms.TextBox() With {
                .Location = New Global.System.Drawing.Point(120, 68),
                .Width = 220,
                .UseSystemPasswordChar = True,
                .TabIndex = 1
            }

            Dim btnEntrar As New Global.System.Windows.Forms.Button() With {
                .Text = "Entrar",
                .DialogResult = Global.System.Windows.Forms.DialogResult.OK,
                .Location = New Global.System.Drawing.Point(184, 125),
                .Width = 75,
                .TabIndex = 2
            }

            Dim btnCancelar As New Global.System.Windows.Forms.Button() With {
                .Text = "Cancelar",
                .DialogResult = Global.System.Windows.Forms.DialogResult.Cancel,
                .Location = New Global.System.Drawing.Point(265, 125),
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

        Private Sub OnEntrarClick(sender As Object, e As Global.System.EventArgs)
            If String.IsNullOrWhiteSpace(Usuario) Then
                Global.System.Windows.Forms.MessageBox.Show(Me, "Debe indicar el usuario.", "Validación", Global.System.Windows.Forms.MessageBoxButtons.OK, Global.System.Windows.Forms.MessageBoxIcon.Warning)
                Me.DialogResult = Global.System.Windows.Forms.DialogResult.None
                _txtUsuario.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(Clave) Then
                Global.System.Windows.Forms.MessageBox.Show(Me, "Debe indicar la clave.", "Validación", Global.System.Windows.Forms.MessageBoxButtons.OK, Global.System.Windows.Forms.MessageBoxIcon.Warning)
                Me.DialogResult = Global.System.Windows.Forms.DialogResult.None
                _txtClave.Focus()
                Return
            End If
        End Sub
    End Class
End Namespace
