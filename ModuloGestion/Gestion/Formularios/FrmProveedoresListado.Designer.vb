<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProveedoresListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedoresListado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnAceptarProveedor = New System.Windows.Forms.Button()
        Me.BtnVerProveedor = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnAceptarProveedorFactura = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorFiscal = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProveedores = New ModuloGestion.DsProveedores()
        Me.ProveedoresTableAdapter = New ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager()
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.ProveedoresBindingNavigatorSaveItem1 = New System.Windows.Forms.ToolStripButton()
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.CompraMaterialesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()
        Me.LblEmpresa = New System.Windows.Forms.Label()
        Me.LblProyecto = New System.Windows.Forms.Label()
        Me.LblPresupuesto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalesCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalCompraPoveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalCompraPoveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalCompraPoveedorBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalCompraPoveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdProveedorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotRDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCompraPoveedorBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionEmpresaDataSet = New ModuloGestion.GestionEmpresaDataSet()
        Me.TotalCompraPoveedorTableAdapter1 = New ModuloGestion.GestionEmpresaDataSetTableAdapters.TotalCompraPoveedorTableAdapter()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraMaterialesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalesCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCompraPoveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCompraPoveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCompraPoveedorBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCompraPoveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCompraPoveedorBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionEmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ProveedoresBindingNavigatorSaveItem
        '
        Me.ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedoresBindingNavigatorSaveItem.Name = "ProveedoresBindingNavigatorSaveItem"
        Me.ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BtnAceptarProveedor
        '
        Me.BtnAceptarProveedor.Location = New System.Drawing.Point(28, 79)
        Me.BtnAceptarProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAceptarProveedor.Name = "BtnAceptarProveedor"
        Me.BtnAceptarProveedor.Size = New System.Drawing.Size(156, 28)
        Me.BtnAceptarProveedor.TabIndex = 2
        Me.BtnAceptarProveedor.Text = "Aceptar Proveedor"
        Me.BtnAceptarProveedor.UseVisualStyleBackColor = True
        '
        'BtnVerProveedor
        '
        Me.BtnVerProveedor.Location = New System.Drawing.Point(356, 81)
        Me.BtnVerProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVerProveedor.Name = "BtnVerProveedor"
        Me.BtnVerProveedor.Size = New System.Drawing.Size(156, 28)
        Me.BtnVerProveedor.TabIndex = 4
        Me.BtnVerProveedor.Text = "Ver Proveedor"
        Me.BtnVerProveedor.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(192, 82)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(156, 28)
        Me.BtnNuevo.TabIndex = 5
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnAceptarProveedorFactura
        '
        Me.BtnAceptarProveedorFactura.Location = New System.Drawing.Point(537, 49)
        Me.BtnAceptarProveedorFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAceptarProveedorFactura.Name = "BtnAceptarProveedorFactura"
        Me.BtnAceptarProveedorFactura.Size = New System.Drawing.Size(156, 28)
        Me.BtnAceptarProveedorFactura.TabIndex = 10
        Me.BtnAceptarProveedorFactura.Text = "Agregar Factura"
        Me.BtnAceptarProveedorFactura.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(537, 85)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(177, 22)
        Me.TxtBuscar.TabIndex = 11
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AllowUserToAddRows = False
        Me.ProveedoresDataGridView.AllowUserToDeleteRows = False
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.ValorFiscal})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(28, 133)
        Me.ProveedoresDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.RowHeadersWidth = 51
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(686, 551)
        Me.ProveedoresDataGridView.TabIndex = 12
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Width = 125
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorFiscal
        '
        Me.ValorFiscal.DataPropertyName = "ValorFiscal"
        Me.ValorFiscal.HeaderText = "ValorFiscal"
        Me.ValorFiscal.MinimumWidth = 6
        Me.ValorFiscal.Name = "ValorFiscal"
        Me.ValorFiscal.Width = 75
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DsProveedores
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "DsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuentaAsociadaTableAdapter = Nothing
        Me.TableAdapterManager.FacturaProveedorTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.ProveedoresBindingNavigator.DeleteItem = Nothing
        Me.ProveedoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ProveedoresBindingNavigatorSaveItem1})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(1908, 27)
        Me.ProveedoresBindingNavigator.TabIndex = 13
        Me.ProveedoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'ProveedoresBindingNavigatorSaveItem1
        '
        Me.ProveedoresBindingNavigatorSaveItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedoresBindingNavigatorSaveItem1.Image = CType(resources.GetObject("ProveedoresBindingNavigatorSaveItem1.Image"), System.Drawing.Image)
        Me.ProveedoresBindingNavigatorSaveItem1.Name = "ProveedoresBindingNavigatorSaveItem1"
        Me.ProveedoresBindingNavigatorSaveItem1.Size = New System.Drawing.Size(29, 24)
        Me.ProveedoresBindingNavigatorSaveItem1.Text = "Guardar datos"
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
        'LblEmpresa
        '
        Me.LblEmpresa.AutoSize = True
        Me.LblEmpresa.Location = New System.Drawing.Point(56, 113)
        Me.LblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(80, 16)
        Me.LblEmpresa.TabIndex = 6
        Me.LblEmpresa.Text = "LblEmpresa"
        Me.LblEmpresa.Visible = False
        '
        'LblProyecto
        '
        Me.LblProyecto.AutoSize = True
        Me.LblProyecto.Location = New System.Drawing.Point(148, 114)
        Me.LblProyecto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProyecto.Name = "LblProyecto"
        Me.LblProyecto.Size = New System.Drawing.Size(79, 16)
        Me.LblProyecto.TabIndex = 7
        Me.LblProyecto.Text = "LblProyecto"
        Me.LblProyecto.Visible = False
        '
        'LblPresupuesto
        '
        Me.LblPresupuesto.AutoSize = True
        Me.LblPresupuesto.Location = New System.Drawing.Point(241, 114)
        Me.LblPresupuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPresupuesto.Name = "LblPresupuesto"
        Me.LblPresupuesto.Size = New System.Drawing.Size(101, 16)
        Me.LblPresupuesto.TabIndex = 8
        Me.LblPresupuesto.Text = "LblPresupuesto"
        Me.LblPresupuesto.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'TotalesCompraBindingSource
        '
        Me.TotalesCompraBindingSource.DataSource = Me.DsCompras
        Me.TotalesCompraBindingSource.Position = 0
        '
        'TotalCompraPoveedorBindingSource
        '
        Me.TotalCompraPoveedorBindingSource.DataSource = Me.DsCompras
        Me.TotalCompraPoveedorBindingSource.Position = 0
        '
        'TotalCompraPoveedorBindingSource1
        '
        Me.TotalCompraPoveedorBindingSource1.DataSource = Me.DsCompras
        Me.TotalCompraPoveedorBindingSource1.Position = 0
        '
        'TotalCompraPoveedorBindingSource2
        '
        Me.TotalCompraPoveedorBindingSource2.DataSource = Me.DsCompras
        Me.TotalCompraPoveedorBindingSource2.Position = 0
        '
        'TotalCompraPoveedorDataGridView
        '
        Me.TotalCompraPoveedorDataGridView.AllowUserToAddRows = False
        Me.TotalCompraPoveedorDataGridView.AllowUserToDeleteRows = False
        Me.TotalCompraPoveedorDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalCompraPoveedorDataGridView.AutoGenerateColumns = False
        Me.TotalCompraPoveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotalCompraPoveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn1, Me.RazonSocialDataGridViewTextBoxColumn1, Me.SubUSDataGridViewTextBoxColumn, Me.ImpUSDataGridViewTextBoxColumn, Me.TotUSDataGridViewTextBoxColumn, Me.SubRDDataGridViewTextBoxColumn, Me.ImpRDDataGridViewTextBoxColumn, Me.TotRDDataGridViewTextBoxColumn})
        Me.TotalCompraPoveedorDataGridView.DataSource = Me.TotalCompraPoveedorBindingSource3
        Me.TotalCompraPoveedorDataGridView.Location = New System.Drawing.Point(741, 133)
        Me.TotalCompraPoveedorDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCompraPoveedorDataGridView.Name = "TotalCompraPoveedorDataGridView"
        Me.TotalCompraPoveedorDataGridView.ReadOnly = True
        Me.TotalCompraPoveedorDataGridView.RowHeadersWidth = 51
        Me.TotalCompraPoveedorDataGridView.Size = New System.Drawing.Size(1067, 551)
        Me.TotalCompraPoveedorDataGridView.TabIndex = 13
        '
        'IdProveedorDataGridViewTextBoxColumn1
        '
        Me.IdProveedorDataGridViewTextBoxColumn1.DataPropertyName = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn1.HeaderText = "Id_Proveedor"
        Me.IdProveedorDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdProveedorDataGridViewTextBoxColumn1.Name = "IdProveedorDataGridViewTextBoxColumn1"
        Me.IdProveedorDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn1.Width = 125
        '
        'RazonSocialDataGridViewTextBoxColumn1
        '
        Me.RazonSocialDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn1.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.RazonSocialDataGridViewTextBoxColumn1.Name = "RazonSocialDataGridViewTextBoxColumn1"
        Me.RazonSocialDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SubUSDataGridViewTextBoxColumn
        '
        Me.SubUSDataGridViewTextBoxColumn.DataPropertyName = "SubUS"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.SubUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubUSDataGridViewTextBoxColumn.HeaderText = "SubUS"
        Me.SubUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubUSDataGridViewTextBoxColumn.Name = "SubUSDataGridViewTextBoxColumn"
        Me.SubUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubUSDataGridViewTextBoxColumn.Width = 75
        '
        'ImpUSDataGridViewTextBoxColumn
        '
        Me.ImpUSDataGridViewTextBoxColumn.DataPropertyName = "ImpUS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.ImpUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImpUSDataGridViewTextBoxColumn.HeaderText = "ImpUS"
        Me.ImpUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImpUSDataGridViewTextBoxColumn.Name = "ImpUSDataGridViewTextBoxColumn"
        Me.ImpUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpUSDataGridViewTextBoxColumn.Width = 75
        '
        'TotUSDataGridViewTextBoxColumn
        '
        Me.TotUSDataGridViewTextBoxColumn.DataPropertyName = "TotUS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.TotUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotUSDataGridViewTextBoxColumn.HeaderText = "TotUS"
        Me.TotUSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotUSDataGridViewTextBoxColumn.Name = "TotUSDataGridViewTextBoxColumn"
        Me.TotUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotUSDataGridViewTextBoxColumn.Width = 75
        '
        'SubRDDataGridViewTextBoxColumn
        '
        Me.SubRDDataGridViewTextBoxColumn.DataPropertyName = "SubRD"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.SubRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubRDDataGridViewTextBoxColumn.HeaderText = "SubRD"
        Me.SubRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubRDDataGridViewTextBoxColumn.Name = "SubRDDataGridViewTextBoxColumn"
        Me.SubRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubRDDataGridViewTextBoxColumn.Width = 75
        '
        'ImpRDDataGridViewTextBoxColumn
        '
        Me.ImpRDDataGridViewTextBoxColumn.DataPropertyName = "ImpRD"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.ImpRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ImpRDDataGridViewTextBoxColumn.HeaderText = "ImpRD"
        Me.ImpRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ImpRDDataGridViewTextBoxColumn.Name = "ImpRDDataGridViewTextBoxColumn"
        Me.ImpRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpRDDataGridViewTextBoxColumn.Width = 75
        '
        'TotRDDataGridViewTextBoxColumn
        '
        Me.TotRDDataGridViewTextBoxColumn.DataPropertyName = "TotRD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.TotRDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotRDDataGridViewTextBoxColumn.HeaderText = "TotRD"
        Me.TotRDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotRDDataGridViewTextBoxColumn.Name = "TotRDDataGridViewTextBoxColumn"
        Me.TotRDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotRDDataGridViewTextBoxColumn.Width = 125
        '
        'TotalCompraPoveedorBindingSource3
        '
        Me.TotalCompraPoveedorBindingSource3.DataMember = "TotalCompraPoveedor"
        Me.TotalCompraPoveedorBindingSource3.DataSource = Me.GestionEmpresaDataSet
        '
        'GestionEmpresaDataSet
        '
        Me.GestionEmpresaDataSet.DataSetName = "GestionEmpresaDataSet"
        Me.GestionEmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalCompraPoveedorTableAdapter1
        '
        Me.TotalCompraPoveedorTableAdapter1.ClearBeforeFill = True
        '
        'FrmProveedoresListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1908, 698)
        Me.Controls.Add(Me.TotalCompraPoveedorDataGridView)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnAceptarProveedorFactura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblPresupuesto)
        Me.Controls.Add(Me.LblProyecto)
        Me.Controls.Add(Me.LblEmpresa)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnVerProveedor)
        Me.Controls.Add(Me.BtnAceptarProveedor)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProveedoresListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProveedoresListado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        CType(Me.DsCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraMaterialesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalesCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCompraPoveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCompraPoveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCompraPoveedorBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCompraPoveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCompraPoveedorBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionEmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ProveedoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAceptarProveedor As System.Windows.Forms.Button
    Friend WithEvents CompraMaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnVerProveedor As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAceptarProveedorFactura As System.Windows.Forms.Button
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsProveedores As ModuloGestion.DsProveedores
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As ModuloGestion.DsProveedoresTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsProveedoresTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProveedoresBindingNavigatorSaveItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DsCompras As ModuloGestion.DsCompras
    Friend WithEvents CompraMaterialesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents LblEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblProyecto As System.Windows.Forms.Label
    Friend WithEvents LblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalesCompraBindingSource As BindingSource
    Friend WithEvents TotalCompraPoveedorBindingSource As BindingSource

    Friend WithEvents TotalCompraPoveedorBindingSource1 As BindingSource
    Friend WithEvents TotalCompraPoveedorBindingSource2 As BindingSource
    Friend WithEvents TotalCompraPoveedorDataGridView As DataGridView
    Friend WithEvents GestionEmpresaDataSet As GestionEmpresaDataSet
    Friend WithEvents TotalCompraPoveedorBindingSource3 As BindingSource
    Friend WithEvents TotalCompraPoveedorTableAdapter1 As GestionEmpresaDataSetTableAdapters.TotalCompraPoveedorTableAdapter
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SubUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotRDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorFiscal As DataGridViewCheckBoxColumn
End Class
