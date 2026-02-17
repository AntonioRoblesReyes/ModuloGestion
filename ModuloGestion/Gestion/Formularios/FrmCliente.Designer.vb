<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
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
        Dim EMail__ClienteLabel As System.Windows.Forms.Label
        Dim NumeroTellfono_ClienteLabel As System.Windows.Forms.Label
        Dim Pais_ClienteLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim NumeroFax_ClienteLabel As System.Windows.Forms.Label
        Dim Ciudad_ClienteLabel As System.Windows.Forms.Label
        Dim Direccion_ClienteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Nombre_ClienteLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrbClientes = New System.Windows.Forms.GroupBox()
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.Nombre_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Direccion_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Ciudad_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Pais_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTellfono_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroFax_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EMail__ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.CarpetaDatosTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComprobanteTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.DvgPagoCliente = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Divisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsPagosClientesDetalle = New ModuloGestion.DsPagosClientesDetalle()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager()
        Me.PagosClientesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPrespuestoPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCobroPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Divisa1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PagadoPorPresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagadoPorPresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PagadoPorPresupuestoTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoRd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EstadoP = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelTotalRDAsignado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnEstadoCliente = New System.Windows.Forms.Button()
        Me.BtnPagos = New System.Windows.Forms.Button()
        Me.CmdNuevoProyecto = New System.Windows.Forms.Button()
        Me.BtnGuardarCliente = New System.Windows.Forms.Button()
        Me.LabelTotalUSAsignado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DsPreciosCompraConsulta = New ModuloGestion.DsPreciosCompraConsulta()
        Me.PrecioCompraConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrecioCompraConsultaTableAdapter = New ModuloGestion.DsPreciosCompraConsultaTableAdapters.PrecioCompraConsultaTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPreciosCompraConsultaTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.IdDetalle_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Ajustado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPartida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsFacturas = New ModuloGestion.DsFacturas()
        Me.FacturaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDetalleTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter()
        Me.TableAdapterManager7 = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.FacturaDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdFAcruraDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columna1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        EMail__ClienteLabel = New System.Windows.Forms.Label()
        NumeroTellfono_ClienteLabel = New System.Windows.Forms.Label()
        Pais_ClienteLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        NumeroFax_ClienteLabel = New System.Windows.Forms.Label()
        Ciudad_ClienteLabel = New System.Windows.Forms.Label()
        Direccion_ClienteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        Me.GrbClientes.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvgPagoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagadoPorPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioCompraConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMail__ClienteLabel
        '
        EMail__ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        EMail__ClienteLabel.Location = New System.Drawing.Point(7, 218)
        EMail__ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMail__ClienteLabel.Name = "EMail__ClienteLabel"
        EMail__ClienteLabel.Size = New System.Drawing.Size(100, 25)
        EMail__ClienteLabel.TabIndex = 14
        EMail__ClienteLabel.Text = "E_Mail "
        '
        'NumeroTellfono_ClienteLabel
        '
        NumeroTellfono_ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        NumeroTellfono_ClienteLabel.Location = New System.Drawing.Point(7, 187)
        NumeroTellfono_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumeroTellfono_ClienteLabel.Name = "NumeroTellfono_ClienteLabel"
        NumeroTellfono_ClienteLabel.Size = New System.Drawing.Size(100, 25)
        NumeroTellfono_ClienteLabel.TabIndex = 10
        NumeroTellfono_ClienteLabel.Text = " Telefono "
        '
        'Pais_ClienteLabel
        '
        Pais_ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Pais_ClienteLabel.Location = New System.Drawing.Point(7, 155)
        Pais_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Pais_ClienteLabel.Name = "Pais_ClienteLabel"
        Pais_ClienteLabel.Size = New System.Drawing.Size(100, 25)
        Pais_ClienteLabel.TabIndex = 8
        Pais_ClienteLabel.Text = "Pais "
        '
        'Label4
        '
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label4.Location = New System.Drawing.Point(7, 26)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 25)
        Label4.TabIndex = 24
        Label4.Text = "Id Fiscal"
        '
        'NumeroFax_ClienteLabel
        '
        NumeroFax_ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        NumeroFax_ClienteLabel.Location = New System.Drawing.Point(306, 182)
        NumeroFax_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumeroFax_ClienteLabel.Name = "NumeroFax_ClienteLabel"
        NumeroFax_ClienteLabel.Size = New System.Drawing.Size(100, 25)
        NumeroFax_ClienteLabel.TabIndex = 12
        NumeroFax_ClienteLabel.Text = " Fax "
        '
        'Ciudad_ClienteLabel
        '
        Ciudad_ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Ciudad_ClienteLabel.Location = New System.Drawing.Point(7, 123)
        Ciudad_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ciudad_ClienteLabel.Name = "Ciudad_ClienteLabel"
        Ciudad_ClienteLabel.Size = New System.Drawing.Size(100, 25)
        Ciudad_ClienteLabel.TabIndex = 6
        Ciudad_ClienteLabel.Text = "Ciudad Cliente:"
        '
        'Direccion_ClienteLabel
        '
        Direccion_ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Direccion_ClienteLabel.Location = New System.Drawing.Point(7, 91)
        Direccion_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Direccion_ClienteLabel.Name = "Direccion_ClienteLabel"
        Direccion_ClienteLabel.Size = New System.Drawing.Size(100, 25)
        Direccion_ClienteLabel.TabIndex = 4
        Direccion_ClienteLabel.Text = "Direccion Cliente:"
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Location = New System.Drawing.Point(7, 244)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(124, 25)
        Label1.TabIndex = 19
        Label1.Text = "Carpeta Datos"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Nombre_ClienteLabel.Location = New System.Drawing.Point(7, 59)
        Nombre_ClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(100, 25)
        Nombre_ClienteLabel.TabIndex = 2
        Nombre_ClienteLabel.Text = "Razon Social"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_FiscalLabel.Location = New System.Drawing.Point(306, 23)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(141, 25)
        Id_FiscalLabel.TabIndex = 0
        Id_FiscalLabel.Text = "Tipo Comprobante:"
        '
        'GrbClientes
        '
        Me.GrbClientes.BackColor = System.Drawing.Color.White
        Me.GrbClientes.Controls.Add(EMail__ClienteLabel)
        Me.GrbClientes.Controls.Add(Me.Id_FiscalTextBox)
        Me.GrbClientes.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.GrbClientes.Controls.Add(Me.Direccion_ClienteTextBox)
        Me.GrbClientes.Controls.Add(Me.Ciudad_ClienteTextBox)
        Me.GrbClientes.Controls.Add(Me.Pais_ClienteTextBox)
        Me.GrbClientes.Controls.Add(Me.NumeroTellfono_ClienteTextBox)
        Me.GrbClientes.Controls.Add(Me.NumeroFax_ClienteTextBox)
        Me.GrbClientes.Controls.Add(Me.Button1)
        Me.GrbClientes.Controls.Add(Me.EMail__ClienteTextBox)
        Me.GrbClientes.Controls.Add(NumeroTellfono_ClienteLabel)
        Me.GrbClientes.Controls.Add(Pais_ClienteLabel)
        Me.GrbClientes.Controls.Add(Label4)
        Me.GrbClientes.Controls.Add(NumeroFax_ClienteLabel)
        Me.GrbClientes.Controls.Add(Me.CarpetaDatosTextBox)
        Me.GrbClientes.Controls.Add(Ciudad_ClienteLabel)
        Me.GrbClientes.Controls.Add(Direccion_ClienteLabel)
        Me.GrbClientes.Controls.Add(Label1)
        Me.GrbClientes.Controls.Add(Nombre_ClienteLabel)
        Me.GrbClientes.Controls.Add(Id_FiscalLabel)
        Me.GrbClientes.Controls.Add(Me.TipoComprobanteTextBox)
        Me.GrbClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GrbClientes.Location = New System.Drawing.Point(13, 26)
        Me.GrbClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.GrbClientes.Name = "GrbClientes"
        Me.GrbClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.GrbClientes.Size = New System.Drawing.Size(574, 288)
        Me.GrbClientes.TabIndex = 32
        Me.GrbClientes.TabStop = False
        Me.GrbClientes.Text = "Datos Cliente"
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(141, 24)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(158, 31)
        Me.Id_FiscalTextBox.TabIndex = 33
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
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(141, 57)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Nombre_ClienteTextBox.TabIndex = 35
        '
        'Direccion_ClienteTextBox
        '
        Me.Direccion_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Direccion_Cliente", True))
        Me.Direccion_ClienteTextBox.Location = New System.Drawing.Point(141, 92)
        Me.Direccion_ClienteTextBox.Name = "Direccion_ClienteTextBox"
        Me.Direccion_ClienteTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Direccion_ClienteTextBox.TabIndex = 37
        '
        'Ciudad_ClienteTextBox
        '
        Me.Ciudad_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Ciudad_Cliente", True))
        Me.Ciudad_ClienteTextBox.Location = New System.Drawing.Point(141, 124)
        Me.Ciudad_ClienteTextBox.Name = "Ciudad_ClienteTextBox"
        Me.Ciudad_ClienteTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Ciudad_ClienteTextBox.TabIndex = 39
        '
        'Pais_ClienteTextBox
        '
        Me.Pais_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Pais_Cliente", True))
        Me.Pais_ClienteTextBox.Location = New System.Drawing.Point(141, 156)
        Me.Pais_ClienteTextBox.Name = "Pais_ClienteTextBox"
        Me.Pais_ClienteTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Pais_ClienteTextBox.TabIndex = 41
        '
        'NumeroTellfono_ClienteTextBox
        '
        Me.NumeroTellfono_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NumeroTellfono_Cliente", True))
        Me.NumeroTellfono_ClienteTextBox.Location = New System.Drawing.Point(141, 187)
        Me.NumeroTellfono_ClienteTextBox.Name = "NumeroTellfono_ClienteTextBox"
        Me.NumeroTellfono_ClienteTextBox.Size = New System.Drawing.Size(158, 31)
        Me.NumeroTellfono_ClienteTextBox.TabIndex = 43
        '
        'NumeroFax_ClienteTextBox
        '
        Me.NumeroFax_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NumeroFax_Cliente", True))
        Me.NumeroFax_ClienteTextBox.Location = New System.Drawing.Point(413, 182)
        Me.NumeroFax_ClienteTextBox.Name = "NumeroFax_ClienteTextBox"
        Me.NumeroFax_ClienteTextBox.Size = New System.Drawing.Size(141, 31)
        Me.NumeroFax_ClienteTextBox.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(455, 244)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EMail__ClienteTextBox
        '
        Me.EMail__ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "EMail_ Cliente", True))
        Me.EMail__ClienteTextBox.Location = New System.Drawing.Point(141, 215)
        Me.EMail__ClienteTextBox.Name = "EMail__ClienteTextBox"
        Me.EMail__ClienteTextBox.Size = New System.Drawing.Size(413, 31)
        Me.EMail__ClienteTextBox.TabIndex = 47
        '
        'CarpetaDatosTextBox
        '
        Me.CarpetaDatosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CarpetaDatos", True))
        Me.CarpetaDatosTextBox.Location = New System.Drawing.Point(141, 244)
        Me.CarpetaDatosTextBox.Name = "CarpetaDatosTextBox"
        Me.CarpetaDatosTextBox.Size = New System.Drawing.Size(306, 31)
        Me.CarpetaDatosTextBox.TabIndex = 53
        '
        'TipoComprobanteTextBox
        '
        Me.TipoComprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "TipoComprobante", True))
        Me.TipoComprobanteTextBox.Location = New System.Drawing.Point(454, 26)
        Me.TipoComprobanteTextBox.Name = "TipoComprobanteTextBox"
        Me.TipoComprobanteTextBox.Size = New System.Drawing.Size(100, 31)
        Me.TipoComprobanteTextBox.TabIndex = 55
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AllowUserToDeleteRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Ver, Me.Estado})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(13, 350)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.ReadOnly = True
        Me.ProyectosDataGridView.RowHeadersWidth = 51
        Me.ProyectosDataGridView.RowTemplate.Height = 24
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(554, 220)
        Me.ProyectosDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Proyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Ver
        '
        Me.Ver.HeaderText = "Ver"
        Me.Ver.MinimumWidth = 6
        Me.Ver.Name = "Ver"
        Me.Ver.ReadOnly = True
        Me.Ver.Width = 40
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 60
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ClientesTableAdapter = Nothing
        Me.TableAdapterManager2.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager2.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DvgPagoCliente
        '
        Me.DvgPagoCliente.AllowUserToAddRows = False
        Me.DvgPagoCliente.AllowUserToDeleteRows = False
        Me.DvgPagoCliente.AutoGenerateColumns = False
        Me.DvgPagoCliente.BackgroundColor = System.Drawing.Color.White
        Me.DvgPagoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DvgPagoCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Divisa, Me.Valor})
        Me.DvgPagoCliente.DataSource = Me.PagosClientesBindingSource
        Me.DvgPagoCliente.Location = New System.Drawing.Point(620, 42)
        Me.DvgPagoCliente.Name = "DvgPagoCliente"
        Me.DvgPagoCliente.ReadOnly = True
        Me.DvgPagoCliente.RowHeadersWidth = 51
        Me.DvgPagoCliente.RowTemplate.Height = 24
        Me.DvgPagoCliente.Size = New System.Drawing.Size(503, 227)
        Me.DvgPagoCliente.TabIndex = 33
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Cobro"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IDCobro"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'Divisa
        '
        Me.Divisa.DataPropertyName = "Moneda"
        Me.Divisa.HeaderText = "Moneda"
        Me.Divisa.MinimumWidth = 6
        Me.Divisa.Name = "Divisa"
        Me.Divisa.ReadOnly = True
        Me.Divisa.Width = 60
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "valor"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle2
        Me.Valor.HeaderText = "valor"
        Me.Valor.MinimumWidth = 6
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 125
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PagosClientesDetalleTableAdapter = Me.PagosClientesDetalleTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesDetalleDataGridView
        '
        Me.PagosClientesDetalleDataGridView.AllowUserToAddRows = False
        Me.PagosClientesDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PagosClientesDetalleDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PagosClientesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPrespuestoPd, Me.IdFacturaPd, Me.IdCobroPd, Me.TotalAsignado, Me.Divisa1, Me.Fecha})
        Me.PagosClientesDetalleDataGridView.DataSource = Me.PagosClientesDetalleBindingSource
        Me.PagosClientesDetalleDataGridView.Location = New System.Drawing.Point(1129, 42)
        Me.PagosClientesDetalleDataGridView.Name = "PagosClientesDetalleDataGridView"
        Me.PagosClientesDetalleDataGridView.ReadOnly = True
        Me.PagosClientesDetalleDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDetalleDataGridView.RowTemplate.Height = 24
        Me.PagosClientesDetalleDataGridView.Size = New System.Drawing.Size(579, 227)
        Me.PagosClientesDetalleDataGridView.TabIndex = 33
        '
        'IdPrespuestoPd
        '
        Me.IdPrespuestoPd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdPrespuestoPd.DataPropertyName = "Id_Presupuesto"
        Me.IdPrespuestoPd.HeaderText = "Presupuesto"
        Me.IdPrespuestoPd.MinimumWidth = 6
        Me.IdPrespuestoPd.Name = "IdPrespuestoPd"
        Me.IdPrespuestoPd.ReadOnly = True
        '
        'IdFacturaPd
        '
        Me.IdFacturaPd.DataPropertyName = "IdFactura"
        Me.IdFacturaPd.HeaderText = "Factura"
        Me.IdFacturaPd.MinimumWidth = 6
        Me.IdFacturaPd.Name = "IdFacturaPd"
        Me.IdFacturaPd.ReadOnly = True
        Me.IdFacturaPd.Width = 90
        '
        'IdCobroPd
        '
        Me.IdCobroPd.DataPropertyName = "ID_Cobro"
        Me.IdCobroPd.HeaderText = "Pago"
        Me.IdCobroPd.MinimumWidth = 6
        Me.IdCobroPd.Name = "IdCobroPd"
        Me.IdCobroPd.ReadOnly = True
        Me.IdCobroPd.Width = 95
        '
        'TotalAsignado
        '
        Me.TotalAsignado.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.TotalAsignado.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalAsignado.HeaderText = "Total"
        Me.TotalAsignado.MinimumWidth = 6
        Me.TotalAsignado.Name = "TotalAsignado"
        Me.TotalAsignado.ReadOnly = True
        Me.TotalAsignado.Width = 70
        '
        'Divisa1
        '
        Me.Divisa1.DataPropertyName = "Moneda"
        Me.Divisa1.HeaderText = "Moneda"
        Me.Divisa1.MinimumWidth = 6
        Me.Divisa1.Name = "Divisa1"
        Me.Divisa1.ReadOnly = True
        Me.Divisa1.Width = 60
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 125
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagadoPorPresupuestoBindingSource
        '
        Me.PagadoPorPresupuestoBindingSource.DataMember = "PagadoPorPresupuesto"
        Me.PagadoPorPresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'PagadoPorPresupuestoTableAdapter
        '
        Me.PagadoPorPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPresupuesto, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11, Me.Moneda, Me.TotalUS, Me.PagadoUS, Me.PendienteUS, Me.TotalRd, Me.PagadoRd, Me.PendienteRD, Me.Total, Me.Pagado, Me.Pendiente, Me.Ejecutado, Me.PagadoP, Me.Ir, Me.EstadoP})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(605, 350)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.ReadOnly = True
        Me.PresupuestoDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDataGridView.RowTemplate.Height = 24
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(1103, 220)
        Me.PresupuestoDataGridView.TabIndex = 33
        '
        'IdPresupuesto
        '
        Me.IdPresupuesto.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuesto.HeaderText = "Presupuesto"
        Me.IdPresupuesto.MinimumWidth = 6
        Me.IdPresupuesto.Name = "IdPresupuesto"
        Me.IdPresupuesto.ReadOnly = True
        Me.IdPresupuesto.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descripcion_Presupuesto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Estado_Presupuesto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "p2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn11.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 60
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
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalPresupuestoUS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalUS.HeaderText = "TotalPresupuestoUS"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.ReadOnly = True
        Me.TotalUS.Visible = False
        Me.TotalUS.Width = 120
        '
        'PagadoUS
        '
        Me.PagadoUS.DataPropertyName = "PagadopresupuestoUS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.PagadoUS.DefaultCellStyle = DataGridViewCellStyle6
        Me.PagadoUS.HeaderText = "PagadopresupuestoUS"
        Me.PagadoUS.MinimumWidth = 6
        Me.PagadoUS.Name = "PagadoUS"
        Me.PagadoUS.ReadOnly = True
        Me.PagadoUS.Visible = False
        Me.PagadoUS.Width = 120
        '
        'PendienteUS
        '
        Me.PendienteUS.DataPropertyName = "EstadoUS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.PendienteUS.DefaultCellStyle = DataGridViewCellStyle7
        Me.PendienteUS.HeaderText = "Pendiente US"
        Me.PendienteUS.MinimumWidth = 6
        Me.PendienteUS.Name = "PendienteUS"
        Me.PendienteUS.ReadOnly = True
        Me.PendienteUS.Visible = False
        Me.PendienteUS.Width = 120
        '
        'TotalRd
        '
        Me.TotalRd.DataPropertyName = "TotalPresupuestoRD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.TotalRd.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalRd.HeaderText = "TotalPresupuestoRD"
        Me.TotalRd.MinimumWidth = 6
        Me.TotalRd.Name = "TotalRd"
        Me.TotalRd.ReadOnly = True
        Me.TotalRd.Visible = False
        Me.TotalRd.Width = 120
        '
        'PagadoRd
        '
        Me.PagadoRd.DataPropertyName = "PagadoRD"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "n2"
        Me.PagadoRd.DefaultCellStyle = DataGridViewCellStyle9
        Me.PagadoRd.HeaderText = "PagadoRD"
        Me.PagadoRd.MinimumWidth = 6
        Me.PagadoRd.Name = "PagadoRd"
        Me.PagadoRd.ReadOnly = True
        Me.PagadoRd.Visible = False
        Me.PagadoRd.Width = 120
        '
        'PendienteRD
        '
        Me.PendienteRD.DataPropertyName = "PendienteRDS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.PendienteRD.DefaultCellStyle = DataGridViewCellStyle10
        Me.PendienteRD.HeaderText = "PendienteRDS"
        Me.PendienteRD.MinimumWidth = 6
        Me.PendienteRD.Name = "PendienteRD"
        Me.PendienteRD.ReadOnly = True
        Me.PendienteRD.Visible = False
        Me.PendienteRD.Width = 120
        '
        'Total
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle11
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'Pagado
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "N2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle12
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 75
        '
        'Pendiente
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle13.Format = "N2"
        Me.Pendiente.DefaultCellStyle = DataGridViewCellStyle13
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.MinimumWidth = 6
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        Me.Pendiente.Width = 75
        '
        'Ejecutado
        '
        Me.Ejecutado.DataPropertyName = "Ejecutado"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle14.Format = "P2"
        Me.Ejecutado.DefaultCellStyle = DataGridViewCellStyle14
        Me.Ejecutado.HeaderText = "Ejecutado"
        Me.Ejecutado.MinimumWidth = 6
        Me.Ejecutado.Name = "Ejecutado"
        Me.Ejecutado.ReadOnly = True
        Me.Ejecutado.Width = 75
        '
        'PagadoP
        '
        Me.PagadoP.DataPropertyName = "PorcientoPago"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle15.Format = "P2"
        Me.PagadoP.DefaultCellStyle = DataGridViewCellStyle15
        Me.PagadoP.HeaderText = "Pagado%"
        Me.PagadoP.MinimumWidth = 6
        Me.PagadoP.Name = "PagadoP"
        Me.PagadoP.ReadOnly = True
        Me.PagadoP.Width = 75
        '
        'Ir
        '
        Me.Ir.HeaderText = "Ver"
        Me.Ir.MinimumWidth = 6
        Me.Ir.Name = "Ir"
        Me.Ir.ReadOnly = True
        Me.Ir.Width = 50
        '
        'EstadoP
        '
        Me.EstadoP.HeaderText = "Estado"
        Me.EstadoP.MinimumWidth = 6
        Me.EstadoP.Name = "EstadoP"
        Me.EstadoP.ReadOnly = True
        Me.EstadoP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EstadoP.Width = 75
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(1446, 583)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 25)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "% pagado"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(1506, 632)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(22, 25)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(1506, 607)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 25)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1414, 632)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 25)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "RD$"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1414, 607)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 25)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "US$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1064, 583)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 25)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Total"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1194, 632)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 25)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1088, 632)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 25)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1194, 607)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 25)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1088, 607)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 25)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1322, 632)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 25)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1162, 583)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 25)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Pagado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1322, 607)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 25)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1303, 583)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Pendiente "
        '
        'LabelTotalRDAsignado
        '
        Me.LabelTotalRDAsignado.AutoSize = True
        Me.LabelTotalRDAsignado.Location = New System.Drawing.Point(1476, 315)
        Me.LabelTotalRDAsignado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalRDAsignado.Name = "LabelTotalRDAsignado"
        Me.LabelTotalRDAsignado.Size = New System.Drawing.Size(22, 25)
        Me.LabelTotalRDAsignado.TabIndex = 67
        Me.LabelTotalRDAsignado.Text = "0"
        Me.LabelTotalRDAsignado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1303, 282)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 25)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Total Asignado US"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(952, 282)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 71
        Me.Label11.Tag = ""
        Me.Label11.Text = "Total RD$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(782, 282)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 25)
        Me.Label10.TabIndex = 70
        Me.Label10.Tag = ""
        Me.Label10.Text = "Total US$"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(877, 282)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 25)
        Me.Label9.TabIndex = 69
        Me.Label9.Tag = ""
        Me.Label9.Text = "Total RD$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(707, 282)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 68
        Me.Label8.Tag = ""
        Me.Label8.Text = "Total US$"
        '
        'BtnEstadoCliente
        '
        Me.BtnEstadoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnEstadoCliente.FlatAppearance.BorderSize = 0
        Me.BtnEstadoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEstadoCliente.ForeColor = System.Drawing.Color.White
        Me.BtnEstadoCliente.Location = New System.Drawing.Point(13, 315)
        Me.BtnEstadoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEstadoCliente.Name = "BtnEstadoCliente"
        Me.BtnEstadoCliente.Size = New System.Drawing.Size(124, 28)
        Me.BtnEstadoCliente.TabIndex = 72
        Me.BtnEstadoCliente.Text = "EstadoCliente"
        Me.BtnEstadoCliente.UseVisualStyleBackColor = False
        '
        'BtnPagos
        '
        Me.BtnPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnPagos.FlatAppearance.BorderSize = 0
        Me.BtnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagos.ForeColor = System.Drawing.Color.White
        Me.BtnPagos.Location = New System.Drawing.Point(145, 315)
        Me.BtnPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPagos.Name = "BtnPagos"
        Me.BtnPagos.Size = New System.Drawing.Size(124, 28)
        Me.BtnPagos.TabIndex = 73
        Me.BtnPagos.Text = "Pagos"
        Me.BtnPagos.UseVisualStyleBackColor = False
        '
        'CmdNuevoProyecto
        '
        Me.CmdNuevoProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmdNuevoProyecto.FlatAppearance.BorderSize = 0
        Me.CmdNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNuevoProyecto.ForeColor = System.Drawing.Color.White
        Me.CmdNuevoProyecto.Location = New System.Drawing.Point(277, 315)
        Me.CmdNuevoProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNuevoProyecto.Name = "CmdNuevoProyecto"
        Me.CmdNuevoProyecto.Size = New System.Drawing.Size(124, 28)
        Me.CmdNuevoProyecto.TabIndex = 74
        Me.CmdNuevoProyecto.Text = "Nuevo Proyecto"
        Me.CmdNuevoProyecto.UseVisualStyleBackColor = False
        '
        'BtnGuardarCliente
        '
        Me.BtnGuardarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BtnGuardarCliente.FlatAppearance.BorderSize = 0
        Me.BtnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarCliente.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarCliente.Location = New System.Drawing.Point(409, 315)
        Me.BtnGuardarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardarCliente.Name = "BtnGuardarCliente"
        Me.BtnGuardarCliente.Size = New System.Drawing.Size(124, 28)
        Me.BtnGuardarCliente.TabIndex = 75
        Me.BtnGuardarCliente.Text = "Guardar "
        Me.BtnGuardarCliente.UseVisualStyleBackColor = False
        '
        'LabelTotalUSAsignado
        '
        Me.LabelTotalUSAsignado.AutoSize = True
        Me.LabelTotalUSAsignado.Location = New System.Drawing.Point(1476, 282)
        Me.LabelTotalUSAsignado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalUSAsignado.Name = "LabelTotalUSAsignado"
        Me.LabelTotalUSAsignado.Size = New System.Drawing.Size(22, 25)
        Me.LabelTotalUSAsignado.TabIndex = 76
        Me.LabelTotalUSAsignado.Text = "0"
        Me.LabelTotalUSAsignado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1303, 315)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 25)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Total Asignado RD"
        '
        'DsPreciosCompraConsulta
        '
        Me.DsPreciosCompraConsulta.DataSetName = "DsPreciosCompraConsulta"
        Me.DsPreciosCompraConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrecioCompraConsultaBindingSource
        '
        Me.PrecioCompraConsultaBindingSource.DataMember = "PrecioCompraConsulta"
        Me.PrecioCompraConsultaBindingSource.DataSource = Me.DsPreciosCompraConsulta
        '
        'PrecioCompraConsultaTableAdapter
        '
        Me.PrecioCompraConsultaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.Connection = Nothing
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsPreciosCompraConsultaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetalle
        '
        Me.DsPresupuestoDetalle.DataSetName = "DsPresupuestoDetalle"
        Me.DsPresupuestoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsPresupuestoDetalle
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalle_Presupuesto, Me.Articulo, Me.Cantidad, Me.Precio_Ajustado, Me.TotalPartida})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(13, 660)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.ReadOnly = True
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 62
        Me.PresupuestoDetalleDataGridView.RowTemplate.Height = 28
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(901, 220)
        Me.PresupuestoDetalleDataGridView.TabIndex = 77
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
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'IdDetalle_Presupuesto
        '
        Me.IdDetalle_Presupuesto.DataPropertyName = "IdDetalle_Presupuesto"
        Me.IdDetalle_Presupuesto.HeaderText = "IdDetalle"
        Me.IdDetalle_Presupuesto.MinimumWidth = 8
        Me.IdDetalle_Presupuesto.Name = "IdDetalle_Presupuesto"
        Me.IdDetalle_Presupuesto.ReadOnly = True
        Me.IdDetalle_Presupuesto.Width = 90
        '
        'Articulo
        '
        Me.Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Articulo.DataPropertyName = "Articulo"
        Me.Articulo.DataSource = Me.ArticulosBindingSource
        Me.Articulo.DisplayMember = "Descripcion_articulo"
        Me.Articulo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.MinimumWidth = 8
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Articulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Articulo.ValueMember = "IdArticulo"
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle16.Format = "n2"
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle16
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 8
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 90
        '
        'Precio_Ajustado
        '
        Me.Precio_Ajustado.DataPropertyName = "Precio_Ajustado"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle17.Format = "n2"
        Me.Precio_Ajustado.DefaultCellStyle = DataGridViewCellStyle17
        Me.Precio_Ajustado.HeaderText = "Precio"
        Me.Precio_Ajustado.MinimumWidth = 8
        Me.Precio_Ajustado.Name = "Precio_Ajustado"
        Me.Precio_Ajustado.ReadOnly = True
        Me.Precio_Ajustado.Width = 90
        '
        'TotalPartida
        '
        Me.TotalPartida.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle18.Format = "n2"
        Me.TotalPartida.DefaultCellStyle = DataGridViewCellStyle18
        Me.TotalPartida.HeaderText = "Total"
        Me.TotalPartida.MinimumWidth = 8
        Me.TotalPartida.Name = "TotalPartida"
        Me.TotalPartida.ReadOnly = True
        Me.TotalPartida.Width = 90
        '
        'DsFacturas
        '
        Me.DsFacturas.DataSetName = "DsFacturas"
        Me.DsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaDetalleBindingSource
        '
        Me.FacturaDetalleBindingSource.DataMember = "FacturaDetalle"
        Me.FacturaDetalleBindingSource.DataSource = Me.DsFacturas
        '
        'FacturaDetalleTableAdapter
        '
        Me.FacturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.ClientesTableAdapter = Nothing
        Me.TableAdapterManager7.ComprobantesFiscalesTableAdapter = Nothing
        Me.TableAdapterManager7.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager7.FacturaDetalleTableAdapter = Me.FacturaDetalleTableAdapter
        Me.TableAdapterManager7.FacturaProformaDetalleTableAdapter = Nothing
        Me.TableAdapterManager7.FacturaProformaTableAdapter = Nothing
        Me.TableAdapterManager7.FacturaTableAdapter = Nothing
        Me.TableAdapterManager7.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsFacturasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaDetalleDataGridView
        '
        Me.FacturaDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaDetalleDataGridView.AllowUserToDeleteRows = False
        Me.FacturaDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.ColumnaPrecio, Me.ColumnaTotal})
        Me.FacturaDetalleDataGridView.DataSource = Me.FacturaDetalleBindingSource
        Me.FacturaDetalleDataGridView.Location = New System.Drawing.Point(920, 660)
        Me.FacturaDetalleDataGridView.Name = "FacturaDetalleDataGridView"
        Me.FacturaDetalleDataGridView.ReadOnly = True
        Me.FacturaDetalleDataGridView.RowHeadersWidth = 62
        Me.FacturaDetalleDataGridView.RowTemplate.Height = 28
        Me.FacturaDetalleDataGridView.Size = New System.Drawing.Size(788, 220)
        Me.FacturaDetalleDataGridView.TabIndex = 77
        '
        'IdFAcruraDetalle
        '
        Me.IdFAcruraDetalle.DataPropertyName = "IdFAcruraDetalle"
        Me.IdFAcruraDetalle.HeaderText = "Id"
        Me.IdFAcruraDetalle.MinimumWidth = 8
        Me.IdFAcruraDetalle.Name = "IdFAcruraDetalle"
        Me.IdFAcruraDetalle.Width = 90
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 8
        Me.Descripcion.Name = "Descripcion"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle22.Format = "n2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'columna1
        '
        Me.columna1.DataPropertyName = "PrecioUS$"
        Me.columna1.HeaderText = "PrecioUS$"
        Me.columna1.MinimumWidth = 8
        Me.columna1.Name = "columna1"
        Me.columna1.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "IdFAcruraDetalle"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Cantidad"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle19.Format = "n2"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn19.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 90
        '
        'ColumnaPrecio
        '
        Me.ColumnaPrecio.DataPropertyName = "PrecioUS$"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "n2"
        Me.ColumnaPrecio.DefaultCellStyle = DataGridViewCellStyle20
        Me.ColumnaPrecio.HeaderText = "PrecioUS$"
        Me.ColumnaPrecio.MinimumWidth = 8
        Me.ColumnaPrecio.Name = "ColumnaPrecio"
        Me.ColumnaPrecio.ReadOnly = True
        Me.ColumnaPrecio.Width = 90
        '
        'ColumnaTotal
        '
        Me.ColumnaTotal.DataPropertyName = "TotalPartidaUS$"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "n2"
        Me.ColumnaTotal.DefaultCellStyle = DataGridViewCellStyle21
        Me.ColumnaTotal.HeaderText = "TotalUS$"
        Me.ColumnaTotal.MinimumWidth = 8
        Me.ColumnaTotal.Name = "ColumnaTotal"
        Me.ColumnaTotal.ReadOnly = True
        Me.ColumnaTotal.Width = 90
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1786, 909)
        Me.Controls.Add(Me.FacturaDetalleDataGridView)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelTotalUSAsignado)
        Me.Controls.Add(Me.BtnGuardarCliente)
        Me.Controls.Add(Me.CmdNuevoProyecto)
        Me.Controls.Add(Me.BtnPagos)
        Me.Controls.Add(Me.BtnEstadoCliente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelTotalRDAsignado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PresupuestoDataGridView)
        Me.Controls.Add(Me.PagosClientesDetalleDataGridView)
        Me.Controls.Add(Me.DvgPagoCliente)
        Me.Controls.Add(Me.ProyectosDataGridView)
        Me.Controls.Add(Me.GrbClientes)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Name = "FrmCliente"
        Me.Text = "FrmCliente"
        Me.GrbClientes.ResumeLayout(False)
        Me.GrbClientes.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvgPagoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagadoPorPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioCompraConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrbClientes As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DsClientes As DsClientes
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents Id_FiscalTextBox As TextBox
    Friend WithEvents Nombre_ClienteTextBox As TextBox
    Friend WithEvents Direccion_ClienteTextBox As TextBox
    Friend WithEvents Ciudad_ClienteTextBox As TextBox
    Friend WithEvents Pais_ClienteTextBox As TextBox
    Friend WithEvents NumeroTellfono_ClienteTextBox As TextBox
    Friend WithEvents NumeroFax_ClienteTextBox As TextBox
    Friend WithEvents EMail__ClienteTextBox As TextBox
    Friend WithEvents CarpetaDatosTextBox As TextBox
    Friend WithEvents TipoComprobanteTextBox As TextBox
    Friend WithEvents DsProyectos As DsProyectos
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager1 As DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosDataGridView As DataGridView
    Friend WithEvents DsPagosClientes As DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As BindingSource
    Friend WithEvents PagosClientesTableAdapter As DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager2 As DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents DvgPagoCliente As DataGridView
    Friend WithEvents DsPagosClientesDetalle As DsPagosClientesDetalle
    Friend WithEvents PagosClientesDetalleBindingSource As BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As DsPagosClientesDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesDetalleDataGridView As DataGridView
    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PagadoPorPresupuestoBindingSource As BindingSource
    Friend WithEvents PagadoPorPresupuestoTableAdapter As DsPresupuestosTableAdapters.PagadoPorPresupuestoTableAdapter
    Friend WithEvents TableAdapterManager4 As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoDataGridView As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelTotalRDAsignado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnEstadoCliente As Button
    Friend WithEvents BtnPagos As Button
    Friend WithEvents CmdNuevoProyecto As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Ver As DataGridViewButtonColumn
    Friend WithEvents Estado As DataGridViewButtonColumn
    Friend WithEvents BtnGuardarCliente As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Divisa As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents IdPrespuestoPd As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaPd As DataGridViewTextBoxColumn
    Friend WithEvents IdCobroPd As DataGridViewTextBoxColumn
    Friend WithEvents TotalAsignado As DataGridViewTextBoxColumn
    Friend WithEvents Divisa1 As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdPresupuesto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents PagadoUS As DataGridViewTextBoxColumn
    Friend WithEvents PendienteUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalRd As DataGridViewTextBoxColumn
    Friend WithEvents PagadoRd As DataGridViewTextBoxColumn
    Friend WithEvents PendienteRD As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutado As DataGridViewTextBoxColumn
    Friend WithEvents PagadoP As DataGridViewTextBoxColumn
    Friend WithEvents Ir As DataGridViewButtonColumn
    Friend WithEvents EstadoP As DataGridViewButtonColumn
    Friend WithEvents LabelTotalUSAsignado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DsPreciosCompraConsulta As DsPreciosCompraConsulta
    Friend WithEvents PrecioCompraConsultaBindingSource As BindingSource
    Friend WithEvents PrecioCompraConsultaTableAdapter As DsPreciosCompraConsultaTableAdapters.PrecioCompraConsultaTableAdapter
    Friend WithEvents TableAdapterManager5 As DsPreciosCompraConsultaTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalle As DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager6 As DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleDataGridView As DataGridView
    Friend WithEvents DsArticulos As DsArticulos
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents IdDetalle_Presupuesto As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewComboBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Ajustado As DataGridViewTextBoxColumn
    Friend WithEvents TotalPartida As DataGridViewTextBoxColumn
    Friend WithEvents DsFacturas As DsFacturas
    Friend WithEvents FacturaDetalleBindingSource As BindingSource
    Friend WithEvents FacturaDetalleTableAdapter As DsFacturasTableAdapters.FacturaDetalleTableAdapter
    Friend WithEvents TableAdapterManager7 As DsFacturasTableAdapters.TableAdapterManager
    Friend WithEvents FacturaDetalleDataGridView As DataGridView
    Friend WithEvents IdFAcruraDetalle As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents columna1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaTotal As DataGridViewTextBoxColumn
End Class
