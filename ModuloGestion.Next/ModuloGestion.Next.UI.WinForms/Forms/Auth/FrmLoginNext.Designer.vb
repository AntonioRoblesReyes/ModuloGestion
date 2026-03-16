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
            lblUsuario = New Label()
            lblClave = New Label()
            txtUsuario = New TextBox()
            txtClave = New TextBox()
            btnEntrar = New Button()
            btnCancelar = New Button()
            SuspendLayout()
            ' 
            ' lblUsuario
            ' 
            lblUsuario.AutoSize = True
            lblUsuario.Location = New Point(24, 28)
            lblUsuario.Name = "lblUsuario"
            lblUsuario.Size = New Size(72, 25)
            lblUsuario.TabIndex = 0
            lblUsuario.Text = "Usuario"
            ' 
            ' lblClave
            ' 
            lblClave.AutoSize = True
            lblClave.Location = New Point(24, 72)
            lblClave.Name = "lblClave"
            lblClave.Size = New Size(54, 25)
            lblClave.TabIndex = 2
            lblClave.Text = "Clave"
            ' 
            ' txtUsuario
            ' 
            txtUsuario.Location = New Point(120, 24)
            txtUsuario.Name = "txtUsuario"
            txtUsuario.Size = New Size(220, 31)
            txtUsuario.TabIndex = 1
            ' 
            ' txtClave
            ' 
            txtClave.Location = New Point(120, 68)
            txtClave.Name = "txtClave"
            txtClave.Size = New Size(220, 31)
            txtClave.TabIndex = 3
            txtClave.UseSystemPasswordChar = True
            ' 
            ' btnEntrar
            ' 
            btnEntrar.DialogResult = DialogResult.OK
            btnEntrar.Location = New Point(184, 125)
            btnEntrar.Name = "btnEntrar"
            btnEntrar.Size = New Size(75, 23)
            btnEntrar.TabIndex = 4
            btnEntrar.Text = "Entrar"
            ' 
            ' btnCancelar
            ' 
            btnCancelar.DialogResult = DialogResult.Cancel
            btnCancelar.Location = New Point(265, 125)
            btnCancelar.Name = "btnCancelar"
            btnCancelar.Size = New Size(75, 23)
            btnCancelar.TabIndex = 5
            btnCancelar.Text = "Cancelar"
            ' 
            ' FrmLoginNext
            ' 
            AcceptButton = btnEntrar
            CancelButton = btnCancelar
            ClientSize = New Size(380, 190)
            Controls.Add(lblUsuario)
            Controls.Add(txtUsuario)
            Controls.Add(lblClave)
            Controls.Add(txtClave)
            Controls.Add(btnEntrar)
            Controls.Add(btnCancelar)
            Name = "FrmLoginNext"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Iniciar sesión"
            ResumeLayout(False)
            PerformLayout()

        End Sub

    End Class

End Namespace