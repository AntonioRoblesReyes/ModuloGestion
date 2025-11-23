<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioMaterial
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
        Me.LblIdSubArticulo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdMaterialDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMatrialesFamiliaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.DsMaterialFamilia = New ModuloGestion.DsMaterialFamilia()
        Me.MaterialesFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesFamiliaTableAdapter = New ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager()
        Me.MaterialesFamiliaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMaterial = New ModuloGestion.DsMaterial()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialesTableAdapter = New ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsMaterialTableAdapters.TableAdapterManager()
        Me.MaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.BtnCambiarMaterial = New System.Windows.Forms.Button()
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager()
        Me.BtnRefrescarMaterilales = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIdSubArticulo
        '
        Me.LblIdSubArticulo.AutoSize = True
        Me.LblIdSubArticulo.Location = New System.Drawing.Point(12, 9)
        Me.LblIdSubArticulo.Name = "LblIdSubArticulo"
        Me.LblIdSubArticulo.Size = New System.Drawing.Size(73, 13)
        Me.LblIdSubArticulo.TabIndex = 0
        Me.LblIdSubArticulo.Text = "Id SubArticulo"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(519, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaterialDetalleDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.IdMatrialesFamiliaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MaterilaesDetalleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(560, 207)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(450, 220)
        Me.DataGridView2.TabIndex = 2
        '
        'IdMaterialDetalleDataGridViewTextBoxColumn
        '
        Me.IdMaterialDetalleDataGridViewTextBoxColumn.DataPropertyName = "Id_Material_Detalle"
        Me.IdMaterialDetalleDataGridViewTextBoxColumn.HeaderText = "Id Material"
        Me.IdMaterialDetalleDataGridViewTextBoxColumn.Name = "IdMaterialDetalleDataGridViewTextBoxColumn"
        Me.IdMaterialDetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMatrialesFamiliaDataGridViewTextBoxColumn
        '
        Me.IdMatrialesFamiliaDataGridViewTextBoxColumn.DataPropertyName = "IdMatrialesFamilia"
        Me.IdMatrialesFamiliaDataGridViewTextBoxColumn.HeaderText = "IdMatrialesFamilia"
        Me.IdMatrialesFamiliaDataGridViewTextBoxColumn.Name = "IdMatrialesFamiliaDataGridViewTextBoxColumn"
        Me.IdMatrialesFamiliaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMatrialesFamiliaDataGridViewTextBoxColumn.Visible = False
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
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'DsMaterialFamilia
        '
        Me.DsMaterialFamilia.DataSetName = "DsMaterialFamilia"
        Me.DsMaterialFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesFamiliaBindingSource
        '
        Me.MaterialesFamiliaBindingSource.DataMember = "MaterialesFamilia"
        Me.MaterialesFamiliaBindingSource.DataSource = Me.DsMaterialFamilia
        '
        'MaterialesFamiliaTableAdapter
        '
        Me.MaterialesFamiliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MaterialesFamiliaTableAdapter = Me.MaterialesFamiliaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesFamiliaDataGridView
        '
        Me.MaterialesFamiliaDataGridView.AllowUserToAddRows = False
        Me.MaterialesFamiliaDataGridView.AllowUserToDeleteRows = False
        Me.MaterialesFamiliaDataGridView.AutoGenerateColumns = False
        Me.MaterialesFamiliaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesFamiliaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MaterialesFamiliaDataGridView.DataSource = Me.MaterialesFamiliaBindingSource
        Me.MaterialesFamiliaDataGridView.Location = New System.Drawing.Point(24, 207)
        Me.MaterialesFamiliaDataGridView.Name = "MaterialesFamiliaDataGridView"
        Me.MaterialesFamiliaDataGridView.ReadOnly = True
        Me.MaterialesFamiliaDataGridView.Size = New System.Drawing.Size(519, 220)
        Me.MaterialesFamiliaDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMatrialesFamilia"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Matriales "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DsMaterial
        '
        Me.DsMaterial.DataSetName = "DsMaterial"
        Me.DsMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.DsMaterial
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MaterialesTableAdapter = Me.MaterialesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesDataGridView
        '
        Me.MaterialesDataGridView.AllowUserToAddRows = False
        Me.MaterialesDataGridView.AllowUserToDeleteRows = False
        Me.MaterialesDataGridView.AutoGenerateColumns = False
        Me.MaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MaterialesDataGridView.DataSource = Me.MaterialesBindingSource
        Me.MaterialesDataGridView.Location = New System.Drawing.Point(560, 51)
        Me.MaterialesDataGridView.Name = "MaterialesDataGridView"
        Me.MaterialesDataGridView.ReadOnly = True
        Me.MaterialesDataGridView.Size = New System.Drawing.Size(450, 150)
        Me.MaterialesDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id Material"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Descrpcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'SubArticulosDetalleDataGridView
        '
        Me.SubArticulosDetalleDataGridView.AutoGenerateColumns = False
        Me.SubArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.SubArticulosDetalleDataGridView.DataSource = Me.SubArticulosDetalleBindingSource
        Me.SubArticulosDetalleDataGridView.Location = New System.Drawing.Point(24, 433)
        Me.SubArticulosDetalleDataGridView.Name = "SubArticulosDetalleDataGridView"
        Me.SubArticulosDetalleDataGridView.Size = New System.Drawing.Size(986, 220)
        Me.SubArticulosDetalleDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Largo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Ancho"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Grueso"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Grueso"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PiesLargo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PiesLargo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Anchopulgadas"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Anchopulgadas"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "GruesoPulgadas"
        Me.DataGridViewTextBoxColumn16.HeaderText = "GruesoPulgadas"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PiesUnidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PiesUnidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "M2Cara"
        Me.DataGridViewTextBoxColumn18.HeaderText = "M2Cara"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "M2Canto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "M2Canto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "M2Cabeza"
        Me.DataGridViewTextBoxColumn20.HeaderText = "M2Cabeza"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn23.HeaderText = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn24.HeaderText = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn25.HeaderText = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TotalCompra"
        Me.DataGridViewTextBoxColumn26.HeaderText = "TotalCompra"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "NuevoId"
        Me.DataGridViewTextBoxColumn27.HeaderText = "NuevoId"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Id_Medida"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
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
        'BtnCambiarMaterial
        '
        Me.BtnCambiarMaterial.Location = New System.Drawing.Point(693, 22)
        Me.BtnCambiarMaterial.Name = "BtnCambiarMaterial"
        Me.BtnCambiarMaterial.Size = New System.Drawing.Size(138, 23)
        Me.BtnCambiarMaterial.TabIndex = 6
        Me.BtnCambiarMaterial.Text = "Cambiar Material"
        Me.BtnCambiarMaterial.UseVisualStyleBackColor = True
        '
        'SubArticulosDetalleTableAdapter
        '
        Me.SubArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.SubArticulosDetalleTableAdapter = Me.SubArticulosDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnRefrescarMaterilales
        '
        Me.BtnRefrescarMaterilales.Location = New System.Drawing.Point(24, 22)
        Me.BtnRefrescarMaterilales.Name = "BtnRefrescarMaterilales"
        Me.BtnRefrescarMaterilales.Size = New System.Drawing.Size(123, 23)
        Me.BtnRefrescarMaterilales.TabIndex = 7
        Me.BtnRefrescarMaterilales.Text = "Refrescar Materilales"
        Me.BtnRefrescarMaterilales.UseVisualStyleBackColor = True
        '
        'FrmCambioMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 673)
        Me.Controls.Add(Me.BtnRefrescarMaterilales)
        Me.Controls.Add(Me.BtnCambiarMaterial)
        Me.Controls.Add(Me.SubArticulosDetalleDataGridView)
        Me.Controls.Add(Me.MaterialesDataGridView)
        Me.Controls.Add(Me.MaterialesFamiliaDataGridView)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblIdSubArticulo)
        Me.Name = "FrmCambioMaterial"
        Me.Text = "FrmCambioMaterial"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIdSubArticulo As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsSubArticulosDetalle As ModuloGestion.DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosDetalleTableAdapter As ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents DsMaterialFamilia As ModuloGestion.DsMaterialFamilia
    Friend WithEvents MaterialesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesFamiliaTableAdapter As ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesFamiliaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsMaterial As ModuloGestion.DsMaterial
    Friend WithEvents MaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesTableAdapter As ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsMaterialTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdMaterialDetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMatrialesFamiliaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents SubArticulosDetalleDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCambiarMaterial As System.Windows.Forms.Button
    Friend WithEvents BtnRefrescarMaterilales As System.Windows.Forms.Button
End Class
