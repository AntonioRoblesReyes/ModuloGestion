<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoMaterial))
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
        Me.MaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager()
        Me.MaterilaesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMaterialFamilia = New ModuloGestion.DsMaterialFamilia()
        Me.MaterialesFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesFamiliaTableAdapter = New ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager()
        Me.MaterialesFamiliaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMaterialMedidadCompra = New ModuloGestion.DsMaterialMedidadCompra()
        Me.MaterialMedidaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialMedidaCompraTableAdapter = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager()
        Me.MaterialMedidaCompraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager()
        Me.Añaadir = New System.Windows.Forms.Button()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialesBindingNavigator.SuspendLayout()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialMedidaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialMedidaCompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MaterialesBindingNavigator.Size = New System.Drawing.Size(1076, 25)
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
        'MaterialesDataGridView
        '
        Me.MaterialesDataGridView.AutoGenerateColumns = False
        Me.MaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.MaterialesDataGridView.DataSource = Me.MaterialesBindingSource
        Me.MaterialesDataGridView.Location = New System.Drawing.Point(12, 57)
        Me.MaterialesDataGridView.Name = "MaterialesDataGridView"
        Me.MaterialesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.MaterialesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descrpcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descrpcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DsMaterialDetalle
        '
        Me.DsMaterialDetalle.DataSetName = "DsMaterialDetalle"
        Me.DsMaterialDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterilaesDetalleBindingSource
        '
        Me.MaterilaesDetalleBindingSource.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource.DataSource = Me.DsMaterialDetalle
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MaterilaesDetalleTableAdapter = Me.MaterilaesDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterilaesDetalleDataGridView
        '
        Me.MaterilaesDetalleDataGridView.AutoGenerateColumns = False
        Me.MaterilaesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterilaesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MaterilaesDetalleDataGridView.DataSource = Me.MaterilaesDetalleBindingSource
        Me.MaterilaesDetalleDataGridView.Location = New System.Drawing.Point(12, 302)
        Me.MaterilaesDetalleDataGridView.Name = "MaterilaesDetalleDataGridView"
        Me.MaterilaesDetalleDataGridView.Size = New System.Drawing.Size(662, 220)
        Me.MaterilaesDetalleDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Desperdicio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Desperdicio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DsMaterialFamilia
        '
        Me.DsMaterialFamilia.DataSetName = "DsMaterialFamilia"
        Me.DsMaterialFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesFamiliaBindingSource
        '
        Me.MaterialesFamiliaBindingSource.DataMember = "MaterialesFamilia"
        Me.MaterialesFamiliaBindingSource.DataSource = Me.DsMaterialFamilia
        '
        'MaterialesFamiliaTableAdapter
        '
        Me.MaterialesFamiliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.MaterialesFamiliaTableAdapter = Me.MaterialesFamiliaTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesFamiliaDataGridView
        '
        Me.MaterialesFamiliaDataGridView.AutoGenerateColumns = False
        Me.MaterialesFamiliaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesFamiliaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MaterialesFamiliaDataGridView.DataSource = Me.MaterialesFamiliaBindingSource
        Me.MaterialesFamiliaDataGridView.Location = New System.Drawing.Point(318, 57)
        Me.MaterialesFamiliaDataGridView.Name = "MaterialesFamiliaDataGridView"
        Me.MaterialesFamiliaDataGridView.Size = New System.Drawing.Size(356, 220)
        Me.MaterialesFamiliaDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.MaterialMedidaCompraTableAdapter = Me.MaterialMedidaCompraTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialMedidaCompraDataGridView
        '
        Me.MaterialMedidaCompraDataGridView.AutoGenerateColumns = False
        Me.MaterialMedidaCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialMedidaCompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.MaterialMedidaCompraDataGridView.DataSource = Me.MaterialMedidaCompraBindingSource
        Me.MaterialMedidaCompraDataGridView.Location = New System.Drawing.Point(680, 57)
        Me.MaterialMedidaCompraDataGridView.Name = "MaterialMedidaCompraDataGridView"
        Me.MaterialMedidaCompraDataGridView.Size = New System.Drawing.Size(291, 162)
        Me.MaterialMedidaCompraDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdMaterialMediaCompra"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdMaterialMediaCompra"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn12.DataSource = Me.MedidasCompraBindingSource
        Me.DataGridViewTextBoxColumn12.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn12.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn12.HeaderText = "Medida Compra"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn12.ValueMember = "Id_Medida"
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
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.MedidasCompraTableAdapter = Me.MedidasCompraTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Añaadir
        '
        Me.Añaadir.Location = New System.Drawing.Point(689, 28)
        Me.Añaadir.Name = "Añaadir"
        Me.Añaadir.Size = New System.Drawing.Size(153, 23)
        Me.Añaadir.TabIndex = 5
        Me.Añaadir.Text = "Añadir Material"
        Me.Añaadir.UseVisualStyleBackColor = True
        '
        'FrmIngresoMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 559)
        Me.Controls.Add(Me.Añaadir)
        Me.Controls.Add(Me.MaterialMedidaCompraDataGridView)
        Me.Controls.Add(Me.MaterialesFamiliaDataGridView)
        Me.Controls.Add(Me.MaterilaesDetalleDataGridView)
        Me.Controls.Add(Me.MaterialesDataGridView)
        Me.Controls.Add(Me.MaterialesBindingNavigator)
        Me.Name = "FrmIngresoMaterial"
        Me.Text = "FrmIngresoMaterial"
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialesBindingNavigator.ResumeLayout(False)
        Me.MaterialesBindingNavigator.PerformLayout()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialMedidaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialMedidaCompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MaterialesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager
    Friend WithEvents MaterilaesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterialFamilia As ModuloGestion.DsMaterialFamilia
    Friend WithEvents MaterialesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesFamiliaTableAdapter As ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesFamiliaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsMaterialMedidadCompra As ModuloGestion.DsMaterialMedidadCompra
    Friend WithEvents MaterialMedidaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialMedidaCompraTableAdapter As ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager
    Friend WithEvents MaterialMedidaCompraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Añaadir As System.Windows.Forms.Button
End Class
