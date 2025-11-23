<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoMateriales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DsMaterial = New ModuloGestion.DsMaterial()
        Me.MaterialesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesTableAdapter = New ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsMaterialTableAdapters.TableAdapterManager()
        Me.MaterialesBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaterialesBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.DsMaterialFamilia = New ModuloGestion.DsMaterialFamilia()
        Me.MaterialesFamiliaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesFamiliaTableAdapter = New ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager()
        Me.MaterialesFamiliaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterilaesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.MaterilaesDetalleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DsMaterialMedidadCompra = New ModuloGestion.DsMaterialMedidadCompra()
        Me.MaterialMedidaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialMedidaCompraTableAdapter = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager()
        Me.MaterialMedidaCompraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialesBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialMedidaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialMedidaCompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Nuevo Grupo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Nuevo Material"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(630, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Material Detalle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DsMaterial
        '
        Me.DsMaterial.DataSetName = "DsMaterial"
        Me.DsMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesBindingSource1
        '
        Me.MaterialesBindingSource1.DataMember = "Materiales"
        Me.MaterialesBindingSource1.DataSource = Me.DsMaterial
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
        'MaterialesBindingSource1BindingNavigator
        '
        Me.MaterialesBindingSource1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.MaterialesBindingSource1BindingNavigator.BindingSource = Me.MaterialesBindingSource1
        Me.MaterialesBindingSource1BindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.MaterialesBindingSource1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.MaterialesBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.MaterialesBindingSource1BindingNavigatorSaveItem})
        Me.MaterialesBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MaterialesBindingSource1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.MaterialesBindingSource1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.MaterialesBindingSource1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.MaterialesBindingSource1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.MaterialesBindingSource1BindingNavigator.Name = "MaterialesBindingSource1BindingNavigator"
        Me.MaterialesBindingSource1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.MaterialesBindingSource1BindingNavigator.Size = New System.Drawing.Size(1248, 25)
        Me.MaterialesBindingSource1BindingNavigator.TabIndex = 7
        Me.MaterialesBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'MaterialesBindingSource1BindingNavigatorSaveItem
        '
        Me.MaterialesBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MaterialesBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("MaterialesBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MaterialesBindingSource1BindingNavigatorSaveItem.Name = "MaterialesBindingSource1BindingNavigatorSaveItem"
        Me.MaterialesBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MaterialesBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MaterialesDataGridView
        '
        Me.MaterialesDataGridView.AllowUserToAddRows = False
        Me.MaterialesDataGridView.AutoGenerateColumns = False
        Me.MaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaterialDataGridViewTextBoxColumn, Me.DescrpcionDataGridViewTextBoxColumn})
        Me.MaterialesDataGridView.DataSource = Me.MaterialesBindingSource1
        Me.MaterialesDataGridView.Location = New System.Drawing.Point(13, 64)
        Me.MaterialesDataGridView.Name = "MaterialesDataGridView"
        Me.MaterialesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MaterialesDataGridView.Size = New System.Drawing.Size(368, 220)
        Me.MaterialesDataGridView.TabIndex = 7
        '
        'IdMaterialDataGridViewTextBoxColumn
        '
        Me.IdMaterialDataGridViewTextBoxColumn.DataPropertyName = "Id_Material"
        Me.IdMaterialDataGridViewTextBoxColumn.HeaderText = "Id Material"
        Me.IdMaterialDataGridViewTextBoxColumn.Name = "IdMaterialDataGridViewTextBoxColumn"
        '
        'DescrpcionDataGridViewTextBoxColumn
        '
        Me.DescrpcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescrpcionDataGridViewTextBoxColumn.DataPropertyName = "Descrpcion"
        Me.DescrpcionDataGridViewTextBoxColumn.HeaderText = "Descrpcion"
        Me.DescrpcionDataGridViewTextBoxColumn.Name = "DescrpcionDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "MedidasCompra"
        Me.BindingSource1.DataSource = Me.DsMedidasCompra
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsMaterialFamilia
        '
        Me.DsMaterialFamilia.DataSetName = "DsMaterialFamilia"
        Me.DsMaterialFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesFamiliaBindingSource1
        '
        Me.MaterialesFamiliaBindingSource1.DataMember = "MaterialesFamilia"
        Me.MaterialesFamiliaBindingSource1.DataSource = Me.DsMaterialFamilia
        '
        'MaterialesFamiliaTableAdapter
        '
        Me.MaterialesFamiliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MaterialesFamiliaTableAdapter = Me.MaterialesFamiliaTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesFamiliaDataGridView
        '
        Me.MaterialesFamiliaDataGridView.AllowUserToAddRows = False
        Me.MaterialesFamiliaDataGridView.AutoGenerateColumns = False
        Me.MaterialesFamiliaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesFamiliaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.MaterialesFamiliaDataGridView.DataSource = Me.MaterialesFamiliaBindingSource1
        Me.MaterialesFamiliaDataGridView.Location = New System.Drawing.Point(20, 325)
        Me.MaterialesFamiliaDataGridView.Name = "MaterialesFamiliaDataGridView"
        Me.MaterialesFamiliaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MaterialesFamiliaDataGridView.Size = New System.Drawing.Size(465, 220)
        Me.MaterialesFamiliaDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Id Material"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'MaterilaesDetalleDataGridView
        '
        Me.MaterilaesDetalleDataGridView.AllowUserToAddRows = False
        Me.MaterilaesDetalleDataGridView.AutoGenerateColumns = False
        Me.MaterilaesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterilaesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.CodigoProveedor})
        Me.MaterilaesDetalleDataGridView.DataSource = Me.MaterilaesDetalleBindingSource1
        Me.MaterilaesDetalleDataGridView.Location = New System.Drawing.Point(630, 64)
        Me.MaterilaesDetalleDataGridView.Name = "MaterilaesDetalleDataGridView"
        Me.MaterilaesDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MaterilaesDetalleDataGridView.Size = New System.Drawing.Size(587, 220)
        Me.MaterilaesDetalleDataGridView.TabIndex = 7
        '
        'MaterilaesDetalleBindingSource1
        '
        Me.MaterilaesDetalleBindingSource1.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource1.DataSource = Me.DsMaterialDetalle
        '
        'DsMaterialDetalle
        '
        Me.DsMaterialDetalle.DataSetName = "DsMaterialDetalle"
        Me.DsMaterialDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.MaterilaesDetalleTableAdapter = Me.MaterilaesDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(387, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Nueva Media Compra"
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.MaterialMedidaCompraDataGridView.AllowUserToAddRows = False
        Me.MaterialMedidaCompraDataGridView.AutoGenerateColumns = False
        Me.MaterialMedidaCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialMedidaCompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn21})
        Me.MaterialMedidaCompraDataGridView.DataSource = Me.MaterialMedidaCompraBindingSource
        Me.MaterialMedidaCompraDataGridView.Location = New System.Drawing.Point(387, 64)
        Me.MaterialMedidaCompraDataGridView.Name = "MaterialMedidaCompraDataGridView"
        Me.MaterialMedidaCompraDataGridView.Size = New System.Drawing.Size(237, 220)
        Me.MaterialMedidaCompraDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IdMaterialMediaCompra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IdMaterialMediaCompra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn21.DataSource = Me.BindingSource2
        Me.DataGridViewTextBoxColumn21.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn21.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn21.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn21.ValueMember = "Id_Medida"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "MedidasCompra"
        Me.BindingSource2.DataSource = Me.DsMedidasCompra
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 344
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Desperdicio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "#%"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn19.HeaderText = "Desperdicio"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn20.HeaderText = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'CodigoProveedor
        '
        Me.CodigoProveedor.DataPropertyName = "CodigoProveedor"
        Me.CodigoProveedor.HeaderText = "ID Proveedor"
        Me.CodigoProveedor.Name = "CodigoProveedor"
        '
        'FrmIngresoMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 646)
        Me.Controls.Add(Me.MaterialMedidaCompraDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MaterilaesDetalleDataGridView)
        Me.Controls.Add(Me.MaterialesFamiliaDataGridView)
        Me.Controls.Add(Me.MaterialesDataGridView)
        Me.Controls.Add(Me.MaterialesBindingSource1BindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmIngresoMateriales"
        Me.Text = "Ingreso Materiales"
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialesBindingSource1BindingNavigator.ResumeLayout(False)
        Me.MaterialesBindingSource1BindingNavigator.PerformLayout()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialMedidaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialMedidaCompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents MaterialesBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn

    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    
    Friend WithEvents MaterialesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsMaterial As ModuloGestion.DsMaterial
    Friend WithEvents MaterialesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesTableAdapter As ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsMaterialTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaterialesBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MaterialesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterialFamilia As ModuloGestion.DsMaterialFamilia
    Friend WithEvents MaterialesFamiliaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesFamiliaTableAdapter As ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesFamiliaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager
    Friend WithEvents MaterilaesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescrpcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DsMaterialMedidadCompra As ModuloGestion.DsMaterialMedidadCompra
    Friend WithEvents MaterialMedidaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialMedidaCompraTableAdapter As ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager
    Friend WithEvents MaterialMedidaCompraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
