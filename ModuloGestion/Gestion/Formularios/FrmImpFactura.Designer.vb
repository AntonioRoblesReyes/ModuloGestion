<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpFactura
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
        Me.DsFacturas = New ModuloGestion.DsFacturas()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.EmpresasTableAdapter = New ModuloGestion.DsFacturasTableAdapters.EmpresasTableAdapter()
        Me.FacturaDetalleTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter()
        Me.FacturaTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter()
        Me.ProyectosTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ProyectosTableAdapter()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ComprobantesFiscalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprobantesFiscalesTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ComprobantesFiscalesTableAdapter()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprobantesFiscalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsFacturas
        '
        Me.DsFacturas.DataSetName = "DsFacturas"
        Me.DsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsFacturas
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ComprobantesFiscalesTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.FacturaDetalleTableAdapter = Me.FacturaDetalleTableAdapter
        Me.TableAdapterManager.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsFacturasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'FacturaDetalleTableAdapter
        '
        Me.FacturaDetalleTableAdapter.ClearBeforeFill = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DsFacturas
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsFacturas
        '
        'FacturaDetalleBindingSource
        '
        Me.FacturaDetalleBindingSource.DataMember = "FacturaDetalle"
        Me.FacturaDetalleBindingSource.DataSource = Me.DsFacturas
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsFacturas
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(637, 440)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'ComprobantesFiscalesBindingSource
        '
        Me.ComprobantesFiscalesBindingSource.DataMember = "ComprobantesFiscales"
        Me.ComprobantesFiscalesBindingSource.DataSource = Me.DsFacturas
        '
        'ComprobantesFiscalesTableAdapter
        '
        Me.ComprobantesFiscalesTableAdapter.ClearBeforeFill = True
        '
        'FrmImpFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 440)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmImpFactura"
        Me.Text = "FrmImpFactura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprobantesFiscalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsFacturas As ModuloGestion.DsFacturas
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsFacturasTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsFacturasTableAdapters.TableAdapterManager
    Friend WithEvents FacturaTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsFacturasTableAdapters.EmpresasTableAdapter
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaDetalleTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaDetalleTableAdapter
    Friend WithEvents FacturaDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsFacturasTableAdapters.ProyectosTableAdapter
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComprobantesFiscalesBindingSource As BindingSource
    Friend WithEvents ComprobantesFiscalesTableAdapter As DsFacturasTableAdapters.ComprobantesFiscalesTableAdapter
End Class
