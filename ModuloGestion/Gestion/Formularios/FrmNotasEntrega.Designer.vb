<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotasEntrega
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
        Dim Id_Nota_EntregaLabel As System.Windows.Forms.Label
        Dim Id_ProyectoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Id_PresupuestoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotasEntrega))
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
        Me.DsNotasEntrega = New ModuloGestion.DsNotasEntrega()
        Me.NotasEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasEntregaTableAdapter = New ModuloGestion.DsNotasEntregaTableAdapters.NotasEntregaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsNotasEntregaTableAdapters.TableAdapterManager()
        Me.NotasEntregaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NotasEntregaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Id_Nota_EntregaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.DsNotasEntregaDetalle = New ModuloGestion.DsNotasEntregaDetalle()
        Me.NotasEntregaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotasEntregaDetalleTableAdapter = New ModuloGestion.DsNotasEntregaDetalleTableAdapters.NotasEntregaDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager()
        Me.NotasEntregaDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UnionSubarticulosHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsUnionSubarticulosHerrajes = New ModuloGestion.DsUnionSubarticulosHerrajes()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.NotasEntregaNombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNotasEntregaNombres = New ModuloGestion.DsNotasEntregaNombres()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NotasEntregaNombresTableAdapter = New ModuloGestion.DsNotasEntregaNombresTableAdapters.NotasEntregaNombresTableAdapter()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadEntregada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.BtnAñadirSubArticulo = New System.Windows.Forms.Button()
        Me.EstadoentregasDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProyectoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSubArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SubArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoentregasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEstadoEntregas = New ModuloGestion.DsEstadoEntregas()
        Me.EstadoentregasTableAdapter = New ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter()
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.DsArticulosdetalle = New ModuloGestion.DsArticulosdetalle()
        Me.ArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosDetalleTableAdapter = New ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager()
        Me.ArticulosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.DsArticulosAprobados = New ModuloGestion.DsArticulosAprobados()
        Me.ArticulosAprobadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosAprobadosTableAdapter = New ModuloGestion.DsArticulosAprobadosTableAdapters.ArticulosAprobadosTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsArticulosAprobadosTableAdapters.TableAdapterManager()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UnionSubarticulosHerrajesTableAdapter = New ModuloGestion.DsUnionSubarticulosHerrajesTableAdapters.UnionSubarticulosHerrajesTableAdapter()
        Me.CmbTransportista = New System.Windows.Forms.ComboBox()
        Me.EmpresasTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresasTransporte = New ModuloGestion.DsEmpresasTransporte()
        Me.CmbHehiculo = New System.Windows.Forms.ComboBox()
        Me.VehiculosTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVehiculosTransporte = New ModuloGestion.DsVehiculosTransporte()
        Me.CmbConductor = New System.Windows.Forms.ComboBox()
        Me.ConductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConductores = New ModuloGestion.DsConductores()
        Me.EmpresasTransporteTableAdapter = New ModuloGestion.DsEmpresasTransporteTableAdapters.EmpresasTransporteTableAdapter()
        Me.VehiculosTransporteTableAdapter = New ModuloGestion.DsVehiculosTransporteTableAdapters.VehiculosTransporteTableAdapter()
        Me.ConductoresTableAdapter = New ModuloGestion.DsConductoresTableAdapters.ConductoresTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_EmpresaTransporteTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PresupuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsEstadoEntregasHerrajes = New ModuloGestion.DsEstadoEntregasHerrajes()
        Me.EstadoEntregasherrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoEntregasherrajesTableAdapter = New ModuloGestion.DsEstadoEntregasHerrajesTableAdapters.EstadoEntregasherrajesTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsEstadoEntregasHerrajesTableAdapters.TableAdapterManager()
        Me.EstadoEntregasherrajesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerrajes = New ModuloGestion.DsHerrajes()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HerrajesTableAdapter = New ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter()
        Me.BtnAñadirHerraje = New System.Windows.Forms.Button()
        Me.BtnAnadirLinea = New System.Windows.Forms.Button()
        Me.DsLineasEntraga = New ModuloGestion.DsLineasEntraga()
        Me.LieneasEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LieneasEntregaTableAdapter = New ModuloGestion.DsLineasEntragaTableAdapters.LieneasEntregaTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsLineasEntragaTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableAdapterManager7 = New ModuloGestion.DsArticulosTableAdapters.TableAdapterManager()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_Nota_EntregaLabel = New System.Windows.Forms.Label()
        Id_ProyectoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Id_PresupuestoLabel = New System.Windows.Forms.Label()
        CType(Me.DsNotasEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotasEntregaBindingNavigator.SuspendLayout()
        CType(Me.DsNotasEntregaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionSubarticulosHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUnionSubarticulosHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasEntregaNombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNotasEntregaNombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoentregasDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulosAprobados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosAprobadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresasTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVehiculosTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEstadoEntregasHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoEntregasherrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoEntregasherrajesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLineasEntraga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LieneasEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_Nota_EntregaLabel
        '
        Id_Nota_EntregaLabel.AutoSize = True
        Id_Nota_EntregaLabel.Location = New System.Drawing.Point(23, 43)
        Id_Nota_EntregaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_Nota_EntregaLabel.Name = "Id_Nota_EntregaLabel"
        Id_Nota_EntregaLabel.Size = New System.Drawing.Size(111, 17)
        Id_Nota_EntregaLabel.TabIndex = 1
        Id_Nota_EntregaLabel.Text = "Id Nota Entrega:"
        '
        'Id_ProyectoLabel
        '
        Id_ProyectoLabel.AutoSize = True
        Id_ProyectoLabel.Location = New System.Drawing.Point(23, 75)
        Id_ProyectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ProyectoLabel.Name = "Id_ProyectoLabel"
        Id_ProyectoLabel.Size = New System.Drawing.Size(83, 17)
        Id_ProyectoLabel.TabIndex = 3
        Id_ProyectoLabel.Text = "Id Proyecto:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(28, 142)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.AutoSize = True
        Id_EmpresaLabel.Location = New System.Drawing.Point(28, 174)
        Id_EmpresaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(83, 17)
        Id_EmpresaLabel.TabIndex = 16
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(31, 32)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(92, 17)
        Label1.TabIndex = 26
        Label1.Text = "Transportista"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(31, 65)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 17)
        Label2.TabIndex = 28
        Label2.Text = "Vehiculo"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(31, 98)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(73, 17)
        Label3.TabIndex = 30
        Label3.Text = "Conductor"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(28, 215)
        ObservacionesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(107, 17)
        ObservacionesLabel.TabIndex = 31
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Id_PresupuestoLabel
        '
        Id_PresupuestoLabel.AutoSize = True
        Id_PresupuestoLabel.Location = New System.Drawing.Point(23, 105)
        Id_PresupuestoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_PresupuestoLabel.Name = "Id_PresupuestoLabel"
        Id_PresupuestoLabel.Size = New System.Drawing.Size(107, 17)
        Id_PresupuestoLabel.TabIndex = 35
        Id_PresupuestoLabel.Text = "Id Presupuesto:"
        '
        'DsNotasEntrega
        '
        Me.DsNotasEntrega.DataSetName = "DsNotasEntrega"
        Me.DsNotasEntrega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotasEntregaBindingSource
        '
        Me.NotasEntregaBindingSource.DataMember = "NotasEntrega"
        Me.NotasEntregaBindingSource.DataSource = Me.DsNotasEntrega
        '
        'NotasEntregaTableAdapter
        '
        Me.NotasEntregaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NotasEntregaTableAdapter = Me.NotasEntregaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsNotasEntregaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NotasEntregaBindingNavigator
        '
        Me.NotasEntregaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NotasEntregaBindingNavigator.BindingSource = Me.NotasEntregaBindingSource
        Me.NotasEntregaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NotasEntregaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NotasEntregaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NotasEntregaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NotasEntregaBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.NotasEntregaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NotasEntregaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NotasEntregaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NotasEntregaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NotasEntregaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NotasEntregaBindingNavigator.Name = "NotasEntregaBindingNavigator"
        Me.NotasEntregaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NotasEntregaBindingNavigator.Size = New System.Drawing.Size(1703, 27)
        Me.NotasEntregaBindingNavigator.TabIndex = 0
        Me.NotasEntregaBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        'NotasEntregaBindingNavigatorSaveItem
        '
        Me.NotasEntregaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NotasEntregaBindingNavigatorSaveItem.Image = CType(resources.GetObject("NotasEntregaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NotasEntregaBindingNavigatorSaveItem.Name = "NotasEntregaBindingNavigatorSaveItem"
        Me.NotasEntregaBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.NotasEntregaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Id_Nota_EntregaTextBox
        '
        Me.Id_Nota_EntregaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Id_Nota_Entrega", True))
        Me.Id_Nota_EntregaTextBox.Location = New System.Drawing.Point(144, 39)
        Me.Id_Nota_EntregaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_Nota_EntregaTextBox.Name = "Id_Nota_EntregaTextBox"
        Me.Id_Nota_EntregaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_Nota_EntregaTextBox.TabIndex = 2
        '
        'Id_ProyectoTextBox
        '
        Me.Id_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Id_Proyecto", True))
        Me.Id_ProyectoTextBox.Location = New System.Drawing.Point(144, 71)
        Me.Id_ProyectoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_ProyectoTextBox.Name = "Id_ProyectoTextBox"
        Me.Id_ProyectoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_ProyectoTextBox.TabIndex = 4
        '
        'TxtFecha
        '
        Me.TxtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NotasEntregaBindingSource, "fecha", True))
        Me.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecha.Location = New System.Drawing.Point(144, 142)
        Me.TxtFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(123, 22)
        Me.TxtFecha.TabIndex = 16
        '
        'DsNotasEntregaDetalle
        '
        Me.DsNotasEntregaDetalle.DataSetName = "DsNotasEntregaDetalle"
        Me.DsNotasEntregaDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotasEntregaDetalleBindingSource
        '
        Me.NotasEntregaDetalleBindingSource.DataMember = "NotasEntregaDetalle"
        Me.NotasEntregaDetalleBindingSource.DataSource = Me.DsNotasEntregaDetalle
        '
        'NotasEntregaDetalleTableAdapter
        '
        Me.NotasEntregaDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.NotasEntregaDetalleTableAdapter = Me.NotasEntregaDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NotasEntregaDetalleDataGridView
        '
        Me.NotasEntregaDetalleDataGridView.AllowUserToAddRows = False
        Me.NotasEntregaDetalleDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NotasEntregaDetalleDataGridView.AutoGenerateColumns = False
        Me.NotasEntregaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotasEntregaDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.NotasEntregaDetalleDataGridView.DataSource = Me.NotasEntregaDetalleBindingSource
        Me.NotasEntregaDetalleDataGridView.Location = New System.Drawing.Point(16, 347)
        Me.NotasEntregaDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NotasEntregaDetalleDataGridView.Name = "NotasEntregaDetalleDataGridView"
        Me.NotasEntregaDetalleDataGridView.RowHeadersWidth = 51
        Me.NotasEntregaDetalleDataGridView.Size = New System.Drawing.Size(724, 526)
        Me.NotasEntregaDetalleDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_detalle_Nota_entrega"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Nota_Entrega"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Nota_Entrega"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.UnionSubarticulosHerrajesBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrpcion"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id_Sub_Articulo"
        '
        'UnionSubarticulosHerrajesBindingSource
        '
        Me.UnionSubarticulosHerrajesBindingSource.DataMember = "UnionSubarticulosHerrajes"
        Me.UnionSubarticulosHerrajesBindingSource.DataSource = Me.DsUnionSubarticulosHerrajes
        '
        'DsUnionSubarticulosHerrajes
        '
        Me.DsUnionSubarticulosHerrajes.DataSetName = "DsUnionSubarticulosHerrajes"
        Me.DsUnionSubarticulosHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'SubArticulosBindingSource
        '
        Me.SubArticulosBindingSource.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource.DataSource = Me.DsSubArticulos
        '
        'DsSubArticulos
        '
        Me.DsSubArticulos.DataSetName = "DsSubArticulos"
        Me.DsSubArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotasEntregaNombresBindingSource
        '
        Me.NotasEntregaNombresBindingSource.DataMember = "NotasEntregaNombres"
        Me.NotasEntregaNombresBindingSource.DataSource = Me.DsNotasEntregaNombres
        '
        'DsNotasEntregaNombres
        '
        Me.DsNotasEntregaNombres.DataSetName = "DsNotasEntregaNombres"
        Me.DsNotasEntregaNombres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(144, 170)
        Me.Id_EmpresaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(52, 22)
        Me.Id_EmpresaTextBox.TabIndex = 17
        '
        'NotasEntregaNombresTableAdapter
        '
        Me.NotasEntregaNombresTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id_proyecto_Presupuestos"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.NotasEntregaNombresBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Id_Sub_Articulo"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CantidadPresupuesto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PrecioVenta"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PrecioVenta"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_empresa"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id_empresa"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'CantidadEntregada
        '
        Me.CantidadEntregada.DataPropertyName = "CantidadEntregada"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.CantidadEntregada.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadEntregada.HeaderText = "Entregado"
        Me.CantidadEntregada.MinimumWidth = 6
        Me.CantidadEntregada.Name = "CantidadEntregada"
        Me.CantidadEntregada.ReadOnly = True
        Me.CantidadEntregada.Width = 75
        '
        'PendienteEntrega
        '
        Me.PendienteEntrega.DataPropertyName = "PendienteEntrega"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.PendienteEntrega.DefaultCellStyle = DataGridViewCellStyle4
        Me.PendienteEntrega.HeaderText = "Pendiente"
        Me.PendienteEntrega.MinimumWidth = 6
        Me.PendienteEntrega.Name = "PendienteEntrega"
        Me.PendienteEntrega.ReadOnly = True
        Me.PendienteEntrega.Width = 75
        '
        'DsEmpresas
        '
        Me.DsEmpresas.DataSetName = "DsEmpresas"
        Me.DsEmpresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.DsEmpresas
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'BtnAñadirSubArticulo
        '
        Me.BtnAñadirSubArticulo.Location = New System.Drawing.Point(761, 380)
        Me.BtnAñadirSubArticulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAñadirSubArticulo.Name = "BtnAñadirSubArticulo"
        Me.BtnAñadirSubArticulo.Size = New System.Drawing.Size(136, 28)
        Me.BtnAñadirSubArticulo.TabIndex = 19
        Me.BtnAñadirSubArticulo.Text = "Añadir SubArticulo"
        Me.BtnAñadirSubArticulo.UseVisualStyleBackColor = True
        '
        'EstadoentregasDataGridView1
        '
        Me.EstadoentregasDataGridView1.AllowUserToAddRows = False
        Me.EstadoentregasDataGridView1.AutoGenerateColumns = False
        Me.EstadoentregasDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstadoentregasDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.IdProyectoDataGridViewTextBoxColumn, Me.IDSubArticuloDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.EntregadosDataGridViewTextBoxColumn, Me.PendienteDataGridViewTextBoxColumn})
        Me.EstadoentregasDataGridView1.DataSource = Me.EstadoentregasBindingSource
        Me.EstadoentregasDataGridView1.Location = New System.Drawing.Point(761, 416)
        Me.EstadoentregasDataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EstadoentregasDataGridView1.Name = "EstadoentregasDataGridView1"
        Me.EstadoentregasDataGridView1.RowHeadersWidth = 51
        Me.EstadoentregasDataGridView1.Size = New System.Drawing.Size(816, 192)
        Me.EstadoentregasDataGridView1.TabIndex = 21
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Frozen = True
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.Width = 125
        '
        'IdProyectoDataGridViewTextBoxColumn
        '
        Me.IdProyectoDataGridViewTextBoxColumn.DataPropertyName = "Id_Proyecto"
        Me.IdProyectoDataGridViewTextBoxColumn.Frozen = True
        Me.IdProyectoDataGridViewTextBoxColumn.HeaderText = "Id_Proyecto"
        Me.IdProyectoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProyectoDataGridViewTextBoxColumn.Name = "IdProyectoDataGridViewTextBoxColumn"
        Me.IdProyectoDataGridViewTextBoxColumn.Visible = False
        Me.IdProyectoDataGridViewTextBoxColumn.Width = 125
        '
        'IDSubArticuloDataGridViewTextBoxColumn
        '
        Me.IDSubArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDSubArticuloDataGridViewTextBoxColumn.DataPropertyName = "ID_Sub_Articulo"
        Me.IDSubArticuloDataGridViewTextBoxColumn.DataSource = Me.SubArticulosBindingSource1
        Me.IDSubArticuloDataGridViewTextBoxColumn.DisplayMember = "Descripcion_Sub_Articulo"
        Me.IDSubArticuloDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IDSubArticuloDataGridViewTextBoxColumn.HeaderText = "Sub Articulo"
        Me.IDSubArticuloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDSubArticuloDataGridViewTextBoxColumn.Name = "IDSubArticuloDataGridViewTextBoxColumn"
        Me.IDSubArticuloDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDSubArticuloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IDSubArticuloDataGridViewTextBoxColumn.ValueMember = "Id_Sub_Articulo"
        '
        'SubArticulosBindingSource1
        '
        Me.SubArticulosBindingSource1.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource1.DataSource = Me.DsSubArticulos
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 75
        '
        'EntregadosDataGridViewTextBoxColumn
        '
        Me.EntregadosDataGridViewTextBoxColumn.DataPropertyName = "Entregados"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.EntregadosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.EntregadosDataGridViewTextBoxColumn.HeaderText = "Entregados"
        Me.EntregadosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EntregadosDataGridViewTextBoxColumn.Name = "EntregadosDataGridViewTextBoxColumn"
        Me.EntregadosDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntregadosDataGridViewTextBoxColumn.Width = 75
        '
        'PendienteDataGridViewTextBoxColumn
        '
        Me.PendienteDataGridViewTextBoxColumn.DataPropertyName = "Pendiente"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PendienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PendienteDataGridViewTextBoxColumn.HeaderText = "Pendiente"
        Me.PendienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PendienteDataGridViewTextBoxColumn.Name = "PendienteDataGridViewTextBoxColumn"
        Me.PendienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PendienteDataGridViewTextBoxColumn.Width = 75
        '
        'EstadoentregasBindingSource
        '
        Me.EstadoentregasBindingSource.DataMember = "Estadoentregas"
        Me.EstadoentregasBindingSource.DataSource = Me.DsEstadoEntregas
        '
        'DsEstadoEntregas
        '
        Me.DsEstadoEntregas.DataSetName = "DsEstadoEntregas"
        Me.DsEstadoEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoentregasTableAdapter
        '
        Me.EstadoentregasTableAdapter.ClearBeforeFill = True
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'DsArticulosdetalle
        '
        Me.DsArticulosdetalle.DataSetName = "DsArticulosdetalle"
        Me.DsArticulosdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosDetalleBindingSource
        '
        Me.ArticulosDetalleBindingSource.DataMember = "ArticulosDetalle"
        Me.ArticulosDetalleBindingSource.DataSource = Me.DsArticulosdetalle
        '
        'ArticulosDetalleTableAdapter
        '
        Me.ArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.ArticulosDetalleTableAdapter = Me.ArticulosDetalleTableAdapter
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosDetalleDataGridView
        '
        Me.ArticulosDetalleDataGridView.AllowUserToAddRows = False
        Me.ArticulosDetalleDataGridView.AllowUserToDeleteRows = False
        Me.ArticulosDetalleDataGridView.AutoGenerateColumns = False
        Me.ArticulosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.ArticulosDetalleDataGridView.DataSource = Me.ArticulosDetalleBindingSource
        Me.ArticulosDetalleDataGridView.Location = New System.Drawing.Point(761, 206)
        Me.ArticulosDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ArticulosDetalleDataGridView.Name = "ArticulosDetalleDataGridView"
        Me.ArticulosDetalleDataGridView.ReadOnly = True
        Me.ArticulosDetalleDataGridView.RowHeadersWidth = 51
        Me.ArticulosDetalleDataGridView.Size = New System.Drawing.Size(816, 167)
        Me.ArticulosDetalleDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Id_Detalle_Articulos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Id_Detalle_Articulos"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Id_Articulo"
        Me.DataGridViewTextBoxColumn15.DataSource = Me.ArticulosBindingSource
        Me.DataGridViewTextBoxColumn15.DisplayMember = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn15.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn15.HeaderText = "Id_Articulo"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn15.ValueMember = "IdArticulo"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "DsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn16.DataSource = Me.SubArticulosBindingSource1
        Me.DataGridViewTextBoxColumn16.DisplayMember = "Descripcion_Sub_Articulo"
        Me.DataGridViewTextBoxColumn16.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID_Sub_Articulo"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.ValueMember = "Id_Sub_Articulo"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn18.HeaderText = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "M2Pintura"
        Me.DataGridViewTextBoxColumn19.HeaderText = "M2Pintura"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "HorasTrabajoTallerTotal"
        Me.DataGridViewTextBoxColumn20.HeaderText = "HorasTrabajoTallerTotal"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "M2Pinturatota"
        Me.DataGridViewTextBoxColumn21.HeaderText = "M2Pinturatota"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'DsPresupuestoDetalle
        '
        Me.DsPresupuestoDetalle.DataSetName = "DsPresupuestoDetalle"
        Me.DsPresupuestoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataMember = "PresupuestoDetalle"
        Me.PresupuestoDetalleBindingSource.DataSource = Me.DsPresupuestoDetalle
        '
        'PresupuestoDetalleTableAdapter
        '
        Me.PresupuestoDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.PresupuestoDetalleTableAdapter = Me.PresupuestoDetalleTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsArticulosAprobados
        '
        Me.DsArticulosAprobados.DataSetName = "DsArticulosAprobados"
        Me.DsArticulosAprobados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosAprobadosBindingSource
        '
        Me.ArticulosAprobadosBindingSource.DataMember = "ArticulosAprobados"
        Me.ArticulosAprobadosBindingSource.DataSource = Me.DsArticulosAprobados
        '
        'ArticulosAprobadosTableAdapter
        '
        Me.ArticulosAprobadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsArticulosAprobadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(640, 166)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Añadir Kit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UnionSubarticulosHerrajesTableAdapter
        '
        Me.UnionSubarticulosHerrajesTableAdapter.ClearBeforeFill = True
        '
        'CmbTransportista
        '
        Me.CmbTransportista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Id_EmpresaTransporte", True))
        Me.CmbTransportista.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotasEntregaBindingSource, "Id_EmpresaTransporte", True))
        Me.CmbTransportista.DataSource = Me.EmpresasTransporteBindingSource
        Me.CmbTransportista.DisplayMember = "RazonSocial"
        Me.CmbTransportista.FormattingEnabled = True
        Me.CmbTransportista.Location = New System.Drawing.Point(135, 22)
        Me.CmbTransportista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbTransportista.Name = "CmbTransportista"
        Me.CmbTransportista.Size = New System.Drawing.Size(233, 24)
        Me.CmbTransportista.TabIndex = 25
        Me.CmbTransportista.ValueMember = "Id_EmpresaTransporte"
        '
        'EmpresasTransporteBindingSource
        '
        Me.EmpresasTransporteBindingSource.DataMember = "EmpresasTransporte"
        Me.EmpresasTransporteBindingSource.DataSource = Me.DsEmpresasTransporte
        '
        'DsEmpresasTransporte
        '
        Me.DsEmpresasTransporte.DataSetName = "DsEmpresasTransporte"
        Me.DsEmpresasTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbHehiculo
        '
        Me.CmbHehiculo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Placa", True))
        Me.CmbHehiculo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotasEntregaBindingSource, "Placa", True))
        Me.CmbHehiculo.DataSource = Me.VehiculosTransporteBindingSource
        Me.CmbHehiculo.DisplayMember = "Placa"
        Me.CmbHehiculo.FormattingEnabled = True
        Me.CmbHehiculo.Location = New System.Drawing.Point(135, 55)
        Me.CmbHehiculo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbHehiculo.Name = "CmbHehiculo"
        Me.CmbHehiculo.Size = New System.Drawing.Size(233, 24)
        Me.CmbHehiculo.TabIndex = 27
        Me.CmbHehiculo.ValueMember = "Placa"
        '
        'VehiculosTransporteBindingSource
        '
        Me.VehiculosTransporteBindingSource.DataMember = "VehiculosTransporte"
        Me.VehiculosTransporteBindingSource.DataSource = Me.DsVehiculosTransporte
        '
        'DsVehiculosTransporte
        '
        Me.DsVehiculosTransporte.DataSetName = "DsVehiculosTransporte"
        Me.DsVehiculosTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbConductor
        '
        Me.CmbConductor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Cedula", True))
        Me.CmbConductor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotasEntregaBindingSource, "Cedula", True))
        Me.CmbConductor.DataSource = Me.ConductoresBindingSource
        Me.CmbConductor.DisplayMember = "Nombre"
        Me.CmbConductor.FormattingEnabled = True
        Me.CmbConductor.Location = New System.Drawing.Point(135, 89)
        Me.CmbConductor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbConductor.Name = "CmbConductor"
        Me.CmbConductor.Size = New System.Drawing.Size(233, 24)
        Me.CmbConductor.TabIndex = 29
        Me.CmbConductor.ValueMember = "Cedula"
        '
        'ConductoresBindingSource
        '
        Me.ConductoresBindingSource.DataMember = "Conductores"
        Me.ConductoresBindingSource.DataSource = Me.DsConductores
        '
        'DsConductores
        '
        Me.DsConductores.DataSetName = "DsConductores"
        Me.DsConductores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasTransporteTableAdapter
        '
        Me.EmpresasTransporteTableAdapter.ClearBeforeFill = True
        '
        'VehiculosTransporteTableAdapter
        '
        Me.VehiculosTransporteTableAdapter.ClearBeforeFill = True
        '
        'ConductoresTableAdapter
        '
        Me.ConductoresTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbConductor)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.CmbHehiculo)
        Me.GroupBox1.Controls.Add(Me.CmbTransportista)
        Me.GroupBox1.Location = New System.Drawing.Point(363, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(377, 119)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medio de transporte"
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(20, 246)
        Me.ObservacionesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(676, 83)
        Me.ObservacionesTextBox.TabIndex = 32
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(427, 214)
        Me.PlacaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PlacaTextBox.TabIndex = 33
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(285, 214)
        Me.CedulaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CedulaTextBox.TabIndex = 34
        '
        'Id_EmpresaTransporteTextBox
        '
        Me.Id_EmpresaTransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Id_EmpresaTransporte", True))
        Me.Id_EmpresaTransporteTextBox.Location = New System.Drawing.Point(144, 214)
        Me.Id_EmpresaTransporteTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_EmpresaTransporteTextBox.Name = "Id_EmpresaTransporteTextBox"
        Me.Id_EmpresaTransporteTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_EmpresaTransporteTextBox.TabIndex = 35
        '
        'Id_PresupuestoTextBox
        '
        Me.Id_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotasEntregaBindingSource, "Id_Presupuesto", True))
        Me.Id_PresupuestoTextBox.Location = New System.Drawing.Point(144, 105)
        Me.Id_PresupuestoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_PresupuestoTextBox.Name = "Id_PresupuestoTextBox"
        Me.Id_PresupuestoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_PresupuestoTextBox.TabIndex = 36
        '
        'PresupuestoDetalleDataGridView
        '
        Me.PresupuestoDetalleDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PresupuestoDetalleDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn25})
        Me.PresupuestoDetalleDataGridView.DataSource = Me.PresupuestoDetalleBindingSource
        Me.PresupuestoDetalleDataGridView.Location = New System.Drawing.Point(761, 43)
        Me.PresupuestoDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PresupuestoDetalleDataGridView.Name = "PresupuestoDetalleDataGridView"
        Me.PresupuestoDetalleDataGridView.ReadOnly = True
        Me.PresupuestoDetalleDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDetalleDataGridView.Size = New System.Drawing.Size(816, 155)
        Me.PresupuestoDetalleDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Articulo"
        Me.DataGridViewTextBoxColumn22.DataSource = Me.ArticulosBindingSource
        Me.DataGridViewTextBoxColumn22.DisplayMember = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn22.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn22.HeaderText = "Articulo"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn22.ValueMember = "IdArticulo"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Cantidad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn25.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 75
        '
        'DsEstadoEntregasHerrajes
        '
        Me.DsEstadoEntregasHerrajes.DataSetName = "DsEstadoEntregasHerrajes"
        Me.DsEstadoEntregasHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoEntregasherrajesBindingSource
        '
        Me.EstadoEntregasherrajesBindingSource.DataMember = "EstadoEntregasherrajes"
        Me.EstadoEntregasherrajesBindingSource.DataSource = Me.DsEstadoEntregasHerrajes
        '
        'EstadoEntregasherrajesTableAdapter
        '
        Me.EstadoEntregasherrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.Connection = Nothing
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsEstadoEntregasHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EstadoEntregasherrajesDataGridView
        '
        Me.EstadoEntregasherrajesDataGridView.AllowUserToAddRows = False
        Me.EstadoEntregasherrajesDataGridView.AllowUserToDeleteRows = False
        Me.EstadoEntregasherrajesDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EstadoEntregasherrajesDataGridView.AutoGenerateColumns = False
        Me.EstadoEntregasherrajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstadoEntregasherrajesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.EstadoEntregasherrajesDataGridView.DataSource = Me.EstadoEntregasherrajesBindingSource
        Me.EstadoEntregasherrajesDataGridView.Location = New System.Drawing.Point(761, 652)
        Me.EstadoEntregasherrajesDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EstadoEntregasherrajesDataGridView.Name = "EstadoEntregasherrajesDataGridView"
        Me.EstadoEntregasherrajesDataGridView.ReadOnly = True
        Me.EstadoEntregasherrajesDataGridView.RowHeadersWidth = 51
        Me.EstadoEntregasherrajesDataGridView.Size = New System.Drawing.Size(816, 220)
        Me.EstadoEntregasherrajesDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Id_Herraje"
        Me.DataGridViewTextBoxColumn24.DataSource = Me.HerrajesBindingSource
        Me.DataGridViewTextBoxColumn24.DisplayMember = "Descripcion_Elemento_Herrajes"
        Me.DataGridViewTextBoxColumn24.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn24.HeaderText = "Herraje"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn24.ValueMember = "IdHerraje"
        '
        'HerrajesBindingSource
        '
        Me.HerrajesBindingSource.DataMember = "Herrajes"
        Me.HerrajesBindingSource.DataSource = Me.DsHerrajes
        '
        'DsHerrajes
        '
        Me.DsHerrajes.DataSetName = "DsHerrajes"
        Me.DsHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Pedidos"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn26.HeaderText = "Pedidos"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 75
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Entregados"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn27.HeaderText = "Entregados"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 75
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Pendientes"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn28.HeaderText = "Pendientes"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 75
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Codigo2"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Codigo2"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'HerrajesTableAdapter
        '
        Me.HerrajesTableAdapter.ClearBeforeFill = True
        '
        'BtnAñadirHerraje
        '
        Me.BtnAñadirHerraje.Location = New System.Drawing.Point(761, 617)
        Me.BtnAñadirHerraje.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAñadirHerraje.Name = "BtnAñadirHerraje"
        Me.BtnAñadirHerraje.Size = New System.Drawing.Size(136, 28)
        Me.BtnAñadirHerraje.TabIndex = 37
        Me.BtnAñadirHerraje.Text = "Añadir Herraje"
        Me.BtnAñadirHerraje.UseVisualStyleBackColor = True
        '
        'BtnAnadirLinea
        '
        Me.BtnAnadirLinea.Location = New System.Drawing.Point(248, 174)
        Me.BtnAnadirLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAnadirLinea.Name = "BtnAnadirLinea"
        Me.BtnAnadirLinea.Size = New System.Drawing.Size(128, 28)
        Me.BtnAnadirLinea.TabIndex = 38
        Me.BtnAnadirLinea.Text = "Añadir  Linea"
        Me.BtnAnadirLinea.UseVisualStyleBackColor = True
        '
        'DsLineasEntraga
        '
        Me.DsLineasEntraga.DataSetName = "DsLineasEntraga"
        Me.DsLineasEntraga.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LieneasEntregaBindingSource
        '
        Me.LieneasEntregaBindingSource.DataMember = "LieneasEntrega"
        Me.LieneasEntregaBindingSource.DataSource = Me.DsLineasEntraga
        '
        'LieneasEntregaTableAdapter
        '
        Me.LieneasEntregaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.LieneasEntregaTableAdapter = Me.LieneasEntregaTableAdapter
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsLineasEntragaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1591, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Añadir Articulo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.AutoGenerateColumns = False
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.ArticulosDataGridView.DataSource = Me.ArticulosBindingSource
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(925, 380)
        Me.ArticulosDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.RowHeadersWidth = 51
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(400, 271)
        Me.ArticulosDataGridView.TabIndex = 39
        Me.ArticulosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn23.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Descripcion_articulo"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn33.HeaderText = "HorasTrabajoTaller"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "M2Pintura"
        Me.DataGridViewTextBoxColumn34.HeaderText = "M2Pintura"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "HorasTrabajoTallerPintura"
        Me.DataGridViewTextBoxColumn35.HeaderText = "HorasTrabajoTallerPintura"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "DiseñoArticulo"
        Me.DataGridViewTextBoxColumn36.HeaderText = "DiseñoArticulo"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Montaje"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Montaje"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'FrmNotasEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1703, 902)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAnadirLinea)
        Me.Controls.Add(Me.BtnAñadirHerraje)
        Me.Controls.Add(Me.EstadoEntregasherrajesDataGridView)
        Me.Controls.Add(Me.PresupuestoDetalleDataGridView)
        Me.Controls.Add(Id_PresupuestoLabel)
        Me.Controls.Add(Me.Id_PresupuestoTextBox)
        Me.Controls.Add(Me.Id_EmpresaTransporteTextBox)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ArticulosDetalleDataGridView)
        Me.Controls.Add(Me.EstadoentregasDataGridView1)
        Me.Controls.Add(Me.BtnAñadirSubArticulo)
        Me.Controls.Add(Id_EmpresaLabel)
        Me.Controls.Add(Me.Id_EmpresaTextBox)
        Me.Controls.Add(Me.NotasEntregaDetalleDataGridView)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Id_Nota_EntregaLabel)
        Me.Controls.Add(Me.Id_Nota_EntregaTextBox)
        Me.Controls.Add(Id_ProyectoLabel)
        Me.Controls.Add(Me.Id_ProyectoTextBox)
        Me.Controls.Add(Me.NotasEntregaBindingNavigator)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmNotasEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas Entrega"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsNotasEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotasEntregaBindingNavigator.ResumeLayout(False)
        Me.NotasEntregaBindingNavigator.PerformLayout()
        CType(Me.DsNotasEntregaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionSubarticulosHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUnionSubarticulosHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasEntregaNombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNotasEntregaNombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoentregasDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoentregasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEstadoEntregas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulosAprobados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosAprobadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresasTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVehiculosTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PresupuestoDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEstadoEntregasHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoEntregasherrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoEntregasherrajesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLineasEntraga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LieneasEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsNotasEntrega As ModuloGestion.DsNotasEntrega
    Friend WithEvents NotasEntregaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaTableAdapter As ModuloGestion.DsNotasEntregaTableAdapters.NotasEntregaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsNotasEntregaTableAdapters.TableAdapterManager
    Friend WithEvents NotasEntregaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NotasEntregaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_Nota_EntregaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsNotasEntregaDetalle As ModuloGestion.DsNotasEntregaDetalle
    Friend WithEvents NotasEntregaDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaDetalleTableAdapter As ModuloGestion.DsNotasEntregaDetalleTableAdapters.NotasEntregaDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsNotasEntregaDetalleTableAdapters.TableAdapterManager
    Friend WithEvents NotasEntregaDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Id_EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsNotasEntregaNombres As ModuloGestion.DsNotasEntregaNombres
    Friend WithEvents NotasEntregaNombresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasEntregaNombresTableAdapter As ModuloGestion.DsNotasEntregaNombresTableAdapters.NotasEntregaNombresTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn


    Friend WithEvents EsatadoEntregasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadEntregada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PendienteEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents BtnAñadirSubArticulo As System.Windows.Forms.Button
    Friend WithEvents EstadoentregasDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsEstadoEntregas As ModuloGestion.DsEstadoEntregas
    Friend WithEvents EstadoentregasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoentregasTableAdapter As ModuloGestion.DsEstadoEntregasTableAdapters.EstadoentregasTableAdapter
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents PresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsArticulosdetalle As ModuloGestion.DsArticulosdetalle
    Friend WithEvents ArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosDetalleTableAdapter As ModuloGestion.DsArticulosdetalleTableAdapters.ArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsArticulosdetalleTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsArticulos As ModuloGestion.DsArticulos
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents DsPresupuestoDetalle As ModuloGestion.DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsArticulosAprobados As ModuloGestion.DsArticulosAprobados
    Friend WithEvents ArticulosAprobadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosAprobadosTableAdapter As ModuloGestion.DsArticulosAprobadosTableAdapters.ArticulosAprobadosTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsArticulosAprobadosTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DsUnionSubarticulosHerrajes As ModuloGestion.DsUnionSubarticulosHerrajes
    Friend WithEvents UnionSubarticulosHerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnionSubarticulosHerrajesTableAdapter As ModuloGestion.DsUnionSubarticulosHerrajesTableAdapters.UnionSubarticulosHerrajesTableAdapter
    Friend WithEvents SubArticulosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProyectoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntregadosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PendienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbTransportista As System.Windows.Forms.ComboBox
    Friend WithEvents CmbHehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbConductor As System.Windows.Forms.ComboBox
    Friend WithEvents DsEmpresasTransporte As ModuloGestion.DsEmpresasTransporte
    Friend WithEvents EmpresasTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTransporteTableAdapter As ModuloGestion.DsEmpresasTransporteTableAdapters.EmpresasTransporteTableAdapter
    Friend WithEvents DsVehiculosTransporte As ModuloGestion.DsVehiculosTransporte
    Friend WithEvents VehiculosTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculosTransporteTableAdapter As ModuloGestion.DsVehiculosTransporteTableAdapters.VehiculosTransporteTableAdapter
    Friend WithEvents DsConductores As ModuloGestion.DsConductores
    Friend WithEvents ConductoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConductoresTableAdapter As ModuloGestion.DsConductoresTableAdapters.ConductoresTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlacaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_EmpresaTransporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_PresupuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresupuestoDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsEstadoEntregasHerrajes As ModuloGestion.DsEstadoEntregasHerrajes
    Friend WithEvents EstadoEntregasherrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoEntregasherrajesTableAdapter As ModuloGestion.DsEstadoEntregasHerrajesTableAdapters.EstadoEntregasherrajesTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsEstadoEntregasHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents EstadoEntregasherrajesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsHerrajes As ModuloGestion.DsHerrajes
    Friend WithEvents HerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesTableAdapter As ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAñadirHerraje As System.Windows.Forms.Button
    Friend WithEvents BtnAnadirLinea As System.Windows.Forms.Button
    Friend WithEvents DsLineasEntraga As ModuloGestion.DsLineasEntraga
    Friend WithEvents LieneasEntregaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LieneasEntregaTableAdapter As ModuloGestion.DsLineasEntragaTableAdapters.LieneasEntregaTableAdapter
    Friend WithEvents TableAdapterManager6 As ModuloGestion.DsLineasEntragaTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TableAdapterManager7 As DsArticulosTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
End Class
