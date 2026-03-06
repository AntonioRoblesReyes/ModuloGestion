<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturasResumen
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.dgvPagosDetalle = New System.Windows.Forms.DataGridView()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblTotales = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFacturas.ColumnHeadersHeight = 34
        Me.dgvFacturas.Location = New System.Drawing.Point(0, 56)
        Me.dgvFacturas.MultiSelect = False
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.ReadOnly = True
        Me.dgvFacturas.RowHeadersWidth = 62
        Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturas.Size = New System.Drawing.Size(1200, 360)
        Me.dgvFacturas.TabIndex = 0
        '
        'dgvPagosDetalle
        '
        Me.dgvPagosDetalle.AllowUserToAddRows = False
        Me.dgvPagosDetalle.AllowUserToDeleteRows = False
        Me.dgvPagosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagosDetalle.ColumnHeadersHeight = 34
        Me.dgvPagosDetalle.Location = New System.Drawing.Point(0, 416)
        Me.dgvPagosDetalle.MultiSelect = False
        Me.dgvPagosDetalle.Name = "dgvPagosDetalle"
        Me.dgvPagosDetalle.ReadOnly = True
        Me.dgvPagosDetalle.RowHeadersWidth = 62
        Me.dgvPagosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagosDetalle.Size = New System.Drawing.Size(1200, 239)
        Me.dgvPagosDetalle.TabIndex = 7
        '
        'cmbClientes
        '
        Me.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClientes.Location = New System.Drawing.Point(13, 13)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(280, 28)
        Me.cmbClientes.TabIndex = 1
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Location = New System.Drawing.Point(299, 13)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(90, 28)
        Me.cmbAnio.TabIndex = 3
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(395, 13)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(160, 26)
        Me.txtFactura.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AutoSize = True
        Me.btnLimpiar.Location = New System.Drawing.Point(561, 13)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 30)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar filtros"
        '
        'lblTotales
        '
        Me.lblTotales.AutoSize = True
        Me.lblTotales.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotales.Location = New System.Drawing.Point(974, 0)
        Me.lblTotales.Name = "lblTotales"
        Me.lblTotales.Padding = New System.Windows.Forms.Padding(0, 8, 10, 0)
        Me.lblTotales.Size = New System.Drawing.Size(226, 28)
        Me.lblTotales.TabIndex = 0
        Me.lblTotales.Text = "Balance total pendiente: 0.00"
        '
        'PanelTop
        '
        Me.PanelTop.AutoSize = True
        Me.PanelTop.Controls.Add(Me.cmbClientes)
        Me.PanelTop.Controls.Add(Me.cmbAnio)
        Me.PanelTop.Controls.Add(Me.txtFactura)
        Me.PanelTop.Controls.Add(Me.btnLimpiar)
        Me.PanelTop.Controls.Add(Me.btnImprimir)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTop.Size = New System.Drawing.Size(1200, 56)
        Me.PanelTop.TabIndex = 2
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSize = True
        Me.btnImprimir.Location = New System.Drawing.Point(679, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 30)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.lblTotales)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 655)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1200, 45)
        Me.PanelBottom.TabIndex = 1
        '
        'FrmFacturasResumen
        '
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.dgvPagosDetalle)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "FrmFacturasResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen de facturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFacturas As DataGridView
    Friend WithEvents dgvPagosDetalle As DataGridView
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents cmbAnio As ComboBox
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblTotales As Label
    Friend WithEvents PanelTop As FlowLayoutPanel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents btnImprimir As Button
End Class