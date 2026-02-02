<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProveedoresListado
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsProveedores = New ModuloGestion.DsProveedores()
        Me.GestionEmpresaDataSet = New ModuloGestion.GestionEmpresaDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalCompraPoveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter()
        Me.TotalCompraPoveedorTableAdapter1 = New ModuloGestion.GestionEmpresaDataSetTableAdapters.TotalCompraPoveedorTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.BtnAceptarProveedor = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnVerProveedor = New System.Windows.Forms.Button()
        Me.BtnAceptarProveedorFactura = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LblEmpresa = New System.Windows.Forms.Label()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelProveedores = New System.Windows.Forms.Panel()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.IdProveedorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorFiscalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.CompraMaterialesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.CompraMaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalCompraUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoCompraUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionEmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCompraPoveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelProveedores.SuspendLayout()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotales.SuspendLayout()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "DsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GestionEmpresaDataSet
        '
        Me.GestionEmpresaDataSet.DataSetName = "GestionEmpresaDataSet"
        Me.GestionEmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsProveedores
        '
        'TotalCompraPoveedorBindingSource
        '
        Me.TotalCompraPoveedorBindingSource.DataMember = "TotalCompraPoveedor"
        Me.TotalCompraPoveedorBindingSource.DataSource = Me.GestionEmpresaDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TotalCompraPoveedorTableAdapter1
        '
        Me.TotalCompraPoveedorTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuentaAsociadaTableAdapter = Nothing
        Me.TableAdapterManager.FacturaProveedorTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.BtnAceptarProveedor)
        Me.PanelTop.Controls.Add(Me.BtnNuevo)
        Me.PanelTop.Controls.Add(Me.BtnVerProveedor)
        Me.PanelTop.Controls.Add(Me.BtnAceptarProveedorFactura)
        Me.PanelTop.Controls.Add(Me.TxtBuscar)
        Me.PanelTop.Controls.Add(Me.LblEmpresa)
        Me.PanelTop.Controls.Add(Me.LblProyecto)
        Me.PanelTop.Controls.Add(Me.LblPresupuesto)
        Me.PanelTop.Controls.Add(Me.Label4)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTop.Size = New System.Drawing.Size(1908, 120)
        Me.PanelTop.TabIndex = 2
        '
        'BtnAceptarProveedor
        '
        Me.BtnAceptarProveedor.Location = New System.Drawing.Point(10, 10)
        Me.BtnAceptarProveedor.Name = "BtnAceptarProveedor"
        Me.BtnAceptarProveedor.Size = New System.Drawing.Size(156, 28)
        Me.BtnAceptarProveedor.TabIndex = 0
        Me.BtnAceptarProveedor.Text = "Aceptar Proveedor"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(176, 10)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(156, 28)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnVerProveedor
        '
        Me.BtnVerProveedor.Location = New System.Drawing.Point(342, 10)
        Me.BtnVerProveedor.Name = "BtnVerProveedor"
        Me.BtnVerProveedor.Size = New System.Drawing.Size(156, 28)
        Me.BtnVerProveedor.TabIndex = 2
        Me.BtnVerProveedor.Text = "Ver Proveedor"
        '
        'BtnAceptarProveedorFactura
        '
        Me.BtnAceptarProveedorFactura.Location = New System.Drawing.Point(508, 10)
        Me.BtnAceptarProveedorFactura.Name = "BtnAceptarProveedorFactura"
        Me.BtnAceptarProveedorFactura.Size = New System.Drawing.Size(156, 28)
        Me.BtnAceptarProveedorFactura.TabIndex = 3
        Me.BtnAceptarProveedorFactura.Text = "Agregar Factura"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(508, 50)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(200, 22)
        Me.TxtBuscar.TabIndex = 4
        '
        'LblEmpresa
        '
        Me.LblEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(100, 23)
        Me.LblEmpresa.TabIndex = 5
        Me.LblEmpresa.Visible = False
        '
        'LblProyecto
        '
        Me.LblProyecto.Location = New System.Drawing.Point(0, 0)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(100, 23)
        Me.LblProyecto.TabIndex = 6
        Me.LblProyecto.Visible = False
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(100, 23)
        Me.LblPresupuesto.TabIndex = 7
        Me.LblPresupuesto.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Visible = False
        '
        'PanelProveedores
        '
        Me.PanelProveedores.Controls.Add(Me.ProveedoresDataGridView)
        Me.PanelProveedores.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProveedores.Location = New System.Drawing.Point(0, 120)
        Me.PanelProveedores.Name = "PanelProveedores"
        Me.PanelProveedores.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelProveedores.Size = New System.Drawing.Size(720, 578)
        Me.PanelProveedores.TabIndex = 1
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AllowUserToAddRows = False
        Me.ProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeight = 29
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn1, Me.RazonSocialDataGridViewTextBoxColumn1, Me.ValorFiscalDataGridViewCheckBoxColumn})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(10, 10)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.RowHeadersWidth = 51
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(700, 558)
        Me.ProveedoresDataGridView.TabIndex = 0
        '
        'PanelTotales
        '
        Me.PanelTotales.Controls.Add(Me.CompraMaterialesDataGridView)
        Me.PanelTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTotales.Location = New System.Drawing.Point(720, 120)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTotales.Size = New System.Drawing.Size(1188, 578)
        Me.PanelTotales.TabIndex = 0
        '
        'IdProveedorDataGridViewTextBoxColumn1
        '
        Me.IdProveedorDataGridViewTextBoxColumn1.DataPropertyName = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn1.HeaderText = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdProveedorDataGridViewTextBoxColumn1.Name = "IdProveedorDataGridViewTextBoxColumn1"
        Me.IdProveedorDataGridViewTextBoxColumn1.Width = 125
        '
        'RazonSocialDataGridViewTextBoxColumn1
        '
        Me.RazonSocialDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn1.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.RazonSocialDataGridViewTextBoxColumn1.Name = "RazonSocialDataGridViewTextBoxColumn1"
        '
        'ValorFiscalDataGridViewCheckBoxColumn
        '
        Me.ValorFiscalDataGridViewCheckBoxColumn.DataPropertyName = "ValorFiscal"
        Me.ValorFiscalDataGridViewCheckBoxColumn.HeaderText = "ValorFiscal"
        Me.ValorFiscalDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ValorFiscalDataGridViewCheckBoxColumn.Name = "ValorFiscalDataGridViewCheckBoxColumn"
        Me.ValorFiscalDataGridViewCheckBoxColumn.Width = 125
        '
        'DsCompras
        '
        Me.DsCompras.DataSetName = "DsCompras"
        Me.DsCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraMaterialesBindingSource1
        '
        Me.CompraMaterialesBindingSource1.DataMember = "CompraMateriales"
        Me.CompraMaterialesBindingSource1.DataSource = Me.DsCompras
        '
        'CompraMaterialesTableAdapter
        '
        Me.CompraMaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CompraMaterialesDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.PagoProveedorDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.PagoProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsComprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompraMaterialesDataGridView
        '
        Me.CompraMaterialesDataGridView.AllowUserToAddRows = False
        Me.CompraMaterialesDataGridView.AllowUserToDeleteRows = False
        Me.CompraMaterialesDataGridView.AutoGenerateColumns = False
        Me.CompraMaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompraMaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn15, Me.SubTotalCompraUS, Me.ImpuestoCompraUS, Me.DataGridViewTextBoxColumn14})
        Me.CompraMaterialesDataGridView.DataSource = Me.CompraMaterialesBindingSource1
        Me.CompraMaterialesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompraMaterialesDataGridView.Location = New System.Drawing.Point(10, 10)
        Me.CompraMaterialesDataGridView.Name = "CompraMaterialesDataGridView"
        Me.CompraMaterialesDataGridView.ReadOnly = True
        Me.CompraMaterialesDataGridView.RowHeadersWidth = 51
        Me.CompraMaterialesDataGridView.RowTemplate.Height = 24
        Me.CompraMaterialesDataGridView.Size = New System.Drawing.Size(1168, 558)
        Me.CompraMaterialesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Id_Compra"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Id_Compra"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha_Compra"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha_Compra"
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
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SubTotalCompraRD"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn11.HeaderText = "SubRD"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ImpuestoCompraRD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn12.HeaderText = "ImRD"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TotalCompraRD"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn15.HeaderText = "TotalRD"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'SubTotalCompraUS
        '
        Me.SubTotalCompraUS.DataPropertyName = "SubTotalCompraUS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "N2"
        Me.SubTotalCompraUS.DefaultCellStyle = DataGridViewCellStyle10
        Me.SubTotalCompraUS.HeaderText = "SubUS"
        Me.SubTotalCompraUS.MinimumWidth = 6
        Me.SubTotalCompraUS.Name = "SubTotalCompraUS"
        Me.SubTotalCompraUS.ReadOnly = True
        Me.SubTotalCompraUS.Width = 125
        '
        'ImpuestoCompraUS
        '
        Me.ImpuestoCompraUS.DataPropertyName = "ImpuestoCompraUS"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "N2"
        Me.ImpuestoCompraUS.DefaultCellStyle = DataGridViewCellStyle11
        Me.ImpuestoCompraUS.HeaderText = "ImpUS"
        Me.ImpuestoCompraUS.MinimumWidth = 6
        Me.ImpuestoCompraUS.Name = "ImpuestoCompraUS"
        Me.ImpuestoCompraUS.ReadOnly = True
        Me.ImpuestoCompraUS.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TotalCompraUS"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn14.HeaderText = "TotalUS"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'FrmProveedoresListado
        '
        Me.ClientSize = New System.Drawing.Size(1908, 698)
        Me.Controls.Add(Me.PanelTotales)
        Me.Controls.Add(Me.PanelProveedores)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "FrmProveedoresListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProveedoresListado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionEmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCompraPoveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelProveedores.ResumeLayout(False)
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotales.ResumeLayout(False)
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAceptarProveedor As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnVerProveedor As Button
    Friend WithEvents BtnAceptarProveedorFactura As Button
    Friend WithEvents TxtBuscar As TextBox

    Friend WithEvents ProveedoresDataGridView As DataGridView

    Friend WithEvents DsProveedores As ModuloGestion.DsProveedores
    Friend WithEvents DsCompras As ModuloGestion.DsCompras
    Friend WithEvents GestionEmpresaDataSet As ModuloGestion.GestionEmpresaDataSet

    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents CompraMaterialesBindingSource1 As BindingSource
    Friend WithEvents TotalCompraPoveedorBindingSource As BindingSource

    Friend WithEvents ProveedoresTableAdapter As ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter
    Friend WithEvents CompraMaterialesTableAdapter As ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TotalCompraPoveedorTableAdapter1 As ModuloGestion.GestionEmpresaDataSetTableAdapters.TotalCompraPoveedorTableAdapter

    Friend WithEvents LblEmpresa As Label
    Friend WithEvents LblProyecto As Label
    Friend WithEvents LblPresupuesto As Label
    Friend WithEvents Label4 As Label

    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelProveedores As Panel
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents TableAdapterManager As ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ValorFiscalDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CompraMaterialesDataGridView As DataGridView
    Friend WithEvents TableAdapterManager1 As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCompraUS As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoCompraUS As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
