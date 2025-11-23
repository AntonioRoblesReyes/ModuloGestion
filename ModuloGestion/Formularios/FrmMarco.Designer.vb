<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarco))
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager()
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SubArticulosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SubArticulosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.TxtTiempoTrabajo = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.Id_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.Descripcion_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.Minutos__Trabajo_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Me.TxtM2Pintura = New System.Windows.Forms.TextBox()
        Me.TxtIdSubarticulo = New System.Windows.Forms.TextBox()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubArticulosBindingNavigator.SuspendLayout()
        CType(Me.SubArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsSubArticulos
        '
        Me.DsSubArticulos.DataSetName = "DsSubArticulos"
        Me.DsSubArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubArticulosBindingSource
        '
        Me.SubArticulosBindingSource.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource.DataSource = Me.DsSubArticulos
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.SubArticulosDetalleTableAdapter = Me.SubArticulosDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
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
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'SubArticulosBindingNavigatorSaveItem
        '
        Me.SubArticulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SubArticulosBindingNavigatorSaveItem.Image = CType(resources.GetObject("SubArticulosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SubArticulosBindingNavigatorSaveItem.Name = "SubArticulosBindingNavigatorSaveItem"
        Me.SubArticulosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SubArticulosBindingNavigatorSaveItem.Text = "Guardar datos"
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
        Me.SubArticulosBindingNavigator.Size = New System.Drawing.Size(1000, 25)
        Me.SubArticulosBindingNavigator.TabIndex = 0
        Me.SubArticulosBindingNavigator.Text = "BindingNavigator1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "M2Pintura"
        Me.DataGridViewTextBoxColumn5.HeaderText = "M2Pintura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "GrupoSubArticulos"
        Me.DataGridViewTextBoxColumn4.HeaderText = "GrupoSubArticulos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Minutos _Trabajo_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Minutos _Trabajo_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'SubArticulosDataGridView
        '
        Me.SubArticulosDataGridView.AutoGenerateColumns = False
        Me.SubArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SubArticulosDataGridView.DataSource = Me.SubArticulosBindingSource
        Me.SubArticulosDataGridView.Location = New System.Drawing.Point(75, 188)
        Me.SubArticulosDataGridView.Name = "SubArticulosDataGridView"
        Me.SubArticulosDataGridView.Size = New System.Drawing.Size(862, 120)
        Me.SubArticulosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Id_Medida"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "NuevoId"
        Me.DataGridViewTextBoxColumn27.HeaderText = "NuevoId"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TotalCompra"
        Me.DataGridViewTextBoxColumn26.HeaderText = "TotalCompra"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn25.HeaderText = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn24.HeaderText = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn23.HeaderText = "M2PinuturaUnidadtotal"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "M2PinuturaUnidad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "M2Cabeza"
        Me.DataGridViewTextBoxColumn20.HeaderText = "M2Cabeza"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "M2Canto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "M2Canto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "M2Cara"
        Me.DataGridViewTextBoxColumn18.HeaderText = "M2Cara"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PiesUnidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PiesUnidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "GruesoPulgadas"
        Me.DataGridViewTextBoxColumn16.HeaderText = "GruesoPulgadas"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Anchopulgadas"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Anchopulgadas"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PiesLargo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PiesLargo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Grueso"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Grueso"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Ancho"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Largo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_detalle_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'SubArticulosDetalleDataGridView
        '
        Me.SubArticulosDetalleDataGridView.AutoGenerateColumns = False
        Me.SubArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.SubArticulosDetalleDataGridView.DataSource = Me.SubArticulosDetalleBindingSource
        Me.SubArticulosDetalleDataGridView.Location = New System.Drawing.Point(75, 328)
        Me.SubArticulosDetalleDataGridView.Name = "SubArticulosDetalleDataGridView"
        Me.SubArticulosDetalleDataGridView.Size = New System.Drawing.Size(862, 220)
        Me.SubArticulosDetalleDataGridView.TabIndex = 2
        '
        'TxtTiempoTrabajo
        '
        Me.TxtTiempoTrabajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Minutos _Trabajo_Sub_Articulo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TxtTiempoTrabajo.Location = New System.Drawing.Point(383, 62)
        Me.TxtTiempoTrabajo.Name = "TxtTiempoTrabajo"
        Me.TxtTiempoTrabajo.Size = New System.Drawing.Size(59, 20)
        Me.TxtTiempoTrabajo.TabIndex = 51
        Me.TxtTiempoTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Descripcion_Sub_Articulo", True))
        Me.TxtDescripcion.Location = New System.Drawing.Point(168, 88)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(274, 45)
        Me.TxtDescripcion.TabIndex = 50
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Location = New System.Drawing.Point(58, 110)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(104, 23)
        Me.CmdNuevo.TabIndex = 49
        Me.CmdNuevo.Text = "Nuevo Elemento"
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'Id_Sub_ArticuloLabel
        '
        Me.Id_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Id_Sub_ArticuloLabel.Location = New System.Drawing.Point(58, 59)
        Me.Id_Sub_ArticuloLabel.Name = "Id_Sub_ArticuloLabel"
        Me.Id_Sub_ArticuloLabel.Size = New System.Drawing.Size(104, 20)
        Me.Id_Sub_ArticuloLabel.TabIndex = 46
        Me.Id_Sub_ArticuloLabel.Text = "Id Sub Articulo:"
        '
        'Descripcion_Sub_ArticuloLabel
        '
        Me.Descripcion_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Descripcion_Sub_ArticuloLabel.Location = New System.Drawing.Point(58, 83)
        Me.Descripcion_Sub_ArticuloLabel.Name = "Descripcion_Sub_ArticuloLabel"
        Me.Descripcion_Sub_ArticuloLabel.Size = New System.Drawing.Size(104, 20)
        Me.Descripcion_Sub_ArticuloLabel.TabIndex = 47
        Me.Descripcion_Sub_ArticuloLabel.Text = "Descripcion "
        '
        'Minutos__Trabajo_Sub_ArticuloLabel
        '
        Me.Minutos__Trabajo_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Location = New System.Drawing.Point(286, 62)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Name = "Minutos__Trabajo_Sub_ArticuloLabel"
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Size = New System.Drawing.Size(90, 20)
        Me.Minutos__Trabajo_Sub_ArticuloLabel.TabIndex = 48
        Me.Minutos__Trabajo_Sub_ArticuloLabel.Text = "Minutos  Trabajo Sub Articulo:"
        '
        'TxtM2Pintura
        '
        Me.TxtM2Pintura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "M2Pintura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TxtM2Pintura.Enabled = False
        Me.TxtM2Pintura.Location = New System.Drawing.Point(512, 62)
        Me.TxtM2Pintura.Name = "TxtM2Pintura"
        Me.TxtM2Pintura.Size = New System.Drawing.Size(66, 20)
        Me.TxtM2Pintura.TabIndex = 52
        Me.TxtM2Pintura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIdSubarticulo
        '
        Me.TxtIdSubarticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Id_Sub_Articulo", True))
        Me.TxtIdSubarticulo.Enabled = False
        Me.TxtIdSubarticulo.Location = New System.Drawing.Point(168, 60)
        Me.TxtIdSubarticulo.Name = "TxtIdSubarticulo"
        Me.TxtIdSubarticulo.Size = New System.Drawing.Size(112, 20)
        Me.TxtIdSubarticulo.TabIndex = 53
        '
        'FrmMarco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 628)
        Me.Controls.Add(Me.TxtIdSubarticulo)
        Me.Controls.Add(Me.TxtTiempoTrabajo)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CmdNuevo)
        Me.Controls.Add(Me.Id_Sub_ArticuloLabel)
        Me.Controls.Add(Me.Descripcion_Sub_ArticuloLabel)
        Me.Controls.Add(Me.Minutos__Trabajo_Sub_ArticuloLabel)
        Me.Controls.Add(Me.TxtM2Pintura)
        Me.Controls.Add(Me.SubArticulosDetalleDataGridView)
        Me.Controls.Add(Me.SubArticulosDataGridView)
        Me.Controls.Add(Me.SubArticulosBindingNavigator)
        Me.Name = "FrmMarco"
        Me.Text = "FrmMarco"
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubArticulosBindingNavigator.ResumeLayout(False)
        Me.SubArticulosBindingNavigator.PerformLayout()
        CType(Me.SubArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsSubArticulos As DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As BindingSource
    Friend WithEvents SubArticulosTableAdapter As DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents TableAdapterManager As DsSubArticulosTableAdapters.TableAdapterManager
    Friend WithEvents DsSubArticulosDetalle As DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleBindingSource As BindingSource
    Friend WithEvents SubArticulosDetalleTableAdapter As DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As DsSubArticulosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents SubArticulosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SubArticulosBindingNavigator As BindingNavigator
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SubArticulosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SubArticulosDetalleDataGridView As DataGridView
    Friend WithEvents TxtTiempoTrabajo As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmdNuevo As Button
    Friend WithEvents Id_Sub_ArticuloLabel As Label
    Friend WithEvents Descripcion_Sub_ArticuloLabel As Label
    Friend WithEvents Minutos__Trabajo_Sub_ArticuloLabel As Label
    Friend WithEvents TxtM2Pintura As TextBox
    Friend WithEvents TxtIdSubarticulo As TextBox
End Class
