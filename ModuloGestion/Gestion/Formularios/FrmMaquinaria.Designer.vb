<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaquinaria
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
        Dim IdMaquinariaLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim PlacaAntiguaLabel As System.Windows.Forms.Label
        Dim PLacaNuevaLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim ReponsableLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Dim DimemsionLargoLabel As System.Windows.Forms.Label
        Dim DimemsionAnchoLabel As System.Windows.Forms.Label
        Dim DimemsionAltoLabel As System.Windows.Forms.Label
        Dim DimemsionSuperficieLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim DimensionTrabajoLargoMaximoLabel As System.Windows.Forms.Label
        Dim DimensionTrabajoLargoMinimoLabel As System.Windows.Forms.Label
        Dim FechaDeCompraLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim PrecioCompraLabel1 As System.Windows.Forms.Label
        Dim PrecioActualLabel1 As System.Windows.Forms.Label
        Dim IdMaquinariaLabel1 As System.Windows.Forms.Label
        Dim IdTensionLabel As System.Windows.Forms.Label
        Dim TensionLabel As System.Windows.Forms.Label
        Dim PotenciaHpLabel As System.Windows.Forms.Label
        Dim PotenciaKwLabel As System.Windows.Forms.Label
        Dim PotenciaKvLabel As System.Windows.Forms.Label
        Dim FrecuenciaHerciosLabel As System.Windows.Forms.Label
        Dim IntensidadAmperesLabel As System.Windows.Forms.Label
        Dim RevolucionesMinutoLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaquinaria))
        Me.MaqinariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaquinarias = New ModuloGestion.DsMaquinarias()
        Me.IdMaquinariaTextBox = New System.Windows.Forms.TextBox()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.PlacaAntiguaTextBox = New System.Windows.Forms.TextBox()
        Me.PLacaNuevaTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.ReponsableTextBox = New System.Windows.Forms.TextBox()
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.DimemsionLargoTextBox = New System.Windows.Forms.TextBox()
        Me.DimemsionAnchoTextBox = New System.Windows.Forms.TextBox()
        Me.DimemsionAltoTextBox = New System.Windows.Forms.TextBox()
        Me.DimemsionSuperficieTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.DimensionTrabajoLargoMaximoTextBox = New System.Windows.Forms.TextBox()
        Me.DimensionTrabajoLargoMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.DimensionTrabajoAnchoMaximoTextBox = New System.Windows.Forms.TextBox()
        Me.DimensionTrabajoAnchoMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.DimensionTrabajoAltoMaximoTextBox = New System.Windows.Forms.TextBox()
        Me.DimensionTrabajoAltoMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.CimentacionCheckBox = New System.Windows.Forms.CheckBox()
        Me.CargaCimentacionTextBox = New System.Windows.Forms.TextBox()
        Me.FosoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ElectricidadCheckBox = New System.Windows.Forms.CheckBox()
        Me.AspiracionCheckBox = New System.Windows.Forms.CheckBox()
        Me.CuentaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDeCompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GbMaquinaria = New System.Windows.Forms.GroupBox()
        Me.MaqinariaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MaqinariaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrecioActualTextBox1 = New System.Windows.Forms.TextBox()
        Me.PrecioCompraTextBox1 = New System.Windows.Forms.TextBox()
        Me.CalefacionCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AireCheckBox = New System.Windows.Forms.CheckBox()
        Me.AguaCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GbElectricidad = New System.Windows.Forms.GroupBox()
        Me.IdMaquinariaTextBox1 = New System.Windows.Forms.TextBox()
        Me.ElectricidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RevolucionesMinutoTextBox = New System.Windows.Forms.TextBox()
        Me.IdTensionTextBox = New System.Windows.Forms.TextBox()
        Me.IntensidadAmperesTextBox = New System.Windows.Forms.TextBox()
        Me.TensionTextBox = New System.Windows.Forms.TextBox()
        Me.FrecuenciaHerciosTextBox = New System.Windows.Forms.TextBox()
        Me.PotenciaHpTextBox = New System.Windows.Forms.TextBox()
        Me.PotenciaKvTextBox = New System.Windows.Forms.TextBox()
        Me.PotenciaKwTextBox = New System.Windows.Forms.TextBox()
        Me.MaqinariaTableAdapter = New ModuloGestion.DsMaquinariasTableAdapters.MaqinariaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsMaquinariasTableAdapters.TableAdapterManager()
        Me.ElectricidadTableAdapter = New ModuloGestion.DsMaquinariasTableAdapters.ElectricidadTableAdapter()
        Me.AireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AireTableAdapter = New ModuloGestion.DsMaquinariasTableAdapters.AireTableAdapter()
        Me.FotoMaquinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillIdMaquinariaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdMaquinariaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdMaquinariaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillIdMaquinariaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FotoMaquinaTableAdapter = New ModuloGestion.DsMaquinariasTableAdapters.FotoMaquinaTableAdapter()
        IdMaquinariaLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        PlacaAntiguaLabel = New System.Windows.Forms.Label()
        PLacaNuevaLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        ReponsableLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        DimemsionLargoLabel = New System.Windows.Forms.Label()
        DimemsionAnchoLabel = New System.Windows.Forms.Label()
        DimemsionAltoLabel = New System.Windows.Forms.Label()
        DimemsionSuperficieLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        DimensionTrabajoLargoMaximoLabel = New System.Windows.Forms.Label()
        DimensionTrabajoLargoMinimoLabel = New System.Windows.Forms.Label()
        FechaDeCompraLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        PrecioCompraLabel1 = New System.Windows.Forms.Label()
        PrecioActualLabel1 = New System.Windows.Forms.Label()
        IdMaquinariaLabel1 = New System.Windows.Forms.Label()
        IdTensionLabel = New System.Windows.Forms.Label()
        TensionLabel = New System.Windows.Forms.Label()
        PotenciaHpLabel = New System.Windows.Forms.Label()
        PotenciaKwLabel = New System.Windows.Forms.Label()
        PotenciaKvLabel = New System.Windows.Forms.Label()
        FrecuenciaHerciosLabel = New System.Windows.Forms.Label()
        IntensidadAmperesLabel = New System.Windows.Forms.Label()
        RevolucionesMinutoLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.MaqinariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaquinarias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMaquinaria.SuspendLayout()
        CType(Me.MaqinariaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaqinariaBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbElectricidad.SuspendLayout()
        CType(Me.ElectricidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoMaquinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillIdMaquinariaToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdMaquinariaLabel
        '
        IdMaquinariaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        IdMaquinariaLabel.Location = New System.Drawing.Point(6, 48)
        IdMaquinariaLabel.Name = "IdMaquinariaLabel"
        IdMaquinariaLabel.Size = New System.Drawing.Size(100, 20)
        IdMaquinariaLabel.TabIndex = 1
        IdMaquinariaLabel.Text = "Id Maquinaria:"
        '
        'ActivoLabel
        '
        ActivoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ActivoLabel.Location = New System.Drawing.Point(166, 48)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(61, 20)
        ActivoLabel.TabIndex = 3
        ActivoLabel.Text = "Activo:"
        '
        'PlacaAntiguaLabel
        '
        PlacaAntiguaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PlacaAntiguaLabel.Location = New System.Drawing.Point(6, 79)
        PlacaAntiguaLabel.Name = "PlacaAntiguaLabel"
        PlacaAntiguaLabel.Size = New System.Drawing.Size(100, 20)
        PlacaAntiguaLabel.TabIndex = 5
        PlacaAntiguaLabel.Text = "Placa Antigua:"
        '
        'PLacaNuevaLabel
        '
        PLacaNuevaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PLacaNuevaLabel.Location = New System.Drawing.Point(6, 109)
        PLacaNuevaLabel.Name = "PLacaNuevaLabel"
        PLacaNuevaLabel.Size = New System.Drawing.Size(100, 20)
        PLacaNuevaLabel.TabIndex = 7
        PLacaNuevaLabel.Text = "PLaca Nueva:"
        '
        'MarcaLabel
        '
        MarcaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        MarcaLabel.Location = New System.Drawing.Point(6, 132)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(100, 20)
        MarcaLabel.TabIndex = 9
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ModeloLabel.Location = New System.Drawing.Point(6, 161)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(100, 20)
        ModeloLabel.TabIndex = 11
        ModeloLabel.Text = "Modelo:"
        '
        'ReponsableLabel
        '
        ReponsableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReponsableLabel.Location = New System.Drawing.Point(6, 184)
        ReponsableLabel.Name = "ReponsableLabel"
        ReponsableLabel.Size = New System.Drawing.Size(100, 20)
        ReponsableLabel.TabIndex = 13
        ReponsableLabel.Text = "Reponsable:"
        '
        'UbicacionLabel
        '
        UbicacionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        UbicacionLabel.Location = New System.Drawing.Point(6, 213)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(100, 20)
        UbicacionLabel.TabIndex = 15
        UbicacionLabel.Text = "Ubicacion:"
        '
        'DimemsionLargoLabel
        '
        DimemsionLargoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DimemsionLargoLabel.Location = New System.Drawing.Point(6, 259)
        DimemsionLargoLabel.Name = "DimemsionLargoLabel"
        DimemsionLargoLabel.Size = New System.Drawing.Size(142, 20)
        DimemsionLargoLabel.TabIndex = 17
        DimemsionLargoLabel.Text = "Dimemsion  Maquina"
        '
        'DimemsionAnchoLabel
        '
        DimemsionAnchoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DimemsionAnchoLabel.Location = New System.Drawing.Point(228, 238)
        DimemsionAnchoLabel.Name = "DimemsionAnchoLabel"
        DimemsionAnchoLabel.Size = New System.Drawing.Size(60, 20)
        DimemsionAnchoLabel.TabIndex = 19
        DimemsionAnchoLabel.Text = "Ancho:"
        '
        'DimemsionAltoLabel
        '
        DimemsionAltoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DimemsionAltoLabel.Location = New System.Drawing.Point(294, 238)
        DimemsionAltoLabel.Name = "DimemsionAltoLabel"
        DimemsionAltoLabel.Size = New System.Drawing.Size(60, 20)
        DimemsionAltoLabel.TabIndex = 21
        DimemsionAltoLabel.Text = " Alto:"
        '
        'DimemsionSuperficieLabel
        '
        DimemsionSuperficieLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DimemsionSuperficieLabel.Location = New System.Drawing.Point(365, 238)
        DimemsionSuperficieLabel.Name = "DimemsionSuperficieLabel"
        DimemsionSuperficieLabel.Size = New System.Drawing.Size(60, 20)
        DimemsionSuperficieLabel.TabIndex = 23
        DimemsionSuperficieLabel.Text = "Superficie:"
        '
        'PesoLabel
        '
        PesoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PesoLabel.Location = New System.Drawing.Point(159, 213)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(60, 20)
        PesoLabel.TabIndex = 25
        PesoLabel.Text = "Peso:"
        '
        'DimensionTrabajoLargoMaximoLabel
        '
        DimensionTrabajoLargoMaximoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DimensionTrabajoLargoMaximoLabel.Location = New System.Drawing.Point(6, 287)
        DimensionTrabajoLargoMaximoLabel.Name = "DimensionTrabajoLargoMaximoLabel"
        DimensionTrabajoLargoMaximoLabel.Size = New System.Drawing.Size(142, 20)
        DimensionTrabajoLargoMaximoLabel.TabIndex = 27
        DimensionTrabajoLargoMaximoLabel.Text = "Dimension Trabajo Maximo"
        '
        'DimensionTrabajoLargoMinimoLabel
        '
        DimensionTrabajoLargoMinimoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DimensionTrabajoLargoMinimoLabel.Location = New System.Drawing.Point(6, 315)
        DimensionTrabajoLargoMinimoLabel.Name = "DimensionTrabajoLargoMinimoLabel"
        DimensionTrabajoLargoMinimoLabel.Size = New System.Drawing.Size(142, 20)
        DimensionTrabajoLargoMinimoLabel.TabIndex = 29
        DimensionTrabajoLargoMinimoLabel.Text = "Dimension Trabajo Minimo:"
        '
        'FechaDeCompraLabel
        '
        FechaDeCompraLabel.AutoSize = True
        FechaDeCompraLabel.Location = New System.Drawing.Point(273, 49)
        FechaDeCompraLabel.Name = "FechaDeCompraLabel"
        FechaDeCompraLabel.Size = New System.Drawing.Size(96, 13)
        FechaDeCompraLabel.TabIndex = 61
        FechaDeCompraLabel.Text = "Fecha De Compra:"
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Location = New System.Drawing.Point(157, 238)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 20)
        Label1.TabIndex = 25
        Label1.Text = "Largo:"
        '
        'Label2
        '
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label2.Location = New System.Drawing.Point(294, 215)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(75, 20)
        Label2.TabIndex = 63
        Label2.Text = "Cimientacion:"
        '
        'Label3
        '
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label3.Location = New System.Drawing.Point(365, 289)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(41, 20)
        Label3.TabIndex = 64
        Label3.Text = "Foso:"
        '
        'Label4
        '
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label4.Location = New System.Drawing.Point(6, 343)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 20)
        Label4.TabIndex = 65
        Label4.Text = "Electricidad:"
        '
        'Label5
        '
        Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label5.Location = New System.Drawing.Point(6, 372)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(100, 20)
        Label5.TabIndex = 66
        Label5.Text = "Aspiracion:"
        '
        'Label6
        '
        Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label6.Location = New System.Drawing.Point(157, 343)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(63, 20)
        Label6.TabIndex = 67
        Label6.Text = "Aire:"
        '
        'Label7
        '
        Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label7.Location = New System.Drawing.Point(157, 376)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(63, 20)
        Label7.TabIndex = 69
        Label7.Text = "Agua:"
        '
        'Label8
        '
        Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label8.Location = New System.Drawing.Point(256, 343)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(63, 20)
        Label8.TabIndex = 70
        Label8.Text = "Calefacion:"
        '
        'PrecioCompraLabel1
        '
        PrecioCompraLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PrecioCompraLabel1.Location = New System.Drawing.Point(26, 410)
        PrecioCompraLabel1.Name = "PrecioCompraLabel1"
        PrecioCompraLabel1.Size = New System.Drawing.Size(80, 20)
        PrecioCompraLabel1.TabIndex = 60
        PrecioCompraLabel1.Text = "Precio Compra:"
        '
        'PrecioActualLabel1
        '
        PrecioActualLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PrecioActualLabel1.Location = New System.Drawing.Point(218, 410)
        PrecioActualLabel1.Name = "PrecioActualLabel1"
        PrecioActualLabel1.Size = New System.Drawing.Size(80, 20)
        PrecioActualLabel1.TabIndex = 61
        PrecioActualLabel1.Text = "Precio Actual:"
        '
        'IdMaquinariaLabel1
        '
        IdMaquinariaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        IdMaquinariaLabel1.Location = New System.Drawing.Point(23, 16)
        IdMaquinariaLabel1.Name = "IdMaquinariaLabel1"
        IdMaquinariaLabel1.Size = New System.Drawing.Size(74, 13)
        IdMaquinariaLabel1.TabIndex = 61
        IdMaquinariaLabel1.Text = "Id Maquinaria:"
        IdMaquinariaLabel1.Visible = False
        '
        'IdTensionLabel
        '
        IdTensionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        IdTensionLabel.Location = New System.Drawing.Point(49, 59)
        IdTensionLabel.Name = "IdTensionLabel"
        IdTensionLabel.Size = New System.Drawing.Size(68, 20)
        IdTensionLabel.TabIndex = 63
        IdTensionLabel.Text = "Id Tension:"
        '
        'TensionLabel
        '
        TensionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        TensionLabel.Location = New System.Drawing.Point(49, 85)
        TensionLabel.Name = "TensionLabel"
        TensionLabel.Size = New System.Drawing.Size(68, 20)
        TensionLabel.TabIndex = 65
        TensionLabel.Text = "Tension:"
        '
        'PotenciaHpLabel
        '
        PotenciaHpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PotenciaHpLabel.Location = New System.Drawing.Point(49, 111)
        PotenciaHpLabel.Name = "PotenciaHpLabel"
        PotenciaHpLabel.Size = New System.Drawing.Size(81, 20)
        PotenciaHpLabel.TabIndex = 67
        PotenciaHpLabel.Text = "Potencia Hp:"
        '
        'PotenciaKwLabel
        '
        PotenciaKwLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PotenciaKwLabel.Location = New System.Drawing.Point(49, 137)
        PotenciaKwLabel.Name = "PotenciaKwLabel"
        PotenciaKwLabel.Size = New System.Drawing.Size(81, 20)
        PotenciaKwLabel.TabIndex = 69
        PotenciaKwLabel.Text = "Potencia Kw:"
        '
        'PotenciaKvLabel
        '
        PotenciaKvLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PotenciaKvLabel.Location = New System.Drawing.Point(286, 58)
        PotenciaKvLabel.Name = "PotenciaKvLabel"
        PotenciaKvLabel.Size = New System.Drawing.Size(81, 20)
        PotenciaKvLabel.TabIndex = 71
        PotenciaKvLabel.Text = "Potencia Kv:"
        '
        'FrecuenciaHerciosLabel
        '
        FrecuenciaHerciosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        FrecuenciaHerciosLabel.Location = New System.Drawing.Point(286, 84)
        FrecuenciaHerciosLabel.Name = "FrecuenciaHerciosLabel"
        FrecuenciaHerciosLabel.Size = New System.Drawing.Size(110, 20)
        FrecuenciaHerciosLabel.TabIndex = 73
        FrecuenciaHerciosLabel.Text = "Frecuencia Hercios:"
        '
        'IntensidadAmperesLabel
        '
        IntensidadAmperesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        IntensidadAmperesLabel.Location = New System.Drawing.Point(286, 110)
        IntensidadAmperesLabel.Name = "IntensidadAmperesLabel"
        IntensidadAmperesLabel.Size = New System.Drawing.Size(110, 20)
        IntensidadAmperesLabel.TabIndex = 75
        IntensidadAmperesLabel.Text = "Intensidad Amperes:"
        '
        'RevolucionesMinutoLabel
        '
        RevolucionesMinutoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        RevolucionesMinutoLabel.Location = New System.Drawing.Point(286, 136)
        RevolucionesMinutoLabel.Name = "RevolucionesMinutoLabel"
        RevolucionesMinutoLabel.Size = New System.Drawing.Size(110, 20)
        RevolucionesMinutoLabel.TabIndex = 77
        RevolucionesMinutoLabel.Text = "Revoluciones Minuto:"
        '
        'Label9
        '
        Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label9.Location = New System.Drawing.Point(244, 376)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(50, 20)
        Label9.TabIndex = 72
        Label9.Text = " Cuenta:"
        '
        'MaqinariaBindingSource
        '
        Me.MaqinariaBindingSource.DataMember = "Maqinaria"
        Me.MaqinariaBindingSource.DataSource = Me.DsMaquinarias
        '
        'DsMaquinarias
        '
        Me.DsMaquinarias.DataSetName = "DsMaquinarias"
        Me.DsMaquinarias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdMaquinariaTextBox
        '
        Me.IdMaquinariaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "IdMaquinaria", True))
        Me.IdMaquinariaTextBox.Location = New System.Drawing.Point(112, 46)
        Me.IdMaquinariaTextBox.Name = "IdMaquinariaTextBox"
        Me.IdMaquinariaTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IdMaquinariaTextBox.TabIndex = 2
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Activo", True))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(244, 44)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.ActivoCheckBox.TabIndex = 4
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'PlacaAntiguaTextBox
        '
        Me.PlacaAntiguaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "PlacaAntigua", True))
        Me.PlacaAntiguaTextBox.Location = New System.Drawing.Point(112, 79)
        Me.PlacaAntiguaTextBox.Name = "PlacaAntiguaTextBox"
        Me.PlacaAntiguaTextBox.Size = New System.Drawing.Size(364, 20)
        Me.PlacaAntiguaTextBox.TabIndex = 6
        '
        'PLacaNuevaTextBox
        '
        Me.PLacaNuevaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "PLacaNueva", True))
        Me.PLacaNuevaTextBox.Location = New System.Drawing.Point(112, 109)
        Me.PLacaNuevaTextBox.Name = "PLacaNuevaTextBox"
        Me.PLacaNuevaTextBox.Size = New System.Drawing.Size(364, 20)
        Me.PLacaNuevaTextBox.TabIndex = 8
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(112, 135)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(364, 20)
        Me.MarcaTextBox.TabIndex = 10
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "Modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(112, 161)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(364, 20)
        Me.ModeloTextBox.TabIndex = 12
        '
        'ReponsableTextBox
        '
        Me.ReponsableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "Reponsable", True))
        Me.ReponsableTextBox.Location = New System.Drawing.Point(112, 187)
        Me.ReponsableTextBox.Name = "ReponsableTextBox"
        Me.ReponsableTextBox.Size = New System.Drawing.Size(364, 20)
        Me.ReponsableTextBox.TabIndex = 14
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "Ubicacion", True))
        Me.UbicacionTextBox.Location = New System.Drawing.Point(112, 213)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(36, 20)
        Me.UbicacionTextBox.TabIndex = 16
        '
        'DimemsionLargoTextBox
        '
        Me.DimemsionLargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimemsionLargo", True))
        Me.DimemsionLargoTextBox.Location = New System.Drawing.Point(157, 261)
        Me.DimemsionLargoTextBox.Name = "DimemsionLargoTextBox"
        Me.DimemsionLargoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimemsionLargoTextBox.TabIndex = 18
        '
        'DimemsionAnchoTextBox
        '
        Me.DimemsionAnchoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimemsionAncho", True))
        Me.DimemsionAnchoTextBox.Location = New System.Drawing.Point(228, 261)
        Me.DimemsionAnchoTextBox.Name = "DimemsionAnchoTextBox"
        Me.DimemsionAnchoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimemsionAnchoTextBox.TabIndex = 20
        '
        'DimemsionAltoTextBox
        '
        Me.DimemsionAltoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimemsionAlto", True))
        Me.DimemsionAltoTextBox.Location = New System.Drawing.Point(294, 261)
        Me.DimemsionAltoTextBox.Name = "DimemsionAltoTextBox"
        Me.DimemsionAltoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimemsionAltoTextBox.TabIndex = 22
        '
        'DimemsionSuperficieTextBox
        '
        Me.DimemsionSuperficieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimemsionSuperficie", True))
        Me.DimemsionSuperficieTextBox.Location = New System.Drawing.Point(365, 261)
        Me.DimemsionSuperficieTextBox.Name = "DimemsionSuperficieTextBox"
        Me.DimemsionSuperficieTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimemsionSuperficieTextBox.TabIndex = 24
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "Peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(225, 213)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(63, 20)
        Me.PesoTextBox.TabIndex = 26
        '
        'DimensionTrabajoLargoMaximoTextBox
        '
        Me.DimensionTrabajoLargoMaximoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimensionTrabajoLargoMaximo", True))
        Me.DimensionTrabajoLargoMaximoTextBox.Location = New System.Drawing.Point(157, 287)
        Me.DimensionTrabajoLargoMaximoTextBox.Name = "DimensionTrabajoLargoMaximoTextBox"
        Me.DimensionTrabajoLargoMaximoTextBox.Size = New System.Drawing.Size(63, 20)
        Me.DimensionTrabajoLargoMaximoTextBox.TabIndex = 28
        '
        'DimensionTrabajoLargoMinimoTextBox
        '
        Me.DimensionTrabajoLargoMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimensionTrabajoLargoMinimo", True))
        Me.DimensionTrabajoLargoMinimoTextBox.Location = New System.Drawing.Point(157, 313)
        Me.DimensionTrabajoLargoMinimoTextBox.Name = "DimensionTrabajoLargoMinimoTextBox"
        Me.DimensionTrabajoLargoMinimoTextBox.Size = New System.Drawing.Size(63, 20)
        Me.DimensionTrabajoLargoMinimoTextBox.TabIndex = 30
        '
        'DimensionTrabajoAnchoMaximoTextBox
        '
        Me.DimensionTrabajoAnchoMaximoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimensionTrabajoAnchoMaximo", True))
        Me.DimensionTrabajoAnchoMaximoTextBox.Location = New System.Drawing.Point(228, 287)
        Me.DimensionTrabajoAnchoMaximoTextBox.Name = "DimensionTrabajoAnchoMaximoTextBox"
        Me.DimensionTrabajoAnchoMaximoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimensionTrabajoAnchoMaximoTextBox.TabIndex = 32
        '
        'DimensionTrabajoAnchoMinimoTextBox
        '
        Me.DimensionTrabajoAnchoMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimensionTrabajoAnchoMinimo", True))
        Me.DimensionTrabajoAnchoMinimoTextBox.Location = New System.Drawing.Point(225, 313)
        Me.DimensionTrabajoAnchoMinimoTextBox.Name = "DimensionTrabajoAnchoMinimoTextBox"
        Me.DimensionTrabajoAnchoMinimoTextBox.Size = New System.Drawing.Size(63, 20)
        Me.DimensionTrabajoAnchoMinimoTextBox.TabIndex = 34
        '
        'DimensionTrabajoAltoMaximoTextBox
        '
        Me.DimensionTrabajoAltoMaximoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimensionTrabajoAltoMaximo", True))
        Me.DimensionTrabajoAltoMaximoTextBox.Location = New System.Drawing.Point(294, 287)
        Me.DimensionTrabajoAltoMaximoTextBox.Name = "DimensionTrabajoAltoMaximoTextBox"
        Me.DimensionTrabajoAltoMaximoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimensionTrabajoAltoMaximoTextBox.TabIndex = 36
        '
        'DimensionTrabajoAltoMinimoTextBox
        '
        Me.DimensionTrabajoAltoMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "DimensionTrabajoAltoMinimo", True))
        Me.DimensionTrabajoAltoMinimoTextBox.Location = New System.Drawing.Point(294, 313)
        Me.DimensionTrabajoAltoMinimoTextBox.Name = "DimensionTrabajoAltoMinimoTextBox"
        Me.DimensionTrabajoAltoMinimoTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DimensionTrabajoAltoMinimoTextBox.TabIndex = 38
        '
        'CimentacionCheckBox
        '
        Me.CimentacionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Cimentacion", True))
        Me.CimentacionCheckBox.Location = New System.Drawing.Point(375, 213)
        Me.CimentacionCheckBox.Name = "CimentacionCheckBox"
        Me.CimentacionCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.CimentacionCheckBox.TabIndex = 40
        Me.CimentacionCheckBox.UseVisualStyleBackColor = True
        '
        'CargaCimentacionTextBox
        '
        Me.CargaCimentacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "CargaCimentacion", True))
        Me.CargaCimentacionTextBox.Location = New System.Drawing.Point(401, 213)
        Me.CargaCimentacionTextBox.Name = "CargaCimentacionTextBox"
        Me.CargaCimentacionTextBox.Size = New System.Drawing.Size(75, 20)
        Me.CargaCimentacionTextBox.TabIndex = 42
        '
        'FosoCheckBox
        '
        Me.FosoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Foso", True))
        Me.FosoCheckBox.Location = New System.Drawing.Point(412, 285)
        Me.FosoCheckBox.Name = "FosoCheckBox"
        Me.FosoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.FosoCheckBox.TabIndex = 44
        Me.FosoCheckBox.UseVisualStyleBackColor = True
        '
        'ElectricidadCheckBox
        '
        Me.ElectricidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Electricidad", True))
        Me.ElectricidadCheckBox.Location = New System.Drawing.Point(112, 339)
        Me.ElectricidadCheckBox.Name = "ElectricidadCheckBox"
        Me.ElectricidadCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.ElectricidadCheckBox.TabIndex = 46
        Me.ElectricidadCheckBox.UseVisualStyleBackColor = True
        '
        'AspiracionCheckBox
        '
        Me.AspiracionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Aspiracion", True))
        Me.AspiracionCheckBox.Location = New System.Drawing.Point(112, 372)
        Me.AspiracionCheckBox.Name = "AspiracionCheckBox"
        Me.AspiracionCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.AspiracionCheckBox.TabIndex = 48
        Me.AspiracionCheckBox.UseVisualStyleBackColor = True
        '
        'CuentaTextBox
        '
        Me.CuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "Cuenta", True))
        Me.CuentaTextBox.Location = New System.Drawing.Point(306, 375)
        Me.CuentaTextBox.Name = "CuentaTextBox"
        Me.CuentaTextBox.Size = New System.Drawing.Size(170, 20)
        Me.CuentaTextBox.TabIndex = 54
        '
        'FechaDeCompraDateTimePicker
        '
        Me.FechaDeCompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MaqinariaBindingSource, "FechaDeCompra", True))
        Me.FechaDeCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDeCompraDateTimePicker.Location = New System.Drawing.Point(375, 46)
        Me.FechaDeCompraDateTimePicker.Name = "FechaDeCompraDateTimePicker"
        Me.FechaDeCompraDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.FechaDeCompraDateTimePicker.TabIndex = 62
        '
        'GbMaquinaria
        '
        Me.GbMaquinaria.Controls.Add(Me.MaqinariaBindingNavigator)
        Me.GbMaquinaria.Controls.Add(Label9)
        Me.GbMaquinaria.Controls.Add(Me.GroupBox1)
        Me.GbMaquinaria.Controls.Add(PrecioCompraLabel1)
        Me.GbMaquinaria.Controls.Add(Me.CuentaTextBox)
        Me.GbMaquinaria.Controls.Add(Me.PrecioActualTextBox1)
        Me.GbMaquinaria.Controls.Add(Me.PrecioCompraTextBox1)
        Me.GbMaquinaria.Controls.Add(PrecioActualLabel1)
        Me.GbMaquinaria.Controls.Add(Me.CalefacionCheckBox1)
        Me.GbMaquinaria.Controls.Add(Label8)
        Me.GbMaquinaria.Controls.Add(Label7)
        Me.GbMaquinaria.Controls.Add(Me.AireCheckBox)
        Me.GbMaquinaria.Controls.Add(Label6)
        Me.GbMaquinaria.Controls.Add(Me.AguaCheckBox1)
        Me.GbMaquinaria.Controls.Add(Label5)
        Me.GbMaquinaria.Controls.Add(Label4)
        Me.GbMaquinaria.Controls.Add(Label3)
        Me.GbMaquinaria.Controls.Add(Label2)
        Me.GbMaquinaria.Controls.Add(Me.ElectricidadCheckBox)
        Me.GbMaquinaria.Controls.Add(Me.AspiracionCheckBox)
        Me.GbMaquinaria.Controls.Add(Me.FosoCheckBox)
        Me.GbMaquinaria.Controls.Add(Me.CimentacionCheckBox)
        Me.GbMaquinaria.Controls.Add(Me.CargaCimentacionTextBox)
        Me.GbMaquinaria.Controls.Add(Label1)
        Me.GbMaquinaria.Controls.Add(Me.PesoTextBox)
        Me.GbMaquinaria.Controls.Add(PesoLabel)
        Me.GbMaquinaria.Controls.Add(IdMaquinariaLabel)
        Me.GbMaquinaria.Controls.Add(Me.DimemsionSuperficieTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimensionTrabajoAltoMinimoTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimensionTrabajoAltoMaximoTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimensionTrabajoLargoMinimoTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimensionTrabajoAnchoMaximoTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimensionTrabajoAnchoMinimoTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimensionTrabajoLargoMaximoTextBox)
        Me.GbMaquinaria.Controls.Add(DimensionTrabajoLargoMaximoLabel)
        Me.GbMaquinaria.Controls.Add(DimensionTrabajoLargoMinimoLabel)
        Me.GbMaquinaria.Controls.Add(Me.DimemsionLargoTextBox)
        Me.GbMaquinaria.Controls.Add(Me.DimemsionAnchoTextBox)
        Me.GbMaquinaria.Controls.Add(DimemsionLargoLabel)
        Me.GbMaquinaria.Controls.Add(Me.DimemsionAltoTextBox)
        Me.GbMaquinaria.Controls.Add(DimemsionAnchoLabel)
        Me.GbMaquinaria.Controls.Add(DimemsionAltoLabel)
        Me.GbMaquinaria.Controls.Add(DimemsionSuperficieLabel)
        Me.GbMaquinaria.Controls.Add(Me.UbicacionTextBox)
        Me.GbMaquinaria.Controls.Add(UbicacionLabel)
        Me.GbMaquinaria.Controls.Add(Me.ReponsableTextBox)
        Me.GbMaquinaria.Controls.Add(Me.FechaDeCompraDateTimePicker)
        Me.GbMaquinaria.Controls.Add(FechaDeCompraLabel)
        Me.GbMaquinaria.Controls.Add(ReponsableLabel)
        Me.GbMaquinaria.Controls.Add(Me.ModeloTextBox)
        Me.GbMaquinaria.Controls.Add(Me.IdMaquinariaTextBox)
        Me.GbMaquinaria.Controls.Add(ModeloLabel)
        Me.GbMaquinaria.Controls.Add(ActivoLabel)
        Me.GbMaquinaria.Controls.Add(Me.MarcaTextBox)
        Me.GbMaquinaria.Controls.Add(Me.ActivoCheckBox)
        Me.GbMaquinaria.Controls.Add(MarcaLabel)
        Me.GbMaquinaria.Controls.Add(PlacaAntiguaLabel)
        Me.GbMaquinaria.Controls.Add(Me.PLacaNuevaTextBox)
        Me.GbMaquinaria.Controls.Add(Me.PlacaAntiguaTextBox)
        Me.GbMaquinaria.Controls.Add(PLacaNuevaLabel)
        Me.GbMaquinaria.Location = New System.Drawing.Point(12, 12)
        Me.GbMaquinaria.Name = "GbMaquinaria"
        Me.GbMaquinaria.Size = New System.Drawing.Size(484, 652)
        Me.GbMaquinaria.TabIndex = 1
        Me.GbMaquinaria.TabStop = False
        Me.GbMaquinaria.Text = "Maquinaria"
        Me.GbMaquinaria.UseCompatibleTextRendering = True
        '
        'MaqinariaBindingNavigator
        '
        Me.MaqinariaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MaqinariaBindingNavigator.BindingSource = Me.MaqinariaBindingSource
        Me.MaqinariaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MaqinariaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MaqinariaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MaqinariaBindingNavigatorSaveItem})
        Me.MaqinariaBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.MaqinariaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MaqinariaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MaqinariaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MaqinariaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MaqinariaBindingNavigator.Name = "MaqinariaBindingNavigator"
        Me.MaqinariaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MaqinariaBindingNavigator.Size = New System.Drawing.Size(478, 25)
        Me.MaqinariaBindingNavigator.TabIndex = 73
        Me.MaqinariaBindingNavigator.Text = "BindingNavigator1"
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
        'MaqinariaBindingNavigatorSaveItem
        '
        Me.MaqinariaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MaqinariaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MaqinariaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MaqinariaBindingNavigatorSaveItem.Name = "MaqinariaBindingNavigatorSaveItem"
        Me.MaqinariaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MaqinariaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 190)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imajenes"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(307, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 118)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PrecioActualTextBox1
        '
        Me.PrecioActualTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "PrecioActual", True))
        Me.PrecioActualTextBox1.Location = New System.Drawing.Point(306, 410)
        Me.PrecioActualTextBox1.Name = "PrecioActualTextBox1"
        Me.PrecioActualTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PrecioActualTextBox1.TabIndex = 62
        '
        'PrecioCompraTextBox1
        '
        Me.PrecioCompraTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaqinariaBindingSource, "PrecioCompra", True))
        Me.PrecioCompraTextBox1.Location = New System.Drawing.Point(112, 410)
        Me.PrecioCompraTextBox1.Name = "PrecioCompraTextBox1"
        Me.PrecioCompraTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PrecioCompraTextBox1.TabIndex = 61
        '
        'CalefacionCheckBox1
        '
        Me.CalefacionCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Calefacion", True))
        Me.CalefacionCheckBox1.Location = New System.Drawing.Point(325, 339)
        Me.CalefacionCheckBox1.Name = "CalefacionCheckBox1"
        Me.CalefacionCheckBox1.Size = New System.Drawing.Size(18, 24)
        Me.CalefacionCheckBox1.TabIndex = 62
        Me.CalefacionCheckBox1.UseVisualStyleBackColor = True
        '
        'AireCheckBox
        '
        Me.AireCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Aire", True))
        Me.AireCheckBox.Location = New System.Drawing.Point(228, 343)
        Me.AireCheckBox.Name = "AireCheckBox"
        Me.AireCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.AireCheckBox.TabIndex = 68
        Me.AireCheckBox.UseVisualStyleBackColor = True
        '
        'AguaCheckBox1
        '
        Me.AguaCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MaqinariaBindingSource, "Agua", True))
        Me.AguaCheckBox1.Location = New System.Drawing.Point(228, 372)
        Me.AguaCheckBox1.Name = "AguaCheckBox1"
        Me.AguaCheckBox1.Size = New System.Drawing.Size(22, 24)
        Me.AguaCheckBox1.TabIndex = 61
        Me.AguaCheckBox1.UseVisualStyleBackColor = True
        '
        'GbElectricidad
        '
        Me.GbElectricidad.Controls.Add(IdMaquinariaLabel1)
        Me.GbElectricidad.Controls.Add(Me.IdMaquinariaTextBox1)
        Me.GbElectricidad.Controls.Add(Me.RevolucionesMinutoTextBox)
        Me.GbElectricidad.Controls.Add(IdTensionLabel)
        Me.GbElectricidad.Controls.Add(RevolucionesMinutoLabel)
        Me.GbElectricidad.Controls.Add(Me.IdTensionTextBox)
        Me.GbElectricidad.Controls.Add(Me.IntensidadAmperesTextBox)
        Me.GbElectricidad.Controls.Add(TensionLabel)
        Me.GbElectricidad.Controls.Add(IntensidadAmperesLabel)
        Me.GbElectricidad.Controls.Add(Me.TensionTextBox)
        Me.GbElectricidad.Controls.Add(Me.FrecuenciaHerciosTextBox)
        Me.GbElectricidad.Controls.Add(PotenciaHpLabel)
        Me.GbElectricidad.Controls.Add(FrecuenciaHerciosLabel)
        Me.GbElectricidad.Controls.Add(Me.PotenciaHpTextBox)
        Me.GbElectricidad.Controls.Add(Me.PotenciaKvTextBox)
        Me.GbElectricidad.Controls.Add(PotenciaKwLabel)
        Me.GbElectricidad.Controls.Add(PotenciaKvLabel)
        Me.GbElectricidad.Controls.Add(Me.PotenciaKwTextBox)
        Me.GbElectricidad.Location = New System.Drawing.Point(546, 60)
        Me.GbElectricidad.Name = "GbElectricidad"
        Me.GbElectricidad.Size = New System.Drawing.Size(541, 188)
        Me.GbElectricidad.TabIndex = 61
        Me.GbElectricidad.TabStop = False
        Me.GbElectricidad.Text = "Electricidad"
        '
        'IdMaquinariaTextBox1
        '
        Me.IdMaquinariaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "IdMaquinaria", True))
        Me.IdMaquinariaTextBox1.Location = New System.Drawing.Point(97, 14)
        Me.IdMaquinariaTextBox1.Name = "IdMaquinariaTextBox1"
        Me.IdMaquinariaTextBox1.Size = New System.Drawing.Size(20, 20)
        Me.IdMaquinariaTextBox1.TabIndex = 62
        Me.IdMaquinariaTextBox1.Visible = False
        '
        'ElectricidadBindingSource
        '
        Me.ElectricidadBindingSource.DataMember = "Electricidad"
        Me.ElectricidadBindingSource.DataSource = Me.DsMaquinarias
        '
        'RevolucionesMinutoTextBox
        '
        Me.RevolucionesMinutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "RevolucionesMinuto", True))
        Me.RevolucionesMinutoTextBox.Location = New System.Drawing.Point(417, 133)
        Me.RevolucionesMinutoTextBox.Name = "RevolucionesMinutoTextBox"
        Me.RevolucionesMinutoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RevolucionesMinutoTextBox.TabIndex = 78
        '
        'IdTensionTextBox
        '
        Me.IdTensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "IdTension", True))
        Me.IdTensionTextBox.Location = New System.Drawing.Point(180, 56)
        Me.IdTensionTextBox.Name = "IdTensionTextBox"
        Me.IdTensionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTensionTextBox.TabIndex = 64
        '
        'IntensidadAmperesTextBox
        '
        Me.IntensidadAmperesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "IntensidadAmperes", True))
        Me.IntensidadAmperesTextBox.Location = New System.Drawing.Point(417, 107)
        Me.IntensidadAmperesTextBox.Name = "IntensidadAmperesTextBox"
        Me.IntensidadAmperesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IntensidadAmperesTextBox.TabIndex = 76
        '
        'TensionTextBox
        '
        Me.TensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "Tension", True))
        Me.TensionTextBox.Location = New System.Drawing.Point(180, 82)
        Me.TensionTextBox.Name = "TensionTextBox"
        Me.TensionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TensionTextBox.TabIndex = 66
        '
        'FrecuenciaHerciosTextBox
        '
        Me.FrecuenciaHerciosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "FrecuenciaHercios", True))
        Me.FrecuenciaHerciosTextBox.Location = New System.Drawing.Point(417, 81)
        Me.FrecuenciaHerciosTextBox.Name = "FrecuenciaHerciosTextBox"
        Me.FrecuenciaHerciosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FrecuenciaHerciosTextBox.TabIndex = 74
        '
        'PotenciaHpTextBox
        '
        Me.PotenciaHpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "PotenciaHp", True))
        Me.PotenciaHpTextBox.Location = New System.Drawing.Point(180, 108)
        Me.PotenciaHpTextBox.Name = "PotenciaHpTextBox"
        Me.PotenciaHpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PotenciaHpTextBox.TabIndex = 68
        '
        'PotenciaKvTextBox
        '
        Me.PotenciaKvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "PotenciaKv", True))
        Me.PotenciaKvTextBox.Location = New System.Drawing.Point(417, 55)
        Me.PotenciaKvTextBox.Name = "PotenciaKvTextBox"
        Me.PotenciaKvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PotenciaKvTextBox.TabIndex = 72
        '
        'PotenciaKwTextBox
        '
        Me.PotenciaKwTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricidadBindingSource, "PotenciaKw", True))
        Me.PotenciaKwTextBox.Location = New System.Drawing.Point(180, 134)
        Me.PotenciaKwTextBox.Name = "PotenciaKwTextBox"
        Me.PotenciaKwTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PotenciaKwTextBox.TabIndex = 70
        '
        'MaqinariaTableAdapter
        '
        Me.MaqinariaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AguaTableAdapter = Nothing
        Me.TableAdapterManager.AireTableAdapter = Nothing
        Me.TableAdapterManager.AspiracionTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalefaccionTableAdapter = Nothing
        Me.TableAdapterManager.ElectricidadTableAdapter = Nothing
        Me.TableAdapterManager.FotoMaquinaTableAdapter = Nothing
        Me.TableAdapterManager.MaqinariaTableAdapter = Me.MaqinariaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsMaquinariasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ElectricidadTableAdapter
        '
        Me.ElectricidadTableAdapter.ClearBeforeFill = True
        '
        'AireBindingSource
        '
        Me.AireBindingSource.DataMember = "Aire"
        Me.AireBindingSource.DataSource = Me.DsMaquinarias
        '
        'AireTableAdapter
        '
        Me.AireTableAdapter.ClearBeforeFill = True
        '
        'FotoMaquinaBindingSource
        '
        Me.FotoMaquinaBindingSource.DataMember = "FotoMaquina"
        Me.FotoMaquinaBindingSource.DataSource = Me.DsMaquinarias
        '
        'FillIdMaquinariaToolStrip
        '
        Me.FillIdMaquinariaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdMaquinariaToolStripLabel, Me.IdMaquinariaToolStripTextBox, Me.FillIdMaquinariaToolStripButton})
        Me.FillIdMaquinariaToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillIdMaquinariaToolStrip.Name = "FillIdMaquinariaToolStrip"
        Me.FillIdMaquinariaToolStrip.Size = New System.Drawing.Size(1307, 25)
        Me.FillIdMaquinariaToolStrip.TabIndex = 62
        Me.FillIdMaquinariaToolStrip.Text = "FillIdMaquinariaToolStrip"
        '
        'IdMaquinariaToolStripLabel
        '
        Me.IdMaquinariaToolStripLabel.Name = "IdMaquinariaToolStripLabel"
        Me.IdMaquinariaToolStripLabel.Size = New System.Drawing.Size(80, 22)
        Me.IdMaquinariaToolStripLabel.Text = "IdMaquinaria:"
        '
        'IdMaquinariaToolStripTextBox
        '
        Me.IdMaquinariaToolStripTextBox.Name = "IdMaquinariaToolStripTextBox"
        Me.IdMaquinariaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillIdMaquinariaToolStripButton
        '
        Me.FillIdMaquinariaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillIdMaquinariaToolStripButton.Name = "FillIdMaquinariaToolStripButton"
        Me.FillIdMaquinariaToolStripButton.Size = New System.Drawing.Size(96, 22)
        Me.FillIdMaquinariaToolStripButton.Text = "FillIdMaquinaria"
        '
        'FotoMaquinaTableAdapter
        '
        Me.FotoMaquinaTableAdapter.ClearBeforeFill = True
        '
        'FrmMaquinaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1307, 741)
        Me.Controls.Add(Me.FillIdMaquinariaToolStrip)
        Me.Controls.Add(Me.GbElectricidad)
        Me.Controls.Add(Me.GbMaquinaria)
        Me.Name = "FrmMaquinaria"
        Me.Text = "FrmMaquinaria"
        CType(Me.MaqinariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaquinarias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMaquinaria.ResumeLayout(False)
        Me.GbMaquinaria.PerformLayout()
        CType(Me.MaqinariaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaqinariaBindingNavigator.ResumeLayout(False)
        Me.MaqinariaBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbElectricidad.ResumeLayout(False)
        Me.GbElectricidad.PerformLayout()
        CType(Me.ElectricidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoMaquinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillIdMaquinariaToolStrip.ResumeLayout(False)
        Me.FillIdMaquinariaToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents DsMaquinarias As ModuloGestion.DsMaquinarias
    Friend WithEvents MaqinariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaqinariaTableAdapter As ModuloGestion.DsMaquinariasTableAdapters.MaqinariaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsMaquinariasTableAdapters.TableAdapterManager
    Friend WithEvents IdMaquinariaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PlacaAntiguaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLacaNuevaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReponsableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimemsionLargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimemsionAnchoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimemsionAltoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimemsionSuperficieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PesoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimensionTrabajoLargoMaximoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimensionTrabajoLargoMinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimensionTrabajoAnchoMaximoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimensionTrabajoAnchoMinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimensionTrabajoAltoMaximoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DimensionTrabajoAltoMinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CimentacionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CargaCimentacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FosoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ElectricidadCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AspiracionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CuentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDeCompraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GbMaquinaria As System.Windows.Forms.GroupBox
    Friend WithEvents AguaCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CalefacionCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PrecioActualTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrecioCompraTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AireCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GbElectricidad As System.Windows.Forms.GroupBox
    Friend WithEvents ElectricidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectricidadTableAdapter As ModuloGestion.DsMaquinariasTableAdapters.ElectricidadTableAdapter
    Friend WithEvents IdMaquinariaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RevolucionesMinutoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IntensidadAmperesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FrecuenciaHerciosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PotenciaHpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PotenciaKvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PotenciaKwTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaqinariaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MaqinariaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AireTableAdapter As ModuloGestion.DsMaquinariasTableAdapters.AireTableAdapter
    Friend WithEvents FotoMaquinaBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents FillIdMaquinariaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdMaquinariaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdMaquinariaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillIdMaquinariaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FotoMaquinaTableAdapter As ModuloGestion.DsMaquinariasTableAdapters.FotoMaquinaTableAdapter
End Class
