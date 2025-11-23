<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntroducirEmpresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.EmpresasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmsAceptar = New System.Windows.Forms.Button()
        Me.CmdCAmcelar = New System.Windows.Forms.Button()
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEmpresa
        '
        Me.CmbEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpresasBindingSource1, "Id_Fiscal", True))
        Me.CmbEmpresa.DataSource = Me.EmpresasBindingSource
        Me.CmbEmpresa.DisplayMember = "Nombre"
        Me.CmbEmpresa.FormattingEnabled = True
        Me.CmbEmpresa.Location = New System.Drawing.Point(76, 91)
        Me.CmbEmpresa.Name = "CmbEmpresa"
        Me.CmbEmpresa.Size = New System.Drawing.Size(263, 21)
        Me.CmbEmpresa.TabIndex = 0
        Me.CmbEmpresa.ValueMember = "Id_Empresa"
        '
        'EmpresasBindingSource1
        '
        Me.EmpresasBindingSource1.DataMember = "Empresas"
        Me.EmpresasBindingSource1.DataSource = Me.DsEmpresas
        '
        'DsEmpresas
        '
        Me.DsEmpresas.DataSetName = "DsEmpresas"
        Me.DsEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsEmpresas
        '
        'CmsAceptar
        '
        Me.CmsAceptar.Location = New System.Drawing.Point(104, 146)
        Me.CmsAceptar.Name = "CmsAceptar"
        Me.CmsAceptar.Size = New System.Drawing.Size(75, 23)
        Me.CmsAceptar.TabIndex = 1
        Me.CmsAceptar.Text = "Aceptar"
        Me.CmsAceptar.UseVisualStyleBackColor = True
        '
        'CmdCAmcelar
        '
        Me.CmdCAmcelar.Location = New System.Drawing.Point(216, 146)
        Me.CmdCAmcelar.Name = "CmdCAmcelar"
        Me.CmdCAmcelar.Size = New System.Drawing.Size(75, 23)
        Me.CmdCAmcelar.TabIndex = 2
        Me.CmdCAmcelar.Text = "Cerrar"
        Me.CmdCAmcelar.UseVisualStyleBackColor = True
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar Empresa  Para Nuevo presupuesto"
        '
        'FrmIntroducirEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdCAmcelar)
        Me.Controls.Add(Me.CmsAceptar)
        Me.Controls.Add(Me.CmbEmpresa)
        Me.Name = "FrmIntroducirEmpresa"
        Me.Text = "FrmIntroducirEmpresa"
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents CmsAceptar As System.Windows.Forms.Button
    Friend WithEvents CmdCAmcelar As System.Windows.Forms.Button
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents EmpresasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
