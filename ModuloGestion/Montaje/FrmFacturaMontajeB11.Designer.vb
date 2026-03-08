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
        Dim IdEmpresaMontajeLabel As System.Windows.Forms.Label
        Dim IdFacturaMontajeLabel As System.Windows.Forms.Label
        Dim FechaPAgoLabel As System.Windows.Forms.Label
        Dim NCFLabel As System.Windows.Forms.Label
        Dim ImpuestoLabel As System.Windows.Forms.Label
        Dim RetencionIRSLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
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
        IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        IdFacturaMontajeLabel = New System.Windows.Forms.Label()
        FechaPAgoLabel = New System.Windows.Forms.Label()
        NCFLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        RetencionIRSLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(35, 35)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(165, 20)
        IdEmpresaMontajeLabel.TabIndex = 0
        IdEmpresaMontajeLabel.Text = "Empresa instaladora:"
        '
        'IdFacturaMontajeLabel
        '
        IdFacturaMontajeLabel.AutoSize = True
        IdFacturaMontajeLabel.Location = New System.Drawing.Point(35, 75)
        IdFacturaMontajeLabel.Name = "IdFacturaMontajeLabel"
        IdFacturaMontajeLabel.Size = New System.Drawing.Size(81, 20)
        IdFacturaMontajeLabel.TabIndex = 2
        IdFacturaMontajeLabel.Text = "Factura Id:"
        '
        'FechaPAgoLabel
        '
        FechaPAgoLabel.AutoSize = True
        FechaPAgoLabel.Location = New System.Drawing.Point(35, 115)
        FechaPAgoLabel.Name = "FechaPAgoLabel"
        FechaPAgoLabel.Size = New System.Drawing.Size(55, 20)
        FechaPAgoLabel.TabIndex = 4
        FechaPAgoLabel.Text = "Fecha:"
        '
        'NCFLabel
        '
        NCFLabel.AutoSize = True
        NCFLabel.Location = New System.Drawing.Point(35, 155)
        NCFLabel.Name = "NCFLabel"
        NCFLabel.Size = New System.Drawing.Size(71, 20)
        NCFLabel.TabIndex = 6
        NCFLabel.Text = "NCF B11:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.Location = New System.Drawing.Point(35, 195)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(119, 20)
        ImpuestoLabel.TabIndex = 8
        ImpuestoLabel.Text = "Impuesto ITBIS:"
        '
        'RetencionIRSLabel
        '
        RetencionIRSLabel.AutoSize = True
        RetencionIRSLabel.Location = New System.Drawing.Point(35, 235)
        RetencionIRSLabel.Name = "RetencionIRSLabel"
        RetencionIRSLabel.Size = New System.Drawing.Size(109, 20)
        RetencionIRSLabel.TabIndex = 10
        RetencionIRSLabel.Text = "Retención IRS:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(35, 275)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(75, 20)
        SubTotalLabel.TabIndex = 12
        SubTotalLabel.Text = "SubTotal:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(35, 315)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(46, 20)
        TotalLabel.TabIndex = 14
        TotalLabel.Text = "Total:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DataSource = Me.EmpresasContratadasMontajeBindingSource
        Me.cboEmpresa.DisplayMember = "RazonSocial"
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(220, 31)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(360, 28)
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
        Me.txtIdFactura.Location = New System.Drawing.Point(220, 71)
        Me.txtIdFactura.Name = "txtIdFactura"
        Me.txtIdFactura.ReadOnly = True
        Me.txtIdFactura.Size = New System.Drawing.Size(180, 26)
        Me.txtIdFactura.TabIndex = 3
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FacturaMontaje"
        Me.FacturaMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaMontajeBindingSource, "FechaPAgo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing))
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(220, 111)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(180, 26)
        Me.dtpFechaFactura.TabIndex = 5
        '
        'txtNCFB11
        '
        Me.txtNCFB11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "NCF", True))
        Me.txtNCFB11.Location = New System.Drawing.Point(220, 151)
        Me.txtNCFB11.Name = "txtNCFB11"
        Me.txtNCFB11.Size = New System.Drawing.Size(240, 26)
        Me.txtNCFB11.TabIndex = 7
        '
        'txtImpuesto
        '
        Me.txtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Impuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtImpuesto.Location = New System.Drawing.Point(220, 191)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(120, 26)
        Me.txtImpuesto.TabIndex = 9
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionIRS
        '
        Me.txtRetencionIRS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "RetencionIRS", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtRetencionIRS.Location = New System.Drawing.Point(220, 231)
        Me.txtRetencionIRS.Name = "txtRetencionIRS"
        Me.txtRetencionIRS.Size = New System.Drawing.Size(120, 26)
        Me.txtRetencionIRS.TabIndex = 11
        Me.txtRetencionIRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtSubTotal.Location = New System.Drawing.Point(220, 271)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(120, 26)
        Me.txtSubTotal.TabIndex = 13
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaMontajeBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.txtTotal.Location = New System.Drawing.Point(220, 311)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 26)
        Me.txtTotal.TabIndex = 15
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnNuevaFactura
        '
        Me.BtnNuevaFactura.Location = New System.Drawing.Point(39, 370)
        Me.BtnNuevaFactura.Name = "BtnNuevaFactura"
        Me.BtnNuevaFactura.Size = New System.Drawing.Size(130, 32)
        Me.BtnNuevaFactura.TabIndex = 16
        Me.BtnNuevaFactura.Text = "Nueva factura"
        Me.BtnNuevaFactura.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(180, 370)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(130, 32)
        Me.BtnGuardar.TabIndex = 17
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRecalcular
        '
        Me.BtnRecalcular.Location = New System.Drawing.Point(321, 370)
        Me.BtnRecalcular.Name = "BtnRecalcular"
        Me.BtnRecalcular.Size = New System.Drawing.Size(130, 32)
        Me.BtnRecalcular.TabIndex = 18
        Me.BtnRecalcular.Text = "Recalcular"
        Me.BtnRecalcular.UseVisualStyleBackColor = True
        '
        'BtnImprimirB11
        '
        Me.BtnImprimirB11.Location = New System.Drawing.Point(462, 370)
        Me.BtnImprimirB11.Name = "BtnImprimirB11"
        Me.BtnImprimirB11.Size = New System.Drawing.Size(160, 32)
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
        'FrmFacturaMontajeB11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 430)
        Me.Controls.Add(Me.BtnImprimirB11)
        Me.Controls.Add(Me.BtnRecalcular)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevaFactura)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(RetencionIRSLabel)
        Me.Controls.Add(Me.txtRetencionIRS)
        Me.Controls.Add(ImpuestoLabel)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(NCFLabel)
        Me.Controls.Add(Me.txtNCFB11)
        Me.Controls.Add(FechaPAgoLabel)
        Me.Controls.Add(Me.dtpFechaFactura)
        Me.Controls.Add(IdFacturaMontajeLabel)
        Me.Controls.Add(Me.txtIdFactura)
        Me.Controls.Add(IdEmpresaMontajeLabel)
        Me.Controls.Add(Me.cboEmpresa)
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
End Class
