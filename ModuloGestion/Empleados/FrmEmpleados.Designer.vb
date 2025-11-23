<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleados
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
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Apellido1Label As System.Windows.Forms.Label
        Dim Apellido2Label As System.Windows.Forms.Label
        Dim TelefonoCasaLabel As System.Windows.Forms.Label
        Dim TelefonoCelularLabel As System.Windows.Forms.Label
        Dim DirecciónLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim FotografiaLabel As System.Windows.Forms.Label
        Dim SueldoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim ArsLabel As System.Windows.Forms.Label
        Dim NumeroARSLabel As System.Windows.Forms.Label
        Dim BancoNominaLabel As System.Windows.Forms.Label
        Dim NumeroCuentaBancoLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim FechaEntradaLabel As System.Windows.Forms.Label
        Dim FechaSalidaLabel As System.Windows.Forms.Label
        Dim SeguroAdicionalLabel As System.Windows.Forms.Label
        Dim ContratoObraLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim EStadoCivilLabel As System.Windows.Forms.Label
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados = New ModuloGestion.DsEmpleados()
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
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido1TextBox = New System.Windows.Forms.TextBox()
        Me.Apellido2TextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoCasaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoCelularTextBox = New System.Windows.Forms.TextBox()
        Me.DirecciónTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        Me.FotografiaTextBox = New System.Windows.Forms.TextBox()
        Me.SueldoTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ArsTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroARSTextBox = New System.Windows.Forms.TextBox()
        Me.BancoNominaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroCuentaBancoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCargarFoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.EmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager()
        Me.FechaEntradaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaSalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.CategoriaTableAdapter()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionCategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaPuestoTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.CategoriaPuestoTableAdapter()
        Me.CategoriaPuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuestoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.NominasDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasDetalleTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasDetalleTableAdapter()
        Me.NominasDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblLiquido = New System.Windows.Forms.Label()
        Me.LblSeguro = New System.Windows.Forms.Label()
        Me.LblArs = New System.Windows.Forms.Label()
        Me.LblRenta = New System.Windows.Forms.Label()
        Me.Lbl35 = New System.Windows.Forms.Label()
        Me.Lbl50 = New System.Windows.Forms.Label()
        Me.Lbl100 = New System.Windows.Forms.Label()
        Me.LblNomina = New System.Windows.Forms.Label()
        Me.LblSeguroEmpresa = New System.Windows.Forms.Label()
        Me.LblArsEmpresa = New System.Windows.Forms.Label()
        Me.LblTotalEmpresa = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SeguroAdicionalTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ContratoObraCheckBox = New System.Windows.Forms.CheckBox()
        Me.EStadoCivilTextBox = New System.Windows.Forms.TextBox()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Apellido1Label = New System.Windows.Forms.Label()
        Apellido2Label = New System.Windows.Forms.Label()
        TelefonoCasaLabel = New System.Windows.Forms.Label()
        TelefonoCelularLabel = New System.Windows.Forms.Label()
        DirecciónLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        FotografiaLabel = New System.Windows.Forms.Label()
        SueldoLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        ArsLabel = New System.Windows.Forms.Label()
        NumeroARSLabel = New System.Windows.Forms.Label()
        BancoNominaLabel = New System.Windows.Forms.Label()
        NumeroCuentaBancoLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        FechaEntradaLabel = New System.Windows.Forms.Label()
        FechaSalidaLabel = New System.Windows.Forms.Label()
        SeguroAdicionalLabel = New System.Windows.Forms.Label()
        ContratoObraLabel = New System.Windows.Forms.Label()
        EStadoCivilLabel = New System.Windows.Forms.Label()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaPuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(26, 62)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        IdEmpleadoLabel.TabIndex = 1
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(26, 88)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 3
        CedulaLabel.Text = "Cedula:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(26, 140)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "Nombre:"
        '
        'Apellido1Label
        '
        Apellido1Label.AutoSize = True
        Apellido1Label.Location = New System.Drawing.Point(26, 166)
        Apellido1Label.Name = "Apellido1Label"
        Apellido1Label.Size = New System.Drawing.Size(53, 13)
        Apellido1Label.TabIndex = 9
        Apellido1Label.Text = "Apellido1:"
        '
        'Apellido2Label
        '
        Apellido2Label.AutoSize = True
        Apellido2Label.Location = New System.Drawing.Point(26, 192)
        Apellido2Label.Name = "Apellido2Label"
        Apellido2Label.Size = New System.Drawing.Size(53, 13)
        Apellido2Label.TabIndex = 11
        Apellido2Label.Text = "Apellido2:"
        '
        'TelefonoCasaLabel
        '
        TelefonoCasaLabel.AutoSize = True
        TelefonoCasaLabel.Location = New System.Drawing.Point(26, 218)
        TelefonoCasaLabel.Name = "TelefonoCasaLabel"
        TelefonoCasaLabel.Size = New System.Drawing.Size(79, 13)
        TelefonoCasaLabel.TabIndex = 13
        TelefonoCasaLabel.Text = "Telefono Casa:"
        '
        'TelefonoCelularLabel
        '
        TelefonoCelularLabel.AutoSize = True
        TelefonoCelularLabel.Location = New System.Drawing.Point(26, 244)
        TelefonoCelularLabel.Name = "TelefonoCelularLabel"
        TelefonoCelularLabel.Size = New System.Drawing.Size(87, 13)
        TelefonoCelularLabel.TabIndex = 15
        TelefonoCelularLabel.Text = "Telefono Celular:"
        '
        'DirecciónLabel
        '
        DirecciónLabel.AutoSize = True
        DirecciónLabel.Location = New System.Drawing.Point(26, 270)
        DirecciónLabel.Name = "DirecciónLabel"
        DirecciónLabel.Size = New System.Drawing.Size(55, 13)
        DirecciónLabel.TabIndex = 17
        DirecciónLabel.Text = "Dirección:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(26, 296)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 19
        CiudadLabel.Text = "Ciudad:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(26, 322)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 21
        ProvinciaLabel.Text = "Provincia:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(298, 382)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 23
        NotasLabel.Text = "Notas:"
        '
        'FotografiaLabel
        '
        FotografiaLabel.AutoSize = True
        FotografiaLabel.Location = New System.Drawing.Point(26, 351)
        FotografiaLabel.Name = "FotografiaLabel"
        FotografiaLabel.Size = New System.Drawing.Size(57, 13)
        FotografiaLabel.TabIndex = 25
        FotografiaLabel.Text = "Fotografia:"
        '
        'SueldoLabel
        '
        SueldoLabel.AutoSize = True
        SueldoLabel.Location = New System.Drawing.Point(26, 377)
        SueldoLabel.Name = "SueldoLabel"
        SueldoLabel.Size = New System.Drawing.Size(43, 13)
        SueldoLabel.TabIndex = 27
        SueldoLabel.Text = "Sueldo:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(26, 405)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 29
        EstadoLabel.Text = "Estado:"
        '
        'ArsLabel
        '
        ArsLabel.AutoSize = True
        ArsLabel.Location = New System.Drawing.Point(26, 433)
        ArsLabel.Name = "ArsLabel"
        ArsLabel.Size = New System.Drawing.Size(25, 13)
        ArsLabel.TabIndex = 31
        ArsLabel.Text = "Ars:"
        '
        'NumeroARSLabel
        '
        NumeroARSLabel.AutoSize = True
        NumeroARSLabel.Location = New System.Drawing.Point(26, 459)
        NumeroARSLabel.Name = "NumeroARSLabel"
        NumeroARSLabel.Size = New System.Drawing.Size(72, 13)
        NumeroARSLabel.TabIndex = 33
        NumeroARSLabel.Text = "Numero ARS:"
        '
        'BancoNominaLabel
        '
        BancoNominaLabel.AutoSize = True
        BancoNominaLabel.Location = New System.Drawing.Point(26, 485)
        BancoNominaLabel.Name = "BancoNominaLabel"
        BancoNominaLabel.Size = New System.Drawing.Size(80, 13)
        BancoNominaLabel.TabIndex = 35
        BancoNominaLabel.Text = "Banco Nomina:"
        '
        'NumeroCuentaBancoLabel
        '
        NumeroCuentaBancoLabel.AutoSize = True
        NumeroCuentaBancoLabel.Location = New System.Drawing.Point(26, 511)
        NumeroCuentaBancoLabel.Name = "NumeroCuentaBancoLabel"
        NumeroCuentaBancoLabel.Size = New System.Drawing.Size(118, 13)
        NumeroCuentaBancoLabel.TabIndex = 37
        NumeroCuentaBancoLabel.Text = "Numero Cuenta Banco:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(26, 111)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 38
        CategoriaLabel.Text = "Categoria:"
        '
        'FechaEntradaLabel
        '
        FechaEntradaLabel.AutoSize = True
        FechaEntradaLabel.Location = New System.Drawing.Point(233, 60)
        FechaEntradaLabel.Name = "FechaEntradaLabel"
        FechaEntradaLabel.Size = New System.Drawing.Size(80, 13)
        FechaEntradaLabel.TabIndex = 41
        FechaEntradaLabel.Text = "Fecha Entrada:"
        AddHandler FechaEntradaLabel.Click, AddressOf Me.FechaEntradaLabel_Click
        '
        'FechaSalidaLabel
        '
        FechaSalidaLabel.AutoSize = True
        FechaSalidaLabel.Location = New System.Drawing.Point(277, 221)
        FechaSalidaLabel.Name = "FechaSalidaLabel"
        FechaSalidaLabel.Size = New System.Drawing.Size(72, 13)
        FechaSalidaLabel.TabIndex = 43
        FechaSalidaLabel.Text = "Fecha Salida:"
        '
        'SeguroAdicionalLabel
        '
        SeguroAdicionalLabel.AutoSize = True
        SeguroAdicionalLabel.Location = New System.Drawing.Point(54, 537)
        SeguroAdicionalLabel.Name = "SeguroAdicionalLabel"
        SeguroAdicionalLabel.Size = New System.Drawing.Size(90, 13)
        SeguroAdicionalLabel.TabIndex = 74
        SeguroAdicionalLabel.Text = "Seguro Adicional:"
        '
        'ContratoObraLabel
        '
        ContratoObraLabel.AutoSize = True
        ContratoObraLabel.Location = New System.Drawing.Point(63, 571)
        ContratoObraLabel.Name = "ContratoObraLabel"
        ContratoObraLabel.Size = New System.Drawing.Size(76, 13)
        ContratoObraLabel.TabIndex = 76
        ContratoObraLabel.Text = "Contrato Obra:"
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(1328, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 0
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "DsEmpleados"
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(150, 59)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.IdEmpleadoTextBox.TabIndex = 2
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(150, 85)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(115, 20)
        Me.CedulaTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(150, 137)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(174, 20)
        Me.NombreTextBox.TabIndex = 8
        '
        'Apellido1TextBox
        '
        Me.Apellido1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Apellido1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido1", True))
        Me.Apellido1TextBox.Location = New System.Drawing.Point(150, 163)
        Me.Apellido1TextBox.Name = "Apellido1TextBox"
        Me.Apellido1TextBox.Size = New System.Drawing.Size(174, 20)
        Me.Apellido1TextBox.TabIndex = 10
        '
        'Apellido2TextBox
        '
        Me.Apellido2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Apellido2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido2", True))
        Me.Apellido2TextBox.Location = New System.Drawing.Point(150, 189)
        Me.Apellido2TextBox.Name = "Apellido2TextBox"
        Me.Apellido2TextBox.Size = New System.Drawing.Size(174, 20)
        Me.Apellido2TextBox.TabIndex = 12
        '
        'TelefonoCasaTextBox
        '
        Me.TelefonoCasaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TelefonoCasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "TelefonoCasa", True))
        Me.TelefonoCasaTextBox.Location = New System.Drawing.Point(150, 215)
        Me.TelefonoCasaTextBox.Name = "TelefonoCasaTextBox"
        Me.TelefonoCasaTextBox.Size = New System.Drawing.Size(115, 20)
        Me.TelefonoCasaTextBox.TabIndex = 14
        '
        'TelefonoCelularTextBox
        '
        Me.TelefonoCelularTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TelefonoCelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "TelefonoCelular", True))
        Me.TelefonoCelularTextBox.Location = New System.Drawing.Point(150, 241)
        Me.TelefonoCelularTextBox.Name = "TelefonoCelularTextBox"
        Me.TelefonoCelularTextBox.Size = New System.Drawing.Size(115, 20)
        Me.TelefonoCelularTextBox.TabIndex = 16
        '
        'DirecciónTextBox
        '
        Me.DirecciónTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DirecciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Dirección", True))
        Me.DirecciónTextBox.Location = New System.Drawing.Point(150, 267)
        Me.DirecciónTextBox.Name = "DirecciónTextBox"
        Me.DirecciónTextBox.Size = New System.Drawing.Size(371, 20)
        Me.DirecciónTextBox.TabIndex = 18
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(150, 293)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(371, 20)
        Me.CiudadTextBox.TabIndex = 20
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(150, 319)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(371, 20)
        Me.ProvinciaTextBox.TabIndex = 22
        '
        'NotasTextBox
        '
        Me.NotasTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(355, 374)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(274, 180)
        Me.NotasTextBox.TabIndex = 24
        '
        'FotografiaTextBox
        '
        Me.FotografiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Fotografia", True))
        Me.FotografiaTextBox.Location = New System.Drawing.Point(150, 348)
        Me.FotografiaTextBox.Name = "FotografiaTextBox"
        Me.FotografiaTextBox.Size = New System.Drawing.Size(479, 20)
        Me.FotografiaTextBox.TabIndex = 26
        '
        'SueldoTextBox
        '
        Me.SueldoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SueldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Sueldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.SueldoTextBox.Location = New System.Drawing.Point(150, 374)
        Me.SueldoTextBox.Name = "SueldoTextBox"
        Me.SueldoTextBox.Size = New System.Drawing.Size(115, 20)
        Me.SueldoTextBox.TabIndex = 28
        '
        'EstadoCheckBox
        '
        Me.EstadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpleadosBindingSource, "Estado", True))
        Me.EstadoCheckBox.Location = New System.Drawing.Point(150, 400)
        Me.EstadoCheckBox.Name = "EstadoCheckBox"
        Me.EstadoCheckBox.Size = New System.Drawing.Size(115, 24)
        Me.EstadoCheckBox.TabIndex = 30
        Me.EstadoCheckBox.Text = "Pendiente"
        Me.EstadoCheckBox.UseVisualStyleBackColor = True
        '
        'ArsTextBox
        '
        Me.ArsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ArsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Ars", True))
        Me.ArsTextBox.Location = New System.Drawing.Point(150, 430)
        Me.ArsTextBox.Name = "ArsTextBox"
        Me.ArsTextBox.Size = New System.Drawing.Size(115, 20)
        Me.ArsTextBox.TabIndex = 32
        '
        'NumeroARSTextBox
        '
        Me.NumeroARSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroARSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "NumeroARS", True))
        Me.NumeroARSTextBox.Location = New System.Drawing.Point(150, 456)
        Me.NumeroARSTextBox.Name = "NumeroARSTextBox"
        Me.NumeroARSTextBox.Size = New System.Drawing.Size(199, 20)
        Me.NumeroARSTextBox.TabIndex = 34
        '
        'BancoNominaTextBox
        '
        Me.BancoNominaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BancoNominaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "BancoNomina", True))
        Me.BancoNominaTextBox.Location = New System.Drawing.Point(150, 482)
        Me.BancoNominaTextBox.Name = "BancoNominaTextBox"
        Me.BancoNominaTextBox.Size = New System.Drawing.Size(199, 20)
        Me.BancoNominaTextBox.TabIndex = 36
        '
        'NumeroCuentaBancoTextBox
        '
        Me.NumeroCuentaBancoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroCuentaBancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "NumeroCuentaBanco", True))
        Me.NumeroCuentaBancoTextBox.Location = New System.Drawing.Point(150, 508)
        Me.NumeroCuentaBancoTextBox.Name = "NumeroCuentaBancoTextBox"
        Me.NumeroCuentaBancoTextBox.Size = New System.Drawing.Size(199, 20)
        Me.NumeroCuentaBancoTextBox.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(469, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'BtnCargarFoto
        '
        Me.BtnCargarFoto.Location = New System.Drawing.Point(470, 217)
        Me.BtnCargarFoto.Name = "BtnCargarFoto"
        Me.BtnCargarFoto.Size = New System.Drawing.Size(104, 23)
        Me.BtnCargarFoto.TabIndex = 41
        Me.BtnCargarFoto.Text = "Cargar Fotografia"
        Me.BtnCargarFoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "\\antonio-dell\Users\Public\Carpeta Datos\Imajenes\Fotos Empleados"
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvanceEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.AvnceEmpleadosPagosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalendarioTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaPuestoTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.HorariosEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.NominasDetalleTableAdapter = Nothing
        Me.TableAdapterManager.NominasTableAdapter = Nothing
        Me.TableAdapterManager.PagasExtrasTableAdapter = Nothing
        Me.TableAdapterManager.RentaTableAdapter = Nothing
        Me.TableAdapterManager.SeguroSocialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FechaEntradaDateTimePicker
        '
        Me.FechaEntradaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "FechaEntrada", True))
        Me.FechaEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaEntradaDateTimePicker.Location = New System.Drawing.Point(319, 56)
        Me.FechaEntradaDateTimePicker.Name = "FechaEntradaDateTimePicker"
        Me.FechaEntradaDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.FechaEntradaDateTimePicker.TabIndex = 42
        Me.FechaEntradaDateTimePicker.Value = New Date(2017, 4, 10, 0, 0, 0, 0)
        '
        'FechaSalidaDateTimePicker
        '
        Me.FechaSalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "FechaSalida", True))
        Me.FechaSalidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaSalidaDateTimePicker.Location = New System.Drawing.Point(355, 217)
        Me.FechaSalidaDateTimePicker.Name = "FechaSalidaDateTimePicker"
        Me.FechaSalidaDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.FechaSalidaDateTimePicker.TabIndex = 44
        Me.FechaSalidaDateTimePicker.Value = New Date(2017, 4, 10, 0, 0, 0, 0)
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.DsEmpleados
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(150, 111)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaTextBox.TabIndex = 47
        '
        'DescripcionCategoriaComboBox
        '
        Me.DescripcionCategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "DescripcionCategoria", True))
        Me.DescripcionCategoriaComboBox.DataSource = Me.CategoriaBindingSource
        Me.DescripcionCategoriaComboBox.DisplayMember = "DescripcionCategoria"
        Me.DescripcionCategoriaComboBox.FormattingEnabled = True
        Me.DescripcionCategoriaComboBox.Location = New System.Drawing.Point(150, 111)
        Me.DescripcionCategoriaComboBox.Name = "DescripcionCategoriaComboBox"
        Me.DescripcionCategoriaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DescripcionCategoriaComboBox.TabIndex = 48
        Me.DescripcionCategoriaComboBox.ValueMember = "IdCategoria"
        '
        'CategoriaPuestoTableAdapter
        '
        Me.CategoriaPuestoTableAdapter.ClearBeforeFill = True
        '
        'CategoriaPuestoBindingSource
        '
        Me.CategoriaPuestoBindingSource.DataMember = "CategoriaPuesto"
        Me.CategoriaPuestoBindingSource.DataSource = Me.DsEmpleados
        '
        'PuestoComboBox
        '
        Me.PuestoComboBox.DataSource = Me.CategoriaPuestoBindingSource
        Me.PuestoComboBox.DisplayMember = "Puesto"
        Me.PuestoComboBox.FormattingEnabled = True
        Me.PuestoComboBox.Location = New System.Drawing.Point(330, 158)
        Me.PuestoComboBox.Name = "PuestoComboBox"
        Me.PuestoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PuestoComboBox.TabIndex = 50
        Me.PuestoComboBox.ValueMember = "IdPuestoEmpleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Puesto :"
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(328, 112)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PuestoTextBox.TabIndex = 52
        '
        'NominasDetalleBindingSource
        '
        Me.NominasDetalleBindingSource.DataMember = "NominasDetalle"
        Me.NominasDetalleBindingSource.DataSource = Me.DsEmpleados
        '
        'NominasDetalleTableAdapter
        '
        Me.NominasDetalleTableAdapter.ClearBeforeFill = True
        '
        'NominasDetalleDataGridView
        '
        Me.NominasDetalleDataGridView.AllowUserToAddRows = False
        Me.NominasDetalleDataGridView.AllowUserToDeleteRows = False
        Me.NominasDetalleDataGridView.AutoGenerateColumns = False
        Me.NominasDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NominasDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.NominasDetalleDataGridView.DataSource = Me.NominasDetalleBindingSource
        Me.NominasDetalleDataGridView.Location = New System.Drawing.Point(635, 45)
        Me.NominasDetalleDataGridView.Name = "NominasDetalleDataGridView"
        Me.NominasDetalleDataGridView.ReadOnly = True
        Me.NominasDetalleDataGridView.Size = New System.Drawing.Size(673, 268)
        Me.NominasDetalleDataGridView.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nomima"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nomima"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Sueldo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn9.HeaderText = "Sueldo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TotalNomina"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total Nomina"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 75
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TotalExtra1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn15.HeaderText = "Extra 35"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 75
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TotalExtra2"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn16.HeaderText = "Extra 50"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 75
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TotalExtra3"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn17.HeaderText = "Extra 100"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 75
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TotalGenerado"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn18.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 75
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SeguroAfiliado"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn19.HeaderText = "Seguro Af "
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 75
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SeguroEmpleador"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn20.HeaderText = "Seguro Em"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 75
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PensionAfiliado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn21.HeaderText = "Pension Af "
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 75
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PensionEmpleador"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn22.HeaderText = "Pension Em"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 75
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Renta"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn23.HeaderText = "Renta"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 75
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TotalLiquido"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn24.HeaderText = "Total Liquido"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 75
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TotalEmpresa"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle13.Format = "n2"
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn25.HeaderText = "Total Empresa"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 75
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(711, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Total Nomina"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(711, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Total 100"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(711, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Total 50"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(711, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Total 35"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(711, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Total Renta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(711, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Total ARS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(711, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Total Seguro"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(711, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Total Liquido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblLiquido
        '
        Me.LblLiquido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblLiquido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblLiquido.Location = New System.Drawing.Point(817, 499)
        Me.LblLiquido.Name = "LblLiquido"
        Me.LblLiquido.Size = New System.Drawing.Size(87, 23)
        Me.LblLiquido.TabIndex = 68
        Me.LblLiquido.Text = "Total Liquido"
        Me.LblLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSeguro
        '
        Me.LblSeguro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblSeguro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSeguro.Location = New System.Drawing.Point(817, 430)
        Me.LblSeguro.Name = "LblSeguro"
        Me.LblSeguro.Size = New System.Drawing.Size(87, 23)
        Me.LblSeguro.TabIndex = 67
        Me.LblSeguro.Text = "Total Seguro"
        Me.LblSeguro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblArs
        '
        Me.LblArs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblArs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblArs.Location = New System.Drawing.Point(817, 453)
        Me.LblArs.Name = "LblArs"
        Me.LblArs.Size = New System.Drawing.Size(87, 23)
        Me.LblArs.TabIndex = 66
        Me.LblArs.Text = "Total ARS"
        Me.LblArs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblRenta
        '
        Me.LblRenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblRenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRenta.Location = New System.Drawing.Point(817, 476)
        Me.LblRenta.Name = "LblRenta"
        Me.LblRenta.Size = New System.Drawing.Size(87, 23)
        Me.LblRenta.TabIndex = 65
        Me.LblRenta.Text = "Total Renta"
        Me.LblRenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl35
        '
        Me.Lbl35.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Lbl35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl35.Location = New System.Drawing.Point(817, 361)
        Me.Lbl35.Name = "Lbl35"
        Me.Lbl35.Size = New System.Drawing.Size(87, 23)
        Me.Lbl35.TabIndex = 64
        Me.Lbl35.Text = "Total 35"
        Me.Lbl35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl50
        '
        Me.Lbl50.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Lbl50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl50.Location = New System.Drawing.Point(817, 384)
        Me.Lbl50.Name = "Lbl50"
        Me.Lbl50.Size = New System.Drawing.Size(87, 23)
        Me.Lbl50.TabIndex = 63
        Me.Lbl50.Text = "Total 50"
        Me.Lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl100
        '
        Me.Lbl100.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Lbl100.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl100.Location = New System.Drawing.Point(817, 407)
        Me.Lbl100.Name = "Lbl100"
        Me.Lbl100.Size = New System.Drawing.Size(87, 23)
        Me.Lbl100.TabIndex = 62
        Me.Lbl100.Text = "Total 100"
        Me.Lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNomina
        '
        Me.LblNomina.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblNomina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNomina.Location = New System.Drawing.Point(817, 338)
        Me.LblNomina.Name = "LblNomina"
        Me.LblNomina.Size = New System.Drawing.Size(87, 23)
        Me.LblNomina.TabIndex = 61
        Me.LblNomina.Text = "Total Nomina"
        Me.LblNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSeguroEmpresa
        '
        Me.LblSeguroEmpresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblSeguroEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSeguroEmpresa.Location = New System.Drawing.Point(1082, 338)
        Me.LblSeguroEmpresa.Name = "LblSeguroEmpresa"
        Me.LblSeguroEmpresa.Size = New System.Drawing.Size(87, 23)
        Me.LblSeguroEmpresa.TabIndex = 74
        Me.LblSeguroEmpresa.Text = "Total Seguro"
        Me.LblSeguroEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblArsEmpresa
        '
        Me.LblArsEmpresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblArsEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblArsEmpresa.Location = New System.Drawing.Point(1082, 361)
        Me.LblArsEmpresa.Name = "LblArsEmpresa"
        Me.LblArsEmpresa.Size = New System.Drawing.Size(87, 23)
        Me.LblArsEmpresa.TabIndex = 73
        Me.LblArsEmpresa.Text = "Total ARS"
        Me.LblArsEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalEmpresa
        '
        Me.LblTotalEmpresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblTotalEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalEmpresa.Location = New System.Drawing.Point(1082, 384)
        Me.LblTotalEmpresa.Name = "LblTotalEmpresa"
        Me.LblTotalEmpresa.Size = New System.Drawing.Size(87, 23)
        Me.LblTotalEmpresa.TabIndex = 72
        Me.LblTotalEmpresa.Text = "Total Renta"
        Me.LblTotalEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(976, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Seguro Empresa"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(976, 361)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "ARS Empresa"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(976, 384)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Total Empresa"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SeguroAdicionalTextBox
        '
        Me.SeguroAdicionalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SeguroAdicional", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.SeguroAdicionalTextBox.Location = New System.Drawing.Point(150, 534)
        Me.SeguroAdicionalTextBox.Name = "SeguroAdicionalTextBox"
        Me.SeguroAdicionalTextBox.Size = New System.Drawing.Size(90, 20)
        Me.SeguroAdicionalTextBox.TabIndex = 75
        Me.SeguroAdicionalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(976, 439)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Label10"
        '
        'ContratoObraCheckBox
        '
        Me.ContratoObraCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmpleadosBindingSource, "ContratoObra", True))
        Me.ContratoObraCheckBox.Location = New System.Drawing.Point(145, 566)
        Me.ContratoObraCheckBox.Name = "ContratoObraCheckBox"
        Me.ContratoObraCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ContratoObraCheckBox.TabIndex = 77
        Me.ContratoObraCheckBox.UseVisualStyleBackColor = True
        '
        'EStadoCivilLabel
        '
        EStadoCivilLabel.AutoSize = True
        EStadoCivilLabel.Location = New System.Drawing.Point(305, 579)
        EStadoCivilLabel.Name = "EStadoCivilLabel"
        EStadoCivilLabel.Size = New System.Drawing.Size(67, 13)
        EStadoCivilLabel.TabIndex = 77
        EStadoCivilLabel.Text = "EStado Civil:"
        '
        'EStadoCivilTextBox
        '
        Me.EStadoCivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "EStadoCivil", True))
        Me.EStadoCivilTextBox.Location = New System.Drawing.Point(378, 576)
        Me.EStadoCivilTextBox.Name = "EStadoCivilTextBox"
        Me.EStadoCivilTextBox.Size = New System.Drawing.Size(239, 20)
        Me.EStadoCivilTextBox.TabIndex = 78
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 616)
        Me.Controls.Add(EStadoCivilLabel)
        Me.Controls.Add(Me.EStadoCivilTextBox)
        Me.Controls.Add(ContratoObraLabel)
        Me.Controls.Add(Me.ContratoObraCheckBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(SeguroAdicionalLabel)
        Me.Controls.Add(Me.SeguroAdicionalTextBox)
        Me.Controls.Add(Me.LblSeguroEmpresa)
        Me.Controls.Add(Me.LblArsEmpresa)
        Me.Controls.Add(Me.LblTotalEmpresa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblLiquido)
        Me.Controls.Add(Me.LblSeguro)
        Me.Controls.Add(Me.LblArs)
        Me.Controls.Add(Me.LblRenta)
        Me.Controls.Add(Me.Lbl35)
        Me.Controls.Add(Me.Lbl50)
        Me.Controls.Add(Me.Lbl100)
        Me.Controls.Add(Me.LblNomina)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NominasDetalleDataGridView)
        Me.Controls.Add(Me.PuestoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PuestoComboBox)
        Me.Controls.Add(Me.DescripcionCategoriaComboBox)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(FechaSalidaLabel)
        Me.Controls.Add(Me.FechaSalidaDateTimePicker)
        Me.Controls.Add(FechaEntradaLabel)
        Me.Controls.Add(Me.FechaEntradaDateTimePicker)
        Me.Controls.Add(Me.BtnCargarFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Apellido1Label)
        Me.Controls.Add(Me.Apellido1TextBox)
        Me.Controls.Add(Apellido2Label)
        Me.Controls.Add(Me.Apellido2TextBox)
        Me.Controls.Add(TelefonoCasaLabel)
        Me.Controls.Add(Me.TelefonoCasaTextBox)
        Me.Controls.Add(TelefonoCelularLabel)
        Me.Controls.Add(Me.TelefonoCelularTextBox)
        Me.Controls.Add(DirecciónLabel)
        Me.Controls.Add(Me.DirecciónTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(NotasLabel)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(FotografiaLabel)
        Me.Controls.Add(Me.FotografiaTextBox)
        Me.Controls.Add(SueldoLabel)
        Me.Controls.Add(Me.SueldoTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoCheckBox)
        Me.Controls.Add(ArsLabel)
        Me.Controls.Add(Me.ArsTextBox)
        Me.Controls.Add(NumeroARSLabel)
        Me.Controls.Add(Me.NumeroARSTextBox)
        Me.Controls.Add(BancoNominaLabel)
        Me.Controls.Add(Me.BancoNominaTextBox)
        Me.Controls.Add(NumeroCuentaBancoLabel)
        Me.Controls.Add(Me.NumeroCuentaBancoTextBox)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Name = "FrmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmEmpleados"
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaPuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsEmpleados As ModuloGestion.DsEmpleados
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdEmpleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoCasaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoCelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirecciónTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FotografiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SueldoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ArsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroARSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BancoNominaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroCuentaBancoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCargarFoto As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FechaEntradaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaSalidaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.CategoriaTableAdapter
    Friend WithEvents CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionCategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaPuestoTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.CategoriaPuestoTableAdapter
    Friend WithEvents CategoriaPuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PuestoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NominasDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasDetalleTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.NominasDetalleTableAdapter
    Friend WithEvents NominasDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblLiquido As System.Windows.Forms.Label
    Friend WithEvents LblSeguro As System.Windows.Forms.Label
    Friend WithEvents LblArs As System.Windows.Forms.Label
    Friend WithEvents LblRenta As System.Windows.Forms.Label
    Friend WithEvents Lbl35 As System.Windows.Forms.Label
    Friend WithEvents Lbl50 As System.Windows.Forms.Label
    Friend WithEvents Lbl100 As System.Windows.Forms.Label
    Friend WithEvents LblNomina As System.Windows.Forms.Label
    Friend WithEvents LblSeguroEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblArsEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblTotalEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SeguroAdicionalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ContratoObraCheckBox As CheckBox
    Friend WithEvents EStadoCivilTextBox As TextBox
End Class
