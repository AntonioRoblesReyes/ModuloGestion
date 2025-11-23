<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoVheiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoVheiculo))
        Dim Id_EmpresaTransporteLabel As System.Windows.Forms.Label
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Me.DsVehiculosTransporte = New ModuloGestion.DsVehiculosTransporte()
        Me.VehiculosTransporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculosTransporteTableAdapter = New ModuloGestion.DsVehiculosTransporteTableAdapters.VehiculosTransporteTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsVehiculosTransporteTableAdapters.TableAdapterManager()
        Me.VehiculosTransporteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.VehiculosTransporteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_EmpresaTransporteTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Id_EmpresaTransporteLabel = New System.Windows.Forms.Label()
        PlacaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        CType(Me.DsVehiculosTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosTransporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosTransporteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehiculosTransporteBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsVehiculosTransporte
        '
        Me.DsVehiculosTransporte.DataSetName = "DsVehiculosTransporte"
        Me.DsVehiculosTransporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehiculosTransporteBindingSource
        '
        Me.VehiculosTransporteBindingSource.DataMember = "VehiculosTransporte"
        Me.VehiculosTransporteBindingSource.DataSource = Me.DsVehiculosTransporte
        '
        'VehiculosTransporteTableAdapter
        '
        Me.VehiculosTransporteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsVehiculosTransporteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTransporteTableAdapter = Me.VehiculosTransporteTableAdapter
        '
        'VehiculosTransporteBindingNavigator
        '
        Me.VehiculosTransporteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VehiculosTransporteBindingNavigator.BindingSource = Me.VehiculosTransporteBindingSource
        Me.VehiculosTransporteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VehiculosTransporteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VehiculosTransporteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VehiculosTransporteBindingNavigatorSaveItem})
        Me.VehiculosTransporteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VehiculosTransporteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehiculosTransporteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehiculosTransporteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehiculosTransporteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehiculosTransporteBindingNavigator.Name = "VehiculosTransporteBindingNavigator"
        Me.VehiculosTransporteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VehiculosTransporteBindingNavigator.Size = New System.Drawing.Size(403, 25)
        Me.VehiculosTransporteBindingNavigator.TabIndex = 0
        Me.VehiculosTransporteBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'VehiculosTransporteBindingNavigatorSaveItem
        '
        Me.VehiculosTransporteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehiculosTransporteBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehiculosTransporteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehiculosTransporteBindingNavigatorSaveItem.Name = "VehiculosTransporteBindingNavigatorSaveItem"
        Me.VehiculosTransporteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VehiculosTransporteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_EmpresaTransporteLabel
        '
        Id_EmpresaTransporteLabel.AutoSize = True
        Id_EmpresaTransporteLabel.Location = New System.Drawing.Point(11, 57)
        Id_EmpresaTransporteLabel.Name = "Id_EmpresaTransporteLabel"
        Id_EmpresaTransporteLabel.Size = New System.Drawing.Size(117, 13)
        Id_EmpresaTransporteLabel.TabIndex = 1
        Id_EmpresaTransporteLabel.Text = "Id Empresa Transporte:"
        '
        'Id_EmpresaTransporteTextBox
        '
        Me.Id_EmpresaTransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosTransporteBindingSource, "Id_EmpresaTransporte", True))
        Me.Id_EmpresaTransporteTextBox.Location = New System.Drawing.Point(134, 54)
        Me.Id_EmpresaTransporteTextBox.Name = "Id_EmpresaTransporteTextBox"
        Me.Id_EmpresaTransporteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_EmpresaTransporteTextBox.TabIndex = 2
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.Location = New System.Drawing.Point(11, 83)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(37, 13)
        PlacaLabel.TabIndex = 3
        PlacaLabel.Text = "Placa:"
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosTransporteBindingSource, "Placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(134, 80)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlacaTextBox.TabIndex = 4
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(11, 109)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(45, 13)
        ModeloLabel.TabIndex = 5
        ModeloLabel.Text = "Modelo:"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosTransporteBindingSource, "Modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(134, 106)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloTextBox.TabIndex = 6
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(11, 135)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(29, 13)
        AñoLabel.TabIndex = 7
        AñoLabel.Text = "Año:"
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosTransporteBindingSource, "Año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(134, 132)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AñoTextBox.TabIndex = 8
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(11, 161)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 9
        ColorLabel.Text = "Color:"
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosTransporteBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(134, 158)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColorTextBox.TabIndex = 10
        '
        'FrmNuevoVheiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 262)
        Me.Controls.Add(Id_EmpresaTransporteLabel)
        Me.Controls.Add(Me.Id_EmpresaTransporteTextBox)
        Me.Controls.Add(PlacaLabel)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(Me.VehiculosTransporteBindingNavigator)
        Me.Name = "FrmNuevoVheiculo"
        Me.Text = "FrmNuevoVheiculo"
        CType(Me.DsVehiculosTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosTransporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosTransporteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehiculosTransporteBindingNavigator.ResumeLayout(False)
        Me.VehiculosTransporteBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsVehiculosTransporte As ModuloGestion.DsVehiculosTransporte
    Friend WithEvents VehiculosTransporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculosTransporteTableAdapter As ModuloGestion.DsVehiculosTransporteTableAdapters.VehiculosTransporteTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsVehiculosTransporteTableAdapters.TableAdapterManager
    Friend WithEvents VehiculosTransporteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VehiculosTransporteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_EmpresaTransporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlacaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
End Class
