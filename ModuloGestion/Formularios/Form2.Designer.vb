<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim FacturaProveedorLabel1 As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Fecha_CompraLabel As System.Windows.Forms.Label
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim PorcientoImpuestoLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim TasaLabel As System.Windows.Forms.Label
        Dim Id_ProveedorLabel As System.Windows.Forms.Label
        Dim Id_CompraLabel As System.Windows.Forms.Label
        Me.FacturaProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.PorcientoImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Id_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.LblProveedor = New System.Windows.Forms.Label()
        FacturaProveedorLabel1 = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Fecha_CompraLabel = New System.Windows.Forms.Label()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        PorcientoImpuestoLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        TasaLabel = New System.Windows.Forms.Label()
        Id_ProveedorLabel = New System.Windows.Forms.Label()
        Id_CompraLabel = New System.Windows.Forms.Label()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaProveedorLabel1
        '
        FacturaProveedorLabel1.AutoSize = True
        FacturaProveedorLabel1.Location = New System.Drawing.Point(780, 34)
        FacturaProveedorLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FacturaProveedorLabel1.Name = "FacturaProveedorLabel1"
        FacturaProveedorLabel1.Size = New System.Drawing.Size(122, 16)
        FacturaProveedorLabel1.TabIndex = 109
        FacturaProveedorLabel1.Text = "Factura Proveedor:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(536, 65)
        ObservacionesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(102, 16)
        ObservacionesLabel.TabIndex = 106
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(376, 34)
        Fecha_CompraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(99, 16)
        Fecha_CompraLabel.TabIndex = 104
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Location = New System.Drawing.Point(196, 132)
        Id_EmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(79, 16)
        Id_EmpresaLabel.TabIndex = 101
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'PorcientoImpuestoLabel
        '
        PorcientoImpuestoLabel.AutoSize = True
        PorcientoImpuestoLabel.Location = New System.Drawing.Point(28, 96)
        PorcientoImpuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PorcientoImpuestoLabel.Name = "PorcientoImpuestoLabel"
        PorcientoImpuestoLabel.Size = New System.Drawing.Size(65, 16)
        PorcientoImpuestoLabel.TabIndex = 100
        PorcientoImpuestoLabel.Text = "Impuesto:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(209, 100)
        MonedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(60, 16)
        MonedaLabel.TabIndex = 98
        MonedaLabel.Text = "Moneda:"
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Location = New System.Drawing.Point(16, 132)
        TasaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(92, 16)
        TasaLabel.TabIndex = 96
        TasaLabel.Text = "Tasa Cambio:"
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(16, 65)
        Id_ProveedorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(88, 16)
        Id_ProveedorLabel.TabIndex = 94
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'Id_CompraLabel
        '
        Id_CompraLabel.AutoSize = True
        Id_CompraLabel.Location = New System.Drawing.Point(33, 33)
        Id_CompraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_CompraLabel.Name = "Id_CompraLabel"
        Id_CompraLabel.Size = New System.Drawing.Size(72, 16)
        Id_CompraLabel.TabIndex = 92
        Id_CompraLabel.Text = "Id Compra:"
        '
        'FacturaProveedorTextBox
        '
        Me.FacturaProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "FacturaProveedor", True))
        Me.FacturaProveedorTextBox.Location = New System.Drawing.Point(919, 31)
        Me.FacturaProveedorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FacturaProveedorTextBox.Name = "FacturaProveedorTextBox"
        Me.FacturaProveedorTextBox.Size = New System.Drawing.Size(132, 22)
        Me.FacturaProveedorTextBox.TabIndex = 110
        '
        'CompraMaterialesBindingSource
        '
        Me.CompraMaterialesBindingSource.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource.DataSource = Me.DsCompras
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 171)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Label1"
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(652, 62)
        Me.ObservacionesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(359, 181)
        Me.ObservacionesTextBox.TabIndex = 107
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CompraMaterialesBindingSource, "Fecha_Compra", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(485, 33)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 22)
        Me.DateTimePicker1.TabIndex = 105
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(288, 128)
        Me.Id_EmpresaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(49, 22)
        Me.Id_EmpresaTextBox.TabIndex = 103
        '
        'PorcientoImpuestoTextBox
        '
        Me.PorcientoImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "PorcientoImpuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.PorcientoImpuestoTextBox.Location = New System.Drawing.Point(119, 96)
        Me.PorcientoImpuestoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PorcientoImpuestoTextBox.Name = "PorcientoImpuestoTextBox"
        Me.PorcientoImpuestoTextBox.Size = New System.Drawing.Size(64, 22)
        Me.PorcientoImpuestoTextBox.TabIndex = 102
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Moneda", True))
        Me.MonedaTextBox.Location = New System.Drawing.Point(283, 96)
        Me.MonedaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(64, 22)
        Me.MonedaTextBox.TabIndex = 99
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Tasa", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TasaTextBox.Location = New System.Drawing.Point(119, 128)
        Me.TasaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(64, 22)
        Me.TasaTextBox.TabIndex = 97
        '
        'Id_ProveedorTextBox
        '
        Me.Id_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Id_Proveedor", True))
        Me.Id_ProveedorTextBox.Enabled = False
        Me.Id_ProveedorTextBox.Location = New System.Drawing.Point(119, 62)
        Me.Id_ProveedorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_ProveedorTextBox.Name = "Id_ProveedorTextBox"
        Me.Id_ProveedorTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_ProveedorTextBox.TabIndex = 95
        '
        'Id_CompraTextBox
        '
        Me.Id_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompraMaterialesBindingSource, "Id_Compra", True))
        Me.Id_CompraTextBox.Enabled = False
        Me.Id_CompraTextBox.Location = New System.Drawing.Point(119, 30)
        Me.Id_CompraTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_CompraTextBox.Name = "Id_CompraTextBox"
        Me.Id_CompraTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_CompraTextBox.TabIndex = 93
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '

        'LblProyecto
        '
        Me.LblProyecto.AutoSize = True
        Me.LblProyecto.Location = New System.Drawing.Point(55, 255)
        Me.LblProyecto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(79, 16)
        Me.LblProyecto.TabIndex = 113
        Me.LblProyecto.Text = "LblProyecto"
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.AutoSize = True
        Me.LblPresupuesto.Location = New System.Drawing.Point(55, 228)
        Me.LblPresupuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(101, 16)
        Me.LblPresupuesto.TabIndex = 112
        Me.LblPresupuesto.Text = "LblPresupuesto"
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(55, 198)
        Me.LblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(89, 16)
        Me.LblProveedor.TabIndex = 111
        Me.LblProveedor.Text = "LblProveedor"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 622)
        Me.Controls.Add(Me.LblProyecto)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.LblProveedor)
        Me.Controls.Add(FacturaProveedorLabel1)
        Me.Controls.Add(Me.FacturaProveedorTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Fecha_CompraLabel)
        Me.Controls.Add(Id_EmpresaLabel)
        Me.Controls.Add(Me.Id_EmpresaTextBox)
        Me.Controls.Add(PorcientoImpuestoLabel)
        Me.Controls.Add(Me.PorcientoImpuestoTextBox)
        Me.Controls.Add(MonedaLabel)
        Me.Controls.Add(Me.MonedaTextBox)
        Me.Controls.Add(TasaLabel)
        Me.Controls.Add(Me.TasaTextBox)
        Me.Controls.Add(Id_ProveedorLabel)
        Me.Controls.Add(Me.Id_ProveedorTextBox)
        Me.Controls.Add(Id_CompraLabel)
        Me.Controls.Add(Me.Id_CompraTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacturaProveedorTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Id_EmpresaTextBox As TextBox
    Friend WithEvents PorcientoImpuestoTextBox As TextBox
    Friend WithEvents MonedaTextBox As TextBox
    Friend WithEvents TasaTextBox As TextBox
    Friend WithEvents Id_ProveedorTextBox As TextBox
    Friend WithEvents Id_CompraTextBox As TextBox
    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents CompraMaterialesBindingSource As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents LblProyecto As Label
    Friend WithEvents LblPresupuesto As Label
    Friend WithEvents LblProveedor As Label
End Class
