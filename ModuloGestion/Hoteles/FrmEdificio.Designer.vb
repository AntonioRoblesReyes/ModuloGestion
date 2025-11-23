<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdificio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEdificio))
        Dim IdEdificiosLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim IdHotelLabel As System.Windows.Forms.Label
        Me.HotelesDataSet = New ModuloGestion.HotelesDataSet()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosTableAdapter = New ModuloGestion.HotelesDataSetTableAdapters.EdificiosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.HotelesDataSetTableAdapters.TableAdapterManager()
        Me.EdificiosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EdificiosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEdificiosTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.IdHotelTextBox = New System.Windows.Forms.TextBox()
        IdEdificiosLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdHotelLabel = New System.Windows.Forms.Label()
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EdificiosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'HotelesDataSet
        '
        Me.HotelesDataSet.DataSetName = "HotelesDataSet"
        Me.HotelesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.HotelesDataSet
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EdificiosTableAdapter = Me.EdificiosTableAdapter
        Me.TableAdapterManager.HabitacionesDetalleTableAdapter = Nothing
        Me.TableAdapterManager.HabitacionesTableAdapter = Nothing
        Me.TableAdapterManager.HotelesTableAdapter = Nothing
        Me.TableAdapterManager.PlantasDetalleTableAdapter = Nothing
        Me.TableAdapterManager.PlantasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.HotelesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EdificiosBindingNavigator
        '
        Me.EdificiosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EdificiosBindingNavigator.BindingSource = Me.EdificiosBindingSource
        Me.EdificiosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EdificiosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EdificiosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EdificiosBindingNavigatorSaveItem})
        Me.EdificiosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EdificiosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EdificiosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EdificiosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EdificiosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EdificiosBindingNavigator.Name = "EdificiosBindingNavigator"
        Me.EdificiosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EdificiosBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EdificiosBindingNavigator.TabIndex = 0
        Me.EdificiosBindingNavigator.Text = "BindingNavigator1"
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
        'EdificiosBindingNavigatorSaveItem
        '
        Me.EdificiosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EdificiosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EdificiosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EdificiosBindingNavigatorSaveItem.Name = "EdificiosBindingNavigatorSaveItem"
        Me.EdificiosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EdificiosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEdificiosLabel
        '
        IdEdificiosLabel.AutoSize = True
        IdEdificiosLabel.Location = New System.Drawing.Point(55, 169)
        IdEdificiosLabel.Name = "IdEdificiosLabel"
        IdEdificiosLabel.Size = New System.Drawing.Size(61, 13)
        IdEdificiosLabel.TabIndex = 1
        IdEdificiosLabel.Text = "Id Edificios:"
        '
        'IdEdificiosTextBox
        '
        Me.IdEdificiosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EdificiosBindingSource, "IdEdificios", True))
        Me.IdEdificiosTextBox.Location = New System.Drawing.Point(127, 166)
        Me.IdEdificiosTextBox.Name = "IdEdificiosTextBox"
        Me.IdEdificiosTextBox.Size = New System.Drawing.Size(144, 20)
        Me.IdEdificiosTextBox.TabIndex = 2
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(55, 195)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EdificiosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(127, 192)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(144, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'IdHotelLabel
        '
        IdHotelLabel.AutoSize = True
        IdHotelLabel.Location = New System.Drawing.Point(55, 221)
        IdHotelLabel.Name = "IdHotelLabel"
        IdHotelLabel.Size = New System.Drawing.Size(47, 13)
        IdHotelLabel.TabIndex = 5
        IdHotelLabel.Text = "Id Hotel:"
        '
        'IdHotelTextBox
        '
        Me.IdHotelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EdificiosBindingSource, "IdHotel", True))
        Me.IdHotelTextBox.Location = New System.Drawing.Point(127, 218)
        Me.IdHotelTextBox.Name = "IdHotelTextBox"
        Me.IdHotelTextBox.Size = New System.Drawing.Size(144, 20)
        Me.IdHotelTextBox.TabIndex = 6
        '
        'FrmEdificio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IdEdificiosLabel)
        Me.Controls.Add(Me.IdEdificiosTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(IdHotelLabel)
        Me.Controls.Add(Me.IdHotelTextBox)
        Me.Controls.Add(Me.EdificiosBindingNavigator)
        Me.Name = "FrmEdificio"
        Me.Text = "FrmEdificio"
        CType(Me.HotelesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EdificiosBindingNavigator.ResumeLayout(False)
        Me.EdificiosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HotelesDataSet As HotelesDataSet
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents EdificiosTableAdapter As HotelesDataSetTableAdapters.EdificiosTableAdapter
    Friend WithEvents TableAdapterManager As HotelesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EdificiosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EdificiosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEdificiosTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents IdHotelTextBox As TextBox
End Class
