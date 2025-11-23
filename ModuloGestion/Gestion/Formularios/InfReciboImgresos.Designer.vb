<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfReciboImgresos
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
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.TableAdapterManager2 = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DsRecibosClientes = New ModuloGestion.DsRecibosClientes()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter1 = New ModuloGestion.DsRecibosClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsRecibosClientesTableAdapters.TableAdapterManager()
        Me.EmpresasTableAdapter1 = New ModuloGestion.DsRecibosClientesTableAdapters.EmpresasTableAdapter()
        Me.PagosClientesTableAdapter = New ModuloGestion.DsRecibosClientesTableAdapters.PagosClientesTableAdapter()
        Me.EmpresasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonedasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonedasTableAdapter = New ModuloGestion.DsRecibosClientesTableAdapters.MonedasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsRecibosClientesTableAdapters.PagosClientesDetalleTableAdapter()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRecibosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "DsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsClientes
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsEmpresas
        '
        Me.DsEmpresas.DataSetName = "DsEmpresas"
        Me.DsEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsEmpresas
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.PagosClientesTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(865, 492)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'DsRecibosClientes
        '
        Me.DsRecibosClientes.DataSetName = "DsRecibosClientes"
        Me.DsRecibosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.DsRecibosClientes
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.ClientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager3.EmpresasTableAdapter = Me.EmpresasTableAdapter1
        Me.TableAdapterManager3.MonedasTableAdapter = Nothing
        Me.TableAdapterManager3.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager3.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsRecibosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasTableAdapter1
        '
        Me.EmpresasTableAdapter1.ClearBeforeFill = True
        '
        'PagosClientesTableAdapter
        '
        Me.PagosClientesTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource1
        '
        Me.EmpresasBindingSource1.DataMember = "Empresas"
        Me.EmpresasBindingSource1.DataSource = Me.DsRecibosClientes
        '
        'PagosClientesBindingSource
        '
        Me.PagosClientesBindingSource.DataMember = "PagosClientes"
        Me.PagosClientesBindingSource.DataSource = Me.DsRecibosClientes
        '
        'MonedasBindingSource
        '
        Me.MonedasBindingSource.DataMember = "Monedas"
        Me.MonedasBindingSource.DataSource = Me.DsRecibosClientes
        '
        'MonedasTableAdapter
        '
        Me.MonedasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(605, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsRecibosClientes
        '
        'PagosClientesDetalleTableAdapter
        '
        Me.PagosClientesDetalleTableAdapter.ClearBeforeFill = True
        '
        'InfReciboImgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 492)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InfReciboImgresos"
        Me.Text = "InfReciboImgresos"
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRecibosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsClientes As ModuloGestion.DsClientes
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DsRecibosClientes As ModuloGestion.DsRecibosClientes
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter1 As ModuloGestion.DsRecibosClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsRecibosClientesTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasTableAdapter1 As ModuloGestion.DsRecibosClientesTableAdapters.EmpresasTableAdapter
    Friend WithEvents EmpresasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsRecibosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonedasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonedasTableAdapter As ModuloGestion.DsRecibosClientesTableAdapters.MonedasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsRecibosClientesTableAdapters.PagosClientesDetalleTableAdapter
End Class
