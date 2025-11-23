<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFerreteria
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
        Dim IdFerreteriaLabel As System.Windows.Forms.Label
        Dim Descripcion_Eemento_FerreteriaLabel As System.Windows.Forms.Label
        Dim Medidad_Elementos_FerreteriaLabel As System.Windows.Forms.Label
        Me.DsFerreteria = New ModuloGestion.DsFerreteria()
        Me.FerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FerreteriaTableAdapter = New ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager()
        Me.IdFerreteriaTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Eemento_FerreteriaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.Medidad_Elementos_FerreteriaTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager1 = New ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager()
        Me.Id_MedidaComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        IdFerreteriaLabel = New System.Windows.Forms.Label()
        Descripcion_Eemento_FerreteriaLabel = New System.Windows.Forms.Label()
        Medidad_Elementos_FerreteriaLabel = New System.Windows.Forms.Label()
        CType(Me.DsFerreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdFerreteriaLabel
        '
        IdFerreteriaLabel.AutoSize = True
        IdFerreteriaLabel.Location = New System.Drawing.Point(38, 80)
        IdFerreteriaLabel.Name = "IdFerreteriaLabel"
        IdFerreteriaLabel.Size = New System.Drawing.Size(66, 13)
        IdFerreteriaLabel.TabIndex = 1
        IdFerreteriaLabel.Text = "Id Ferreteria:"
        '
        'Descripcion_Eemento_FerreteriaLabel
        '
        Descripcion_Eemento_FerreteriaLabel.AutoSize = True
        Descripcion_Eemento_FerreteriaLabel.Location = New System.Drawing.Point(38, 106)
        Descripcion_Eemento_FerreteriaLabel.Name = "Descripcion_Eemento_FerreteriaLabel"
        Descripcion_Eemento_FerreteriaLabel.Size = New System.Drawing.Size(66, 13)
        Descripcion_Eemento_FerreteriaLabel.TabIndex = 3
        Descripcion_Eemento_FerreteriaLabel.Text = "Descripcion "
        '
        'Medidad_Elementos_FerreteriaLabel
        '
        Medidad_Elementos_FerreteriaLabel.AutoSize = True
        Medidad_Elementos_FerreteriaLabel.Location = New System.Drawing.Point(38, 132)
        Medidad_Elementos_FerreteriaLabel.Name = "Medidad_Elementos_FerreteriaLabel"
        Medidad_Elementos_FerreteriaLabel.Size = New System.Drawing.Size(87, 13)
        Medidad_Elementos_FerreteriaLabel.TabIndex = 5
        Medidad_Elementos_FerreteriaLabel.Text = "Medidad Compra"
        '
        'DsFerreteria
        '
        Me.DsFerreteria.DataSetName = "DsFerreteria"
        Me.DsFerreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FerreteriaBindingSource
        '
        Me.FerreteriaBindingSource.DataMember = "Ferreteria"
        Me.FerreteriaBindingSource.DataSource = Me.DsFerreteria
        '
        'FerreteriaTableAdapter
        '
        Me.FerreteriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FerreteriaTableAdapter = Me.FerreteriaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdFerreteriaTextBox
        '
        Me.IdFerreteriaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdFerreteriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FerreteriaBindingSource, "IdFerreteria", True))
        Me.IdFerreteriaTextBox.Location = New System.Drawing.Point(134, 77)
        Me.IdFerreteriaTextBox.Name = "IdFerreteriaTextBox"
        Me.IdFerreteriaTextBox.Size = New System.Drawing.Size(174, 20)
        Me.IdFerreteriaTextBox.TabIndex = 2
        '
        'Descripcion_Eemento_FerreteriaTextBox
        '
        Me.Descripcion_Eemento_FerreteriaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcion_Eemento_FerreteriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FerreteriaBindingSource, "Descripcion_Eemento_Ferreteria", True))
        Me.Descripcion_Eemento_FerreteriaTextBox.Location = New System.Drawing.Point(134, 103)
        Me.Descripcion_Eemento_FerreteriaTextBox.Name = "Descripcion_Eemento_FerreteriaTextBox"
        Me.Descripcion_Eemento_FerreteriaTextBox.Size = New System.Drawing.Size(256, 20)
        Me.Descripcion_Eemento_FerreteriaTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'Medidad_Elementos_FerreteriaTextBox
        '
        Me.Medidad_Elementos_FerreteriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FerreteriaBindingSource, "Medidad_Elementos_Ferreteria", True))
        Me.Medidad_Elementos_FerreteriaTextBox.Location = New System.Drawing.Point(12, 148)
        Me.Medidad_Elementos_FerreteriaTextBox.Name = "Medidad_Elementos_FerreteriaTextBox"
        Me.Medidad_Elementos_FerreteriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Medidad_Elementos_FerreteriaTextBox.TabIndex = 8
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MedidasCompraTableAdapter = Me.MedidasCompraTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_MedidaComboBox
        '
        Me.Id_MedidaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedidasCompraBindingSource, "Id_Medida", True))
        Me.Id_MedidaComboBox.DataSource = Me.MedidasCompraBindingSource
        Me.Id_MedidaComboBox.DisplayMember = "Descripcion_Medida"
        Me.Id_MedidaComboBox.FormattingEnabled = True
        Me.Id_MedidaComboBox.Location = New System.Drawing.Point(134, 129)
        Me.Id_MedidaComboBox.Name = "Id_MedidaComboBox"
        Me.Id_MedidaComboBox.Size = New System.Drawing.Size(144, 21)
        Me.Id_MedidaComboBox.TabIndex = 9
        Me.Id_MedidaComboBox.ValueMember = "Id_Medida"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(284, 129)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(106, 23)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar y Cerrar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(401, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 184)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'FrmFerreteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 274)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Id_MedidaComboBox)
        Me.Controls.Add(Me.Medidad_Elementos_FerreteriaTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdFerreteriaLabel)
        Me.Controls.Add(Me.IdFerreteriaTextBox)
        Me.Controls.Add(Descripcion_Eemento_FerreteriaLabel)
        Me.Controls.Add(Me.Descripcion_Eemento_FerreteriaTextBox)
        Me.Controls.Add(Medidad_Elementos_FerreteriaLabel)
        Me.Name = "FrmFerreteria"
        Me.Text = "FrmFerreteria"
        CType(Me.DsFerreteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FerreteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsFerreteria As ModuloGestion.DsFerreteria
    Friend WithEvents FerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FerreteriaTableAdapter As ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager
    Friend WithEvents IdFerreteriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion_Eemento_FerreteriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents Medidad_Elementos_FerreteriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager
    Friend WithEvents Id_MedidaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
