<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirNotaEntrega
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
        Me.DsImrpimirNotasEntregas = New ModuloGestion.DsImrpimirNotasEntregas()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.TableAdapterManager()
        Me.ConductoresTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ConductoresTableAdapter()
        Me.EmpresasTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.EmpresasTableAdapter()
        Me.EmpresasTransporteTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.EmpresasTransporteTableAdapter()
        Me.ProyectosTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ProyectosTableAdapter()
        Me.VehiculosTransporteTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.VehiculosTransporteTableAdapter()
        Me.ConductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleEntregaImpresionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleEntregaImpresionTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.DetalleEntregaImpresionTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculosTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnionSubarticulosHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnionSubarticulosHerrajesTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.UnionSubarticulosHerrajesTableAdapter()
        Me.ConsultaNotasEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaNotasEntregaTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ConsultaNotasEntregaTableAdapter()
        Me.NotasEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasEntregaTableAdapter = New ModuloGestion.DsImrpimirNotasEntregasTableAdapters.NotasEntregaTableAdapter()
        CType(Me.DsImrpimirNotasEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleEntregaImpresionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionSubarticulosHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaNotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1107, 586)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'DsImrpimirNotasEntregas
        '
        Me.DsImrpimirNotasEntregas.DataSetName = "DsImrpimirNotasEntregas"
        Me.DsImrpimirNotasEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ConductoresTableAdapter = Me.ConductoresTableAdapter
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.EmpresasTransporteTableAdapter = Me.EmpresasTransporteTableAdapter
        Me.TableAdapterManager.NotasEntregaTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsImrpimirNotasEntregasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTransporteTableAdapter = Me.VehiculosTransporteTableAdapter
        '
        'ConductoresTableAdapter
        '
        Me.ConductoresTableAdapter.ClearBeforeFill = True
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'EmpresasTransporteTableAdapter
        '
        Me.EmpresasTransporteTableAdapter.ClearBeforeFill = True
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'VehiculosTransporteTableAdapter
        '
        Me.VehiculosTransporteTableAdapter.ClearBeforeFill = True
        '
        'ConductoresBindingSource
        '
        Me.ConductoresBindingSource.DataMember = "Conductores"
        Me.ConductoresBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'DetalleEntregaImpresionBindingSource
        '
        Me.DetalleEntregaImpresionBindingSource.DataMember = "DetalleEntregaImpresion"
        Me.DetalleEntregaImpresionBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'DetalleEntregaImpresionTableAdapter
        '
        Me.DetalleEntregaImpresionTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'EmpresasTransporteBindingSource
        '
        Me.EmpresasTransporteBindingSource.DataMember = "EmpresasTransporte"
        Me.EmpresasTransporteBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'VehiculosTransporteBindingSource
        '
        Me.VehiculosTransporteBindingSource.DataMember = "VehiculosTransporte"
        Me.VehiculosTransporteBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'UnionSubarticulosHerrajesBindingSource
        '
        Me.UnionSubarticulosHerrajesBindingSource.DataMember = "UnionSubarticulosHerrajes"
        Me.UnionSubarticulosHerrajesBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'UnionSubarticulosHerrajesTableAdapter
        '
        Me.UnionSubarticulosHerrajesTableAdapter.ClearBeforeFill = True
        '
        'ConsultaNotasEntregaBindingSource
        '
        Me.ConsultaNotasEntregaBindingSource.DataMember = "ConsultaNotasEntrega"
        Me.ConsultaNotasEntregaBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'ConsultaNotasEntregaTableAdapter
        '
        Me.ConsultaNotasEntregaTableAdapter.ClearBeforeFill = True
        '
        'NotasEntregaBindingSource
        '
        Me.NotasEntregaBindingSource.DataMember = "NotasEntrega"
        Me.NotasEntregaBindingSource.DataSource = Me.DsImrpimirNotasEntregas
        '
        'NotasEntregaTableAdapter
        '
        Me.NotasEntregaTableAdapter.ClearBeforeFill = True
        '
        'ImprimirNotaEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 586)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "ImprimirNotaEntrega"
        Me.Text = "ImprimirNotaEntrega"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsImrpimirNotasEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleEntregaImpresionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionSubarticulosHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaNotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsImrpimirNotasEntregas As ModuloGestion.DsImrpimirNotasEntregas
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.TableAdapterManager
    Friend WithEvents ConductoresTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ConductoresTableAdapter
    Friend WithEvents ConductoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetalleEntregaImpresionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetalleEntregaImpresionTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.DetalleEntregaImpresionTableAdapter
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.EmpresasTableAdapter
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTransporteTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.EmpresasTransporteTableAdapter
    Friend WithEvents EmpresasTransporteBindingSource As System.Windows.Forms.BindingSource
   
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ProyectosTableAdapter
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents VehiculosTransporteTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.VehiculosTransporteTableAdapter
    Friend WithEvents VehiculosTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

    Friend WithEvents UnionSubarticulosHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionSubarticulosHerrajesTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.UnionSubarticulosHerrajesTableAdapter
    Friend WithEvents ConsultaNotasEntregaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultaNotasEntregaTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.ConsultaNotasEntregaTableAdapter
    Friend WithEvents NotasEntregaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaTableAdapter As ModuloGestion.DsImrpimirNotasEntregasTableAdapters.NotasEntregaTableAdapter
    


End Class
