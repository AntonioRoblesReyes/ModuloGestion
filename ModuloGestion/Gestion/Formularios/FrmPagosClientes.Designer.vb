<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagosClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagosClientes))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.PagosClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        Me.BtnImprimirRecibo = New System.Windows.Forms.Button()
        Me.PagosClientesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosClientesDetalle = New ModuloGestion.DsPagosClientesDetalle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.cmbFiltroMonto = New System.Windows.Forms.ComboBox()
        Me.ID_Cobro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Fiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sin_Asignar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarP = New System.Windows.Forms.DataGridViewButtonColumn()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.PagosClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(43, 50)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(60, 16)
        Id_FiscalLabel.TabIndex = 1
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.AutoSize = True
        Nombre_ClienteLabel.Location = New System.Drawing.Point(289, 52)
        Nombre_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(103, 16)
        Nombre_ClienteLabel.TabIndex = 3
        Nombre_ClienteLabel.Text = "Nombre Cliente:"
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
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(1649, 27)
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
        Me.Id_FiscalTextBox.Enabled = False
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(129, 47)
        Me.Id_FiscalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_FiscalTextBox.TabIndex = 2
        '
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Enabled = False
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(396, 48)
        Me.Nombre_ClienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(379, 22)
        Me.Nombre_ClienteTextBox.TabIndex = 4
        '
        'PagosClientesDataGridView
        '
        Me.PagosClientesDataGridView.AllowUserToAddRows = False
        Me.PagosClientesDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Cobro, Me.Id_Fiscal, Me.Fecha, Me.Valor, Me.Moneda, Me.Asignado, Me.Sin_Asignar, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.EliminarP})
        Me.PagosClientesDataGridView.DataSource = Me.PagosClientesBindingSource
        Me.PagosClientesDataGridView.Location = New System.Drawing.Point(16, 80)
        Me.PagosClientesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PagosClientesDataGridView.Name = "PagosClientesDataGridView"
        Me.PagosClientesDataGridView.ReadOnly = True
        Me.PagosClientesDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PagosClientesDataGridView.Size = New System.Drawing.Size(948, 475)
        Me.PagosClientesDataGridView.TabIndex = 5
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsEmpresas
        '
        'DsEmpresas
        '
        Me.DsEmpresas.DataSetName = "DsEmpresas"
        Me.DsEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesBindingSource
        '
        Me.PagosClientesBindingSource.DataMember = "PagosClientes"
        Me.PagosClientesBindingSource.DataSource = Me.DsPagosClientes
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(323, 563)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnNuevoPago
        '
        Me.BtnNuevoPago.Location = New System.Drawing.Point(794, 47)
        Me.BtnNuevoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevoPago.Name = "BtnNuevoPago"
        Me.BtnNuevoPago.Size = New System.Drawing.Size(100, 28)
        Me.BtnNuevoPago.TabIndex = 7
        Me.BtnNuevoPago.Text = "Nuevo Pago"
        Me.BtnNuevoPago.UseVisualStyleBackColor = True
        '
        'BtnImprimirRecibo
        '
        Me.BtnImprimirRecibo.Location = New System.Drawing.Point(1172, 41)
        Me.BtnImprimirRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImprimirRecibo.Name = "BtnImprimirRecibo"
        Me.BtnImprimirRecibo.Size = New System.Drawing.Size(120, 28)
        Me.BtnImprimirRecibo.TabIndex = 8
        Me.BtnImprimirRecibo.Text = "Imprimir Recibo"
        Me.BtnImprimirRecibo.UseVisualStyleBackColor = True
        '
        'PagosClientesDetalleDataGridView
        '
        Me.PagosClientesDetalleDataGridView.AllowUserToAddRows = False
        Me.PagosClientesDetalleDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.eliminar})
        Me.PagosClientesDetalleDataGridView.DataSource = Me.PagosClientesDetalleBindingSource
        Me.PagosClientesDetalleDataGridView.Location = New System.Drawing.Point(972, 80)
        Me.PagosClientesDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PagosClientesDetalleDataGridView.Name = "PagosClientesDetalleDataGridView"
        Me.PagosClientesDetalleDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PagosClientesDetalleDataGridView.Size = New System.Drawing.Size(542, 474)
        Me.PagosClientesDetalleDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdPagoClientesDetalle"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdPagoClientesDetalle"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID_Cobro"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID_Cobro"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Proyecto"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn14.HeaderText = "Asignado"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'eliminar
        '
        Me.eliminar.FalseValue = ""
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.MinimumWidth = 6
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ThreeState = True
        Me.eliminar.TrueValue = ""
        Me.eliminar.Width = 75
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsPagosClientesDetalle
        '
        'DsPagosClientesDetalle
        '
        Me.DsPagosClientesDetalle.DataSetName = "DsPagosClientesDetalle"
        Me.DsPagosClientesDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(902, 44)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Asignar Pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(464, 563)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 22)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(597, 563)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 22)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(1280, 562)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(124, 22)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1333, 41)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
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
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1031, 45)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 28)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Modificar Pago"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1441, 41)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(196, 28)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Estado Presupuesto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PagosClientesTableAdapter
        '
        Me.PagosClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbFiltroMonto
        '
        Me.cmbFiltroMonto.FormattingEnabled = True
        Me.cmbFiltroMonto.Location = New System.Drawing.Point(16, 563)
        Me.cmbFiltroMonto.Name = "cmbFiltroMonto"
        Me.cmbFiltroMonto.Size = New System.Drawing.Size(159, 24)
        Me.cmbFiltroMonto.TabIndex = 16
        '
        'ID_Cobro
        '
        Me.ID_Cobro.DataPropertyName = "ID_Cobro"
        Me.ID_Cobro.HeaderText = "ID_Cobro"
        Me.ID_Cobro.MinimumWidth = 6
        Me.ID_Cobro.Name = "ID_Cobro"
        Me.ID_Cobro.ReadOnly = True
        Me.ID_Cobro.Width = 75
        '
        'Id_Fiscal
        '
        Me.Id_Fiscal.DataPropertyName = "Id_Fiscal"
        Me.Id_Fiscal.HeaderText = "Id_Fiscal"
        Me.Id_Fiscal.MinimumWidth = 6
        Me.Id_Fiscal.Name = "Id_Fiscal"
        Me.Id_Fiscal.ReadOnly = True
        Me.Id_Fiscal.Visible = False
        Me.Id_Fiscal.Width = 125
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 75
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "valor"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle2
        Me.Valor.HeaderText = "valor"
        Me.Valor.MinimumWidth = 6
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 75
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
        'Asignado
        '
        Me.Asignado.DataPropertyName = "Asignado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Asignado.DefaultCellStyle = DataGridViewCellStyle3
        Me.Asignado.HeaderText = "Asignado"
        Me.Asignado.MinimumWidth = 6
        Me.Asignado.Name = "Asignado"
        Me.Asignado.ReadOnly = True
        Me.Asignado.Width = 125
        '
        'Sin_Asignar
        '
        Me.Sin_Asignar.DataPropertyName = "PendienteAsignar"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Sin_Asignar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Sin_Asignar.HeaderText = "Sin Asignar"
        Me.Sin_Asignar.MinimumWidth = 6
        Me.Sin_Asignar.Name = "Sin_Asignar"
        Me.Sin_Asignar.ReadOnly = True
        Me.Sin_Asignar.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id_Empresa"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.EmpresasBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id_Empresa"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "Id_Empresa"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FormaDePago"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FormaDePago"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'EliminarP
        '
        Me.EliminarP.HeaderText = "ElimInar"
        Me.EliminarP.MinimumWidth = 6
        Me.EliminarP.Name = "EliminarP"
        Me.EliminarP.ReadOnly = True
        Me.EliminarP.Width = 125
        '
        'FrmPagosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1649, 624)
        Me.Controls.Add(Me.cmbFiltroMonto)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PagosClientesDetalleDataGridView)
        Me.Controls.Add(Me.BtnImprimirRecibo)
        Me.Controls.Add(Me.BtnNuevoPago)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PagosClientesDataGridView)
        Me.Controls.Add(Nombre_ClienteLabel)
        Me.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPagosClientes"
        Me.Text = "FrmPagosClientes"
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.PagosClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

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
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevoPago As System.Windows.Forms.Button
    Friend WithEvents BtnImprimirRecibo As System.Windows.Forms.Button
    Friend WithEvents DsPagosClientesDetalle As ModuloGestion.DsPagosClientesDetalle
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cmbFiltroMonto As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents ID_Cobro As DataGridViewTextBoxColumn
    Friend WithEvents Id_Fiscal As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents Asignado As DataGridViewTextBoxColumn
    Friend WithEvents Sin_Asignar As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents EliminarP As DataGridViewButtonColumn
End Class
