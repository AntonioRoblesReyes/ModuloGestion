<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturaMontajeB11
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        Me.IdFacturaMontajeLabel = New System.Windows.Forms.Label()
        Me.FechaPAgoLabel = New System.Windows.Forms.Label()
        Me.NCFLabel = New System.Windows.Forms.Label()
        Me.ImpuestoLabel = New System.Windows.Forms.Label()
        Me.RetencionIRSLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
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
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        Me.IdEmpresaMontajeLabel.AutoSize = True
        Me.IdEmpresaMontajeLabel.Location = New System.Drawing.Point(39, 44)
        Me.IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        Me.IdEmpresaMontajeLabel.Size = New System.Drawing.Size(159, 20)
        Me.IdEmpresaMontajeLabel.TabIndex = 0
        Me.IdEmpresaMontajeLabel.Text = "Empresa instaladora:"
        '
        'IdFacturaMontajeLabel
        '
        Me.IdFacturaMontajeLabel.AutoSize = True
        Me.IdFacturaMontajeLabel.Location = New System.Drawing.Point(39, 94)
        Me.IdFacturaMontajeLabel.Name = "IdFacturaMontajeLabel"
        Me.IdFacturaMontajeLabel.Size = New System.Drawing.Size(86, 20)
        Me.IdFacturaMontajeLabel.TabIndex = 2
        Me.IdFacturaMontajeLabel.Text = "Factura Id:"
        '
        'FechaPAgoLabel
        '
        Me.FechaPAgoLabel.AutoSize = True
        Me.FechaPAgoLabel.Location = New System.Drawing.Point(39, 144)
        Me.FechaPAgoLabel.Name = "FechaPAgoLabel"
        Me.FechaPAgoLabel.Size = New System.Drawing.Size(58, 20)
        Me.FechaPAgoLabel.TabIndex = 4
        Me.FechaPAgoLabel.Text = "Fecha:"
        '
        'NCFLabel
        '
        Me.NCFLabel.AutoSize = True
        Me.NCFLabel.Location = New System.Drawing.Point(39, 194)
        Me.NCFLabel.Name = "NCFLabel"
        Me.NCFLabel.Size = New System.Drawing.Size(78, 20)
        Me.NCFLabel.TabIndex = 6
        Me.NCFLabel.Text = "NCF B11:"
        '
        'ImpuestoLabel
        '
        Me.ImpuestoLabel.AutoSize = True
        Me.ImpuestoLabel.Location = New System.Drawing.Point(39, 244)
        Me.ImpuestoLabel.Name = "ImpuestoLabel"
        Me.ImpuestoLabel.Size = New System.Drawing.Size(125, 20)
        Me.ImpuestoLabel.TabIndex = 8
        Me.ImpuestoLabel.Text = "Impuesto ITBIS:"
        '
        'RetencionIRSLabel
        '
        Me.RetencionIRSLabel.AutoSize = True
        Me.RetencionIRSLabel.Location = New System.Drawing.Point(39, 294)
        Me.RetencionIRSLabel.Name = "RetencionIRSLabel"
        Me.RetencionIRSLabel.Size = New System.Drawing.Size(118, 20)
        Me.RetencionIRSLabel.TabIndex = 10
        Me.RetencionIRSLabel.Text = "Retención IRS:"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Location = New System.Drawing.Point(39, 344)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(77, 20)
        Me.SubTotalLabel.TabIndex = 12
        Me.SubTotalLabel.Text = "SubTotal:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(39, 394)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(48, 20)
        Me.TotalLabel.TabIndex = 14
        Me.TotalLabel.Text = "Total:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DataSource = Me.EmpresasContratadasMontajeBindingSource
        Me.cboEmpresa.DisplayMember = "RazonSocial"
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(248, 39)
        Me.cboEmpresa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(404, 28)
        Me.cboEmpresa.TabIndex = 1
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
        Me.txtIdFactura.Location = New System.Drawing.Point(248, 89)
        Me.txtIdFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdFactura.Name = "txtIdFactura"
        Me.txtIdFactura.ReadOnly = True
        Me.txtIdFactura.Size = New System.Drawing.Size(202, 26)
        Me.txtIdFactura.TabIndex = 3
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
        Me.dtpFechaFactura.Location = New System.Drawing.Point(248, 139)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(202, 26)
        Me.dtpFechaFactura.TabIndex = 5
        '
        'txtNCFB11
        '
        Me.txtNCFB11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "NCF", True))
        Me.txtNCFB11.Location = New System.Drawing.Point(248, 189)
        Me.txtNCFB11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNCFB11.Name = "txtNCFB11"
        Me.txtNCFB11.Size = New System.Drawing.Size(270, 26)
        Me.txtNCFB11.TabIndex = 7
        '
        'txtImpuesto
        '
        Me.txtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Impuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtImpuesto.Location = New System.Drawing.Point(248, 239)
        Me.txtImpuesto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(134, 26)
        Me.txtImpuesto.TabIndex = 9
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionIRS
        '
        Me.txtRetencionIRS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "RetencionIRS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtRetencionIRS.Location = New System.Drawing.Point(248, 289)
        Me.txtRetencionIRS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRetencionIRS.Name = "txtRetencionIRS"
        Me.txtRetencionIRS.Size = New System.Drawing.Size(134, 26)
        Me.txtRetencionIRS.TabIndex = 11
        Me.txtRetencionIRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtSubTotal.Location = New System.Drawing.Point(248, 339)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(134, 26)
        Me.txtSubTotal.TabIndex = 13
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtTotal.Location = New System.Drawing.Point(248, 389)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(134, 26)
        Me.txtTotal.TabIndex = 15
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnNuevaFactura
        '
        Me.BtnNuevaFactura.Location = New System.Drawing.Point(44, 462)
        Me.BtnNuevaFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNuevaFactura.Name = "BtnNuevaFactura"
        Me.BtnNuevaFactura.Size = New System.Drawing.Size(146, 40)
        Me.BtnNuevaFactura.TabIndex = 16
        Me.BtnNuevaFactura.Text = "Nueva factura"
        Me.BtnNuevaFactura.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(202, 462)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(146, 40)
        Me.BtnGuardar.TabIndex = 17
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRecalcular
        '
        Me.BtnRecalcular.Location = New System.Drawing.Point(361, 462)
        Me.BtnRecalcular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRecalcular.Name = "BtnRecalcular"
        Me.BtnRecalcular.Size = New System.Drawing.Size(146, 40)
        Me.BtnRecalcular.TabIndex = 18
        Me.BtnRecalcular.Text = "Recalcular"
        Me.BtnRecalcular.UseVisualStyleBackColor = True
        '
        'BtnImprimirB11
        '
        Me.BtnImprimirB11.Location = New System.Drawing.Point(520, 462)
        Me.BtnImprimirB11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnImprimirB11.Name = "BtnImprimirB11"
        Me.BtnImprimirB11.Size = New System.Drawing.Size(180, 40)
        Me.BtnImprimirB11.TabIndex = 19
        Me.BtnImprimirB11.Text = "Imprimir B11"
        Me.BtnImprimirB11.UseVisualStyleBackColor = True
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeTableAdapter
        '
        Me.FacturaMontajeTableAdapter.ClearBeforeFill = True
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "NCF", True))
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(417, 244)
        Me.IdEmpresaMontajeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(270, 26)
        Me.IdEmpresaMontajeTextBox.TabIndex = 20
        '
        'FrmFacturaMontajeB11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 538)
        Me.Controls.Add(Me.IdEmpresaMontajeTextBox)
        Me.Controls.Add(Me.BtnImprimirB11)
        Me.Controls.Add(Me.BtnRecalcular)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevaFactura)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.RetencionIRSLabel)
        Me.Controls.Add(Me.txtRetencionIRS)
        Me.Controls.Add(Me.ImpuestoLabel)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.NCFLabel)
        Me.Controls.Add(Me.txtNCFB11)
        Me.Controls.Add(Me.FechaPAgoLabel)
        Me.Controls.Add(Me.dtpFechaFactura)
        Me.Controls.Add(Me.IdFacturaMontajeLabel)
        Me.Controls.Add(Me.txtIdFactura)
        Me.Controls.Add(Me.IdEmpresaMontajeLabel)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmFacturaMontajeB11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Montaje B11"
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents EmpresasContratadasMontajeBindingSource As BindingSource
    Friend WithEvents FacturaMontajeBindingSource As BindingSource
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents FacturaMontajeTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter
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
    Friend WithEvents IdEmpresaMontajeLabel As Label
    Friend WithEvents IdFacturaMontajeLabel As Label
    Friend WithEvents FechaPAgoLabel As Label
    Friend WithEvents NCFLabel As Label
    Friend WithEvents ImpuestoLabel As Label
    Friend WithEvents RetencionIRSLabel As Label
    Friend WithEvents SubTotalLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents IdEmpresaMontajeTextBox As TextBox
End Class
