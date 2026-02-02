<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresaMontaje
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Telefono2Label As System.Windows.Forms.Label
        Dim Telefono1Label As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim IdEmpresaMontajeLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim CuentaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresaMontaje))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmpresasContratadasMontajeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
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
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PagoMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.PagoMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.PagoMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagoMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter()
        Me.BtnResumenFactura = New System.Windows.Forms.Button()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FacturaMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.FacturaMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaMontaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.PendienteInstalador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.BtnModificarFactura = New System.Windows.Forms.Button()
        Me.BtnResumenPagos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CuentaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono2TextBox = New System.Windows.Forms.TextBox()
        Me.BancoTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Telefono1TextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RazonSocialComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IdEmpresaMontajeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPartida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        EmailLabel = New System.Windows.Forms.Label()
        Telefono2Label = New System.Windows.Forms.Label()
        Telefono1Label = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        IdEmpresaMontajeLabel = New System.Windows.Forms.Label()
        BancoLabel = New System.Windows.Forms.Label()
        CuentaLabel = New System.Windows.Forms.Label()
        CType(Me.EmpresasContratadasMontajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasContratadasMontajeBindingNavigator.SuspendLayout()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(4, 179)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'Telefono2Label
        '
        Telefono2Label.AutoSize = True
        Telefono2Label.Location = New System.Drawing.Point(4, 139)
        Telefono2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefono2Label.Name = "Telefono2Label"
        Telefono2Label.Size = New System.Drawing.Size(84, 20)
        Telefono2Label.TabIndex = 7
        Telefono2Label.Text = "Telefono2:"
        '
        'Telefono1Label
        '
        Telefono1Label.AutoSize = True
        Telefono1Label.Location = New System.Drawing.Point(4, 99)
        Telefono1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telefono1Label.Name = "Telefono1Label"
        Telefono1Label.Size = New System.Drawing.Size(84, 20)
        Telefono1Label.TabIndex = 5
        Telefono1Label.Text = "Telefono1:"
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(4, 58)
        RazonSocialLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(107, 20)
        RazonSocialLabel.TabIndex = 3
        RazonSocialLabel.Text = "Razon Social:"
        '
        'IdEmpresaMontajeLabel
        '
        IdEmpresaMontajeLabel.AutoSize = True
        IdEmpresaMontajeLabel.Location = New System.Drawing.Point(4, 18)
        IdEmpresaMontajeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdEmpresaMontajeLabel.Name = "IdEmpresaMontajeLabel"
        IdEmpresaMontajeLabel.Size = New System.Drawing.Size(156, 20)
        IdEmpresaMontajeLabel.TabIndex = 1
        IdEmpresaMontajeLabel.Text = "Id Empresa Montaje:"
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(4, 211)
        BancoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(59, 20)
        BancoLabel.TabIndex = 35
        BancoLabel.Text = "Banco:"
        '
        'CuentaLabel
        '
        CuentaLabel.AutoSize = True
        CuentaLabel.Location = New System.Drawing.Point(386, 15)
        CuentaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CuentaLabel.Name = "CuentaLabel"
        CuentaLabel.Size = New System.Drawing.Size(65, 20)
        CuentaLabel.TabIndex = 37
        CuentaLabel.Text = "Cuenta:"
        '
        'EmpresasContratadasMontajeBindingNavigator
        '
        Me.EmpresasContratadasMontajeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasContratadasMontajeBindingNavigator.BindingSource = Me.EmpresasContratadasMontajeBindingSource
        Me.EmpresasContratadasMontajeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasContratadasMontajeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasContratadasMontajeBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpresasContratadasMontajeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasContratadasMontajeBindingNavigatorSaveItem})
        Me.EmpresasContratadasMontajeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasContratadasMontajeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasContratadasMontajeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasContratadasMontajeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasContratadasMontajeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasContratadasMontajeBindingNavigator.Name = "EmpresasContratadasMontajeBindingNavigator"
        Me.EmpresasContratadasMontajeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasContratadasMontajeBindingNavigator.Size = New System.Drawing.Size(2124, 31)
        Me.EmpresasContratadasMontajeBindingNavigator.TabIndex = 0
        Me.EmpresasContratadasMontajeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 26)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 26)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'EmpresasContratadasMontajeBindingNavigatorSaveItem
        '
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasContratadasMontajeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Name = "EmpresasContratadasMontajeBindingNavigatorSaveItem"
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 26)
        Me.EmpresasContratadasMontajeBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PagoMontajeBindingSource
        '
        Me.PagoMontajeBindingSource.DataMember = "PagoMontaje"
        Me.PagoMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
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
        'PagoMontajeTableAdapter
        '
        Me.PagoMontajeTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeBindingSource
        '
        Me.FacturaMontajeBindingSource.DataMember = "FK_PagoMontaje_EmpresasContratadasMontaje1"
        Me.FacturaMontajeBindingSource.DataSource = Me.EmpresasContratadasMontajeBindingSource
        '
        'FacturaMontajeTableAdapter
        '
        Me.FacturaMontajeTableAdapter.ClearBeforeFill = True
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
        'BtnResumenFactura
        '
        Me.BtnResumenFactura.Location = New System.Drawing.Point(936, 99)
        Me.BtnResumenFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnResumenFactura.Name = "BtnResumenFactura"
        Me.BtnResumenFactura.Size = New System.Drawing.Size(159, 31)
        Me.BtnResumenFactura.TabIndex = 26
        Me.BtnResumenFactura.Text = "Resume Facturas"
        Me.BtnResumenFactura.UseVisualStyleBackColor = True
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager3.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(1120, 265)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 22)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Presupuesto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(1232, 265)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 22)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Label18"
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
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'FacturaMontajeDetalleDataGridView
        '
        Me.FacturaMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.FacturaMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn31, Me.Descripcion, Me.DataGridViewTextBoxColumn33, Me.Precio, Me.TotalPartida})
        Me.FacturaMontajeDetalleDataGridView.DataSource = Me.FacturaMontajeDetalleBindingSource
        Me.FacturaMontajeDetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturaMontajeDetalleDataGridView.Location = New System.Drawing.Point(4, 551)
        Me.FacturaMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaMontajeDetalleDataGridView.Name = "FacturaMontajeDetalleDataGridView"
        Me.FacturaMontajeDetalleDataGridView.ReadOnly = True
        Me.FacturaMontajeDetalleDataGridView.RowHeadersWidth = 51
        Me.FacturaMontajeDetalleDataGridView.Size = New System.Drawing.Size(1160, 355)
        Me.FacturaMontajeDetalleDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn29.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn29.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IdPagoMontajeDetalle"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IdPagoMontajeDetalle"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'IdFacturaMontaje
        '
        Me.IdFacturaMontaje.DataPropertyName = "IdFacturaMontaje"
        Me.IdFacturaMontaje.HeaderText = "IdFactura"
        Me.IdFacturaMontaje.MinimumWidth = 6
        Me.IdFacturaMontaje.Name = "IdFacturaMontaje"
        Me.IdFacturaMontaje.ReadOnly = True
        Me.IdFacturaMontaje.Width = 125
        '
        'PagoMontajeDetalleDataGridView
        '
        Me.PagoMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.PagoMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PagoMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.PagoMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagoMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaMontaje, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn28})
        Me.PagoMontajeDetalleDataGridView.DataSource = Me.PagoMontajeDetalleBindingSource
        Me.PagoMontajeDetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagoMontajeDetalleDataGridView.Location = New System.Drawing.Point(1172, 5)
        Me.PagoMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PagoMontajeDetalleDataGridView.Name = "PagoMontajeDetalleDataGridView"
        Me.PagoMontajeDetalleDataGridView.ReadOnly = True
        Me.PagoMontajeDetalleDataGridView.RowHeadersWidth = 51
        Me.PagoMontajeDetalleDataGridView.Size = New System.Drawing.Size(948, 536)
        Me.PagoMontajeDetalleDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FormaDePago"
        Me.DataGridViewTextBoxColumn25.HeaderText = "FormaDePago"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "PendienteAsignar"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn23.HeaderText = "Pendiente Asignar"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Asignado"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn22.HeaderText = "Asignado"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "valor"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn21.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "IdPagoMontaje"
        Me.DataGridViewTextBoxColumn17.HeaderText = "IdPagoMontaje"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'PagoMontajeDataGridView
        '
        Me.PagoMontajeDataGridView.AllowUserToAddRows = False
        Me.PagoMontajeDataGridView.AllowUserToDeleteRows = False
        Me.PagoMontajeDataGridView.AutoGenerateColumns = False
        Me.PagoMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagoMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn25})
        Me.PagoMontajeDataGridView.DataSource = Me.PagoMontajeBindingSource
        Me.PagoMontajeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagoMontajeDataGridView.Location = New System.Drawing.Point(1172, 551)
        Me.PagoMontajeDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PagoMontajeDataGridView.Name = "PagoMontajeDataGridView"
        Me.PagoMontajeDataGridView.ReadOnly = True
        Me.PagoMontajeDataGridView.RowHeadersWidth = 51
        Me.PagoMontajeDataGridView.Size = New System.Drawing.Size(948, 355)
        Me.PagoMontajeDataGridView.TabIndex = 14
        '
        'PendienteInstalador
        '
        Me.PendienteInstalador.DataPropertyName = "PendienteInstalador"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.PendienteInstalador.DefaultCellStyle = DataGridViewCellStyle8
        Me.PendienteInstalador.HeaderText = "Pendiente"
        Me.PendienteInstalador.MinimumWidth = 6
        Me.PendienteInstalador.Name = "PendienteInstalador"
        Me.PendienteInstalador.ReadOnly = True
        Me.PendienteInstalador.Width = 75
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Pagado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle9
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 75
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle10
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 75
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Itebis"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn15.HeaderText = "Itebis"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 75
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SubTotal"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn14.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FechaPAgo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdFacturaMontaje"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdFactura"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'FacturaMontajeDataGridView
        '
        Me.FacturaMontajeDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDataGridView.AllowUserToDeleteRows = False
        Me.FacturaMontajeDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.Total, Me.Pagado, Me.PendienteInstalador})
        Me.FacturaMontajeDataGridView.DataSource = Me.FacturaMontajeBindingSource
        Me.FacturaMontajeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturaMontajeDataGridView.Location = New System.Drawing.Point(4, 5)
        Me.FacturaMontajeDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaMontajeDataGridView.Name = "FacturaMontajeDataGridView"
        Me.FacturaMontajeDataGridView.ReadOnly = True
        Me.FacturaMontajeDataGridView.RowHeadersWidth = 51
        Me.FacturaMontajeDataGridView.Size = New System.Drawing.Size(1160, 536)
        Me.FacturaMontajeDataGridView.TabIndex = 13
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.BtnModificarFactura)
        Me.pnlCabecera.Controls.Add(IdEmpresaMontajeLabel)
        Me.pnlCabecera.Controls.Add(Me.BtnResumenPagos)
        Me.pnlCabecera.Controls.Add(CuentaLabel)
        Me.pnlCabecera.Controls.Add(Me.Button3)
        Me.pnlCabecera.Controls.Add(Me.CuentaTextBox)
        Me.pnlCabecera.Controls.Add(Me.EmailTextBox)
        Me.pnlCabecera.Controls.Add(Me.BtnResumenFactura)
        Me.pnlCabecera.Controls.Add(EmailLabel)
        Me.pnlCabecera.Controls.Add(Me.Telefono2TextBox)
        Me.pnlCabecera.Controls.Add(BancoLabel)
        Me.pnlCabecera.Controls.Add(Telefono2Label)
        Me.pnlCabecera.Controls.Add(Me.BancoTextBox)
        Me.pnlCabecera.Controls.Add(Me.Label17)
        Me.pnlCabecera.Controls.Add(Me.Telefono1TextBox)
        Me.pnlCabecera.Controls.Add(Telefono1Label)
        Me.pnlCabecera.Controls.Add(Me.Label15)
        Me.pnlCabecera.Controls.Add(Me.RazonSocialComboBox)
        Me.pnlCabecera.Controls.Add(Me.Label14)
        Me.pnlCabecera.Controls.Add(RazonSocialLabel)
        Me.pnlCabecera.Controls.Add(Me.Label13)
        Me.pnlCabecera.Controls.Add(Me.IdEmpresaMontajeTextBox)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.Label7)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.Label8)
        Me.pnlCabecera.Controls.Add(Me.Label4)
        Me.pnlCabecera.Controls.Add(Me.Label9)
        Me.pnlCabecera.Controls.Add(Me.Label3)
        Me.pnlCabecera.Controls.Add(Me.Label10)
        Me.pnlCabecera.Controls.Add(Me.Label6)
        Me.pnlCabecera.Controls.Add(Me.Label11)
        Me.pnlCabecera.Controls.Add(Me.Label5)
        Me.pnlCabecera.Controls.Add(Me.Label12)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 31)
        Me.pnlCabecera.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(2124, 280)
        Me.pnlCabecera.TabIndex = 40
        '
        'BtnModificarFactura
        '
        Me.BtnModificarFactura.Location = New System.Drawing.Point(936, 140)
        Me.BtnModificarFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnModificarFactura.Name = "BtnModificarFactura"
        Me.BtnModificarFactura.Size = New System.Drawing.Size(159, 31)
        Me.BtnModificarFactura.TabIndex = 40
        Me.BtnModificarFactura.Text = "Modificar Factura"
        Me.BtnModificarFactura.UseVisualStyleBackColor = True
        '
        'BtnResumenPagos
        '
        Me.BtnResumenPagos.Location = New System.Drawing.Point(936, 55)
        Me.BtnResumenPagos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnResumenPagos.Name = "BtnResumenPagos"
        Me.BtnResumenPagos.Size = New System.Drawing.Size(159, 31)
        Me.BtnResumenPagos.TabIndex = 34
        Me.BtnResumenPagos.Text = "Resume Pagos"
        Me.BtnResumenPagos.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(367, 214)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 31)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Nueva Empresa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CuentaTextBox
        '
        Me.CuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Cuenta", True))
        Me.CuentaTextBox.Location = New System.Drawing.Point(461, 10)
        Me.CuentaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CuentaTextBox.Name = "CuentaTextBox"
        Me.CuentaTextBox.Size = New System.Drawing.Size(196, 26)
        Me.CuentaTextBox.TabIndex = 38
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(170, 174)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(180, 26)
        Me.EmailTextBox.TabIndex = 10
        '
        'Telefono2TextBox
        '
        Me.Telefono2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Telefono2", True))
        Me.Telefono2TextBox.Location = New System.Drawing.Point(170, 134)
        Me.Telefono2TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Telefono2TextBox.Name = "Telefono2TextBox"
        Me.Telefono2TextBox.Size = New System.Drawing.Size(180, 26)
        Me.Telefono2TextBox.TabIndex = 8
        '
        'BancoTextBox
        '
        Me.BancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Banco", True))
        Me.BancoTextBox.Location = New System.Drawing.Point(170, 211)
        Me.BancoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BancoTextBox.Name = "BancoTextBox"
        Me.BancoTextBox.Size = New System.Drawing.Size(180, 26)
        Me.BancoTextBox.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(719, 214)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 22)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Label17"
        '
        'Telefono1TextBox
        '
        Me.Telefono1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "Telefono1", True))
        Me.Telefono1TextBox.Location = New System.Drawing.Point(170, 94)
        Me.Telefono1TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Telefono1TextBox.Name = "Telefono1TextBox"
        Me.Telefono1TextBox.Size = New System.Drawing.Size(180, 26)
        Me.Telefono1TextBox.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(633, 214)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 22)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Proyecto"
        '
        'RazonSocialComboBox
        '
        Me.RazonSocialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "RazonSocial", True))
        Me.RazonSocialComboBox.FormattingEnabled = True
        Me.RazonSocialComboBox.Location = New System.Drawing.Point(170, 52)
        Me.RazonSocialComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RazonSocialComboBox.Name = "RazonSocialComboBox"
        Me.RazonSocialComboBox.Size = New System.Drawing.Size(180, 28)
        Me.RazonSocialComboBox.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(714, 178)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 22)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(633, 176)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 22)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Cliente"
        '
        'IdEmpresaMontajeTextBox
        '
        Me.IdEmpresaMontajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasContratadasMontajeBindingSource, "IdEmpresaMontaje", True))
        Me.IdEmpresaMontajeTextBox.Location = New System.Drawing.Point(170, 12)
        Me.IdEmpresaMontajeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdEmpresaMontajeTextBox.Name = "IdEmpresaMontajeTextBox"
        Me.IdEmpresaMontajeTextBox.Size = New System.Drawing.Size(180, 26)
        Me.IdEmpresaMontajeTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(389, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Facturado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(802, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(478, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(645, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Pendiente Asignar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(389, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pagado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(802, 96)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 22)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(478, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(645, 96)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 22)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Asignado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(389, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Pendiente"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(802, 55)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 22)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Total"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(478, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(645, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 22)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Pagado"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FacturaMontajeDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PagoMontajeDetalleDataGridView, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FacturaMontajeDetalleDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PagoMontajeDataGridView, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 311)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2124, 911)
        Me.TableLayoutPanel1.TabIndex = 41
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IdFacturaMontajeDetalle"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IdFacturaMontajeDetalle"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn31.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 125
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
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn33.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn33.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle2
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 125
        '
        'TotalPartida
        '
        Me.TotalPartida.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.TotalPartida.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalPartida.HeaderText = "Total"
        Me.TotalPartida.MinimumWidth = 6
        Me.TotalPartida.Name = "TotalPartida"
        Me.TotalPartida.ReadOnly = True
        Me.TotalPartida.Width = 125
        '
        'FrmEmpresaMontaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2124, 1222)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.EmpresasContratadasMontajeBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmEmpresaMontaje"
        Me.Text = "FrmEmpresaMontaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EmpresasContratadasMontajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasContratadasMontajeBindingNavigator.ResumeLayout(False)
        Me.EmpresasContratadasMontajeBindingNavigator.PerformLayout()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPagosMontaje As ModuloGestion.DsPagosMontaje
    Friend WithEvents EmpresasContratadasMontajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasContratadasMontajeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmpresasContratadasMontajeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PagoMontajeTableAdapter As ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeTableAdapter
    Friend WithEvents PagoMontajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacturaMontajeBindingSource As BindingSource
    Friend WithEvents FacturaMontajeTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter
    Friend WithEvents PagoMontajeDetalleBindingSource As BindingSource
    Friend WithEvents PagoMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter
    Friend WithEvents BtnResumenFactura As Button
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager1 As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents DsProyectos As DsProyectos
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager2 As DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents DsClientes As DsClientes
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager3 As DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents FacturaMontajeDetalleBindingSource As BindingSource
    Friend WithEvents FacturaMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DsArticulos As DsArticulos
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents FacturaMontajeDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaMontaje As DataGridViewTextBoxColumn
    Friend WithEvents PagoMontajeDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents PagoMontajeDataGridView As DataGridView
    Friend WithEvents PendienteInstalador As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FacturaMontajeDataGridView As DataGridView
    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Telefono2TextBox As TextBox
    Friend WithEvents Telefono1TextBox As TextBox
    Friend WithEvents RazonSocialComboBox As ComboBox
    Friend WithEvents IdEmpresaMontajeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnResumenPagos As Button
    Friend WithEvents BancoTextBox As TextBox
    Friend WithEvents CuentaTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnModificarFactura As Button
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents TotalPartida As DataGridViewTextBoxColumn
End Class
