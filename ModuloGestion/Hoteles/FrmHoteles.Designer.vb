<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHoteles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHoteles))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HotelesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.HotelesBindingSource = New System.Windows.Forms.BindingSource(Me.components)

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
        Me.HotelesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.HotelesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdificiosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HotelesTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.HotelesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.HotelesDataSetTableAdapters.TableAdapterManager()
        Me.EdificiosTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.EdificiosTableAdapter()
        Me.EdificiosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosDetalleTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.EdificiosDetalleTableAdapter()
        Me.EdificiosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelesDataSet = New ModuloGestion.HotelesDataSet()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabitacionesTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.HabitacionesTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.HotelesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HotelesBindingNavigator.SuspendLayout()
        CType(Me.HotelesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HotelesBindingNavigator
        '
        Me.HotelesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HotelesBindingNavigator.BindingSource = Me.HotelesBindingSource
        Me.HotelesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HotelesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HotelesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HotelesBindingNavigatorSaveItem})
        Me.HotelesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HotelesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HotelesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HotelesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HotelesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HotelesBindingNavigator.Name = "HotelesBindingNavigator"
        Me.HotelesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HotelesBindingNavigator.Size = New System.Drawing.Size(1130, 25)
        Me.HotelesBindingNavigator.TabIndex = 0
        Me.HotelesBindingNavigator.Text = "BindingNavigator1"
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
        'HotelesBindingSource
        '
        Me.HotelesBindingSource.DataMember = "Hoteles"
        Me.HotelesBindingSource.DataSource = Me.HotelesDataSet
        '
        'HotelesDataSet
        '
        Me.HotelesDataSet.DataSetName = "HotelesDataSet"
        Me.HotelesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'HotelesBindingNavigatorSaveItem
        '
        Me.HotelesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HotelesBindingNavigatorSaveItem.Image = CType(resources.GetObject("HotelesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HotelesBindingNavigatorSaveItem.Name = "HotelesBindingNavigatorSaveItem"
        Me.HotelesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HotelesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'HotelesDataGridView
        '
        Me.HotelesDataGridView.AutoGenerateColumns = False
        Me.HotelesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HotelesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.HotelesDataGridView.DataSource = Me.HotelesBindingSource
        Me.HotelesDataGridView.Location = New System.Drawing.Point(12, 47)
        Me.HotelesDataGridView.Name = "HotelesDataGridView"
        Me.HotelesDataGridView.Size = New System.Drawing.Size(465, 220)
        Me.HotelesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdHotel"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdHotel"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'EdificiosDataGridView
        '
        Me.EdificiosDataGridView.AutoGenerateColumns = False
        Me.EdificiosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EdificiosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EdificiosDataGridView.DataSource = Me.EdificiosBindingSource
        Me.EdificiosDataGridView.Location = New System.Drawing.Point(564, 47)
        Me.EdificiosDataGridView.Name = "EdificiosDataGridView"
        Me.EdificiosDataGridView.Size = New System.Drawing.Size(409, 220)
        Me.EdificiosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdEdificios"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdEdificios"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.HotelesDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nuevo Edificio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HotelesTableAdapter
        '
        Me.HotelesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EdificiosDetalleTableAdapter = Nothing
        Me.TableAdapterManager.EdificiosTableAdapter = Me.EdificiosTableAdapter
        Me.TableAdapterManager.HabitacionesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.HabitacionesTableAdapter = Nothing
        Me.TableAdapterManager.HotelesTableAdapter = Me.HotelesTableAdapter
        Me.TableAdapterManager.PlantasDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PlantasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.HotelesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
        '
        'EdificiosDetalleBindingSource
        '
        Me.EdificiosDetalleBindingSource.DataMember = "EdificiosDetalle"
        Me.EdificiosDetalleBindingSource.DataSource = Me.HotelesDataSet
        '
        'EdificiosDetalleTableAdapter
        '
        Me.EdificiosDetalleTableAdapter.ClearBeforeFill = True
        '
        'EdificiosDetalleDataGridView
        '
        Me.EdificiosDetalleDataGridView.AutoGenerateColumns = False
        Me.EdificiosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EdificiosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EdificiosDetalleDataGridView.DataSource = Me.EdificiosDetalleBindingSource
        Me.EdificiosDetalleDataGridView.Location = New System.Drawing.Point(12, 282)
        Me.EdificiosDetalleDataGridView.Name = "EdificiosDetalleDataGridView"
        Me.EdificiosDetalleDataGridView.Size = New System.Drawing.Size(465, 220)
        Me.EdificiosDetalleDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdEdificioDetalle"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdEdificioDetalle"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdHabitacionesTipo"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.HabitacionesBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id Habitaciones Tipo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "IdHabitacionesTipo"
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.HotelesDataSet
        '
        'HotelesDataSet
        '
        Me.HotelesDataSet.DataSetName = "HotelesDataSet"
        Me.HotelesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N0"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'HabitacionesTableAdapter
        '
        Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(996, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Habitaciones"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmHoteles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 545)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.EdificiosDetalleDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EdificiosDataGridView)
        Me.Controls.Add(Me.HotelesDataGridView)
        Me.Controls.Add(Me.HotelesBindingNavigator)
        Me.Name = "FrmHoteles"
        Me.Text = "FrmHoteles"
        CType(Me.HotelesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HotelesBindingNavigator.ResumeLayout(False)
        Me.HotelesBindingNavigator.PerformLayout()
        CType(Me.HotelesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HotelesDataSet As HotelesDataSet
    Friend WithEvents HotelesBindingSource As BindingSource
    Friend WithEvents HotelesTableAdapter As HotelesDataSetTableAdapters.HotelesTableAdapter
    Friend WithEvents TableAdapterManager As HotelesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HotelesBindingNavigator As BindingNavigator
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
    Friend WithEvents HotelesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents HotelesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents EdificiosTableAdapter As HotelesDataSetTableAdapters.EdificiosTableAdapter
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents EdificiosDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents EdificiosDetalleBindingSource As BindingSource
    Friend WithEvents EdificiosDetalleTableAdapter As HotelesDataSetTableAdapters.EdificiosDetalleTableAdapter
    Friend WithEvents EdificiosDetalleDataGridView As DataGridView

    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents HabitacionesTableAdapter As HotelesDataSetTableAdapters.HabitacionesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
