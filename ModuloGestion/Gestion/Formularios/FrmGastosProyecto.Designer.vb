<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGastosProyecto
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

    '========================
    ' TUS COMPONENTES (NO TOCAR)
    '========================
    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents ResumenComprasProyectoBindingSource As BindingSource
    Friend WithEvents ResumenComprasProyectoTableAdapter As DsComprasTableAdapters.ResumenComprasProyectoTableAdapter
    Friend WithEvents TableAdapterManager As DsComprasTableAdapters.TableAdapterManager

    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents FacturaMontajeBindingSource As BindingSource
    Friend WithEvents FacturaMontajeTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter
    Friend WithEvents TableAdapterManager1 As DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents FacturaMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter
    Friend WithEvents FacturaMontajeDetalleBindingSource As BindingSource

    Friend WithEvents CompraMaterialesDetalleBindingSource As BindingSource
    Friend WithEvents CompraMaterialesDetalleTableAdapter As DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter

    Friend WithEvents CostoComprasProyectoBindingSource As BindingSource
    Friend WithEvents CostoComprasProyectoTableAdapter As DsComprasTableAdapters.CostoComprasProyectoTableAdapter

    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCompraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetallecompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCompraDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioEUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisEuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalEUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSubtotalRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TItbisRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTotalRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSubtotaUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TItbisUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTotalusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.tlpTotalesMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTotales = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSubTotalMontaje = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblItebisMontaje = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTotalMontaje = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblPagadoMontaje = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.lblPendienteMontaje = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.lblSubTotalCompras = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblItebisCompras = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblTotalCompras = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblPagadoCompras = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.PanelTotalesDerecha = New System.Windows.Forms.Panel()
        Me.tlpResumenAcciones = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelResumen = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTasaCambio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblGastosUSD = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSubTotalProyecto = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBeneficio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPorcentajeBeneficio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.splitCompras = New System.Windows.Forms.SplitContainer()
        Me.CostoComprasProyectoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItebisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoComprasProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.CompraMaterialesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompraMaterialesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.splitFacturas = New System.Windows.Forms.SplitContainer()
        Me.FacturaMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Itebis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalIrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.FacturaMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.FacturaMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter()
        Me.ResumenComprasProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenComprasProyectoTableAdapter = New ModuloGestion.DsComprasTableAdapters.ResumenComprasProyectoTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.CostoComprasProyectoTableAdapter = New ModuloGestion.DsComprasTableAdapters.CostoComprasProyectoTableAdapter()
        Me.CompraMaterialesDetalleTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter()
        Me.PanelTotales.SuspendLayout()
        Me.tlpTotalesMain.SuspendLayout()
        Me.tlpTotales.SuspendLayout()
        Me.PanelTotalesDerecha.SuspendLayout()
        Me.tlpResumenAcciones.SuspendLayout()
        Me.PanelResumen.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.splitCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitCompras.Panel1.SuspendLayout()
        Me.splitCompras.Panel2.SuspendLayout()
        Me.splitCompras.SuspendLayout()
        CType(Me.CostoComprasProyectoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostoComprasProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitFacturas.Panel1.SuspendLayout()
        Me.splitFacturas.Panel2.SuspendLayout()
        Me.splitFacturas.SuspendLayout()
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        CType(Me.ResumenComprasProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdproyectoPresupuestosDataGridViewTextBoxColumn1
        '
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn1.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn1.HeaderText = "Id_proyecto_Presupuestos"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn1.Name = "IdproyectoPresupuestosDataGridViewTextBoxColumn1"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn1.Width = 8
        '
        'IdCompraDataGridViewTextBoxColumn1
        '
        Me.IdCompraDataGridViewTextBoxColumn1.DataPropertyName = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn1.HeaderText = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IdCompraDataGridViewTextBoxColumn1.Name = "IdCompraDataGridViewTextBoxColumn1"
        Me.IdCompraDataGridViewTextBoxColumn1.Width = 22
        '
        'TotalDataGridViewTextBoxColumn1
        '
        Me.TotalDataGridViewTextBoxColumn1.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TotalDataGridViewTextBoxColumn1.Name = "TotalDataGridViewTextBoxColumn1"
        Me.TotalDataGridViewTextBoxColumn1.Width = 21
        '
        'RazonSocialDataGridViewTextBoxColumn1
        '
        Me.RazonSocialDataGridViewTextBoxColumn1.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.RazonSocialDataGridViewTextBoxColumn1.Name = "RazonSocialDataGridViewTextBoxColumn1"
        Me.RazonSocialDataGridViewTextBoxColumn1.Width = 22
        '
        'SubtotalDataGridViewTextBoxColumn1
        '
        Me.SubtotalDataGridViewTextBoxColumn1.DataPropertyName = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn1.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.SubtotalDataGridViewTextBoxColumn1.Name = "SubtotalDataGridViewTextBoxColumn1"
        Me.SubtotalDataGridViewTextBoxColumn1.Width = 22
        '
        'ItebisDataGridViewTextBoxColumn1
        '
        Me.ItebisDataGridViewTextBoxColumn1.DataPropertyName = "Itebis"
        Me.ItebisDataGridViewTextBoxColumn1.HeaderText = "Itebis"
        Me.ItebisDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.ItebisDataGridViewTextBoxColumn1.Name = "ItebisDataGridViewTextBoxColumn1"
        Me.ItebisDataGridViewTextBoxColumn1.Width = 23
        '
        'PagadoRDDataGridViewTextBoxColumn
        '
        Me.PagadoRDDataGridViewTextBoxColumn.DataPropertyName = "PagadoRD"
        Me.PagadoRDDataGridViewTextBoxColumn.HeaderText = "PagadoRD"
        Me.PagadoRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PagadoRDDataGridViewTextBoxColumn.Name = "PagadoRDDataGridViewTextBoxColumn"
        Me.PagadoRDDataGridViewTextBoxColumn.Width = 22
        '
        'IdDetallecompraDataGridViewTextBoxColumn
        '
        Me.IdDetallecompraDataGridViewTextBoxColumn.DataPropertyName = "Id_Detalle_compra"
        Me.IdDetallecompraDataGridViewTextBoxColumn.HeaderText = "Id_Detalle_compra"
        Me.IdDetallecompraDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDetallecompraDataGridViewTextBoxColumn.Name = "IdDetallecompraDataGridViewTextBoxColumn"
        Me.IdDetallecompraDataGridViewTextBoxColumn.Width = 8
        '
        'IdCompraDataGridViewTextBoxColumn2
        '
        Me.IdCompraDataGridViewTextBoxColumn2.DataPropertyName = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn2.HeaderText = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.IdCompraDataGridViewTextBoxColumn2.Name = "IdCompraDataGridViewTextBoxColumn2"
        Me.IdCompraDataGridViewTextBoxColumn2.Width = 8
        '
        'IdMaterialDataGridViewTextBoxColumn
        '
        Me.IdMaterialDataGridViewTextBoxColumn.DataPropertyName = "Id_Material"
        Me.IdMaterialDataGridViewTextBoxColumn.HeaderText = "Id_Material"
        Me.IdMaterialDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdMaterialDataGridViewTextBoxColumn.Name = "IdMaterialDataGridViewTextBoxColumn"
        Me.IdMaterialDataGridViewTextBoxColumn.Width = 8
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 8
        '
        'PrecioUSDataGridViewTextBoxColumn
        '
        Me.PrecioUSDataGridViewTextBoxColumn.DataPropertyName = "PrecioUS"
        Me.PrecioUSDataGridViewTextBoxColumn.HeaderText = "PrecioUS"
        Me.PrecioUSDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioUSDataGridViewTextBoxColumn.Name = "PrecioUSDataGridViewTextBoxColumn"
        Me.PrecioUSDataGridViewTextBoxColumn.Width = 8
        '
        'ItebisUSDataGridViewTextBoxColumn
        '
        Me.ItebisUSDataGridViewTextBoxColumn.DataPropertyName = "ItebisUS"
        Me.ItebisUSDataGridViewTextBoxColumn.HeaderText = "ItebisUS"
        Me.ItebisUSDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ItebisUSDataGridViewTextBoxColumn.Name = "ItebisUSDataGridViewTextBoxColumn"
        Me.ItebisUSDataGridViewTextBoxColumn.Width = 8
        '
        'TotalUSDataGridViewTextBoxColumn
        '
        Me.TotalUSDataGridViewTextBoxColumn.DataPropertyName = "TotalUS"
        Me.TotalUSDataGridViewTextBoxColumn.HeaderText = "TotalUS"
        Me.TotalUSDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalUSDataGridViewTextBoxColumn.Name = "TotalUSDataGridViewTextBoxColumn"
        Me.TotalUSDataGridViewTextBoxColumn.Width = 8
        '
        'IdMedidaDataGridViewTextBoxColumn
        '
        Me.IdMedidaDataGridViewTextBoxColumn.DataPropertyName = "Id_Medida"
        Me.IdMedidaDataGridViewTextBoxColumn.HeaderText = "Id_Medida"
        Me.IdMedidaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdMedidaDataGridViewTextBoxColumn.Name = "IdMedidaDataGridViewTextBoxColumn"
        Me.IdMedidaDataGridViewTextBoxColumn.Width = 8
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.Width = 8
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.Width = 8
        '
        'PrecioRDDataGridViewTextBoxColumn
        '
        Me.PrecioRDDataGridViewTextBoxColumn.DataPropertyName = "PrecioRD"
        Me.PrecioRDDataGridViewTextBoxColumn.HeaderText = "PrecioRD"
        Me.PrecioRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioRDDataGridViewTextBoxColumn.Name = "PrecioRDDataGridViewTextBoxColumn"
        Me.PrecioRDDataGridViewTextBoxColumn.Width = 8
        '
        'ItebisRDDataGridViewTextBoxColumn
        '
        Me.ItebisRDDataGridViewTextBoxColumn.DataPropertyName = "ItebisRD"
        Me.ItebisRDDataGridViewTextBoxColumn.HeaderText = "ItebisRD"
        Me.ItebisRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ItebisRDDataGridViewTextBoxColumn.Name = "ItebisRDDataGridViewTextBoxColumn"
        Me.ItebisRDDataGridViewTextBoxColumn.Width = 8
        '
        'TotalRDDataGridViewTextBoxColumn
        '
        Me.TotalRDDataGridViewTextBoxColumn.DataPropertyName = "TotalRD"
        Me.TotalRDDataGridViewTextBoxColumn.HeaderText = "TotalRD"
        Me.TotalRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalRDDataGridViewTextBoxColumn.Name = "TotalRDDataGridViewTextBoxColumn"
        Me.TotalRDDataGridViewTextBoxColumn.Width = 8
        '
        'PrecioEUDataGridViewTextBoxColumn
        '
        Me.PrecioEUDataGridViewTextBoxColumn.DataPropertyName = "PrecioEU"
        Me.PrecioEUDataGridViewTextBoxColumn.HeaderText = "PrecioEU"
        Me.PrecioEUDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioEUDataGridViewTextBoxColumn.Name = "PrecioEUDataGridViewTextBoxColumn"
        Me.PrecioEUDataGridViewTextBoxColumn.Width = 8
        '
        'ItebisEuDataGridViewTextBoxColumn
        '
        Me.ItebisEuDataGridViewTextBoxColumn.DataPropertyName = "ItebisEu"
        Me.ItebisEuDataGridViewTextBoxColumn.HeaderText = "ItebisEu"
        Me.ItebisEuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ItebisEuDataGridViewTextBoxColumn.Name = "ItebisEuDataGridViewTextBoxColumn"
        Me.ItebisEuDataGridViewTextBoxColumn.Width = 8
        '
        'TotalEUDataGridViewTextBoxColumn
        '
        Me.TotalEUDataGridViewTextBoxColumn.DataPropertyName = "TotalEU"
        Me.TotalEUDataGridViewTextBoxColumn.HeaderText = "TotalEU"
        Me.TotalEUDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalEUDataGridViewTextBoxColumn.Name = "TotalEUDataGridViewTextBoxColumn"
        Me.TotalEUDataGridViewTextBoxColumn.Width = 8
        '
        'ItebisDataGridViewTextBoxColumn2
        '
        Me.ItebisDataGridViewTextBoxColumn2.DataPropertyName = "Itebis"
        Me.ItebisDataGridViewTextBoxColumn2.HeaderText = "Itebis"
        Me.ItebisDataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.ItebisDataGridViewTextBoxColumn2.Name = "ItebisDataGridViewTextBoxColumn2"
        Me.ItebisDataGridViewTextBoxColumn2.Width = 8
        '
        'IdPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.HeaderText = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdPresupuestoDataGridViewTextBoxColumn.Name = "IdPresupuestoDataGridViewTextBoxColumn"
        Me.IdPresupuestoDataGridViewTextBoxColumn.Width = 8
        '
        'DescripcionProveedorDataGridViewTextBoxColumn
        '
        Me.DescripcionProveedorDataGridViewTextBoxColumn.DataPropertyName = "DescripcionProveedor"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.HeaderText = "DescripcionProveedor"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DescripcionProveedorDataGridViewTextBoxColumn.Name = "DescripcionProveedorDataGridViewTextBoxColumn"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.Width = 8
        '
        'IdDetalleDataGridViewTextBoxColumn
        '
        Me.IdDetalleDataGridViewTextBoxColumn.DataPropertyName = "IdDetalle"
        Me.IdDetalleDataGridViewTextBoxColumn.HeaderText = "IdDetalle"
        Me.IdDetalleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDetalleDataGridViewTextBoxColumn.Name = "IdDetalleDataGridViewTextBoxColumn"
        Me.IdDetalleDataGridViewTextBoxColumn.Width = 8
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 8
        '
        'TSubtotalRDDataGridViewTextBoxColumn
        '
        Me.TSubtotalRDDataGridViewTextBoxColumn.DataPropertyName = "TSubtotalRD"
        Me.TSubtotalRDDataGridViewTextBoxColumn.HeaderText = "TSubtotalRD"
        Me.TSubtotalRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TSubtotalRDDataGridViewTextBoxColumn.Name = "TSubtotalRDDataGridViewTextBoxColumn"
        Me.TSubtotalRDDataGridViewTextBoxColumn.Width = 8
        '
        'TItbisRDDataGridViewTextBoxColumn
        '
        Me.TItbisRDDataGridViewTextBoxColumn.DataPropertyName = "TItbisRD"
        Me.TItbisRDDataGridViewTextBoxColumn.HeaderText = "TItbisRD"
        Me.TItbisRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TItbisRDDataGridViewTextBoxColumn.Name = "TItbisRDDataGridViewTextBoxColumn"
        Me.TItbisRDDataGridViewTextBoxColumn.Width = 8
        '
        'TTotalRDDataGridViewTextBoxColumn
        '
        Me.TTotalRDDataGridViewTextBoxColumn.DataPropertyName = "TTotalRD"
        Me.TTotalRDDataGridViewTextBoxColumn.HeaderText = "TTotalRD"
        Me.TTotalRDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TTotalRDDataGridViewTextBoxColumn.Name = "TTotalRDDataGridViewTextBoxColumn"
        Me.TTotalRDDataGridViewTextBoxColumn.Width = 8
        '
        'TSubtotaUSDataGridViewTextBoxColumn
        '
        Me.TSubtotaUSDataGridViewTextBoxColumn.DataPropertyName = "TSubtotaUS"
        Me.TSubtotaUSDataGridViewTextBoxColumn.HeaderText = "TSubtotaUS"
        Me.TSubtotaUSDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TSubtotaUSDataGridViewTextBoxColumn.Name = "TSubtotaUSDataGridViewTextBoxColumn"
        Me.TSubtotaUSDataGridViewTextBoxColumn.Width = 8
        '
        'TItbisUSDataGridViewTextBoxColumn
        '
        Me.TItbisUSDataGridViewTextBoxColumn.DataPropertyName = "TItbisUS"
        Me.TItbisUSDataGridViewTextBoxColumn.HeaderText = "TItbisUS"
        Me.TItbisUSDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TItbisUSDataGridViewTextBoxColumn.Name = "TItbisUSDataGridViewTextBoxColumn"
        Me.TItbisUSDataGridViewTextBoxColumn.Width = 8
        '
        'TTotalusDataGridViewTextBoxColumn
        '
        Me.TTotalusDataGridViewTextBoxColumn.DataPropertyName = "TTotalus"
        Me.TTotalusDataGridViewTextBoxColumn.HeaderText = "TTotalus"
        Me.TTotalusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TTotalusDataGridViewTextBoxColumn.Name = "TTotalusDataGridViewTextBoxColumn"
        Me.TTotalusDataGridViewTextBoxColumn.Width = 8
        '
        'PanelTotales
        '
        Me.PanelTotales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTotales.Controls.Add(Me.tlpTotalesMain)
        Me.PanelTotales.Location = New System.Drawing.Point(3, 593)
        Me.PanelTotales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Padding = New System.Windows.Forms.Padding(11, 12, 11, 12)
        Me.PanelTotales.Size = New System.Drawing.Size(766, 379)
        Me.PanelTotales.TabIndex = 3
        '
        'tlpTotalesMain
        '
        Me.tlpTotalesMain.ColumnCount = 2
        Me.tlpTotalesMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpTotalesMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpTotalesMain.Controls.Add(Me.tlpTotales, 0, 0)
        Me.tlpTotalesMain.Controls.Add(Me.PanelTotalesDerecha, 1, 0)
        Me.tlpTotalesMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTotalesMain.Location = New System.Drawing.Point(11, 12)
        Me.tlpTotalesMain.Name = "tlpTotalesMain"
        Me.tlpTotalesMain.RowCount = 1
        Me.tlpTotalesMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355.0!))
        Me.tlpTotalesMain.Size = New System.Drawing.Size(742, 353)
        Me.tlpTotalesMain.TabIndex = 0
        '
        'tlpTotales
        '
        Me.tlpTotales.BackColor = System.Drawing.Color.White
        Me.tlpTotales.ColumnCount = 2
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tlpTotales.Controls.Add(Me.lblSubTotalMontaje, 0, 0)
        Me.tlpTotales.Controls.Add(Me.TextBox1, 1, 0)
        Me.tlpTotales.Controls.Add(Me.lblItebisMontaje, 0, 1)
        Me.tlpTotales.Controls.Add(Me.TextBox2, 1, 1)
        Me.tlpTotales.Controls.Add(Me.lblTotalMontaje, 0, 2)
        Me.tlpTotales.Controls.Add(Me.TextBox3, 1, 2)
        Me.tlpTotales.Controls.Add(Me.lblPagadoMontaje, 0, 3)
        Me.tlpTotales.Controls.Add(Me.TextBox8, 1, 3)
        Me.tlpTotales.Controls.Add(Me.lblPendienteMontaje, 0, 4)
        Me.tlpTotales.Controls.Add(Me.TextBox9, 1, 4)
        Me.tlpTotales.Controls.Add(Me.lblSubTotalCompras, 0, 5)
        Me.tlpTotales.Controls.Add(Me.TextBox4, 1, 5)
        Me.tlpTotales.Controls.Add(Me.lblItebisCompras, 0, 6)
        Me.tlpTotales.Controls.Add(Me.TextBox5, 1, 6)
        Me.tlpTotales.Controls.Add(Me.lblTotalCompras, 0, 7)
        Me.tlpTotales.Controls.Add(Me.TextBox6, 1, 7)
        Me.tlpTotales.Controls.Add(Me.lblPagadoCompras, 0, 8)
        Me.tlpTotales.Controls.Add(Me.TextBox10, 1, 8)
        Me.tlpTotales.Controls.Add(Me.Label2, 0, 9)
        Me.tlpTotales.Controls.Add(Me.TextBox7, 1, 9)
        Me.tlpTotales.Controls.Add(Me.Label3, 0, 10)
        Me.tlpTotales.Controls.Add(Me.TextBox11, 1, 10)
        Me.tlpTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTotales.Location = New System.Drawing.Point(3, 4)
        Me.tlpTotales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpTotales.Name = "tlpTotales"
        Me.tlpTotales.RowCount = 11
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpTotales.Size = New System.Drawing.Size(439, 347)
        Me.tlpTotales.TabIndex = 0
        '
        'lblSubTotalMontaje
        '
        Me.lblSubTotalMontaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubTotalMontaje.Location = New System.Drawing.Point(3, 0)
        Me.lblSubTotalMontaje.Name = "lblSubTotalMontaje"
        Me.lblSubTotalMontaje.Size = New System.Drawing.Size(191, 30)
        Me.lblSubTotalMontaje.TabIndex = 0
        Me.lblSubTotalMontaje.Text = "SubTotal Montaje"
        Me.lblSubTotalMontaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(200, 4)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(236, 31)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblItebisMontaje
        '
        Me.lblItebisMontaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblItebisMontaje.Location = New System.Drawing.Point(3, 30)
        Me.lblItebisMontaje.Name = "lblItebisMontaje"
        Me.lblItebisMontaje.Size = New System.Drawing.Size(191, 30)
        Me.lblItebisMontaje.TabIndex = 2
        Me.lblItebisMontaje.Text = "ITBIS Montaje"
        Me.lblItebisMontaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(200, 34)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(236, 31)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalMontaje
        '
        Me.lblTotalMontaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalMontaje.Location = New System.Drawing.Point(3, 60)
        Me.lblTotalMontaje.Name = "lblTotalMontaje"
        Me.lblTotalMontaje.Size = New System.Drawing.Size(191, 30)
        Me.lblTotalMontaje.TabIndex = 4
        Me.lblTotalMontaje.Text = "Total Montaje"
        Me.lblTotalMontaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(200, 64)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(236, 31)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPagadoMontaje
        '
        Me.lblPagadoMontaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPagadoMontaje.Location = New System.Drawing.Point(3, 90)
        Me.lblPagadoMontaje.Name = "lblPagadoMontaje"
        Me.lblPagadoMontaje.Size = New System.Drawing.Size(191, 30)
        Me.lblPagadoMontaje.TabIndex = 6
        Me.lblPagadoMontaje.Text = "Pagado Montaje"
        Me.lblPagadoMontaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.Location = New System.Drawing.Point(200, 94)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(236, 31)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPendienteMontaje
        '
        Me.lblPendienteMontaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPendienteMontaje.Location = New System.Drawing.Point(3, 120)
        Me.lblPendienteMontaje.Name = "lblPendienteMontaje"
        Me.lblPendienteMontaje.Size = New System.Drawing.Size(191, 30)
        Me.lblPendienteMontaje.TabIndex = 8
        Me.lblPendienteMontaje.Text = "Pendiente Montaje"
        Me.lblPendienteMontaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox9.Location = New System.Drawing.Point(200, 124)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(236, 31)
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSubTotalCompras
        '
        Me.lblSubTotalCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubTotalCompras.Location = New System.Drawing.Point(3, 150)
        Me.lblSubTotalCompras.Name = "lblSubTotalCompras"
        Me.lblSubTotalCompras.Size = New System.Drawing.Size(191, 30)
        Me.lblSubTotalCompras.TabIndex = 10
        Me.lblSubTotalCompras.Text = "SubTotal Compras"
        Me.lblSubTotalCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(200, 154)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(236, 31)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblItebisCompras
        '
        Me.lblItebisCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblItebisCompras.Location = New System.Drawing.Point(3, 180)
        Me.lblItebisCompras.Name = "lblItebisCompras"
        Me.lblItebisCompras.Size = New System.Drawing.Size(191, 30)
        Me.lblItebisCompras.TabIndex = 12
        Me.lblItebisCompras.Text = "ITBIS Compras"
        Me.lblItebisCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(200, 184)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(236, 31)
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalCompras
        '
        Me.lblTotalCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCompras.Location = New System.Drawing.Point(3, 210)
        Me.lblTotalCompras.Name = "lblTotalCompras"
        Me.lblTotalCompras.Size = New System.Drawing.Size(191, 30)
        Me.lblTotalCompras.TabIndex = 14
        Me.lblTotalCompras.Text = "Total Compras"
        Me.lblTotalCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.Location = New System.Drawing.Point(200, 214)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(236, 31)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPagadoCompras
        '
        Me.lblPagadoCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPagadoCompras.Location = New System.Drawing.Point(3, 240)
        Me.lblPagadoCompras.Name = "lblPagadoCompras"
        Me.lblPagadoCompras.Size = New System.Drawing.Size(191, 30)
        Me.lblPagadoCompras.TabIndex = 16
        Me.lblPagadoCompras.Text = "Pagado Compras"
        Me.lblPagadoCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox10.Location = New System.Drawing.Point(200, 244)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(236, 31)
        Me.TextBox10.TabIndex = 17
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 30)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total Montaje y compras"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.Location = New System.Drawing.Point(200, 274)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(236, 31)
        Me.TextBox7.TabIndex = 19
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 47)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Pendiente Pagar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox11.Location = New System.Drawing.Point(200, 304)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(236, 31)
        Me.TextBox11.TabIndex = 21
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelTotalesDerecha
        '
        Me.PanelTotalesDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelTotalesDerecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTotalesDerecha.Controls.Add(Me.tlpResumenAcciones)
        Me.PanelTotalesDerecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTotalesDerecha.Location = New System.Drawing.Point(448, 3)
        Me.PanelTotalesDerecha.Name = "PanelTotalesDerecha"
        Me.PanelTotalesDerecha.Size = New System.Drawing.Size(291, 349)
        Me.PanelTotalesDerecha.TabIndex = 1
        '
        'tlpResumenAcciones
        '
        Me.tlpResumenAcciones.ColumnCount = 1
        Me.tlpResumenAcciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpResumenAcciones.Controls.Add(Me.PanelResumen, 0, 0)
        Me.tlpResumenAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpResumenAcciones.Location = New System.Drawing.Point(0, 0)
        Me.tlpResumenAcciones.Name = "tlpResumenAcciones"
        Me.tlpResumenAcciones.RowCount = 2
        Me.tlpResumenAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpResumenAcciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpResumenAcciones.Size = New System.Drawing.Size(289, 347)
        Me.tlpResumenAcciones.TabIndex = 0
        '
        'PanelResumen
        '
        Me.PanelResumen.BackColor = System.Drawing.Color.White
        Me.PanelResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelResumen.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelResumen.Controls.Add(Me.Label4)
        Me.PanelResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelResumen.Location = New System.Drawing.Point(3, 3)
        Me.PanelResumen.Name = "PanelResumen"
        Me.PanelResumen.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelResumen.Size = New System.Drawing.Size(283, 236)
        Me.PanelResumen.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTasaCambio, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGastosUSD, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSubTotalProyecto, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBeneficio, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPorcentajeBeneficio, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 38)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(261, 150)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tasa"
        '
        'txtTasaCambio
        '
        Me.txtTasaCambio.BackColor = System.Drawing.Color.White
        Me.txtTasaCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTasaCambio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTasaCambio.Location = New System.Drawing.Point(159, 3)
        Me.txtTasaCambio.Name = "txtTasaCambio"
        Me.txtTasaCambio.Size = New System.Drawing.Size(99, 31)
        Me.txtTasaCambio.TabIndex = 1
        Me.txtTasaCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 30)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gastos en dólares"
        '
        'lblGastosUSD
        '
        Me.lblGastosUSD.AutoSize = True
        Me.lblGastosUSD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGastosUSD.Location = New System.Drawing.Point(159, 30)
        Me.lblGastosUSD.Name = "lblGastosUSD"
        Me.lblGastosUSD.Size = New System.Drawing.Size(99, 30)
        Me.lblGastosUSD.TabIndex = 3
        Me.lblGastosUSD.Text = "0.00"
        Me.lblGastosUSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SubTotal Proyecto"
        '
        'lblSubTotalProyecto
        '
        Me.lblSubTotalProyecto.AutoSize = True
        Me.lblSubTotalProyecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubTotalProyecto.Location = New System.Drawing.Point(159, 60)
        Me.lblSubTotalProyecto.Name = "lblSubTotalProyecto"
        Me.lblSubTotalProyecto.Size = New System.Drawing.Size(99, 30)
        Me.lblSubTotalProyecto.TabIndex = 5
        Me.lblSubTotalProyecto.Text = "0.00"
        Me.lblSubTotalProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 30)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Beneficio"
        '
        'lblBeneficio
        '
        Me.lblBeneficio.AutoSize = True
        Me.lblBeneficio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBeneficio.Location = New System.Drawing.Point(159, 90)
        Me.lblBeneficio.Name = "lblBeneficio"
        Me.lblBeneficio.Size = New System.Drawing.Size(99, 30)
        Me.lblBeneficio.TabIndex = 7
        Me.lblBeneficio.Text = "0.00"
        Me.lblBeneficio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "% de beneficio"
        '
        'lblPorcentajeBeneficio
        '
        Me.lblPorcentajeBeneficio.AutoSize = True
        Me.lblPorcentajeBeneficio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPorcentajeBeneficio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPorcentajeBeneficio.Location = New System.Drawing.Point(159, 120)
        Me.lblPorcentajeBeneficio.Name = "lblPorcentajeBeneficio"
        Me.lblPorcentajeBeneficio.Size = New System.Drawing.Size(99, 30)
        Me.lblPorcentajeBeneficio.TabIndex = 9
        Me.lblPorcentajeBeneficio.Text = " 0.00 %"
        Me.lblPorcentajeBeneficio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Resumen Final"
        '
        'splitCompras
        '
        Me.splitCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitCompras.Location = New System.Drawing.Point(3, 326)
        Me.splitCompras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitCompras.Name = "splitCompras"
        '
        'splitCompras.Panel1
        '
        Me.splitCompras.Panel1.Controls.Add(Me.CostoComprasProyectoDataGridView)
        '
        'splitCompras.Panel2
        '
        Me.splitCompras.Panel2.Controls.Add(Me.CompraMaterialesDetalleDataGridView)
        Me.splitCompras.Size = New System.Drawing.Size(1595, 259)
        Me.splitCompras.SplitterDistance = 760
        Me.splitCompras.SplitterWidth = 7
        Me.splitCompras.TabIndex = 2
        '
        'CostoComprasProyectoDataGridView
        '
        Me.CostoComprasProyectoDataGridView.AllowUserToAddRows = False
        Me.CostoComprasProyectoDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostoComprasProyectoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CostoComprasProyectoDataGridView.AutoGenerateColumns = False
        Me.CostoComprasProyectoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CostoComprasProyectoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CostoComprasProyectoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CostoComprasProyectoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CostoComprasProyectoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CostoComprasProyectoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CostoComprasProyectoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproyectoPresupuestosDataGridViewTextBoxColumn, Me.IdCompraDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.ItebisDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PagadoRD})
        Me.CostoComprasProyectoDataGridView.DataSource = Me.CostoComprasProyectoBindingSource
        Me.CostoComprasProyectoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CostoComprasProyectoDataGridView.EnableHeadersVisualStyles = False
        Me.CostoComprasProyectoDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CostoComprasProyectoDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CostoComprasProyectoDataGridView.MultiSelect = False
        Me.CostoComprasProyectoDataGridView.Name = "CostoComprasProyectoDataGridView"
        Me.CostoComprasProyectoDataGridView.ReadOnly = True
        Me.CostoComprasProyectoDataGridView.RowHeadersVisible = False
        Me.CostoComprasProyectoDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.CostoComprasProyectoDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.CostoComprasProyectoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CostoComprasProyectoDataGridView.Size = New System.Drawing.Size(760, 259)
        Me.CostoComprasProyectoDataGridView.TabIndex = 0
        '
        'IdproyectoPresupuestosDataGridViewTextBoxColumn
        '
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.HeaderText = "Id_proyecto_Presupuestos"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.Name = "IdproyectoPresupuestosDataGridViewTextBoxColumn"
        Me.IdproyectoPresupuestosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCompraDataGridViewTextBoxColumn
        '
        Me.IdCompraDataGridViewTextBoxColumn.DataPropertyName = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn.HeaderText = "Id_Compra"
        Me.IdCompraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCompraDataGridViewTextBoxColumn.Name = "IdCompraDataGridViewTextBoxColumn"
        Me.IdCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.SubtotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItebisDataGridViewTextBoxColumn
        '
        Me.ItebisDataGridViewTextBoxColumn.DataPropertyName = "Itebis"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.ItebisDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ItebisDataGridViewTextBoxColumn.HeaderText = "Itebis"
        Me.ItebisDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItebisDataGridViewTextBoxColumn.Name = "ItebisDataGridViewTextBoxColumn"
        Me.ItebisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagadoRD
        '
        Me.PagadoRD.DataPropertyName = "PagadoRD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.PagadoRD.DefaultCellStyle = DataGridViewCellStyle6
        Me.PagadoRD.HeaderText = "Pagado"
        Me.PagadoRD.MinimumWidth = 6
        Me.PagadoRD.Name = "PagadoRD"
        Me.PagadoRD.ReadOnly = True
        '
        'CostoComprasProyectoBindingSource
        '
        Me.CostoComprasProyectoBindingSource.DataMember = "CostoComprasProyecto"
        Me.CostoComprasProyectoBindingSource.DataSource = Me.DsCompras
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraMaterialesDetalleDataGridView
        '
        Me.CompraMaterialesDetalleDataGridView.AllowUserToAddRows = False
        Me.CompraMaterialesDetalleDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompraMaterialesDetalleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.CompraMaterialesDetalleDataGridView.AutoGenerateColumns = False
        Me.CompraMaterialesDetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CompraMaterialesDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CompraMaterialesDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CompraMaterialesDetalleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CompraMaterialesDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.CompraMaterialesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompraMaterialesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Compra, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.CompraMaterialesDetalleDataGridView.DataSource = Me.CompraMaterialesDetalleBindingSource
        Me.CompraMaterialesDetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompraMaterialesDetalleDataGridView.EnableHeadersVisualStyles = False
        Me.CompraMaterialesDetalleDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CompraMaterialesDetalleDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompraMaterialesDetalleDataGridView.MultiSelect = False
        Me.CompraMaterialesDetalleDataGridView.Name = "CompraMaterialesDetalleDataGridView"
        Me.CompraMaterialesDetalleDataGridView.ReadOnly = True
        Me.CompraMaterialesDetalleDataGridView.RowHeadersVisible = False
        Me.CompraMaterialesDetalleDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.CompraMaterialesDetalleDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.CompraMaterialesDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompraMaterialesDetalleDataGridView.Size = New System.Drawing.Size(828, 259)
        Me.CompraMaterialesDetalleDataGridView.TabIndex = 0
        '
        'Id_Compra
        '
        Me.Id_Compra.DataPropertyName = "Id_Compra"
        Me.Id_Compra.HeaderText = "Id_Compra"
        Me.Id_Compra.MinimumWidth = 8
        Me.Id_Compra.Name = "Id_Compra"
        Me.Id_Compra.ReadOnly = True
        Me.Id_Compra.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "DescripcionProveedor"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cantidad"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PrecioRD"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn24.HeaderText = "PrecioRD"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "ItebisRD"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn25.HeaderText = "ItebisRD"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TotalRD"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle13.Format = "n2"
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn26.HeaderText = "TotalRD"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'CompraMaterialesDetalleBindingSource
        '
        Me.CompraMaterialesDetalleBindingSource.DataMember = "CompraMaterialesDetalle"
        Me.CompraMaterialesDetalleBindingSource.DataSource = Me.DsCompras
        '
        'splitFacturas
        '
        Me.splitFacturas.Location = New System.Drawing.Point(3, 59)
        Me.splitFacturas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitFacturas.Name = "splitFacturas"
        '
        'splitFacturas.Panel1
        '
        Me.splitFacturas.Panel1.Controls.Add(Me.FacturaMontajeDataGridView)
        '
        'splitFacturas.Panel2
        '
        Me.splitFacturas.Panel2.Controls.Add(Me.FacturaMontajeDetalleDataGridView)
        Me.splitFacturas.Size = New System.Drawing.Size(1595, 259)
        Me.splitFacturas.SplitterDistance = 760
        Me.splitFacturas.SplitterWidth = 7
        Me.splitFacturas.TabIndex = 1
        '
        'FacturaMontajeDataGridView
        '
        Me.FacturaMontajeDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FacturaMontajeDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.FacturaMontajeDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FacturaMontajeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FacturaMontajeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FacturaMontajeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FacturaMontajeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.FacturaMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SubTotal, Me.Itebis, Me.Total, Me.Pagado, Me.Pendiente, Me.TotalIrs})
        Me.FacturaMontajeDataGridView.DataSource = Me.FacturaMontajeBindingSource
        Me.FacturaMontajeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturaMontajeDataGridView.EnableHeadersVisualStyles = False
        Me.FacturaMontajeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.FacturaMontajeDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FacturaMontajeDataGridView.MultiSelect = False
        Me.FacturaMontajeDataGridView.Name = "FacturaMontajeDataGridView"
        Me.FacturaMontajeDataGridView.ReadOnly = True
        Me.FacturaMontajeDataGridView.RowHeadersVisible = False
        Me.FacturaMontajeDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        Me.FacturaMontajeDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle22
        Me.FacturaMontajeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FacturaMontajeDataGridView.Size = New System.Drawing.Size(760, 259)
        Me.FacturaMontajeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotalIrs"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle17.Format = "n2"
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle17
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'Itebis
        '
        Me.Itebis.DataPropertyName = "Itebis"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle18.Format = "n2"
        Me.Itebis.DefaultCellStyle = DataGridViewCellStyle18
        Me.Itebis.HeaderText = "Itebis"
        Me.Itebis.MinimumWidth = 6
        Me.Itebis.Name = "Itebis"
        Me.Itebis.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "TotalConIrs"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle19.Format = "n2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle19
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Pagado"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle20.Format = "n2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle20
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        '
        'Pendiente
        '
        Me.Pendiente.DataPropertyName = "PendienteInstalador"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle21.Format = "n2"
        DataGridViewCellStyle21.NullValue = "0"
        Me.Pendiente.DefaultCellStyle = DataGridViewCellStyle21
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.MinimumWidth = 6
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.ReadOnly = True
        '
        'TotalIrs
        '
        Me.TotalIrs.DataPropertyName = "TotalIrs"
        Me.TotalIrs.HeaderText = "TotalIrs"
        Me.TotalIrs.MinimumWidth = 8
        Me.TotalIrs.Name = "TotalIrs"
        Me.TotalIrs.ReadOnly = True
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FacturaMontaje"
        Me.FacturaMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'DsPagosMontaje
        '
        Me.DsPagosMontaje.DataSetName = "DsPagosMontaje"
        Me.DsPagosMontaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaMontajeDetalleDataGridView
        '
        Me.FacturaMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FacturaMontajeDetalleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle23
        Me.FacturaMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FacturaMontajeDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FacturaMontajeDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.FacturaMontajeDetalleDataGridView.DataSource = Me.FacturaMontajeDetalleBindingSource
        Me.FacturaMontajeDetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturaMontajeDetalleDataGridView.EnableHeadersVisualStyles = False
        Me.FacturaMontajeDetalleDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.FacturaMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FacturaMontajeDetalleDataGridView.MultiSelect = False
        Me.FacturaMontajeDetalleDataGridView.Name = "FacturaMontajeDetalleDataGridView"
        Me.FacturaMontajeDetalleDataGridView.ReadOnly = True
        Me.FacturaMontajeDetalleDataGridView.RowHeadersVisible = False
        Me.FacturaMontajeDetalleDataGridView.RowHeadersWidth = 51
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
        Me.FacturaMontajeDetalleDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.FacturaMontajeDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FacturaMontajeDetalleDataGridView.Size = New System.Drawing.Size(828, 259)
        Me.FacturaMontajeDetalleDataGridView.TabIndex = 0
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 8
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cantidad"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle25.Format = "n2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Precio"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle26.Format = "n2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn16.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle27.Format = "n2"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn17.HeaderText = "TotalPartida"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'FacturaMontajeDetalleBindingSource
        '
        Me.FacturaMontajeDetalleBindingSource.DataMember = "FacturaMontajeDetalle"
        Me.FacturaMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHeader.Location = New System.Drawing.Point(3, 4)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.PanelHeader.Size = New System.Drawing.Size(1595, 47)
        Me.PanelHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gastos del Proyecto"
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Controls.Add(Me.splitFacturas, 0, 1)
        Me.tlpMain.Controls.Add(Me.PanelHeader, 0, 0)
        Me.tlpMain.Controls.Add(Me.splitCompras, 0, 2)
        Me.tlpMain.Controls.Add(Me.PanelTotales, 0, 3)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 5
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 408.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1601, 1031)
        Me.tlpMain.TabIndex = 0
        '
        'FacturaMontajeTableAdapter
        '
        Me.FacturaMontajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.EmpresasContratadasMontajeTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaMontajeDetalleTableAdapter = Me.FacturaMontajeDetalleTableAdapter
        Me.TableAdapterManager1.FacturaMontajeTableAdapter = Me.FacturaMontajeTableAdapter
        Me.TableAdapterManager1.PagoMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.PagoMontajeTableAdapter = Nothing
        Me.TableAdapterManager1.PresupuestoDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager1.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaMontajeDetalleTableAdapter
        '
        Me.FacturaMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'ResumenComprasProyectoBindingSource
        '
        Me.ResumenComprasProyectoBindingSource.DataMember = "ResumenComprasProyecto"
        Me.ResumenComprasProyectoBindingSource.DataSource = Me.DsCompras
        '
        'ResumenComprasProyectoTableAdapter
        '
        Me.ResumenComprasProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraMaterialesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CostoComprasProyectoTableAdapter
        '
        Me.CostoComprasProyectoTableAdapter.ClearBeforeFill = True
        '
        'CompraMaterialesDetalleTableAdapter
        '
        Me.CompraMaterialesDetalleTableAdapter.ClearBeforeFill = True
        '
        'FrmGastosProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1601, 1031)
        Me.Controls.Add(Me.tlpMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmGastosProyecto"
        Me.Text = "Gastos del Proyecto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTotales.ResumeLayout(False)
        Me.tlpTotalesMain.ResumeLayout(False)
        Me.tlpTotales.ResumeLayout(False)
        Me.tlpTotales.PerformLayout()
        Me.PanelTotalesDerecha.ResumeLayout(False)
        Me.tlpResumenAcciones.ResumeLayout(False)
        Me.PanelResumen.ResumeLayout(False)
        Me.PanelResumen.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.splitCompras.Panel1.ResumeLayout(False)
        Me.splitCompras.Panel2.ResumeLayout(False)
        CType(Me.splitCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitCompras.ResumeLayout(False)
        CType(Me.CostoComprasProyectoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostoComprasProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitFacturas.Panel1.ResumeLayout(False)
        Me.splitFacturas.Panel2.ResumeLayout(False)
        CType(Me.splitFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitFacturas.ResumeLayout(False)
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.tlpMain.ResumeLayout(False)
        CType(Me.ResumenComprasProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IdproyectoPresupuestosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdCompraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItebisDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PagadoRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDetallecompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCompraDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdMaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItebisUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItebisRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioEUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItebisEuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalEUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItebisDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TSubtotalRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TItbisRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TTotalRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TSubtotaUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TItbisUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TTotalusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents tlpTotales As TableLayoutPanel
    Friend WithEvents tlpTotalesMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelTotalesDerecha As System.Windows.Forms.Panel

    Friend WithEvents lblSubTotalMontaje As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblItebisMontaje As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTotalMontaje As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblPagadoMontaje As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents lblPendienteMontaje As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents lblSubTotalCompras As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblItebisCompras As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblTotalCompras As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblPagadoCompras As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents splitCompras As SplitContainer
    Friend WithEvents CostoComprasProyectoDataGridView As DataGridView
    Friend WithEvents IdproyectoPresupuestosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItebisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagadoRD As DataGridViewTextBoxColumn
    Friend WithEvents CompraMaterialesDetalleDataGridView As DataGridView
    Friend WithEvents splitFacturas As SplitContainer
    Friend WithEvents FacturaMontajeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Itebis As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
    Friend WithEvents TotalIrs As DataGridViewTextBoxColumn
    Friend WithEvents FacturaMontajeDetalleDataGridView As DataGridView
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpResumenAcciones As TableLayoutPanel
    Friend WithEvents PanelResumen As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTasaCambio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblGastosUSD As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSubTotalProyecto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBeneficio As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPorcentajeBeneficio As Label
    Friend WithEvents Id_Compra As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
End Class
