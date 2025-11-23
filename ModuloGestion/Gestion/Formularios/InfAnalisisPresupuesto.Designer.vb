<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfAnalisisPresupuesto
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
        Me.AnalisisPresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAnalisisPresupuesto = New ModuloGestion.DsAnalisisPresupuesto()
        Me.AnalisisPresupuestoTableAdapter = New ModuloGestion.DsAnalisisPresupuestoTableAdapters.AnalisisPresupuestoTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsAnalisisPresupuestoTableAdapters.TableAdapterManager()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsAnalisisPresupuestoTableAdapters.PresupuestoTableAdapter()
        Me.ProyectosTableAdapter = New ModuloGestion.DsAnalisisPresupuestoTableAdapters.ProyectosTableAdapter()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AnalisisPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAnalisisPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(877, 461)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'AnalisisPresupuestoBindingSource
        '
        Me.AnalisisPresupuestoBindingSource.DataMember = "AnalisisPresupuesto"
        Me.AnalisisPresupuestoBindingSource.DataSource = Me.DsAnalisisPresupuesto
        '
        'DsAnalisisPresupuesto
        '
        Me.DsAnalisisPresupuesto.DataSetName = "DsAnalisisPresupuesto"
        Me.DsAnalisisPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnalisisPresupuestoTableAdapter
        '
        Me.AnalisisPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsAnalisisPresupuestoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsAnalisisPresupuesto
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsAnalisisPresupuesto
        '
        'InfAnalisisPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 461)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "InfAnalisisPresupuesto"
        Me.Text = "InfAnalisisPresupuesto"
        CType(Me.AnalisisPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAnalisisPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DsAnalisisPresupuesto As ModuloGestion.DsAnalisisPresupuesto
    Friend WithEvents AnalisisPresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnalisisPresupuestoTableAdapter As ModuloGestion.DsAnalisisPresupuestoTableAdapters.AnalisisPresupuestoTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsAnalisisPresupuestoTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsAnalisisPresupuestoTableAdapters.PresupuestoTableAdapter
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsAnalisisPresupuestoTableAdapters.ProyectosTableAdapter
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource

End Class
