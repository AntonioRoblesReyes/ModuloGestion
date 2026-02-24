Imports System.Globalization
Imports System.IO

Public Class FrmCobros

    '=========================================================
    ' Constantes de nombres de columnas (ajústalas si difieren)
    '=========================================================
    Private Const COL_FECHA As String = "Fecha"
    Private Const COL_MONEDA As String = "Moneda"
    Private Const COL_MONTO As String = "Asignado" ' o el campo real que trae el monto base (antes usabas Cells(4))
    Private Const COL_RD As String = "RD"
    Private Const COL_US As String = "US"
    Private Const COL_ID_COBRO As String = "ID_Cobro"

    ' Evitar re-entradas al cambiar combos
    Private _cargandoCombos As Boolean = False

    '=========================================================
    ' LOAD
    '=========================================================
    Private Sub FrmCobros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.PagosClientesDetalleTableAdapter.Fill(Me.DsPagosClientesDetalle.PagosClientesDetalle)
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)

        _cargandoCombos = True
        LlenarComboAñoDesdeData()
        LlenarComboMesDesdeData() ' arranca en "Todos"
        _cargandoCombos = False

        AplicarFiltro()          ' filtro inicial (Todos/Todos)
        RecalcularMonedaYTotales()
        SincronizarDetalleConSeleccion()
    End Sub

    '=========================================================
    ' SAVE
    '=========================================================
    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PagosClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)
    End Sub

    '=========================================================
    ' IMPRIMIR
    '=========================================================
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim idCobro As String = ObtenerIdCobroActual()
        If String.IsNullOrWhiteSpace(idCobro) Then
            MessageBox.Show("No hay un cobro seleccionado para imprimir.", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        My.Forms.InfReciboImgresos.Close()
        My.Forms.InfReciboImgresos.Label1.Text = idCobro
        My.Forms.InfReciboImgresos.Show()
        My.Forms.InfReciboImgresos.Imprimir()
    End Sub

    Private Sub FrmCobros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

    '=========================================================
    ' EVENTOS GRID
    '=========================================================
    Private Sub PagosClientesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PagosClientesDataGridView.CellClick
        SincronizarDetalleConSeleccion()
    End Sub

    '=========================================================
    ' EVENTOS FILTROS
    '=========================================================
    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged
        If _cargandoCombos Then Return

        _cargandoCombos = True
        LlenarComboMesDesdeData() ' meses disponibles según año
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
    ' FILTRO PROFESIONAL (BindingSource.Filter)
    '=========================================================
    Private Sub AplicarFiltro()
        Dim bs As BindingSource = PagosClientesBindingSource
        If bs Is Nothing Then Return

        Dim año As Integer
        If cmbAño.Text = "Todos" OrElse Not Integer.TryParse(cmbAño.Text, año) Then
            bs.RemoveFilter()
            Return
        End If

        Dim desde As Date = New Date(año, 1, 1)
        Dim hasta As Date = New Date(año + 1, 1, 1)

        bs.Filter = $"[{COL_FECHA}] >= #{desde:MM/dd/yyyy}# AND [{COL_FECHA}] < #{hasta:MM/dd/yyyy}#"
    End Sub


    Private Function ConstruirFiltro() As String
        Dim partes As New List(Of String)

        Dim año As String = cmbAño.Text.Trim()
        Dim mes As String = cmbMes.Text.Trim()

        If año <> "Todos" AndAlso Integer.TryParse(año, Nothing) Then
            ' DataViewRowFilter soporta Year()
            partes.Add($"Year([{COL_FECHA}]) = {año}")
        End If

        If mes <> "Todos" Then
            Dim mesNumero As Integer = MesNombreANumero(mes)
            If mesNumero >= 1 AndAlso mesNumero <= 12 Then
                partes.Add($"Month([{COL_FECHA}]) = {mesNumero}")
            End If
        End If

        Return String.Join(" AND ", partes)
    End Function

    Private Function MesNombreANumero(nombreMes As String) As Integer
        If String.IsNullOrWhiteSpace(nombreMes) Then Return 0

        ' Acepta nombres en español o inglés, y mayúsculas/minúsculas.
        Dim n As String = nombreMes.Trim().ToLowerInvariant()

        Select Case n
            Case "enero", "january" : Return 1
            Case "febrero", "february" : Return 2
            Case "marzo", "march" : Return 3
            Case "abril", "april" : Return 4
            Case "mayo", "may" : Return 5
            Case "junio", "june" : Return 6
            Case "julio", "july" : Return 7
            Case "agosto", "august" : Return 8
            Case "septiembre", "setiembre", "september" : Return 9
            Case "octubre", "october" : Return 10
            Case "noviembre", "november" : Return 11
            Case "diciembre", "december" : Return 12
        End Select

        Return 0
    End Function

    '=========================================================
    ' RECALCULO DE RD/US + TOTALES (sin Val, sin indices)
    '=========================================================
    Private Sub RecalcularMonedaYTotales()
        If PagosClientesDataGridView Is Nothing OrElse PagosClientesDataGridView.Rows.Count = 0 Then
            Label2.Text = "0.00"
            Label4.Text = "0.00"
            Return
        End If

        Dim totalRD As Decimal = 0D
        Dim totalUS As Decimal = 0D

        For Each row As DataGridViewRow In PagosClientesDataGridView.Rows
            If row.IsNewRow Then Continue For

            ' Monto base
            Dim monto As Decimal = ObtenerDecimal(row.Cells(COL_MONTO)?.Value)

            ' Moneda normalizada
            Dim moneda As String = NormalizarMoneda(ObtenerTexto(row.Cells(COL_MONEDA)?.Value))

            Dim rd As Decimal = 0D
            Dim us As Decimal = 0D

            If moneda = "RD" Then
                rd = monto
            ElseIf moneda = "US" Then
                us = monto
            Else
                ' Si viene vacío/extraño, lo tratamos como 0/0 (y no rompemos nada)
                rd = 0D
                us = 0D
            End If

            ' Escribir en columnas (si existen)
            If PagosClientesDataGridView.Columns.Contains(COL_RD) Then row.Cells(COL_RD).Value = rd
            If PagosClientesDataGridView.Columns.Contains(COL_US) Then row.Cells(COL_US).Value = us

            totalRD += rd
            totalUS += us
        Next

        Label2.Text = totalRD.ToString("#,##0.00")
        Label4.Text = totalUS.ToString("#,##0.00")
    End Sub

    Private Function NormalizarMoneda(valor As String) As String
        If String.IsNullOrWhiteSpace(valor) Then Return ""

        Dim v As String = valor.Trim().ToUpperInvariant()

        ' Acepta variantes reales
        If v.Contains("RD") Then Return "RD"
        If v.Contains("US") OrElse v.Contains("USD") OrElse v.Contains("$") Then Return "US"

        Return v
    End Function

    Private Function ObtenerTexto(v As Object) As String
        If v Is Nothing OrElse v Is DBNull.Value Then Return ""
        Return v.ToString()
    End Function

    Private Function ObtenerDecimal(v As Object) As Decimal
        If v Is Nothing OrElse v Is DBNull.Value Then Return 0D

        If TypeOf v Is Decimal Then Return DirectCast(v, Decimal)
        If TypeOf v Is Double Then Return CDec(DirectCast(v, Double))
        If TypeOf v Is Single Then Return CDec(DirectCast(v, Single))
        If TypeOf v Is Integer Then Return CDec(DirectCast(v, Integer))
        If TypeOf v Is Long Then Return CDec(DirectCast(v, Long))

        Dim s As String = v.ToString().Trim()
        If s = "" Then Return 0D

        ' Intento con cultura actual y con Invariant
        Dim d As Decimal
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, d) Then Return d
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then Return d

        ' Último intento: limpiar separadores comunes
        s = s.Replace(" ", "").Replace("RD$", "").Replace("US$", "").Replace("$", "")
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, d) Then Return d
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then Return d

        Return 0D
    End Function

    '=========================================================
    ' DETALLE: SINCRONIZAR + VALIDAR CUADRE
    '=========================================================
    Private Sub SincronizarDetalleConSeleccion()
        Dim idCobro As String = ObtenerIdCobroActual()

        If String.IsNullOrWhiteSpace(idCobro) Then
            LimpiarDetalle()
            Return
        End If

        Me.PagosClientesDetalleTableAdapter.FillByIdCobro(Me.DsPagosClientesDetalle.PagosClientesDetalle, idCobro)

        ' sumar detalle
        Dim totalDetalle As Decimal = 0D
        For Each row As DataGridViewRow In Me.PagosClientesDetalleDataGridView.Rows
            If row.IsNewRow Then Continue For
            totalDetalle += ObtenerDecimal(row.Cells("TotalPagado")?.Value) ' Ajusta si tu columna se llama diferente
        Next

        Label5.Text = totalDetalle.ToString("#,##0.00")

        ' comparar con monto del cobro
        Dim montoCobro As Decimal = ObtenerMontoCobroActual()
        If Math.Round(montoCobro, 2) <> Math.Round(totalDetalle, 2) Then
            ' Feedback no intrusivo (puedes cambiar color/label)
            MessageBox.Show("⚠ El registro no cuadra: el total del detalle no coincide con el total del cobro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ObtenerIdCobroActual() As String
        ' Preferir la grilla (porque está ya filtrada)
        If PagosClientesDataGridView.CurrentRow IsNot Nothing AndAlso Not PagosClientesDataGridView.CurrentRow.IsNewRow Then
            If PagosClientesDataGridView.Columns.Contains(COL_ID_COBRO) Then
                Return ObtenerTexto(PagosClientesDataGridView.CurrentRow.Cells(COL_ID_COBRO).Value)
            End If
        End If

        ' Fallback: BindingSource
        If PagosClientesBindingSource IsNot Nothing AndAlso PagosClientesBindingSource.Current IsNot Nothing Then
            Dim drv As DataRowView = TryCast(PagosClientesBindingSource.Current, DataRowView)
            If drv IsNot Nothing AndAlso drv.Row.Table.Columns.Contains(COL_ID_COBRO) Then
                Return ObtenerTexto(drv(COL_ID_COBRO))
            End If
        End If

        Return ""
    End Function

    Private Function ObtenerMontoCobroActual() As Decimal
        If PagosClientesDataGridView.CurrentRow Is Nothing OrElse PagosClientesDataGridView.CurrentRow.IsNewRow Then Return 0D
        If Not PagosClientesDataGridView.Columns.Contains(COL_MONTO) Then Return 0D
        Return ObtenerDecimal(PagosClientesDataGridView.CurrentRow.Cells(COL_MONTO).Value)
    End Function

    Private Sub LimpiarDetalle()
        PagosClientesDetalleDataGridView.DataSource = Nothing
        Label5.Text = "0.00"
    End Sub

    '=========================================================
    ' COMBOS (desde DATA, no desde filas visibles)
    '=========================================================
    Private Sub LlenarComboAñoDesdeData()
        Dim años As New HashSet(Of Integer)

        Dim dt As DataTable = Nothing
        Dim dv As DataView = TryCast(PagosClientesBindingSource.List, DataView)
        If dv IsNot Nothing Then dt = dv.Table
        If dt Is Nothing AndAlso DsPagosClientes IsNot Nothing Then dt = DsPagosClientes.PagosClientes

        If dt Is Nothing OrElse Not dt.Columns.Contains(COL_FECHA) Then
            cmbAño.Items.Clear()
            cmbAño.Items.Add("Todos")
            cmbAño.SelectedIndex = 0
            Return
        End If

        For Each r As DataRow In dt.Rows
            If r.IsNull(COL_FECHA) Then Continue For
            Dim fecha As DateTime
            If DateTime.TryParse(r(COL_FECHA).ToString(), fecha) Then
                años.Add(fecha.Year)
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
        ' Meses disponibles según año seleccionado (pero leyendo desde DATA, no desde Visible rows)
        Dim año As String = cmbAño.Text.Trim()
        Dim meses As New HashSet(Of Integer)

        Dim dt As DataTable = Nothing
        Dim dv As DataView = TryCast(PagosClientesBindingSource.List, DataView)
        If dv IsNot Nothing Then dt = dv.Table
        If dt Is Nothing AndAlso DsPagosClientes IsNot Nothing Then dt = DsPagosClientes.PagosClientes

        If dt Is Nothing OrElse Not dt.Columns.Contains(COL_FECHA) Then
            cmbMes.Items.Clear()
            cmbMes.Items.Add("Todos")
            cmbMes.SelectedIndex = 0
            Return
        End If

        For Each r As DataRow In dt.Rows
            If r.IsNull(COL_FECHA) Then Continue For
            Dim f As DateTime
            If Not DateTime.TryParse(r(COL_FECHA).ToString(), f) Then Continue For

            If año <> "Todos" AndAlso f.Year.ToString() <> año Then Continue For
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
