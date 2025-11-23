<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpEstadoTrabajos
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
        Me.DsEstadoTrabajos = New ModuloGestion.DsEstadoTrabajos()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEstadoTrabajosTableAdapters.TableAdapterManager()
        Me.EstadoTrabajosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTrabajosTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.EstadoTrabajosTableAdapter()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.PresupuestoTableAdapter()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.PresupuestoDetalleTableAdapter()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsEstadoTrabajosTableAdapters.ProyectosTableAdapter()
        CType(Me.DsEstadoTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoTrabajosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 509)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'DsEstadoTrabajos
        '
        Me.DsEstadoTrabajos.DataSetName = "DsEstadoTrabajos"
        Me.DsEstadoTrabajos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEstadoTrabajosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EstadoTrabajosBindingSource
        '
        Me.EstadoTrabajosBindingSource.DataMember = "EstadoTrabajos"
        Me.EstadoTrabajosBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'EstadoTrabajosTableAdapter
        '
        Me.EstadoTrabajosTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsEstadoTrabajos
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'ImpEstadoTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 509)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "ImpEstadoTrabajos"
        Me.Text = "ImpEstadoTrabajos"
        CType(Me.DsEstadoTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoTrabajosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalReportViewer
    Friend WithEvents DsEstadoTrabajos As DsEstadoTrabajos
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsEstadoTrabajosTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager As DsEstadoTrabajosTableAdapters.TableAdapterManager
    Friend WithEvents EstadoTrabajosBindingSource As BindingSource
    Friend WithEvents EstadoTrabajosTableAdapter As DsEstadoTrabajosTableAdapters.EstadoTrabajosTableAdapter
    Friend WithEvents PresupuestoTableAdapter As DsEstadoTrabajosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsEstadoTrabajosTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsEstadoTrabajosTableAdapters.ProyectosTableAdapter
    Friend WithEvents ProyectosBindingSource As BindingSource
End Class
