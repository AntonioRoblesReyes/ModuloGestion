<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerPinturaTipo
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
        Dim IdPinturaTipoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim DesperdicioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerPinturaTipo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdPinturaTipo = New System.Windows.Forms.TextBox()
        Me.PinturaTipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TxtDesperdicio = New System.Windows.Forms.TextBox()
      
        Me.PinturaTipoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PinturaTipoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnGaurdarYCerrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        IdPinturaTipoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        DesperdicioLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PinturaTipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.PinturaTipoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PinturaTipoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdPinturaTipoLabel
        '
        IdPinturaTipoLabel.AutoSize = True
        IdPinturaTipoLabel.Location = New System.Drawing.Point(30, 22)
        IdPinturaTipoLabel.Name = "IdPinturaTipoLabel"
        IdPinturaTipoLabel.Size = New System.Drawing.Size(79, 13)
        IdPinturaTipoLabel.TabIndex = 0
        IdPinturaTipoLabel.Text = "Id Pintura Tipo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(30, 52)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripcion:"
        '
        'DesperdicioLabel
        '
        DesperdicioLabel.AutoSize = True
        DesperdicioLabel.Location = New System.Drawing.Point(221, 22)
        DesperdicioLabel.Name = "DesperdicioLabel"
        DesperdicioLabel.Size = New System.Drawing.Size(66, 13)
        DesperdicioLabel.TabIndex = 4
        DesperdicioLabel.Text = "Desperdicio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(IdPinturaTipoLabel)
        Me.GroupBox1.Controls.Add(Me.TxtIdPinturaTipo)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(DesperdicioLabel)
        Me.GroupBox1.Controls.Add(Me.TxtDesperdicio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TxtIdPinturaTipo
        '
        Me.TxtIdPinturaTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PinturaTipoBindingSource, "IdPinturaTipo", True))
        Me.TxtIdPinturaTipo.Location = New System.Drawing.Point(115, 19)
        Me.TxtIdPinturaTipo.Name = "TxtIdPinturaTipo"
        Me.TxtIdPinturaTipo.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdPinturaTipo.TabIndex = 1
        '
       
       

        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PinturaTipoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(115, 49)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(272, 106)
        Me.DescripcionTextBox.TabIndex = 3
        '
        'TxtDesperdicio
        '
        Me.TxtDesperdicio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PinturaTipoBindingSource, "Desperdicio", True))
        Me.TxtDesperdicio.Location = New System.Drawing.Point(306, 19)
        Me.TxtDesperdicio.Name = "TxtDesperdicio"
        Me.TxtDesperdicio.Size = New System.Drawing.Size(81, 20)
        Me.TxtDesperdicio.TabIndex = 5
        '
  
        '
     
        'PinturaTipoBindingNavigator
        '
        Me.PinturaTipoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PinturaTipoBindingNavigator.BindingSource = Me.PinturaTipoBindingSource
        Me.PinturaTipoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PinturaTipoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PinturaTipoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PinturaTipoBindingNavigatorSaveItem})
        Me.PinturaTipoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PinturaTipoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PinturaTipoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PinturaTipoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PinturaTipoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PinturaTipoBindingNavigator.Name = "PinturaTipoBindingNavigator"
        Me.PinturaTipoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PinturaTipoBindingNavigator.Size = New System.Drawing.Size(458, 25)
        Me.PinturaTipoBindingNavigator.TabIndex = 1
        Me.PinturaTipoBindingNavigator.Text = "BindingNavigator1"
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
        'PinturaTipoBindingNavigatorSaveItem
        '
        Me.PinturaTipoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PinturaTipoBindingNavigatorSaveItem.Image = CType(resources.GetObject("PinturaTipoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PinturaTipoBindingNavigatorSaveItem.Name = "PinturaTipoBindingNavigatorSaveItem"
        Me.PinturaTipoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PinturaTipoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BtnGaurdarYCerrar
        '
        Me.BtnGaurdarYCerrar.Location = New System.Drawing.Point(128, 28)
        Me.BtnGaurdarYCerrar.Name = "BtnGaurdarYCerrar"
        Me.BtnGaurdarYCerrar.Size = New System.Drawing.Size(99, 23)
        Me.BtnGaurdarYCerrar.TabIndex = 2
        Me.BtnGaurdarYCerrar.Text = "Gaurdar Y Cerrar"
        Me.BtnGaurdarYCerrar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(236, 28)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(99, 23)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmVerPinturaTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 287)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGaurdarYCerrar)
        Me.Controls.Add(Me.PinturaTipoBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmVerPinturaTipo"
        Me.Text = "FrmVerPinturaTipo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PinturaTipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.PinturaTipoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PinturaTipoBindingNavigator.ResumeLayout(False)
        Me.PinturaTipoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

    Friend WithEvents PinturaTipoBindingSource As System.Windows.Forms.BindingSource
    
    Friend WithEvents PinturaTipoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PinturaTipoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtIdPinturaTipo As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesperdicio As System.Windows.Forms.TextBox
    Friend WithEvents BtnGaurdarYCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
