<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubarticulosGenerar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubarticulosGenerar))
        Dim MaterialPrincipalLabel As System.Windows.Forms.Label
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnDuplicarRegistro = New System.Windows.Forms.Button()
        Me.CmdNuevoDetaleferreteria = New System.Windows.Forms.Button()
        Me.CmdVerConsumos = New System.Windows.Forms.Button()
        Me.CmdFerreteria = New System.Windows.Forms.Button()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.TableAdapterManager6 = New ModuloGestion.DsMaterialTableAdapters.TableAdapterManager()
        Me.MaterialesTableAdapter = New ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter()
        Me.DsDuplicarSubArticuloDetalle = New ModuloGestion.DsDuplicarSubArticuloDetalle()
        Me.DuplicarSubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DuplicarSubArticulosDetalleTableAdapter = New ModuloGestion.DsDuplicarSubArticuloDetalleTableAdapters.DuplicarSubArticulosDetalleTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager()
        Me.MaterialesFamiliaTableAdapter = New ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager()
        Me.TableAdapterManager7 = New ModuloGestion.DsDuplicarSubArticuloDetalleTableAdapters.TableAdapterManager()
        Me.DescripcionesTableAdapter = New ModuloGestion.DsDescripcionesTableAdapters.DescripcionesTableAdapter()
        Me.TableAdapterManager8 = New ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager()
        Me.TableAdapterManager9 = New ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager()
        Me.DescripcionesDetalleTableAdapter = New ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter()
        Me.TableAdapterManager11 = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager()
        Me.MaterialMedidaCompraTableAdapter = New ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter()
        Me.FerreteriaTableAdapter = New ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter()
        Me.TableAdapterManager10 = New ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager()
        Me.DsMaterialMedidadCompra = New ModuloGestion.DsMaterialMedidadCompra()
        Me.MaterialMedidaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterial = New ModuloGestion.DsMaterial()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New ModuloGestion.DsSubArticulosFerreteriaTableAdapters.TableAdapterManager()
        Me.SubArticulosDetalleFerreteriaTableAdapter = New ModuloGestion.DsSubArticulosFerreteriaTableAdapters.SubArticulosDetalleFerreteriaTableAdapter()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager()
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.DsSubArticulosFerreteria = New ModuloGestion.DsSubArticulosFerreteria()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.SubArticulosDetalleFerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager2 = New ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager()
        Me.DescripcionesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDescripcionesdetalle = New ModuloGestion.DsDescripcionesdetalle()
        Me.DescripcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDescripciones = New ModuloGestion.DsDescripciones()
        Me.MaterialesFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialFamilia = New ModuloGestion.DsMaterialFamilia()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.DsFerreteria = New ModuloGestion.DsFerreteria()
        Me.FerreteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.PresupuestoDetalleElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalleElementos = New ModuloGestion.DsPresupuestoDetalleElementos()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager13 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleElementosTableAdapter = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter()
        Me.TableAdapterManager14 = New ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PresupuestoDetalleElementosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtGrupoSubarticulo = New System.Windows.Forms.TextBox()
        Me.SubArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
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
        Me.TxtTiempoTrabajo = New System.Windows.Forms.TextBox()
        Me.TxtIdSubarticulo = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSubArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CantidadFerreteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.Id_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.Descripcion_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.Minutos__Trabajo_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.TxtM2Pintura = New System.Windows.Forms.TextBox()
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
        Me.MaterialPrincipalTextBox = New System.Windows.Forms.TextBox()
        M2PinturaLabel = New System.Windows.Forms.Label()
        MaterialPrincipalLabel = New System.Windows.Forms.Label()
        CType(Me.SubArticulosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsSubArticulos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsDuplicarSubArticuloDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DuplicarSubArticulosDetalleBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsMaterialMedidadCompra,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MaterialMedidaCompraBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsMaterial,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MaterialesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsSubArticulosFerreteria,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubArticulosDetalleBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsSubArticulosDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubArticulosDetalleFerreteriaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DescripcionesDetalleBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsDescripcionesdetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DescripcionesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsDescripciones,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MaterialesFamiliaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsMaterialFamilia,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsArticulosdetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsFerreteria,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FerreteriaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MaterilaesDetalleBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsMaterialDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MedidasCompraBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsMedidasCompra,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PresupuestoDetalleElementosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DsPresupuestoDetalleElementos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ArticulosDetalleBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.PresupuestoDetalleElementosDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubArticulosDetalleDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubArticulosBindingNavigator,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SubArticulosBindingNavigator.SuspendLayout
        Me.SuspendLayout
        '
        'M2PinturaLabel
        '
        M2PinturaLabel.AutoSize = true
        M2PinturaLabel.Location = New System.Drawing.Point(396, 28)
        M2PinturaLabel.Name = "M2PinturaLabel"
        M2PinturaLabel.Size = New System.Drawing.Size(58, 13)
        M2PinturaLabel.TabIndex = 44
        M2PinturaLabel.Text = "M2Pintura:"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(223, -228)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 42
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(-51, -228)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 23)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Nuevo Subarticulo"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(475, -199)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 23)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Imrpmir Consumos"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'BtnDuplicarRegistro
        '
        Me.BtnDuplicarRegistro.Location = New System.Drawing.Point(-180, -228)
        Me.BtnDuplicarRegistro.Name = "BtnDuplicarRegistro"
        Me.BtnDuplicarRegistro.Size = New System.Drawing.Size(123, 23)
        Me.BtnDuplicarRegistro.TabIndex = 39
        Me.BtnDuplicarRegistro.Text = "Duplicar Registro"
        Me.BtnDuplicarRegistro.UseVisualStyleBackColor = true
        '
        'CmdNuevoDetaleferreteria
        '
        Me.CmdNuevoDetaleferreteria.Location = New System.Drawing.Point(324, -199)
        Me.CmdNuevoDetaleferreteria.Name = "CmdNuevoDetaleferreteria"
        Me.CmdNuevoDetaleferreteria.Size = New System.Drawing.Size(125, 23)
        Me.CmdNuevoDetaleferreteria.TabIndex = 38
        Me.CmdNuevoDetaleferreteria.Text = "Añadir Ferreteria"
        Me.CmdNuevoDetaleferreteria.UseVisualStyleBackColor = true
        '
        'CmdVerConsumos
        '
        Me.CmdVerConsumos.Location = New System.Drawing.Point(475, -230)
        Me.CmdVerConsumos.Name = "CmdVerConsumos"
        Me.CmdVerConsumos.Size = New System.Drawing.Size(125, 23)
        Me.CmdVerConsumos.TabIndex = 37
        Me.CmdVerConsumos.Text = "Ver Consumos"
        Me.CmdVerConsumos.UseVisualStyleBackColor = true
        '
        'CmdFerreteria
        '
        Me.CmdFerreteria.Location = New System.Drawing.Point(324, -228)
        Me.CmdFerreteria.Name = "CmdFerreteria"
        Me.CmdFerreteria.Size = New System.Drawing.Size(125, 23)
        Me.CmdFerreteria.TabIndex = 36
        Me.CmdFerreteria.Text = "Ocultar Ferreteria "
        Me.CmdFerreteria.UseVisualStyleBackColor = true
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
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager6.MaterialesTableAdapter = Me.MaterialesTableAdapter
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = true
        '
        'DsDuplicarSubArticuloDetalle
        '
        Me.DsDuplicarSubArticuloDetalle.DataSetName = "DsDuplicarSubArticuloDetalle"
        Me.DsDuplicarSubArticuloDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DuplicarSubArticulosDetalleBindingSource
        '
        Me.DuplicarSubArticulosDetalleBindingSource.DataMember = "DuplicarSubArticulosDetalle"
        Me.DuplicarSubArticulosDetalleBindingSource.DataSource = Me.DsDuplicarSubArticuloDetalle
        '
        'DuplicarSubArticulosDetalleTableAdapter
        '
        Me.DuplicarSubArticulosDetalleTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager5.MaterialesFamiliaTableAdapter = Me.MaterialesFamiliaTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesFamiliaTableAdapter
        '
        Me.MaterialesFamiliaTableAdapter.ClearBeforeFill = true
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager3.MedidasCompraTableAdapter = Me.MedidasCompraTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager4.MaterilaesDetalleTableAdapter = Me.MaterilaesDetalleTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager7.Connection = Nothing
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsDuplicarSubArticuloDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionesTableAdapter
        '
        Me.DescripcionesTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager8
        '
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager8.DescripcionesTableAdapter = Me.DescripcionesTableAdapter
        Me.TableAdapterManager8.UpdateOrder = ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager9
        '
        Me.TableAdapterManager9.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager9.DescripcionesDetalleTableAdapter = Me.DescripcionesDetalleTableAdapter
        Me.TableAdapterManager9.UpdateOrder = ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionesDetalleTableAdapter
        '
        Me.DescripcionesDetalleTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager11
        '
        Me.TableAdapterManager11.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager11.MaterialMedidaCompraTableAdapter = Me.MaterialMedidaCompraTableAdapter
        Me.TableAdapterManager11.UpdateOrder = ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialMedidaCompraTableAdapter
        '
        Me.MaterialMedidaCompraTableAdapter.ClearBeforeFill = true
        '
        'FerreteriaTableAdapter
        '
        Me.FerreteriaTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager10
        '
        Me.TableAdapterManager10.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager10.FerreteriaTableAdapter = Me.FerreteriaTableAdapter
        Me.TableAdapterManager10.UpdateOrder = ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsMaterialMedidadCompra
        '
        Me.DsMaterialMedidadCompra.DataSetName = "DsMaterialMedidadCompra"
        Me.DsMaterialMedidadCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialMedidaCompraBindingSource
        '
        Me.MaterialMedidaCompraBindingSource.DataMember = "MaterialMedidaCompra"
        Me.MaterialMedidaCompraBindingSource.DataSource = Me.DsMaterialMedidadCompra
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager1.SubArticulosDetalleFerreteriaTableAdapter = Me.SubArticulosDetalleFerreteriaTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsSubArticulosFerreteriaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubArticulosDetalleFerreteriaTableAdapter
        '
        Me.SubArticulosDetalleFerreteriaTableAdapter.ClearBeforeFill = true
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.SubArticulosTableAdapter = Me.SubArticulosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubArticulosDetalleTableAdapter
        '
        Me.SubArticulosDetalleTableAdapter.ClearBeforeFill = true
        '
        'DsSubArticulosFerreteria
        '
        Me.DsSubArticulosFerreteria.DataSetName = "DsSubArticulosFerreteria"
        Me.DsSubArticulosFerreteria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SubArticulosDetalleFerreteriaBindingSource
        '
        Me.SubArticulosDetalleFerreteriaBindingSource.DataMember = "SubArticulosDetalleFerreteria"
        Me.SubArticulosDetalleFerreteriaBindingSource.DataSource = Me.DsSubArticulosFerreteria
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager2.SubArticulosDetalleTableAdapter = Me.SubArticulosDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'DescripcionesBindingSource
        '
        Me.DescripcionesBindingSource.DataMember = "Descripciones"
        Me.DescripcionesBindingSource.DataSource = Me.DsDescripciones
        '
        'DsDescripciones
        '
        Me.DsDescripciones.DataSetName = "DsDescripciones"
        Me.DsDescripciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialesFamiliaBindingSource
        '
        Me.MaterialesFamiliaBindingSource.DataMember = "MaterialesFamilia"
        Me.MaterialesFamiliaBindingSource.DataSource = Me.DsMaterialFamilia
        '
        'DsMaterialFamilia
        '
        Me.DsMaterialFamilia.DataSetName = "DsMaterialFamilia"
        Me.DsMaterialFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsArticulosdetalle
        '
        Me.DsArticulosdetalle.DataSetName = "DsArticulosdetalle"
        Me.DsArticulosdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PresupuestoDetalleElementosBindingSource
        '
        Me.PresupuestoDetalleElementosBindingSource.DataMember = "PresupuestoDetalleElementos"
        Me.PresupuestoDetalleElementosBindingSource.DataSource = Me.DsPresupuestoDetalleElementos
        '
        'DsPresupuestoDetalleElementos
        '
        Me.DsPresupuestoDetalleElementos.DataSetName = "DsPresupuestoDetalleElementos"
        Me.DsPresupuestoDetalleElementos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosDetalleBindingSource
        '
        Me.ArticulosDetalleBindingSource.DataMember = "ArticulosDetalle"
        Me.ArticulosDetalleBindingSource.DataSource = Me.DsArticulosdetalle
        '
        'ArticulosDetalleTableAdapter
        '
        Me.ArticulosDetalleTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager13
        '
        Me.TableAdapterManager13.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager13.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager13.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleElementosTableAdapter
        '
        Me.PresupuestoDetalleElementosTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager14
        '
        Me.TableAdapterManager14.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager14.PresupuestoDetalleElementosTableAdapter = Me.PresupuestoDetalleElementosTableAdapter
        Me.TableAdapterManager14.UpdateOrder = ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Nuevo Subarticulo"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(677, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Imrpmir Consumos"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(22, 33)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 23)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Duplicar Registro"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(526, 62)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 23)
        Me.Button7.TabIndex = 45
        Me.Button7.Text = "Añadir Ferreteria"
        Me.Button7.UseVisualStyleBackColor = true
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(677, 31)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(125, 23)
        Me.Button8.TabIndex = 44
        Me.Button8.Text = "Ver Consumos"
        Me.Button8.UseVisualStyleBackColor = true
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(526, 33)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(125, 23)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "Ocultar Ferreteria "
        Me.Button9.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PresupuestoDetalleElementosDataGridView)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TxtGrupoSubarticulo)
        Me.GroupBox1.Controls.Add(Me.SubArticulosDetalleDataGridView)
        Me.GroupBox1.Controls.Add(Me.TxtTiempoTrabajo)
        Me.GroupBox1.Controls.Add(Me.TxtIdSubarticulo)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.CmdNuevo)
        Me.GroupBox1.Controls.Add(Me.Id_Sub_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.Descripcion_Sub_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.Minutos__Trabajo_Sub_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Me.TxtM2Pintura)
        Me.GroupBox1.Controls.Add(M2PinturaLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1273, 738)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PresupuestoDetalleElementosDataGridView
        '
        Me.PresupuestoDetalleElementosDataGridView.AutoGenerateColumns = false
        Me.PresupuestoDetalleElementosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleElementosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58})
        Me.PresupuestoDetalleElementosDataGridView.DataSource = Me.PresupuestoDetalleElementosBindingSource
        Me.PresupuestoDetalleElementosDataGridView.Location = New System.Drawing.Point(15, 415)
        Me.PresupuestoDetalleElementosDataGridView.Name = "PresupuestoDetalleElementosDataGridView"
        Me.PresupuestoDetalleElementosDataGridView.Size = New System.Drawing.Size(1211, 146)
        Me.PresupuestoDetalleElementosDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "IdPresupuestoDetalleElemento"
        Me.DataGridViewTextBoxColumn27.HeaderText = "IdPresupuestoDetalleElemento"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn30.HeaderText = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn31.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Visible = false
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Visible = false
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Visible = false
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "CantidadArticulos"
        Me.DataGridViewTextBoxColumn34.HeaderText = "CantidadArticulos"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Visible = false
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "CantidadSubarticulo"
        Me.DataGridViewTextBoxColumn35.HeaderText = "CantidadSubarticulo"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Visible = false
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "CantidadElemntos"
        Me.DataGridViewTextBoxColumn36.HeaderText = "CantidadElemntos"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Visible = false
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Visible = false
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Visible = false
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn39.HeaderText = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Visible = false
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn40.HeaderText = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Visible = false
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "TotalCompra"
        Me.DataGridViewTextBoxColumn41.HeaderText = "TotalCompra"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Visible = false
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Id_Medida"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Visible = false
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Id_Empresa"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Id_Empresa"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Visible = false
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "PrecioCompra"
        Me.DataGridViewTextBoxColumn45.HeaderText = "PrecioCompra"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Visible = false
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "TotalCosto"
        Me.DataGridViewTextBoxColumn46.HeaderText = "TotalCosto"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Visible = false
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Id_Detalle_Articulos"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Id_Detalle_Articulos"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Visible = false
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn48.HeaderText = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Visible = false
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn49.HeaderText = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "ConsumoTotalArticulo"
        Me.DataGridViewTextBoxColumn50.HeaderText = "ConsumoTotalArticulo"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Visible = false
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "TotalDesperdicioArticulo"
        Me.DataGridViewTextBoxColumn51.HeaderText = "TotalDesperdicioArticulo"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Visible = false
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "TotalCompraArticulo"
        Me.DataGridViewTextBoxColumn52.HeaderText = "TotalCompraArticulo"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Visible = false
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "TotalCostoArticulo"
        Me.DataGridViewTextBoxColumn53.HeaderText = "TotalCostoArticulo"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Visible = false
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "ConsumoTotalPresupuesto"
        Me.DataGridViewTextBoxColumn54.HeaderText = "ConsumoTotalPresupuesto"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Visible = false
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "TotalDesperdicioPresupuesto"
        Me.DataGridViewTextBoxColumn55.HeaderText = "TotalDesperdicioPresupuesto"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Visible = false
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "TotalCompraPresupuesto"
        Me.DataGridViewTextBoxColumn56.HeaderText = "TotalCompraPresupuesto"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "TotalCostoPresupuesto"
        Me.DataGridViewTextBoxColumn57.HeaderText = "TotalCostoPresupuesto"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Visible = false
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 250
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 47
        '
        'TxtGrupoSubarticulo
        '
        Me.TxtGrupoSubarticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "GrupoSubArticulos", true))
        Me.TxtGrupoSubarticulo.Location = New System.Drawing.Point(144, 187)
        Me.TxtGrupoSubarticulo.Name = "TxtGrupoSubarticulo"
        Me.TxtGrupoSubarticulo.Size = New System.Drawing.Size(140, 20)
        Me.TxtGrupoSubarticulo.TabIndex = 46
        '
        'SubArticulosDetalleDataGridView
        '
        Me.SubArticulosDetalleDataGridView.AutoGenerateColumns = false
        Me.SubArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.SubArticulosDetalleDataGridView.DataSource = Me.SubArticulosDetalleBindingSource
        Me.SubArticulosDetalleDataGridView.Location = New System.Drawing.Point(21, 213)
        Me.SubArticulosDetalleDataGridView.Name = "SubArticulosDetalleDataGridView"
        Me.SubArticulosDetalleDataGridView.Size = New System.Drawing.Size(1217, 182)
        Me.SubArticulosDetalleDataGridView.TabIndex = 43
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = false
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = false
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.DescripcionesDetalleBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Largo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ancho"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Grueso"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Grueso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.MaterilaesDetalleBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn9.DataSource = Me.MedidasCompraBindingSource
        Me.DataGridViewTextBoxColumn9.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn9.HeaderText = "Id_Medida"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn9.ValueMember = "Id_Medida"
        Me.DataGridViewTextBoxColumn9.Width = 250
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PiesLargo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PiesLargo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Anchopulgadas"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Anchopulgadas"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "GruesoPulgadas"
        Me.DataGridViewTextBoxColumn12.HeaderText = "GruesoPulgadas"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PiesUnidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PiesUnidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "M2Cara"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n3"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn14.HeaderText = "M2Cara"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "M2Canto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n3"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn15.HeaderText = "M2Canto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "M2Cabeza"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n3"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn16.HeaderText = "M2Cabeza"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "M2PinuturaUnidad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n3"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn18.HeaderText = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "M2PinuturaUnidadtotal"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n3"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn19.HeaderText = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn21.HeaderText = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TotalCompra"
        Me.DataGridViewTextBoxColumn22.HeaderText = "TotalCompra"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "NuevoId"
        Me.DataGridViewTextBoxColumn23.HeaderText = "NuevoId"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'TxtTiempoTrabajo
        '
        Me.TxtTiempoTrabajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Minutos _Trabajo_Sub_Articulo", true))
        Me.TxtTiempoTrabajo.Location = New System.Drawing.Point(331, 25)
        Me.TxtTiempoTrabajo.Name = "TxtTiempoTrabajo"
        Me.TxtTiempoTrabajo.Size = New System.Drawing.Size(59, 20)
        Me.TxtTiempoTrabajo.TabIndex = 43
        '
        'TxtIdSubarticulo
        '
        Me.TxtIdSubarticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Id_Sub_Articulo", true))
        Me.TxtIdSubarticulo.Location = New System.Drawing.Point(116, 25)
        Me.TxtIdSubarticulo.Name = "TxtIdSubarticulo"
        Me.TxtIdSubarticulo.Size = New System.Drawing.Size(112, 20)
        Me.TxtIdSubarticulo.TabIndex = 42
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Descripcion_Sub_Articulo", true))
        Me.TxtDescripcion.Location = New System.Drawing.Point(116, 51)
        Me.TxtDescripcion.Multiline = true
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(274, 90)
        Me.TxtDescripcion.TabIndex = 41
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(801, 25)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(97, 23)
        Me.Button10.TabIndex = 30
        Me.Button10.Text = "Nuevo Elemento"
        Me.Button10.UseVisualStyleBackColor = true
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(519, 172)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(78, 23)
        Me.Button11.TabIndex = 35
        Me.Button11.Text = "Nuevo"
        Me.Button11.UseVisualStyleBackColor = true
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(310, 147)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(80, 23)
        Me.Button12.TabIndex = 30
        Me.Button12.Text = "Nuevo Grupo"
        Me.Button12.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(21, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Grupo "
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(620, 172)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(125, 23)
        Me.Button13.TabIndex = 31
        Me.Button13.Text = "Nuevo Material"
        Me.Button13.UseVisualStyleBackColor = true
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = false
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddetalleFerreteriaDataGridViewTextBoxColumn, Me.IdSubArticuloDataGridViewTextBoxColumn, Me.IdEementoFerreteriaDataGridViewTextBoxColumn, Me.CantidadFerreteriaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SubArticulosDetalleFerreteriaBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(396, 25)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(399, 141)
        Me.DataGridView2.TabIndex = 21
        '
        'IddetalleFerreteriaDataGridViewTextBoxColumn
        '
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Id_detalle_Ferreteria"
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.HeaderText = "Id detalle"
        Me.IddetalleFerreteriaDataGridViewTextBoxColumn.Name = "IddetalleFerreteriaDataGridViewTextBoxColumn"
        '
        'IdSubArticuloDataGridViewTextBoxColumn
        '
        Me.IdSubArticuloDataGridViewTextBoxColumn.DataPropertyName = "Id_SubArticulo"
        Me.IdSubArticuloDataGridViewTextBoxColumn.HeaderText = "Id_SubArticulo"
        Me.IdSubArticuloDataGridViewTextBoxColumn.Name = "IdSubArticuloDataGridViewTextBoxColumn"
        Me.IdSubArticuloDataGridViewTextBoxColumn.Visible = false
        '
        'IdEementoFerreteriaDataGridViewTextBoxColumn
        '
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Id_Eemento_Ferreteria"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DataSource = Me.FerreteriaBindingSource
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DisplayMember = "Descripcion_Eemento_Ferreteria"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.HeaderText = "Id_Eemento_Ferreteria"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.Name = "IdEementoFerreteriaDataGridViewTextBoxColumn"
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdEementoFerreteriaDataGridViewTextBoxColumn.ValueMember = "IdFerreteria"
        '
        'CantidadFerreteriaDataGridViewTextBoxColumn
        '
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Ferreteria"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n0"
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.Name = "CantidadFerreteriaDataGridViewTextBoxColumn"
        Me.CantidadFerreteriaDataGridViewTextBoxColumn.Width = 75
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Location = New System.Drawing.Point(21, 184)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(117, 23)
        Me.CmdNuevo.TabIndex = 12
        Me.CmdNuevo.Text = "Nuevo Elemento"
        Me.CmdNuevo.UseVisualStyleBackColor = true
        '
        'Id_Sub_ArticuloLabel
        '
        Me.Id_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Id_Sub_ArticuloLabel.Location = New System.Drawing.Point(21, 25)
        Me.Id_Sub_ArticuloLabel.Name = "Id_Sub_ArticuloLabel"
        Me.Id_Sub_ArticuloLabel.Size = New System.Drawing.Size(90, 20)
        Me.Id_Sub_ArticuloLabel.TabIndex = 0
        Me.Id_Sub_ArticuloLabel.Text = "Id Sub Articulo:"
        '
        'Descripcion_Sub_ArticuloLabel
        '
        Me.Descripcion_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Descripcion_Sub_ArticuloLabel.Location = New System.Drawing.Point(21, 50)
        Me.Descripcion_Sub_ArticuloLabel.Name = "Descripcion_Sub_ArticuloLabel"
        Me.Descripcion_Sub_ArticuloLabel.Size = New System.Drawing.Size(90, 20)
        Me.Descripcion_Sub_ArticuloLabel.TabIndex = 2
        Me.Descripcion_Sub_ArticuloLabel.Text = "Descripcion "
        '
        'Minutos__Trabajo_Sub_ArticuloLabel
        '
        Me.Minutos__Trabajo_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Location = New System.Drawing.Point(234, 25)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Name = "Minutos__Trabajo_Sub_ArticuloLabel"
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Size = New System.Drawing.Size(90, 20)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.TabIndex = 6
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Text = "Minutos  Trabajo Sub Articulo:"
        '
        'TxtM2Pintura
        '
        Me.TxtM2Pintura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "M2Pintura", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtM2Pintura.Location = New System.Drawing.Point(460, 25)
        Me.TxtM2Pintura.Name = "TxtM2Pintura"
        Me.TxtM2Pintura.Size = New System.Drawing.Size(100, 20)
        Me.TxtM2Pintura.TabIndex = 45
        Me.TxtM2Pintura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubArticulosBindingNavigator
        '
        Me.SubArticulosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SubArticulosBindingNavigator.BindingSource = Me.SubArticulosBindingSource
        Me.SubArticulosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SubArticulosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SubArticulosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SubArticulosBindingNavigatorSaveItem})
        Me.SubArticulosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SubArticulosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SubArticulosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SubArticulosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SubArticulosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SubArticulosBindingNavigator.Name = "SubArticulosBindingNavigator"
        Me.SubArticulosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SubArticulosBindingNavigator.Size = New System.Drawing.Size(1295, 25)
        Me.SubArticulosBindingNavigator.TabIndex = 51
        Me.SubArticulosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = false
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SubArticulosBindingNavigatorSaveItem
        '
        Me.SubArticulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SubArticulosBindingNavigatorSaveItem.Image = CType(resources.GetObject("SubArticulosBindingNavigatorSaveItem.Image"),System.Drawing.Image)
        Me.SubArticulosBindingNavigatorSaveItem.Name = "SubArticulosBindingNavigatorSaveItem"
        Me.SubArticulosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SubArticulosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MaterialPrincipalLabel
        '
        MaterialPrincipalLabel.AutoSize = true
        MaterialPrincipalLabel.Location = New System.Drawing.Point(237, 79)
        MaterialPrincipalLabel.Name = "MaterialPrincipalLabel"
        MaterialPrincipalLabel.Size = New System.Drawing.Size(90, 13)
        MaterialPrincipalLabel.TabIndex = 51
        MaterialPrincipalLabel.Text = "Material Principal:"
        MaterialPrincipalLabel.Visible = false
        '
        'MaterialPrincipalTextBox
        '
        Me.MaterialPrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "MaterialPrincipal", true))
        Me.MaterialPrincipalTextBox.Location = New System.Drawing.Point(333, 76)
        Me.MaterialPrincipalTextBox.Name = "MaterialPrincipalTextBox"
        Me.MaterialPrincipalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MaterialPrincipalTextBox.TabIndex = 52
        Me.MaterialPrincipalTextBox.Visible = false
        '
        'FrmSubarticulosGenerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.ClientSize = New System.Drawing.Size(1295, 733)
        Me.Controls.Add(MaterialPrincipalLabel)
        Me.Controls.Add(Me.MaterialPrincipalTextBox)
        Me.Controls.Add(Me.SubArticulosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnDuplicarRegistro)
        Me.Controls.Add(Me.CmdNuevoDetaleferreteria)
        Me.Controls.Add(Me.CmdVerConsumos)
        Me.Controls.Add(Me.CmdFerreteria)
        Me.Name = "FrmSubarticulosGenerar"
        Me.Text = "FrmSubarticulosGenerar"
        CType(Me.SubArticulosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsSubArticulos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsDuplicarSubArticuloDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DuplicarSubArticulosDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMaterialMedidadCompra,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MaterialMedidaCompraBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMaterial,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MaterialesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsSubArticulosFerreteria,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubArticulosDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsSubArticulosDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubArticulosDetalleFerreteriaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DescripcionesDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsDescripcionesdetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DescripcionesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsDescripciones,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MaterialesFamiliaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMaterialFamilia,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsArticulosdetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsFerreteria,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FerreteriaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MaterilaesDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMaterialDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MedidasCompraBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsMedidasCompra,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PresupuestoDetalleElementosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPresupuestoDetalleElementos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ArticulosDetalleBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PresupuestoDetalleElementosDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubArticulosDetalleDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubArticulosBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.SubArticulosBindingNavigator.ResumeLayout(false)
        Me.SubArticulosBindingNavigator.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BtnDuplicarRegistro As System.Windows.Forms.Button
    Friend WithEvents CmdNuevoDetaleferreteria As System.Windows.Forms.Button
    Friend WithEvents CmdVerConsumos As System.Windows.Forms.Button
    Friend WithEvents CmdFerreteria As System.Windows.Forms.Button
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents TableAdapterManager6 As ModuloGestion.DsMaterialTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesTableAdapter As ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter
    Friend WithEvents DsDuplicarSubArticuloDetalle As ModuloGestion.DsDuplicarSubArticuloDetalle
    Friend WithEvents DuplicarSubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DuplicarSubArticulosDetalleTableAdapter As ModuloGestion.DsDuplicarSubArticuloDetalleTableAdapters.DuplicarSubArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager
    Friend WithEvents MaterialesFamiliaTableAdapter As ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager7 As ModuloGestion.DsDuplicarSubArticuloDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionesTableAdapter As ModuloGestion.DsDescripcionesTableAdapters.DescripcionesTableAdapter
    Friend WithEvents TableAdapterManager8 As ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager9 As ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionesDetalleTableAdapter As ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter
   
    Friend WithEvents TableAdapterManager11 As ModuloGestion.DsMaterialMedidadCompraTableAdapters.TableAdapterManager
    Friend WithEvents MaterialMedidaCompraTableAdapter As ModuloGestion.DsMaterialMedidadCompraTableAdapters.MaterialMedidaCompraTableAdapter
    Friend WithEvents FerreteriaTableAdapter As ModuloGestion.DsFerreteriaTableAdapters.FerreteriaTableAdapter
    Friend WithEvents TableAdapterManager10 As ModuloGestion.DsFerreteriaTableAdapters.TableAdapterManager
    Friend WithEvents DsMaterialMedidadCompra As ModuloGestion.DsMaterialMedidadCompra
    Friend WithEvents MaterialMedidaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMaterial As ModuloGestion.DsMaterial
    Friend WithEvents MaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsSubArticulosFerreteriaTableAdapters.TableAdapterManager
    Friend WithEvents SubArticulosDetalleFerreteriaTableAdapter As ModuloGestion.DsSubArticulosFerreteriaTableAdapters.SubArticulosDetalleFerreteriaTableAdapter
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager
    Friend WithEvents SubArticulosDetalleTableAdapter As ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents DsSubArticulosFerreteria As ModuloGestion.DsSubArticulosFerreteria
    Friend WithEvents SubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSubArticulosDetalle As ModuloGestion.DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleFerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDescripcionesdetalle As ModuloGestion.DsDescripcionesdetalle
    Friend WithEvents DescripcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDescripciones As ModuloGestion.DsDescripciones
    Friend WithEvents MaterialesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMaterialFamilia As ModuloGestion.DsMaterialFamilia
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents DsFerreteria As ModuloGestion.DsFerreteria
    Friend WithEvents FerreteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra

    Friend WithEvents PresupuestoDetalleElementosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPresupuestoDetalleElementos As ModuloGestion.DsPresupuestoDetalleElementos
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager13 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleElementosTableAdapter As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.PresupuestoDetalleElementosTableAdapter
    Friend WithEvents TableAdapterManager14 As ModuloGestion.DsPresupuestoDetalleElementosTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PresupuestoDetalleElementosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrupoSubarticulo As System.Windows.Forms.TextBox
    Friend WithEvents SubArticulosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewComboBoxColumn
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
    Friend WithEvents TxtTiempoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdSubarticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IddetalleFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSubArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEementoFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CantidadFerreteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Id_Sub_ArticuloLabel As System.Windows.Forms.Label
    Friend WithEvents Descripcion_Sub_ArticuloLabel As System.Windows.Forms.Label
    Friend WithEvents Minutos__Trabajo_Sub_ArticuloLabel As System.Windows.Forms.Label
    Friend WithEvents TxtM2Pintura As System.Windows.Forms.TextBox
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
    Friend WithEvents MaterialPrincipalTextBox As System.Windows.Forms.TextBox
End Class
