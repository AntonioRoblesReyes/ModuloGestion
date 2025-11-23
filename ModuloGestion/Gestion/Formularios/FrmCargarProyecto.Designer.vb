<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargarProyecto
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProyectoPendienteAsignarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectoPendienteAsignarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProyectoPendienteAsignar = New ModuloGestion.DsProyectoPendienteAsignar()
        Me.LblInformacion = New System.Windows.Forms.Label()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.DsProyectoPendienteAsignarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoPendienteAsignarTableAdapter = New ModuloGestion.DsProyectoPendienteAsignarTableAdapters.ProyectoPendienteAsignarTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsProyectoPendienteAsignarTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProyectoPendienteAsignarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoPendienteAsignarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectoPendienteAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyectoPendienteAsignarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Controls.Add(Me.ProyectoPendienteAsignarDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 421)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proyectos disponibles"
        '
        'ProyectoPendienteAsignarDataGridView
        '
        Me.ProyectoPendienteAsignarDataGridView.AutoGenerateColumns = False
        Me.ProyectoPendienteAsignarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectoPendienteAsignarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.Codigo, Me.Id_Empresa})
        Me.ProyectoPendienteAsignarDataGridView.DataSource = Me.ProyectoPendienteAsignarBindingSource
        Me.ProyectoPendienteAsignarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProyectoPendienteAsignarDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.ProyectoPendienteAsignarDataGridView.Name = "ProyectoPendienteAsignarDataGridView"
        Me.ProyectoPendienteAsignarDataGridView.Size = New System.Drawing.Size(1032, 402)
        Me.ProyectoPendienteAsignarDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Id_Proyecto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id Proyecto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nombre_Proyecto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Id_Empresa
        '
        Me.Id_Empresa.DataPropertyName = "Id_Empresa"
        Me.Id_Empresa.HeaderText = "Empresa"
        Me.Id_Empresa.Name = "Id_Empresa"
        '
        'ProyectoPendienteAsignarBindingSource
        '
        Me.ProyectoPendienteAsignarBindingSource.DataMember = "ProyectoPendienteAsignar"
        Me.ProyectoPendienteAsignarBindingSource.DataSource = Me.DsProyectoPendienteAsignar
        '
        'DsProyectoPendienteAsignar
        '
        Me.DsProyectoPendienteAsignar.DataSetName = "DsProyectoPendienteAsignar"
        Me.DsProyectoPendienteAsignar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblInformacion
        '
        Me.LblInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblInformacion.Location = New System.Drawing.Point(12, 9)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(720, 45)
        Me.LblInformacion.TabIndex = 1
        Me.LblInformacion.Text = "Seleccione un proyecto"
        Me.LblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblInformacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Location = New System.Drawing.Point(750, 17)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(120, 30)
        Me.CmdAceptar.TabIndex = 2
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = True
        Me.CmdAceptar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Location = New System.Drawing.Point(880, 17)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(120, 30)
        Me.CmdCancelar.TabIndex = 3
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = True
        Me.CmdCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        '
        'ProyectoPendienteAsignarTableAdapter
        '
        Me.ProyectoPendienteAsignarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsProyectoPendienteAsignarTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmCargarProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 481)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.LblInformacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCargarProyecto"
        Me.Text = "Cargar Proyecto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ProyectoPendienteAsignarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoPendienteAsignarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectoPendienteAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyectoPendienteAsignarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblInformacion As System.Windows.Forms.Label
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents DescuentoMontajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsProyectoPendienteAsignarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsProyectoPendienteAsignar As ModuloGestion.DsProyectoPendienteAsignar
    Friend WithEvents ProyectoPendienteAsignarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyectoPendienteAsignarTableAdapter As ModuloGestion.DsProyectoPendienteAsignarTableAdapters.ProyectoPendienteAsignarTableAdapter
    Friend WithEvents TableAdapterManager As ModuloGestion.DsProyectoPendienteAsignarTableAdapters.TableAdapterManager
    Friend WithEvents ProyectoPendienteAsignarDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
