<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadoCliente
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
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim Nombre_ClienteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadoCliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrdenDeCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItbisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorImpuestoUs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPresupuestoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadopresupuestoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorImpuestoRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteRDSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcientoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.DsPagosClientesDetalle = New ModuloGestion.DsPagosClientesDetalle()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager()
        Me.PagosClientesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.TxtPorciento = New System.Windows.Forms.TextBox()
        Me.TxtTotalAsignado = New System.Windows.Forms.TextBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnPorPresupuesto = New System.Windows.Forms.Button()
        Me.TxtSaldoPendiente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxTTotalSaldado = New System.Windows.Forms.TextBox()
        Me.BtnEstadoCompleto = New System.Windows.Forms.Button()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtContratado = New System.Windows.Forms.TextBox()
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imprimir = New System.Windows.Forms.DataGridViewButtonColumn()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(28, 58)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(60, 16)
        Id_FiscalLabel.TabIndex = 1
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.AutoSize = True
        Nombre_ClienteLabel.Location = New System.Drawing.Point(16, 90)
        Nombre_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(103, 16)
        Nombre_ClienteLabel.TabIndex = 3
        Nombre_ClienteLabel.Text = "Nombre Cliente:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 142)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(93, 16)
        Label1.TabIndex = 6
        Label1.Text = "Presupuestos "
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(647, 129)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(75, 16)
        Label4.TabIndex = 17
        Label4.Text = "% Cobrado"
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "DsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsClientes
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(1801, 27)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
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
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(161, 54)
        Me.Id_FiscalTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_FiscalTextBox.TabIndex = 2
        '
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(161, 90)
        Me.Nombre_ClienteTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(352, 22)
        Me.Nombre_ClienteTextBox.TabIndex = 4
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdenDeCompra, Me.IdproyectoPresupuestosDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.IdPresupuestoDataGridViewTextBoxColumn, Me.DescripcionPresupuestoDataGridViewTextBoxColumn, Me.EstadoPresupuestoDataGridViewTextBoxColumn, Me.ItbisDataGridViewCheckBoxColumn, Me.LeyendaPresupuestoDataGridViewTextBoxColumn, Me.PlanosDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.SubTotalUS, Me.ValorImpuestoUs, Me.TotalPresupuestoUS, Me.PagadopresupuestoUS, Me.EstadoUS, Me.SubTotalRDDataGridViewTextBoxColumn, Me.ValorImpuestoRDDataGridViewTextBoxColumn, Me.TotalPresupuestoRDDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.PagadoRDDataGridViewTextBoxColumn, Me.PendienteRDSDataGridViewTextBoxColumn, Me.SubTotal, Me.Impuesto, Me.Total, Me.Pagado, Me.Pendiente, Me.PorcientoPago})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(20, 169)
        Me.PresupuestoDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.ReadOnly = True
        Me.PresupuestoDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(1253, 289)
        Me.PresupuestoDataGridView.TabIndex = 5
        '
        'OrdenDeCompra
        '
        Me.OrdenDeCompra.DataPropertyName = "OrdenDeCompra"
        Me.OrdenDeCompra.HeaderText = "Orden"
        Me.OrdenDeCompra.MinimumWidth = 6
        Me.OrdenDeCompra.Name = "OrdenDeCompra"
        Me.OrdenDeCompra.ReadOnly = True
        Me.OrdenDeCompra.Visible = False
        Me.OrdenDeCompra.Width = 40
        '
        'IdproyectoPresupuestosDataGridViewTextBoxColumn
        '
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.HeaderText = "Id_proyecto_Presupuestos"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.Name = "IdproyectoPresupuestosDataGridViewTextBoxColumn"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.Visible = False
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'IdPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.HeaderText = "Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPresupuestoDataGridViewTextBoxColumn.Name = "IdPresupuestoDataGridViewTextBoxColumn"
        Me.IdPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionPresupuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Presupuesto"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.Name = "DescripcionPresupuestoDataGridViewTextBoxColumn"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoPresupuestoDataGridViewTextBoxColumn
        '
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Estado_Presupuesto"
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.Name = "EstadoPresupuestoDataGridViewTextBoxColumn"
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.Width = 60
        '
        'ItbisDataGridViewCheckBoxColumn
        '
        Me.ItbisDataGridViewCheckBoxColumn.DataPropertyName = "Itbis"
        Me.ItbisDataGridViewCheckBoxColumn.HeaderText = "Itbis"
        Me.ItbisDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ItbisDataGridViewCheckBoxColumn.Name = "ItbisDataGridViewCheckBoxColumn"
        Me.ItbisDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ItbisDataGridViewCheckBoxColumn.Visible = False
        Me.ItbisDataGridViewCheckBoxColumn.Width = 125
        '
        'LeyendaPresupuestoDataGridViewTextBoxColumn
        '
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Leyenda_Presupuesto"
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.HeaderText = "Leyenda_Presupuesto"
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.Name = "LeyendaPresupuestoDataGridViewTextBoxColumn"
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.Visible = False
        Me.LeyendaPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'PlanosDataGridViewTextBoxColumn
        '
        Me.PlanosDataGridViewTextBoxColumn.DataPropertyName = "Planos"
        Me.PlanosDataGridViewTextBoxColumn.HeaderText = "Planos"
        Me.PlanosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PlanosDataGridViewTextBoxColumn.Name = "PlanosDataGridViewTextBoxColumn"
        Me.PlanosDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlanosDataGridViewTextBoxColumn.Visible = False
        Me.PlanosDataGridViewTextBoxColumn.Width = 125
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonedaDataGridViewTextBoxColumn.Width = 50
        '
        'SubTotalUS
        '
        Me.SubTotalUS.DataPropertyName = "SubTotalUS"
        Me.SubTotalUS.HeaderText = "SubTotalUS"
        Me.SubTotalUS.MinimumWidth = 6
        Me.SubTotalUS.Name = "SubTotalUS"
        Me.SubTotalUS.ReadOnly = True
        Me.SubTotalUS.Visible = False
        Me.SubTotalUS.Width = 125
        '
        'ValorImpuestoUs
        '
        Me.ValorImpuestoUs.DataPropertyName = "ValorImpuestoUs"
        Me.ValorImpuestoUs.HeaderText = "ValorImpuestoUs"
        Me.ValorImpuestoUs.MinimumWidth = 6
        Me.ValorImpuestoUs.Name = "ValorImpuestoUs"
        Me.ValorImpuestoUs.ReadOnly = True
        Me.ValorImpuestoUs.Visible = False
        Me.ValorImpuestoUs.Width = 125
        '
        'TotalPresupuestoUS
        '
        Me.TotalPresupuestoUS.DataPropertyName = "TotalPresupuestoUS"
        Me.TotalPresupuestoUS.HeaderText = "TotalPresupuestoUS"
        Me.TotalPresupuestoUS.MinimumWidth = 6
        Me.TotalPresupuestoUS.Name = "TotalPresupuestoUS"
        Me.TotalPresupuestoUS.ReadOnly = True
        Me.TotalPresupuestoUS.Visible = False
        Me.TotalPresupuestoUS.Width = 125
        '
        'PagadopresupuestoUS
        '
        Me.PagadopresupuestoUS.DataPropertyName = "PagadopresupuestoUS"
        Me.PagadopresupuestoUS.HeaderText = "PagadopresupuestoUS"
        Me.PagadopresupuestoUS.MinimumWidth = 6
        Me.PagadopresupuestoUS.Name = "PagadopresupuestoUS"
        Me.PagadopresupuestoUS.ReadOnly = True
        Me.PagadopresupuestoUS.Visible = False
        Me.PagadopresupuestoUS.Width = 125
        '
        'EstadoUS
        '
        Me.EstadoUS.DataPropertyName = "EstadoUS"
        Me.EstadoUS.HeaderText = "EstadoUS"
        Me.EstadoUS.MinimumWidth = 6
        Me.EstadoUS.Name = "EstadoUS"
        Me.EstadoUS.ReadOnly = True
        Me.EstadoUS.Visible = False
        Me.EstadoUS.Width = 125
        '
        'SubTotalRDDataGridViewTextBoxColumn
        '
        Me.SubTotalRDDataGridViewTextBoxColumn.DataPropertyName = "SubTotalRD"
        Me.SubTotalRDDataGridViewTextBoxColumn.HeaderText = "SubTotalRD"
        Me.SubTotalRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubTotalRDDataGridViewTextBoxColumn.Name = "SubTotalRDDataGridViewTextBoxColumn"
        Me.SubTotalRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTotalRDDataGridViewTextBoxColumn.Visible = False
        Me.SubTotalRDDataGridViewTextBoxColumn.Width = 125
        '
        'ValorImpuestoRDDataGridViewTextBoxColumn
        '
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.DataPropertyName = "ValorImpuestoRD"
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.HeaderText = "ValorImpuestoRD"
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.Name = "ValorImpuestoRDDataGridViewTextBoxColumn"
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.Visible = False
        Me.ValorImpuestoRDDataGridViewTextBoxColumn.Width = 125
        '
        'TotalPresupuestoRDDataGridViewTextBoxColumn
        '
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.DataPropertyName = "TotalPresupuestoRD"
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.HeaderText = "TotalPresupuestoRD"
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.Name = "TotalPresupuestoRDDataGridViewTextBoxColumn"
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.Visible = False
        Me.TotalPresupuestoRDDataGridViewTextBoxColumn.Width = 125
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "tasa"
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "tasa"
        Me.TasaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TasaDataGridViewTextBoxColumn.Width = 50
        '
        'PagadoRDDataGridViewTextBoxColumn
        '
        Me.PagadoRDDataGridViewTextBoxColumn.DataPropertyName = "PagadoRD"
        Me.PagadoRDDataGridViewTextBoxColumn.HeaderText = "PagadoRD"
        Me.PagadoRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PagadoRDDataGridViewTextBoxColumn.Name = "PagadoRDDataGridViewTextBoxColumn"
        Me.PagadoRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagadoRDDataGridViewTextBoxColumn.Visible = False
        Me.PagadoRDDataGridViewTextBoxColumn.Width = 125
        '
        'PendienteRDSDataGridViewTextBoxColumn
        '
        Me.PendienteRDSDataGridViewTextBoxColumn.DataPropertyName = "PendienteRDS"
        Me.PendienteRDSDataGridViewTextBoxColumn.HeaderText = "PendienteRDS"
        Me.PendienteRDSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PendienteRDSDataGridViewTextBoxColumn.Name = "PendienteRDSDataGridViewTextBoxColumn"
        Me.PendienteRDSDataGridViewTextBoxColumn.ReadOnly = True
        Me.PendienteRDSDataGridViewTextBoxColumn.Visible = False
        Me.PendienteRDSDataGridViewTextBoxColumn.Width = 125
        '
        'SubTotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubTotal.HeaderText = "Subtotal"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 75
        '
        'Impuesto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.MinimumWidth = 6
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.ReadOnly = True
        Me.Impuesto.Width = 75
        '
        'Total
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle3
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 75
        '
        'Pagado
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle4
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 75
        '
        'Pendiente
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.Pendiente.DefaultCellStyle = DataGridViewCellStyle5
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.MinimumWidth = 6
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        Me.Pendiente.Width = 75
        '
        'PorcientoPago
        '
        Me.PorcientoPago.DataPropertyName = "PorcientoPago"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "## %"
        DataGridViewCellStyle6.NullValue = "0"
        Me.PorcientoPago.DefaultCellStyle = DataGridViewCellStyle6
        Me.PorcientoPago.HeaderText = "% Pagado"
        Me.PorcientoPago.MinimumWidth = 6
        Me.PorcientoPago.Name = "PorcientoPago"
        Me.PorcientoPago.ReadOnly = True
        Me.PorcientoPago.Width = 60
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.PagosClientesDetalleTableAdapter = Me.PagosClientesDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesDetalleDataGridView
        '
        Me.PagosClientesDetalleDataGridView.AllowUserToAddRows = False
        Me.PagosClientesDetalleDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.PagosClientesDetalleDataGridView.DataSource = Me.PagosClientesDetalleBindingSource
        Me.PagosClientesDetalleDataGridView.Location = New System.Drawing.Point(1281, 169)
        Me.PagosClientesDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PagosClientesDetalleDataGridView.Name = "PagosClientesDetalleDataGridView"
        Me.PagosClientesDetalleDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDetalleDataGridView.Size = New System.Drawing.Size(455, 271)
        Me.PagosClientesDetalleDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "IdPagoClientesDetalle"
        Me.DataGridViewTextBoxColumn26.HeaderText = "IdPagoClientesDetalle"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "ID_Cobro"
        Me.DataGridViewTextBoxColumn27.HeaderText = "ID_Cobro"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.DataGridViewTextBoxColumn30.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn30.HeaderText = "Pagado"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 125
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.ClientesTableAdapter = Nothing
        Me.TableAdapterManager3.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager3.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TxtPorciento
        '
        Me.TxtPorciento.Location = New System.Drawing.Point(764, 121)
        Me.TxtPorciento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPorciento.Name = "TxtPorciento"
        Me.TxtPorciento.Size = New System.Drawing.Size(132, 22)
        Me.TxtPorciento.TabIndex = 16
        Me.TxtPorciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalAsignado
        '
        Me.TxtTotalAsignado.Location = New System.Drawing.Point(1469, 447)
        Me.TxtTotalAsignado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTotalAsignado.Name = "TxtTotalAsignado"
        Me.TxtTotalAsignado.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotalAsignado.TabIndex = 22
        Me.TxtTotalAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(905, 26)
        Me.BtnImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(184, 28)
        Me.BtnImprimir.TabIndex = 23
        Me.BtnImprimir.Text = "Imprimir Por Pago"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnPorPresupuesto
        '
        Me.BtnPorPresupuesto.Location = New System.Drawing.Point(905, 62)
        Me.BtnPorPresupuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPorPresupuesto.Name = "BtnPorPresupuesto"
        Me.BtnPorPresupuesto.Size = New System.Drawing.Size(184, 28)
        Me.BtnPorPresupuesto.TabIndex = 25
        Me.BtnPorPresupuesto.Text = "Imprimir Por Presupuesto"
        Me.BtnPorPresupuesto.UseVisualStyleBackColor = True
        '
        'TxtSaldoPendiente
        '
        Me.TxtSaldoPendiente.Location = New System.Drawing.Point(764, 92)
        Me.TxtSaldoPendiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSaldoPendiente.Name = "TxtSaldoPendiente"
        Me.TxtSaldoPendiente.Size = New System.Drawing.Size(132, 22)
        Me.TxtSaldoPendiente.TabIndex = 26
        Me.TxtSaldoPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Location = New System.Drawing.Point(632, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Saldo Pendiente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Location = New System.Drawing.Point(632, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Total Saldado"
        '
        'TxTTotalSaldado
        '
        Me.TxTTotalSaldado.Location = New System.Drawing.Point(764, 64)
        Me.TxTTotalSaldado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxTTotalSaldado.Name = "TxTTotalSaldado"
        Me.TxTTotalSaldado.Size = New System.Drawing.Size(132, 22)
        Me.TxTTotalSaldado.TabIndex = 28
        Me.TxTTotalSaldado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnEstadoCompleto
        '
        Me.BtnEstadoCompleto.Location = New System.Drawing.Point(905, 96)
        Me.BtnEstadoCompleto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEstadoCompleto.Name = "BtnEstadoCompleto"
        Me.BtnEstadoCompleto.Size = New System.Drawing.Size(184, 28)
        Me.BtnEstadoCompleto.TabIndex = 32
        Me.BtnEstadoCompleto.Text = "Estado Completo"
        Me.BtnEstadoCompleto.UseVisualStyleBackColor = True
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Location = New System.Drawing.Point(632, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Total Contradado"
        '
        'TxtContratado
        '
        Me.TxtContratado.Location = New System.Drawing.Point(764, 34)
        Me.TxtContratado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtContratado.Name = "TxtContratado"
        Me.TxtContratado.Size = New System.Drawing.Size(132, 22)
        Me.TxtContratado.TabIndex = 33
        Me.TxtContratado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DsProyectos
        '
        Me.DsProyectos.DataSetName = "DsProyectos"
        Me.DsProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsProyectos
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AllowUserToDeleteRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Imprimir})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(1131, 15)
        Me.ProyectosDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.ReadOnly = True
        Me.ProyectosDataGridView.RowHeadersWidth = 51
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(605, 146)
        Me.ProyectosDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Proyecto"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Proyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre "
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.MinimumWidth = 6
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.ReadOnly = True
        Me.Imprimir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Imprimir.Width = 65
        '
        'FrmEstadoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1801, 521)
        Me.Controls.Add(Me.ProyectosDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtContratado)
        Me.Controls.Add(Me.BtnEstadoCompleto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxTTotalSaldado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSaldoPendiente)
        Me.Controls.Add(Me.BtnPorPresupuesto)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.TxtTotalAsignado)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.TxtPorciento)
        Me.Controls.Add(Me.PagosClientesDetalleDataGridView)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PresupuestoDataGridView)
        Me.Controls.Add(Nombre_ClienteLabel)
        Me.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmEstadoCliente"
        Me.Text = "FrmEstadoCliente"
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsClientes As ModuloGestion.DsClientes
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_FiscalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresupuestoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsPagosClientesDetalle As ModuloGestion.DsPagosClientesDetalle
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents TxtPorciento As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAsignado As System.Windows.Forms.TextBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnPorPresupuesto As System.Windows.Forms.Button
    Friend WithEvents TxtSaldoPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxTTotalSaldado As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagadopresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenDeCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdproyectoPresupuestosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItbisDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LeyendaPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuestoUs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPresupuestoUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagadopresupuestoUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalRDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuestoRDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPresupuestoRDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagadoRDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PendienteRDSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcientoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnEstadoCompleto As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtContratado As System.Windows.Forms.TextBox
    Friend WithEvents DsProyectos As ModuloGestion.DsProyectos
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imprimir As System.Windows.Forms.DataGridViewButtonColumn
End Class
