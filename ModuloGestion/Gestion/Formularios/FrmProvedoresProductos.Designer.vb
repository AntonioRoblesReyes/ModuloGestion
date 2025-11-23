<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProvedoresProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProvedoresProductos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdUnico = New System.Windows.Forms.TextBox()
        Me.TxtIdProvedore = New System.Windows.Forms.TextBox()
        Me.TxtIdMaterial = New System.Windows.Forms.TextBox()
        Me.TxtDescricionSistema = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionProveedor = New System.Windows.Forms.TextBox()
        Me.UnionNombreMaterialesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UnionNombreMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsUnionMaterialesNombre = New ModuloGestion.DsUnionMaterialesNombre()
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
        Me.UnionNombreMaterialesTableAdapter = New ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsUnionMaterialesNombreTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtArticuloProvveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsProveedoresProducto = New ModuloGestion.DsProveedoresProducto()
        Me.ProveedoresProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresProductoTableAdapter = New ModuloGestion.DsProveedoresProductoTableAdapters.ProveedoresProductoTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProveedoresProductoTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.UnionNombreMaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UnionNombreMaterialesBindingNavigator.SuspendLayout()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedoresProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Unico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion Sistema"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codigo Material"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Codigo Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripcion Proveedor"
        '
        'TxtIdUnico
        '
        Me.TxtIdUnico.Enabled = False
        Me.TxtIdUnico.Location = New System.Drawing.Point(193, 43)
        Me.TxtIdUnico.Name = "TxtIdUnico"
        Me.TxtIdUnico.Size = New System.Drawing.Size(163, 20)
        Me.TxtIdUnico.TabIndex = 5
        '
        'TxtIdProvedore
        '
        Me.TxtIdProvedore.Enabled = False
        Me.TxtIdProvedore.Location = New System.Drawing.Point(193, 65)
        Me.TxtIdProvedore.Name = "TxtIdProvedore"
        Me.TxtIdProvedore.Size = New System.Drawing.Size(163, 20)
        Me.TxtIdProvedore.TabIndex = 6
        '
        'TxtIdMaterial
        '
        Me.TxtIdMaterial.Enabled = False
        Me.TxtIdMaterial.Location = New System.Drawing.Point(193, 190)
        Me.TxtIdMaterial.Name = "TxtIdMaterial"
        Me.TxtIdMaterial.Size = New System.Drawing.Size(163, 20)
        Me.TxtIdMaterial.TabIndex = 7
        Me.TxtIdMaterial.Visible = False
        '
        'TxtDescricionSistema
        '
        Me.TxtDescricionSistema.Enabled = False
        Me.TxtDescricionSistema.Location = New System.Drawing.Point(193, 216)
        Me.TxtDescricionSistema.Name = "TxtDescricionSistema"
        Me.TxtDescricionSistema.Size = New System.Drawing.Size(387, 20)
        Me.TxtDescricionSistema.TabIndex = 8
        Me.TxtDescricionSistema.Visible = False
        '
        'TxtDescripcionProveedor
        '
        Me.TxtDescripcionProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcionProveedor.Location = New System.Drawing.Point(193, 115)
        Me.TxtDescripcionProveedor.Name = "TxtDescripcionProveedor"
        Me.TxtDescripcionProveedor.Size = New System.Drawing.Size(387, 20)
        Me.TxtDescripcionProveedor.TabIndex = 2
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
        Me.UnionNombreMaterialesBindingNavigator.Size = New System.Drawing.Size(731, 25)
        Me.UnionNombreMaterialesBindingNavigator.TabIndex = 10
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
        'UnionNombreMaterialesBindingSource
        '
        Me.UnionNombreMaterialesBindingSource.DataMember = "UnionNombreMateriales"
        Me.UnionNombreMaterialesBindingSource.DataSource = Me.DsUnionMaterialesNombre
        '
        'DsUnionMaterialesNombre
        '
        Me.DsUnionMaterialesNombre.DataSetName = "DsUnionMaterialesNombre"
        Me.DsUnionMaterialesNombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtArticuloProvveedor
        '
        Me.TxtArticuloProvveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtArticuloProvveedor.Location = New System.Drawing.Point(193, 89)
        Me.TxtArticuloProvveedor.Name = "TxtArticuloProvveedor"
        Me.TxtArticuloProvveedor.Size = New System.Drawing.Size(163, 20)
        Me.TxtArticuloProvveedor.TabIndex = 1
        Me.TxtArticuloProvveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Codigo Articulo"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdDetalle"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DescripcionProveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DescripcionProveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdProductoProveedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdProductoProveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PrecioMayor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PrecioMayor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PrecioMenor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PrecioMenor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DsProveedoresProducto
        '
        Me.DsProveedoresProducto.DataSetName = "DsProveedoresProducto"
        Me.DsProveedoresProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresProductoBindingSource
        '
        Me.ProveedoresProductoBindingSource.DataMember = "ProveedoresProducto"
        Me.ProveedoresProductoBindingSource.DataSource = Me.DsProveedoresProducto
        '
        'ProveedoresProductoTableAdapter
        '
        Me.ProveedoresProductoTableAdapter.ClearBeforeFill = True
        '

        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.MedidasCompraBindingSource
        Me.ComboBox1.DisplayMember = "Descripcion_Medida"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(364, 142)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "Id_Medida"
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Medida Compra"
        '
        'FrmProvedoresProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 253)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TxtArticuloProvveedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnionNombreMaterialesBindingNavigator)
        Me.Controls.Add(Me.TxtDescripcionProveedor)
        Me.Controls.Add(Me.TxtDescricionSistema)
        Me.Controls.Add(Me.TxtIdMaterial)
        Me.Controls.Add(Me.TxtIdProvedore)
        Me.Controls.Add(Me.TxtIdUnico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProvedoresProductos"
        Me.Text = "FrmProvedoresProductos"
        CType(Me.UnionNombreMaterialesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UnionNombreMaterialesBindingNavigator.ResumeLayout(False)
        Me.UnionNombreMaterialesBindingNavigator.PerformLayout()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedoresProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtIdUnico As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdProvedore As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdMaterial As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescricionSistema As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcionProveedor As System.Windows.Forms.TextBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DsProveedoresProducto As ModuloGestion.DsProveedoresProducto
    Friend WithEvents ProveedoresProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresProductoTableAdapter As ModuloGestion.DsProveedoresProductoTableAdapters.ProveedoresProductoTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsProveedoresProductoTableAdapters.TableAdapterManager
    Friend WithEvents TxtArticuloProvveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn


    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsProveedoresProductoTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
