<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagarCompra
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
        Dim MediaLabel As System.Windows.Forms.Label
        Me.CompraMaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnRegistrarPago = New System.Windows.Forms.Button()
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.RbRD = New System.Windows.Forms.RadioButton()
        Me.RbUS = New System.Windows.Forms.RadioButton()
        Me.DsTasa = New ModuloGestion.DsTasa()
        Me.TasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasaTableAdapter = New ModuloGestion.DsTasaTableAdapters.TasaTableAdapter()
        Me.MediaTextBox = New System.Windows.Forms.TextBox()
        Me.DgvFacturasSeleccionadas = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New ModuloGestion.DsContabilidad()
        Me.LabelCuenta = New System.Windows.Forms.Label()
        Me.CuentasTableAdapter = New ModuloGestion.DsContabilidadTableAdapters.CuentasTableAdapter()
        Me.PagoProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoProveedorDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoProveedorTableAdapter = New ModuloGestion.DsComprasTableAdapters.PagoProveedorTableAdapter()
        Me.PagoProveedorDetalleTableAdapter = New ModuloGestion.DsComprasTableAdapters.PagoProveedorDetalleTableAdapter()
        MediaLabel = New System.Windows.Forms.Label()
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFacturasSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoProveedorDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaLabel
        '
        MediaLabel.AutoSize = True
        MediaLabel.Location = New System.Drawing.Point(706, 19)
        MediaLabel.Name = "MediaLabel"
        MediaLabel.Size = New System.Drawing.Size(83, 16)
        MediaLabel.TabIndex = 37
        MediaLabel.Text = "Tasa Media:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(714, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Monto "
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(800, 376)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(124, 22)
        Me.TxtMonto.TabIndex = 21
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(536, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 22)
        Me.DateTimePicker1.TabIndex = 22
        '
        'BtnRegistrarPago
        '
        Me.BtnRegistrarPago.Location = New System.Drawing.Point(811, 423)
        Me.BtnRegistrarPago.Name = "BtnRegistrarPago"
        Me.BtnRegistrarPago.Size = New System.Drawing.Size(113, 46)
        Me.BtnRegistrarPago.TabIndex = 23
        Me.BtnRegistrarPago.Text = "Aprobar Pago"
        Me.BtnRegistrarPago.UseVisualStyleBackColor = True
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraMaterialesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RbRD
        '
        Me.RbRD.AutoSize = True
        Me.RbRD.Location = New System.Drawing.Point(972, 376)
        Me.RbRD.Name = "RbRD"
        Me.RbRD.Size = New System.Drawing.Size(55, 20)
        Me.RbRD.TabIndex = 25
        Me.RbRD.TabStop = True
        Me.RbRD.Text = "RD$"
        Me.RbRD.UseVisualStyleBackColor = True
        '
        'RbUS
        '
        Me.RbUS.AutoSize = True
        Me.RbUS.Location = New System.Drawing.Point(972, 402)
        Me.RbUS.Name = "RbUS"
        Me.RbUS.Size = New System.Drawing.Size(54, 20)
        Me.RbUS.TabIndex = 26
        Me.RbUS.TabStop = True
        Me.RbUS.Text = "US$"
        Me.RbUS.UseVisualStyleBackColor = True
        '
        'DsTasa
        '
        Me.DsTasa.DataSetName = "DsTasa"
        Me.DsTasa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TasaBindingSource
        '
        Me.TasaBindingSource.DataMember = "Tasa"
        Me.TasaBindingSource.DataSource = Me.DsTasa
        '
        'TasaTableAdapter
        '
        Me.TasaTableAdapter.ClearBeforeFill = True
        '
        'MediaTextBox
        '
        Me.MediaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TasaBindingSource, "Media", True))
        Me.MediaTextBox.Location = New System.Drawing.Point(798, 14)
        Me.MediaTextBox.Name = "MediaTextBox"
        Me.MediaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MediaTextBox.TabIndex = 38
        '
        'DgvFacturasSeleccionadas
        '
        Me.DgvFacturasSeleccionadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFacturasSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvFacturasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturasSeleccionadas.Location = New System.Drawing.Point(19, 50)
        Me.DgvFacturasSeleccionadas.Name = "DgvFacturasSeleccionadas"
        Me.DgvFacturasSeleccionadas.RowHeadersWidth = 51
        Me.DgvFacturasSeleccionadas.RowTemplate.Height = 24
        Me.DgvFacturasSeleccionadas.Size = New System.Drawing.Size(750, 300)
        Me.DgvFacturasSeleccionadas.TabIndex = 0
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DataSource = Me.CuentasBindingSource
        Me.CmbFormaPago.DisplayMember = "NumeroDeCuenta"
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(775, 69)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(324, 24)
        Me.CmbFormaPago.TabIndex = 39
        Me.CmbFormaPago.ValueMember = "Idcontable"
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "DsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelCuenta
        '
        Me.LabelCuenta.AutoSize = True
        Me.LabelCuenta.Location = New System.Drawing.Point(791, 50)
        Me.LabelCuenta.Name = "LabelCuenta"
        Me.LabelCuenta.Size = New System.Drawing.Size(107, 16)
        Me.LabelCuenta.TabIndex = 40
        Me.LabelCuenta.Text = "Cuenta de Pago:"
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'PagoProveedorBindingSource
        '
        Me.PagoProveedorBindingSource.DataMember = "PagoProveedor"
        Me.PagoProveedorBindingSource.DataSource = Me.DsCompras
        '
        'PagoProveedorDetalleBindingSource
        '
        Me.PagoProveedorDetalleBindingSource.DataMember = "PagoProveedorDetalle"
        Me.PagoProveedorDetalleBindingSource.DataSource = Me.DsCompras
        '
        'PagoProveedorTableAdapter
        '
        Me.PagoProveedorTableAdapter.ClearBeforeFill = True
        '
        'PagoProveedorDetalleTableAdapter
        '
        Me.PagoProveedorDetalleTableAdapter.ClearBeforeFill = True
        '
        'FrmPagarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 786)
        Me.Controls.Add(Me.LabelCuenta)
        Me.Controls.Add(Me.CmbFormaPago)
        Me.Controls.Add(Me.DgvFacturasSeleccionadas)
        Me.Controls.Add(MediaLabel)
        Me.Controls.Add(Me.MediaTextBox)
        Me.Controls.Add(Me.RbUS)
        Me.Controls.Add(Me.RbRD)
        Me.Controls.Add(Me.BtnRegistrarPago)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmPagarCompra"
        Me.Text = "FrmPagarCompra"
        CType(Me.CompraMaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFacturasSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoProveedorDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents CompraMaterialesBindingSource As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnRegistrarPago As Button
    Friend WithEvents RbRD As RadioButton
    Friend WithEvents RbUS As RadioButton
    Friend WithEvents DsTasa As DsTasa
    Friend WithEvents TasaBindingSource As BindingSource
    Friend WithEvents TasaTableAdapter As DsTasaTableAdapters.TasaTableAdapter
    Friend WithEvents MediaTextBox As TextBox
    Friend WithEvents DgvFacturasSeleccionadas As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CmbFormaPago As ComboBox
    Friend WithEvents LabelCuenta As Label
    Friend WithEvents DsContabilidad As DsContabilidad
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As DsContabilidadTableAdapters.CuentasTableAdapter
    Friend WithEvents PagoProveedorBindingSource As BindingSource
    Friend WithEvents PagoProveedorDetalleBindingSource As BindingSource
    Friend WithEvents PagoProveedorTableAdapter As DsComprasTableAdapters.PagoProveedorTableAdapter
    Friend WithEvents PagoProveedorDetalleTableAdapter As DsComprasTableAdapters.PagoProveedorDetalleTableAdapter
End Class
