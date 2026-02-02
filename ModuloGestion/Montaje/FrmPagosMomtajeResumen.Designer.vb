<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagosMomtajeResumen
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtItebis = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.BtnPendientes = New System.Windows.Forms.Button()
        Me.BtnFiltroTodos = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.pnlTotals = New System.Windows.Forms.Panel()
        Me.splitMain = New System.Windows.Forms.SplitContainer()
        Me.PagoMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPagoMontaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresaMontaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteAsignar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Imprimir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PagoMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.splitRight = New System.Windows.Forms.SplitContainer()
        Me.EmpresasContratadasMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.PagoMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlTotals.SuspendLayout()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        CType(Me.PagoMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitRight.Panel1.SuspendLayout()
        Me.splitRight.Panel2.SuspendLayout()
        Me.splitRight.SuspendLayout()
        CType(Me.EmpresasContratadasMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 26)
        Me.TextBox1.TabIndex = 0
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.BackColor = System.Drawing.Color.White
        Me.TxtSubtotal.Location = New System.Drawing.Point(0, 22)
        Me.TxtSubtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(150, 26)
        Me.TxtSubtotal.TabIndex = 1
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtItebis
        '
        Me.TxtItebis.BackColor = System.Drawing.Color.White
        Me.TxtItebis.Location = New System.Drawing.Point(180, 22)
        Me.TxtItebis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtItebis.Name = "TxtItebis"
        Me.TxtItebis.ReadOnly = True
        Me.TxtItebis.Size = New System.Drawing.Size(150, 26)
        Me.TxtItebis.TabIndex = 3
        Me.TxtItebis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Location = New System.Drawing.Point(360, 22)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(150, 26)
        Me.TxtTotal.TabIndex = 5
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pagado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Asignado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pendiente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(254, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Nuevo Pago"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.BtnPendientes)
        Me.pnlHeader.Controls.Add(Me.BtnFiltroTodos)
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.pnlSearch)
        Me.pnlHeader.Controls.Add(Me.pnlTotals)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(18, 14, 18, 10)
        Me.pnlHeader.Size = New System.Drawing.Size(1924, 132)
        Me.pnlHeader.TabIndex = 1
        '
        'BtnPendientes
        '
        Me.BtnPendientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BtnPendientes.FlatAppearance.BorderSize = 0
        Me.BtnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPendientes.ForeColor = System.Drawing.Color.White
        Me.BtnPendientes.Location = New System.Drawing.Point(704, 62)
        Me.BtnPendientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPendientes.Name = "BtnPendientes"
        Me.BtnPendientes.Size = New System.Drawing.Size(150, 30)
        Me.BtnPendientes.TabIndex = 3
        Me.BtnPendientes.Text = "Pendientes"
        Me.BtnPendientes.UseVisualStyleBackColor = False
        '
        'BtnFiltroTodos
        '
        Me.BtnFiltroTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BtnFiltroTodos.FlatAppearance.BorderSize = 0
        Me.BtnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFiltroTodos.ForeColor = System.Drawing.Color.White
        Me.BtnFiltroTodos.Location = New System.Drawing.Point(523, 60)
        Me.BtnFiltroTodos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFiltroTodos.Name = "BtnFiltroTodos"
        Me.BtnFiltroTodos.Size = New System.Drawing.Size(150, 30)
        Me.BtnFiltroTodos.TabIndex = 2
        Me.BtnFiltroTodos.Text = "Todos"
        Me.BtnFiltroTodos.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(18, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(388, 45)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Resumen Pagos Montaje"
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.Transparent
        Me.pnlSearch.Controls.Add(Me.TextBox1)
        Me.pnlSearch.Controls.Add(Me.Button1)
        Me.pnlSearch.Location = New System.Drawing.Point(22, 48)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(420, 72)
        Me.pnlSearch.TabIndex = 1
        '
        'pnlTotals
        '
        Me.pnlTotals.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotals.Controls.Add(Me.Label2)
        Me.pnlTotals.Controls.Add(Me.TxtSubtotal)
        Me.pnlTotals.Controls.Add(Me.Label1)
        Me.pnlTotals.Controls.Add(Me.TxtItebis)
        Me.pnlTotals.Controls.Add(Me.Label3)
        Me.pnlTotals.Controls.Add(Me.TxtTotal)
        Me.pnlTotals.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTotals.Location = New System.Drawing.Point(1366, 14)
        Me.pnlTotals.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTotals.Name = "pnlTotals"
        Me.pnlTotals.Size = New System.Drawing.Size(540, 108)
        Me.pnlTotals.TabIndex = 2
        '
        'splitMain
        '
        Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMain.Location = New System.Drawing.Point(0, 132)
        Me.splitMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.splitMain.Name = "splitMain"
        '
        'splitMain.Panel1
        '
        Me.splitMain.Panel1.BackColor = System.Drawing.Color.White
        Me.splitMain.Panel1.Controls.Add(Me.PagoMontajeDataGridView)
        Me.splitMain.Panel1MinSize = 0
        '
        'splitMain.Panel2
        '
        Me.splitMain.Panel2.BackColor = System.Drawing.Color.White
        Me.splitMain.Panel2.Controls.Add(Me.splitRight)
        Me.splitMain.Panel2MinSize = 0
        Me.splitMain.Size = New System.Drawing.Size(1924, 660)
        Me.splitMain.SplitterDistance = 1374
        Me.splitMain.SplitterWidth = 8
        Me.splitMain.TabIndex = 0
        '
        'PagoMontajeDataGridView
        '
        Me.PagoMontajeDataGridView.AllowUserToAddRows = False
        Me.PagoMontajeDataGridView.AllowUserToDeleteRows = False
        Me.PagoMontajeDataGridView.AutoGenerateColumns = False
        Me.PagoMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagoMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoMontaje, Me.IdEmpresaMontaje, Me.Fecha, Me.valor, Me.Asignado, Me.PendienteAsignar, Me.Asignar, Me.Modificar, Me.Imprimir})
        Me.PagoMontajeDataGridView.DataSource = Me.PagoMontajeBindingSource
        Me.PagoMontajeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagoMontajeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PagoMontajeDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.PagoMontajeDataGridView.Name = "PagoMontajeDataGridView"
        Me.PagoMontajeDataGridView.RowHeadersWidth = 62
        Me.PagoMontajeDataGridView.RowTemplate.Height = 28
        Me.PagoMontajeDataGridView.Size = New System.Drawing.Size(1374, 660)
        Me.PagoMontajeDataGridView.TabIndex = 0
        '
        'IdPagoMontaje
        '
        Me.IdPagoMontaje.DataPropertyName = "IdPagoMontaje"
        Me.IdPagoMontaje.HeaderText = "IdPagoMontaje"
        Me.IdPagoMontaje.MinimumWidth = 8
        Me.IdPagoMontaje.Name = "IdPagoMontaje"
        Me.IdPagoMontaje.Width = 150
        '
        'IdEmpresaMontaje
        '
        Me.IdEmpresaMontaje.DataPropertyName = "IdEmpresaMontaje"
        Me.IdEmpresaMontaje.HeaderText = "IdEmpresaMontaje"
        Me.IdEmpresaMontaje.MinimumWidth = 8
        Me.IdEmpresaMontaje.Name = "IdEmpresaMontaje"
        Me.IdEmpresaMontaje.Width = 150
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 8
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 150
        '
        'valor
        '
        Me.valor.DataPropertyName = "valor"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.valor.DefaultCellStyle = DataGridViewCellStyle10
        Me.valor.HeaderText = "valor"
        Me.valor.MinimumWidth = 8
        Me.valor.Name = "valor"
        Me.valor.Width = 125
        '
        'Asignado
        '
        Me.Asignado.DataPropertyName = "Asignado"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.Asignado.DefaultCellStyle = DataGridViewCellStyle11
        Me.Asignado.HeaderText = "Asignado"
        Me.Asignado.MinimumWidth = 8
        Me.Asignado.Name = "Asignado"
        Me.Asignado.Width = 125
        '
        'PendienteAsignar
        '
        Me.PendienteAsignar.DataPropertyName = "PendienteAsignar"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.PendienteAsignar.DefaultCellStyle = DataGridViewCellStyle12
        Me.PendienteAsignar.HeaderText = "PendienteAsignar"
        Me.PendienteAsignar.MinimumWidth = 8
        Me.PendienteAsignar.Name = "PendienteAsignar"
        Me.PendienteAsignar.Width = 125
        '
        'Asignar
        '
        Me.Asignar.HeaderText = "Asignar"
        Me.Asignar.MinimumWidth = 8
        Me.Asignar.Name = "Asignar"
        Me.Asignar.Width = 125
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.MinimumWidth = 8
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Width = 125
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.MinimumWidth = 8
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Width = 125
        '
        'PagoMontajeBindingSource
        '
        Me.PagoMontajeBindingSource.DataMember = "PagoMontaje"
        Me.PagoMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'DsPagosMontaje
        '
        Me.DsPagosMontaje.DataSetName = "DsPagosMontaje"
        Me.DsPagosMontaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'splitRight
        '
        Me.splitRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitRight.Location = New System.Drawing.Point(0, 0)
        Me.splitRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.splitRight.Name = "splitRight"
        Me.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitRight.Panel1
        '
        Me.splitRight.Panel1.Controls.Add(Me.EmpresasContratadasMontajeDataGridView)
        Me.splitRight.Panel1MinSize = 50
        '
        'splitRight.Panel2
        '
        Me.splitRight.Panel2.Controls.Add(Me.PagoMontajeDetalleDataGridView)
        Me.splitRight.Panel2MinSize = 50
        Me.splitRight.Size = New System.Drawing.Size(542, 660)
        Me.splitRight.SplitterDistance = 309
        Me.splitRight.SplitterWidth = 8
        Me.splitRight.TabIndex = 0
        '
        'EmpresasContratadasMontajeDataGridView
        '
        Me.EmpresasContratadasMontajeDataGridView.AllowUserToAddRows = False
        Me.EmpresasContratadasMontajeDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasContratadasMontajeDataGridView.AutoGenerateColumns = False
        Me.EmpresasContratadasMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasContratadasMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpresaMontajeDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn})
        Me.EmpresasContratadasMontajeDataGridView.DataSource = Me.EmpresasContratadasMontajeBindingSource
        Me.EmpresasContratadasMontajeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpresasContratadasMontajeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasContratadasMontajeDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.EmpresasContratadasMontajeDataGridView.Name = "EmpresasContratadasMontajeDataGridView"
        Me.EmpresasContratadasMontajeDataGridView.ReadOnly = True
        Me.EmpresasContratadasMontajeDataGridView.RowHeadersWidth = 62
        Me.EmpresasContratadasMontajeDataGridView.Size = New System.Drawing.Size(542, 309)
        Me.EmpresasContratadasMontajeDataGridView.TabIndex = 0
        '
        'EmpresasContratadasMontajeBindingSource
        '
        Me.EmpresasContratadasMontajeBindingSource.DataMember = "EmpresasContratadasMontaje"
        Me.EmpresasContratadasMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PagoMontajeDetalleDataGridView
        '
        Me.PagoMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.PagoMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PagoMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.PagoMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagoMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15})
        Me.PagoMontajeDetalleDataGridView.DataSource = Me.PagoMontajeDetalleBindingSource
        Me.PagoMontajeDetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagoMontajeDetalleDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PagoMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.PagoMontajeDetalleDataGridView.Name = "PagoMontajeDetalleDataGridView"
        Me.PagoMontajeDetalleDataGridView.RowHeadersWidth = 62
        Me.PagoMontajeDetalleDataGridView.RowTemplate.Height = 28
        Me.PagoMontajeDetalleDataGridView.Size = New System.Drawing.Size(542, 343)
        Me.PagoMontajeDetalleDataGridView.TabIndex = 0
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasContratadasMontajeTableAdapter = Nothing
        Me.TableAdapterManager.FacturaMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.FacturaMontajeTableAdapter = Nothing
        Me.TableAdapterManager.PagoMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoMontajeTableAdapter = Me.PagoMontajeTableAdapter
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'PagoMontajeDetalleTableAdapter
        '
        Me.PagoMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'IdEmpresaMontajeDataGridViewTextBoxColumn
        '
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn.DataPropertyName = "IdEmpresaMontaje"
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn.HeaderText = "IdEmpresaMontaje"
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn.Name = "IdEmpresaMontajeDataGridViewTextBoxColumn"
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpresaMontajeDataGridViewTextBoxColumn.Width = 150
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialDataGridViewTextBoxColumn.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IdPagoMontaje"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn9.HeaderText = "IdPagoMontaje"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TotalPagado"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TotalPagado"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn15.HeaderText = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'FrmPagosMomtajeResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 792)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPagosMomtajeResumen"
        Me.Text = "Resumen Pagos Montaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlTotals.ResumeLayout(False)
        Me.pnlTotals.PerformLayout()
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        CType(Me.PagoMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitRight.Panel1.ResumeLayout(False)
        Me.splitRight.Panel2.ResumeLayout(False)
        CType(Me.splitRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitRight.ResumeLayout(False)
        CType(Me.EmpresasContratadasMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtItebis As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents pnlTotals As System.Windows.Forms.Panel
    Friend WithEvents splitMain As System.Windows.Forms.SplitContainer
    Friend WithEvents splitRight As System.Windows.Forms.SplitContainer
    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents PagoMontajeBindingSource As BindingSource
    Friend WithEvents PagoMontajeTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeTableAdapter
    Friend WithEvents TableAdapterManager As DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasContratadasMontajeDataGridView As DataGridView
    Friend WithEvents EmpresasContratadasMontajeBindingSource As BindingSource
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PagoMontajeDetalleBindingSource As BindingSource
    Friend WithEvents PagoMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter
    Friend WithEvents PagoMontajeDataGridView As DataGridView
    Friend WithEvents PagoMontajeDetalleDataGridView As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents IdPagoMontaje As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaMontaje As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents Asignado As DataGridViewTextBoxColumn
    Friend WithEvents PendienteAsignar As DataGridViewTextBoxColumn
    Friend WithEvents Asignar As DataGridViewButtonColumn
    Friend WithEvents Modificar As DataGridViewButtonColumn
    Friend WithEvents Imprimir As DataGridViewButtonColumn
    Friend WithEvents BtnPendientes As Button
    Friend WithEvents BtnFiltroTodos As Button
    Friend WithEvents IdEmpresaMontajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
End Class
