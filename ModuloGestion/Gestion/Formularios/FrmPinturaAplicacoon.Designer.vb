<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPinturaAplicacoon
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsPinturaAplicacion = New ModuloGestion.DsPinturaAplicacion()
        Me.PinturaAplicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinturaAplicacionTableAdapter = New ModuloGestion.DsPinturaAplicacionTableAdapters.PinturaAplicacionTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPinturaAplicacionTableAdapters.TableAdapterManager()
        Me.PinturaAplicacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinturaAplicacionDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PinturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPintura = New ModuloGestion.DsPintura()
        Me.ConsumoM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoAolicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desperdicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinturaAplicacionDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaAplicacionDetalle = New ModuloGestion.DsPinturaAplicacionDetalle()
        Me.PinturaTableAdapter = New ModuloGestion.DsPinturaTableAdapters.PinturaTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPinturaTableAdapters.TableAdapterManager()
        Me.PinturaComponentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaComponentes = New ModuloGestion.DsPinturaComponentes()
        Me.PinturaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaDetalle = New ModuloGestion.DsPinturaDetalle()
        Me.PinturaComponentesTableAdapter = New ModuloGestion.DsPinturaComponentesTableAdapters.PinturaComponentesTableAdapter()
        Me.btnanadirpintutrapDetalle = New System.Windows.Forms.Button()
        Me.TableAdapterManager7 = New ModuloGestion.DsPinturaConsumosElementosTableAdapters.TableAdapterManager()
        Me.BtnNuevaAplicacion = New System.Windows.Forms.Button()
        Me.BtnNuevaPintura = New System.Windows.Forms.Button()
        Me.BtnNuevoDetallePintura = New System.Windows.Forms.Button()
        Me.PinturaAplicacionDetalleTableAdapter = New ModuloGestion.DsPinturaAplicacionDetalleTableAdapters.PinturaAplicacionDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPinturaAplicacionDetalleTableAdapters.TableAdapterManager()
        Me.PinturaDetalleTableAdapter = New ModuloGestion.DsPinturaDetalleTableAdapters.PinturaDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPinturaDetalleTableAdapters.TableAdapterManager()
        Me.PinturaConsumosElementosTableAdapter = New ModuloGestion.DsPinturaConsumosElementosTableAdapters.PinturaConsumosElementosTableAdapter()
        Me.PinturaConsumosElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaConsumosElementos = New ModuloGestion.DsPinturaConsumosElementos()
        Me.PinturaConsumoElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetallePintura = New ModuloGestion.DsPresupuestoDetallePintura()
        Me.PresupuestoDetallePinturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetallePinturaTableAdapter = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager8 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.PinturaDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.DsPreciosCompraProyecto = New ModuloGestion.DsPreciosCompraProyecto()
        Me.PreciosCompraProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreciosCompraProyectoTableAdapter = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter()
        Me.TableAdapterManager9 = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsPinturaAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaAplicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaAplicacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaAplicacionDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaAplicacionDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaAplicacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaConsumosElementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaConsumosElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaConsumoElementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsPinturaAplicacion
        '
        Me.DsPinturaAplicacion.DataSetName = "DsPinturaAplicacion"
        Me.DsPinturaAplicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaAplicacionBindingSource
        '
        Me.PinturaAplicacionBindingSource.DataMember = "PinturaAplicacion"
        Me.PinturaAplicacionBindingSource.DataSource = Me.DsPinturaAplicacion
        '
        'PinturaAplicacionTableAdapter
        '
        Me.PinturaAplicacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PinturaAplicacionTableAdapter = Me.PinturaAplicacionTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPinturaAplicacionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PinturaAplicacionDataGridView
        '
        Me.PinturaAplicacionDataGridView.AllowUserToAddRows = False
        Me.PinturaAplicacionDataGridView.AutoGenerateColumns = False
        Me.PinturaAplicacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PinturaAplicacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PinturaAplicacionDataGridView.DataSource = Me.PinturaAplicacionBindingSource
        Me.PinturaAplicacionDataGridView.Location = New System.Drawing.Point(12, 53)
        Me.PinturaAplicacionDataGridView.Name = "PinturaAplicacionDataGridView"
        Me.PinturaAplicacionDataGridView.Size = New System.Drawing.Size(365, 220)
        Me.PinturaAplicacionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPinturaTipo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Aplicacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'PinturaAplicacionDetalleDataGridView
        '
        Me.PinturaAplicacionDetalleDataGridView.AllowUserToAddRows = False
        Me.PinturaAplicacionDetalleDataGridView.AutoGenerateColumns = False
        Me.PinturaAplicacionDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PinturaAplicacionDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.ConsumoM2, Me.TiempoAolicacion, Me.Desperdicio, Me.DataGridViewTextBoxColumn4})
        Me.PinturaAplicacionDetalleDataGridView.DataSource = Me.PinturaAplicacionDetalleBindingSource
        Me.PinturaAplicacionDetalleDataGridView.Location = New System.Drawing.Point(409, 53)
        Me.PinturaAplicacionDetalleDataGridView.Name = "PinturaAplicacionDetalleDataGridView"
        Me.PinturaAplicacionDetalleDataGridView.Size = New System.Drawing.Size(637, 220)
        Me.PinturaAplicacionDetalleDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdPinturaTipoDetalle"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdPintura"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.PinturaBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripcion Pintura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "IdPintura"
        '
        'PinturaBindingSource
        '
        Me.PinturaBindingSource.DataMember = "Pintura"
        Me.PinturaBindingSource.DataSource = Me.DsPintura
        '
        'DsPintura
        '
        Me.DsPintura.DataSetName = "DsPintura"
        Me.DsPintura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsumoM2
        '
        Me.ConsumoM2.DataPropertyName = "ConsumoM2"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.ConsumoM2.DefaultCellStyle = DataGridViewCellStyle4
        Me.ConsumoM2.HeaderText = "Cons M2"
        Me.ConsumoM2.Name = "ConsumoM2"
        Me.ConsumoM2.Width = 75
        '
        'TiempoAolicacion
        '
        Me.TiempoAolicacion.DataPropertyName = "TiempoAolicacion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TiempoAolicacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.TiempoAolicacion.HeaderText = "T Aplicac"
        Me.TiempoAolicacion.Name = "TiempoAolicacion"
        Me.TiempoAolicacion.Width = 75
        '
        'Desperdicio
        '
        Me.Desperdicio.DataPropertyName = "Desperdicio"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "## %"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Desperdicio.DefaultCellStyle = DataGridViewCellStyle6
        Me.Desperdicio.HeaderText = "Des %"
        Me.Desperdicio.Name = "Desperdicio"
        Me.Desperdicio.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdPinturaTipo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdPinturaTipo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'PinturaAplicacionDetalleBindingSource
        '
        Me.PinturaAplicacionDetalleBindingSource.DataMember = "PinturaAplicacionDetalle"
        Me.PinturaAplicacionDetalleBindingSource.DataSource = Me.DsPinturaAplicacionDetalle
        '
        'DsPinturaAplicacionDetalle
        '
        Me.DsPinturaAplicacionDetalle.DataSetName = "DsPinturaAplicacionDetalle"
        Me.DsPinturaAplicacionDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaTableAdapter
        '
        Me.PinturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.PinturaTableAdapter = Me.PinturaTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPinturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'PinturaDetalleBindingSource
        '
        Me.PinturaDetalleBindingSource.DataMember = "PinturaDetalle"
        Me.PinturaDetalleBindingSource.DataSource = Me.DsPinturaDetalle
        '
        'DsPinturaDetalle
        '
        Me.DsPinturaDetalle.DataSetName = "DsPinturaDetalle"
        Me.DsPinturaDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaComponentesTableAdapter
        '
        Me.PinturaComponentesTableAdapter.ClearBeforeFill = True
        '
        'btnanadirpintutrapDetalle
        '
        Me.btnanadirpintutrapDetalle.Location = New System.Drawing.Point(12, 284)
        Me.btnanadirpintutrapDetalle.Name = "btnanadirpintutrapDetalle"
        Me.btnanadirpintutrapDetalle.Size = New System.Drawing.Size(147, 23)
        Me.btnanadirpintutrapDetalle.TabIndex = 3
        Me.btnanadirpintutrapDetalle.Text = "Añadir Detalle a Prespuesto"
        Me.btnanadirpintutrapDetalle.UseVisualStyleBackColor = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.Connection = Nothing
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsPinturaConsumosElementosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnNuevaAplicacion
        '
        Me.BtnNuevaAplicacion.Location = New System.Drawing.Point(12, 24)
        Me.BtnNuevaAplicacion.Name = "BtnNuevaAplicacion"
        Me.BtnNuevaAplicacion.Size = New System.Drawing.Size(119, 23)
        Me.BtnNuevaAplicacion.TabIndex = 4
        Me.BtnNuevaAplicacion.TabStop = False
        Me.BtnNuevaAplicacion.Text = "Nueva Aplicacion"
        Me.BtnNuevaAplicacion.UseVisualStyleBackColor = True
        '
        'BtnNuevaPintura
        '
        Me.BtnNuevaPintura.Location = New System.Drawing.Point(409, 24)
        Me.BtnNuevaPintura.Name = "BtnNuevaPintura"
        Me.BtnNuevaPintura.Size = New System.Drawing.Size(119, 23)
        Me.BtnNuevaPintura.TabIndex = 5
        Me.BtnNuevaPintura.Text = "Nueva Pintura"
        Me.BtnNuevaPintura.UseVisualStyleBackColor = True
        '
        'BtnNuevoDetallePintura
        '
        Me.BtnNuevoDetallePintura.Location = New System.Drawing.Point(409, 284)
        Me.BtnNuevoDetallePintura.Name = "BtnNuevoDetallePintura"
        Me.BtnNuevoDetallePintura.Size = New System.Drawing.Size(119, 23)
        Me.BtnNuevoDetallePintura.TabIndex = 6
        Me.BtnNuevoDetallePintura.Text = "Nueva Detalle Pintura"
        Me.BtnNuevoDetallePintura.UseVisualStyleBackColor = True
        '
        'PinturaAplicacionDetalleTableAdapter
        '
        Me.PinturaAplicacionDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PinturaAplicacionDetalleTableAdapter = Me.PinturaAplicacionDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPinturaAplicacionDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PinturaDetalleTableAdapter
        '
        Me.PinturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PinturaDetalleTableAdapter = Me.PinturaDetalleTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPinturaDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PinturaConsumosElementosTableAdapter
        '
        Me.PinturaConsumosElementosTableAdapter.ClearBeforeFill = True
        '
        'PinturaConsumosElementosBindingSource
        '
        Me.PinturaConsumosElementosBindingSource.DataMember = "PinturaConsumosElementos"
        '
        'DsPinturaConsumosElementos
        '
        Me.DsPinturaConsumosElementos.DataSetName = "DsPinturaConsumosElementos"
        Me.DsPinturaConsumosElementos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager8
        '
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager8.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager8.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PinturaDetalleDataGridView
        '
        Me.PinturaDetalleDataGridView.AllowUserToAddRows = False
        Me.PinturaDetalleDataGridView.AutoGenerateColumns = False
        Me.PinturaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PinturaDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.PinturaDetalleDataGridView.DataSource = Me.PinturaDetalleBindingSource
        Me.PinturaDetalleDataGridView.Location = New System.Drawing.Point(12, 326)
        Me.PinturaDetalleDataGridView.Name = "PinturaDetalleDataGridView"
        Me.PinturaDetalleDataGridView.Size = New System.Drawing.Size(767, 220)
        Me.PinturaDetalleDataGridView.TabIndex = 8
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
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'DsPreciosCompraProyecto
        '
        Me.DsPreciosCompraProyecto.DataSetName = "DsPreciosCompraProyecto"
        Me.DsPreciosCompraProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreciosCompraProyectoBindingSource
        '
        Me.PreciosCompraProyectoBindingSource.DataMember = "PreciosCompraProyecto"
        Me.PreciosCompraProyectoBindingSource.DataSource = Me.DsPreciosCompraProyecto
        '
        'PreciosCompraProyectoTableAdapter
        '
        Me.PreciosCompraProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager9
        '
        Me.TableAdapterManager9.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager9.PreciosCompraProyectoTableAdapter = Me.PreciosCompraProyectoTableAdapter
        Me.TableAdapterManager9.UpdateOrder = ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(785, 326)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 379)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdPinturaDetalle"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdPinturaDetalle"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdPinturaComponente"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.PinturaComponentesBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "IdPinturaComponente"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn19.DataSource = Me.MedidasCompraBindingSource
        Me.DataGridViewTextBoxColumn19.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn19.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn19.HeaderText = "Medida Compra"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn19.ValueMember = "Id_Medida"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CantidadXlitro"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Cantidad por litro"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'FrmPinturaAplicacoon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1106, 733)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PinturaDetalleDataGridView)
        Me.Controls.Add(Me.BtnNuevoDetallePintura)
        Me.Controls.Add(Me.BtnNuevaPintura)
        Me.Controls.Add(Me.BtnNuevaAplicacion)
        Me.Controls.Add(Me.btnanadirpintutrapDetalle)
        Me.Controls.Add(Me.PinturaAplicacionDetalleDataGridView)
        Me.Controls.Add(Me.PinturaAplicacionDataGridView)
        Me.Name = "FrmPinturaAplicacoon"
        Me.Text = "FrmPinturaAplicacoon"
        CType(Me.DsPinturaAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaAplicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaAplicacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaAplicacionDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaAplicacionDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturaAplicacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturaComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaConsumosElementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturaConsumosElementos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaConsumoElementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPinturaAplicacion As ModuloGestion.DsPinturaAplicacion
    Friend WithEvents PinturaAplicacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaAplicacionTableAdapter As ModuloGestion.DsPinturaAplicacionTableAdapters.PinturaAplicacionTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPinturaAplicacionTableAdapters.TableAdapterManager
    Friend WithEvents PinturaAplicacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPinturaAplicacionDetalle As ModuloGestion.DsPinturaAplicacionDetalle
    Friend WithEvents PinturaAplicacionDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaAplicacionDetalleTableAdapter As ModuloGestion.DsPinturaAplicacionDetalleTableAdapters.PinturaAplicacionDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPinturaAplicacionDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PinturaAplicacionDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsPintura As ModuloGestion.DsPintura
    Friend WithEvents PinturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaTableAdapter As ModuloGestion.DsPinturaTableAdapters.PinturaTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPinturaTableAdapters.TableAdapterManager
    Friend WithEvents DsPinturaDetalle As ModuloGestion.DsPinturaDetalle
    Friend WithEvents PinturaDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaDetalleTableAdapter As ModuloGestion.DsPinturaDetalleTableAdapters.PinturaDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPinturaDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsPinturaComponentes As ModuloGestion.DsPinturaComponentes
    Friend WithEvents PinturaComponentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaComponentesTableAdapter As ModuloGestion.DsPinturaComponentesTableAdapters.PinturaComponentesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ConsumoM2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoAolicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desperdicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnanadirpintutrapDetalle As System.Windows.Forms.Button



    Friend WithEvents TableAdapterManager7 As ModuloGestion.DsPinturaConsumosElementosTableAdapters.TableAdapterManager


    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn



    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnNuevaAplicacion As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaPintura As System.Windows.Forms.Button
    Friend WithEvents BtnNuevoDetallePintura As System.Windows.Forms.Button
    Friend WithEvents PinturaConsumosElementosTableAdapter As ModuloGestion.DsPinturaConsumosElementosTableAdapters.PinturaConsumosElementosTableAdapter
    Friend WithEvents PinturaConsumosElementosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPinturaConsumosElementos As ModuloGestion.DsPinturaConsumosElementos
    Friend WithEvents PinturaConsumoElementosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetallePintura As ModuloGestion.DsPresupuestoDetallePintura
    Friend WithEvents PresupuestoDetallePinturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetallePinturaTableAdapter As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager6 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager8 As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PinturaDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsPreciosCompraProyecto As ModuloGestion.DsPreciosCompraProyecto
    Friend WithEvents PreciosCompraProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreciosCompraProyectoTableAdapter As ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter
    Friend WithEvents TableAdapterManager9 As ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
