<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfConsumoPresupuestos
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
        Me.EncabezadoConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEcabezadoConsumos = New ModuloGestion.DsEcabezadoConsumos()
        Me.lblIdPresupuesto = New System.Windows.Forms.Label()
        Me.EncabezadoConsumoTableAdapter = New ModuloGestion.DsEcabezadoConsumosTableAdapters.EncabezadoConsumoTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEcabezadoConsumosTableAdapters.TableAdapterManager()
        Me.ConsumosTotalesPresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsumosTotalesPresupuestoTableAdapter = New ModuloGestion.DsEcabezadoConsumosTableAdapters.ConsumosTotalesPresupuestoTableAdapter()
        CType(Me.EncabezadoConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEcabezadoConsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumosTotalesPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(963, 429)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'EncabezadoConsumoBindingSource
        '
        Me.EncabezadoConsumoBindingSource.DataMember = "EncabezadoConsumo"
        Me.EncabezadoConsumoBindingSource.DataSource = Me.DsEcabezadoConsumos
        '
        'DsEcabezadoConsumos
        '
        Me.DsEcabezadoConsumos.DataSetName = "DsEcabezadoConsumos"
        Me.DsEcabezadoConsumos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblIdPresupuesto
        '
        Me.lblIdPresupuesto.AutoSize = True
        Me.lblIdPresupuesto.Location = New System.Drawing.Point(644, 58)
        Me.lblIdPresupuesto.Name = "lblIdPresupuesto"
        Me.lblIdPresupuesto.Size = New System.Drawing.Size(0, 13)
        Me.lblIdPresupuesto.TabIndex = 2
        Me.lblIdPresupuesto.Visible = False
        '
        'EncabezadoConsumoTableAdapter
        '
        Me.EncabezadoConsumoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEcabezadoConsumosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsumosTotalesPresupuestoBindingSource
        '
        Me.ConsumosTotalesPresupuestoBindingSource.DataMember = "ConsumosTotalesPresupuesto"
        Me.ConsumosTotalesPresupuestoBindingSource.DataSource = Me.DsEcabezadoConsumos
        '
        'ConsumosTotalesPresupuestoTableAdapter
        '
        Me.ConsumosTotalesPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'InfConsumoPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 429)
        Me.Controls.Add(Me.lblIdPresupuesto)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "InfConsumoPresupuestos"
        Me.Text = "InfConsumoPresupuestos"
        CType(Me.EncabezadoConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEcabezadoConsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumosTotalesPresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DsEcabezadoConsumos As ModuloGestion.DsEcabezadoConsumos
    Friend WithEvents EncabezadoConsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncabezadoConsumoTableAdapter As ModuloGestion.DsEcabezadoConsumosTableAdapters.EncabezadoConsumoTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEcabezadoConsumosTableAdapters.TableAdapterManager
    Friend WithEvents lblIdPresupuesto As System.Windows.Forms.Label
    Friend WithEvents ConsumosTotalesPresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsumosTotalesPresupuestoTableAdapter As ModuloGestion.DsEcabezadoConsumosTableAdapters.ConsumosTotalesPresupuestoTableAdapter


End Class
