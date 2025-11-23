<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImpReciboNomina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados = New ModuloGestion.DsEmpleados()
        Me.EmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager()
        Me.HorariosEmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.HorariosEmpleadosTableAdapter()
        Me.NominasDetalleTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasDetalleTableAdapter()
        Me.NominasDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorariosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter()
        Me.AvanceEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvanceEmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.AvanceEmpleadosTableAdapter()
        Me.TSSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSSTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.TSSTableAdapter()
        Me.GanadoPorAñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GanadoPorAñoTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.GanadoPorAñoTableAdapter()
        Me.PagasExtrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagasExtrasTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.PagasExtrasTableAdapter()
        Me.LblAño = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.Lblincio = New System.Windows.Forms.Label()
        Me.LblFin = New System.Windows.Forms.Label()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvanceEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GanadoPorAñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagasExtrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1072, 527)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(332, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "DsEmpleados"
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvanceEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.AvnceEmpleadosPagosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalendarioTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaPuestoTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.HorariosEmpleadosTableAdapter = Me.HorariosEmpleadosTableAdapter
        Me.TableAdapterManager.NominasDetalleTableAdapter = Me.NominasDetalleTableAdapter
        Me.TableAdapterManager.NominasTableAdapter = Nothing
        Me.TableAdapterManager.PagasExtrasTableAdapter = Nothing
        Me.TableAdapterManager.RentaTableAdapter = Nothing
        Me.TableAdapterManager.SeguroSocialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HorariosEmpleadosTableAdapter
        '
        Me.HorariosEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'NominasDetalleTableAdapter
        '
        Me.NominasDetalleTableAdapter.ClearBeforeFill = True
        '
        'NominasDetalleBindingSource
        '
        Me.NominasDetalleBindingSource.DataMember = "NominasDetalle"
        Me.NominasDetalleBindingSource.DataSource = Me.DsEmpleados
        '
        'HorariosEmpleadosBindingSource
        '
        Me.HorariosEmpleadosBindingSource.DataMember = "HorariosEmpleados"
        Me.HorariosEmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'NominasBindingSource
        '
        Me.NominasBindingSource.DataMember = "Nominas"
        Me.NominasBindingSource.DataSource = Me.DsEmpleados
        '
        'NominasTableAdapter
        '
        Me.NominasTableAdapter.ClearBeforeFill = True
        '
        'AvanceEmpleadosBindingSource
        '
        Me.AvanceEmpleadosBindingSource.DataMember = "AvanceEmpleados"
        Me.AvanceEmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'AvanceEmpleadosTableAdapter
        '
        Me.AvanceEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TSSBindingSource
        '
        Me.TSSBindingSource.DataMember = "TSS"
        Me.TSSBindingSource.DataSource = Me.DsEmpleados
        '
        'TSSTableAdapter
        '
        Me.TSSTableAdapter.ClearBeforeFill = True
        '
        'GanadoPorAñoBindingSource
        '
        Me.GanadoPorAñoBindingSource.DataMember = "GanadoPorAño"
        Me.GanadoPorAñoBindingSource.DataSource = Me.DsEmpleados
        '
        'GanadoPorAñoTableAdapter
        '
        Me.GanadoPorAñoTableAdapter.ClearBeforeFill = True
        '
        'PagasExtrasBindingSource
        '
        Me.PagasExtrasBindingSource.DataMember = "PagasExtras"
        Me.PagasExtrasBindingSource.DataSource = Me.DsEmpleados
        '
        'PagasExtrasTableAdapter
        '
        Me.PagasExtrasTableAdapter.ClearBeforeFill = True
        '
        'LblAño
        '
        Me.LblAño.AutoSize = True
        Me.LblAño.Location = New System.Drawing.Point(773, 124)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(39, 13)
        Me.LblAño.TabIndex = 2
        Me.LblAño.Text = "Label2"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(773, 80)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(39, 13)
        Me.LblTipo.TabIndex = 3
        Me.LblTipo.Text = "Label3"
        '
        'Lblincio
        '
        Me.Lblincio.AutoSize = True
        Me.Lblincio.Location = New System.Drawing.Point(888, 179)
        Me.Lblincio.Name = "Lblincio"
        Me.Lblincio.Size = New System.Drawing.Size(32, 13)
        Me.Lblincio.TabIndex = 4
        Me.Lblincio.Text = "Inicio"
        '
        'LblFin
        '
        Me.LblFin.AutoSize = True
        Me.LblFin.Location = New System.Drawing.Point(899, 242)
        Me.LblFin.Name = "LblFin"
        Me.LblFin.Size = New System.Drawing.Size(21, 13)
        Me.LblFin.TabIndex = 5
        Me.LblFin.Text = "Fin"
        '
        'ImpReciboNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 527)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblAño)
        Me.Controls.Add(Me.Lblincio)
        Me.Controls.Add(Me.LblFin)
        Me.Name = "ImpReciboNomina"
        Me.Text = "ImpReciboNomina"
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvanceEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GanadoPorAñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagasExtrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DsEmpleados As ModuloGestion.DsEmpleados
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager
    Friend WithEvents NominasDetalleTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.NominasDetalleTableAdapter
    Friend WithEvents NominasDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HorariosEmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.HorariosEmpleadosTableAdapter
    Friend WithEvents HorariosEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter
    Friend WithEvents AvanceEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvanceEmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.AvanceEmpleadosTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TSSBindingSource As BindingSource
    Friend WithEvents TSSTableAdapter As DsEmpleadosTableAdapters.TSSTableAdapter
    Friend WithEvents GanadoPorAñoBindingSource As BindingSource
    Friend WithEvents GanadoPorAñoTableAdapter As DsEmpleadosTableAdapters.GanadoPorAñoTableAdapter
    Friend WithEvents PagasExtrasBindingSource As BindingSource
    Friend WithEvents PagasExtrasTableAdapter As DsEmpleadosTableAdapters.PagasExtrasTableAdapter
    Friend WithEvents LblAño As Label
    Friend WithEvents LblTipo As Label
    Friend WithEvents Lblincio As Label
    Friend WithEvents LblFin As Label
End Class
