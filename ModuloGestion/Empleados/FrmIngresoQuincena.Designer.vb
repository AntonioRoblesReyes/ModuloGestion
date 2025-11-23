<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresoQuincena
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

    'Definición de controles
    Private WithEvents PanelQuincena As Panel
    Private WithEvents QuincenaComboBox As ComboBox
    Private WithEvents BtnEjecutar As Button

    Private WithEvents GroupBoxHorarios As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TextBox3 As TextBox
    Private WithEvents TextBox4 As TextBox

    Private WithEvents SplitContainerMain As SplitContainer
    Private WithEvents EmpleadosDataGridView As DataGridView
    Private WithEvents CalendarioDataGridView As DataGridView



    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim QuincenaLabel As System.Windows.Forms.Label
        Me.PanelQuincena = New System.Windows.Forms.Panel()
        Me.QuincenaComboBox = New System.Windows.Forms.ComboBox()
        Me.NominasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados = New ModuloGestion.DsEmpleados()
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.GroupBoxHorarios = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoCasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoCelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SueldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ArsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroARSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoNominaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCuentaBancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotografiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroAdicionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContratoObraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EStadoCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalendarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuincenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaSemanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter()
        Me.EmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter()
        Me.CalendarioTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.CalendarioTableAdapter()
        Me.HorariosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorariosEmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.HorariosEmpleadosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager()
        QuincenaLabel = New System.Windows.Forms.Label()
        Me.PanelQuincena.SuspendLayout()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxHorarios.SuspendLayout()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuincenaLabel
        '
        QuincenaLabel.Location = New System.Drawing.Point(10, 20)
        QuincenaLabel.Name = "QuincenaLabel"
        QuincenaLabel.Size = New System.Drawing.Size(73, 23)
        QuincenaLabel.TabIndex = 0
        QuincenaLabel.Text = "Quincena:"
        '
        'PanelQuincena
        '
        Me.PanelQuincena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelQuincena.Controls.Add(QuincenaLabel)
        Me.PanelQuincena.Controls.Add(Me.QuincenaComboBox)
        Me.PanelQuincena.Controls.Add(Me.BtnEjecutar)
        Me.PanelQuincena.Location = New System.Drawing.Point(20, 20)
        Me.PanelQuincena.Name = "PanelQuincena"
        Me.PanelQuincena.Size = New System.Drawing.Size(320, 100)
        Me.PanelQuincena.TabIndex = 0
        '
        'QuincenaComboBox
        '
        Me.QuincenaComboBox.DataSource = Me.NominasBindingSource
        Me.QuincenaComboBox.DisplayMember = "Quincena"
        Me.QuincenaComboBox.Location = New System.Drawing.Point(89, 17)
        Me.QuincenaComboBox.Name = "QuincenaComboBox"
        Me.QuincenaComboBox.Size = New System.Drawing.Size(150, 24)
        Me.QuincenaComboBox.TabIndex = 1
        Me.QuincenaComboBox.ValueMember = "Quincena"
        '
        'NominasBindingSource
        '
        Me.NominasBindingSource.DataMember = "Nominas"
        Me.NominasBindingSource.DataSource = Me.DsEmpleados
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "DsEmpleados"
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(80, 50)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 2
        Me.BtnEjecutar.Text = "Ejecutar"
        '
        'GroupBoxHorarios
        '
        Me.GroupBoxHorarios.Controls.Add(Me.Label1)
        Me.GroupBoxHorarios.Controls.Add(Me.TextBox1)
        Me.GroupBoxHorarios.Controls.Add(Me.Label2)
        Me.GroupBoxHorarios.Controls.Add(Me.TextBox2)
        Me.GroupBoxHorarios.Controls.Add(Me.Label3)
        Me.GroupBoxHorarios.Controls.Add(Me.TextBox3)
        Me.GroupBoxHorarios.Controls.Add(Me.Label4)
        Me.GroupBoxHorarios.Controls.Add(Me.TextBox4)
        Me.GroupBoxHorarios.Location = New System.Drawing.Point(360, 20)
        Me.GroupBoxHorarios.Name = "GroupBoxHorarios"
        Me.GroupBoxHorarios.Size = New System.Drawing.Size(320, 150)
        Me.GroupBoxHorarios.TabIndex = 1
        Me.GroupBoxHorarios.TabStop = False
        Me.GroupBoxHorarios.Text = "Horarios"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrada Mañana"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salida Mañana"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(150, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Entrada Tarde"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 90)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Salida Tarde"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(150, 120)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 7
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Location = New System.Drawing.Point(20, 200)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.EmpleadosDataGridView)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.CalendarioDataGridView)
        Me.SplitContainerMain.Size = New System.Drawing.Size(1260, 550)
        Me.SplitContainerMain.SplitterDistance = 420
        Me.SplitContainerMain.TabIndex = 2
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeight = 29
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleadoDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.PuestoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.Apellido1DataGridViewTextBoxColumn, Me.Apellido2DataGridViewTextBoxColumn, Me.TelefonoCasaDataGridViewTextBoxColumn, Me.TelefonoCelularDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.NotasDataGridViewTextBoxColumn, Me.SueldoDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn, Me.ArsDataGridViewTextBoxColumn, Me.NumeroARSDataGridViewTextBoxColumn, Me.BancoNominaDataGridViewTextBoxColumn, Me.NumeroCuentaBancoDataGridViewTextBoxColumn, Me.FechaEntradaDataGridViewTextBoxColumn, Me.FechaSalidaDataGridViewTextBoxColumn, Me.FotografiaDataGridViewTextBoxColumn, Me.SeguroAdicionalDataGridViewTextBoxColumn, Me.ContratoObraDataGridViewCheckBoxColumn, Me.EStadoCivilDataGridViewTextBoxColumn})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersWidth = 51
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(420, 550)
        Me.EmpleadosDataGridView.TabIndex = 0
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.Width = 125
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.Width = 125
        '
        'PuestoDataGridViewTextBoxColumn
        '
        Me.PuestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.HeaderText = "Puesto"
        Me.PuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PuestoDataGridViewTextBoxColumn.Name = "PuestoDataGridViewTextBoxColumn"
        Me.PuestoDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'Apellido1DataGridViewTextBoxColumn
        '
        Me.Apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1"
        Me.Apellido1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Apellido1DataGridViewTextBoxColumn.Name = "Apellido1DataGridViewTextBoxColumn"
        Me.Apellido1DataGridViewTextBoxColumn.Width = 125
        '
        'Apellido2DataGridViewTextBoxColumn
        '
        Me.Apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2"
        Me.Apellido2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Apellido2DataGridViewTextBoxColumn.Name = "Apellido2DataGridViewTextBoxColumn"
        Me.Apellido2DataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoCasaDataGridViewTextBoxColumn
        '
        Me.TelefonoCasaDataGridViewTextBoxColumn.DataPropertyName = "TelefonoCasa"
        Me.TelefonoCasaDataGridViewTextBoxColumn.HeaderText = "TelefonoCasa"
        Me.TelefonoCasaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoCasaDataGridViewTextBoxColumn.Name = "TelefonoCasaDataGridViewTextBoxColumn"
        Me.TelefonoCasaDataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoCelularDataGridViewTextBoxColumn
        '
        Me.TelefonoCelularDataGridViewTextBoxColumn.DataPropertyName = "TelefonoCelular"
        Me.TelefonoCelularDataGridViewTextBoxColumn.HeaderText = "TelefonoCelular"
        Me.TelefonoCelularDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoCelularDataGridViewTextBoxColumn.Name = "TelefonoCelularDataGridViewTextBoxColumn"
        Me.TelefonoCelularDataGridViewTextBoxColumn.Width = 125
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        Me.DirecciónDataGridViewTextBoxColumn.Width = 125
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.Width = 125
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.Width = 125
        '
        'NotasDataGridViewTextBoxColumn
        '
        Me.NotasDataGridViewTextBoxColumn.DataPropertyName = "Notas"
        Me.NotasDataGridViewTextBoxColumn.HeaderText = "Notas"
        Me.NotasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NotasDataGridViewTextBoxColumn.Name = "NotasDataGridViewTextBoxColumn"
        Me.NotasDataGridViewTextBoxColumn.Width = 125
        '
        'SueldoDataGridViewTextBoxColumn
        '
        Me.SueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo"
        Me.SueldoDataGridViewTextBoxColumn.HeaderText = "Sueldo"
        Me.SueldoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SueldoDataGridViewTextBoxColumn.Name = "SueldoDataGridViewTextBoxColumn"
        Me.SueldoDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        Me.EstadoDataGridViewCheckBoxColumn.Width = 125
        '
        'ArsDataGridViewTextBoxColumn
        '
        Me.ArsDataGridViewTextBoxColumn.DataPropertyName = "Ars"
        Me.ArsDataGridViewTextBoxColumn.HeaderText = "Ars"
        Me.ArsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ArsDataGridViewTextBoxColumn.Name = "ArsDataGridViewTextBoxColumn"
        Me.ArsDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroARSDataGridViewTextBoxColumn
        '
        Me.NumeroARSDataGridViewTextBoxColumn.DataPropertyName = "NumeroARS"
        Me.NumeroARSDataGridViewTextBoxColumn.HeaderText = "NumeroARS"
        Me.NumeroARSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroARSDataGridViewTextBoxColumn.Name = "NumeroARSDataGridViewTextBoxColumn"
        Me.NumeroARSDataGridViewTextBoxColumn.Width = 125
        '
        'BancoNominaDataGridViewTextBoxColumn
        '
        Me.BancoNominaDataGridViewTextBoxColumn.DataPropertyName = "BancoNomina"
        Me.BancoNominaDataGridViewTextBoxColumn.HeaderText = "BancoNomina"
        Me.BancoNominaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BancoNominaDataGridViewTextBoxColumn.Name = "BancoNominaDataGridViewTextBoxColumn"
        Me.BancoNominaDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroCuentaBancoDataGridViewTextBoxColumn
        '
        Me.NumeroCuentaBancoDataGridViewTextBoxColumn.DataPropertyName = "NumeroCuentaBanco"
        Me.NumeroCuentaBancoDataGridViewTextBoxColumn.HeaderText = "NumeroCuentaBanco"
        Me.NumeroCuentaBancoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroCuentaBancoDataGridViewTextBoxColumn.Name = "NumeroCuentaBancoDataGridViewTextBoxColumn"
        Me.NumeroCuentaBancoDataGridViewTextBoxColumn.Width = 125
        '
        'FechaEntradaDataGridViewTextBoxColumn
        '
        Me.FechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrada"
        Me.FechaEntradaDataGridViewTextBoxColumn.HeaderText = "FechaEntrada"
        Me.FechaEntradaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaEntradaDataGridViewTextBoxColumn.Name = "FechaEntradaDataGridViewTextBoxColumn"
        Me.FechaEntradaDataGridViewTextBoxColumn.Width = 125
        '
        'FechaSalidaDataGridViewTextBoxColumn
        '
        Me.FechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.HeaderText = "FechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaSalidaDataGridViewTextBoxColumn.Name = "FechaSalidaDataGridViewTextBoxColumn"
        Me.FechaSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'FotografiaDataGridViewTextBoxColumn
        '
        Me.FotografiaDataGridViewTextBoxColumn.DataPropertyName = "Fotografia"
        Me.FotografiaDataGridViewTextBoxColumn.HeaderText = "Fotografia"
        Me.FotografiaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FotografiaDataGridViewTextBoxColumn.Name = "FotografiaDataGridViewTextBoxColumn"
        Me.FotografiaDataGridViewTextBoxColumn.Width = 125
        '
        'SeguroAdicionalDataGridViewTextBoxColumn
        '
        Me.SeguroAdicionalDataGridViewTextBoxColumn.DataPropertyName = "SeguroAdicional"
        Me.SeguroAdicionalDataGridViewTextBoxColumn.HeaderText = "SeguroAdicional"
        Me.SeguroAdicionalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SeguroAdicionalDataGridViewTextBoxColumn.Name = "SeguroAdicionalDataGridViewTextBoxColumn"
        Me.SeguroAdicionalDataGridViewTextBoxColumn.Width = 125
        '
        'ContratoObraDataGridViewCheckBoxColumn
        '
        Me.ContratoObraDataGridViewCheckBoxColumn.DataPropertyName = "ContratoObra"
        Me.ContratoObraDataGridViewCheckBoxColumn.HeaderText = "ContratoObra"
        Me.ContratoObraDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ContratoObraDataGridViewCheckBoxColumn.Name = "ContratoObraDataGridViewCheckBoxColumn"
        Me.ContratoObraDataGridViewCheckBoxColumn.Width = 125
        '
        'EStadoCivilDataGridViewTextBoxColumn
        '
        Me.EStadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EStadoCivil"
        Me.EStadoCivilDataGridViewTextBoxColumn.HeaderText = "EStadoCivil"
        Me.EStadoCivilDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EStadoCivilDataGridViewTextBoxColumn.Name = "EStadoCivilDataGridViewTextBoxColumn"
        Me.EStadoCivilDataGridViewTextBoxColumn.Width = 125
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'CalendarioDataGridView
        '
        Me.CalendarioDataGridView.AutoGenerateColumns = False
        Me.CalendarioDataGridView.ColumnHeadersHeight = 29
        Me.CalendarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFechaDataGridViewTextBoxColumn, Me.QuincenaDataGridViewTextBoxColumn, Me.DiaSemanaDataGridViewTextBoxColumn, Me.TipoDiaDataGridViewTextBoxColumn, Me.HorasDataGridViewTextBoxColumn})
        Me.CalendarioDataGridView.DataSource = Me.CalendarioBindingSource
        Me.CalendarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalendarioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CalendarioDataGridView.Name = "CalendarioDataGridView"
        Me.CalendarioDataGridView.RowHeadersWidth = 51
        Me.CalendarioDataGridView.Size = New System.Drawing.Size(836, 550)
        Me.CalendarioDataGridView.TabIndex = 0
        '
        'IdFechaDataGridViewTextBoxColumn
        '
        Me.IdFechaDataGridViewTextBoxColumn.DataPropertyName = "IdFecha"
        Me.IdFechaDataGridViewTextBoxColumn.HeaderText = "IdFecha"
        Me.IdFechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdFechaDataGridViewTextBoxColumn.Name = "IdFechaDataGridViewTextBoxColumn"
        Me.IdFechaDataGridViewTextBoxColumn.Width = 125
        '
        'QuincenaDataGridViewTextBoxColumn
        '
        Me.QuincenaDataGridViewTextBoxColumn.DataPropertyName = "Quincena"
        Me.QuincenaDataGridViewTextBoxColumn.HeaderText = "Quincena"
        Me.QuincenaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuincenaDataGridViewTextBoxColumn.Name = "QuincenaDataGridViewTextBoxColumn"
        Me.QuincenaDataGridViewTextBoxColumn.Width = 125
        '
        'DiaSemanaDataGridViewTextBoxColumn
        '
        Me.DiaSemanaDataGridViewTextBoxColumn.DataPropertyName = "DiaSemana"
        Me.DiaSemanaDataGridViewTextBoxColumn.HeaderText = "DiaSemana"
        Me.DiaSemanaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiaSemanaDataGridViewTextBoxColumn.Name = "DiaSemanaDataGridViewTextBoxColumn"
        Me.DiaSemanaDataGridViewTextBoxColumn.Width = 125
        '
        'TipoDiaDataGridViewTextBoxColumn
        '
        Me.TipoDiaDataGridViewTextBoxColumn.DataPropertyName = "TipoDia"
        Me.TipoDiaDataGridViewTextBoxColumn.HeaderText = "TipoDia"
        Me.TipoDiaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoDiaDataGridViewTextBoxColumn.Name = "TipoDiaDataGridViewTextBoxColumn"
        Me.TipoDiaDataGridViewTextBoxColumn.Width = 125
        '
        'HorasDataGridViewTextBoxColumn
        '
        Me.HorasDataGridViewTextBoxColumn.DataPropertyName = "Horas"
        Me.HorasDataGridViewTextBoxColumn.HeaderText = "Horas"
        Me.HorasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HorasDataGridViewTextBoxColumn.Name = "HorasDataGridViewTextBoxColumn"
        Me.HorasDataGridViewTextBoxColumn.Width = 125
        '
        'CalendarioBindingSource
        '
        Me.CalendarioBindingSource.DataMember = "Calendario"
        Me.CalendarioBindingSource.DataSource = Me.DsEmpleados
        '
        'NominasTableAdapter
        '
        Me.NominasTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'CalendarioTableAdapter
        '
        Me.CalendarioTableAdapter.ClearBeforeFill = True
        '
        'HorariosEmpleadosBindingSource
        '
        Me.HorariosEmpleadosBindingSource.DataMember = "HorariosEmpleados"
        Me.HorariosEmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'HorariosEmpleadosTableAdapter
        '
        Me.HorariosEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvanceEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.AvnceEmpleadosPagosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalendarioTableAdapter = Me.CalendarioTableAdapter
        Me.TableAdapterManager.CategoriaPuestoTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.HorariosEmpleadosTableAdapter = Me.HorariosEmpleadosTableAdapter
        Me.TableAdapterManager.NominasDetalleTableAdapter = Nothing
        Me.TableAdapterManager.NominasTableAdapter = Me.NominasTableAdapter
        Me.TableAdapterManager.PagasExtrasTableAdapter = Nothing
        Me.TableAdapterManager.RentaTableAdapter = Nothing
        Me.TableAdapterManager.SeguroSocialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmIngresoQuincena
        '
        Me.ClientSize = New System.Drawing.Size(1304, 778)
        Me.Controls.Add(Me.PanelQuincena)
        Me.Controls.Add(Me.GroupBoxHorarios)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmIngresoQuincena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Quincena"
        Me.PanelQuincena.ResumeLayout(False)
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxHorarios.ResumeLayout(False)
        Me.GroupBoxHorarios.PerformLayout()
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsEmpleados As DsEmpleados
    Friend WithEvents NominasBindingSource As BindingSource
    Friend WithEvents NominasTableAdapter As DsEmpleadosTableAdapters.NominasTableAdapter
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As DsEmpleadosTableAdapters.EmpleadosTableAdapter
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Apellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoCasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoCelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SueldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ArsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroARSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoNominaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroCuentaBancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotografiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeguroAdicionalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContratoObraDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EStadoCivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalendarioBindingSource As BindingSource
    Friend WithEvents CalendarioTableAdapter As DsEmpleadosTableAdapters.CalendarioTableAdapter
    Friend WithEvents IdFechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuincenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaSemanaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorariosEmpleadosBindingSource As BindingSource
    Friend WithEvents HorariosEmpleadosTableAdapter As DsEmpleadosTableAdapters.HorariosEmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As DsEmpleadosTableAdapters.TableAdapterManager
End Class
