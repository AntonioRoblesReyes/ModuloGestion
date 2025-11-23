<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnexrMediaCompraMaterial
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
        Dim Id_MaterialLabel As System.Windows.Forms.Label
        Dim DescrpcionLabel As System.Windows.Forms.Label
        Dim Id_MedidaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnexrMediaCompraMaterial))
        Me.DsMaterial = New ModuloGestion.DsMaterial()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesTableAdapter = New ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsMaterialTableAdapters.TableAdapterManager()
        Me.MaterialesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaterialesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.DescrpcionTextBox = New System.Windows.Forms.TextBox()
        Me.DsMaterialMedidadCompra = New ModuloGestion.DsMaterialMedidadCompra()
        Me.MaterialMedidaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialMedidaCompraTableAdapter = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager()
        Me.MaterialMedidaCompraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager()
        Me.Id_MedidaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MedidasCompraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Id_MaterialLabel = New System.Windows.Forms.Label()
        DescrpcionLabel = New System.Windows.Forms.Label()
        Id_MedidaLabel = New System.Windows.Forms.Label()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialesBindingNavigator.SuspendLayout()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialMedidaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialMedidaCompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_MaterialLabel
        '
        Id_MaterialLabel.AutoSize = True
        Id_MaterialLabel.Location = New System.Drawing.Point(11, 31)
        Id_MaterialLabel.Name = "Id_MaterialLabel"
        Id_MaterialLabel.Size = New System.Drawing.Size(59, 13)
        Id_MaterialLabel.TabIndex = 1
        Id_MaterialLabel.Text = "Id Material:"
        '
        'DescrpcionLabel
        '
        DescrpcionLabel.AutoSize = True
        DescrpcionLabel.Location = New System.Drawing.Point(11, 57)
        DescrpcionLabel.Name = "DescrpcionLabel"
        DescrpcionLabel.Size = New System.Drawing.Size(64, 13)
        DescrpcionLabel.TabIndex = 3
        DescrpcionLabel.Text = "Descrpcion:"
        '
        'Id_MedidaLabel
        '
        Id_MedidaLabel.AutoSize = True
        Id_MedidaLabel.Location = New System.Drawing.Point(331, 63)
        Id_MedidaLabel.Name = "Id_MedidaLabel"
        Id_MedidaLabel.Size = New System.Drawing.Size(57, 13)
        Id_MedidaLabel.TabIndex = 6
        Id_MedidaLabel.Text = "Id Medida:"
        '
        'DsMaterial
        '
        Me.DsMaterial.DataSetName = "DsMaterial"
        Me.DsMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.DsMaterial
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MaterialesTableAdapter = Me.MaterialesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesBindingNavigator
        '
        Me.MaterialesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MaterialesBindingNavigator.BindingSource = Me.MaterialesBindingSource
        Me.MaterialesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MaterialesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MaterialesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MaterialesBindingNavigatorSaveItem})
        Me.MaterialesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MaterialesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MaterialesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MaterialesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MaterialesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MaterialesBindingNavigator.Name = "MaterialesBindingNavigator"
        Me.MaterialesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MaterialesBindingNavigator.Size = New System.Drawing.Size(589, 25)
        Me.MaterialesBindingNavigator.TabIndex = 0
        Me.MaterialesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MaterialesBindingNavigatorSaveItem
        '
        Me.MaterialesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MaterialesBindingNavigatorSaveItem.Image = CType(resources.GetObject("MaterialesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MaterialesBindingNavigatorSaveItem.Name = "MaterialesBindingNavigatorSaveItem"
        Me.MaterialesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MaterialesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_MaterialTextBox
        '
        Me.Id_MaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "Id_Material", True))
        Me.Id_MaterialTextBox.Location = New System.Drawing.Point(81, 28)
        Me.Id_MaterialTextBox.Name = "Id_MaterialTextBox"
        Me.Id_MaterialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_MaterialTextBox.TabIndex = 2
        '
        'DescrpcionTextBox
        '
        Me.DescrpcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "Descrpcion", True))
        Me.DescrpcionTextBox.Location = New System.Drawing.Point(81, 54)
        Me.DescrpcionTextBox.Name = "DescrpcionTextBox"
        Me.DescrpcionTextBox.Size = New System.Drawing.Size(201, 20)
        Me.DescrpcionTextBox.TabIndex = 4
        '
        'DsMaterialMedidadCompra
        '
        Me.DsMaterialMedidadCompra.DataSetName = "DsMaterialMedidadCompra"
        Me.DsMaterialMedidadCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialMedidaCompraBindingSource
        '
        Me.MaterialMedidaCompraBindingSource.DataMember = "MaterialMedidaCompra"
        Me.MaterialMedidaCompraBindingSource.DataSource = Me.DsMaterialMedidadCompra
        '
        'MaterialMedidaCompraTableAdapter
        '
        Me.MaterialMedidaCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MaterialMedidaCompraTableAdapter = Me.MaterialMedidaCompraTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialMedidaCompraDataGridView
        '
        Me.MaterialMedidaCompraDataGridView.AllowUserToAddRows = False
        Me.MaterialMedidaCompraDataGridView.AutoGenerateColumns = False
        Me.MaterialMedidaCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialMedidaCompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MaterialMedidaCompraDataGridView.DataSource = Me.MaterialMedidaCompraBindingSource
        Me.MaterialMedidaCompraDataGridView.Location = New System.Drawing.Point(0, 90)
        Me.MaterialMedidaCompraDataGridView.Name = "MaterialMedidaCompraDataGridView"
        Me.MaterialMedidaCompraDataGridView.Size = New System.Drawing.Size(282, 220)
        Me.MaterialMedidaCompraDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMaterialMediaCompra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMaterialMediaCompra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.MedidasCompraBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id_Medida"
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.MedidasCompraTableAdapter = Me.MedidasCompraTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_MedidaComboBox
        '
        Me.Id_MedidaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedidasCompraBindingSource, "Id_Medida", True))
        Me.Id_MedidaComboBox.DataSource = Me.MedidasCompraBindingSource
        Me.Id_MedidaComboBox.DisplayMember = "Descripcion_Medida"
        Me.Id_MedidaComboBox.FormattingEnabled = True
        Me.Id_MedidaComboBox.Location = New System.Drawing.Point(394, 60)
        Me.Id_MedidaComboBox.Name = "Id_MedidaComboBox"
        Me.Id_MedidaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Id_MedidaComboBox.TabIndex = 7
        Me.Id_MedidaComboBox.ValueMember = "Id_Medida"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Anexar Medida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MedidasCompraBindingSource1
        '
        Me.MedidasCompraBindingSource1.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource1.DataSource = Me.DsMedidasCompra
        '
        'FrmAnexrMediaCompraMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 340)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_MedidaLabel)
        Me.Controls.Add(Me.Id_MedidaComboBox)
        Me.Controls.Add(Me.MaterialMedidaCompraDataGridView)
        Me.Controls.Add(Id_MaterialLabel)
        Me.Controls.Add(Me.Id_MaterialTextBox)
        Me.Controls.Add(DescrpcionLabel)
        Me.Controls.Add(Me.DescrpcionTextBox)
        Me.Controls.Add(Me.MaterialesBindingNavigator)
        Me.Name = "FrmAnexrMediaCompraMaterial"
        Me.Text = "FrmAnexrMediaCompraMaterial"
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialesBindingNavigator.ResumeLayout(False)
        Me.MaterialesBindingNavigator.PerformLayout()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialMedidaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialMedidaCompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsMaterial As ModuloGestion.DsMaterial
    Friend WithEvents MaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesTableAdapter As ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsMaterialTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaterialesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_MaterialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescrpcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsMaterialMedidadCompra As ModuloGestion.DsMaterialMedidadCompra
    Friend WithEvents MaterialMedidaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialMedidaCompraTableAdapter As ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager
    Friend WithEvents MaterialMedidaCompraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager
    Friend WithEvents Id_MedidaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MedidasCompraBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
