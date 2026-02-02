<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProyectoCliente
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
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim Id_ProyectoLabel As System.Windows.Forms.Label
        Dim Nombre_ProyectoLabel As System.Windows.Forms.Label
        Dim Direccion_ProyectoLabel As System.Windows.Forms.Label
        Dim Ciudad_ProyectoLabel As System.Windows.Forms.Label
        Dim Pais_ProyectoLabel As System.Windows.Forms.Label
        Dim DatosLabel As System.Windows.Forms.Label
        Dim MonedaPresupuestoLabel As System.Windows.Forms.Label
        Dim ImpuestoventaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProyectoCliente))
        Me.ProyectosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectos = New ModuloGestion.DsProyectos()
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
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.Id_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Direccion_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Ciudad_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.Pais_ProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.DatosTextBox = New System.Windows.Forms.TextBox()
        Me.BtnVerDAtos = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnCrearCarpetea = New System.Windows.Forms.Button()
        Me.DsClientes = New ModuloGestion.DsClientes()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsClientesTableAdapters.TableAdapterManager()
        Me.CarpetaDatosTextBox = New System.Windows.Forms.TextBox()
        Me.MonedaPresupuestoComboBox = New System.Windows.Forms.ComboBox()
        Me.ImpuestoventaTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.DsProyectosDetalle = New ModuloGestion.DsProyectosDetalle()
        Me.ProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectosDetalleTableAdapter = New ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        Id_ProyectoLabel = New System.Windows.Forms.Label()
        Nombre_ProyectoLabel = New System.Windows.Forms.Label()
        Direccion_ProyectoLabel = New System.Windows.Forms.Label()
        Ciudad_ProyectoLabel = New System.Windows.Forms.Label()
        Pais_ProyectoLabel = New System.Windows.Forms.Label()
        DatosLabel = New System.Windows.Forms.Label()
        MonedaPresupuestoLabel = New System.Windows.Forms.Label()
        ImpuestoventaLabel = New System.Windows.Forms.Label()
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProyectosBindingNavigator.SuspendLayout()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(12, 50)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(49, 13)
        Id_FiscalLabel.TabIndex = 1
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'Id_ProyectoLabel
        '
        Id_ProyectoLabel.AutoSize = True
        Id_ProyectoLabel.Location = New System.Drawing.Point(12, 76)
        Id_ProyectoLabel.Name = "Id_ProyectoLabel"
        Id_ProyectoLabel.Size = New System.Drawing.Size(64, 13)
        Id_ProyectoLabel.TabIndex = 3
        Id_ProyectoLabel.Text = "Id Proyecto:"
        '
        'Nombre_ProyectoLabel
        '
        Nombre_ProyectoLabel.AutoSize = True
        Nombre_ProyectoLabel.Location = New System.Drawing.Point(12, 102)
        Nombre_ProyectoLabel.Name = "Nombre_ProyectoLabel"
        Nombre_ProyectoLabel.Size = New System.Drawing.Size(92, 13)
        Nombre_ProyectoLabel.TabIndex = 5
        Nombre_ProyectoLabel.Text = "Nombre Proyecto:"
        '
        'Direccion_ProyectoLabel
        '
        Direccion_ProyectoLabel.AutoSize = True
        Direccion_ProyectoLabel.Location = New System.Drawing.Point(12, 128)
        Direccion_ProyectoLabel.Name = "Direccion_ProyectoLabel"
        Direccion_ProyectoLabel.Size = New System.Drawing.Size(100, 13)
        Direccion_ProyectoLabel.TabIndex = 7
        Direccion_ProyectoLabel.Text = "Direccion Proyecto:"
        '
        'Ciudad_ProyectoLabel
        '
        Ciudad_ProyectoLabel.AutoSize = True
        Ciudad_ProyectoLabel.Location = New System.Drawing.Point(12, 154)
        Ciudad_ProyectoLabel.Name = "Ciudad_ProyectoLabel"
        Ciudad_ProyectoLabel.Size = New System.Drawing.Size(88, 13)
        Ciudad_ProyectoLabel.TabIndex = 9
        Ciudad_ProyectoLabel.Text = "Ciudad Proyecto:"
        '
        'Pais_ProyectoLabel
        '
        Pais_ProyectoLabel.AutoSize = True
        Pais_ProyectoLabel.Location = New System.Drawing.Point(12, 180)
        Pais_ProyectoLabel.Name = "Pais_ProyectoLabel"
        Pais_ProyectoLabel.Size = New System.Drawing.Size(75, 13)
        Pais_ProyectoLabel.TabIndex = 11
        Pais_ProyectoLabel.Text = "Pais Proyecto:"
        '
        'DatosLabel
        '
        DatosLabel.AutoSize = True
        DatosLabel.Location = New System.Drawing.Point(12, 207)
        DatosLabel.Name = "DatosLabel"
        DatosLabel.Size = New System.Drawing.Size(78, 13)
        DatosLabel.TabIndex = 15
        DatosLabel.Text = "Carpeta Datos:"
        '
        'MonedaPresupuestoLabel
        '
        MonedaPresupuestoLabel.AutoSize = True
        MonedaPresupuestoLabel.Location = New System.Drawing.Point(372, 50)
        MonedaPresupuestoLabel.Name = "MonedaPresupuestoLabel"
        MonedaPresupuestoLabel.Size = New System.Drawing.Size(105, 13)
        MonedaPresupuestoLabel.TabIndex = 19
        MonedaPresupuestoLabel.Text = "Moneda Facturacion"
        '
        'ImpuestoventaLabel
        '
        ImpuestoventaLabel.AutoSize = True
        ImpuestoventaLabel.Location = New System.Drawing.Point(427, 102)
        ImpuestoventaLabel.Name = "ImpuestoventaLabel"
        ImpuestoventaLabel.Size = New System.Drawing.Size(56, 13)
        ImpuestoventaLabel.TabIndex = 20
        ImpuestoventaLabel.Text = "Impuesto :"
        '
        'ProyectosBindingNavigator
        '
        Me.ProyectosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProyectosBindingNavigator.BindingSource = Me.ProyectosBindingSource
        Me.ProyectosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProyectosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProyectosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProyectosBindingNavigatorSaveItem})
        Me.ProyectosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProyectosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProyectosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProyectosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProyectosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProyectosBindingNavigator.Name = "ProyectosBindingNavigator"
        Me.ProyectosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProyectosBindingNavigator.Size = New System.Drawing.Size(658, 25)
        Me.ProyectosBindingNavigator.TabIndex = 0
        Me.ProyectosBindingNavigator.Text = "BindingNavigator1"
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
        'ProyectosBindingNavigatorSaveItem
        '
        Me.ProyectosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProyectosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProyectosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProyectosBindingNavigatorSaveItem.Name = "ProyectosBindingNavigatorSaveItem"
        Me.ProyectosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProyectosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(121, 47)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_FiscalTextBox.TabIndex = 2
        '
        'Id_ProyectoTextBox
        '
        Me.Id_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Id_Proyecto", True))
        Me.Id_ProyectoTextBox.Location = New System.Drawing.Point(121, 73)
        Me.Id_ProyectoTextBox.Name = "Id_ProyectoTextBox"
        Me.Id_ProyectoTextBox.Size = New System.Drawing.Size(77, 20)
        Me.Id_ProyectoTextBox.TabIndex = 4
        '
        'Nombre_ProyectoTextBox
        '
        Me.Nombre_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Nombre_Proyecto", True))
        Me.Nombre_ProyectoTextBox.Location = New System.Drawing.Point(121, 99)
        Me.Nombre_ProyectoTextBox.Name = "Nombre_ProyectoTextBox"
        Me.Nombre_ProyectoTextBox.Size = New System.Drawing.Size(300, 20)
        Me.Nombre_ProyectoTextBox.TabIndex = 6
        '
        'Direccion_ProyectoTextBox
        '
        Me.Direccion_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Direccion_Proyecto", True))
        Me.Direccion_ProyectoTextBox.Location = New System.Drawing.Point(121, 125)
        Me.Direccion_ProyectoTextBox.Name = "Direccion_ProyectoTextBox"
        Me.Direccion_ProyectoTextBox.Size = New System.Drawing.Size(300, 20)
        Me.Direccion_ProyectoTextBox.TabIndex = 8
        '
        'Ciudad_ProyectoTextBox
        '
        Me.Ciudad_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Ciudad_Proyecto", True))
        Me.Ciudad_ProyectoTextBox.Location = New System.Drawing.Point(121, 151)
        Me.Ciudad_ProyectoTextBox.Name = "Ciudad_ProyectoTextBox"
        Me.Ciudad_ProyectoTextBox.Size = New System.Drawing.Size(300, 20)
        Me.Ciudad_ProyectoTextBox.TabIndex = 10
        '
        'Pais_ProyectoTextBox
        '
        Me.Pais_ProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Pais_Proyecto", True))
        Me.Pais_ProyectoTextBox.Location = New System.Drawing.Point(121, 177)
        Me.Pais_ProyectoTextBox.Name = "Pais_ProyectoTextBox"
        Me.Pais_ProyectoTextBox.Size = New System.Drawing.Size(300, 20)
        Me.Pais_ProyectoTextBox.TabIndex = 12
        '
        'DatosTextBox
        '
        Me.DatosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Datos", True))
        Me.DatosTextBox.Location = New System.Drawing.Point(121, 204)
        Me.DatosTextBox.Name = "DatosTextBox"
        Me.DatosTextBox.Size = New System.Drawing.Size(300, 20)
        Me.DatosTextBox.TabIndex = 16
        '
        'BtnVerDAtos
        '
        Me.BtnVerDAtos.Location = New System.Drawing.Point(427, 202)
        Me.BtnVerDAtos.Name = "BtnVerDAtos"
        Me.BtnVerDAtos.Size = New System.Drawing.Size(85, 23)
        Me.BtnVerDAtos.TabIndex = 17
        Me.BtnVerDAtos.Text = "Ver Datos"
        Me.BtnVerDAtos.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "\\PCShernia\Users\Public\Carpeta Datos\Proyectos"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Nombre_ProyectoTextBox.text"
        Me.SaveFileDialog1.InitialDirectory = "\\PCShernia\Users\Public\Carpeta Datos\Proyectos"
        '
        'BtnCrearCarpetea
        '
        Me.BtnCrearCarpetea.Location = New System.Drawing.Point(227, 45)
        Me.BtnCrearCarpetea.Name = "BtnCrearCarpetea"
        Me.BtnCrearCarpetea.Size = New System.Drawing.Size(133, 23)
        Me.BtnCrearCarpetea.TabIndex = 18
        Me.BtnCrearCarpetea.Text = "Crear Carpeta Datos"
        Me.BtnCrearCarpetea.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarpetaDatosTextBox
        '
        Me.CarpetaDatosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CarpetaDatos", True))
        Me.CarpetaDatosTextBox.Location = New System.Drawing.Point(220, 73)
        Me.CarpetaDatosTextBox.Name = "CarpetaDatosTextBox"
        Me.CarpetaDatosTextBox.Size = New System.Drawing.Size(345, 20)
        Me.CarpetaDatosTextBox.TabIndex = 19
        '
        'MonedaPresupuestoComboBox
        '
        Me.MonedaPresupuestoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "MonedaPresupuesto", True))
        Me.MonedaPresupuestoComboBox.FormattingEnabled = True
        Me.MonedaPresupuestoComboBox.Items.AddRange(New Object() {"US$", "RD$", "EUR"})
        Me.MonedaPresupuestoComboBox.Location = New System.Drawing.Point(489, 47)
        Me.MonedaPresupuestoComboBox.Name = "MonedaPresupuestoComboBox"
        Me.MonedaPresupuestoComboBox.Size = New System.Drawing.Size(69, 21)
        Me.MonedaPresupuestoComboBox.TabIndex = 20
        '
        'ImpuestoventaTextBox
        '
        Me.ImpuestoventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Impuestoventa", True))
        Me.ImpuestoventaTextBox.Location = New System.Drawing.Point(489, 99)
        Me.ImpuestoventaTextBox.Name = "ImpuestoventaTextBox"
        Me.ImpuestoventaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ImpuestoventaTextBox.TabIndex = 21
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsProyectosDetalle
        '
        Me.DsProyectosDetalle.DataSetName = "DsProyectosDetalle"
        Me.DsProyectosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectosDetalleBindingSource
        '
        Me.ProyectosDetalleBindingSource.DataMember = "ProyectosDetalle"
        Me.ProyectosDetalleBindingSource.DataSource = Me.DsProyectosDetalle
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
        'FrmProyectoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 309)
        Me.Controls.Add(ImpuestoventaLabel)
        Me.Controls.Add(Me.ImpuestoventaTextBox)
        Me.Controls.Add(MonedaPresupuestoLabel)
        Me.Controls.Add(Me.MonedaPresupuestoComboBox)
        Me.Controls.Add(Me.CarpetaDatosTextBox)
        Me.Controls.Add(Me.BtnCrearCarpetea)
        Me.Controls.Add(Me.BtnVerDAtos)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(Id_ProyectoLabel)
        Me.Controls.Add(Me.Id_ProyectoTextBox)
        Me.Controls.Add(Nombre_ProyectoLabel)
        Me.Controls.Add(Me.Nombre_ProyectoTextBox)
        Me.Controls.Add(Direccion_ProyectoLabel)
        Me.Controls.Add(Me.Direccion_ProyectoTextBox)
        Me.Controls.Add(Ciudad_ProyectoLabel)
        Me.Controls.Add(Me.Ciudad_ProyectoTextBox)
        Me.Controls.Add(Pais_ProyectoLabel)
        Me.Controls.Add(Me.Pais_ProyectoTextBox)
        Me.Controls.Add(DatosLabel)
        Me.Controls.Add(Me.DatosTextBox)
        Me.Controls.Add(Me.ProyectosBindingNavigator)
        Me.Name = "FrmProyectoCliente"
        Me.Text = "FrmProyectoCliente"
        CType(Me.ProyectosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProyectosBindingNavigator.ResumeLayout(False)
        Me.ProyectosBindingNavigator.PerformLayout()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
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
    Friend WithEvents Id_FiscalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Direccion_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ciudad_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pais_ProyectoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnVerDAtos As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BtnCrearCarpetea As System.Windows.Forms.Button
    Friend WithEvents DsClientes As ModuloGestion.DsClientes
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ModuloGestion.DsClientesTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsClientesTableAdapters.TableAdapterManager
    Friend WithEvents CarpetaDatosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonedaPresupuestoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImpuestoventaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsProyectosDetalle As ModuloGestion.DsProyectosDetalle
    Friend WithEvents ProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleTableAdapter As ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager
End Class
