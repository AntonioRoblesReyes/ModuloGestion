<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMntajeYDescuento
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
        Dim ArticuloLabel As System.Windows.Forms.Label
        Dim PresupuestoLabel As System.Windows.Forms.Label
        Dim IdDetalle_PresupuestoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Precio_GeneradoLabel As System.Windows.Forms.Label
        Dim Precio_AjustadoLabel As System.Windows.Forms.Label
        Dim TotalPartidaLabel As System.Windows.Forms.Label
        Dim DescuentoLabel As System.Windows.Forms.Label
        Dim PorcientoMontajeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMntajeYDescuento))
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
        Me.ArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoTextBox = New System.Windows.Forms.TextBox()
        Me.IdDetalle_PresupuestoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_GeneradoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_AjustadoTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPartidaTextBox = New System.Windows.Forms.TextBox()
        Me.DescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.PorcientoMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdAceptarCambios = New System.Windows.Forms.Button()
        ArticuloLabel = New System.Windows.Forms.Label()
        PresupuestoLabel = New System.Windows.Forms.Label()
        IdDetalle_PresupuestoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Precio_GeneradoLabel = New System.Windows.Forms.Label()
        Precio_AjustadoLabel = New System.Windows.Forms.Label()
        TotalPartidaLabel = New System.Windows.Forms.Label()
        DescuentoLabel = New System.Windows.Forms.Label()
        PorcientoMontajeLabel = New System.Windows.Forms.Label()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PresupuestoDetalleBindingNavigator.SuspendLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArticuloLabel
        '
        ArticuloLabel.AutoSize = True
        ArticuloLabel.Location = New System.Drawing.Point(69, 77)
        ArticuloLabel.Name = "ArticuloLabel"
        ArticuloLabel.Size = New System.Drawing.Size(45, 13)
        ArticuloLabel.TabIndex = 1
        ArticuloLabel.Text = "Articulo:"
        '
        'PresupuestoLabel
        '
        PresupuestoLabel.AutoSize = True
        PresupuestoLabel.Location = New System.Drawing.Point(69, 103)
        PresupuestoLabel.Name = "PresupuestoLabel"
        PresupuestoLabel.Size = New System.Drawing.Size(69, 13)
        PresupuestoLabel.TabIndex = 3
        PresupuestoLabel.Text = "Presupuesto:"
        '
        'IdDetalle_PresupuestoLabel
        '
        IdDetalle_PresupuestoLabel.AutoSize = True
        IdDetalle_PresupuestoLabel.Location = New System.Drawing.Point(69, 129)
        IdDetalle_PresupuestoLabel.Name = "IdDetalle_PresupuestoLabel"
        IdDetalle_PresupuestoLabel.Size = New System.Drawing.Size(117, 13)
        IdDetalle_PresupuestoLabel.TabIndex = 5
        IdDetalle_PresupuestoLabel.Text = "Id Detalle Presupuesto:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(69, 155)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 7
        CantidadLabel.Text = "Cantidad:"
        '
        'Precio_GeneradoLabel
        '
        Precio_GeneradoLabel.AutoSize = True
        Precio_GeneradoLabel.Location = New System.Drawing.Point(69, 181)
        Precio_GeneradoLabel.Name = "Precio_GeneradoLabel"
        Precio_GeneradoLabel.Size = New System.Drawing.Size(90, 13)
        Precio_GeneradoLabel.TabIndex = 9
        Precio_GeneradoLabel.Text = "Precio Generado:"
        '
        'Precio_AjustadoLabel
        '
        Precio_AjustadoLabel.AutoSize = True
        Precio_AjustadoLabel.Location = New System.Drawing.Point(69, 207)
        Precio_AjustadoLabel.Name = "Precio_AjustadoLabel"
        Precio_AjustadoLabel.Size = New System.Drawing.Size(84, 13)
        Precio_AjustadoLabel.TabIndex = 11
        Precio_AjustadoLabel.Text = "Precio Ajustado:"
        '
        'TotalPartidaLabel
        '
        TotalPartidaLabel.AutoSize = True
        TotalPartidaLabel.Location = New System.Drawing.Point(69, 233)
        TotalPartidaLabel.Name = "TotalPartidaLabel"
        TotalPartidaLabel.Size = New System.Drawing.Size(70, 13)
        TotalPartidaLabel.TabIndex = 13
        TotalPartidaLabel.Text = "Total Partida:"
        '
        'DescuentoLabel
        '
        DescuentoLabel.AutoSize = True
        DescuentoLabel.Location = New System.Drawing.Point(69, 259)
        DescuentoLabel.Name = "DescuentoLabel"
        DescuentoLabel.Size = New System.Drawing.Size(62, 13)
        DescuentoLabel.TabIndex = 15
        DescuentoLabel.Text = "Descuento:"
        '
        'PorcientoMontajeLabel
        '
        PorcientoMontajeLabel.AutoSize = True
        PorcientoMontajeLabel.Location = New System.Drawing.Point(69, 285)
        PorcientoMontajeLabel.Name = "PorcientoMontajeLabel"
        PorcientoMontajeLabel.Size = New System.Drawing.Size(96, 13)
        PorcientoMontajeLabel.TabIndex = 17
        PorcientoMontajeLabel.Text = "Porciento Montaje:"
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
        Me.PresupuestoDetalleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PresupuestoDetalleBindingNavigatorSaveItem})
        Me.PresupuestoDetalleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PresupuestoDetalleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PresupuestoDetalleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PresupuestoDetalleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PresupuestoDetalleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PresupuestoDetalleBindingNavigator.Name = "PresupuestoDetalleBindingNavigator"
        Me.PresupuestoDetalleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PresupuestoDetalleBindingNavigator.Size = New System.Drawing.Size(588, 25)
        Me.PresupuestoDetalleBindingNavigator.TabIndex = 0
        Me.PresupuestoDetalleBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        'PresupuestoDetalleBindingNavigatorSaveItem
        '
        Me.PresupuestoDetalleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Image = CType(resources.GetObject("PresupuestoDetalleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Name = "PresupuestoDetalleBindingNavigatorSaveItem"
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PresupuestoDetalleBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ArticuloTextBox
        '
        Me.ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Articulo", True))
        Me.ArticuloTextBox.Location = New System.Drawing.Point(192, 74)
        Me.ArticuloTextBox.Name = "ArticuloTextBox"
        Me.ArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArticuloTextBox.TabIndex = 2
        '
        'PresupuestoTextBox
        '
        Me.PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Presupuesto", True))
        Me.PresupuestoTextBox.Location = New System.Drawing.Point(192, 100)
        Me.PresupuestoTextBox.Name = "PresupuestoTextBox"
        Me.PresupuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PresupuestoTextBox.TabIndex = 4
        '
        'IdDetalle_PresupuestoTextBox
        '
        Me.IdDetalle_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "IdDetalle_Presupuesto", True))
        Me.IdDetalle_PresupuestoTextBox.Location = New System.Drawing.Point(192, 126)
        Me.IdDetalle_PresupuestoTextBox.Name = "IdDetalle_PresupuestoTextBox"
        Me.IdDetalle_PresupuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdDetalle_PresupuestoTextBox.TabIndex = 6
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(192, 152)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 8
        '
        'Precio_GeneradoTextBox
        '
        Me.Precio_GeneradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Precio_Generado", True))
        Me.Precio_GeneradoTextBox.Location = New System.Drawing.Point(192, 178)
        Me.Precio_GeneradoTextBox.Name = "Precio_GeneradoTextBox"
        Me.Precio_GeneradoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Precio_GeneradoTextBox.TabIndex = 10
        '
        'Precio_AjustadoTextBox
        '
        Me.Precio_AjustadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Precio_Ajustado", True))
        Me.Precio_AjustadoTextBox.Location = New System.Drawing.Point(192, 204)
        Me.Precio_AjustadoTextBox.Name = "Precio_AjustadoTextBox"
        Me.Precio_AjustadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Precio_AjustadoTextBox.TabIndex = 12
        '
        'TotalPartidaTextBox
        '
        Me.TotalPartidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "TotalPartida", True))
        Me.TotalPartidaTextBox.Location = New System.Drawing.Point(192, 230)
        Me.TotalPartidaTextBox.Name = "TotalPartidaTextBox"
        Me.TotalPartidaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPartidaTextBox.TabIndex = 14
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "Descuento", True))
        Me.DescuentoTextBox.Location = New System.Drawing.Point(192, 256)
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescuentoTextBox.TabIndex = 16
        '
        'PorcientoMontajeTextBox
        '
        Me.PorcientoMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoDetalleBindingSource, "PorcientoMontaje", True))
        Me.PorcientoMontajeTextBox.Location = New System.Drawing.Point(192, 282)
        Me.PorcientoMontajeTextBox.Name = "PorcientoMontajeTextBox"
        Me.PorcientoMontajeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PorcientoMontajeTextBox.TabIndex = 18
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(58, 320)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PresupuestoDetalleDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Presupuesto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio_Generado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio_Generado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio_Ajustado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio_Ajustado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TotalPartida"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TotalPartida"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PorcientoMontaje"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PorcientoMontaje"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'CmdAceptarCambios
        '
        Me.CmdAceptarCambios.Location = New System.Drawing.Point(373, 77)
        Me.CmdAceptarCambios.Name = "CmdAceptarCambios"
        Me.CmdAceptarCambios.Size = New System.Drawing.Size(107, 23)
        Me.CmdAceptarCambios.TabIndex = 20
        Me.CmdAceptarCambios.Text = "Aceptar Cambios"
        Me.CmdAceptarCambios.UseVisualStyleBackColor = True
        '
        'FrmMntajeYDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 560)
        Me.Controls.Add(Me.CmdAceptarCambios)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(ArticuloLabel)
        Me.Controls.Add(Me.ArticuloTextBox)
        Me.Controls.Add(PresupuestoLabel)
        Me.Controls.Add(Me.PresupuestoTextBox)
        Me.Controls.Add(IdDetalle_PresupuestoLabel)
        Me.Controls.Add(Me.IdDetalle_PresupuestoTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Precio_GeneradoLabel)
        Me.Controls.Add(Me.Precio_GeneradoTextBox)
        Me.Controls.Add(Precio_AjustadoLabel)
        Me.Controls.Add(Me.Precio_AjustadoTextBox)
        Me.Controls.Add(TotalPartidaLabel)
        Me.Controls.Add(Me.TotalPartidaTextBox)
        Me.Controls.Add(DescuentoLabel)
        Me.Controls.Add(Me.DescuentoTextBox)
        Me.Controls.Add(PorcientoMontajeLabel)
        Me.Controls.Add(Me.PorcientoMontajeTextBox)
        Me.Controls.Add(Me.PresupuestoDetalleBindingNavigator)
        Me.Name = "FrmMntajeYDescuento"
        Me.Text = "FrmMntajeYDescuento"
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PresupuestoDetalleBindingNavigator.ResumeLayout(False)
        Me.PresupuestoDetalleBindingNavigator.PerformLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PresupuestoDetalleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresupuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdDetalle_PresupuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_GeneradoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_AjustadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPartidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescuentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PorcientoMontajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresupuestoDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdAceptarCambios As System.Windows.Forms.Button
End Class
