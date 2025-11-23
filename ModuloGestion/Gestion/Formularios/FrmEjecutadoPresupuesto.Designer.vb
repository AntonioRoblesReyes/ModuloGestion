<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEjecutadoPresupuesto
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
        Dim EjSubtotalUSLabel As System.Windows.Forms.Label
        Dim EjSubtotalRDLabel As System.Windows.Forms.Label
        Dim SubTotalRDLabel As System.Windows.Forms.Label
        Dim SubTotalUSLabel As System.Windows.Forms.Label
        Dim EjecutadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjecutadoPresupuesto))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PresupuestoDetalleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EjecutadoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EjecutadoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.EjSubtotalUSTextBox = New System.Windows.Forms.TextBox()
        Me.EjSubtotalRDTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalRDTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalUSTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlTotales = New System.Windows.Forms.Panel()
        Me.tlpTotales = New System.Windows.Forms.TableLayoutPanel()
        Me.contRight = New System.Windows.Forms.FlowLayoutPanel()
        Me.EjecutadoTextBox = New System.Windows.Forms.TextBox()
        EjSubtotalUSLabel = New System.Windows.Forms.Label()
        EjSubtotalRDLabel = New System.Windows.Forms.Label()
        SubTotalRDLabel = New System.Windows.Forms.Label()
        SubTotalUSLabel = New System.Windows.Forms.Label()
        EjecutadoLabel = New System.Windows.Forms.Label()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PresupuestoDetalleBindingNavigator.SuspendLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        Me.tlpTotales.SuspendLayout()
        Me.contRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'EjSubtotalUSLabel
        '
        EjSubtotalUSLabel.AutoSize = True
        EjSubtotalUSLabel.Location = New System.Drawing.Point(402, 0)
        EjSubtotalUSLabel.Name = "EjSubtotalUSLabel"
        EjSubtotalUSLabel.Size = New System.Drawing.Size(106, 20)
        EjSubtotalUSLabel.TabIndex = 2
        EjSubtotalUSLabel.Text = "Ej Subtotal US:"
        '
        'EjSubtotalRDLabel
        '
        EjSubtotalRDLabel.AutoSize = True
        EjSubtotalRDLabel.Location = New System.Drawing.Point(402, 44)
        EjSubtotalRDLabel.Name = "EjSubtotalRDLabel"
        EjSubtotalRDLabel.Size = New System.Drawing.Size(108, 20)
        EjSubtotalRDLabel.TabIndex = 6
        EjSubtotalRDLabel.Text = "Ej Subtotal RD:"
        '
        'SubTotalRDLabel
        '
        SubTotalRDLabel.AutoSize = True
        SubTotalRDLabel.Location = New System.Drawing.Point(122, 44)
        SubTotalRDLabel.Name = "SubTotalRDLabel"
        SubTotalRDLabel.Size = New System.Drawing.Size(98, 20)
        SubTotalRDLabel.TabIndex = 4
        SubTotalRDLabel.Text = "Sub Total RD:"
        '
        'SubTotalUSLabel
        '
        SubTotalUSLabel.AutoSize = True
        SubTotalUSLabel.Location = New System.Drawing.Point(122, 0)
        SubTotalUSLabel.Name = "SubTotalUSLabel"
        SubTotalUSLabel.Size = New System.Drawing.Size(96, 20)
        SubTotalUSLabel.TabIndex = 0
        SubTotalUSLabel.Text = "Sub Total US:"
        '
        'EjecutadoLabel
        '
        EjecutadoLabel.AutoSize = True
        EjecutadoLabel.Location = New System.Drawing.Point(0, 6)
        EjecutadoLabel.Margin = New System.Windows.Forms.Padding(0, 6, 8, 0)
        EjecutadoLabel.Name = "EjecutadoLabel"
        EjecutadoLabel.Size = New System.Drawing.Size(78, 20)
        EjecutadoLabel.TabIndex = 0
        EjecutadoLabel.Text = "Ejecutado:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleBindingNavigator
        '
        Me.PresupuestoDetalleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PresupuestoDetalleBindingNavigator.BindingSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PresupuestoDetalleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PresupuestoDetalleBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PresupuestoDetalleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PresupuestoDetalleBindingNavigatorSaveItem})
        Me.PresupuestoDetalleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PresupuestoDetalleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PresupuestoDetalleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PresupuestoDetalleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PresupuestoDetalleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PresupuestoDetalleBindingNavigator.Name = "PresupuestoDetalleBindingNavigator"
        Me.PresupuestoDetalleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PresupuestoDetalleBindingNavigator.Size = New System.Drawing.Size(1336, 31)
        Me.PresupuestoDetalleBindingNavigator.TabIndex = 0
        Me.PresupuestoDetalleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'PresupuestoDetalleBindingNavigatorSaveItem
        '
        Me.PresupuestoDetalleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Image = CType(resources.GetObject("PresupuestoDetalleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Name = "PresupuestoDetalleBindingNavigatorSaveItem"
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PresupuestoDetalleDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PresupuestoDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PresupuestoDetalleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PresupuestoDetalleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresupuestoDetalleDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeight = 32
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.Cantidad, Me.TotalUS, Me.TotalRD, Me.Ejecutado, Me.EjecutadoUS, Me.EjecutadoRD})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PresupuestoDetalleDataGridView.DefaultCellStyle = DataGridViewCellStyle18
        Me.PresupuestoDetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PresupuestoDetalleDataGridView.EnableHeadersVisualStyles = False
        Me.PresupuestoDetalleDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(0, 101)
        Me.PresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(16)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.RowHeadersVisible = False
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.RowTemplate.Height = 28
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(1336, 459)
        Me.PresupuestoDetalleDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdDetalle"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.ArticulosBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn1.HeaderText = "Artículo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "IdArticulo"
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
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "n2"
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle12
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 90
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "n2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle13
        Me.TotalUS.HeaderText = "Total US"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.Width = 110
        '
        'TotalRD
        '
        Me.TotalRD.DataPropertyName = "TotalPartidaRD$"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "n2"
        Me.TotalRD.DefaultCellStyle = DataGridViewCellStyle14
        Me.TotalRD.HeaderText = "Total RD"
        Me.TotalRD.MinimumWidth = 6
        Me.TotalRD.Name = "TotalRD"
        Me.TotalRD.Width = 110
        '
        'Ejecutado
        '
        Me.Ejecutado.DataPropertyName = "Ejecutado"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "#0 \\%"
        DataGridViewCellStyle15.NullValue = "0"
        Me.Ejecutado.DefaultCellStyle = DataGridViewCellStyle15
        Me.Ejecutado.HeaderText = "Ejecutado"
        Me.Ejecutado.MinimumWidth = 6
        Me.Ejecutado.Name = "Ejecutado"
        Me.Ejecutado.Width = 95
        '
        'EjecutadoUS
        '
        Me.EjecutadoUS.DataPropertyName = "ValorEjecutadoUS"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "n2"
        Me.EjecutadoUS.DefaultCellStyle = DataGridViewCellStyle16
        Me.EjecutadoUS.HeaderText = "Ejecutado US"
        Me.EjecutadoUS.MinimumWidth = 6
        Me.EjecutadoUS.Name = "EjecutadoUS"
        Me.EjecutadoUS.Width = 130
        '
        'EjecutadoRD
        '
        Me.EjecutadoRD.DataPropertyName = "ValorEjecutadoRD"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "n2"
        Me.EjecutadoRD.DefaultCellStyle = DataGridViewCellStyle17
        Me.EjecutadoRD.HeaderText = "Ejecutado RD"
        Me.EjecutadoRD.MinimumWidth = 6
        Me.EjecutadoRD.Name = "EjecutadoRD"
        Me.EjecutadoRD.Width = 130
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(120, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Id Prespuesto"
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EjSubtotalUSTextBox
        '
        Me.EjSubtotalUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "EjSubtotalUS", True))
        Me.EjSubtotalUSTextBox.Location = New System.Drawing.Point(522, 3)
        Me.EjSubtotalUSTextBox.Name = "EjSubtotalUSTextBox"
        Me.EjSubtotalUSTextBox.Size = New System.Drawing.Size(100, 27)
        Me.EjSubtotalUSTextBox.TabIndex = 3
        Me.EjSubtotalUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EjSubtotalRDTextBox
        '
        Me.EjSubtotalRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "EjSubtotalRD", True))
        Me.EjSubtotalRDTextBox.Location = New System.Drawing.Point(522, 47)
        Me.EjSubtotalRDTextBox.Name = "EjSubtotalRDTextBox"
        Me.EjSubtotalRDTextBox.Size = New System.Drawing.Size(100, 27)
        Me.EjSubtotalRDTextBox.TabIndex = 7
        Me.EjSubtotalRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalRDTextBox
        '
        Me.SubTotalRDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "SubTotalRD", True))
        Me.SubTotalRDTextBox.Location = New System.Drawing.Point(242, 47)
        Me.SubTotalRDTextBox.Name = "SubTotalRDTextBox"
        Me.SubTotalRDTextBox.Size = New System.Drawing.Size(100, 27)
        Me.SubTotalRDTextBox.TabIndex = 5
        Me.SubTotalRDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubTotalUSTextBox
        '
        Me.SubTotalUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "SubTotalUS", True))
        Me.SubTotalUSTextBox.Location = New System.Drawing.Point(242, 3)
        Me.SubTotalUSTextBox.Name = "SubTotalUSTextBox"
        Me.SubTotalUSTextBox.Size = New System.Drawing.Size(100, 27)
        Me.SubTotalUSTextBox.TabIndex = 1
        Me.SubTotalUSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(215, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.Button1.Size = New System.Drawing.Size(99, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Recalcular"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 31)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(16, 10, 16, 10)
        Me.pnlHeader.Size = New System.Drawing.Size(1336, 70)
        Me.pnlHeader.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(12, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(253, 28)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ejecución de Presupuesto"
        '
        'pnlTotales
        '
        Me.pnlTotales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTotales.Controls.Add(Me.tlpTotales)
        Me.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotales.Location = New System.Drawing.Point(0, 560)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlTotales.Size = New System.Drawing.Size(1336, 120)
        Me.pnlTotales.TabIndex = 1
        '
        'tlpTotales
        '
        Me.tlpTotales.ColumnCount = 6
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.tlpTotales.Controls.Add(SubTotalUSLabel, 1, 0)
        Me.tlpTotales.Controls.Add(Me.SubTotalUSTextBox, 2, 0)
        Me.tlpTotales.Controls.Add(EjSubtotalUSLabel, 3, 0)
        Me.tlpTotales.Controls.Add(Me.EjSubtotalUSTextBox, 4, 0)
        Me.tlpTotales.Controls.Add(SubTotalRDLabel, 1, 1)
        Me.tlpTotales.Controls.Add(Me.SubTotalRDTextBox, 2, 1)
        Me.tlpTotales.Controls.Add(EjSubtotalRDLabel, 3, 1)
        Me.tlpTotales.Controls.Add(Me.EjSubtotalRDTextBox, 4, 1)
        Me.tlpTotales.Controls.Add(Me.contRight, 5, 0)
        Me.tlpTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTotales.Location = New System.Drawing.Point(16, 16)
        Me.tlpTotales.Name = "tlpTotales"
        Me.tlpTotales.RowCount = 2
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTotales.Size = New System.Drawing.Size(1304, 88)
        Me.tlpTotales.TabIndex = 0
        '
        'contRight
        '
        Me.contRight.AutoSize = True
        Me.contRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.contRight.Controls.Add(EjecutadoLabel)
        Me.contRight.Controls.Add(Me.EjecutadoTextBox)
        Me.contRight.Controls.Add(Me.Button1)
        Me.contRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contRight.Location = New System.Drawing.Point(682, 3)
        Me.contRight.Name = "contRight"
        Me.tlpTotales.SetRowSpan(Me.contRight, 2)
        Me.contRight.Size = New System.Drawing.Size(619, 82)
        Me.contRight.TabIndex = 8
        Me.contRight.WrapContents = False
        '
        'EjecutadoTextBox
        '
        Me.EjecutadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Ejecutado", True))
        Me.EjecutadoTextBox.Location = New System.Drawing.Point(89, 3)
        Me.EjecutadoTextBox.Name = "EjecutadoTextBox"
        Me.EjecutadoTextBox.Size = New System.Drawing.Size(120, 27)
        Me.EjecutadoTextBox.TabIndex = 1
        Me.EjecutadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmEjecutadoPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1336, 680)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.pnlTotales)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.PresupuestoDetalleBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "FrmEjecutadoPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejecución de Presupuesto"
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PresupuestoDetalleBindingNavigator.ResumeLayout(False)
        Me.PresupuestoDetalleBindingNavigator.PerformLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlTotales.ResumeLayout(False)
        Me.tlpTotales.ResumeLayout(False)
        Me.tlpTotales.PerformLayout()
        Me.contRight.ResumeLayout(False)
        Me.contRight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    '=== TUS CAMPOS ORIGINALES (SIN CAMBIOS) ===
    Friend WithEvents DsPresupuestoDetalle As DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager As DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PresupuestoDetalleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PresupuestoDetalleDataGridView As DataGridView
    Friend WithEvents DsArticulos As DsArticulos
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager1 As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents EjSubtotalUSTextBox As TextBox
    Friend WithEvents EjSubtotalRDTextBox As TextBox
    Friend WithEvents SubTotalRDTextBox As TextBox
    Friend WithEvents SubTotalUSTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalRD As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutado As DataGridViewTextBoxColumn
    Friend WithEvents EjecutadoUS As DataGridViewTextBoxColumn
    Friend WithEvents EjecutadoRD As DataGridViewTextBoxColumn

    '=== NUEVOS CONTENEDORES (SOLO VISUAL, NO SUSTITUYEN NADA) ===
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlTotales As Panel
    Friend WithEvents tlpTotales As TableLayoutPanel
    Friend WithEvents contRight As FlowLayoutPanel
    Friend WithEvents EjecutadoTextBox As TextBox
End Class
