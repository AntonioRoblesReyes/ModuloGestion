<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCuentasPorPagar
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ModuloGestion.DsComprasTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.CompraMaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LabelTotalGeneralRD = New System.Windows.Forms.Label()
        Me.LabelTotalGeneralUS = New System.Windows.Forms.Label()
        Me.LabelTotalSeleccionRD = New System.Windows.Forms.Label()
        Me.LabelTotalSeleccionUS = New System.Windows.Forms.Label()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.LabelBuscarProveedor = New System.Windows.Forms.Label()
        Me.TxtBuscarProveedor = New System.Windows.Forms.TextBox()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.PanelTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsCompras
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraMaterialesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedoresBindingNavigatorSaveItem})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(1543, 31)
        Me.ProveedoresBindingNavigator.TabIndex = 0
        Me.ProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
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
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        'ProveedoresBindingNavigatorSaveItem
        '
        Me.ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedoresBindingNavigatorSaveItem.Name = "ProveedoresBindingNavigatorSaveItem"
        Me.ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AllowUserToAddRows = False
        Me.ProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProveedoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Proveedor, Me.DataGridViewTextBoxColumn2})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(0, 58)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.ReadOnly = True
        Me.ProveedoresDataGridView.RowHeadersWidth = 51
        Me.ProveedoresDataGridView.RowTemplate.Height = 24
        Me.ProveedoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(450, 538)
        Me.ProveedoresDataGridView.TabIndex = 1
        '
        'Id_Proveedor
        '
        Me.Id_Proveedor.DataPropertyName = "Id_Proveedor"
        Me.Id_Proveedor.HeaderText = "Id_Proveedor"
        Me.Id_Proveedor.MinimumWidth = 6
        Me.Id_Proveedor.Name = "Id_Proveedor"
        Me.Id_Proveedor.ReadOnly = True
        Me.Id_Proveedor.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón social"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CompraMaterialesBindingSource
        '
        Me.CompraMaterialesBindingSource.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource.DataSource = Me.DsCompras
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '
        'CompraMaterialesDataGridView
        '
        Me.CompraMaterialesDataGridView.AllowUserToAddRows = False
        Me.CompraMaterialesDataGridView.AllowUserToDeleteRows = False
        Me.CompraMaterialesDataGridView.AllowUserToOrderColumns = True
        Me.CompraMaterialesDataGridView.AutoGenerateColumns = False
        Me.CompraMaterialesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CompraMaterialesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CompraMaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompraMaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Compra, Me.Proveedor, Me.Fecha, Me.Factura, Me.Moneda, Me.TotalUS, Me.DataGridViewTextBoxColumn24, Me.PendienteUS, Me.TotalRD, Me.DataGridViewTextBoxColumn26, Me.PendienteRD, Me.Pagar})
        Me.CompraMaterialesDataGridView.DataSource = Me.CompraMaterialesBindingSource
        Me.CompraMaterialesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompraMaterialesDataGridView.Location = New System.Drawing.Point(10, 10)
        Me.CompraMaterialesDataGridView.Name = "CompraMaterialesDataGridView"
        Me.CompraMaterialesDataGridView.RowHeadersWidth = 51
        Me.CompraMaterialesDataGridView.RowTemplate.Height = 24
        Me.CompraMaterialesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompraMaterialesDataGridView.Size = New System.Drawing.Size(1069, 543)
        Me.CompraMaterialesDataGridView.TabIndex = 2
        '
        'Id_Compra
        '
        Me.Id_Compra.DataPropertyName = "Id_Compra"
        Me.Id_Compra.HeaderText = "Id_Compra"
        Me.Id_Compra.MinimumWidth = 6
        Me.Id_Compra.Name = "Id_Compra"
        Me.Id_Compra.ReadOnly = True
        Me.Id_Compra.Width = 75
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Id_Proveedor"
        Me.Proveedor.HeaderText = "Id_Proveedor"
        Me.Proveedor.MinimumWidth = 6
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 75
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha_Compra"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 90
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "FacturaProveedor"
        Me.Factura.HeaderText = "Factura"
        Me.Factura.MinimumWidth = 6
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        Me.Factura.Width = 125
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.MinimumWidth = 6
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Width = 75
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalCompraUS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalUS.HeaderText = "Total US"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.ReadOnly = True
        Me.TotalUS.Width = 90
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PagadoUS"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn24.HeaderText = "Pagado US"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 90
        '
        'PendienteUS
        '
        Me.PendienteUS.DataPropertyName = "PendienteUS"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.PendienteUS.DefaultCellStyle = DataGridViewCellStyle9
        Me.PendienteUS.HeaderText = "Pendiente US"
        Me.PendienteUS.MinimumWidth = 6
        Me.PendienteUS.Name = "PendienteUS"
        Me.PendienteUS.ReadOnly = True
        Me.PendienteUS.Width = 125
        '
        'TotalRD
        '
        Me.TotalRD.DataPropertyName = "TotalCompraRD"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.TotalRD.DefaultCellStyle = DataGridViewCellStyle10
        Me.TotalRD.HeaderText = "Total RD"
        Me.TotalRD.MinimumWidth = 6
        Me.TotalRD.Name = "TotalRD"
        Me.TotalRD.ReadOnly = True
        Me.TotalRD.Width = 90
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "PagadoRD"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn26.HeaderText = "Pagado RD"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 90
        '
        'PendienteRD
        '
        Me.PendienteRD.DataPropertyName = "PendienteRD"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.PendienteRD.DefaultCellStyle = DataGridViewCellStyle12
        Me.PendienteRD.HeaderText = "Pendiente RD"
        Me.PendienteRD.MinimumWidth = 6
        Me.PendienteRD.Name = "PendienteRD"
        Me.PendienteRD.ReadOnly = True
        Me.PendienteRD.Width = 90
        '
        'Pagar
        '
        Me.Pagar.HeaderText = "Pagar"
        Me.Pagar.MinimumWidth = 6
        Me.Pagar.Name = "Pagar"
        Me.Pagar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Pagar.Width = 75
        '
        'LabelTotalGeneralRD
        '
        Me.LabelTotalGeneralRD.AutoSize = True
        Me.LabelTotalGeneralRD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalGeneralRD.Location = New System.Drawing.Point(15, 10)
        Me.LabelTotalGeneralRD.Name = "LabelTotalGeneralRD"
        Me.LabelTotalGeneralRD.Size = New System.Drawing.Size(125, 20)
        Me.LabelTotalGeneralRD.TabIndex = 3
        Me.LabelTotalGeneralRD.Text = "Total general RD"
        '
        'LabelTotalGeneralUS
        '
        Me.LabelTotalGeneralUS.AutoSize = True
        Me.LabelTotalGeneralUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalGeneralUS.Location = New System.Drawing.Point(15, 35)
        Me.LabelTotalGeneralUS.Name = "LabelTotalGeneralUS"
        Me.LabelTotalGeneralUS.Size = New System.Drawing.Size(123, 20)
        Me.LabelTotalGeneralUS.TabIndex = 4
        Me.LabelTotalGeneralUS.Text = "Total general US"
        '
        'LabelTotalSeleccionRD
        '
        Me.LabelTotalSeleccionRD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTotalSeleccionRD.AutoSize = True
        Me.LabelTotalSeleccionRD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalSeleccionRD.Location = New System.Drawing.Point(680, 10)
        Me.LabelTotalSeleccionRD.Name = "LabelTotalSeleccionRD"
        Me.LabelTotalSeleccionRD.Size = New System.Drawing.Size(100, 20)
        Me.LabelTotalSeleccionRD.TabIndex = 6
        Me.LabelTotalSeleccionRD.Text = "Total a pagar"
        '
        'LabelTotalSeleccionUS
        '
        Me.LabelTotalSeleccionUS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTotalSeleccionUS.AutoSize = True
        Me.LabelTotalSeleccionUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalSeleccionUS.Location = New System.Drawing.Point(680, 35)
        Me.LabelTotalSeleccionUS.Name = "LabelTotalSeleccionUS"
        Me.LabelTotalSeleccionUS.Size = New System.Drawing.Size(100, 20)
        Me.LabelTotalSeleccionUS.TabIndex = 7
        Me.LabelTotalSeleccionUS.Text = "Total a pagar"
        '
        'BtnPagar
        '
        Me.BtnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnPagar.Location = New System.Drawing.Point(910, 18)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(120, 32)
        Me.BtnPagar.TabIndex = 8
        Me.BtnPagar.Text = "Pagar"
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.TxtBuscarProveedor)
        Me.SplitContainerMain.Panel1.Controls.Add(Me.LabelBuscarProveedor)
        Me.SplitContainerMain.Panel1.Controls.Add(Me.ProveedoresDataGridView)
        Me.SplitContainerMain.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.CompraMaterialesDataGridView)
        Me.SplitContainerMain.Panel2.Controls.Add(Me.PanelTotales)
        Me.SplitContainerMain.Panel2.Padding = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me.SplitContainerMain.Size = New System.Drawing.Size(1543, 633)
        Me.SplitContainerMain.SplitterDistance = 450
        Me.SplitContainerMain.TabIndex = 9
        '
        'PanelTotales
        '
        Me.PanelTotales.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelTotales.Controls.Add(Me.LabelTotalGeneralRD)
        Me.PanelTotales.Controls.Add(Me.LabelTotalGeneralUS)
        Me.PanelTotales.Controls.Add(Me.LabelTotalSeleccionRD)
        Me.PanelTotales.Controls.Add(Me.LabelTotalSeleccionUS)
        Me.PanelTotales.Controls.Add(Me.BtnPagar)
        Me.PanelTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTotales.Location = New System.Drawing.Point(10, 553)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.PanelTotales.Size = New System.Drawing.Size(1069, 75)
        Me.PanelTotales.TabIndex = 10
        '
        'LabelBuscarProveedor
        '
        Me.LabelBuscarProveedor.AutoSize = True
        Me.LabelBuscarProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelBuscarProveedor.Location = New System.Drawing.Point(10, 10)
        Me.LabelBuscarProveedor.Name = "LabelBuscarProveedor"
        Me.LabelBuscarProveedor.Size = New System.Drawing.Size(114, 20)
        Me.LabelBuscarProveedor.TabIndex = 2
        Me.LabelBuscarProveedor.Text = "Buscar proveedor:"
        Me.LabelBuscarProveedor.UseCompatibleTextRendering = True
        '
        'TxtBuscarProveedor
        '
        Me.TxtBuscarProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtBuscarProveedor.Location = New System.Drawing.Point(10, 30)
        Me.TxtBuscarProveedor.Name = "TxtBuscarProveedor"
        Me.TxtBuscarProveedor.Size = New System.Drawing.Size(430, 22)
        Me.TxtBuscarProveedor.TabIndex = 3
        '
        'FrmCuentasPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1543, 664)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
        Me.Name = "FrmCuentasPorPagar"
        Me.Text = "Cuentas por pagar"
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel1.PerformLayout()
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        Me.PanelTotales.ResumeLayout(False)
        Me.PanelTotales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As DsComprasTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProveedoresDataGridView As DataGridView
    Friend WithEvents CompraMaterialesBindingSource As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents CompraMaterialesDataGridView As DataGridView
    Friend WithEvents LabelTotalGeneralRD As Label
    Friend WithEvents LabelTotalGeneralUS As Label
    Friend WithEvents LabelTotalSeleccionRD As Label
    Friend WithEvents LabelTotalSeleccionUS As Label
    Friend WithEvents BtnPagar As Button
    Friend WithEvents Id_Compra As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents PendienteUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalRD As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents PendienteRD As DataGridViewTextBoxColumn
    Friend WithEvents Pagar As DataGridViewCheckBoxColumn
    Friend WithEvents Id_Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents TxtBuscarProveedor As TextBox
    Friend WithEvents LabelBuscarProveedor As Label
End Class
