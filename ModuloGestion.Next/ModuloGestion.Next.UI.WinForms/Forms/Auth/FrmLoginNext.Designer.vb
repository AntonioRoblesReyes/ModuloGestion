Namespace Forms.Auth
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmLoginNext
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Private WithEvents lblUsuario As Global.System.Windows.Forms.Label
    Private WithEvents lblClave As Global.System.Windows.Forms.Label
    Private WithEvents txtUsuario As Global.System.Windows.Forms.TextBox
    Private WithEvents txtClave As Global.System.Windows.Forms.TextBox
    Private WithEvents btnEntrar As Global.System.Windows.Forms.Button
    Private WithEvents btnCancelar As Global.System.Windows.Forms.Button

    <Global.System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <Global.System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblUsuario = New Global.System.Windows.Forms.Label()
        Me.lblClave = New Global.System.Windows.Forms.Label()
        Me.txtUsuario = New Global.System.Windows.Forms.TextBox()
        Me.txtClave = New Global.System.Windows.Forms.TextBox()
        Me.btnEntrar = New Global.System.Windows.Forms.Button()
        Me.btnCancelar = New Global.System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New Global.System.Drawing.Point(24, 28)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New Global.System.Drawing.Size(50, 15)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New Global.System.Drawing.Point(120, 24)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New Global.System.Drawing.Size(220, 23)
        Me.txtUsuario.TabIndex = 1
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New Global.System.Drawing.Point(24, 72)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New Global.System.Drawing.Size(35, 15)
        Me.lblClave.TabIndex = 2
        Me.lblClave.Text = "Clave"
        '
        'txtClave
        '
        Me.txtClave.Location = New Global.System.Drawing.Point(120, 68)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New Global.System.Drawing.Size(220, 23)
        Me.txtClave.TabIndex = 3
        Me.txtClave.UseSystemPasswordChar = True
        '
        'btnEntrar
        '
        Me.btnEntrar.DialogResult = Global.System.Windows.Forms.DialogResult.OK
        Me.btnEntrar.Location = New Global.System.Drawing.Point(184, 125)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New Global.System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New Global.System.Drawing.Point(265, 125)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New Global.System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmLoginNext
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New Global.System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New Global.System.Drawing.Size(380, 190)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLoginNext"
        Me.ShowInTaskbar = False
        Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

End Namespace
