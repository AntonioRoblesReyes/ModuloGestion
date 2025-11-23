<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoMontaje
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
        Dim IdEmpresaMontajeLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim IdPagoMontajeLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim FormaDePagoLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.IdPagoMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.FormaDePagoTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasContratadasMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.PagoMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        IdPagoMontajeLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        FormaDePagoLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresasContratadasMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(447, 60)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(104, 13)
        IdEmpresaMontajeLabel.TabIndex = 1
        IdEmpresaMontajeLabel.Text = "Id Empresa Montaje:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(447, 294)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 3
        ObservacionesLabel.Text = "Observaciones:"
        '
        'IdPagoMontajeLabel
        '
        IdPagoMontajeLabel.AutoSize = True
        IdPagoMontajeLabel.Location = New System.Drawing.Point(447, 86)
        IdPagoMontajeLabel.Name = "IdPagoMontajeLabel"
        IdPagoMontajeLabel.Size = New System.Drawing.Size(88, 13)
        IdPagoMontajeLabel.TabIndex = 5
        IdPagoMontajeLabel.Text = "Id Pago Montaje:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(447, 113)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(447, 138)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(33, 13)
        ValorLabel.TabIndex = 9
        ValorLabel.Text = "valor:"
        '
        'FormaDePagoLabel
        '
        FormaDePagoLabel.AutoSize = True
        FormaDePagoLabel.Location = New System.Drawing.Point(447, 168)
        FormaDePagoLabel.Name = "FormaDePagoLabel"
        FormaDePagoLabel.Size = New System.Drawing.Size(84, 13)
        FormaDePagoLabel.TabIndex = 17
        FormaDePagoLabel.Text = "Forma De Pago:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(447, 268)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(49, 13)
        MonedaLabel.TabIndex = 19
        MonedaLabel.Text = "Moneda:"
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "IdEmpresaMontaje", True))
        Me.IdEmpresaMontajeTextBox.Enabled = False
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(557, 57)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(201, 20)
        Me.IdEmpresaMontajeTextBox.TabIndex = 2
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(557, 291)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(319, 62)
        Me.ObservacionesTextBox.TabIndex = 4
        Me.ObservacionesTextBox.Text = "Sin Obsevaciones"
        '
        'IdPagoMontajeTextBox
        '
        Me.IdPagoMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "IdPagoMontaje", True))
        Me.IdPagoMontajeTextBox.Enabled = False
        Me.IdPagoMontajeTextBox.Location = New System.Drawing.Point(557, 83)
        Me.IdPagoMontajeTextBox.Name = "IdPagoMontajeTextBox"
        Me.IdPagoMontajeTextBox.Size = New System.Drawing.Size(201, 20)
        Me.IdPagoMontajeTextBox.TabIndex = 6
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagoMontajeBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(557, 109)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(201, 20)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(557, 135)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(124, 20)
        Me.ValorTextBox.TabIndex = 10
        Me.ValorTextBox.Text = "0"
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormaDePagoTextBox
        '
        Me.FormaDePagoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FormaDePagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "FormaDePago", True))
        Me.FormaDePagoTextBox.Location = New System.Drawing.Point(557, 165)
        Me.FormaDePagoTextBox.Multiline = True
        Me.FormaDePagoTextBox.Name = "FormaDePagoTextBox"
        Me.FormaDePagoTextBox.Size = New System.Drawing.Size(319, 82)
        Me.FormaDePagoTextBox.TabIndex = 18
        Me.FormaDePagoTextBox.Text = "SIN ESPECIFICAR"
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "Moneda", True))
        Me.MonedaTextBox.Location = New System.Drawing.Point(557, 265)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.MonedaTextBox.TabIndex = 20
        Me.MonedaTextBox.Text = "RD$"
        '
        'EmpresasContratadasMontajeDataGridView
        '
        Me.EmpresasContratadasMontajeDataGridView.AllowUserToAddRows = False
        Me.EmpresasContratadasMontajeDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasContratadasMontajeDataGridView.AutoGenerateColumns = False
        Me.EmpresasContratadasMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasContratadasMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.EmpresasContratadasMontajeDataGridView.DataSource = Me.EmpresasContratadasMontajeBindingSource
        Me.EmpresasContratadasMontajeDataGridView.Location = New System.Drawing.Point(12, 31)
        Me.EmpresasContratadasMontajeDataGridView.Name = "EmpresasContratadasMontajeDataGridView"
        Me.EmpresasContratadasMontajeDataGridView.ReadOnly = True
        Me.EmpresasContratadasMontajeDataGridView.Size = New System.Drawing.Size(401, 154)
        Me.EmpresasContratadasMontajeDataGridView.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(900, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(900, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEmpresaMontaje"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEmpresaMontaje"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RazonSocial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        'PagoMontajeBindingSource
        '
        Me.PagoMontajeBindingSource.DataMember = "PagoMontaje"
        Me.PagoMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PagoMontajeTableAdapter
        '
        Me.PagoMontajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasContratadasMontajeTableAdapter = Me.EmpresasContratadasMontajeTableAdapter
        Me.TableAdapterManager.FacturaMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.FacturaMontajeTableAdapter = Nothing
        Me.TableAdapterManager.PagoMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoMontajeTableAdapter = Me.PagoMontajeTableAdapter
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
        '
        'FrmPagoMontaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EmpresasContratadasMontajeDataGridView)
        Me.Controls.Add(IdEmpresaMontajeLabel)
        Me.Controls.Add(Me.IdEmpresaMontajeTextBox)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(IdPagoMontajeLabel)
        Me.Controls.Add(Me.IdPagoMontajeTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(FormaDePagoLabel)
        Me.Controls.Add(Me.FormaDePagoTextBox)
        Me.Controls.Add(MonedaLabel)
        Me.Controls.Add(Me.MonedaTextBox)
        Me.Name = "FrmPagoMontaje"
        Me.Text = "FrmPagoMontaje"
        CType(Me.EmpresasContratadasMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents PagoMontajeBindingSource As BindingSource
    Friend WithEvents PagoMontajeTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeTableAdapter
    Friend WithEvents TableAdapterManager As DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents IdEmpresaMontajeTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents IdPagoMontajeTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents FormaDePagoTextBox As TextBox
    Friend WithEvents MonedaTextBox As TextBox
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents EmpresasContratadasMontajeBindingSource As BindingSource
    Friend WithEvents EmpresasContratadasMontajeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
