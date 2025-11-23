<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstudioPrecios
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
        Dim IdDetalle_PresupuestoLabel As System.Windows.Forms.Label
        Dim ArticuloLabel As System.Windows.Forms.Label
        Dim DescuentoLabel As System.Windows.Forms.Label
        Dim Precio_AjustadoLabel As System.Windows.Forms.Label
        Dim CostoMaderaLabel As System.Windows.Forms.Label
        Dim CostoPinturaLabel As System.Windows.Forms.Label
        Dim PrecioHoraLabel As System.Windows.Forms.Label
        Dim TrabajoTallerLabel As System.Windows.Forms.Label
        Dim TrabajoPiinturaLabel As System.Windows.Forms.Label
        Dim CostoFereteriaLabel As System.Windows.Forms.Label
        Dim SubTotalCostoDirectoLabel As System.Windows.Forms.Label
        Dim OtrosCostosLabel As System.Windows.Forms.Label
        Dim TotalCostoDirectoLabel As System.Windows.Forms.Label
        Dim CostoIdirectoLabel As System.Windows.Forms.Label
        Dim TransporteEmbalajeLabel As System.Windows.Forms.Label
        Dim CostoHerrajesLabel As System.Windows.Forms.Label
        Dim CostoMontajeLabel As System.Windows.Forms.Label
        Dim SubTotalCostoLabel As System.Windows.Forms.Label
        Dim BeneficioLabel As System.Windows.Forms.Label
        Dim ImprevistosLabel As System.Windows.Forms.Label
        Dim SubtotalVentaLabel As System.Windows.Forms.Label
        Dim PrecioVentaLabel As System.Windows.Forms.Label
        Dim TotalHorasLabel As System.Windows.Forms.Label
        Dim CostoTrabajoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ItbisIncluidoLabel As System.Windows.Forms.Label
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
        Me.IdDetalle_PresupuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.ArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.Precio_AjustadoTextBox = New System.Windows.Forms.TextBox()
        Me.CostoMaderaTextBox = New System.Windows.Forms.TextBox()
        Me.CostoPinturaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioHoraTextBox = New System.Windows.Forms.TextBox()
        Me.TrabajoPiinturaTextBox = New System.Windows.Forms.TextBox()
        Me.CostoFereteriaTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalCostoDirectoTextBox = New System.Windows.Forms.TextBox()
        Me.OtrosCostosTextBox = New System.Windows.Forms.TextBox()
        Me.CostoOtrosCostosTextBox = New System.Windows.Forms.TextBox()
        Me.CostoIndirectoTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostoIdirectoTextBox = New System.Windows.Forms.TextBox()
        Me.TransporteEmbalajeTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTransporteEmbalajeTextBox = New System.Windows.Forms.TextBox()
        Me.CostoHerrajesTextBox = New System.Windows.Forms.TextBox()
        Me.MontajeTextBox = New System.Windows.Forms.TextBox()
        Me.CostoMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalCostoTextBox = New System.Windows.Forms.TextBox()
        Me.BeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.TotalBeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.ImprevistosTextBox = New System.Windows.Forms.TextBox()
        Me.TotalImprevistosTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalVentaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioVentaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalHorasTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTrabajoTextBox = New System.Windows.Forms.TextBox()
        Me.TotalcostoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnGenerarPrecio = New System.Windows.Forms.Button()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.ConsumoPinturaArticuloDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinturaCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinturaPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoPinturaArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCosumoPinturaArticulo = New ModuloGestion.DsCosumoPinturaArticulo()
        Me.PinturaComponentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaComponentes = New ModuloGestion.DsPinturaComponentes()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra3 = New ModuloGestion.DsMedidasCompra()
        Me.PrecioGeneradoTextBox = New System.Windows.Forms.TextBox()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.DsConsumoMaterialArticulo = New ModuloGestion.DsConsumoMaterialArticulo()
        Me.ConsumoMaterialArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoMaterialArticulosTableAdapter = New ModuloGestion.DsConsumoMaterialArticuloTableAdapters.ConsumoMaterialArticulosTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsConsumoMaterialArticuloTableAdapters.TableAdapterManager()
        Me.ConsumoMaterialArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.MaterialId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialTotalCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinturaComponentesTableAdapter = New ModuloGestion.DsPinturaComponentesTableAdapters.PinturaComponentesTableAdapter()
        Me.BtnAgregarPresupuesto = New System.Windows.Forms.Button()
        Me.TotalPartidaTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.DsPresupuestoDetalleferreteria = New ModuloGestion.DsPresupuestoDetalleferreteria()
        Me.PresupuestoDetalleFerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleFerreteriaTableAdapter = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager()
        Me.DsFerreteria = New ModuloGestion.DsFerreteria()
        Me.FerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FerreteriaTableAdapter = New ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter()
        Me.PresupuestoDetalleHerrajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Descripcion_Elemento_Herrajes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadHerrajesDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompraHerrajes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostodetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoHerrajesArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsumoHerrajesArticulo = New ModuloGestion.DsConsumoHerrajesArticulo()
        Me.HerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerrajes = New ModuloGestion.DsHerrajes()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalleHerrajes = New ModuloGestion.DsPresupuestoDetalleHerrajes()
        Me.HerrajesTableAdapter = New ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter()
        Me.MedidasCompraTableAdapter3 = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager()
        Me.ConsumoPinturaArticuloTableAdapter = New ModuloGestion.DsCosumoPinturaArticuloTableAdapters.ConsumoPinturaArticuloTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsCosumoPinturaArticuloTableAdapters.TableAdapterManager()
        Me.ConsumoHerrajesArticuloTableAdapter = New ModuloGestion.DsConsumoHerrajesArticuloTableAdapters.ConsumoHerrajesArticuloTableAdapter()
        Me.ConsumoFerreteriaArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionMedidaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoFerreteriaArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsumoFerreteriaArticulos = New ModuloGestion.DsConsumoFerreteriaArticulos()
        Me.ConsumoFerreteriaArticulosTableAdapter = New ModuloGestion.DsConsumoFerreteriaArticulosTableAdapters.ConsumoFerreteriaArticulosTableAdapter()
        Me.TableAdapterManager7 = New ModuloGestion.DsConsumoFerreteriaArticulosTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descripcion_articuloTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_AjustadoRD_TextBox = New System.Windows.Forms.TextBox()
        Me.TotalPartidaRD_TextBox = New System.Windows.Forms.TextBox()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ItbisIncluidoTextBox = New System.Windows.Forms.TextBox()
        Me.InlItebisCheckBox = New System.Windows.Forms.CheckBox()
        Me.DescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.TrabajoTallerTextBox = New System.Windows.Forms.TextBox()
        IdDetalle_PresupuestoLabel = New System.Windows.Forms.Label()
        ArticuloLabel = New System.Windows.Forms.Label()
        DescuentoLabel = New System.Windows.Forms.Label()
        Precio_AjustadoLabel = New System.Windows.Forms.Label()
        CostoMaderaLabel = New System.Windows.Forms.Label()
        CostoPinturaLabel = New System.Windows.Forms.Label()
        PrecioHoraLabel = New System.Windows.Forms.Label()
        TrabajoTallerLabel = New System.Windows.Forms.Label()
        TrabajoPiinturaLabel = New System.Windows.Forms.Label()
        CostoFereteriaLabel = New System.Windows.Forms.Label()
        SubTotalCostoDirectoLabel = New System.Windows.Forms.Label()
        OtrosCostosLabel = New System.Windows.Forms.Label()
        TotalCostoDirectoLabel = New System.Windows.Forms.Label()
        CostoIdirectoLabel = New System.Windows.Forms.Label()
        TransporteEmbalajeLabel = New System.Windows.Forms.Label()
        CostoHerrajesLabel = New System.Windows.Forms.Label()
        CostoMontajeLabel = New System.Windows.Forms.Label()
        SubTotalCostoLabel = New System.Windows.Forms.Label()
        BeneficioLabel = New System.Windows.Forms.Label()
        ImprevistosLabel = New System.Windows.Forms.Label()
        SubtotalVentaLabel = New System.Windows.Forms.Label()
        PrecioVentaLabel = New System.Windows.Forms.Label()
        TotalHorasLabel = New System.Windows.Forms.Label()
        CostoTrabajoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ItbisIncluidoLabel = New System.Windows.Forms.Label()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoPinturaArticuloDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoPinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCosumoPinturaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsumoMaterialArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoMaterialArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoMaterialArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFerreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoHerrajesArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsumoHerrajesArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoFerreteriaArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoFerreteriaArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsumoFerreteriaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdDetalle_PresupuestoLabel
        '
        IdDetalle_PresupuestoLabel.AutoSize = True
        IdDetalle_PresupuestoLabel.Location = New System.Drawing.Point(11, 38)
        IdDetalle_PresupuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdDetalle_PresupuestoLabel.Name = "IdDetalle_PresupuestoLabel"
        IdDetalle_PresupuestoLabel.Size = New System.Drawing.Size(155, 17)
        IdDetalle_PresupuestoLabel.TabIndex = 1
        IdDetalle_PresupuestoLabel.Text = "Id Detalle Presupuesto:"
        '
        'ArticuloLabel
        '
        ArticuloLabel.AutoSize = True
        ArticuloLabel.Location = New System.Drawing.Point(44, 69)
        ArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ArticuloLabel.Name = "ArticuloLabel"
        ArticuloLabel.Size = New System.Drawing.Size(74, 17)
        ArticuloLabel.TabIndex = 3
        ArticuloLabel.Text = "Id Articulo:"
        '
        'DescuentoLabel
        '
        DescuentoLabel.AutoSize = True
        DescuentoLabel.Location = New System.Drawing.Point(1172, 612)
        DescuentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescuentoLabel.Name = "DescuentoLabel"
        DescuentoLabel.Size = New System.Drawing.Size(80, 17)
        DescuentoLabel.TabIndex = 15
        DescuentoLabel.Text = "Descuento:"
        '
        'Precio_AjustadoLabel
        '
        Precio_AjustadoLabel.AutoSize = True
        Precio_AjustadoLabel.Location = New System.Drawing.Point(1247, 713)
        Precio_AjustadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Precio_AjustadoLabel.Name = "Precio_AjustadoLabel"
        Precio_AjustadoLabel.Size = New System.Drawing.Size(129, 17)
        Precio_AjustadoLabel.TabIndex = 17
        Precio_AjustadoLabel.Text = "Precio Presentado:"
        '
        'CostoMaderaLabel
        '
        CostoMaderaLabel.AutoSize = True
        CostoMaderaLabel.Location = New System.Drawing.Point(1265, 97)
        CostoMaderaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoMaderaLabel.Name = "CostoMaderaLabel"
        CostoMaderaLabel.Size = New System.Drawing.Size(100, 17)
        CostoMaderaLabel.TabIndex = 25
        CostoMaderaLabel.Text = "Costo Madera:"
        '
        'CostoPinturaLabel
        '
        CostoPinturaLabel.AutoSize = True
        CostoPinturaLabel.Location = New System.Drawing.Point(1269, 129)
        CostoPinturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoPinturaLabel.Name = "CostoPinturaLabel"
        CostoPinturaLabel.Size = New System.Drawing.Size(97, 17)
        CostoPinturaLabel.TabIndex = 27
        CostoPinturaLabel.Text = "Costo Pintura:"
        '
        'PrecioHoraLabel
        '
        PrecioHoraLabel.AutoSize = True
        PrecioHoraLabel.Location = New System.Drawing.Point(1052, 10)
        PrecioHoraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioHoraLabel.Name = "PrecioHoraLabel"
        PrecioHoraLabel.Size = New System.Drawing.Size(87, 17)
        PrecioHoraLabel.TabIndex = 29
        PrecioHoraLabel.Text = "Precio Hora:"
        '
        'TrabajoTallerLabel
        '
        TrabajoTallerLabel.AutoSize = True
        TrabajoTallerLabel.Location = New System.Drawing.Point(1157, 10)
        TrabajoTallerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TrabajoTallerLabel.Name = "TrabajoTallerLabel"
        TrabajoTallerLabel.Size = New System.Drawing.Size(86, 17)
        TrabajoTallerLabel.TabIndex = 31
        TrabajoTallerLabel.Text = "HorasTaller:"
        '
        'TrabajoPiinturaLabel
        '
        TrabajoPiinturaLabel.AutoSize = True
        TrabajoPiinturaLabel.Location = New System.Drawing.Point(1268, 10)
        TrabajoPiinturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TrabajoPiinturaLabel.Name = "TrabajoPiinturaLabel"
        TrabajoPiinturaLabel.Size = New System.Drawing.Size(95, 17)
        TrabajoPiinturaLabel.TabIndex = 33
        TrabajoPiinturaLabel.Text = "Horas Pintura"
        '
        'CostoFereteriaLabel
        '
        CostoFereteriaLabel.AutoSize = True
        CostoFereteriaLabel.Location = New System.Drawing.Point(1259, 161)
        CostoFereteriaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoFereteriaLabel.Name = "CostoFereteriaLabel"
        CostoFereteriaLabel.Size = New System.Drawing.Size(109, 17)
        CostoFereteriaLabel.TabIndex = 35
        CostoFereteriaLabel.Text = "Costo Fereteria:"
        '
        'SubTotalCostoDirectoLabel
        '
        SubTotalCostoDirectoLabel.AutoSize = True
        SubTotalCostoDirectoLabel.Location = New System.Drawing.Point(1272, 230)
        SubTotalCostoDirectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubTotalCostoDirectoLabel.Name = "SubTotalCostoDirectoLabel"
        SubTotalCostoDirectoLabel.Size = New System.Drawing.Size(93, 17)
        SubTotalCostoDirectoLabel.TabIndex = 37
        SubTotalCostoDirectoLabel.Text = "Costo Directo"
        '
        'OtrosCostosLabel
        '
        OtrosCostosLabel.AutoSize = True
        OtrosCostosLabel.Location = New System.Drawing.Point(1165, 194)
        OtrosCostosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OtrosCostosLabel.Name = "OtrosCostosLabel"
        OtrosCostosLabel.Size = New System.Drawing.Size(94, 17)
        OtrosCostosLabel.TabIndex = 39
        OtrosCostosLabel.Text = "Otros Costos:"
        '
        'TotalCostoDirectoLabel
        '
        TotalCostoDirectoLabel.AutoSize = True
        TotalCostoDirectoLabel.Location = New System.Drawing.Point(1265, 289)
        TotalCostoDirectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalCostoDirectoLabel.Name = "TotalCostoDirectoLabel"
        TotalCostoDirectoLabel.Size = New System.Drawing.Size(95, 17)
        TotalCostoDirectoLabel.TabIndex = 43
        TotalCostoDirectoLabel.Text = "Costo Fabrica"
        '
        'CostoIdirectoLabel
        '
        CostoIdirectoLabel.AutoSize = True
        CostoIdirectoLabel.Location = New System.Drawing.Point(1159, 257)
        CostoIdirectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoIdirectoLabel.Name = "CostoIdirectoLabel"
        CostoIdirectoLabel.Size = New System.Drawing.Size(106, 17)
        CostoIdirectoLabel.TabIndex = 45
        CostoIdirectoLabel.Text = "Costo Indirecto:"
        '
        'TransporteEmbalajeLabel
        '
        TransporteEmbalajeLabel.AutoSize = True
        TransporteEmbalajeLabel.Location = New System.Drawing.Point(1116, 321)
        TransporteEmbalajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TransporteEmbalajeLabel.Name = "TransporteEmbalajeLabel"
        TransporteEmbalajeLabel.Size = New System.Drawing.Size(144, 17)
        TransporteEmbalajeLabel.TabIndex = 49
        TransporteEmbalajeLabel.Text = "Transporte Embalaje:"
        '
        'CostoHerrajesLabel
        '
        CostoHerrajesLabel.AutoSize = True
        CostoHerrajesLabel.Location = New System.Drawing.Point(1257, 353)
        CostoHerrajesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoHerrajesLabel.Name = "CostoHerrajesLabel"
        CostoHerrajesLabel.Size = New System.Drawing.Size(106, 17)
        CostoHerrajesLabel.TabIndex = 53
        CostoHerrajesLabel.Text = "Costo Herrajes:"
        '
        'CostoMontajeLabel
        '
        CostoMontajeLabel.AutoSize = True
        CostoMontajeLabel.Location = New System.Drawing.Point(1155, 385)
        CostoMontajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoMontajeLabel.Name = "CostoMontajeLabel"
        CostoMontajeLabel.Size = New System.Drawing.Size(102, 17)
        CostoMontajeLabel.TabIndex = 57
        CostoMontajeLabel.Text = "Costo Montaje:"
        '
        'SubTotalCostoLabel
        '
        SubTotalCostoLabel.AutoSize = True
        SubTotalCostoLabel.Location = New System.Drawing.Point(1277, 417)
        SubTotalCostoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubTotalCostoLabel.Name = "SubTotalCostoLabel"
        SubTotalCostoLabel.Size = New System.Drawing.Size(84, 17)
        SubTotalCostoLabel.TabIndex = 59
        SubTotalCostoLabel.Text = "Total Costo:"
        '
        'BeneficioLabel
        '
        BeneficioLabel.AutoSize = True
        BeneficioLabel.Location = New System.Drawing.Point(1165, 454)
        BeneficioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BeneficioLabel.Name = "BeneficioLabel"
        BeneficioLabel.Size = New System.Drawing.Size(70, 17)
        BeneficioLabel.TabIndex = 61
        BeneficioLabel.Text = "Beneficio:"
        '
        'ImprevistosLabel
        '
        ImprevistosLabel.AutoSize = True
        ImprevistosLabel.Location = New System.Drawing.Point(1171, 548)
        ImprevistosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImprevistosLabel.Name = "ImprevistosLabel"
        ImprevistosLabel.Size = New System.Drawing.Size(83, 17)
        ImprevistosLabel.TabIndex = 65
        ImprevistosLabel.Text = "Imprevistos:"
        '
        'SubtotalVentaLabel
        '
        SubtotalVentaLabel.AutoSize = True
        SubtotalVentaLabel.Location = New System.Drawing.Point(1256, 516)
        SubtotalVentaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubtotalVentaLabel.Name = "SubtotalVentaLabel"
        SubtotalVentaLabel.Size = New System.Drawing.Size(105, 17)
        SubtotalVentaLabel.TabIndex = 69
        SubtotalVentaLabel.Text = "Subtotal Venta:"
        '
        'PrecioVentaLabel
        '
        PrecioVentaLabel.AutoSize = True
        PrecioVentaLabel.Location = New System.Drawing.Point(1272, 642)
        PrecioVentaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioVentaLabel.Name = "PrecioVentaLabel"
        PrecioVentaLabel.Size = New System.Drawing.Size(93, 17)
        PrecioVentaLabel.TabIndex = 73
        PrecioVentaLabel.Text = "Precio Venta:"
        '
        'TotalHorasLabel
        '
        TotalHorasLabel.AutoSize = True
        TotalHorasLabel.Location = New System.Drawing.Point(1371, 10)
        TotalHorasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalHorasLabel.Name = "TotalHorasLabel"
        TotalHorasLabel.Size = New System.Drawing.Size(86, 17)
        TotalHorasLabel.TabIndex = 75
        TotalHorasLabel.Text = "Total Horas:"
        '
        'CostoTrabajoLabel
        '
        CostoTrabajoLabel.AutoSize = True
        CostoTrabajoLabel.Location = New System.Drawing.Point(1265, 70)
        CostoTrabajoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CostoTrabajoLabel.Name = "CostoTrabajoLabel"
        CostoTrabajoLabel.Size = New System.Drawing.Size(101, 17)
        CostoTrabajoLabel.TabIndex = 77
        CostoTrabajoLabel.Text = "Costo Trabajo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(1251, 580)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(116, 17)
        Label1.TabIndex = 83
        Label1.Text = "Precio Generado"
        '
        'ItbisIncluidoLabel
        '
        ItbisIncluidoLabel.AutoSize = True
        ItbisIncluidoLabel.Location = New System.Drawing.Point(1177, 484)
        ItbisIncluidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ItbisIncluidoLabel.Name = "ItbisIncluidoLabel"
        ItbisIncluidoLabel.Size = New System.Drawing.Size(89, 17)
        ItbisIncluidoLabel.TabIndex = 96
        ItbisIncluidoLabel.Text = "Itbis Incluido:"
        '
        'IdDetalle_PresupuestoTextBox
        '
        Me.IdDetalle_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "IdDetalle_Presupuesto", True))
        Me.IdDetalle_PresupuestoTextBox.Location = New System.Drawing.Point(175, 34)
        Me.IdDetalle_PresupuestoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdDetalle_PresupuestoTextBox.Name = "IdDetalle_PresupuestoTextBox"
        Me.IdDetalle_PresupuestoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IdDetalle_PresupuestoTextBox.TabIndex = 2
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsPresupuestoDetalle
        '
        'DsPresupuestoDetalle
        '
        Me.DsPresupuestoDetalle.DataSetName = "DsPresupuestoDetalle"
        Me.DsPresupuestoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticuloTextBox
        '
        Me.ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Articulo", True))
        Me.ArticuloTextBox.Location = New System.Drawing.Point(175, 65)
        Me.ArticuloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ArticuloTextBox.Name = "ArticuloTextBox"
        Me.ArticuloTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ArticuloTextBox.TabIndex = 4
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "DsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsArticulos
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
        'Precio_AjustadoTextBox
        '
        Me.Precio_AjustadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Precio_Ajustado", True))
        Me.Precio_AjustadoTextBox.Location = New System.Drawing.Point(1375, 709)
        Me.Precio_AjustadoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Precio_AjustadoTextBox.Name = "Precio_AjustadoTextBox"
        Me.Precio_AjustadoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.Precio_AjustadoTextBox.TabIndex = 18
        Me.Precio_AjustadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoMaderaTextBox
        '
        Me.CostoMaderaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoMadera", True))
        Me.CostoMaderaTextBox.Enabled = False
        Me.CostoMaderaTextBox.Location = New System.Drawing.Point(1375, 94)
        Me.CostoMaderaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoMaderaTextBox.Name = "CostoMaderaTextBox"
        Me.CostoMaderaTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoMaderaTextBox.TabIndex = 26
        Me.CostoMaderaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoPinturaTextBox
        '
        Me.CostoPinturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoPintura", True))
        Me.CostoPinturaTextBox.Enabled = False
        Me.CostoPinturaTextBox.Location = New System.Drawing.Point(1375, 126)
        Me.CostoPinturaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoPinturaTextBox.Name = "CostoPinturaTextBox"
        Me.CostoPinturaTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoPinturaTextBox.TabIndex = 28
        Me.CostoPinturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioHoraTextBox
        '
        Me.PrecioHoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "PrecioHora", True))
        Me.PrecioHoraTextBox.Enabled = False
        Me.PrecioHoraTextBox.Location = New System.Drawing.Point(1049, 30)
        Me.PrecioHoraTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecioHoraTextBox.Name = "PrecioHoraTextBox"
        Me.PrecioHoraTextBox.Size = New System.Drawing.Size(99, 22)
        Me.PrecioHoraTextBox.TabIndex = 30
        Me.PrecioHoraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TrabajoPiinturaTextBox
        '
        Me.TrabajoPiinturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TrabajoPiintura", True))
        Me.TrabajoPiinturaTextBox.Enabled = False
        Me.TrabajoPiinturaTextBox.Location = New System.Drawing.Point(1267, 30)
        Me.TrabajoPiinturaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TrabajoPiinturaTextBox.Name = "TrabajoPiinturaTextBox"
        Me.TrabajoPiinturaTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TrabajoPiinturaTextBox.TabIndex = 34
        Me.TrabajoPiinturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoFereteriaTextBox
        '
        Me.CostoFereteriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoFereteria", True))
        Me.CostoFereteriaTextBox.Enabled = False
        Me.CostoFereteriaTextBox.Location = New System.Drawing.Point(1375, 158)
        Me.CostoFereteriaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoFereteriaTextBox.Name = "CostoFereteriaTextBox"
        Me.CostoFereteriaTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoFereteriaTextBox.TabIndex = 36
        Me.CostoFereteriaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalCostoDirectoTextBox
        '
        Me.SubTotalCostoDirectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "SubTotalCostoDirecto", True))
        Me.SubTotalCostoDirectoTextBox.Enabled = False
        Me.SubTotalCostoDirectoTextBox.Location = New System.Drawing.Point(1375, 222)
        Me.SubTotalCostoDirectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalCostoDirectoTextBox.Name = "SubTotalCostoDirectoTextBox"
        Me.SubTotalCostoDirectoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.SubTotalCostoDirectoTextBox.TabIndex = 38
        Me.SubTotalCostoDirectoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OtrosCostosTextBox
        '
        Me.OtrosCostosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "OtrosCostos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "## %"))
        Me.OtrosCostosTextBox.Location = New System.Drawing.Point(1267, 191)
        Me.OtrosCostosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OtrosCostosTextBox.Name = "OtrosCostosTextBox"
        Me.OtrosCostosTextBox.Size = New System.Drawing.Size(99, 22)
        Me.OtrosCostosTextBox.TabIndex = 40
        Me.OtrosCostosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoOtrosCostosTextBox
        '
        Me.CostoOtrosCostosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoOtrosCostos", True))
        Me.CostoOtrosCostosTextBox.Enabled = False
        Me.CostoOtrosCostosTextBox.Location = New System.Drawing.Point(1375, 190)
        Me.CostoOtrosCostosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoOtrosCostosTextBox.Name = "CostoOtrosCostosTextBox"
        Me.CostoOtrosCostosTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoOtrosCostosTextBox.TabIndex = 42
        Me.CostoOtrosCostosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoIndirectoTextBox
        '
        Me.CostoIndirectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoIdirecto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.CostoIndirectoTextBox.Enabled = False
        Me.CostoIndirectoTextBox.Location = New System.Drawing.Point(1267, 254)
        Me.CostoIndirectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoIndirectoTextBox.Name = "CostoIndirectoTextBox"
        Me.CostoIndirectoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoIndirectoTextBox.TabIndex = 46
        Me.CostoIndirectoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalCostoIdirectoTextBox
        '
        Me.TotalCostoIdirectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalCostoIdirecto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TotalCostoIdirectoTextBox.Enabled = False
        Me.TotalCostoIdirectoTextBox.Location = New System.Drawing.Point(1375, 254)
        Me.TotalCostoIdirectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCostoIdirectoTextBox.Name = "TotalCostoIdirectoTextBox"
        Me.TotalCostoIdirectoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TotalCostoIdirectoTextBox.TabIndex = 48
        Me.TotalCostoIdirectoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TransporteEmbalajeTextBox
        '
        Me.TransporteEmbalajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TransporteEmbalaje", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "## %"))
        Me.TransporteEmbalajeTextBox.Location = New System.Drawing.Point(1267, 318)
        Me.TransporteEmbalajeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TransporteEmbalajeTextBox.Name = "TransporteEmbalajeTextBox"
        Me.TransporteEmbalajeTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TransporteEmbalajeTextBox.TabIndex = 50
        Me.TransporteEmbalajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoTransporteEmbalajeTextBox
        '
        Me.CostoTransporteEmbalajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoTransporteEmbalaje", True))
        Me.CostoTransporteEmbalajeTextBox.Location = New System.Drawing.Point(1375, 318)
        Me.CostoTransporteEmbalajeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoTransporteEmbalajeTextBox.Name = "CostoTransporteEmbalajeTextBox"
        Me.CostoTransporteEmbalajeTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoTransporteEmbalajeTextBox.TabIndex = 52
        Me.CostoTransporteEmbalajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoHerrajesTextBox
        '
        Me.CostoHerrajesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoHerrajes", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.CostoHerrajesTextBox.Enabled = False
        Me.CostoHerrajesTextBox.Location = New System.Drawing.Point(1375, 350)
        Me.CostoHerrajesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoHerrajesTextBox.Name = "CostoHerrajesTextBox"
        Me.CostoHerrajesTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoHerrajesTextBox.TabIndex = 54
        Me.CostoHerrajesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MontajeTextBox
        '
        Me.MontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Montaje", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "## %"))
        Me.MontajeTextBox.Enabled = False
        Me.MontajeTextBox.Location = New System.Drawing.Point(1267, 382)
        Me.MontajeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MontajeTextBox.Name = "MontajeTextBox"
        Me.MontajeTextBox.Size = New System.Drawing.Size(99, 22)
        Me.MontajeTextBox.TabIndex = 56
        Me.MontajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoMontajeTextBox
        '
        Me.CostoMontajeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CostoMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoMontaje", True))
        Me.CostoMontajeTextBox.Location = New System.Drawing.Point(1375, 382)
        Me.CostoMontajeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoMontajeTextBox.Name = "CostoMontajeTextBox"
        Me.CostoMontajeTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoMontajeTextBox.TabIndex = 58
        Me.CostoMontajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalCostoTextBox
        '
        Me.SubTotalCostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "SubTotalCosto", True))
        Me.SubTotalCostoTextBox.Enabled = False
        Me.SubTotalCostoTextBox.Location = New System.Drawing.Point(1375, 414)
        Me.SubTotalCostoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalCostoTextBox.Name = "SubTotalCostoTextBox"
        Me.SubTotalCostoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.SubTotalCostoTextBox.TabIndex = 60
        Me.SubTotalCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BeneficioTextBox
        '
        Me.BeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Beneficio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "## %"))
        Me.BeneficioTextBox.Location = New System.Drawing.Point(1267, 446)
        Me.BeneficioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BeneficioTextBox.Name = "BeneficioTextBox"
        Me.BeneficioTextBox.Size = New System.Drawing.Size(99, 22)
        Me.BeneficioTextBox.TabIndex = 62
        Me.BeneficioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalBeneficioTextBox
        '
        Me.TotalBeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalBeneficio", True))
        Me.TotalBeneficioTextBox.Enabled = False
        Me.TotalBeneficioTextBox.Location = New System.Drawing.Point(1375, 446)
        Me.TotalBeneficioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalBeneficioTextBox.Name = "TotalBeneficioTextBox"
        Me.TotalBeneficioTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TotalBeneficioTextBox.TabIndex = 64
        Me.TotalBeneficioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImprevistosTextBox
        '
        Me.ImprevistosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Imprevistos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "## %"))
        Me.ImprevistosTextBox.Location = New System.Drawing.Point(1267, 544)
        Me.ImprevistosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImprevistosTextBox.Name = "ImprevistosTextBox"
        Me.ImprevistosTextBox.Size = New System.Drawing.Size(99, 22)
        Me.ImprevistosTextBox.TabIndex = 66
        Me.ImprevistosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalImprevistosTextBox
        '
        Me.TotalImprevistosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalImprevistos", True))
        Me.TotalImprevistosTextBox.Enabled = False
        Me.TotalImprevistosTextBox.Location = New System.Drawing.Point(1375, 544)
        Me.TotalImprevistosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalImprevistosTextBox.Name = "TotalImprevistosTextBox"
        Me.TotalImprevistosTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TotalImprevistosTextBox.TabIndex = 68
        Me.TotalImprevistosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubtotalVentaTextBox
        '
        Me.SubtotalVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "SubtotalVenta", True))
        Me.SubtotalVentaTextBox.Enabled = False
        Me.SubtotalVentaTextBox.Location = New System.Drawing.Point(1375, 512)
        Me.SubtotalVentaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubtotalVentaTextBox.Name = "SubtotalVentaTextBox"
        Me.SubtotalVentaTextBox.Size = New System.Drawing.Size(99, 22)
        Me.SubtotalVentaTextBox.TabIndex = 70
        Me.SubtotalVentaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalDescuentoTextBox
        '
        Me.TotalDescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalDescuento", True))
        Me.TotalDescuentoTextBox.Enabled = False
        Me.TotalDescuentoTextBox.Location = New System.Drawing.Point(1375, 608)
        Me.TotalDescuentoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalDescuentoTextBox.Name = "TotalDescuentoTextBox"
        Me.TotalDescuentoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TotalDescuentoTextBox.TabIndex = 72
        Me.TotalDescuentoTextBox.Text = "`"
        Me.TotalDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioVentaTextBox
        '
        Me.PrecioVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "PrecioVenta", True))
        Me.PrecioVentaTextBox.Enabled = False
        Me.PrecioVentaTextBox.Location = New System.Drawing.Point(1375, 639)
        Me.PrecioVentaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecioVentaTextBox.Name = "PrecioVentaTextBox"
        Me.PrecioVentaTextBox.Size = New System.Drawing.Size(99, 22)
        Me.PrecioVentaTextBox.TabIndex = 74
        Me.PrecioVentaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalHorasTextBox
        '
        Me.TotalHorasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalHoras", True))
        Me.TotalHorasTextBox.Enabled = False
        Me.TotalHorasTextBox.Location = New System.Drawing.Point(1375, 30)
        Me.TotalHorasTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalHorasTextBox.Name = "TotalHorasTextBox"
        Me.TotalHorasTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TotalHorasTextBox.TabIndex = 76
        Me.TotalHorasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoTrabajoTextBox
        '
        Me.CostoTrabajoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "CostoTrabajo", True))
        Me.CostoTrabajoTextBox.Enabled = False
        Me.CostoTrabajoTextBox.Location = New System.Drawing.Point(1375, 62)
        Me.CostoTrabajoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostoTrabajoTextBox.Name = "CostoTrabajoTextBox"
        Me.CostoTrabajoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.CostoTrabajoTextBox.TabIndex = 78
        Me.CostoTrabajoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalcostoTextBox
        '
        Me.TotalcostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Totalcosto", True))
        Me.TotalcostoTextBox.Enabled = False
        Me.TotalcostoTextBox.Location = New System.Drawing.Point(1375, 286)
        Me.TotalcostoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalcostoTextBox.Name = "TotalcostoTextBox"
        Me.TotalcostoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.TotalcostoTextBox.TabIndex = 80
        Me.TotalcostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnGenerarPrecio
        '
        Me.BtnGenerarPrecio.Location = New System.Drawing.Point(1056, 68)
        Me.BtnGenerarPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGenerarPrecio.Name = "BtnGenerarPrecio"
        Me.BtnGenerarPrecio.Size = New System.Drawing.Size(100, 28)
        Me.BtnGenerarPrecio.TabIndex = 81
        Me.BtnGenerarPrecio.Text = "Generar Precio"
        Me.BtnGenerarPrecio.UseVisualStyleBackColor = True
        '
        'MaterilaesDetalleBindingSource
        '
        Me.MaterilaesDetalleBindingSource.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource.DataSource = Me.DsMaterialDetalle
        '
        'DsMaterialDetalle
        '
        Me.DsMaterialDetalle.DataSetName = "DsMaterialDetalle"
        Me.DsMaterialDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsumoPinturaArticuloDataGridView
        '
        Me.ConsumoPinturaArticuloDataGridView.AllowUserToAddRows = False
        Me.ConsumoPinturaArticuloDataGridView.AllowUserToDeleteRows = False
        Me.ConsumoPinturaArticuloDataGridView.AutoGenerateColumns = False
        Me.ConsumoPinturaArticuloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumoPinturaArticuloDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.PinturaCantidad, Me.PinturaPrecio, Me.DataGridViewTextBoxColumn29, Me.Id_Medida})
        Me.ConsumoPinturaArticuloDataGridView.DataSource = Me.ConsumoPinturaArticuloBindingSource
        Me.ConsumoPinturaArticuloDataGridView.Location = New System.Drawing.Point(27, 286)
        Me.ConsumoPinturaArticuloDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsumoPinturaArticuloDataGridView.Name = "ConsumoPinturaArticuloDataGridView"
        Me.ConsumoPinturaArticuloDataGridView.ReadOnly = True
        Me.ConsumoPinturaArticuloDataGridView.RowHeadersWidth = 51
        Me.ConsumoPinturaArticuloDataGridView.Size = New System.Drawing.Size(972, 156)
        Me.ConsumoPinturaArticuloDataGridView.TabIndex = 81
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 250
        '
        'PinturaCantidad
        '
        Me.PinturaCantidad.DataPropertyName = "TotalNecesidadarticulo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n4"
        Me.PinturaCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.PinturaCantidad.HeaderText = "Cantidad"
        Me.PinturaCantidad.MinimumWidth = 6
        Me.PinturaCantidad.Name = "PinturaCantidad"
        Me.PinturaCantidad.ReadOnly = True
        Me.PinturaCantidad.Width = 75
        '
        'PinturaPrecio
        '
        Me.PinturaPrecio.DataPropertyName = "PrecioCompra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.PinturaPrecio.DefaultCellStyle = DataGridViewCellStyle2
        Me.PinturaPrecio.HeaderText = "Precio"
        Me.PinturaPrecio.MinimumWidth = 6
        Me.PinturaPrecio.Name = "PinturaPrecio"
        Me.PinturaPrecio.ReadOnly = True
        Me.PinturaPrecio.Width = 75
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "TotalCostoArticulo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn29.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn29.HeaderText = "Total Costo"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 75
        '
        'Id_Medida
        '
        Me.Id_Medida.DataPropertyName = "Descripcion_Medida"
        Me.Id_Medida.HeaderText = "Medida"
        Me.Id_Medida.MinimumWidth = 6
        Me.Id_Medida.Name = "Id_Medida"
        Me.Id_Medida.ReadOnly = True
        Me.Id_Medida.Width = 200
        '
        'ConsumoPinturaArticuloBindingSource
        '
        Me.ConsumoPinturaArticuloBindingSource.DataMember = "ConsumoPinturaArticulo"
        Me.ConsumoPinturaArticuloBindingSource.DataSource = Me.DsCosumoPinturaArticulo
        '
        'DsCosumoPinturaArticulo
        '
        Me.DsCosumoPinturaArticulo.DataSetName = "DsCosumoPinturaArticulo"
        Me.DsCosumoPinturaArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaComponentesBindingSource
        '
        Me.PinturaComponentesBindingSource.DataMember = "PinturaComponentes"
        Me.PinturaComponentesBindingSource.DataSource = Me.DsPinturaComponentes
        '
        'DsPinturaComponentes
        '
        Me.DsPinturaComponentes.DataSetName = "DsPinturaComponentes"
        Me.DsPinturaComponentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra3
        '
        'DsMedidasCompra3
        '
        Me.DsMedidasCompra3.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrecioGeneradoTextBox
        '
        Me.PrecioGeneradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "PrecioGenerado", True))
        Me.PrecioGeneradoTextBox.Enabled = False
        Me.PrecioGeneradoTextBox.Location = New System.Drawing.Point(1375, 576)
        Me.PrecioGeneradoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrecioGeneradoTextBox.Name = "PrecioGeneradoTextBox"
        Me.PrecioGeneradoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.PrecioGeneradoTextBox.TabIndex = 82
        Me.PrecioGeneradoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'DsConsumoMaterialArticulo
        '
        Me.DsConsumoMaterialArticulo.DataSetName = "DsConsumoMaterialArticulo"
        Me.DsConsumoMaterialArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsumoMaterialArticulosBindingSource
        '
        Me.ConsumoMaterialArticulosBindingSource.DataMember = "ConsumoMaterialArticulos"
        Me.ConsumoMaterialArticulosBindingSource.DataSource = Me.DsConsumoMaterialArticulo
        '
        'ConsumoMaterialArticulosTableAdapter
        '
        Me.ConsumoMaterialArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsConsumoMaterialArticuloTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsumoMaterialArticulosDataGridView
        '
        Me.ConsumoMaterialArticulosDataGridView.AllowUserToAddRows = False
        Me.ConsumoMaterialArticulosDataGridView.AllowUserToDeleteRows = False
        Me.ConsumoMaterialArticulosDataGridView.AutoGenerateColumns = False
        Me.ConsumoMaterialArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumoMaterialArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialId, Me.MaterialCantidad, Me.MaterialPrecio, Me.MaterialTotalCosto, Me.DataGridViewTextBoxColumn57})
        Me.ConsumoMaterialArticulosDataGridView.DataSource = Me.ConsumoMaterialArticulosBindingSource
        Me.ConsumoMaterialArticulosDataGridView.Location = New System.Drawing.Point(27, 126)
        Me.ConsumoMaterialArticulosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsumoMaterialArticulosDataGridView.Name = "ConsumoMaterialArticulosDataGridView"
        Me.ConsumoMaterialArticulosDataGridView.ReadOnly = True
        Me.ConsumoMaterialArticulosDataGridView.RowHeadersWidth = 51
        Me.ConsumoMaterialArticulosDataGridView.Size = New System.Drawing.Size(972, 156)
        Me.ConsumoMaterialArticulosDataGridView.TabIndex = 83
        '
        'MaterialId
        '
        Me.MaterialId.DataPropertyName = "Descripcion"
        Me.MaterialId.HeaderText = "Descripcion"
        Me.MaterialId.MinimumWidth = 6
        Me.MaterialId.Name = "MaterialId"
        Me.MaterialId.ReadOnly = True
        Me.MaterialId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MaterialId.Width = 250
        '
        'MaterialCantidad
        '
        Me.MaterialCantidad.DataPropertyName = "TotalCompraArticulo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.MaterialCantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.MaterialCantidad.HeaderText = "Cantidad"
        Me.MaterialCantidad.MinimumWidth = 6
        Me.MaterialCantidad.Name = "MaterialCantidad"
        Me.MaterialCantidad.ReadOnly = True
        Me.MaterialCantidad.Width = 75
        '
        'MaterialPrecio
        '
        Me.MaterialPrecio.DataPropertyName = "PrecioCompra"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.MaterialPrecio.DefaultCellStyle = DataGridViewCellStyle5
        Me.MaterialPrecio.HeaderText = "Precio"
        Me.MaterialPrecio.MinimumWidth = 6
        Me.MaterialPrecio.Name = "MaterialPrecio"
        Me.MaterialPrecio.ReadOnly = True
        Me.MaterialPrecio.Width = 75
        '
        'MaterialTotalCosto
        '
        Me.MaterialTotalCosto.DataPropertyName = "TotalCostoArticulo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.MaterialTotalCosto.DefaultCellStyle = DataGridViewCellStyle6
        Me.MaterialTotalCosto.HeaderText = "Total Costo"
        Me.MaterialTotalCosto.MinimumWidth = 6
        Me.MaterialTotalCosto.Name = "MaterialTotalCosto"
        Me.MaterialTotalCosto.ReadOnly = True
        Me.MaterialTotalCosto.Width = 75
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Medida"
        Me.DataGridViewTextBoxColumn57.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn57.Width = 200
        '
        'PinturaComponentesTableAdapter
        '
        Me.PinturaComponentesTableAdapter.ClearBeforeFill = True
        '
        'BtnAgregarPresupuesto
        '
        Me.BtnAgregarPresupuesto.Location = New System.Drawing.Point(1120, 676)
        Me.BtnAgregarPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregarPresupuesto.Name = "BtnAgregarPresupuesto"
        Me.BtnAgregarPresupuesto.Size = New System.Drawing.Size(147, 28)
        Me.BtnAgregarPresupuesto.TabIndex = 84
        Me.BtnAgregarPresupuesto.Text = "Aceptar"
        Me.BtnAgregarPresupuesto.UseVisualStyleBackColor = True
        '
        'TotalPartidaTextBox
        '
        Me.TotalPartidaTextBox.AcceptsReturn = True
        Me.TotalPartidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalPartida", True))
        Me.TotalPartidaTextBox.Location = New System.Drawing.Point(439, 641)
        Me.TotalPartidaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPartidaTextBox.Name = "TotalPartidaTextBox"
        Me.TotalPartidaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalPartidaTextBox.TabIndex = 86
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(265, 641)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CantidadTextBox.TabIndex = 87
        '
        'DsPresupuestoDetalleferreteria
        '
        Me.DsPresupuestoDetalleferreteria.DataSetName = "DsPresupuestoDetalleferreteria"
        Me.DsPresupuestoDetalleferreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleFerreteriaBindingSource
        '
        Me.PresupuestoDetalleFerreteriaBindingSource.DataMember = "PresupuestoDetalleFerreteria"
        Me.PresupuestoDetalleFerreteriaBindingSource.DataSource = Me.DsPresupuestoDetalleferreteria
        '
        'PresupuestoDetalleFerreteriaTableAdapter
        '
        Me.PresupuestoDetalleFerreteriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.PresupuestoDetalleFerreteriaTableAdapter = Me.PresupuestoDetalleFerreteriaTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsFerreteria
        '
        Me.DsFerreteria.DataSetName = "DsFerreteria"
        Me.DsFerreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FerreteriaBindingSource
        '
        Me.FerreteriaBindingSource.DataMember = "Ferreteria"
        Me.FerreteriaBindingSource.DataSource = Me.DsFerreteria
        '
        'FerreteriaTableAdapter
        '
        Me.FerreteriaTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDetalleHerrajesDataGridView
        '
        Me.PresupuestoDetalleHerrajesDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleHerrajesDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleHerrajesDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleHerrajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleHerrajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion_Elemento_Herrajes, Me.CantidadHerrajesDetalle, Me.PrecioCompraHerrajes, Me.TotalCostodetalle, Me.DescripcionMedidaDataGridViewTextBoxColumn})
        Me.PresupuestoDetalleHerrajesDataGridView.DataSource = Me.ConsumoHerrajesArticuloBindingSource
        Me.PresupuestoDetalleHerrajesDataGridView.Location = New System.Drawing.Point(27, 450)
        Me.PresupuestoDetalleHerrajesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PresupuestoDetalleHerrajesDataGridView.Name = "PresupuestoDetalleHerrajesDataGridView"
        Me.PresupuestoDetalleHerrajesDataGridView.ReadOnly = True
        Me.PresupuestoDetalleHerrajesDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleHerrajesDataGridView.Size = New System.Drawing.Size(972, 156)
        Me.PresupuestoDetalleHerrajesDataGridView.TabIndex = 87
        '
        'Descripcion_Elemento_Herrajes
        '
        Me.Descripcion_Elemento_Herrajes.DataPropertyName = "Descripcion_Elemento_Herrajes"
        Me.Descripcion_Elemento_Herrajes.HeaderText = "Descripcion"
        Me.Descripcion_Elemento_Herrajes.MinimumWidth = 6
        Me.Descripcion_Elemento_Herrajes.Name = "Descripcion_Elemento_Herrajes"
        Me.Descripcion_Elemento_Herrajes.ReadOnly = True
        Me.Descripcion_Elemento_Herrajes.Width = 250
        '
        'CantidadHerrajesDetalle
        '
        Me.CantidadHerrajesDetalle.DataPropertyName = "CantidadHerrajesDetalle"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.CantidadHerrajesDetalle.DefaultCellStyle = DataGridViewCellStyle7
        Me.CantidadHerrajesDetalle.HeaderText = "Cantidad"
        Me.CantidadHerrajesDetalle.MinimumWidth = 6
        Me.CantidadHerrajesDetalle.Name = "CantidadHerrajesDetalle"
        Me.CantidadHerrajesDetalle.ReadOnly = True
        Me.CantidadHerrajesDetalle.Width = 75
        '
        'PrecioCompraHerrajes
        '
        Me.PrecioCompraHerrajes.DataPropertyName = "PrecioCompraHerrajes"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.PrecioCompraHerrajes.DefaultCellStyle = DataGridViewCellStyle8
        Me.PrecioCompraHerrajes.HeaderText = "Precio"
        Me.PrecioCompraHerrajes.MinimumWidth = 6
        Me.PrecioCompraHerrajes.Name = "PrecioCompraHerrajes"
        Me.PrecioCompraHerrajes.ReadOnly = True
        Me.PrecioCompraHerrajes.Width = 75
        '
        'TotalCostodetalle
        '
        Me.TotalCostodetalle.DataPropertyName = "TotalCostodetalle"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.TotalCostodetalle.DefaultCellStyle = DataGridViewCellStyle9
        Me.TotalCostodetalle.HeaderText = "Total Costo"
        Me.TotalCostodetalle.MinimumWidth = 6
        Me.TotalCostodetalle.Name = "TotalCostodetalle"
        Me.TotalCostodetalle.ReadOnly = True
        Me.TotalCostodetalle.Width = 75
        '
        'DescripcionMedidaDataGridViewTextBoxColumn
        '
        Me.DescripcionMedidaDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Medida"
        Me.DescripcionMedidaDataGridViewTextBoxColumn.HeaderText = "Medida"
        Me.DescripcionMedidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionMedidaDataGridViewTextBoxColumn.Name = "DescripcionMedidaDataGridViewTextBoxColumn"
        Me.DescripcionMedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionMedidaDataGridViewTextBoxColumn.Width = 200
        '
        'ConsumoHerrajesArticuloBindingSource
        '
        Me.ConsumoHerrajesArticuloBindingSource.DataMember = "ConsumoHerrajesArticulo"
        Me.ConsumoHerrajesArticuloBindingSource.DataSource = Me.DsConsumoHerrajesArticulo
        '
        'DsConsumoHerrajesArticulo
        '
        Me.DsConsumoHerrajesArticulo.DataSetName = "DsConsumoHerrajesArticulo"
        Me.DsConsumoHerrajesArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerrajesBindingSource
        '
        Me.HerrajesBindingSource.DataMember = "Herrajes"
        Me.HerrajesBindingSource.DataSource = Me.DsHerrajes
        '
        'DsHerrajes
        '
        Me.DsHerrajes.DataSetName = "DsHerrajes"
        Me.DsHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleHerrajesBindingSource
        '
        Me.PresupuestoDetalleHerrajesBindingSource.DataMember = "PresupuestoDetalleHerrajes"
        Me.PresupuestoDetalleHerrajesBindingSource.DataSource = Me.DsPresupuestoDetalleHerrajes
        '
        'DsPresupuestoDetalleHerrajes
        '
        Me.DsPresupuestoDetalleHerrajes.DataSetName = "DsPresupuestoDetalleHerrajes"
        Me.DsPresupuestoDetalleHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerrajesTableAdapter
        '
        Me.HerrajesTableAdapter.ClearBeforeFill = True
        '
        'MedidasCompraTableAdapter3
        '
        Me.MedidasCompraTableAdapter3.ClearBeforeFill = True
        '
        'PresupuestoDetalleHerrajesTableAdapter
        '
        Me.PresupuestoDetalleHerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.PresupuestoDetalleHerrajesTableAdapter = Me.PresupuestoDetalleHerrajesTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsumoPinturaArticuloTableAdapter
        '
        Me.ConsumoPinturaArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsCosumoPinturaArticuloTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsumoHerrajesArticuloTableAdapter
        '
        Me.ConsumoHerrajesArticuloTableAdapter.ClearBeforeFill = True
        '
        'ConsumoFerreteriaArticulosDataGridView
        '
        Me.ConsumoFerreteriaArticulosDataGridView.AllowUserToAddRows = False
        Me.ConsumoFerreteriaArticulosDataGridView.AllowUserToDeleteRows = False
        Me.ConsumoFerreteriaArticulosDataGridView.AutoGenerateColumns = False
        Me.ConsumoFerreteriaArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumoFerreteriaArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn, Me.TotalArticuloDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CostoArticuloDataGridViewTextBoxColumn, Me.DescripcionMedidaDataGridViewTextBoxColumn1})
        Me.ConsumoFerreteriaArticulosDataGridView.DataSource = Me.ConsumoFerreteriaArticulosBindingSource
        Me.ConsumoFerreteriaArticulosDataGridView.Location = New System.Drawing.Point(27, 624)
        Me.ConsumoFerreteriaArticulosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsumoFerreteriaArticulosDataGridView.Name = "ConsumoFerreteriaArticulosDataGridView"
        Me.ConsumoFerreteriaArticulosDataGridView.ReadOnly = True
        Me.ConsumoFerreteriaArticulosDataGridView.RowHeadersWidth = 51
        Me.ConsumoFerreteriaArticulosDataGridView.Size = New System.Drawing.Size(972, 156)
        Me.ConsumoFerreteriaArticulosDataGridView.TabIndex = 87
        '
        'DescripcionEementoFerreteriaDataGridViewTextBoxColumn
        '
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Eemento_Ferreteria"
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn.Name = "DescripcionEementoFerreteriaDataGridViewTextBoxColumn"
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionEementoFerreteriaDataGridViewTextBoxColumn.Width = 250
        '
        'TotalArticuloDataGridViewTextBoxColumn
        '
        Me.TotalArticuloDataGridViewTextBoxColumn.DataPropertyName = "TotalArticulo"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.TotalArticuloDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TotalArticuloDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.TotalArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalArticuloDataGridViewTextBoxColumn.Name = "TotalArticuloDataGridViewTextBoxColumn"
        Me.TotalArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalArticuloDataGridViewTextBoxColumn.Width = 75
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 75
        '
        'CostoArticuloDataGridViewTextBoxColumn
        '
        Me.CostoArticuloDataGridViewTextBoxColumn.DataPropertyName = "CostoArticulo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.CostoArticuloDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.CostoArticuloDataGridViewTextBoxColumn.HeaderText = "Total Costo"
        Me.CostoArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostoArticuloDataGridViewTextBoxColumn.Name = "CostoArticuloDataGridViewTextBoxColumn"
        Me.CostoArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoArticuloDataGridViewTextBoxColumn.Width = 75
        '
        'DescripcionMedidaDataGridViewTextBoxColumn1
        '
        Me.DescripcionMedidaDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion_Medida"
        Me.DescripcionMedidaDataGridViewTextBoxColumn1.HeaderText = "Medida"
        Me.DescripcionMedidaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DescripcionMedidaDataGridViewTextBoxColumn1.Name = "DescripcionMedidaDataGridViewTextBoxColumn1"
        Me.DescripcionMedidaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DescripcionMedidaDataGridViewTextBoxColumn1.Width = 200
        '
        'ConsumoFerreteriaArticulosBindingSource
        '
        Me.ConsumoFerreteriaArticulosBindingSource.DataMember = "ConsumoFerreteriaArticulos"
        Me.ConsumoFerreteriaArticulosBindingSource.DataSource = Me.DsConsumoFerreteriaArticulos
        '
        'DsConsumoFerreteriaArticulos
        '
        Me.DsConsumoFerreteriaArticulos.DataSetName = "DsConsumoFerreteriaArticulos"
        Me.DsConsumoFerreteriaArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsumoFerreteriaArticulosTableAdapter
        '
        Me.ConsumoFerreteriaArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.Connection = Nothing
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsConsumoFerreteriaArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Descripcion_articuloTextBox
        '
        Me.Descripcion_articuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion_articulo", True))
        Me.Descripcion_articuloTextBox.Location = New System.Drawing.Point(316, 34)
        Me.Descripcion_articuloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion_articuloTextBox.Multiline = True
        Me.Descripcion_articuloTextBox.Name = "Descripcion_articuloTextBox"
        Me.Descripcion_articuloTextBox.Size = New System.Drawing.Size(681, 83)
        Me.Descripcion_articuloTextBox.TabIndex = 89
        '
        'Precio_AjustadoRD_TextBox
        '
        Me.Precio_AjustadoRD_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Precio_AjustadoRD$", True))
        Me.Precio_AjustadoRD_TextBox.Location = New System.Drawing.Point(757, 641)
        Me.Precio_AjustadoRD_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Precio_AjustadoRD_TextBox.Name = "Precio_AjustadoRD_TextBox"
        Me.Precio_AjustadoRD_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.Precio_AjustadoRD_TextBox.TabIndex = 92
        '
        'TotalPartidaRD_TextBox
        '
        Me.TotalPartidaRD_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalPartidaRD$", True))
        Me.TotalPartidaRD_TextBox.Location = New System.Drawing.Point(244, 673)
        Me.TotalPartidaRD_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPartidaRD_TextBox.Name = "TotalPartidaRD_TextBox"
        Me.TotalPartidaRD_TextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalPartidaRD_TextBox.TabIndex = 93
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
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.Connection = Nothing
        Me.TableAdapterManager6.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Tasa", True))
        Me.TasaTextBox.Location = New System.Drawing.Point(600, 641)
        Me.TasaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TasaTextBox.TabIndex = 95
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1484, 318)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 28)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ItbisIncluidoTextBox
        '
        Me.ItbisIncluidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "ItbisIncluido", True))
        Me.ItbisIncluidoTextBox.Enabled = False
        Me.ItbisIncluidoTextBox.Location = New System.Drawing.Point(1375, 480)
        Me.ItbisIncluidoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItbisIncluidoTextBox.Name = "ItbisIncluidoTextBox"
        Me.ItbisIncluidoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.ItbisIncluidoTextBox.TabIndex = 97
        Me.ItbisIncluidoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InlItebisCheckBox
        '
        Me.InlItebisCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PresupuestoDetalleBindingSource, "InlItebis", True))
        Me.InlItebisCheckBox.Location = New System.Drawing.Point(1277, 482)
        Me.InlItebisCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InlItebisCheckBox.Name = "InlItebisCheckBox"
        Me.InlItebisCheckBox.Size = New System.Drawing.Size(25, 30)
        Me.InlItebisCheckBox.TabIndex = 99
        Me.InlItebisCheckBox.UseVisualStyleBackColor = True
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Descuento", True))
        Me.DescuentoTextBox.Location = New System.Drawing.Point(1267, 608)
        Me.DescuentoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.Size = New System.Drawing.Size(99, 22)
        Me.DescuentoTextBox.TabIndex = 100
        Me.DescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TrabajoTallerTextBox
        '
        Me.TrabajoTallerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TrabajoTaller", True))
        Me.TrabajoTallerTextBox.Location = New System.Drawing.Point(1158, 30)
        Me.TrabajoTallerTextBox.Name = "TrabajoTallerTextBox"
        Me.TrabajoTallerTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TrabajoTallerTextBox.TabIndex = 101
        '
        'EstudioPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1569, 805)
        Me.Controls.Add(Me.TrabajoTallerTextBox)
        Me.Controls.Add(Me.DescuentoTextBox)
        Me.Controls.Add(Me.InlItebisCheckBox)
        Me.Controls.Add(ItbisIncluidoLabel)
        Me.Controls.Add(Me.ItbisIncluidoTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ConsumoFerreteriaArticulosDataGridView)
        Me.Controls.Add(Me.TasaTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TotalPartidaRD_TextBox)
        Me.Controls.Add(Me.Precio_AjustadoRD_TextBox)
        Me.Controls.Add(Me.Descripcion_articuloTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PresupuestoDetalleHerrajesDataGridView)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Me.TotalPartidaTextBox)
        Me.Controls.Add(Me.BtnAgregarPresupuesto)
        Me.Controls.Add(Me.ConsumoMaterialArticulosDataGridView)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PrecioGeneradoTextBox)
        Me.Controls.Add(Me.ConsumoPinturaArticuloDataGridView)
        Me.Controls.Add(Me.BtnGenerarPrecio)
        Me.Controls.Add(DescuentoLabel)
        Me.Controls.Add(Precio_AjustadoLabel)
        Me.Controls.Add(Me.Precio_AjustadoTextBox)
        Me.Controls.Add(CostoMaderaLabel)
        Me.Controls.Add(Me.CostoMaderaTextBox)
        Me.Controls.Add(CostoPinturaLabel)
        Me.Controls.Add(Me.CostoPinturaTextBox)
        Me.Controls.Add(PrecioHoraLabel)
        Me.Controls.Add(Me.PrecioHoraTextBox)
        Me.Controls.Add(TrabajoTallerLabel)
        Me.Controls.Add(TrabajoPiinturaLabel)
        Me.Controls.Add(Me.TrabajoPiinturaTextBox)
        Me.Controls.Add(CostoFereteriaLabel)
        Me.Controls.Add(Me.CostoFereteriaTextBox)
        Me.Controls.Add(SubTotalCostoDirectoLabel)
        Me.Controls.Add(Me.SubTotalCostoDirectoTextBox)
        Me.Controls.Add(OtrosCostosLabel)
        Me.Controls.Add(Me.OtrosCostosTextBox)
        Me.Controls.Add(Me.CostoOtrosCostosTextBox)
        Me.Controls.Add(TotalCostoDirectoLabel)
        Me.Controls.Add(CostoIdirectoLabel)
        Me.Controls.Add(Me.CostoIndirectoTextBox)
        Me.Controls.Add(Me.TotalCostoIdirectoTextBox)
        Me.Controls.Add(TransporteEmbalajeLabel)
        Me.Controls.Add(Me.TransporteEmbalajeTextBox)
        Me.Controls.Add(Me.CostoTransporteEmbalajeTextBox)
        Me.Controls.Add(CostoHerrajesLabel)
        Me.Controls.Add(Me.CostoHerrajesTextBox)
        Me.Controls.Add(Me.MontajeTextBox)
        Me.Controls.Add(CostoMontajeLabel)
        Me.Controls.Add(Me.CostoMontajeTextBox)
        Me.Controls.Add(SubTotalCostoLabel)
        Me.Controls.Add(Me.SubTotalCostoTextBox)
        Me.Controls.Add(BeneficioLabel)
        Me.Controls.Add(Me.BeneficioTextBox)
        Me.Controls.Add(Me.TotalBeneficioTextBox)
        Me.Controls.Add(ImprevistosLabel)
        Me.Controls.Add(Me.ImprevistosTextBox)
        Me.Controls.Add(Me.TotalImprevistosTextBox)
        Me.Controls.Add(SubtotalVentaLabel)
        Me.Controls.Add(Me.SubtotalVentaTextBox)
        Me.Controls.Add(Me.TotalDescuentoTextBox)
        Me.Controls.Add(PrecioVentaLabel)
        Me.Controls.Add(Me.PrecioVentaTextBox)
        Me.Controls.Add(TotalHorasLabel)
        Me.Controls.Add(Me.TotalHorasTextBox)
        Me.Controls.Add(CostoTrabajoLabel)
        Me.Controls.Add(Me.CostoTrabajoTextBox)
        Me.Controls.Add(Me.TotalcostoTextBox)
        Me.Controls.Add(ArticuloLabel)
        Me.Controls.Add(Me.ArticuloTextBox)
        Me.Controls.Add(IdDetalle_PresupuestoLabel)
        Me.Controls.Add(Me.IdDetalle_PresupuestoTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EstudioPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EstudioPrecios"
        CType(Me.PresupuestoDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPresupuestoDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsArticulos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ArticulosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MaterilaesDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMaterialDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoPinturaArticuloDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoPinturaArticuloBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsCosumoPinturaArticulo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PinturaComponentesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPinturaComponentes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MedidasCompraBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMedidasCompra3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsConsumoMaterialArticulo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoMaterialArticulosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoMaterialArticulosDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPresupuestoDetalleferreteria,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PresupuestoDetalleFerreteriaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsFerreteria,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FerreteriaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PresupuestoDetalleHerrajesDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoHerrajesArticuloBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsConsumoHerrajesArticulo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HerrajesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsHerrajes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PresupuestoDetalleHerrajesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPresupuestoDetalleHerrajes,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoFerreteriaArticulosDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsumoFerreteriaArticulosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsConsumoFerreteriaArticulos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPresupuestos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PresupuestoBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents IdDetalle_PresupuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents Precio_AjustadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoMaderaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoPinturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioHoraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrabajoPiinturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoFereteriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalCostoDirectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrosCostosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoOtrosCostosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoIndirectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostoIdirectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransporteEmbalajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTransporteEmbalajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoHerrajesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MontajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoMontajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalCostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeneficioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalBeneficioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImprevistosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalImprevistosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubtotalVentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDescuentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioVentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalHorasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTrabajoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalcostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerarPrecio As System.Windows.Forms.Button


    Friend WithEvents DsCosumoPinturaArticulo As ModuloGestion.DsCosumoPinturaArticulo
    Friend WithEvents ConsumoPinturaArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumoPinturaArticuloTableAdapter As ModuloGestion.DsCosumoPinturaArticuloTableAdapters.ConsumoPinturaArticuloTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsCosumoPinturaArticuloTableAdapters.TableAdapterManager
    Friend WithEvents ConsumoPinturaArticuloDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrecioGeneradoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsConsumoMaterialArticulo As ModuloGestion.DsConsumoMaterialArticulo
    Friend WithEvents ConsumoMaterialArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumoMaterialArticulosTableAdapter As ModuloGestion.DsConsumoMaterialArticuloTableAdapters.ConsumoMaterialArticulosTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsConsumoMaterialArticuloTableAdapters.TableAdapterManager
    Friend WithEvents ConsumoMaterialArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsPinturaComponentes As ModuloGestion.DsPinturaComponentes
    Friend WithEvents PinturaComponentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaComponentesTableAdapter As ModuloGestion.DsPinturaComponentesTableAdapters.PinturaComponentesTableAdapter
    Friend WithEvents BtnAgregarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents TotalPartidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsPresupuestoDetalleferreteria As ModuloGestion.DsPresupuestoDetalleferreteria
    Friend WithEvents PresupuestoDetalleFerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleFerreteriaTableAdapter As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager
    Friend WithEvents DsFerreteria As ModuloGestion.DsFerreteria
    Friend WithEvents FerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FerreteriaTableAdapter As ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager6 As ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents DsMedidasCompra1 As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraTableAdapter1 As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsMedidasCompra2 As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraTableAdapter2 As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsPresupuestoDetalleHerrajes As ModuloGestion.DsPresupuestoDetalleHerrajes
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleHerrajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsHerrajes As ModuloGestion.DsHerrajes
    Friend WithEvents HerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesTableAdapter As ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter
    Friend WithEvents DsMedidasCompra3 As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter3 As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsConsumoHerrajesArticulo As ModuloGestion.DsConsumoHerrajesArticulo
    Friend WithEvents ConsumoHerrajesArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumoHerrajesArticuloTableAdapter As ModuloGestion.DsConsumoHerrajesArticuloTableAdapters.ConsumoHerrajesArticuloTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinturaCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinturaPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialTotalCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_Elemento_Herrajes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadHerrajesDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompraHerrajes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostodetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumoFerreteriaArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsConsumoFerreteriaArticulos As ModuloGestion.DsConsumoFerreteriaArticulos
    Friend WithEvents ConsumoFerreteriaArticulosTableAdapter As ModuloGestion.DsConsumoFerreteriaArticulosTableAdapters.ConsumoFerreteriaArticulosTableAdapter
    Friend WithEvents TableAdapterManager7 As ModuloGestion.DsConsumoFerreteriaArticulosTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionEementoFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionMedidaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumoFerreteriaArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descripcion_articuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_AjustadoRD_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPartidaRD_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TasaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ItbisIncluidoTextBox As TextBox
    Friend WithEvents InlItebisCheckBox As CheckBox
    Friend WithEvents DescuentoTextBox As TextBox
    Friend WithEvents TrabajoTallerTextBox As TextBox
End Class
