<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEstadoTrabajos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadoTrabajos))
        Me.EstadoTrabajosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EstadoTrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEstadoTrabajos = New ModuloGestion.DsEstadoTrabajos()
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
        Me.EstadoTrabajosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTrabajosTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.EstadoTrabajosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEstadoTrabajosTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.PresupuestoDetalleTableAdapter()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.PresupuestoTableAdapter()
        Me.ProyectosTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.ProyectosTableAdapter()
        Me.ArticulosTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.ArticulosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.EstadoTrabajosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstadoTrabajosBindingNavigator.SuspendLayout()
        CType(Me.EstadoTrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEstadoTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstadoTrabajosBindingNavigator
        '
        Me.EstadoTrabajosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstadoTrabajosBindingNavigator.BindingSource = Me.EstadoTrabajosBindingSource
        Me.EstadoTrabajosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstadoTrabajosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstadoTrabajosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EstadoTrabajosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EstadoTrabajosBindingNavigatorSaveItem})
        Me.EstadoTrabajosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstadoTrabajosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstadoTrabajosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstadoTrabajosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstadoTrabajosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstadoTrabajosBindingNavigator.Name = "EstadoTrabajosBindingNavigator"
        Me.EstadoTrabajosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstadoTrabajosBindingNavigator.Size = New System.Drawing.Size(1545, 27)
        Me.EstadoTrabajosBindingNavigator.TabIndex = 0
        Me.EstadoTrabajosBindingNavigator.Text = "BindingNavigator1"
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
        'EstadoTrabajosBindingSource
        '
        Me.EstadoTrabajosBindingSource.DataMember = "EstadoTrabajos"
        Me.EstadoTrabajosBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'DsEstadoTrabajos
        '
        Me.DsEstadoTrabajos.DataSetName = "DsEstadoTrabajos"
        Me.DsEstadoTrabajos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'EstadoTrabajosBindingNavigatorSaveItem
        '
        Me.EstadoTrabajosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstadoTrabajosBindingNavigatorSaveItem.Enabled = False
        Me.EstadoTrabajosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstadoTrabajosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstadoTrabajosBindingNavigatorSaveItem.Name = "EstadoTrabajosBindingNavigatorSaveItem"
        Me.EstadoTrabajosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.EstadoTrabajosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(465, 60)
        Me.PresupuestoDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.ReadOnly = True
        Me.PresupuestoDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(617, 271)
        Me.PresupuestoDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Descripcion_Presupuesto"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Descripcion_Presupuesto"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AllowUserToDeleteRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn102, Me.DataGridViewTextBoxColumn103})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(16, 60)
        Me.ProyectosDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.ReadOnly = True
        Me.ProyectosDataGridView.RowHeadersWidth = 51
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(400, 271)
        Me.ProyectosDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn102
        '
        Me.DataGridViewTextBoxColumn102.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn102.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn102.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
        Me.DataGridViewTextBoxColumn102.ReadOnly = True
        Me.DataGridViewTextBoxColumn102.Width = 125
        '
        'DataGridViewTextBoxColumn103
        '
        Me.DataGridViewTextBoxColumn103.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn103.DataPropertyName = "Nombre_Proyecto"
        Me.DataGridViewTextBoxColumn103.HeaderText = "Nombre_Proyecto"
        Me.DataGridViewTextBoxColumn103.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
        Me.DataGridViewTextBoxColumn103.ReadOnly = True
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Articulo, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(16, 338)
        Me.PresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(1440, 271)
        Me.PresupuestoDetalleDataGridView.TabIndex = 5
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'EstadoTrabajosTableAdapter
        '
        Me.EstadoTrabajosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEstadoTrabajosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1148, 112)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Articulo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'Articulo
        '
        Me.Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Articulo.DataPropertyName = "Articulo"
        Me.Articulo.DataSource = Me.ArticulosBindingSource
        Me.Articulo.DisplayMember = "Descripcion_articulo"
        Me.Articulo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Articulo.HeaderText = "Descripcion"
        Me.Articulo.MinimumWidth = 6
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Articulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Articulo.ValueMember = "IdArticulo"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "EnProduccion"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Produccion"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "EnPintura"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Pintura"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Enobra"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Obra"
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 125
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Instalado"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Instalado"
        Me.DataGridViewCheckBoxColumn4.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 125
        '
        'FrmEstadoTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 660)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Me.ProyectosDataGridView)
        Me.Controls.Add(Me.PresupuestoDataGridView)
        Me.Controls.Add(Me.EstadoTrabajosBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmEstadoTrabajos"
        Me.Text = "FrmEstadoTrabajos"
        CType(Me.EstadoTrabajosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstadoTrabajosBindingNavigator.ResumeLayout(False)
        Me.EstadoTrabajosBindingNavigator.PerformLayout()
        CType(Me.EstadoTrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEstadoTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsEstadoTrabajos As DsEstadoTrabajos
    Friend WithEvents EstadoTrabajosBindingSource As BindingSource
    Friend WithEvents EstadoTrabajosTableAdapter As DsEstadoTrabajosTableAdapters.EstadoTrabajosTableAdapter
    Friend WithEvents TableAdapterManager As DsEstadoTrabajosTableAdapters.TableAdapterManager
    Friend WithEvents EstadoTrabajosBindingNavigator As BindingNavigator
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
    Friend WithEvents EstadoTrabajosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PresupuestoTableAdapter As DsEstadoTrabajosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsEstadoTrabajosTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents PresupuestoDataGridView As DataGridView
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsEstadoTrabajosTableAdapters.ProyectosTableAdapter
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn102 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn103 As DataGridViewTextBoxColumn
    Friend WithEvents PresupuestoDetalleDataGridView As DataGridView
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsEstadoTrabajosTableAdapters.ArticulosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
End Class
