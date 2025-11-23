<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubArticulosCosumo
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblIdSubarticulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdCerrar = New System.Windows.Forms.Button()
        Me.SubArticuloConsumoTotalDataGridView = New System.Windows.Forms.DataGridView()
        Me.Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desperdicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ElementosM2PinturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.TotalM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMaterialDetalle = New ModuloGestion.DsMaterialDetalle()
        Me.MaterilaesDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterilaesDetalleTableAdapter = New ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter()
        Me.DsMedidasCompra = New ModuloGestion.DsMedidasCompra()
        Me.MedidasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedidasCompraTableAdapter = New ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsConsumoMaterialSubarticulosTableAdapters.TableAdapterManager()
        Me.ConsumoMatereialSubArticulosTableAdapter = New ModuloGestion.DsConsumoMaterialSubarticulosTableAdapters.ConsumoMatereialSubArticulosTableAdapter()
        Me.ConsumoMatereialSubArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsumoMaterialSubarticulos = New ModuloGestion.DsConsumoMaterialSubarticulos()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoMatereialSubArticulosDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.SubArticuloConsumoTotalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElementosM2PinturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoMatereialSubArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsumoMaterialSubarticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumoMatereialSubArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIdSubarticulo
        '
        Me.LblIdSubarticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIdSubarticulo.Location = New System.Drawing.Point(57, 71)
        Me.LblIdSubarticulo.Name = "LblIdSubarticulo"
        Me.LblIdSubarticulo.Size = New System.Drawing.Size(110, 20)
        Me.LblIdSubarticulo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(57, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id SubArticulo"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(185, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(271, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 63)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'CmdCerrar
        '
        Me.CmdCerrar.Location = New System.Drawing.Point(707, 65)
        Me.CmdCerrar.Name = "CmdCerrar"
        Me.CmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.CmdCerrar.TabIndex = 6
        Me.CmdCerrar.Text = "Cerrar"
        Me.CmdCerrar.UseVisualStyleBackColor = True
        '
        'SubArticuloConsumoTotalDataGridView
        '
        Me.SubArticuloConsumoTotalDataGridView.AllowUserToAddRows = False
        Me.SubArticuloConsumoTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubArticuloConsumoTotalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Consumo, Me.Desperdicio, Me.Total, Me.DataGridViewTextBoxColumn16})
        Me.SubArticuloConsumoTotalDataGridView.Location = New System.Drawing.Point(30, 350)
        Me.SubArticuloConsumoTotalDataGridView.Name = "SubArticuloConsumoTotalDataGridView"
        Me.SubArticuloConsumoTotalDataGridView.ReadOnly = True
        Me.SubArticuloConsumoTotalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SubArticuloConsumoTotalDataGridView.Size = New System.Drawing.Size(724, 256)
        Me.SubArticuloConsumoTotalDataGridView.TabIndex = 6
        '
        'Consumo
        '
        Me.Consumo.DataPropertyName = "Consumo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Consumo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Consumo.HeaderText = "Consumo"
        Me.Consumo.Name = "Consumo"
        Me.Consumo.ReadOnly = True
        '
        'Desperdicio
        '
        Me.Desperdicio.DataPropertyName = "Desperdicio"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "n2"
        Me.Desperdicio.DefaultCellStyle = DataGridViewCellStyle6
        Me.Desperdicio.HeaderText = "Desperdicio"
        Me.Desperdicio.Name = "Desperdicio"
        Me.Desperdicio.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "n2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle7
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Id_Medida"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn16.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn16.HeaderText = "Medida Compra"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.Width = 200
        '
        'ElementosM2PinturaDataGridView
        '
        Me.ElementosM2PinturaDataGridView.AllowUserToAddRows = False
        Me.ElementosM2PinturaDataGridView.AllowUserToDeleteRows = False
        Me.ElementosM2PinturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ElementosM2PinturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TotalM2})
        Me.ElementosM2PinturaDataGridView.Location = New System.Drawing.Point(768, 350)
        Me.ElementosM2PinturaDataGridView.Name = "ElementosM2PinturaDataGridView"
        Me.ElementosM2PinturaDataGridView.ReadOnly = True
        Me.ElementosM2PinturaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ElementosM2PinturaDataGridView.Size = New System.Drawing.Size(349, 256)
        Me.ElementosM2PinturaDataGridView.TabIndex = 7
        '
        'TotalM2
        '
        Me.TotalM2.DataPropertyName = "TotalM2"
        Me.TotalM2.HeaderText = "TotalM2"
        Me.TotalM2.Name = "TotalM2"
        Me.TotalM2.ReadOnly = True
        '
        'DsMaterialDetalle
        '
        Me.DsMaterialDetalle.DataSetName = "DsMaterialDetalle"
        Me.DsMaterialDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterilaesDetalleBindingSource
        '
        Me.MaterilaesDetalleBindingSource.DataMember = "MaterilaesDetalle"
        Me.MaterilaesDetalleBindingSource.DataSource = Me.DsMaterialDetalle
        '
        'MaterilaesDetalleTableAdapter
        '
        Me.MaterilaesDetalleTableAdapter.ClearBeforeFill = True
        '
        'DsMedidasCompra
        '
        Me.DsMedidasCompra.DataSetName = "DsMedidasCompra"
        Me.DsMedidasCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedidasCompraBindingSource
        '
        Me.MedidasCompraBindingSource.DataMember = "MedidasCompra"
        Me.MedidasCompraBindingSource.DataSource = Me.DsMedidasCompra
        '
        'MedidasCompraTableAdapter
        '
        Me.MedidasCompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsConsumoMaterialSubarticulosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConsumoMatereialSubArticulosTableAdapter
        '
        Me.ConsumoMatereialSubArticulosTableAdapter.ClearBeforeFill = True
        '
        'ConsumoMatereialSubArticulosBindingSource
        '
        Me.ConsumoMatereialSubArticulosBindingSource.DataMember = "ConsumoMatereialSubArticulos"
        Me.ConsumoMatereialSubArticulosBindingSource.DataSource = Me.DsConsumoMaterialSubarticulos
        '
        'DsConsumoMaterialSubarticulos
        '
        Me.DsConsumoMaterialSubarticulos.DataSetName = "DsConsumoMaterialSubarticulos"
        Me.DsConsumoMaterialSubarticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Estado_Presupuesto"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Id_Empresa"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Id_Empresa"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Id_Medida"
        Me.DataGridViewTextBoxColumn24.DataSource = Me.MedidasCompraBindingSource
        Me.DataGridViewTextBoxColumn24.DisplayMember = "Descripcion_Medida"
        Me.DataGridViewTextBoxColumn24.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn24.HeaderText = "Medida Compra"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn24.ValueMember = "Id_Medida"
        Me.DataGridViewTextBoxColumn24.Width = 200
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TotalCosto"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Total Costo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PrecioCompra"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Precio Compra"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TotalCompra"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Total Compra"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TotalDesperdicio"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Total Desperdicio"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DesperdicioMaterial"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Desperdicio Material"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ConsumoTotal"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Consumo Total"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn17.DataSource = Me.MaterilaesDetalleBindingSource
        Me.DataGridViewTextBoxColumn17.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn17.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn17.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn17.ValueMember = "Id_Material_Detalle"
        Me.DataGridViewTextBoxColumn17.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_Sub_Articulo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdArticulo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdArticulo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdDetalle_Presupuesto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_Presupuesto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'ConsumoMatereialSubArticulosDataGridView
        '
        Me.ConsumoMatereialSubArticulosDataGridView.AutoGenerateColumns = False
        Me.ConsumoMatereialSubArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsumoMatereialSubArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.ConsumoMatereialSubArticulosDataGridView.DataSource = Me.ConsumoMatereialSubArticulosBindingSource
        Me.ConsumoMatereialSubArticulosDataGridView.Location = New System.Drawing.Point(50, 124)
        Me.ConsumoMatereialSubArticulosDataGridView.Name = "ConsumoMatereialSubArticulosDataGridView"
        Me.ConsumoMatereialSubArticulosDataGridView.Size = New System.Drawing.Size(1043, 220)
        Me.ConsumoMatereialSubArticulosDataGridView.TabIndex = 7
        '
        'FrmSubArticulosCosumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.ConsumoMatereialSubArticulosDataGridView)
        Me.Controls.Add(Me.ElementosM2PinturaDataGridView)
        Me.Controls.Add(Me.SubArticuloConsumoTotalDataGridView)
        Me.Controls.Add(Me.CmdCerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblIdSubarticulo)
        Me.Name = "FrmSubArticulosCosumo"
        Me.Text = "FrmSubArticulosConsumo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SubArticuloConsumoTotalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElementosM2PinturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterilaesDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMedidasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedidasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoMatereialSubArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsumoMaterialSubarticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumoMatereialSubArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub


    Friend WithEvents LblIdSubarticulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdCerrar As System.Windows.Forms.Button



    Friend WithEvents SubArticuloConsumoTotalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn


    Friend WithEvents ElementosM2PinturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TotalM2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Consumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desperdicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DsMaterialDetalle As ModuloGestion.DsMaterialDetalle
    Friend WithEvents MaterilaesDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaterilaesDetalleTableAdapter As ModuloGestion.DsMaterialDetalleTableAdapters.MaterilaesDetalleTableAdapter
    Friend WithEvents DsMedidasCompra As ModuloGestion.DsMedidasCompra
    Friend WithEvents MedidasCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedidasCompraTableAdapter As ModuloGestion.DsMedidasCompraTableAdapters.MedidasCompraTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsConsumoMaterialSubarticulosTableAdapters.TableAdapterManager
    Friend WithEvents ConsumoMatereialSubArticulosTableAdapter As ModuloGestion.DsConsumoMaterialSubarticulosTableAdapters.ConsumoMatereialSubArticulosTableAdapter
    Friend WithEvents ConsumoMatereialSubArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsConsumoMaterialSubarticulos As ModuloGestion.DsConsumoMaterialSubarticulos
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumoMatereialSubArticulosDataGridView As System.Windows.Forms.DataGridView
End Class
