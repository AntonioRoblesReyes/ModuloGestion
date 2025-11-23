<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoPago
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
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.DsPagosClientesDetalle = New ModuloGestion.DsPagosClientesDetalle()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager()
        Me.DsEmpresas1 = New ModuloGestion.DsEmpresas()
        Me.EmpresasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter1 = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesBindingSource1
        '
        Me.PagosClientesBindingSource1.DataMember = "PagosClientes"
        Me.PagosClientesBindingSource1.DataSource = Me.DsPagosClientes
        '
        'PagosClientesTableAdapter
        '
        Me.PagosClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPagosClientesDetalle
        '
        Me.DsPagosClientesDetalle.DataSetName = "DsPagosClientesDetalle"
        Me.DsPagosClientesDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsPagosClientesDetalle
        '
        'PagosClientesDetalleTableAdapter
        '
        Me.PagosClientesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PagosClientesDetalleTableAdapter = Me.PagosClientesDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsEmpresas1
        '
        Me.DsEmpresas1.DataSetName = "DsEmpresas"
        Me.DsEmpresas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource1
        '
        Me.EmpresasBindingSource1.DataMember = "Empresas"
        Me.EmpresasBindingSource1.DataSource = Me.DsEmpresas1
        '
        'EmpresasTableAdapter1
        '
        Me.EmpresasTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.EmpresasTableAdapter = Me.EmpresasTableAdapter1
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmNuevoPago
        '
        Me.ClientSize = New System.Drawing.Size(818, 342)
        Me.Name = "FrmNuevoPago"
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
   
    Friend WithEvents TxtIdCobro As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdFiscal As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents DsPagosClientesDetalle As ModuloGestion.DsPagosClientesDetalle
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsEmpresas1 As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter1 As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager
End Class
