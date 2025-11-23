<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim NiombreUsuaarioLabel As System.Windows.Forms.Label
        Dim ConrasenaLabel As System.Windows.Forms.Label
        Dim Id_UsuarioLabel As System.Windows.Forms.Label
        Dim CategoriaUsarioLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsUsuarios = New ModuloGestion.DsUsuarios()
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
        Me.UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreUsuaarioTextBox = New System.Windows.Forms.TextBox()
        Me.ConrasenaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaUsarioTextBox = New System.Windows.Forms.TextBox()
        Me.txtverificar = New System.Windows.Forms.TextBox()
        Me.btnacaptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsuariosTableAdapter = New ModuloGestion.DsUsuariosTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsUsuariosTableAdapters.TableAdapterManager()
        Me.DsCategoriasUsuarios = New ModuloGestion.DsCategoriasUsuarios()
        Me.CategoriaUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaUsuariosTableAdapter = New ModuloGestion.DsCategoriasUsuariosTableAdapters.CategoriaUsuariosTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        NiombreUsuaarioLabel = New System.Windows.Forms.Label()
        ConrasenaLabel = New System.Windows.Forms.Label()
        Id_UsuarioLabel = New System.Windows.Forms.Label()
        CategoriaUsarioLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCategoriasUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NiombreUsuaarioLabel
        '
        NiombreUsuaarioLabel.AutoSize = True
        NiombreUsuaarioLabel.Location = New System.Drawing.Point(45, 98)
        NiombreUsuaarioLabel.Name = "NiombreUsuaarioLabel"
        NiombreUsuaarioLabel.Size = New System.Drawing.Size(94, 13)
        NiombreUsuaarioLabel.TabIndex = 1
        NiombreUsuaarioLabel.Text = "Niombre Usuaario:"
        '
        'ConrasenaLabel
        '
        ConrasenaLabel.AutoSize = True
        ConrasenaLabel.Location = New System.Drawing.Point(45, 124)
        ConrasenaLabel.Name = "ConrasenaLabel"
        ConrasenaLabel.Size = New System.Drawing.Size(58, 13)
        ConrasenaLabel.TabIndex = 3
        ConrasenaLabel.Text = "Conraseña"
        '
        'Id_UsuarioLabel
        '
        Id_UsuarioLabel.AutoSize = True
        Id_UsuarioLabel.Location = New System.Drawing.Point(45, 72)
        Id_UsuarioLabel.Name = "Id_UsuarioLabel"
        Id_UsuarioLabel.Size = New System.Drawing.Size(58, 13)
        Id_UsuarioLabel.TabIndex = 5
        Id_UsuarioLabel.Text = "Id Usuario:"
        '
        'CategoriaUsarioLabel
        '
        CategoriaUsarioLabel.AutoSize = True
        CategoriaUsarioLabel.Location = New System.Drawing.Point(285, 72)
        CategoriaUsarioLabel.Name = "CategoriaUsarioLabel"
        CategoriaUsarioLabel.Size = New System.Drawing.Size(88, 13)
        CategoriaUsarioLabel.TabIndex = 7
        CategoriaUsarioLabel.Text = "Categoria Usario:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(45, 150)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(112, 13)
        Label1.TabIndex = 10
        Label1.Text = "Comprobar Conraseña"
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsuariosBindingNavigatorSaveItem})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(553, 25)
        Me.UsuariosBindingNavigator.TabIndex = 0
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
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
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DsUsuarios
        '
        'DsUsuarios
        '
        Me.DsUsuarios.DataSetName = "DsUsuarios"
        Me.DsUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'UsuariosBindingNavigatorSaveItem
        '
        Me.UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuariosBindingNavigatorSaveItem.Name = "UsuariosBindingNavigatorSaveItem"
        Me.UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreUsuaarioTextBox
        '
        Me.NombreUsuaarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "NiombreUsuaario", True))
        Me.NombreUsuaarioTextBox.Location = New System.Drawing.Point(163, 95)
        Me.NombreUsuaarioTextBox.Name = "NombreUsuaarioTextBox"
        Me.NombreUsuaarioTextBox.Size = New System.Drawing.Size(276, 20)
        Me.NombreUsuaarioTextBox.TabIndex = 2
        '
        'ConrasenaTextBox
        '
        Me.ConrasenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Conrasena", True))
        Me.ConrasenaTextBox.Location = New System.Drawing.Point(163, 121)
        Me.ConrasenaTextBox.Name = "ConrasenaTextBox"
        Me.ConrasenaTextBox.Size = New System.Drawing.Size(126, 20)
        Me.ConrasenaTextBox.TabIndex = 4
        Me.ConrasenaTextBox.UseSystemPasswordChar = True
        '
        'Id_UsuarioTextBox
        '
        Me.Id_UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Id_Usuario", True))
        Me.Id_UsuarioTextBox.Location = New System.Drawing.Point(163, 69)
        Me.Id_UsuarioTextBox.Name = "Id_UsuarioTextBox"
        Me.Id_UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_UsuarioTextBox.TabIndex = 6
        '
        'CategoriaUsarioTextBox
        '
        Me.CategoriaUsarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "CategoriaUsario", True))
        Me.CategoriaUsarioTextBox.Location = New System.Drawing.Point(389, 153)
        Me.CategoriaUsarioTextBox.Name = "CategoriaUsarioTextBox"
        Me.CategoriaUsarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaUsarioTextBox.TabIndex = 8
        '
        'txtverificar
        '
        Me.txtverificar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Conrasena", True))
        Me.txtverificar.Location = New System.Drawing.Point(163, 147)
        Me.txtverificar.Name = "txtverificar"
        Me.txtverificar.Size = New System.Drawing.Size(126, 20)
        Me.txtverificar.TabIndex = 9
        Me.txtverificar.UseSystemPasswordChar = True
        '
        'btnacaptar
        '
        Me.btnacaptar.Location = New System.Drawing.Point(163, 199)
        Me.btnacaptar.Name = "btnacaptar"
        Me.btnacaptar.Size = New System.Drawing.Size(75, 23)
        Me.btnacaptar.TabIndex = 11
        Me.btnacaptar.Text = "Aceptar"
        Me.btnacaptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(260, 199)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsUsuariosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'DsCategoriasUsuarios
        '
        Me.DsCategoriasUsuarios.DataSetName = "DsCategoriasUsuarios"
        Me.DsCategoriasUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaUsuariosBindingSource
        '
        Me.CategoriaUsuariosBindingSource.DataMember = "CategoriaUsuarios"
        Me.CategoriaUsuariosBindingSource.DataSource = Me.DsCategoriasUsuarios
        '
        'CategoriaUsuariosTableAdapter
        '
        Me.CategoriaUsuariosTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuariosBindingSource, "CategoriaUsario", True))
        Me.ComboBox1.DataSource = Me.CategoriaUsuariosBindingSource
        Me.ComboBox1.DisplayMember = "Descrpcion"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(379, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "IdCategoria"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 335)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnacaptar)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtverificar)
        Me.Controls.Add(NiombreUsuaarioLabel)
        Me.Controls.Add(Me.NombreUsuaarioTextBox)
        Me.Controls.Add(ConrasenaLabel)
        Me.Controls.Add(Me.ConrasenaTextBox)
        Me.Controls.Add(Id_UsuarioLabel)
        Me.Controls.Add(Me.Id_UsuarioTextBox)
        Me.Controls.Add(CategoriaUsarioLabel)
        Me.Controls.Add(Me.CategoriaUsarioTextBox)
        Me.Controls.Add(Me.UsuariosBindingNavigator)
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCategoriasUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsUsuarios As ModuloGestion.DsUsuarios
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ModuloGestion.DsUsuariosTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsUsuariosTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UsuariosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombreUsuaarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConrasenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaUsarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtverificar As System.Windows.Forms.TextBox
    Friend WithEvents btnacaptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DsCategoriasUsuarios As ModuloGestion.DsCategoriasUsuarios
    Friend WithEvents CategoriaUsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaUsuariosTableAdapter As ModuloGestion.DsCategoriasUsuariosTableAdapters.CategoriaUsuariosTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
