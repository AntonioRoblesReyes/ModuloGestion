<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescripciones
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsDescripciones = New ModuloGestion.DsDescripciones()
        Me.DescripcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionesTableAdapter = New ModuloGestion.DsDescripcionesTableAdapters.DescripcionesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager()
        Me.DescripcionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsDescripcionesdetalle = New ModuloGestion.DsDescripcionesdetalle()
        Me.DescripcionesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionesDetalleTableAdapter = New ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter()
        Me.TableAdapterManager1 = New ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager()
        Me.BtnNuevoGrupo = New System.Windows.Forms.Button()
        Me.DescripcionesDetalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.SiguienteDescripcionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.SiguienteDescripcionDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
       
        Me.BtnNuevoDetalle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DsDescripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionesDetalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.SiguienteDescripcionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.SiguienteDescripcionDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsDescripciones
        '
        Me.DsDescripciones.DataSetName = "DsDescripciones"
        Me.DsDescripciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionesBindingSource
        '
        Me.DescripcionesBindingSource.DataMember = "Descripciones"
        Me.DescripcionesBindingSource.DataSource = Me.DsDescripciones
        '
        'DescripcionesTableAdapter
        '
        Me.DescripcionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DescripcionesTableAdapter = Me.DescripcionesTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionesDataGridView
        '
        Me.DescripcionesDataGridView.AllowUserToAddRows = False
        Me.DescripcionesDataGridView.AutoGenerateColumns = False
        Me.DescripcionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DescripcionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DescripcionesDataGridView.DataSource = Me.DescripcionesBindingSource
        Me.DescripcionesDataGridView.Location = New System.Drawing.Point(30, 67)
        Me.DescripcionesDataGridView.Name = "DescripcionesDataGridView"
        Me.DescripcionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DescripcionesDataGridView.Size = New System.Drawing.Size(440, 220)
        Me.DescripcionesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_descripcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Descripcion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        DataGridViewCellStyle21.Format = ">"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DsDescripcionesdetalle
        '
        Me.DsDescripcionesdetalle.DataSetName = "DsDescripcionesdetalle"
        Me.DsDescripcionesdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionesDetalleBindingSource
        '
        Me.DescripcionesDetalleBindingSource.DataMember = "DescripcionesDetalle"
        Me.DescripcionesDetalleBindingSource.DataSource = Me.DsDescripcionesdetalle
        '
        'DescripcionesDetalleTableAdapter
        '
        Me.DescripcionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.DescripcionesDetalleTableAdapter = Me.DescripcionesDetalleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnNuevoGrupo
        '
        Me.BtnNuevoGrupo.Location = New System.Drawing.Point(30, 38)
        Me.BtnNuevoGrupo.Name = "BtnNuevoGrupo"
        Me.BtnNuevoGrupo.Size = New System.Drawing.Size(118, 23)
        Me.BtnNuevoGrupo.TabIndex = 3
        Me.BtnNuevoGrupo.Text = "Nuevo Grupo"
        Me.BtnNuevoGrupo.UseVisualStyleBackColor = True
        '
        'DescripcionesDetalleDataGridView
        '
        Me.DescripcionesDetalleDataGridView.AllowUserToAddRows = False
        Me.DescripcionesDetalleDataGridView.AutoGenerateColumns = False
        Me.DescripcionesDetalleDataGridView.ColumnHeadersHeight = 21
        Me.DescripcionesDetalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DescripcionesDetalleDataGridView.DataSource = Me.DescripcionesDetalleBindingSource
        Me.DescripcionesDetalleDataGridView.Location = New System.Drawing.Point(548, 67)
        Me.DescripcionesDetalleDataGridView.Name = "DescripcionesDetalleDataGridView"
        Me.DescripcionesDetalleDataGridView.Size = New System.Drawing.Size(657, 343)
        Me.DescripcionesDetalleDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_descripcion_Detalle"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id Detalle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
        DataGridViewCellStyle22.Format = ">"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pintura Caras"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle23.Format = "N0"
        DataGridViewCellStyle23.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn5.HeaderText = "Caras"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pintura Canto"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle24.Format = "n0"
        DataGridViewCellStyle24.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn6.HeaderText = " Cantos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pintura cabeza"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle25.Format = "N0"
        DataGridViewCellStyle25.NullValue = "0"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cabeza"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Id_descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Id_descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
      
       
        
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Siguientedescripcion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Siguientedescripcion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
      
        'BtnNuevoDetalle
        '
        Me.BtnNuevoDetalle.Location = New System.Drawing.Point(548, 38)
        Me.BtnNuevoDetalle.Name = "BtnNuevoDetalle"
        Me.BtnNuevoDetalle.Size = New System.Drawing.Size(118, 23)
        Me.BtnNuevoDetalle.TabIndex = 4
        Me.BtnNuevoDetalle.Text = "Nuevo Detalle"
        Me.BtnNuevoDetalle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(1060, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pimtado en:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDescripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNuevoDetalle)
        Me.Controls.Add(Me.BtnNuevoGrupo)
        Me.Controls.Add(Me.DescripcionesDetalleDataGridView)
        Me.Controls.Add(Me.DescripcionesDataGridView)
        Me.Name = "FrmDescripciones"
        Me.Text = "FrmDescripciones"
        CType(Me.DsDescripciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDescripcionesdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionesDetalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.SiguienteDescripcionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.SiguienteDescripcionDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsDescripciones As ModuloGestion.DsDescripciones
    Friend WithEvents DescripcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionesTableAdapter As ModuloGestion.DsDescripcionesTableAdapters.DescripcionesTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsDescripcionesTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DsDescripcionesdetalle As ModuloGestion.DsDescripcionesdetalle
    Friend WithEvents DescripcionesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionesDetalleTableAdapter As ModuloGestion.DsDescripcionesdetalleTableAdapters.DescripcionesDetalleTableAdapter
    Friend WithEvents TableAdapterManager1 As ModuloGestion.DsDescripcionesdetalleTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnNuevoGrupo As System.Windows.Forms.Button
    Friend WithEvents DescripcionesDetalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents SiguienteDescripcionBindingSource As System.Windows.Forms.BindingSource
   
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn

    Friend WithEvents SiguienteDescripcionDetalleBindingSource As System.Windows.Forms.BindingSource
  
    Friend WithEvents BtnNuevoDetalle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
