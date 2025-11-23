<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpEstadoEntregas
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
        Me.DsEstadoEntregas = New ModuloGestion.DsEstadoEntregas()
        Me.EstadoentregasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoentregasTableAdapter = New ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager()
        Me.ProyectosTableAdapter = New ModuloGestion.DsEstadoEntregasTableAdapters.ProyectosTableAdapter()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsEstadoEntregasTableAdapters.SubArticulosTableAdapter()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsEstadoEntregas
        '
        Me.DsEstadoEntregas.DataSetName = "DsEstadoEntregas"
        Me.DsEstadoEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoentregasBindingSource
        '
        Me.EstadoentregasBindingSource.DataMember = "Estadoentregas"
        Me.EstadoentregasBindingSource.DataSource = Me.DsEstadoEntregas
        '
        'EstadoentregasTableAdapter
        '
        Me.EstadoentregasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
     
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsEstadoEntregas
        '
        'SubArticulosBindingSource
        '
        Me.SubArticulosBindingSource.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource.DataSource = Me.DsEstadoEntregas
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(644, 351)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'ImpEstadoEntregas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 351)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "ImpEstadoEntregas"
        Me.Text = "Estado Entregas"
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsEstadoEntregas As ModuloGestion.DsEstadoEntregas
    Friend WithEvents EstadoentregasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoentregasTableAdapter As ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEstadoEntregasTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsEstadoEntregasTableAdapters.ProyectosTableAdapter
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsEstadoEntregasTableAdapters.SubArticulosTableAdapter
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
