<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerNotasEntregas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerNotasEntregas))
        Me.DsNotasEntrega = New ModuloGestion.DsNotasEntrega()
        Me.NotasEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasEntregaTableAdapter = New ModuloGestion.DsNotasEntregaTableAdapters.NotasEntregaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsNotasEntregaTableAdapters.TableAdapterManager()
        Me.NotasEntregaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Empresa = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmpresasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmdVerDetalle = New System.Windows.Forms.Button()
        Me.BtnNuevaNotaEntrega = New System.Windows.Forms.Button()
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.DsEstadoEntregas = New ModuloGestion.DsEstadoEntregas()
        Me.EstadoentregasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoentregasTableAdapter = New ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstadoentregasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UnionSubarticulosHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsUnionSubarticulosHerrajes = New ModuloGestion.DsUnionSubarticulosHerrajes()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.DsNotasEntregaDetalle = New ModuloGestion.DsNotasEntregaDetalle()
        Me.NotasEntregaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasEntregaDetalleTableAdapter = New ModuloGestion.DsNotasEntregaDetalleTableAdapters.NotasEntregaDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager()
        Me.NotasEntregaDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectosDetalle = New ModuloGestion.DsProyectosDetalle()
        Me.ProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosDetalleTableAdapter = New ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.UnionSubarticulosHerrajesTableAdapter = New ModuloGestion.DsUnionSubarticulosHerrajesTableAdapters.UnionSubarticulosHerrajesTableAdapter()
        Me.txtpresupuesto = New System.Windows.Forms.TextBox()
        Me.txtproyecto = New System.Windows.Forms.TextBox()
        Me.txtempresa = New System.Windows.Forms.TextBox()
        Me.txtsiguiente = New System.Windows.Forms.TextBox()
        CType(Me.DsNotasEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoentregasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionSubarticulosHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUnionSubarticulosHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNotasEntregaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsNotasEntrega
        '
        Me.DsNotasEntrega.DataSetName = "DsNotasEntrega"
        Me.DsNotasEntrega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotasEntregaBindingSource
        '
        Me.NotasEntregaBindingSource.DataMember = "NotasEntrega"
        Me.NotasEntregaBindingSource.DataSource = Me.DsNotasEntrega
        '
        'NotasEntregaTableAdapter
        '
        Me.NotasEntregaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NotasEntregaTableAdapter = Me.NotasEntregaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsNotasEntregaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NotasEntregaDataGridView
        '
        Me.NotasEntregaDataGridView.AllowUserToAddRows = False
        Me.NotasEntregaDataGridView.AllowUserToDeleteRows = False
        Me.NotasEntregaDataGridView.AutoGenerateColumns = False
        Me.NotasEntregaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotasEntregaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Id_Empresa, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.NotasEntregaDataGridView.DataSource = Me.NotasEntregaBindingSource
        Me.NotasEntregaDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.NotasEntregaDataGridView.Name = "NotasEntregaDataGridView"
        Me.NotasEntregaDataGridView.ReadOnly = True
        Me.NotasEntregaDataGridView.Size = New System.Drawing.Size(425, 220)
        Me.NotasEntregaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Nota_Entrega"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nota Entrega"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Id_Empresa
        '
        Me.Id_Empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Id_Empresa.DataPropertyName = "Id_Empresa"
        Me.Id_Empresa.DataSource = Me.EmpresasBindingSource1
        Me.Id_Empresa.DisplayMember = "Nombre"
        Me.Id_Empresa.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Id_Empresa.HeaderText = "Empresa"
        Me.Id_Empresa.Name = "Id_Empresa"
        Me.Id_Empresa.ReadOnly = True
        Me.Id_Empresa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Empresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Id_Empresa.ValueMember = "Id_Empresa"
        '
        'EmpresasBindingSource1
        '
        Me.EmpresasBindingSource1.DataMember = "Empresas"
        Me.EmpresasBindingSource1.DataSource = Me.DsEmpresasBindingSource
        '
        'DsEmpresasBindingSource
        '
        Me.DsEmpresasBindingSource.DataSource = Me.DsEmpresas
        Me.DsEmpresasBindingSource.Position = 0
        '
        'DsEmpresas
        '
        Me.DsEmpresas.DataSetName = "DsEmpresas"
        Me.DsEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Entrega"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsEmpresasBindingSource
        '
        'CmdVerDetalle
        '
        Me.CmdVerDetalle.Location = New System.Drawing.Point(427, 19)
        Me.CmdVerDetalle.Name = "CmdVerDetalle"
        Me.CmdVerDetalle.Size = New System.Drawing.Size(75, 23)
        Me.CmdVerDetalle.TabIndex = 2
        Me.CmdVerDetalle.Text = "Ver Detalle"
        Me.CmdVerDetalle.UseVisualStyleBackColor = True
        '
        'BtnNuevaNotaEntrega
        '
        Me.BtnNuevaNotaEntrega.Location = New System.Drawing.Point(12, 19)
        Me.BtnNuevaNotaEntrega.Name = "BtnNuevaNotaEntrega"
        Me.BtnNuevaNotaEntrega.Size = New System.Drawing.Size(135, 23)
        Me.BtnNuevaNotaEntrega.TabIndex = 3
        Me.BtnNuevaNotaEntrega.Text = "Nueva Nota Entrega"
        Me.BtnNuevaNotaEntrega.UseVisualStyleBackColor = True
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'DsEstadoEntregas
        '
        Me.DsEstadoEntregas.DataSetName = "DsEstadoEntregas"
        Me.DsEstadoEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoentregasBindingSource
        '
        Me.EstadoentregasBindingSource.DataMember = "Estadoentregas"
        Me.EstadoentregasBindingSource.DataSource = Me.DsEstadoEntregas
        '
        'EstadoentregasTableAdapter
        '
        Me.EstadoentregasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager1.SubArticulosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'EstadoentregasDataGridView
        '
        Me.EstadoentregasDataGridView.AllowUserToAddRows = False
        Me.EstadoentregasDataGridView.AllowUserToDeleteRows = False
        Me.EstadoentregasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoentregasDataGridView.AutoGenerateColumns = False
        Me.EstadoentregasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstadoentregasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.EstadoentregasDataGridView.DataSource = Me.EstadoentregasBindingSource
        Me.EstadoentregasDataGridView.Location = New System.Drawing.Point(443, 48)
        Me.EstadoentregasDataGridView.Name = "EstadoentregasDataGridView"
        Me.EstadoentregasDataGridView.ReadOnly = True
        Me.EstadoentregasDataGridView.Size = New System.Drawing.Size(556, 447)
        Me.EstadoentregasDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.UnionSubarticulosHerrajesBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "Id_Sub_Articulo"
        '
        'UnionSubarticulosHerrajesBindingSource
        '
        Me.UnionSubarticulosHerrajesBindingSource.DataMember = "UnionSubarticulosHerrajes"
        Me.UnionSubarticulosHerrajesBindingSource.DataSource = Me.DsUnionSubarticulosHerrajes
        '
        'DsUnionSubarticulosHerrajes
        '
        Me.DsUnionSubarticulosHerrajes.DataSetName = "DsUnionSubarticulosHerrajes"
        Me.DsUnionSubarticulosHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Entregados"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn9.HeaderText = "Entregados"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Pendiente"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pendiente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 75
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
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'DsNotasEntregaDetalle
        '
        Me.DsNotasEntregaDetalle.DataSetName = "DsNotasEntregaDetalle"
        Me.DsNotasEntregaDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotasEntregaDetalleBindingSource
        '
        Me.NotasEntregaDetalleBindingSource.DataMember = "NotasEntregaDetalle"
        Me.NotasEntregaDetalleBindingSource.DataSource = Me.DsNotasEntregaDetalle
        '
        'NotasEntregaDetalleTableAdapter
        '
        Me.NotasEntregaDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.NotasEntregaDetalleTableAdapter = Me.NotasEntregaDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NotasEntregaDetalleDataGridView
        '
        Me.NotasEntregaDetalleDataGridView.AllowUserToAddRows = False
        Me.NotasEntregaDetalleDataGridView.AllowUserToDeleteRows = False
        Me.NotasEntregaDetalleDataGridView.AutoGenerateColumns = False
        Me.NotasEntregaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotasEntregaDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.NotasEntregaDetalleDataGridView.DataSource = Me.NotasEntregaDetalleBindingSource
        Me.NotasEntregaDetalleDataGridView.Location = New System.Drawing.Point(14, 275)
        Me.NotasEntregaDetalleDataGridView.Name = "NotasEntregaDetalleDataGridView"
        Me.NotasEntregaDetalleDataGridView.ReadOnly = True
        Me.NotasEntregaDetalleDataGridView.Size = New System.Drawing.Size(423, 220)
        Me.NotasEntregaDetalleDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Id_detalle_Nota_entrega"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Id_detalle_Nota_entrega"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_Nota_Entrega"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nota Entrega"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn14.DataSource = Me.UnionSubarticulosHerrajesBindingSource
        Me.DataGridViewTextBoxColumn14.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn14.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn14.HeaderText = "SubArticulo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn14.ValueMember = "Id_Sub_Articulo"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 75
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'SubArticulosBindingSource1
        '
        Me.SubArticulosBindingSource1.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource1.DataSource = Me.DsSubArticulos
        '
        'DsProyectosDetalle
        '
        Me.DsProyectosDetalle.DataSetName = "DsProyectosDetalle"
        Me.DsProyectosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosDetalleBindingSource
        '
        Me.ProyectosDetalleBindingSource.DataMember = "ProyectosDetalle"
        Me.ProyectosDetalleBindingSource.DataSource = Me.DsProyectosDetalle
        '
        'ProyectosDetalleTableAdapter
        '
        Me.ProyectosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.ProyectosDetalleTableAdapter = Me.ProyectosDetalleTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(509, 18)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(23, 23)
        Me.BtnImprimir.TabIndex = 10
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'UnionSubarticulosHerrajesTableAdapter
        '
        Me.UnionSubarticulosHerrajesTableAdapter.ClearBeforeFill = True
        '
        'txtpresupuesto
        '
        Me.txtpresupuesto.Location = New System.Drawing.Point(195, 20)
        Me.txtpresupuesto.Name = "txtpresupuesto"
        Me.txtpresupuesto.Size = New System.Drawing.Size(128, 20)
        Me.txtpresupuesto.TabIndex = 11
        '
        'txtproyecto
        '
        Me.txtproyecto.Location = New System.Drawing.Point(557, 18)
        Me.txtproyecto.Name = "txtproyecto"
        Me.txtproyecto.Size = New System.Drawing.Size(128, 20)
        Me.txtproyecto.TabIndex = 12
        '
        'txtempresa
        '
        Me.txtempresa.Location = New System.Drawing.Point(701, 18)
        Me.txtempresa.Name = "txtempresa"
        Me.txtempresa.Size = New System.Drawing.Size(128, 20)
        Me.txtempresa.TabIndex = 13
        '
        'txtsiguiente
        '
        Me.txtsiguiente.Location = New System.Drawing.Point(848, 18)
        Me.txtsiguiente.Name = "txtsiguiente"
        Me.txtsiguiente.Size = New System.Drawing.Size(128, 20)
        Me.txtsiguiente.TabIndex = 14
        '
        'FrmVerNotasEntregas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 515)
        Me.Controls.Add(Me.txtsiguiente)
        Me.Controls.Add(Me.txtempresa)
        Me.Controls.Add(Me.txtproyecto)
        Me.Controls.Add(Me.txtpresupuesto)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.NotasEntregaDetalleDataGridView)
        Me.Controls.Add(Me.EstadoentregasDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnNuevaNotaEntrega)
        Me.Controls.Add(Me.CmdVerDetalle)
        Me.Controls.Add(Me.NotasEntregaDataGridView)
        Me.Name = "FrmVerNotasEntregas"
        Me.Text = "VerNotasEntregas"
        CType(Me.DsNotasEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoentregasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionSubarticulosHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUnionSubarticulosHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNotasEntregaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsNotasEntrega As ModuloGestion.DsNotasEntrega
    Friend WithEvents NotasEntregaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaTableAdapter As ModuloGestion.DsNotasEntregaTableAdapters.NotasEntregaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsNotasEntregaTableAdapters.TableAdapterManager
    Friend WithEvents NotasEntregaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CmdVerDetalle As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaNotaEntrega As System.Windows.Forms.Button
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents DsEmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents EmpresasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsEstadoEntregas As ModuloGestion.DsEstadoEntregas
    Friend WithEvents EstadoentregasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoentregasTableAdapter As ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EstadoentregasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsNotasEntregaDetalle As ModuloGestion.DsNotasEntregaDetalle
    Friend WithEvents NotasEntregaDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaDetalleTableAdapter As ModuloGestion.DsNotasEntregaDetalleTableAdapters.NotasEntregaDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager
    Friend WithEvents NotasEntregaDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SubArticulosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsProyectosDetalle As ModuloGestion.DsProyectosDetalle
    Friend WithEvents ProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleTableAdapter As ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents DsUnionSubarticulosHerrajes As ModuloGestion.DsUnionSubarticulosHerrajes
    Friend WithEvents UnionSubarticulosHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionSubarticulosHerrajesTableAdapter As ModuloGestion.DsUnionSubarticulosHerrajesTableAdapters.UnionSubarticulosHerrajesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Empresa As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtpresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtempresa As System.Windows.Forms.TextBox
    Friend WithEvents txtsiguiente As System.Windows.Forms.TextBox
End Class
