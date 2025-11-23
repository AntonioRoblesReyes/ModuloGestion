<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubArticuloDetalle
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
        Dim Id_Sub_ArticuloLabel As System.Windows.Forms.Label
        Dim Descripcion_Sub_ArticuloLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim PiesLargoLabel As System.Windows.Forms.Label
        Dim AnchopulgadasLabel As System.Windows.Forms.Label
        Dim GruesoPulgadasLabel As System.Windows.Forms.Label
        Dim PiesUnidadLabel As System.Windows.Forms.Label
        Dim M2CaraLabel As System.Windows.Forms.Label
        Dim M2CantoLabel As System.Windows.Forms.Label
        Dim M2CabezaLabel As System.Windows.Forms.Label
        Dim Id_MedidaLabel As System.Windows.Forms.Label
        Dim M2PinuturaUnidadLabel As System.Windows.Forms.Label
        Dim M2PinuturaUnidadtotalLabel As System.Windows.Forms.Label
        Dim NuevoIdLabel As System.Windows.Forms.Label
        Dim ConsumoUnidadLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubArticuloDetalle))
        Me.DsSubArticulos = New ModuloGestion.DsSubArticulos()
        Me.SubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubArticulosTableAdapter = New ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager()
        Me.SubArticulosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SubArticulosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_Sub_ArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_Sub_ArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterial = New ModuloGestion.DsMaterial()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Id_Material_DetalleComboBox = New System.Windows.Forms.ComboBox()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.IdMatrialesFamiliaComboBox = New System.Windows.Forms.ComboBox()
        Me.MaterialesFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialFamilia = New ModuloGestion.DsMaterialFamilia()
        Me.Id_descripcion_DetalleComboBox = New System.Windows.Forms.ComboBox()
        Me.DescripcionesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDescripcionesdetalle = New ModuloGestion.DsDescripcionesdetalle()
        Me.Id_MaterialComboBox = New System.Windows.Forms.ComboBox()
        Me.MaterialesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_MedidaComboBox = New System.Windows.Forms.ComboBox()
        Me.SubArticulosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSubArticulosDetalle = New ModuloGestion.DsSubArticulosDetalle()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.LargoTextBox = New System.Windows.Forms.TextBox()
        Me.AnchoTextBox = New System.Windows.Forms.TextBox()
        Me.GruesoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PiesLargoTextBox = New System.Windows.Forms.TextBox()
        Me.AnchopulgadasTextBox = New System.Windows.Forms.TextBox()
        Me.GruesoPulgadasTextBox = New System.Windows.Forms.TextBox()
        Me.PiesUnidadTextBox = New System.Windows.Forms.TextBox()
        Me.M2CaraTextBox = New System.Windows.Forms.TextBox()
        Me.M2CantoTextBox = New System.Windows.Forms.TextBox()
        Me.M2CabezaTextBox = New System.Windows.Forms.TextBox()
        Me.M2PinuturaUnidadTextBox = New System.Windows.Forms.TextBox()
        Me.M2PinuturaUnidadtotalTextBox = New System.Windows.Forms.TextBox()
        Me.NuevoIdTextBox = New System.Windows.Forms.TextBox()
        Me.ConsumoUnidadTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionesDetalleTableAdapter = New ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter()
        Me.SubArticulosDetalleTableAdapter = New ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager()
        Me.MaterialesTableAdapter = New ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsMaterialTableAdapters.TableAdapterManager()
        Me.MaterialesFamiliaTableAdapter = New ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager()
        Me.TableAdapterManager5 = New ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager()
        Id_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Descripcion_Sub_ArticuloLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        PiesLargoLabel = New System.Windows.Forms.Label()
        AnchopulgadasLabel = New System.Windows.Forms.Label()
        GruesoPulgadasLabel = New System.Windows.Forms.Label()
        PiesUnidadLabel = New System.Windows.Forms.Label()
        M2CaraLabel = New System.Windows.Forms.Label()
        M2CantoLabel = New System.Windows.Forms.Label()
        M2CabezaLabel = New System.Windows.Forms.Label()
        Id_MedidaLabel = New System.Windows.Forms.Label()
        M2PinuturaUnidadLabel = New System.Windows.Forms.Label()
        M2PinuturaUnidadtotalLabel = New System.Windows.Forms.Label()
        NuevoIdLabel = New System.Windows.Forms.Label()
        ConsumoUnidadLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubArticulosBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_Sub_ArticuloLabel
        '
        Id_Sub_ArticuloLabel.AutoSize = True
        Id_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Id_Sub_ArticuloLabel.Location = New System.Drawing.Point(16, 54)
        Id_Sub_ArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_Sub_ArticuloLabel.Name = "Id_Sub_ArticuloLabel"
        Id_Sub_ArticuloLabel.Size = New System.Drawing.Size(97, 18)
        Id_Sub_ArticuloLabel.TabIndex = 1
        Id_Sub_ArticuloLabel.Text = "Id Sub Articulo:"
        '
        'Descripcion_Sub_ArticuloLabel
        '
        Descripcion_Sub_ArticuloLabel.AutoSize = True
        Descripcion_Sub_ArticuloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Descripcion_Sub_ArticuloLabel.Location = New System.Drawing.Point(16, 86)
        Descripcion_Sub_ArticuloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Descripcion_Sub_ArticuloLabel.Name = "Descripcion_Sub_ArticuloLabel"
        Descripcion_Sub_ArticuloLabel.Size = New System.Drawing.Size(2, 18)
        Descripcion_Sub_ArticuloLabel.TabIndex = 3
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Location = New System.Drawing.Point(13, 53)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(145, 25)
        Label1.TabIndex = 6
        Label1.Text = "Descripcion "
        '
        'Label3
        '
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label3.Location = New System.Drawing.Point(13, 28)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(145, 25)
        Label3.TabIndex = 8
        Label3.Text = "Id detalle SubArticulo"
        '
        'Label4
        '
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label4.Location = New System.Drawing.Point(13, 118)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(145, 25)
        Label4.TabIndex = 9
        Label4.Text = "Ancho"
        '
        'Label5
        '
        Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label5.Location = New System.Drawing.Point(13, 86)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(145, 25)
        Label5.TabIndex = 10
        Label5.Text = "Largo"
        '
        'Label6
        '
        Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label6.Location = New System.Drawing.Point(13, 144)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(145, 25)
        Label6.TabIndex = 13
        Label6.Text = "Grueso"
        '
        'Label8
        '
        Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label8.Location = New System.Drawing.Point(13, 175)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(145, 25)
        Label8.TabIndex = 17
        Label8.Text = "Cantidad"
        '
        'Label9
        '
        Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label9.Location = New System.Drawing.Point(13, 207)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(145, 25)
        Label9.TabIndex = 19
        Label9.Text = "Material"
        '
        'PiesLargoLabel
        '
        PiesLargoLabel.AutoSize = True
        PiesLargoLabel.Location = New System.Drawing.Point(721, 303)
        PiesLargoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PiesLargoLabel.Name = "PiesLargoLabel"
        PiesLargoLabel.Size = New System.Drawing.Size(75, 16)
        PiesLargoLabel.TabIndex = 35
        PiesLargoLabel.Text = "Pies Largo:"
        '
        'AnchopulgadasLabel
        '
        AnchopulgadasLabel.AutoSize = True
        AnchopulgadasLabel.Location = New System.Drawing.Point(721, 335)
        AnchopulgadasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AnchopulgadasLabel.Name = "AnchopulgadasLabel"
        AnchopulgadasLabel.Size = New System.Drawing.Size(105, 16)
        AnchopulgadasLabel.TabIndex = 37
        AnchopulgadasLabel.Text = "Anchopulgadas:"
        '
        'GruesoPulgadasLabel
        '
        GruesoPulgadasLabel.AutoSize = True
        GruesoPulgadasLabel.Location = New System.Drawing.Point(721, 367)
        GruesoPulgadasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GruesoPulgadasLabel.Name = "GruesoPulgadasLabel"
        GruesoPulgadasLabel.Size = New System.Drawing.Size(115, 16)
        GruesoPulgadasLabel.TabIndex = 39
        GruesoPulgadasLabel.Text = "Grueso Pulgadas:"
        '
        'PiesUnidadLabel
        '
        PiesUnidadLabel.AutoSize = True
        PiesUnidadLabel.Location = New System.Drawing.Point(721, 399)
        PiesUnidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PiesUnidadLabel.Name = "PiesUnidadLabel"
        PiesUnidadLabel.Size = New System.Drawing.Size(84, 16)
        PiesUnidadLabel.TabIndex = 41
        PiesUnidadLabel.Text = "Pies Unidad:"
        '
        'M2CaraLabel
        '
        M2CaraLabel.AutoSize = True
        M2CaraLabel.Location = New System.Drawing.Point(721, 431)
        M2CaraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        M2CaraLabel.Name = "M2CaraLabel"
        M2CaraLabel.Size = New System.Drawing.Size(57, 16)
        M2CaraLabel.TabIndex = 43
        M2CaraLabel.Text = "M2Cara:"
        '
        'M2CantoLabel
        '
        M2CantoLabel.AutoSize = True
        M2CantoLabel.Location = New System.Drawing.Point(721, 463)
        M2CantoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        M2CantoLabel.Name = "M2CantoLabel"
        M2CantoLabel.Size = New System.Drawing.Size(63, 16)
        M2CantoLabel.TabIndex = 45
        M2CantoLabel.Text = "M2Canto:"
        '
        'M2CabezaLabel
        '
        M2CabezaLabel.AutoSize = True
        M2CabezaLabel.Location = New System.Drawing.Point(721, 495)
        M2CabezaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        M2CabezaLabel.Name = "M2CabezaLabel"
        M2CabezaLabel.Size = New System.Drawing.Size(75, 16)
        M2CabezaLabel.TabIndex = 47
        M2CabezaLabel.Text = "M2Cabeza:"
        '
        'Id_MedidaLabel
        '
        Id_MedidaLabel.AutoSize = True
        Id_MedidaLabel.Location = New System.Drawing.Point(721, 527)
        Id_MedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_MedidaLabel.Name = "Id_MedidaLabel"
        Id_MedidaLabel.Size = New System.Drawing.Size(70, 16)
        Id_MedidaLabel.TabIndex = 49
        Id_MedidaLabel.Text = "Id Medida:"
        '
        'M2PinuturaUnidadLabel
        '
        M2PinuturaUnidadLabel.AutoSize = True
        M2PinuturaUnidadLabel.Location = New System.Drawing.Point(721, 559)
        M2PinuturaUnidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        M2PinuturaUnidadLabel.Name = "M2PinuturaUnidadLabel"
        M2PinuturaUnidadLabel.Size = New System.Drawing.Size(123, 16)
        M2PinuturaUnidadLabel.TabIndex = 51
        M2PinuturaUnidadLabel.Text = "M2Pinutura Unidad:"
        '
        'M2PinuturaUnidadtotalLabel
        '
        M2PinuturaUnidadtotalLabel.AutoSize = True
        M2PinuturaUnidadtotalLabel.Location = New System.Drawing.Point(721, 591)
        M2PinuturaUnidadtotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        M2PinuturaUnidadtotalLabel.Name = "M2PinuturaUnidadtotalLabel"
        M2PinuturaUnidadtotalLabel.Size = New System.Drawing.Size(148, 16)
        M2PinuturaUnidadtotalLabel.TabIndex = 53
        M2PinuturaUnidadtotalLabel.Text = "M2Pinutura Unidadtotal:"
        '
        'NuevoIdLabel
        '
        NuevoIdLabel.AutoSize = True
        NuevoIdLabel.Location = New System.Drawing.Point(721, 623)
        NuevoIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NuevoIdLabel.Name = "NuevoIdLabel"
        NuevoIdLabel.Size = New System.Drawing.Size(64, 16)
        NuevoIdLabel.TabIndex = 55
        NuevoIdLabel.Text = "Nuevo Id:"
        '
        'ConsumoUnidadLabel
        '
        ConsumoUnidadLabel.AutoSize = True
        ConsumoUnidadLabel.Location = New System.Drawing.Point(721, 655)
        ConsumoUnidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ConsumoUnidadLabel.Name = "ConsumoUnidadLabel"
        ConsumoUnidadLabel.Size = New System.Drawing.Size(114, 16)
        ConsumoUnidadLabel.TabIndex = 57
        ConsumoUnidadLabel.Text = "Consumo Unidad:"
        '
        'Label7
        '
        Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label7.Location = New System.Drawing.Point(13, 242)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(145, 25)
        Label7.TabIndex = 62
        Label7.Text = "Medida Compra"
        '
        'Label2
        '
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label2.Location = New System.Drawing.Point(620, 52)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(145, 25)
        Label2.TabIndex = 65
        Label2.Text = "Material"
        '
        'Label10
        '
        Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label10.Location = New System.Drawing.Point(620, 86)
        Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(145, 25)
        Label10.TabIndex = 67
        Label10.Text = "Material Detalle"
        '
        'DsSubArticulos
        '
        Me.DsSubArticulos.DataSetName = "DsSubArticulos"
        Me.DsSubArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubArticulosBindingSource
        '
        Me.SubArticulosBindingSource.DataMember = "SubArticulos"
        Me.SubArticulosBindingSource.DataSource = Me.DsSubArticulos
        '
        'SubArticulosTableAdapter
        '
        Me.SubArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SubArticulosTableAdapter = Me.SubArticulosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubArticulosBindingNavigator
        '
        Me.SubArticulosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SubArticulosBindingNavigator.BindingSource = Me.SubArticulosBindingSource
        Me.SubArticulosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SubArticulosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SubArticulosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SubArticulosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SubArticulosBindingNavigatorSaveItem})
        Me.SubArticulosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SubArticulosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SubArticulosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SubArticulosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SubArticulosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SubArticulosBindingNavigator.Name = "SubArticulosBindingNavigator"
        Me.SubArticulosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SubArticulosBindingNavigator.Size = New System.Drawing.Size(1131, 31)
        Me.SubArticulosBindingNavigator.TabIndex = 0
        Me.SubArticulosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'SubArticulosBindingNavigatorSaveItem
        '
        Me.SubArticulosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SubArticulosBindingNavigatorSaveItem.Image = CType(resources.GetObject("SubArticulosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SubArticulosBindingNavigatorSaveItem.Name = "SubArticulosBindingNavigatorSaveItem"
        Me.SubArticulosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.SubArticulosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_Sub_ArticuloTextBox
        '
        Me.Id_Sub_ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Id_Sub_Articulo", True))
        Me.Id_Sub_ArticuloTextBox.Location = New System.Drawing.Point(123, 50)
        Me.Id_Sub_ArticuloTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_Sub_ArticuloTextBox.Name = "Id_Sub_ArticuloTextBox"
        Me.Id_Sub_ArticuloTextBox.Size = New System.Drawing.Size(235, 22)
        Me.Id_Sub_ArticuloTextBox.TabIndex = 2
        '
        'Descripcion_Sub_ArticuloTextBox
        '
        Me.Descripcion_Sub_ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosBindingSource, "Descripcion_Sub_Articulo", True))
        Me.Descripcion_Sub_ArticuloTextBox.Location = New System.Drawing.Point(123, 82)
        Me.Descripcion_Sub_ArticuloTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Descripcion_Sub_ArticuloTextBox.Multiline = True
        Me.Descripcion_Sub_ArticuloTextBox.Name = "Descripcion_Sub_ArticuloTextBox"
        Me.Descripcion_Sub_ArticuloTextBox.Size = New System.Drawing.Size(384, 68)
        Me.Descripcion_Sub_ArticuloTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialesDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Id_Material_DetalleComboBox)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.IdMatrialesFamiliaComboBox)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.Id_descripcion_DetalleComboBox)
        Me.GroupBox1.Controls.Add(Me.Id_MaterialComboBox)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.Id_MedidaComboBox)
        Me.GroupBox1.Controls.Add(Me.txtDetalle)
        Me.GroupBox1.Controls.Add(Me.LargoTextBox)
        Me.GroupBox1.Controls.Add(Me.AnchoTextBox)
        Me.GroupBox1.Controls.Add(Me.GruesoTextBox)
        Me.GroupBox1.Controls.Add(Me.CantidadTextBox)
        Me.GroupBox1.Controls.Add(PiesLargoLabel)
        Me.GroupBox1.Controls.Add(Me.PiesLargoTextBox)
        Me.GroupBox1.Controls.Add(AnchopulgadasLabel)
        Me.GroupBox1.Controls.Add(Me.AnchopulgadasTextBox)
        Me.GroupBox1.Controls.Add(GruesoPulgadasLabel)
        Me.GroupBox1.Controls.Add(Me.GruesoPulgadasTextBox)
        Me.GroupBox1.Controls.Add(PiesUnidadLabel)
        Me.GroupBox1.Controls.Add(Me.PiesUnidadTextBox)
        Me.GroupBox1.Controls.Add(M2CaraLabel)
        Me.GroupBox1.Controls.Add(Me.M2CaraTextBox)
        Me.GroupBox1.Controls.Add(M2CantoLabel)
        Me.GroupBox1.Controls.Add(Me.M2CantoTextBox)
        Me.GroupBox1.Controls.Add(M2CabezaLabel)
        Me.GroupBox1.Controls.Add(Me.M2CabezaTextBox)
        Me.GroupBox1.Controls.Add(Id_MedidaLabel)
        Me.GroupBox1.Controls.Add(M2PinuturaUnidadLabel)
        Me.GroupBox1.Controls.Add(Me.M2PinuturaUnidadTextBox)
        Me.GroupBox1.Controls.Add(M2PinuturaUnidadtotalLabel)
        Me.GroupBox1.Controls.Add(Me.M2PinuturaUnidadtotalTextBox)
        Me.GroupBox1.Controls.Add(NuevoIdLabel)
        Me.GroupBox1.Controls.Add(Me.NuevoIdTextBox)
        Me.GroupBox1.Controls.Add(ConsumoUnidadLabel)
        Me.GroupBox1.Controls.Add(Me.ConsumoUnidadTextBox)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 177)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 700)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'MaterialesDataGridView
        '
        Me.MaterialesDataGridView.AutoGenerateColumns = False
        Me.MaterialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaterialesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.MaterialesDataGridView.DataSource = Me.MaterialesBindingSource
        Me.MaterialesDataGridView.Location = New System.Drawing.Point(605, 167)
        Me.MaterialesDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaterialesDataGridView.Name = "MaterialesDataGridView"
        Me.MaterialesDataGridView.RowHeadersWidth = 51
        Me.MaterialesDataGridView.Size = New System.Drawing.Size(400, 271)
        Me.MaterialesDataGridView.TabIndex = 68
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Material"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Material"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descrpcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descrpcion"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.DsMaterial
        '
        'DsMaterial
        '
        Me.DsMaterial.DataSetName = "DsMaterial"
        Me.DsMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 290)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Aprobar y Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 290)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Aprobar y Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Id_Material_DetalleComboBox
        '
        Me.Id_Material_DetalleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterilaesDetalleBindingSource, "Id_Material_Detalle", True))
        Me.Id_Material_DetalleComboBox.DataSource = Me.MaterilaesDetalleBindingSource
        Me.Id_Material_DetalleComboBox.DisplayMember = "Descripcion"
        Me.Id_Material_DetalleComboBox.FormattingEnabled = True
        Me.Id_Material_DetalleComboBox.Location = New System.Drawing.Point(167, 207)
        Me.Id_Material_DetalleComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_Material_DetalleComboBox.Name = "Id_Material_DetalleComboBox"
        Me.Id_Material_DetalleComboBox.Size = New System.Drawing.Size(361, 24)
        Me.Id_Material_DetalleComboBox.TabIndex = 68
        Me.Id_Material_DetalleComboBox.ValueMember = "Id_Material_Detalle"
        '
        'MaterilaesDetalleBindingSource
        '
        Me.MaterilaesDetalleBindingSource.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource.DataSource = Me.DsMaterialDetalle
        '
        'DsMaterialDetalle
        '
        Me.DsMaterialDetalle.DataSetName = "DsMaterialDetalle"
        Me.DsMaterialDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdMatrialesFamiliaComboBox
        '
        Me.IdMatrialesFamiliaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesFamiliaBindingSource, "IdMatrialesFamilia", True))
        Me.IdMatrialesFamiliaComboBox.DataSource = Me.MaterialesFamiliaBindingSource
        Me.IdMatrialesFamiliaComboBox.DisplayMember = "Descripcion"
        Me.IdMatrialesFamiliaComboBox.FormattingEnabled = True
        Me.IdMatrialesFamiliaComboBox.Location = New System.Drawing.Point(773, 86)
        Me.IdMatrialesFamiliaComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IdMatrialesFamiliaComboBox.Name = "IdMatrialesFamiliaComboBox"
        Me.IdMatrialesFamiliaComboBox.Size = New System.Drawing.Size(249, 24)
        Me.IdMatrialesFamiliaComboBox.TabIndex = 66
        Me.IdMatrialesFamiliaComboBox.ValueMember = "IdMatrialesFamilia"
        '
        'MaterialesFamiliaBindingSource
        '
        Me.MaterialesFamiliaBindingSource.DataMember = "MaterialesFamilia"
        Me.MaterialesFamiliaBindingSource.DataSource = Me.DsMaterialFamilia
        '
        'DsMaterialFamilia
        '
        Me.DsMaterialFamilia.DataSetName = "DsMaterialFamilia"
        Me.DsMaterialFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_descripcion_DetalleComboBox
        '
        Me.Id_descripcion_DetalleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DescripcionesDetalleBindingSource, "Id_descripcion_Detalle", True))
        Me.Id_descripcion_DetalleComboBox.DataSource = Me.DescripcionesDetalleBindingSource
        Me.Id_descripcion_DetalleComboBox.DisplayMember = "Descripcion"
        Me.Id_descripcion_DetalleComboBox.FormattingEnabled = True
        Me.Id_descripcion_DetalleComboBox.Location = New System.Drawing.Point(167, 53)
        Me.Id_descripcion_DetalleComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_descripcion_DetalleComboBox.Name = "Id_descripcion_DetalleComboBox"
        Me.Id_descripcion_DetalleComboBox.Size = New System.Drawing.Size(361, 24)
        Me.Id_descripcion_DetalleComboBox.TabIndex = 63
        Me.Id_descripcion_DetalleComboBox.ValueMember = "Id_descripcion_Detalle"
        '
        'DescripcionesDetalleBindingSource
        '
        Me.DescripcionesDetalleBindingSource.DataMember = "DescripcionesDetalle"
        Me.DescripcionesDetalleBindingSource.DataSource = Me.DsDescripcionesdetalle
        '
        'DsDescripcionesdetalle
        '
        Me.DsDescripcionesdetalle.DataSetName = "DsDescripcionesdetalle"
        Me.DsDescripcionesdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_MaterialComboBox
        '
        Me.Id_MaterialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "Id_Material", True))
        Me.Id_MaterialComboBox.DataSource = Me.MaterialesBindingSource1
        Me.Id_MaterialComboBox.DisplayMember = "Descrpcion"
        Me.Id_MaterialComboBox.FormattingEnabled = True
        Me.Id_MaterialComboBox.Location = New System.Drawing.Point(773, 50)
        Me.Id_MaterialComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_MaterialComboBox.Name = "Id_MaterialComboBox"
        Me.Id_MaterialComboBox.Size = New System.Drawing.Size(249, 24)
        Me.Id_MaterialComboBox.TabIndex = 64
        Me.Id_MaterialComboBox.ValueMember = "Id_Material"
        '
        'MaterialesBindingSource1
        '
        Me.MaterialesBindingSource1.DataMember = "Materiales"
        Me.MaterialesBindingSource1.DataSource = Me.DsMaterial
        '
        'Id_MedidaComboBox
        '
        Me.Id_MedidaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Id_Medida", True))
        Me.Id_MedidaComboBox.DataSource = Me.MedidasCompraBindingSource
        Me.Id_MedidaComboBox.DisplayMember = "Descripcion_Medida"
        Me.Id_MedidaComboBox.FormattingEnabled = True
        Me.Id_MedidaComboBox.Location = New System.Drawing.Point(167, 240)
        Me.Id_MedidaComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_MedidaComboBox.Name = "Id_MedidaComboBox"
        Me.Id_MedidaComboBox.Size = New System.Drawing.Size(309, 24)
        Me.Id_MedidaComboBox.TabIndex = 61
        Me.Id_MedidaComboBox.ValueMember = "Id_Medida"
        '
        'SubArticulosDetalleBindingSource
        '
        Me.SubArticulosDetalleBindingSource.DataMember = "SubArticulosDetalle"
        Me.SubArticulosDetalleBindingSource.DataSource = Me.DsSubArticulosDetalle
        '
        'DsSubArticulosDetalle
        '
        Me.DsSubArticulosDetalle.DataSetName = "DsSubArticulosDetalle"
        Me.DsSubArticulosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDetalle
        '
        Me.txtDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Id_detalle_Sub_Articulo", True))
        Me.txtDetalle.Location = New System.Drawing.Point(167, 28)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(288, 22)
        Me.txtDetalle.TabIndex = 20
        '
        'LargoTextBox
        '
        Me.LargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Largo", True))
        Me.LargoTextBox.Location = New System.Drawing.Point(167, 86)
        Me.LargoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LargoTextBox.Name = "LargoTextBox"
        Me.LargoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.LargoTextBox.TabIndex = 26
        '
        'AnchoTextBox
        '
        Me.AnchoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Ancho", True))
        Me.AnchoTextBox.Location = New System.Drawing.Point(167, 116)
        Me.AnchoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AnchoTextBox.Name = "AnchoTextBox"
        Me.AnchoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AnchoTextBox.TabIndex = 28
        '
        'GruesoTextBox
        '
        Me.GruesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Grueso", True))
        Me.GruesoTextBox.Location = New System.Drawing.Point(167, 148)
        Me.GruesoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GruesoTextBox.Name = "GruesoTextBox"
        Me.GruesoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.GruesoTextBox.TabIndex = 30
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(167, 180)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(132, 22)
        Me.CantidadTextBox.TabIndex = 32
        '
        'PiesLargoTextBox
        '
        Me.PiesLargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "PiesLargo", True))
        Me.PiesLargoTextBox.Location = New System.Drawing.Point(891, 299)
        Me.PiesLargoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PiesLargoTextBox.Name = "PiesLargoTextBox"
        Me.PiesLargoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PiesLargoTextBox.TabIndex = 36
        '
        'AnchopulgadasTextBox
        '
        Me.AnchopulgadasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "Anchopulgadas", True))
        Me.AnchopulgadasTextBox.Location = New System.Drawing.Point(891, 331)
        Me.AnchopulgadasTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AnchopulgadasTextBox.Name = "AnchopulgadasTextBox"
        Me.AnchopulgadasTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AnchopulgadasTextBox.TabIndex = 38
        '
        'GruesoPulgadasTextBox
        '
        Me.GruesoPulgadasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "GruesoPulgadas", True))
        Me.GruesoPulgadasTextBox.Location = New System.Drawing.Point(891, 363)
        Me.GruesoPulgadasTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GruesoPulgadasTextBox.Name = "GruesoPulgadasTextBox"
        Me.GruesoPulgadasTextBox.Size = New System.Drawing.Size(132, 22)
        Me.GruesoPulgadasTextBox.TabIndex = 40
        '
        'PiesUnidadTextBox
        '
        Me.PiesUnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "PiesUnidad", True))
        Me.PiesUnidadTextBox.Location = New System.Drawing.Point(891, 395)
        Me.PiesUnidadTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PiesUnidadTextBox.Name = "PiesUnidadTextBox"
        Me.PiesUnidadTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PiesUnidadTextBox.TabIndex = 42
        '
        'M2CaraTextBox
        '
        Me.M2CaraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "M2Cara", True))
        Me.M2CaraTextBox.Location = New System.Drawing.Point(891, 427)
        Me.M2CaraTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M2CaraTextBox.Name = "M2CaraTextBox"
        Me.M2CaraTextBox.Size = New System.Drawing.Size(132, 22)
        Me.M2CaraTextBox.TabIndex = 44
        '
        'M2CantoTextBox
        '
        Me.M2CantoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "M2Canto", True))
        Me.M2CantoTextBox.Location = New System.Drawing.Point(891, 459)
        Me.M2CantoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M2CantoTextBox.Name = "M2CantoTextBox"
        Me.M2CantoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.M2CantoTextBox.TabIndex = 46
        '
        'M2CabezaTextBox
        '
        Me.M2CabezaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "M2Cabeza", True))
        Me.M2CabezaTextBox.Location = New System.Drawing.Point(891, 491)
        Me.M2CabezaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M2CabezaTextBox.Name = "M2CabezaTextBox"
        Me.M2CabezaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.M2CabezaTextBox.TabIndex = 48
        '
        'M2PinuturaUnidadTextBox
        '
        Me.M2PinuturaUnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "M2PinuturaUnidad", True))
        Me.M2PinuturaUnidadTextBox.Location = New System.Drawing.Point(891, 555)
        Me.M2PinuturaUnidadTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M2PinuturaUnidadTextBox.Name = "M2PinuturaUnidadTextBox"
        Me.M2PinuturaUnidadTextBox.Size = New System.Drawing.Size(132, 22)
        Me.M2PinuturaUnidadTextBox.TabIndex = 52
        '
        'M2PinuturaUnidadtotalTextBox
        '
        Me.M2PinuturaUnidadtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "M2PinuturaUnidadtotal", True))
        Me.M2PinuturaUnidadtotalTextBox.Location = New System.Drawing.Point(891, 587)
        Me.M2PinuturaUnidadtotalTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M2PinuturaUnidadtotalTextBox.Name = "M2PinuturaUnidadtotalTextBox"
        Me.M2PinuturaUnidadtotalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.M2PinuturaUnidadtotalTextBox.TabIndex = 54
        '
        'NuevoIdTextBox
        '
        Me.NuevoIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "NuevoId", True))
        Me.NuevoIdTextBox.Location = New System.Drawing.Point(891, 619)
        Me.NuevoIdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NuevoIdTextBox.Name = "NuevoIdTextBox"
        Me.NuevoIdTextBox.Size = New System.Drawing.Size(132, 22)
        Me.NuevoIdTextBox.TabIndex = 56
        '
        'ConsumoUnidadTextBox
        '
        Me.ConsumoUnidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubArticulosDetalleBindingSource, "ConsumoUnidad", True))
        Me.ConsumoUnidadTextBox.Location = New System.Drawing.Point(891, 651)
        Me.ConsumoUnidadTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConsumoUnidadTextBox.Name = "ConsumoUnidadTextBox"
        Me.ConsumoUnidadTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ConsumoUnidadTextBox.TabIndex = 58
        '
        'DescripcionesDetalleTableAdapter
        '
        Me.DescripcionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'SubArticulosDetalleTableAdapter
        '
        Me.SubArticulosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.SubArticulosDetalleTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 108)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Grupo SubArticulo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.DescripcionesDetalleTableAdapter = Me.DescripcionesDetalleTableAdapter
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.MaterialesTableAdapter = Me.MaterialesTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaterialesFamiliaTableAdapter
        '
        Me.MaterialesFamiliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.MaterialesFamiliaTableAdapter = Me.MaterialesFamiliaTableAdapter
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.Connection = Nothing
        Me.TableAdapterManager5.MaterilaesDetalleTableAdapter = Nothing
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmSubArticuloDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 878)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Id_Sub_ArticuloLabel)
        Me.Controls.Add(Me.Id_Sub_ArticuloTextBox)
        Me.Controls.Add(Descripcion_Sub_ArticuloLabel)
        Me.Controls.Add(Me.Descripcion_Sub_ArticuloTextBox)
        Me.Controls.Add(Me.SubArticulosBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSubArticuloDetalle"
        Me.Text = "FrmSubArticuloDetalle"
        CType(Me.DsSubArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubArticulosBindingNavigator.ResumeLayout(False)
        Me.SubArticulosBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MaterialesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubArticulosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSubArticulosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsSubArticulos As ModuloGestion.DsSubArticulos
    Friend WithEvents SubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosTableAdapter As ModuloGestion.DsSubArticulosTableAdapters.SubArticulosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsSubArticulosTableAdapters.TableAdapterManager
    Friend WithEvents SubArticulosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SubArticulosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_Sub_ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion_Sub_ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DsDescripcionesdetalle As ModuloGestion.DsDescripcionesdetalle
    Friend WithEvents DescripcionesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionesDetalleTableAdapter As ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter
    Friend WithEvents DsSubArticulosDetalle As ModuloGestion.DsSubArticulosDetalle
    Friend WithEvents SubArticulosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubArticulosDetalleTableAdapter As ModuloGestion.DsSubArticulosDetalleTableAdapters.SubArticulosDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsSubArticulosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Id_MedidaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents LargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnchoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PiesLargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnchopulgadasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GruesoPulgadasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PiesUnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M2CaraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M2CantoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M2CabezaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M2PinuturaUnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M2PinuturaUnidadtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NuevoIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConsumoUnidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents Id_descripcion_DetalleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsMaterial As ModuloGestion.DsMaterial
    Friend WithEvents MaterialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesTableAdapter As ModuloGestion.DsMaterialTableAdapters.MaterialesTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsMaterialTableAdapters.TableAdapterManager
    Friend WithEvents Id_MaterialComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MaterialesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsMaterialFamilia As ModuloGestion.DsMaterialFamilia
    Friend WithEvents MaterialesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialesFamiliaTableAdapter As ModuloGestion.DsMaterialFamiliaTableAdapters.MaterialesFamiliaTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsMaterialFamiliaTableAdapters.TableAdapterManager
    Friend WithEvents IdMatrialesFamiliaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_Material_DetalleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsMaterialDetalleTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MaterialesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
