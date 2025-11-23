<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreciosCompras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PreciosCompraProyectoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPrecioCopmraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UnionNombreMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsUnionMaterialesNombre = New ModuloGestion.DsUnionMaterialesNombre()
        Me.PrecioCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyectoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadNecesariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.IdpresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciosCompraProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreciosCompraProyecto = New ModuloGestion.DsPreciosCompraProyecto()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrecioCompraConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreciosCompraConsulta = New ModuloGestion.DsPreciosCompraConsulta()
        Me.TxtPesos = New System.Windows.Forms.TextBox()
        Me.TxtDolares = New System.Windows.Forms.TextBox()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.UnionNombreMaterialesTableAdapter = New ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter()
        Me.PrecioCompraConsultaTableAdapter = New ModuloGestion.DsPreciosCompraConsultaTableAdapters.PrecioCompraConsultaTableAdapter()
        Me.DsPresupuestoDetalleElementos = New ModuloGestion.DsPresupuestoDetalleElementos()
        Me.PresupuestoDetalleElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleElementosTableAdapter = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalleHerrajes = New ModuloGestion.DsPresupuestoDetalleHerrajes()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetallePintura = New ModuloGestion.DsPresupuestoDetallePintura()
        Me.PresupuestoDetallePinturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetallePinturaTableAdapter = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager()
        Me.BtnActualizarPrecios = New System.Windows.Forms.Button()
        Me.DsPreciosCompra = New ModuloGestion.DsPreciosCompra()
        Me.PreciosCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreciosCompraTableAdapter = New ModuloGestion.DsPreciosCompraTableAdapters.PreciosCompraTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPreciosCompraTableAdapters.TableAdapterManager()
        Me.PreciosCompraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DescripcionProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompraMaterialesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DsAnexarMaterialCompra = New ModuloGestion.DsAnexarMaterialCompra()
        Me.AnexarMaterialCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexarMaterialCompraTableAdapter = New ModuloGestion.DsAnexarMaterialCompraTableAdapters.AnexarMaterialCompraTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsAnexarMaterialCompraTableAdapters.TableAdapterManager()
        Me.DsAnexarPinturaCompra = New ModuloGestion.DsAnexarPinturaCompra()
        Me.AnrxarPinturaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnrxarPinturaCompraTableAdapter = New ModuloGestion.DsAnexarPinturaCompraTableAdapters.AnrxarPinturaCompraTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsAnexarPinturaCompraTableAdapters.TableAdapterManager()
        Me.DsAnexarHerrajeCompra = New ModuloGestion.DsAnexarHerrajeCompra()
        Me.AnexarHerrajesCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexarHerrajesCompraTableAdapter = New ModuloGestion.DsAnexarHerrajeCompraTableAdapters.AnexarHerrajesCompraTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsAnexarHerrajeCompraTableAdapters.TableAdapterManager()
        Me.PreciosCompraProyectoTableAdapter = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter()
        Me.DsPresupuestoDetalleferreteria = New ModuloGestion.DsPresupuestoDetalleferreteria()
        Me.PresupuestoDetalleFerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleFerreteriaTableAdapter = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter()
        Me.TableAdapterManager7 = New ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager()
        Me.CompraMaterialesDetalleTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableAdapterManager8 = New ModuloGestion.DsPreciosCompraConsultaTableAdapters.TableAdapterManager()
        Me.PrecioCompraConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PreciosCompraProyectoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioCompraConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleElementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarMaterialCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexarMaterialCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarPinturaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnrxarPinturaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnexarHerrajeCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexarHerrajesCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioCompraConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreciosCompraProyectoDataGridView
        '
        Me.PreciosCompraProyectoDataGridView.AllowUserToAddRows = False
        Me.PreciosCompraProyectoDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PreciosCompraProyectoDataGridView.AutoGenerateColumns = False
        Me.PreciosCompraProyectoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreciosCompraProyectoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPrecioCopmraDataGridViewTextBoxColumn, Me.IdmaterialDataGridViewTextBoxColumn, Me.PrecioCompraDataGridViewTextBoxColumn, Me.IdProyectoDataGridViewTextBoxColumn, Me.CantidadNecesariaDataGridViewTextBoxColumn, Me.IdEmpresaDataGridViewTextBoxColumn, Me.TotalCostoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.IdMedidaDataGridViewTextBoxColumn, Me.IdpresupuestoDataGridViewTextBoxColumn})
        Me.PreciosCompraProyectoDataGridView.DataSource = Me.PreciosCompraProyectoBindingSource
        Me.PreciosCompraProyectoDataGridView.Location = New System.Drawing.Point(12, 85)
        Me.PreciosCompraProyectoDataGridView.Name = "PreciosCompraProyectoDataGridView"
        Me.PreciosCompraProyectoDataGridView.Size = New System.Drawing.Size(688, 467)
        Me.PreciosCompraProyectoDataGridView.TabIndex = 7
        '
        'IdPrecioCopmraDataGridViewTextBoxColumn
        '
        Me.IdPrecioCopmraDataGridViewTextBoxColumn.DataPropertyName = "IdPrecioCopmra"
        Me.IdPrecioCopmraDataGridViewTextBoxColumn.HeaderText = "IdPrecioCopmra"
        Me.IdPrecioCopmraDataGridViewTextBoxColumn.Name = "IdPrecioCopmraDataGridViewTextBoxColumn"
        Me.IdPrecioCopmraDataGridViewTextBoxColumn.Visible = False
        '
        'IdmaterialDataGridViewTextBoxColumn
        '
        Me.IdmaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdmaterialDataGridViewTextBoxColumn.DataPropertyName = "Id_material"
        Me.IdmaterialDataGridViewTextBoxColumn.DataSource = Me.UnionNombreMaterialesBindingSource
        Me.IdmaterialDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.IdmaterialDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdmaterialDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.IdmaterialDataGridViewTextBoxColumn.Name = "IdmaterialDataGridViewTextBoxColumn"
        Me.IdmaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdmaterialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdmaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdmaterialDataGridViewTextBoxColumn.ValueMember = "Id_Material_Detalle"
        '
        'UnionNombreMaterialesBindingSource
        '
        Me.UnionNombreMaterialesBindingSource.DataMember = "UnionNombreMateriales"
        Me.UnionNombreMaterialesBindingSource.DataSource = Me.DsUnionMaterialesNombre
        '
        'DsUnionMaterialesNombre
        '
        Me.DsUnionMaterialesNombre.DataSetName = "DsUnionMaterialesNombre"
        Me.DsUnionMaterialesNombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrecioCompraDataGridViewTextBoxColumn
        '
        Me.PrecioCompraDataGridViewTextBoxColumn.DataPropertyName = "Precio_Compra"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.PrecioCompraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioCompraDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioCompraDataGridViewTextBoxColumn.Name = "PrecioCompraDataGridViewTextBoxColumn"
        Me.PrecioCompraDataGridViewTextBoxColumn.Width = 75
        '
        'IdProyectoDataGridViewTextBoxColumn
        '
        Me.IdProyectoDataGridViewTextBoxColumn.DataPropertyName = "Id_Proyecto"
        Me.IdProyectoDataGridViewTextBoxColumn.HeaderText = "Id_Proyecto"
        Me.IdProyectoDataGridViewTextBoxColumn.Name = "IdProyectoDataGridViewTextBoxColumn"
        Me.IdProyectoDataGridViewTextBoxColumn.Visible = False
        '
        'CantidadNecesariaDataGridViewTextBoxColumn
        '
        Me.CantidadNecesariaDataGridViewTextBoxColumn.DataPropertyName = "CantidadNecesaria"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.CantidadNecesariaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadNecesariaDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadNecesariaDataGridViewTextBoxColumn.Name = "CantidadNecesariaDataGridViewTextBoxColumn"
        Me.CantidadNecesariaDataGridViewTextBoxColumn.Visible = False
        Me.CantidadNecesariaDataGridViewTextBoxColumn.Width = 75
        '
        'IdEmpresaDataGridViewTextBoxColumn
        '
        Me.IdEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Id_Empresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.HeaderText = "Id_Empresa"
        Me.IdEmpresaDataGridViewTextBoxColumn.Name = "IdEmpresaDataGridViewTextBoxColumn"
        Me.IdEmpresaDataGridViewTextBoxColumn.Visible = False
        '
        'TotalCostoDataGridViewTextBoxColumn
        '
        Me.TotalCostoDataGridViewTextBoxColumn.DataPropertyName = "TotalCosto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.TotalCostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalCostoDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalCostoDataGridViewTextBoxColumn.Name = "TotalCostoDataGridViewTextBoxColumn"
        Me.TotalCostoDataGridViewTextBoxColumn.Visible = False
        Me.TotalCostoDataGridViewTextBoxColumn.Width = 75
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'IdMedidaDataGridViewTextBoxColumn
        '
        Me.IdMedidaDataGridViewTextBoxColumn.DataPropertyName = "Id_Medida"
        Me.IdMedidaDataGridViewTextBoxColumn.DataSource = Me.MedidasCompraBindingSource
        Me.IdMedidaDataGridViewTextBoxColumn.DisplayMember = "Descripcion_Medida"
        Me.IdMedidaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdMedidaDataGridViewTextBoxColumn.HeaderText = "Medida"
        Me.IdMedidaDataGridViewTextBoxColumn.Name = "IdMedidaDataGridViewTextBoxColumn"
        Me.IdMedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMedidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdMedidaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdMedidaDataGridViewTextBoxColumn.ValueMember = "Id_Medida"
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
        'IdpresupuestoDataGridViewTextBoxColumn
        '
        Me.IdpresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_presupuesto"
        Me.IdpresupuestoDataGridViewTextBoxColumn.HeaderText = "Id_presupuesto"
        Me.IdpresupuestoDataGridViewTextBoxColumn.Name = "IdpresupuestoDataGridViewTextBoxColumn"
        Me.IdpresupuestoDataGridViewTextBoxColumn.Visible = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrecioCompraConsultaBindingSource
        '
        Me.PrecioCompraConsultaBindingSource.DataMember = "PrecioCompraConsulta"
        Me.PrecioCompraConsultaBindingSource.DataSource = Me.DsPreciosCompraConsulta
        '
        'DsPreciosCompraConsulta
        '
        Me.DsPreciosCompraConsulta.DataSetName = "DsPreciosCompraConsulta"
        Me.DsPreciosCompraConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtPesos
        '
        Me.TxtPesos.Location = New System.Drawing.Point(319, 54)
        Me.TxtPesos.Name = "TxtPesos"
        Me.TxtPesos.Size = New System.Drawing.Size(89, 20)
        Me.TxtPesos.TabIndex = 10
        Me.TxtPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDolares
        '
        Me.TxtDolares.Location = New System.Drawing.Point(509, 54)
        Me.TxtDolares.Name = "TxtDolares"
        Me.TxtDolares.Size = New System.Drawing.Size(89, 20)
        Me.TxtDolares.TabIndex = 11
        Me.TxtDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTasa
        '
        Me.TxtTasa.Location = New System.Drawing.Point(414, 54)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(89, 20)
        Me.TxtTasa.TabIndex = 12
        Me.TxtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Pesos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tasa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Dolaree"
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'UnionNombreMaterialesTableAdapter
        '
        Me.UnionNombreMaterialesTableAdapter.ClearBeforeFill = True
        '
        'PrecioCompraConsultaTableAdapter
        '
        Me.PrecioCompraConsultaTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoDetalleElementosTableAdapter = Me.PresupuestoDetalleElementosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetalleHerrajes
        '
        Me.DsPresupuestoDetalleHerrajes.DataSetName = "DsPresupuestoDetalleHerrajes"
        Me.DsPresupuestoDetalleHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleHerrajesBindingSource
        '
        Me.PresupuestoDetalleHerrajesBindingSource.DataMember = "PresupuestoDetalleHerrajes"
        Me.PresupuestoDetalleHerrajesBindingSource.DataSource = Me.DsPresupuestoDetalleHerrajes
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.PresupuestoDetallePinturaTableAdapter = Me.PresupuestoDetallePinturaTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnActualizarPrecios
        '
        Me.BtnActualizarPrecios.Location = New System.Drawing.Point(720, 50)
        Me.BtnActualizarPrecios.Name = "BtnActualizarPrecios"
        Me.BtnActualizarPrecios.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarPrecios.TabIndex = 16
        Me.BtnActualizarPrecios.Text = "Actualizar Precios"
        Me.BtnActualizarPrecios.UseVisualStyleBackColor = True
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPreciosCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PreciosCompraDataGridView
        '
        Me.PreciosCompraDataGridView.AllowUserToAddRows = False
        Me.PreciosCompraDataGridView.AllowUserToDeleteRows = False
        Me.PreciosCompraDataGridView.AutoGenerateColumns = False
        Me.PreciosCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreciosCompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionProveedorDataGridViewTextBoxColumn, Me.PrecioUSDataGridViewTextBoxColumn, Me.TasaDataGridViewTextBoxColumn, Me.PrecioRDDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn1})
        Me.PreciosCompraDataGridView.DataSource = Me.CompraMaterialesDetalleBindingSource
        Me.PreciosCompraDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.PreciosCompraDataGridView.Location = New System.Drawing.Point(706, 332)
        Me.PreciosCompraDataGridView.Name = "PreciosCompraDataGridView"
        Me.PreciosCompraDataGridView.ReadOnly = True
        Me.PreciosCompraDataGridView.Size = New System.Drawing.Size(640, 220)
        Me.PreciosCompraDataGridView.TabIndex = 16
        '
        'DescripcionProveedorDataGridViewTextBoxColumn
        '
        Me.DescripcionProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionProveedorDataGridViewTextBoxColumn.DataPropertyName = "DescripcionProveedor"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.HeaderText = "DescripcionProveedor"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.Name = "DescripcionProveedorDataGridViewTextBoxColumn"
        Me.DescripcionProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUSDataGridViewTextBoxColumn
        '
        Me.PrecioUSDataGridViewTextBoxColumn.DataPropertyName = "PrecioUS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        Me.PrecioUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioUSDataGridViewTextBoxColumn.HeaderText = "US"
        Me.PrecioUSDataGridViewTextBoxColumn.Name = "PrecioUSDataGridViewTextBoxColumn"
        Me.PrecioUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUSDataGridViewTextBoxColumn.Width = 75
        '
        'TasaDataGridViewTextBoxColumn
        '
        Me.TasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TasaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.TasaDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaDataGridViewTextBoxColumn.Name = "TasaDataGridViewTextBoxColumn"
        Me.TasaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TasaDataGridViewTextBoxColumn.Width = 60
        '
        'PrecioRDDataGridViewTextBoxColumn
        '
        Me.PrecioRDDataGridViewTextBoxColumn.DataPropertyName = "PrecioRD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.PrecioRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioRDDataGridViewTextBoxColumn.HeaderText = "RD"
        Me.PrecioRDDataGridViewTextBoxColumn.Name = "PrecioRDDataGridViewTextBoxColumn"
        Me.PrecioRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioRDDataGridViewTextBoxColumn.Width = 75
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.Width = 75
        '
        'CompraMaterialesDetalleBindingSource
        '
        Me.CompraMaterialesDetalleBindingSource.DataMember = "CompraMaterialesDetalle"
        Me.CompraMaterialesDetalleBindingSource.DataSource = Me.DsCompras
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(792, 311)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 20)
        Me.TextBox1.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(814, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 20)
        Me.TextBox2.TabIndex = 18
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
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsAnexarMaterialCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.Connection = Nothing
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsAnexarPinturaCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.Connection = Nothing
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsAnexarHerrajeCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PreciosCompraProyectoTableAdapter
        '
        Me.PreciosCompraProyectoTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.PresupuestoDetalleFerreteriaTableAdapter = Me.PresupuestoDetalleFerreteriaTableAdapter
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompraMaterialesDetalleTableAdapter
        '
        Me.CompraMaterialesDetalleTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(1352, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Compra"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(1435, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(1352, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Itbis"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(1352, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Itbis"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(1435, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableAdapterManager8
        '
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager8.Connection = Nothing
        Me.TableAdapterManager8.UpdateOrder = ModuloGestion.DsPreciosCompraConsultaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrecioCompraConsultaDataGridView
        '
        Me.PrecioCompraConsultaDataGridView.AutoGenerateColumns = False
        Me.PrecioCompraConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrecioCompraConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PrecioCompraConsultaDataGridView.DataSource = Me.PrecioCompraConsultaBindingSource
        Me.PrecioCompraConsultaDataGridView.Location = New System.Drawing.Point(706, 85)
        Me.PrecioCompraConsultaDataGridView.Name = "PrecioCompraConsultaDataGridView"
        Me.PrecioCompraConsultaDataGridView.Size = New System.Drawing.Size(640, 220)
        Me.PrecioCompraConsultaDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_material"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_material"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Precio_Compra"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'FrmPreciosCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 608)
        Me.Controls.Add(Me.PrecioCompraConsultaDataGridView)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PreciosCompraDataGridView)
        Me.Controls.Add(Me.BtnActualizarPrecios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.TxtDolares)
        Me.Controls.Add(Me.TxtPesos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PreciosCompraProyectoDataGridView)
        Me.Name = "FrmPreciosCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPreciosCompras"
        CType(Me.PreciosCompraProyectoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioCompraConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleElementos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleElementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarMaterialCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexarMaterialCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarPinturaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnrxarPinturaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnexarHerrajeCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexarHerrajesCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleferreteria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleFerreteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioCompraConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents PreciosCompraProyectoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPesos As System.Windows.Forms.TextBox
    Friend WithEvents TxtDolares As System.Windows.Forms.TextBox
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPreciosCompraProyecto As ModuloGestion.DsPreciosCompraProyecto
    Friend WithEvents PreciosCompraProyectoTableAdapter As ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsUnionMaterialesNombre As ModuloGestion.DsUnionMaterialesNombre
    Friend WithEvents UnionNombreMaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionNombreMaterialesTableAdapter As ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter
    Friend WithEvents DsPreciosCompraConsulta As ModuloGestion.DsPreciosCompraConsulta
    Friend WithEvents PrecioCompraConsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrecioCompraConsultaTableAdapter As ModuloGestion.DsPreciosCompraConsultaTableAdapters.PrecioCompraConsultaTableAdapter
    Friend WithEvents IdmaterialDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPresupuestoDetalleElementos As ModuloGestion.DsPresupuestoDetalleElementos
    Friend WithEvents PresupuestoDetalleElementosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleElementosTableAdapter As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleHerrajes As ModuloGestion.DsPresupuestoDetalleHerrajes
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetallePintura As ModuloGestion.DsPresupuestoDetallePintura
    Friend WithEvents PresupuestoDetallePinturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetallePinturaTableAdapter As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager
    Friend WithEvents BtnActualizarPrecios As System.Windows.Forms.Button
    Friend WithEvents DsPreciosCompra As ModuloGestion.DsPreciosCompra
    Friend WithEvents PreciosCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreciosCompraTableAdapter As ModuloGestion.DsPreciosCompraTableAdapters.PreciosCompraTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPreciosCompraTableAdapters.TableAdapterManager
    Friend WithEvents PreciosCompraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DsAnexarMaterialCompra As ModuloGestion.DsAnexarMaterialCompra
    Friend WithEvents AnexarMaterialCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexarMaterialCompraTableAdapter As ModuloGestion.DsAnexarMaterialCompraTableAdapters.AnexarMaterialCompraTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsAnexarMaterialCompraTableAdapters.TableAdapterManager
    Friend WithEvents DsAnexarPinturaCompra As ModuloGestion.DsAnexarPinturaCompra
    Friend WithEvents AnrxarPinturaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnrxarPinturaCompraTableAdapter As ModuloGestion.DsAnexarPinturaCompraTableAdapters.AnrxarPinturaCompraTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsAnexarPinturaCompraTableAdapters.TableAdapterManager
    Friend WithEvents DsAnexarHerrajeCompra As ModuloGestion.DsAnexarHerrajeCompra
    Friend WithEvents AnexarHerrajesCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexarHerrajesCompraTableAdapter As ModuloGestion.DsAnexarHerrajeCompraTableAdapters.AnexarHerrajesCompraTableAdapter
    Friend WithEvents TableAdapterManager6 As ModuloGestion.DsAnexarHerrajeCompraTableAdapters.TableAdapterManager
    Friend WithEvents PreciosCompraProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPresupuestoDetalleferreteria As ModuloGestion.DsPresupuestoDetalleferreteria
    Friend WithEvents PresupuestoDetalleFerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleFerreteriaTableAdapter As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.PresupuestoDetalleFerreteriaTableAdapter
    Friend WithEvents TableAdapterManager7 As ModuloGestion.DsPresupuestoDetalleferreteriaTableAdapters.TableAdapterManager
    Friend WithEvents IdPrecioCopmraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdmaterialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PrecioCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProyectoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadNecesariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdpresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents CompraMaterialesDetalleBindingSource As BindingSource
    Friend WithEvents CompraMaterialesDetalleTableAdapter As DsComprasTableAdapters.CompraMaterialesDetalleTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents DescripcionProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableAdapterManager8 As DsPreciosCompraConsultaTableAdapters.TableAdapterManager
    Friend WithEvents PrecioCompraConsultaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
