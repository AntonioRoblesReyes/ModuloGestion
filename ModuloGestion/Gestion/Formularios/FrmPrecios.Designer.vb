<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrecios))
        Me.PreciosCompraProyectoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PreciosCompraProyectoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PreciosCompraProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreciosCompraProyecto = New ModuloGestion.DsPreciosCompraProyecto()
        Me.PreciosCompraProyectoTableAdapter = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager()
        CType(Me.PreciosCompraProyectoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PreciosCompraProyectoBindingNavigator.SuspendLayout()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreciosCompraProyectoBindingNavigator
        '
        Me.PreciosCompraProyectoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PreciosCompraProyectoBindingNavigator.BindingSource = Me.PreciosCompraProyectoBindingSource
        Me.PreciosCompraProyectoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PreciosCompraProyectoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PreciosCompraProyectoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PreciosCompraProyectoBindingNavigatorSaveItem})
        Me.PreciosCompraProyectoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PreciosCompraProyectoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PreciosCompraProyectoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PreciosCompraProyectoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PreciosCompraProyectoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PreciosCompraProyectoBindingNavigator.Name = "PreciosCompraProyectoBindingNavigator"
        Me.PreciosCompraProyectoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PreciosCompraProyectoBindingNavigator.Size = New System.Drawing.Size(757, 25)
        Me.PreciosCompraProyectoBindingNavigator.TabIndex = 0
        Me.PreciosCompraProyectoBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PreciosCompraProyectoBindingNavigatorSaveItem
        '
        Me.PreciosCompraProyectoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PreciosCompraProyectoBindingNavigatorSaveItem.Image = CType(resources.GetObject("PreciosCompraProyectoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PreciosCompraProyectoBindingNavigatorSaveItem.Name = "PreciosCompraProyectoBindingNavigatorSaveItem"
        Me.PreciosCompraProyectoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PreciosCompraProyectoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PreciosCompraProyectoBindingSource
        '
        Me.PreciosCompraProyectoBindingSource.DataMember = "PreciosCompraProyecto"
        Me.PreciosCompraProyectoBindingSource.DataSource = Me.DsPreciosCompraProyecto
        '
        'DsPreciosCompraProyecto
        '
        Me.DsPreciosCompraProyecto.DataSetName = "DsPreciosCompraProyecto"
        Me.DsPreciosCompraProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreciosCompraProyectoTableAdapter
        '
        Me.PreciosCompraProyectoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PreciosCompraProyectoTableAdapter = Me.PreciosCompraProyectoTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 363)
        Me.Controls.Add(Me.PreciosCompraProyectoBindingNavigator)
        Me.Name = "FrmPrecios"
        Me.Text = "FrmPrecios"
        CType(Me.PreciosCompraProyectoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PreciosCompraProyectoBindingNavigator.ResumeLayout(False)
        Me.PreciosCompraProyectoBindingNavigator.PerformLayout()
        CType(Me.PreciosCompraProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreciosCompraProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPreciosCompraProyecto As ModuloGestion.DsPreciosCompraProyecto
    Friend WithEvents PreciosCompraProyectoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreciosCompraProyectoTableAdapter As ModuloGestion.DsPreciosCompraProyectoTableAdapters.PreciosCompraProyectoTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPreciosCompraProyectoTableAdapters.TableAdapterManager
    Friend WithEvents PreciosCompraProyectoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PreciosCompraProyectoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
End Class
