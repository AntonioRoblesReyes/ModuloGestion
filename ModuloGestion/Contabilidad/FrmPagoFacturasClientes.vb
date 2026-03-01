Imports System.Globalization

Public Class FrmPagoFacturasClientes
    Inherits Form

    Private ReadOnly _grid As New DataGridView()
    Private ReadOnly _cmbClientes As New ComboBox()
    Private ReadOnly _txtFactura As New TextBox()
    Private ReadOnly _lblTotal As New Label()
    Private ReadOnly _origen As New BindingSource()

    Private ReadOnly _dsPagos As New DsPagosClientes()
    Private ReadOnly _dsDetalle As New DsPagosClientesDetalle()
    Private ReadOnly _dsClientes As New DsClientes()

    Private ReadOnly _taPagos As New DsPagosClientesTableAdapters.PagosClientesTableAdapter()
    Private ReadOnly _taDetalle As New DsPagosClientesDetalleTableAdapters.PagosClientesDetalleTableAdapter()
    Private ReadOnly _taClientes As New DsClientesTableAdapters.ClientesTableAdapter()

    Public Sub New()
        Me.Text = "Pagos de facturas por cliente"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Width = 1200
        Me.Height = 700

        ConstruirInterfaz()
        AddHandler Me.Load, AddressOf FrmPagoFacturasClientes_Load
    End Sub

    Private Sub ConstruirInterfaz()
        Dim panelSuperior As New FlowLayoutPanel() With {
            .Dock = DockStyle.Top,
            .AutoSize = True,
            .Padding = New Padding(10),
            .WrapContents = True
        }

        panelSuperior.Controls.Add(New Label() With {.Text = "Cliente:", .AutoSize = True, .Margin = New Padding(0, 8, 6, 0)})

        _cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList
        _cmbClientes.Width = 300
        AddHandler _cmbClientes.SelectedIndexChanged, AddressOf FiltrosCambiaron
        panelSuperior.Controls.Add(_cmbClientes)

        panelSuperior.Controls.Add(New Label() With {.Text = "Factura:", .AutoSize = True, .Margin = New Padding(20, 8, 6, 0)})

        _txtFactura.Width = 180
        AddHandler _txtFactura.TextChanged, AddressOf FiltrosCambiaron
        panelSuperior.Controls.Add(_txtFactura)

        Dim btnLimpiar As New Button() With {.Text = "Limpiar filtros", .AutoSize = True, .Margin = New Padding(20, 3, 0, 3)}
        AddHandler btnLimpiar.Click,
            Sub()
                _cmbClientes.SelectedIndex = 0
                _txtFactura.Clear()
            End Sub
        panelSuperior.Controls.Add(btnLimpiar)

        _grid.Dock = DockStyle.Fill
        _grid.ReadOnly = True
        _grid.AllowUserToAddRows = False
        _grid.AllowUserToDeleteRows = False
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        _grid.MultiSelect = False

        Dim panelInferior As New Panel() With {.Dock = DockStyle.Bottom, .Height = 40}
        _lblTotal.Dock = DockStyle.Right
        _lblTotal.AutoSize = True
        _lblTotal.Padding = New Padding(0, 10, 10, 0)
        panelInferior.Controls.Add(_lblTotal)

        Me.Controls.Add(_grid)
        Me.Controls.Add(panelInferior)
        Me.Controls.Add(panelSuperior)
    End Sub

    Private Sub FrmPagoFacturasClientes_Load(sender As Object, e As EventArgs)
        _taClientes.Fill(_dsClientes.Clientes)
        _taPagos.Fill(_dsPagos.PagosClientes)
        _taDetalle.Fill(_dsDetalle.PagosClientesDetalle)

        Dim tabla As DataTable = ConstruirTablaVisual()
        _origen.DataSource = tabla
        _grid.DataSource = _origen

        CargarClientesEnFiltro(tabla)
        ActualizarTotal()
    End Sub

    Private Function ConstruirTablaVisual() As DataTable
        Dim resultado As New DataTable("PagosFacturaCliente")

        resultado.Columns.Add("FechaPago", GetType(Date))
        resultado.Columns.Add("IdFiscal", GetType(String))
        resultado.Columns.Add("Cliente", GetType(String))
        resultado.Columns.Add("Factura", GetType(String))
        resultado.Columns.Add("Presupuesto", GetType(String))
        resultado.Columns.Add("Moneda", GetType(String))
        resultado.Columns.Add("FormaPago", GetType(String))
        resultado.Columns.Add("MontoPagado", GetType(Decimal))
        resultado.Columns.Add("Cobro", GetType(String))

        Dim clientesPorId As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        For Each filaCliente As DsClientes.ClientesRow In _dsClientes.Clientes.Rows
            Dim idFiscal As String = ValorTextoSeguro(filaCliente("Id_Fiscal"))
            If idFiscal = "" Then Continue For

            If Not clientesPorId.ContainsKey(idFiscal) Then
                clientesPorId(idFiscal) = ValorTextoSeguro(filaCliente("Nombre_Cliente"))
            End If
        Next

        Dim pagoPorCobro As New Dictionary(Of String, DsPagosClientes.PagosClientesRow)(StringComparer.OrdinalIgnoreCase)
        For Each filaPago As DsPagosClientes.PagosClientesRow In _dsPagos.PagosClientes.Rows
            Dim idCobro As String = ValorTextoSeguro(filaPago("ID_Cobro"))
            If idCobro = "" Then Continue For
            If Not pagoPorCobro.ContainsKey(idCobro) Then
                pagoPorCobro(idCobro) = filaPago
            End If
        Next

        For Each filaDetalle As DsPagosClientesDetalle.PagosClientesDetalleRow In _dsDetalle.PagosClientesDetalle.Rows
            Dim idCobro As String = ValorTextoSeguro(filaDetalle("ID_Cobro"))
            Dim filaPago As DsPagosClientes.PagosClientesRow = Nothing
            If idCobro <> "" AndAlso pagoPorCobro.ContainsKey(idCobro) Then
                filaPago = pagoPorCobro(idCobro)
            End If

            Dim idFiscal As String = ""
            Dim cliente As String = ""
            Dim moneda As String = ValorTextoSeguro(filaDetalle("Moneda"))
            Dim formaPago As String = ""
            Dim fechaPago As Date = Date.Today

            If filaPago IsNot Nothing Then
                idFiscal = ValorTextoSeguro(filaPago("Id_Fiscal"))
                formaPago = ValorTextoSeguro(filaPago("FormaDePago"))
                moneda = If(moneda = "", ValorTextoSeguro(filaPago("Moneda")), moneda)
                fechaPago = CType(filaPago("Fecha"), Date)
            ElseIf Not filaDetalle.IsFechaNull() Then
                fechaPago = filaDetalle.Fecha
            End If

            If idFiscal <> "" AndAlso clientesPorId.ContainsKey(idFiscal) Then
                cliente = clientesPorId(idFiscal)
            End If

            Dim nueva As DataRow = resultado.NewRow()
            nueva("FechaPago") = fechaPago
            nueva("IdFiscal") = idFiscal
            nueva("Cliente") = cliente
            nueva("Factura") = ValorTextoSeguro(filaDetalle("IdFactura"))
            nueva("Presupuesto") = ValorTextoSeguro(filaDetalle("Id_Presupuesto"))
            nueva("Moneda") = moneda
            nueva("FormaPago") = formaPago
            nueva("MontoPagado") = If(filaDetalle.IsTotalPagadoNull(), 0D, filaDetalle.TotalPagado)
            nueva("Cobro") = idCobro

            resultado.Rows.Add(nueva)
        Next

        Return resultado
    End Function

    Private Sub CargarClientesEnFiltro(tabla As DataTable)
        Dim vista As DataView = tabla.DefaultView
        Dim clientes As DataTable = vista.ToTable(True, "IdFiscal", "Cliente")

        Dim tablaFiltro As New DataTable()
        tablaFiltro.Columns.Add("IdFiscal", GetType(String))
        tablaFiltro.Columns.Add("Cliente", GetType(String))
        tablaFiltro.Rows.Add("", "Todos")

        For Each fila As DataRow In clientes.Select("Cliente <> ''", "Cliente ASC")
            tablaFiltro.ImportRow(fila)
        Next

        _cmbClientes.DataSource = tablaFiltro
        _cmbClientes.DisplayMember = "Cliente"
        _cmbClientes.ValueMember = "IdFiscal"
    End Sub

    Private Sub FiltrosCambiaron(sender As Object, e As EventArgs)
        Dim filtros As New List(Of String)()

        Dim idFiscal As String = ""
        If _cmbClientes.SelectedValue IsNot Nothing Then
            idFiscal = _cmbClientes.SelectedValue.ToString().Trim()
        End If

        If idFiscal <> "" Then
            filtros.Add($"IdFiscal = '{idFiscal.Replace("'", "''")}'")
        End If

        Dim factura As String = _txtFactura.Text.Trim()
        If factura <> "" Then
            filtros.Add($"Factura LIKE '%{factura.Replace("'", "''")}%'")
        End If

        _origen.Filter = String.Join(" AND ", filtros)
        ActualizarTotal()
    End Sub

    Private Sub ActualizarTotal()
        Dim total As Decimal = 0D

        For Each item As Object In _origen.List
            Dim vista As DataRowView = TryCast(item, DataRowView)
            If vista Is Nothing Then Continue For
            total += Convert.ToDecimal(vista("MontoPagado"), CultureInfo.InvariantCulture)
        Next

        _lblTotal.Text = $"Total mostrado: {total:#,##0.00}"
    End Sub

    Private Function ValorTextoSeguro(valor As Object) As String
        If valor Is Nothing OrElse valor Is DBNull.Value Then Return ""
        Return valor.ToString().Trim()
    End Function
End Class
