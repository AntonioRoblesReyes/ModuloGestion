Imports System.Drawing
Imports System.Reflection

Public Class FrmFacturasResumen

    Private ReadOnly _origen As New BindingSource()
    Private ReadOnly _tablaPagos As DataTable

    Private _tablaFacturas As DataTable
    Private _tablaFacturasOrigen As DataTable
    Private _cargandoCombos As Boolean = False

    ' ===== Clientes (Razón social) =====
    Private ReadOnly _dsClientes As New DsClientes()
    Private ReadOnly _taClientes As New DsClientesTableAdapters.ClientesTableAdapter()
    Private _clientesPorFiscal As Dictionary(Of String, String)

    ' Recibe la tabla de pagos (ya cargada)
    Public Sub New(tablaPagos As DataTable)
        InitializeComponent()
        _tablaPagos = tablaPagos
    End Sub

    Private Sub FrmFacturasResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 1) Cargar CLIENTES (Id_Fiscal -> Nombre_Cliente)
        _taClientes.Fill(_dsClientes.Clientes)

        _clientesPorFiscal = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        For Each c As DsClientes.ClientesRow In _dsClientes.Clientes
            Dim id As String = c.Id_Fiscal.Trim()
            Dim nombre As String = c.Nombre_Cliente.Trim()
            _clientesPorFiscal(id) = nombre
        Next

        ' 2) Cargar FACTURAS
        Dim taFacturas As New DsFacturasTableAdapters.FacturaTableAdapter()
        Dim dsFacturas As New DsFacturas()
        taFacturas.Fill(dsFacturas.Factura)
        _tablaFacturasOrigen = dsFacturas.Factura

        ' 3) Construir resumen
        ConstruirTablaFacturas()

        ' 4) Enlazar grid
        _origen.DataSource = _tablaFacturas
        dgvFacturas.DataSource = _origen

        ' 5) UI + filtros
        ConfigurarGrid()
        ActivarDoubleBuffer(dgvFacturas)
        CargarFiltros()
        ActualizarTotales()

        _origen.Sort = "Factura ASC, Moneda ASC"

    End Sub

    ' ------------------------------
    ' Construir resumen por factura
    ' ------------------------------
    Private Sub ConstruirTablaFacturas()

        _tablaFacturas = New DataTable("FacturasResumen")

        _tablaFacturas.Columns.Add("Factura", GetType(String))
        _tablaFacturas.Columns.Add("IdFiscal", GetType(String))
        _tablaFacturas.Columns.Add("FechaFactura", GetType(Date))
        _tablaFacturas.Columns.Add("Cliente", GetType(String))
        _tablaFacturas.Columns.Add("Moneda", GetType(String))
        _tablaFacturas.Columns.Add("Anio", GetType(Integer))
        _tablaFacturas.Columns.Add("TotalFactura", GetType(Decimal))
        _tablaFacturas.Columns.Add("TotalPagado", GetType(Decimal))
        _tablaFacturas.Columns.Add("Balance", GetType(Decimal))
        _tablaFacturas.Columns.Add("Estado", GetType(String))

        ' Recorremos FACTURAS (fecha sale de aquí)
        For Each f As DataRow In _tablaFacturasOrigen.Rows

            Dim factura As String = f("IdFactura").ToString().Trim()
            If factura = "" Then Continue For

            Dim fechaFactura As Date = CDate(f("Fecha"))
            Dim anio As Integer = fechaFactura.Year

            Dim idFiscal As String = f("IdCliente").ToString().Trim()
            Dim moneda As String = f("Moneda").ToString().Trim()

            ' ✅ Razón social
            Dim cliente As String = _clientesPorFiscal(idFiscal)

            ' ✅ TotalFactura por moneda
            Dim totalFactura As Decimal
            If moneda.Equals("US$", StringComparison.OrdinalIgnoreCase) Then
                totalFactura = CDec(f("TotalUS$"))
            Else
                totalFactura = CDec(f("TotalRDS"))
            End If

            ' ✅ TotalPagado (por factura y por moneda)
            Dim totalPagado As Decimal = 0D
            For Each p As DataRow In _tablaPagos.Rows
                If p("Factura").ToString().Trim() <> factura Then Continue For
                If p("Moneda").ToString().Trim() <> moneda Then Continue For
                totalPagado += CDec(p("MontoPagado"))
            Next

            Dim balance As Decimal = totalFactura - totalPagado
            Dim estado As String = If(balance <= 0D, "Pagada", "Pendiente")

            _tablaFacturas.Rows.Add(
                factura,
                idFiscal,
                fechaFactura,
                cliente,
                moneda,
                anio,
                totalFactura,
                totalPagado,
                balance,
                estado
            )

        Next

    End Sub

    ' ------------------------------
    ' Filtros
    ' ------------------------------
    Private Sub CargarFiltros()

        _cargandoCombos = True

        ' Clientes (combo muestra Razón Social, value = IdFiscal)
        Dim dtClientes As New DataTable()
        dtClientes.Columns.Add("IdFiscal", GetType(String))
        dtClientes.Columns.Add("Cliente", GetType(String))
        dtClientes.Rows.Add("", "Todos")

        Dim dtUniq As DataTable = _tablaFacturas.DefaultView.ToTable(True, "IdFiscal", "Cliente")
        dtUniq.DefaultView.Sort = "Cliente ASC"

        For Each r As DataRowView In dtUniq.DefaultView
            dtClientes.Rows.Add(r("IdFiscal").ToString(), r("Cliente").ToString())
        Next

        cmbClientes.DataSource = dtClientes
        cmbClientes.DisplayMember = "Cliente"
        cmbClientes.ValueMember = "IdFiscal"
        cmbClientes.SelectedIndex = 0

        ' Años
        Dim dtAnios As New DataTable()
        dtAnios.Columns.Add("Anio", GetType(Integer))
        dtAnios.Rows.Add(0)

        Dim vistos As New HashSet(Of Integer)()
        For Each r As DataRow In _tablaFacturas.Rows
            Dim y As Integer = CInt(r("Anio"))
            If Not vistos.Contains(y) Then vistos.Add(y)
        Next

        For Each y In vistos.OrderByDescending(Function(x) x)
            If y > 0 Then dtAnios.Rows.Add(y)
        Next

        cmbAnio.DataSource = dtAnios
        cmbAnio.DisplayMember = "Anio"
        cmbAnio.ValueMember = "Anio"
        cmbAnio.SelectedIndex = 0

        _cargandoCombos = False

    End Sub

    Private Sub AplicarFiltros()

        If _cargandoCombos Then Exit Sub

        Dim filtros As New List(Of String)

        If cmbClientes.SelectedValue IsNot Nothing AndAlso cmbClientes.SelectedValue.ToString() <> "" Then
            filtros.Add($"IdFiscal = '{cmbClientes.SelectedValue.ToString().Replace("'", "''")}'")
        End If

        If txtFactura.Text.Trim().Length >= 3 Then
            filtros.Add($"Factura LIKE '%{txtFactura.Text.Trim().Replace("'", "''")}%'")
        End If

        If cmbAnio.SelectedValue IsNot Nothing Then
            Dim anio As Integer = Convert.ToInt32(cmbAnio.SelectedValue)
            If anio > 0 Then filtros.Add($"Anio = {anio}")
        End If

        _origen.Filter = String.Join(" AND ", filtros)
        ActualizarTotales()

    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub cmbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnio.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub txtFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFactura.KeyDown
        If e.KeyCode = Keys.Enter Then AplicarFiltros()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbClientes.SelectedIndex = 0
        cmbAnio.SelectedIndex = 0
        txtFactura.Clear()
        _origen.RemoveFilter()
        ActualizarTotales()
    End Sub

    ' ------------------------------
    ' Totales (Balance total filtrado)
    ' ------------------------------
    Private Sub ActualizarTotales()

        Dim totalBalance As Decimal = 0D
        For Each drv As DataRowView In _origen
            totalBalance += CDec(drv("Balance"))
        Next

        lblTotales.Text = $"Balance total pendiente: {totalBalance:#,##0.00}"

    End Sub

    ' ------------------------------
    ' Grid helpers
    ' ------------------------------
    Private Sub ConfigurarGrid()

        dgvFacturas.Columns("FechaFactura").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvFacturas.Columns("TotalFactura").DefaultCellStyle.Format = "#,##0.00"
        dgvFacturas.Columns("TotalPagado").DefaultCellStyle.Format = "#,##0.00"
        dgvFacturas.Columns("Balance").DefaultCellStyle.Format = "#,##0.00"

        dgvFacturas.Columns("TotalFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvFacturas.Columns("TotalPagado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvFacturas.Columns("Balance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub ActivarDoubleBuffer(grid As DataGridView)
        Dim p = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance)
        If p IsNot Nothing Then p.SetValue(grid, True, Nothing)
    End Sub
    Private Sub dgvFacturas_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvFacturas.CellClick

        ' Evitar header
        If e.RowIndex < 0 Then Exit Sub

        ' Tomar la factura seleccionada
        Dim factura As String =
        dgvFacturas.Rows(e.RowIndex).Cells("Factura").Value.ToString()

        ' Filtrar pagos de esa factura
        Dim dv As New DataView(_tablaPagos)
        dv.RowFilter = $"Factura = '{factura.Replace("'", "''")}'"

        ' Mostrar detalle en el grid inferior
        dgvPagosDetalle.DataSource = dv

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        If dgvFacturas.CurrentRow Is Nothing Then
            MsgBox("Seleccione una factura.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim factura As String =
        dgvFacturas.CurrentRow.Cells("Factura").Value.ToString()

        ' ===== FACTURA =====
        Dim dvFactura As New DataView(_tablaFacturas)
        dvFactura.RowFilter = $"Factura = '{factura.Replace("'", "''")}'"

        ' ===== PAGOS =====
        Dim dtPagos As DataTable
        If dgvPagosDetalle.DataSource IsNot Nothing Then
            dtPagos = CType(dgvPagosDetalle.DataSource, DataView).ToTable()
        Else
            dtPagos = _tablaPagos.Clone()
        End If

        Dim frm As New FrmVisorCrystal()
        frm.ImprimirFactura(dvFactura.ToTable(), dtPagos)
        frm.ShowDialog()

    End Sub
End Class