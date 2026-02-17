<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVerFacturas
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
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerFacturas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BtnBuscarPagoDirecto = New System.Windows.Forms.Button()
        Me.BtnAsignarPago = New System.Windows.Forms.Button()
        Me.dgvPagosCandidatos = New System.Windows.Forms.DataGridView()
        Me.FacturaTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.FacturaDetalleTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter()
        Me.dgvPagosAplicados = New System.Windows.Forms.DataGridView()
        Me.BtnDesasignarPago = New System.Windows.Forms.Button()
        Me.IdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalUSF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoUSF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aprobada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        CType(Me.dgvPagosCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagosAplicados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Enabled = False
        Id_EmpresaLabel.Location = New System.Drawing.Point(14, 48)
        Id_EmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(105, 25)
        Id_EmpresaLabel.TabIndex = 1
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Enabled = False
        NombreLabel.Location = New System.Drawing.Point(14, 88)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(82, 25)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Enabled = False
        Id_FiscalLabel.Location = New System.Drawing.Point(202, 48)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(79, 25)
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
        Me.EmpresasBindingNavigator.Size = New System.Drawing.Size(2172, 38)
        Me.EmpresasBindingNavigator.TabIndex = 0
        Me.EmpresasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 33)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'EmpresasBindingNavigatorSaveItem
        '
        Me.EmpresasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasBindingNavigatorSaveItem.Name = "EmpresasBindingNavigatorSaveItem"
        Me.EmpresasBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 33)
        Me.EmpresasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Enabled = False
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(117, 42)
        Me.Id_EmpresaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(64, 31)
        Me.Id_EmpresaTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(117, 82)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(309, 31)
        Me.NombreTextBox.TabIndex = 4
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Enabled = False
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(278, 42)
        Me.Id_FiscalTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(148, 31)
        Me.Id_FiscalTextBox.TabIndex = 6
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AllowUserToAddRows = False
        Me.FacturaDataGridView.AllowUserToDeleteRows = False
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FacturaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFactura, Me.IdProyecto, Me.IdCliente, Me.RazonSocial, Me.NCF, Me.Fecha, Me.Moneda, Me.SubtotalUSF, Me.ImpuestoUSF, Me.TotalUS, Me.TotalRDS, Me.Aprobada, Me.Pagado, Me.Pendiente})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FacturaDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.FacturaDataGridView.EnableHeadersVisualStyles = False
        Me.FacturaDataGridView.Location = New System.Drawing.Point(18, 122)
        Me.FacturaDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.ReadOnly = True
        Me.FacturaDataGridView.RowHeadersWidth = 51
        Me.FacturaDataGridView.Size = New System.Drawing.Size(1918, 485)
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
        Me.BtnNuevaFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnNuevaFactura.FlatAppearance.BorderSize = 0
        Me.BtnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaFactura.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevaFactura.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaFactura.Location = New System.Drawing.Point(577, 39)
        Me.BtnNuevaFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNuevaFactura.Name = "BtnNuevaFactura"
        Me.BtnNuevaFactura.Size = New System.Drawing.Size(140, 35)
        Me.BtnNuevaFactura.TabIndex = 8
        Me.BtnNuevaFactura.Text = "Nueva Factura"
        Me.BtnNuevaFactura.UseVisualStyleBackColor = False
        '
        'BtnVerFactura
        '
        Me.BtnVerFactura.BackColor = System.Drawing.Color.White
        Me.BtnVerFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnVerFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerFactura.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnVerFactura.Location = New System.Drawing.Point(426, 39)
        Me.BtnVerFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVerFactura.Name = "BtnVerFactura"
        Me.BtnVerFactura.Size = New System.Drawing.Size(140, 35)
        Me.BtnVerFactura.TabIndex = 9
        Me.BtnVerFactura.Text = "Ver Factura"
        Me.BtnVerFactura.UseVisualStyleBackColor = False
        '
        'BtnBuscarPagoDirecto
        '
        Me.BtnBuscarPagoDirecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnBuscarPagoDirecto.FlatAppearance.BorderSize = 0
        Me.BtnBuscarPagoDirecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarPagoDirecto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarPagoDirecto.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarPagoDirecto.Location = New System.Drawing.Point(736, 42)
        Me.BtnBuscarPagoDirecto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscarPagoDirecto.Name = "BtnBuscarPagoDirecto"
        Me.BtnBuscarPagoDirecto.Size = New System.Drawing.Size(199, 35)
        Me.BtnBuscarPagoDirecto.TabIndex = 10
        Me.BtnBuscarPagoDirecto.Text = "Buscar Pago Directo"
        Me.BtnBuscarPagoDirecto.UseVisualStyleBackColor = False
        '
        'BtnAsignarPago
        '
        Me.BtnAsignarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnAsignarPago.FlatAppearance.BorderSize = 0
        Me.BtnAsignarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsignarPago.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsignarPago.ForeColor = System.Drawing.Color.White
        Me.BtnAsignarPago.Location = New System.Drawing.Point(824, 824)
        Me.BtnAsignarPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAsignarPago.Name = "BtnAsignarPago"
        Me.BtnAsignarPago.Size = New System.Drawing.Size(171, 35)
        Me.BtnAsignarPago.TabIndex = 11
        Me.BtnAsignarPago.Text = "Asignar Pago"
        Me.BtnAsignarPago.UseVisualStyleBackColor = False
        '
        'dgvPagosCandidatos
        '
        Me.dgvPagosCandidatos.AllowUserToAddRows = False
        Me.dgvPagosCandidatos.AllowUserToDeleteRows = False
        Me.dgvPagosCandidatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPagosCandidatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPagosCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagosCandidatos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPagosCandidatos.EnableHeadersVisualStyles = False
        Me.dgvPagosCandidatos.Location = New System.Drawing.Point(18, 616)
        Me.dgvPagosCandidatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPagosCandidatos.Name = "dgvPagosCandidatos"
        Me.dgvPagosCandidatos.ReadOnly = True
        Me.dgvPagosCandidatos.RowHeadersWidth = 51
        Me.dgvPagosCandidatos.RowTemplate.Height = 24
        Me.dgvPagosCandidatos.Size = New System.Drawing.Size(977, 199)
        Me.dgvPagosCandidatos.TabIndex = 12
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
        'FacturaDetalleTableAdapter
        '
        Me.FacturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'dgvPagosAplicados
        '
        Me.dgvPagosAplicados.BackgroundColor = System.Drawing.Color.White
        Me.dgvPagosAplicados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPagosAplicados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagosAplicados.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPagosAplicados.EnableHeadersVisualStyles = False
        Me.dgvPagosAplicados.Location = New System.Drawing.Point(1020, 616)
        Me.dgvPagosAplicados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPagosAplicados.Name = "dgvPagosAplicados"
        Me.dgvPagosAplicados.RowHeadersWidth = 51
        Me.dgvPagosAplicados.RowTemplate.Height = 24
        Me.dgvPagosAplicados.Size = New System.Drawing.Size(791, 199)
        Me.dgvPagosAplicados.TabIndex = 13
        '
        'BtnDesasignarPago
        '
        Me.BtnDesasignarPago.BackColor = System.Drawing.Color.White
        Me.BtnDesasignarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnDesasignarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesasignarPago.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesasignarPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnDesasignarPago.Location = New System.Drawing.Point(1634, 824)
        Me.BtnDesasignarPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDesasignarPago.Name = "BtnDesasignarPago"
        Me.BtnDesasignarPago.Size = New System.Drawing.Size(177, 35)
        Me.BtnDesasignarPago.TabIndex = 14
        Me.BtnDesasignarPago.Text = "Desasignar Pago"
        Me.BtnDesasignarPago.UseVisualStyleBackColor = False
        '
        'IdFactura
        '
        Me.IdFactura.DataPropertyName = "IdFactura"
        Me.IdFactura.HeaderText = "IdFactura"
        Me.IdFactura.MinimumWidth = 6
        Me.IdFactura.Name = "IdFactura"
        Me.IdFactura.ReadOnly = True
        Me.IdFactura.Width = 90
        '
        'IdProyecto
        '
        Me.IdProyecto.DataPropertyName = "IdProyecto"
        Me.IdProyecto.HeaderText = "IdProyecto"
        Me.IdProyecto.MinimumWidth = 8
        Me.IdProyecto.Name = "IdProyecto"
        Me.IdProyecto.ReadOnly = True
        Me.IdProyecto.Width = 60
        '
        'IdCliente
        '
        Me.IdCliente.DataPropertyName = "IdCliente"
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.MinimumWidth = 6
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        Me.IdCliente.Width = 90
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "IdCliente"
        Me.RazonSocial.DataSource = Me.ClientesBindingSource
        Me.RazonSocial.DisplayMember = "Nombre_Cliente"
        Me.RazonSocial.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.RazonSocial.HeaderText = "IdProyecto"
        Me.RazonSocial.MinimumWidth = 6
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        Me.RazonSocial.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RazonSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RazonSocial.ValueMember = "Id_Fiscal"
        Me.RazonSocial.Width = 150
        '
        'NCF
        '
        Me.NCF.DataPropertyName = "NCF"
        Me.NCF.HeaderText = "NCF"
        Me.NCF.MinimumWidth = 6
        Me.NCF.Name = "NCF"
        Me.NCF.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 60
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
        'SubtotalUSF
        '
        Me.SubtotalUSF.DataPropertyName = "SubtotalUS$"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.NullValue = "n2"
        Me.SubtotalUSF.DefaultCellStyle = DataGridViewCellStyle2
        Me.SubtotalUSF.HeaderText = "SubtotalUS$"
        Me.SubtotalUSF.MinimumWidth = 8
        Me.SubtotalUSF.Name = "SubtotalUSF"
        Me.SubtotalUSF.ReadOnly = True
        Me.SubtotalUSF.Width = 90
        '
        'ImpuestoUSF
        '
        Me.ImpuestoUSF.DataPropertyName = "ImpuestoUS$"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.ImpuestoUSF.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImpuestoUSF.HeaderText = "ImpuestoUS$"
        Me.ImpuestoUSF.MinimumWidth = 8
        Me.ImpuestoUSF.Name = "ImpuestoUSF"
        Me.ImpuestoUSF.ReadOnly = True
        Me.ImpuestoUSF.Width = 90
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalUS$"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalUS.HeaderText = "TotalUS$"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.ReadOnly = True
        Me.TotalUS.Width = 80
        '
        'TotalRDS
        '
        Me.TotalRDS.DataPropertyName = "TotalRDS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalRDS.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalRDS.HeaderText = "TotalRDS"
        Me.TotalRDS.MinimumWidth = 6
        Me.TotalRDS.Name = "TotalRDS"
        Me.TotalRDS.ReadOnly = True
        Me.TotalRDS.Width = 80
        '
        'Aprobada
        '
        Me.Aprobada.DataPropertyName = "Aprobada"
        Me.Aprobada.HeaderText = "Aprobada"
        Me.Aprobada.MinimumWidth = 6
        Me.Aprobada.Name = "Aprobada"
        Me.Aprobada.ReadOnly = True
        Me.Aprobada.Width = 50
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Pagado"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle6
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 90
        '
        'Pendiente
        '
        Me.Pendiente.DataPropertyName = "Pendiente"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.Pendiente.DefaultCellStyle = DataGridViewCellStyle7
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.MinimumWidth = 6
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        Me.Pendiente.Width = 90
        '
        'FrmVerFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2172, 873)
        Me.Controls.Add(Me.BtnDesasignarPago)
        Me.Controls.Add(Me.dgvPagosAplicados)
        Me.Controls.Add(Me.dgvPagosCandidatos)
        Me.Controls.Add(Me.BtnAsignarPago)
        Me.Controls.Add(Me.BtnBuscarPagoDirecto)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmVerFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
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
        CType(Me.dgvPagosCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagosAplicados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BtnBuscarPagoDirecto As Button
    Friend WithEvents BtnAsignarPago As Button
    Friend WithEvents dgvPagosCandidatos As DataGridView
    Friend WithEvents dgvPagosAplicados As DataGridView
    Friend WithEvents BtnDesasignarPago As Button
    Friend WithEvents IdFactura As DataGridViewTextBoxColumn
    Friend WithEvents IdProyecto As DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewComboBoxColumn
    Friend WithEvents NCF As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalUSF As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoUSF As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalRDS As DataGridViewTextBoxColumn
    Friend WithEvents Aprobada As DataGridViewCheckBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
End Class
