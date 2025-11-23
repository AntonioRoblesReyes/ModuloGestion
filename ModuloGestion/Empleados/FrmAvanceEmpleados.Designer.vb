<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAvanceEmpleados
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
        Dim IdAvanceEmpleadoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim FechaAVanceLabel As System.Windows.Forms.Label
        Dim QuincenaAdescontarLabel As System.Windows.Forms.Label
        Dim TotalAvanceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsEmpleados = New ModuloGestion.DsEmpleados()
        Me.AvanceEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvanceEmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.AvanceEmpleadosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager()
        Me.IdAvanceEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaAVanceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NominasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtAvance = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtCheque = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.AvnceEmpleadosPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvnceEmpleadosPagosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.AvnceEmpleadosPagosTableAdapter()
        Me.AvnceEmpleadosPagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuincenaAdescontarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AplicadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AvanceEmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        IdAvanceEmpleadoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        FechaAVanceLabel = New System.Windows.Forms.Label()
        QuincenaAdescontarLabel = New System.Windows.Forms.Label()
        TotalAvanceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvanceEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvnceEmpleadosPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvnceEmpleadosPagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvanceEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAvanceEmpleadoLabel
        '
        IdAvanceEmpleadoLabel.AutoSize = True
        IdAvanceEmpleadoLabel.Location = New System.Drawing.Point(45, 27)
        IdAvanceEmpleadoLabel.Name = "IdAvanceEmpleadoLabel"
        IdAvanceEmpleadoLabel.Size = New System.Drawing.Size(109, 13)
        IdAvanceEmpleadoLabel.TabIndex = 1
        IdAvanceEmpleadoLabel.Text = "Id Avance Empleado:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(45, 53)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 3
        CedulaLabel.Text = "Cedula:"
        '
        'FechaAVanceLabel
        '
        FechaAVanceLabel.AutoSize = True
        FechaAVanceLabel.Location = New System.Drawing.Point(45, 80)
        FechaAVanceLabel.Name = "FechaAVanceLabel"
        FechaAVanceLabel.Size = New System.Drawing.Size(80, 13)
        FechaAVanceLabel.TabIndex = 5
        FechaAVanceLabel.Text = "Fecha Avance:"
        '
        'QuincenaAdescontarLabel
        '
        QuincenaAdescontarLabel.AutoSize = True
        QuincenaAdescontarLabel.Location = New System.Drawing.Point(45, 105)
        QuincenaAdescontarLabel.Name = "QuincenaAdescontarLabel"
        QuincenaAdescontarLabel.Size = New System.Drawing.Size(118, 13)
        QuincenaAdescontarLabel.TabIndex = 7
        QuincenaAdescontarLabel.Text = "Quincena A Descontar:"
        '
        'TotalAvanceLabel
        '
        TotalAvanceLabel.AutoSize = True
        TotalAvanceLabel.Location = New System.Drawing.Point(45, 131)
        TotalAvanceLabel.Name = "TotalAvanceLabel"
        TotalAvanceLabel.Size = New System.Drawing.Size(74, 13)
        TotalAvanceLabel.TabIndex = 9
        TotalAvanceLabel.Text = "Total Avance:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(45, 160)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(84, 13)
        Label1.TabIndex = 18
        Label1.Text = "Cheque Numero"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(45, 186)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(94, 13)
        Label2.TabIndex = 21
        Label2.Text = "Numero De Pagos"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(45, 209)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 13)
        Label3.TabIndex = 22
        Label3.Text = "Monto a Descontar"
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "DsEmpleados"
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AvanceEmpleadosBindingSource
        '
        Me.AvanceEmpleadosBindingSource.DataMember = "AvanceEmpleados"
        Me.AvanceEmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'AvanceEmpleadosTableAdapter
        '
        Me.AvanceEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvanceEmpleadosTableAdapter = Me.AvanceEmpleadosTableAdapter
        Me.TableAdapterManager.AvnceEmpleadosPagosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalendarioTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaPuestoTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.HorariosEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.NominasDetalleTableAdapter = Nothing
        Me.TableAdapterManager.NominasTableAdapter = Nothing
        Me.TableAdapterManager.RentaTableAdapter = Nothing
        Me.TableAdapterManager.SeguroSocialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdAvanceEmpleadoTextBox
        '
        Me.IdAvanceEmpleadoTextBox.Enabled = False
        Me.IdAvanceEmpleadoTextBox.Location = New System.Drawing.Point(164, 24)
        Me.IdAvanceEmpleadoTextBox.Name = "IdAvanceEmpleadoTextBox"
        Me.IdAvanceEmpleadoTextBox.Size = New System.Drawing.Size(119, 20)
        Me.IdAvanceEmpleadoTextBox.TabIndex = 2
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.Enabled = False
        Me.CedulaTextBox.Location = New System.Drawing.Point(164, 50)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(119, 20)
        Me.CedulaTextBox.TabIndex = 4
        '
        'FechaAVanceDateTimePicker
        '
        Me.FechaAVanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaAVanceDateTimePicker.Location = New System.Drawing.Point(164, 75)
        Me.FechaAVanceDateTimePicker.Name = "FechaAVanceDateTimePicker"
        Me.FechaAVanceDateTimePicker.Size = New System.Drawing.Size(94, 20)
        Me.FechaAVanceDateTimePicker.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.NominasBindingSource
        Me.ComboBox1.DisplayMember = "Quincena"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(164, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "Quincena"
        '
        'NominasBindingSource
        '
        Me.NominasBindingSource.DataMember = "Nominas"
        Me.NominasBindingSource.DataSource = Me.DsEmpleados
        '
        'NominasTableAdapter
        '
        Me.NominasTableAdapter.ClearBeforeFill = True
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(290, 52)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(39, 13)
        Me.LblNombre.TabIndex = 14
        Me.LblNombre.Text = "Label1"
        '
        'TxtAvance
        '
        Me.TxtAvance.Location = New System.Drawing.Point(164, 131)
        Me.TxtAvance.Name = "TxtAvance"
        Me.TxtAvance.Size = New System.Drawing.Size(100, 20)
        Me.TxtAvance.TabIndex = 15
        Me.TxtAvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(44, 254)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 16
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtCheque
        '
        Me.TxtCheque.Location = New System.Drawing.Point(164, 157)
        Me.TxtCheque.Name = "TxtCheque"
        Me.TxtCheque.Size = New System.Drawing.Size(100, 20)
        Me.TxtCheque.TabIndex = 17
        Me.TxtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(876, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Inprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 183)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(164, 209)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AvnceEmpleadosPagosBindingSource
        '
        Me.AvnceEmpleadosPagosBindingSource.DataMember = "AvnceEmpleadosPagos"
        Me.AvnceEmpleadosPagosBindingSource.DataSource = Me.DsEmpleados
        '
        'AvnceEmpleadosPagosTableAdapter
        '
        Me.AvnceEmpleadosPagosTableAdapter.ClearBeforeFill = True
        '
        'AvnceEmpleadosPagosDataGridView
        '
        Me.AvnceEmpleadosPagosDataGridView.AllowUserToAddRows = False
        Me.AvnceEmpleadosPagosDataGridView.AllowUserToDeleteRows = False
        Me.AvnceEmpleadosPagosDataGridView.AutoGenerateColumns = False
        Me.AvnceEmpleadosPagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvnceEmpleadosPagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn, Me.IdAvanceEmpleadoDataGridViewTextBoxColumn, Me.QuincenaAdescontarDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.AplicadoDataGridViewCheckBoxColumn})
        Me.AvnceEmpleadosPagosDataGridView.DataSource = Me.AvnceEmpleadosPagosBindingSource
        Me.AvnceEmpleadosPagosDataGridView.Location = New System.Drawing.Point(302, 266)
        Me.AvnceEmpleadosPagosDataGridView.Name = "AvnceEmpleadosPagosDataGridView"
        Me.AvnceEmpleadosPagosDataGridView.ReadOnly = True
        Me.AvnceEmpleadosPagosDataGridView.Size = New System.Drawing.Size(547, 161)
        Me.AvnceEmpleadosPagosDataGridView.TabIndex = 23
        '
        'IdPagoAvanceEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdPagoAvanceEmpleado"
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdPagoAvanceEmpleado"
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.Name = "IdPagoAvanceEmpleadoDataGridViewTextBoxColumn"
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdAvanceEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdAvanceEmpleado"
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdAvanceEmpleado"
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.Name = "IdAvanceEmpleadoDataGridViewTextBoxColumn"
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuincenaAdescontarDataGridViewTextBoxColumn
        '
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.DataPropertyName = "QuincenaAdescontar"
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.HeaderText = "QuincenaAdescontar"
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.Name = "QuincenaAdescontarDataGridViewTextBoxColumn"
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AplicadoDataGridViewCheckBoxColumn
        '
        Me.AplicadoDataGridViewCheckBoxColumn.DataPropertyName = "Aplicado"
        Me.AplicadoDataGridViewCheckBoxColumn.HeaderText = "Aplicado"
        Me.AplicadoDataGridViewCheckBoxColumn.Name = "AplicadoDataGridViewCheckBoxColumn"
        Me.AplicadoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'AvanceEmpleadosDataGridView
        '
        Me.AvanceEmpleadosDataGridView.AutoGenerateColumns = False
        Me.AvanceEmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvanceEmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6})
        Me.AvanceEmpleadosDataGridView.DataSource = Me.AvanceEmpleadosBindingSource
        Me.AvanceEmpleadosDataGridView.Location = New System.Drawing.Point(302, 77)
        Me.AvanceEmpleadosDataGridView.Name = "AvanceEmpleadosDataGridView"
        Me.AvanceEmpleadosDataGridView.Size = New System.Drawing.Size(649, 149)
        Me.AvanceEmpleadosDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdAvanceEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdAvance"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaAVance"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaAVance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalAvance"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "TotalAvance"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cobrado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cobrado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SaldoPendiente"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pendiente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cheque"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cheque"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(289, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Nuevo Avance"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmAvanceEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 515)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AvanceEmpleadosDataGridView)
        Me.Controls.Add(Me.AvnceEmpleadosPagosDataGridView)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TxtCheque)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtAvance)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdAvanceEmpleadoLabel)
        Me.Controls.Add(Me.IdAvanceEmpleadoTextBox)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(FechaAVanceLabel)
        Me.Controls.Add(Me.FechaAVanceDateTimePicker)
        Me.Controls.Add(QuincenaAdescontarLabel)
        Me.Controls.Add(TotalAvanceLabel)
        Me.Name = "FrmAvanceEmpleados"
        Me.Text = "FrmAvanceEmpleados"
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvanceEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvnceEmpleadosPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvnceEmpleadosPagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvanceEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents DsEmpleados As ModuloGestion.DsEmpleados
    Friend WithEvents AvanceEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvanceEmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.AvanceEmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager
    Friend WithEvents IdAvanceEmpleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaAVanceDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents NominasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtAvance As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents AvnceEmpleadosPagosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvnceEmpleadosPagosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.AvnceEmpleadosPagosTableAdapter
    Friend WithEvents AvnceEmpleadosPagosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdPagoAvanceEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAvanceEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuincenaAdescontarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AplicadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AvanceEmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
