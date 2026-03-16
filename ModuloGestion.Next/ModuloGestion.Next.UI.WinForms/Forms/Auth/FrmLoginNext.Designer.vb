Imports System.Windows.Forms
Imports System.Drawing

Namespace Forms.Auth

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class FrmLoginNext
        Inherits Form

        Private components As System.ComponentModel.IContainer

        Friend WithEvents lblUsuario As Label
        Friend WithEvents lblClave As Label
        Friend WithEvents txtUsuario As TextBox
        Friend WithEvents txtClave As TextBox
        Friend WithEvents btnEntrar As Button
        Friend WithEvents btnCancelar As Button

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()

            Me.lblUsuario = New Label()
            Me.lblClave = New Label()
            Me.txtUsuario = New TextBox()
            Me.txtClave = New TextBox()
            Me.btnEntrar = New Button()
            Me.btnCancelar = New Button()

            Me.SuspendLayout()

            'lblUsuario
            Me.lblUsuario.AutoSize = True
            Me.lblUsuario.Location = New Point(24, 28)
            Me.lblUsuario.Text = "Usuario"

            'txtUsuario
            Me.txtUsuario.Location = New Point(120, 24)
            Me.txtUsuario.Size = New Size(220, 23)

            'lblClave
            Me.lblClave.AutoSize = True
            Me.lblClave.Location = New Point(24, 72)
            Me.lblClave.Text = "Clave"

            'txtClave
            Me.txtClave.Location = New Point(120, 68)
            Me.txtClave.Size = New Size(220, 23)
            Me.txtClave.UseSystemPasswordChar = True

            'btnEntrar
            Me.btnEntrar.DialogResult = DialogResult.OK
            Me.btnEntrar.Location = New Point(184, 125)
            Me.btnEntrar.Text = "Entrar"

            'btnCancelar
            Me.btnCancelar.DialogResult = DialogResult.Cancel
            Me.btnCancelar.Location = New Point(265, 125)
            Me.btnCancelar.Text = "Cancelar"

            'FrmLoginNext
            Me.AcceptButton = Me.btnEntrar
            Me.CancelButton = Me.btnCancelar
            Me.ClientSize = New Size(380, 190)
            Me.Controls.Add(Me.lblUsuario)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.lblClave)
            Me.Controls.Add(Me.txtClave)
            Me.Controls.Add(Me.btnEntrar)
            Me.Controls.Add(Me.btnCancelar)
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Iniciar sesión"

            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

    End Class

End Namespace