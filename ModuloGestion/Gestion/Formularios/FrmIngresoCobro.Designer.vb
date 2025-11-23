<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoCobro
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
        Dim ID_CobroLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim FormaDePagoLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim TasaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoCobro))
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.PagosClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PagosClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_CobroTextBox = New System.Windows.Forms.TextBox()
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FormaDePagoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MonedasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMonedas = New ModuloGestion.DsMonedas()
        Me.MonedasTableAdapter = New ModuloGestion.DsMonedasTableAdapters.MonedasTableAdapter()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaRecibidaTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DsTasa = New ModuloGestion.DsTasa()
        Me.TasaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasaTableAdapter = New ModuloGestion.DsTasaTableAdapters.TasaTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsTasaTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        ID_CobroLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        FormaDePagoLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        TasaLabel = New System.Windows.Forms.Label()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagosClientesBindingNavigator.SuspendLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CobroLabel
        '
        ID_CobroLabel.AutoSize = True
        ID_CobroLabel.Location = New System.Drawing.Point(45, 50)
        ID_CobroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_CobroLabel.Name = "ID_CobroLabel"
        ID_CobroLabel.Size = New System.Drawing.Size(67, 17)
        ID_CobroLabel.TabIndex = 1
        ID_CobroLabel.Text = "ID Cobro:"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(45, 82)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(63, 17)
        Id_FiscalLabel.TabIndex = 3
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(45, 116)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(45, 146)
        ValorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(43, 17)
        ValorLabel.TabIndex = 7
        ValorLabel.Text = "valor:"
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Location = New System.Drawing.Point(45, 178)
        Id_EmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(83, 17)
        Id_EmpresaLabel.TabIndex = 13
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'FormaDePagoLabel
        '
        FormaDePagoLabel.AutoSize = True
        FormaDePagoLabel.Location = New System.Drawing.Point(45, 212)
        FormaDePagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FormaDePagoLabel.Name = "FormaDePagoLabel"
        FormaDePagoLabel.Size = New System.Drawing.Size(111, 17)
        FormaDePagoLabel.TabIndex = 15
        FormaDePagoLabel.Text = "Forma De Pago:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(699, 60)
        ObservacionesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(107, 17)
        ObservacionesLabel.TabIndex = 18
        ObservacionesLabel.Text = "Observaciones:"
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Location = New System.Drawing.Point(580, 93)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(39, 17)
        TasaLabel.TabIndex = 25
        TasaLabel.Text = "tasa:"
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesBindingSource
        '
        Me.PagosClientesBindingSource.DataMember = "PagosClientes"
        Me.PagosClientesBindingSource.DataSource = Me.DsPagosClientes
        '
        'PagosClientesTableAdapter
        '
        Me.PagosClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesBindingNavigator
        '
        Me.PagosClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PagosClientesBindingNavigator.BindingSource = Me.PagosClientesBindingSource
        Me.PagosClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PagosClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PagosClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PagosClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PagosClientesBindingNavigatorSaveItem})
        Me.PagosClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PagosClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PagosClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PagosClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PagosClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PagosClientesBindingNavigator.Name = "PagosClientesBindingNavigator"
        Me.PagosClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PagosClientesBindingNavigator.Size = New System.Drawing.Size(1129, 27)
        Me.PagosClientesBindingNavigator.TabIndex = 0
        Me.PagosClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'PagosClientesBindingNavigatorSaveItem
        '
        Me.PagosClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagosClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PagosClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PagosClientesBindingNavigatorSaveItem.Name = "PagosClientesBindingNavigatorSaveItem"
        Me.PagosClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.PagosClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ID_CobroTextBox
        '
        Me.ID_CobroTextBox.Location = New System.Drawing.Point(181, 47)
        Me.ID_CobroTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ID_CobroTextBox.Name = "ID_CobroTextBox"
        Me.ID_CobroTextBox.Size = New System.Drawing.Size(265, 22)
        Me.ID_CobroTextBox.TabIndex = 2
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(181, 79)
        Me.Id_FiscalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Id_FiscalTextBox.TabIndex = 4
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(181, 111)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(151, 22)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'FormaDePagoComboBox
        '
        Me.FormaDePagoComboBox.FormattingEnabled = True
        Me.FormaDePagoComboBox.Items.AddRange(New Object() {"Efectivo", "Transferencia", "Cheque", "Ingreso Banco"})
        Me.FormaDePagoComboBox.Location = New System.Drawing.Point(181, 208)
        Me.FormaDePagoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FormaDePagoComboBox.Name = "FormaDePagoComboBox"
        Me.FormaDePagoComboBox.Size = New System.Drawing.Size(253, 24)
        Me.FormaDePagoComboBox.TabIndex = 17
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsEmpresas
        '
        'DsEmpresas
        '
        Me.DsEmpresas.DataSetName = "DsEmpresas"
        Me.DsEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(815, 57)
        Me.ObservacionesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(287, 187)
        Me.ObservacionesTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 208)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Aceptar Pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ValorTextBox
        '
        Me.ValorTextBox.Location = New System.Drawing.Point(181, 143)
        Me.ValorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(151, 22)
        Me.ValorTextBox.TabIndex = 8
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpresasBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(181, 175)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(348, 24)
        Me.ComboBox1.TabIndex = 24
        Me.ComboBox1.ValueMember = "Id_Empresa"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MonedasBindingSource
        Me.ComboBox2.DisplayMember = "Descripcion"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(341, 142)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(116, 24)
        Me.ComboBox2.TabIndex = 25
        Me.ComboBox2.ValueMember = "IdMoneda"
        '
        'MonedasBindingSource
        '
        Me.MonedasBindingSource.DataMember = "Monedas"
        Me.MonedasBindingSource.DataSource = Me.DsMonedas
        '
        'DsMonedas
        '
        Me.DsMonedas.DataSetName = "DsMonedas"
        Me.DsMonedas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MonedasTableAdapter
        '
        Me.MonedasTableAdapter.ClearBeforeFill = True
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "tasa", True))
        Me.TasaTextBox.Location = New System.Drawing.Point(625, 92)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TasaTextBox.TabIndex = 26
        '
        'MonedaRecibidaTextBox
        '
        Me.MonedaRecibidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "MonedaRecibida", True))
        Me.MonedaRecibidaTextBox.Location = New System.Drawing.Point(625, 131)
        Me.MonedaRecibidaTextBox.Name = "MonedaRecibidaTextBox"
        Me.MonedaRecibidaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MonedaRecibidaTextBox.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(604, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Realizar Cambio"
        Me.Button2.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TasaTableAdapter = Me.TasaTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsTasaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(464, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmIngresoCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 467)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MonedaRecibidaTextBox)
        Me.Controls.Add(TasaLabel)
        Me.Controls.Add(Me.TasaTextBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(Me.FormaDePagoComboBox)
        Me.Controls.Add(ID_CobroLabel)
        Me.Controls.Add(Me.ID_CobroTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(Id_EmpresaLabel)
        Me.Controls.Add(FormaDePagoLabel)
        Me.Controls.Add(Me.PagosClientesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmIngresoCobro"
        Me.Text = "FrmIngresoCobro"
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagosClientesBindingNavigator.ResumeLayout(False)
        Me.PagosClientesBindingNavigator.PerformLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PagosClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_CobroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_FiscalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FormaDePagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DsMonedas As ModuloGestion.DsMonedas
    Friend WithEvents MonedasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonedasTableAdapter As ModuloGestion.DsMonedasTableAdapters.MonedasTableAdapter
    Friend WithEvents TasaTextBox As TextBox
    Friend WithEvents MonedaRecibidaTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DsTasa As DsTasa
    Friend WithEvents TasaBindingSource As BindingSource
    Friend WithEvents TasaTableAdapter As DsTasaTableAdapters.TasaTableAdapter
    Friend WithEvents TableAdapterManager1 As DsTasaTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
End Class
