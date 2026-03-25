<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturaMontajeB11
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNCF = New System.Windows.Forms.Label()
        Me.lblImpuesto = New System.Windows.Forms.Label()
        Me.lblRetencion = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.txtIdFactura = New System.Windows.Forms.TextBox()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.txtNCFB11 = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtRetencionIRS = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.BtnNuevaFactura = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnRecalcular = New System.Windows.Forms.Button()
        Me.BtnImprimirB11 = New System.Windows.Forms.Button()
        Me.BtnNuevoDetalle = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.ColIdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.DsMontajeB11 = New ModuloGestion.DsMontajeB11()
        Me.FacturaMontajeB11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaMontajeB11TableAdapter = New ModuloGestion.DsMontajeB11TableAdapters.FacturaMontajeB11TableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsMontajeB11TableAdapters.TableAdapterManager()
        Me.FacturaMontajeB11DetalleTableAdapter = New ModuloGestion.DsMontajeB11TableAdapters.FacturaMontajeB11DetalleTableAdapter()
        Me.FacturaMontajeB11DetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotalPagado = New System.Windows.Forms.TextBox()
        Me.txtRetencionITBIS = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.TxtValorOriginal = New System.Windows.Forms.TextBox()
        Me.TxtValorConIRS = New System.Windows.Forms.TextBox()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMontajeB11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeB11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeB11DetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(24, 24)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(159, 20)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Empresa instaladora:"
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(24, 64)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(86, 20)
        Me.lblFactura.TabIndex = 1
        Me.lblFactura.Text = "Factura Id:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(24, 104)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 20)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'lblNCF
        '
        Me.lblNCF.AutoSize = True
        Me.lblNCF.Location = New System.Drawing.Point(24, 144)
        Me.lblNCF.Name = "lblNCF"
        Me.lblNCF.Size = New System.Drawing.Size(78, 20)
        Me.lblNCF.TabIndex = 3
        Me.lblNCF.Text = "NCF B11:"
        '
        'lblImpuesto
        '
        Me.lblImpuesto.AutoSize = True
        Me.lblImpuesto.Location = New System.Drawing.Point(24, 184)
        Me.lblImpuesto.Name = "lblImpuesto"
        Me.lblImpuesto.Size = New System.Drawing.Size(125, 20)
        Me.lblImpuesto.TabIndex = 4
        Me.lblImpuesto.Text = "Impuesto ITBIS:"
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = True
        Me.lblRetencion.Location = New System.Drawing.Point(24, 224)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(118, 20)
        Me.lblRetencion.TabIndex = 5
        Me.lblRetencion.Text = "Retención IRS:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(24, 264)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(77, 20)
        Me.lblSubTotal.TabIndex = 6
        Me.lblSubTotal.Text = "SubTotal:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(24, 304)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total:"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Location = New System.Drawing.Point(24, 350)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(63, 20)
        Me.lblDetalle.TabIndex = 8
        Me.lblDetalle.Text = "Detalle:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DataSource = Me.EmpresasContratadasMontajeBindingSource
        Me.cboEmpresa.DisplayMember = "RazonSocial"
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(200, 20)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(420, 28)
        Me.cboEmpresa.TabIndex = 9
        Me.cboEmpresa.ValueMember = "IdEmpresaMontaje"
        '
        'EmpresasContratadasMontajeBindingSource
        '
        Me.EmpresasContratadasMontajeBindingSource.DataMember = "EmpresasContratadasMontaje"
        Me.EmpresasContratadasMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'DsPagosMontaje
        '
        Me.DsPagosMontaje.DataSetName = "DsPagosMontaje"
        Me.DsPagosMontaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtIdFactura
        '
        Me.txtIdFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "IdFacturaMontaje", True))
        Me.txtIdFactura.Location = New System.Drawing.Point(200, 60)
        Me.txtIdFactura.Name = "txtIdFactura"
        Me.txtIdFactura.ReadOnly = True
        Me.txtIdFactura.Size = New System.Drawing.Size(180, 26)
        Me.txtIdFactura.TabIndex = 10
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FacturaMontaje"
        Me.FacturaMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaMontajeBindingSource, "FechaPAgo", True))
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(200, 100)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(180, 26)
        Me.dtpFechaFactura.TabIndex = 11
        '
        'txtNCFB11
        '
        Me.txtNCFB11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "NCF", True))
        Me.txtNCFB11.Location = New System.Drawing.Point(200, 140)
        Me.txtNCFB11.Name = "txtNCFB11"
        Me.txtNCFB11.Size = New System.Drawing.Size(240, 26)
        Me.txtNCFB11.TabIndex = 12
        '
        'txtImpuesto
        '
        Me.txtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Impuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtImpuesto.Location = New System.Drawing.Point(200, 180)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(120, 26)
        Me.txtImpuesto.TabIndex = 13
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionIRS
        '
        Me.txtRetencionIRS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "RetencionIRS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtRetencionIRS.Location = New System.Drawing.Point(200, 220)
        Me.txtRetencionIRS.Name = "txtRetencionIRS"
        Me.txtRetencionIRS.Size = New System.Drawing.Size(120, 26)
        Me.txtRetencionIRS.TabIndex = 14
        Me.txtRetencionIRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtSubTotal.Location = New System.Drawing.Point(200, 260)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 26)
        Me.txtSubTotal.TabIndex = 15
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtTotal.Location = New System.Drawing.Point(200, 300)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 26)
        Me.txtTotal.TabIndex = 16
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnNuevaFactura
        '
        Me.BtnNuevaFactura.Location = New System.Drawing.Point(650, 20)
        Me.BtnNuevaFactura.Name = "BtnNuevaFactura"
        Me.BtnNuevaFactura.Size = New System.Drawing.Size(150, 35)
        Me.BtnNuevaFactura.TabIndex = 17
        Me.BtnNuevaFactura.Text = "Nueva factura"
        Me.BtnNuevaFactura.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(650, 65)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 35)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRecalcular
        '
        Me.BtnRecalcular.Location = New System.Drawing.Point(650, 110)
        Me.BtnRecalcular.Name = "BtnRecalcular"
        Me.BtnRecalcular.Size = New System.Drawing.Size(150, 35)
        Me.BtnRecalcular.TabIndex = 19
        Me.BtnRecalcular.Text = "Recalcular"
        Me.BtnRecalcular.UseVisualStyleBackColor = True
        '
        'BtnImprimirB11
        '
        Me.BtnImprimirB11.Location = New System.Drawing.Point(650, 155)
        Me.BtnImprimirB11.Name = "BtnImprimirB11"
        Me.BtnImprimirB11.Size = New System.Drawing.Size(150, 35)
        Me.BtnImprimirB11.TabIndex = 20
        Me.BtnImprimirB11.Text = "Imprimir B11"
        Me.BtnImprimirB11.UseVisualStyleBackColor = True
        '
        'BtnNuevoDetalle
        '
        Me.BtnNuevoDetalle.Location = New System.Drawing.Point(650, 200)
        Me.BtnNuevoDetalle.Name = "BtnNuevoDetalle"
        Me.BtnNuevoDetalle.Size = New System.Drawing.Size(150, 35)
        Me.BtnNuevoDetalle.TabIndex = 21
        Me.BtnNuevoDetalle.Text = "Agregar detalle"
        Me.BtnNuevoDetalle.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdDetalle, Me.ColIdFactura, Me.ColDescripcion, Me.ColCantidad, Me.ColPrecio, Me.ColTotal})
        Me.dgvDetalle.Location = New System.Drawing.Point(28, 380)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersWidth = 51
        Me.dgvDetalle.Size = New System.Drawing.Size(1384, 260)
        Me.dgvDetalle.TabIndex = 22
        '
        'ColIdDetalle
        '
        Me.ColIdDetalle.HeaderText = "IdDetalle"
        Me.ColIdDetalle.MinimumWidth = 6
        Me.ColIdDetalle.Name = "ColIdDetalle"
        Me.ColIdDetalle.Width = 90
        '
        'ColIdFactura
        '
        Me.ColIdFactura.HeaderText = "IdFactura"
        Me.ColIdFactura.MinimumWidth = 6
        Me.ColIdFactura.Name = "ColIdFactura"
        Me.ColIdFactura.Visible = False
        Me.ColIdFactura.Width = 110
        '
        'ColDescripcion
        '
        Me.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColDescripcion.HeaderText = "Descripción"
        Me.ColDescripcion.MinimumWidth = 6
        Me.ColDescripcion.Name = "ColDescripcion"
        '
        'ColCantidad
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.ColCantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColCantidad.HeaderText = "Cantidad"
        Me.ColCantidad.MinimumWidth = 6
        Me.ColCantidad.Name = "ColCantidad"
        Me.ColCantidad.Width = 90
        '
        'ColPrecio
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.ColPrecio.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColPrecio.HeaderText = "Precio"
        Me.ColPrecio.MinimumWidth = 6
        Me.ColPrecio.Name = "ColPrecio"
        Me.ColPrecio.Width = 110
        '
        'ColTotal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.ColTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColTotal.HeaderText = "Total"
        Me.ColTotal.MinimumWidth = 6
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.Width = 110
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeTableAdapter
        '
        Me.FacturaMontajeTableAdapter.ClearBeforeFill = True
        '
        'DsMontajeB11
        '
        Me.DsMontajeB11.DataSetName = "DsMontajeB11"
        Me.DsMontajeB11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaMontajeB11BindingSource
        '
        Me.FacturaMontajeB11BindingSource.DataMember = "FacturaMontajeB11"
        Me.FacturaMontajeB11BindingSource.DataSource = Me.DsMontajeB11
        '
        'FacturaMontajeB11TableAdapter
        '
        Me.FacturaMontajeB11TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacturaMontajeB11DetalleTableAdapter = Me.FacturaMontajeB11DetalleTableAdapter
        Me.TableAdapterManager.FacturaMontajeB11TableAdapter = Me.FacturaMontajeB11TableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsMontajeB11TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaMontajeB11DetalleTableAdapter
        '
        Me.FacturaMontajeB11DetalleTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeB11DetalleBindingSource
        '
        Me.FacturaMontajeB11DetalleBindingSource.DataMember = "FacturaMontajeB11Detalle"
        Me.FacturaMontajeB11DetalleBindingSource.DataSource = Me.DsMontajeB11
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtTotalPagado.Location = New System.Drawing.Point(387, 304)
        Me.txtTotalPagado.Name = "txtTotalPagado"
        Me.txtTotalPagado.Size = New System.Drawing.Size(120, 26)
        Me.txtTotalPagado.TabIndex = 24
        Me.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionITBIS
        '
        Me.txtRetencionITBIS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtRetencionITBIS.Location = New System.Drawing.Point(387, 264)
        Me.txtRetencionITBIS.Name = "txtRetencionITBIS"
        Me.txtRetencionITBIS.Size = New System.Drawing.Size(120, 26)
        Me.txtRetencionITBIS.TabIndex = 23
        Me.txtRetencionITBIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(865, 24)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(150, 35)
        Me.BtnAnular.TabIndex = 25
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'TxtValorOriginal
        '
        Me.TxtValorOriginal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtValorOriginal.Location = New System.Drawing.Point(968, 224)
        Me.TxtValorOriginal.Name = "TxtValorOriginal"
        Me.TxtValorOriginal.Size = New System.Drawing.Size(177, 26)
        Me.TxtValorOriginal.TabIndex = 26
        Me.TxtValorOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorConIRS
        '
        Me.TxtValorConIRS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtValorConIRS.Location = New System.Drawing.Point(968, 264)
        Me.TxtValorConIRS.Name = "TxtValorConIRS"
        Me.TxtValorConIRS.Size = New System.Drawing.Size(177, 26)
        Me.TxtValorConIRS.TabIndex = 27
        Me.TxtValorConIRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmFacturaMontajeB11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1640, 670)
        Me.Controls.Add(Me.TxtValorConIRS)
        Me.Controls.Add(Me.TxtValorOriginal)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.txtTotalPagado)
        Me.Controls.Add(Me.txtRetencionITBIS)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.BtnNuevoDetalle)
        Me.Controls.Add(Me.BtnImprimirB11)
        Me.Controls.Add(Me.BtnRecalcular)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevaFactura)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtRetencionIRS)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.txtNCFB11)
        Me.Controls.Add(Me.dtpFechaFactura)
        Me.Controls.Add(Me.txtIdFactura)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblRetencion)
        Me.Controls.Add(Me.lblImpuesto)
        Me.Controls.Add(Me.lblNCF)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Name = "FrmFacturaMontajeB11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Montaje B11"
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMontajeB11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeB11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeB11DetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPagosMontaje As ModuloGestion.DsPagosMontaje
    Friend WithEvents EmpresasContratadasMontajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaMontajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents FacturaMontajeTableAdapter As ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter

    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblFactura As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNCF As Label
    Friend WithEvents lblImpuesto As Label
    Friend WithEvents lblRetencion As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDetalle As Label

    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents txtIdFactura As TextBox
    Friend WithEvents dtpFechaFactura As DateTimePicker
    Friend WithEvents txtNCFB11 As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtRetencionIRS As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTotal As TextBox

    Friend WithEvents BtnNuevaFactura As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnRecalcular As Button
    Friend WithEvents BtnImprimirB11 As Button
    Friend WithEvents BtnNuevoDetalle As Button

    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents DsMontajeB11 As DsMontajeB11
    Friend WithEvents FacturaMontajeB11BindingSource As BindingSource
    Friend WithEvents FacturaMontajeB11TableAdapter As DsMontajeB11TableAdapters.FacturaMontajeB11TableAdapter
    Friend WithEvents TableAdapterManager As DsMontajeB11TableAdapters.TableAdapterManager
    Friend WithEvents FacturaMontajeB11DetalleTableAdapter As DsMontajeB11TableAdapters.FacturaMontajeB11DetalleTableAdapter
    Friend WithEvents FacturaMontajeB11DetalleBindingSource As BindingSource
    Friend WithEvents txtTotalPagado As TextBox
    Friend WithEvents txtRetencionITBIS As TextBox
    Friend WithEvents BtnAnular As Button
    Friend WithEvents ColIdDetalle As DataGridViewTextBoxColumn
    Friend WithEvents ColIdFactura As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As DataGridViewTextBoxColumn
    Friend WithEvents TxtValorOriginal As TextBox
    Friend WithEvents TxtValorConIRS As TextBox
End Class