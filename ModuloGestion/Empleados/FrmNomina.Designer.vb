<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNomina
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
        Dim QuincenaLabel As System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados = New ModuloGestion.DsEmpleados()
        Me.SeguroSocialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NominasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentaTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.RentaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager()
        Me.SeguroSocialTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.SeguroSocialTableAdapter()
        Me.NominasTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HorariosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorariosEmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.HorariosEmpleadosTableAdapter()
        Me.NominasDetalleTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.NominasDetalleTableAdapter()
        Me.NominasDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NominasDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalLiquido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasExtras3H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasExtras2H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasExtras1H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasNominaH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHorasH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorariosEmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AvanceEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvanceEmpleadosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.AvanceEmpleadosTableAdapter()
        Me.AvanceEmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalendarioTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.CalendarioTableAdapter()
        Me.CalendarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnArchivoBanco = New System.Windows.Forms.Button()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvnceEmpleadosPagosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuincenaAdescontarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AplicadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AvnceEmpleadosPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AvnceEmpleadosPagosTableAdapter = New ModuloGestion.DsEmpleadosTableAdapters.AvnceEmpleadosPagosTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NominasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        QuincenaLabel = New System.Windows.Forms.Label()
        CType(Me.RentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguroSocialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorariosEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AvanceEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvanceEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvnceEmpleadosPagosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvnceEmpleadosPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuincenaLabel
        '
        QuincenaLabel.AutoSize = True
        QuincenaLabel.Location = New System.Drawing.Point(288, 11)
        QuincenaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuincenaLabel.Name = "QuincenaLabel"
        QuincenaLabel.Size = New System.Drawing.Size(73, 17)
        QuincenaLabel.TabIndex = 10
        QuincenaLabel.Text = "Quincena:"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdAporte"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdAporte"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SeguroAfiliado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SeguroAfiliado"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SeguroEmpleador"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SeguroEmpleador"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PensionAfiliado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PensionAfiliado"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PensionEmpleador"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PensionEmpleador"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'RentaBindingSource
        '
        Me.RentaBindingSource.DataMember = "Renta"
        Me.RentaBindingSource.DataSource = Me.DsEmpleados
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "DsEmpleados"
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeguroSocialBindingSource
        '
        Me.SeguroSocialBindingSource.DataMember = "SeguroSocial"
        Me.SeguroSocialBindingSource.DataSource = Me.DsEmpleados
        '
        'NominasBindingSource
        '
        Me.NominasBindingSource.DataMember = "Nominas"
        Me.NominasBindingSource.DataSource = Me.DsEmpleados
        '
        'RentaTableAdapter
        '
        Me.RentaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvanceEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.AvnceEmpleadosPagosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalendarioTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaPuestoTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.HorariosEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.NominasDetalleTableAdapter = Nothing
        Me.TableAdapterManager.NominasTableAdapter = Nothing
        Me.TableAdapterManager.PagasExtrasTableAdapter = Nothing
        Me.TableAdapterManager.RentaTableAdapter = Me.RentaTableAdapter
        Me.TableAdapterManager.SeguroSocialTableAdapter = Me.SeguroSocialTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SeguroSocialTableAdapter
        '
        Me.SeguroSocialTableAdapter.ClearBeforeFill = True
        '
        'NominasTableAdapter
        '
        Me.NominasTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.NominasBindingSource
        Me.ComboBox1.DisplayMember = "Quincena"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(387, 7)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.ValueMember = "Quincena"
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
        'NominasDetalleTableAdapter
        '
        Me.NominasDetalleTableAdapter.ClearBeforeFill = True
        '
        'NominasDetalleBindingSource
        '
        Me.NominasDetalleBindingSource.DataMember = "NominasDetalle"
        Me.NominasDetalleBindingSource.DataSource = Me.DsEmpleados
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(387, 41)
        Me.BtnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(139, 28)
        Me.BtnImprimir.TabIndex = 14
        Me.BtnImprimir.Text = "Imprimir Recibos"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 76)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Imprimir Nomina"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NominasDetalleDataGridView
        '
        Me.NominasDetalleDataGridView.AllowUserToAddRows = False
        Me.NominasDetalleDataGridView.AllowUserToDeleteRows = False
        Me.NominasDetalleDataGridView.AutoGenerateColumns = False
        Me.NominasDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NominasDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.TotalHoras, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.TotalLiquido})
        Me.NominasDetalleDataGridView.DataSource = Me.NominasDetalleBindingSource
        Me.NominasDetalleDataGridView.Location = New System.Drawing.Point(39, 129)
        Me.NominasDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.NominasDetalleDataGridView.Name = "NominasDetalleDataGridView"
        Me.NominasDetalleDataGridView.ReadOnly = True
        Me.NominasDetalleDataGridView.RowHeadersWidth = 51
        Me.NominasDetalleDataGridView.Size = New System.Drawing.Size(1508, 743)
        Me.NominasDetalleDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "Nomima"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Nomima"
        Me.DataGridViewTextBoxColumn52.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Width = 125
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "IdNonina"
        Me.DataGridViewTextBoxColumn53.HeaderText = "IdNonina"
        Me.DataGridViewTextBoxColumn53.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 125
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn54.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Width = 125
        '
        'TotalHoras
        '
        Me.TotalHoras.DataPropertyName = "TotalHoras"
        Me.TotalHoras.HeaderText = "TotalHoras"
        Me.TotalHoras.MinimumWidth = 6
        Me.TotalHoras.Name = "TotalHoras"
        Me.TotalHoras.ReadOnly = True
        Me.TotalHoras.Width = 125
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "HorasNomina"
        Me.DataGridViewTextBoxColumn56.HeaderText = "HorasNomina"
        Me.DataGridViewTextBoxColumn56.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Width = 125
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "HorasExtras1"
        Me.DataGridViewTextBoxColumn57.HeaderText = "HorasExtras1"
        Me.DataGridViewTextBoxColumn57.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Width = 125
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "HorasExtras2"
        Me.DataGridViewTextBoxColumn58.HeaderText = "HorasExtras2"
        Me.DataGridViewTextBoxColumn58.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 125
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "HorasExtras3"
        Me.DataGridViewTextBoxColumn59.HeaderText = "HorasExtras3"
        Me.DataGridViewTextBoxColumn59.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        Me.DataGridViewTextBoxColumn59.Width = 125
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Sueldo"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Sueldo"
        Me.DataGridViewTextBoxColumn60.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        Me.DataGridViewTextBoxColumn60.Width = 125
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "PrecioHorasNomina"
        Me.DataGridViewTextBoxColumn61.HeaderText = "PrecioHorasNomina"
        Me.DataGridViewTextBoxColumn61.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        Me.DataGridViewTextBoxColumn61.Width = 125
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "PrecioExtras1"
        Me.DataGridViewTextBoxColumn62.HeaderText = "PrecioExtras1"
        Me.DataGridViewTextBoxColumn62.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        Me.DataGridViewTextBoxColumn62.Width = 125
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "PrecioExtras2"
        Me.DataGridViewTextBoxColumn63.HeaderText = "PrecioExtras2"
        Me.DataGridViewTextBoxColumn63.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Width = 125
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "PrecioExtra3"
        Me.DataGridViewTextBoxColumn64.HeaderText = "PrecioExtra3"
        Me.DataGridViewTextBoxColumn64.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Width = 125
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "TotalNomina"
        Me.DataGridViewTextBoxColumn65.HeaderText = "TotalNomina"
        Me.DataGridViewTextBoxColumn65.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        Me.DataGridViewTextBoxColumn65.Width = 125
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "TotalExtra1"
        Me.DataGridViewTextBoxColumn66.HeaderText = "TotalExtra1"
        Me.DataGridViewTextBoxColumn66.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        Me.DataGridViewTextBoxColumn66.Width = 125
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "TotalExtra2"
        Me.DataGridViewTextBoxColumn67.HeaderText = "TotalExtra2"
        Me.DataGridViewTextBoxColumn67.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        Me.DataGridViewTextBoxColumn67.Width = 125
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "TotalExtra3"
        Me.DataGridViewTextBoxColumn68.HeaderText = "TotalExtra3"
        Me.DataGridViewTextBoxColumn68.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.ReadOnly = True
        Me.DataGridViewTextBoxColumn68.Width = 125
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "TotalGenerado"
        Me.DataGridViewTextBoxColumn69.HeaderText = "TotalGenerado"
        Me.DataGridViewTextBoxColumn69.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        Me.DataGridViewTextBoxColumn69.ReadOnly = True
        Me.DataGridViewTextBoxColumn69.Width = 125
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "SeguroAfiliado"
        Me.DataGridViewTextBoxColumn70.HeaderText = "SeguroAfiliado"
        Me.DataGridViewTextBoxColumn70.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.ReadOnly = True
        Me.DataGridViewTextBoxColumn70.Width = 125
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "SeguroEmpleador"
        Me.DataGridViewTextBoxColumn71.HeaderText = "SeguroEmpleador"
        Me.DataGridViewTextBoxColumn71.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.ReadOnly = True
        Me.DataGridViewTextBoxColumn71.Width = 125
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "PensionAfiliado"
        Me.DataGridViewTextBoxColumn72.HeaderText = "PensionAfiliado"
        Me.DataGridViewTextBoxColumn72.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.ReadOnly = True
        Me.DataGridViewTextBoxColumn72.Width = 125
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "PensionEmpleador"
        Me.DataGridViewTextBoxColumn73.HeaderText = "PensionEmpleador"
        Me.DataGridViewTextBoxColumn73.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.ReadOnly = True
        Me.DataGridViewTextBoxColumn73.Width = 125
        '
        'TotalLiquido
        '
        Me.TotalLiquido.DataPropertyName = "TotalLiquido"
        Me.TotalLiquido.HeaderText = "TotalLiquido"
        Me.TotalLiquido.MinimumWidth = 6
        Me.TotalLiquido.Name = "TotalLiquido"
        Me.TotalLiquido.ReadOnly = True
        Me.TotalLiquido.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Quincena"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Quincena"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Obsevaciones"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Obsevaciones"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'HorasExtras3H
        '
        Me.HorasExtras3H.DataPropertyName = "HorasExtras3"
        Me.HorasExtras3H.HeaderText = "HorasExtras3"
        Me.HorasExtras3H.MinimumWidth = 6
        Me.HorasExtras3H.Name = "HorasExtras3H"
        Me.HorasExtras3H.ReadOnly = True
        Me.HorasExtras3H.Width = 125
        '
        'HorasExtras2H
        '
        Me.HorasExtras2H.DataPropertyName = "HorasExtras2"
        Me.HorasExtras2H.HeaderText = "HorasExtras2"
        Me.HorasExtras2H.MinimumWidth = 6
        Me.HorasExtras2H.Name = "HorasExtras2H"
        Me.HorasExtras2H.ReadOnly = True
        Me.HorasExtras2H.Width = 125
        '
        'HorasExtras1H
        '
        Me.HorasExtras1H.DataPropertyName = "HorasExtras1"
        Me.HorasExtras1H.HeaderText = "HorasExtras1"
        Me.HorasExtras1H.MinimumWidth = 6
        Me.HorasExtras1H.Name = "HorasExtras1H"
        Me.HorasExtras1H.ReadOnly = True
        Me.HorasExtras1H.Width = 125
        '
        'HorasNominaH
        '
        Me.HorasNominaH.DataPropertyName = "HorasNomina"
        Me.HorasNominaH.HeaderText = "HorasNomina"
        Me.HorasNominaH.MinimumWidth = 6
        Me.HorasNominaH.Name = "HorasNominaH"
        Me.HorasNominaH.ReadOnly = True
        Me.HorasNominaH.Width = 125
        '
        'TotalHorasH
        '
        Me.TotalHorasH.DataPropertyName = "TotalHoras"
        Me.TotalHorasH.HeaderText = "TotalHoras"
        Me.TotalHorasH.MinimumWidth = 6
        Me.TotalHorasH.Name = "TotalHorasH"
        Me.TotalHorasH.ReadOnly = True
        Me.TotalHorasH.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TipoDia"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TipoDia"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "SalidaTarde"
        Me.DataGridViewTextBoxColumn22.HeaderText = "SalidaTarde"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "EntradaTarde"
        Me.DataGridViewTextBoxColumn20.HeaderText = "EntradaTarde"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SalidaMañana"
        Me.DataGridViewTextBoxColumn19.HeaderText = "SalidaMañana"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "EntradaMañana"
        Me.DataGridViewTextBoxColumn18.HeaderText = "EntradaMañana"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IdNomina"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IdNomina"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'HorariosEmpleadosDataGridView
        '
        Me.HorariosEmpleadosDataGridView.AllowUserToAddRows = False
        Me.HorariosEmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.HorariosEmpleadosDataGridView.AutoGenerateColumns = False
        Me.HorariosEmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HorariosEmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.TotalHorasH, Me.HorasNominaH, Me.HorasExtras1H, Me.HorasExtras2H, Me.HorasExtras3H, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.HorariosEmpleadosDataGridView.DataSource = Me.HorariosEmpleadosBindingSource
        Me.HorariosEmpleadosDataGridView.Location = New System.Drawing.Point(516, 129)
        Me.HorariosEmpleadosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.HorariosEmpleadosDataGridView.Name = "HorariosEmpleadosDataGridView"
        Me.HorariosEmpleadosDataGridView.ReadOnly = True
        Me.HorariosEmpleadosDataGridView.RowHeadersWidth = 51
        Me.HorariosEmpleadosDataGridView.Size = New System.Drawing.Size(559, 180)
        Me.HorariosEmpleadosDataGridView.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(585, 48)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Generar Nomina"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(23, 23)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 21)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Abierta"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(144, 85)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado Nomina"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(23, 52)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 21)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cerrada"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1107, 7)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 28)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Cerrar Quincena"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(585, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
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
        'AvanceEmpleadosDataGridView
        '
        Me.AvanceEmpleadosDataGridView.AllowUserToAddRows = False
        Me.AvanceEmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.AvanceEmpleadosDataGridView.AutoGenerateColumns = False
        Me.AvanceEmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvanceEmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.AvanceEmpleadosDataGridView.DataSource = Me.AvanceEmpleadosBindingSource
        Me.AvanceEmpleadosDataGridView.Location = New System.Drawing.Point(472, 348)
        Me.AvanceEmpleadosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.AvanceEmpleadosDataGridView.Name = "AvanceEmpleadosDataGridView"
        Me.AvanceEmpleadosDataGridView.ReadOnly = True
        Me.AvanceEmpleadosDataGridView.RowHeadersWidth = 51
        Me.AvanceEmpleadosDataGridView.Size = New System.Drawing.Size(559, 271)
        Me.AvanceEmpleadosDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdAvanceEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdAvanceEmpleado"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaAVance"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaAVance"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QuincenaAdescontar"
        Me.DataGridViewTextBoxColumn4.HeaderText = "QuincenaAdescontar"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TotalAvance"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TotalAvance"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cobrado"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cobrado"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cheque"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cheque"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'CalendarioBindingSource
        '
        Me.CalendarioBindingSource.DataMember = "Calendario"
        Me.CalendarioBindingSource.DataSource = Me.DsEmpleados
        '
        'CalendarioTableAdapter
        '
        Me.CalendarioTableAdapter.ClearBeforeFill = True
        '
        'CalendarioDataGridView
        '
        Me.CalendarioDataGridView.AllowUserToAddRows = False
        Me.CalendarioDataGridView.AllowUserToDeleteRows = False
        Me.CalendarioDataGridView.AutoGenerateColumns = False
        Me.CalendarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CalendarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn24, Me.Horas})
        Me.CalendarioDataGridView.DataSource = Me.CalendarioBindingSource
        Me.CalendarioDataGridView.Location = New System.Drawing.Point(39, 129)
        Me.CalendarioDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CalendarioDataGridView.Name = "CalendarioDataGridView"
        Me.CalendarioDataGridView.ReadOnly = True
        Me.CalendarioDataGridView.RowHeadersWidth = 51
        Me.CalendarioDataGridView.Size = New System.Drawing.Size(469, 180)
        Me.CalendarioDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IdFecha"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IdFecha"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Quincena"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Quincena"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DiaSemana"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DiaSemana"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TipoDia"
        Me.DataGridViewTextBoxColumn24.HeaderText = "TipoDia"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'Horas
        '
        Me.Horas.DataPropertyName = "Horas"
        Me.Horas.HeaderText = "Horas"
        Me.Horas.MinimumWidth = 6
        Me.Horas.Name = "Horas"
        Me.Horas.ReadOnly = True
        Me.Horas.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 22
        '
        'BtnArchivoBanco
        '
        Me.BtnArchivoBanco.Location = New System.Drawing.Point(943, 7)
        Me.BtnArchivoBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnArchivoBanco.Name = "BtnArchivoBanco"
        Me.BtnArchivoBanco.Size = New System.Drawing.Size(156, 28)
        Me.BtnArchivoBanco.TabIndex = 23
        Me.BtnArchivoBanco.Text = "Crear Archivo Banco"
        Me.BtnArchivoBanco.UseVisualStyleBackColor = True
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(1088, 129)
        Me.EmpleadosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersWidth = 51
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(459, 180)
        Me.EmpleadosDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn25.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Puesto"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Puesto"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Apellido1"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Apellido1"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Apellido2"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Apellido2"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TelefonoCasa"
        Me.DataGridViewTextBoxColumn34.HeaderText = "TelefonoCasa"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "TelefonoCelular"
        Me.DataGridViewTextBoxColumn35.HeaderText = "TelefonoCelular"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Dirección"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Provincia"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 125
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Notas"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Notas"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 125
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Sueldo"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Sueldo"
        Me.DataGridViewTextBoxColumn40.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Estado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Ars"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Ars"
        Me.DataGridViewTextBoxColumn41.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 125
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "NumeroARS"
        Me.DataGridViewTextBoxColumn42.HeaderText = "NumeroARS"
        Me.DataGridViewTextBoxColumn42.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 125
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "BancoNomina"
        Me.DataGridViewTextBoxColumn43.HeaderText = "BancoNomina"
        Me.DataGridViewTextBoxColumn43.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 125
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "NumeroCuentaBanco"
        Me.DataGridViewTextBoxColumn44.HeaderText = "NumeroCuentaBanco"
        Me.DataGridViewTextBoxColumn44.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 125
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "FechaEntrada"
        Me.DataGridViewTextBoxColumn45.HeaderText = "FechaEntrada"
        Me.DataGridViewTextBoxColumn45.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 125
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "FechaSalida"
        Me.DataGridViewTextBoxColumn46.HeaderText = "FechaSalida"
        Me.DataGridViewTextBoxColumn46.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 125
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Fotografia"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Fotografia"
        Me.DataGridViewTextBoxColumn47.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 125
        '
        'AvnceEmpleadosPagosDataGridView
        '
        Me.AvnceEmpleadosPagosDataGridView.AllowUserToAddRows = False
        Me.AvnceEmpleadosPagosDataGridView.AllowUserToDeleteRows = False
        Me.AvnceEmpleadosPagosDataGridView.AutoGenerateColumns = False
        Me.AvnceEmpleadosPagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvnceEmpleadosPagosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn, Me.IdAvanceEmpleadoDataGridViewTextBoxColumn, Me.QuincenaAdescontarDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.AplicadoDataGridViewCheckBoxColumn})
        Me.AvnceEmpleadosPagosDataGridView.DataSource = Me.AvnceEmpleadosPagosBindingSource
        Me.AvnceEmpleadosPagosDataGridView.Location = New System.Drawing.Point(1083, 348)
        Me.AvnceEmpleadosPagosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.AvnceEmpleadosPagosDataGridView.Name = "AvnceEmpleadosPagosDataGridView"
        Me.AvnceEmpleadosPagosDataGridView.ReadOnly = True
        Me.AvnceEmpleadosPagosDataGridView.RowHeadersWidth = 51
        Me.AvnceEmpleadosPagosDataGridView.Size = New System.Drawing.Size(464, 271)
        Me.AvnceEmpleadosPagosDataGridView.TabIndex = 23
        '
        'IdPagoAvanceEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdPagoAvanceEmpleado"
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdPagoAvanceEmpleado"
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.Name = "IdPagoAvanceEmpleadoDataGridViewTextBoxColumn"
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPagoAvanceEmpleadoDataGridViewTextBoxColumn.Width = 125
        '
        'IdAvanceEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdAvanceEmpleado"
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdAvanceEmpleado"
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.Name = "IdAvanceEmpleadoDataGridViewTextBoxColumn"
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAvanceEmpleadoDataGridViewTextBoxColumn.Width = 125
        '
        'QuincenaAdescontarDataGridViewTextBoxColumn
        '
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.DataPropertyName = "QuincenaAdescontar"
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.HeaderText = "QuincenaAdescontar"
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.Name = "QuincenaAdescontarDataGridViewTextBoxColumn"
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuincenaAdescontarDataGridViewTextBoxColumn.Width = 125
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 125
        '
        'AplicadoDataGridViewCheckBoxColumn
        '
        Me.AplicadoDataGridViewCheckBoxColumn.DataPropertyName = "Aplicado"
        Me.AplicadoDataGridViewCheckBoxColumn.HeaderText = "Aplicado"
        Me.AplicadoDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.AplicadoDataGridViewCheckBoxColumn.Name = "AplicadoDataGridViewCheckBoxColumn"
        Me.AplicadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AplicadoDataGridViewCheckBoxColumn.Width = 125
        '
        'AvnceEmpleadosPagosBindingSource
        '
        Me.AvnceEmpleadosPagosBindingSource.DataMember = "AvnceEmpleadosPagos"
        Me.AvnceEmpleadosPagosBindingSource.DataSource = Me.DsEmpleados
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(823, 318)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Label3"
        '
        'AvnceEmpleadosPagosTableAdapter
        '
        Me.AvnceEmpleadosPagosTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(943, 41)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Imprimir TSS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NominasDataGridView
        '
        Me.NominasDataGridView.AllowUserToAddRows = False
        Me.NominasDataGridView.AllowUserToDeleteRows = False
        Me.NominasDataGridView.AutoGenerateColumns = False
        Me.NominasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NominasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn48, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51})
        Me.NominasDataGridView.DataSource = Me.NominasBindingSource
        Me.NominasDataGridView.Location = New System.Drawing.Point(39, 348)
        Me.NominasDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.NominasDataGridView.Name = "NominasDataGridView"
        Me.NominasDataGridView.ReadOnly = True
        Me.NominasDataGridView.RowHeadersWidth = 51
        Me.NominasDataGridView.Size = New System.Drawing.Size(400, 128)
        Me.NominasDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "Quincena"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Quincena"
        Me.DataGridViewTextBoxColumn48.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Width = 125
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Cerrada"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Cerrada"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "Empieza"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Empieza"
        Me.DataGridViewTextBoxColumn49.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Width = 125
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "Termina"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Termina"
        Me.DataGridViewTextBoxColumn50.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Width = 125
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "Mes"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Mes"
        Me.DataGridViewTextBoxColumn51.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Width = 125
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1225, 69)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 28)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Imprimir Recibos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1424, 10)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 22)
        Me.TextBox1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1381, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Año"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(1424, 47)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 21)
        Me.RadioButton3.TabIndex = 31
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Bonos"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(1424, 101)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(102, 21)
        Me.RadioButton4.TabIndex = 32
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Vacaciones"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(1424, 76)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(93, 21)
        Me.RadioButton5.TabIndex = 33
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Salario 13"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Horas Laborables"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 60)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Dias Festivos"
        '
        'FrmNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1565, 916)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NominasDetalleDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AvnceEmpleadosPagosDataGridView)
        Me.Controls.Add(Me.BtnArchivoBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.HorariosEmpleadosDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(QuincenaLabel)
        Me.Controls.Add(Me.AvanceEmpleadosDataGridView)
        Me.Controls.Add(Me.CalendarioDataGridView)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.NominasDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNomina"
        CType(Me.RentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguroSocialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorariosEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AvanceEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvanceEmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvnceEmpleadosPagosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvnceEmpleadosPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsEmpleados As ModuloGestion.DsEmpleados
    Friend WithEvents RentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentaTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.RentaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpleadosTableAdapters.TableAdapterManager
    Friend WithEvents SeguroSocialTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.SeguroSocialTableAdapter
    Friend WithEvents SeguroSocialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominasTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.NominasTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.EmpleadosTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents HorariosEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HorariosEmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.HorariosEmpleadosTableAdapter
    Friend WithEvents NominasDetalleTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.NominasDetalleTableAdapter
    Friend WithEvents NominasDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NominasDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasExtras3H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasExtras2H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasExtras1H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorasNominaH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHorasH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorariosEmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AvanceEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvanceEmpleadosTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.AvanceEmpleadosTableAdapter
    Friend WithEvents AvanceEmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalendarioTableAdapter As ModuloGestion.DsEmpleadosTableAdapters.CalendarioTableAdapter
    Friend WithEvents CalendarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Horas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnArchivoBanco As System.Windows.Forms.Button
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHoras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalLiquido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvnceEmpleadosPagosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AvnceEmpleadosPagosBindingSource As BindingSource
    Friend WithEvents AvnceEmpleadosPagosTableAdapter As DsEmpleadosTableAdapters.AvnceEmpleadosPagosTableAdapter
    Friend WithEvents IdPagoAvanceEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAvanceEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuincenaAdescontarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AplicadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents NominasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
