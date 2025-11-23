<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RotConsumoArticulos
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
        Me.DsConsumoArticulosInforme = New ModuloGestion.DsConsumoArticulosInforme()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.PresupuestoDetalleTableAdapter()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.ArticulosTableAdapter()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.ProyectosTableAdapter()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.PresupuestoTableAdapter()
        Me.HerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerrajesTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.HerrajesTableAdapter()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.MaterilaesDetalleTableAdapter()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.MedidasCompraTableAdapter()
        Me.PinturaComponentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinturaComponentesTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.PinturaComponentesTableAdapter()
        Me.ConsumoMaterialArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoMaterialArticulosTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.ConsumoMaterialArticulosTableAdapter()
        Me.ConsumoPinturaArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumoPinturaArticuloTableAdapter = New ModuloGestion.DsConsumoArticulosInformeTableAdapters.ConsumoPinturaArticuloTableAdapter()
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter1 = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter1 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        CType(Me.DsConsumoArticulosInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoMaterialArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoPinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1048, 489)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'DsConsumoArticulosInforme
        '
        Me.DsConsumoArticulosInforme.DataSetName = "DsConsumoArticulosInforme"
        Me.DsConsumoArticulosInforme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleHerrajesBindingSource
        '
        Me.PresupuestoDetalleHerrajesBindingSource.DataMember = "PresupuestoDetalleHerrajes"
        Me.PresupuestoDetalleHerrajesBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'PresupuestoDetalleHerrajesTableAdapter
        '
        Me.PresupuestoDetalleHerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.HerrajesTableAdapter = Nothing
        Me.TableAdapterManager.MaterilaesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.MedidasCompraTableAdapter = Nothing
        Me.TableAdapterManager.PinturaComponentesTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoDetalleHerrajesTableAdapter = Me.PresupuestoDetalleHerrajesTableAdapter
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsConsumoArticulosInformeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'HerrajesBindingSource
        '
        Me.HerrajesBindingSource.DataMember = "Herrajes"
        Me.HerrajesBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'HerrajesTableAdapter
        '
        Me.HerrajesTableAdapter.ClearBeforeFill = True
        '
        'MaterilaesDetalleBindingSource
        '
        Me.MaterilaesDetalleBindingSource.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'PinturaComponentesBindingSource
        '
        Me.PinturaComponentesBindingSource.DataMember = "PinturaComponentes"
        Me.PinturaComponentesBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'PinturaComponentesTableAdapter
        '
        Me.PinturaComponentesTableAdapter.ClearBeforeFill = True
        '
        'ConsumoMaterialArticulosBindingSource
        '
        Me.ConsumoMaterialArticulosBindingSource.DataMember = "ConsumoMaterialArticulos"
        Me.ConsumoMaterialArticulosBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'ConsumoMaterialArticulosTableAdapter
        '
        Me.ConsumoMaterialArticulosTableAdapter.ClearBeforeFill = True
        '
        'ConsumoPinturaArticuloBindingSource
        '
        Me.ConsumoPinturaArticuloBindingSource.DataMember = "ConsumoPinturaArticulo"
        Me.ConsumoPinturaArticuloBindingSource.DataSource = Me.DsConsumoArticulosInforme
        '
        'ConsumoPinturaArticuloTableAdapter
        '
        Me.ConsumoPinturaArticuloTableAdapter.ClearBeforeFill = True
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "DsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource1
        '
        Me.ArticulosBindingSource1.DataMember = "Articulos"
        Me.ArticulosBindingSource1.DataSource = Me.DsArticulos
        '
        'ArticulosTableAdapter1
        '
        Me.ArticulosTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ArticulosTableAdapter = Me.ArticulosTableAdapter1
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestoDetalle
        '
        Me.DsPresupuestoDetalle.DataSetName = "DsPresupuestoDetalle"
        Me.DsPresupuestoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleBindingSource1
        '
        Me.PresupuestoDetalleBindingSource1.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource1.DataSource = Me.DsPresupuestoDetalle
        '
        'PresupuestoDetalleTableAdapter1
        '
        Me.PresupuestoDetalleTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter1
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RotConsumoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 489)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RotConsumoArticulos"
        Me.Text = "RotConsumoArticulos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsConsumoArticulosInforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoMaterialArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoPinturaArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DsConsumoArticulosInforme As ModuloGestion.DsConsumoArticulosInforme
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsConsumoArticulosInformeTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.ArticulosTableAdapter
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.ProyectosTableAdapter
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.PresupuestoTableAdapter
    Friend WithEvents HerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.HerrajesTableAdapter
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents PinturaComponentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaComponentesTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.PinturaComponentesTableAdapter
    Friend WithEvents ConsumoMaterialArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumoMaterialArticulosTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.ConsumoMaterialArticulosTableAdapter
    Friend WithEvents ConsumoPinturaArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumoPinturaArticuloTableAdapter As ModuloGestion.DsConsumoArticulosInformeTableAdapters.ConsumoPinturaArticuloTableAdapter
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter1 As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter1 As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
End Class
