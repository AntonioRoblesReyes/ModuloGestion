<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprasPorProveedor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.ComprasPorProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComprasPorProyecto = New ModuloGestion.DsComprasPorProyecto()
        Me.ComprasPorProyectoTableAdapter = New ModuloGestion.DsComprasPorProyectoTableAdapters.ComprasPorProyectoTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsComprasPorProyectoTableAdapters.TableAdapterManager()
        Me.DsUnionMaterialesNombre = New ModuloGestion.DsUnionMaterialesNombre()
        Me.DsUnionMaterialesNombreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnionNombreMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnionNombreMaterialesTableAdapter = New ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter()
        Me.ComprasProyectoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsComprasProyectoDetalle = New ModuloGestion.DsComprasProyectoDetalle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComprasProyectoDetalleTableAdapter = New ModuloGestion.DsComprasProyectoDetalleTableAdapters.ComprasProyectoDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsComprasProyectoDetalleTableAdapters.TableAdapterManager()
        Me.DsProveedores = New ModuloGestion.DsProveedores()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasPorProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComprasPorProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUnionMaterialesNombreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasProyectoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsComprasProyectoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'CompraMaterialesBindingSource
        '
        Me.CompraMaterialesBindingSource.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource.DataSource = Me.DsCompras
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '

        'ComprasPorProyectoBindingSource
        '
        Me.ComprasPorProyectoBindingSource.DataMember = "ComprasPorProyecto"
        Me.ComprasPorProyectoBindingSource.DataSource = Me.DsComprasPorProyecto
        '
        'DsComprasPorProyecto
        '
        Me.DsComprasPorProyecto.DataSetName = "DsComprasPorProyecto"
        Me.DsComprasPorProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasPorProyectoTableAdapter
        '
        Me.ComprasPorProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsComprasPorProyectoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '

        'DsUnionMaterialesNombre
        '
        Me.DsUnionMaterialesNombre.DataSetName = "DsUnionMaterialesNombre"
        Me.DsUnionMaterialesNombre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsUnionMaterialesNombreBindingSource
        '
        Me.DsUnionMaterialesNombreBindingSource.DataSource = Me.DsUnionMaterialesNombre
        Me.DsUnionMaterialesNombreBindingSource.Position = 0
        '
        'UnionNombreMaterialesBindingSource
        '
        Me.UnionNombreMaterialesBindingSource.DataMember = "UnionNombreMateriales"
        Me.UnionNombreMaterialesBindingSource.DataSource = Me.DsUnionMaterialesNombreBindingSource
        '
        'UnionNombreMaterialesTableAdapter
        '
        Me.UnionNombreMaterialesTableAdapter.ClearBeforeFill = True
        '
        'ComprasProyectoDetalleBindingSource
        '
        Me.ComprasProyectoDetalleBindingSource.DataMember = "ComprasProyectoDetalle"
        Me.ComprasProyectoDetalleBindingSource.DataSource = Me.DsComprasProyectoDetalle
        '
        'DsComprasProyectoDetalle
        '
        Me.DsComprasProyectoDetalle.DataSetName = "DsComprasProyectoDetalle"
        Me.DsComprasProyectoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(601, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Modificar Compra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComprasProyectoDetalleTableAdapter
        '
        Me.ComprasProyectoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsComprasProyectoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "DsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsProveedores
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(25, 53)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(347, 220)
        Me.ProveedoresDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RazonSocial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FrmComprasPorProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 477)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmComprasPorProveedor"
        Me.Text = "FrmComprasPorProveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasPorProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComprasPorProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUnionMaterialesNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUnionMaterialesNombreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionNombreMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasProyectoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsComprasProyectoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsCompras As ModuloGestion.DsCompras
    Friend WithEvents CompraMaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsComprasTableAdapters.TableAdapterManager
   
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsComprasPorProyecto As ModuloGestion.DsComprasPorProyecto
    Friend WithEvents ComprasPorProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasPorProyectoTableAdapter As ModuloGestion.DsComprasPorProyectoTableAdapters.ComprasPorProyectoTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsComprasPorProyectoTableAdapters.TableAdapterManager

    Friend WithEvents CompraMaterialesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsUnionMaterialesNombre As ModuloGestion.DsUnionMaterialesNombre
    Friend WithEvents DsUnionMaterialesNombreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionNombreMaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionNombreMaterialesTableAdapter As ModuloGestion.DsUnionMaterialesNombreTableAdapters.UnionNombreMaterialesTableAdapter
    Friend WithEvents DsComprasProyectoDetalle As ModuloGestion.DsComprasProyectoDetalle
    Friend WithEvents ComprasProyectoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasProyectoDetalleTableAdapter As ModuloGestion.DsComprasProyectoDetalleTableAdapters.ComprasProyectoDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsComprasProyectoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DsProveedores As ModuloGestion.DsProveedores
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
