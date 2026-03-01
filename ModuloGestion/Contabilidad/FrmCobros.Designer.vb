<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCobros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCobros))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.PagosClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PagosClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PagosClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.DsPagosClientesDetalle = New ModuloGestion.DsPagosClientesDetalle()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager()
        Me.PagosClientesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ID_Cobro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Fiscal = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.US = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteAsignar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagosClientesBindingNavigator.SuspendLayout()
        CType(Me.PagosClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesBindingSource
        '
        Me.PagosClientesBindingSource.DataMember = "PagosClientes"
        Me.PagosClientesBindingSource.DataSource = Me.DsPagosClientes
        '
        'PagosClientesTableAdapter
        '
        Me.PagosClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesBindingNavigator
        '
        Me.PagosClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PagosClientesBindingNavigator.BindingSource = Me.PagosClientesBindingSource
        Me.PagosClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PagosClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PagosClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PagosClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PagosClientesBindingNavigatorSaveItem})
        Me.PagosClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PagosClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PagosClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PagosClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PagosClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PagosClientesBindingNavigator.Name = "PagosClientesBindingNavigator"
        Me.PagosClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PagosClientesBindingNavigator.Size = New System.Drawing.Size(1580, 31)
        Me.PagosClientesBindingNavigator.TabIndex = 0
        Me.PagosClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 26)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'PagosClientesBindingNavigatorSaveItem
        '
        Me.PagosClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagosClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PagosClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PagosClientesBindingNavigatorSaveItem.Name = "PagosClientesBindingNavigatorSaveItem"
        Me.PagosClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 26)
        Me.PagosClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PagosClientesDataGridView
        '
        Me.PagosClientesDataGridView.AllowUserToAddRows = False
        Me.PagosClientesDataGridView.AllowUserToDeleteRows = False
        Me.PagosClientesDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Cobro, Me.DataGridViewTextBoxColumn2, Me.Id_Fiscal, Me.Fecha, Me.DataGridViewTextBoxColumn4, Me.Moneda, Me.RD, Me.US, Me.Asignado, Me.PendienteAsignar, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PagosClientesDataGridView.DataSource = Me.PagosClientesBindingSource
        Me.PagosClientesDataGridView.Location = New System.Drawing.Point(18, 155)
        Me.PagosClientesDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PagosClientesDataGridView.Name = "PagosClientesDataGridView"
        Me.PagosClientesDataGridView.ReadOnly = True
        Me.PagosClientesDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDataGridView.Size = New System.Drawing.Size(1513, 339)
        Me.PagosClientesDataGridView.TabIndex = 1
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsClientesBindingSource
        '
        'DsClientesBindingSource
        '
        Me.DsClientesBindingSource.DataSource = Me.DsClientes
        Me.DsClientesBindingSource.Position = 0
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "DsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsPagosClientesDetalle
        '
        Me.DsPagosClientesDetalle.DataSetName = "DsPagosClientesDetalle"
        Me.DsPagosClientesDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsPagosClientesDetalle
        '
        'PagosClientesDetalleTableAdapter
        '
        Me.PagosClientesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PagosClientesDetalleTableAdapter = Me.PagosClientesDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesDetalleDataGridView
        '
        Me.PagosClientesDetalleDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.TotalPagado, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.PagosClientesDetalleDataGridView.DataSource = Me.PagosClientesDetalleBindingSource
        Me.PagosClientesDetalleDataGridView.Location = New System.Drawing.Point(15, 526)
        Me.PagosClientesDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PagosClientesDetalleDataGridView.Name = "PagosClientesDetalleDataGridView"
        Me.PagosClientesDetalleDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDetalleDataGridView.Size = New System.Drawing.Size(1151, 201)
        Me.PagosClientesDetalleDataGridView.TabIndex = 2
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 111)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Imprimir Recibo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(847, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Rd$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(951, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(847, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total US$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(951, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1380, 526)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Label5"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1118, 106)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(246, 35)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Listado Pagos Fecha"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(429, 111)
        Me.cmbAño.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(136, 28)
        Me.cmbAño.TabIndex = 11
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(637, 111)
        Me.cmbMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(136, 28)
        Me.cmbMes.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Año"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(644, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Mes"
        '
        'ID_Cobro
        '
        Me.ID_Cobro.DataPropertyName = "ID_Cobro"
        Me.ID_Cobro.HeaderText = "ID_Cobro"
        Me.ID_Cobro.MinimumWidth = 6
        Me.ID_Cobro.Name = "ID_Cobro"
        Me.ID_Cobro.ReadOnly = True
        Me.ID_Cobro.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Fiscal"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Fiscal"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'Id_Fiscal
        '
        Me.Id_Fiscal.DataPropertyName = "Id_Fiscal"
        Me.Id_Fiscal.DataSource = Me.ClientesBindingSource
        Me.Id_Fiscal.DisplayMember = "Nombre_Cliente"
        Me.Id_Fiscal.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Id_Fiscal.HeaderText = "Razon Social"
        Me.Id_Fiscal.MinimumWidth = 6
        Me.Id_Fiscal.Name = "Id_Fiscal"
        Me.Id_Fiscal.ReadOnly = True
        Me.Id_Fiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Fiscal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Id_Fiscal.ValueMember = "Id_Fiscal"
        Me.Id_Fiscal.Width = 150
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle6
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.MinimumWidth = 6
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Width = 60
        '
        'RD
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.RD.DefaultCellStyle = DataGridViewCellStyle7
        Me.RD.HeaderText = "RD"
        Me.RD.MinimumWidth = 6
        Me.RD.Name = "RD"
        Me.RD.ReadOnly = True
        Me.RD.Width = 75
        '
        'US
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.US.DefaultCellStyle = DataGridViewCellStyle8
        Me.US.HeaderText = "US"
        Me.US.MinimumWidth = 6
        Me.US.Name = "US"
        Me.US.ReadOnly = True
        Me.US.Width = 75
        '
        'Asignado
        '
        Me.Asignado.DataPropertyName = "Asignado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.Asignado.DefaultCellStyle = DataGridViewCellStyle9
        Me.Asignado.HeaderText = "Asignado"
        Me.Asignado.MinimumWidth = 6
        Me.Asignado.Name = "Asignado"
        Me.Asignado.ReadOnly = True
        Me.Asignado.Width = 75
        '
        'PendienteAsignar
        '
        Me.PendienteAsignar.DataPropertyName = "PendienteAsignar"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.PendienteAsignar.DefaultCellStyle = DataGridViewCellStyle10
        Me.PendienteAsignar.HeaderText = "Sin Asignar"
        Me.PendienteAsignar.MinimumWidth = 6
        Me.PendienteAsignar.Name = "PendienteAsignar"
        Me.PendienteAsignar.ReadOnly = True
        Me.PendienteAsignar.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id_Empresa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id_Empresa"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FormaDePago"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FormaDePago"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IdPagoClientesDetalle"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID_Cobro"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID_Cobro"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'TotalPagado
        '
        Me.TotalPagado.DataPropertyName = "TotalPagado"
        Me.TotalPagado.HeaderText = "TotalPagado"
        Me.TotalPagado.MinimumWidth = 6
        Me.TotalPagado.Name = "TotalPagado"
        Me.TotalPagado.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IdFactura"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IdFactura"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'FrmCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 846)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PagosClientesDetalleDataGridView)
        Me.Controls.Add(Me.PagosClientesDataGridView)
        Me.Controls.Add(Me.PagosClientesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCobros"
        Me.Text = "FrmCobros"
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagosClientesBindingNavigator.ResumeLayout(False)
        Me.PagosClientesBindingNavigator.PerformLayout()
        CType(Me.PagosClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PagosClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PagosClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsPagosClientesDetalle As ModuloGestion.DsPagosClientesDetalle
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsClientes As ModuloGestion.DsClientes
    Friend WithEvents DsClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ID_Cobro As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Id_Fiscal As DataGridViewComboBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents RD As DataGridViewTextBoxColumn
    Friend WithEvents US As DataGridViewTextBoxColumn
    Friend WithEvents Asignado As DataGridViewTextBoxColumn
    Friend WithEvents PendienteAsignar As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
End Class
