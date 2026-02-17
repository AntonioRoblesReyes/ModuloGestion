
Imports System.IO
Imports System.Globalization

Public Class FrmCobros
    Private ReadOnly MonedasPeso As String() = {"RD$", "RDS", "RD", "DOP"}
    Private ReadOnly MonedasDolar As String() = {"US$", "USS", "US", "USD"}
    Private Const MonedaPeso As String = "RD$"
    Private Const MonedaDolar As String = "US$"

    Sub PagoMoneda()
        Dim totalRD As Decimal = 0D
        Dim totalUS As Decimal = 0D

        For Each row As DataGridViewRow In Me.PagosClientesDataGridView.Rows
            If row.IsNewRow Then Continue For

            Dim valor As Decimal = ObtenerDecimal(row.Cells(4).Value)
            Dim moneda As String = NormalizarMoneda(Convert.ToString(row.Cells(5).Value))

            If MonedasPeso.Contains(moneda) Then
                row.Cells("RD").Value = valor
                row.Cells("US").Value = 0D
            ElseIf MonedasDolar.Contains(moneda) Then
            Dim moneda As String = Convert.ToString(row.Cells(5).Value)

            If moneda = MonedaPeso Then
                row.Cells("RD").Value = valor
                row.Cells("US").Value = 0D
            ElseIf moneda = MonedaDolar Then
                row.Cells("RD").Value = 0D
                row.Cells("US").Value = valor
            Else
                row.Cells("RD").Value = 0D
                row.Cells("US").Value = 0D
            End If

            totalRD += ObtenerDecimal(row.Cells("RD").Value)
            totalUS += ObtenerDecimal(row.Cells("US").Value)
        Next

        Me.Label2.Text = FormatearMonto(totalRD)
        Me.Label4.Text = FormatearMonto(totalUS)
    End Sub

    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PagosClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)
    End Sub

    Private Sub FrmCobros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.PagosClientesDetalleTableAdapter.Fill(Me.DsPagosClientesDetalle.PagosClientesDetalle)
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)

        LlenarComboAño()
        LlenarComboMesPorAño()

        PagoMoneda()
        AplicarEstiloPremium()
        Label5.Visible = True
        Label5.Text = "Seleccione un cobro para validar el detalle."
        Label5.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.InfReciboImgresos.Close()
        My.Forms.InfReciboImgresos.Label1.Text = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro
        My.Forms.InfReciboImgresos.Show()
        My.Forms.InfReciboImgresos.Imprimir()
    End Sub

    Private Sub FrmCobros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

    Private Sub PagosClientesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PagosClientesDataGridView.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim pago As String = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro
        Me.PagosClientesDetalleTableAdapter.FillByIdCobro(Me.DsPagosClientesDetalle.PagosClientesDetalle, pago)

        Dim total As Decimal = 0D
        For Each row As DataGridViewRow In Me.PagosClientesDetalleDataGridView.Rows
            If row.IsNewRow Then Continue For
            total += ObtenerDecimal(row.Cells(4).Value)
        Next

        Me.Label5.Text = "Detalle: " & FormatearMonto(total)

        Dim valorPago As Decimal = ObtenerDecimal(Me.PagosClientesDataGridView.CurrentRow.Cells(4).Value)
        If Math.Abs(valorPago - total) > 0.01D Then
            Me.Label5.Text = "Diferencia detectada: " & FormatearMonto(valorPago - total)
            Me.Label5.ForeColor = Color.FromArgb(176, 42, 55)
        Else
            Me.Label5.Text = "Detalle cuadrado correctamente."
            Me.Label5.ForeColor = Color.FromArgb(25, 135, 84)
        Me.Label5.Text = FormatearMonto(total)

        Dim valorPago As Decimal = ObtenerDecimal(Me.PagosClientesDataGridView.CurrentRow.Cells(4).Value)
        If Math.Abs(valorPago - total) > 0.01D Then
            MsgBox("El cobro seleccionado no cuadra con su detalle. Verifique la asignación.", MsgBoxStyle.Exclamation, "Validación de cobros")
        End If
    End Sub

    Private Sub CmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged
        AplicarFiltroSoloAño()
        LlenarComboMesPorAño()
    End Sub

    Private Sub AplicarFiltroSoloAño()
        Dim añoSeleccionado As String = cmbAño.Text

        AplicarVisibilidadFilas(Function(fecha)
                                   Return (añoSeleccionado = "Todos") OrElse (fecha.Year.ToString() = añoSeleccionado)
                               End Function)

        CalcularTotalesFiltrados()
    End Sub

    Private Sub LlenarComboMesPorAño()
        Dim añoSeleccionado As String = cmbAño.Text
        Dim mesesDisponibles As New HashSet(Of Integer)

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow OrElse Not fila.Visible Then Continue For

            Dim fecha As Date
            If Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) Then
                If añoSeleccionado = "Todos" OrElse fecha.Year.ToString() = añoSeleccionado Then
                    mesesDisponibles.Add(fecha.Month)
                End If
            End If
        Next

        cmbMes.Items.Clear()
        cmbMes.Items.Add("Todos")

        For Each mes As Integer In mesesDisponibles.OrderBy(Function(x) x)
            cmbMes.Items.Add(MonthName(mes, False))
        Next

        cmbMes.SelectedIndex = 0
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        AplicarFiltroAñoYMes()
    End Sub

    Private Sub AplicarFiltroAñoYMes()
        Dim añoSeleccionado As String = cmbAño.Text
        Dim mesSeleccionado As String = cmbMes.Text

        AplicarVisibilidadFilas(Function(fecha)
                                   Dim mostrar As Boolean = True

                                   If añoSeleccionado <> "Todos" AndAlso fecha.Year.ToString() <> añoSeleccionado Then
                                       mostrar = False
                                   End If

                                   If mesSeleccionado <> "Todos" AndAlso MonthName(fecha.Month, False) <> mesSeleccionado Then
                                       mostrar = False
                                   End If

                                   Return mostrar
                               End Function)

        CalcularTotalesFiltrados()
    End Sub


    Private Sub AplicarVisibilidadFilas(criterio As Func(Of Date, Boolean))
        Dim primerIndiceVisible As Integer = -1

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim fecha As Date
            Dim mostrar As Boolean = Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) AndAlso criterio(fecha)

            If mostrar AndAlso primerIndiceVisible = -1 Then
                primerIndiceVisible = fila.Index
            End If

            fila.Tag = mostrar
        Next

        Dim bs As BindingSource = TryCast(PagosClientesDataGridView.DataSource, BindingSource)
        If bs IsNot Nothing AndAlso primerIndiceVisible >= 0 Then
            Dim filaActual As DataGridViewRow = PagosClientesDataGridView.CurrentRow
            If filaActual IsNot Nothing AndAlso Not CBool(filaActual.Tag) Then
                bs.Position = primerIndiceVisible
            End If
        End If

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow Then Continue For
            If mesSeleccionado <> "Todos" AndAlso MonthName(fecha.Month, False) <> mesSeleccionado Then
                mostrar = False
            End If

            Dim mostrar As Boolean = TypeOf fila.Tag Is Boolean AndAlso CBool(fila.Tag)
            fila.Visible = mostrar
            fila.Tag = Nothing
        Next

        CalcularTotalesFiltrados()
    End Sub

    Private Sub LlenarComboAño()
        Dim añosDisponibles As New HashSet(Of Integer)

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim fecha As Date
            If Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) Then
                añosDisponibles.Add(fecha.Year)
            End If
        Next

        cmbAño.Items.Clear()
        cmbAño.Items.Add("Todos")

        For Each año As Integer In añosDisponibles.OrderBy(Function(x) x)
            cmbAño.Items.Add(año.ToString())
        Next

        cmbAño.SelectedIndex = 0
    End Sub

    Private Sub CalcularTotalesFiltrados()
        Dim totalRD As Decimal = 0D
        Dim totalUS As Decimal = 0D

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow OrElse Not fila.Visible Then Continue For

            totalRD += ObtenerDecimal(fila.Cells("RD").Value)
            totalUS += ObtenerDecimal(fila.Cells("US").Value)
        Next

        Label2.Text = FormatearMonto(totalRD)
        Label4.Text = FormatearMonto(totalUS)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If PagosClientesDataGridView.Rows.Count = 0 Then Exit Sub

        AplicarFiltroAñoYMes()
        PagosClientesDataGridView.Sort(Fecha, System.ComponentModel.ListSortDirection.Descending)
        Label5.Text = "Listado ordenado por fecha descendente."
        Label5.ForeColor = Color.FromArgb(13, 110, 253)
        PagosClientesDataGridView.Sort(Fecha, System.ComponentModel.ListSortDirection.Descending)
        MsgBox("Listado ordenado por fecha descendente.", MsgBoxStyle.Information, "Cobros")
    End Sub

    Private Function ObtenerDecimal(valor As Object) As Decimal
        If valor Is Nothing Then Return 0D

        Dim texto As String = valor.ToString().Trim()
        If String.IsNullOrWhiteSpace(texto) Then Return 0D

        Dim resultado As Decimal
        If Decimal.TryParse(texto, NumberStyles.Any, CultureInfo.CurrentCulture, resultado) Then Return resultado
        If Decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, resultado) Then Return resultado

        Return 0D
    End Function

    Private Function FormatearMonto(monto As Decimal) As String
        Return monto.ToString("N2")
    End Function

    Private Function NormalizarMoneda(moneda As String) As String
        If String.IsNullOrWhiteSpace(moneda) Then Return String.Empty

        Return moneda.Trim().ToUpperInvariant()
    End Function

    Private Sub AplicarEstiloPremium()
        Me.Text = "Cobros - Vista Premium"
        Me.BackColor = Color.FromArgb(245, 248, 252)
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.StartPosition = FormStartPosition.CenterScreen

        ConfigurarGridPrincipal()
        ConfigurarGridDetalle()
        ConfigurarEtiquetasResumen()
        ConfigurarFiltrosYAcciones()
    End Sub

    Private Sub ConfigurarGridPrincipal()
        With PagosClientesDataGridView
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 48, 68)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
            .ColumnHeadersHeight = 34
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 240, 255)
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(28, 39, 58)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 254)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
        End With

        If PagosClientesDataGridView.Columns.Contains("ID_Cobro") Then PagosClientesDataGridView.Columns("ID_Cobro").HeaderText = "No. Cobro"
        If PagosClientesDataGridView.Columns.Contains("Id_Fiscal") Then PagosClientesDataGridView.Columns("Id_Fiscal").HeaderText = "RNC / Cédula"
        If PagosClientesDataGridView.Columns.Contains("FormaDePago") Then PagosClientesDataGridView.Columns("FormaDePago").HeaderText = "Forma de pago"
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 240, 255)
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(28, 39, 58)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 254)
            .RowHeadersVisible = False
        End With
    End Sub

    Private Sub ConfigurarGridDetalle()
        With PagosClientesDetalleDataGridView
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 70, 97)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
            .ColumnHeadersHeight = 32
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 254)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 254)
            .RowHeadersVisible = False
            .ReadOnly = True
        End With
    End Sub

    Private Sub ConfigurarEtiquetasResumen()
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(13, 110, 253)
        Label4.ForeColor = Color.FromArgb(25, 135, 84)
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(108, 117, 125)
    End Sub

    Private Sub ConfigurarFiltrosYAcciones()
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.BackColor = Color.FromArgb(13, 110, 253)
        Button1.ForeColor = Color.White
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)

        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button3.BackColor = Color.FromArgb(108, 117, 125)
        Button3.ForeColor = Color.White
        Button3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)

        cmbAño.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMes.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAño.FlatStyle = FlatStyle.Flat
        cmbMes.FlatStyle = FlatStyle.Flat

    Private Sub ConfigurarFiltrosYAcciones()
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.BackColor = Color.FromArgb(13, 110, 253)
        Button1.ForeColor = Color.White
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)

        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button3.BackColor = Color.FromArgb(108, 117, 125)
        Button3.ForeColor = Color.White
        Button3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)

        cmbAño.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMes.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAño.FlatStyle = FlatStyle.Flat
        cmbMes.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub ConfigurarFiltrosYAcciones()
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.FromArgb(13, 110, 253)
        Button1.ForeColor = Color.White

        Button3.FlatStyle = FlatStyle.Flat
        Button3.BackColor = Color.FromArgb(108, 117, 125)
        Button3.ForeColor = Color.White

        cmbAño.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMes.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class
