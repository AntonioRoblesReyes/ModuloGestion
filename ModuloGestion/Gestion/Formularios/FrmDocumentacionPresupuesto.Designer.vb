<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentacionPresupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentacionPresupuesto))
        Me.PresupuestoDocumentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PresupuestoDocumentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PresupuestoDocumentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LblCarpeta = New System.Windows.Forms.Label()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.LblRuta = New System.Windows.Forms.Label()
        Me.DescripcionDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoDocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPresupuestoDocumentos = New ModuloGestion.DsPresupuestoDocumentos()
        Me.PresupuestoDocumentosTableAdapter = New ModuloGestion.DsPresupuestoDocumentosTableAdapters.PresupuestoDocumentosTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPresupuestoDocumentosTableAdapters.TableAdapterManager()
        CType(Me.PresupuestoDocumentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PresupuestoDocumentosBindingNavigator.SuspendLayout()
        CType(Me.PresupuestoDocumentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPresupuestoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PresupuestoDocumentosBindingNavigator
        '
        Me.PresupuestoDocumentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PresupuestoDocumentosBindingNavigator.BindingSource = Me.PresupuestoDocumentosBindingSource
        Me.PresupuestoDocumentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PresupuestoDocumentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PresupuestoDocumentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PresupuestoDocumentosBindingNavigatorSaveItem})
        Me.PresupuestoDocumentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PresupuestoDocumentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PresupuestoDocumentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PresupuestoDocumentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PresupuestoDocumentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PresupuestoDocumentosBindingNavigator.Name = "PresupuestoDocumentosBindingNavigator"
        Me.PresupuestoDocumentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PresupuestoDocumentosBindingNavigator.Size = New System.Drawing.Size(583, 25)
        Me.PresupuestoDocumentosBindingNavigator.TabIndex = 0
        Me.PresupuestoDocumentosBindingNavigator.Text = "BindingNavigator1"
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
        'PresupuestoDocumentosBindingNavigatorSaveItem
        '
        Me.PresupuestoDocumentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PresupuestoDocumentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PresupuestoDocumentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PresupuestoDocumentosBindingNavigatorSaveItem.Name = "PresupuestoDocumentosBindingNavigatorSaveItem"
        Me.PresupuestoDocumentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PresupuestoDocumentosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PresupuestoDocumentosDataGridView
        '
        Me.PresupuestoDocumentosDataGridView.AllowUserToAddRows = False
        Me.PresupuestoDocumentosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PresupuestoDocumentosDataGridView.AutoGenerateColumns = False
        Me.PresupuestoDocumentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoDocumentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DescripcionDocumento, Me.archivo})
        Me.PresupuestoDocumentosDataGridView.DataSource = Me.PresupuestoDocumentosBindingSource
        Me.PresupuestoDocumentosDataGridView.Location = New System.Drawing.Point(12, 123)
        Me.PresupuestoDocumentosDataGridView.Name = "PresupuestoDocumentosDataGridView"
        Me.PresupuestoDocumentosDataGridView.Size = New System.Drawing.Size(546, 220)
        Me.PresupuestoDocumentosDataGridView.TabIndex = 1
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 78)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(124, 23)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnVer
        '
        Me.BtnVer.Location = New System.Drawing.Point(142, 78)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(124, 23)
        Me.BtnVer.TabIndex = 3
        Me.BtnVer.Text = "Ver"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LblCarpeta
        '
        Me.LblCarpeta.AutoSize = True
        Me.LblCarpeta.Location = New System.Drawing.Point(95, 45)
        Me.LblCarpeta.Name = "LblCarpeta"
        Me.LblCarpeta.Size = New System.Drawing.Size(39, 13)
        Me.LblCarpeta.TabIndex = 4
        Me.LblCarpeta.Text = "Label1"
        Me.LblCarpeta.Visible = False
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(285, 78)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(39, 13)
        Me.lblArchivo.TabIndex = 5
        Me.lblArchivo.Text = "Label1"
        Me.lblArchivo.Visible = False
        '
        'LblRuta
        '
        Me.LblRuta.AutoSize = True
        Me.LblRuta.Location = New System.Drawing.Point(12, 107)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(39, 13)
        Me.LblRuta.TabIndex = 6
        Me.LblRuta.Text = "Label1"
        Me.LblRuta.Visible = False
        '
        'DescripcionDocumento
        '
        Me.DescripcionDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDocumento.DataPropertyName = "DescripcionDocumento"
        Me.DescripcionDocumento.HeaderText = "Descripcion"
        Me.DescripcionDocumento.Name = "DescripcionDocumento"
        '
        'archivo
        '
        Me.archivo.DataPropertyName = "archivo"
        Me.archivo.HeaderText = "Archivo"
        Me.archivo.Name = "archivo"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdDocumento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdDocumento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'PresupuestoDocumentosBindingSource
        '
        Me.PresupuestoDocumentosBindingSource.DataMember = "PresupuestoDocumentos"
        Me.PresupuestoDocumentosBindingSource.DataSource = Me.DsPresupuestoDocumentos
        '
        'DsPresupuestoDocumentos
        '
        Me.DsPresupuestoDocumentos.DataSetName = "DsPresupuestoDocumentos"
        Me.DsPresupuestoDocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoDocumentosTableAdapter
        '
        Me.PresupuestoDocumentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoDocumentosTableAdapter = Me.PresupuestoDocumentosTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPresupuestoDocumentosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmDocumentacionPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 462)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.LblCarpeta)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.PresupuestoDocumentosDataGridView)
        Me.Controls.Add(Me.PresupuestoDocumentosBindingNavigator)
        Me.Name = "FrmDocumentacionPresupuesto"
        Me.Text = "FrmDocumentacionPresupuesto"
        CType(Me.PresupuestoDocumentosBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.PresupuestoDocumentosBindingNavigator.ResumeLayout(false)
        Me.PresupuestoDocumentosBindingNavigator.PerformLayout
        CType(Me.PresupuestoDocumentosDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PresupuestoDocumentosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DsPresupuestoDocumentos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DsPresupuestoDocumentos As ModuloGestion.DsPresupuestoDocumentos
    Friend WithEvents PresupuestoDocumentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PresupuestoDocumentosTableAdapter As ModuloGestion.DsPresupuestoDocumentosTableAdapters.PresupuestoDocumentosTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPresupuestoDocumentosTableAdapters.TableAdapterManager
    Friend WithEvents PresupuestoDocumentosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PresupuestoDocumentosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PresupuestoDocumentosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnVer As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblCarpeta As System.Windows.Forms.Label
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents LblRuta As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents archivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
