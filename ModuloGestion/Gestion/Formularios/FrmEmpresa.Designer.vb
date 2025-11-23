<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpresa
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
        Dim Id_EmpresaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim E_MaiLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogoTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpresas = New ModuloGestion.DsEmpresas()
        Me.ProyectosDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectosDetalle = New ModuloGestion.DsProyectosDetalle()
        Me.TxtIdEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtIdfiscal = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.E_MaiTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresasTableAdapter = New ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager()
        Me.TableAdapterManager1 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.ProyectosDetalleTableAdapter = New ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpresasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CmdCargarNuevoProyecto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnFacturas = New System.Windows.Forms.Button()
        Me.BtnBanco = New System.Windows.Forms.Button()
        Me.BtnFacturaProveedor = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalContratadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalPendienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Id_EmpresaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        E_MaiLabel = New System.Windows.Forms.Label()
        LogoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_EmpresaLabel
        '
        Id_EmpresaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Id_EmpresaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_EmpresaLabel.Location = New System.Drawing.Point(14, 26)
        Id_EmpresaLabel.Name = "Id_EmpresaLabel"
        Id_EmpresaLabel.Size = New System.Drawing.Size(75, 20)
        Id_EmpresaLabel.TabIndex = 0
        Id_EmpresaLabel.Text = "Id Empresa:"
        '
        'NombreLabel
        '
        NombreLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        NombreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        NombreLabel.Location = New System.Drawing.Point(14, 52)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(75, 20)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Razon Social"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Id_FiscalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_FiscalLabel.Location = New System.Drawing.Point(151, 27)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(75, 20)
        Id_FiscalLabel.TabIndex = 4
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'DireccionLabel
        '
        DireccionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        DireccionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DireccionLabel.Location = New System.Drawing.Point(14, 78)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(75, 20)
        DireccionLabel.TabIndex = 6
        DireccionLabel.Text = "Direccion:"
        '
        'CiudadLabel
        '
        CiudadLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        CiudadLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        CiudadLabel.Location = New System.Drawing.Point(14, 104)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(75, 20)
        CiudadLabel.TabIndex = 8
        CiudadLabel.Text = "Ciudad:"
        '
        'PaisLabel
        '
        PaisLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        PaisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PaisLabel.Location = New System.Drawing.Point(14, 130)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(75, 20)
        PaisLabel.TabIndex = 10
        PaisLabel.Text = "Pais:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        TelefonoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        TelefonoLabel.Location = New System.Drawing.Point(14, 156)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(75, 20)
        TelefonoLabel.TabIndex = 12
        TelefonoLabel.Text = "telefono:"
        '
        'FaxLabel
        '
        FaxLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        FaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        FaxLabel.Location = New System.Drawing.Point(203, 155)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(75, 20)
        FaxLabel.TabIndex = 14
        FaxLabel.Text = "fax:"
        '
        'E_MaiLabel
        '
        E_MaiLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        E_MaiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        E_MaiLabel.Location = New System.Drawing.Point(14, 182)
        E_MaiLabel.Name = "E_MaiLabel"
        E_MaiLabel.Size = New System.Drawing.Size(75, 20)
        E_MaiLabel.TabIndex = 16
        E_MaiLabel.Text = "E-Mai:"
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.Location = New System.Drawing.Point(11, 207)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(34, 13)
        LogoLabel.TabIndex = 19
        LogoLabel.Text = "Logo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(LogoLabel)
        Me.GroupBox1.Controls.Add(Me.LogoTextBox)
        Me.GroupBox1.Controls.Add(Me.ProyectosDetalleDataGridView)
        Me.GroupBox1.Controls.Add(Id_EmpresaLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdEmpresa)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.TxtRazonSocial)
        Me.GroupBox1.Controls.Add(Id_FiscalLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdfiscal)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(CiudadLabel)
        Me.GroupBox1.Controls.Add(Me.CiudadTextBox)
        Me.GroupBox1.Controls.Add(PaisLabel)
        Me.GroupBox1.Controls.Add(Me.PaisTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(FaxLabel)
        Me.GroupBox1.Controls.Add(Me.FaxTextBox)
        Me.GroupBox1.Controls.Add(E_MaiLabel)
        Me.GroupBox1.Controls.Add(Me.E_MaiTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(802, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(667, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Ir Proyecto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(393, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'LogoTextBox
        '
        Me.LogoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Logo", True))
        Me.LogoTextBox.Location = New System.Drawing.Point(97, 204)
        Me.LogoTextBox.Name = "LogoTextBox"
        Me.LogoTextBox.Size = New System.Drawing.Size(289, 20)
        Me.LogoTextBox.TabIndex = 20
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
        'ProyectosDetalleDataGridView
        '
        Me.ProyectosDetalleDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProyectosDetalleDataGridView.AutoGenerateColumns = False
        Me.ProyectosDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProyectosDetalleDataGridView.DataSource = Me.ProyectosDetalleBindingSource
        Me.ProyectosDetalleDataGridView.Location = New System.Drawing.Point(14, 232)
        Me.ProyectosDetalleDataGridView.Name = "ProyectosDetalleDataGridView"
        Me.ProyectosDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProyectosDetalleDataGridView.Size = New System.Drawing.Size(647, 184)
        Me.ProyectosDetalleDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_DetalleProyecto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_DetalleProyecto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Proyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Empresa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        'TxtIdEmpresa
        '
        Me.TxtIdEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Id_Empresa", True))
        Me.TxtIdEmpresa.Location = New System.Drawing.Point(97, 25)
        Me.TxtIdEmpresa.Name = "TxtIdEmpresa"
        Me.TxtIdEmpresa.Size = New System.Drawing.Size(46, 20)
        Me.TxtIdEmpresa.TabIndex = 1
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Nombre", True))
        Me.TxtRazonSocial.Location = New System.Drawing.Point(97, 51)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(289, 20)
        Me.TxtRazonSocial.TabIndex = 3
        '
        'TxtIdfiscal
        '
        Me.TxtIdfiscal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Id_Fiscal", True))
        Me.TxtIdfiscal.Location = New System.Drawing.Point(234, 26)
        Me.TxtIdfiscal.Name = "TxtIdfiscal"
        Me.TxtIdfiscal.Size = New System.Drawing.Size(152, 20)
        Me.TxtIdfiscal.TabIndex = 5
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(97, 77)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(289, 20)
        Me.DireccionTextBox.TabIndex = 7
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(97, 103)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(289, 20)
        Me.CiudadTextBox.TabIndex = 9
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(97, 129)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(289, 20)
        Me.PaisTextBox.TabIndex = 11
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(97, 153)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 13
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(286, 154)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FaxTextBox.TabIndex = 15
        '
        'E_MaiTextBox
        '
        Me.E_MaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasBindingSource, "E_Mail", True))
        Me.E_MaiTextBox.Location = New System.Drawing.Point(97, 180)
        Me.E_MaiTextBox.Name = "E_MaiTextBox"
        Me.E_MaiTextBox.Size = New System.Drawing.Size(289, 20)
        Me.E_MaiTextBox.TabIndex = 17
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasTableAdapter = Me.EmpresasTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyectosDetalleTableAdapter
        '
        Me.ProyectosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ProyectosDetalleTableAdapter = Me.ProyectosDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Location = New System.Drawing.Point(203, 67)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.CmdGuardar.TabIndex = 2
        Me.CmdGuardar.Text = "Guardar "
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Location = New System.Drawing.Point(444, 67)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancelar.TabIndex = 3
        Me.CmdCancelar.Text = "Cerrar"
        Me.CmdCancelar.UseVisualStyleBackColor = True
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'EmpresasBindingNavigator
        '
        Me.EmpresasBindingNavigator.AddNewItem = Nothing
        Me.EmpresasBindingNavigator.BindingSource = Me.EmpresasBindingSource
        Me.EmpresasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasBindingNavigator.DeleteItem = Nothing
        Me.EmpresasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpresasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.EmpresasBindingNavigator.Location = New System.Drawing.Point(0, 527)
        Me.EmpresasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasBindingNavigator.Name = "EmpresasBindingNavigator"
        Me.EmpresasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.EmpresasBindingNavigator.Size = New System.Drawing.Size(814, 25)
        Me.EmpresasBindingNavigator.TabIndex = 1
        Me.EmpresasBindingNavigator.Text = "BindingNavigator1"
        '
        'CmdCargarNuevoProyecto
        '
        Me.CmdCargarNuevoProyecto.Location = New System.Drawing.Point(525, 67)
        Me.CmdCargarNuevoProyecto.Name = "CmdCargarNuevoProyecto"
        Me.CmdCargarNuevoProyecto.Size = New System.Drawing.Size(149, 23)
        Me.CmdCargarNuevoProyecto.TabIndex = 4
        Me.CmdCargarNuevoProyecto.Text = "Cargar Nuevo Proyecto"
        Me.CmdCargarNuevoProyecto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "\\antonio-dell\Users\Public\Carpeta Datos\Imajenes\Logos"
        '
        'BtnFacturas
        '
        Me.BtnFacturas.Location = New System.Drawing.Point(686, 67)
        Me.BtnFacturas.Name = "BtnFacturas"
        Me.BtnFacturas.Size = New System.Drawing.Size(75, 23)
        Me.BtnFacturas.TabIndex = 5
        Me.BtnFacturas.Text = "Facturas"
        Me.BtnFacturas.UseVisualStyleBackColor = True
        '
        'BtnBanco
        '
        Me.BtnBanco.Location = New System.Drawing.Point(284, 67)
        Me.BtnBanco.Name = "BtnBanco"
        Me.BtnBanco.Size = New System.Drawing.Size(75, 23)
        Me.BtnBanco.TabIndex = 6
        Me.BtnBanco.Text = "Bancos"
        Me.BtnBanco.UseVisualStyleBackColor = True
        '
        'BtnFacturaProveedor
        '
        Me.BtnFacturaProveedor.Location = New System.Drawing.Point(39, 67)
        Me.BtnFacturaProveedor.Name = "BtnFacturaProveedor"
        Me.BtnFacturaProveedor.Size = New System.Drawing.Size(158, 23)
        Me.BtnFacturaProveedor.TabIndex = 7
        Me.BtnFacturaProveedor.Text = "Facturas Proveedores"
        Me.BtnFacturaProveedor.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalContratadoToolStripMenuItem, Me.TotalPendienteToolStripMenuItem})
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'TotalContratadoToolStripMenuItem
        '
        Me.TotalContratadoToolStripMenuItem.Name = "TotalContratadoToolStripMenuItem"
        Me.TotalContratadoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TotalContratadoToolStripMenuItem.Text = "Total Contratado"
        '
        'TotalPendienteToolStripMenuItem
        '
        Me.TotalPendienteToolStripMenuItem.Name = "TotalPendienteToolStripMenuItem"
        Me.TotalPendienteToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TotalPendienteToolStripMenuItem.Text = "Total Pendiente"
        '
        'FrmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnFacturaProveedor)
        Me.Controls.Add(Me.BtnBanco)
        Me.Controls.Add(Me.BtnFacturas)
        Me.Controls.Add(Me.CmdCargarNuevoProyecto)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Controls.Add(Me.EmpresasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEmpresa"
        Me.Text = "FrmEmpresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasBindingNavigator.ResumeLayout(False)
        Me.EmpresasBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DsEmpresas As ModuloGestion.DsEmpresas
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTableAdapter As ModuloGestion.DsEmpresasTableAdapters.EmpresasTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpresasTableAdapters.TableAdapterManager
    Friend WithEvents TxtIdEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdfiscal As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_MaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents DsProyectosDetalle As ModuloGestion.DsProyectosDetalle
    Friend WithEvents ProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleTableAdapter As ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmpresasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CmdCargarNuevoProyecto As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnFacturas As System.Windows.Forms.Button
    Friend WithEvents BtnBanco As System.Windows.Forms.Button
    Friend WithEvents BtnFacturaProveedor As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalContratadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalPendienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
