<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpCompras
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.CompraMaterialesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter1 = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter1 = New ModuloGestion.DsComprasTableAdapters.ProveedoresTableAdapter()
        Me.DsImprimirCompras = New ModuloGestion.DsImprimirCompras()
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsImprimirComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsImprimirComprasTableAdapters.TableAdapterManager()
        Me.CompraMaterialesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesDetalleTableAdapter = New ModuloGestion.DsImprimirComprasTableAdapters.CompraMaterialesDetalleTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ModuloGestion.DsImprimirComprasTableAdapters.EmpresasTableAdapter()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ModuloGestion.DsImprimirComprasTableAdapters.ProveedoresTableAdapter()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsImprimirComprasTableAdapters.MedidasCompraTableAdapter()
        Me.LblIdCompra = New System.Windows.Forms.Label()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsImprimirCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1299, 620)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelWidth = 267
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraMaterialesBindingSource1
        '
        Me.CompraMaterialesBindingSource1.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource1.DataSource = Me.DsCompras
        '
        'CompraMaterialesTableAdapter1
        '
        Me.CompraMaterialesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CompraMaterialesDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "Proveedores"
        Me.ProveedoresBindingSource1.DataSource = Me.DsCompras
        '
        'ProveedoresTableAdapter1
        '
        Me.ProveedoresTableAdapter1.ClearBeforeFill = True
        '
        'DsImprimirCompras
        '
        Me.DsImprimirCompras.DataSetName = "DsImprimirCompras"
        Me.DsImprimirCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraMaterialesBindingSource
        '
        Me.CompraMaterialesBindingSource.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource.DataSource = Me.DsImprimirCompras
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ProveedoresProductoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsImprimirComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompraMaterialesDetalleBindingSource
        '
        Me.CompraMaterialesDetalleBindingSource.DataMember = "CompraMaterialesDetalle"
        Me.CompraMaterialesDetalleBindingSource.DataSource = Me.DsImprimirCompras
        '
        'CompraMaterialesDetalleTableAdapter
        '
        Me.CompraMaterialesDetalleTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsImprimirCompras
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsImprimirCompras
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsImprimirCompras
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'LblIdCompra
        '
        Me.LblIdCompra.AutoSize = True
        Me.LblIdCompra.Location = New System.Drawing.Point(1038, 137)
        Me.LblIdCompra.Name = "LblIdCompra"
        Me.LblIdCompra.Size = New System.Drawing.Size(48, 16)
        Me.LblIdCompra.TabIndex = 1
        Me.LblIdCompra.Text = "Label1"
        Me.LblIdCompra.Visible = False
        '
        'ImpCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 620)
        Me.Controls.Add(Me.LblIdCompra)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ImpCompras"
        Me.Text = "ImpCompras"
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsImprimirCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsImprimirCompras As ModuloGestion.DsImprimirCompras
    Friend WithEvents CompraMaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As ModuloGestion.DsImprimirComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsImprimirComprasTableAdapters.TableAdapterManager
    Friend WithEvents CompraMaterialesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompraMaterialesDetalleTableAdapter As ModuloGestion.DsImprimirComprasTableAdapters.CompraMaterialesDetalleTableAdapter
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsImprimirComprasTableAdapters.EmpresasTableAdapter
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ModuloGestion.DsImprimirComprasTableAdapters.ProveedoresTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsImprimirComprasTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents CompraMaterialesBindingSource1 As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter1 As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager1 As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingSource1 As BindingSource
    Friend WithEvents ProveedoresTableAdapter1 As DsComprasTableAdapters.ProveedoresTableAdapter
    Friend WithEvents LblIdCompra As Label
End Class
