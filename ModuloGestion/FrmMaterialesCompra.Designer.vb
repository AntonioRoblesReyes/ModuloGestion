<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaterialesCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterialesCompra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsUnionMaterialesNombre = New ModuloGestion.DsUnionMaterialesNombre()
        Me.UnionNombreMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnionNombreMaterialesTableAdapter = New ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsUnionMaterialesNombreTableAdapters.TableAdapterManager()
        Me.UnionNombreMaterialesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UnionNombreMaterialesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UnionNombreMaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionNombreMaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UnionNombreMaterialesBindingNavigator.SuspendLayout()
        CType(Me.UnionNombreMaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsUnionMaterialesNombre
        '
        Me.DsUnionMaterialesNombre.DataSetName = "DsUnionMaterialesNombre"
        Me.DsUnionMaterialesNombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnionNombreMaterialesBindingSource
        '
        Me.UnionNombreMaterialesBindingSource.DataMember = "UnionNombreMateriales"
        Me.UnionNombreMaterialesBindingSource.DataSource = Me.DsUnionMaterialesNombre
        '
        'UnionNombreMaterialesTableAdapter
        '
        Me.UnionNombreMaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsUnionMaterialesNombreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UnionNombreMaterialesBindingNavigator
        '
        Me.UnionNombreMaterialesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UnionNombreMaterialesBindingNavigator.BindingSource = Me.UnionNombreMaterialesBindingSource
        Me.UnionNombreMaterialesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UnionNombreMaterialesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UnionNombreMaterialesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UnionNombreMaterialesBindingNavigatorSaveItem})
        Me.UnionNombreMaterialesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UnionNombreMaterialesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UnionNombreMaterialesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UnionNombreMaterialesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UnionNombreMaterialesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UnionNombreMaterialesBindingNavigator.Name = "UnionNombreMaterialesBindingNavigator"
        Me.UnionNombreMaterialesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UnionNombreMaterialesBindingNavigator.Size = New System.Drawing.Size(644, 25)
        Me.UnionNombreMaterialesBindingNavigator.TabIndex = 0
        Me.UnionNombreMaterialesBindingNavigator.Text = "BindingNavigator1"
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
        'UnionNombreMaterialesBindingNavigatorSaveItem
        '
        Me.UnionNombreMaterialesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnionNombreMaterialesBindingNavigatorSaveItem.Enabled = False
        Me.UnionNombreMaterialesBindingNavigatorSaveItem.Image = CType(resources.GetObject("UnionNombreMaterialesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UnionNombreMaterialesBindingNavigatorSaveItem.Name = "UnionNombreMaterialesBindingNavigatorSaveItem"
        Me.UnionNombreMaterialesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UnionNombreMaterialesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'UnionNombreMaterialesDataGridView
        '
        Me.UnionNombreMaterialesDataGridView.AutoGenerateColumns = False
        Me.UnionNombreMaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnionNombreMaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.UnionNombreMaterialesDataGridView.DataSource = Me.UnionNombreMaterialesBindingSource
        Me.UnionNombreMaterialesDataGridView.Location = New System.Drawing.Point(26, 106)
        Me.UnionNombreMaterialesDataGridView.Name = "UnionNombreMaterialesDataGridView"
        Me.UnionNombreMaterialesDataGridView.Size = New System.Drawing.Size(592, 220)
        Me.UnionNombreMaterialesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Material"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PrecioMenor"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio Menor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PrecioMayor"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio Mayor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(44, 70)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(180, 20)
        Me.TxtBuscar.TabIndex = 2
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(289, 66)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAñadir.TabIndex = 3
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'FrmMaterialesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 350)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.UnionNombreMaterialesDataGridView)
        Me.Controls.Add(Me.UnionNombreMaterialesBindingNavigator)
        Me.Name = "FrmMaterialesCompra"
        Me.Text = "FrmMaterialesCompra"
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionNombreMaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UnionNombreMaterialesBindingNavigator.ResumeLayout(False)
        Me.UnionNombreMaterialesBindingNavigator.PerformLayout()
        CType(Me.UnionNombreMaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsUnionMaterialesNombre As ModuloGestion.DsUnionMaterialesNombre
    Friend WithEvents UnionNombreMaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionNombreMaterialesTableAdapter As ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsUnionMaterialesNombreTableAdapters.TableAdapterManager
    Friend WithEvents UnionNombreMaterialesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UnionNombreMaterialesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UnionNombreMaterialesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAñadir As System.Windows.Forms.Button
End Class
