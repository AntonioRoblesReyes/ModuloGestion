<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
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
        Dim IdArticuloLabel As System.Windows.Forms.Label
        Dim Descripcion_articuloLabel As System.Windows.Forms.Label
        Dim HorasTrabajoTallerLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim DiseñoArticuloLabel As System.Windows.Forms.Label
        Dim MontajeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulo))
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
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.ArticulosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ArticulosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.Descripcion_articuloTextBox = New System.Windows.Forms.TextBox()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.Bbtnduplicar = New System.Windows.Forms.Button()
        Me.CmdImprimir = New System.Windows.Forms.Button()
        Me.CmdVerCosumo = New System.Windows.Forms.Button()
        Me.CmdNuevoElemento = New System.Windows.Forms.Button()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.PresupuestoDetalleSubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalleElementos = New ModuloGestion.DsPresupuestoDetalleElementos()
        Me.PresupuestoDetalleElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleElementosTableAdapter = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager()
        Me.DsTrabajoTallerM2PinturaArticulo = New ModuloGestion.DsTrabajoTallerM2PinturaArticulo()
        Me.TrabajoTallerM2PinturaArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajoTallerM2PinturaArticuloTableAdapter = New ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TrabajoTallerM2PinturaArticuloTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TableAdapterManager()
        Me.M2PinturaTextBox = New System.Windows.Forms.TextBox()
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager()
        Me.DescripcionesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDescripcionesdetalle = New ModuloGestion.DsDescripcionesdetalle()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.DescripcionesDetalleTableAdapter = New ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.BtnVerDiseño = New System.Windows.Forms.Button()
        Me.DiseñoArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblInicioFormulario = New System.Windows.Forms.Label()
        Me.SubArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.PiesLargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anchopulgadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GruesoPulgadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesperdicioMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDetalleArticulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSubArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMontaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalMonatje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasTrabajoTaller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasTrabajoTallerTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2Pintura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2Pinturatota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnCambiarSubArticulo = New System.Windows.Forms.Button()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.HorasTrabajoTallerTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MontajeTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        IdArticuloLabel = New System.Windows.Forms.Label()
        Descripcion_articuloLabel = New System.Windows.Forms.Label()
        HorasTrabajoTallerLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        DiseñoArticuloLabel = New System.Windows.Forms.Label()
        MontajeLabel = New System.Windows.Forms.Label()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArticulosBindingNavigator.SuspendLayout()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleSubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleElementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrabajoTallerM2PinturaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajoTallerM2PinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdArticuloLabel
        '
        IdArticuloLabel.AutoSize = True
        IdArticuloLabel.Location = New System.Drawing.Point(76, 49)
        IdArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdArticuloLabel.Name = "IdArticuloLabel"
        IdArticuloLabel.Size = New System.Drawing.Size(74, 17)
        IdArticuloLabel.TabIndex = 1
        IdArticuloLabel.Text = "Id Articulo:"
        '
        'Descripcion_articuloLabel
        '
        Descripcion_articuloLabel.AutoSize = True
        Descripcion_articuloLabel.Location = New System.Drawing.Point(19, 81)
        Descripcion_articuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Descripcion_articuloLabel.Name = "Descripcion_articuloLabel"
        Descripcion_articuloLabel.Size = New System.Drawing.Size(136, 17)
        Descripcion_articuloLabel.TabIndex = 3
        Descripcion_articuloLabel.Text = "Descripcion articulo:"
        '
        'HorasTrabajoTallerLabel
        '
        HorasTrabajoTallerLabel.AutoSize = True
        HorasTrabajoTallerLabel.Location = New System.Drawing.Point(1189, 96)
        HorasTrabajoTallerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HorasTrabajoTallerLabel.Name = "HorasTrabajoTallerLabel"
        HorasTrabajoTallerLabel.Size = New System.Drawing.Size(143, 17)
        HorasTrabajoTallerLabel.TabIndex = 18
        HorasTrabajoTallerLabel.Text = "Horas Trabajo Taller:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(1253, 126)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 17)
        Label1.TabIndex = 20
        Label1.Text = "M2 Pintura"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(493, 52)
        ModeloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(58, 17)
        ModeloLabel.TabIndex = 20
        ModeloLabel.Text = "Modelo:"
        '
        'DiseñoArticuloLabel
        '
        DiseñoArticuloLabel.AutoSize = True
        DiseñoArticuloLabel.Location = New System.Drawing.Point(19, 313)
        DiseñoArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DiseñoArticuloLabel.Name = "DiseñoArticuloLabel"
        DiseñoArticuloLabel.Size = New System.Drawing.Size(141, 17)
        DiseñoArticuloLabel.TabIndex = 22
        DiseñoArticuloLabel.Text = "Diseño Articulo: Ruta"
        '
        'MontajeLabel
        '
        MontajeLabel.AutoSize = True
        MontajeLabel.Location = New System.Drawing.Point(1267, 155)
        MontajeLabel.Name = "MontajeLabel"
        MontajeLabel.Size = New System.Drawing.Size(62, 17)
        MontajeLabel.TabIndex = 27
        MontajeLabel.Text = "Montaje:"
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
        'ArticulosBindingNavigator
        '
        Me.ArticulosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ArticulosBindingNavigator.BindingSource = Me.ArticulosBindingSource
        Me.ArticulosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ArticulosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ArticulosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ArticulosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ArticulosBindingNavigatorSaveItem})
        Me.ArticulosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ArticulosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ArticulosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ArticulosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ArticulosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ArticulosBindingNavigator.Name = "ArticulosBindingNavigator"
        Me.ArticulosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ArticulosBindingNavigator.Size = New System.Drawing.Size(1969, 27)
        Me.ArticulosBindingNavigator.TabIndex = 0
        Me.ArticulosBindingNavigator.Text = "BindingNavigator1"
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
        'ArticulosBindingNavigatorSaveItem
        '
        Me.ArticulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArticulosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ArticulosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ArticulosBindingNavigatorSaveItem.Name = "ArticulosBindingNavigatorSaveItem"
        Me.ArticulosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ArticulosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "IdArticulo", True))
        Me.TxtIdArticulo.Enabled = False
        Me.TxtIdArticulo.Location = New System.Drawing.Point(164, 46)
        Me.TxtIdArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.Size = New System.Drawing.Size(132, 22)
        Me.TxtIdArticulo.TabIndex = 2
        '
        'Descripcion_articuloTextBox
        '
        Me.Descripcion_articuloTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcion_articuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion_articulo", True))
        Me.Descripcion_articuloTextBox.Location = New System.Drawing.Point(164, 78)
        Me.Descripcion_articuloTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Descripcion_articuloTextBox.Multiline = True
        Me.Descripcion_articuloTextBox.Name = "Descripcion_articuloTextBox"
        Me.Descripcion_articuloTextBox.Size = New System.Drawing.Size(661, 223)
        Me.Descripcion_articuloTextBox.TabIndex = 4
        '
        'DsArticulosdetalle
        '
        Me.DsArticulosdetalle.DataSetName = "DsArticulosdetalle"
        Me.DsArticulosdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosDetalleBindingSource
        '
        Me.ArticulosDetalleBindingSource.DataMember = "ArticulosDetalle"
        Me.ArticulosDetalleBindingSource.DataSource = Me.DsArticulosdetalle
        '
        'ArticulosDetalleTableAdapter
        '
        Me.ArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Bbtnduplicar
        '
        Me.Bbtnduplicar.Location = New System.Drawing.Point(305, 44)
        Me.Bbtnduplicar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bbtnduplicar.Name = "Bbtnduplicar"
        Me.Bbtnduplicar.Size = New System.Drawing.Size(175, 28)
        Me.Bbtnduplicar.TabIndex = 17
        Me.Bbtnduplicar.Text = "Duplicar Articulo"
        Me.Bbtnduplicar.UseVisualStyleBackColor = True
        '
        'CmdImprimir
        '
        Me.CmdImprimir.Location = New System.Drawing.Point(651, 14)
        Me.CmdImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.Size = New System.Drawing.Size(175, 28)
        Me.CmdImprimir.TabIndex = 16
        Me.CmdImprimir.Text = "Imprimir"
        Me.CmdImprimir.UseVisualStyleBackColor = True
        '
        'CmdVerCosumo
        '
        Me.CmdVerCosumo.Location = New System.Drawing.Point(969, 84)
        Me.CmdVerCosumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdVerCosumo.Name = "CmdVerCosumo"
        Me.CmdVerCosumo.Size = New System.Drawing.Size(175, 28)
        Me.CmdVerCosumo.TabIndex = 13
        Me.CmdVerCosumo.Text = "Ver Consumo"
        Me.CmdVerCosumo.UseVisualStyleBackColor = True
        '
        'CmdNuevoElemento
        '
        Me.CmdNuevoElemento.Location = New System.Drawing.Point(969, 119)
        Me.CmdNuevoElemento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdNuevoElemento.Name = "CmdNuevoElemento"
        Me.CmdNuevoElemento.Size = New System.Drawing.Size(175, 28)
        Me.CmdNuevoElemento.TabIndex = 14
        Me.CmdNuevoElemento.Text = "Agregar SubAriculo"
        Me.CmdNuevoElemento.UseVisualStyleBackColor = True
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PresupuestoDetalleElementosTableAdapter = Me.PresupuestoDetalleElementosTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsTrabajoTallerM2PinturaArticulo
        '
        Me.DsTrabajoTallerM2PinturaArticulo.DataSetName = "DsTrabajoTallerM2PinturaArticulo"
        Me.DsTrabajoTallerM2PinturaArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrabajoTallerM2PinturaArticuloBindingSource
        '
        Me.TrabajoTallerM2PinturaArticuloBindingSource.DataMember = "TrabajoTallerM2PinturaArticulo"
        Me.TrabajoTallerM2PinturaArticuloBindingSource.DataSource = Me.DsTrabajoTallerM2PinturaArticulo
        '
        'TrabajoTallerM2PinturaArticuloTableAdapter
        '
        Me.TrabajoTallerM2PinturaArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'M2PinturaTextBox
        '
        Me.M2PinturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "M2Pintura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.M2PinturaTextBox.Enabled = False
        Me.M2PinturaTextBox.Location = New System.Drawing.Point(1339, 122)
        Me.M2PinturaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M2PinturaTextBox.Name = "M2PinturaTextBox"
        Me.M2PinturaTextBox.Size = New System.Drawing.Size(93, 22)
        Me.M2PinturaTextBox.TabIndex = 18
        Me.M2PinturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.SubArticulosDetalleTableAdapter = Me.SubArticulosDetalleTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionesDetalleBindingSource
        '
        Me.DescripcionesDetalleBindingSource.DataMember = "DescripcionesDetalle"
        Me.DescripcionesDetalleBindingSource.DataSource = Me.DsDescripcionesdetalle
        '
        'DsDescripcionesdetalle
        '
        Me.DsDescripcionesdetalle.DataSetName = "DsDescripcionesdetalle"
        Me.DsDescripcionesdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DescripcionesDetalleTableAdapter
        '
        Me.DescripcionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(571, 49)
        Me.ModeloTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(255, 22)
        Me.ModeloTextBox.TabIndex = 21
        '
        'BtnVerDiseño
        '
        Me.BtnVerDiseño.Location = New System.Drawing.Point(16, 101)
        Me.BtnVerDiseño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnVerDiseño.Name = "BtnVerDiseño"
        Me.BtnVerDiseño.Size = New System.Drawing.Size(140, 28)
        Me.BtnVerDiseño.TabIndex = 22
        Me.BtnVerDiseño.Text = "Ver Diseño"
        Me.BtnVerDiseño.UseVisualStyleBackColor = True
        '
        'DiseñoArticuloTextBox
        '
        Me.DiseñoArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "DiseñoArticulo", True))
        Me.DiseñoArticuloTextBox.Location = New System.Drawing.Point(164, 309)
        Me.DiseñoArticuloTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DiseñoArticuloTextBox.Name = "DiseñoArticuloTextBox"
        Me.DiseñoArticuloTextBox.Size = New System.Drawing.Size(477, 22)
        Me.DiseñoArticuloTextBox.TabIndex = 23
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog"
        Me.OpenFileDialog1.InitialDirectory = "\\antonio-dell\Users\Public\Carpeta Datos\Diseño Articulos Pdf"
        '
        'lblInicioFormulario
        '
        Me.lblInicioFormulario.AutoSize = True
        Me.lblInicioFormulario.Location = New System.Drawing.Point(1139, 57)
        Me.lblInicioFormulario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInicioFormulario.Name = "lblInicioFormulario"
        Me.lblInicioFormulario.Size = New System.Drawing.Size(51, 17)
        Me.lblInicioFormulario.TabIndex = 24
        Me.lblInicioFormulario.Text = "Label2"
        '
        'SubArticulosDetalleDataGridView
        '
        Me.SubArticulosDetalleDataGridView.AllowUserToAddRows = False
        Me.SubArticulosDetalleDataGridView.AutoGenerateColumns = False
        Me.SubArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn26, Me.PiesLargo, Me.Anchopulgadas, Me.GruesoPulgadas, Me.DesperdicioMaterial})
        Me.SubArticulosDetalleDataGridView.DataSource = Me.SubArticulosDetalleBindingSource
        Me.SubArticulosDetalleDataGridView.Location = New System.Drawing.Point(16, 623)
        Me.SubArticulosDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubArticulosDetalleDataGridView.Name = "SubArticulosDetalleDataGridView"
        Me.SubArticulosDetalleDataGridView.RowHeadersWidth = 51
        Me.SubArticulosDetalleDataGridView.Size = New System.Drawing.Size(1833, 271)
        Me.SubArticulosDetalleDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.DescripcionesDetalleBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Id_descripcion_Detalle"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.MaterilaesDetalleBindingSource
        Me.DataGridViewTextBoxColumn11.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn11.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Largo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ancho"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Grueso"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn9.HeaderText = "Grueso"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn26.DataSource = Me.MedidasCompraBindingSource
        Me.DataGridViewTextBoxColumn26.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn26.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn26.HeaderText = "Medida Compra"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn26.ValueMember = "Id_Medida"
        Me.DataGridViewTextBoxColumn26.Width = 150
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PiesLargo
        '
        Me.PiesLargo.DataPropertyName = "PiesLargo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.PiesLargo.DefaultCellStyle = DataGridViewCellStyle5
        Me.PiesLargo.HeaderText = "Pies Largo"
        Me.PiesLargo.MinimumWidth = 6
        Me.PiesLargo.Name = "PiesLargo"
        Me.PiesLargo.Width = 60
        '
        'Anchopulgadas
        '
        Me.Anchopulgadas.DataPropertyName = "Anchopulgadas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.Anchopulgadas.DefaultCellStyle = DataGridViewCellStyle6
        Me.Anchopulgadas.HeaderText = "Ancho P"
        Me.Anchopulgadas.MinimumWidth = 6
        Me.Anchopulgadas.Name = "Anchopulgadas"
        Me.Anchopulgadas.Width = 60
        '
        'GruesoPulgadas
        '
        Me.GruesoPulgadas.DataPropertyName = "GruesoPulgadas"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.GruesoPulgadas.DefaultCellStyle = DataGridViewCellStyle7
        Me.GruesoPulgadas.HeaderText = "Grueso P"
        Me.GruesoPulgadas.MinimumWidth = 6
        Me.GruesoPulgadas.Name = "GruesoPulgadas"
        Me.GruesoPulgadas.Width = 60
        '
        'DesperdicioMaterial
        '
        Me.DesperdicioMaterial.DataPropertyName = "DesperdicioMaterial"
        Me.DesperdicioMaterial.HeaderText = "Des M"
        Me.DesperdicioMaterial.MinimumWidth = 6
        Me.DesperdicioMaterial.Name = "DesperdicioMaterial"
        Me.DesperdicioMaterial.Width = 30
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalleArticulosDataGridViewTextBoxColumn, Me.IDSubArticuloDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioMontaje, Me.TotalMonatje, Me.HorasTrabajoTaller, Me.HorasTrabajoTallerTotal, Me.M2Pintura, Me.M2Pinturatota, Me.Ver})
        Me.DataGridView.DataSource = Me.ArticulosDetalleBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(0, 341)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.Size = New System.Drawing.Size(1561, 261)
        Me.DataGridView.TabIndex = 25
        '
        'IdDetalleArticulosDataGridViewTextBoxColumn
        '
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.DataPropertyName = "Id_Detalle_Articulos"
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.HeaderText = "Id_Detalle_Articulos"
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.Name = "IdDetalleArticulosDataGridViewTextBoxColumn"
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.Width = 125
        '
        'IDSubArticuloDataGridViewTextBoxColumn
        '
        Me.IDSubArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDSubArticuloDataGridViewTextBoxColumn.DataPropertyName = "ID_Sub_Articulo"
        Me.IDSubArticuloDataGridViewTextBoxColumn.DataSource = Me.SubArticulosBindingSource
        Me.IDSubArticuloDataGridViewTextBoxColumn.DisplayMember = "Descripcion_Sub_Articulo"
        Me.IDSubArticuloDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IDSubArticuloDataGridViewTextBoxColumn.HeaderText = "ID_Sub_Articulo"
        Me.IDSubArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDSubArticuloDataGridViewTextBoxColumn.Name = "IDSubArticuloDataGridViewTextBoxColumn"
        Me.IDSubArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDSubArticuloDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDSubArticuloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IDSubArticuloDataGridViewTextBoxColumn.ValueMember = "Id_Sub_Articulo"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 60
        '
        'PrecioMontaje
        '
        Me.PrecioMontaje.DataPropertyName = "PrecioMontaje"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.PrecioMontaje.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrecioMontaje.HeaderText = "Precio Montaje"
        Me.PrecioMontaje.MinimumWidth = 6
        Me.PrecioMontaje.Name = "PrecioMontaje"
        Me.PrecioMontaje.Width = 60
        '
        'TotalMonatje
        '
        Me.TotalMonatje.DataPropertyName = "TotalMonatje"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.TotalMonatje.DefaultCellStyle = DataGridViewCellStyle10
        Me.TotalMonatje.HeaderText = "Total Monatje"
        Me.TotalMonatje.MinimumWidth = 6
        Me.TotalMonatje.Name = "TotalMonatje"
        Me.TotalMonatje.Width = 60
        '
        'HorasTrabajoTaller
        '
        Me.HorasTrabajoTaller.DataPropertyName = "HorasTrabajoTaller"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.HorasTrabajoTaller.DefaultCellStyle = DataGridViewCellStyle11
        Me.HorasTrabajoTaller.HeaderText = "Horas Taller"
        Me.HorasTrabajoTaller.MinimumWidth = 6
        Me.HorasTrabajoTaller.Name = "HorasTrabajoTaller"
        Me.HorasTrabajoTaller.ReadOnly = True
        Me.HorasTrabajoTaller.Width = 75
        '
        'HorasTrabajoTallerTotal
        '
        Me.HorasTrabajoTallerTotal.DataPropertyName = "HorasTrabajoTallerTotal"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.HorasTrabajoTallerTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.HorasTrabajoTallerTotal.HeaderText = "Taller Total"
        Me.HorasTrabajoTallerTotal.MinimumWidth = 6
        Me.HorasTrabajoTallerTotal.Name = "HorasTrabajoTallerTotal"
        Me.HorasTrabajoTallerTotal.ReadOnly = True
        Me.HorasTrabajoTallerTotal.Width = 75
        '
        'M2Pintura
        '
        Me.M2Pintura.DataPropertyName = "M2Pintura"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle13.Format = "n2"
        Me.M2Pintura.DefaultCellStyle = DataGridViewCellStyle13
        Me.M2Pintura.HeaderText = "M2Pintura"
        Me.M2Pintura.MinimumWidth = 6
        Me.M2Pintura.Name = "M2Pintura"
        Me.M2Pintura.ReadOnly = True
        Me.M2Pintura.Width = 75
        '
        'M2Pinturatota
        '
        Me.M2Pinturatota.DataPropertyName = "M2Pinturatota"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle14.Format = "n2"
        Me.M2Pinturatota.DefaultCellStyle = DataGridViewCellStyle14
        Me.M2Pinturatota.HeaderText = "M2 Total"
        Me.M2Pinturatota.MinimumWidth = 6
        Me.M2Pinturatota.Name = "M2Pinturatota"
        Me.M2Pinturatota.ReadOnly = True
        Me.M2Pinturatota.Width = 75
        '
        'Ver
        '
        Me.Ver.DataPropertyName = "Id_Detalle_Articulos"
        Me.Ver.HeaderText = "Ver"
        Me.Ver.MinimumWidth = 6
        Me.Ver.Name = "Ver"
        Me.Ver.Text = "Ver"
        Me.Ver.UseColumnTextForButtonValue = True
        Me.Ver.Width = 35
        '
        'BtnCambiarSubArticulo
        '
        Me.BtnCambiarSubArticulo.Location = New System.Drawing.Point(969, 155)
        Me.BtnCambiarSubArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCambiarSubArticulo.Name = "BtnCambiarSubArticulo"
        Me.BtnCambiarSubArticulo.Size = New System.Drawing.Size(175, 28)
        Me.BtnCambiarSubArticulo.TabIndex = 26
        Me.BtnCambiarSubArticulo.Text = "Cambiar SubAriculo"
        Me.BtnCambiarSubArticulo.UseVisualStyleBackColor = True
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'HorasTrabajoTallerTextBox
        '
        Me.HorasTrabajoTallerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "HorasTrabajoTaller", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.HorasTrabajoTallerTextBox.Enabled = False
        Me.HorasTrabajoTallerTextBox.Location = New System.Drawing.Point(1339, 92)
        Me.HorasTrabajoTallerTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HorasTrabajoTallerTextBox.Name = "HorasTrabajoTallerTextBox"
        Me.HorasTrabajoTallerTextBox.Size = New System.Drawing.Size(93, 22)
        Me.HorasTrabajoTallerTextBox.TabIndex = 19
        Me.HorasTrabajoTallerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(1569, 341)
        Me.PresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.ReadOnly = True
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(400, 261)
        Me.PresupuestoDetalleDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Presupuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdDetalle"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(652, 305)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 28)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Agregar  prespuesto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MontajeTextBox
        '
        Me.MontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Montaje", True))
        Me.MontajeTextBox.Enabled = False
        Me.MontajeTextBox.Location = New System.Drawing.Point(1339, 151)
        Me.MontajeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MontajeTextBox.Name = "MontajeTextBox"
        Me.MontajeTextBox.Size = New System.Drawing.Size(93, 22)
        Me.MontajeTextBox.TabIndex = 28
        Me.MontajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1339, 212)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1193, 215)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 22)
        Me.TextBox1.TabIndex = 30
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsArticulos
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1684, 977)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(MontajeLabel)
        Me.Controls.Add(Me.MontajeTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.BtnCambiarSubArticulo)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.SubArticulosDetalleDataGridView)
        Me.Controls.Add(Me.lblInicioFormulario)
        Me.Controls.Add(DiseñoArticuloLabel)
        Me.Controls.Add(Me.DiseñoArticuloTextBox)
        Me.Controls.Add(Me.BtnVerDiseño)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(HorasTrabajoTallerLabel)
        Me.Controls.Add(Me.HorasTrabajoTallerTextBox)
        Me.Controls.Add(Me.M2PinturaTextBox)
        Me.Controls.Add(Me.Bbtnduplicar)
        Me.Controls.Add(Me.CmdImprimir)
        Me.Controls.Add(Me.CmdVerCosumo)
        Me.Controls.Add(Me.CmdNuevoElemento)
        Me.Controls.Add(IdArticuloLabel)
        Me.Controls.Add(Me.TxtIdArticulo)
        Me.Controls.Add(Descripcion_articuloLabel)
        Me.Controls.Add(Me.Descripcion_articuloTextBox)
        Me.Controls.Add(Me.ArticulosBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm Articulo"
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArticulosBindingNavigator.ResumeLayout(False)
        Me.ArticulosBindingNavigator.PerformLayout()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleSubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleElementos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleElementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrabajoTallerM2PinturaArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajoTallerM2PinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ArticulosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion_articuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents Bbtnduplicar As System.Windows.Forms.Button
    Friend WithEvents CmdImprimir As System.Windows.Forms.Button
    Friend WithEvents CmdVerCosumo As System.Windows.Forms.Button
    Friend WithEvents CmdNuevoElemento As System.Windows.Forms.Button
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter

    Friend WithEvents PresupuestoDetalleSubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleElementos As ModuloGestion.DsPresupuestoDetalleElementos
    Friend WithEvents PresupuestoDetalleElementosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleElementosTableAdapter As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager
    Friend WithEvents DsTrabajoTallerM2PinturaArticulo As ModuloGestion.DsTrabajoTallerM2PinturaArticulo
    Friend WithEvents TrabajoTallerM2PinturaArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrabajoTallerM2PinturaArticuloTableAdapter As ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TrabajoTallerM2PinturaArticuloTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TableAdapterManager
    Friend WithEvents M2PinturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsSubArticulosDetalle As ModuloGestion.DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosDetalleTableAdapter As ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsDescripcionesdetalle As ModuloGestion.DsDescripcionesdetalle
    Friend WithEvents DescripcionesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionesDetalleTableAdapter As ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnVerDiseño As System.Windows.Forms.Button
    Friend WithEvents DiseñoArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblInicioFormulario As System.Windows.Forms.Label
    Friend WithEvents SubArticulosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCambiarSubArticulo As System.Windows.Forms.Button
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents HorasTrabajoTallerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PiesLargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anchopulgadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GruesoPulgadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesperdicioMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresupuestoDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents MontajeTextBox As TextBox
    Friend WithEvents IdDetalleArticulosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSubArticuloDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioMontaje As DataGridViewTextBoxColumn
    Friend WithEvents TotalMonatje As DataGridViewTextBoxColumn
    Friend WithEvents HorasTrabajoTaller As DataGridViewTextBoxColumn
    Friend WithEvents HorasTrabajoTallerTotal As DataGridViewTextBoxColumn
    Friend WithEvents M2Pintura As DataGridViewTextBoxColumn
    Friend WithEvents M2Pinturatota As DataGridViewTextBoxColumn
    Friend WithEvents Ver As DataGridViewButtonColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
