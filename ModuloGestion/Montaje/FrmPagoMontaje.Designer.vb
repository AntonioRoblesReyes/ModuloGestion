<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagoMontaje
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
        Dim IdEmpresaMontajeLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim IdPagoMontajeLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim FormaDePagoLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.PagoMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.IdPagoMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.FormaDePagoTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasContratadasMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
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
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(584, 40)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(130, 16)
        IdEmpresaMontajeLabel.TabIndex = 1
        IdEmpresaMontajeLabel.Text = "Id Empresa Montaje:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(584, 260)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(102, 16)
        ObservacionesLabel.TabIndex = 3
        ObservacionesLabel.Text = "Observaciones:"
        '
        'IdPagoMontajeLabel
        '
        IdPagoMontajeLabel.AutoSize = True
        IdPagoMontajeLabel.Location = New System.Drawing.Point(584, 72)
        IdPagoMontajeLabel.Name = "IdPagoMontajeLabel"
        IdPagoMontajeLabel.Size = New System.Drawing.Size(108, 16)
        IdPagoMontajeLabel.TabIndex = 5
        IdPagoMontajeLabel.Text = "Id Pago Montaje:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(584, 104)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(48, 16)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(584, 136)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(42, 16)
        ValorLabel.TabIndex = 9
        ValorLabel.Text = "Valor:"
        '
        'FormaDePagoLabel
        '
        FormaDePagoLabel.AutoSize = True
        FormaDePagoLabel.Location = New System.Drawing.Point(584, 168)
        FormaDePagoLabel.Name = "FormaDePagoLabel"
        FormaDePagoLabel.Size = New System.Drawing.Size(103, 16)
        FormaDePagoLabel.TabIndex = 17
        FormaDePagoLabel.Text = "Forma de pago:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(584, 232)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(60, 16)
        MonedaLabel.TabIndex = 19
        MonedaLabel.Text = "Moneda:"
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "IdEmpresaMontaje", True))
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(728, 36)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.ReadOnly = True
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(220, 22)
        Me.IdEmpresaMontajeTextBox.TabIndex = 2
        Me.IdEmpresaMontajeTextBox.TabStop = False
        '
        'PagoMontajeBindingSource
        '
        Me.PagoMontajeBindingSource.DataMember = "PagoMontaje"
        Me.PagoMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'DsPagosMontaje
        '
        Me.DsPagosMontaje.DataSetName = "DsPagosMontaje"
        Me.DsPagosMontaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(728, 256)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(380, 80)
        Me.ObservacionesTextBox.TabIndex = 8
        '
        'IdPagoMontajeTextBox
        '
        Me.IdPagoMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "IdPagoMontaje", True))
        Me.IdPagoMontajeTextBox.Location = New System.Drawing.Point(728, 68)
        Me.IdPagoMontajeTextBox.Name = "IdPagoMontajeTextBox"
        Me.IdPagoMontajeTextBox.ReadOnly = True
        Me.IdPagoMontajeTextBox.Size = New System.Drawing.Size(220, 22)
        Me.IdPagoMontajeTextBox.TabIndex = 6
        Me.IdPagoMontajeTextBox.TabStop = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagoMontajeBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(728, 100)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(220, 22)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(728, 132)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(160, 22)
        Me.ValorTextBox.TabIndex = 4
        Me.ValorTextBox.Text = "0,00"
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormaDePagoTextBox
        '
        Me.FormaDePagoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FormaDePagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "FormaDePago", True))
        Me.FormaDePagoTextBox.Location = New System.Drawing.Point(728, 164)
        Me.FormaDePagoTextBox.Multiline = True
        Me.FormaDePagoTextBox.Name = "FormaDePagoTextBox"
        Me.FormaDePagoTextBox.Size = New System.Drawing.Size(380, 60)
        Me.FormaDePagoTextBox.TabIndex = 5
        Me.FormaDePagoTextBox.Text = "SIN ESPECIFICAR"
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "Moneda", True))
        Me.MonedaTextBox.Location = New System.Drawing.Point(728, 228)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(80, 22)
        Me.MonedaTextBox.TabIndex = 7
        Me.MonedaTextBox.Text = "RD$"
        Me.MonedaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpresasContratadasMontajeDataGridView
        '
        Me.EmpresasContratadasMontajeDataGridView.AllowUserToAddRows = False
        Me.EmpresasContratadasMontajeDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasContratadasMontajeDataGridView.AutoGenerateColumns = False
        Me.EmpresasContratadasMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasContratadasMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.EmpresasContratadasMontajeDataGridView.DataSource = Me.EmpresasContratadasMontajeBindingSource
        Me.EmpresasContratadasMontajeDataGridView.Location = New System.Drawing.Point(16, 24)
        Me.EmpresasContratadasMontajeDataGridView.MultiSelect = False
        Me.EmpresasContratadasMontajeDataGridView.Name = "EmpresasContratadasMontajeDataGridView"
        Me.EmpresasContratadasMontajeDataGridView.ReadOnly = True
        Me.EmpresasContratadasMontajeDataGridView.RowHeadersVisible = False
        Me.EmpresasContratadasMontajeDataGridView.RowHeadersWidth = 51
        Me.EmpresasContratadasMontajeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpresasContratadasMontajeDataGridView.Size = New System.Drawing.Size(540, 230)
        Me.EmpresasContratadasMontajeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEmpresaMontaje"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'EmpresasContratadasMontajeBindingSource
        '
        Me.EmpresasContratadasMontajeBindingSource.DataMember = "EmpresasContratadasMontaje"
        Me.EmpresasContratadasMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(728, 356)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 32)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Actualizar"
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 420)
        Me.Controls.Add(Me.btnGuardar)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago a Empresa de Montaje"
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGuardar As Button
End Class
