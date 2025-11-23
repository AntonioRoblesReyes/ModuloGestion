<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioProyecto
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
        Dim Id_proyecto_PresupuestosLabel As System.Windows.Forms.Label
        Dim Id_FiscalLabel As System.Windows.Forms.Label
        Dim Id_PresupuestoLabel As System.Windows.Forms.Label
        Me.DsPresupuestos = New ModuloGestion.DsPresupuestos()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresupuestoTableAdapter = New ModuloGestion.DsPresupuestosTableAdapters.PresupuestoTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager()
        Me.Id_proyecto_PresupuestosTextBox = New System.Windows.Forms.TextBox()
        Me.Id_FiscalTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PresupuestoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Id_proyecto_PresupuestosLabel = New System.Windows.Forms.Label()
        Id_FiscalLabel = New System.Windows.Forms.Label()
        Id_PresupuestoLabel = New System.Windows.Forms.Label()
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_proyecto_PresupuestosLabel
        '
        Id_proyecto_PresupuestosLabel.AutoSize = True
        Id_proyecto_PresupuestosLabel.Location = New System.Drawing.Point(98, 98)
        Id_proyecto_PresupuestosLabel.Name = "Id_proyecto_PresupuestosLabel"
        Id_proyecto_PresupuestosLabel.Size = New System.Drawing.Size(63, 13)
        Id_proyecto_PresupuestosLabel.TabIndex = 1
        Id_proyecto_PresupuestosLabel.Text = "Id proyecto "
        '
        'Id_FiscalLabel
        '
        Id_FiscalLabel.AutoSize = True
        Id_FiscalLabel.Location = New System.Drawing.Point(103, 72)
        Id_FiscalLabel.Name = "Id_FiscalLabel"
        Id_FiscalLabel.Size = New System.Drawing.Size(49, 13)
        Id_FiscalLabel.TabIndex = 3
        Id_FiscalLabel.Text = "Id Fiscal:"
        '
        'Id_PresupuestoLabel
        '
        Id_PresupuestoLabel.AutoSize = True
        Id_PresupuestoLabel.Location = New System.Drawing.Point(80, 37)
        Id_PresupuestoLabel.Name = "Id_PresupuestoLabel"
        Id_PresupuestoLabel.Size = New System.Drawing.Size(81, 13)
        Id_PresupuestoLabel.TabIndex = 4
        Id_PresupuestoLabel.Text = "Id Presupuesto:"
        '
        'DsPresupuestos
        '
        Me.DsPresupuestos.DataSetName = "DsPresupuestos"
        Me.DsPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataMember = "Presupuesto"
        Me.PresupuestoBindingSource.DataSource = Me.DsPresupuestos
        '
        'PresupuestoTableAdapter
        '
        Me.PresupuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PresupuestoTableAdapter = Me.PresupuestoTableAdapter
        Me.TableAdapterManager.UpdateOrder = ModuloGestion.DsPresupuestosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_proyecto_PresupuestosTextBox
        '
        Me.Id_proyecto_PresupuestosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Id_proyecto_Presupuestos", True))
        Me.Id_proyecto_PresupuestosTextBox.Location = New System.Drawing.Point(167, 95)
        Me.Id_proyecto_PresupuestosTextBox.Name = "Id_proyecto_PresupuestosTextBox"
        Me.Id_proyecto_PresupuestosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_proyecto_PresupuestosTextBox.TabIndex = 2
        '
        'Id_FiscalTextBox
        '
        Me.Id_FiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Id_Fiscal", True))
        Me.Id_FiscalTextBox.Location = New System.Drawing.Point(167, 69)
        Me.Id_FiscalTextBox.Name = "Id_FiscalTextBox"
        Me.Id_FiscalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_FiscalTextBox.TabIndex = 4
        '
        'Id_PresupuestoTextBox
        '
        Me.Id_PresupuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PresupuestoBindingSource, "Id_Presupuesto", True))
        Me.Id_PresupuestoTextBox.Location = New System.Drawing.Point(167, 34)
        Me.Id_PresupuestoTextBox.Name = "Id_PresupuestoTextBox"
        Me.Id_PresupuestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_PresupuestoTextBox.TabIndex = 5
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(307, 98)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmCambioProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 244)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Id_PresupuestoLabel)
        Me.Controls.Add(Me.Id_PresupuestoTextBox)
        Me.Controls.Add(Id_FiscalLabel)
        Me.Controls.Add(Me.Id_FiscalTextBox)
        Me.Controls.Add(Id_proyecto_PresupuestosLabel)
        Me.Controls.Add(Me.Id_proyecto_PresupuestosTextBox)
        Me.Name = "FrmCambioProyecto"
        Me.Text = "FrmCambioProyecto"
        CType(Me.DsPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPresupuestos As DsPresupuestos
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents PresupuestoTableAdapter As DsPresupuestosTableAdapters.PresupuestoTableAdapter
    Friend WithEvents TableAdapterManager As DsPresupuestosTableAdapters.TableAdapterManager
    Friend WithEvents Id_proyecto_PresupuestosTextBox As TextBox
    Friend WithEvents Id_FiscalTextBox As TextBox
    Friend WithEvents Id_PresupuestoTextBox As TextBox
    Friend WithEvents BtnAceptar As Button
End Class
