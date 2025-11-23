<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoHerrajes
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
        Dim IdHerrajeLabel As System.Windows.Forms.Label
        Dim Descripcion_Elemento_HerrajesLabel As System.Windows.Forms.Label
        Dim Medidad_Elementos_HerrajesLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim FabricanteLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim ImajenLabel As System.Windows.Forms.Label
        Dim Tipo_herrajeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoHerrajes))
        Me.DsHerrajes = New ModuloGestion.DsHerrajes()
        Me.HerrajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerrajesTableAdapter = New ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsHerrajesTableAdapters.TableAdapterManager()
        Me.HerrajesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HerrajesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TxtIdherrajes = New System.Windows.Forms.TextBox()
        Me.Descripcion_Elemento_HerrajesTextBox = New System.Windows.Forms.TextBox()
        Me.Medidad_Elementos_HerrajesTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.FabricanteTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.ImajenTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbTipoHerraje = New System.Windows.Forms.ComboBox()
        Me.HerrajesFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHerrajesFamilia = New ModuloGestion.DsHerrajesFamilia()
        Me.HerrajesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerrajesFamiliaTableAdapter = New ModuloGestion.DsHerrajesFamiliaTableAdapters.HerrajesFamiliaTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tipo_herrajeTextBox = New System.Windows.Forms.TextBox()
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        IdHerrajeLabel = New System.Windows.Forms.Label()
        Descripcion_Elemento_HerrajesLabel = New System.Windows.Forms.Label()
        Medidad_Elementos_HerrajesLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        FabricanteLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        ImajenLabel = New System.Windows.Forms.Label()
        Tipo_herrajeLabel = New System.Windows.Forms.Label()
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HerrajesBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHerrajesFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdHerrajeLabel
        '
        IdHerrajeLabel.AutoSize = True
        IdHerrajeLabel.Location = New System.Drawing.Point(17, 69)
        IdHerrajeLabel.Name = "IdHerrajeLabel"
        IdHerrajeLabel.Size = New System.Drawing.Size(56, 13)
        IdHerrajeLabel.TabIndex = 1
        IdHerrajeLabel.Text = "Id Herraje:"
        '
        'Descripcion_Elemento_HerrajesLabel
        '
        Descripcion_Elemento_HerrajesLabel.AutoSize = True
        Descripcion_Elemento_HerrajesLabel.Location = New System.Drawing.Point(17, 92)
        Descripcion_Elemento_HerrajesLabel.Name = "Descripcion_Elemento_HerrajesLabel"
        Descripcion_Elemento_HerrajesLabel.Size = New System.Drawing.Size(63, 13)
        Descripcion_Elemento_HerrajesLabel.TabIndex = 3
        Descripcion_Elemento_HerrajesLabel.Text = "Descripcion"
        '
        'Medidad_Elementos_HerrajesLabel
        '
        Medidad_Elementos_HerrajesLabel.AutoSize = True
        Medidad_Elementos_HerrajesLabel.Location = New System.Drawing.Point(17, 147)
        Medidad_Elementos_HerrajesLabel.Name = "Medidad_Elementos_HerrajesLabel"
        Medidad_Elementos_HerrajesLabel.Size = New System.Drawing.Size(89, 13)
        Medidad_Elementos_HerrajesLabel.TabIndex = 5
        Medidad_Elementos_HerrajesLabel.Text = "Medidad compra "
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(17, 173)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(34, 13)
        PesoLabel.TabIndex = 7
        PesoLabel.Text = "Peso:"
        '
        'FabricanteLabel
        '
        FabricanteLabel.AutoSize = True
        FabricanteLabel.Location = New System.Drawing.Point(288, 65)
        FabricanteLabel.Name = "FabricanteLabel"
        FabricanteLabel.Size = New System.Drawing.Size(60, 13)
        FabricanteLabel.TabIndex = 11
        FabricanteLabel.Text = "Fabricante:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(17, 225)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 13
        ColorLabel.Text = "Color:"
        '
        'ImajenLabel
        '
        ImajenLabel.AutoSize = True
        ImajenLabel.Location = New System.Drawing.Point(17, 251)
        ImajenLabel.Name = "ImajenLabel"
        ImajenLabel.Size = New System.Drawing.Size(41, 13)
        ImajenLabel.TabIndex = 15
        ImajenLabel.Text = "Imajen:"
        '
        'Tipo_herrajeLabel
        '
        Tipo_herrajeLabel.AutoSize = True
        Tipo_herrajeLabel.Location = New System.Drawing.Point(17, 199)
        Tipo_herrajeLabel.Name = "Tipo_herrajeLabel"
        Tipo_herrajeLabel.Size = New System.Drawing.Size(66, 13)
        Tipo_herrajeLabel.TabIndex = 18
        Tipo_herrajeLabel.Text = "Tipo herraje:"
        '
        'DsHerrajes
        '
        Me.DsHerrajes.DataSetName = "DsHerrajes"
        Me.DsHerrajes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerrajesBindingSource
        '
        Me.HerrajesBindingSource.DataMember = "Herrajes"
        Me.HerrajesBindingSource.DataSource = Me.DsHerrajes
        '
        'HerrajesTableAdapter
        '
        Me.HerrajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HerrajesTableAdapter = Me.HerrajesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsHerrajesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HerrajesBindingNavigator
        '
        Me.HerrajesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HerrajesBindingNavigator.BindingSource = Me.HerrajesBindingSource
        Me.HerrajesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HerrajesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HerrajesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HerrajesBindingNavigatorSaveItem})
        Me.HerrajesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HerrajesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HerrajesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HerrajesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HerrajesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HerrajesBindingNavigator.Name = "HerrajesBindingNavigator"
        Me.HerrajesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HerrajesBindingNavigator.Size = New System.Drawing.Size(750, 25)
        Me.HerrajesBindingNavigator.TabIndex = 0
        Me.HerrajesBindingNavigator.Text = "BindingNavigator1"
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
        'HerrajesBindingNavigatorSaveItem
        '
        Me.HerrajesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HerrajesBindingNavigatorSaveItem.Image = CType(resources.GetObject("HerrajesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HerrajesBindingNavigatorSaveItem.Name = "HerrajesBindingNavigatorSaveItem"
        Me.HerrajesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HerrajesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TxtIdherrajes
        '
        Me.TxtIdherrajes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "IdHerraje", True))
        Me.TxtIdherrajes.Location = New System.Drawing.Point(111, 66)
        Me.TxtIdherrajes.Name = "TxtIdherrajes"
        Me.TxtIdherrajes.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdherrajes.TabIndex = 2
        '
        'Descripcion_Elemento_HerrajesTextBox
        '
        Me.Descripcion_Elemento_HerrajesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Descripcion_Elemento_HerrajesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Descripcion_Elemento_Herrajes", True))
        Me.Descripcion_Elemento_HerrajesTextBox.Location = New System.Drawing.Point(111, 92)
        Me.Descripcion_Elemento_HerrajesTextBox.Multiline = True
        Me.Descripcion_Elemento_HerrajesTextBox.Name = "Descripcion_Elemento_HerrajesTextBox"
        Me.Descripcion_Elemento_HerrajesTextBox.Size = New System.Drawing.Size(246, 46)
        Me.Descripcion_Elemento_HerrajesTextBox.TabIndex = 4
        '
        'Medidad_Elementos_HerrajesTextBox
        '
        Me.Medidad_Elementos_HerrajesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Medidad_Elementos_Herrajes", True))
        Me.Medidad_Elementos_HerrajesTextBox.Location = New System.Drawing.Point(429, 36)
        Me.Medidad_Elementos_HerrajesTextBox.Name = "Medidad_Elementos_HerrajesTextBox"
        Me.Medidad_Elementos_HerrajesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Medidad_Elementos_HerrajesTextBox.TabIndex = 6
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(111, 170)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PesoTextBox.TabIndex = 8
        '
        'FabricanteTextBox
        '
        Me.FabricanteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FabricanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Fabricante", True))
        Me.FabricanteTextBox.Location = New System.Drawing.Point(354, 62)
        Me.FabricanteTextBox.Name = "FabricanteTextBox"
        Me.FabricanteTextBox.Size = New System.Drawing.Size(195, 20)
        Me.FabricanteTextBox.TabIndex = 12
        '
        'ColorTextBox
        '
        Me.ColorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(111, 222)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(246, 20)
        Me.ColorTextBox.TabIndex = 14
        '
        'ImajenTextBox
        '
        Me.ImajenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Imajen", True))
        Me.ImajenTextBox.Location = New System.Drawing.Point(111, 268)
        Me.ImajenTextBox.Name = "ImajenTextBox"
        Me.ImajenTextBox.Size = New System.Drawing.Size(518, 20)
        Me.ImajenTextBox.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(387, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(555, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Anexar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmbTipoHerraje
        '
        Me.CmbTipoHerraje.DataSource = Me.HerrajesFamiliaBindingSource
        Me.CmbTipoHerraje.DisplayMember = "Decripcion"
        Me.CmbTipoHerraje.FormattingEnabled = True
        Me.CmbTipoHerraje.Location = New System.Drawing.Point(111, 196)
        Me.CmbTipoHerraje.Name = "CmbTipoHerraje"
        Me.CmbTipoHerraje.Size = New System.Drawing.Size(121, 21)
        Me.CmbTipoHerraje.TabIndex = 19
        Me.CmbTipoHerraje.ValueMember = "Id_Tipo_Hherraje"
        '
        'HerrajesFamiliaBindingSource
        '
        Me.HerrajesFamiliaBindingSource.DataMember = "HerrajesFamilia"
        Me.HerrajesFamiliaBindingSource.DataSource = Me.DsHerrajesFamilia
        '
        'DsHerrajesFamilia
        '
        Me.DsHerrajesFamilia.DataSetName = "DsHerrajesFamilia"
        Me.DsHerrajesFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerrajesBindingSource1
        '
        Me.HerrajesBindingSource1.DataMember = "Herrajes"
        Me.HerrajesBindingSource1.DataSource = Me.DsHerrajes
        '
        'HerrajesFamiliaTableAdapter
        '
        Me.HerrajesFamiliaTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "\\PORTATIL-DELL\Users\Public\Imajenes Herrajes"
        '
        'Tipo_herrajeTextBox
        '
        Me.Tipo_herrajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesBindingSource, "Tipo_herraje", True))
        Me.Tipo_herrajeTextBox.Location = New System.Drawing.Point(216, 170)
        Me.Tipo_herrajeTextBox.Name = "Tipo_herrajeTextBox"
        Me.Tipo_herrajeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_herrajeTextBox.TabIndex = 20
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MedidasCompraTableAdapter = Me.MedidasCompraTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HerrajesBindingSource, "Medidad_Elementos_Herrajes", True))
        Me.ComboBox1.DataSource = Me.MedidasCompraBindingSource
        Me.ComboBox1.DisplayMember = "Descripcion_Medida"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 145)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.ValueMember = "Id_Medida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(238, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Nuevo Grupo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmIngresoHerrajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 300)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Tipo_herrajeTextBox)
        Me.Controls.Add(Tipo_herrajeLabel)
        Me.Controls.Add(Me.CmbTipoHerraje)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IdHerrajeLabel)
        Me.Controls.Add(Me.TxtIdherrajes)
        Me.Controls.Add(Descripcion_Elemento_HerrajesLabel)
        Me.Controls.Add(Me.Descripcion_Elemento_HerrajesTextBox)
        Me.Controls.Add(Medidad_Elementos_HerrajesLabel)
        Me.Controls.Add(Me.Medidad_Elementos_HerrajesTextBox)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(FabricanteLabel)
        Me.Controls.Add(Me.FabricanteTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(ImajenLabel)
        Me.Controls.Add(Me.ImajenTextBox)
        Me.Controls.Add(Me.HerrajesBindingNavigator)
        Me.Name = "FrmIngresoHerrajes"
        Me.Text = "FrmIngresoHerrajes"
        CType(Me.DsHerrajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HerrajesBindingNavigator.ResumeLayout(False)
        Me.HerrajesBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHerrajesFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsHerrajes As ModuloGestion.DsHerrajes
    Friend WithEvents HerrajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesTableAdapter As ModuloGestion.DsHerrajesTableAdapters.HerrajesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsHerrajesTableAdapters.TableAdapterManager
    Friend WithEvents HerrajesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HerrajesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtIdherrajes As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion_Elemento_HerrajesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Medidad_Elementos_HerrajesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FabricanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImajenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmbTipoHerraje As System.Windows.Forms.ComboBox
    Friend WithEvents HerrajesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsHerrajesFamilia As ModuloGestion.DsHerrajesFamilia
    Friend WithEvents HerrajesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesFamiliaTableAdapter As ModuloGestion.DsHerrajesFamiliaTableAdapters.HerrajesFamiliaTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Tipo_herrajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsMedidasCompraTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
