<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagoFacturasClientes
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalesPorMoneda = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.BtnFacturas = New System.Windows.Forms.Button()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.ColumnHeadersHeight = 34
        Me.dgvPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPagos.Location = New System.Drawing.Point(0, 56)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersWidth = 62
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(1184, 566)
        Me.dgvPagos.TabIndex = 0
        '
        'cmbClientes
        '
        Me.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClientes.Location = New System.Drawing.Point(13, 13)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(300, 28)
        Me.cmbClientes.TabIndex = 1
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(319, 13)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(180, 26)
        Me.txtFactura.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotal.Location = New System.Drawing.Point(1174, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New System.Windows.Forms.Padding(0, 8, 10, 0)
        Me.lblTotal.Size = New System.Drawing.Size(10, 28)
        Me.lblTotal.TabIndex = 1
        '
        'lblTotalesPorMoneda
        '
        Me.lblTotalesPorMoneda.AutoSize = True
        Me.lblTotalesPorMoneda.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTotalesPorMoneda.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalesPorMoneda.Name = "lblTotalesPorMoneda"
        Me.lblTotalesPorMoneda.Padding = New System.Windows.Forms.Padding(10, 8, 0, 0)
        Me.lblTotalesPorMoneda.Size = New System.Drawing.Size(10, 28)
        Me.lblTotalesPorMoneda.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AutoSize = True
        Me.btnLimpiar.Location = New System.Drawing.Point(505, 13)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 30)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar filtros"
        '
        'PanelTop
        '
        Me.PanelTop.AutoSize = True
        Me.PanelTop.Controls.Add(Me.cmbClientes)
        Me.PanelTop.Controls.Add(Me.txtFactura)
        Me.PanelTop.Controls.Add(Me.btnLimpiar)
        Me.PanelTop.Controls.Add(Me.cmbAnio)
        Me.PanelTop.Controls.Add(Me.BtnFacturas)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTop.Size = New System.Drawing.Size(1184, 56)
        Me.PanelTop.TabIndex = 2
        '
        'cmbAnio
        '
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(623, 13)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(121, 28)
        Me.cmbAnio.TabIndex = 5
        '
        'BtnFacturas
        '
        Me.BtnFacturas.Location = New System.Drawing.Point(750, 13)
        Me.BtnFacturas.Name = "BtnFacturas"
        Me.BtnFacturas.Size = New System.Drawing.Size(102, 30)
        Me.BtnFacturas.TabIndex = 6
        Me.BtnFacturas.Text = "Facturas"
        Me.BtnFacturas.UseVisualStyleBackColor = True
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.lblTotalesPorMoneda)
        Me.PanelBottom.Controls.Add(Me.lblTotal)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 622)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1184, 55)
        Me.PanelBottom.TabIndex = 1
        '
        'FrmPagoFacturasClientes
        '
        Me.ClientSize = New System.Drawing.Size(1184, 677)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "FrmPagoFacturasClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pagos de facturas por cliente"
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalesPorMoneda As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PanelTop As FlowLayoutPanel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents cmbAnio As ComboBox
    Friend WithEvents BtnFacturas As Button
End Class