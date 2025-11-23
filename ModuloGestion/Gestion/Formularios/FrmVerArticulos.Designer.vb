<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerArticulos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsModeloArticulos = New ModuloGestion.DsModeloArticulos()
        Me.ModeloArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModeloArticuloTableAdapter = New ModuloGestion.DsModeloArticulosTableAdapters.ModeloArticuloTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsModeloArticulosTableAdapters.TableAdapterManager()
        Me.ModeloArticuloBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ModeloArticuloBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CmdAgregarpresupuesto = New System.Windows.Forms.Button()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.btnverarticulo = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.TotalFerreteriaArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTotalFerreteriaArticulo = New ModuloGestion.DsTotalFerreteriaArticulo()
        Me.TotalFerreteriaArticuloTableAdapter = New ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TotalFerreteriaArticuloTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalleferreteria = New ModuloGestion.DsPresupuestoDetalleferreteria()
        Me.PresupuestoDetalleFerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleFerreteriaTableAdapter = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.ArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Ajustado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPartida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsModeloArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloArticuloBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModeloArticuloBindingNavigator.SuspendLayout()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFerreteriaArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTotalFerreteriaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsModeloArticulos
        '
        Me.DsModeloArticulos.DataSetName = "DsModeloArticulos"
        Me.DsModeloArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModeloArticuloBindingSource
        '
        Me.ModeloArticuloBindingSource.DataMember = "ModeloArticulo"
        Me.ModeloArticuloBindingSource.DataSource = Me.DsModeloArticulos
        '
        'ModeloArticuloTableAdapter
        '
        Me.ModeloArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ModeloArticuloTableAdapter = Me.ModeloArticuloTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsModeloArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ModeloArticuloBindingNavigator
        '
        Me.ModeloArticuloBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ModeloArticuloBindingNavigator.BindingSource = Me.ModeloArticuloBindingSource
        Me.ModeloArticuloBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ModeloArticuloBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ModeloArticuloBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ModeloArticuloBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ModeloArticuloBindingNavigatorSaveItem})
        Me.ModeloArticuloBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ModeloArticuloBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ModeloArticuloBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ModeloArticuloBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ModeloArticuloBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ModeloArticuloBindingNavigator.Name = "ModeloArticuloBindingNavigator"
        Me.ModeloArticuloBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ModeloArticuloBindingNavigator.Size = New System.Drawing.Size(1572, 27)
        Me.ModeloArticuloBindingNavigator.TabIndex = 0
        Me.ModeloArticuloBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ModeloArticuloBindingNavigatorSaveItem
        '
        Me.ModeloArticuloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ModeloArticuloBindingNavigatorSaveItem.Image = CType(resources.GetObject("ModeloArticuloBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ModeloArticuloBindingNavigatorSaveItem.Name = "ModeloArticuloBindingNavigatorSaveItem"
        Me.ModeloArticuloBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ModeloArticuloBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CmdAgregarpresupuesto
        '
        Me.CmdAgregarpresupuesto.Location = New System.Drawing.Point(792, 79)
        Me.CmdAgregarpresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAgregarpresupuesto.Name = "CmdAgregarpresupuesto"
        Me.CmdAgregarpresupuesto.Size = New System.Drawing.Size(171, 28)
        Me.CmdAgregarpresupuesto.TabIndex = 6
        Me.CmdAgregarpresupuesto.Text = "Agregar Al Presupuesto"
        Me.CmdAgregarpresupuesto.UseVisualStyleBackColor = True
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.AllowUserToAddRows = False
        Me.ArticulosDataGridView.AutoGenerateColumns = False
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ArticulosDataGridView.DataSource = Me.ArticulosBindingSource
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(67, 116)
        Me.ArticulosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.RowHeadersWidth = 51
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(1057, 377)
        Me.ArticulosDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Articulo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "DsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnverarticulo
        '
        Me.btnverarticulo.Location = New System.Drawing.Point(613, 81)
        Me.btnverarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnverarticulo.Name = "btnverarticulo"
        Me.btnverarticulo.Size = New System.Drawing.Size(171, 28)
        Me.btnverarticulo.TabIndex = 7
        Me.btnverarticulo.Text = "Ver Detalle"
        Me.btnverarticulo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(357, 81)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar por descripcion"
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
        'TotalFerreteriaArticuloBindingSource
        '
        Me.TotalFerreteriaArticuloBindingSource.DataMember = "TotalFerreteriaArticulo"
        Me.TotalFerreteriaArticuloBindingSource.DataSource = Me.DsTotalFerreteriaArticulo
        '
        'DsTotalFerreteriaArticulo
        '
        Me.DsTotalFerreteriaArticulo.DataSetName = "DsTotalFerreteriaArticulo"
        Me.DsTotalFerreteriaArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalFerreteriaArticuloTableAdapter
        '
        Me.TotalFerreteriaArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetalleferreteria
        '
        Me.DsPresupuestoDetalleferreteria.DataSetName = "DsPresupuestoDetalleferreteria"
        Me.DsPresupuestoDetalleferreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleFerreteriaBindingSource
        '
        Me.PresupuestoDetalleFerreteriaBindingSource.DataMember = "PresupuestoDetalleFerreteria"
        Me.PresupuestoDetalleFerreteriaBindingSource.DataSource = Me.DsPresupuestoDetalleferreteria
        '
        'PresupuestoDetalleFerreteriaTableAdapter
        '
        Me.PresupuestoDetalleFerreteriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PresupuestoDetalleFerreteriaTableAdapter = Me.PresupuestoDetalleFerreteriaTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosDetalleDataGridView
        '
        Me.ArticulosDetalleDataGridView.AllowUserToAddRows = False
        Me.ArticulosDetalleDataGridView.AllowUserToDeleteRows = False
        Me.ArticulosDetalleDataGridView.AutoGenerateColumns = False
        Me.ArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ArticulosDetalleDataGridView.DataSource = Me.ArticulosDetalleBindingSource
        Me.ArticulosDetalleDataGridView.Location = New System.Drawing.Point(1132, 116)
        Me.ArticulosDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ArticulosDetalleDataGridView.Name = "ArticulosDetalleDataGridView"
        Me.ArticulosDetalleDataGridView.ReadOnly = True
        Me.ArticulosDetalleDataGridView.RowHeadersWidth = 51
        Me.ArticulosDetalleDataGridView.Size = New System.Drawing.Size(400, 377)
        Me.ArticulosDetalleDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.SubArticulosBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Id_Sub_Articulo"
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 74
        '
        'oOpenFileDialog
        '
        Me.oOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'DsPresupuestoDetalle
        '
        Me.DsPresupuestoDetalle.DataSetName = "DsPresupuestoDetalle"
        Me.DsPresupuestoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsPresupuestoDetalle
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Id_Proyecto, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.Cantidad, Me.Precio_Ajustado, Me.TotalPartida})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(103, 512)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.RowTemplate.Height = 24
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(1233, 220)
        Me.PresupuestoDetalleDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Articulo"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Id_Proyecto
        '
        Me.Id_Proyecto.DataPropertyName = "Id_Proyecto"
        Me.Id_Proyecto.HeaderText = "Id_Proyecto"
        Me.Id_Proyecto.MinimumWidth = 6
        Me.Id_Proyecto.Name = "Id_Proyecto"
        Me.Id_Proyecto.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Presupuesto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 125
        '
        'Precio_Ajustado
        '
        Me.Precio_Ajustado.DataPropertyName = "Precio_Ajustado"
        Me.Precio_Ajustado.HeaderText = "Precio_Ajustado"
        Me.Precio_Ajustado.MinimumWidth = 6
        Me.Precio_Ajustado.Name = "Precio_Ajustado"
        Me.Precio_Ajustado.Width = 125
        '
        'TotalPartida
        '
        Me.TotalPartida.DataPropertyName = "TotalPartida"
        Me.TotalPartida.HeaderText = "TotalPartida"
        Me.TotalPartida.MinimumWidth = 6
        Me.TotalPartida.Name = "TotalPartida"
        Me.TotalPartida.Width = 125
        '
        'FrmVerArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1572, 752)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.ArticulosDetalleDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnverarticulo)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Controls.Add(Me.CmdAgregarpresupuesto)
        Me.Controls.Add(Me.ModeloArticuloBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVerArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVerArticulos"
        CType(Me.DsModeloArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloArticuloBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModeloArticuloBindingNavigator.ResumeLayout(False)
        Me.ModeloArticuloBindingNavigator.PerformLayout()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFerreteriaArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTotalFerreteriaArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsModeloArticulos As ModuloGestion.DsModeloArticulos
    Friend WithEvents ModeloArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModeloArticuloTableAdapter As ModuloGestion.DsModeloArticulosTableAdapters.ModeloArticuloTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsModeloArticulosTableAdapters.TableAdapterManager
    Friend WithEvents ModeloArticuloBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ModeloArticuloBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents CmdAgregarpresupuesto As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnverarticulo As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsTotalFerreteriaArticulo As ModuloGestion.DsTotalFerreteriaArticulo
    Friend WithEvents TotalFerreteriaArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalFerreteriaArticuloTableAdapter As ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TotalFerreteriaArticuloTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleferreteria As ModuloGestion.DsPresupuestoDetalleferreteria
    Friend WithEvents PresupuestoDetalleFerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleFerreteriaTableAdapter As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents oOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPresupuestoDetalle As DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager5 As DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Id_Proyecto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Ajustado As DataGridViewTextBoxColumn
    Friend WithEvents TotalPartida As DataGridViewTextBoxColumn
End Class
