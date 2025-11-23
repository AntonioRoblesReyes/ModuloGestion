<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOptimizarMadera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOptimizarMadera))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rdbModoIdeal = New System.Windows.Forms.RadioButton()
        Me.rdbModoProveedor = New System.Windows.Forms.RadioButton()
        Me.btnCargarStock = New System.Windows.Forms.Button()
        Me.dgvOptimizado = New System.Windows.Forms.DataGridView()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvImportado = New System.Windows.Forms.DataGridView()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.cmbgrueso = New System.Windows.Forms.ComboBox()
        Me.cmbAncho = New System.Windows.Forms.ComboBox()
        Me.cmbLargo = New System.Windows.Forms.ComboBox()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.lblPiesTablaresOptimizado = New System.Windows.Forms.Label()
        Me.lblPiesTablaresResumen = New System.Windows.Forms.Label()
        Me.lblPiesTablaresImportados = New System.Windows.Forms.Label()
        Me.dgvNoOptimizado = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnVerGrafico = New System.Windows.Forms.Button()
        Me.gbModo = New System.Windows.Forms.GroupBox()
        Me.gbExcel = New System.Windows.Forms.GroupBox()
        Me.txtArchivoExcel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargarExcel = New System.Windows.Forms.Button()
        Me.btnOptimizar = New System.Windows.Forms.Button()
        Me.tabResultados = New System.Windows.Forms.TabControl()
        Me.tpImportado = New System.Windows.Forms.TabPage()
        Me.tpOptimizado = New System.Windows.Forms.TabPage()
        Me.cmbLargoOptimizacion = New System.Windows.Forms.ComboBox()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.tpResumen = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabMedidas = New System.Windows.Forms.TabPage()
        Me.lblSeleccionados = New System.Windows.Forms.Label()
        Me.dgvProveedorMedidas = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblRegistrosImportado = New System.Windows.Forms.Label()
        Me.LblPiesImportado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegistroOptimizados = New System.Windows.Forms.Label()
        Me.lbltotalpiesoptimizados = New System.Windows.Forms.Label()
        CType(Me.dgvOptimizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImportado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNoOptimizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbModo.SuspendLayout()
        Me.gbExcel.SuspendLayout()
        Me.tabResultados.SuspendLayout()
        Me.tpImportado.SuspendLayout()
        Me.tpOptimizado.SuspendLayout()
        Me.tpResumen.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabMedidas.SuspendLayout()
        CType(Me.dgvProveedorMedidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rdbModoIdeal
        '
        Me.rdbModoIdeal.AutoSize = True
        Me.rdbModoIdeal.Checked = True
        Me.rdbModoIdeal.Location = New System.Drawing.Point(28, 19)
        Me.rdbModoIdeal.Name = "rdbModoIdeal"
        Me.rdbModoIdeal.Size = New System.Drawing.Size(96, 20)
        Me.rdbModoIdeal.TabIndex = 1
        Me.rdbModoIdeal.TabStop = True
        Me.rdbModoIdeal.Text = "Modo Ideal"
        Me.rdbModoIdeal.UseVisualStyleBackColor = True
        '
        'rdbModoProveedor
        '
        Me.rdbModoProveedor.AutoSize = True
        Me.rdbModoProveedor.Location = New System.Drawing.Point(150, 21)
        Me.rdbModoProveedor.Name = "rdbModoProveedor"
        Me.rdbModoProveedor.Size = New System.Drawing.Size(130, 20)
        Me.rdbModoProveedor.TabIndex = 2
        Me.rdbModoProveedor.Text = "Modo Proveedor"
        Me.rdbModoProveedor.UseVisualStyleBackColor = True
        '
        'btnCargarStock
        '
        Me.btnCargarStock.Location = New System.Drawing.Point(1464, 738)
        Me.btnCargarStock.Name = "btnCargarStock"
        Me.btnCargarStock.Size = New System.Drawing.Size(124, 23)
        Me.btnCargarStock.TabIndex = 3
        Me.btnCargarStock.Text = "Resumen"
        Me.btnCargarStock.UseVisualStyleBackColor = True
        '
        'dgvOptimizado
        '
        Me.dgvOptimizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOptimizado.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvOptimizado.Location = New System.Drawing.Point(3, 3)
        Me.dgvOptimizado.Name = "dgvOptimizado"
        Me.dgvOptimizado.RowHeadersWidth = 51
        Me.dgvOptimizado.RowTemplate.Height = 24
        Me.dgvOptimizado.Size = New System.Drawing.Size(1305, 215)
        Me.dgvOptimizado.TabIndex = 5
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(607, 96)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(124, 23)
        Me.btnExportarPDF.TabIndex = 7
        Me.btnExportarPDF.Text = "Exportar PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exportar Excel"
        Me.Button2.UseMnemonic = False
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvImportado
        '
        Me.dgvImportado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImportado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvImportado.Location = New System.Drawing.Point(3, 3)
        Me.dgvImportado.Name = "dgvImportado"
        Me.dgvImportado.RowHeadersWidth = 51
        Me.dgvImportado.RowTemplate.Height = 24
        Me.dgvImportado.Size = New System.Drawing.Size(1305, 465)
        Me.dgvImportado.TabIndex = 9
        '
        'dgvResumen
        '
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResumen.Location = New System.Drawing.Point(3, 3)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.RowHeadersWidth = 51
        Me.dgvResumen.RowTemplate.Height = 24
        Me.dgvResumen.Size = New System.Drawing.Size(1305, 465)
        Me.dgvResumen.TabIndex = 10
        '
        'cmbgrueso
        '
        Me.cmbgrueso.FormattingEnabled = True
        Me.cmbgrueso.Location = New System.Drawing.Point(1464, 115)
        Me.cmbgrueso.Name = "cmbgrueso"
        Me.cmbgrueso.Size = New System.Drawing.Size(121, 24)
        Me.cmbgrueso.TabIndex = 11
        '
        'cmbAncho
        '
        Me.cmbAncho.FormattingEnabled = True
        Me.cmbAncho.Location = New System.Drawing.Point(1628, 115)
        Me.cmbAncho.Name = "cmbAncho"
        Me.cmbAncho.Size = New System.Drawing.Size(91, 24)
        Me.cmbAncho.TabIndex = 12
        '
        'cmbLargo
        '
        Me.cmbLargo.FormattingEnabled = True
        Me.cmbLargo.Location = New System.Drawing.Point(1767, 115)
        Me.cmbLargo.Name = "cmbLargo"
        Me.cmbLargo.Size = New System.Drawing.Size(121, 24)
        Me.cmbLargo.TabIndex = 13
        '
        'lblErrores
        '
        Me.lblErrores.AutoSize = True
        Me.lblErrores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.Red
        Me.lblErrores.Location = New System.Drawing.Point(184, 42)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(59, 23)
        Me.lblErrores.TabIndex = 15
        Me.lblErrores.Text = "Label1"
        '
        'lblPiesTablaresOptimizado
        '
        Me.lblPiesTablaresOptimizado.AutoSize = True
        Me.lblPiesTablaresOptimizado.Location = New System.Drawing.Point(454, 23)
        Me.lblPiesTablaresOptimizado.Name = "lblPiesTablaresOptimizado"
        Me.lblPiesTablaresOptimizado.Size = New System.Drawing.Size(48, 16)
        Me.lblPiesTablaresOptimizado.TabIndex = 16
        Me.lblPiesTablaresOptimizado.Text = "Label1"
        Me.lblPiesTablaresOptimizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPiesTablaresResumen
        '
        Me.lblPiesTablaresResumen.AutoSize = True
        Me.lblPiesTablaresResumen.Location = New System.Drawing.Point(223, 23)
        Me.lblPiesTablaresResumen.Name = "lblPiesTablaresResumen"
        Me.lblPiesTablaresResumen.Size = New System.Drawing.Size(48, 16)
        Me.lblPiesTablaresResumen.TabIndex = 17
        Me.lblPiesTablaresResumen.Text = "Label1"
        Me.lblPiesTablaresResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPiesTablaresImportados
        '
        Me.lblPiesTablaresImportados.AutoSize = True
        Me.lblPiesTablaresImportados.Location = New System.Drawing.Point(29, 23)
        Me.lblPiesTablaresImportados.Name = "lblPiesTablaresImportados"
        Me.lblPiesTablaresImportados.Size = New System.Drawing.Size(48, 16)
        Me.lblPiesTablaresImportados.TabIndex = 18
        Me.lblPiesTablaresImportados.Text = "Label1"
        Me.lblPiesTablaresImportados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvNoOptimizado
        '
        Me.dgvNoOptimizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNoOptimizado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvNoOptimizado.Location = New System.Drawing.Point(3, 256)
        Me.dgvNoOptimizado.Name = "dgvNoOptimizado"
        Me.dgvNoOptimizado.RowHeadersWidth = 51
        Me.dgvNoOptimizado.RowTemplate.Height = 24
        Me.dgvNoOptimizado.Size = New System.Drawing.Size(1305, 212)
        Me.dgvNoOptimizado.TabIndex = 19
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnVerGrafico)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExportarPDF)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbModo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbExcel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOptimizar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabResultados)
        Me.SplitContainer1.Size = New System.Drawing.Size(1319, 697)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 20
        '


        '
        'gbModo
        '
        Me.gbModo.Controls.Add(Me.rdbModoIdeal)
        Me.gbModo.Controls.Add(Me.lblErrores)
        Me.gbModo.Controls.Add(Me.rdbModoProveedor)
        Me.gbModo.Location = New System.Drawing.Point(7, 96)
        Me.gbModo.Name = "gbModo"
        Me.gbModo.Size = New System.Drawing.Size(300, 70)
        Me.gbModo.TabIndex = 1
        Me.gbModo.TabStop = False
        Me.gbModo.Text = " Modo de Optimización"
        '
        'gbExcel
        '
        Me.gbExcel.Controls.Add(Me.txtArchivoExcel)
        Me.gbExcel.Controls.Add(Me.Label1)
        Me.gbExcel.Controls.Add(Me.btnCargarExcel)
        Me.gbExcel.Location = New System.Drawing.Point(7, 3)
        Me.gbExcel.Name = "gbExcel"
        Me.gbExcel.Size = New System.Drawing.Size(600, 70)
        Me.gbExcel.TabIndex = 0
        Me.gbExcel.TabStop = False
        Me.gbExcel.Text = "Cargar Excel"
        '
        'txtArchivoExcel
        '
        Me.txtArchivoExcel.Location = New System.Drawing.Point(94, 28)
        Me.txtArchivoExcel.Name = "txtArchivoExcel"
        Me.txtArchivoExcel.ReadOnly = True
        Me.txtArchivoExcel.Size = New System.Drawing.Size(100, 22)
        Me.txtArchivoExcel.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Archivo"
        '
        'btnCargarExcel
        '
        Me.btnCargarExcel.Image = CType(resources.GetObject("btnCargarExcel.Image"), System.Drawing.Image)
        Me.btnCargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarExcel.Location = New System.Drawing.Point(325, 19)
        Me.btnCargarExcel.Name = "btnCargarExcel"
        Me.btnCargarExcel.Size = New System.Drawing.Size(130, 40)
        Me.btnCargarExcel.TabIndex = 0
        Me.btnCargarExcel.Text = "Examinar"
        Me.btnCargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargarExcel.UseVisualStyleBackColor = True
        '

        '
        'tabResultados
        '
        Me.tabResultados.Controls.Add(Me.tpImportado)
        Me.tabResultados.Controls.Add(Me.tpOptimizado)
        Me.tabResultados.Controls.Add(Me.tpResumen)
        Me.tabResultados.Controls.Add(Me.TabMedidas)
        Me.tabResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabResultados.Location = New System.Drawing.Point(0, 0)
        Me.tabResultados.Name = "tabResultados"
        Me.tabResultados.SelectedIndex = 0
        Me.tabResultados.Size = New System.Drawing.Size(1319, 500)
        Me.tabResultados.TabIndex = 0
        '
        'tpImportado
        '
        Me.tpImportado.Controls.Add(Me.Panel2)
        Me.tpImportado.Controls.Add(Me.dgvImportado)
        Me.tpImportado.Location = New System.Drawing.Point(4, 25)
        Me.tpImportado.Name = "tpImportado"
        Me.tpImportado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpImportado.Size = New System.Drawing.Size(1311, 471)
        Me.tpImportado.TabIndex = 0
        Me.tpImportado.Text = "Importado"
        Me.tpImportado.UseVisualStyleBackColor = True
        '
        'tpOptimizado
        '
        Me.tpOptimizado.Controls.Add(Me.lbltotalpiesoptimizados)
        Me.tpOptimizado.Controls.Add(Me.lblRegistroOptimizados)
        Me.tpOptimizado.Controls.Add(Me.Label2)
        Me.tpOptimizado.Controls.Add(Me.cmbLargoOptimizacion)
        Me.tpOptimizado.Controls.Add(Me.btnDividir)
        Me.tpOptimizado.Controls.Add(Me.dgvNoOptimizado)
        Me.tpOptimizado.Controls.Add(Me.dgvOptimizado)
        Me.tpOptimizado.Location = New System.Drawing.Point(4, 25)
        Me.tpOptimizado.Name = "tpOptimizado"
        Me.tpOptimizado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOptimizado.Size = New System.Drawing.Size(1311, 471)
        Me.tpOptimizado.TabIndex = 1
        Me.tpOptimizado.Text = "Optimizado"
        Me.tpOptimizado.UseVisualStyleBackColor = True
        '
        'cmbLargoOptimizacion
        '
        Me.cmbLargoOptimizacion.FormattingEnabled = True
        Me.cmbLargoOptimizacion.Location = New System.Drawing.Point(153, 225)
        Me.cmbLargoOptimizacion.Name = "cmbLargoOptimizacion"
        Me.cmbLargoOptimizacion.Size = New System.Drawing.Size(121, 24)
        Me.cmbLargoOptimizacion.TabIndex = 20

        '
        'tpResumen
        '
        Me.tpResumen.Controls.Add(Me.Panel1)
        Me.tpResumen.Controls.Add(Me.dgvResumen)
        Me.tpResumen.Location = New System.Drawing.Point(4, 25)
        Me.tpResumen.Name = "tpResumen"
        Me.tpResumen.Padding = New System.Windows.Forms.Padding(3)
        Me.tpResumen.Size = New System.Drawing.Size(1311, 471)
        Me.tpResumen.TabIndex = 2
        Me.tpResumen.Text = "Resumen"
        Me.tpResumen.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPiesTablaresImportados)
        Me.Panel1.Controls.Add(Me.lblPiesTablaresOptimizado)
        Me.Panel1.Controls.Add(Me.lblPiesTablaresResumen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1305, 52)
        Me.Panel1.TabIndex = 11
        '
        'TabMedidas
        '
        Me.TabMedidas.Controls.Add(Me.lblSeleccionados)
        Me.TabMedidas.Controls.Add(Me.dgvProveedorMedidas)
        Me.TabMedidas.Location = New System.Drawing.Point(4, 25)
        Me.TabMedidas.Name = "TabMedidas"
        Me.TabMedidas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMedidas.Size = New System.Drawing.Size(1311, 471)
        Me.TabMedidas.TabIndex = 3
        Me.TabMedidas.Text = "Medidas"
        Me.TabMedidas.UseVisualStyleBackColor = True
        '
        'lblSeleccionados
        '
        Me.lblSeleccionados.AutoSize = True
        Me.lblSeleccionados.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionados.ForeColor = System.Drawing.Color.Blue
        Me.lblSeleccionados.Location = New System.Drawing.Point(969, 3)
        Me.lblSeleccionados.Name = "lblSeleccionados"
        Me.lblSeleccionados.Size = New System.Drawing.Size(59, 23)
        Me.lblSeleccionados.TabIndex = 21
        Me.lblSeleccionados.Text = "Label2"
        '
        'dgvProveedorMedidas
        '
        Me.dgvProveedorMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedorMedidas.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvProveedorMedidas.Location = New System.Drawing.Point(3, 3)
        Me.dgvProveedorMedidas.Name = "dgvProveedorMedidas"
        Me.dgvProveedorMedidas.RowHeadersWidth = 51
        Me.dgvProveedorMedidas.RowTemplate.Height = 24
        Me.dgvProveedorMedidas.Size = New System.Drawing.Size(960, 465)
        Me.dgvProveedorMedidas.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblPiesImportado)
        Me.Panel2.Controls.Add(Me.LblRegistrosImportado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1305, 46)
        Me.Panel2.TabIndex = 10
        '
        'LblRegistrosImportado
        '
        Me.LblRegistrosImportado.AutoSize = True
        Me.LblRegistrosImportado.Location = New System.Drawing.Point(100, 16)
        Me.LblRegistrosImportado.Name = "LblRegistrosImportado"
        Me.LblRegistrosImportado.Size = New System.Drawing.Size(0, 16)
        Me.LblRegistrosImportado.TabIndex = 0
        '
        'LblPiesImportado
        '
        Me.LblPiesImportado.AutoSize = True
        Me.LblPiesImportado.Location = New System.Drawing.Point(392, 16)
        Me.LblPiesImportado.Name = "LblPiesImportado"
        Me.LblPiesImportado.Size = New System.Drawing.Size(0, 16)
        Me.LblPiesImportado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        '
        'lblRegistroOptimizados
        '
        Me.lblRegistroOptimizados.AutoSize = True
        Me.lblRegistroOptimizados.Location = New System.Drawing.Point(449, 234)
        Me.lblRegistroOptimizados.Name = "lblRegistroOptimizados"
        Me.lblRegistroOptimizados.Size = New System.Drawing.Size(48, 16)
        Me.lblRegistroOptimizados.TabIndex = 22
        Me.lblRegistroOptimizados.Text = "Label3"
        '
        'lbltotalpiesoptimizados
        '
        Me.lbltotalpiesoptimizados.AutoSize = True
        Me.lbltotalpiesoptimizados.Location = New System.Drawing.Point(738, 233)
        Me.lbltotalpiesoptimizados.Name = "lbltotalpiesoptimizados"
        Me.lbltotalpiesoptimizados.Size = New System.Drawing.Size(0, 16)
        Me.lbltotalpiesoptimizados.TabIndex = 23
        '
        'FrmOptimizarMadera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 697)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmbLargo)
        Me.Controls.Add(Me.cmbAncho)
        Me.Controls.Add(Me.cmbgrueso)
        Me.Controls.Add(Me.btnCargarStock)
        Me.Name = "FrmOptimizarMadera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Optimización de Madera"
        Me.TopMost = True
        CType(Me.dgvOptimizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImportado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNoOptimizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbModo.ResumeLayout(False)
        Me.gbModo.PerformLayout()
        Me.gbExcel.ResumeLayout(False)
        Me.gbExcel.PerformLayout()
        Me.tabResultados.ResumeLayout(False)
        Me.tpImportado.ResumeLayout(False)
        Me.tpOptimizado.ResumeLayout(False)
        Me.tpOptimizado.PerformLayout()
        Me.tpResumen.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabMedidas.ResumeLayout(False)
        Me.TabMedidas.PerformLayout()
        CType(Me.dgvProveedorMedidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCargarExcel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rdbModoIdeal As RadioButton
    Friend WithEvents rdbModoProveedor As RadioButton
    Friend WithEvents btnCargarStock As Button
    Friend WithEvents btnOptimizar As Button
    Friend WithEvents dgvOptimizado As DataGridView
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvImportado As DataGridView
    Friend WithEvents dgvResumen As DataGridView
    Friend WithEvents cmbgrueso As ComboBox
    Friend WithEvents cmbAncho As ComboBox
    Friend WithEvents cmbLargo As ComboBox
    Friend WithEvents lblErrores As Label
    Friend WithEvents lblPiesTablaresOptimizado As Label
    Friend WithEvents lblPiesTablaresResumen As Label
    Friend WithEvents lblPiesTablaresImportados As Label
    Friend WithEvents dgvNoOptimizado As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents gbExcel As GroupBox
    Friend WithEvents btnVerGrafico As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtArchivoExcel As TextBox
    Friend WithEvents gbModo As GroupBox
    Friend WithEvents lblSeleccionados As Label
    Friend WithEvents tabResultados As TabControl
    Friend WithEvents tpImportado As TabPage
    Friend WithEvents tpOptimizado As TabPage
    Friend WithEvents tpResumen As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabMedidas As TabPage
    Friend WithEvents dgvProveedorMedidas As DataGridView
    Friend WithEvents btnDividir As Button
    Friend WithEvents cmbLargoOptimizacion As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblPiesImportado As Label
    Friend WithEvents LblRegistrosImportado As Label
    Friend WithEvents lblRegistroOptimizados As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltotalpiesoptimizados As Label
End Class
