<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHistorialPagosProveedor
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.LblPendienteUS = New System.Windows.Forms.Label()
        Me.LblPendienteRD = New System.Windows.Forms.Label()
        Me.LblTotalPagadoUS = New System.Windows.Forms.Label()
        Me.LblTotalPagadoRD = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelFiltros = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.DgvCompras = New System.Windows.Forms.DataGridView()
        Me.Expandir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Id_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCompraRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCompraUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelTotales.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.PanelCabecera.Controls.Add(Me.LblTitulo)
        Me.PanelCabecera.Controls.Add(Me.LblProveedor)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Padding = New System.Windows.Forms.Padding(16, 12, 16, 12)
        Me.PanelCabecera.Size = New System.Drawing.Size(1380, 92)
        Me.PanelCabecera.TabIndex = 0
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(18, 10)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(286, 31)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Historial de Pagos a Proveedor"
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProveedor.ForeColor = System.Drawing.Color.White
        Me.LblProveedor.Location = New System.Drawing.Point(17, 43)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(231, 38)
        Me.LblProveedor.TabIndex = 1
        Me.LblProveedor.Text = "Nombre Proveedor"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.PanelTotales)
        Me.PanelTop.Controls.Add(Me.PanelFiltros)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 92)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.PanelTop.Size = New System.Drawing.Size(1380, 124)
        Me.PanelTop.TabIndex = 1
        '
        'PanelTotales
        '
        Me.PanelTotales.BackColor = System.Drawing.Color.White
        Me.PanelTotales.Controls.Add(Me.LblPendienteUS)
        Me.PanelTotales.Controls.Add(Me.LblPendienteRD)
        Me.PanelTotales.Controls.Add(Me.LblTotalPagadoUS)
        Me.PanelTotales.Controls.Add(Me.LblTotalPagadoRD)
        Me.PanelTotales.Controls.Add(Me.Label8)
        Me.PanelTotales.Controls.Add(Me.Label7)
        Me.PanelTotales.Controls.Add(Me.Label6)
        Me.PanelTotales.Controls.Add(Me.Label5)
        Me.PanelTotales.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelTotales.Location = New System.Drawing.Point(807, 10)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Padding = New System.Windows.Forms.Padding(12)
        Me.PanelTotales.Size = New System.Drawing.Size(561, 104)
        Me.PanelTotales.TabIndex = 1
        '
        'LblPendienteUS
        '
        Me.LblPendienteUS.AutoSize = True
        Me.LblPendienteUS.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblPendienteUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.LblPendienteUS.Location = New System.Drawing.Point(417, 62)
        Me.LblPendienteUS.Name = "LblPendienteUS"
        Me.LblPendienteUS.Size = New System.Drawing.Size(79, 23)
        Me.LblPendienteUS.TabIndex = 7
        Me.LblPendienteUS.Text = "US$ 0.00"
        '
        'LblPendienteRD
        '
        Me.LblPendienteRD.AutoSize = True
        Me.LblPendienteRD.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblPendienteRD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.LblPendienteRD.Location = New System.Drawing.Point(140, 62)
        Me.LblPendienteRD.Name = "LblPendienteRD"
        Me.LblPendienteRD.Size = New System.Drawing.Size(84, 23)
        Me.LblPendienteRD.TabIndex = 6
        Me.LblPendienteRD.Text = "RD$ 0.00"
        '
        'LblTotalPagadoUS
        '
        Me.LblTotalPagadoUS.AutoSize = True
        Me.LblTotalPagadoUS.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblTotalPagadoUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.LblTotalPagadoUS.Location = New System.Drawing.Point(417, 23)
        Me.LblTotalPagadoUS.Name = "LblTotalPagadoUS"
        Me.LblTotalPagadoUS.Size = New System.Drawing.Size(79, 23)
        Me.LblTotalPagadoUS.TabIndex = 5
        Me.LblTotalPagadoUS.Text = "US$ 0.00"
        '
        'LblTotalPagadoRD
        '
        Me.LblTotalPagadoRD.AutoSize = True
        Me.LblTotalPagadoRD.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblTotalPagadoRD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.LblTotalPagadoRD.Location = New System.Drawing.Point(140, 23)
        Me.LblTotalPagadoRD.Name = "LblTotalPagadoRD"
        Me.LblTotalPagadoRD.Size = New System.Drawing.Size(84, 23)
        Me.LblTotalPagadoRD.TabIndex = 4
        Me.LblTotalPagadoRD.Text = "RD$ 0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(297, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Pendiente US"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(15, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Pendiente RD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(297, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Pagado US"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(15, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Pagado RD"
        '
        'PanelFiltros
        '
        Me.PanelFiltros.BackColor = System.Drawing.Color.White
        Me.PanelFiltros.Controls.Add(Me.BtnCerrar)
        Me.PanelFiltros.Controls.Add(Me.BtnFiltrar)
        Me.PanelFiltros.Controls.Add(Me.DateTimePickerHasta)
        Me.PanelFiltros.Controls.Add(Me.DateTimePickerDesde)
        Me.PanelFiltros.Controls.Add(Me.Label4)
        Me.PanelFiltros.Controls.Add(Me.Label3)
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFiltros.Location = New System.Drawing.Point(12, 10)
        Me.PanelFiltros.Name = "PanelFiltros"
        Me.PanelFiltros.Padding = New System.Windows.Forms.Padding(12)
        Me.PanelFiltros.Size = New System.Drawing.Size(1356, 104)
        Me.PanelFiltros.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.White
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnCerrar.Location = New System.Drawing.Point(692, 33)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(126, 36)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFiltrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltrar.ForeColor = System.Drawing.Color.White
        Me.BtnFiltrar.Location = New System.Drawing.Point(560, 33)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(126, 36)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = False
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(314, 38)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(220, 27)
        Me.DateTimePickerHasta.TabIndex = 3
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(70, 38)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(220, 27)
        Me.DateTimePickerDesde.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(310, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(66, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desde"
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.DgvCompras)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 216)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Padding = New System.Windows.Forms.Padding(12)
        Me.PanelGrid.Size = New System.Drawing.Size(1380, 493)
        Me.PanelGrid.TabIndex = 2
        '
        'DgvCompras
        '
        Me.DgvCompras.AllowUserToAddRows = False
        Me.DgvCompras.AllowUserToDeleteRows = False
        Me.DgvCompras.AutoGenerateColumns = False
        Me.DgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCompras.BackgroundColor = System.Drawing.Color.White
        Me.DgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCompras.ColumnHeadersHeight = 34
        Me.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Expandir, Me.Id_Compra, Me.FacturaProveedor, Me.Fecha_Compra, Me.Moneda, Me.TotalCompraRD, Me.TotalCompraUS, Me.PagadoRD, Me.PagadoUS, Me.PendienteRD, Me.PendienteUS})
        Me.DgvCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCompras.EnableHeadersVisualStyles = False
        Me.DgvCompras.GridColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DgvCompras.Location = New System.Drawing.Point(12, 12)
        Me.DgvCompras.MultiSelect = False
        Me.DgvCompras.Name = "DgvCompras"
        Me.DgvCompras.ReadOnly = True
        Me.DgvCompras.RowHeadersVisible = False
        Me.DgvCompras.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DgvCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvCompras.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCompras.Size = New System.Drawing.Size(1356, 469)
        Me.DgvCompras.TabIndex = 0
        '
        'Expandir
        '
        Me.Expandir.FillWeight = 35.0!
        Me.Expandir.HeaderText = ""
        Me.Expandir.MinimumWidth = 6
        Me.Expandir.Name = "Expandir"
        Me.Expandir.ReadOnly = True
        Me.Expandir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Expandir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Expandir.Text = "+"
        Me.Expandir.UseColumnTextForButtonValue = False
        '
        'Id_Compra
        '
        Me.Id_Compra.DataPropertyName = "Id_Compra"
        Me.Id_Compra.HeaderText = "Compra"
        Me.Id_Compra.MinimumWidth = 6
        Me.Id_Compra.Name = "Id_Compra"
        Me.Id_Compra.ReadOnly = True
        '
        'FacturaProveedor
        '
        Me.FacturaProveedor.DataPropertyName = "FacturaProveedor"
        Me.FacturaProveedor.HeaderText = "Factura"
        Me.FacturaProveedor.MinimumWidth = 6
        Me.FacturaProveedor.Name = "FacturaProveedor"
        Me.FacturaProveedor.ReadOnly = True
        '
        'Fecha_Compra
        '
        Me.Fecha_Compra.DataPropertyName = "Fecha_Compra"
        DataGridViewCellStyle4.Format = "d"
        Me.Fecha_Compra.DefaultCellStyle = DataGridViewCellStyle4
        Me.Fecha_Compra.HeaderText = "Fecha Compra"
        Me.Fecha_Compra.MinimumWidth = 6
        Me.Fecha_Compra.Name = "Fecha_Compra"
        Me.Fecha_Compra.ReadOnly = True
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.MinimumWidth = 6
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        '
        'TotalCompraRD
        '
        Me.TotalCompraRD.DataPropertyName = "TotalCompraRD"
        DataGridViewCellStyle5.Format = "N2"
        Me.TotalCompraRD.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalCompraRD.HeaderText = "Total RD$"
        Me.TotalCompraRD.MinimumWidth = 6
        Me.TotalCompraRD.Name = "TotalCompraRD"
        Me.TotalCompraRD.ReadOnly = True
        '
        'TotalCompraUS
        '
        Me.TotalCompraUS.DataPropertyName = "TotalCompraUS"
        DataGridViewCellStyle6.Format = "N2"
        Me.TotalCompraUS.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalCompraUS.HeaderText = "Total US$"
        Me.TotalCompraUS.MinimumWidth = 6
        Me.TotalCompraUS.Name = "TotalCompraUS"
        Me.TotalCompraUS.ReadOnly = True
        '
        'PagadoRD
        '
        Me.PagadoRD.DataPropertyName = "PagadoRD"
        DataGridViewCellStyle7.Format = "N2"
        Me.PagadoRD.DefaultCellStyle = DataGridViewCellStyle7
        Me.PagadoRD.HeaderText = "Pagado RD$"
        Me.PagadoRD.MinimumWidth = 6
        Me.PagadoRD.Name = "PagadoRD"
        Me.PagadoRD.ReadOnly = True
        '
        'PagadoUS
        '
        Me.PagadoUS.DataPropertyName = "PagadoUS"
        DataGridViewCellStyle8.Format = "N2"
        Me.PagadoUS.DefaultCellStyle = DataGridViewCellStyle8
        Me.PagadoUS.HeaderText = "Pagado US$"
        Me.PagadoUS.MinimumWidth = 6
        Me.PagadoUS.Name = "PagadoUS"
        Me.PagadoUS.ReadOnly = True
        '
        'PendienteRD
        '
        Me.PendienteRD.DataPropertyName = "PendienteRD"
        Me.PendienteRD.DefaultCellStyle = DataGridViewCellStyle7
        Me.PendienteRD.HeaderText = "Pendiente RD$"
        Me.PendienteRD.MinimumWidth = 6
        Me.PendienteRD.Name = "PendienteRD"
        Me.PendienteRD.ReadOnly = True
        '
        'PendienteUS
        '
        Me.PendienteUS.DataPropertyName = "PendienteUS"
        Me.PendienteUS.DefaultCellStyle = DataGridViewCellStyle8
        Me.PendienteUS.HeaderText = "Pendiente US$"
        Me.PendienteUS.MinimumWidth = 6
        Me.PendienteUS.Name = "PendienteUS"
        Me.PendienteUS.ReadOnly = True
        '
        'FrmHistorialPagosProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1380, 709)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelCabecera)
        Me.MinimumSize = New System.Drawing.Size(1200, 650)
        Me.Name = "FrmHistorialPagosProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Pagos del Proveedor"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTotales.ResumeLayout(False)
        Me.PanelTotales.PerformLayout()
        Me.PanelFiltros.ResumeLayout(False)
        Me.PanelFiltros.PerformLayout()
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblProveedor As Label
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents LblPendienteUS As Label
    Friend WithEvents LblPendienteRD As Label
    Friend WithEvents LblTotalPagadoUS As Label
    Friend WithEvents LblTotalPagadoRD As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelFiltros As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents DateTimePickerHasta As DateTimePicker
    Friend WithEvents DateTimePickerDesde As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents DgvCompras As DataGridView
    Friend WithEvents Expandir As DataGridViewButtonColumn
    Friend WithEvents Id_Compra As DataGridViewTextBoxColumn
    Friend WithEvents FacturaProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Compra As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents TotalCompraRD As DataGridViewTextBoxColumn
    Friend WithEvents TotalCompraUS As DataGridViewTextBoxColumn
    Friend WithEvents PagadoRD As DataGridViewTextBoxColumn
    Friend WithEvents PagadoUS As DataGridViewTextBoxColumn
    Friend WithEvents PendienteRD As DataGridViewTextBoxColumn
    Friend WithEvents PendienteUS As DataGridViewTextBoxColumn
End Class
