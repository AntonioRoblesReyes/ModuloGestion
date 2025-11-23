<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturaMontajeEditar
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
        Dim IdEmpresaMontajeLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim Telefono1Label As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim FechaPAgoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim PagadoLabel As System.Windows.Forms.Label
        Dim PendienteLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim ItebisLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Descripcion_PresupuestoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturaMontajeEditar))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Añadir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaPAgoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAprobarPago = New System.Windows.Forms.Button()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.FacturaMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.PagoMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter()
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PresupuestoDetalleTableAdapter()
        Me.EmpresasContratadasMontajeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PagoMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter()
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.PagadoTextBox = New System.Windows.Forms.TextBox()
        Me.PendienteTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ItebisTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PresupuestoTableAdapter()
        Me.Descripcion_PresupuestoTextBox = New System.Windows.Forms.TextBox()
        IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        Telefono1Label = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        FechaPAgoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        PagadoLabel = New System.Windows.Forms.Label()
        PendienteLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        ItebisLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Descripcion_PresupuestoLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasContratadasMontajeBindingNavigator.SuspendLayout()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(10, 22)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(104, 13)
        IdEmpresaMontajeLabel.TabIndex = 1
        IdEmpresaMontajeLabel.Text = "Id Empresa Montaje:"
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(41, 48)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 3
        RazonSocialLabel.Text = "Razon Social:"
        '
        'Telefono1Label
        '
        Telefono1Label.AutoSize = True
        Telefono1Label.Location = New System.Drawing.Point(56, 74)
        Telefono1Label.Name = "Telefono1Label"
        Telefono1Label.Size = New System.Drawing.Size(58, 13)
        Telefono1Label.TabIndex = 5
        Telefono1Label.Text = "Telefono1:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(32, 221)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(58, 13)
        IdPagoLabel.TabIndex = 9
        IdPagoLabel.Text = "Id Factura:"
        '
        'FechaPAgoLabel
        '
        FechaPAgoLabel.AutoSize = True
        FechaPAgoLabel.Location = New System.Drawing.Point(209, 221)
        FechaPAgoLabel.Name = "FechaPAgoLabel"
        FechaPAgoLabel.Size = New System.Drawing.Size(69, 13)
        FechaPAgoLabel.TabIndex = 10
        FechaPAgoLabel.Text = "Fecha PAgo:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(805, 538)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 20
        TotalLabel.Text = "Total:"
        '
        'PagadoLabel
        '
        PagadoLabel.AutoSize = True
        PagadoLabel.Location = New System.Drawing.Point(181, 503)
        PagadoLabel.Name = "PagadoLabel"
        PagadoLabel.Size = New System.Drawing.Size(47, 13)
        PagadoLabel.TabIndex = 21
        PagadoLabel.Text = "Pagado:"
        '
        'PendienteLabel
        '
        PendienteLabel.AutoSize = True
        PendienteLabel.Location = New System.Drawing.Point(383, 503)
        PendienteLabel.Name = "PendienteLabel"
        PendienteLabel.Size = New System.Drawing.Size(58, 13)
        PendienteLabel.TabIndex = 22
        PendienteLabel.Text = "Pendiente:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(783, 484)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(56, 13)
        SubTotalLabel.TabIndex = 23
        SubTotalLabel.Text = "Sub Total:"
        '
        'ItebisLabel
        '
        ItebisLabel.AutoSize = True
        ItebisLabel.Location = New System.Drawing.Point(804, 510)
        ItebisLabel.Name = "ItebisLabel"
        ItebisLabel.Size = New System.Drawing.Size(35, 13)
        ItebisLabel.TabIndex = 24
        ItebisLabel.Text = "Itebis:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(603, 180)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(32, 13)
        Label2.TabIndex = 29
        Label2.Text = "Itebis"
        '
        'Descripcion_PresupuestoLabel
        '
        Descripcion_PresupuestoLabel.AutoSize = True
        Descripcion_PresupuestoLabel.Location = New System.Drawing.Point(66, 100)
        Descripcion_PresupuestoLabel.Name = "Descripcion_PresupuestoLabel"
        Descripcion_PresupuestoLabel.Size = New System.Drawing.Size(128, 13)
        Descripcion_PresupuestoLabel.TabIndex = 7
        Descripcion_PresupuestoLabel.Text = "Descripcion Presupuesto:"
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Telefono1", True))
        Me.Telefono1TextBox.Enabled = False
        Me.Telefono1TextBox.Location = New System.Drawing.Point(120, 71)
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono1TextBox.TabIndex = 6
        '
        'EmpresasContratadasMontajeBindingSource
        '
        Me.EmpresasContratadasMontajeBindingSource.DataMember = "EmpresasContratadasMontaje"
        Me.EmpresasContratadasMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'DsPagosMontaje
        '
        Me.DsPagosMontaje.DataSetName = "DsPagosMontaje"
        Me.DsPagosMontaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Descripcion_PresupuestoLabel)
        Me.GroupBox1.Controls.Add(Me.RazonSocialTextBox)
        Me.GroupBox1.Controls.Add(Me.IdEmpresaMontajeTextBox)
        Me.GroupBox1.Controls.Add(Telefono1Label)
        Me.GroupBox1.Controls.Add(IdEmpresaMontajeLabel)
        Me.GroupBox1.Controls.Add(Me.Telefono1TextBox)
        Me.GroupBox1.Controls.Add(RazonSocialLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empresa Montaje"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "RazonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(120, 45)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RazonSocialTextBox.TabIndex = 7
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "IdEmpresaMontaje", True))
        Me.IdEmpresaMontajeTextBox.Enabled = False
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(120, 19)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEmpresaMontajeTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Presupuesto"
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.AutoSize = True
        Me.LblPresupuesto.Location = New System.Drawing.Point(424, 37)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(72, 13)
        Me.LblPresupuesto.TabIndex = 9
        Me.LblPresupuesto.Text = "Id Prespuesto"
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn34, Me.Añadir})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(358, 53)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.ReadOnly = True
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(618, 119)
        Me.PresupuestoDetalleDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdDetalle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.ArticulosBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn1.HeaderText = "Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "IdArticulo"
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CostoMontaje"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn26.HeaderText = "Previsto"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 75
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Precio_Ajustado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.DataGridViewTextBoxColumn34.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn34.HeaderText = "PrecioVenta"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 75
        '
        'Añadir
        '
        Me.Añadir.HeaderText = "Añadir"
        Me.Añadir.Name = "Añadir"
        Me.Añadir.ReadOnly = True
        Me.Añadir.Width = 70
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'IdFacturaTextBox
        '
        Me.IdFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "IdFacturaMontaje", True))
        Me.IdFacturaTextBox.Enabled = False
        Me.IdFacturaTextBox.Location = New System.Drawing.Point(96, 218)
        Me.IdFacturaTextBox.Name = "IdFacturaTextBox"
        Me.IdFacturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdFacturaTextBox.TabIndex = 10
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FacturaMontaje"
        Me.FacturaMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'FechaPAgoDateTimePicker
        '
        Me.FechaPAgoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPAgoDateTimePicker.Location = New System.Drawing.Point(296, 219)
        Me.FechaPAgoDateTimePicker.Name = "FechaPAgoDateTimePicker"
        Me.FechaPAgoDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FechaPAgoDateTimePicker.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(489, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Nuevo Linea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnAprobarPago
        '
        Me.BtnAprobarPago.Location = New System.Drawing.Point(96, 189)
        Me.BtnAprobarPago.Name = "BtnAprobarPago"
        Me.BtnAprobarPago.Size = New System.Drawing.Size(93, 23)
        Me.BtnAprobarPago.TabIndex = 16
        Me.BtnAprobarPago.Text = "Aprobar Pago"
        Me.BtnAprobarPago.UseVisualStyleBackColor = True
        '
        'LblProyecto
        '
        Me.LblProyecto.AutoSize = True
        Me.LblProyecto.Location = New System.Drawing.Point(424, 24)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(49, 13)
        Me.LblProyecto.TabIndex = 18
        Me.LblProyecto.Text = "Proyecto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Proyecto"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(745, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(376, 65)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(435, 60)
        Me.ArticulosDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn14.HeaderText = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "M2Pintura"
        Me.DataGridViewTextBoxColumn15.HeaderText = "M2Pintura"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "HorasTrabajoTallerPintura"
        Me.DataGridViewTextBoxColumn16.HeaderText = "HorasTrabajoTallerPintura"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DiseñoArticulo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "DiseñoArticulo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasContratadasMontajeTableAdapter = Me.EmpresasContratadasMontajeTableAdapter
        Me.TableAdapterManager.FacturaMontajeDetalleTableAdapter = Me.FacturaMontajeDetalleTableAdapter
        Me.TableAdapterManager.FacturaMontajeTableAdapter = Me.FacturaMontajeTableAdapter
        Me.TableAdapterManager.PagoMontajeDetalleTableAdapter = Me.PagoMontajeDetalleTableAdapter
        Me.TableAdapterManager.PagoMontajeTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaMontajeDetalleTableAdapter
        '
        Me.FacturaMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeTableAdapter
        '
        Me.FacturaMontajeTableAdapter.ClearBeforeFill = True
        '
        'PagoMontajeDetalleTableAdapter
        '
        Me.PagoMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'EmpresasContratadasMontajeBindingNavigator
        '
        Me.EmpresasContratadasMontajeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasContratadasMontajeBindingNavigator.BindingSource = Me.EmpresasContratadasMontajeBindingSource
        Me.EmpresasContratadasMontajeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasContratadasMontajeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasContratadasMontajeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasContratadasMontajeBindingNavigatorSaveItem})
        Me.EmpresasContratadasMontajeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasContratadasMontajeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasContratadasMontajeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasContratadasMontajeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasContratadasMontajeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasContratadasMontajeBindingNavigator.Name = "EmpresasContratadasMontajeBindingNavigator"
        Me.EmpresasContratadasMontajeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasContratadasMontajeBindingNavigator.Size = New System.Drawing.Size(1011, 25)
        Me.EmpresasContratadasMontajeBindingNavigator.TabIndex = 20
        Me.EmpresasContratadasMontajeBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'EmpresasContratadasMontajeBindingNavigatorSaveItem
        '
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasContratadasMontajeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Name = "EmpresasContratadasMontajeBindingNavigatorSaveItem"
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PagoMontajeDetalleBindingSource
        '
        Me.PagoMontajeDetalleBindingSource.DataMember = "PagoMontajeDetalle"
        Me.PagoMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'FacturaMontajeDetalleBindingSource
        '
        Me.FacturaMontajeDetalleBindingSource.DataMember = "FacturaMontajeDetalle"
        Me.FacturaMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'FacturaMontajeDetalleDataGridView
        '
        Me.FacturaMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn18})
        Me.FacturaMontajeDetalleDataGridView.DataSource = Me.FacturaMontajeDetalleBindingSource
        Me.FacturaMontajeDetalleDataGridView.Location = New System.Drawing.Point(46, 255)
        Me.FacturaMontajeDetalleDataGridView.Name = "FacturaMontajeDetalleDataGridView"
        Me.FacturaMontajeDetalleDataGridView.Size = New System.Drawing.Size(889, 220)
        Me.FacturaMontajeDetalleDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdFacturaMontajeDetalle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdF Detalle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id Detalle_Presupuesto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descrpcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Precio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn10.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn18.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
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
        'FKPagoMontajeEmpresasContratadasMontajeBindingSource
        '
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource.DataMember = "FK_PagoMontaje_EmpresasContratadasMontaje"
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource.DataSource = Me.EmpresasContratadasMontajeBindingSource
        '
        'PagoMontajeTableAdapter
        '
        Me.PagoMontajeTableAdapter.ClearBeforeFill = True
        '
        'FKPagoMontajeEmpresasContratadasMontajeBindingSource1
        '
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1.DataMember = "FK_PagoMontaje_EmpresasContratadasMontaje"
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1.DataSource = Me.EmpresasContratadasMontajeBindingSource
        '
        'FKPagoMontajeEmpresasContratadasMontajeBindingSource2
        '
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2.DataMember = "FK_PagoMontaje_EmpresasContratadasMontaje"
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2.DataSource = Me.EmpresasContratadasMontajeBindingSource
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TotalTextBox.Location = New System.Drawing.Point(845, 535)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 21
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PagadoTextBox
        '
        Me.PagadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Pagado", True))
        Me.PagadoTextBox.Location = New System.Drawing.Point(234, 500)
        Me.PagadoTextBox.Name = "PagadoTextBox"
        Me.PagadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PagadoTextBox.TabIndex = 22
        '
        'PendienteTextBox
        '
        Me.PendienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Pendiente", True))
        Me.PendienteTextBox.Location = New System.Drawing.Point(447, 500)
        Me.PendienteTextBox.Name = "PendienteTextBox"
        Me.PendienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PendienteTextBox.TabIndex = 23
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(845, 481)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubTotalTextBox.TabIndex = 24
        Me.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ItebisTextBox
        '
        Me.ItebisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Itebis", True))
        Me.ItebisTextBox.Location = New System.Drawing.Point(845, 507)
        Me.ItebisTextBox.Name = "ItebisTextBox"
        Me.ItebisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ItebisTextBox.TabIndex = 25
        Me.ItebisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpuestoTextBox
        '
        Me.ImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Impuesto", True))
        Me.ImpuestoTextBox.Location = New System.Drawing.Point(641, 177)
        Me.ImpuestoTextBox.Name = "ImpuestoTextBox"
        Me.ImpuestoTextBox.Size = New System.Drawing.Size(51, 20)
        Me.ImpuestoTextBox.TabIndex = 28
        Me.ImpuestoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'Descripcion_PresupuestoTextBox
        '
        Me.Descripcion_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Descripcion_Presupuesto", True))
        Me.Descripcion_PresupuestoTextBox.Location = New System.Drawing.Point(535, 27)
        Me.Descripcion_PresupuestoTextBox.Name = "Descripcion_PresupuestoTextBox"
        Me.Descripcion_PresupuestoTextBox.Size = New System.Drawing.Size(363, 20)
        Me.Descripcion_PresupuestoTextBox.TabIndex = 8
        '
        'FrmFacturaMontajeEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 575)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Descripcion_PresupuestoTextBox)
        Me.Controls.Add(Me.ImpuestoTextBox)
        Me.Controls.Add(ItebisLabel)
        Me.Controls.Add(Me.ItebisTextBox)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(PendienteLabel)
        Me.Controls.Add(Me.PendienteTextBox)
        Me.Controls.Add(PagadoLabel)
        Me.Controls.Add(Me.PagadoTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.FacturaMontajeDetalleDataGridView)
        Me.Controls.Add(Me.EmpresasContratadasMontajeBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LblProyecto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnAprobarPago)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(FechaPAgoLabel)
        Me.Controls.Add(Me.FechaPAgoDateTimePicker)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdFacturaTextBox)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Name = "FrmFacturaMontajeEditar"
        Me.Text = "FrmFacturasMontaje"
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasContratadasMontajeBindingNavigator.ResumeLayout(False)
        Me.EmpresasContratadasMontajeBindingNavigator.PerformLayout()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Telefono1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents PresupuestoDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdFacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaPAgoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdEmpresaMontajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnAprobarPago As System.Windows.Forms.Button
    Friend WithEvents LblProyecto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents EmpresasContratadasMontajeBindingSource As BindingSource
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents TableAdapterManager As DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasContratadasMontajeBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpresasContratadasMontajeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FacturaMontajeTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter
    Friend WithEvents FacturaMontajeBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsPagosMontajeTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents PagoMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter
    Friend WithEvents PagoMontajeDetalleBindingSource As BindingSource
    Friend WithEvents FacturaMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter
    Friend WithEvents FacturaMontajeDetalleBindingSource As BindingSource
    Friend WithEvents FacturaMontajeDetalleDataGridView As DataGridView
    Friend WithEvents DsArticulos As DsArticulos
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager1 As DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents FKPagoMontajeEmpresasContratadasMontajeBindingSource As BindingSource
    Friend WithEvents PagoMontajeTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeTableAdapter
    Friend WithEvents FKPagoMontajeEmpresasContratadasMontajeBindingSource1 As BindingSource
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents FKPagoMontajeEmpresasContratadasMontajeBindingSource2 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents Añadir As DataGridViewButtonColumn
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PagadoTextBox As TextBox
    Friend WithEvents PendienteTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents ItebisTextBox As TextBox
    Friend WithEvents ImpuestoTextBox As TextBox
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPagosMontajeTableAdapters.PresupuestoTableAdapter
    Friend WithEvents Descripcion_PresupuestoTextBox As TextBox
End Class
