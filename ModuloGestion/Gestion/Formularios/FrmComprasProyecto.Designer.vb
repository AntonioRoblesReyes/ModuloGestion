<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComprasProyecto
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.lblempresa = New System.Windows.Forms.Label()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxFiltros = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.BtnFiltrarFecha = New System.Windows.Forms.Button()
        Me.BtnQuitarFiltroFecha = New System.Windows.Forms.Button()
        Me.BtnNuevaCompra = New System.Windows.Forms.Button()
        Me.BtnVerConmpra = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComprasPorProyectoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProveedores = New ModuloGestion.DsProveedores()
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.CompraMaterialesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.CompraMaterialesDetalleTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.ProveedoresTableAdapter = New ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager()
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.DsTasa = New ModuloGestion.DsTasa()
        Me.TasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasaTableAdapter = New ModuloGestion.DsTasaTableAdapters.TasaTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsTasaTableAdapters.TableAdapterManager()
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.DsPreciosCompra = New ModuloGestion.DsPreciosCompra()
        Me.PreciosCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreciosCompraTableAdapter = New ModuloGestion.DsPreciosCompraTableAdapters.PreciosCompraTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsPreciosCompraTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.LblImpuesto = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Id_proyecto_Presupuestos = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdPresupuestoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Proveedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalCompraUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCompraUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalCompraRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCompraRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFiltros.SuspendLayout()
        CType(Me.ComprasPorProyectoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '

        'lblempresa
        '
        Me.lblempresa.Location = New System.Drawing.Point(0, 0)
        Me.lblempresa.Name = "lblempresa"
        Me.lblempresa.Size = New System.Drawing.Size(100, 23)
        Me.lblempresa.TabIndex = 10
        '
        'LblProyecto
        '
        Me.LblProyecto.Location = New System.Drawing.Point(0, 0)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(100, 23)
        Me.LblProyecto.TabIndex = 11
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(100, 23)
        Me.LblPresupuesto.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 13
        '
        'GroupBoxFiltros
        '
        Me.GroupBoxFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxFiltros.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxFiltros.Controls.Add(Me.Label9)
        Me.GroupBoxFiltros.Controls.Add(Me.TxtBuscar)
        Me.GroupBoxFiltros.Controls.Add(Me.Label10)
        Me.GroupBoxFiltros.Controls.Add(Me.TxtValor)
        Me.GroupBoxFiltros.Controls.Add(Me.Label11)
        Me.GroupBoxFiltros.Controls.Add(Me.DateTimePicker3)
        Me.GroupBoxFiltros.Controls.Add(Me.BtnFiltrarFecha)
        Me.GroupBoxFiltros.Controls.Add(Me.BtnQuitarFiltroFecha)
        Me.GroupBoxFiltros.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxFiltros.Location = New System.Drawing.Point(20, 10)
        Me.GroupBoxFiltros.Name = "GroupBoxFiltros"
        Me.GroupBoxFiltros.Size = New System.Drawing.Size(968, 70)
        Me.GroupBoxFiltros.TabIndex = 0
        Me.GroupBoxFiltros.TabStop = False
        Me.GroupBoxFiltros.Text = "Filtros de búsqueda"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(15, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(93, 27)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(132, 30)
        Me.TxtBuscar.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(240, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Factura:"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(296, 27)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(100, 30)
        Me.TxtValor.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(428, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 23)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Fecha:"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(520, 27)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(131, 30)
        Me.DateTimePicker3.TabIndex = 5
        '
        'BtnFiltrarFecha
        '
        Me.BtnFiltrarFecha.Location = New System.Drawing.Point(657, 26)
        Me.BtnFiltrarFecha.Name = "BtnFiltrarFecha"
        Me.BtnFiltrarFecha.Size = New System.Drawing.Size(122, 30)
        Me.BtnFiltrarFecha.TabIndex = 6
        Me.BtnFiltrarFecha.Text = "Filtrar Fecha"
        '
        'BtnQuitarFiltroFecha
        '
        Me.BtnQuitarFiltroFecha.Location = New System.Drawing.Point(800, 26)
        Me.BtnQuitarFiltroFecha.Name = "BtnQuitarFiltroFecha"
        Me.BtnQuitarFiltroFecha.Size = New System.Drawing.Size(168, 30)
        Me.BtnQuitarFiltroFecha.TabIndex = 7
        Me.BtnQuitarFiltroFecha.Text = "Quitar Filtro"
        '
        'BtnNuevaCompra
        '
        Me.BtnNuevaCompra.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnNuevaCompra.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevaCompra.Location = New System.Drawing.Point(20, 90)
        Me.BtnNuevaCompra.Name = "BtnNuevaCompra"
        Me.BtnNuevaCompra.Size = New System.Drawing.Size(150, 35)
        Me.BtnNuevaCompra.TabIndex = 2
        Me.BtnNuevaCompra.Text = "Nueva Compra"
        Me.BtnNuevaCompra.UseVisualStyleBackColor = False
        '
        'BtnVerConmpra
        '
        Me.BtnVerConmpra.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnVerConmpra.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnVerConmpra.Location = New System.Drawing.Point(180, 90)
        Me.BtnVerConmpra.Name = "BtnVerConmpra"
        Me.BtnVerConmpra.Size = New System.Drawing.Size(170, 35)
        Me.BtnVerConmpra.TabIndex = 3
        Me.BtnVerConmpra.Text = "Modificar Compra"
        Me.BtnVerConmpra.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(360, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(470, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cuentas Por Pagar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(650, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(250, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Cuentas Por Pagar Empleados"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComprasPorProyectoDataGridView
        '
        Me.ComprasPorProyectoDataGridView.AllowUserToAddRows = False
        Me.ComprasPorProyectoDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.ComprasPorProyectoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ComprasPorProyectoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComprasPorProyectoDataGridView.AutoGenerateColumns = False
        Me.ComprasPorProyectoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ComprasPorProyectoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ComprasPorProyectoDataGridView.ColumnHeadersHeight = 29
        Me.ComprasPorProyectoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.Id_Proveedor, Me.FechaCompraDataGridViewTextBoxColumn, Me.FacturaProveedorDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn1, Me.TasaDataGridViewTextBoxColumn, Me.SubTotalCompraUSDataGridViewTextBoxColumn, Me.ImpuestoCompraUSDataGridViewTextBoxColumn, Me.TotalCompraUSDataGridViewTextBoxColumn, Me.SubTotalCompraRDDataGridViewTextBoxColumn, Me.ImpuestoCompraRDDataGridViewTextBoxColumn, Me.TotalCompraRDDataGridViewTextBoxColumn})
        Me.ComprasPorProyectoDataGridView.DataSource = Me.CompraMaterialesBindingSource
        Me.ComprasPorProyectoDataGridView.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComprasPorProyectoDataGridView.Location = New System.Drawing.Point(20, 144)
        Me.ComprasPorProyectoDataGridView.Name = "ComprasPorProyectoDataGridView"
        Me.ComprasPorProyectoDataGridView.ReadOnly = True
        Me.ComprasPorProyectoDataGridView.RowHeadersVisible = False
        Me.ComprasPorProyectoDataGridView.RowHeadersWidth = 51
        Me.ComprasPorProyectoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ComprasPorProyectoDataGridView.Size = New System.Drawing.Size(1376, 552)
        Me.ComprasPorProyectoDataGridView.TabIndex = 7
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsProveedores
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "DsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraMaterialesBindingSource
        '
        Me.CompraMaterialesBindingSource.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource.DataSource = Me.DsCompras
        '
        'CompraMaterialesDetalleDataGridView
        '
        Me.CompraMaterialesDetalleDataGridView.AllowUserToAddRows = False
        Me.CompraMaterialesDetalleDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue
        Me.CompraMaterialesDetalleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.CompraMaterialesDetalleDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompraMaterialesDetalleDataGridView.AutoGenerateColumns = False
        Me.CompraMaterialesDetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CompraMaterialesDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CompraMaterialesDetalleDataGridView.ColumnHeadersHeight = 29
        Me.CompraMaterialesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionProveedorDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.PrecioUSDataGridViewTextBoxColumn, Me.PrecioRDDataGridViewTextBoxColumn, Me.IdPresupuestoDataGridViewTextBoxColumn, Me.Asignar})
        Me.CompraMaterialesDetalleDataGridView.DataSource = Me.CompraMaterialesDetalleBindingSource
        Me.CompraMaterialesDetalleDataGridView.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CompraMaterialesDetalleDataGridView.Location = New System.Drawing.Point(20, 702)
        Me.CompraMaterialesDetalleDataGridView.Name = "CompraMaterialesDetalleDataGridView"
        Me.CompraMaterialesDetalleDataGridView.RowHeadersVisible = False
        Me.CompraMaterialesDetalleDataGridView.RowHeadersWidth = 51
        Me.CompraMaterialesDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompraMaterialesDetalleDataGridView.Size = New System.Drawing.Size(870, 200)
        Me.CompraMaterialesDetalleDataGridView.TabIndex = 8
        '
        'CompraMaterialesDetalleBindingSource
        '
        Me.CompraMaterialesDetalleBindingSource.DataMember = "CompraMaterialesDetalle"
        Me.CompraMaterialesDetalleBindingSource.DataSource = Me.DsCompras
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.AliceBlue
        Me.PresupuestoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.PresupuestoDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PresupuestoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PresupuestoDataGridView.ColumnHeadersHeight = 29
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_proyecto_Presupuestos, Me.IdPresupuestoDataGridViewTextBoxColumn1, Me.DescripcionPresupuestoDataGridViewTextBoxColumn})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        Me.PresupuestoDataGridView.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(905, 702)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.RowHeadersVisible = False
        Me.PresupuestoDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(491, 200)
        Me.PresupuestoDataGridView.TabIndex = 9
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
        'CompraMaterialesDetalleTableAdapter
        '
        Me.CompraMaterialesDetalleTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CuentaAsociadaTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsTasa
        '
        Me.DsTasa.DataSetName = "DsTasa"
        Me.DsTasa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TasaBindingSource
        '
        Me.TasaBindingSource.DataMember = "Tasa"
        Me.TasaBindingSource.DataSource = Me.DsTasa
        '
        'TasaTableAdapter
        '
        Me.TasaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.TasaTableAdapter = Me.TasaTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsTasaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '
        'DsPreciosCompra
        '
        Me.DsPreciosCompra.DataSetName = "DsPreciosCompra"
        Me.DsPreciosCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreciosCompraBindingSource
        '
        Me.PreciosCompraBindingSource.DataMember = "PreciosCompra"
        Me.PreciosCompraBindingSource.DataSource = Me.DsPreciosCompra
        '
        'PreciosCompraTableAdapter
        '
        Me.PreciosCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsPreciosCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Impuesto:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal:"
        '
        'PanelTotales
        '
        Me.PanelTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotales.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTotales.Controls.Add(Me.LblSubTotal)
        Me.PanelTotales.Controls.Add(Me.LblImpuesto)
        Me.PanelTotales.Controls.Add(Me.LblTotal)
        Me.PanelTotales.Controls.Add(Me.Label1)
        Me.PanelTotales.Controls.Add(Me.Label2)
        Me.PanelTotales.Controls.Add(Me.Label3)
        Me.PanelTotales.Location = New System.Drawing.Point(1018, 10)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Size = New System.Drawing.Size(350, 115)
        Me.PanelTotales.TabIndex = 1
        '
        'LblSubTotal
        '
        Me.LblSubTotal.Location = New System.Drawing.Point(96, 10)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.LblSubTotal.TabIndex = 1
        '
        'LblImpuesto
        '
        Me.LblImpuesto.Location = New System.Drawing.Point(96, 30)
        Me.LblImpuesto.Name = "LblImpuesto"
        Me.LblImpuesto.Size = New System.Drawing.Size(100, 23)
        Me.LblImpuesto.TabIndex = 3
        '
        'LblTotal
        '
        Me.LblTotal.Location = New System.Drawing.Point(96, 50)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(100, 23)
        Me.LblTotal.TabIndex = 5
        '
        'Id_proyecto_Presupuestos
        '
        Me.Id_proyecto_Presupuestos.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.Id_proyecto_Presupuestos.DataSource = Me.ProyectosBindingSource
        Me.Id_proyecto_Presupuestos.DisplayMember = "Nombre_Proyecto"
        Me.Id_proyecto_Presupuestos.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Id_proyecto_Presupuestos.FillWeight = 59.34568!
        Me.Id_proyecto_Presupuestos.HeaderText = "Proyecto"
        Me.Id_proyecto_Presupuestos.MinimumWidth = 6
        Me.Id_proyecto_Presupuestos.Name = "Id_proyecto_Presupuestos"
        Me.Id_proyecto_Presupuestos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_proyecto_Presupuestos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Id_proyecto_Presupuestos.ValueMember = "Id_Proyecto"
        '
        'IdPresupuestoDataGridViewTextBoxColumn1
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn1.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn1.FillWeight = 57.726!
        Me.IdPresupuestoDataGridViewTextBoxColumn1.HeaderText = "Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdPresupuestoDataGridViewTextBoxColumn1.Name = "IdPresupuestoDataGridViewTextBoxColumn1"
        '
        'DescripcionPresupuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Presupuesto"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.FillWeight = 98.82355!
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.Name = "DescripcionPresupuestoDataGridViewTextBoxColumn"
        '
        'DescripcionProveedorDataGridViewTextBoxColumn
        '
        Me.DescripcionProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionProveedorDataGridViewTextBoxColumn.DataPropertyName = "DescripcionProveedor"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.DescripcionProveedorDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionProveedorDataGridViewTextBoxColumn.Name = "DescripcionProveedorDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.CantidadDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 108
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.Width = 102
        '
        'PrecioUSDataGridViewTextBoxColumn
        '
        Me.PrecioUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrecioUSDataGridViewTextBoxColumn.DataPropertyName = "PrecioUS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.PrecioUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.PrecioUSDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.PrecioUSDataGridViewTextBoxColumn.HeaderText = "PrecioUS"
        Me.PrecioUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioUSDataGridViewTextBoxColumn.Name = "PrecioUSDataGridViewTextBoxColumn"
        Me.PrecioUSDataGridViewTextBoxColumn.Width = 107
        '
        'PrecioRDDataGridViewTextBoxColumn
        '
        Me.PrecioRDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrecioRDDataGridViewTextBoxColumn.DataPropertyName = "PrecioRD"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.PrecioRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.PrecioRDDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.PrecioRDDataGridViewTextBoxColumn.HeaderText = "PrecioRD"
        Me.PrecioRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioRDDataGridViewTextBoxColumn.Name = "PrecioRDDataGridViewTextBoxColumn"
        Me.PrecioRDDataGridViewTextBoxColumn.Width = 108
        '
        'IdPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.FillWeight = 1.0!
        Me.IdPresupuestoDataGridViewTextBoxColumn.HeaderText = "Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPresupuestoDataGridViewTextBoxColumn.Name = "IdPresupuestoDataGridViewTextBoxColumn"
        Me.IdPresupuestoDataGridViewTextBoxColumn.Width = 133
        '
        'Asignar
        '
        Me.Asignar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Asignar.FillWeight = 1.0!
        Me.Asignar.HeaderText = "Asignar"
        Me.Asignar.MinimumWidth = 6
        Me.Asignar.Name = "Asignar"
        Me.Asignar.Width = 73
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.FillWeight = 144.8834!
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "RNC"
        Me.IdProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Width = 73
        '
        'Id_Proveedor
        '
        Me.Id_Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Id_Proveedor.DataPropertyName = "Id_Proveedor"
        Me.Id_Proveedor.DataSource = Me.ProveedoresBindingSource
        Me.Id_Proveedor.DisplayMember = "RazonSocial"
        Me.Id_Proveedor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Id_Proveedor.FillWeight = 166.0369!
        Me.Id_Proveedor.HeaderText = "Proveedor"
        Me.Id_Proveedor.MinimumWidth = 6
        Me.Id_Proveedor.Name = "Id_Proveedor"
        Me.Id_Proveedor.ReadOnly = True
        Me.Id_Proveedor.ValueMember = "Id_Proveedor"
        '
        'FechaCompraDataGridViewTextBoxColumn
        '
        Me.FechaCompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaCompraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Compra"
        Me.FechaCompraDataGridViewTextBoxColumn.FillWeight = 96.25668!
        Me.FechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaCompraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaCompraDataGridViewTextBoxColumn.Name = "FechaCompraDataGridViewTextBoxColumn"
        Me.FechaCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCompraDataGridViewTextBoxColumn.Width = 83
        '
        'FacturaProveedorDataGridViewTextBoxColumn
        '
        Me.FacturaProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FacturaProveedorDataGridViewTextBoxColumn.DataPropertyName = "FacturaProveedor"
        Me.FacturaProveedorDataGridViewTextBoxColumn.FillWeight = 129.3401!
        Me.FacturaProveedorDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FacturaProveedorDataGridViewTextBoxColumn.Name = "FacturaProveedorDataGridViewTextBoxColumn"
        Me.FacturaProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacturaProveedorDataGridViewTextBoxColumn.Width = 94
        '
        'MonedaDataGridViewTextBoxColumn1
        '
        Me.MonedaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MonedaDataGridViewTextBoxColumn1.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn1.FillWeight = 50.58894!
        Me.MonedaDataGridViewTextBoxColumn1.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MonedaDataGridViewTextBoxColumn1.Name = "MonedaDataGridViewTextBoxColumn1"
        Me.MonedaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MonedaDataGridViewTextBoxColumn1.Width = 102
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.FillWeight = 48.25618!
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TasaDataGridViewTextBoxColumn.Width = 71
        '
        'SubTotalCompraUSDataGridViewTextBoxColumn
        '
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.DataPropertyName = "SubTotalCompraUS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.FillWeight = 95.92551!
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.HeaderText = "Sub US"
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.Name = "SubTotalCompraUSDataGridViewTextBoxColumn"
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTotalCompraUSDataGridViewTextBoxColumn.Width = 94
        '
        'ImpuestoCompraUSDataGridViewTextBoxColumn
        '
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.DataPropertyName = "ImpuestoCompraUS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.FillWeight = 95.28372!
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.HeaderText = "Imp US"
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.Name = "ImpuestoCompraUSDataGridViewTextBoxColumn"
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoCompraUSDataGridViewTextBoxColumn.Width = 95
        '
        'TotalCompraUSDataGridViewTextBoxColumn
        '
        Me.TotalCompraUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TotalCompraUSDataGridViewTextBoxColumn.DataPropertyName = "TotalCompraUS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.TotalCompraUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalCompraUSDataGridViewTextBoxColumn.FillWeight = 94.58189!
        Me.TotalCompraUSDataGridViewTextBoxColumn.HeaderText = "Total US"
        Me.TotalCompraUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCompraUSDataGridViewTextBoxColumn.Name = "TotalCompraUSDataGridViewTextBoxColumn"
        Me.TotalCompraUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCompraUSDataGridViewTextBoxColumn.Width = 101
        '
        'SubTotalCompraRDDataGridViewTextBoxColumn
        '
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.DataPropertyName = "SubTotalCompraRD"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.FillWeight = 93.81439!
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.HeaderText = "Sub RD"
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.Name = "SubTotalCompraRDDataGridViewTextBoxColumn"
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTotalCompraRDDataGridViewTextBoxColumn.Width = 107
        '
        'ImpuestoCompraRDDataGridViewTextBoxColumn
        '
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.DataPropertyName = "ImpuestoCompraRD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.FillWeight = 92.97509!
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.HeaderText = "Imp RD"
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.Name = "ImpuestoCompraRDDataGridViewTextBoxColumn"
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoCompraRDDataGridViewTextBoxColumn.Width = 96
        '
        'TotalCompraRDDataGridViewTextBoxColumn
        '
        Me.TotalCompraRDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TotalCompraRDDataGridViewTextBoxColumn.DataPropertyName = "TotalCompraRD"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.TotalCompraRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalCompraRDDataGridViewTextBoxColumn.FillWeight = 92.05725!
        Me.TotalCompraRDDataGridViewTextBoxColumn.HeaderText = "Total RD"
        Me.TotalCompraRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCompraRDDataGridViewTextBoxColumn.Name = "TotalCompraRDDataGridViewTextBoxColumn"
        Me.TotalCompraRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCompraRDDataGridViewTextBoxColumn.Width = 102
        '
        'FrmComprasProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1408, 922)
        Me.Controls.Add(Me.GroupBoxFiltros)
        Me.Controls.Add(Me.PanelTotales)
        Me.Controls.Add(Me.BtnNuevaCompra)
        Me.Controls.Add(Me.BtnVerConmpra)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComprasPorProyectoDataGridView)
        Me.Controls.Add(Me.CompraMaterialesDetalleDataGridView)
        Me.Controls.Add(Me.PresupuestoDataGridView)
        Me.Controls.Add(Me.lblempresa)
        Me.Controls.Add(Me.LblProyecto)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "FrmComprasProyecto"
        Me.Text = "Gestión de Compras por Proyecto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFiltros.ResumeLayout(False)
        Me.GroupBoxFiltros.PerformLayout()
        CType(Me.ComprasPorProyectoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotales.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As ModuloGestion.DsComprasTableAdapters.TableAdapterManager

    ' Labels y controles ocultos
    Friend WithEvents lblempresa As System.Windows.Forms.Label
    Friend WithEvents LblProyecto As System.Windows.Forms.Label
    Friend WithEvents LblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

    ' BindingSources y DataSets (ya estaban)
    Friend WithEvents DsCompras As ModuloGestion.DsCompras

    ' Filtros
    Friend WithEvents GroupBoxFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrarFecha As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarFiltroFecha As System.Windows.Forms.Button

    ' Botones de acción
    Friend WithEvents BtnNuevaCompra As System.Windows.Forms.Button
    Friend WithEvents BtnVerConmpra As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

    ' Grids
    Friend WithEvents ComprasPorProyectoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CompraMaterialesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PresupuestoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CompraMaterialesDetalleBindingSource As BindingSource
    Friend WithEvents CompraMaterialesDetalleTableAdapter As DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter
    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents DsProveedores As DsProveedores
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As DsProveedoresTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager1 As DsProveedoresTableAdapters.TableAdapterManager
    Friend WithEvents DsProyectos As DsProyectos
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager2 As DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents DsTasa As DsTasa
    Friend WithEvents TasaBindingSource As BindingSource
    Friend WithEvents TasaTableAdapter As DsTasaTableAdapters.TasaTableAdapter
    Friend WithEvents TableAdapterManager3 As DsTasaTableAdapters.TableAdapterManager
    Friend WithEvents DsPreciosCompra As DsPreciosCompra
    Friend WithEvents PreciosCompraBindingSource As BindingSource
    Friend WithEvents PreciosCompraTableAdapter As DsPreciosCompraTableAdapters.PreciosCompraTableAdapter
    Friend WithEvents TableAdapterManager4 As DsPreciosCompraTableAdapters.TableAdapterManager
    Friend WithEvents CompraMaterialesBindingSource As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents LblSubTotal As Label
    Friend WithEvents LblImpuesto As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Id_proyecto_Presupuestos As DataGridViewComboBoxColumn
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Asignar As DataGridViewButtonColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Id_Proveedor As DataGridViewComboBoxColumn
    Friend WithEvents FechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCompraUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoCompraUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCompraUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCompraRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoCompraRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCompraRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
