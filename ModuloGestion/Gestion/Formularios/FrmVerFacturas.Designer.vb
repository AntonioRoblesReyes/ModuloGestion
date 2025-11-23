<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerFacturas
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
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerFacturas))
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager()
        Me.EmpresasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpresasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFacturas = New ModuloGestion.DsFacturas()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.BtnNuevaFactura = New System.Windows.Forms.Button()
        Me.BtnVerFactura = New System.Windows.Forms.Button()
        Me.FacturaDetalleTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter()
        Me.IdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyecto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalUSD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaCambioRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aprobada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalRDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestolRDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasBindingNavigator.SuspendLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Enabled = False
        Id_EmpresaLabel.Location = New System.Drawing.Point(12, 38)
        Id_EmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(79, 16)
        Id_EmpresaLabel.TabIndex = 1
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Enabled = False
        NombreLabel.Location = New System.Drawing.Point(12, 70)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(59, 16)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Enabled = False
        Id_FiscalLabel.Location = New System.Drawing.Point(180, 38)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(60, 16)
        Id_FiscalLabel.TabIndex = 5
        Id_FiscalLabel.Text = "Id Fiscal:"
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
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasBindingNavigator
        '
        Me.EmpresasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasBindingNavigator.BindingSource = Me.EmpresasBindingSource
        Me.EmpresasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpresasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasBindingNavigatorSaveItem})
        Me.EmpresasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasBindingNavigator.Name = "EmpresasBindingNavigator"
        Me.EmpresasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasBindingNavigator.Size = New System.Drawing.Size(1712, 31)
        Me.EmpresasBindingNavigator.TabIndex = 0
        Me.EmpresasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
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
        'EmpresasBindingNavigatorSaveItem
        '
        Me.EmpresasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasBindingNavigatorSaveItem.Name = "EmpresasBindingNavigatorSaveItem"
        Me.EmpresasBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.EmpresasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Enabled = False
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(104, 34)
        Me.Id_EmpresaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(57, 22)
        Me.Id_EmpresaTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(104, 66)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(275, 22)
        Me.NombreTextBox.TabIndex = 4
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Enabled = False
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(247, 34)
        Me.Id_FiscalTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_FiscalTextBox.TabIndex = 6
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.ComprobantesFiscalesTableAdapter = Nothing
        Me.TableAdapterManager1.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaProformaDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaProformaTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager1.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsFacturasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AllowUserToAddRows = False
        Me.FacturaDataGridView.AllowUserToDeleteRows = False
        Me.FacturaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFactura, Me.NCF, Me.Fecha, Me.IdEmpresa, Me.IdCliente, Me.IdProyecto, Me.Moneda, Me.SubtotalUSD, Me.ValorImpuesto, Me.ImpuestoUS, Me.TotalUS, Me.TasaCambioRD, Me.TotalRDS, Me.Aprobada, Me.TipoComprobante, Me.SubTotalRDS, Me.ImpuestolRDS, Me.Pagado, Me.Pendiente})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(16, 98)
        Me.FacturaDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.ReadOnly = True
        Me.FacturaDataGridView.RowHeadersWidth = 51
        Me.FacturaDataGridView.Size = New System.Drawing.Size(1680, 290)
        Me.FacturaDataGridView.TabIndex = 7
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsClientes
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "DsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DsFacturas
        '
        'DsFacturas
        '
        Me.DsFacturas.DataSetName = "DsFacturas"
        Me.DsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsProyectos
        '
        'DsProyectos
        '
        Me.DsProyectos.DataSetName = "DsProyectos"
        Me.DsProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'BtnNuevaFactura
        '
        Me.BtnNuevaFactura.Location = New System.Drawing.Point(619, 66)
        Me.BtnNuevaFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNuevaFactura.Name = "BtnNuevaFactura"
        Me.BtnNuevaFactura.Size = New System.Drawing.Size(100, 28)
        Me.BtnNuevaFactura.TabIndex = 8
        Me.BtnNuevaFactura.Text = "Nueva Factura"
        Me.BtnNuevaFactura.UseVisualStyleBackColor = True
        '
        'BtnVerFactura
        '
        Me.BtnVerFactura.Location = New System.Drawing.Point(492, 66)
        Me.BtnVerFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnVerFactura.Name = "BtnVerFactura"
        Me.BtnVerFactura.Size = New System.Drawing.Size(100, 28)
        Me.BtnVerFactura.TabIndex = 9
        Me.BtnVerFactura.Text = "Ver Factura"
        Me.BtnVerFactura.UseVisualStyleBackColor = True
        '
        'FacturaDetalleTableAdapter
        '
        Me.FacturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'IdFactura
        '
        Me.IdFactura.DataPropertyName = "IdFactura"
        Me.IdFactura.HeaderText = "IdFactura"
        Me.IdFactura.MinimumWidth = 6
        Me.IdFactura.Name = "IdFactura"
        Me.IdFactura.ReadOnly = True
        Me.IdFactura.Width = 125
        '
        'NCF
        '
        Me.NCF.DataPropertyName = "NCF"
        Me.NCF.HeaderText = "NCF"
        Me.NCF.MinimumWidth = 6
        Me.NCF.Name = "NCF"
        Me.NCF.ReadOnly = True
        Me.NCF.Width = 125
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 125
        '
        'IdEmpresa
        '
        Me.IdEmpresa.DataPropertyName = "IdEmpresa"
        Me.IdEmpresa.HeaderText = "IdEmpresa"
        Me.IdEmpresa.MinimumWidth = 6
        Me.IdEmpresa.Name = "IdEmpresa"
        Me.IdEmpresa.ReadOnly = True
        Me.IdEmpresa.Visible = False
        Me.IdEmpresa.Width = 125
        '
        'IdCliente
        '
        Me.IdCliente.DataPropertyName = "IdCliente"
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.MinimumWidth = 6
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Width = 125
        '
        'IdProyecto
        '
        Me.IdProyecto.DataPropertyName = "IdCliente"
        Me.IdProyecto.DataSource = Me.ClientesBindingSource
        Me.IdProyecto.DisplayMember = "Nombre_Cliente"
        Me.IdProyecto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdProyecto.HeaderText = "IdProyecto"
        Me.IdProyecto.MinimumWidth = 6
        Me.IdProyecto.Name = "IdProyecto"
        Me.IdProyecto.ReadOnly = True
        Me.IdProyecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdProyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdProyecto.ValueMember = "Id_Fiscal"
        Me.IdProyecto.Width = 150
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.MinimumWidth = 6
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Width = 125
        '
        'SubtotalUSD
        '
        Me.SubtotalUSD.DataPropertyName = "SubtotalUS$"
        Me.SubtotalUSD.HeaderText = "SubtotalUS$"
        Me.SubtotalUSD.MinimumWidth = 6
        Me.SubtotalUSD.Name = "SubtotalUSD"
        Me.SubtotalUSD.ReadOnly = True
        Me.SubtotalUSD.Width = 125
        '
        'ValorImpuesto
        '
        Me.ValorImpuesto.DataPropertyName = "ValorImpuesto"
        Me.ValorImpuesto.HeaderText = "ValorImpuesto"
        Me.ValorImpuesto.MinimumWidth = 6
        Me.ValorImpuesto.Name = "ValorImpuesto"
        Me.ValorImpuesto.ReadOnly = True
        Me.ValorImpuesto.Width = 125
        '
        'ImpuestoUS
        '
        Me.ImpuestoUS.DataPropertyName = "ImpuestoUS$"
        Me.ImpuestoUS.HeaderText = "ImpuestoUS$"
        Me.ImpuestoUS.MinimumWidth = 6
        Me.ImpuestoUS.Name = "ImpuestoUS"
        Me.ImpuestoUS.ReadOnly = True
        Me.ImpuestoUS.Width = 125
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalUS$"
        Me.TotalUS.HeaderText = "TotalUS$"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.ReadOnly = True
        Me.TotalUS.Width = 125
        '
        'TasaCambioRD
        '
        Me.TasaCambioRD.DataPropertyName = "TasaCambioRD$"
        Me.TasaCambioRD.HeaderText = "TasaCambioRD$"
        Me.TasaCambioRD.MinimumWidth = 6
        Me.TasaCambioRD.Name = "TasaCambioRD"
        Me.TasaCambioRD.ReadOnly = True
        Me.TasaCambioRD.Width = 125
        '
        'TotalRDS
        '
        Me.TotalRDS.DataPropertyName = "TotalRDS"
        Me.TotalRDS.HeaderText = "TotalRDS"
        Me.TotalRDS.MinimumWidth = 6
        Me.TotalRDS.Name = "TotalRDS"
        Me.TotalRDS.ReadOnly = True
        Me.TotalRDS.Width = 125
        '
        'Aprobada
        '
        Me.Aprobada.DataPropertyName = "Aprobada"
        Me.Aprobada.HeaderText = "Aprobada"
        Me.Aprobada.MinimumWidth = 6
        Me.Aprobada.Name = "Aprobada"
        Me.Aprobada.ReadOnly = True
        Me.Aprobada.Width = 125
        '
        'TipoComprobante
        '
        Me.TipoComprobante.DataPropertyName = "TipoComprobante"
        Me.TipoComprobante.HeaderText = "TipoComprobante"
        Me.TipoComprobante.MinimumWidth = 6
        Me.TipoComprobante.Name = "TipoComprobante"
        Me.TipoComprobante.ReadOnly = True
        Me.TipoComprobante.Width = 125
        '
        'SubTotalRDS
        '
        Me.SubTotalRDS.DataPropertyName = "SubTotalRDS"
        Me.SubTotalRDS.HeaderText = "SubTotalRDS"
        Me.SubTotalRDS.MinimumWidth = 6
        Me.SubTotalRDS.Name = "SubTotalRDS"
        Me.SubTotalRDS.ReadOnly = True
        Me.SubTotalRDS.Width = 125
        '
        'ImpuestolRDS
        '
        Me.ImpuestolRDS.DataPropertyName = "ImpuestolRDS"
        Me.ImpuestolRDS.HeaderText = "ImpuestolRDS"
        Me.ImpuestolRDS.MinimumWidth = 6
        Me.ImpuestolRDS.Name = "ImpuestolRDS"
        Me.ImpuestolRDS.ReadOnly = True
        Me.ImpuestolRDS.Width = 125
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Pagado"
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Visible = False
        Me.Pagado.Width = 125
        '
        'Pendiente
        '
        Me.Pendiente.DataPropertyName = "Pendiente"
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.MinimumWidth = 6
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        Me.Pendiente.Visible = False
        Me.Pendiente.Width = 125
        '
        'FrmVerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1712, 404)
        Me.Controls.Add(Me.BtnVerFactura)
        Me.Controls.Add(Me.BtnNuevaFactura)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Id_EmpresaLabel)
        Me.Controls.Add(Me.Id_EmpresaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(Me.EmpresasBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmVerFacturas"
        Me.Text = "FrmVerFacturas"
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasBindingNavigator.ResumeLayout(False)
        Me.EmpresasBindingNavigator.PerformLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmpresasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_FiscalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FacturaTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsFacturasTableAdapters.TableAdapterManager
    Friend WithEvents FacturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsClientes As ModuloGestion.DsClientes
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents DsProyectos As ModuloGestion.DsProyectos
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents BtnNuevaFactura As System.Windows.Forms.Button
    Friend WithEvents BtnVerFactura As System.Windows.Forms.Button
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaDetalleTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter
    Friend WithEvents DsFacturas As ModuloGestion.DsFacturas
    Friend WithEvents RegitroContableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdFactura As DataGridViewTextBoxColumn
    Friend WithEvents NCF As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents IdProyecto As DataGridViewComboBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalUSD As DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuesto As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents TasaCambioRD As DataGridViewTextBoxColumn
    Friend WithEvents TotalRDS As DataGridViewTextBoxColumn
    Friend WithEvents Aprobada As DataGridViewCheckBoxColumn
    Friend WithEvents TipoComprobante As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalRDS As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestolRDS As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
End Class
