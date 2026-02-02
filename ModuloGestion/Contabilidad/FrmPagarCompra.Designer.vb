<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagarCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose
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
        Me.components = New System.ComponentModel.Container()

        ' ======== PANEL SUPERIOR ========
        Dim panelSuperior As New Panel()
        panelSuperior.Dock = DockStyle.Top
        panelSuperior.Height = 120
        panelSuperior.Padding = New Padding(15)
        panelSuperior.BackColor = Color.WhiteSmoke

        ' ======== PANEL INFERIOR ========
        Dim panelInferior As New Panel()
        panelInferior.Dock = DockStyle.Bottom
        panelInferior.Height = 120
        panelInferior.Padding = New Padding(15)
        panelInferior.BackColor = Color.WhiteSmoke

        ' ======== LABEL FECHA ========
        Dim lblFecha As New Label()
        lblFecha.Text = "Fecha de Pago:"
        lblFecha.Font = New Font("Segoe UI", 10)
        lblFecha.Location = New Point(10, 15)
        lblFecha.AutoSize = True

        ' ======== DATE PICKER ========
        Me.DateTimePicker1 = New DateTimePicker()
        Me.DateTimePicker1.Font = New Font("Segoe UI", 10)
        Me.DateTimePicker1.Format = DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New Point(140, 12)
        Me.DateTimePicker1.Width = 150

        ' ======== LABEL TASA ========
        Dim MediaLabel As New Label()
        MediaLabel.Text = "Tasa del día:"
        MediaLabel.Font = New Font("Segoe UI", 10)
        MediaLabel.Location = New Point(320, 15)
        MediaLabel.AutoSize = True

        ' ======== TEXTBOX TASA ========
        Me.MediaTextBox = New TextBox()
        Me.MediaTextBox.Font = New Font("Segoe UI", 10)
        Me.MediaTextBox.Location = New Point(420, 12)
        Me.MediaTextBox.Width = 120
        Me.MediaTextBox.ReadOnly = True
        Me.MediaTextBox.TextAlign = HorizontalAlignment.Right

        ' ======== LABEL CUENTA ========
        Me.LabelCuenta = New Label()
        Me.LabelCuenta.Text = "Cuenta de Pago:"
        Me.LabelCuenta.Font = New Font("Segoe UI", 10)
        Me.LabelCuenta.Location = New Point(10, 60)
        Me.LabelCuenta.AutoSize = True

        ' ======== COMBO CUENTA ========
        Me.CmbFormaPago = New ComboBox()
        Me.CmbFormaPago.Font = New Font("Segoe UI", 10)
        Me.CmbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList
        Me.CmbFormaPago.Location = New Point(140, 56)
        Me.CmbFormaPago.Width = 400

        ' ======== DATAGRID =========
        Me.DgvFacturasSeleccionadas = New DataGridView()
        Me.DgvFacturasSeleccionadas.Dock = DockStyle.Fill
        Me.DgvFacturasSeleccionadas.Font = New Font("Segoe UI", 10)
        Me.DgvFacturasSeleccionadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFacturasSeleccionadas.RowHeadersVisible = False
        Me.DgvFacturasSeleccionadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturasSeleccionadas.BackgroundColor = Color.White

        ' ======== MONTO ========
        Dim lblMonto As New Label()
        lblMonto.Text = "Monto total a pagar:"
        lblMonto.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblMonto.Location = New Point(10, 20)
        lblMonto.AutoSize = True

        Me.TxtMonto = New TextBox()
        Me.TxtMonto.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.TxtMonto.Location = New Point(180, 15)
        Me.TxtMonto.Width = 160
        Me.TxtMonto.TextAlign = HorizontalAlignment.Right

        ' ======== MONEDA ========
        Me.RbRD = New RadioButton()
        Me.RbRD.Text = "RD$"
        Me.RbRD.Font = New Font("Segoe UI", 10)
        Me.RbRD.Location = New Point(360, 18)

        Me.RbUS = New RadioButton()
        Me.RbUS.Text = "US$"
        Me.RbUS.Font = New Font("Segoe UI", 10)
        Me.RbUS.Location = New Point(430, 18)

        ' ======== BOTÓN PAGAR ========
        Me.BtnRegistrarPago = New Button()
        Me.BtnRegistrarPago.Text = "Registrar Pago"
        Me.BtnRegistrarPago.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.BtnRegistrarPago.BackColor = Color.DodgerBlue
        Me.BtnRegistrarPago.ForeColor = Color.White
        Me.BtnRegistrarPago.FlatStyle = FlatStyle.Flat
        Me.BtnRegistrarPago.Width = 200
        Me.BtnRegistrarPago.Height = 50
        Me.BtnRegistrarPago.Location = New Point(700, 30)

        ' Panel Superior Controles
        panelSuperior.Controls.Add(lblFecha)
        panelSuperior.Controls.Add(DateTimePicker1)
        panelSuperior.Controls.Add(MediaLabel)
        panelSuperior.Controls.Add(MediaTextBox)
        panelSuperior.Controls.Add(LabelCuenta)
        panelSuperior.Controls.Add(CmbFormaPago)

        ' Panel Inferior Controles
        panelInferior.Controls.Add(lblMonto)
        panelInferior.Controls.Add(TxtMonto)
        panelInferior.Controls.Add(RbRD)
        panelInferior.Controls.Add(RbUS)
        panelInferior.Controls.Add(BtnRegistrarPago)

        ' FORM
        Me.Text = "Registro de Pago a Proveedor"
        Me.Font = New Font("Segoe UI", 10)
        Me.BackColor = Color.White
        Me.ClientSize = New Size(1100, 700)
        Me.Padding = New Padding(10)

        ' AGREGAR TODO AL FORMULARIO
        Me.Controls.Add(DgvFacturasSeleccionadas)
        Me.Controls.Add(panelInferior)
        Me.Controls.Add(panelSuperior)

        ' TableAdapters y BindingSources originales
        Me.DsCompras = New ModuloGestion.DsCompras()
        Me.CompraMaterialesBindingSource = New BindingSource(Me.components)
        Me.CompraMaterialesTableAdapter = New ModuloGestion.DsComprasTableAdapters.CompraMaterialesTableAdapter()
        Me.TableAdapterManager = New ModuloGestion.DsComprasTableAdapters.TableAdapterManager()

        Me.DsTasa = New ModuloGestion.DsTasa()
        Me.TasaBindingSource = New BindingSource(Me.components)
        Me.TasaTableAdapter = New ModuloGestion.DsTasaTableAdapters.TasaTableAdapter()

        Me.DsContabilidad = New ModuloGestion.DsContabilidad()
        Me.CuentasBindingSource = New BindingSource(Me.components)
        Me.CuentasTableAdapter = New ModuloGestion.DsContabilidadTableAdapters.CuentasTableAdapter()

        Me.PagoProveedorBindingSource = New BindingSource(Me.components)
        Me.PagoProveedorDetalleBindingSource = New BindingSource(Me.components)
        Me.PagoProveedorTableAdapter = New ModuloGestion.DsComprasTableAdapters.PagoProveedorTableAdapter()
        Me.PagoProveedorDetalleTableAdapter = New ModuloGestion.DsComprasTableAdapters.PagoProveedorDetalleTableAdapter()

    End Sub

    Friend WithEvents DsCompras As DsCompras
    Friend WithEvents CompraMaterialesBindingSource As BindingSource
    Friend WithEvents CompraMaterialesTableAdapter As DsComprasTableAdapters.CompraMaterialesTableAdapter
    Friend WithEvents TableAdapterManager As DsComprasTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnRegistrarPago As Button
    Friend WithEvents RbRD As RadioButton
    Friend WithEvents RbUS As RadioButton
    Friend WithEvents DsTasa As DsTasa
    Friend WithEvents TasaBindingSource As BindingSource
    Friend WithEvents TasaTableAdapter As DsTasaTableAdapters.TasaTableAdapter
    Friend WithEvents MediaTextBox As TextBox
    Friend WithEvents DgvFacturasSeleccionadas As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CmbFormaPago As ComboBox
    Friend WithEvents LabelCuenta As Label
    Friend WithEvents DsContabilidad As DsContabilidad
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As DsContabilidadTableAdapters.CuentasTableAdapter
    Friend WithEvents PagoProveedorBindingSource As BindingSource
    Friend WithEvents PagoProveedorDetalleBindingSource As BindingSource
    Friend WithEvents PagoProveedorTableAdapter As DsComprasTableAdapters.PagoProveedorTableAdapter
    Friend WithEvents PagoProveedorDetalleTableAdapter As DsComprasTableAdapters.PagoProveedorDetalleTableAdapter
End Class
