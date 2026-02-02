<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignarPagoMontaje
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
        Dim IdPagoMontajeLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim AsignadoLabel As System.Windows.Forms.Label
        Dim PendienteAsignarLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.PagoMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdPagoMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.AsignadoTextBox = New System.Windows.Forms.TextBox()
        Me.PendienteAsignarTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.PagoMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.PagoMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter()
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.FacturaMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteInstalador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter()
        Me.FacturaMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        IdPagoMontajeLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        AsignadoLabel = New System.Windows.Forms.Label()
        PendienteAsignarLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(138, 82)
        IdEmpresaMontajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(156, 20)
        IdEmpresaMontajeLabel.TabIndex = 2
        IdEmpresaMontajeLabel.Text = "Id Empresa Montaje:"
        '
        'IdPagoMontajeLabel
        '
        IdPagoMontajeLabel.AutoSize = True
        IdPagoMontajeLabel.Location = New System.Drawing.Point(138, 122)
        IdPagoMontajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdPagoMontajeLabel.Name = "IdPagoMontajeLabel"
        IdPagoMontajeLabel.Size = New System.Drawing.Size(129, 20)
        IdPagoMontajeLabel.TabIndex = 6
        IdPagoMontajeLabel.Text = "Id Pago Montaje:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(138, 165)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(58, 20)
        FechaLabel.TabIndex = 8
        FechaLabel.Text = "Fecha:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(138, 202)
        ValorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(46, 20)
        ValorLabel.TabIndex = 10
        ValorLabel.Text = "valor:"
        '
        'AsignadoLabel
        '
        AsignadoLabel.AutoSize = True
        AsignadoLabel.Location = New System.Drawing.Point(138, 242)
        AsignadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsignadoLabel.Name = "AsignadoLabel"
        AsignadoLabel.Size = New System.Drawing.Size(80, 20)
        AsignadoLabel.TabIndex = 12
        AsignadoLabel.Text = "Asignado:"
        '
        'PendienteAsignarLabel
        '
        PendienteAsignarLabel.AutoSize = True
        PendienteAsignarLabel.Location = New System.Drawing.Point(138, 282)
        PendienteAsignarLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PendienteAsignarLabel.Name = "PendienteAsignarLabel"
        PendienteAsignarLabel.Size = New System.Drawing.Size(143, 20)
        PendienteAsignarLabel.TabIndex = 14
        PendienteAsignarLabel.Text = "Pendiente Asignar:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(138, 322)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 20)
        Label1.TabIndex = 17
        Label1.Text = "Asignar:"
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FacturaMontaje"
        Me.FacturaMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'DsPagosMontaje
        '
        Me.DsPagosMontaje.DataSetName = "DsPagosMontaje"
        Me.DsPagosMontaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "IdEmpresaMontaje", True))
        Me.IdEmpresaMontajeTextBox.Enabled = False
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(303, 78)
        Me.IdEmpresaMontajeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(298, 26)
        Me.IdEmpresaMontajeTextBox.TabIndex = 3
        '
        'PagoMontajeBindingSource
        '
        Me.PagoMontajeBindingSource.DataMember = "PagoMontaje"
        Me.PagoMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'IdPagoMontajeTextBox
        '
        Me.IdPagoMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "IdPagoMontaje", True))
        Me.IdPagoMontajeTextBox.Enabled = False
        Me.IdPagoMontajeTextBox.Location = New System.Drawing.Point(303, 118)
        Me.IdPagoMontajeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdPagoMontajeTextBox.Name = "IdPagoMontajeTextBox"
        Me.IdPagoMontajeTextBox.Size = New System.Drawing.Size(298, 26)
        Me.IdPagoMontajeTextBox.TabIndex = 7
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PagoMontajeBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(303, 158)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(298, 26)
        Me.FechaDateTimePicker.TabIndex = 9
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ValorTextBox.Enabled = False
        Me.ValorTextBox.Location = New System.Drawing.Point(303, 198)
        Me.ValorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(180, 26)
        Me.ValorTextBox.TabIndex = 11
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AsignadoTextBox
        '
        Me.AsignadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "Asignado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.AsignadoTextBox.Enabled = False
        Me.AsignadoTextBox.Location = New System.Drawing.Point(303, 238)
        Me.AsignadoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AsignadoTextBox.Name = "AsignadoTextBox"
        Me.AsignadoTextBox.Size = New System.Drawing.Size(180, 26)
        Me.AsignadoTextBox.TabIndex = 13
        Me.AsignadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PendienteAsignarTextBox
        '
        Me.PendienteAsignarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagoMontajeBindingSource, "PendienteAsignar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.PendienteAsignarTextBox.Enabled = False
        Me.PendienteAsignarTextBox.Location = New System.Drawing.Point(303, 278)
        Me.PendienteAsignarTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PendienteAsignarTextBox.Name = "PendienteAsignarTextBox"
        Me.PendienteAsignarTextBox.Size = New System.Drawing.Size(180, 26)
        Me.PendienteAsignarTextBox.TabIndex = 15
        Me.PendienteAsignarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(303, 318)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 26)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaMontajeTableAdapter
        '
        Me.FacturaMontajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasContratadasMontajeTableAdapter = Nothing
        Me.TableAdapterManager.FacturaMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.FacturaMontajeTableAdapter = Me.FacturaMontajeTableAdapter
        Me.TableAdapterManager.PagoMontajeDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagoMontajeTableAdapter = Me.PagoMontajeTableAdapter
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagoMontajeTableAdapter
        '
        Me.PagoMontajeTableAdapter.ClearBeforeFill = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(834, 242)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(112, 35)
        Me.BtnAceptar.TabIndex = 18
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'PagoMontajeDetalleBindingSource
        '
        Me.PagoMontajeDetalleBindingSource.DataMember = "PagoMontajeDetalle"
        Me.PagoMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'PagoMontajeDetalleTableAdapter
        '
        Me.PagoMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "DsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsClientes
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager1.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaMontajeDataGridView
        '
        Me.FacturaMontajeDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDataGridView.AllowUserToDeleteRows = False
        Me.FacturaMontajeDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFactura, Me.SubTotal, Me.Pagado, Me.Id_Presupuesto, Me.PendienteInstalador})
        Me.FacturaMontajeDataGridView.DataSource = Me.FacturaMontajeBindingSource
        Me.FacturaMontajeDataGridView.Location = New System.Drawing.Point(111, 358)
        Me.FacturaMontajeDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaMontajeDataGridView.Name = "FacturaMontajeDataGridView"
        Me.FacturaMontajeDataGridView.ReadOnly = True
        Me.FacturaMontajeDataGridView.RowHeadersWidth = 62
        Me.FacturaMontajeDataGridView.Size = New System.Drawing.Size(1039, 338)
        Me.FacturaMontajeDataGridView.TabIndex = 18
        '
        'IdFactura
        '
        Me.IdFactura.DataPropertyName = "IdFacturaMontaje"
        Me.IdFactura.HeaderText = "IdFactura"
        Me.IdFactura.MinimumWidth = 8
        Me.IdFactura.Name = "IdFactura"
        Me.IdFactura.ReadOnly = True
        Me.IdFactura.Width = 150
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 125
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Pagado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 8
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 150
        '
        'Id_Presupuesto
        '
        Me.Id_Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Id_Presupuesto.HeaderText = "Presupuesto"
        Me.Id_Presupuesto.MinimumWidth = 8
        Me.Id_Presupuesto.Name = "Id_Presupuesto"
        Me.Id_Presupuesto.ReadOnly = True
        Me.Id_Presupuesto.Visible = False
        Me.Id_Presupuesto.Width = 150
        '
        'PendienteInstalador
        '
        Me.PendienteInstalador.DataPropertyName = "PendienteInstalador"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.PendienteInstalador.DefaultCellStyle = DataGridViewCellStyle3
        Me.PendienteInstalador.HeaderText = "Pendiente"
        Me.PendienteInstalador.MinimumWidth = 8
        Me.PendienteInstalador.Name = "PendienteInstalador"
        Me.PendienteInstalador.ReadOnly = True
        Me.PendienteInstalador.Width = 150
        '
        'FacturaMontajeDetalleBindingSource
        '
        Me.FacturaMontajeDetalleBindingSource.DataMember = "FacturaMontajeDetalle"
        Me.FacturaMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'FacturaMontajeDetalleTableAdapter
        '
        Me.FacturaMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeDetalleDataGridView
        '
        Me.FacturaMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.FacturaMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.Presupuesto})
        Me.FacturaMontajeDetalleDataGridView.DataSource = Me.FacturaMontajeDetalleBindingSource
        Me.FacturaMontajeDetalleDataGridView.Location = New System.Drawing.Point(111, 706)
        Me.FacturaMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaMontajeDetalleDataGridView.Name = "FacturaMontajeDetalleDataGridView"
        Me.FacturaMontajeDetalleDataGridView.ReadOnly = True
        Me.FacturaMontajeDetalleDataGridView.RowHeadersWidth = 62
        Me.FacturaMontajeDetalleDataGridView.Size = New System.Drawing.Size(1039, 338)
        Me.FacturaMontajeDetalleDataGridView.TabIndex = 18
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 8
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Precio"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn9.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'Presupuesto
        '
        Me.Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Presupuesto.HeaderText = "Presupuesto"
        Me.Presupuesto.MinimumWidth = 8
        Me.Presupuesto.Name = "Presupuesto"
        Me.Presupuesto.ReadOnly = True
        Me.Presupuesto.Width = 75
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsArticulosBindingSource
        '
        'DsArticulosBindingSource
        '
        Me.DsArticulosBindingSource.DataSource = Me.DsArticulos
        Me.DsArticulosBindingSource.Position = 0
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "DsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(848, 322)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 22)
        Me.Label2.TabIndex = 19
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'FrmAsignarPagoMontaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1816, 1094)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FacturaMontajeDetalleDataGridView)
        Me.Controls.Add(Me.FacturaMontajeDataGridView)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(IdEmpresaMontajeLabel)
        Me.Controls.Add(Me.IdEmpresaMontajeTextBox)
        Me.Controls.Add(IdPagoMontajeLabel)
        Me.Controls.Add(Me.IdPagoMontajeTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(AsignadoLabel)
        Me.Controls.Add(Me.AsignadoTextBox)
        Me.Controls.Add(PendienteAsignarLabel)
        Me.Controls.Add(Me.PendienteAsignarTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmAsignarPagoMontaje"
        Me.Text = "FrmAsignarPagoMontaje"
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents FacturaMontajeBindingSource As BindingSource
    Friend WithEvents FacturaMontajeTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter
    Friend WithEvents TableAdapterManager As DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents PagoMontajeTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeTableAdapter
    Friend WithEvents PagoMontajeBindingSource As BindingSource
    Friend WithEvents IdEmpresaMontajeTextBox As TextBox
    Friend WithEvents IdPagoMontajeTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents AsignadoTextBox As TextBox
    Friend WithEvents PendienteAsignarTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents PagoMontajeDetalleBindingSource As BindingSource
    Friend WithEvents PagoMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter
    Friend WithEvents DsClientes As DsClientes
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager2 As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents DsProyectos As DsProyectos
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager3 As DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents FacturaMontajeDataGridView As DataGridView
    Friend WithEvents FacturaMontajeDetalleBindingSource As BindingSource
    Friend WithEvents FacturaMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter
    Friend WithEvents FacturaMontajeDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents DsArticulos As DsArticulos
    Friend WithEvents DsArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
    Friend WithEvents IdFactura As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Id_Presupuesto As DataGridViewTextBoxColumn
    Friend WithEvents PendienteInstalador As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Presupuesto As DataGridViewTextBoxColumn
End Class
