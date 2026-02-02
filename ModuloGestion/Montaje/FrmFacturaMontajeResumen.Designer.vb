<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturaMontajeResumen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FacturaMontajeDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdFacturaMontaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresaMontaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPAgo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteInstalador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Imprimir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FacturaNcf = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FacturaMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPagosMontaje = New ModuloGestion.DsPagosMontaje()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FacturaMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New ModuloGestion.DsArticulos()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PagoMontajeDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoMontajeDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenComprasProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.ResumenComprasProyectoTableAdapter = New ModuloGestion.DsComprasTableAdapters.ResumenComprasProyectoTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FacturaMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager()
        Me.FacturaMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter()
        Me.PagoMontajeDetalleTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter()
        Me.EmpresasContratadasMontajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasContratadasMontajeTableAdapter = New ModuloGestion.DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter()
        Me.ArticulosTableAdapter = New ModuloGestion.DsArticulosTableAdapters.ArticulosTableAdapter()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenComprasProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaMontajeDataGridView
        '
        Me.FacturaMontajeDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDataGridView.AllowUserToDeleteRows = False
        Me.FacturaMontajeDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaMontaje, Me.IdEmpresaMontaje, Me.FechaPAgo, Me.Id_Proyecto, Me.Id_Presupuesto, Me.SubTotal, Me.Pagado, Me.PendienteInstalador, Me.Modificar, Me.Imprimir, Me.FacturaNcf})
        Me.FacturaMontajeDataGridView.DataSource = Me.FacturaMontajeBindingSource
        Me.FacturaMontajeDataGridView.Location = New System.Drawing.Point(18, 86)
        Me.FacturaMontajeDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaMontajeDataGridView.Name = "FacturaMontajeDataGridView"
        Me.FacturaMontajeDataGridView.ReadOnly = True
        Me.FacturaMontajeDataGridView.RowHeadersWidth = 51
        Me.FacturaMontajeDataGridView.Size = New System.Drawing.Size(1370, 519)
        Me.FacturaMontajeDataGridView.TabIndex = 1
        '
        'IdFacturaMontaje
        '
        Me.IdFacturaMontaje.DataPropertyName = "IdFacturaMontaje"
        Me.IdFacturaMontaje.HeaderText = "Id Factura"
        Me.IdFacturaMontaje.MinimumWidth = 6
        Me.IdFacturaMontaje.Name = "IdFacturaMontaje"
        Me.IdFacturaMontaje.ReadOnly = True
        Me.IdFacturaMontaje.Width = 75
        '
        'IdEmpresaMontaje
        '
        Me.IdEmpresaMontaje.DataPropertyName = "IdEmpresaMontaje"
        Me.IdEmpresaMontaje.HeaderText = "Id Empresa"
        Me.IdEmpresaMontaje.MinimumWidth = 6
        Me.IdEmpresaMontaje.Name = "IdEmpresaMontaje"
        Me.IdEmpresaMontaje.ReadOnly = True
        Me.IdEmpresaMontaje.Width = 75
        '
        'FechaPAgo
        '
        Me.FechaPAgo.DataPropertyName = "FechaPAgo"
        Me.FechaPAgo.HeaderText = "Fecha "
        Me.FechaPAgo.MinimumWidth = 6
        Me.FechaPAgo.Name = "FechaPAgo"
        Me.FechaPAgo.ReadOnly = True
        Me.FechaPAgo.Width = 75
        '
        'Id_Proyecto
        '
        Me.Id_Proyecto.DataPropertyName = "Id_Proyecto"
        Me.Id_Proyecto.HeaderText = " Proyecto"
        Me.Id_Proyecto.MinimumWidth = 6
        Me.Id_Proyecto.Name = "Id_Proyecto"
        Me.Id_Proyecto.ReadOnly = True
        Me.Id_Proyecto.Width = 75
        '
        'Id_Presupuesto
        '
        Me.Id_Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Id_Presupuesto.HeaderText = "Presupuesto"
        Me.Id_Presupuesto.MinimumWidth = 6
        Me.Id_Presupuesto.Name = "Id_Presupuesto"
        Me.Id_Presupuesto.ReadOnly = True
        Me.Id_Presupuesto.Width = 125
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
        Me.SubTotal.Width = 75
        '
        'Pagado
        '
        Me.Pagado.DataPropertyName = "Pagado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 75
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
        Me.PendienteInstalador.Width = 75
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.MinimumWidth = 6
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Width = 75
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.MinimumWidth = 6
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.ReadOnly = True
        Me.Imprimir.Width = 75
        '
        'FacturaNcf
        '
        Me.FacturaNcf.HeaderText = "FacturaNcf"
        Me.FacturaNcf.MinimumWidth = 8
        Me.FacturaNcf.Name = "FacturaNcf"
        Me.FacturaNcf.ReadOnly = True
        Me.FacturaNcf.Width = 75
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
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(809, 609)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(930, 609)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(1070, 609)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(1191, 609)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(1313, 609)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 31)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FacturaMontajeDetalleDataGridView
        '
        Me.FacturaMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.FacturaMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.FacturaMontajeDetalleDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.FacturaMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.FacturaMontajeDetalleDataGridView.DataSource = Me.FacturaMontajeDetalleBindingSource
        Me.FacturaMontajeDetalleDataGridView.Location = New System.Drawing.Point(18, 664)
        Me.FacturaMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FacturaMontajeDetalleDataGridView.Name = "FacturaMontajeDetalleDataGridView"
        Me.FacturaMontajeDetalleDataGridView.ReadOnly = True
        Me.FacturaMontajeDetalleDataGridView.RowHeadersVisible = False
        Me.FacturaMontajeDetalleDataGridView.RowHeadersWidth = 51
        Me.FacturaMontajeDetalleDataGridView.Size = New System.Drawing.Size(1370, 339)
        Me.FacturaMontajeDetalleDataGridView.TabIndex = 6
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
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn17.FillWeight = 26.99026!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 75
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Precio"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn18.FillWeight = 65.76938!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 75
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TotalPartida"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn19.FillWeight = 129.7843!
        Me.DataGridViewTextBoxColumn19.HeaderText = "TotalPartida"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 75
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn20.FillWeight = 267.3797!
        Me.DataGridViewTextBoxColumn20.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'FacturaMontajeDetalleBindingSource
        '
        Me.FacturaMontajeDetalleBindingSource.DataMember = "FacturaMontajeDetalle"
        Me.FacturaMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(508, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Proyecto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(393, 59)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descripcion Presupuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(608, 59)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(2, 22)
        Me.Label8.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(608, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(2, 22)
        Me.Label9.TabIndex = 10
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1848, 41)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Actualizar Saldos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PagoMontajeDetalleDataGridView
        '
        Me.PagoMontajeDetalleDataGridView.AllowUserToAddRows = False
        Me.PagoMontajeDetalleDataGridView.AllowUserToDeleteRows = False
        Me.PagoMontajeDetalleDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagoMontajeDetalleDataGridView.AutoGenerateColumns = False
        Me.PagoMontajeDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagoMontajeDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn23})
        Me.PagoMontajeDetalleDataGridView.DataSource = Me.PagoMontajeDetalleBindingSource
        Me.PagoMontajeDetalleDataGridView.Location = New System.Drawing.Point(1396, 85)
        Me.PagoMontajeDetalleDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PagoMontajeDetalleDataGridView.Name = "PagoMontajeDetalleDataGridView"
        Me.PagoMontajeDetalleDataGridView.ReadOnly = True
        Me.PagoMontajeDetalleDataGridView.RowHeadersVisible = False
        Me.PagoMontajeDetalleDataGridView.RowHeadersWidth = 51
        Me.PagoMontajeDetalleDataGridView.Size = New System.Drawing.Size(278, 519)
        Me.PagoMontajeDetalleDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IdPagoMontaje"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IdPago"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TotalPagado"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn23.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 75
        '
        'PagoMontajeDetalleBindingSource
        '
        Me.PagoMontajeDetalleBindingSource.DataMember = "PagoMontajeDetalle"
        Me.PagoMontajeDetalleBindingSource.DataSource = Me.DsPagosMontaje
        '
        'ResumenComprasProyectoBindingSource
        '
        Me.ResumenComprasProyectoBindingSource.DataMember = "ResumenComprasProyecto"
        Me.ResumenComprasProyectoBindingSource.DataSource = Me.DsCompras
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResumenComprasProyectoTableAdapter
        '
        Me.ResumenComprasProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.CompraMaterialesDetalleTableAdapter = Nothing
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager3.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(973, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 13
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
        Me.TableAdapterManager.PagoMontajeTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosMontajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaMontajeDetalleTableAdapter
        '
        Me.FacturaMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'PagoMontajeDetalleTableAdapter
        '
        Me.PagoMontajeDetalleTableAdapter.ClearBeforeFill = True
        '
        'EmpresasContratadasMontajeBindingSource
        '
        Me.EmpresasContratadasMontajeBindingSource.DataMember = "EmpresasContratadasMontaje"
        Me.EmpresasContratadasMontajeBindingSource.DataSource = Me.DsPagosMontaje
        '
        'EmpresasContratadasMontajeTableAdapter
        '
        Me.EmpresasContratadasMontajeTableAdapter.ClearBeforeFill = True
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(1213, 20)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(163, 26)
        Me.TxtFiltro.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(1070, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Filtrar Proyecto"
        '
        'FrmFacturaMontajeResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2048, 1042)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PagoMontajeDetalleDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FacturaMontajeDetalleDataGridView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FacturaMontajeDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmFacturaMontajeResumen"
        Me.Text = "FrmFacturaMontaje"
        CType(Me.FacturaMontajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosMontaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoMontajeDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenComprasProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasContratadasMontajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPagosMontaje As DsPagosMontaje
    Friend WithEvents FacturaMontajeBindingSource As BindingSource
    Friend WithEvents FacturaMontajeTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeTableAdapter
    Friend WithEvents TableAdapterManager As DsPagosMontajeTableAdapters.TableAdapterManager
    Friend WithEvents FacturaMontajeDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FacturaMontajeDetalleBindingSource As BindingSource
    Friend WithEvents FacturaMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.FacturaMontajeDetalleTableAdapter
    Friend WithEvents FacturaMontajeDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager1 As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents DsProyectos As DsProyectos
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager2 As DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents PagoMontajeDetalleBindingSource As BindingSource
    Friend WithEvents PagoMontajeDetalleTableAdapter As DsPagosMontajeTableAdapters.PagoMontajeDetalleTableAdapter
    Friend WithEvents PagoMontajeDetalleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents ResumenComprasProyectoBindingSource As BindingSource
    Friend WithEvents ResumenComprasProyectoTableAdapter As DsComprasTableAdapters.ResumenComprasProyectoTableAdapter
    Friend WithEvents TableAdapterManager3 As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents Label10 As Label
    Friend WithEvents EmpresasContratadasMontajeBindingSource As BindingSource
    Friend WithEvents EmpresasContratadasMontajeTableAdapter As DsPagosMontajeTableAdapters.EmpresasContratadasMontajeTableAdapter
    Friend WithEvents DsArticulos As DsArticulos
    Friend WithEvents ArticulosBindingSource As BindingSource
    Friend WithEvents ArticulosTableAdapter As DsArticulosTableAdapters.ArticulosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaMontaje As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaMontaje As DataGridViewTextBoxColumn
    Friend WithEvents FechaPAgo As DataGridViewTextBoxColumn
    Friend WithEvents Id_Proyecto As DataGridViewTextBoxColumn
    Friend WithEvents Id_Presupuesto As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents PendienteInstalador As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewButtonColumn
    Friend WithEvents Imprimir As DataGridViewButtonColumn
    Friend WithEvents FacturaNcf As DataGridViewButtonColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents TxtFiltro As TextBox
    Friend WithEvents Label11 As Label
End Class
