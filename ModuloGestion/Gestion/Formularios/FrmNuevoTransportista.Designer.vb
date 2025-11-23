<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoTransportista
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
        Dim Id_EmpresaTransporteLabel As System.Windows.Forms.Label
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim Tlf1Label As System.Windows.Forms.Label
        Dim Tlf2Label As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoTransportista))
        Me.DsEmpresasTransporte = New ModuloGestion.DsEmpresasTransporte()
        Me.EmpresasTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTransporteTableAdapter = New ModuloGestion.DsEmpresasTransporteTableAdapters.EmpresasTransporteTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsEmpresasTransporteTableAdapters.TableAdapterManager()
        Me.EmpresasTransporteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpresasTransporteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_EmpresaTransporteTextBox = New System.Windows.Forms.TextBox()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.Tlf1TextBox = New System.Windows.Forms.TextBox()
        Me.Tlf2TextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Id_EmpresaTransporteLabel = New System.Windows.Forms.Label()
        RazonSocialLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        Tlf1Label = New System.Windows.Forms.Label()
        Tlf2Label = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.DsEmpresasTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasTransporteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresasTransporteBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_EmpresaTransporteLabel
        '
        Id_EmpresaTransporteLabel.AutoSize = True
        Id_EmpresaTransporteLabel.Location = New System.Drawing.Point(33, 53)
        Id_EmpresaTransporteLabel.Name = "Id_EmpresaTransporteLabel"
        Id_EmpresaTransporteLabel.Size = New System.Drawing.Size(117, 13)
        Id_EmpresaTransporteLabel.TabIndex = 1
        Id_EmpresaTransporteLabel.Text = "Id Empresa Transporte:"
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.Location = New System.Drawing.Point(33, 79)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(73, 13)
        RazonSocialLabel.TabIndex = 3
        RazonSocialLabel.Text = "Razon Social:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(33, 105)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Direccion:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(33, 131)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 7
        CiudadLabel.Text = "Ciudad:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(33, 157)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 9
        PaisLabel.Text = "Pais:"
        '
        'Tlf1Label
        '
        Tlf1Label.AutoSize = True
        Tlf1Label.Location = New System.Drawing.Point(33, 183)
        Tlf1Label.Name = "Tlf1Label"
        Tlf1Label.Size = New System.Drawing.Size(28, 13)
        Tlf1Label.TabIndex = 11
        Tlf1Label.Text = "Tlf1:"
        '
        'Tlf2Label
        '
        Tlf2Label.AutoSize = True
        Tlf2Label.Location = New System.Drawing.Point(33, 209)
        Tlf2Label.Name = "Tlf2Label"
        Tlf2Label.Size = New System.Drawing.Size(28, 13)
        Tlf2Label.TabIndex = 13
        Tlf2Label.Text = "Tlf2:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(33, 235)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 15
        FaxLabel.Text = "Fax:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(33, 261)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        '
        'DsEmpresasTransporte
        '
        Me.DsEmpresasTransporte.DataSetName = "DsEmpresasTransporte"
        Me.DsEmpresasTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresasTransporteBindingSource
        '
        Me.EmpresasTransporteBindingSource.DataMember = "EmpresasTransporte"
        Me.EmpresasTransporteBindingSource.DataSource = Me.DsEmpresasTransporte
        '
        'EmpresasTransporteTableAdapter
        '
        Me.EmpresasTransporteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpresasTransporteTableAdapter = Me.EmpresasTransporteTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsEmpresasTransporteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresasTransporteBindingNavigator
        '
        Me.EmpresasTransporteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresasTransporteBindingNavigator.BindingSource = Me.EmpresasTransporteBindingSource
        Me.EmpresasTransporteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresasTransporteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresasTransporteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresasTransporteBindingNavigatorSaveItem})
        Me.EmpresasTransporteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresasTransporteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresasTransporteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresasTransporteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresasTransporteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresasTransporteBindingNavigator.Name = "EmpresasTransporteBindingNavigator"
        Me.EmpresasTransporteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresasTransporteBindingNavigator.Size = New System.Drawing.Size(563, 25)
        Me.EmpresasTransporteBindingNavigator.TabIndex = 0
        Me.EmpresasTransporteBindingNavigator.Text = "BindingNavigator1"
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
        'EmpresasTransporteBindingNavigatorSaveItem
        '
        Me.EmpresasTransporteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresasTransporteBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresasTransporteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresasTransporteBindingNavigatorSaveItem.Name = "EmpresasTransporteBindingNavigatorSaveItem"
        Me.EmpresasTransporteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpresasTransporteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_EmpresaTransporteTextBox
        '
        Me.Id_EmpresaTransporteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id_EmpresaTransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Id_EmpresaTransporte", True))
        Me.Id_EmpresaTransporteTextBox.Location = New System.Drawing.Point(156, 50)
        Me.Id_EmpresaTransporteTextBox.Name = "Id_EmpresaTransporteTextBox"
        Me.Id_EmpresaTransporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_EmpresaTransporteTextBox.TabIndex = 2
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RazonSocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "RazonSocial", True))
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(156, 76)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(221, 20)
        Me.RazonSocialTextBox.TabIndex = 4
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(156, 102)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(221, 20)
        Me.DireccionTextBox.TabIndex = 6
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(156, 128)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(221, 20)
        Me.CiudadTextBox.TabIndex = 8
        '
        'PaisTextBox
        '
        Me.PaisTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(156, 154)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(221, 20)
        Me.PaisTextBox.TabIndex = 10
        '
        'Tlf1TextBox
        '
        Me.Tlf1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Tlf1", True))
        Me.Tlf1TextBox.Location = New System.Drawing.Point(156, 180)
        Me.Tlf1TextBox.Name = "Tlf1TextBox"
        Me.Tlf1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tlf1TextBox.TabIndex = 12
        Me.Tlf1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tlf2TextBox
        '
        Me.Tlf2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Tlf2", True))
        Me.Tlf2TextBox.Location = New System.Drawing.Point(156, 206)
        Me.Tlf2TextBox.Name = "Tlf2TextBox"
        Me.Tlf2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tlf2TextBox.TabIndex = 14
        Me.Tlf2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(156, 232)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FaxTextBox.TabIndex = 16
        Me.FaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresasTransporteBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(156, 258)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(221, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Nuevo Vehiculo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(383, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Nuevo Conductor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmNuevoTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 324)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_EmpresaTransporteLabel)
        Me.Controls.Add(Me.Id_EmpresaTransporteTextBox)
        Me.Controls.Add(RazonSocialLabel)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(Tlf1Label)
        Me.Controls.Add(Me.Tlf1TextBox)
        Me.Controls.Add(Tlf2Label)
        Me.Controls.Add(Me.Tlf2TextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.EmpresasTransporteBindingNavigator)
        Me.Name = "FrmNuevoTransportista"
        Me.Text = "FrmNuevoTransportista"
        CType(Me.DsEmpresasTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasTransporteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresasTransporteBindingNavigator.ResumeLayout(False)
        Me.EmpresasTransporteBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsEmpresasTransporte As ModuloGestion.DsEmpresasTransporte
    Friend WithEvents EmpresasTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasTransporteTableAdapter As ModuloGestion.DsEmpresasTransporteTableAdapters.EmpresasTransporteTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsEmpresasTransporteTableAdapters.TableAdapterManager
    Friend WithEvents EmpresasTransporteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmpresasTransporteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_EmpresaTransporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RazonSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tlf1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tlf2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
