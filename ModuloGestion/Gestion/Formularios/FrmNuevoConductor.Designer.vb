<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoConductor
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
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Apellido1Label As System.Windows.Forms.Label
        Dim Apellido2Label As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoConductor))
        Me.DsConductores = New ModuloGestion.DsConductores()
        Me.ConductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConductoresTableAdapter = New ModuloGestion.DsConductoresTableAdapters.ConductoresTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsConductoresTableAdapters.TableAdapterManager()
        Me.ConductoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ConductoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_EmpresaTransporteTextBox = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido1TextBox = New System.Windows.Forms.TextBox()
        Me.Apellido2TextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Id_EmpresaTransporteLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Apellido1Label = New System.Windows.Forms.Label()
        Apellido2Label = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        CType(Me.DsConductores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConductoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_EmpresaTransporteLabel
        '
        Id_EmpresaTransporteLabel.AutoSize = True
        Id_EmpresaTransporteLabel.Location = New System.Drawing.Point(26, 47)
        Id_EmpresaTransporteLabel.Name = "Id_EmpresaTransporteLabel"
        Id_EmpresaTransporteLabel.Size = New System.Drawing.Size(117, 13)
        Id_EmpresaTransporteLabel.TabIndex = 1
        Id_EmpresaTransporteLabel.Text = "Id Empresa Transporte:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(26, 73)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 3
        CedulaLabel.Text = "Cedula:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(26, 99)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'Apellido1Label
        '
        Apellido1Label.AutoSize = True
        Apellido1Label.Location = New System.Drawing.Point(26, 125)
        Apellido1Label.Name = "Apellido1Label"
        Apellido1Label.Size = New System.Drawing.Size(53, 13)
        Apellido1Label.TabIndex = 7
        Apellido1Label.Text = "Apellido1:"
        '
        'Apellido2Label
        '
        Apellido2Label.AutoSize = True
        Apellido2Label.Location = New System.Drawing.Point(26, 151)
        Apellido2Label.Name = "Apellido2Label"
        Apellido2Label.Size = New System.Drawing.Size(53, 13)
        Apellido2Label.TabIndex = 9
        Apellido2Label.Text = "Apellido2:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(26, 177)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 11
        CelularLabel.Text = "Celular:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(29, 200)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(40, 13)
        ActivoLabel.TabIndex = 13
        ActivoLabel.Text = "Activo:"
        '
        'DsConductores
        '
        Me.DsConductores.DataSetName = "DsConductores"
        Me.DsConductores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConductoresBindingSource
        '
        Me.ConductoresBindingSource.DataMember = "Conductores"
        Me.ConductoresBindingSource.DataSource = Me.DsConductores
        '
        'ConductoresTableAdapter
        '
        Me.ConductoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConductoresTableAdapter = Me.ConductoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsConductoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConductoresBindingNavigator
        '
        Me.ConductoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConductoresBindingNavigator.BindingSource = Me.ConductoresBindingSource
        Me.ConductoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConductoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConductoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConductoresBindingNavigatorSaveItem})
        Me.ConductoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConductoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConductoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConductoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConductoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConductoresBindingNavigator.Name = "ConductoresBindingNavigator"
        Me.ConductoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConductoresBindingNavigator.Size = New System.Drawing.Size(333, 25)
        Me.ConductoresBindingNavigator.TabIndex = 0
        Me.ConductoresBindingNavigator.Text = "BindingNavigator1"
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
        'ConductoresBindingNavigatorSaveItem
        '
        Me.ConductoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConductoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConductoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConductoresBindingNavigatorSaveItem.Name = "ConductoresBindingNavigatorSaveItem"
        Me.ConductoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConductoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_EmpresaTransporteTextBox
        '
        Me.Id_EmpresaTransporteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id_EmpresaTransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConductoresBindingSource, "Id_EmpresaTransporte", True))
        Me.Id_EmpresaTransporteTextBox.Enabled = False
        Me.Id_EmpresaTransporteTextBox.Location = New System.Drawing.Point(149, 44)
        Me.Id_EmpresaTransporteTextBox.Name = "Id_EmpresaTransporteTextBox"
        Me.Id_EmpresaTransporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_EmpresaTransporteTextBox.TabIndex = 2
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConductoresBindingSource, "Cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(87, 70)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CedulaTextBox.TabIndex = 4
        Me.CedulaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConductoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(87, 96)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(164, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'Apellido1TextBox
        '
        Me.Apellido1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Apellido1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConductoresBindingSource, "Apellido1", True))
        Me.Apellido1TextBox.Location = New System.Drawing.Point(87, 122)
        Me.Apellido1TextBox.Name = "Apellido1TextBox"
        Me.Apellido1TextBox.Size = New System.Drawing.Size(164, 20)
        Me.Apellido1TextBox.TabIndex = 8
        '
        'Apellido2TextBox
        '
        Me.Apellido2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Apellido2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConductoresBindingSource, "Apellido2", True))
        Me.Apellido2TextBox.Location = New System.Drawing.Point(87, 148)
        Me.Apellido2TextBox.Name = "Apellido2TextBox"
        Me.Apellido2TextBox.Size = New System.Drawing.Size(164, 20)
        Me.Apellido2TextBox.TabIndex = 10
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConductoresBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(87, 174)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 12
        Me.CelularTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ConductoresBindingSource, "Activo", True))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(87, 195)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(25, 24)
        Me.ActivoCheckBox.TabIndex = 14
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'FrmNuevoConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 262)
        Me.Controls.Add(ActivoLabel)
        Me.Controls.Add(Me.ActivoCheckBox)
        Me.Controls.Add(Id_EmpresaTransporteLabel)
        Me.Controls.Add(Me.Id_EmpresaTransporteTextBox)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.CedulaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Apellido1Label)
        Me.Controls.Add(Me.Apellido1TextBox)
        Me.Controls.Add(Apellido2Label)
        Me.Controls.Add(Me.Apellido2TextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(Me.ConductoresBindingNavigator)
        Me.Name = "FrmNuevoConductor"
        Me.Text = "FrmNuevoConductor"
        CType(Me.DsConductores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConductoresBindingNavigator.ResumeLayout(False)
        Me.ConductoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsConductores As ModuloGestion.DsConductores
    Friend WithEvents ConductoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConductoresTableAdapter As ModuloGestion.DsConductoresTableAdapters.ConductoresTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsConductoresTableAdapters.TableAdapterManager
    Friend WithEvents ConductoresBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ConductoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_EmpresaTransporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActivoCheckBox As System.Windows.Forms.CheckBox
End Class
