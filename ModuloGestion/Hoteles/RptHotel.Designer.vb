<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptHotel
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
        Me.HotelesDataSet = New ModuloGestion.HotelesDataSet()
        Me.HotelesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelesTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.HotelesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.HotelesDataSetTableAdapters.TableAdapterManager()
        Me.ArticulosTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.ArticulosTableAdapter()
        Me.EdificiosDetalleTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.EdificiosDetalleTableAdapter()
        Me.EdificiosTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.EdificiosTableAdapter()
        Me.HabitacionesDetalleTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.HabitacionesDetalleTableAdapter()
        Me.HabitacionesTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.HabitacionesTableAdapter()
        Me.PlantasDetalleTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.PlantasDetalleTableAdapter()
        Me.PlantasTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.PlantasTableAdapter()
        Me.PlantasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlantasDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlantasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlantasDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(828, 497)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'HotelesDataSet
        '
        Me.HotelesDataSet.DataSetName = "HotelesDataSet"
        Me.HotelesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HotelesBindingSource
        '
        Me.HotelesBindingSource.DataMember = "Hoteles"
        Me.HotelesBindingSource.DataSource = Me.HotelesDataSet
        '
        'HotelesTableAdapter
        '
        Me.HotelesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticuloDetalleTableAdapter = Nothing
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EdificiosDetalleTableAdapter = Me.EdificiosDetalleTableAdapter
        Me.TableAdapterManager.EdificiosTableAdapter = Me.EdificiosTableAdapter
        Me.TableAdapterManager.HabitacionesDetalleTableAdapter = Me.HabitacionesDetalleTableAdapter
        Me.TableAdapterManager.HabitacionesTableAdapter = Me.HabitacionesTableAdapter
        Me.TableAdapterManager.HotelesTableAdapter = Me.HotelesTableAdapter
        Me.TableAdapterManager.PlantasDetalleTableAdapter = Me.PlantasDetalleTableAdapter
        Me.TableAdapterManager.PlantasTableAdapter = Me.PlantasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.HotelesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'EdificiosDetalleTableAdapter
        '
        Me.EdificiosDetalleTableAdapter.ClearBeforeFill = True
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
        '
        'HabitacionesDetalleTableAdapter
        '
        Me.HabitacionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'HabitacionesTableAdapter
        '
        Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'PlantasDetalleTableAdapter
        '
        Me.PlantasDetalleTableAdapter.ClearBeforeFill = True
        '
        'PlantasTableAdapter
        '
        Me.PlantasTableAdapter.ClearBeforeFill = True
        '
        'PlantasBindingSource
        '
        Me.PlantasBindingSource.DataMember = "Plantas"
        Me.PlantasBindingSource.DataSource = Me.HotelesDataSet
        '
        'PlantasDetalleBindingSource
        '
        Me.PlantasDetalleBindingSource.DataMember = "PlantasDetalle"
        Me.PlantasDetalleBindingSource.DataSource = Me.HotelesDataSet
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.HotelesDataSet
        '
        'EdificiosDetalleBindingSource
        '
        Me.EdificiosDetalleBindingSource.DataMember = "EdificiosDetalle"
        Me.EdificiosDetalleBindingSource.DataSource = Me.HotelesDataSet
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.HotelesDataSet
        '
        'HabitacionesDetalleBindingSource
        '
        Me.HabitacionesDetalleBindingSource.DataMember = "FK_HabitacionesDetalle_Habitaciones"
        Me.HabitacionesDetalleBindingSource.DataSource = Me.HabitacionesBindingSource
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.HotelesDataSet
        '
        'RptHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 497)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RptHotel"
        Me.Text = "RptHotel"
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlantasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlantasDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalReportViewer
    Friend WithEvents HotelesDataSet As HotelesDataSet
    Friend WithEvents HotelesBindingSource As BindingSource
    Friend WithEvents HotelesTableAdapter As HotelesDataSetTableAdapters.HotelesTableAdapter
    Friend WithEvents TableAdapterManager As HotelesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlantasTableAdapter As HotelesDataSetTableAdapters.PlantasTableAdapter
    Friend WithEvents PlantasBindingSource As BindingSource
    Friend WithEvents PlantasDetalleTableAdapter As HotelesDataSetTableAdapters.PlantasDetalleTableAdapter
    Friend WithEvents PlantasDetalleBindingSource As BindingSource
    Friend WithEvents EdificiosTableAdapter As HotelesDataSetTableAdapters.EdificiosTableAdapter
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents EdificiosDetalleTableAdapter As HotelesDataSetTableAdapters.EdificiosDetalleTableAdapter
    Friend WithEvents EdificiosDetalleBindingSource As BindingSource
    Friend WithEvents HabitacionesTableAdapter As HotelesDataSetTableAdapters.HabitacionesTableAdapter
    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents HabitacionesDetalleTableAdapter As HotelesDataSetTableAdapters.HabitacionesDetalleTableAdapter
    Friend WithEvents HabitacionesDetalleBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As HotelesDataSetTableAdapters.ArticulosTableAdapter
    Friend WithEvents ArticulosBindingSource As BindingSource
End Class
