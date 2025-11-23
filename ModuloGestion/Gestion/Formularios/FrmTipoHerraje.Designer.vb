<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoHerraje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoHerraje))
        Dim Id_Tipo_HherrajeLabel As System.Windows.Forms.Label
        Dim DecripcionLabel As System.Windows.Forms.Label
        Me.DsHerrajesFamilia = New ModuloGestion.DsHerrajesFamilia()
        Me.HerrajesFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerrajesFamiliaTableAdapter = New ModuloGestion.DsHerrajesFamiliaTableAdapters.HerrajesFamiliaTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsHerrajesFamiliaTableAdapters.TableAdapterManager()
        Me.HerrajesFamiliaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HerrajesFamiliaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_Tipo_HherrajeTextBox = New System.Windows.Forms.TextBox()
        Me.DecripcionTextBox = New System.Windows.Forms.TextBox()
        Id_Tipo_HherrajeLabel = New System.Windows.Forms.Label()
        DecripcionLabel = New System.Windows.Forms.Label()
        CType(Me.DsHerrajesFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerrajesFamiliaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HerrajesFamiliaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsHerrajesFamilia
        '
        Me.DsHerrajesFamilia.DataSetName = "DsHerrajesFamilia"
        Me.DsHerrajesFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerrajesFamiliaBindingSource
        '
        Me.HerrajesFamiliaBindingSource.DataMember = "HerrajesFamilia"
        Me.HerrajesFamiliaBindingSource.DataSource = Me.DsHerrajesFamilia
        '
        'HerrajesFamiliaTableAdapter
        '
        Me.HerrajesFamiliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HerrajesFamiliaTableAdapter = Me.HerrajesFamiliaTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsHerrajesFamiliaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HerrajesFamiliaBindingNavigator
        '
        Me.HerrajesFamiliaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HerrajesFamiliaBindingNavigator.BindingSource = Me.HerrajesFamiliaBindingSource
        Me.HerrajesFamiliaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HerrajesFamiliaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HerrajesFamiliaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HerrajesFamiliaBindingNavigatorSaveItem})
        Me.HerrajesFamiliaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HerrajesFamiliaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HerrajesFamiliaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HerrajesFamiliaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HerrajesFamiliaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HerrajesFamiliaBindingNavigator.Name = "HerrajesFamiliaBindingNavigator"
        Me.HerrajesFamiliaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HerrajesFamiliaBindingNavigator.Size = New System.Drawing.Size(334, 25)
        Me.HerrajesFamiliaBindingNavigator.TabIndex = 0
        Me.HerrajesFamiliaBindingNavigator.Text = "BindingNavigator1"
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
        'HerrajesFamiliaBindingNavigatorSaveItem
        '
        Me.HerrajesFamiliaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HerrajesFamiliaBindingNavigatorSaveItem.Image = CType(resources.GetObject("HerrajesFamiliaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HerrajesFamiliaBindingNavigatorSaveItem.Name = "HerrajesFamiliaBindingNavigatorSaveItem"
        Me.HerrajesFamiliaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.HerrajesFamiliaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_Tipo_HherrajeLabel
        '
        Id_Tipo_HherrajeLabel.AutoSize = True
        Id_Tipo_HherrajeLabel.Location = New System.Drawing.Point(4, 69)
        Id_Tipo_HherrajeLabel.Name = "Id_Tipo_HherrajeLabel"
        Id_Tipo_HherrajeLabel.Size = New System.Drawing.Size(86, 13)
        Id_Tipo_HherrajeLabel.TabIndex = 1
        Id_Tipo_HherrajeLabel.Text = "Id Tipo Hherraje:"
        '
        'Id_Tipo_HherrajeTextBox
        '
        Me.Id_Tipo_HherrajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesFamiliaBindingSource, "Id_Tipo_Hherraje", True))
        Me.Id_Tipo_HherrajeTextBox.Location = New System.Drawing.Point(96, 66)
        Me.Id_Tipo_HherrajeTextBox.Name = "Id_Tipo_HherrajeTextBox"
        Me.Id_Tipo_HherrajeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_Tipo_HherrajeTextBox.TabIndex = 2
        '
        'DecripcionLabel
        '
        DecripcionLabel.AutoSize = True
        DecripcionLabel.Location = New System.Drawing.Point(4, 95)
        DecripcionLabel.Name = "DecripcionLabel"
        DecripcionLabel.Size = New System.Drawing.Size(61, 13)
        DecripcionLabel.TabIndex = 3
        DecripcionLabel.Text = "Decripcion:"
        '
        'DecripcionTextBox
        '
        Me.DecripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerrajesFamiliaBindingSource, "Decripcion", True))
        Me.DecripcionTextBox.Location = New System.Drawing.Point(96, 92)
        Me.DecripcionTextBox.Name = "DecripcionTextBox"
        Me.DecripcionTextBox.Size = New System.Drawing.Size(180, 20)
        Me.DecripcionTextBox.TabIndex = 4
        '
        'FrmTipoHerraje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 261)
        Me.Controls.Add(Id_Tipo_HherrajeLabel)
        Me.Controls.Add(Me.Id_Tipo_HherrajeTextBox)
        Me.Controls.Add(DecripcionLabel)
        Me.Controls.Add(Me.DecripcionTextBox)
        Me.Controls.Add(Me.HerrajesFamiliaBindingNavigator)
        Me.Name = "FrmTipoHerraje"
        Me.Text = "FrmTipoHerraje"
        CType(Me.DsHerrajesFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerrajesFamiliaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HerrajesFamiliaBindingNavigator.ResumeLayout(False)
        Me.HerrajesFamiliaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsHerrajesFamilia As ModuloGestion.DsHerrajesFamilia
    Friend WithEvents HerrajesFamiliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HerrajesFamiliaTableAdapter As ModuloGestion.DsHerrajesFamiliaTableAdapters.HerrajesFamiliaTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsHerrajesFamiliaTableAdapters.TableAdapterManager
    Friend WithEvents HerrajesFamiliaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HerrajesFamiliaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_Tipo_HherrajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DecripcionTextBox As System.Windows.Forms.TextBox
End Class
