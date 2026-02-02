<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPinturaComponentes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PinturaComponentesDataGridView = New System.Windows.Forms.DataGridView()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.PinturaComponentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturaComponentes = New ModuloGestion.DsPinturaComponentes()
        Me.PinturaComponentesTableAdapter = New ModuloGestion.DsPinturaComponentesTableAdapters.PinturaComponentesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPinturaComponentesTableAdapters.TableAdapterManager()
        Me.BtnAñadirComponente = New System.Windows.Forms.Button()
        Me.CmbIdFamilia = New System.Windows.Forms.ComboBox()
        Me.PinturaFamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPinturasFamilia = New ModuloGestion.DsPinturasFamilia()
        Me.PinturaFamiliasTableAdapter = New ModuloGestion.DsPinturasFamiliaTableAdapters.PinturaFamiliasTableAdapter()
        Me.BtnNuevoComponete = New System.Windows.Forms.Button()
        Me.SiguientePinturaComponenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.BtnFichaTecnica = New System.Windows.Forms.Button()
        Me.IdPinturaComponenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedidaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FichaTecnica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PinturaComponentesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturaComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinturaFamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPinturasFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiguientePinturaComponenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PinturaComponentesDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 282)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PinturaComponentesDataGridView
        '
        Me.PinturaComponentesDataGridView.AllowUserToAddRows = False
        Me.PinturaComponentesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PinturaComponentesDataGridView.AutoGenerateColumns = False
        Me.PinturaComponentesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PinturaComponentesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPinturaComponenteDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.MedidaCompraDataGridViewTextBoxColumn, Me.FichaTecnica})
        Me.PinturaComponentesDataGridView.DataSource = Me.PinturaComponentesBindingSource
        Me.PinturaComponentesDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.PinturaComponentesDataGridView.Name = "PinturaComponentesDataGridView"
        Me.PinturaComponentesDataGridView.Size = New System.Drawing.Size(749, 239)
        Me.PinturaComponentesDataGridView.TabIndex = 0
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaComponentesBindingSource
        '
        Me.PinturaComponentesBindingSource.DataMember = "PinturaComponentes"
        Me.PinturaComponentesBindingSource.DataSource = Me.DsPinturaComponentes
        '
        'DsPinturaComponentes
        '
        Me.DsPinturaComponentes.DataSetName = "DsPinturaComponentes"
        Me.DsPinturaComponentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaComponentesTableAdapter
        '
        Me.PinturaComponentesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PinturaComponentesTableAdapter = Me.PinturaComponentesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPinturaComponentesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnAñadirComponente
        '
        Me.BtnAñadirComponente.Location = New System.Drawing.Point(617, 60)
        Me.BtnAñadirComponente.Name = "BtnAñadirComponente"
        Me.BtnAñadirComponente.Size = New System.Drawing.Size(146, 23)
        Me.BtnAñadirComponente.TabIndex = 1
        Me.BtnAñadirComponente.Text = "Añadir Componente"
        Me.BtnAñadirComponente.UseVisualStyleBackColor = True
        '
        'CmbIdFamilia
        '
        Me.CmbIdFamilia.DataSource = Me.PinturaFamiliasBindingSource
        Me.CmbIdFamilia.DisplayMember = "Descripcion"
        Me.CmbIdFamilia.FormattingEnabled = True
        Me.CmbIdFamilia.Location = New System.Drawing.Point(18, 60)
        Me.CmbIdFamilia.Name = "CmbIdFamilia"
        Me.CmbIdFamilia.Size = New System.Drawing.Size(193, 21)
        Me.CmbIdFamilia.TabIndex = 4
        Me.CmbIdFamilia.ValueMember = "IdPinturaFamilia"
        '
        'PinturaFamiliasBindingSource
        '
        Me.PinturaFamiliasBindingSource.DataMember = "PinturaFamilias"
        Me.PinturaFamiliasBindingSource.DataSource = Me.DsPinturasFamilia
        '
        'DsPinturasFamilia
        '
        Me.DsPinturasFamilia.DataSetName = "DsPinturasFamilia"
        Me.DsPinturasFamilia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinturaFamiliasTableAdapter
        '
        Me.PinturaFamiliasTableAdapter.ClearBeforeFill = True
        '
        'BtnNuevoComponete
        '
        Me.BtnNuevoComponete.Location = New System.Drawing.Point(18, 30)
        Me.BtnNuevoComponete.Name = "BtnNuevoComponete"
        Me.BtnNuevoComponete.Size = New System.Drawing.Size(117, 23)
        Me.BtnNuevoComponete.TabIndex = 5
        Me.BtnNuevoComponete.Text = "Nuevo Componete"
        Me.BtnNuevoComponete.UseVisualStyleBackColor = True
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'BtnFichaTecnica
        '
        Me.BtnFichaTecnica.Location = New System.Drawing.Point(452, 60)
        Me.BtnFichaTecnica.Name = "BtnFichaTecnica"
        Me.BtnFichaTecnica.Size = New System.Drawing.Size(146, 23)
        Me.BtnFichaTecnica.TabIndex = 6
        Me.BtnFichaTecnica.Text = "Ficha Tecnica"
        Me.BtnFichaTecnica.UseVisualStyleBackColor = True
        '
        'IdPinturaComponenteDataGridViewTextBoxColumn
        '
        Me.IdPinturaComponenteDataGridViewTextBoxColumn.DataPropertyName = "IdPinturaComponente"
        Me.IdPinturaComponenteDataGridViewTextBoxColumn.HeaderText = "Id Componente"
        Me.IdPinturaComponenteDataGridViewTextBoxColumn.Name = "IdPinturaComponenteDataGridViewTextBoxColumn"
        Me.IdPinturaComponenteDataGridViewTextBoxColumn.Width = 110
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'MedidaCompraDataGridViewTextBoxColumn
        '
        Me.MedidaCompraDataGridViewTextBoxColumn.DataPropertyName = "MedidaCompra"
        Me.MedidaCompraDataGridViewTextBoxColumn.DataSource = Me.MedidasCompraBindingSource
        Me.MedidaCompraDataGridViewTextBoxColumn.DisplayMember = "Descripcion_Medida"
        Me.MedidaCompraDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MedidaCompraDataGridViewTextBoxColumn.HeaderText = "Medida Compra"
        Me.MedidaCompraDataGridViewTextBoxColumn.Name = "MedidaCompraDataGridViewTextBoxColumn"
        Me.MedidaCompraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedidaCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MedidaCompraDataGridViewTextBoxColumn.ValueMember = "Id_Medida"
        Me.MedidaCompraDataGridViewTextBoxColumn.Width = 125
        '
        'FichaTecnica
        '
        Me.FichaTecnica.DataPropertyName = "FichaTecnica"
        Me.FichaTecnica.HeaderText = "FichaTecnica"
        Me.FichaTecnica.Name = "FichaTecnica"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "\\PCShernia\Users\Public\FichaTecnica"
        '
        'FrmPinturaComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 371)
        Me.Controls.Add(Me.BtnFichaTecnica)
        Me.Controls.Add(Me.BtnNuevoComponete)
        Me.Controls.Add(Me.CmbIdFamilia)
        Me.Controls.Add(Me.BtnAñadirComponente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPinturaComponentes"
        Me.Text = "FrmPinturaComponetes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PinturaComponentesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaComponentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturaComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinturaFamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPinturasFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiguientePinturaComponenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DsPinturaComponentes As ModuloGestion.DsPinturaComponentes
    Friend WithEvents PinturaComponentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaComponentesTableAdapter As ModuloGestion.DsPinturaComponentesTableAdapters.PinturaComponentesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsPinturaComponentesTableAdapters.TableAdapterManager
    Friend WithEvents PinturaComponentesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAñadirComponente As System.Windows.Forms.Button
    Friend WithEvents CmbIdFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents DsPinturasFamilia As ModuloGestion.DsPinturasFamilia
    Friend WithEvents PinturaFamiliasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PinturaFamiliasTableAdapter As ModuloGestion.DsPinturasFamiliaTableAdapters.PinturaFamiliasTableAdapter
    Friend WithEvents BtnNuevoComponete As System.Windows.Forms.Button

    Friend WithEvents SiguientePinturaComponenteBindingSource As System.Windows.Forms.BindingSource
  
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents IdPinturaComponenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedidaCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FichaTecnica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnFichaTecnica As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
