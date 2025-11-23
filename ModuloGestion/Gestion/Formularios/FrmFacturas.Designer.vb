<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturas
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
        Dim IdFacturaLabel As System.Windows.Forms.Label
        Dim IdEmpresaLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim SubtotalUS_Label As System.Windows.Forms.Label
        Dim ValorImpuestoLabel As System.Windows.Forms.Label
        Dim TotalUS_Label As System.Windows.Forms.Label
        Dim TasaCambioRD_Label As System.Windows.Forms.Label
        Dim NCFLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim AprobadaLabel As System.Windows.Forms.Label
        Dim TipoComprobanteLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim IdProyectoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FacturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFacturas = New ModuloGestion.DsFacturas()
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
        Me.FacturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ValorImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.TasaCambioRD_TextBox = New System.Windows.Forms.TextBox()
        Me.NCFTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscarPresupuesto = New System.Windows.Forms.Button()
        Me.BtnImprimirFactura = New System.Windows.Forms.Button()
        Me.AprobadaCheckBox = New System.Windows.Forms.CheckBox()
        Me.IdFAcruraDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtComprobante = New System.Windows.Forms.TextBox()
        Me.FacturaDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.FacturaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.EmpresasTableAdapter = New ModuloGestion.DsFacturasTableAdapters.EmpresasTableAdapter()
        Me.FacturaDetalleTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ClientesTableAdapter()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ProyectosTableAdapter()
        Me.ComprobantesFiscalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprobantesFiscalesTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ComprobantesFiscalesTableAdapter()
        Me.IdProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalRDSTextBox = New System.Windows.Forms.TextBox()
        Me.TotalUS_TextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalUS_TextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalRDSTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestolRDSTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoUS_TextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItbisRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdFacturaLabel = New System.Windows.Forms.Label()
        IdEmpresaLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        SubtotalUS_Label = New System.Windows.Forms.Label()
        ValorImpuestoLabel = New System.Windows.Forms.Label()
        TotalUS_Label = New System.Windows.Forms.Label()
        TasaCambioRD_Label = New System.Windows.Forms.Label()
        NCFLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        AprobadaLabel = New System.Windows.Forms.Label()
        TipoComprobanteLabel = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        IdProyectoLabel = New System.Windows.Forms.Label()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprobantesFiscalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdFacturaLabel
        '
        IdFacturaLabel.AutoSize = True
        IdFacturaLabel.Location = New System.Drawing.Point(33, 31)
        IdFacturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdFacturaLabel.Name = "IdFacturaLabel"
        IdFacturaLabel.Size = New System.Drawing.Size(69, 16)
        IdFacturaLabel.TabIndex = 1
        IdFacturaLabel.Text = "Id Factura:"
        '
        'IdEmpresaLabel
        '
        IdEmpresaLabel.AutoSize = True
        IdEmpresaLabel.Location = New System.Drawing.Point(33, 63)
        IdEmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdEmpresaLabel.Name = "IdEmpresaLabel"
        IdEmpresaLabel.Size = New System.Drawing.Size(79, 16)
        IdEmpresaLabel.TabIndex = 3
        IdEmpresaLabel.Text = "Id Empresa:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(33, 95)
        IdClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(65, 16)
        IdClienteLabel.TabIndex = 5
        IdClienteLabel.Text = "Id Cliente:"
        '
        'SubtotalUS_Label
        '
        SubtotalUS_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        SubtotalUS_Label.AutoSize = True
        SubtotalUS_Label.Location = New System.Drawing.Point(1009, 661)
        SubtotalUS_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubtotalUS_Label.Name = "SubtotalUS_Label"
        SubtotalUS_Label.Size = New System.Drawing.Size(62, 16)
        SubtotalUS_Label.TabIndex = 9
        SubtotalUS_Label.Text = "Subtotal :"
        '
        'ValorImpuestoLabel
        '
        ValorImpuestoLabel.AutoSize = True
        ValorImpuestoLabel.Location = New System.Drawing.Point(329, 66)
        ValorImpuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ValorImpuestoLabel.Name = "ValorImpuestoLabel"
        ValorImpuestoLabel.Size = New System.Drawing.Size(100, 16)
        ValorImpuestoLabel.TabIndex = 11
        ValorImpuestoLabel.Text = "Valor Impuesto:"
        '
        'TotalUS_Label
        '
        TotalUS_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        TotalUS_Label.AutoSize = True
        TotalUS_Label.Location = New System.Drawing.Point(1032, 725)
        TotalUS_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalUS_Label.Name = "TotalUS_Label"
        TotalUS_Label.Size = New System.Drawing.Size(44, 16)
        TotalUS_Label.TabIndex = 15
        TotalUS_Label.Text = "Total :"
        '
        'TasaCambioRD_Label
        '
        TasaCambioRD_Label.AutoSize = True
        TasaCambioRD_Label.Location = New System.Drawing.Point(329, 98)
        TasaCambioRD_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TasaCambioRD_Label.Name = "TasaCambioRD_Label"
        TasaCambioRD_Label.Size = New System.Drawing.Size(122, 16)
        TasaCambioRD_Label.TabIndex = 17
        TasaCambioRD_Label.Text = "Tasa Cambio RD$:"
        '
        'NCFLabel
        '
        NCFLabel.AutoSize = True
        NCFLabel.Location = New System.Drawing.Point(321, 31)
        NCFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NCFLabel.Name = "NCFLabel"
        NCFLabel.Size = New System.Drawing.Size(37, 16)
        NCFLabel.TabIndex = 21
        NCFLabel.Text = "NCF:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(752, 31)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(48, 16)
        FechaLabel.TabIndex = 23
        FechaLabel.Text = "Fecha:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(529, 66)
        MonedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(60, 16)
        MonedaLabel.TabIndex = 25
        MonedaLabel.Text = "Moneda:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(1032, 693)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(42, 16)
        Label1.TabIndex = 30
        Label1.Text = "Itebis:"
        '
        'AprobadaLabel
        '
        AprobadaLabel.AutoSize = True
        AprobadaLabel.Location = New System.Drawing.Point(804, 135)
        AprobadaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AprobadaLabel.Name = "AprobadaLabel"
        AprobadaLabel.Size = New System.Drawing.Size(71, 16)
        AprobadaLabel.TabIndex = 31
        AprobadaLabel.Text = "Aprobada:"
        '
        'TipoComprobanteLabel
        '
        TipoComprobanteLabel.AutoSize = True
        TipoComprobanteLabel.Location = New System.Drawing.Point(671, 66)
        TipoComprobanteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipoComprobanteLabel.Name = "TipoComprobanteLabel"
        TipoComprobanteLabel.Size = New System.Drawing.Size(123, 16)
        TipoComprobanteLabel.TabIndex = 34
        TipoComprobanteLabel.Text = "Tipo Comprobante:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(112, 159)
        NotasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(46, 16)
        NotasLabel.TabIndex = 40
        NotasLabel.Text = "Notas:"
        AddHandler NotasLabel.Click, AddressOf Me.NotasLabel_Click
        '
        'IdProyectoLabel
        '
        IdProyectoLabel.AutoSize = True
        IdProyectoLabel.Location = New System.Drawing.Point(23, 127)
        IdProyectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdProyectoLabel.Name = "IdProyectoLabel"
        IdProyectoLabel.Size = New System.Drawing.Size(78, 16)
        IdProyectoLabel.TabIndex = 41
        IdProyectoLabel.Text = "Id Proyecto:"
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturaBindingNavigatorSaveItem})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(1535, 27)
        Me.FacturaBindingNavigator.TabIndex = 0
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
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
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.FacturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdFacturaTextBox
        '
        Me.IdFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "IdFactura", True))
        Me.IdFacturaTextBox.Location = New System.Drawing.Point(171, 27)
        Me.IdFacturaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdFacturaTextBox.Name = "IdFacturaTextBox"
        Me.IdFacturaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdFacturaTextBox.TabIndex = 2
        '
        'IdEmpresaTextBox
        '
        Me.IdEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "IdEmpresa", True))
        Me.IdEmpresaTextBox.Location = New System.Drawing.Point(171, 59)
        Me.IdEmpresaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdEmpresaTextBox.Name = "IdEmpresaTextBox"
        Me.IdEmpresaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdEmpresaTextBox.TabIndex = 4
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "IdCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(171, 91)
        Me.IdClienteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdClienteTextBox.TabIndex = 6
        '
        'ValorImpuestoTextBox
        '
        Me.ValorImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "ValorImpuesto", True))
        Me.ValorImpuestoTextBox.Location = New System.Drawing.Point(467, 63)
        Me.ValorImpuestoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ValorImpuestoTextBox.Name = "ValorImpuestoTextBox"
        Me.ValorImpuestoTextBox.Size = New System.Drawing.Size(47, 22)
        Me.ValorImpuestoTextBox.TabIndex = 12
        '
        'TasaCambioRD_TextBox
        '
        Me.TasaCambioRD_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "TasaCambioRD$", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TasaCambioRD_TextBox.Enabled = False
        Me.TasaCambioRD_TextBox.Location = New System.Drawing.Point(467, 95)
        Me.TasaCambioRD_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TasaCambioRD_TextBox.Name = "TasaCambioRD_TextBox"
        Me.TasaCambioRD_TextBox.Size = New System.Drawing.Size(73, 22)
        Me.TasaCambioRD_TextBox.TabIndex = 18
        Me.TasaCambioRD_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NCFTextBox
        '
        Me.NCFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "NCF", True))
        Me.NCFTextBox.Location = New System.Drawing.Point(371, 27)
        Me.NCFTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NCFTextBox.Name = "NCFTextBox"
        Me.NCFTextBox.Size = New System.Drawing.Size(265, 22)
        Me.NCFTextBox.TabIndex = 22
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(813, 27)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(132, 22)
        Me.FechaDateTimePicker.TabIndex = 24
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Moneda", True))
        Me.MonedaTextBox.Location = New System.Drawing.Point(603, 63)
        Me.MonedaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(53, 22)
        Me.MonedaTextBox.TabIndex = 26
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(519, 185)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(161, 28)
        Me.BtnNuevo.TabIndex = 28
        Me.BtnNuevo.Text = "Nuevo Apunte"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnBuscarPresupuesto
        '
        Me.BtnBuscarPresupuesto.Location = New System.Drawing.Point(700, 187)
        Me.BtnBuscarPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscarPresupuesto.Name = "BtnBuscarPresupuesto"
        Me.BtnBuscarPresupuesto.Size = New System.Drawing.Size(161, 28)
        Me.BtnBuscarPresupuesto.TabIndex = 29
        Me.BtnBuscarPresupuesto.Text = "Buscar Presupuesto"
        Me.BtnBuscarPresupuesto.UseVisualStyleBackColor = True
        '
        'BtnImprimirFactura
        '
        Me.BtnImprimirFactura.Location = New System.Drawing.Point(623, 123)
        Me.BtnImprimirFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImprimirFactura.Name = "BtnImprimirFactura"
        Me.BtnImprimirFactura.Size = New System.Drawing.Size(161, 28)
        Me.BtnImprimirFactura.TabIndex = 31
        Me.BtnImprimirFactura.Text = "Imprimir Factura"
        Me.BtnImprimirFactura.UseVisualStyleBackColor = True
        '
        'AprobadaCheckBox
        '
        Me.AprobadaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FacturaBindingSource, "Aprobada", True))
        Me.AprobadaCheckBox.Location = New System.Drawing.Point(887, 129)
        Me.AprobadaCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AprobadaCheckBox.Name = "AprobadaCheckBox"
        Me.AprobadaCheckBox.Size = New System.Drawing.Size(33, 30)
        Me.AprobadaCheckBox.TabIndex = 32
        Me.AprobadaCheckBox.UseVisualStyleBackColor = True
        '
        'IdFAcruraDetalle
        '
        Me.IdFAcruraDetalle.DataPropertyName = "IdFAcruraDetalle"
        Me.IdFAcruraDetalle.HeaderText = "Id faCTURA"
        Me.IdFAcruraDetalle.MinimumWidth = 6
        Me.IdFAcruraDetalle.Name = "IdFAcruraDetalle"
        Me.IdFAcruraDetalle.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'TxtComprobante
        '
        Me.TxtComprobante.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "TipoComprobante", True))
        Me.TxtComprobante.Location = New System.Drawing.Point(813, 63)
        Me.TxtComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtComprobante.Name = "TxtComprobante"
        Me.TxtComprobante.Size = New System.Drawing.Size(64, 22)
        Me.TxtComprobante.TabIndex = 40
        '
        'FacturaDetalleDataGridView
        '
        Me.FacturaDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaDetalleDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FacturaDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.IdFactura, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.PrecioUS, Me.ItebisUS, Me.TotalUS, Me.PrecioRD, Me.ItbisRD, Me.TotalRd, Me.ItemPresupuesto})
        Me.FacturaDetalleDataGridView.DataSource = Me.FacturaDetalleBindingSource
        Me.FacturaDetalleDataGridView.Location = New System.Drawing.Point(37, 262)
        Me.FacturaDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.FacturaDetalleDataGridView.Name = "FacturaDetalleDataGridView"
        Me.FacturaDetalleDataGridView.RowHeadersWidth = 51
        Me.FacturaDetalleDataGridView.Size = New System.Drawing.Size(1372, 387)
        Me.FacturaDetalleDataGridView.TabIndex = 35
        '
        'FacturaDetalleBindingSource
        '
        Me.FacturaDetalleBindingSource.DataMember = "FacturaDetalle"
        Me.FacturaDetalleBindingSource.DataSource = Me.DsFacturas
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(171, 155)
        Me.NotasTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(287, 99)
        Me.NotasTextBox.TabIndex = 41
        Me.NotasTextBox.Visible = False
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.ComprobantesFiscalesTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.FacturaDetalleTableAdapter = Me.FacturaDetalleTableAdapter
        Me.TableAdapterManager.FacturaProformaDetalleTableAdapter = Nothing
        Me.TableAdapterManager.FacturaProformaTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsFacturasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'FacturaDetalleTableAdapter
        '
        Me.FacturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsFacturas
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsFacturas
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsFacturas
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'ComprobantesFiscalesBindingSource
        '
        Me.ComprobantesFiscalesBindingSource.DataMember = "ComprobantesFiscales"
        Me.ComprobantesFiscalesBindingSource.DataSource = Me.DsFacturas
        '
        'ComprobantesFiscalesTableAdapter
        '
        Me.ComprobantesFiscalesTableAdapter.ClearBeforeFill = True
        '
        'IdProyectoTextBox
        '
        Me.IdProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "IdProyecto", True))
        Me.IdProyectoTextBox.Location = New System.Drawing.Point(171, 123)
        Me.IdProyectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdProyectoTextBox.Name = "IdProyectoTextBox"
        Me.IdProyectoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdProyectoTextBox.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'TotalRDSTextBox
        '
        Me.TotalRDSTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalRDSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "TotalRDS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TotalRDSTextBox.Location = New System.Drawing.Point(1089, 725)
        Me.TotalRDSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalRDSTextBox.Name = "TotalRDSTextBox"
        Me.TotalRDSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalRDSTextBox.TabIndex = 44
        Me.TotalRDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalUS_TextBox
        '
        Me.TotalUS_TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalUS_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "TotalUS$", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TotalUS_TextBox.Location = New System.Drawing.Point(1086, 725)
        Me.TotalUS_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalUS_TextBox.Name = "TotalUS_TextBox"
        Me.TotalUS_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalUS_TextBox.TabIndex = 45
        Me.TotalUS_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubtotalUS_TextBox
        '
        Me.SubtotalUS_TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SubtotalUS_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "SubtotalUS$", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SubtotalUS_TextBox.Location = New System.Drawing.Point(1086, 657)
        Me.SubtotalUS_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubtotalUS_TextBox.Name = "SubtotalUS_TextBox"
        Me.SubtotalUS_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.SubtotalUS_TextBox.TabIndex = 46
        Me.SubtotalUS_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalRDSTextBox
        '
        Me.SubTotalRDSTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SubTotalRDSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "SubTotalRDS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SubTotalRDSTextBox.Location = New System.Drawing.Point(1086, 657)
        Me.SubTotalRDSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalRDSTextBox.Name = "SubTotalRDSTextBox"
        Me.SubTotalRDSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SubTotalRDSTextBox.TabIndex = 47
        Me.SubTotalRDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpuestolRDSTextBox
        '
        Me.ImpuestolRDSTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImpuestolRDSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "ImpuestolRDS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ImpuestolRDSTextBox.Location = New System.Drawing.Point(1086, 689)
        Me.ImpuestolRDSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestolRDSTextBox.Name = "ImpuestolRDSTextBox"
        Me.ImpuestolRDSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ImpuestolRDSTextBox.TabIndex = 48
        Me.ImpuestolRDSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpuestoUS_TextBox
        '
        Me.ImpuestoUS_TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImpuestoUS_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "ImpuestoUS$", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ImpuestoUS_TextBox.Location = New System.Drawing.Point(1086, 689)
        Me.ImpuestoUS_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestoUS_TextBox.Name = "ImpuestoUS_TextBox"
        Me.ImpuestoUS_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.ImpuestoUS_TextBox.TabIndex = 49
        Me.ImpuestoUS_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'IdFactura
        '
        Me.IdFactura.DataPropertyName = "IdFactura"
        Me.IdFactura.HeaderText = "IdFactura"
        Me.IdFactura.MinimumWidth = 6
        Me.IdFactura.Name = "IdFactura"
        Me.IdFactura.Visible = False
        Me.IdFactura.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n4"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 65
        '
        'PrecioUS
        '
        Me.PrecioUS.DataPropertyName = "PrecioUS$"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n4"
        Me.PrecioUS.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioUS.HeaderText = "Precio US$"
        Me.PrecioUS.MinimumWidth = 6
        Me.PrecioUS.Name = "PrecioUS"
        Me.PrecioUS.Width = 125
        '
        'ItebisUS
        '
        Me.ItebisUS.DataPropertyName = "ItebisUS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n4"
        Me.ItebisUS.DefaultCellStyle = DataGridViewCellStyle4
        Me.ItebisUS.HeaderText = "ItebisUS"
        Me.ItebisUS.MinimumWidth = 6
        Me.ItebisUS.Name = "ItebisUS"
        Me.ItebisUS.Width = 125
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalPartidaUS$"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalUS.HeaderText = "Total US$"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.Width = 125
        '
        'PrecioRD
        '
        Me.PrecioRD.DataPropertyName = "PrecioRD$"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n4"
        Me.PrecioRD.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioRD.HeaderText = "Precio RD$"
        Me.PrecioRD.MinimumWidth = 6
        Me.PrecioRD.Name = "PrecioRD"
        Me.PrecioRD.Width = 125
        '
        'ItbisRD
        '
        Me.ItbisRD.DataPropertyName = "ItbisRD"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n4"
        Me.ItbisRD.DefaultCellStyle = DataGridViewCellStyle7
        Me.ItbisRD.HeaderText = "ItbisRD"
        Me.ItbisRD.MinimumWidth = 6
        Me.ItbisRD.Name = "ItbisRD"
        Me.ItbisRD.Width = 125
        '
        'TotalRd
        '
        Me.TotalRd.DataPropertyName = "TotalPartidaRD$"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.TotalRd.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalRd.HeaderText = "Total RD$"
        Me.TotalRd.MinimumWidth = 6
        Me.TotalRd.Name = "TotalRd"
        Me.TotalRd.Width = 125
        '
        'ItemPresupuesto
        '
        Me.ItemPresupuesto.DataPropertyName = "ItemPresupuesto"
        Me.ItemPresupuesto.HeaderText = "ItemPresupuesto"
        Me.ItemPresupuesto.MinimumWidth = 6
        Me.ItemPresupuesto.Name = "ItemPresupuesto"
        Me.ItemPresupuesto.Visible = False
        Me.ItemPresupuesto.Width = 125
        '
        'FrmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1535, 753)
        Me.Controls.Add(Me.ImpuestoUS_TextBox)
        Me.Controls.Add(Me.ImpuestolRDSTextBox)
        Me.Controls.Add(Me.SubTotalRDSTextBox)
        Me.Controls.Add(Me.SubtotalUS_TextBox)
        Me.Controls.Add(Me.TotalUS_TextBox)
        Me.Controls.Add(Me.TotalRDSTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IdProyectoLabel)
        Me.Controls.Add(Me.IdProyectoTextBox)
        Me.Controls.Add(NotasLabel)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(Me.TxtComprobante)
        Me.Controls.Add(Me.FacturaDetalleDataGridView)
        Me.Controls.Add(TipoComprobanteLabel)
        Me.Controls.Add(AprobadaLabel)
        Me.Controls.Add(Me.AprobadaCheckBox)
        Me.Controls.Add(Me.BtnImprimirFactura)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.BtnBuscarPresupuesto)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(IdFacturaLabel)
        Me.Controls.Add(Me.IdFacturaTextBox)
        Me.Controls.Add(IdEmpresaLabel)
        Me.Controls.Add(Me.IdEmpresaTextBox)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteTextBox)
        Me.Controls.Add(SubtotalUS_Label)
        Me.Controls.Add(ValorImpuestoLabel)
        Me.Controls.Add(Me.ValorImpuestoTextBox)
        Me.Controls.Add(TotalUS_Label)
        Me.Controls.Add(TasaCambioRD_Label)
        Me.Controls.Add(Me.TasaCambioRD_TextBox)
        Me.Controls.Add(NCFLabel)
        Me.Controls.Add(Me.NCFTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(MonedaLabel)
        Me.Controls.Add(Me.MonedaTextBox)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm Facturas"
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprobantesFiscalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsFacturas As ModuloGestion.DsFacturas
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsFacturasTableAdapters.TableAdapterManager
    Friend WithEvents FacturaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FacturaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdFacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdEmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorImpuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TasaCambioRD_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NCFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MonedaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FacturaDetalleTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsFacturasTableAdapters.EmpresasTableAdapter
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnImprimirFactura As System.Windows.Forms.Button
    Friend WithEvents AprobadaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IdFAcruraDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtComprobante As System.Windows.Forms.TextBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsFacturasTableAdapters.ClientesTableAdapter
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsFacturasTableAdapters.ProyectosTableAdapter
    Friend WithEvents FacturaDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FacturaDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComprobantesFiscalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprobantesFiscalesTableAdapter As ModuloGestion.DsFacturasTableAdapters.ComprobantesFiscalesTableAdapter
    Friend WithEvents IdProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TotalRDSTextBox As TextBox
    Friend WithEvents TotalUS_TextBox As TextBox
    Friend WithEvents SubtotalUS_TextBox As TextBox
    Friend WithEvents SubTotalRDSTextBox As TextBox
    Friend WithEvents ImpuestolRDSTextBox As TextBox
    Friend WithEvents ImpuestoUS_TextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdFactura As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUS As DataGridViewTextBoxColumn
    Friend WithEvents ItebisUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRD As DataGridViewTextBoxColumn
    Friend WithEvents ItbisRD As DataGridViewTextBoxColumn
    Friend WithEvents TotalRd As DataGridViewTextBoxColumn
    Friend WithEvents ItemPresupuesto As DataGridViewTextBoxColumn
End Class
