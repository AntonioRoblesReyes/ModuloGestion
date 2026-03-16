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

Imports System.Windows.Forms
Imports System.Drawing


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLoginNext
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblClave = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(32, 24)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(278, 25)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "ModuloGestion.Next - Acceso"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(34, 82)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(46, 15)
        Me.LblUsuario.TabIndex = 1
        Me.LblUsuario.Text = "Usuario"
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.Location = New System.Drawing.Point(34, 138)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(67, 15)
        Me.LblClave.TabIndex = 2
        Me.LblClave.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(37, 102)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(273, 23)
        Me.TxtUsuario.TabIndex = 3
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(37, 158)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(273, 23)
        Me.TxtClave.TabIndex = 4
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Location = New System.Drawing.Point(154, 205)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 30)
        Me.BtnEntrar.TabIndex = 5
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(235, 205)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmLoginNext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 263)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblClave)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLoginNext"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

End Namespace
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblClave As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents BtnCancelar As Button
End Class
