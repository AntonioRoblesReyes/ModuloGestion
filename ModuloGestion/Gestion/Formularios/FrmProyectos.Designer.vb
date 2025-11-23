<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProyectos
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
        Dim Id_ProyectoLabel As System.Windows.Forms.Label
        Dim Nombre_ProyectoLabel As System.Windows.Forms.Label
        Dim Direccion_ProyectoLabel As System.Windows.Forms.Label
        Dim Impuesto As System.Windows.Forms.Label
        Dim Pais_ProyectoLabel As System.Windows.Forms.Label
        Dim DatosLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProyectos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ImpRD = New System.Windows.Forms.TextBox()
        Me.TotRD = New System.Windows.Forms.TextBox()
        Me.SubRD = New System.Windows.Forms.TextBox()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectosDetalle = New ModuloGestion.DsProyectosDetalle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnResumenMontaje = New System.Windows.Forms.Button()
        Me.BtnVerOrden = New System.Windows.Forms.Button()
        Me.txtdatos = New System.Windows.Forms.TextBox()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnRevisionArticulos = New System.Windows.Forms.Button()
        Me.BtnPendienteEntregas = New System.Windows.Forms.Button()
        Me.ImpuestoventaTextBox = New System.Windows.Forms.TextBox()
        Me.BtmNotasEntrega = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.BtnCarpetas = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnEstadoEntregas = New System.Windows.Forms.Button()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.TxtIdFiscalCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbBuscraEstado = New System.Windows.Forms.ComboBox()
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorImpuestoUs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPresupuestoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorImpuestoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPresupuestoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Ejecutado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.TxtIdProyecto = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Direccion_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Ciudad_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Pais_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDetalleHerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDetalleHerrajes = New ModuloGestion.DsPresupuestoDetalleHerrajes()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.ProyectosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProyectosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DsProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosDetalleTableAdapter = New ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter()
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.CmdCerrar = New System.Windows.Forms.Button()
        Me.CmdNuevoPresupuesto = New System.Windows.Forms.Button()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.BtnFacturas = New System.Windows.Forms.Button()
        Me.BtnEstadoProyecto = New System.Windows.Forms.Button()
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnAnalisisProyecto = New System.Windows.Forms.Button()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetalle = New ModuloGestion.DsPresupuestoDetalle()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetalleTableAdapter = New ModuloGestion.DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestoDetalleTableAdapters.TableAdapterManager()
        Me.DsPresupuestoDetallePintura = New ModuloGestion.DsPresupuestoDetallePintura()
        Me.PresupuestoDetallePinturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoDetallePinturaTableAdapter = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager()
        Me.PresupuestoDetalleHerrajesTableAdapter = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager()
        Me.DsPreciosCompraProyecto = New ModuloGestion.DsPreciosCompraProyecto()
        Me.PreciosCompraProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreciosCompraProyectoTableAdapter = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter()
        Me.TableAdapterManager6 = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager()
        Me.SiguientePrespuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TableAdapterManager7 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Id_ProyectoLabel = New System.Windows.Forms.Label()
        Nombre_ProyectoLabel = New System.Windows.Forms.Label()
        Direccion_ProyectoLabel = New System.Windows.Forms.Label()
        Impuesto = New System.Windows.Forms.Label()
        Pais_ProyectoLabel = New System.Windows.Forms.Label()
        DatosLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProyectosBindingNavigator.SuspendLayout()
        CType(Me.DsProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiguientePrespuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ProyectoLabel
        '
        Id_ProyectoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_ProyectoLabel.Location = New System.Drawing.Point(9, 27)
        Id_ProyectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ProyectoLabel.Name = "Id_ProyectoLabel"
        Id_ProyectoLabel.Size = New System.Drawing.Size(100, 25)
        Id_ProyectoLabel.TabIndex = 2
        Id_ProyectoLabel.Text = "Id Proyecto:"
        '
        'Nombre_ProyectoLabel
        '
        Nombre_ProyectoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Nombre_ProyectoLabel.Location = New System.Drawing.Point(9, 59)
        Nombre_ProyectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_ProyectoLabel.Name = "Nombre_ProyectoLabel"
        Nombre_ProyectoLabel.Size = New System.Drawing.Size(100, 25)
        Nombre_ProyectoLabel.TabIndex = 4
        Nombre_ProyectoLabel.Text = "Nombre Proyecto:"
        '
        'Direccion_ProyectoLabel
        '
        Direccion_ProyectoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Direccion_ProyectoLabel.Location = New System.Drawing.Point(9, 94)
        Direccion_ProyectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Direccion_ProyectoLabel.Name = "Direccion_ProyectoLabel"
        Direccion_ProyectoLabel.Size = New System.Drawing.Size(100, 25)
        Direccion_ProyectoLabel.TabIndex = 6
        Direccion_ProyectoLabel.Text = "Direccion Proyecto:"
        '
        'Impuesto
        '
        Impuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Impuesto.Location = New System.Drawing.Point(931, 24)
        Impuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Impuesto.Name = "Impuesto"
        Impuesto.Size = New System.Drawing.Size(67, 25)
        Impuesto.TabIndex = 8
        Impuesto.Text = "Impuesto"
        '
        'Pais_ProyectoLabel
        '
        Pais_ProyectoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Pais_ProyectoLabel.Location = New System.Drawing.Point(9, 130)
        Pais_ProyectoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Pais_ProyectoLabel.Name = "Pais_ProyectoLabel"
        Pais_ProyectoLabel.Size = New System.Drawing.Size(100, 25)
        Pais_ProyectoLabel.TabIndex = 10
        Pais_ProyectoLabel.Text = "Pais Proyecto:"
        '
        'DatosLabel
        '
        DatosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DatosLabel.Location = New System.Drawing.Point(468, 130)
        DatosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DatosLabel.Name = "DatosLabel"
        DatosLabel.Size = New System.Drawing.Size(100, 25)
        DatosLabel.TabIndex = 14
        DatosLabel.Text = "Datos:"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_FiscalLabel.Location = New System.Drawing.Point(261, 27)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(116, 25)
        Id_FiscalLabel.TabIndex = 19
        Id_FiscalLabel.Text = "Id Fiscal Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.ImpRD)
        Me.GroupBox1.Controls.Add(Me.TotRD)
        Me.GroupBox1.Controls.Add(Me.SubRD)
        Me.GroupBox1.Controls.Add(Me.Id_EmpresaTextBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BtnResumenMontaje)
        Me.GroupBox1.Controls.Add(Me.BtnVerOrden)
        Me.GroupBox1.Controls.Add(Me.txtdatos)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnRevisionArticulos)
        Me.GroupBox1.Controls.Add(Me.BtnPendienteEntregas)
        Me.GroupBox1.Controls.Add(Me.ImpuestoventaTextBox)
        Me.GroupBox1.Controls.Add(Me.BtmNotasEntrega)
        Me.GroupBox1.Controls.Add(Me.BtnCompras)
        Me.GroupBox1.Controls.Add(Me.BtnCarpetas)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.BtnEstadoEntregas)
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox1.Controls.Add(Id_FiscalLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdFiscalCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CmbBuscraEstado)
        Me.GroupBox1.Controls.Add(Me.PresupuestoDataGridView)
        Me.GroupBox1.Controls.Add(Id_ProyectoLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdProyecto)
        Me.GroupBox1.Controls.Add(Nombre_ProyectoLabel)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Direccion_ProyectoLabel)
        Me.GroupBox1.Controls.Add(Me.Direccion_ProyectoTextBox)
        Me.GroupBox1.Controls.Add(Impuesto)
        Me.GroupBox1.Controls.Add(Me.Ciudad_ProyectoTextBox)
        Me.GroupBox1.Controls.Add(Pais_ProyectoLabel)
        Me.GroupBox1.Controls.Add(Me.Pais_ProyectoTextBox)
        Me.GroupBox1.Controls.Add(DatosLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1481, 540)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(760, 17)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 26)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "Duplicar Presupuesto"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(1278, 102)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 26)
        Me.Button5.TabIndex = 50
        Me.Button5.Text = "Resumen Montanje"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(1278, 31)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 26)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "Pagos Montaje"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ImpRD
        '
        Me.ImpRD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImpRD.Location = New System.Drawing.Point(789, 482)
        Me.ImpRD.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpRD.Name = "ImpRD"
        Me.ImpRD.Size = New System.Drawing.Size(132, 22)
        Me.ImpRD.TabIndex = 48
        Me.ImpRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotRD
        '
        Me.TotRD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotRD.Location = New System.Drawing.Point(931, 482)
        Me.TotRD.Margin = New System.Windows.Forms.Padding(4)
        Me.TotRD.Name = "TotRD"
        Me.TotRD.Size = New System.Drawing.Size(132, 22)
        Me.TotRD.TabIndex = 47
        Me.TotRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubRD
        '
        Me.SubRD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubRD.Location = New System.Drawing.Point(648, 482)
        Me.SubRD.Margin = New System.Windows.Forms.Padding(4)
        Me.SubRD.Name = "SubRD"
        Me.SubRD.Size = New System.Drawing.Size(132, 22)
        Me.SubRD.TabIndex = 46
        Me.SubRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosDetalleBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(468, 59)
        Me.Id_EmpresaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(72, 22)
        Me.Id_EmpresaTextBox.TabIndex = 45
        '
        'ProyectosDetalleBindingSource
        '
        Me.ProyectosDetalleBindingSource.DataMember = "ProyectosDetalle"
        Me.ProyectosDetalleBindingSource.DataSource = Me.DsProyectosDetalle
        '
        'DsProyectosDetalle
        '
        Me.DsProyectosDetalle.DataSetName = "DsProyectosDetalle"
        Me.DsProyectosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1107, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 26)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Compras Presupuesto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnResumenMontaje
        '
        Me.BtnResumenMontaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResumenMontaje.Location = New System.Drawing.Point(1278, 68)
        Me.BtnResumenMontaje.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnResumenMontaje.Name = "BtnResumenMontaje"
        Me.BtnResumenMontaje.Size = New System.Drawing.Size(123, 26)
        Me.BtnResumenMontaje.TabIndex = 43
        Me.BtnResumenMontaje.Text = "Ver Gastos"
        Me.BtnResumenMontaje.UseVisualStyleBackColor = True
        '
        'BtnVerOrden
        '
        Me.BtnVerOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVerOrden.Location = New System.Drawing.Point(1142, 134)
        Me.BtnVerOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerOrden.Name = "BtnVerOrden"
        Me.BtnVerOrden.Size = New System.Drawing.Size(122, 26)
        Me.BtnVerOrden.TabIndex = 42
        Me.BtnVerOrden.Text = "Ver Orden"
        Me.BtnVerOrden.UseVisualStyleBackColor = True
        '
        'txtdatos
        '
        Me.txtdatos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Datos", True))
        Me.txtdatos.Location = New System.Drawing.Point(576, 130)
        Me.txtdatos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdatos.Name = "txtdatos"
        Me.txtdatos.Size = New System.Drawing.Size(403, 22)
        Me.txtdatos.TabIndex = 41
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DsProyectos
        '
        'DsProyectos
        '
        Me.DsProyectos.DataSetName = "DsProyectos"
        Me.DsProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1418, 126)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 40
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnRevisionArticulos
        '
        Me.BtnRevisionArticulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRevisionArticulos.Location = New System.Drawing.Point(1142, 102)
        Me.BtnRevisionArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRevisionArticulos.Name = "BtnRevisionArticulos"
        Me.BtnRevisionArticulos.Size = New System.Drawing.Size(122, 26)
        Me.BtnRevisionArticulos.TabIndex = 39
        Me.BtnRevisionArticulos.Text = "Revision Articulos"
        Me.BtnRevisionArticulos.UseVisualStyleBackColor = True
        '
        'BtnPendienteEntregas
        '
        Me.BtnPendienteEntregas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPendienteEntregas.Location = New System.Drawing.Point(936, 53)
        Me.BtnPendienteEntregas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPendienteEntregas.Name = "BtnPendienteEntregas"
        Me.BtnPendienteEntregas.Size = New System.Drawing.Size(163, 26)
        Me.BtnPendienteEntregas.TabIndex = 38
        Me.BtnPendienteEntregas.Text = "Pendiente Entregas"
        Me.BtnPendienteEntregas.UseVisualStyleBackColor = True
        '
        'ImpuestoventaTextBox
        '
        Me.ImpuestoventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Impuestoventa", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "## %"))
        Me.ImpuestoventaTextBox.Location = New System.Drawing.Point(1016, 23)
        Me.ImpuestoventaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpuestoventaTextBox.Name = "ImpuestoventaTextBox"
        Me.ImpuestoventaTextBox.Size = New System.Drawing.Size(50, 22)
        Me.ImpuestoventaTextBox.TabIndex = 36
        '
        'BtmNotasEntrega
        '
        Me.BtmNotasEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtmNotasEntrega.Location = New System.Drawing.Point(1278, 134)
        Me.BtmNotasEntrega.Margin = New System.Windows.Forms.Padding(4)
        Me.BtmNotasEntrega.Name = "BtmNotasEntrega"
        Me.BtmNotasEntrega.Size = New System.Drawing.Size(123, 26)
        Me.BtmNotasEntrega.TabIndex = 28
        Me.BtmNotasEntrega.Text = "Notas Entrega"
        Me.BtmNotasEntrega.UseVisualStyleBackColor = True
        '
        'BtnCompras
        '
        Me.BtnCompras.Location = New System.Drawing.Point(997, 94)
        Me.BtnCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(123, 26)
        Me.BtnCompras.TabIndex = 35
        Me.BtnCompras.Text = "Compras "
        Me.BtnCompras.UseVisualStyleBackColor = True
        '
        'BtnCarpetas
        '
        Me.BtnCarpetas.Location = New System.Drawing.Point(997, 127)
        Me.BtnCarpetas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCarpetas.Name = "BtnCarpetas"
        Me.BtnCarpetas.Size = New System.Drawing.Size(136, 26)
        Me.BtnCarpetas.TabIndex = 33
        Me.BtnCarpetas.Text = "Abrir Carpeta"
        Me.BtnCarpetas.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(760, 54)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 28)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Quitar Filtros"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnEstadoEntregas
        '
        Me.BtnEstadoEntregas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEstadoEntregas.Location = New System.Drawing.Point(1139, 66)
        Me.BtnEstadoEntregas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEstadoEntregas.Name = "BtnEstadoEntregas"
        Me.BtnEstadoEntregas.Size = New System.Drawing.Size(122, 26)
        Me.BtnEstadoEntregas.TabIndex = 31
        Me.BtnEstadoEntregas.Text = "Estado Entregas"
        Me.BtnEstadoEntregas.UseVisualStyleBackColor = True
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtImpuesto.Location = New System.Drawing.Point(360, 482)
        Me.TxtImpuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Size = New System.Drawing.Size(132, 22)
        Me.TxtImpuesto.TabIndex = 23
        Me.TxtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.Location = New System.Drawing.Point(501, 482)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(132, 22)
        Me.TxtTotal.TabIndex = 22
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubTotal.Location = New System.Drawing.Point(219, 482)
        Me.TxtSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(132, 22)
        Me.TxtSubTotal.TabIndex = 21
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIdFiscalCliente
        '
        Me.TxtIdFiscalCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Id_Fiscal", True))
        Me.TxtIdFiscalCliente.Enabled = False
        Me.TxtIdFiscalCliente.Location = New System.Drawing.Point(385, 27)
        Me.TxtIdFiscalCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdFiscalCliente.Name = "TxtIdFiscalCliente"
        Me.TxtIdFiscalCliente.Size = New System.Drawing.Size(181, 22)
        Me.TxtIdFiscalCliente.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(576, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Buscar Por Estado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CmbBuscraEstado
        '
        Me.CmbBuscraEstado.FormattingEnabled = True
        Me.CmbBuscraEstado.Items.AddRange(New Object() {"Pendiente", "Aprobado", "Entregado", "Cerrado", "Rechazado"})
        Me.CmbBuscraEstado.Location = New System.Drawing.Point(576, 58)
        Me.CmbBuscraEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBuscraEstado.Name = "CmbBuscraEstado"
        Me.CmbBuscraEstado.Size = New System.Drawing.Size(155, 24)
        Me.CmbBuscraEstado.TabIndex = 16
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PresupuestoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.IdPresupuestoDataGridViewTextBoxColumn, Me.DescripcionPresupuestoDataGridViewTextBoxColumn, Me.SubTotalUS, Me.ValorImpuestoUs, Me.TotalPresupuestoUS, Me.SubTotalRD, Me.ValorImpuestoRD, Me.TotalPresupuestoRD, Me.EstadoPresupuestoDataGridViewTextBoxColumn, Me.Orden, Me.Ver, Me.Ejecutado})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PresupuestoDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(9, 164)
        Me.PresupuestoDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(1464, 310)
        Me.PresupuestoDataGridView.TabIndex = 15
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'IdPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.HeaderText = "Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPresupuestoDataGridViewTextBoxColumn.Name = "IdPresupuestoDataGridViewTextBoxColumn"
        Me.IdPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPresupuestoDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionPresupuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Presupuesto"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.Name = "DescripcionPresupuestoDataGridViewTextBoxColumn"
        Me.DescripcionPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalUS
        '
        Me.SubTotalUS.DataPropertyName = "SubTotalUS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.SubTotalUS.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubTotalUS.HeaderText = "Sub US$"
        Me.SubTotalUS.MinimumWidth = 6
        Me.SubTotalUS.Name = "SubTotalUS"
        Me.SubTotalUS.ReadOnly = True
        Me.SubTotalUS.Width = 125
        '
        'ValorImpuestoUs
        '
        Me.ValorImpuestoUs.DataPropertyName = "ValorImpuestoUs"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.ValorImpuestoUs.DefaultCellStyle = DataGridViewCellStyle4
        Me.ValorImpuestoUs.HeaderText = "Imp US"
        Me.ValorImpuestoUs.MinimumWidth = 6
        Me.ValorImpuestoUs.Name = "ValorImpuestoUs"
        Me.ValorImpuestoUs.ReadOnly = True
        Me.ValorImpuestoUs.Width = 125
        '
        'TotalPresupuestoUS
        '
        Me.TotalPresupuestoUS.DataPropertyName = "TotalPresupuestoUS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalPresupuestoUS.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalPresupuestoUS.HeaderText = "Total US"
        Me.TotalPresupuestoUS.MinimumWidth = 6
        Me.TotalPresupuestoUS.Name = "TotalPresupuestoUS"
        Me.TotalPresupuestoUS.ReadOnly = True
        Me.TotalPresupuestoUS.Width = 125
        '
        'SubTotalRD
        '
        Me.SubTotalRD.DataPropertyName = "SubTotalRD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.SubTotalRD.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubTotalRD.HeaderText = "Sub RD"
        Me.SubTotalRD.MinimumWidth = 6
        Me.SubTotalRD.Name = "SubTotalRD"
        Me.SubTotalRD.ReadOnly = True
        Me.SubTotalRD.Width = 125
        '
        'ValorImpuestoRD
        '
        Me.ValorImpuestoRD.DataPropertyName = "ValorImpuestoRD"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.ValorImpuestoRD.DefaultCellStyle = DataGridViewCellStyle7
        Me.ValorImpuestoRD.HeaderText = "Imp RD"
        Me.ValorImpuestoRD.MinimumWidth = 6
        Me.ValorImpuestoRD.Name = "ValorImpuestoRD"
        Me.ValorImpuestoRD.ReadOnly = True
        Me.ValorImpuestoRD.Width = 125
        '
        'TotalPresupuestoRD
        '
        Me.TotalPresupuestoRD.DataPropertyName = "TotalPresupuestoRD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.TotalPresupuestoRD.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalPresupuestoRD.HeaderText = "Total RD"
        Me.TotalPresupuestoRD.MinimumWidth = 6
        Me.TotalPresupuestoRD.Name = "TotalPresupuestoRD"
        Me.TotalPresupuestoRD.ReadOnly = True
        Me.TotalPresupuestoRD.Width = 125
        '
        'EstadoPresupuestoDataGridViewTextBoxColumn
        '
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "Estado_Presupuesto"
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.Name = "EstadoPresupuestoDataGridViewTextBoxColumn"
        Me.EstadoPresupuestoDataGridViewTextBoxColumn.Width = 75
        '
        'Orden
        '
        Me.Orden.DataPropertyName = "OrdenDeCompra"
        Me.Orden.HeaderText = "Orden"
        Me.Orden.MinimumWidth = 6
        Me.Orden.Name = "Orden"
        Me.Orden.ReadOnly = True
        Me.Orden.Width = 125
        '
        'Ver
        '
        Me.Ver.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.Ver.HeaderText = "Ver"
        Me.Ver.MinimumWidth = 6
        Me.Ver.Name = "Ver"
        Me.Ver.Text = "Ir"
        Me.Ver.UseColumnTextForButtonValue = True
        Me.Ver.Width = 35
        '
        'Ejecutado
        '
        Me.Ejecutado.DataPropertyName = "Ejecutado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "#0 %"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Ejecutado.DefaultCellStyle = DataGridViewCellStyle9
        Me.Ejecutado.HeaderText = "Ejecutado"
        Me.Ejecutado.MinimumWidth = 6
        Me.Ejecutado.Name = "Ejecutado"
        Me.Ejecutado.Width = 75
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtIdProyecto
        '
        Me.TxtIdProyecto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Id_Proyecto", True))
        Me.TxtIdProyecto.Location = New System.Drawing.Point(139, 27)
        Me.TxtIdProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdProyecto.Name = "TxtIdProyecto"
        Me.TxtIdProyecto.Size = New System.Drawing.Size(113, 22)
        Me.TxtIdProyecto.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre_Proyecto", True))
        Me.TxtNombre.Location = New System.Drawing.Point(139, 59)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(320, 22)
        Me.TxtNombre.TabIndex = 5
        '
        'Direccion_ProyectoTextBox
        '
        Me.Direccion_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Direccion_Proyecto", True))
        Me.Direccion_ProyectoTextBox.Location = New System.Drawing.Point(139, 94)
        Me.Direccion_ProyectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Direccion_ProyectoTextBox.Name = "Direccion_ProyectoTextBox"
        Me.Direccion_ProyectoTextBox.Size = New System.Drawing.Size(320, 22)
        Me.Direccion_ProyectoTextBox.TabIndex = 7
        '
        'Ciudad_ProyectoTextBox
        '
        Me.Ciudad_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ciudad_Proyecto", True))
        Me.Ciudad_ProyectoTextBox.Location = New System.Drawing.Point(576, 94)
        Me.Ciudad_ProyectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Ciudad_ProyectoTextBox.Name = "Ciudad_ProyectoTextBox"
        Me.Ciudad_ProyectoTextBox.Size = New System.Drawing.Size(403, 22)
        Me.Ciudad_ProyectoTextBox.TabIndex = 9
        '
        'Pais_ProyectoTextBox
        '
        Me.Pais_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Pais_Proyecto", True))
        Me.Pais_ProyectoTextBox.Location = New System.Drawing.Point(139, 130)
        Me.Pais_ProyectoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Pais_ProyectoTextBox.Name = "Pais_ProyectoTextBox"
        Me.Pais_ProyectoTextBox.Size = New System.Drawing.Size(320, 22)
        Me.Pais_ProyectoTextBox.TabIndex = 11
        '
        'PresupuestoDetalleHerrajesBindingSource
        '
        Me.PresupuestoDetalleHerrajesBindingSource.DataMember = "PresupuestoDetalleHerrajes"
        Me.PresupuestoDetalleHerrajesBindingSource.DataSource = Me.DsPresupuestoDetalleHerrajes
        '
        'DsPresupuestoDetalleHerrajes
        '
        Me.DsPresupuestoDetalleHerrajes.DataSetName = "DsPresupuestoDetalleHerrajes"
        Me.DsPresupuestoDetalleHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosBindingNavigator
        '
        Me.ProyectosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProyectosBindingNavigator.BindingSource = Me.ProyectosBindingSource
        Me.ProyectosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProyectosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProyectosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProyectosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProyectosBindingNavigatorSaveItem})
        Me.ProyectosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProyectosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProyectosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProyectosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProyectosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProyectosBindingNavigator.Name = "ProyectosBindingNavigator"
        Me.ProyectosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProyectosBindingNavigator.Size = New System.Drawing.Size(1510, 27)
        Me.ProyectosBindingNavigator.TabIndex = 1
        Me.ProyectosBindingNavigator.Text = "BindingNavigator1"
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
        'ProyectosBindingNavigatorSaveItem
        '
        Me.ProyectosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProyectosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProyectosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProyectosBindingNavigatorSaveItem.Name = "ProyectosBindingNavigatorSaveItem"
        Me.ProyectosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ProyectosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DsProyectosDetalleBindingSource
        '
        Me.DsProyectosDetalleBindingSource.DataSource = Me.DsProyectosDetalle
        Me.DsProyectosDetalleBindingSource.Position = 0
        '
        'ProyectosDetalleTableAdapter
        '
        Me.ProyectosDetalleTableAdapter.ClearBeforeFill = True
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Location = New System.Drawing.Point(376, 2)
        Me.CmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(100, 28)
        Me.CmdGuardar.TabIndex = 20
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'CmdCerrar
        '
        Me.CmdCerrar.Location = New System.Drawing.Point(484, 2)
        Me.CmdCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCerrar.Name = "CmdCerrar"
        Me.CmdCerrar.Size = New System.Drawing.Size(100, 28)
        Me.CmdCerrar.TabIndex = 21
        Me.CmdCerrar.Text = "Cerrar"
        Me.CmdCerrar.UseVisualStyleBackColor = True
        '
        'CmdNuevoPresupuesto
        '
        Me.CmdNuevoPresupuesto.Location = New System.Drawing.Point(592, 2)
        Me.CmdNuevoPresupuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNuevoPresupuesto.Name = "CmdNuevoPresupuesto"
        Me.CmdNuevoPresupuesto.Size = New System.Drawing.Size(176, 28)
        Me.CmdNuevoPresupuesto.TabIndex = 22
        Me.CmdNuevoPresupuesto.Text = "Nuevo Presupuesto"
        Me.CmdNuevoPresupuesto.UseVisualStyleBackColor = True
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'BtnFacturas
        '
        Me.BtnFacturas.Location = New System.Drawing.Point(960, 2)
        Me.BtnFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFacturas.Name = "BtnFacturas"
        Me.BtnFacturas.Size = New System.Drawing.Size(176, 28)
        Me.BtnFacturas.TabIndex = 29
        Me.BtnFacturas.Text = "Facturas"
        Me.BtnFacturas.UseVisualStyleBackColor = True
        '
        'BtnEstadoProyecto
        '
        Me.BtnEstadoProyecto.Location = New System.Drawing.Point(1144, 2)
        Me.BtnEstadoProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEstadoProyecto.Name = "BtnEstadoProyecto"
        Me.BtnEstadoProyecto.Size = New System.Drawing.Size(176, 28)
        Me.BtnEstadoProyecto.TabIndex = 30
        Me.BtnEstadoProyecto.Text = "Estado Proyecto"
        Me.BtnEstadoProyecto.UseVisualStyleBackColor = True
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
        'BtnAnalisisProyecto
        '
        Me.BtnAnalisisProyecto.Location = New System.Drawing.Point(776, 2)
        Me.BtnAnalisisProyecto.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAnalisisProyecto.Name = "BtnAnalisisProyecto"
        Me.BtnAnalisisProyecto.Size = New System.Drawing.Size(176, 28)
        Me.BtnAnalisisProyecto.TabIndex = 31
        Me.BtnAnalisisProyecto.Text = "Analisis Proyecto"
        Me.BtnAnalisisProyecto.UseVisualStyleBackColor = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ProyectosDetalleTableAdapter = Me.ProyectosDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'DsPresupuestoDetallePintura
        '
        Me.DsPresupuestoDetallePintura.DataSetName = "DsPresupuestoDetallePintura"
        Me.DsPresupuestoDetallePintura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDetallePinturaBindingSource
        '
        Me.PresupuestoDetallePinturaBindingSource.DataMember = "PresupuestoDetallePintura"
        Me.PresupuestoDetallePinturaBindingSource.DataSource = Me.DsPresupuestoDetallePintura
        '
        'PresupuestoDetallePinturaTableAdapter
        '
        Me.PresupuestoDetallePinturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.PresupuestoDetallePinturaTableAdapter = Me.PresupuestoDetallePinturaTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PresupuestoDetalleHerrajesTableAdapter
        '
        Me.PresupuestoDetalleHerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.PresupuestoDetalleHerrajesTableAdapter = Me.PresupuestoDetalleHerrajesTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPreciosCompraProyecto
        '
        Me.DsPreciosCompraProyecto.DataSetName = "DsPreciosCompraProyecto"
        Me.DsPreciosCompraProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreciosCompraProyectoBindingSource
        '
        Me.PreciosCompraProyectoBindingSource.DataMember = "PreciosCompraProyecto"
        Me.PreciosCompraProyectoBindingSource.DataSource = Me.DsPreciosCompraProyecto
        '
        'PreciosCompraProyectoTableAdapter
        '
        Me.PreciosCompraProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.PreciosCompraProyectoTableAdapter = Me.PreciosCompraProyectoTableAdapter
        Me.TableAdapterManager6.UpdateOrder = ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1328, 2)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(203, 28)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Duplicar Precios Compra"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager7.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmProyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnAnalisisProyecto)
        Me.Controls.Add(Me.BtnEstadoProyecto)
        Me.Controls.Add(Me.BtnFacturas)
        Me.Controls.Add(Me.CmdNuevoPresupuesto)
        Me.Controls.Add(Me.CmdCerrar)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Controls.Add(Me.ProyectosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProyectos"
        Me.Text = "FrmProyectos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleHerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalleHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProyectosBindingNavigator.ResumeLayout(False)
        Me.ProyectosBindingNavigator.PerformLayout()
        CType(Me.DsProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestoDetallePintura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetallePinturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiguientePrespuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DsProyectos As ModuloGestion.DsProyectos
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProyectosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Direccion_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ciudad_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pais_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents CmbBuscraEstado As System.Windows.Forms.ComboBox
    Friend WithEvents DsProyectosDetalle As ModuloGestion.DsProyectosDetalle
    Friend WithEvents DsProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleTableAdapter As ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents CmdCerrar As System.Windows.Forms.Button
    Friend WithEvents TxtIdFiscalCliente As System.Windows.Forms.TextBox
    Friend WithEvents CmdNuevoPresupuesto As System.Windows.Forms.Button
    Friend WithEvents TxtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox

    Friend WithEvents PresupuestoDataGridView As System.Windows.Forms.DataGridView

    Friend WithEvents BtnEstadoEntregas As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtmNotasEntrega As System.Windows.Forms.Button
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiguientePresupuestoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn


    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents SiguientePrespuestoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents BtnCarpetas As System.Windows.Forms.Button
    Friend WithEvents BtnCompras As System.Windows.Forms.Button
    Friend WithEvents BtnFacturas As System.Windows.Forms.Button
    Friend WithEvents ImpuestoventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnEstadoProyecto As System.Windows.Forms.Button
    Friend WithEvents DsClientes As ModuloGestion.DsClientes
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents BtnPendienteEntregas As System.Windows.Forms.Button
    Friend WithEvents BtnRevisionArticulos As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtdatos As System.Windows.Forms.TextBox
    Friend WithEvents BtnVerOrden As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnResumenMontaje As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnAnalisisProyecto As System.Windows.Forms.Button
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPresupuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents ImpRD As System.Windows.Forms.TextBox
    Friend WithEvents TotRD As System.Windows.Forms.TextBox
    Friend WithEvents SubRD As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DsPresupuestoDetalle As DsPresupuestoDetalle
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleTableAdapter As DsPresupuestoDetalleTableAdapters.PresupuestoDetalleTableAdapter
    Friend WithEvents TableAdapterManager3 As DsPresupuestoDetalleTableAdapters.TableAdapterManager
    Friend WithEvents Button6 As Button
    Friend WithEvents DsPresupuestoDetallePintura As DsPresupuestoDetallePintura
    Friend WithEvents PresupuestoDetallePinturaBindingSource As BindingSource
    Friend WithEvents PresupuestoDetallePinturaTableAdapter As DsPresupuestoDetallePinturaTableAdapters.PresupuestoDetallePinturaTableAdapter
    Friend WithEvents TableAdapterManager4 As DsPresupuestoDetallePinturaTableAdapters.TableAdapterManager
    Friend WithEvents DsPresupuestoDetalleHerrajes As DsPresupuestoDetalleHerrajes
    Friend WithEvents PresupuestoDetalleHerrajesBindingSource As BindingSource
    Friend WithEvents PresupuestoDetalleHerrajesTableAdapter As DsPresupuestoDetalleHerrajesTableAdapters.PresupuestoDetalleHerrajesTableAdapter
    Friend WithEvents TableAdapterManager5 As DsPresupuestoDetalleHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents DsPreciosCompraProyecto As DsPreciosCompraProyecto
    Friend WithEvents PreciosCompraProyectoBindingSource As BindingSource
    Friend WithEvents PreciosCompraProyectoTableAdapter As DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter
    Friend WithEvents TableAdapterManager6 As DsPreciosCompraProyectoTableAdapters.TableAdapterManager
    Friend WithEvents Button7 As Button
    Friend WithEvents TableAdapterManager7 As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalUS As DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuestoUs As DataGridViewTextBoxColumn
    Friend WithEvents TotalPresupuestoUS As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalRD As DataGridViewTextBoxColumn
    Friend WithEvents ValorImpuestoRD As DataGridViewTextBoxColumn
    Friend WithEvents TotalPresupuestoRD As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Orden As DataGridViewTextBoxColumn
    Friend WithEvents Ver As DataGridViewButtonColumn
    Friend WithEvents Ejecutado As DataGridViewTextBoxColumn
End Class
