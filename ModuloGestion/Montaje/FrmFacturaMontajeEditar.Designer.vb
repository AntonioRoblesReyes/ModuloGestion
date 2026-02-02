<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturaMontajeEditar
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
        Dim IdEmpresaMontajeLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim Telefono1Label As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim FechaPAgoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim PagadoLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim ItebisLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Descripcion_PresupuestoLabel As System.Windows.Forms.Label
        Dim RetencionIRSLabel As System.Windows.Forms.Label
        Dim TotalIrsLabel As System.Windows.Forms.Label
        Dim TotalConIrsLabel As System.Windows.Forms.Label
        Dim PendienteInstaladorLabel As System.Windows.Forms.Label
        Dim PendientefacturaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturaMontajeEditar))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDetallePresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticulo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Previsto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Añadir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaPAgoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnNuevalínea = New System.Windows.Forms.Button()
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
        Me.FacturaMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.FacturaMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagadoTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ItebisTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_PresupuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetencionIRSTextBox = New System.Windows.Forms.TextBox()
        Me.TotalIrsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalConIrsTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.FacturaMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.PagoMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter()
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PresupuestoDetalleTableAdapter()
        Me.PagoMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PresupuestoTableAdapter()
        Me.IdFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.PendienteInstaladorTextBox = New System.Windows.Forms.TextBox()
        Me.PendientefacturaTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaMontajeDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        Telefono1Label = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        FechaPAgoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        PagadoLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        ItebisLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Descripcion_PresupuestoLabel = New System.Windows.Forms.Label()
        RetencionIRSLabel = New System.Windows.Forms.Label()
        TotalIrsLabel = New System.Windows.Forms.Label()
        TotalConIrsLabel = New System.Windows.Forms.Label()
        PendienteInstaladorLabel = New System.Windows.Forms.Label()
        PendientefacturaLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasContratadasMontajeBindingNavigator.SuspendLayout()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(13, 27)
        IdEmpresaMontajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(175, 25)
        IdEmpresaMontajeLabel.TabIndex = 1
        IdEmpresaMontajeLabel.Text = "Id Empresa Montaje:"
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(55, 59)
        RazonSocialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(116, 25)
        RazonSocialLabel.TabIndex = 3
        RazonSocialLabel.Text = "Razon Social:"
        '
        'Telefono1Label
        '
        Telefono1Label.AutoSize = True
        Telefono1Label.Location = New System.Drawing.Point(75, 91)
        Telefono1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefono1Label.Name = "Telefono1Label"
        Telefono1Label.Size = New System.Drawing.Size(93, 25)
        Telefono1Label.TabIndex = 5
        Telefono1Label.Text = "Telefono1:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(43, 272)
        IdPagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(93, 25)
        IdPagoLabel.TabIndex = 9
        IdPagoLabel.Text = "Id Factura:"
        '
        'FechaPAgoLabel
        '
        FechaPAgoLabel.AutoSize = True
        FechaPAgoLabel.Location = New System.Drawing.Point(279, 272)
        FechaPAgoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaPAgoLabel.Name = "FechaPAgoLabel"
        FechaPAgoLabel.Size = New System.Drawing.Size(106, 25)
        FechaPAgoLabel.TabIndex = 10
        FechaPAgoLabel.Text = "Fecha Pago:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(1073, 662)
        TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(53, 25)
        TotalLabel.TabIndex = 20
        TotalLabel.Text = "Total:"
        '
        'PagadoLabel
        '
        PagadoLabel.AutoSize = True
        PagadoLabel.Location = New System.Drawing.Point(241, 619)
        PagadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PagadoLabel.Name = "PagadoLabel"
        PagadoLabel.Size = New System.Drawing.Size(76, 25)
        PagadoLabel.TabIndex = 21
        PagadoLabel.Text = "Pagado:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(1044, 596)
        SubTotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(89, 25)
        SubTotalLabel.TabIndex = 23
        SubTotalLabel.Text = "Sub Total:"
        '
        'ItebisLabel
        '
        ItebisLabel.AutoSize = True
        ItebisLabel.Location = New System.Drawing.Point(1072, 628)
        ItebisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ItebisLabel.Name = "ItebisLabel"
        ItebisLabel.Size = New System.Drawing.Size(59, 25)
        ItebisLabel.TabIndex = 24
        ItebisLabel.Text = "Itebis:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(804, 222)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(55, 25)
        Label2.TabIndex = 29
        Label2.Text = "Itebis"
        '
        'Descripcion_PresupuestoLabel
        '
        Descripcion_PresupuestoLabel.AutoSize = True
        Descripcion_PresupuestoLabel.Location = New System.Drawing.Point(88, 123)
        Descripcion_PresupuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Descripcion_PresupuestoLabel.Name = "Descripcion_PresupuestoLabel"
        Descripcion_PresupuestoLabel.Size = New System.Drawing.Size(211, 25)
        Descripcion_PresupuestoLabel.TabIndex = 7
        Descripcion_PresupuestoLabel.Text = "Descripcion Presupuesto:"
        '
        'RetencionIRSLabel
        '
        RetencionIRSLabel.AutoSize = True
        RetencionIRSLabel.Location = New System.Drawing.Point(973, 225)
        RetencionIRSLabel.Name = "RetencionIRSLabel"
        RetencionIRSLabel.Size = New System.Drawing.Size(124, 25)
        RetencionIRSLabel.TabIndex = 29
        RetencionIRSLabel.Text = "Retencion IRS:"
        '
        'TotalIrsLabel
        '
        TotalIrsLabel.AutoSize = True
        TotalIrsLabel.Location = New System.Drawing.Point(816, 615)
        TotalIrsLabel.Name = "TotalIrsLabel"
        TotalIrsLabel.Size = New System.Drawing.Size(77, 25)
        TotalIrsLabel.TabIndex = 31
        TotalIrsLabel.Text = "Total Irs:"
        '
        'TotalConIrsLabel
        '
        TotalConIrsLabel.AutoSize = True
        TotalConIrsLabel.Location = New System.Drawing.Point(786, 648)
        TotalConIrsLabel.Name = "TotalConIrsLabel"
        TotalConIrsLabel.Size = New System.Drawing.Size(114, 25)
        TotalConIrsLabel.TabIndex = 33
        TotalConIrsLabel.Text = "Total Con Irs:"
        '
        'PendienteInstaladorLabel
        '
        PendienteInstaladorLabel.AutoSize = True
        PendienteInstaladorLabel.Location = New System.Drawing.Point(462, 622)
        PendienteInstaladorLabel.Name = "PendienteInstaladorLabel"
        PendienteInstaladorLabel.Size = New System.Drawing.Size(177, 25)
        PendienteInstaladorLabel.TabIndex = 35
        PendienteInstaladorLabel.Text = "Pendiente Instalador:"
        '
        'PendientefacturaLabel
        '
        PendientefacturaLabel.AutoSize = True
        PendientefacturaLabel.Location = New System.Drawing.Point(486, 655)
        PendientefacturaLabel.Name = "PendientefacturaLabel"
        PendientefacturaLabel.Size = New System.Drawing.Size(147, 25)
        PendientefacturaLabel.TabIndex = 36
        PendientefacturaLabel.Text = "Pendientefactura:"
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Telefono1", True))
        Me.Telefono1TextBox.Enabled = False
        Me.Telefono1TextBox.Location = New System.Drawing.Point(160, 87)
        Me.Telefono1TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(132, 31)
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
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Descripcion_PresupuestoLabel)
        Me.GroupBox1.Controls.Add(Me.RazonSocialTextBox)
        Me.GroupBox1.Controls.Add(Me.IdEmpresaMontajeTextBox)
        Me.GroupBox1.Controls.Add(Telefono1Label)
        Me.GroupBox1.Controls.Add(IdEmpresaMontajeLabel)
        Me.GroupBox1.Controls.Add(Me.Telefono1TextBox)
        Me.GroupBox1.Controls.Add(RazonSocialLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(433, 170)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empresa Montaje"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "RazonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(160, 55)
        Me.RazonSocialTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(248, 31)
        Me.RazonSocialTextBox.TabIndex = 7
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "IdEmpresaMontaje", True))
        Me.IdEmpresaMontajeTextBox.Enabled = False
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(160, 23)
        Me.IdEmpresaMontajeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(132, 31)
        Me.IdEmpresaMontajeTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Presupuesto"
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.AutoSize = True
        Me.LblPresupuesto.Location = New System.Drawing.Point(565, 46)
        Me.LblPresupuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(131, 25)
        Me.LblPresupuesto.TabIndex = 9
        Me.LblPresupuesto.Text = "Id Presupuesto"
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PresupuestoDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PresupuestoDetalleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresupuestoDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetallePresupuesto, Me.IdArticulo, Me.Cantidad, Me.Previsto, Me.PrecioVenta, Me.Añadir})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.EnableHeadersVisualStyles = False
        Me.PresupuestoDetalleDataGridView.GridColor = System.Drawing.Color.Gainsboro
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(477, 65)
        Me.PresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.ReadOnly = True
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(824, 146)
        Me.PresupuestoDetalleDataGridView.TabIndex = 9
        '
        'IdDetallePresupuesto
        '
        Me.IdDetallePresupuesto.DataPropertyName = "IdDetalle_Presupuesto"
        Me.IdDetallePresupuesto.HeaderText = "IdDetalle"
        Me.IdDetallePresupuesto.MinimumWidth = 6
        Me.IdDetallePresupuesto.Name = "IdDetallePresupuesto"
        Me.IdDetallePresupuesto.ReadOnly = True
        Me.IdDetallePresupuesto.Width = 90
        '
        'IdArticulo
        '
        Me.IdArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdArticulo.DataPropertyName = "Articulo"
        Me.IdArticulo.DataSource = Me.ArticulosBindingSource
        Me.IdArticulo.DisplayMember = "Descripcion_articulo"
        Me.IdArticulo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdArticulo.HeaderText = "Articulo"
        Me.IdArticulo.MinimumWidth = 6
        Me.IdArticulo.Name = "IdArticulo"
        Me.IdArticulo.ReadOnly = True
        Me.IdArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdArticulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdArticulo.ValueMember = "IdArticulo"
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
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 75
        '
        'Previsto
        '
        Me.Previsto.DataPropertyName = "CostoMontaje"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Previsto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Previsto.HeaderText = "Previsto"
        Me.Previsto.MinimumWidth = 6
        Me.Previsto.Name = "Previsto"
        Me.Previsto.ReadOnly = True
        Me.Previsto.Width = 75
        '
        'PrecioVenta
        '
        Me.PrecioVenta.DataPropertyName = "Precio_Ajustado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.PrecioVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioVenta.HeaderText = "PrecioVenta"
        Me.PrecioVenta.MinimumWidth = 6
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.ReadOnly = True
        Me.PrecioVenta.Width = 90
        '
        'Añadir
        '
        Me.Añadir.HeaderText = "Añadir"
        Me.Añadir.MinimumWidth = 6
        Me.Añadir.Name = "Añadir"
        Me.Añadir.ReadOnly = True
        Me.Añadir.Width = 70
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'FechaPAgoDateTimePicker
        '
        Me.FechaPAgoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPAgoDateTimePicker.Location = New System.Drawing.Point(395, 270)
        Me.FechaPAgoDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaPAgoDateTimePicker.Name = "FechaPAgoDateTimePicker"
        Me.FechaPAgoDateTimePicker.Size = New System.Drawing.Size(131, 31)
        Me.FechaPAgoDateTimePicker.TabIndex = 11
        '
        'BtnNuevalínea
        '
        Me.BtnNuevalínea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnNuevalínea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevalínea.FlatAppearance.BorderSize = 0
        Me.BtnNuevalínea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevalínea.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevalínea.Location = New System.Drawing.Point(652, 266)
        Me.BtnNuevalínea.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevalínea.Name = "BtnNuevalínea"
        Me.BtnNuevalínea.Size = New System.Drawing.Size(124, 28)
        Me.BtnNuevalínea.TabIndex = 13
        Me.BtnNuevalínea.Text = "Nueva línea"
        Me.BtnNuevalínea.UseVisualStyleBackColor = False
        '
        'BtnAprobarPago
        '
        Me.BtnAprobarPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAprobarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAprobarPago.FlatAppearance.BorderSize = 0
        Me.BtnAprobarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAprobarPago.ForeColor = System.Drawing.Color.Black
        Me.BtnAprobarPago.Location = New System.Drawing.Point(128, 233)
        Me.BtnAprobarPago.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAprobarPago.Name = "BtnAprobarPago"
        Me.BtnAprobarPago.Size = New System.Drawing.Size(124, 28)
        Me.BtnAprobarPago.TabIndex = 16
        Me.BtnAprobarPago.Text = "Aprobar pago"
        Me.BtnAprobarPago.UseVisualStyleBackColor = False
        '
        'LblProyecto
        '
        Me.LblProyecto.AutoSize = True
        Me.LblProyecto.Location = New System.Drawing.Point(565, 30)
        Me.LblProyecto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(82, 25)
        Me.LblProyecto.TabIndex = 18
        Me.LblProyecto.Text = "Proyecto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(439, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Proyecto"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(993, 265)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 28)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ArticulosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ArticulosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ArticulosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.ArticulosDataGridView.EnableHeadersVisualStyles = False
        Me.ArticulosDataGridView.GridColor = System.Drawing.Color.Gainsboro
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(501, 80)
        Me.ArticulosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.RowHeadersWidth = 51
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(580, 74)
        Me.ArticulosDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 90
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 90
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn14.HeaderText = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 110
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "M2Pintura"
        Me.DataGridViewTextBoxColumn15.HeaderText = "M2Pintura"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 90
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "HorasTrabajoTallerPintura"
        Me.DataGridViewTextBoxColumn16.HeaderText = "HorasTrabajoTallerPintura"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 120
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DiseñoArticulo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "DiseñoArticulo"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 110
        '
        'EmpresasContratadasMontajeBindingNavigator
        '
        Me.EmpresasContratadasMontajeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasContratadasMontajeBindingNavigator.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EmpresasContratadasMontajeBindingNavigator.BindingSource = Me.EmpresasContratadasMontajeBindingSource
        Me.EmpresasContratadasMontajeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasContratadasMontajeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasContratadasMontajeBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EmpresasContratadasMontajeBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpresasContratadasMontajeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasContratadasMontajeBindingNavigatorSaveItem})
        Me.EmpresasContratadasMontajeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasContratadasMontajeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasContratadasMontajeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasContratadasMontajeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasContratadasMontajeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasContratadasMontajeBindingNavigator.Name = "EmpresasContratadasMontajeBindingNavigator"
        Me.EmpresasContratadasMontajeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasContratadasMontajeBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.EmpresasContratadasMontajeBindingNavigator.Size = New System.Drawing.Size(1348, 30)
        Me.EmpresasContratadasMontajeBindingNavigator.TabIndex = 20
        Me.EmpresasContratadasMontajeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 25)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'EmpresasContratadasMontajeBindingNavigatorSaveItem
        '
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasContratadasMontajeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Name = "EmpresasContratadasMontajeBindingNavigatorSaveItem"
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 25)
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FacturaMontajeDetalleDataGridView
        '
        Me.FacturaMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FacturaMontajeDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.IdFacturaMontajeDetalle, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Descripcion, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn18})
        Me.FacturaMontajeDetalleDataGridView.DataSource = Me.FacturaMontajeDetalleBindingSource
        Me.FacturaMontajeDetalleDataGridView.EnableHeadersVisualStyles = False
        Me.FacturaMontajeDetalleDataGridView.GridColor = System.Drawing.Color.Gainsboro
        Me.FacturaMontajeDetalleDataGridView.Location = New System.Drawing.Point(61, 314)
        Me.FacturaMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.FacturaMontajeDetalleDataGridView.Name = "FacturaMontajeDetalleDataGridView"
        Me.FacturaMontajeDetalleDataGridView.RowHeadersWidth = 51
        Me.FacturaMontajeDetalleDataGridView.Size = New System.Drawing.Size(1185, 271)
        Me.FacturaMontajeDetalleDataGridView.TabIndex = 20
        '
        'FacturaMontajeDetalleBindingSource
        '
        Me.FacturaMontajeDetalleBindingSource.DataMember = "FacturaMontajeDetalle"
        Me.FacturaMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
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
        Me.TotalTextBox.Location = New System.Drawing.Point(1127, 658)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(132, 31)
        Me.TotalTextBox.TabIndex = 21
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FacturaMontaje"
        Me.FacturaMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PagadoTextBox
        '
        Me.PagadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Pagado", True))
        Me.PagadoTextBox.Location = New System.Drawing.Point(312, 615)
        Me.PagadoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PagadoTextBox.Name = "PagadoTextBox"
        Me.PagadoTextBox.ReadOnly = True
        Me.PagadoTextBox.Size = New System.Drawing.Size(132, 31)
        Me.PagadoTextBox.TabIndex = 22
        Me.PagadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(1127, 592)
        Me.SubTotalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(132, 31)
        Me.SubTotalTextBox.TabIndex = 24
        Me.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ItebisTextBox
        '
        Me.ItebisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Itebis", True))
        Me.ItebisTextBox.Location = New System.Drawing.Point(1127, 624)
        Me.ItebisTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItebisTextBox.Name = "ItebisTextBox"
        Me.ItebisTextBox.Size = New System.Drawing.Size(132, 31)
        Me.ItebisTextBox.TabIndex = 25
        Me.ItebisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpuestoTextBox
        '
        Me.ImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Impuesto", True))
        Me.ImpuestoTextBox.Location = New System.Drawing.Point(855, 218)
        Me.ImpuestoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestoTextBox.Name = "ImpuestoTextBox"
        Me.ImpuestoTextBox.Size = New System.Drawing.Size(67, 31)
        Me.ImpuestoTextBox.TabIndex = 28
        Me.ImpuestoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Descripcion_PresupuestoTextBox
        '
        Me.Descripcion_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Descripcion_Presupuesto", True))
        Me.Descripcion_PresupuestoTextBox.Location = New System.Drawing.Point(713, 33)
        Me.Descripcion_PresupuestoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion_PresupuestoTextBox.Name = "Descripcion_PresupuestoTextBox"
        Me.Descripcion_PresupuestoTextBox.Size = New System.Drawing.Size(483, 31)
        Me.Descripcion_PresupuestoTextBox.TabIndex = 8
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPagosMontaje
        '
        'RetencionIRSTextBox
        '
        Me.RetencionIRSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "RetencionIRS", True))
        Me.RetencionIRSTextBox.Location = New System.Drawing.Point(1075, 222)
        Me.RetencionIRSTextBox.Name = "RetencionIRSTextBox"
        Me.RetencionIRSTextBox.Size = New System.Drawing.Size(100, 31)
        Me.RetencionIRSTextBox.TabIndex = 30
        Me.RetencionIRSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalIrsTextBox
        '
        Me.TotalIrsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "TotalIrs", True))
        Me.TotalIrsTextBox.Location = New System.Drawing.Point(886, 612)
        Me.TotalIrsTextBox.Name = "TotalIrsTextBox"
        Me.TotalIrsTextBox.Size = New System.Drawing.Size(100, 31)
        Me.TotalIrsTextBox.TabIndex = 32
        Me.TotalIrsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalConIrsTextBox
        '
        Me.TotalConIrsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "TotalConIrs", True))
        Me.TotalConIrsTextBox.Location = New System.Drawing.Point(886, 645)
        Me.TotalConIrsTextBox.Name = "TotalConIrsTextBox"
        Me.TotalConIrsTextBox.Size = New System.Drawing.Size(100, 31)
        Me.TotalConIrsTextBox.TabIndex = 34
        Me.TotalConIrsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'PagoMontajeDetalleBindingSource
        '
        Me.PagoMontajeDetalleBindingSource.DataMember = "PagoMontajeDetalle"
        Me.PagoMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PagoMontajeTableAdapter
        '
        Me.PagoMontajeTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'IdFacturaTextBox
        '
        Me.IdFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "IdFacturaMontaje", True))
        Me.IdFacturaTextBox.Location = New System.Drawing.Point(152, 269)
        Me.IdFacturaTextBox.Name = "IdFacturaTextBox"
        Me.IdFacturaTextBox.Size = New System.Drawing.Size(100, 31)
        Me.IdFacturaTextBox.TabIndex = 35
        '
        'PendienteInstaladorTextBox
        '
        Me.PendienteInstaladorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "PendienteInstalador", True))
        Me.PendienteInstaladorTextBox.Location = New System.Drawing.Point(615, 619)
        Me.PendienteInstaladorTextBox.Name = "PendienteInstaladorTextBox"
        Me.PendienteInstaladorTextBox.Size = New System.Drawing.Size(100, 31)
        Me.PendienteInstaladorTextBox.TabIndex = 36
        '
        'PendientefacturaTextBox
        '
        Me.PendientefacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Pendientefactura", True))
        Me.PendientefacturaTextBox.Location = New System.Drawing.Point(615, 652)
        Me.PendientefacturaTextBox.Name = "PendientefacturaTextBox"
        Me.PendientefacturaTextBox.Size = New System.Drawing.Size(100, 31)
        Me.PendientefacturaTextBox.TabIndex = 37
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'IdFacturaMontajeDetalle
        '
        Me.IdFacturaMontajeDetalle.DataPropertyName = "IdFacturaMontajeDetalle"
        Me.IdFacturaMontajeDetalle.HeaderText = "IdF Detalle"
        Me.IdFacturaMontajeDetalle.MinimumWidth = 6
        Me.IdFacturaMontajeDetalle.Name = "IdFacturaMontajeDetalle"
        Me.IdFacturaMontajeDetalle.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id Detalle_Presupuesto"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cantidad"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Precio"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn10.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn18.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 90
        '
        'FrmFacturaMontajeEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 708)
        Me.Controls.Add(PendientefacturaLabel)
        Me.Controls.Add(Me.PendientefacturaTextBox)
        Me.Controls.Add(PendienteInstaladorLabel)
        Me.Controls.Add(Me.PendienteInstaladorTextBox)
        Me.Controls.Add(Me.IdFacturaTextBox)
        Me.Controls.Add(TotalConIrsLabel)
        Me.Controls.Add(Me.TotalConIrsTextBox)
        Me.Controls.Add(TotalIrsLabel)
        Me.Controls.Add(Me.TotalIrsTextBox)
        Me.Controls.Add(RetencionIRSLabel)
        Me.Controls.Add(Me.RetencionIRSTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Descripcion_PresupuestoTextBox)
        Me.Controls.Add(Me.ImpuestoTextBox)
        Me.Controls.Add(ItebisLabel)
        Me.Controls.Add(Me.ItebisTextBox)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
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
        Me.Controls.Add(Me.BtnNuevalínea)
        Me.Controls.Add(FechaPAgoLabel)
        Me.Controls.Add(Me.FechaPAgoDateTimePicker)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1150, 600)
        Me.Name = "FrmFacturaMontajeEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura de montaje"
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasContratadasMontajeBindingNavigator.ResumeLayout(False)
        Me.EmpresasContratadasMontajeBindingNavigator.PerformLayout()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPagoMontajeEmpresasContratadasMontajeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Telefono1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents PresupuestoDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FechaPAgoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdEmpresaMontajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevalínea As System.Windows.Forms.Button
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
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PagadoTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents ItebisTextBox As TextBox
    Friend WithEvents ImpuestoTextBox As TextBox
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPagosMontajeTableAdapters.PresupuestoTableAdapter
    Friend WithEvents Descripcion_PresupuestoTextBox As TextBox
    Friend WithEvents RetencionIRSTextBox As TextBox
    Friend WithEvents TotalIrsTextBox As TextBox
    Friend WithEvents TotalConIrsTextBox As TextBox
    Friend WithEvents IdFacturaTextBox As TextBox
    Friend WithEvents PendienteInstaladorTextBox As TextBox
    Friend WithEvents PendientefacturaTextBox As TextBox
    Friend WithEvents IdDetallePresupuesto As DataGridViewTextBoxColumn
    Friend WithEvents IdArticulo As DataGridViewComboBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Previsto As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents Añadir As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaMontajeDetalle As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
End Class
