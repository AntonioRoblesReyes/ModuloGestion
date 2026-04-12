Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class FrmHistorialPagosProveedor

    Public IdProveedor As String
    Public NombreProveedor As String

    Private ExpandedRows As New Dictionary(Of Integer, DataGridViewRow)

    Private Sub FrmHistorialPagosProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerDesde.Value = New Date(Date.Today.Year, 1, 1)
        DateTimePickerHasta.Value = Date.Today
        LblProveedor.Text = NombreProveedor
        CargarPagos()
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        CargarPagos()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub CargarPagos()
        Dim dt As New DataTable()

        Const sql As String = "SELECT
    c.Id_Compra,
    c.FacturaProveedor,
    c.Fecha_Compra,
    c.Moneda,
    c.TotalCompraRD,
    c.TotalCompraUS,
    ISNULL(SUM(pd.PagoRD),0) AS PagadoRD,
    ISNULL(SUM(pd.PagoUS),0) AS PagadoUS,
    c.TotalCompraRD - ISNULL(SUM(pd.PagoRD),0) AS PendienteRD,
    c.TotalCompraUS - ISNULL(SUM(pd.PagoUS),0) AS PendienteUS
FROM CompraMateriales c
LEFT JOIN PagoProveedorDetalle pd
    ON c.Id_Compra = pd.Id_Compra
WHERE c.Id_Proveedor = @IdProveedor
  AND c.Fecha_Compra BETWEEN @Desde AND @Hasta
GROUP BY
    c.Id_Compra,
    c.FacturaProveedor,
    c.Fecha_Compra,
    c.Moneda,
    c.TotalCompraRD,
    c.TotalCompraUS
ORDER BY c.Fecha_Compra DESC"

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor)
                cmd.Parameters.AddWithValue("@Desde", DateTimePickerDesde.Value.Date)
                cmd.Parameters.AddWithValue("@Hasta", DateTimePickerHasta.Value.Date.AddDays(1).AddTicks(-1))

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        DgvCompras.Rows.Clear()
        ExpandedRows.Clear()

        Dim totalPagadoRD As Decimal = 0D
        Dim totalPagadoUS As Decimal = 0D
        Dim totalPendienteRD As Decimal = 0D
        Dim totalPendienteUS As Decimal = 0D

        For Each row As DataRow In dt.Rows
            Dim index As Integer = DgvCompras.Rows.Add(
                "+",
                If(IsDBNull(row("Id_Compra")), "", row("Id_Compra").ToString()),
                If(IsDBNull(row("FacturaProveedor")), "", row("FacturaProveedor").ToString()),
                If(IsDBNull(row("Fecha_Compra")), Nothing, Convert.ToDateTime(row("Fecha_Compra"))),
                If(IsDBNull(row("Moneda")), "", row("Moneda").ToString()),
                If(IsDBNull(row("TotalCompraRD")), 0D, Convert.ToDecimal(row("TotalCompraRD"))),
                If(IsDBNull(row("TotalCompraUS")), 0D, Convert.ToDecimal(row("TotalCompraUS"))),
                If(IsDBNull(row("PagadoRD")), 0D, Convert.ToDecimal(row("PagadoRD"))),
                If(IsDBNull(row("PagadoUS")), 0D, Convert.ToDecimal(row("PagadoUS"))),
                If(IsDBNull(row("PendienteRD")), 0D, Convert.ToDecimal(row("PendienteRD"))),
                If(IsDBNull(row("PendienteUS")), 0D, Convert.ToDecimal(row("PendienteUS")))
            )

            DgvCompras.Rows(index).Tag = "MASTER"

            totalPagadoRD += If(IsDBNull(row("PagadoRD")), 0D, Convert.ToDecimal(row("PagadoRD")))
            totalPagadoUS += If(IsDBNull(row("PagadoUS")), 0D, Convert.ToDecimal(row("PagadoUS")))
            totalPendienteRD += If(IsDBNull(row("PendienteRD")), 0D, Convert.ToDecimal(row("PendienteRD")))
            totalPendienteUS += If(IsDBNull(row("PendienteUS")), 0D, Convert.ToDecimal(row("PendienteUS")))
        Next

        LblTotalPagadoRD.Text = "RD$ " & totalPagadoRD.ToString("N2")
        LblTotalPagadoUS.Text = "US$ " & totalPagadoUS.ToString("N2")
        LblPendienteRD.Text = "RD$ " & totalPendienteRD.ToString("N2")
        LblPendienteUS.Text = "US$ " & totalPendienteUS.ToString("N2")
    End Sub

    Private Sub ExpandirFila(idCompra As String, rowIndex As Integer)
        Dim dt As New DataTable()

        Const sql As String = "SELECT
    Fecha_Pago,
    FormaDePago,
    PagoRD,
    PagoUS
FROM PagoProveedorDetalle
WHERE Id_Compra = @IdCompra
ORDER BY Fecha_Pago DESC"

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@IdCompra", idCompra)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Dim filaActual As Integer = rowIndex + 1

        If dt.Rows.Count = 0 Then
            Dim detalleSinPago As String = "   Sin pagos registrados"
            DgvCompras.Rows.Insert(filaActual, "", "", detalleSinPago, Nothing, "", "", "", "", "", "")
            AplicarEstiloDetalle(filaActual)
        Else
            For Each dr As DataRow In dt.Rows
                Dim fechaTexto As String = If(IsDBNull(dr("Fecha_Pago")), "", Convert.ToDateTime(dr("Fecha_Pago")).ToString("dd/MM/yyyy"))
                Dim formaTexto As String = If(IsDBNull(dr("FormaDePago")), "", dr("FormaDePago").ToString())
                Dim pagoRD As Decimal = If(IsDBNull(dr("PagoRD")), 0D, Convert.ToDecimal(dr("PagoRD")))
                Dim pagoUS As Decimal = If(IsDBNull(dr("PagoUS")), 0D, Convert.ToDecimal(dr("PagoUS")))
                Dim detalle As String = "   " & fechaTexto & "   " & formaTexto & "   RD$ " & pagoRD.ToString("N2") & "   US$ " & pagoUS.ToString("N2")

                DgvCompras.Rows.Insert(filaActual, "", "", detalle, Nothing, "", "", "", "", "", "")
                AplicarEstiloDetalle(filaActual)
                filaActual += 1
            Next
        End If

        DgvCompras.Rows(rowIndex).Cells("Expandir").Value = "-"
        ExpandedRows(rowIndex) = DgvCompras.Rows(rowIndex)
        RebuildExpandedRows()
    End Sub

    Private Sub ContraerFila(rowIndex As Integer)
        Dim i As Integer = rowIndex + 1

        While i < DgvCompras.Rows.Count AndAlso Convert.ToString(DgvCompras.Rows(i).Tag) = "DETAIL"
            DgvCompras.Rows.RemoveAt(i)
        End While

        If rowIndex >= 0 AndAlso rowIndex < DgvCompras.Rows.Count Then
            DgvCompras.Rows(rowIndex).Cells("Expandir").Value = "+"
        End If

        RebuildExpandedRows()
    End Sub

    Private Sub AplicarEstiloDetalle(indice As Integer)
        Dim detalleRow As DataGridViewRow = DgvCompras.Rows(indice)
        detalleRow.Tag = "DETAIL"
        detalleRow.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
        detalleRow.DefaultCellStyle.Font = New Font("Segoe UI", 8.0!, FontStyle.Regular)
        detalleRow.DefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70)
        detalleRow.Cells("Expandir").ReadOnly = True
    End Sub

    Private Sub RebuildExpandedRows()
        ExpandedRows.Clear()

        For i As Integer = 0 To DgvCompras.Rows.Count - 1
            If Convert.ToString(DgvCompras.Rows(i).Tag) = "MASTER" AndAlso Convert.ToString(DgvCompras.Rows(i).Cells("Expandir").Value) = "-" Then
                ExpandedRows(i) = DgvCompras.Rows(i)
            End If
        Next
    End Sub

    Private Sub DgvCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCompras.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex <> DgvCompras.Columns("Expandir").Index Then Exit Sub
        If Convert.ToString(DgvCompras.Rows(e.RowIndex).Tag) <> "MASTER" Then Exit Sub

        Dim idCompra As String = Convert.ToString(DgvCompras.Rows(e.RowIndex).Cells("Id_Compra").Value)
        If String.IsNullOrWhiteSpace(idCompra) Then Exit Sub

        Dim estado As String = Convert.ToString(DgvCompras.Rows(e.RowIndex).Cells("Expandir").Value)

        If estado = "+" Then
            ExpandirFila(idCompra, e.RowIndex)
        Else
            ContraerFila(e.RowIndex)
        End If
    End Sub

End Class
