<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresoCompras
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
        Dim Id_CompraLabel As System.Windows.Forms.Label
        Dim Id_ProveedorLabel As System.Windows.Forms.Label
        Dim TasaLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim PorcientoImpuestoLabel As System.Windows.Forms.Label
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim Fecha_CompraLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim FacturaProveedorLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SubTotalCompraUSTextBox = New System.Windows.Forms.TextBox()
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.ImpuestoCompraUSTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalCompraRDTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoCompraRDTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCompraRDTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCompraUSTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Id_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.Id_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.PorcientoImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.BtnNuevoArticulo = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompraMaterialesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.CompraMaterialesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProveedoresProducto = New ModuloGestion.DsProveedoresProducto()
        Me.ProveedoresProductoTableAdapter = New ModuloGestion.DsProveedoresProductoTableAdapters.ProveedoresProductoTableAdapter()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FacturaProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TotalPagoPorCompraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTasa = New ModuloGestion.DsTasa()
        Me.TasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasaTableAdapter = New ModuloGestion.DsTasaTableAdapters.TasaTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsTasaTableAdapters.TableAdapterManager()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalPagoPorCompraBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.CompraMaterialesDetalleTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.TotalPagoPorCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalPagoPorCompraTableAdapter = New ModuloGestion.DsComprasTableAdapters.TotalPagoPorCompraTableAdapter()
        Me.GroupBoxDatosCompra = New System.Windows.Forms.GroupBox()
        Me.GroupBoxObservaciones = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTotales = New System.Windows.Forms.GroupBox()
        Me.DsCompras1 = New ModuloGestion.DsCompras()
        Me.IdDetallecompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalleP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tasa1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Itebis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_CompraLabel = New System.Windows.Forms.Label()
        Id_ProveedorLabel = New System.Windows.Forms.Label()
        TasaLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        PorcientoImpuestoLabel = New System.Windows.Forms.Label()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        Fecha_CompraLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        FacturaProveedorLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedoresProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPagoPorCompraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPagoPorCompraBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPagoPorCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosCompra.SuspendLayout()
        Me.GroupBoxObservaciones.SuspendLayout()
        Me.GroupBoxTotales.SuspendLayout()
        CType(Me.DsCompras1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_CompraLabel
        '
        Id_CompraLabel.AutoSize = True
        Id_CompraLabel.Location = New System.Drawing.Point(16, 28)
        Id_CompraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_CompraLabel.Name = "Id_CompraLabel"
        Id_CompraLabel.Size = New System.Drawing.Size(72, 16)
        Id_CompraLabel.TabIndex = 67
        Id_CompraLabel.Text = "Id Compra:"
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(16, 60)
        Id_ProveedorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(88, 16)
        Id_ProveedorLabel.TabIndex = 70
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Location = New System.Drawing.Point(16, 124)
        TasaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(92, 16)
        TasaLabel.TabIndex = 71
        TasaLabel.Text = "Tasa Cambio:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(237, 92)
        MonedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(60, 16)
        MonedaLabel.TabIndex = 72
        MonedaLabel.Text = "Moneda:"
        '
        'PorcientoImpuestoLabel
        '
        PorcientoImpuestoLabel.AutoSize = True
        PorcientoImpuestoLabel.Location = New System.Drawing.Point(16, 92)
        PorcientoImpuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PorcientoImpuestoLabel.Name = "PorcientoImpuestoLabel"
        PorcientoImpuestoLabel.Size = New System.Drawing.Size(65, 16)
        PorcientoImpuestoLabel.TabIndex = 73
        PorcientoImpuestoLabel.Text = "Impuesto:"
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Location = New System.Drawing.Point(237, 124)
        Id_EmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(79, 16)
        Id_EmpresaLabel.TabIndex = 74
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(16, 31)
        Fecha_CompraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(99, 16)
        Fecha_CompraLabel.TabIndex = 80
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(16, 70)
        ObservacionesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(102, 16)
        ObservacionesLabel.TabIndex = 84
        ObservacionesLabel.Text = "Observaciones:"
        '
        'FacturaProveedorLabel1
        '
        FacturaProveedorLabel1.AutoSize = True
        FacturaProveedorLabel1.Location = New System.Drawing.Point(260, 31)
        FacturaProveedorLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FacturaProveedorLabel1.Name = "FacturaProveedorLabel1"
        FacturaProveedorLabel1.Size = New System.Drawing.Size(122, 16)
        FacturaProveedorLabel1.TabIndex = 90
        FacturaProveedorLabel1.Text = "Factura Proveedor:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 219)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 16)
        Label2.TabIndex = 94
        Label2.Text = "Precio Con Itbis"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 247)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(95, 16)
        Label3.TabIndex = 95
        Label3.Text = "Precio Sin Itbis"
        '
        'SubTotalCompraUSTextBox
        '
        Me.SubTotalCompraUSTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SubTotalCompraUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "SubTotalCompraUS", True))
        Me.SubTotalCompraUSTextBox.Enabled = False
        Me.SubTotalCompraUSTextBox.Location = New System.Drawing.Point(449, 32)
        Me.SubTotalCompraUSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalCompraUSTextBox.Name = "SubTotalCompraUSTextBox"
        Me.SubTotalCompraUSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SubTotalCompraUSTextBox.TabIndex = 30
        Me.SubTotalCompraUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CompraMaterialesBindingSource
        '
        Me.CompraMaterialesBindingSource.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource.DataSource = Me.DsCompras
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImpuestoCompraUSTextBox
        '
        Me.ImpuestoCompraUSTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ImpuestoCompraUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "ImpuestoCompraUS", True))
        Me.ImpuestoCompraUSTextBox.Enabled = False
        Me.ImpuestoCompraUSTextBox.Location = New System.Drawing.Point(449, 62)
        Me.ImpuestoCompraUSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestoCompraUSTextBox.Name = "ImpuestoCompraUSTextBox"
        Me.ImpuestoCompraUSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ImpuestoCompraUSTextBox.TabIndex = 31
        Me.ImpuestoCompraUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalCompraRDTextBox
        '
        Me.SubTotalCompraRDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SubTotalCompraRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "SubTotalCompraRD", True))
        Me.SubTotalCompraRDTextBox.Enabled = False
        Me.SubTotalCompraRDTextBox.Location = New System.Drawing.Point(107, 32)
        Me.SubTotalCompraRDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalCompraRDTextBox.Name = "SubTotalCompraRDTextBox"
        Me.SubTotalCompraRDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SubTotalCompraRDTextBox.TabIndex = 35
        Me.SubTotalCompraRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpuestoCompraRDTextBox
        '
        Me.ImpuestoCompraRDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ImpuestoCompraRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "ImpuestoCompraRD", True))
        Me.ImpuestoCompraRDTextBox.Enabled = False
        Me.ImpuestoCompraRDTextBox.Location = New System.Drawing.Point(107, 62)
        Me.ImpuestoCompraRDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestoCompraRDTextBox.Name = "ImpuestoCompraRDTextBox"
        Me.ImpuestoCompraRDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ImpuestoCompraRDTextBox.TabIndex = 37
        Me.ImpuestoCompraRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalCompraRDTextBox
        '
        Me.TotalCompraRDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TotalCompraRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "TotalCompraRD", True))
        Me.TotalCompraRDTextBox.Enabled = False
        Me.TotalCompraRDTextBox.Location = New System.Drawing.Point(107, 94)
        Me.TotalCompraRDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCompraRDTextBox.Name = "TotalCompraRDTextBox"
        Me.TotalCompraRDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalCompraRDTextBox.TabIndex = 39
        Me.TotalCompraRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalCompraUSTextBox
        '
        Me.TotalCompraUSTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TotalCompraUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "TotalCompraUS", True))
        Me.TotalCompraUSTextBox.Enabled = False
        Me.TotalCompraUSTextBox.Location = New System.Drawing.Point(449, 94)
        Me.TotalCompraUSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCompraUSTextBox.Name = "TotalCompraUSTextBox"
        Me.TotalCompraUSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalCompraUSTextBox.TabIndex = 41
        Me.TotalCompraUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(522, 219)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 28)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Id_CompraTextBox
        '
        Me.Id_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Id_Compra", True))
        Me.Id_CompraTextBox.Enabled = False
        Me.Id_CompraTextBox.Location = New System.Drawing.Point(113, 25)
        Me.Id_CompraTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_CompraTextBox.Name = "Id_CompraTextBox"
        Me.Id_CompraTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_CompraTextBox.TabIndex = 68
        '
        'Id_ProveedorTextBox
        '
        Me.Id_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Id_Proveedor", True))
        Me.Id_ProveedorTextBox.Enabled = False
        Me.Id_ProveedorTextBox.Location = New System.Drawing.Point(113, 57)
        Me.Id_ProveedorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_ProveedorTextBox.Name = "Id_ProveedorTextBox"
        Me.Id_ProveedorTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_ProveedorTextBox.TabIndex = 71
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Moneda", True))
        Me.MonedaTextBox.Location = New System.Drawing.Point(319, 89)
        Me.MonedaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(64, 22)
        Me.MonedaTextBox.TabIndex = 73
        '
        'PorcientoImpuestoTextBox
        '
        Me.PorcientoImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "PorcientoImpuesto", True))
        Me.PorcientoImpuestoTextBox.Location = New System.Drawing.Point(113, 89)
        Me.PorcientoImpuestoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PorcientoImpuestoTextBox.Name = "PorcientoImpuestoTextBox"
        Me.PorcientoImpuestoTextBox.Size = New System.Drawing.Size(64, 22)
        Me.PorcientoImpuestoTextBox.TabIndex = 74
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(319, 121)
        Me.Id_EmpresaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(64, 22)
        Me.Id_EmpresaTextBox.TabIndex = 75
        '
        'BtnNuevoArticulo
        '
        Me.BtnNuevoArticulo.Location = New System.Drawing.Point(354, 219)
        Me.BtnNuevoArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevoArticulo.Name = "BtnNuevoArticulo"
        Me.BtnNuevoArticulo.Size = New System.Drawing.Size(160, 28)
        Me.BtnNuevoArticulo.TabIndex = 77
        Me.BtnNuevoArticulo.Text = "Nuevo Articulo"
        Me.BtnNuevoArticulo.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CompraMaterialesBindingSource, "Fecha_Compra", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 28)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 22)
        Me.DateTimePicker1.TabIndex = 84
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(123, 67)
        Me.ObservacionesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(450, 132)
        Me.ObservacionesTextBox.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 195)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'CompraMaterialesDetalleDataGridView
        '
        Me.CompraMaterialesDetalleDataGridView.AllowUserToAddRows = False
        Me.CompraMaterialesDetalleDataGridView.AutoGenerateColumns = False
        Me.CompraMaterialesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompraMaterialesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetallecompra, Me.IdDetalleP, Me.Id_Medida, Me.Tasa1, Me.Id_Material, Me.DescripcionProveedor, Me.Itebis, Me.Cantidad, Me.PrecioUS, Me.ItebisUS, Me.TotalUS, Me.PrecioRD, Me.ItebisRD, Me.TotalRD, Me.Id_Presupuesto})
        Me.CompraMaterialesDetalleDataGridView.DataSource = Me.CompraMaterialesDetalleBindingSource
        Me.CompraMaterialesDetalleDataGridView.Location = New System.Drawing.Point(16, 318)
        Me.CompraMaterialesDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CompraMaterialesDetalleDataGridView.Name = "CompraMaterialesDetalleDataGridView"
        Me.CompraMaterialesDetalleDataGridView.RowHeadersWidth = 51
        Me.CompraMaterialesDetalleDataGridView.Size = New System.Drawing.Size(1332, 271)
        Me.CompraMaterialesDetalleDataGridView.TabIndex = 86
        '
        'CompraMaterialesDetalleBindingSource
        '
        Me.CompraMaterialesDetalleBindingSource.DataMember = "CompraMaterialesDetalle"
        Me.CompraMaterialesDetalleBindingSource.DataSource = Me.DsCompras
        '
        'ProveedoresProductoBindingSource
        '
        Me.ProveedoresProductoBindingSource.DataMember = "ProveedoresProducto"
        Me.ProveedoresProductoBindingSource.DataSource = Me.DsProveedoresProducto
        '
        'DsProveedoresProducto
        '
        Me.DsProveedoresProducto.DataSetName = "DsProveedoresProducto"
        Me.DsProveedoresProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresProductoTableAdapter
        '
        Me.ProveedoresProductoTableAdapter.ClearBeforeFill = True
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(65, 224)
        Me.LblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(89, 16)
        Me.LblProveedor.TabIndex = 87
        Me.LblProveedor.Text = "LblProveedor"
        Me.LblProveedor.Visible = False
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.AutoSize = True
        Me.LblPresupuesto.Location = New System.Drawing.Point(65, 254)
        Me.LblPresupuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(101, 16)
        Me.LblPresupuesto.TabIndex = 88
        Me.LblPresupuesto.Text = "LblPresupuesto"
        Me.LblPresupuesto.Visible = False
        '
        'LblProyecto
        '
        Me.LblProyecto.AutoSize = True
        Me.LblProyecto.Location = New System.Drawing.Point(71, 270)
        Me.LblProyecto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(79, 16)
        Me.LblProyecto.TabIndex = 89
        Me.LblProyecto.Text = "LblProyecto"
        Me.LblProyecto.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 28)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Asignar Presupuesto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FacturaProveedorTextBox
        '
        Me.FacturaProveedorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "FacturaProveedor", True))
        Me.FacturaProveedorTextBox.Location = New System.Drawing.Point(390, 28)
        Me.FacturaProveedorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FacturaProveedorTextBox.Name = "FacturaProveedorTextBox"
        Me.FacturaProveedorTextBox.Size = New System.Drawing.Size(173, 22)
        Me.FacturaProveedorTextBox.TabIndex = 91
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 216)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 92
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(133, 244)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 93
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(607, 62)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(117, 34)
        Me.BtnGuardar.TabIndex = 96
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TasaTableAdapter = Me.TasaTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsTasaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Tasa", True))
        Me.TasaTextBox.Location = New System.Drawing.Point(113, 121)
        Me.TasaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(64, 22)
        Me.TasaTextBox.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 35)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Sub Total"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Itbis"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Total"
        Me.Label7.Visible = False
        '
        'TotalPagoPorCompraBindingSource2
        '
        Me.TotalPagoPorCompraBindingSource2.DataMember = "TotalPagoPorCompra"
        Me.TotalPagoPorCompraBindingSource2.DataSource = Me.DsCompras
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '
        'CompraMaterialesDetalleTableAdapter
        '
        Me.CompraMaterialesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraMaterialesDetalleTableAdapter = Me.CompraMaterialesDetalleTableAdapter
        Me.TableAdapterManager.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TotalPagoPorCompraBindingSource
        '
        Me.TotalPagoPorCompraBindingSource.DataSource = Me.DsCompras
        Me.TotalPagoPorCompraBindingSource.Position = 0
        '
        'TotalPagoPorCompraTableAdapter
        '
        Me.TotalPagoPorCompraTableAdapter.ClearBeforeFill = True
        '
        'GroupBoxDatosCompra
        '
        Me.GroupBoxDatosCompra.Controls.Add(Id_CompraLabel)
        Me.GroupBoxDatosCompra.Controls.Add(Me.Id_CompraTextBox)
        Me.GroupBoxDatosCompra.Controls.Add(Id_ProveedorLabel)
        Me.GroupBoxDatosCompra.Controls.Add(Me.Id_ProveedorTextBox)
        Me.GroupBoxDatosCompra.Controls.Add(PorcientoImpuestoLabel)
        Me.GroupBoxDatosCompra.Controls.Add(Me.PorcientoImpuestoTextBox)
        Me.GroupBoxDatosCompra.Controls.Add(MonedaLabel)
        Me.GroupBoxDatosCompra.Controls.Add(Me.MonedaTextBox)
        Me.GroupBoxDatosCompra.Controls.Add(TasaLabel)
        Me.GroupBoxDatosCompra.Controls.Add(Me.TasaTextBox)
        Me.GroupBoxDatosCompra.Controls.Add(Id_EmpresaLabel)
        Me.GroupBoxDatosCompra.Controls.Add(Me.Id_EmpresaTextBox)
        Me.GroupBoxDatosCompra.Location = New System.Drawing.Point(16, 15)
        Me.GroupBoxDatosCompra.Name = "GroupBoxDatosCompra"
        Me.GroupBoxDatosCompra.Size = New System.Drawing.Size(414, 173)
        Me.GroupBoxDatosCompra.TabIndex = 106
        Me.GroupBoxDatosCompra.TabStop = False
        Me.GroupBoxDatosCompra.Text = "Datos de Compra"
        '
        'GroupBoxObservaciones
        '
        Me.GroupBoxObservaciones.Controls.Add(Fecha_CompraLabel)
        Me.GroupBoxObservaciones.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxObservaciones.Controls.Add(FacturaProveedorLabel1)
        Me.GroupBoxObservaciones.Controls.Add(Me.FacturaProveedorTextBox)
        Me.GroupBoxObservaciones.Controls.Add(ObservacionesLabel)
        Me.GroupBoxObservaciones.Controls.Add(Me.ObservacionesTextBox)
        Me.GroupBoxObservaciones.Controls.Add(Label2)
        Me.GroupBoxObservaciones.Controls.Add(Me.TextBox1)
        Me.GroupBoxObservaciones.Controls.Add(Label3)
        Me.GroupBoxObservaciones.Controls.Add(Me.TextBox2)
        Me.GroupBoxObservaciones.Controls.Add(Me.BtnNuevoArticulo)
        Me.GroupBoxObservaciones.Controls.Add(Me.Button2)
        Me.GroupBoxObservaciones.Controls.Add(Me.Button1)
        Me.GroupBoxObservaciones.Location = New System.Drawing.Point(446, 15)
        Me.GroupBoxObservaciones.Name = "GroupBoxObservaciones"
        Me.GroupBoxObservaciones.Size = New System.Drawing.Size(902, 280)
        Me.GroupBoxObservaciones.TabIndex = 107
        Me.GroupBoxObservaciones.TabStop = False
        Me.GroupBoxObservaciones.Text = "Factura y Observaciones"
        '
        'GroupBoxTotales
        '
        Me.GroupBoxTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxTotales.Controls.Add(Me.Label5)
        Me.GroupBoxTotales.Controls.Add(Me.SubTotalCompraRDTextBox)
        Me.GroupBoxTotales.Controls.Add(Me.Label6)
        Me.GroupBoxTotales.Controls.Add(Me.ImpuestoCompraRDTextBox)
        Me.GroupBoxTotales.Controls.Add(Me.Label7)
        Me.GroupBoxTotales.Controls.Add(Me.TotalCompraRDTextBox)
        Me.GroupBoxTotales.Controls.Add(Me.SubTotalCompraUSTextBox)
        Me.GroupBoxTotales.Controls.Add(Me.ImpuestoCompraUSTextBox)
        Me.GroupBoxTotales.Controls.Add(Me.TotalCompraUSTextBox)
        Me.GroupBoxTotales.Controls.Add(Me.BtnGuardar)
        Me.GroupBoxTotales.Location = New System.Drawing.Point(16, 596)
        Me.GroupBoxTotales.Name = "GroupBoxTotales"
        Me.GroupBoxTotales.Size = New System.Drawing.Size(764, 134)
        Me.GroupBoxTotales.TabIndex = 108
        Me.GroupBoxTotales.TabStop = False
        Me.GroupBoxTotales.Text = "Totales"
        '
        'DsCompras1
        '
        Me.DsCompras1.DataSetName = "DsCompras"
        Me.DsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdDetallecompra
        '
        Me.IdDetallecompra.DataPropertyName = "Id_Detalle_compra"
        Me.IdDetallecompra.HeaderText = "Id Detalle"
        Me.IdDetallecompra.MinimumWidth = 6
        Me.IdDetallecompra.Name = "IdDetallecompra"
        Me.IdDetallecompra.Width = 125
        '
        'IdDetalleP
        '
        Me.IdDetalleP.DataPropertyName = "IdDetalle"
        Me.IdDetalleP.HeaderText = "IdDetalleProveedor"
        Me.IdDetalleP.MinimumWidth = 6
        Me.IdDetalleP.Name = "IdDetalleP"
        Me.IdDetalleP.Visible = False
        Me.IdDetalleP.Width = 125
        '
        'Id_Medida
        '
        Me.Id_Medida.DataPropertyName = "Id_Medida"
        Me.Id_Medida.HeaderText = "Id_Medida"
        Me.Id_Medida.MinimumWidth = 6
        Me.Id_Medida.Name = "Id_Medida"
        Me.Id_Medida.Visible = False
        Me.Id_Medida.Width = 125
        '
        'Tasa1
        '
        Me.Tasa1.DataPropertyName = "Tasa"
        Me.Tasa1.HeaderText = "Tasa"
        Me.Tasa1.MinimumWidth = 6
        Me.Tasa1.Name = "Tasa1"
        Me.Tasa1.Visible = False
        Me.Tasa1.Width = 125
        '
        'Id_Material
        '
        Me.Id_Material.DataPropertyName = "Id_Material"
        Me.Id_Material.HeaderText = "Id_Material"
        Me.Id_Material.MinimumWidth = 6
        Me.Id_Material.Name = "Id_Material"
        Me.Id_Material.Visible = False
        Me.Id_Material.Width = 125
        '
        'DescripcionProveedor
        '
        Me.DescripcionProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionProveedor.DataPropertyName = "DescripcionProveedor"
        Me.DescripcionProveedor.HeaderText = "Descripcion"
        Me.DescripcionProveedor.MinimumWidth = 6
        Me.DescripcionProveedor.Name = "DescripcionProveedor"
        Me.DescripcionProveedor.ReadOnly = True
        Me.DescripcionProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Itebis
        '
        Me.Itebis.DataPropertyName = "Itebis"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.Itebis.DefaultCellStyle = DataGridViewCellStyle1
        Me.Itebis.HeaderText = "Itebis"
        Me.Itebis.MinimumWidth = 6
        Me.Itebis.Name = "Itebis"
        Me.Itebis.Visible = False
        Me.Itebis.Width = 60
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n4"
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 75
        '
        'PrecioUS
        '
        Me.PrecioUS.DataPropertyName = "PrecioUS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n4"
        Me.PrecioUS.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioUS.HeaderText = "PrecioUS"
        Me.PrecioUS.MinimumWidth = 6
        Me.PrecioUS.Name = "PrecioUS"
        Me.PrecioUS.Width = 75
        '
        'ItebisUS
        '
        Me.ItebisUS.DataPropertyName = "ItebisUS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.ItebisUS.DefaultCellStyle = DataGridViewCellStyle4
        Me.ItebisUS.HeaderText = "ItebisUS"
        Me.ItebisUS.MinimumWidth = 6
        Me.ItebisUS.Name = "ItebisUS"
        Me.ItebisUS.Width = 75
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalUS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalUS.HeaderText = "TotalUS"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.Width = 75
        '
        'PrecioRD
        '
        Me.PrecioRD.DataPropertyName = "PrecioRD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n4"
        Me.PrecioRD.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioRD.HeaderText = "PrecioRD"
        Me.PrecioRD.MinimumWidth = 6
        Me.PrecioRD.Name = "PrecioRD"
        Me.PrecioRD.Width = 75
        '
        'ItebisRD
        '
        Me.ItebisRD.DataPropertyName = "ItebisRD"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.ItebisRD.DefaultCellStyle = DataGridViewCellStyle7
        Me.ItebisRD.HeaderText = "ItebisRD"
        Me.ItebisRD.MinimumWidth = 6
        Me.ItebisRD.Name = "ItebisRD"
        Me.ItebisRD.Width = 75
        '
        'TotalRD
        '
        Me.TotalRD.DataPropertyName = "TotalRD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n4"
        Me.TotalRD.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalRD.HeaderText = "TotalRD"
        Me.TotalRD.MinimumWidth = 6
        Me.TotalRD.Name = "TotalRD"
        Me.TotalRD.Width = 75
        '
        'Id_Presupuesto
        '
        Me.Id_Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Id_Presupuesto.HeaderText = "Presupuesto"
        Me.Id_Presupuesto.MinimumWidth = 6
        Me.Id_Presupuesto.Name = "Id_Presupuesto"
        Me.Id_Presupuesto.Width = 125
        '
        'FrmIngresoCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1445, 742)
        Me.Controls.Add(Me.GroupBoxTotales)
        Me.Controls.Add(Me.GroupBoxObservaciones)
        Me.Controls.Add(Me.GroupBoxDatosCompra)
        Me.Controls.Add(Me.CompraMaterialesDetalleDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblProyecto)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.LblProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmIngresoCompras"
        Me.Text = "FrmIngresoCompras"
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedoresProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPagoPorCompraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPagoPorCompraBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPagoPorCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosCompra.ResumeLayout(False)
        Me.GroupBoxDatosCompra.PerformLayout()
        Me.GroupBoxObservaciones.ResumeLayout(False)
        Me.GroupBoxObservaciones.PerformLayout()
        Me.GroupBoxTotales.ResumeLayout(False)
        Me.GroupBoxTotales.PerformLayout()
        CType(Me.DsCompras1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubTotalCompraUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImpuestoCompraUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalCompraRDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImpuestoCompraRDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCompraRDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCompraUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Id_CompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonedaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PorcientoImpuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevoArticulo As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CompraMaterialesDetalleDataGridView As DataGridView
    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents CompraMaterialesBindingSource As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents CompraMaterialesDetalleBindingSource As BindingSource
    Friend WithEvents CompraMaterialesDetalleTableAdapter As DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter
    Friend WithEvents DsProveedoresProducto As DsProveedoresProducto
    Friend WithEvents ProveedoresProductoBindingSource As BindingSource
    Friend WithEvents ProveedoresProductoTableAdapter As DsProveedoresProductoTableAdapters.ProveedoresProductoTableAdapter
    Friend WithEvents LblProveedor As Label
    Friend WithEvents LblPresupuesto As Label
    Friend WithEvents LblProyecto As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TableAdapterManager As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents FacturaProveedorTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TotalPagoPorCompraBindingSource As BindingSource
    Friend WithEvents TotalPagoPorCompraTableAdapter As DsComprasTableAdapters.TotalPagoPorCompraTableAdapter
    Friend WithEvents DsCompras1 As DsCompras
    Friend WithEvents TotalPagoPorCompraBindingSource1 As BindingSource
    Friend WithEvents TotalPagoPorCompraBindingSource2 As BindingSource
    Friend WithEvents DsTasa As DsTasa
    Friend WithEvents TasaBindingSource As BindingSource
    Friend WithEvents TasaTableAdapter As DsTasaTableAdapters.TasaTableAdapter
    Friend WithEvents TableAdapterManager1 As DsTasaTableAdapters.TableAdapterManager
    Friend WithEvents TasaTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBoxDatosCompra As GroupBox
    Friend WithEvents GroupBoxObservaciones As GroupBox
    Friend WithEvents GroupBoxTotales As GroupBox
    Friend WithEvents IdDetallecompra As DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleP As DataGridViewTextBoxColumn
    Friend WithEvents Id_Medida As DataGridViewTextBoxColumn
    Friend WithEvents Tasa1 As DataGridViewTextBoxColumn
    Friend WithEvents Id_Material As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Itebis As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUS As DataGridViewTextBoxColumn
    Friend WithEvents ItebisUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRD As DataGridViewTextBoxColumn
    Friend WithEvents ItebisRD As DataGridViewTextBoxColumn
    Friend WithEvents TotalRD As DataGridViewTextBoxColumn
    Friend WithEvents Id_Presupuesto As DataGridViewTextBoxColumn
End Class
