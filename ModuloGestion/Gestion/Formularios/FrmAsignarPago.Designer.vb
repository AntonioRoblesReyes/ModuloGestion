<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignarPago
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
        Dim ID_CobroLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim AsignadoLabel As System.Windows.Forms.Label
        Dim PendienteAsignarLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarPago))
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsPagosClientes = New ModuloGestion.DsPagosClientes()
        Me.PagosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesTableAdapter = New ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager()
        Me.PagosClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PagosClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_CobroTextBox = New System.Windows.Forms.TextBox()
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.AsignadoTextBox = New System.Windows.Forms.TextBox()
        Me.PendienteAsignarTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectosDetalle = New ModuloGestion.DsProyectosDetalle()
        Me.ProyectosDetalleTableAdapter = New ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter()
        Me.TableAdapterManager2 = New ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectos = New ModuloGestion.DsProyectos()
        Me.ProyectosTableAdapter = New ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsProyectosTableAdapters.TableAdapterManager()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.DsFacturas = New ModuloGestion.DsFacturas()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager4 = New ModuloGestion.DsFacturasTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.DsPagosClientesDetalle = New ModuloGestion.DsPagosClientesDetalle()
        Me.PagosClientesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PagosClientesDetalleTableAdapter = New ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
        Me.TableAdapterManager5 = New ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_proyecto_Presupuestos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.PresupuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager3 = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.Proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagadoRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendienteRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_CobroLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        AsignadoLabel = New System.Windows.Forms.Label()
        PendienteAsignarLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagosClientesBindingNavigator.SuspendLayout()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CobroLabel
        '
        ID_CobroLabel.AutoSize = True
        ID_CobroLabel.Location = New System.Drawing.Point(80, 57)
        ID_CobroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_CobroLabel.Name = "ID_CobroLabel"
        ID_CobroLabel.Size = New System.Drawing.Size(63, 16)
        ID_CobroLabel.TabIndex = 1
        ID_CobroLabel.Text = "ID Cobro:"
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(84, 91)
        Id_FiscalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(60, 16)
        Id_FiscalLabel.TabIndex = 3
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(105, 123)
        ValorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(40, 16)
        ValorLabel.TabIndex = 7
        ValorLabel.Text = "Pago"
        '
        'AsignadoLabel
        '
        AsignadoLabel.AutoSize = True
        AsignadoLabel.Location = New System.Drawing.Point(85, 155)
        AsignadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AsignadoLabel.Name = "AsignadoLabel"
        AsignadoLabel.Size = New System.Drawing.Size(60, 16)
        AsignadoLabel.TabIndex = 9
        AsignadoLabel.Text = "Asignado:"
        '
        'PendienteAsignarLabel
        '
        PendienteAsignarLabel.AutoSize = True
        PendienteAsignarLabel.Location = New System.Drawing.Point(21, 186)
        PendienteAsignarLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PendienteAsignarLabel.Name = "PendienteAsignarLabel"
        PendienteAsignarLabel.Size = New System.Drawing.Size(120, 16)
        PendienteAsignarLabel.TabIndex = 11
        PendienteAsignarLabel.Text = "Pendiente Asignar:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Enabled = False
        MonedaLabel.Location = New System.Drawing.Point(297, 191)
        MonedaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(60, 16)
        MonedaLabel.TabIndex = 19
        MonedaLabel.Text = "Moneda:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(327, 57)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(48, 16)
        FechaLabel.TabIndex = 23
        FechaLabel.Text = "Fecha:"
        '
        'DsPagosClientes
        '
        Me.DsPagosClientes.DataSetName = "DsPagosClientes"
        Me.DsPagosClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesBindingSource
        '
        Me.PagosClientesBindingSource.DataMember = "PagosClientes"
        Me.PagosClientesBindingSource.DataSource = Me.DsPagosClientes
        '
        'PagosClientesTableAdapter
        '
        Me.PagosClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.PagosClientesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PagosClientesTableAdapter = Me.PagosClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PagosClientesBindingNavigator
        '
        Me.PagosClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PagosClientesBindingNavigator.BindingSource = Me.PagosClientesBindingSource
        Me.PagosClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PagosClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PagosClientesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PagosClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PagosClientesBindingNavigatorSaveItem})
        Me.PagosClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PagosClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PagosClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PagosClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PagosClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PagosClientesBindingNavigator.Name = "PagosClientesBindingNavigator"
        Me.PagosClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PagosClientesBindingNavigator.Size = New System.Drawing.Size(1454, 27)
        Me.PagosClientesBindingNavigator.TabIndex = 0
        Me.PagosClientesBindingNavigator.Text = "BindingNavigator1"
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
        'PagosClientesBindingNavigatorSaveItem
        '
        Me.PagosClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagosClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PagosClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PagosClientesBindingNavigatorSaveItem.Name = "PagosClientesBindingNavigatorSaveItem"
        Me.PagosClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PagosClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ID_CobroTextBox
        '
        Me.ID_CobroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "ID_Cobro", True))
        Me.ID_CobroTextBox.Enabled = False
        Me.ID_CobroTextBox.Location = New System.Drawing.Point(157, 53)
        Me.ID_CobroTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ID_CobroTextBox.Name = "ID_CobroTextBox"
        Me.ID_CobroTextBox.Size = New System.Drawing.Size(143, 22)
        Me.ID_CobroTextBox.TabIndex = 2
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Enabled = False
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(157, 87)
        Me.Id_FiscalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Id_FiscalTextBox.TabIndex = 4
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "valor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ValorTextBox.Enabled = False
        Me.ValorTextBox.Location = New System.Drawing.Point(157, 119)
        Me.ValorTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ValorTextBox.TabIndex = 8
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AsignadoTextBox
        '
        Me.AsignadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Asignado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.AsignadoTextBox.Enabled = False
        Me.AsignadoTextBox.Location = New System.Drawing.Point(157, 151)
        Me.AsignadoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AsignadoTextBox.Name = "AsignadoTextBox"
        Me.AsignadoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AsignadoTextBox.TabIndex = 10
        Me.AsignadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PendienteAsignarTextBox
        '
        Me.PendienteAsignarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "PendienteAsignar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.PendienteAsignarTextBox.Enabled = False
        Me.PendienteAsignarTextBox.Location = New System.Drawing.Point(157, 182)
        Me.PendienteAsignarTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PendienteAsignarTextBox.Name = "PendienteAsignarTextBox"
        Me.PendienteAsignarTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PendienteAsignarTextBox.TabIndex = 12
        Me.PendienteAsignarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'ProyectosDetalleTableAdapter
        '
        Me.ProyectosDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.ProyectosDetalleTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ProyectosTableAdapter = Me.ProyectosTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsProyectosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Location = New System.Drawing.Point(49, 225)
        Me.BtnAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(100, 28)
        Me.BtnAsignar.TabIndex = 17
        Me.BtnAsignar.Text = "Asignar"
        Me.BtnAsignar.UseVisualStyleBackColor = True
        '
        'DsFacturas
        '
        Me.DsFacturas.DataSetName = "DsFacturas"
        Me.DsFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DsFacturas
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.ClientesTableAdapter = Nothing
        Me.TableAdapterManager4.ComprobantesFiscalesTableAdapter = Nothing
        Me.TableAdapterManager4.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager4.FacturaDetalleTableAdapter = Nothing
        Me.TableAdapterManager4.FacturaProformaDetalleTableAdapter = Nothing
        Me.TableAdapterManager4.FacturaProformaTableAdapter = Nothing
        Me.TableAdapterManager4.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager4.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager4.UpdateOrder = ModuloGestion.DsFacturasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFactura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdFactura"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "IdFactura"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Asignado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1.Location = New System.Drawing.Point(157, 225)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MonedaTextBox
        '
        Me.MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Moneda", True))
        Me.MonedaTextBox.Enabled = False
        Me.MonedaTextBox.Location = New System.Drawing.Point(371, 182)
        Me.MonedaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MonedaTextBox.Name = "MonedaTextBox"
        Me.MonedaTextBox.Size = New System.Drawing.Size(63, 22)
        Me.MonedaTextBox.TabIndex = 20
        '
        'DsPagosClientesDetalle
        '
        Me.DsPagosClientesDetalle.DataSetName = "DsPagosClientesDetalle"
        Me.DsPagosClientesDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosClientesDetalleBindingSource
        '
        Me.PagosClientesDetalleBindingSource.DataMember = "PagosClientesDetalle"
        Me.PagosClientesDetalleBindingSource.DataSource = Me.DsPagosClientesDetalle
        '
        'PagosClientesDetalleTableAdapter
        '
        Me.PagosClientesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.PagosClientesDetalleTableAdapter = Me.PagosClientesDetalleTableAdapter
        Me.TableAdapterManager5.UpdateOrder = ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Presupuesto"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SubTotalUS
        '
        Me.SubTotalUS.DataPropertyName = "SubTotalUS"
        Me.SubTotalUS.HeaderText = "SubTotalUS"
        Me.SubTotalUS.MinimumWidth = 6
        Me.SubTotalUS.Name = "SubTotalUS"
        Me.SubTotalUS.Visible = False
        Me.SubTotalUS.Width = 75
        '
        'ImpuestoUS
        '
        Me.ImpuestoUS.DataPropertyName = "ValorImpuestoUs"
        Me.ImpuestoUS.HeaderText = "ValorImpuestoUS"
        Me.ImpuestoUS.MinimumWidth = 6
        Me.ImpuestoUS.Name = "ImpuestoUS"
        Me.ImpuestoUS.Visible = False
        Me.ImpuestoUS.Width = 75
        '
        'SubTotalRD
        '
        Me.SubTotalRD.DataPropertyName = "SubTotalRD"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "n2"
        Me.SubTotalRD.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubTotalRD.HeaderText = "SubTotal RD"
        Me.SubTotalRD.MinimumWidth = 6
        Me.SubTotalRD.Name = "SubTotalRD"
        Me.SubTotalRD.Visible = False
        Me.SubTotalRD.Width = 125
        '
        'ImpuestoRD
        '
        Me.ImpuestoRD.DataPropertyName = "ValorImpuestoRD"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n2"
        Me.ImpuestoRD.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImpuestoRD.HeaderText = "Impuesto RD"
        Me.ImpuestoRD.MinimumWidth = 6
        Me.ImpuestoRD.Name = "ImpuestoRD"
        Me.ImpuestoRD.Visible = False
        Me.ImpuestoRD.Width = 75
        '
        'Id_proyecto_Presupuestos
        '
        Me.Id_proyecto_Presupuestos.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.Id_proyecto_Presupuestos.HeaderText = "Id_proyecto_Presupuestos"
        Me.Id_proyecto_Presupuestos.MinimumWidth = 6
        Me.Id_proyecto_Presupuestos.Name = "Id_proyecto_Presupuestos"
        Me.Id_proyecto_Presupuestos.Visible = False
        Me.Id_proyecto_Presupuestos.Width = 125
        '
        'Id_Presupuesto
        '
        Me.Id_Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Id_Presupuesto.HeaderText = "Id_Presupuesto"
        Me.Id_Presupuesto.MinimumWidth = 6
        Me.Id_Presupuesto.Name = "Id_Presupuesto"
        Me.Id_Presupuesto.Visible = False
        Me.Id_Presupuesto.Width = 125
        '
        'Subtotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.Subtotal.HeaderText = "SubTotal"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Width = 75
        '
        'Impuesto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n2"
        Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle4
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.MinimumWidth = 6
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Width = 75
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagosClientesBindingSource, "Fecha", True))
        Me.FechaTextBox.Location = New System.Drawing.Point(388, 53)
        Me.FechaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.FechaTextBox.TabIndex = 24
        '
        'PresupuestoDataGridView
        '
        Me.PresupuestoDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Proyecto, Me.Presupuesto, Me.Descripcion, Me.Moneda, Me.TotalUS, Me.PagadoUS, Me.PendienteUS, Me.TotalRD, Me.PagadoRD, Me.PendienteRD, Me.Total, Me.Pagado, Me.Pendiente, Me.tasa})
        Me.PresupuestoDataGridView.DataSource = Me.PresupuestoBindingSource
        Me.PresupuestoDataGridView.Location = New System.Drawing.Point(24, 272)
        Me.PresupuestoDataGridView.Name = "PresupuestoDataGridView"
        Me.PresupuestoDataGridView.RowHeadersWidth = 51
        Me.PresupuestoDataGridView.RowTemplate.Height = 24
        Me.PresupuestoDataGridView.Size = New System.Drawing.Size(812, 220)
        Me.PresupuestoDataGridView.TabIndex = 24
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
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.PresupuestoTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Proyecto
        '
        Me.Proyecto.DataPropertyName = "Id_proyecto_Presupuestos"
        Me.Proyecto.HeaderText = "Proyecto"
        Me.Proyecto.MinimumWidth = 6
        Me.Proyecto.Name = "Proyecto"
        Me.Proyecto.Visible = False
        Me.Proyecto.Width = 125
        '
        'Presupuesto
        '
        Me.Presupuesto.DataPropertyName = "Id_Presupuesto"
        Me.Presupuesto.HeaderText = "Presupuesto"
        Me.Presupuesto.MinimumWidth = 6
        Me.Presupuesto.Name = "Presupuesto"
        Me.Presupuesto.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion_Presupuesto"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 125
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.MinimumWidth = 6
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Width = 125
        '
        'TotalUS
        '
        Me.TotalUS.DataPropertyName = "TotalPresupuestoUS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "n2"
        Me.TotalUS.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalUS.HeaderText = "TotalUS"
        Me.TotalUS.MinimumWidth = 6
        Me.TotalUS.Name = "TotalUS"
        Me.TotalUS.Visible = False
        Me.TotalUS.Width = 125
        '
        'PagadoUS
        '
        Me.PagadoUS.DataPropertyName = "PagadopresupuestoUS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.PagadoUS.DefaultCellStyle = DataGridViewCellStyle6
        Me.PagadoUS.HeaderText = "PagadoUS"
        Me.PagadoUS.MinimumWidth = 6
        Me.PagadoUS.Name = "PagadoUS"
        Me.PagadoUS.Visible = False
        Me.PagadoUS.Width = 125
        '
        'PendienteUS
        '
        Me.PendienteUS.DataPropertyName = "EstadoUS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.PendienteUS.DefaultCellStyle = DataGridViewCellStyle7
        Me.PendienteUS.HeaderText = "PendienteUS"
        Me.PendienteUS.MinimumWidth = 6
        Me.PendienteUS.Name = "PendienteUS"
        Me.PendienteUS.Visible = False
        Me.PendienteUS.Width = 125
        '
        'TotalRD
        '
        Me.TotalRD.DataPropertyName = "TotalPresupuestoRD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "n2"
        Me.TotalRD.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalRD.HeaderText = "TotalRD"
        Me.TotalRD.MinimumWidth = 6
        Me.TotalRD.Name = "TotalRD"
        Me.TotalRD.Visible = False
        Me.TotalRD.Width = 125
        '
        'PagadoRD
        '
        Me.PagadoRD.DataPropertyName = "PagadoRD"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "n2"
        Me.PagadoRD.DefaultCellStyle = DataGridViewCellStyle9
        Me.PagadoRD.HeaderText = "PagadoRD"
        Me.PagadoRD.MinimumWidth = 6
        Me.PagadoRD.Name = "PagadoRD"
        Me.PagadoRD.Visible = False
        Me.PagadoRD.Width = 125
        '
        'PendienteRD
        '
        Me.PendienteRD.DataPropertyName = "PendienteRDS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "n2"
        Me.PendienteRD.DefaultCellStyle = DataGridViewCellStyle10
        Me.PendienteRD.HeaderText = "PendienteRD"
        Me.PendienteRD.MinimumWidth = 6
        Me.PendienteRD.Name = "PendienteRD"
        Me.PendienteRD.Visible = False
        Me.PendienteRD.Width = 125
        '
        'Total
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "n2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle11
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.Width = 125
        '
        'Pagado
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "n2"
        Me.Pagado.DefaultCellStyle = DataGridViewCellStyle12
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.Width = 125
        '
        'Pendiente
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle13.Format = "n2"
        Me.Pendiente.DefaultCellStyle = DataGridViewCellStyle13
        Me.Pendiente.HeaderText = "Pendiente"
        Me.Pendiente.MinimumWidth = 6
        Me.Pendiente.Name = "Pendiente"
        Me.Pendiente.Width = 125
        '
        'tasa
        '
        Me.tasa.DataPropertyName = "tasa"
        Me.tasa.HeaderText = "tasa"
        Me.tasa.MinimumWidth = 6
        Me.tasa.Name = "tasa"
        Me.tasa.Visible = False
        Me.tasa.Width = 125
        '
        'FrmAsignarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1454, 598)
        Me.Controls.Add(Me.PresupuestoDataGridView)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(MonedaLabel)
        Me.Controls.Add(Me.MonedaTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnAsignar)
        Me.Controls.Add(PendienteAsignarLabel)
        Me.Controls.Add(Me.PendienteAsignarTextBox)
        Me.Controls.Add(AsignadoLabel)
        Me.Controls.Add(Me.AsignadoTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(ID_CobroLabel)
        Me.Controls.Add(Me.ID_CobroTextBox)
        Me.Controls.Add(Me.PagosClientesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAsignarPago"
        Me.Text = "FrmAsignarPago"
        CType(Me.DsPagosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagosClientesBindingNavigator.ResumeLayout(False)
        Me.PagosClientesBindingNavigator.PerformLayout()
        CType(Me.ProyectosDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPagosClientesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosClientesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPagosClientes As ModuloGestion.DsPagosClientes
    Friend WithEvents PagosClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesTableAdapter As ModuloGestion.DsPagosClientesTableAdapters.PagosClientesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPagosClientesTableAdapters.TableAdapterManager
    Friend WithEvents PagosClientesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PagosClientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_CobroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_FiscalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AsignadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PendienteAsignarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DsProyectosDetalle As ModuloGestion.DsProyectosDetalle
    Friend WithEvents ProyectosDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosDetalleTableAdapter As ModuloGestion.DsProyectosDetalleTableAdapters.ProyectosDetalleTableAdapter
    Friend WithEvents TableAdapterManager2 As ModuloGestion.DsProyectosDetalleTableAdapters.TableAdapterManager
    Friend WithEvents DsProyectos As ModuloGestion.DsProyectos
    Friend WithEvents ProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectosTableAdapter As ModuloGestion.DsProyectosTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsProyectosTableAdapters.TableAdapterManager
    Friend WithEvents BtnAsignar As System.Windows.Forms.Button
    Friend WithEvents DsPresupuestos As ModuloGestion.DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoTableAdapter As ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager3 As ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents DsFacturas As ModuloGestion.DsFacturas
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter As ModuloGestion.DsFacturasTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager4 As ModuloGestion.DsFacturasTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsPagosClientesDetalle As ModuloGestion.DsPagosClientesDetalle
    Friend WithEvents PagosClientesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagosClientesDetalleTableAdapter As ModuloGestion.DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter
    Friend WithEvents TableAdapterManager5 As ModuloGestion.DsPagosClientesDetalleTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MonedaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents SubTotalUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoUS As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents SubTotalRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoRD As System.Windows.Forms.DataGridViewTextBoxColumn


    Friend WithEvents Id_proyecto_Presupuestos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Presupuesto As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresupuestoDataGridView As DataGridView
    Friend WithEvents Proyecto As DataGridViewTextBoxColumn
    Friend WithEvents Presupuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents TotalUS As DataGridViewTextBoxColumn
    Friend WithEvents PagadoUS As DataGridViewTextBoxColumn
    Friend WithEvents PendienteUS As DataGridViewTextBoxColumn
    Friend WithEvents TotalRD As DataGridViewTextBoxColumn
    Friend WithEvents PagadoRD As DataGridViewTextBoxColumn
    Friend WithEvents PendienteRD As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Pendiente As DataGridViewTextBoxColumn
    Friend WithEvents tasa As DataGridViewTextBoxColumn
End Class
