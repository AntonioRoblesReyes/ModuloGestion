<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsumosArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsumosArticulo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsConsumoArticulosResumen = New ModuloGestion.DsConsumoArticulosResumen()
        Me.DsConsumoMaterialArticulo1TotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsumoMaterialArticulo1TotalTableAdapter = New ModuloGestion.DsConsumoArticulosResumenTableAdapters.DsConsumoMaterialArticulo1TotalTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsConsumoArticulosResumenTableAdapters.TableAdapterManager()
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DsConsumoMaterialArticulo1TotalDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Medida = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.IdArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_articuloTextBox = New System.Windows.Forms.TextBox()
        IdArticuloLabel = New System.Windows.Forms.Label()
        CType(Me.DsConsumoArticulosResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsumoMaterialArticulo1TotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsumoMaterialArticulo1TotalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.SuspendLayout()
        CType(Me.DsConsumoMaterialArticulo1TotalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdArticuloLabel
        '
        IdArticuloLabel.AutoSize = True
        IdArticuloLabel.Location = New System.Drawing.Point(39, 41)
        IdArticuloLabel.Name = "IdArticuloLabel"
        IdArticuloLabel.Size = New System.Drawing.Size(57, 13)
        IdArticuloLabel.TabIndex = 2
        IdArticuloLabel.Text = "Id Articulo:"
        '
        'DsConsumoArticulosResumen
        '
        Me.DsConsumoArticulosResumen.DataSetName = "DsConsumoArticulosResumen"
        Me.DsConsumoArticulosResumen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsConsumoMaterialArticulo1TotalBindingSource
        '
        Me.DsConsumoMaterialArticulo1TotalBindingSource.DataMember = "DsConsumoMaterialArticulo1Total"
        Me.DsConsumoMaterialArticulo1TotalBindingSource.DataSource = Me.DsConsumoArticulosResumen
        '
        'DsConsumoMaterialArticulo1TotalTableAdapter
        '
        Me.DsConsumoMaterialArticulo1TotalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsConsumoArticulosResumenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsConsumoMaterialArticulo1TotalBindingNavigator
        '
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.BindingSource = Me.DsConsumoMaterialArticulo1TotalBindingSource
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem})
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.Name = "DsConsumoMaterialArticulo1TotalBindingNavigator"
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.Size = New System.Drawing.Size(887, 25)
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.TabIndex = 0
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.Text = "BindingNavigator1"
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
        'DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem
        '
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.Enabled = False
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.Image = CType(resources.GetObject("DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.Name = "DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem"
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DsConsumoMaterialArticulo1TotalDataGridView
        '
        Me.DsConsumoMaterialArticulo1TotalDataGridView.AutoGenerateColumns = False
        Me.DsConsumoMaterialArticulo1TotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsConsumoMaterialArticulo1TotalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Articulo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Id_Medida})
        Me.DsConsumoMaterialArticulo1TotalDataGridView.DataSource = Me.DsConsumoMaterialArticulo1TotalBindingSource
        Me.DsConsumoMaterialArticulo1TotalDataGridView.Location = New System.Drawing.Point(12, 90)
        Me.DsConsumoMaterialArticulo1TotalDataGridView.Name = "DsConsumoMaterialArticulo1TotalDataGridView"
        Me.DsConsumoMaterialArticulo1TotalDataGridView.Size = New System.Drawing.Size(853, 264)
        Me.DsConsumoMaterialArticulo1TotalDataGridView.TabIndex = 1
        '
        'Id_Articulo
        '
        Me.Id_Articulo.DataPropertyName = "Id_Articulo"
        Me.Id_Articulo.HeaderText = "Id_Articulo"
        Me.Id_Articulo.Name = "Id_Articulo"
        Me.Id_Articulo.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.MaterilaesDetalleBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'MaterilaesDetalleBindingSource
        '
        Me.MaterilaesDetalleBindingSource.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource.DataSource = Me.DsMaterialDetalle
        '
        'DsMaterialDetalle
        '
        Me.DsMaterialDetalle.DataSetName = "DsMaterialDetalle"
        Me.DsMaterialDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ConsumoTotal"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Consumo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DesperdicioMaterial"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "## %"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Desperdicio Material"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TotalDesperdicio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Desperdicio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalCompra"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Compra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Id_Medida
        '
        Me.Id_Medida.DataPropertyName = "Id_Medida"
        Me.Id_Medida.DataSource = Me.MedidasCompraBindingSource
        Me.Id_Medida.DisplayMember = "Descripcion_Medida"
        Me.Id_Medida.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Id_Medida.HeaderText = "Medida Cmpra"
        Me.Id_Medida.Name = "Id_Medida"
        Me.Id_Medida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Id_Medida.ValueMember = "Id_Medida"
        Me.Id_Medida.Width = 200
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
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdArticuloTextBox
        '
        Me.IdArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "IdArticulo", True))
        Me.IdArticuloTextBox.Location = New System.Drawing.Point(102, 38)
        Me.IdArticuloTextBox.Name = "IdArticuloTextBox"
        Me.IdArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdArticuloTextBox.TabIndex = 3
        '
        'Descripcion_articuloTextBox
        '
        Me.Descripcion_articuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion_articulo", True))
        Me.Descripcion_articuloTextBox.Location = New System.Drawing.Point(208, 38)
        Me.Descripcion_articuloTextBox.Multiline = True
        Me.Descripcion_articuloTextBox.Name = "Descripcion_articuloTextBox"
        Me.Descripcion_articuloTextBox.Size = New System.Drawing.Size(379, 46)
        Me.Descripcion_articuloTextBox.TabIndex = 5
        '
        'FrmConsumosArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 379)
        Me.Controls.Add(Me.Descripcion_articuloTextBox)
        Me.Controls.Add(IdArticuloLabel)
        Me.Controls.Add(Me.IdArticuloTextBox)
        Me.Controls.Add(Me.DsConsumoMaterialArticulo1TotalDataGridView)
        Me.Controls.Add(Me.DsConsumoMaterialArticulo1TotalBindingNavigator)
        Me.Name = "FrmConsumosArticulo"
        Me.Text = "FrmConsumosArticulo"
        CType(Me.DsConsumoArticulosResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsumoMaterialArticulo1TotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsumoMaterialArticulo1TotalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.ResumeLayout(False)
        Me.DsConsumoMaterialArticulo1TotalBindingNavigator.PerformLayout()
        CType(Me.DsConsumoMaterialArticulo1TotalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsConsumoArticulosResumen As ModuloGestion.DsConsumoArticulosResumen
    Friend WithEvents DsConsumoMaterialArticulo1TotalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsConsumoMaterialArticulo1TotalTableAdapter As ModuloGestion.DsConsumoArticulosResumenTableAdapters.DsConsumoMaterialArticulo1TotalTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsConsumoArticulosResumenTableAdapters.TableAdapterManager
    Friend WithEvents DsConsumoMaterialArticulo1TotalBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DsConsumoMaterialArticulo1TotalBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DsConsumoMaterialArticulo1TotalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Medida As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents IdArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion_articuloTextBox As System.Windows.Forms.TextBox
End Class
