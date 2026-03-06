Imports System.Reflection
Imports System.Drawing

Public Class FrmPagoFacturasClientes

    '========================
    ' DATA
    '========================
    Private ReadOnly _origen As New BindingSource()
    Private _tablaVisual As DataTable

    Private ReadOnly _dsPagos As New DsPagosClientes()
    Private ReadOnly _dsDetalle As New DsPagosClientesDetalle()
    Private ReadOnly _dsClientes As New DsClientes()
    Private ReadOnly _dsFacturas As New DsFacturas()

    Private ReadOnly _taPagos As New DsPagosClientesTableAdapters.PagosClientesTableAdapter()
    Private ReadOnly _taDetalle As New DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
    Private ReadOnly _taClientes As New DsClientesTableAdapters.ClientesTableAdapter()
    Private ReadOnly _taFacturas As New DsFacturasTableAdapters.FacturaTableAdapter()

    '========================
    ' LOAD
    '========================
    Private Sub FrmPagoFacturasClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _taClientes.Fill(_dsClientes.Clientes)
        _taPagos.Fill(_dsPagos.PagosClientes)
        _taDetalle.Fill(_dsDetalle.PagosClientesDetalle)
        _taFacturas.Fill(_dsFacturas.Factura)

        _tablaVisual = ConstruirTablaVisual()

        _origen.DataSource = _tablaVisual
        dgvPagos.DataSource = _origen

        ConfigurarGrid()
        ActivarDoubleBuffer(dgvPagos)
        CargarClientesFiltro()
        ActualizarTotales()
        CargarAnios()

        _origen.Sort = "Factura ASC, FechaPago ASC"
    End Sub

    '========================
    ' TABLA VISUAL
    '========================
    Private Function ConstruirTablaVisual() As DataTable

        Dim t As New DataTable()

        '========================
        ' Columnas visuales
        '========================
        t.Columns.Add("FechaPago", GetType(Date))
        t.Columns.Add("IdFiscal", GetType(String))
        t.Columns.Add("Cliente", GetType(String))
        t.Columns.Add("Factura", GetType(String))
        t.Columns.Add("Moneda", GetType(String))
        t.Columns.Add("MontoPagado", GetType(Decimal))
        t.Columns.Add("TotalPagadoFactura", GetType(Decimal))
        t.Columns.Add("TotalFactura", GetType(Decimal))
        t.Columns.Add("BalanceFactura", GetType(Decimal))

        '========================
        ' Clientes por IdFiscal
        '========================
        Dim clientes As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        For Each c As DsClientes.ClientesRow In _dsClientes.Clientes
            Dim id As String = c.Id_Fiscal.Trim()
            If id <> "" AndAlso Not clientes.ContainsKey(id) Then
                clientes(id) = c.Nombre_Cliente.Trim()
            End If
        Next

        '========================
        ' TOTAL ORIGINAL DE FACTURA (SEGÚN MONEDA)
        ' Clave: IdFactura|Moneda
        '========================
        Dim totalFacturaPorKey As New Dictionary(Of String, Decimal)(StringComparer.OrdinalIgnoreCase)

        For Each f As DataRow In _dsFacturas.Factura.Rows

            Dim idFactura As String = f("IdFactura").ToString().Trim()
            Dim moneda As String = f("Moneda").ToString().Trim().ToUpper()

            Dim totalFactura As Decimal = 0D

            If moneda = "US$" OrElse moneda = "USD" Then
                totalFactura = Convert.ToDecimal(f("TotalUS$"))
            ElseIf moneda = "RDS" OrElse moneda = "RD$" Then
                totalFactura = Convert.ToDecimal(f("TotalRDS"))
            End If

            Dim key As String = idFactura & "|" & moneda
            If Not totalFacturaPorKey.ContainsKey(key) Then
                totalFacturaPorKey(key) = totalFactura
            End If
        Next

        '========================
        ' Pagos por cobro
        '========================
        Dim pagosPorCobro As New Dictionary(Of String, DsPagosClientes.PagosClientesRow)(StringComparer.OrdinalIgnoreCase)
        For Each p As DsPagosClientes.PagosClientesRow In _dsPagos.PagosClientes
            pagosPorCobro(p.ID_Cobro.Trim()) = p
        Next

        '========================
        ' Construir filas base
        '========================
        For Each d As DsPagosClientesDetalle.PagosClientesDetalleRow In _dsDetalle.PagosClientesDetalle

            Dim pago As DsPagosClientes.PagosClientesRow = Nothing
            pagosPorCobro.TryGetValue(d.ID_Cobro.Trim(), pago)

            Dim monedaDetalle As String = d.Moneda.Trim()
            Dim monedaPago As String = If(pago IsNot Nothing, pago.Moneda.Trim(), "")
            Dim monedaFinal As String =
            If(monedaDetalle <> "", monedaDetalle,
               If(monedaPago <> "", monedaPago, "RDS"))

            Dim idFiscal As String = If(pago IsNot Nothing, pago.Id_Fiscal.Trim(), "")
            Dim cliente As String = If(clientes.ContainsKey(idFiscal), clientes(idFiscal), "")

            Dim monto As Decimal =
            If(d("TotalPagado") Is DBNull.Value, 0D, Convert.ToDecimal(d("TotalPagado")))

            t.Rows.Add(
            If(pago IsNot Nothing, pago.Fecha, d.Fecha),
            idFiscal,
            cliente,
            d.IdFactura.Trim(),
            monedaFinal,
            monto,
            0D,
            0D,
            0D
        )
        Next

        '========================
        ' TOTAL PAGADO POR FACTURA + MONEDA
        '========================
        Dim totalPagadoPorKey As New Dictionary(Of String, Decimal)(StringComparer.OrdinalIgnoreCase)

        For Each r As DataRow In t.Rows

            Dim factura As String = r("Factura").ToString().Trim()
            Dim moneda As String = r("Moneda").ToString().Trim().ToUpper()
            Dim monto As Decimal = Convert.ToDecimal(r("MontoPagado"))

            ' Pagos sin factura NO se agrupan
            If factura = "" OrElse factura.Equals("Sin Factura", StringComparison.OrdinalIgnoreCase) Then
                r("TotalPagadoFactura") = monto
                r("TotalFactura") = 0D
                r("BalanceFactura") = 0D
                Continue For
            End If

            Dim key As String = factura & "|" & moneda
            If Not totalPagadoPorKey.ContainsKey(key) Then
                totalPagadoPorKey(key) = 0D
            End If
            totalPagadoPorKey(key) += monto
        Next

        '========================
        ' ASIGNAR TOTAL FACTURA Y BALANCE
        '========================
        For Each r As DataRow In t.Rows

            Dim factura As String = r("Factura").ToString().Trim()
            If factura = "" OrElse factura.Equals("Sin Factura", StringComparison.OrdinalIgnoreCase) Then Continue For

            Dim moneda As String = r("Moneda").ToString().Trim().ToUpper()
            Dim key As String = factura & "|" & moneda

            Dim totalPagado As Decimal =
            If(totalPagadoPorKey.ContainsKey(key), totalPagadoPorKey(key), 0D)

            Dim totalFactura As Decimal =
            If(totalFacturaPorKey.ContainsKey(key), totalFacturaPorKey(key), 0D)

            r("TotalPagadoFactura") = totalPagado
            r("TotalFactura") = totalFactura
            r("BalanceFactura") = totalFactura - totalPagado
        Next

        Return t
    End Function

    '========================
    ' FILTROS
    '========================
    Private Sub CargarClientesFiltro()

        Dim tablaFiltro As New DataTable()
        tablaFiltro.Columns.Add("IdFiscal", GetType(String))
        tablaFiltro.Columns.Add("Cliente", GetType(String))
        tablaFiltro.Rows.Add("", "Todos")

        For Each r As DataRow In _tablaVisual.DefaultView.
            ToTable(True, "IdFiscal", "Cliente").
            Select("Cliente <> ''", "Cliente ASC")

            tablaFiltro.ImportRow(r)
        Next

        cmbClientes.DataSource = tablaFiltro
        cmbClientes.DisplayMember = "Cliente"
        cmbClientes.ValueMember = "IdFiscal"
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub txtFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFactura.KeyDown
        If e.KeyCode = Keys.Enter Then AplicarFiltros()
    End Sub

    Private Sub btnLimpiar_Click(
    sender As Object,
    e As EventArgs
) Handles btnLimpiar.Click

        cmbClientes.SelectedIndex = 0
        cmbAnio.SelectedIndex = 0
        txtFactura.Clear()

        _origen.RemoveFilter()
        ActualizarTotales()

    End Sub

    Private Sub AplicarFiltros()

        Dim filtros As New List(Of String)

        ' ======================
        ' FILTRO CLIENTE
        ' ======================
        If cmbClientes.SelectedValue IsNot Nothing AndAlso
       cmbClientes.SelectedValue.ToString() <> "" Then

            filtros.Add($"IdFiscal = '{cmbClientes.SelectedValue}'")
        End If

        ' ======================
        ' FILTRO FACTURA
        ' ======================
        If txtFactura.Text.Trim().Length >= 3 Then
            filtros.Add($"Factura LIKE '%{txtFactura.Text.Trim().Replace("'", "''")}%'")
        End If

        ' ======================
        ' FILTRO AÑO (CORRECTO – SIN YEAR)
        ' ======================
        If cmbAnio.SelectedItem IsNot Nothing AndAlso
       TypeOf cmbAnio.SelectedItem Is DataRowView Then

            Dim drv As DataRowView = CType(cmbAnio.SelectedItem, DataRowView)

            If Not IsDBNull(drv("Anio")) Then

                Dim anio As Integer = Convert.ToInt32(drv("Anio"))

                If anio > 0 Then
                    Dim desde As Date = New Date(anio, 1, 1)
                    Dim hasta As Date = New Date(anio + 1, 1, 1)

                    filtros.Add(
                    $"FechaPago >= #{desde:MM/dd/yyyy}# AND FechaPago < #{hasta:MM/dd/yyyy}#"
                )
                End If

            End If
        End If

        _origen.Filter = String.Join(" AND ", filtros)
        ActualizarTotales()

    End Sub

    '========================
    ' TOTALES POR MONEDA
    '========================
    Private Sub ActualizarTotales()

        Dim totales As New Dictionary(Of String, Decimal)
        Dim totalGeneral As Decimal = 0D

        For Each r As DataRowView In _origen

            Dim moneda As String = r("Moneda").ToString()
            Dim monto As Decimal = Convert.ToDecimal(r("MontoPagado"))

            totalGeneral += monto
            If Not totales.ContainsKey(moneda) Then totales(moneda) = 0D
            totales(moneda) += monto
        Next

        lblTotal.Text = $"Total general: {totalGeneral:#,##0.00}"
        lblTotalesPorMoneda.Text =
            String.Join(" | ", totales.Select(Function(x) $"{x.Key}: {x.Value:#,##0.00}"))
    End Sub

    '========================
    ' GRID
    '========================
    Private Sub ConfigurarGrid()
        With dgvPagos
            .Columns("MontoPagado").DefaultCellStyle.Format = "#,##0.00"
            .Columns("TotalPagadoFactura").DefaultCellStyle.Format = "#,##0.00"
            .Columns("TotalFactura").DefaultCellStyle.Format = "#,##0.00"
            .Columns("BalanceFactura").DefaultCellStyle.Format = "#,##0.00"

            .Columns("MontoPagado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("TotalPagadoFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("TotalFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("BalanceFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub




    Private Sub dgvPagos_CellFormatting(
        sender As Object,
        e As DataGridViewCellFormattingEventArgs
    ) Handles dgvPagos.CellFormatting

        If dgvPagos.Columns(e.ColumnIndex).Name = "BalanceFactura" AndAlso
           e.Value IsNot Nothing AndAlso Convert.ToDecimal(e.Value) > 0D Then

            e.CellStyle.ForeColor = Color.Red
            e.CellStyle.Font = New Font(dgvPagos.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub ActivarDoubleBuffer(grid As DataGridView)
        Dim p = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance)
        p.SetValue(grid, True, Nothing)
    End Sub
    Private Sub CargarAnios()

        Dim tablaAnios As New DataTable()
        tablaAnios.Columns.Add("Anio", GetType(Integer))

        ' Opción "Todos"
        tablaAnios.Rows.Add(0)

        Dim anios = _tablaVisual.AsEnumerable().
            Select(Function(r) r.Field(Of Date)("FechaPago").Year).
            Distinct().
            OrderByDescending(Function(y) y)

        For Each y In anios
            tablaAnios.Rows.Add(y)
        Next

        cmbAnio.DataSource = tablaAnios
        cmbAnio.DisplayMember = "Anio"
        cmbAnio.ValueMember = "Anio"
    End Sub
    Private Sub cmbAnio_SelectedIndexChanged(
    sender As Object,
    e As EventArgs
) Handles cmbAnio.SelectedIndexChanged

        AplicarFiltros()

    End Sub

    Private Sub BtnFacturas_Click(sender As Object, e As EventArgs) Handles BtnFacturas.Click
        Dim frm As New FrmFacturasResumen(_tablaVisual)
        frm.ShowDialog(Me)
    End Sub
End Class