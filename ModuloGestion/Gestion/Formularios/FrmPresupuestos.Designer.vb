<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPresupuestos
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
        Dim Id_empresaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim PlanosLabel As System.Windows.Forms.Label
        Dim Leyenda_PresupuestoLabel As System.Windows.Forms.Label
        Dim Descripcion_PresupuestoLabel As System.Windows.Forms.Label
        Dim Id_PresupuestoLabel As System.Windows.Forms.Label
        Dim Id_proyecto_PresupuestosLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim OtrosLabel As System.Windows.Forms.Label
        Dim Tarnsporte_EmbalajeLabel As System.Windows.Forms.Label
        Dim BeneficioLabel As System.Windows.Forms.Label
        Dim Gastos_ImprevistosLabel As System.Windows.Forms.Label
        Dim Gastos_IndierectosLabel As System.Windows.Forms.Label
        Dim Otros_GastosLabel As System.Windows.Forms.Label
        Dim Precio_HoraLabel As System.Windows.Forms.Label
        Dim ItbisLabel As System.Windows.Forms.Label
        Dim TasaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ItbisIncluidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresupuestos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.PreciosCompraProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreciosCompraProyecto = New ModuloGestion.DsPreciosCompraProyecto()
        Me.ConsultaHerrajePresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsultaHerrajesPresupuestoDetalle = New ModuloGestion.DsConsultaHerrajesPresupuestoDetalle()
        Me.LblPintura = New System.Windows.Forms.Label()
        Me.LblTipoPintura = New System.Windows.Forms.Label()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalleHerrajes = New ModuloGestion.DsPresupuestoDetalleHerrajes()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalleElementos = New ModuloGestion.DsPresupuestoDetalleElementos()
        Me.PresupuestoDetalleElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleElementosTableAdapter = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetallePintura = New ModuloGestion.DsPresupuestoDetallePintura()
        Me.PresupuestoDetallePinturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetallePinturaTableAdapter = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager()
        Me.HerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerrajes = New ModuloGestion.DsHerrajes()
        Me.HerrajesTableAdapter = New ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter()
        Me.ConsultaHerrajePresupuestoDetalleTableAdapter = New ModuloGestion.DsConsultaHerrajesPresupuestoDetalleTableAdapters.ConsultaHerrajePresupuestoDetalleTableAdapter()
        Me.TableAdapterManager8 = New ModuloGestion.DsConsultaHerrajesPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.DsAnexarHerrajeCompra = New ModuloGestion.DsAnexarHerrajeCompra()
        Me.AnexarHerrajesCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexarHerrajesCompraTableAdapter = New ModuloGestion.DsAnexarHerrajeCompraTableAdapters.AnexarHerrajesCompraTableAdapter()
        Me.TableAdapterManager9 = New ModuloGestion.DsAnexarHerrajeCompraTableAdapters.TableAdapterManager()
        Me.DsAnexarMaterialCompra = New ModuloGestion.DsAnexarMaterialCompra()
        Me.AnexarMaterialCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexarMaterialCompraTableAdapter = New ModuloGestion.DsAnexarMaterialCompraTableAdapters.AnexarMaterialCompraTableAdapter()
        Me.TableAdapterManager10 = New ModuloGestion.DsAnexarMaterialCompraTableAdapters.TableAdapterManager()
        Me.DsAnexarPinturaCompra = New ModuloGestion.DsAnexarPinturaCompra()
        Me.AnrxarPinturaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnrxarPinturaCompraTableAdapter = New ModuloGestion.DsAnexarPinturaCompraTableAdapters.AnrxarPinturaCompraTableAdapter()
        Me.TableAdapterManager11 = New ModuloGestion.DsAnexarPinturaCompraTableAdapters.TableAdapterManager()
        Me.BtnNotaEntrega = New System.Windows.Forms.Button()
        Me.BtnCambioProyecto = New System.Windows.Forms.Button()
        Me.LblEtiqueta = New System.Windows.Forms.Label()
        Me.BtnPreciosArticulo = New System.Windows.Forms.Button()
        Me.BtnAnexarPrecios = New System.Windows.Forms.Button()
        Me.BtnImprimirProforma = New System.Windows.Forms.Button()
        Me.BtnActualizarConsumos1 = New System.Windows.Forms.Button()
        Me.BtnSoloConsumos = New System.Windows.Forms.Button()
        Me.BtnDuplicarPresupuesto = New System.Windows.Forms.Button()
        Me.BtnImprimirPresupuesto = New System.Windows.Forms.Button()
        Me.Btnimprimirarticulos = New System.Windows.Forms.Button()
        Me.BtnKitArticulos = New System.Windows.Forms.Button()
        Me.BtnConsumoPresupuesto = New System.Windows.Forms.Button()
        Me.BtnAnalisisPresupuesto = New System.Windows.Forms.Button()
        Me.BtnCostoArticulos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnPinturaPresupuesto = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnDocumentacion = New System.Windows.Forms.Button()
        Me.PresupuestoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
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
        Me.PresupuestoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LblTipoPinturaPresupuestada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdDuplicarHerraje = New System.Windows.Forms.Button()
        Me.LblRegistroADuplicar = New System.Windows.Forms.Label()
        Me.lblDesdeelregistro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.DsAnexarFerreteriaCompra = New ModuloGestion.DsAnexarFerreteriaCompra()
        Me.AnexarFerreteriaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexarFerreteriaCompraTableAdapter = New ModuloGestion.DsAnexarFerreteriaCompraTableAdapters.AnexarFerreteriaCompraTableAdapter()
        Me.TableAdapterManager12 = New ModuloGestion.DsAnexarFerreteriaCompraTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalleferreteria = New ModuloGestion.DsPresupuestoDetalleferreteria()
        Me.PresupuestoDetalleFerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleFerreteriaTableAdapter = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter()
        Me.TableAdapterManager13 = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager()
        Me.DsTotalFerreteriaArticulo = New ModuloGestion.DsTotalFerreteriaArticulo()
        Me.TotalFerreteriaArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalFerreteriaArticuloTableAdapter = New ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TotalFerreteriaArticuloTableAdapter()
        Me.TableAdapterManager14 = New ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TableAdapterManager()
        Me.DsEliminarMatertialPrecioCompra = New ModuloGestion.DsEliminarMatertialPrecioCompra()
        Me.EliminarMaterialPreciosCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EliminarMaterialPreciosCompraTableAdapter = New ModuloGestion.DsEliminarMatertialPrecioCompraTableAdapters.EliminarMaterialPreciosCompraTableAdapter()
        Me.TableAdapterManager15 = New ModuloGestion.DsEliminarMatertialPrecioCompraTableAdapters.TableAdapterManager()
        Me.IdEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciosCompraProyectoTableAdapter = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter()
        Me.TableAdapterManager7 = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager()
        Me.IddetalleHerrajesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHerrajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadHerrajesDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion_Elemento_Herrajes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalle_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultaHerrajePresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.TxtIdEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtIdPresupuesto = New System.Windows.Forms.TextBox()
        Me.TxtIdProyecto = New System.Windows.Forms.TextBox()
        Me.CmdGenerles = New System.Windows.Forms.Button()
        Me.TxtEstado = New System.Windows.Forms.ComboBox()
        Me.CmdNuevoArticulo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CantidadView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precioview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRDview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalRdview = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnProduccion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EnPintura = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Enobra = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LblImpuesto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmdHerrajePintura = New System.Windows.Forms.Button()
        Me.BtnVerArticulo = New System.Windows.Forms.Button()
        Me.Carpeta_DatosTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtOrdenDeCompra = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Leyenda_PresupuestoTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EjecutadoTextBox = New System.Windows.Forms.TextBox()
        Me.GrbPresupuestodetalles = New System.Windows.Forms.GroupBox()
        Me.ItbisIncluidoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Precio_HoraTextBox = New System.Windows.Forms.TextBox()
        Me.Otros_GastosTextBox = New System.Windows.Forms.TextBox()
        Me.BeneficioTextBox = New System.Windows.Forms.TextBox()
        Me.Tarnsporte_EmbalajeTextBox = New System.Windows.Forms.TextBox()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.Gastos_IndierectosTextBox = New System.Windows.Forms.TextBox()
        Me.Gastos_ImprevistosTextBox = New System.Windows.Forms.TextBox()
        Me.DescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.OtrosTextBox = New System.Windows.Forms.TextBox()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.TotalPresupuestoUSTextBox = New System.Windows.Forms.TextBox()
        Me.ValorImpuestoUsTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalUSTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaComboBox = New System.Windows.Forms.ComboBox()
        Me.TotalPresupuestoRDTextBox = New System.Windows.Forms.TextBox()
        Me.ValorImpuestoRDTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalRDTextBox = New System.Windows.Forms.TextBox()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesDetalleTableAdapter()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager16 = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Id_empresaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        PlanosLabel = New System.Windows.Forms.Label()
        Leyenda_PresupuestoLabel = New System.Windows.Forms.Label()
        Descripcion_PresupuestoLabel = New System.Windows.Forms.Label()
        Id_PresupuestoLabel = New System.Windows.Forms.Label()
        Id_proyecto_PresupuestosLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        OtrosLabel = New System.Windows.Forms.Label()
        Tarnsporte_EmbalajeLabel = New System.Windows.Forms.Label()
        BeneficioLabel = New System.Windows.Forms.Label()
        Gastos_ImprevistosLabel = New System.Windows.Forms.Label()
        Gastos_IndierectosLabel = New System.Windows.Forms.Label()
        Otros_GastosLabel = New System.Windows.Forms.Label()
        Precio_HoraLabel = New System.Windows.Forms.Label()
        ItbisLabel = New System.Windows.Forms.Label()
        TasaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ItbisIncluidoLabel = New System.Windows.Forms.Label()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaHerrajePresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsultaHerrajesPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleElementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarHerrajeCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexarHerrajesCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarMaterialCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexarMaterialCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarPinturaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnrxarPinturaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PresupuestoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PresupuestoBindingNavigator.SuspendLayout()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarFerreteriaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexarFerreteriaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTotalFerreteriaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFerreteriaArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEliminarMatertialPrecioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EliminarMaterialPreciosCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaHerrajePresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GrbPresupuestodetalles.SuspendLayout()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_empresaLabel
        '
        Id_empresaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_empresaLabel.Location = New System.Drawing.Point(274, 28)
        Id_empresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_empresaLabel.Name = "Id_empresaLabel"
        Id_empresaLabel.Size = New System.Drawing.Size(100, 25)
        Id_empresaLabel.TabIndex = 98
        Id_empresaLabel.Text = "Id Empresa:"
        '
        'FechaLabel
        '
        FechaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        FechaLabel.Location = New System.Drawing.Point(20, 160)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(100, 25)
        FechaLabel.TabIndex = 96
        FechaLabel.Text = "Fecha:"
        '
        'PlanosLabel
        '
        PlanosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PlanosLabel.Location = New System.Drawing.Point(20, 124)
        PlanosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PlanosLabel.Name = "PlanosLabel"
        PlanosLabel.Size = New System.Drawing.Size(100, 25)
        PlanosLabel.TabIndex = 95
        PlanosLabel.Text = "Carpeta"
        '
        'Leyenda_PresupuestoLabel
        '
        Leyenda_PresupuestoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Leyenda_PresupuestoLabel.Location = New System.Drawing.Point(490, 28)
        Leyenda_PresupuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Leyenda_PresupuestoLabel.Name = "Leyenda_PresupuestoLabel"
        Leyenda_PresupuestoLabel.Size = New System.Drawing.Size(100, 25)
        Leyenda_PresupuestoLabel.TabIndex = 93
        Leyenda_PresupuestoLabel.Text = "Leyenda Presupuesto:"
        '
        'Descripcion_PresupuestoLabel
        '
        Descripcion_PresupuestoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Descripcion_PresupuestoLabel.Location = New System.Drawing.Point(20, 91)
        Descripcion_PresupuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Descripcion_PresupuestoLabel.Name = "Descripcion_PresupuestoLabel"
        Descripcion_PresupuestoLabel.Size = New System.Drawing.Size(100, 25)
        Descripcion_PresupuestoLabel.TabIndex = 90
        Descripcion_PresupuestoLabel.Text = "Descripcion Presupuesto:"
        '
        'Id_PresupuestoLabel
        '
        Id_PresupuestoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_PresupuestoLabel.Location = New System.Drawing.Point(20, 59)
        Id_PresupuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_PresupuestoLabel.Name = "Id_PresupuestoLabel"
        Id_PresupuestoLabel.Size = New System.Drawing.Size(100, 25)
        Id_PresupuestoLabel.TabIndex = 87
        Id_PresupuestoLabel.Text = "Id Presupuesto"
        '
        'Id_proyecto_PresupuestosLabel
        '
        Id_proyecto_PresupuestosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_proyecto_PresupuestosLabel.Location = New System.Drawing.Point(20, 26)
        Id_proyecto_PresupuestosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_proyecto_PresupuestosLabel.Name = "Id_proyecto_PresupuestosLabel"
        Id_proyecto_PresupuestosLabel.Size = New System.Drawing.Size(100, 25)
        Id_proyecto_PresupuestosLabel.TabIndex = 85
        Id_proyecto_PresupuestosLabel.Text = "Id proyecto "
        '
        'Label3
        '
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label3.Location = New System.Drawing.Point(155, 194)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(110, 25)
        Label3.TabIndex = 115
        Label3.Text = "Fecha: Entrega"
        '
        'Label4
        '
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label4.Location = New System.Drawing.Point(415, 195)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(132, 25)
        Label4.TabIndex = 117
        Label4.Text = "Orden De Compra"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(296, 64)
        MonedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(60, 16)
        MonedaLabel.TabIndex = 143
        MonedaLabel.Text = "Moneda:"
        '
        'Label8
        '
        Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label8.Location = New System.Drawing.Point(235, 166)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(128, 25)
        Label8.TabIndex = 77
        Label8.Text = "Descuento:"
        '
        'OtrosLabel
        '
        OtrosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        OtrosLabel.Location = New System.Drawing.Point(235, 201)
        OtrosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OtrosLabel.Name = "OtrosLabel"
        OtrosLabel.Size = New System.Drawing.Size(128, 25)
        OtrosLabel.TabIndex = 75
        OtrosLabel.Text = "Otros:"
        '
        'Tarnsporte_EmbalajeLabel
        '
        Tarnsporte_EmbalajeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Tarnsporte_EmbalajeLabel.Location = New System.Drawing.Point(31, 202)
        Tarnsporte_EmbalajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tarnsporte_EmbalajeLabel.Name = "Tarnsporte_EmbalajeLabel"
        Tarnsporte_EmbalajeLabel.Size = New System.Drawing.Size(94, 25)
        Tarnsporte_EmbalajeLabel.TabIndex = 73
        Tarnsporte_EmbalajeLabel.Text = "Tarnsporte Embalaje:"
        '
        'BeneficioLabel
        '
        BeneficioLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        BeneficioLabel.Location = New System.Drawing.Point(32, 168)
        BeneficioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BeneficioLabel.Name = "BeneficioLabel"
        BeneficioLabel.Size = New System.Drawing.Size(94, 25)
        BeneficioLabel.TabIndex = 71
        BeneficioLabel.Text = "Beneficio:"
        '
        'Gastos_ImprevistosLabel
        '
        Gastos_ImprevistosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Gastos_ImprevistosLabel.Location = New System.Drawing.Point(235, 131)
        Gastos_ImprevistosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Gastos_ImprevistosLabel.Name = "Gastos_ImprevistosLabel"
        Gastos_ImprevistosLabel.Size = New System.Drawing.Size(128, 25)
        Gastos_ImprevistosLabel.TabIndex = 69
        Gastos_ImprevistosLabel.Text = "Gastos Imprevistos:"
        '
        'Gastos_IndierectosLabel
        '
        Gastos_IndierectosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Gastos_IndierectosLabel.Location = New System.Drawing.Point(235, 96)
        Gastos_IndierectosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Gastos_IndierectosLabel.Name = "Gastos_IndierectosLabel"
        Gastos_IndierectosLabel.Size = New System.Drawing.Size(128, 25)
        Gastos_IndierectosLabel.TabIndex = 67
        Gastos_IndierectosLabel.Text = "Gastos Indirectos:"
        '
        'Otros_GastosLabel
        '
        Otros_GastosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Otros_GastosLabel.Location = New System.Drawing.Point(30, 131)
        Otros_GastosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Otros_GastosLabel.Name = "Otros_GastosLabel"
        Otros_GastosLabel.Size = New System.Drawing.Size(96, 25)
        Otros_GastosLabel.TabIndex = 65
        Otros_GastosLabel.Text = "Otros Gastos:"
        '
        'Precio_HoraLabel
        '
        Precio_HoraLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Precio_HoraLabel.Location = New System.Drawing.Point(32, 96)
        Precio_HoraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Precio_HoraLabel.Name = "Precio_HoraLabel"
        Precio_HoraLabel.Size = New System.Drawing.Size(94, 25)
        Precio_HoraLabel.TabIndex = 63
        Precio_HoraLabel.Text = "Precio Hora:"
        '
        'ItbisLabel
        '
        ItbisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ItbisLabel.Location = New System.Drawing.Point(32, 65)
        ItbisLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ItbisLabel.Name = "ItbisLabel"
        ItbisLabel.Size = New System.Drawing.Size(94, 25)
        ItbisLabel.TabIndex = 59
        ItbisLabel.Text = "Itbis:"
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        TasaLabel.Location = New System.Drawing.Point(235, 65)
        TasaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(44, 18)
        TasaLabel.TabIndex = 86
        TasaLabel.Text = "Tasa:"
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Location = New System.Drawing.Point(356, 162)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 25)
        Label1.TabIndex = 149
        Label1.Text = "Ejecutado:"
        '
        'ItbisIncluidoLabel
        '
        ItbisIncluidoLabel.AutoSize = True
        ItbisIncluidoLabel.Location = New System.Drawing.Point(244, 244)
        ItbisIncluidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ItbisIncluidoLabel.Name = "ItbisIncluidoLabel"
        ItbisIncluidoLabel.Size = New System.Drawing.Size(83, 16)
        ItbisIncluidoLabel.TabIndex = 98
        ItbisIncluidoLabel.Text = "Itbis Incluido:"
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
        'SubArticulosBindingSource
        '
        Me.SubArticulosBindingSource.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource.DataSource = Me.DsSubArticulos
        '
        'DsSubArticulos
        '
        Me.DsSubArticulos.DataSetName = "DsSubArticulos"
        Me.DsSubArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosDetalleBindingSource
        '
        Me.ArticulosDetalleBindingSource.DataMember = "ArticulosDetalle"
        Me.ArticulosDetalleBindingSource.DataSource = Me.DsArticulosdetalle
        '
        'DsArticulosdetalle
        '
        Me.DsArticulosdetalle.DataSetName = "DsArticulosdetalle"
        Me.DsArticulosdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreciosCompraProyectoBindingSource
        '
        Me.PreciosCompraProyectoBindingSource.DataMember = "PreciosCompraProyecto"
        Me.PreciosCompraProyectoBindingSource.DataSource = Me.DsPreciosCompraProyecto
        '
        'DsPreciosCompraProyecto
        '
        Me.DsPreciosCompraProyecto.DataSetName = "DsPreciosCompraProyecto"
        Me.DsPreciosCompraProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultaHerrajePresupuestoDetalleBindingSource
        '
        Me.ConsultaHerrajePresupuestoDetalleBindingSource.DataMember = "ConsultaHerrajePresupuestoDetalle"
        Me.ConsultaHerrajePresupuestoDetalleBindingSource.DataSource = Me.DsConsultaHerrajesPresupuestoDetalle
        '
        'DsConsultaHerrajesPresupuestoDetalle
        '
        Me.DsConsultaHerrajesPresupuestoDetalle.DataSetName = "DsConsultaHerrajesPresupuestoDetalle"
        Me.DsConsultaHerrajesPresupuestoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblPintura
        '
        Me.LblPintura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPintura.AutoSize = True
        Me.LblPintura.Location = New System.Drawing.Point(1310, 458)
        Me.LblPintura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPintura.Name = "LblPintura"
        Me.LblPintura.Size = New System.Drawing.Size(0, 16)
        Me.LblPintura.TabIndex = 110
        '
        'LblTipoPintura
        '
        Me.LblTipoPintura.AutoSize = True
        Me.LblTipoPintura.Location = New System.Drawing.Point(1109, -1)
        Me.LblTipoPintura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoPintura.Name = "LblTipoPintura"
        Me.LblTipoPintura.Size = New System.Drawing.Size(0, 16)
        Me.LblTipoPintura.TabIndex = 85
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
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'ArticulosDetalleTableAdapter
        '
        Me.ArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsSubArticulosDetalle
        '
        Me.DsSubArticulosDetalle.DataSetName = "DsSubArticulosDetalle"
        Me.DsSubArticulosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubArticulosDetalleBindingSource
        '
        Me.SubArticulosDetalleBindingSource.DataMember = "SubArticulosDetalle"
        Me.SubArticulosDetalleBindingSource.DataSource = Me.DsSubArticulosDetalle
        '
        'SubArticulosDetalleTableAdapter
        '
        Me.SubArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.SubArticulosDetalleTableAdapter = Me.SubArticulosDetalleTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetalleElementos
        '
        Me.DsPresupuestoDetalleElementos.DataSetName = "DsPresupuestoDetalleElementos"
        Me.DsPresupuestoDetalleElementos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleElementosBindingSource
        '
        Me.PresupuestoDetalleElementosBindingSource.DataMember = "PresupuestoDetalleElementos"
        Me.PresupuestoDetalleElementosBindingSource.DataSource = Me.DsPresupuestoDetalleElementos
        '
        'PresupuestoDetalleElementosTableAdapter
        '
        Me.PresupuestoDetalleElementosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.PresupuestoDetalleElementosTableAdapter = Me.PresupuestoDetalleElementosTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetallePintura
        '
        Me.DsPresupuestoDetallePintura.DataSetName = "DsPresupuestoDetallePintura"
        Me.DsPresupuestoDetallePintura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetallePinturaBindingSource
        '
        Me.PresupuestoDetallePinturaBindingSource.DataMember = "PresupuestoDetallePintura"
        Me.PresupuestoDetallePinturaBindingSource.DataSource = Me.DsPresupuestoDetallePintura
        '
        'PresupuestoDetallePinturaTableAdapter
        '
        Me.PresupuestoDetallePinturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.PresupuestoDetallePinturaTableAdapter = Me.PresupuestoDetallePinturaTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleHerrajesTableAdapter
        '
        Me.PresupuestoDetalleHerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.PresupuestoDetalleHerrajesTableAdapter = Me.PresupuestoDetalleHerrajesTableAdapter
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'HerrajesTableAdapter
        '
        Me.HerrajesTableAdapter.ClearBeforeFill = True
        '
        'ConsultaHerrajePresupuestoDetalleTableAdapter
        '
        Me.ConsultaHerrajePresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager8
        '
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager8.Connection = Nothing
        Me.TableAdapterManager8.UpdateOrder = ModuloGestion.DsConsultaHerrajesPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsAnexarHerrajeCompra
        '
        Me.DsAnexarHerrajeCompra.DataSetName = "DsAnexarHerrajeCompra"
        Me.DsAnexarHerrajeCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexarHerrajesCompraBindingSource
        '
        Me.AnexarHerrajesCompraBindingSource.DataMember = "AnexarHerrajesCompra"
        Me.AnexarHerrajesCompraBindingSource.DataSource = Me.DsAnexarHerrajeCompra
        '
        'AnexarHerrajesCompraTableAdapter
        '
        Me.AnexarHerrajesCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager9
        '
        Me.TableAdapterManager9.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager9.Connection = Nothing
        Me.TableAdapterManager9.UpdateOrder = ModuloGestion.DsAnexarHerrajeCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsAnexarMaterialCompra
        '
        Me.DsAnexarMaterialCompra.DataSetName = "DsAnexarMaterialCompra"
        Me.DsAnexarMaterialCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexarMaterialCompraBindingSource
        '
        Me.AnexarMaterialCompraBindingSource.DataMember = "AnexarMaterialCompra"
        Me.AnexarMaterialCompraBindingSource.DataSource = Me.DsAnexarMaterialCompra
        '
        'AnexarMaterialCompraTableAdapter
        '
        Me.AnexarMaterialCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager10
        '
        Me.TableAdapterManager10.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager10.Connection = Nothing
        Me.TableAdapterManager10.UpdateOrder = ModuloGestion.DsAnexarMaterialCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsAnexarPinturaCompra
        '
        Me.DsAnexarPinturaCompra.DataSetName = "DsAnexarPinturaCompra"
        Me.DsAnexarPinturaCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnrxarPinturaCompraBindingSource
        '
        Me.AnrxarPinturaCompraBindingSource.DataMember = "AnrxarPinturaCompra"
        Me.AnrxarPinturaCompraBindingSource.DataSource = Me.DsAnexarPinturaCompra
        '
        'AnrxarPinturaCompraTableAdapter
        '
        Me.AnrxarPinturaCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager11
        '
        Me.TableAdapterManager11.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager11.Connection = Nothing
        Me.TableAdapterManager11.UpdateOrder = ModuloGestion.DsAnexarPinturaCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnNotaEntrega
        '
        Me.BtnNotaEntrega.Location = New System.Drawing.Point(8, 144)
        Me.BtnNotaEntrega.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNotaEntrega.Name = "BtnNotaEntrega"
        Me.BtnNotaEntrega.Size = New System.Drawing.Size(169, 29)
        Me.BtnNotaEntrega.TabIndex = 134
        Me.BtnNotaEntrega.Text = "Nota Entrega"
        Me.BtnNotaEntrega.UseVisualStyleBackColor = True
        '
        'BtnCambioProyecto
        '
        Me.BtnCambioProyecto.Location = New System.Drawing.Point(188, 60)
        Me.BtnCambioProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCambioProyecto.Name = "BtnCambioProyecto"
        Me.BtnCambioProyecto.Size = New System.Drawing.Size(169, 29)
        Me.BtnCambioProyecto.TabIndex = 133
        Me.BtnCambioProyecto.Text = "Cambio Proyecto"
        Me.BtnCambioProyecto.UseVisualStyleBackColor = True
        '
        'LblEtiqueta
        '
        Me.LblEtiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEtiqueta.AutoSize = True
        Me.LblEtiqueta.Location = New System.Drawing.Point(1275, 505)
        Me.LblEtiqueta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEtiqueta.Name = "LblEtiqueta"
        Me.LblEtiqueta.Size = New System.Drawing.Size(143, 16)
        Me.LblEtiqueta.TabIndex = 132
        Me.LblEtiqueta.Text = "HERRAJES DETALLE"
        '
        'BtnPreciosArticulo
        '
        Me.BtnPreciosArticulo.Location = New System.Drawing.Point(11, 96)
        Me.BtnPreciosArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPreciosArticulo.Name = "BtnPreciosArticulo"
        Me.BtnPreciosArticulo.Size = New System.Drawing.Size(169, 29)
        Me.BtnPreciosArticulo.TabIndex = 121
        Me.BtnPreciosArticulo.Text = "Estudio Precios Articulos"
        Me.BtnPreciosArticulo.UseVisualStyleBackColor = True
        '
        'BtnAnexarPrecios
        '
        Me.BtnAnexarPrecios.Location = New System.Drawing.Point(11, 60)
        Me.BtnAnexarPrecios.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAnexarPrecios.Name = "BtnAnexarPrecios"
        Me.BtnAnexarPrecios.Size = New System.Drawing.Size(169, 29)
        Me.BtnAnexarPrecios.TabIndex = 120
        Me.BtnAnexarPrecios.Text = "Anexar Precios"
        Me.BtnAnexarPrecios.UseVisualStyleBackColor = True
        '
        'BtnImprimirProforma
        '
        Me.BtnImprimirProforma.Location = New System.Drawing.Point(182, 179)
        Me.BtnImprimirProforma.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImprimirProforma.Name = "BtnImprimirProforma"
        Me.BtnImprimirProforma.Size = New System.Drawing.Size(169, 29)
        Me.BtnImprimirProforma.TabIndex = 123
        Me.BtnImprimirProforma.Text = "Imprimir Proforma"
        Me.BtnImprimirProforma.UseVisualStyleBackColor = True
        '
        'BtnActualizarConsumos1
        '
        Me.BtnActualizarConsumos1.Location = New System.Drawing.Point(10, 24)
        Me.BtnActualizarConsumos1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizarConsumos1.Name = "BtnActualizarConsumos1"
        Me.BtnActualizarConsumos1.Size = New System.Drawing.Size(168, 29)
        Me.BtnActualizarConsumos1.TabIndex = 126
        Me.BtnActualizarConsumos1.Text = "Acualizar Consumos"
        Me.BtnActualizarConsumos1.UseVisualStyleBackColor = True
        '
        'BtnSoloConsumos
        '
        Me.BtnSoloConsumos.Location = New System.Drawing.Point(8, 105)
        Me.BtnSoloConsumos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSoloConsumos.Name = "BtnSoloConsumos"
        Me.BtnSoloConsumos.Size = New System.Drawing.Size(169, 29)
        Me.BtnSoloConsumos.TabIndex = 122
        Me.BtnSoloConsumos.TabStop = False
        Me.BtnSoloConsumos.Text = "Solo Consumos"
        Me.BtnSoloConsumos.UseVisualStyleBackColor = True
        '
        'BtnDuplicarPresupuesto
        '
        Me.BtnDuplicarPresupuesto.Location = New System.Drawing.Point(189, 24)
        Me.BtnDuplicarPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDuplicarPresupuesto.Name = "BtnDuplicarPresupuesto"
        Me.BtnDuplicarPresupuesto.Size = New System.Drawing.Size(168, 29)
        Me.BtnDuplicarPresupuesto.TabIndex = 129
        Me.BtnDuplicarPresupuesto.Text = "DuplicarPresupuesto"
        Me.BtnDuplicarPresupuesto.UseVisualStyleBackColor = True
        '
        'BtnImprimirPresupuesto
        '
        Me.BtnImprimirPresupuesto.Location = New System.Drawing.Point(9, 180)
        Me.BtnImprimirPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImprimirPresupuesto.Name = "BtnImprimirPresupuesto"
        Me.BtnImprimirPresupuesto.Size = New System.Drawing.Size(169, 29)
        Me.BtnImprimirPresupuesto.TabIndex = 118
        Me.BtnImprimirPresupuesto.Text = "Imprimir Presupuesto"
        Me.BtnImprimirPresupuesto.UseVisualStyleBackColor = True
        '
        'Btnimprimirarticulos
        '
        Me.Btnimprimirarticulos.Location = New System.Drawing.Point(184, 142)
        Me.Btnimprimirarticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnimprimirarticulos.Name = "Btnimprimirarticulos"
        Me.Btnimprimirarticulos.Size = New System.Drawing.Size(169, 29)
        Me.Btnimprimirarticulos.TabIndex = 119
        Me.Btnimprimirarticulos.Text = "Imprimir Articulos"
        Me.Btnimprimirarticulos.UseVisualStyleBackColor = True
        '
        'BtnKitArticulos
        '
        Me.BtnKitArticulos.Location = New System.Drawing.Point(184, 105)
        Me.BtnKitArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnKitArticulos.Name = "BtnKitArticulos"
        Me.BtnKitArticulos.Size = New System.Drawing.Size(169, 29)
        Me.BtnKitArticulos.TabIndex = 130
        Me.BtnKitArticulos.Text = "Kit Articulos"
        Me.BtnKitArticulos.UseVisualStyleBackColor = True
        '
        'BtnConsumoPresupuesto
        '
        Me.BtnConsumoPresupuesto.Location = New System.Drawing.Point(8, 69)
        Me.BtnConsumoPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnConsumoPresupuesto.Name = "BtnConsumoPresupuesto"
        Me.BtnConsumoPresupuesto.Size = New System.Drawing.Size(169, 29)
        Me.BtnConsumoPresupuesto.TabIndex = 125
        Me.BtnConsumoPresupuesto.Text = "Consumos Presupuesto"
        Me.BtnConsumoPresupuesto.UseVisualStyleBackColor = True
        '
        'BtnAnalisisPresupuesto
        '
        Me.BtnAnalisisPresupuesto.Location = New System.Drawing.Point(8, 32)
        Me.BtnAnalisisPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAnalisisPresupuesto.Name = "BtnAnalisisPresupuesto"
        Me.BtnAnalisisPresupuesto.Size = New System.Drawing.Size(169, 29)
        Me.BtnAnalisisPresupuesto.TabIndex = 127
        Me.BtnAnalisisPresupuesto.Text = "Analisis Presupuesto"
        Me.BtnAnalisisPresupuesto.UseVisualStyleBackColor = True
        '
        'BtnCostoArticulos
        '
        Me.BtnCostoArticulos.Location = New System.Drawing.Point(184, 32)
        Me.BtnCostoArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCostoArticulos.Name = "BtnCostoArticulos"
        Me.BtnCostoArticulos.Size = New System.Drawing.Size(169, 29)
        Me.BtnCostoArticulos.TabIndex = 124
        Me.BtnCostoArticulos.Text = "Costos Articulos Detalle"
        Me.BtnCostoArticulos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BtnPinturaPresupuesto)
        Me.GroupBox2.Controls.Add(Me.BtnAnalisisPresupuesto)
        Me.GroupBox2.Controls.Add(Me.BtnNotaEntrega)
        Me.GroupBox2.Controls.Add(Me.BtnConsumoPresupuesto)
        Me.GroupBox2.Controls.Add(Me.BtnCostoArticulos)
        Me.GroupBox2.Controls.Add(Me.BtnSoloConsumos)
        Me.GroupBox2.Controls.Add(Me.BtnKitArticulos)
        Me.GroupBox2.Controls.Add(Me.Btnimprimirarticulos)
        Me.GroupBox2.Controls.Add(Me.BtnImprimirPresupuesto)
        Me.GroupBox2.Controls.Add(Me.BtnImprimirProforma)
        Me.GroupBox2.Location = New System.Drawing.Point(1302, 38)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(375, 225)
        Me.GroupBox2.TabIndex = 135
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes"
        '
        'BtnPinturaPresupuesto
        '
        Me.BtnPinturaPresupuesto.Location = New System.Drawing.Point(188, 69)
        Me.BtnPinturaPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPinturaPresupuesto.Name = "BtnPinturaPresupuesto"
        Me.BtnPinturaPresupuesto.Size = New System.Drawing.Size(164, 29)
        Me.BtnPinturaPresupuesto.TabIndex = 141
        Me.BtnPinturaPresupuesto.Text = "Pintura Presupuesto"
        Me.BtnPinturaPresupuesto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BtnDocumentacion)
        Me.GroupBox3.Controls.Add(Me.BtnActualizarConsumos1)
        Me.GroupBox3.Controls.Add(Me.BtnAnexarPrecios)
        Me.GroupBox3.Controls.Add(Me.BtnPreciosArticulo)
        Me.GroupBox3.Controls.Add(Me.BtnCambioProyecto)
        Me.GroupBox3.Controls.Add(Me.BtnDuplicarPresupuesto)
        Me.GroupBox3.Location = New System.Drawing.Point(1302, 294)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(375, 134)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'BtnDocumentacion
        '
        Me.BtnDocumentacion.Location = New System.Drawing.Point(188, 96)
        Me.BtnDocumentacion.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDocumentacion.Name = "BtnDocumentacion"
        Me.BtnDocumentacion.Size = New System.Drawing.Size(169, 29)
        Me.BtnDocumentacion.TabIndex = 134
        Me.BtnDocumentacion.Text = "Documentacion"
        Me.BtnDocumentacion.UseVisualStyleBackColor = True
        '
        'PresupuestoBindingNavigator
        '
        Me.PresupuestoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PresupuestoBindingNavigator.BindingSource = Me.PresupuestoBindingSource
        Me.PresupuestoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PresupuestoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PresupuestoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PresupuestoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PresupuestoBindingNavigatorSaveItem})
        Me.PresupuestoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PresupuestoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PresupuestoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PresupuestoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PresupuestoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PresupuestoBindingNavigator.Name = "PresupuestoBindingNavigator"
        Me.PresupuestoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PresupuestoBindingNavigator.Size = New System.Drawing.Size(1692, 27)
        Me.PresupuestoBindingNavigator.TabIndex = 137
        Me.PresupuestoBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(62, 27)
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
        'PresupuestoBindingNavigatorSaveItem
        '
        Me.PresupuestoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PresupuestoBindingNavigatorSaveItem.Image = CType(resources.GetObject("PresupuestoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PresupuestoBindingNavigatorSaveItem.Name = "PresupuestoBindingNavigatorSaveItem"
        Me.PresupuestoBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PresupuestoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'LblTipoPinturaPresupuestada
        '
        Me.LblTipoPinturaPresupuestada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTipoPinturaPresupuestada.AutoSize = True
        Me.LblTipoPinturaPresupuestada.Location = New System.Drawing.Point(1310, 435)
        Me.LblTipoPinturaPresupuestada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoPinturaPresupuestada.Name = "LblTipoPinturaPresupuestada"
        Me.LblTipoPinturaPresupuestada.Size = New System.Drawing.Size(109, 16)
        Me.LblTipoPinturaPresupuestada.TabIndex = 139
        Me.LblTipoPinturaPresupuestada.Text = "Pintura Asignada"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1335, 270)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'cmdDuplicarHerraje
        '
        Me.cmdDuplicarHerraje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDuplicarHerraje.Location = New System.Drawing.Point(1539, 499)
        Me.cmdDuplicarHerraje.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDuplicarHerraje.Name = "cmdDuplicarHerraje"
        Me.cmdDuplicarHerraje.Size = New System.Drawing.Size(130, 29)
        Me.cmdDuplicarHerraje.TabIndex = 141
        Me.cmdDuplicarHerraje.Text = "Duplicar Herraje"
        Me.cmdDuplicarHerraje.UseVisualStyleBackColor = True
        '
        'LblRegistroADuplicar
        '
        Me.LblRegistroADuplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRegistroADuplicar.AutoSize = True
        Me.LblRegistroADuplicar.Location = New System.Drawing.Point(1335, 544)
        Me.LblRegistroADuplicar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRegistroADuplicar.Name = "LblRegistroADuplicar"
        Me.LblRegistroADuplicar.Size = New System.Drawing.Size(0, 16)
        Me.LblRegistroADuplicar.TabIndex = 142
        Me.LblRegistroADuplicar.Visible = False
        '
        'lblDesdeelregistro
        '
        Me.lblDesdeelregistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDesdeelregistro.AutoSize = True
        Me.lblDesdeelregistro.Location = New System.Drawing.Point(1535, 544)
        Me.lblDesdeelregistro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesdeelregistro.Name = "lblDesdeelregistro"
        Me.lblDesdeelregistro.Size = New System.Drawing.Size(0, 16)
        Me.lblDesdeelregistro.TabIndex = 143
        Me.lblDesdeelregistro.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1270, 544)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Duplicar"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1488, 544)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Desde"
        Me.Label9.Visible = False
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'DsAnexarFerreteriaCompra
        '
        Me.DsAnexarFerreteriaCompra.DataSetName = "DsAnexarFerreteriaCompra"
        Me.DsAnexarFerreteriaCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexarFerreteriaCompraBindingSource
        '
        Me.AnexarFerreteriaCompraBindingSource.DataMember = "AnexarFerreteriaCompra"
        Me.AnexarFerreteriaCompraBindingSource.DataSource = Me.DsAnexarFerreteriaCompra
        '
        'AnexarFerreteriaCompraTableAdapter
        '
        Me.AnexarFerreteriaCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager12
        '
        Me.TableAdapterManager12.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager12.Connection = Nothing
        Me.TableAdapterManager12.UpdateOrder = ModuloGestion.DsAnexarFerreteriaCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager13
        '
        Me.TableAdapterManager13.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager13.PresupuestoDetalleFerreteriaTableAdapter = Me.PresupuestoDetalleFerreteriaTableAdapter
        Me.TableAdapterManager13.UpdateOrder = ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsTotalFerreteriaArticulo
        '
        Me.DsTotalFerreteriaArticulo.DataSetName = "DsTotalFerreteriaArticulo"
        Me.DsTotalFerreteriaArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalFerreteriaArticuloBindingSource
        '
        Me.TotalFerreteriaArticuloBindingSource.DataMember = "TotalFerreteriaArticulo"
        Me.TotalFerreteriaArticuloBindingSource.DataSource = Me.DsTotalFerreteriaArticulo
        '
        'TotalFerreteriaArticuloTableAdapter
        '
        Me.TotalFerreteriaArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager14
        '
        Me.TableAdapterManager14.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager14.Connection = Nothing
        Me.TableAdapterManager14.UpdateOrder = ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsEliminarMatertialPrecioCompra
        '
        Me.DsEliminarMatertialPrecioCompra.DataSetName = "DsEliminarMatertialPrecioCompra"
        Me.DsEliminarMatertialPrecioCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EliminarMaterialPreciosCompraBindingSource
        '
        Me.EliminarMaterialPreciosCompraBindingSource.DataMember = "EliminarMaterialPreciosCompra"
        Me.EliminarMaterialPreciosCompraBindingSource.DataSource = Me.DsEliminarMatertialPrecioCompra
        '
        'EliminarMaterialPreciosCompraTableAdapter
        '
        Me.EliminarMaterialPreciosCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager15
        '
        Me.TableAdapterManager15.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager15.Connection = Nothing
        Me.TableAdapterManager15.UpdateOrder = ModuloGestion.DsEliminarMatertialPrecioCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdEmpresaDataGridViewTextBoxColumn
        '
        Me.IdEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Id_Empresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.HeaderText = "Id_Empresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpresaDataGridViewTextBoxColumn.Name = "IdEmpresaDataGridViewTextBoxColumn"
        Me.IdEmpresaDataGridViewTextBoxColumn.Width = 125
        '
        'PreciosCompraProyectoTableAdapter
        '
        Me.PreciosCompraProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.PreciosCompraProyectoTableAdapter = Me.PreciosCompraProyectoTableAdapter
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IddetalleHerrajesDataGridViewTextBoxColumn
        '
        Me.IddetalleHerrajesDataGridViewTextBoxColumn.DataPropertyName = "Id_detalle_Herrajes"
        Me.IddetalleHerrajesDataGridViewTextBoxColumn.HeaderText = "Id_detalle_Herrajes"
        Me.IddetalleHerrajesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IddetalleHerrajesDataGridViewTextBoxColumn.Name = "IddetalleHerrajesDataGridViewTextBoxColumn"
        Me.IddetalleHerrajesDataGridViewTextBoxColumn.Visible = False
        Me.IddetalleHerrajesDataGridViewTextBoxColumn.Width = 125
        '
        'IdHerrajeDataGridViewTextBoxColumn
        '
        Me.IdHerrajeDataGridViewTextBoxColumn.DataPropertyName = "Id_Herraje"
        Me.IdHerrajeDataGridViewTextBoxColumn.HeaderText = "Id_Herraje"
        Me.IdHerrajeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdHerrajeDataGridViewTextBoxColumn.Name = "IdHerrajeDataGridViewTextBoxColumn"
        Me.IdHerrajeDataGridViewTextBoxColumn.Visible = False
        Me.IdHerrajeDataGridViewTextBoxColumn.Width = 125
        '
        'IdDetallePresupuestoDataGridViewTextBoxColumn
        '
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn.DataPropertyName = "IdDetalle_Presupuesto"
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn.HeaderText = "IdDetalle_Presupuesto"
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn.Name = "IdDetallePresupuestoDataGridViewTextBoxColumn"
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn.Visible = False
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'CantidadHerrajesDetalle
        '
        Me.CantidadHerrajesDetalle.DataPropertyName = "CantidadHerrajesDetalle"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.CantidadHerrajesDetalle.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadHerrajesDetalle.HeaderText = "Cantidad"
        Me.CantidadHerrajesDetalle.MinimumWidth = 6
        Me.CantidadHerrajesDetalle.Name = "CantidadHerrajesDetalle"
        Me.CantidadHerrajesDetalle.Width = 75
        '
        'Descripcion_Elemento_Herrajes
        '
        Me.Descripcion_Elemento_Herrajes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion_Elemento_Herrajes.DataPropertyName = "Descripcion_Elemento_Herrajes"
        Me.Descripcion_Elemento_Herrajes.HeaderText = "Descripcion"
        Me.Descripcion_Elemento_Herrajes.MinimumWidth = 6
        Me.Descripcion_Elemento_Herrajes.Name = "Descripcion_Elemento_Herrajes"
        '
        'IdDetalle_Presupuesto
        '
        Me.IdDetalle_Presupuesto.DataPropertyName = "IdDetalle_Presupuesto"
        Me.IdDetalle_Presupuesto.HeaderText = "IdDetalle_Presupuesto"
        Me.IdDetalle_Presupuesto.MinimumWidth = 6
        Me.IdDetalle_Presupuesto.Name = "IdDetalle_Presupuesto"
        Me.IdDetalle_Presupuesto.Visible = False
        Me.IdDetalle_Presupuesto.Width = 125
        '
        'ConsultaHerrajePresupuestoDetalleDataGridView
        '
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalle_Presupuesto, Me.Descripcion_Elemento_Herrajes, Me.CantidadHerrajesDetalle, Me.IdDetallePresupuestoDataGridViewTextBoxColumn, Me.IdHerrajeDataGridViewTextBoxColumn, Me.IddetalleHerrajesDataGridViewTextBoxColumn})
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.DataSource = Me.ConsultaHerrajePresupuestoDetalleBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.Location = New System.Drawing.Point(1266, 576)
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.Name = "ConsultaHerrajePresupuestoDetalleDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.Size = New System.Drawing.Size(411, 184)
        Me.ConsultaHerrajePresupuestoDetalleDataGridView.TabIndex = 131
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Presupuesto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TxtIdEmpresa
        '
        Me.TxtIdEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Id_empresa", True))
        Me.TxtIdEmpresa.Enabled = False
        Me.TxtIdEmpresa.Location = New System.Drawing.Point(381, 28)
        Me.TxtIdEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdEmpresa.Name = "TxtIdEmpresa"
        Me.TxtIdEmpresa.Size = New System.Drawing.Size(76, 22)
        Me.TxtIdEmpresa.TabIndex = 99
        '
        'TxtFecha
        '
        Me.TxtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PresupuestoBindingSource, "Fecha", True))
        Me.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecha.Location = New System.Drawing.Point(125, 162)
        Me.TxtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(122, 22)
        Me.TxtFecha.TabIndex = 97
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Descripcion_Presupuesto", True))
        Me.TxtDescripcion.Location = New System.Drawing.Point(169, 92)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(420, 22)
        Me.TxtDescripcion.TabIndex = 92
        '
        'TxtIdPresupuesto
        '
        Me.TxtIdPresupuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Id_Presupuesto", True))
        Me.TxtIdPresupuesto.Enabled = False
        Me.TxtIdPresupuesto.Location = New System.Drawing.Point(169, 60)
        Me.TxtIdPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPresupuesto.Name = "TxtIdPresupuesto"
        Me.TxtIdPresupuesto.Size = New System.Drawing.Size(119, 22)
        Me.TxtIdPresupuesto.TabIndex = 88
        '
        'TxtIdProyecto
        '
        Me.TxtIdProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Id_proyecto_Presupuestos", True))
        Me.TxtIdProyecto.Enabled = False
        Me.TxtIdProyecto.Location = New System.Drawing.Point(169, 28)
        Me.TxtIdProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdProyecto.Name = "TxtIdProyecto"
        Me.TxtIdProyecto.Size = New System.Drawing.Size(96, 22)
        Me.TxtIdProyecto.TabIndex = 86
        '
        'CmdGenerles
        '
        Me.CmdGenerles.Location = New System.Drawing.Point(255, 160)
        Me.CmdGenerles.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdGenerles.Name = "CmdGenerles"
        Me.CmdGenerles.Size = New System.Drawing.Size(94, 29)
        Me.CmdGenerles.TabIndex = 91
        Me.CmdGenerles.Text = "Generales"
        Me.CmdGenerles.UseVisualStyleBackColor = True
        '
        'TxtEstado
        '
        Me.TxtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Estado_Presupuesto", True))
        Me.TxtEstado.FormattingEnabled = True
        Me.TxtEstado.Items.AddRange(New Object() {"Pendiente", "Aprobado", "Entregado", "Cerrado", "Rechazado", "Inpago"})
        Me.TxtEstado.Location = New System.Drawing.Point(451, 60)
        Me.TxtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(138, 24)
        Me.TxtEstado.TabIndex = 100
        '
        'CmdNuevoArticulo
        '
        Me.CmdNuevoArticulo.Location = New System.Drawing.Point(20, 191)
        Me.CmdNuevoArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNuevoArticulo.Name = "CmdNuevoArticulo"
        Me.CmdNuevoArticulo.Size = New System.Drawing.Size(128, 29)
        Me.CmdNuevoArticulo.TabIndex = 89
        Me.CmdNuevoArticulo.Text = "Nuevo Articulo"
        Me.CmdNuevoArticulo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(128, 124)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 102
        Me.Button1.TabStop = False
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresupuestoDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetallePresupuestoDataGridViewTextBoxColumn1, Me.ArticuloDataGridViewTextBoxColumn, Me.Column1, Me.CantidadView, Me.Precioview, Me.totalview, Me.PrecioRDview, Me.totalRdview, Me.EnProduccion, Me.EnPintura, Me.Enobra})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PresupuestoDetalleDataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(20, 226)
        Me.PresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresupuestoDetalleDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(1196, 541)
        Me.PresupuestoDetalleDataGridView.TabIndex = 102
        '
        'IdDetallePresupuestoDataGridViewTextBoxColumn1
        '
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1.DataPropertyName = "IdDetalle_Presupuesto"
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1.HeaderText = "Id Detalle"
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1.Name = "IdDetallePresupuestoDataGridViewTextBoxColumn1"
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDetallePresupuestoDataGridViewTextBoxColumn1.Width = 85
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "Articulo"
        Me.ArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.Width = 75
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Articulo"
        Me.Column1.DataSource = Me.ArticulosBindingSource
        Me.Column1.DisplayMember = "Descripcion_articulo"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Descripcion"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.ValueMember = "IdArticulo"
        '
        'CantidadView
        '
        Me.CantidadView.DataPropertyName = "Cantidad"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n3"
        Me.CantidadView.DefaultCellStyle = DataGridViewCellStyle6
        Me.CantidadView.HeaderText = "Cantidad"
        Me.CantidadView.MinimumWidth = 6
        Me.CantidadView.Name = "CantidadView"
        Me.CantidadView.Width = 75
        '
        'Precioview
        '
        Me.Precioview.DataPropertyName = "Precio_Ajustado"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.Precioview.DefaultCellStyle = DataGridViewCellStyle7
        Me.Precioview.HeaderText = "Precio"
        Me.Precioview.MinimumWidth = 6
        Me.Precioview.Name = "Precioview"
        Me.Precioview.Width = 75
        '
        'totalview
        '
        Me.totalview.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.totalview.DefaultCellStyle = DataGridViewCellStyle8
        Me.totalview.HeaderText = "Total"
        Me.totalview.MinimumWidth = 6
        Me.totalview.Name = "totalview"
        Me.totalview.ReadOnly = True
        Me.totalview.Width = 80
        '
        'PrecioRDview
        '
        Me.PrecioRDview.DataPropertyName = "Precio_AjustadoRD$"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.PrecioRDview.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrecioRDview.HeaderText = "Precio RD$"
        Me.PrecioRDview.MinimumWidth = 6
        Me.PrecioRDview.Name = "PrecioRDview"
        Me.PrecioRDview.Width = 75
        '
        'totalRdview
        '
        Me.totalRdview.DataPropertyName = "TotalPartidaRD$"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.totalRdview.DefaultCellStyle = DataGridViewCellStyle10
        Me.totalRdview.HeaderText = "Total RD$"
        Me.totalRdview.MinimumWidth = 6
        Me.totalRdview.Name = "totalRdview"
        Me.totalRdview.ReadOnly = True
        Me.totalRdview.Width = 80
        '
        'EnProduccion
        '
        Me.EnProduccion.DataPropertyName = "EnProduccion"
        Me.EnProduccion.HeaderText = "T"
        Me.EnProduccion.MinimumWidth = 6
        Me.EnProduccion.Name = "EnProduccion"
        Me.EnProduccion.Width = 25
        '
        'EnPintura
        '
        Me.EnPintura.DataPropertyName = "EnPintura"
        Me.EnPintura.HeaderText = "P"
        Me.EnPintura.MinimumWidth = 25
        Me.EnPintura.Name = "EnPintura"
        Me.EnPintura.Width = 25
        '
        'Enobra
        '
        Me.Enobra.DataPropertyName = "Enobra"
        Me.Enobra.HeaderText = "O"
        Me.Enobra.MinimumWidth = 6
        Me.Enobra.Name = "Enobra"
        Me.Enobra.Width = 25
        '
        'LblImpuesto
        '
        Me.LblImpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImpuesto.Location = New System.Drawing.Point(705, 806)
        Me.LblImpuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblImpuesto.Name = "LblImpuesto"
        Me.LblImpuesto.Size = New System.Drawing.Size(125, 25)
        Me.LblImpuesto.TabIndex = 103
        Me.LblImpuesto.Text = "Impuesto"
        Me.LblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(705, 774)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "SubTotal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(705, 842)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdHerrajePintura
        '
        Me.CmdHerrajePintura.Location = New System.Drawing.Point(881, 189)
        Me.CmdHerrajePintura.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdHerrajePintura.Name = "CmdHerrajePintura"
        Me.CmdHerrajePintura.Size = New System.Drawing.Size(164, 29)
        Me.CmdHerrajePintura.TabIndex = 87
        Me.CmdHerrajePintura.Text = "Ingreso Herraje/Pintura"
        Me.CmdHerrajePintura.UseVisualStyleBackColor = True
        '
        'BtnVerArticulo
        '
        Me.BtnVerArticulo.Location = New System.Drawing.Point(705, 192)
        Me.BtnVerArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerArticulo.Name = "BtnVerArticulo"
        Me.BtnVerArticulo.Size = New System.Drawing.Size(142, 29)
        Me.BtnVerArticulo.TabIndex = 88
        Me.BtnVerArticulo.Text = "Ver Articulo"
        Me.BtnVerArticulo.UseVisualStyleBackColor = True
        '
        'Carpeta_DatosTextBox
        '
        Me.Carpeta_DatosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Carpeta_Datos", True))
        Me.Carpeta_DatosTextBox.Enabled = False
        Me.Carpeta_DatosTextBox.Location = New System.Drawing.Point(174, 128)
        Me.Carpeta_DatosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Carpeta_DatosTextBox.Name = "Carpeta_DatosTextBox"
        Me.Carpeta_DatosTextBox.Size = New System.Drawing.Size(415, 22)
        Me.Carpeta_DatosTextBox.TabIndex = 111
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PresupuestoBindingSource, "FechaEntrega", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(272, 194)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 22)
        Me.DateTimePicker1.TabIndex = 116
        '
        'TxtOrdenDeCompra
        '
        Me.TxtOrdenDeCompra.AcceptsReturn = True
        Me.TxtOrdenDeCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "OrdenDeCompra", True))
        Me.TxtOrdenDeCompra.Location = New System.Drawing.Point(551, 195)
        Me.TxtOrdenDeCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOrdenDeCompra.Name = "TxtOrdenDeCompra"
        Me.TxtOrdenDeCompra.Size = New System.Drawing.Size(143, 22)
        Me.TxtOrdenDeCompra.TabIndex = 117
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(116, 828)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(0, 16)
        Me.LblDescripcion.TabIndex = 118
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Leyenda_PresupuestoTextBox)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.EjecutadoTextBox)
        Me.GroupBox1.Controls.Add(Me.GrbPresupuestodetalles)
        Me.GroupBox1.Controls.Add(Me.TotalPresupuestoUSTextBox)
        Me.GroupBox1.Controls.Add(Me.ValorImpuestoUsTextBox)
        Me.GroupBox1.Controls.Add(Me.SubTotalUSTextBox)
        Me.GroupBox1.Controls.Add(Me.MonedaComboBox)
        Me.GroupBox1.Controls.Add(MonedaLabel)
        Me.GroupBox1.Controls.Add(Me.TotalPresupuestoRDTextBox)
        Me.GroupBox1.Controls.Add(Me.ValorImpuestoRDTextBox)
        Me.GroupBox1.Controls.Add(Me.SubTotalRDTextBox)
        Me.GroupBox1.Controls.Add(Me.LblDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxtOrdenDeCompra)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.Carpeta_DatosTextBox)
        Me.GroupBox1.Controls.Add(Me.BtnVerArticulo)
        Me.GroupBox1.Controls.Add(Me.CmdHerrajePintura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblImpuesto)
        Me.GroupBox1.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CmdNuevoArticulo)
        Me.GroupBox1.Controls.Add(Me.TxtEstado)
        Me.GroupBox1.Controls.Add(Me.CmdGenerles)
        Me.GroupBox1.Controls.Add(Id_proyecto_PresupuestosLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdProyecto)
        Me.GroupBox1.Controls.Add(Id_PresupuestoLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdPresupuesto)
        Me.GroupBox1.Controls.Add(Descripcion_PresupuestoLabel)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Leyenda_PresupuestoLabel)
        Me.GroupBox1.Controls.Add(PlanosLabel)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Me.TxtFecha)
        Me.GroupBox1.Controls.Add(Id_empresaLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 38)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1265, 888)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Leyenda_PresupuestoTextBox
        '
        Me.Leyenda_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Leyenda_Presupuesto", True))
        Me.Leyenda_PresupuestoTextBox.Location = New System.Drawing.Point(598, 23)
        Me.Leyenda_PresupuestoTextBox.Name = "Leyenda_PresupuestoTextBox"
        Me.Leyenda_PresupuestoTextBox.Size = New System.Drawing.Size(596, 166)
        Me.Leyenda_PresupuestoTextBox.TabIndex = 152
        Me.Leyenda_PresupuestoTextBox.Text = ""
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1052, 189)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 29)
        Me.Button3.TabIndex = 151
        Me.Button3.Text = "Compras y Gastos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1088, 68)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'EjecutadoTextBox
        '
        Me.EjecutadoTextBox.Location = New System.Drawing.Point(446, 160)
        Me.EjecutadoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EjecutadoTextBox.Name = "EjecutadoTextBox"
        Me.EjecutadoTextBox.Size = New System.Drawing.Size(68, 22)
        Me.EjecutadoTextBox.TabIndex = 148
        '
        'GrbPresupuestodetalles
        '
        Me.GrbPresupuestodetalles.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrbPresupuestodetalles.Controls.Add(ItbisIncluidoLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Me.ItbisIncluidoCheckBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.ImpuestoTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.Button2)
        Me.GrbPresupuestodetalles.Controls.Add(Me.Precio_HoraTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.Otros_GastosTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.BeneficioTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.Tarnsporte_EmbalajeTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.TasaTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.Gastos_IndierectosTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.Gastos_ImprevistosTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.DescuentoTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(Me.OtrosTextBox)
        Me.GrbPresupuestodetalles.Controls.Add(TasaLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Me.CmdAceptar)
        Me.GrbPresupuestodetalles.Controls.Add(ItbisLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Precio_HoraLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Otros_GastosLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Gastos_IndierectosLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Gastos_ImprevistosLabel)
        Me.GrbPresupuestodetalles.Controls.Add(BeneficioLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Tarnsporte_EmbalajeLabel)
        Me.GrbPresupuestodetalles.Controls.Add(OtrosLabel)
        Me.GrbPresupuestodetalles.Controls.Add(Label8)
        Me.GrbPresupuestodetalles.Location = New System.Drawing.Point(274, 280)
        Me.GrbPresupuestodetalles.Margin = New System.Windows.Forms.Padding(4)
        Me.GrbPresupuestodetalles.Name = "GrbPresupuestodetalles"
        Me.GrbPresupuestodetalles.Padding = New System.Windows.Forms.Padding(4)
        Me.GrbPresupuestodetalles.Size = New System.Drawing.Size(501, 299)
        Me.GrbPresupuestodetalles.TabIndex = 109
        Me.GrbPresupuestodetalles.TabStop = False
        '
        'ItbisIncluidoCheckBox
        '
        Me.ItbisIncluidoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PresupuestoBindingSource, "ItbisIncluido", True))
        Me.ItbisIncluidoCheckBox.Location = New System.Drawing.Point(339, 244)
        Me.ItbisIncluidoCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItbisIncluidoCheckBox.Name = "ItbisIncluidoCheckBox"
        Me.ItbisIncluidoCheckBox.Size = New System.Drawing.Size(130, 30)
        Me.ItbisIncluidoCheckBox.TabIndex = 99
        Me.ItbisIncluidoCheckBox.UseVisualStyleBackColor = True
        '
        'ImpuestoTextBox
        '
        Me.ImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Impuesto", True))
        Me.ImpuestoTextBox.Location = New System.Drawing.Point(134, 62)
        Me.ImpuestoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestoTextBox.Name = "ImpuestoTextBox"
        Me.ImpuestoTextBox.Size = New System.Drawing.Size(80, 22)
        Me.ImpuestoTextBox.TabIndex = 98
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 238)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Precio_HoraTextBox
        '
        Me.Precio_HoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Precio_Hora", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.Precio_HoraTextBox.Location = New System.Drawing.Point(136, 98)
        Me.Precio_HoraTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Precio_HoraTextBox.Name = "Precio_HoraTextBox"
        Me.Precio_HoraTextBox.Size = New System.Drawing.Size(78, 22)
        Me.Precio_HoraTextBox.TabIndex = 96
        '
        'Otros_GastosTextBox
        '
        Me.Otros_GastosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Otros_Gastos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.Otros_GastosTextBox.Location = New System.Drawing.Point(135, 126)
        Me.Otros_GastosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Otros_GastosTextBox.Name = "Otros_GastosTextBox"
        Me.Otros_GastosTextBox.Size = New System.Drawing.Size(79, 22)
        Me.Otros_GastosTextBox.TabIndex = 94
        '
        'BeneficioTextBox
        '
        Me.BeneficioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Beneficio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.BeneficioTextBox.Location = New System.Drawing.Point(136, 166)
        Me.BeneficioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BeneficioTextBox.Name = "BeneficioTextBox"
        Me.BeneficioTextBox.Size = New System.Drawing.Size(79, 22)
        Me.BeneficioTextBox.TabIndex = 93
        '
        'Tarnsporte_EmbalajeTextBox
        '
        Me.Tarnsporte_EmbalajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Tarnsporte_Embalaje", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.Tarnsporte_EmbalajeTextBox.Location = New System.Drawing.Point(136, 200)
        Me.Tarnsporte_EmbalajeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Tarnsporte_EmbalajeTextBox.Name = "Tarnsporte_EmbalajeTextBox"
        Me.Tarnsporte_EmbalajeTextBox.Size = New System.Drawing.Size(79, 22)
        Me.Tarnsporte_EmbalajeTextBox.TabIndex = 92
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "tasa", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TasaTextBox.Location = New System.Drawing.Point(370, 65)
        Me.TasaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(79, 22)
        Me.TasaTextBox.TabIndex = 91
        '
        'Gastos_IndierectosTextBox
        '
        Me.Gastos_IndierectosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Gastos_Indierectos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.Gastos_IndierectosTextBox.Location = New System.Drawing.Point(370, 94)
        Me.Gastos_IndierectosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Gastos_IndierectosTextBox.Name = "Gastos_IndierectosTextBox"
        Me.Gastos_IndierectosTextBox.Size = New System.Drawing.Size(79, 22)
        Me.Gastos_IndierectosTextBox.TabIndex = 90
        '
        'Gastos_ImprevistosTextBox
        '
        Me.Gastos_ImprevistosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Gastos_Imprevistos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.Gastos_ImprevistosTextBox.Location = New System.Drawing.Point(370, 126)
        Me.Gastos_ImprevistosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Gastos_ImprevistosTextBox.Name = "Gastos_ImprevistosTextBox"
        Me.Gastos_ImprevistosTextBox.Size = New System.Drawing.Size(79, 22)
        Me.Gastos_ImprevistosTextBox.TabIndex = 89
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.DescuentoTextBox.Location = New System.Drawing.Point(370, 166)
        Me.DescuentoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.Size = New System.Drawing.Size(79, 22)
        Me.DescuentoTextBox.TabIndex = 88
        '
        'OtrosTextBox
        '
        Me.OtrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Otros", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.OtrosTextBox.Location = New System.Drawing.Point(370, 199)
        Me.OtrosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OtrosTextBox.Name = "OtrosTextBox"
        Me.OtrosTextBox.Size = New System.Drawing.Size(79, 22)
        Me.OtrosTextBox.TabIndex = 87
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Location = New System.Drawing.Point(21, 238)
        Me.CmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmdAceptar.TabIndex = 54
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = True
        '
        'TotalPresupuestoUSTextBox
        '
        Me.TotalPresupuestoUSTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPresupuestoUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "TotalPresupuestoUS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TotalPresupuestoUSTextBox.Enabled = False
        Me.TotalPresupuestoUSTextBox.Location = New System.Drawing.Point(839, 844)
        Me.TotalPresupuestoUSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPresupuestoUSTextBox.Name = "TotalPresupuestoUSTextBox"
        Me.TotalPresupuestoUSTextBox.Size = New System.Drawing.Size(124, 22)
        Me.TotalPresupuestoUSTextBox.TabIndex = 147
        Me.TotalPresupuestoUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ValorImpuestoUsTextBox
        '
        Me.ValorImpuestoUsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValorImpuestoUsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "ValorImpuestoUs", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ValorImpuestoUsTextBox.Enabled = False
        Me.ValorImpuestoUsTextBox.Location = New System.Drawing.Point(839, 808)
        Me.ValorImpuestoUsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ValorImpuestoUsTextBox.Name = "ValorImpuestoUsTextBox"
        Me.ValorImpuestoUsTextBox.Size = New System.Drawing.Size(124, 22)
        Me.ValorImpuestoUsTextBox.TabIndex = 146
        Me.ValorImpuestoUsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalUSTextBox
        '
        Me.SubTotalUSTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubTotalUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "SubTotalUS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SubTotalUSTextBox.Enabled = False
        Me.SubTotalUSTextBox.Location = New System.Drawing.Point(838, 775)
        Me.SubTotalUSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalUSTextBox.Name = "SubTotalUSTextBox"
        Me.SubTotalUSTextBox.Size = New System.Drawing.Size(124, 22)
        Me.SubTotalUSTextBox.TabIndex = 145
        Me.SubTotalUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MonedaComboBox
        '
        Me.MonedaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Moneda", True))
        Me.MonedaComboBox.FormattingEnabled = True
        Me.MonedaComboBox.Items.AddRange(New Object() {"RD$", "US$", "EUR"})
        Me.MonedaComboBox.Location = New System.Drawing.Point(361, 60)
        Me.MonedaComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MonedaComboBox.Name = "MonedaComboBox"
        Me.MonedaComboBox.Size = New System.Drawing.Size(82, 24)
        Me.MonedaComboBox.TabIndex = 144
        '
        'TotalPresupuestoRDTextBox
        '
        Me.TotalPresupuestoRDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPresupuestoRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "TotalPresupuestoRD", True))
        Me.TotalPresupuestoRDTextBox.Enabled = False
        Me.TotalPresupuestoRDTextBox.Location = New System.Drawing.Point(1009, 844)
        Me.TotalPresupuestoRDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPresupuestoRDTextBox.Name = "TotalPresupuestoRDTextBox"
        Me.TotalPresupuestoRDTextBox.Size = New System.Drawing.Size(124, 22)
        Me.TotalPresupuestoRDTextBox.TabIndex = 143
        Me.TotalPresupuestoRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ValorImpuestoRDTextBox
        '
        Me.ValorImpuestoRDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValorImpuestoRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "ValorImpuestoRD", True))
        Me.ValorImpuestoRDTextBox.Enabled = False
        Me.ValorImpuestoRDTextBox.Location = New System.Drawing.Point(1009, 806)
        Me.ValorImpuestoRDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ValorImpuestoRDTextBox.Name = "ValorImpuestoRDTextBox"
        Me.ValorImpuestoRDTextBox.Size = New System.Drawing.Size(124, 22)
        Me.ValorImpuestoRDTextBox.TabIndex = 142
        Me.ValorImpuestoRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalRDTextBox
        '
        Me.SubTotalRDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubTotalRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "SubTotalRD", True))
        Me.SubTotalRDTextBox.Enabled = False
        Me.SubTotalRDTextBox.Location = New System.Drawing.Point(1009, 774)
        Me.SubTotalRDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SubTotalRDTextBox.Name = "SubTotalRDTextBox"
        Me.SubTotalRDTextBox.Size = New System.Drawing.Size(124, 22)
        Me.SubTotalRDTextBox.TabIndex = 141
        Me.SubTotalRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesDetalleTableAdapter
        '
        Me.PagosClientesDetalleTableAdapter.ClearBeforeFill = True
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsPagosClientes
        '
        'TableAdapterManager16
        '
        Me.TableAdapterManager16.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager16.ClientesTableAdapter = Nothing
        Me.TableAdapterManager16.Connection = Nothing
        Me.TableAdapterManager16.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager16.PagosClientesTableAdapter = Nothing
        Me.TableAdapterManager16.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1692, 929)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDesdeelregistro)
        Me.Controls.Add(Me.LblRegistroADuplicar)
        Me.Controls.Add(Me.cmdDuplicarHerraje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTipoPinturaPresupuestada)
        Me.Controls.Add(Me.PresupuestoBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblEtiqueta)
        Me.Controls.Add(Me.LblPintura)
        Me.Controls.Add(Me.ConsultaHerrajePresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.LblTipoPintura)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPresupuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuestos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaHerrajePresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsultaHerrajesPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleElementos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleElementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarHerrajeCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexarHerrajesCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarMaterialCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexarMaterialCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarPinturaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnrxarPinturaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PresupuestoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PresupuestoBindingNavigator.ResumeLayout(False)
        Me.PresupuestoBindingNavigator.PerformLayout()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarFerreteriaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexarFerreteriaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTotalFerreteriaArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFerreteriaArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEliminarMatertialPrecioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EliminarMaterialPreciosCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaHerrajePresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrbPresupuestodetalles.ResumeLayout(False)
        Me.GrbPresupuestodetalles.PerformLayout()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter










    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsSubArticulosDetalle As ModuloGestion.DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosDetalleTableAdapter As ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleElementos As ModuloGestion.DsPresupuestoDetalleElementos
    Friend WithEvents PresupuestoDetalleElementosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleElementosTableAdapter As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPresupuestoDetallePintura As ModuloGestion.DsPresupuestoDetallePintura
    Friend WithEvents PresupuestoDetallePinturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetallePinturaTableAdapter As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleHerrajes As ModuloGestion.DsPresupuestoDetalleHerrajes
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager6 As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents DsHerrajes As ModuloGestion.DsHerrajes
    Friend WithEvents HerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesTableAdapter As ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter
    Friend WithEvents LblTipoPintura As System.Windows.Forms.Label


    Friend WithEvents LblPintura As System.Windows.Forms.Label
    Friend WithEvents DsConsultaHerrajesPresupuestoDetalle As ModuloGestion.DsConsultaHerrajesPresupuestoDetalle
    Friend WithEvents ConsultaHerrajePresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultaHerrajePresupuestoDetalleTableAdapter As ModuloGestion.DsConsultaHerrajesPresupuestoDetalleTableAdapters.ConsultaHerrajePresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager8 As ModuloGestion.DsConsultaHerrajesPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsAnexarHerrajeCompra As ModuloGestion.DsAnexarHerrajeCompra
    Friend WithEvents AnexarHerrajesCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexarHerrajesCompraTableAdapter As ModuloGestion.DsAnexarHerrajeCompraTableAdapters.AnexarHerrajesCompraTableAdapter
    Friend WithEvents TableAdapterManager9 As ModuloGestion.DsAnexarHerrajeCompraTableAdapters.TableAdapterManager
    Friend WithEvents DsAnexarMaterialCompra As ModuloGestion.DsAnexarMaterialCompra
    Friend WithEvents AnexarMaterialCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexarMaterialCompraTableAdapter As ModuloGestion.DsAnexarMaterialCompraTableAdapters.AnexarMaterialCompraTableAdapter
    Friend WithEvents TableAdapterManager10 As ModuloGestion.DsAnexarMaterialCompraTableAdapters.TableAdapterManager
    Friend WithEvents DsAnexarPinturaCompra As ModuloGestion.DsAnexarPinturaCompra
    Friend WithEvents AnrxarPinturaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnrxarPinturaCompraTableAdapter As ModuloGestion.DsAnexarPinturaCompraTableAdapters.AnrxarPinturaCompraTableAdapter
    Friend WithEvents TableAdapterManager11 As ModuloGestion.DsAnexarPinturaCompraTableAdapters.TableAdapterManager
    Friend WithEvents BtnNotaEntrega As System.Windows.Forms.Button
    Friend WithEvents BtnCambioProyecto As System.Windows.Forms.Button
    Friend WithEvents LblEtiqueta As System.Windows.Forms.Label
    Friend WithEvents BtnPreciosArticulo As System.Windows.Forms.Button
    Friend WithEvents BtnAnexarPrecios As System.Windows.Forms.Button
    Friend WithEvents BtnImprimirProforma As System.Windows.Forms.Button
    Friend WithEvents BtnActualizarConsumos1 As System.Windows.Forms.Button
    Friend WithEvents BtnSoloConsumos As System.Windows.Forms.Button
    Friend WithEvents BtnDuplicarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents BtnImprimirPresupuesto As System.Windows.Forms.Button
    Friend WithEvents Btnimprimirarticulos As System.Windows.Forms.Button
    Friend WithEvents BtnKitArticulos As System.Windows.Forms.Button
    Friend WithEvents BtnConsumoPresupuesto As System.Windows.Forms.Button
    Friend WithEvents BtnAnalisisPresupuesto As System.Windows.Forms.Button
    Friend WithEvents BtnCostoArticulos As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PresupuestoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PresupuestoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblTipoPinturaPresupuestada As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnDocumentacion As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdDuplicarHerraje As System.Windows.Forms.Button
    Friend WithEvents LblRegistroADuplicar As System.Windows.Forms.Label
    Friend WithEvents lblDesdeelregistro As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPinturaPresupuesto As System.Windows.Forms.Button
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents DsAnexarFerreteriaCompra As ModuloGestion.DsAnexarFerreteriaCompra
    Friend WithEvents AnexarFerreteriaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexarFerreteriaCompraTableAdapter As ModuloGestion.DsAnexarFerreteriaCompraTableAdapters.AnexarFerreteriaCompraTableAdapter
    Friend WithEvents TableAdapterManager12 As ModuloGestion.DsAnexarFerreteriaCompraTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleferreteria As ModuloGestion.DsPresupuestoDetalleferreteria
    Friend WithEvents PresupuestoDetalleFerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleFerreteriaTableAdapter As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter
    Friend WithEvents TableAdapterManager13 As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager
    Friend WithEvents DsTotalFerreteriaArticulo As ModuloGestion.DsTotalFerreteriaArticulo
    Friend WithEvents TotalFerreteriaArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalFerreteriaArticuloTableAdapter As ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TotalFerreteriaArticuloTableAdapter
    Friend WithEvents TableAdapterManager14 As ModuloGestion.DsTotalFerreteriaArticuloTableAdapters.TableAdapterManager
    Friend WithEvents DsEliminarMatertialPrecioCompra As ModuloGestion.DsEliminarMatertialPrecioCompra
    Friend WithEvents EliminarMaterialPreciosCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EliminarMaterialPreciosCompraTableAdapter As ModuloGestion.DsEliminarMatertialPrecioCompraTableAdapters.EliminarMaterialPreciosCompraTableAdapter
    Friend WithEvents TableAdapterManager15 As ModuloGestion.DsEliminarMatertialPrecioCompraTableAdapters.TableAdapterManager


    Friend WithEvents PreciosCompraProyectoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdProyectoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPreciosCompraProyecto As ModuloGestion.DsPreciosCompraProyecto
    Friend WithEvents PreciosCompraProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreciosCompraProyectoTableAdapter As ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter
    Friend WithEvents TableAdapterManager7 As ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager
    Friend WithEvents IddetalleHerrajesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdHerrajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDetallePresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadHerrajesDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_Elemento_Herrajes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDetalle_Presupuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsultaHerrajePresupuestoDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtIdEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents CmdGenerles As System.Windows.Forms.Button
    Friend WithEvents TxtEstado As System.Windows.Forms.ComboBox
    Friend WithEvents CmdNuevoArticulo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PresupuestoDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LblImpuesto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmdHerrajePintura As System.Windows.Forms.Button
    Friend WithEvents BtnVerArticulo As System.Windows.Forms.Button
    Friend WithEvents Carpeta_DatosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtOrdenDeCompra As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalPresupuestoRDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorImpuestoRDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalRDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonedaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GrbPresupuestodetalles As System.Windows.Forms.GroupBox
    Friend WithEvents Precio_HoraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Otros_GastosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeneficioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tarnsporte_EmbalajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TasaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gastos_IndierectosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gastos_ImprevistosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescuentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtrosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents TotalPresupuestoUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorImpuestoUsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EjecutadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager16 As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ImpuestoTextBox As TextBox
    Friend WithEvents ItbisIncluidoCheckBox As CheckBox
    Friend WithEvents IdDetallePresupuestoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents CantidadView As DataGridViewTextBoxColumn
    Friend WithEvents Precioview As DataGridViewTextBoxColumn
    Friend WithEvents totalview As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRDview As DataGridViewTextBoxColumn
    Friend WithEvents totalRdview As DataGridViewTextBoxColumn
    Friend WithEvents EnProduccion As DataGridViewCheckBoxColumn
    Friend WithEvents EnPintura As DataGridViewCheckBoxColumn
    Friend WithEvents Enobra As DataGridViewCheckBoxColumn
    Friend WithEvents Leyenda_PresupuestoTextBox As RichTextBox
End Class
