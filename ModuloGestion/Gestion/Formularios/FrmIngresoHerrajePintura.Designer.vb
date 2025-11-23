<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresoHerrajePintura
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoHerrajePintura))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PresupuestoDetalleHerrajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_detalle_Herrajes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerrajes = New ModuloGestion.DsHerrajes()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalleHerrajes = New ModuloGestion.DsPresupuestoDetalleHerrajes()
        Me.LblTipoPinturaPresupuestada = New System.Windows.Forms.Label()
        Me.BtnAñadirPintura = New System.Windows.Forms.Button()
        Me.BtnAñadirHerraje = New System.Windows.Forms.Button()
        Me.PresupuestoDetallePinturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPinturaTipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PinturaAplicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaAplicacion = New ModuloGestion.DsPinturaAplicacion()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadArticulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSubarticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadElemntosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalleArticulosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosumoArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostoArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosumoPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoDetallePinturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetallePintura = New ModuloGestion.DsPresupuestoDetallePintura()
        Me.TrabajoTallerM2PinturaArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTrabajoTallerM2PinturaArticulo = New ModuloGestion.DsTrabajoTallerM2PinturaArticulo()
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
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
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Descripcion_articuloTextBox = New System.Windows.Forms.TextBox()
        Me.IdArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.TxtdDetallePresupuesto = New System.Windows.Forms.TextBox()
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager()
        Me.HerrajesTableAdapter = New ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter()
        Me.PresupuestoDetallePinturaTableAdapter = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.TrabajoTallerM2PinturaArticuloTableAdapter = New ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TrabajoTallerM2PinturaArticuloTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TableAdapterManager()
        Me.PinturaAplicacionTableAdapter = New ModuloGestion.DsPinturaAplicacionTableAdapters.PinturaAplicacionTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PresupuestoDetalleHerrajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetallePinturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaAplicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajoTallerM2PinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTrabajoTallerM2PinturaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArticulosBindingNavigator.SuspendLayout()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PresupuestoDetalleHerrajesDataGridView)
        Me.GroupBox1.Controls.Add(Me.LblTipoPinturaPresupuestada)
        Me.GroupBox1.Controls.Add(Me.BtnAñadirPintura)
        Me.GroupBox1.Controls.Add(Me.BtnAñadirHerraje)
        Me.GroupBox1.Controls.Add(Me.PresupuestoDetallePinturaDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 188)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1344, 366)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'PresupuestoDetalleHerrajesDataGridView
        '
        Me.PresupuestoDetalleHerrajesDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleHerrajesDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleHerrajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleHerrajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_detalle_Herrajes, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.PresupuestoDetalleHerrajesDataGridView.DataSource = Me.PresupuestoDetalleHerrajesBindingSource
        Me.PresupuestoDetalleHerrajesDataGridView.Location = New System.Drawing.Point(8, 63)
        Me.PresupuestoDetalleHerrajesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PresupuestoDetalleHerrajesDataGridView.Name = "PresupuestoDetalleHerrajesDataGridView"
        Me.PresupuestoDetalleHerrajesDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleHerrajesDataGridView.Size = New System.Drawing.Size(651, 271)
        Me.PresupuestoDetalleHerrajesDataGridView.TabIndex = 6
        '
        'Id_detalle_Herrajes
        '
        Me.Id_detalle_Herrajes.DataPropertyName = "Id_detalle_Herrajes"
        Me.Id_detalle_Herrajes.HeaderText = "Id_detalle_Herrajes"
        Me.Id_detalle_Herrajes.MinimumWidth = 6
        Me.Id_detalle_Herrajes.Name = "Id_detalle_Herrajes"
        Me.Id_detalle_Herrajes.Visible = False
        Me.Id_detalle_Herrajes.Width = 125
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Id_Herraje"
        Me.DataGridViewTextBoxColumn26.DataSource = Me.HerrajesBindingSource
        Me.DataGridViewTextBoxColumn26.DisplayMember = "Descripcion_Elemento_Herrajes"
        Me.DataGridViewTextBoxColumn26.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn26.HeaderText = "Id_Herraje"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn26.ValueMember = "IdHerraje"
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
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CantidadHerrajesDetalle"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 75
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
        'LblTipoPinturaPresupuestada
        '
        Me.LblTipoPinturaPresupuestada.AutoSize = True
        Me.LblTipoPinturaPresupuestada.Location = New System.Drawing.Point(988, 37)
        Me.LblTipoPinturaPresupuestada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoPinturaPresupuestada.Name = "LblTipoPinturaPresupuestada"
        Me.LblTipoPinturaPresupuestada.Size = New System.Drawing.Size(51, 17)
        Me.LblTipoPinturaPresupuestada.TabIndex = 6
        Me.LblTipoPinturaPresupuestada.Text = "Label4"
        '
        'BtnAñadirPintura
        '
        Me.BtnAñadirPintura.Location = New System.Drawing.Point(824, 27)
        Me.BtnAñadirPintura.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAñadirPintura.Name = "BtnAñadirPintura"
        Me.BtnAñadirPintura.Size = New System.Drawing.Size(119, 28)
        Me.BtnAñadirPintura.TabIndex = 5
        Me.BtnAñadirPintura.Text = " Añadir Pintura"
        Me.BtnAñadirPintura.UseVisualStyleBackColor = True
        '
        'BtnAñadirHerraje
        '
        Me.BtnAñadirHerraje.Location = New System.Drawing.Point(49, 27)
        Me.BtnAñadirHerraje.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAñadirHerraje.Name = "BtnAñadirHerraje"
        Me.BtnAñadirHerraje.Size = New System.Drawing.Size(119, 28)
        Me.BtnAñadirHerraje.TabIndex = 4
        Me.BtnAñadirHerraje.Text = " Añadir Herraje"
        Me.BtnAñadirHerraje.UseVisualStyleBackColor = True
        '
        'PresupuestoDetallePinturaDataGridView
        '
        Me.PresupuestoDetallePinturaDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetallePinturaDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetallePinturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetallePinturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.IdPinturaTipo, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.IdArticuloDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.CantidadArticulosDataGridViewTextBoxColumn, Me.CantidadSubarticuloDataGridViewTextBoxColumn, Me.CantidadElemntosDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.IdEmpresaDataGridViewTextBoxColumn, Me.PrecioCompraDataGridViewTextBoxColumn, Me.TotalCostoDataGridViewTextBoxColumn, Me.IdDetalleArticulosDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.CosumoArticuloDataGridViewTextBoxColumn, Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn, Me.TotalNecesidadarticuloDataGridViewTextBoxColumn, Me.TotalCostoArticuloDataGridViewTextBoxColumn, Me.CosumoPresupuestoDataGridViewTextBoxColumn, Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn, Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn, Me.TotalCostoPresupuestoDataGridViewTextBoxColumn})
        Me.PresupuestoDetallePinturaDataGridView.DataSource = Me.PresupuestoDetallePinturaBindingSource
        Me.PresupuestoDetallePinturaDataGridView.Location = New System.Drawing.Point(696, 58)
        Me.PresupuestoDetallePinturaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PresupuestoDetallePinturaDataGridView.Name = "PresupuestoDetallePinturaDataGridView"
        Me.PresupuestoDetallePinturaDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetallePinturaDataGridView.Size = New System.Drawing.Size(648, 271)
        Me.PresupuestoDetallePinturaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdPinturaTipoPresupuesto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdPinturaTipoPresupuesto"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'IdPinturaTipo
        '
        Me.IdPinturaTipo.DataPropertyName = "IdPinturaTipo"
        Me.IdPinturaTipo.DataSource = Me.PinturaAplicacionBindingSource
        Me.IdPinturaTipo.DisplayMember = "Descripcion"
        Me.IdPinturaTipo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdPinturaTipo.HeaderText = "IdPinturaTipo"
        Me.IdPinturaTipo.MinimumWidth = 6
        Me.IdPinturaTipo.Name = "IdPinturaTipo"
        Me.IdPinturaTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdPinturaTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdPinturaTipo.ValueMember = "IdPinturaTipo"
        Me.IdPinturaTipo.Width = 125
        '
        'PinturaAplicacionBindingSource
        '
        Me.PinturaAplicacionBindingSource.DataMember = "PinturaAplicacion"
        Me.PinturaAplicacionBindingSource.DataSource = Me.DsPinturaAplicacion
        '
        'DsPinturaAplicacion
        '
        Me.DsPinturaAplicacion.DataSetName = "DsPinturaAplicacion"
        Me.DsPinturaAplicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IdPresupuesto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IdPresupuesto"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IdDetallePresupuesto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IdDetallePresupuesto"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'IdArticuloDataGridViewTextBoxColumn
        '
        Me.IdArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo"
        Me.IdArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo"
        Me.IdArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdArticuloDataGridViewTextBoxColumn.Name = "IdArticuloDataGridViewTextBoxColumn"
        Me.IdArticuloDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdArticuloDataGridViewTextBoxColumn.Visible = False
        Me.IdArticuloDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IdsubArticulo"
        Me.DataGridViewTextBoxColumn14.DataSource = Me.SubArticulosBindingSource
        Me.DataGridViewTextBoxColumn14.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn14.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn14.HeaderText = "IdsubArticulo"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn14.ValueMember = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn14.Width = 125
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
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'CantidadArticulosDataGridViewTextBoxColumn
        '
        Me.CantidadArticulosDataGridViewTextBoxColumn.DataPropertyName = "CantidadArticulos"
        Me.CantidadArticulosDataGridViewTextBoxColumn.HeaderText = "CantidadArticulos"
        Me.CantidadArticulosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadArticulosDataGridViewTextBoxColumn.Name = "CantidadArticulosDataGridViewTextBoxColumn"
        Me.CantidadArticulosDataGridViewTextBoxColumn.Visible = False
        Me.CantidadArticulosDataGridViewTextBoxColumn.Width = 125
        '
        'CantidadSubarticuloDataGridViewTextBoxColumn
        '
        Me.CantidadSubarticuloDataGridViewTextBoxColumn.DataPropertyName = "CantidadSubarticulo"
        Me.CantidadSubarticuloDataGridViewTextBoxColumn.HeaderText = "CantidadSubarticulo"
        Me.CantidadSubarticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadSubarticuloDataGridViewTextBoxColumn.Name = "CantidadSubarticuloDataGridViewTextBoxColumn"
        Me.CantidadSubarticuloDataGridViewTextBoxColumn.Visible = False
        Me.CantidadSubarticuloDataGridViewTextBoxColumn.Width = 125
        '
        'CantidadElemntosDataGridViewTextBoxColumn
        '
        Me.CantidadElemntosDataGridViewTextBoxColumn.DataPropertyName = "CantidadElemntos"
        Me.CantidadElemntosDataGridViewTextBoxColumn.HeaderText = "CantidadElemntos"
        Me.CantidadElemntosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadElemntosDataGridViewTextBoxColumn.Name = "CantidadElemntosDataGridViewTextBoxColumn"
        Me.CantidadElemntosDataGridViewTextBoxColumn.Visible = False
        Me.CantidadElemntosDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IdPinturaComponente"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IdPinturaComponente"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "MetrosCuadrados"
        Me.DataGridViewTextBoxColumn17.HeaderText = "MetrosCuadrados"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ConsumoPorMetro"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ConsumoPorMetro"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TotalConsumo"
        Me.DataGridViewTextBoxColumn19.HeaderText = "TotalConsumo"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Desperdicio"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Desperdicio"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TotalNecesidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "TotalNecesidad"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'IdEmpresaDataGridViewTextBoxColumn
        '
        Me.IdEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Id_Empresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.HeaderText = "Id_Empresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpresaDataGridViewTextBoxColumn.Name = "IdEmpresaDataGridViewTextBoxColumn"
        Me.IdEmpresaDataGridViewTextBoxColumn.Visible = False
        Me.IdEmpresaDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioCompraDataGridViewTextBoxColumn
        '
        Me.PrecioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra"
        Me.PrecioCompraDataGridViewTextBoxColumn.HeaderText = "PrecioCompra"
        Me.PrecioCompraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioCompraDataGridViewTextBoxColumn.Name = "PrecioCompraDataGridViewTextBoxColumn"
        Me.PrecioCompraDataGridViewTextBoxColumn.Visible = False
        Me.PrecioCompraDataGridViewTextBoxColumn.Width = 125
        '
        'TotalCostoDataGridViewTextBoxColumn
        '
        Me.TotalCostoDataGridViewTextBoxColumn.DataPropertyName = "TotalCosto"
        Me.TotalCostoDataGridViewTextBoxColumn.HeaderText = "TotalCosto"
        Me.TotalCostoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCostoDataGridViewTextBoxColumn.Name = "TotalCostoDataGridViewTextBoxColumn"
        Me.TotalCostoDataGridViewTextBoxColumn.Visible = False
        Me.TotalCostoDataGridViewTextBoxColumn.Width = 125
        '
        'IdDetalleArticulosDataGridViewTextBoxColumn
        '
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.DataPropertyName = "Id_Detalle_Articulos"
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.HeaderText = "Id_Detalle_Articulos"
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.Name = "IdDetalleArticulosDataGridViewTextBoxColumn"
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.Visible = False
        Me.IdDetalleArticulosDataGridViewTextBoxColumn.Width = 125
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Visible = False
        Me.CodigoDataGridViewTextBoxColumn.Width = 125
        '
        'CosumoArticuloDataGridViewTextBoxColumn
        '
        Me.CosumoArticuloDataGridViewTextBoxColumn.DataPropertyName = "CosumoArticulo"
        Me.CosumoArticuloDataGridViewTextBoxColumn.HeaderText = "CosumoArticulo"
        Me.CosumoArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CosumoArticuloDataGridViewTextBoxColumn.Name = "CosumoArticuloDataGridViewTextBoxColumn"
        Me.CosumoArticuloDataGridViewTextBoxColumn.Visible = False
        Me.CosumoArticuloDataGridViewTextBoxColumn.Width = 125
        '
        'TotalDesperdicioArticuloDataGridViewTextBoxColumn
        '
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn.DataPropertyName = "TotalDesperdicioArticulo"
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn.HeaderText = "TotalDesperdicioArticulo"
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn.Name = "TotalDesperdicioArticuloDataGridViewTextBoxColumn"
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn.Visible = False
        Me.TotalDesperdicioArticuloDataGridViewTextBoxColumn.Width = 125
        '
        'TotalNecesidadarticuloDataGridViewTextBoxColumn
        '
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn.DataPropertyName = "TotalNecesidadarticulo"
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn.HeaderText = "TotalNecesidadarticulo"
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn.Name = "TotalNecesidadarticuloDataGridViewTextBoxColumn"
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn.Visible = False
        Me.TotalNecesidadarticuloDataGridViewTextBoxColumn.Width = 125
        '
        'TotalCostoArticuloDataGridViewTextBoxColumn
        '
        Me.TotalCostoArticuloDataGridViewTextBoxColumn.DataPropertyName = "TotalCostoArticulo"
        Me.TotalCostoArticuloDataGridViewTextBoxColumn.HeaderText = "TotalCostoArticulo"
        Me.TotalCostoArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCostoArticuloDataGridViewTextBoxColumn.Name = "TotalCostoArticuloDataGridViewTextBoxColumn"
        Me.TotalCostoArticuloDataGridViewTextBoxColumn.Visible = False
        Me.TotalCostoArticuloDataGridViewTextBoxColumn.Width = 125
        '
        'CosumoPresupuestoDataGridViewTextBoxColumn
        '
        Me.CosumoPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "CosumoPresupuesto"
        Me.CosumoPresupuestoDataGridViewTextBoxColumn.HeaderText = "CosumoPresupuesto"
        Me.CosumoPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CosumoPresupuestoDataGridViewTextBoxColumn.Name = "CosumoPresupuestoDataGridViewTextBoxColumn"
        Me.CosumoPresupuestoDataGridViewTextBoxColumn.Visible = False
        Me.CosumoPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'TotalDesperdicioPresupuestoDataGridViewTextBoxColumn
        '
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "TotalDesperdicioPresupuesto"
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn.HeaderText = "TotalDesperdicioPresupuesto"
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn.Name = "TotalDesperdicioPresupuestoDataGridViewTextBoxColumn"
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn.Visible = False
        Me.TotalDesperdicioPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'TotalNecesidadPresupuestoDataGridViewTextBoxColumn
        '
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "TotalNecesidadPresupuesto"
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn.HeaderText = "TotalNecesidadPresupuesto"
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn.Name = "TotalNecesidadPresupuestoDataGridViewTextBoxColumn"
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn.Visible = False
        Me.TotalNecesidadPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'TotalCostoPresupuestoDataGridViewTextBoxColumn
        '
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "TotalCostoPresupuesto"
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn.HeaderText = "TotalCostoPresupuesto"
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn.Name = "TotalCostoPresupuestoDataGridViewTextBoxColumn"
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn.Visible = False
        Me.TotalCostoPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'PresupuestoDetallePinturaBindingSource
        '
        Me.PresupuestoDetallePinturaBindingSource.DataMember = "PresupuestoDetallePintura"
        Me.PresupuestoDetallePinturaBindingSource.DataSource = Me.DsPresupuestoDetallePintura
        '
        'DsPresupuestoDetallePintura
        '
        Me.DsPresupuestoDetallePintura.DataSetName = "DsPresupuestoDetallePintura"
        Me.DsPresupuestoDetallePintura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrabajoTallerM2PinturaArticuloBindingSource
        '
        Me.TrabajoTallerM2PinturaArticuloBindingSource.DataMember = "TrabajoTallerM2PinturaArticulo"
        Me.TrabajoTallerM2PinturaArticuloBindingSource.DataSource = Me.DsTrabajoTallerM2PinturaArticulo
        '
        'DsTrabajoTallerM2PinturaArticulo
        '
        Me.DsTrabajoTallerM2PinturaArticulo.DataSetName = "DsTrabajoTallerM2PinturaArticulo"
        Me.DsTrabajoTallerM2PinturaArticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.ArticulosBindingNavigator.Size = New System.Drawing.Size(1461, 27)
        Me.ArticulosBindingNavigator.TabIndex = 1
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(387, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(33, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Id Articulo"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(33, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Id Detalle Presupuesto"
        '
        'Descripcion_articuloTextBox
        '
        Me.Descripcion_articuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion_articulo", True))
        Me.Descripcion_articuloTextBox.Location = New System.Drawing.Point(493, 50)
        Me.Descripcion_articuloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion_articuloTextBox.Multiline = True
        Me.Descripcion_articuloTextBox.Name = "Descripcion_articuloTextBox"
        Me.Descripcion_articuloTextBox.Size = New System.Drawing.Size(801, 112)
        Me.Descripcion_articuloTextBox.TabIndex = 16
        '
        'IdArticuloTextBox
        '
        Me.IdArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "IdArticulo", True))
        Me.IdArticuloTextBox.Location = New System.Drawing.Point(205, 92)
        Me.IdArticuloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdArticuloTextBox.Name = "IdArticuloTextBox"
        Me.IdArticuloTextBox.Size = New System.Drawing.Size(172, 22)
        Me.IdArticuloTextBox.TabIndex = 15
        '
        'TxtdDetallePresupuesto
        '
        Me.TxtdDetallePresupuesto.AcceptsReturn = True
        Me.TxtdDetallePresupuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "IdDetalle_Presupuesto", True))
        Me.TxtdDetallePresupuesto.Location = New System.Drawing.Point(205, 48)
        Me.TxtdDetallePresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtdDetallePresupuesto.Name = "TxtdDetallePresupuesto"
        Me.TxtdDetallePresupuesto.Size = New System.Drawing.Size(172, 22)
        Me.TxtdDetallePresupuesto.TabIndex = 14
        '
        'PresupuestoDetalleHerrajesTableAdapter
        '
        Me.PresupuestoDetalleHerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PresupuestoDetalleHerrajesTableAdapter = Me.PresupuestoDetalleHerrajesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HerrajesTableAdapter
        '
        Me.HerrajesTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDetallePinturaTableAdapter
        '
        Me.PresupuestoDetallePinturaTableAdapter.ClearBeforeFill = True
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'TrabajoTallerM2PinturaArticuloTableAdapter
        '
        Me.TrabajoTallerM2PinturaArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PinturaAplicacionTableAdapter
        '
        Me.PinturaAplicacionTableAdapter.ClearBeforeFill = True
        '
        'FrmIngresoHerrajePintura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 590)
        Me.Controls.Add(Me.Descripcion_articuloTextBox)
        Me.Controls.Add(Me.IdArticuloTextBox)
        Me.Controls.Add(Me.TxtdDetallePresupuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ArticulosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmIngresoHerrajePintura"
        Me.Text = "FrmIngresoHerrajePintura1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PresupuestoDetalleHerrajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetallePinturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaAplicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturaAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajoTallerM2PinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTrabajoTallerM2PinturaArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArticulosBindingNavigator.ResumeLayout(False)
        Me.ArticulosBindingNavigator.PerformLayout()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents DsPresupuestoDetalleHerrajes As ModuloGestion.DsPresupuestoDetalleHerrajes
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn


    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents BtnAñadirPintura As System.Windows.Forms.Button
    Friend WithEvents BtnAñadirHerraje As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Descripcion_articuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TxtdDetallePresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents PresupuestoDetallePinturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn



    Friend WithEvents IdPinturaTipoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProyectoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDetallePresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdsubArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IddetalleSubArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPinturaComponenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetrosCuadradosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumoPorMetroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalConsumoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesperdicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDesperdicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNecesidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsHerrajes As ModuloGestion.DsHerrajes
    Friend WithEvents HerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesTableAdapter As ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter
    Friend WithEvents DsPresupuestoDetallePintura As ModuloGestion.DsPresupuestoDetallePintura
    Friend WithEvents PresupuestoDetallePinturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetallePinturaTableAdapter As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents DsTrabajoTallerM2PinturaArticulo As ModuloGestion.DsTrabajoTallerM2PinturaArticulo
    Friend WithEvents TrabajoTallerM2PinturaArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrabajoTallerM2PinturaArticuloTableAdapter As ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TrabajoTallerM2PinturaArticuloTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsTrabajoTallerM2PinturaArticuloTableAdapters.TableAdapterManager
    Friend WithEvents DsPinturaAplicacion As ModuloGestion.DsPinturaAplicacion
    Friend WithEvents PinturaAplicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaAplicacionTableAdapter As ModuloGestion.DsPinturaAplicacionTableAdapters.PinturaAplicacionTableAdapter
    Friend WithEvents LblTipoPinturaPresupuestada As System.Windows.Forms.Label
    Friend WithEvents PresupuestoDetalleHerrajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPinturaTipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadArticulosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadSubarticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadElemntosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleArticulosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosumoArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDesperdicioArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNecesidadarticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostoArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosumoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDesperdicioPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNecesidadPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_detalle_Herrajes As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
End Class
