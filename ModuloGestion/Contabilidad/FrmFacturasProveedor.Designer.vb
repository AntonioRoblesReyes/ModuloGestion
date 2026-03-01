<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturasProveedor
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FacturaProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.NCFProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProveedores = New ModuloGestion.DsProveedores()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaCambioRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contabilizada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodigoUnico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContabilidad = New ModuloGestion.DsContabilidad()
        Me.LblRncEmpresa = New System.Windows.Forms.Label()
        Me.BtnIngresarFactura = New System.Windows.Forms.Button()
        Me.ProveedoresTableAdapter = New ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.TxtTotales = New System.Windows.Forms.TextBox()
        Me.TxtTotalSinPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeInicio = New System.Windows.Forms.DateTimePicker()
        Me.FacturaProveedorTableAdapter = New ModuloGestion.DsContabilidadTableAdapters.FacturaProveedorTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeFinal = New System.Windows.Forms.DateTimePicker()
        Me.DsFacturaProveedor = New ModuloGestion.DsFacturaProveedor()
        Me.TableAdapterManager = New ModuloGestion.DsFacturaProveedorTableAdapters.TableAdapterManager()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnRecargar = New System.Windows.Forms.Button()
        CType(Me.FacturaProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaProveedorDataGridView
        '
        Me.FacturaProveedorDataGridView.AllowUserToAddRows = False
        Me.FacturaProveedorDataGridView.AllowUserToDeleteRows = False
        Me.FacturaProveedorDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaProveedorDataGridView.AutoGenerateColumns = False
        Me.FacturaProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCFProveedorDataGridViewTextBoxColumn, Me.IdFacturaProveedorDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.Id_Proveedor, Me.IdProveedorDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.ValorImpuestoDataGridViewTextBoxColumn, Me.ImpuestoDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.TasaCambioRDDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.FormaDePagoDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.Contabilizada, Me.CodigoUnico})
        Me.FacturaProveedorDataGridView.DataSource = Me.FacturaProveedorBindingSource
        Me.FacturaProveedorDataGridView.Location = New System.Drawing.Point(17, 128)
        Me.FacturaProveedorDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FacturaProveedorDataGridView.Name = "FacturaProveedorDataGridView"
        Me.FacturaProveedorDataGridView.RowHeadersWidth = 51
        Me.FacturaProveedorDataGridView.Size = New System.Drawing.Size(1772, 671)
        Me.FacturaProveedorDataGridView.TabIndex = 1
        '
        'NCFProveedorDataGridViewTextBoxColumn
        '
        Me.NCFProveedorDataGridViewTextBoxColumn.DataPropertyName = "NCFProveedor"
        Me.NCFProveedorDataGridViewTextBoxColumn.HeaderText = "NCF"
        Me.NCFProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NCFProveedorDataGridViewTextBoxColumn.Name = "NCFProveedorDataGridViewTextBoxColumn"
        Me.NCFProveedorDataGridViewTextBoxColumn.Width = 125
        '
        'IdFacturaProveedorDataGridViewTextBoxColumn
        '
        Me.IdFacturaProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdFacturaProveedor"
        Me.IdFacturaProveedorDataGridViewTextBoxColumn.HeaderText = "Id Factura"
        Me.IdFacturaProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdFacturaProveedorDataGridViewTextBoxColumn.Name = "IdFacturaProveedorDataGridViewTextBoxColumn"
        Me.IdFacturaProveedorDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'Id_Proveedor
        '
        Me.Id_Proveedor.DataPropertyName = "Id_Proveedor"
        Me.Id_Proveedor.HeaderText = "Id Proveedor"
        Me.Id_Proveedor.MinimumWidth = 6
        Me.Id_Proveedor.Name = "Id_Proveedor"
        Me.Id_Proveedor.Width = 125
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.DataSource = Me.ProveedoresBindingSource
        Me.IdProveedorDataGridViewTextBoxColumn.DisplayMember = "RazonSocial"
        Me.IdProveedorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "Razon Social"
        Me.IdProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdProveedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdProveedorDataGridViewTextBoxColumn.ValueMember = "Id_Proveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsProveedores
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "DsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.SubtotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.Width = 60
        '
        'ValorImpuestoDataGridViewTextBoxColumn
        '
        Me.ValorImpuestoDataGridViewTextBoxColumn.DataPropertyName = "ValorImpuesto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.ValorImpuestoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ValorImpuestoDataGridViewTextBoxColumn.HeaderText = "Impuesto"
        Me.ValorImpuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorImpuestoDataGridViewTextBoxColumn.Name = "ValorImpuestoDataGridViewTextBoxColumn"
        Me.ValorImpuestoDataGridViewTextBoxColumn.Width = 60
        '
        'ImpuestoDataGridViewTextBoxColumn
        '
        Me.ImpuestoDataGridViewTextBoxColumn.DataPropertyName = "Impuesto"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "## %"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ImpuestoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ImpuestoDataGridViewTextBoxColumn.HeaderText = "% Impuesto"
        Me.ImpuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImpuestoDataGridViewTextBoxColumn.Name = "ImpuestoDataGridViewTextBoxColumn"
        Me.ImpuestoDataGridViewTextBoxColumn.Width = 60
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 60
        '
        'TasaCambioRDDataGridViewTextBoxColumn
        '
        Me.TasaCambioRDDataGridViewTextBoxColumn.DataPropertyName = "TasaCambioRD$"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.TasaCambioRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TasaCambioRDDataGridViewTextBoxColumn.HeaderText = "Tasa"
        Me.TasaCambioRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TasaCambioRDDataGridViewTextBoxColumn.Name = "TasaCambioRDDataGridViewTextBoxColumn"
        Me.TasaCambioRDDataGridViewTextBoxColumn.Width = 60
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.Width = 60
        '
        'FormaDePagoDataGridViewTextBoxColumn
        '
        Me.FormaDePagoDataGridViewTextBoxColumn.DataPropertyName = "FormaDePago"
        Me.FormaDePagoDataGridViewTextBoxColumn.HeaderText = "Forma De Pago"
        Me.FormaDePagoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FormaDePagoDataGridViewTextBoxColumn.Name = "FormaDePagoDataGridViewTextBoxColumn"
        Me.FormaDePagoDataGridViewTextBoxColumn.Width = 75
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.Width = 75
        '
        'Contabilizada
        '
        Me.Contabilizada.DataPropertyName = "Contabilizada"
        Me.Contabilizada.HeaderText = "Contabilizada"
        Me.Contabilizada.MinimumWidth = 6
        Me.Contabilizada.Name = "Contabilizada"
        Me.Contabilizada.Width = 75
        '
        'CodigoUnico
        '
        Me.CodigoUnico.DataPropertyName = "CodigoUnico"
        Me.CodigoUnico.HeaderText = "CodigoUnico"
        Me.CodigoUnico.MinimumWidth = 6
        Me.CodigoUnico.Name = "CodigoUnico"
        Me.CodigoUnico.Visible = False
        Me.CodigoUnico.Width = 125
        '
        'FacturaProveedorBindingSource
        '
        Me.FacturaProveedorBindingSource.DataMember = "FacturaProveedor"
        Me.FacturaProveedorBindingSource.DataSource = Me.DsContabilidad
        '
        'DsContabilidad
        '
        Me.DsContabilidad.DataSetName = "DsContabilidad"
        Me.DsContabilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblRncEmpresa
        '
        Me.LblRncEmpresa.AutoSize = True
        Me.LblRncEmpresa.Location = New System.Drawing.Point(16, 57)
        Me.LblRncEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRncEmpresa.Name = "LblRncEmpresa"
        Me.LblRncEmpresa.Size = New System.Drawing.Size(48, 16)
        Me.LblRncEmpresa.TabIndex = 2
        Me.LblRncEmpresa.Text = "Label1"
        '
        'BtnIngresarFactura
        '
        Me.BtnIngresarFactura.Location = New System.Drawing.Point(17, 84)
        Me.BtnIngresarFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnIngresarFactura.Name = "BtnIngresarFactura"
        Me.BtnIngresarFactura.Size = New System.Drawing.Size(205, 28)
        Me.BtnIngresarFactura.TabIndex = 3
        Me.BtnIngresarFactura.Text = "Ingresar Factura"
        Me.BtnIngresarFactura.UseVisualStyleBackColor = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 84)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Refrescar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(1235, 92)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(132, 22)
        Me.TxtBuscar.TabIndex = 5
        '
        'TxtTotales
        '
        Me.TxtTotales.Enabled = False
        Me.TxtTotales.Location = New System.Drawing.Point(1444, 94)
        Me.TxtTotales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTotales.Name = "TxtTotales"
        Me.TxtTotales.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotales.TabIndex = 6
        Me.TxtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalSinPago
        '
        Me.TxtTotalSinPago.Enabled = False
        Me.TxtTotalSinPago.Location = New System.Drawing.Point(1444, 66)
        Me.TxtTotalSinPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTotalSinPago.Name = "TxtTotalSinPago"
        Me.TxtTotalSinPago.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotalSinPago.TabIndex = 14
        Me.TxtTotalSinPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(1115, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Flitro por campo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(1368, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(1310, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total sin pago"
        '
        'DateTimeInicio
        '
        Me.DateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeInicio.Location = New System.Drawing.Point(761, 96)
        Me.DateTimeInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimeInicio.Name = "DateTimeInicio"
        Me.DateTimeInicio.Size = New System.Drawing.Size(124, 22)
        Me.DateTimeInicio.TabIndex = 10
        '
        'FacturaProveedorTableAdapter
        '
        Me.FacturaProveedorTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(761, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "            Flitrar por fechas                    Inicio                       Fi" &
    "nal"
        '
        'DateTimeFinal
        '
        Me.DateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFinal.Location = New System.Drawing.Point(916, 96)
        Me.DateTimeFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimeFinal.Name = "DateTimeFinal"
        Me.DateTimeFinal.Size = New System.Drawing.Size(124, 22)
        Me.DateTimeFinal.TabIndex = 11
        '
        'DsFacturaProveedor
        '
        Me.DsFacturaProveedor.DataSetName = "DsFacturaProveedor"
        Me.DsFacturaProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.FacturaProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsFacturaProveedorTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1669, 94)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 28)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Contabilizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnRecargar
        '
        Me.BtnRecargar.Location = New System.Drawing.Point(359, 84)
        Me.BtnRecargar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRecargar.Name = "BtnRecargar"
        Me.BtnRecargar.Size = New System.Drawing.Size(120, 28)
        Me.BtnRecargar.TabIndex = 13
        Me.BtnRecargar.Text = "Recargar"
        Me.BtnRecargar.UseVisualStyleBackColor = True
        '
        'FrmFacturasProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1805, 814)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTotalSinPago)
        Me.Controls.Add(Me.BtnRecargar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimeFinal)
        Me.Controls.Add(Me.DateTimeInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTotales)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnIngresarFactura)
        Me.Controls.Add(Me.LblRncEmpresa)
        Me.Controls.Add(Me.FacturaProveedorDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmFacturasProveedor"
        Me.Text = "FrmFacturasProveedor"
        CType(Me.FacturaProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents FacturaProveedorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblRncEmpresa As System.Windows.Forms.Label
    Friend WithEvents BtnIngresarFactura As System.Windows.Forms.Button
    Friend WithEvents DsContabilidad As ModuloGestion.DsContabilidad
    Friend WithEvents FacturaProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaProveedorTableAdapter As ModuloGestion.DsContabilidadTableAdapters.FacturaProveedorTableAdapter
    Friend WithEvents DsProveedores As ModuloGestion.DsProveedores
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotales As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalSinPago As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimeInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimeFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsFacturaProveedor As ModuloGestion.DsFacturaProveedor
    Friend WithEvents TableAdapterManager As ModuloGestion.DsFacturaProveedorTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NCFProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasaCambioRDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormaDePagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contabilizada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoUnico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnRecargar As Button
    Friend WithEvents Label4 As Label
End Class
