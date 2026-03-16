
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

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblClave As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents BtnCancelar As Button
End Class
