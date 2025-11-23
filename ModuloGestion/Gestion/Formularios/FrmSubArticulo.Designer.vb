<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubArticulo
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
        Dim M2PinturaLabel As System.Windows.Forms.Label
        Dim MontajeLabel As System.Windows.Forms.Label
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubArticulo))
        Me.Id_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.Descripcion_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.Minutos__Trabajo_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MontajeTextBox = New System.Windows.Forms.TextBox()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.LblGrupo = New System.Windows.Forms.Label()
        Me.DgwSubarticuloDetalle = New System.Windows.Forms.DataGridView()
        Me.SubIddetalleSubArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubIdSubArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubIddescripcionDetalle = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DescripcionesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDescripcionesdetalle = New ModuloGestion.DsDescripcionesdetalle()
        Me.SubIdMaterialDetalle = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.SubCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubLargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubAncho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGrueso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubIdMedida = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.SubPiesLargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubAnchopulgadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubGruesoPulgadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubPiesUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubM2Cara = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubM2Canto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubM2Cabeza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubConsumoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubM2PinuturaUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubM2PinuturaUnidadtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubDesperdicioMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDesperdicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.BtnCambioMAterial = New System.Windows.Forms.Button()
        Me.TxtIdGrupo = New System.Windows.Forms.TextBox()
        Me.TxtTiempoTrabajo = New System.Windows.Forms.TextBox()
        Me.TxtIdSubarticulo = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DgwFerreteriaDetalle = New System.Windows.Forms.DataGridView()
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSubArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFerreteria = New ModuloGestion.DsFerreteria()
        Me.CantidadFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosDetalleFerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulosFerreteria = New ModuloGestion.DsSubArticulosFerreteria()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.TxtM2Pintura = New System.Windows.Forms.TextBox()
        Me.BtnAñadirFerreteria = New System.Windows.Forms.Button()
        Me.CmdFerreteria = New System.Windows.Forms.Button()
        Me.Id_Material_Detalle = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PiesLargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anchopulgadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GruesoPulgadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PiesUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2Cara = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2Canto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2Cabeza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnDuplicarRegistro = New System.Windows.Forms.Button()
        Me.SubArticulosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SubArticulosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SubArticulosDetalleFerreteriaTableAdapter = New ModuloGestion.DsSubArticulosFerreteriaTableAdapters.SubArticulosDetalleFerreteriaTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsSubArticulosFerreteriaTableAdapters.TableAdapterManager()
        Me.FerreteriaTableAdapter = New ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter()
        Me.TableAdapterManager10 = New ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager()
        Me.DsMaterialMedidadCompra = New ModuloGestion.DsMaterialMedidadCompra()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.DsDescripciones = New ModuloGestion.DsDescripciones()
        Me.DescripcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionesTableAdapter = New ModuloGestion.DsDescripcionesTableAdapters.DescripcionesTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.DescripcionesDetalleTableAdapter = New ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        M2PinturaLabel = New System.Windows.Forms.Label()
        MontajeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwSubarticuloDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwFerreteriaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFerreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosFerreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubArticulosBindingNavigator.SuspendLayout()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDescripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'M2PinturaLabel
        '
        M2PinturaLabel.AutoSize = True
        M2PinturaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        M2PinturaLabel.Location = New System.Drawing.Point(528, 34)
        M2PinturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        M2PinturaLabel.Name = "M2PinturaLabel"
        M2PinturaLabel.Size = New System.Drawing.Size(71, 18)
        M2PinturaLabel.TabIndex = 44
        M2PinturaLabel.Text = "M2Pintura:"
        '
        'MontajeLabel
        '
        MontajeLabel.AutoSize = True
        MontajeLabel.Location = New System.Drawing.Point(708, 34)
        MontajeLabel.Name = "MontajeLabel"
        MontajeLabel.Size = New System.Drawing.Size(58, 16)
        MontajeLabel.TabIndex = 54
        MontajeLabel.Text = "Montaje:"
        '
        'Id_Sub_ArticuloLabel
        '
        Me.Id_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Id_Sub_ArticuloLabel.Location = New System.Drawing.Point(8, 27)
        Me.Id_Sub_ArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Id_Sub_ArticuloLabel.Name = "Id_Sub_ArticuloLabel"
        Me.Id_Sub_ArticuloLabel.Size = New System.Drawing.Size(139, 25)
        Me.Id_Sub_ArticuloLabel.TabIndex = 0
        Me.Id_Sub_ArticuloLabel.Text = "Id Sub Articulo:"
        '
        'Descripcion_Sub_ArticuloLabel
        '
        Me.Descripcion_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Descripcion_Sub_ArticuloLabel.Location = New System.Drawing.Point(8, 57)
        Me.Descripcion_Sub_ArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Descripcion_Sub_ArticuloLabel.Name = "Descripcion_Sub_ArticuloLabel"
        Me.Descripcion_Sub_ArticuloLabel.Size = New System.Drawing.Size(139, 25)
        Me.Descripcion_Sub_ArticuloLabel.TabIndex = 2
        Me.Descripcion_Sub_ArticuloLabel.Text = "Descripcion "
        '
        'Minutos__Trabajo_Sub_ArticuloLabel
        '
        Me.Minutos__Trabajo_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Location = New System.Drawing.Point(312, 31)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Name = "Minutos__Trabajo_Sub_ArticuloLabel"
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Size = New System.Drawing.Size(120, 25)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.TabIndex = 6
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Text = "Minutos  Trabajo Sub Articulo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(MontajeLabel)
        Me.GroupBox1.Controls.Add(Me.MontajeTextBox)
        Me.GroupBox1.Controls.Add(Me.LblGrupo)
        Me.GroupBox1.Controls.Add(Me.DgwSubarticuloDetalle)
        Me.GroupBox1.Controls.Add(Me.BtnCambioMAterial)
        Me.GroupBox1.Controls.Add(Me.TxtIdGrupo)
        Me.GroupBox1.Controls.Add(Me.TxtTiempoTrabajo)
        Me.GroupBox1.Controls.Add(Me.TxtIdSubarticulo)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DgwFerreteriaDetalle)
        Me.GroupBox1.Controls.Add(Me.CmdNuevo)
        Me.GroupBox1.Controls.Add(Me.Id_Sub_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.Descripcion_Sub_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.Minutos__Trabajo_Sub_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.TxtM2Pintura)
        Me.GroupBox1.Controls.Add(M2PinturaLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1837, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generales SubArticulo"
        '
        'MontajeTextBox
        '
        Me.MontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Montaje", True))
        Me.MontajeTextBox.Location = New System.Drawing.Point(776, 32)
        Me.MontajeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MontajeTextBox.Name = "MontajeTextBox"
        Me.MontajeTextBox.Size = New System.Drawing.Size(84, 22)
        Me.MontajeTextBox.TabIndex = 55
        Me.MontajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'LblGrupo
        '
        Me.LblGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblGrupo.Location = New System.Drawing.Point(653, 65)
        Me.LblGrupo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGrupo.Name = "LblGrupo"
        Me.LblGrupo.Size = New System.Drawing.Size(316, 25)
        Me.LblGrupo.TabIndex = 54
        Me.LblGrupo.Text = "Grupo "
        '
        'DgwSubarticuloDetalle
        '
        Me.DgwSubarticuloDetalle.AllowUserToAddRows = False
        Me.DgwSubarticuloDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgwSubarticuloDetalle.AutoGenerateColumns = False
        Me.DgwSubarticuloDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwSubarticuloDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubIddetalleSubArticulo, Me.SubIdSubArticulo, Me.SubIddescripcionDetalle, Me.SubIdMaterialDetalle, Me.SubCantidad, Me.SubLargo, Me.SubAncho, Me.SubGrueso, Me.SubIdMedida, Me.SubPiesLargo, Me.SubAnchopulgadas, Me.SubGruesoPulgadas, Me.SubPiesUnidad, Me.SubM2Cara, Me.SubM2Canto, Me.SubM2Cabeza, Me.SubConsumoTotal, Me.SubM2PinuturaUnidad, Me.SubM2PinuturaUnidadtotal, Me.SubDesperdicioMaterial, Me.SubTotalDesperdicio, Me.SubTotalCompra})
        Me.DgwSubarticuloDetalle.DataSource = Me.SubArticulosDetalleBindingSource
        Me.DgwSubarticuloDetalle.Location = New System.Drawing.Point(8, 129)
        Me.DgwSubarticuloDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DgwSubarticuloDetalle.Name = "DgwSubarticuloDetalle"
        Me.DgwSubarticuloDetalle.RowHeadersWidth = 51
        Me.DgwSubarticuloDetalle.Size = New System.Drawing.Size(1821, 195)
        Me.DgwSubarticuloDetalle.TabIndex = 53
        '
        'SubIddetalleSubArticulo
        '
        Me.SubIddetalleSubArticulo.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.SubIddetalleSubArticulo.HeaderText = "Id Detalle"
        Me.SubIddetalleSubArticulo.MinimumWidth = 6
        Me.SubIddetalleSubArticulo.Name = "SubIddetalleSubArticulo"
        Me.SubIddetalleSubArticulo.Width = 125
        '
        'SubIdSubArticulo
        '
        Me.SubIdSubArticulo.DataPropertyName = "Id_Sub_Articulo"
        Me.SubIdSubArticulo.HeaderText = "Id_Sub_Articulo"
        Me.SubIdSubArticulo.MinimumWidth = 6
        Me.SubIdSubArticulo.Name = "SubIdSubArticulo"
        Me.SubIdSubArticulo.Visible = False
        Me.SubIdSubArticulo.Width = 125
        '
        'SubIddescripcionDetalle
        '
        Me.SubIddescripcionDetalle.DataPropertyName = "Id_descripcion_Detalle"
        Me.SubIddescripcionDetalle.DataSource = Me.DescripcionesDetalleBindingSource
        Me.SubIddescripcionDetalle.DisplayMember = "Descripcion"
        Me.SubIddescripcionDetalle.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SubIddescripcionDetalle.HeaderText = "Descripcion"
        Me.SubIddescripcionDetalle.MinimumWidth = 6
        Me.SubIddescripcionDetalle.Name = "SubIddescripcionDetalle"
        Me.SubIddescripcionDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubIddescripcionDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SubIddescripcionDetalle.ValueMember = "Id_descripcion_Detalle"
        Me.SubIddescripcionDetalle.Width = 250
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
        'SubIdMaterialDetalle
        '
        Me.SubIdMaterialDetalle.DataPropertyName = "Id_Material_Detalle"
        Me.SubIdMaterialDetalle.DataSource = Me.MaterilaesDetalleBindingSource
        Me.SubIdMaterialDetalle.DisplayMember = "Descripcion"
        Me.SubIdMaterialDetalle.HeaderText = "Material"
        Me.SubIdMaterialDetalle.MinimumWidth = 6
        Me.SubIdMaterialDetalle.Name = "SubIdMaterialDetalle"
        Me.SubIdMaterialDetalle.ReadOnly = True
        Me.SubIdMaterialDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubIdMaterialDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SubIdMaterialDetalle.ValueMember = "Id_Material_Detalle"
        Me.SubIdMaterialDetalle.Width = 250
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
        'SubCantidad
        '
        Me.SubCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.SubCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubCantidad.HeaderText = "Cantidad"
        Me.SubCantidad.MinimumWidth = 6
        Me.SubCantidad.Name = "SubCantidad"
        Me.SubCantidad.Width = 75
        '
        'SubLargo
        '
        Me.SubLargo.DataPropertyName = "Largo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.SubLargo.DefaultCellStyle = DataGridViewCellStyle2
        Me.SubLargo.HeaderText = "Largo"
        Me.SubLargo.MinimumWidth = 6
        Me.SubLargo.Name = "SubLargo"
        Me.SubLargo.Width = 75
        '
        'SubAncho
        '
        Me.SubAncho.DataPropertyName = "Ancho"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.SubAncho.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubAncho.HeaderText = "Ancho"
        Me.SubAncho.MinimumWidth = 6
        Me.SubAncho.Name = "SubAncho"
        Me.SubAncho.Width = 75
        '
        'SubGrueso
        '
        Me.SubGrueso.DataPropertyName = "Grueso"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.SubGrueso.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubGrueso.HeaderText = "Grueso"
        Me.SubGrueso.MinimumWidth = 6
        Me.SubGrueso.Name = "SubGrueso"
        Me.SubGrueso.Width = 75
        '
        'SubIdMedida
        '
        Me.SubIdMedida.DataPropertyName = "Id_Medida"
        Me.SubIdMedida.DataSource = Me.MedidasCompraBindingSource
        Me.SubIdMedida.DisplayMember = "Descripcion_Medida"
        Me.SubIdMedida.HeaderText = "Medida Compra"
        Me.SubIdMedida.MinimumWidth = 6
        Me.SubIdMedida.Name = "SubIdMedida"
        Me.SubIdMedida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubIdMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SubIdMedida.ValueMember = "Id_Medida"
        Me.SubIdMedida.Width = 150
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
        'SubPiesLargo
        '
        Me.SubPiesLargo.DataPropertyName = "PiesLargo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.SubPiesLargo.DefaultCellStyle = DataGridViewCellStyle5
        Me.SubPiesLargo.HeaderText = "Pies Largo"
        Me.SubPiesLargo.MinimumWidth = 6
        Me.SubPiesLargo.Name = "SubPiesLargo"
        Me.SubPiesLargo.ReadOnly = True
        Me.SubPiesLargo.Width = 75
        '
        'SubAnchopulgadas
        '
        Me.SubAnchopulgadas.DataPropertyName = "Anchopulgadas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.SubAnchopulgadas.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubAnchopulgadas.HeaderText = "Ancho Pulgadas"
        Me.SubAnchopulgadas.MinimumWidth = 6
        Me.SubAnchopulgadas.Name = "SubAnchopulgadas"
        Me.SubAnchopulgadas.ReadOnly = True
        Me.SubAnchopulgadas.Width = 75
        '
        'SubGruesoPulgadas
        '
        Me.SubGruesoPulgadas.DataPropertyName = "GruesoPulgadas"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.SubGruesoPulgadas.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubGruesoPulgadas.HeaderText = "Grueso Pulgadas"
        Me.SubGruesoPulgadas.MinimumWidth = 6
        Me.SubGruesoPulgadas.Name = "SubGruesoPulgadas"
        Me.SubGruesoPulgadas.ReadOnly = True
        Me.SubGruesoPulgadas.Width = 75
        '
        'SubPiesUnidad
        '
        Me.SubPiesUnidad.DataPropertyName = "PiesUnidad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.SubPiesUnidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.SubPiesUnidad.HeaderText = "Pies Unidad"
        Me.SubPiesUnidad.MinimumWidth = 6
        Me.SubPiesUnidad.Name = "SubPiesUnidad"
        Me.SubPiesUnidad.ReadOnly = True
        Me.SubPiesUnidad.Width = 75
        '
        'SubM2Cara
        '
        Me.SubM2Cara.DataPropertyName = "M2Cara"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n4"
        Me.SubM2Cara.DefaultCellStyle = DataGridViewCellStyle9
        Me.SubM2Cara.HeaderText = "M2 Cara"
        Me.SubM2Cara.MinimumWidth = 6
        Me.SubM2Cara.Name = "SubM2Cara"
        Me.SubM2Cara.ReadOnly = True
        Me.SubM2Cara.Width = 75
        '
        'SubM2Canto
        '
        Me.SubM2Canto.DataPropertyName = "M2Canto"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n4"
        Me.SubM2Canto.DefaultCellStyle = DataGridViewCellStyle10
        Me.SubM2Canto.HeaderText = "M2 Canto"
        Me.SubM2Canto.MinimumWidth = 6
        Me.SubM2Canto.Name = "SubM2Canto"
        Me.SubM2Canto.ReadOnly = True
        Me.SubM2Canto.Width = 75
        '
        'SubM2Cabeza
        '
        Me.SubM2Cabeza.DataPropertyName = "M2Cabeza"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n4"
        Me.SubM2Cabeza.DefaultCellStyle = DataGridViewCellStyle11
        Me.SubM2Cabeza.HeaderText = "M2Cabeza"
        Me.SubM2Cabeza.MinimumWidth = 6
        Me.SubM2Cabeza.Name = "SubM2Cabeza"
        Me.SubM2Cabeza.ReadOnly = True
        Me.SubM2Cabeza.Width = 75
        '
        'SubConsumoTotal
        '
        Me.SubConsumoTotal.DataPropertyName = "ConsumoTotal"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.SubConsumoTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.SubConsumoTotal.HeaderText = "Consumo Total"
        Me.SubConsumoTotal.MinimumWidth = 6
        Me.SubConsumoTotal.Name = "SubConsumoTotal"
        Me.SubConsumoTotal.ReadOnly = True
        Me.SubConsumoTotal.Width = 75
        '
        'SubM2PinuturaUnidad
        '
        Me.SubM2PinuturaUnidad.DataPropertyName = "M2PinuturaUnidad"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle13.Format = "n4"
        Me.SubM2PinuturaUnidad.DefaultCellStyle = DataGridViewCellStyle13
        Me.SubM2PinuturaUnidad.HeaderText = "M2 Pinutura Unidad"
        Me.SubM2PinuturaUnidad.MinimumWidth = 6
        Me.SubM2PinuturaUnidad.Name = "SubM2PinuturaUnidad"
        Me.SubM2PinuturaUnidad.ReadOnly = True
        Me.SubM2PinuturaUnidad.Width = 75
        '
        'SubM2PinuturaUnidadtotal
        '
        Me.SubM2PinuturaUnidadtotal.DataPropertyName = "M2PinuturaUnidadtotal"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle14.Format = "n4"
        Me.SubM2PinuturaUnidadtotal.DefaultCellStyle = DataGridViewCellStyle14
        Me.SubM2PinuturaUnidadtotal.HeaderText = "M2 Pinutura Unidad Total"
        Me.SubM2PinuturaUnidadtotal.MinimumWidth = 6
        Me.SubM2PinuturaUnidadtotal.Name = "SubM2PinuturaUnidadtotal"
        Me.SubM2PinuturaUnidadtotal.ReadOnly = True
        Me.SubM2PinuturaUnidadtotal.Width = 75
        '
        'SubDesperdicioMaterial
        '
        Me.SubDesperdicioMaterial.DataPropertyName = "DesperdicioMaterial"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle15.Format = "n2"
        Me.SubDesperdicioMaterial.DefaultCellStyle = DataGridViewCellStyle15
        Me.SubDesperdicioMaterial.HeaderText = "Desperdicio Material"
        Me.SubDesperdicioMaterial.MinimumWidth = 6
        Me.SubDesperdicioMaterial.Name = "SubDesperdicioMaterial"
        Me.SubDesperdicioMaterial.ReadOnly = True
        Me.SubDesperdicioMaterial.Width = 75
        '
        'SubTotalDesperdicio
        '
        Me.SubTotalDesperdicio.DataPropertyName = "TotalDesperdicio"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle16.Format = "n2"
        Me.SubTotalDesperdicio.DefaultCellStyle = DataGridViewCellStyle16
        Me.SubTotalDesperdicio.HeaderText = "Total Desperdicio"
        Me.SubTotalDesperdicio.MinimumWidth = 6
        Me.SubTotalDesperdicio.Name = "SubTotalDesperdicio"
        Me.SubTotalDesperdicio.ReadOnly = True
        Me.SubTotalDesperdicio.Width = 75
        '
        'SubTotalCompra
        '
        Me.SubTotalCompra.DataPropertyName = "TotalCompra"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle17.Format = "n2"
        Me.SubTotalCompra.DefaultCellStyle = DataGridViewCellStyle17
        Me.SubTotalCompra.HeaderText = "Total Compra"
        Me.SubTotalCompra.MinimumWidth = 6
        Me.SubTotalCompra.Name = "SubTotalCompra"
        Me.SubTotalCompra.Width = 75
        '
        'SubArticulosDetalleBindingSource
        '
        Me.SubArticulosDetalleBindingSource.DataMember = "SubArticulosDetalle"
        Me.SubArticulosDetalleBindingSource.DataSource = Me.DsSubArticulosDetalle
        '
        'DsSubArticulosDetalle
        '
        Me.DsSubArticulosDetalle.DataSetName = "DsSubArticulosDetalle"
        Me.DsSubArticulosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnCambioMAterial
        '
        Me.BtnCambioMAterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCambioMAterial.Location = New System.Drawing.Point(852, 94)
        Me.BtnCambioMAterial.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCambioMAterial.Name = "BtnCambioMAterial"
        Me.BtnCambioMAterial.Size = New System.Drawing.Size(135, 28)
        Me.BtnCambioMAterial.TabIndex = 51
        Me.BtnCambioMAterial.Text = "Cambio Material"
        Me.BtnCambioMAterial.UseVisualStyleBackColor = True
        '
        'TxtIdGrupo
        '
        Me.TxtIdGrupo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "GrupoSubArticulos", True))
        Me.TxtIdGrupo.Location = New System.Drawing.Point(856, 94)
        Me.TxtIdGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdGrupo.Name = "TxtIdGrupo"
        Me.TxtIdGrupo.Size = New System.Drawing.Size(112, 22)
        Me.TxtIdGrupo.TabIndex = 49
        Me.TxtIdGrupo.WordWrap = False
        '
        'TxtTiempoTrabajo
        '
        Me.TxtTiempoTrabajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Minutos _Trabajo_Sub_Articulo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TxtTiempoTrabajo.Location = New System.Drawing.Point(441, 31)
        Me.TxtTiempoTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTiempoTrabajo.Name = "TxtTiempoTrabajo"
        Me.TxtTiempoTrabajo.Size = New System.Drawing.Size(77, 22)
        Me.TxtTiempoTrabajo.TabIndex = 43
        Me.TxtTiempoTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIdSubarticulo
        '
        Me.TxtIdSubarticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Id_Sub_Articulo", True))
        Me.TxtIdSubarticulo.Enabled = False
        Me.TxtIdSubarticulo.Location = New System.Drawing.Point(155, 31)
        Me.TxtIdSubarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdSubarticulo.Name = "TxtIdSubarticulo"
        Me.TxtIdSubarticulo.Size = New System.Drawing.Size(148, 22)
        Me.TxtIdSubarticulo.TabIndex = 42
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Descripcion_Sub_Articulo", True))
        Me.TxtDescripcion.Location = New System.Drawing.Point(155, 63)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(364, 54)
        Me.TxtDescripcion.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(867, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 28)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Nuevo Grupo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(525, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Grupo "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(528, 94)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 28)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Nuevo Material"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DgwFerreteriaDetalle
        '
        Me.DgwFerreteriaDetalle.AllowUserToAddRows = False
        Me.DgwFerreteriaDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgwFerreteriaDetalle.AutoGenerateColumns = False
        Me.DgwFerreteriaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwFerreteriaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddetalleFerreteriaDataGridViewTextBoxColumn, Me.IdSubArticuloDataGridViewTextBoxColumn, Me.IdEementoFerreteriaDataGridViewTextBoxColumn, Me.CantidadFerreteriaDataGridViewTextBoxColumn})
        Me.DgwFerreteriaDetalle.DataSource = Me.SubArticulosDetalleFerreteriaBindingSource
        Me.DgwFerreteriaDetalle.Location = New System.Drawing.Point(982, 7)
        Me.DgwFerreteriaDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DgwFerreteriaDetalle.Name = "DgwFerreteriaDetalle"
        Me.DgwFerreteriaDetalle.RowHeadersWidth = 51
        Me.DgwFerreteriaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwFerreteriaDetalle.Size = New System.Drawing.Size(700, 174)
        Me.DgwFerreteriaDetalle.TabIndex = 21
        '
        'IddetalleFerreteriaDataGridViewTextBoxColumn
        '
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Id_detalle_Ferreteria"
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.HeaderText = "Id detalle"
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.Name = "IddetalleFerreteriaDataGridViewTextBoxColumn"
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.Width = 125
        '
        'IdSubArticuloDataGridViewTextBoxColumn
        '
        Me.IdSubArticuloDataGridViewTextBoxColumn.DataPropertyName = "Id_SubArticulo"
        Me.IdSubArticuloDataGridViewTextBoxColumn.HeaderText = "Id_SubArticulo"
        Me.IdSubArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdSubArticuloDataGridViewTextBoxColumn.Name = "IdSubArticuloDataGridViewTextBoxColumn"
        Me.IdSubArticuloDataGridViewTextBoxColumn.Visible = False
        Me.IdSubArticuloDataGridViewTextBoxColumn.Width = 125
        '
        'IdEementoFerreteriaDataGridViewTextBoxColumn
        '
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Eemento_Ferreteria"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DataSource = Me.FerreteriaBindingSource
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DisplayMember = "Descripcion_Eemento_Ferreteria"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.Name = "IdEementoFerreteriaDataGridViewTextBoxColumn"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.ValueMember = "IdFerreteria"
        '
        'FerreteriaBindingSource
        '
        Me.FerreteriaBindingSource.DataMember = "Ferreteria"
        Me.FerreteriaBindingSource.DataSource = Me.DsFerreteria
        '
        'DsFerreteria
        '
        Me.DsFerreteria.DataSetName = "DsFerreteria"
        Me.DsFerreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CantidadFerreteriaDataGridViewTextBoxColumn
        '
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Ferreteria"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle18.Format = "n0"
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.Name = "CantidadFerreteriaDataGridViewTextBoxColumn"
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.Width = 75
        '
        'SubArticulosDetalleFerreteriaBindingSource
        '
        Me.SubArticulosDetalleFerreteriaBindingSource.DataMember = "SubArticulosDetalleFerreteria"
        Me.SubArticulosDetalleFerreteriaBindingSource.DataSource = Me.DsSubArticulosFerreteria
        '
        'DsSubArticulosFerreteria
        '
        Me.DsSubArticulosFerreteria.DataSetName = "DsSubArticulosFerreteria"
        Me.DsSubArticulosFerreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Location = New System.Drawing.Point(8, 90)
        Me.CmdNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(139, 28)
        Me.CmdNuevo.TabIndex = 12
        Me.CmdNuevo.Text = "Nuevo Elemento"
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'TxtM2Pintura
        '
        Me.TxtM2Pintura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "M2Pintura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TxtM2Pintura.Enabled = False
        Me.TxtM2Pintura.Location = New System.Drawing.Point(613, 31)
        Me.TxtM2Pintura.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtM2Pintura.Name = "TxtM2Pintura"
        Me.TxtM2Pintura.Size = New System.Drawing.Size(87, 22)
        Me.TxtM2Pintura.TabIndex = 45
        Me.TxtM2Pintura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAñadirFerreteria
        '
        Me.BtnAñadirFerreteria.Location = New System.Drawing.Point(1168, 41)
        Me.BtnAñadirFerreteria.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAñadirFerreteria.Name = "BtnAñadirFerreteria"
        Me.BtnAñadirFerreteria.Size = New System.Drawing.Size(129, 28)
        Me.BtnAñadirFerreteria.TabIndex = 52
        Me.BtnAñadirFerreteria.Text = "Añadir Ferreteria"
        Me.BtnAñadirFerreteria.UseVisualStyleBackColor = True
        '
        'CmdFerreteria
        '
        Me.CmdFerreteria.Location = New System.Drawing.Point(993, 41)
        Me.CmdFerreteria.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdFerreteria.Name = "CmdFerreteria"
        Me.CmdFerreteria.Size = New System.Drawing.Size(167, 28)
        Me.CmdFerreteria.TabIndex = 22
        Me.CmdFerreteria.Text = "Ocultar Ferreteria "
        Me.CmdFerreteria.UseVisualStyleBackColor = True
        '
        'Id_Material_Detalle
        '
        Me.Id_Material_Detalle.DataPropertyName = "Id_Material_Detalle"
        Me.Id_Material_Detalle.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Id_Material_Detalle.HeaderText = "Material"
        Me.Id_Material_Detalle.MinimumWidth = 6
        Me.Id_Material_Detalle.Name = "Id_Material_Detalle"
        Me.Id_Material_Detalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Material_Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Id_Material_Detalle.Width = 200
        '
        'PiesLargo
        '
        Me.PiesLargo.DataPropertyName = "PiesLargo"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0"
        Me.PiesLargo.DefaultCellStyle = DataGridViewCellStyle19
        Me.PiesLargo.HeaderText = "PiesLargo"
        Me.PiesLargo.MinimumWidth = 6
        Me.PiesLargo.Name = "PiesLargo"
        Me.PiesLargo.Width = 125
        '
        'Anchopulgadas
        '
        Me.Anchopulgadas.DataPropertyName = "Anchopulgadas"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.Anchopulgadas.DefaultCellStyle = DataGridViewCellStyle20
        Me.Anchopulgadas.HeaderText = "Anchopulgadas"
        Me.Anchopulgadas.MinimumWidth = 6
        Me.Anchopulgadas.Name = "Anchopulgadas"
        Me.Anchopulgadas.Width = 125
        '
        'GruesoPulgadas
        '
        Me.GruesoPulgadas.DataPropertyName = "GruesoPulgadas"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0"
        DataGridViewCellStyle21.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.GruesoPulgadas.DefaultCellStyle = DataGridViewCellStyle21
        Me.GruesoPulgadas.HeaderText = "GruesoPulgadas"
        Me.GruesoPulgadas.MinimumWidth = 6
        Me.GruesoPulgadas.Name = "GruesoPulgadas"
        Me.GruesoPulgadas.Width = 125
        '
        'PiesUnidad
        '
        Me.PiesUnidad.DataPropertyName = "PiesUnidad"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = "0"
        Me.PiesUnidad.DefaultCellStyle = DataGridViewCellStyle22
        Me.PiesUnidad.HeaderText = "PiesUnidad"
        Me.PiesUnidad.MinimumWidth = 6
        Me.PiesUnidad.Name = "PiesUnidad"
        Me.PiesUnidad.Visible = False
        Me.PiesUnidad.Width = 125
        '
        'M2Cara
        '
        Me.M2Cara.DataPropertyName = "M2Cara"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle23.Format = "N4"
        DataGridViewCellStyle23.NullValue = "0"
        Me.M2Cara.DefaultCellStyle = DataGridViewCellStyle23
        Me.M2Cara.HeaderText = "M2Cara"
        Me.M2Cara.MinimumWidth = 6
        Me.M2Cara.Name = "M2Cara"
        Me.M2Cara.Visible = False
        Me.M2Cara.Width = 125
        '
        'M2Canto
        '
        Me.M2Canto.DataPropertyName = "M2Canto"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle24.Format = "N4"
        DataGridViewCellStyle24.NullValue = "0"
        Me.M2Canto.DefaultCellStyle = DataGridViewCellStyle24
        Me.M2Canto.HeaderText = "M2Canto"
        Me.M2Canto.MinimumWidth = 6
        Me.M2Canto.Name = "M2Canto"
        Me.M2Canto.Visible = False
        Me.M2Canto.Width = 125
        '
        'M2Cabeza
        '
        Me.M2Cabeza.DataPropertyName = "M2Cabeza"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle25.Format = "N4"
        DataGridViewCellStyle25.NullValue = "0"
        Me.M2Cabeza.DefaultCellStyle = DataGridViewCellStyle25
        Me.M2Cabeza.HeaderText = "M2Cabeza"
        Me.M2Cabeza.MinimumWidth = 6
        Me.M2Cabeza.Name = "M2Cabeza"
        Me.M2Cabeza.Visible = False
        Me.M2Cabeza.Width = 125
        '
        'BtnDuplicarRegistro
        '
        Me.BtnDuplicarRegistro.Location = New System.Drawing.Point(211, 41)
        Me.BtnDuplicarRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDuplicarRegistro.Name = "BtnDuplicarRegistro"
        Me.BtnDuplicarRegistro.Size = New System.Drawing.Size(164, 28)
        Me.BtnDuplicarRegistro.TabIndex = 29
        Me.BtnDuplicarRegistro.Text = "Duplicar Registro"
        Me.BtnDuplicarRegistro.UseVisualStyleBackColor = True
        '
        'SubArticulosBindingNavigator
        '
        Me.SubArticulosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SubArticulosBindingNavigator.BindingSource = Me.SubArticulosBindingSource
        Me.SubArticulosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SubArticulosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SubArticulosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SubArticulosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SubArticulosBindingNavigatorSaveItem})
        Me.SubArticulosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SubArticulosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SubArticulosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SubArticulosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SubArticulosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SubArticulosBindingNavigator.Name = "SubArticulosBindingNavigator"
        Me.SubArticulosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SubArticulosBindingNavigator.Size = New System.Drawing.Size(1693, 27)
        Me.SubArticulosBindingNavigator.TabIndex = 33
        Me.SubArticulosBindingNavigator.Text = "BindingNavigator1"
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
        'SubArticulosBindingNavigatorSaveItem
        '
        Me.SubArticulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SubArticulosBindingNavigatorSaveItem.Image = CType(resources.GetObject("SubArticulosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SubArticulosBindingNavigatorSaveItem.Name = "SubArticulosBindingNavigatorSaveItem"
        Me.SubArticulosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.SubArticulosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SubArticulosDetalleFerreteriaTableAdapter
        '
        Me.SubArticulosDetalleFerreteriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.SubArticulosDetalleFerreteriaTableAdapter = Me.SubArticulosDetalleFerreteriaTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsSubArticulosFerreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FerreteriaTableAdapter
        '
        Me.FerreteriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager10
        '
        Me.TableAdapterManager10.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager10.FerreteriaTableAdapter = Me.FerreteriaTableAdapter
        Me.TableAdapterManager10.UpdateOrder = ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsMaterialMedidadCompra
        '
        Me.DsMaterialMedidadCompra.DataSetName = "DsMaterialMedidadCompra"
        Me.DsMaterialMedidadCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SubArticulosTableAdapter = Me.SubArticulosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(1593, 38)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(100, 28)
        Me.BtnCerrar.TabIndex = 34
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(715, 50)
        Me.lblInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(85, 16)
        Me.lblInicio.TabIndex = 35
        Me.lblInicio.Text = "IdSubarticulo"
        '
        'SubArticulosDetalleTableAdapter
        '
        Me.SubArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'DsDescripciones
        '
        Me.DsDescripciones.DataSetName = "DsDescripciones"
        Me.DsDescripciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionesBindingSource
        '
        Me.DescripcionesBindingSource.DataMember = "Descripciones"
        Me.DescripcionesBindingSource.DataSource = Me.DsDescripciones
        '
        'DescripcionesTableAdapter
        '
        Me.DescripcionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.DescripcionesTableAdapter = Me.DescripcionesTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'DescripcionesDetalleTableAdapter
        '
        Me.DescripcionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1305, 38)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(191, 28)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "GenerarSubArticulo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmSubArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1684, 718)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnAñadirFerreteria)
        Me.Controls.Add(Me.SubArticulosBindingNavigator)
        Me.Controls.Add(Me.BtnDuplicarRegistro)
        Me.Controls.Add(Me.CmdFerreteria)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSubArticulo"
        Me.Text = "FrmSubArticulo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgwSubarticuloDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgwFerreteriaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FerreteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFerreteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosFerreteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubArticulosBindingNavigator.ResumeLayout(False)
        Me.SubArticulosBindingNavigator.PerformLayout()
        CType(Me.DsMaterialMedidadCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDescripciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox


    Friend WithEvents CmdNuevo As System.Windows.Forms.Button

    Friend WithEvents Sub_Articulos_DetalleBindingSource As System.Windows.Forms.BindingSource


    Friend WithEvents DgwFerreteriaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents CmdFerreteria As System.Windows.Forms.Button
    Friend WithEvents PiesMadera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Sub_ArticuloLabel As System.Windows.Forms.Label
    Friend WithEvents Descripcion_Sub_ArticuloLabel As System.Windows.Forms.Label
    Friend WithEvents Minutos__Trabajo_Sub_ArticuloLabel As System.Windows.Forms.Label
    Friend WithEvents Id_Material_Detalle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PiesLargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anchopulgadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GruesoPulgadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiesUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M2Cara As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M2Canto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M2Cabeza As System.Windows.Forms.DataGridViewTextBoxColumn







    Friend WithEvents BtnDuplicarRegistro As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button



    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager
    Friend WithEvents SubArticulosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SubArticulosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DsSubArticulosFerreteria As ModuloGestion.DsSubArticulosFerreteria
    Friend WithEvents SubArticulosDetalleFerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosDetalleFerreteriaTableAdapter As ModuloGestion.DsSubArticulosFerreteriaTableAdapters.SubArticulosDetalleFerreteriaTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsSubArticulosFerreteriaTableAdapters.TableAdapterManager
    Friend WithEvents FerreteriaTableAdapter As ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter
    Friend WithEvents TableAdapterManager10 As ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager
    Friend WithEvents DsMaterialMedidadCompra As ModuloGestion.DsMaterialMedidadCompra
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtTiempoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdSubarticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtM2Pintura As System.Windows.Forms.TextBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button



    Friend WithEvents TxtIdGrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents BtnCambioMAterial As System.Windows.Forms.Button
    Friend WithEvents BtnAñadirFerreteria As System.Windows.Forms.Button
    Friend WithEvents DgwSubarticuloDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents DsSubArticulosDetalle As ModuloGestion.DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosDetalleTableAdapter As ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents IddetalleFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSubArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEementoFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsFerreteria As ModuloGestion.DsFerreteria
    Friend WithEvents CantidadFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblGrupo As System.Windows.Forms.Label
    Friend WithEvents DsDescripciones As ModuloGestion.DsDescripciones
    Friend WithEvents DescripcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionesTableAdapter As ModuloGestion.DsDescripcionesTableAdapters.DescripcionesTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents DsDescripcionesdetalle As ModuloGestion.DsDescripcionesdetalle
    Friend WithEvents DescripcionesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionesDetalleTableAdapter As ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents SubIddetalleSubArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubIdSubArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubIddescripcionDetalle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubIdMaterialDetalle As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubLargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubAncho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubGrueso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubIdMedida As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubPiesLargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubAnchopulgadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubGruesoPulgadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubPiesUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubM2Cara As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubM2Canto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubM2Cabeza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubConsumoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubM2PinuturaUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubM2PinuturaUnidadtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubDesperdicioMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDesperdicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MontajeTextBox As TextBox

End Class
