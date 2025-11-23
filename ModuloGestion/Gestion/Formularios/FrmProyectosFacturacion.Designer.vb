<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProyectosFacturacion
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
        Me.DsProyectosDetalle = New ModuloGestion.DsProyectosDetalle()
        Me.ProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosDetalleTableAdapter = New ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager()
        Me.ProyectosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DsFacturas = New ModuloGestion.DsFacturas()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.ComprobantesFiscalesTableAdapter = New ModuloGestion.DsFacturasTableAdapters.ComprobantesFiscalesTableAdapter()
        Me.ComprobantesFiscalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprobantesFiscalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsProyectosDetalle
        '
        Me.DsProyectosDetalle.DataSetName = "DsProyectosDetalle"
        Me.DsProyectosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosDetalleBindingSource
        '
        Me.ProyectosDetalleBindingSource.DataMember = "ProyectosDetalle"
        Me.ProyectosDetalleBindingSource.DataSource = Me.DsProyectosDetalle
        '
        'ProyectosDetalleTableAdapter
        '
        Me.ProyectosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProyectosDetalleTableAdapter = Me.ProyectosDetalleTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosDetalleDataGridView
        '
        Me.ProyectosDetalleDataGridView.AutoGenerateColumns = False
        Me.ProyectosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPresupuestoDataGridViewTextBoxColumn, Me.DescripcionPresupuestoDataGridViewTextBoxColumn})
        Me.ProyectosDetalleDataGridView.DataSource = Me.PresupuestoBindingSource
        Me.ProyectosDetalleDataGridView.Location = New System.Drawing.Point(12, 61)
        Me.ProyectosDetalleDataGridView.Name = "ProyectosDetalleDataGridView"
        Me.ProyectosDetalleDataGridView.Size = New System.Drawing.Size(362, 220)
        Me.ProyectosDetalleDataGridView.TabIndex = 1
        '
        'IdPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.HeaderText = "Id Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.Name = "IdPresupuestoDataGridViewTextBoxColumn"
        '
        'DescripcionPresupuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Presupuesto"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.Name = "DescripcionPresupuestoDataGridViewTextBoxColumn"
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar Proyecto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DsProyectos
        '
        Me.DsProyectos.DataSetName = "DsProyectos"
        Me.DsProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsProyectos
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"US$", "RD$"})
        Me.ComboBox1.Location = New System.Drawing.Point(501, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(65, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Moneda a facturar"
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'DsFacturas
        '
        Me.DsFacturas.DataSetName = "DsFacturas"
        Me.DsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsFacturas
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager2.ComprobantesFiscalesTableAdapter = Me.ComprobantesFiscalesTableAdapter
        Me.TableAdapterManager2.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager2.FacturaDetalleTableAdapter = Nothing
        Me.TableAdapterManager2.FacturaTableAdapter = Nothing
        Me.TableAdapterManager2.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsFacturasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComprobantesFiscalesTableAdapter
        '
        Me.ComprobantesFiscalesTableAdapter.ClearBeforeFill = True
        '
        'ComprobantesFiscalesBindingSource
        '
        Me.ComprobantesFiscalesBindingSource.DataMember = "ComprobantesFiscales"
        Me.ComprobantesFiscalesBindingSource.DataSource = Me.DsFacturas
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo  de Comprobante"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ComprobantesFiscalesBindingSource
        Me.ComboBox2.DisplayMember = "Descripcion"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(501, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox2.TabIndex = 6
        Me.ComboBox2.ValueMember = "IDCombrobante"
        '
        'FrmProyectosFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 392)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProyectosDetalleDataGridView)
        Me.Name = "FrmProyectosFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecto a Facturar"
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprobantesFiscalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsProyectosDetalle As ModuloGestion.DsProyectosDetalle
    Friend WithEvents ProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleTableAdapter As ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DsProyectos As ModuloGestion.DsProyectos
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DsFacturas As ModuloGestion.DsFacturas
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsFacturasTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsFacturasTableAdapters.TableAdapterManager
    Friend WithEvents ComprobantesFiscalesTableAdapter As ModuloGestion.DsFacturasTableAdapters.ComprobantesFiscalesTableAdapter
    Friend WithEvents ComprobantesFiscalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
