<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKtCompleto
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
        Dim IdArticuloLabel As System.Windows.Forms.Label
        Dim Descripcion_articuloLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKtCompleto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.ArticulosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ArticulosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.ArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Descripcion_articuloTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DsNotasEntregaDetalle = New ModuloGestion.DsNotasEntregaDetalle()
        Me.NotasEntregaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasEntregaDetalleTableAdapter = New ModuloGestion.DsNotasEntregaDetalleTableAdapters.NotasEntregaDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager()
        Me.DsEstadoEntregas = New ModuloGestion.DsEstadoEntregas()
        Me.EstadoentregasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoentregasTableAdapter = New ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalleHerrajes = New ModuloGestion.DsPresupuestoDetalleHerrajes()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager()
        IdArticuloLabel = New System.Windows.Forms.Label()
        Descripcion_articuloLabel = New System.Windows.Forms.Label()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArticulosBindingNavigator.SuspendLayout()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNotasEntregaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdArticuloLabel
        '
        IdArticuloLabel.AutoSize = True
        IdArticuloLabel.Location = New System.Drawing.Point(17, 25)
        IdArticuloLabel.Name = "IdArticuloLabel"
        IdArticuloLabel.Size = New System.Drawing.Size(57, 13)
        IdArticuloLabel.TabIndex = 1
        IdArticuloLabel.Text = "Id Articulo:"
        '
        'Descripcion_articuloLabel
        '
        Descripcion_articuloLabel.AutoSize = True
        Descripcion_articuloLabel.Location = New System.Drawing.Point(12, 54)
        Descripcion_articuloLabel.Name = "Descripcion_articuloLabel"
        Descripcion_articuloLabel.Size = New System.Drawing.Size(103, 13)
        Descripcion_articuloLabel.TabIndex = 6
        Descripcion_articuloLabel.Text = "Descripcion articulo:"
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "DsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsArticulos
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosBindingNavigator
        '
        Me.ArticulosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ArticulosBindingNavigator.BindingSource = Me.ArticulosBindingSource
        Me.ArticulosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ArticulosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ArticulosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ArticulosBindingNavigatorSaveItem})
        Me.ArticulosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ArticulosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ArticulosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ArticulosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ArticulosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ArticulosBindingNavigator.Name = "ArticulosBindingNavigator"
        Me.ArticulosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ArticulosBindingNavigator.Size = New System.Drawing.Size(509, 25)
        Me.ArticulosBindingNavigator.TabIndex = 0
        Me.ArticulosBindingNavigator.Text = "BindingNavigator1"
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
        'ArticulosBindingNavigatorSaveItem
        '
        Me.ArticulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArticulosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ArticulosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ArticulosBindingNavigatorSaveItem.Name = "ArticulosBindingNavigatorSaveItem"
        Me.ArticulosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ArticulosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdArticuloTextBox
        '
        Me.IdArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "IdArticulo", True))
        Me.IdArticuloTextBox.Enabled = False
        Me.IdArticuloTextBox.Location = New System.Drawing.Point(80, 22)
        Me.IdArticuloTextBox.Name = "IdArticuloTextBox"
        Me.IdArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdArticuloTextBox.TabIndex = 2
        '
        'DsArticulosdetalle
        '
        Me.DsArticulosdetalle.DataSetName = "DsArticulosdetalle"
        Me.DsArticulosdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosDetalleBindingSource
        '
        Me.ArticulosDetalleBindingSource.DataMember = "ArticulosDetalle"
        Me.ArticulosDetalleBindingSource.DataSource = Me.DsArticulosdetalle
        '
        'ArticulosDetalleTableAdapter
        '
        Me.ArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosDetalleDataGridView
        '
        Me.ArticulosDetalleDataGridView.AllowUserToAddRows = False
        Me.ArticulosDetalleDataGridView.AllowUserToDeleteRows = False
        Me.ArticulosDetalleDataGridView.AutoGenerateColumns = False
        Me.ArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ArticulosDetalleDataGridView.DataSource = Me.ArticulosDetalleBindingSource
        Me.ArticulosDetalleDataGridView.Location = New System.Drawing.Point(20, 103)
        Me.ArticulosDetalleDataGridView.Name = "ArticulosDetalleDataGridView"
        Me.ArticulosDetalleDataGridView.ReadOnly = True
        Me.ArticulosDetalleDataGridView.Size = New System.Drawing.Size(433, 220)
        Me.ArticulosDetalleDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Detalle_Articulos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Detalle_Articulos"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Articulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Articulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.SubArticulosBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id_Sub_Articulo"
        '
        'SubArticulosBindingSource
        '
        Me.SubArticulosBindingSource.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource.DataSource = Me.DsSubArticulos
        '
        'DsSubArticulos
        '
        Me.DsSubArticulos.DataSetName = "DsSubArticulos"
        Me.DsSubArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "M2Pintura"
        Me.DataGridViewTextBoxColumn6.HeaderText = "M2Pintura"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "HorasTrabajoTallerTotal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "HorasTrabajoTallerTotal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "M2Pinturatota"
        Me.DataGridViewTextBoxColumn8.HeaderText = "M2Pinturatota"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad a Añadir"
        '
        'Descripcion_articuloTextBox
        '
        Me.Descripcion_articuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion_articulo", True))
        Me.Descripcion_articuloTextBox.Enabled = False
        Me.Descripcion_articuloTextBox.Location = New System.Drawing.Point(121, 51)
        Me.Descripcion_articuloTextBox.Name = "Descripcion_articuloTextBox"
        Me.Descripcion_articuloTextBox.Size = New System.Drawing.Size(308, 20)
        Me.Descripcion_articuloTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DsNotasEntregaDetalle
        '
        Me.DsNotasEntregaDetalle.DataSetName = "DsNotasEntregaDetalle"
        Me.DsNotasEntregaDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotasEntregaDetalleBindingSource
        '
        Me.NotasEntregaDetalleBindingSource.DataMember = "NotasEntregaDetalle"
        Me.NotasEntregaDetalleBindingSource.DataSource = Me.DsNotasEntregaDetalle
        '
        'NotasEntregaDetalleTableAdapter
        '
        Me.NotasEntregaDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.NotasEntregaDetalleTableAdapter = Me.NotasEntregaDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsEstadoEntregas
        '
        Me.DsEstadoEntregas.DataSetName = "DsEstadoEntregas"
        Me.DsEstadoEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoentregasBindingSource
        '
        Me.EstadoentregasBindingSource.DataMember = "Estadoentregas"
        Me.EstadoentregasBindingSource.DataSource = Me.DsEstadoEntregas
        '
        'EstadoentregasTableAdapter
        '
        Me.EstadoentregasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetalleHerrajes
        '
        Me.DsPresupuestoDetalleHerrajes.DataSetName = "DsPresupuestoDetalleHerrajes"
        Me.DsPresupuestoDetalleHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleHerrajesBindingSource
        '
        Me.PresupuestoDetalleHerrajesBindingSource.DataMember = "PresupuestoDetalleHerrajes"
        Me.PresupuestoDetalleHerrajesBindingSource.DataSource = Me.DsPresupuestoDetalleHerrajes
        '
        'PresupuestoDetalleHerrajesTableAdapter
        '
        Me.PresupuestoDetalleHerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.PresupuestoDetalleHerrajesTableAdapter = Nothing
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmKtCompleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 346)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Descripcion_articuloLabel)
        Me.Controls.Add(Me.Descripcion_articuloTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ArticulosDetalleDataGridView)
        Me.Controls.Add(IdArticuloLabel)
        Me.Controls.Add(Me.IdArticuloTextBox)
        Me.Controls.Add(Me.ArticulosBindingNavigator)
        Me.Name = "FrmKtCompleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmKtCompleto"
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArticulosBindingNavigator.ResumeLayout(False)
        Me.ArticulosBindingNavigator.PerformLayout()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNotasEntregaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ArticulosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Descripcion_articuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DsNotasEntregaDetalle As ModuloGestion.DsNotasEntregaDetalle
    Friend WithEvents NotasEntregaDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaDetalleTableAdapter As ModuloGestion.DsNotasEntregaDetalleTableAdapters.NotasEntregaDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsEstadoEntregas As ModuloGestion.DsEstadoEntregas
    Friend WithEvents EstadoentregasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoentregasTableAdapter As ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleHerrajes As ModuloGestion.DsPresupuestoDetalleHerrajes
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager
End Class
