Imports System.Globalization
Imports System.IO

Public Class FrmCobros

    '=========================================================
    ' CONSTANTES DE COLUMNAS (AJUSTA SI ALGÚN NOMBRE CAMBIA)
    '=========================================================
    Private Const COL_FECHA As String = "Fecha"
    Private Const COL_MONEDA As String = "Moneda"
    Private Const COL_MONTO As String = "Asignado"
    Private Const COL_RD As String = "RD"
    Private Const COL_US As String = "US"
    Private Const COL_ID_COBRO As String = "ID_Cobro"

    Private _cargandoCombos As Boolean = False

    '=========================================================
    ' LOAD
    '=========================================================
    Private Sub FrmCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.PagosClientesDetalleTableAdapter.Fill(Me.DsPagosClientesDetalle.PagosClientesDetalle)
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)

        _cargandoCombos = True
        LlenarComboAñoDesdeData()
        LlenarComboMesDesdeData()
        _cargandoCombos = False

        AplicarFiltro()
        RecalcularMonedaYTotales()
        SincronizarDetalleConSeleccion()
    End Sub

    '=========================================================
    ' GUARDAR
    '=========================================================
    Private Sub PagosClientesBindingNavigatorSaveItem_Click(
        sender As Object,
        e As EventArgs
    ) Handles PagosClientesBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub

    '=========================================================
    ' EVENTOS GRID
    '=========================================================
    Private Sub PagosClientesDataGridView_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles PagosClientesDataGridView.CellClick

        SincronizarDetalleConSeleccion()

    End Sub

    '=========================================================
    ' EVENTOS FILTROS
    '=========================================================
    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged
        If _cargandoCombos Then Return

        _cargandoCombos = True
        LlenarComboMesDesdeData()
        _cargandoCombos = False

        AplicarFiltro()
        RecalcularMonedaYTotales()
        SincronizarDetalleConSeleccion()
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        If _cargandoCombos Then Return

        AplicarFiltro()
        RecalcularMonedaYTotales()
        SincronizarDetalleConSeleccion()
    End Sub

    '=========================================================
    ' FILTRO (BindingSource.Filter)
    '=========================================================
    Private Sub AplicarFiltro()

        Dim bs As BindingSource = PagosClientesBindingSource
        If bs Is Nothing Then Return

        ' Si es "Todos", quitamos filtros
        If cmbAño.Text = "Todos" AndAlso cmbMes.Text = "Todos" Then
            bs.RemoveFilter()
            Return
        End If

        Dim filtros As New List(Of String)

        ' ======================
        ' FILTRO POR AÑO
        ' ======================
        Dim año As Integer
        If cmbAño.Text <> "Todos" AndAlso Integer.TryParse(cmbAño.Text, año) Then

            Dim desde As Date = New Date(año, 1, 1)
            Dim hasta As Date = New Date(año + 1, 1, 1)

            filtros.Add(
            $"[{COL_FECHA}] >= #{desde:MM/dd/yyyy}# AND [{COL_FECHA}] < #{hasta:MM/dd/yyyy}#"
        )

        End If

        ' ======================
        ' FILTRO POR MES
        ' ======================
        If cmbMes.Text <> "Todos" Then

            Dim mes As Integer = MesNombreANumero(cmbMes.Text)
            If mes > 0 AndAlso Integer.TryParse(cmbAño.Text, año) Then

                Dim desdeMes As Date = New Date(año, mes, 1)
                Dim hastaMes As Date = desdeMes.AddMonths(1)

                filtros.Clear() ' el mes ya incluye el año
                filtros.Add(
                $"[{COL_FECHA}] >= #{desdeMes:MM/dd/yyyy}# AND [{COL_FECHA}] < #{hastaMes:MM/dd/yyyy}#"
            )

            End If

        End If

        bs.Filter = String.Join(" AND ", filtros)

    End Sub

    Private Function MesNombreANumero(nombreMes As String) As Integer
        Select Case nombreMes.Trim().ToLowerInvariant()
            Case "enero" : Return 1
            Case "febrero" : Return 2
            Case "marzo" : Return 3
            Case "abril" : Return 4
            Case "mayo" : Return 5
            Case "junio" : Return 6
            Case "julio" : Return 7
            Case "agosto" : Return 8
            Case "septiembre", "setiembre" : Return 9
            Case "octubre" : Return 10
            Case "noviembre" : Return 11
            Case "diciembre" : Return 12
        End Select
        Return 0
    End Function

    '=========================================================
    ' RECALCULO RD / US Y TOTALES
    '=========================================================
    Private Sub RecalcularMonedaYTotales()

        Dim totalRD As Decimal = 0D
        Dim totalUS As Decimal = 0D

        For Each row As DataGridViewRow In PagosClientesDataGridView.Rows
            If row.IsNewRow Then Continue For

            Dim monto As Decimal = ObtenerDecimal(row.Cells(COL_MONTO)?.Value)
            Dim moneda As String = NormalizarMoneda(row.Cells(COL_MONEDA)?.Value)

            Dim rd As Decimal = 0D
            Dim us As Decimal = 0D

            If moneda = "RD" Then rd = monto
            If moneda = "US" Then us = monto

            If PagosClientesDataGridView.Columns.Contains(COL_RD) Then row.Cells(COL_RD).Value = rd
            If PagosClientesDataGridView.Columns.Contains(COL_US) Then row.Cells(COL_US).Value = us

            totalRD += rd
            totalUS += us
        Next

        Label2.Text = totalRD.ToString("N2")
        Label4.Text = totalUS.ToString("N2")

    End Sub

    Private Function NormalizarMoneda(valor As Object) As String
        If valor Is Nothing OrElse valor Is DBNull.Value Then Return ""

        Dim v As String = valor.ToString().Trim().ToUpperInvariant()

        If v.Contains("RD") Then Return "RD"
        If v.Contains("US") OrElse v.Contains("USD") OrElse v.Contains("$") Then Return "US"

        Return ""
    End Function

    Private Function ObtenerDecimal(valor As Object) As Decimal
        If valor Is Nothing OrElse valor Is DBNull.Value Then Return 0D

        Dim s As String = valor.ToString().Trim()
        If s = "" Then Return 0D

        Dim d As Decimal
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, d) Then Return d
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then Return d

        s = s.Replace("RD$", "").Replace("US$", "").Replace("$", "").Trim()
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, d) Then Return d
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then Return d

        Return 0D
    End Function

    '=========================================================
    ' DETALLE Y VALIDACIÓN
    '=========================================================
    Private Sub SincronizarDetalleConSeleccion()

        Dim idCobro As String = ObtenerIdCobroActual()
        If String.IsNullOrWhiteSpace(idCobro) Then
            PagosClientesDetalleDataGridView.DataSource = Nothing
            Label5.Text = "0.00"
            Return
        End If

        Me.PagosClientesDetalleTableAdapter.FillByIdCobro(
            Me.DsPagosClientesDetalle.PagosClientesDetalle,
            idCobro
        )

        Dim totalDetalle As Decimal = 0D
        For Each row As DataGridViewRow In PagosClientesDetalleDataGridView.Rows
            If row.IsNewRow Then Continue For
            totalDetalle += ObtenerDecimal(row.Cells("TotalPagado")?.Value)
        Next

        Label5.Text = totalDetalle.ToString("N2")

        Dim montoCobro As Decimal = ObtenerDecimal(PagosClientesDataGridView.CurrentRow.Cells(COL_MONTO).Value)
        If Math.Round(montoCobro, 2) <> Math.Round(totalDetalle, 2) Then
            MessageBox.Show(
                "⚠ El total del detalle no cuadra con el cobro.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
        End If

    End Sub

    Private Function ObtenerIdCobroActual() As String
        If PagosClientesDataGridView.CurrentRow Is Nothing Then Return ""
        If PagosClientesDataGridView.CurrentRow.IsNewRow Then Return ""
        Return PagosClientesDataGridView.CurrentRow.Cells(COL_ID_COBRO).Value.ToString()
    End Function

    '=========================================================
    ' COMBOS
    '=========================================================
    Private Sub LlenarComboAñoDesdeData()

        Dim años As New HashSet(Of Integer)
        For Each r As DataRow In DsPagosClientes.PagosClientes.Rows
            If r.IsNull(COL_FECHA) Then Continue For
            Dim f As Date
            If Date.TryParse(r(COL_FECHA).ToString(), f) Then
                años.Add(f.Year)
            End If
        Next

        cmbAño.Items.Clear()
        cmbAño.Items.Add("Todos")
        For Each a In años.OrderBy(Function(x) x)
            cmbAño.Items.Add(a.ToString())
        Next
        cmbAño.SelectedIndex = 0

    End Sub

    Private Sub LlenarComboMesDesdeData()

        Dim meses As New HashSet(Of Integer)
        For Each r As DataRow In DsPagosClientes.PagosClientes.Rows
            If r.IsNull(COL_FECHA) Then Continue For

            Dim f As Date
            If Not Date.TryParse(r(COL_FECHA).ToString(), f) Then Continue For

            If cmbAño.Text <> "Todos" AndAlso f.Year.ToString() <> cmbAño.Text Then Continue For
            meses.Add(f.Month)
        Next

        cmbMes.Items.Clear()
        cmbMes.Items.Add("Todos")
        For Each m In meses.OrderBy(Function(x) x)
            cmbMes.Items.Add(MonthName(m, False))
        Next
        cmbMes.SelectedIndex = 0

    End Sub

End Class