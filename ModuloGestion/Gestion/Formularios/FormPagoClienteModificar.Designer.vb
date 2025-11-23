<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagoClienteModificar
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
        Dim AsignadoLabel As System.Windows.Forms.Label
        Dim PendienteAsignarLabel As System.Windows.Forms.Label
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim FormaDePagoLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim TasaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPagoClienteModificar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesDetalleTableAdapter()
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
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.AsignadoTextBox = New System.Windows.Forms.TextBox()
        Me.PendienteAsignarTextBox = New System.Windows.Forms.TextBox()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.FormaDePagoComboBox = New System.Windows.Forms.ComboBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.TasaTextBox = New System.Windows.Forms.TextBox()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        ID_CobroLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        AsignadoLabel = New System.Windows.Forms.Label()
        PendienteAsignarLabel = New System.Windows.Forms.Label()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        FormaDePagoLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        TasaLabel = New System.Windows.Forms.Label()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagosClientesBindingNavigator.SuspendLayout()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CobroLabel
        '
        ID_CobroLabel.AutoSize = True
        ID_CobroLabel.Location = New System.Drawing.Point(51, 44)
        ID_CobroLabel.Name = "ID_CobroLabel"
        ID_CobroLabel.Size = New System.Drawing.Size(67, 17)
        ID_CobroLabel.TabIndex = 1
        ID_CobroLabel.Text = "ID Cobro:"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(51, 72)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(63, 17)
        Id_FiscalLabel.TabIndex = 3
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(51, 100)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(51, 128)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(43, 17)
        ValorLabel.TabIndex = 7
        ValorLabel.Text = "valor:"
        '
        'AsignadoLabel
        '
        AsignadoLabel.AutoSize = True
        AsignadoLabel.Location = New System.Drawing.Point(51, 156)
        AsignadoLabel.Name = "AsignadoLabel"
        AsignadoLabel.Size = New System.Drawing.Size(63, 17)
        AsignadoLabel.TabIndex = 9
        AsignadoLabel.Text = "Asignado:"
        '
        'PendienteAsignarLabel
        '
        PendienteAsignarLabel.AutoSize = True
        PendienteAsignarLabel.Location = New System.Drawing.Point(51, 184)
        PendienteAsignarLabel.Name = "PendienteAsignarLabel"
        PendienteAsignarLabel.Size = New System.Drawing.Size(128, 17)
        PendienteAsignarLabel.TabIndex = 11
        PendienteAsignarLabel.Text = "Pendiente Asignar:"
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Location = New System.Drawing.Point(51, 212)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(83, 17)
        Id_EmpresaLabel.TabIndex = 13
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'FormaDePagoLabel
        '
        FormaDePagoLabel.AutoSize = True
        FormaDePagoLabel.Location = New System.Drawing.Point(51, 240)
        FormaDePagoLabel.Name = "FormaDePagoLabel"
        FormaDePagoLabel.Size = New System.Drawing.Size(111, 17)
        FormaDePagoLabel.TabIndex = 15
        FormaDePagoLabel.Text = "Forma De Pago:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(51, 271)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(107, 17)
        ObservacionesLabel.TabIndex = 17
        ObservacionesLabel.Text = "Observaciones:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Location = New System.Drawing.Point(38, 393)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(63, 17)
        MonedaLabel.TabIndex = 19
        MonedaLabel.Text = "Moneda:"
        '
        'TasaLabel
        '
        TasaLabel.AutoSize = True
        TasaLabel.Location = New System.Drawing.Point(38, 421)
        TasaLabel.Name = "TasaLabel"
        TasaLabel.Size = New System.Drawing.Size(39, 17)
        TasaLabel.TabIndex = 21
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
        Me.TableAdapterManager.PagosClientesDetalleTableAdapter = Me.PagosClientesDetalleTableAdapter
        Me.TableAdapterManager.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesDetalleTableAdapter
        '
        Me.PagosClientesDetalleTableAdapter.ClearBeforeFill = True
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
        Me.PagosClientesBindingNavigator.Size = New System.Drawing.Size(939, 27)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PagosClientesBindingNavigatorSaveItem
        '
        Me.PagosClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagosClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PagosClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PagosClientesBindingNavigatorSaveItem.Name = "PagosClientesBindingNavigatorSaveItem"
        Me.PagosClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PagosClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ID_CobroTextBox
        '
        Me.ID_CobroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "ID_Cobro", True))
        Me.ID_CobroTextBox.Location = New System.Drawing.Point(185, 41)
        Me.ID_CobroTextBox.Name = "ID_CobroTextBox"
        Me.ID_CobroTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ID_CobroTextBox.TabIndex = 2
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(185, 69)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Id_FiscalTextBox.TabIndex = 4
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Fecha", True))
        Me.FechaTextBox.Location = New System.Drawing.Point(185, 97)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(121, 22)
        Me.FechaTextBox.TabIndex = 6
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(185, 125)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ValorTextBox.TabIndex = 8
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AsignadoTextBox
        '
        Me.AsignadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Asignado", True))
        Me.AsignadoTextBox.Location = New System.Drawing.Point(185, 153)
        Me.AsignadoTextBox.Name = "AsignadoTextBox"
        Me.AsignadoTextBox.Size = New System.Drawing.Size(121, 22)
        Me.AsignadoTextBox.TabIndex = 10
        Me.AsignadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PendienteAsignarTextBox
        '
        Me.PendienteAsignarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "PendienteAsignar", True))
        Me.PendienteAsignarTextBox.Location = New System.Drawing.Point(185, 181)
        Me.PendienteAsignarTextBox.Name = "PendienteAsignarTextBox"
        Me.PendienteAsignarTextBox.Size = New System.Drawing.Size(121, 22)
        Me.PendienteAsignarTextBox.TabIndex = 12
        Me.PendienteAsignarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(185, 209)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Id_EmpresaTextBox.TabIndex = 14
        '
        'FormaDePagoComboBox
        '
        Me.FormaDePagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "FormaDePago", True))
        Me.FormaDePagoComboBox.FormattingEnabled = True
        Me.FormaDePagoComboBox.Location = New System.Drawing.Point(185, 237)
        Me.FormaDePagoComboBox.Name = "FormaDePagoComboBox"
        Me.FormaDePagoComboBox.Size = New System.Drawing.Size(121, 24)
        Me.FormaDePagoComboBox.TabIndex = 16
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(185, 268)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(292, 116)
        Me.ObservacionesTextBox.TabIndex = 18
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Moneda", True))
        Me.MonedaTextBox.Location = New System.Drawing.Point(172, 390)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(121, 22)
        Me.MonedaTextBox.TabIndex = 20
        '
        'TasaTextBox
        '
        Me.TasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "tasa", True))
        Me.TasaTextBox.Location = New System.Drawing.Point(172, 418)
        Me.TasaTextBox.Name = "TasaTextBox"
        Me.TasaTextBox.Size = New System.Drawing.Size(121, 22)
        Me.TasaTextBox.TabIndex = 22
        Me.TasaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsPagosClientes
        '
        'PagosClientesDetalleDataGridView
        '
        Me.PagosClientesDetalleDataGridView.AllowUserToAddRows = False
        Me.PagosClientesDetalleDataGridView.AutoGenerateColumns = False
        Me.PagosClientesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagosClientesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PagosClientesDetalleDataGridView.DataSource = Me.PagosClientesDetalleBindingSource
        Me.PagosClientesDetalleDataGridView.Location = New System.Drawing.Point(375, 44)
        Me.PagosClientesDetalleDataGridView.Name = "PagosClientesDetalleDataGridView"
        Me.PagosClientesDetalleDataGridView.RowHeadersWidth = 51
        Me.PagosClientesDetalleDataGridView.RowTemplate.Height = 24
        Me.PagosClientesDetalleDataGridView.Size = New System.Drawing.Size(552, 144)
        Me.PagosClientesDetalleDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Cobro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Cobro"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "TotalPagado"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(607, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 22)
        Me.TextBox1.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(607, 271)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 22)
        Me.TextBox2.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(506, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Monto RD$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(506, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Tasa"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(607, 310)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 22)
        Me.TextBox3.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(506, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Monto US$"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(778, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(665, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 33)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Actulizar Pago"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormPagoClienteModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 508)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PagosClientesDetalleDataGridView)
        Me.Controls.Add(ID_CobroLabel)
        Me.Controls.Add(Me.ID_CobroTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(AsignadoLabel)
        Me.Controls.Add(Me.AsignadoTextBox)
        Me.Controls.Add(PendienteAsignarLabel)
        Me.Controls.Add(Me.PendienteAsignarTextBox)
        Me.Controls.Add(Id_EmpresaLabel)
        Me.Controls.Add(Me.Id_EmpresaTextBox)
        Me.Controls.Add(FormaDePagoLabel)
        Me.Controls.Add(Me.FormaDePagoComboBox)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(MonedaLabel)
        Me.Controls.Add(Me.MonedaTextBox)
        Me.Controls.Add(TasaLabel)
        Me.Controls.Add(Me.TasaTextBox)
        Me.Controls.Add(Me.PagosClientesBindingNavigator)
        Me.Name = "FormPagoClienteModificar"
        Me.Text = "FormPagoClienteModificar"
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagosClientesBindingNavigator.ResumeLayout(False)
        Me.PagosClientesBindingNavigator.PerformLayout()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPagosClientes As DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As BindingSource
    Friend WithEvents PagosClientesTableAdapter As DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager As DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PagosClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_CobroTextBox As TextBox
    Friend WithEvents Id_FiscalTextBox As TextBox
    Friend WithEvents FechaTextBox As TextBox
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents AsignadoTextBox As TextBox
    Friend WithEvents PendienteAsignarTextBox As TextBox
    Friend WithEvents Id_EmpresaTextBox As TextBox
    Friend WithEvents FormaDePagoComboBox As ComboBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents MonedaTextBox As TextBox
    Friend WithEvents TasaTextBox As TextBox
    Friend WithEvents PagosClientesDetalleTableAdapter As DsPagosClientesTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents PagosClientesDetalleBindingSource As BindingSource
    Friend WithEvents PagosClientesDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
