Imports System.Data.SqlClient

Partial Public Class FrmFacturaMontajeB11

    Public Property IdEmpresaSeleccionada As String
    Public Property IdFacturaGenerada As String

    Private Sub FrmFacturaMontajeB11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' Cargar empresas
            EmpresasContratadasMontajeTableAdapter.FillByActivas(DsPagosMontaje.EmpresasContratadasMontaje)

            If Not String.IsNullOrEmpty(IdEmpresaSeleccionada) Then
                cboEmpresa.SelectedValue = IdEmpresaSeleccionada
            End If

            ' 🔥 ASIGNAR FACTURA GENERADA DESDE EL BOTÓN
            txtIdFactura.Text = IdFacturaGenerada

            LimpiarPantallaNuevaFactura()

        Catch ex As Exception
            MessageBox.Show("Error cargando formulario B11: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnNuevaFactura_Click(sender As Object, e As EventArgs) Handles BtnNuevaFactura.Click

        Try
            If cboEmpresa.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una empresa instaladora.")
                Exit Sub
            End If

            Dim idFactura As String = txtIdFactura.Text.Trim()
            Dim idEmpresa As String = Convert.ToString(cboEmpresa.SelectedValue)

            If String.IsNullOrWhiteSpace(idFactura) Then
                MessageBox.Show("No hay número de factura.")
                Exit Sub
            End If

            ' 🔥 INSERT DIRECTO A TU TABLA NUEVA
            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlCommand("
                    INSERT INTO FacturaMontajeB11
                    (IdFacturaB11, IdEmpresaMontaje, Fecha, NCF, SubTotal, ITBIS, RetencionISR, Total)
                    VALUES
                    (@IdFactura, @IdEmpresa, @Fecha, @NCF, @SubTotal, @ITBIS, @Retencion, @Total)", cn)

                    cmd.Parameters.AddWithValue("@IdFactura", idFactura)
                    cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa)
                    cmd.Parameters.AddWithValue("@Fecha", dtpFechaFactura.Value)
                    cmd.Parameters.AddWithValue("@NCF", txtNCFB11.Text)

                    cmd.Parameters.AddWithValue("@SubTotal", ObtenerDecimal(txtSubTotal.Text))
                    cmd.Parameters.AddWithValue("@ITBIS", ObtenerDecimal(txtImpuesto.Text))
                    cmd.Parameters.AddWithValue("@Retencion", ObtenerDecimal(txtRetencionIRS.Text))
                    cmd.Parameters.AddWithValue("@Total", ObtenerDecimal(txtTotal.Text))

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Factura creada correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error creando factura: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try
            Dim idFactura As String = txtIdFactura.Text.Trim()

            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlCommand("
                    UPDATE FacturaMontajeB11 SET
                    IdEmpresaMontaje=@IdEmpresa,
                    Fecha=@Fecha,
                    NCF=@NCF,
                    SubTotal=@SubTotal,
                    ITBIS=@ITBIS,
                    RetencionISR=@Retencion,
                    Total=@Total
                    WHERE IdFacturaB11=@IdFactura", cn)

                    cmd.Parameters.AddWithValue("@IdEmpresa", cboEmpresa.SelectedValue)
                    cmd.Parameters.AddWithValue("@Fecha", dtpFechaFactura.Value)
                    cmd.Parameters.AddWithValue("@NCF", txtNCFB11.Text)

                    cmd.Parameters.AddWithValue("@SubTotal", ObtenerDecimal(txtSubTotal.Text))
                    cmd.Parameters.AddWithValue("@ITBIS", ObtenerDecimal(txtImpuesto.Text))
                    cmd.Parameters.AddWithValue("@Retencion", ObtenerDecimal(txtRetencionIRS.Text))
                    cmd.Parameters.AddWithValue("@Total", ObtenerDecimal(txtTotal.Text))

                    cmd.Parameters.AddWithValue("@IdFactura", idFactura)

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Factura guardada.")

        Catch ex As Exception
            MessageBox.Show("Error guardando: " & ex.Message)
        End Try

    End Sub

    Private Sub LimpiarPantallaNuevaFactura()
        txtNCFB11.Text = ""
        txtImpuesto.Text = "0"
        txtRetencionIRS.Text = "0"
        txtSubTotal.Text = "0"
        txtTotal.Text = "0"
        dtpFechaFactura.Value = Date.Today
    End Sub

    Private Function ObtenerDecimal(valorTexto As String) As Decimal
        Dim valor As Decimal
        If Decimal.TryParse(valorTexto, valor) Then Return valor
        Return 0D
    End Function

    Private Sub BtnNuevoDetalle_Click(sender As Object, e As EventArgs) Handles BtnNuevoDetalle.Click

        Try
            If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
                MsgBox("Debe crear la factura primero.")
                Exit Sub
            End If

            Dim idDetalle As String = GenerarIdDetalle(txtIdFactura.Text)

            Dim rowIndex As Integer = dgvDetalle.Rows.Add()

            With dgvDetalle.Rows(rowIndex)
                .Cells("ColIdDetalle").Value = idDetalle
                .Cells("ColIdFactura").Value = txtIdFactura.Text
                .Cells("ColDescripcion").Value = ""
                .Cells("ColCantidad").Value = 1D
                .Cells("ColPrecio").Value = 0D
                .Cells("ColTotal").Value = 0D
            End With

            dgvDetalle.CurrentCell = dgvDetalle.Rows(rowIndex).Cells("ColDescripcion")
            dgvDetalle.BeginEdit(True)

            CalcularTotalesFactura()

        Catch ex As Exception
            MsgBox("Error agregando detalle: " & ex.Message)
        End Try

    End Sub
    Private Function GenerarIdDetalle(idFactura As String) As String
        Dim contador As Integer = 0

        For Each row As DataGridViewRow In dgvDetalle.Rows
            If Not row.IsNewRow Then
                contador += 1
            End If
        Next

        contador += 1

        Return idFactura & "-" & contador.ToString("000")
    End Function
    Private Function ObtenerValorCeldaDecimal(row As DataGridViewRow, nombreColumna As String) As Decimal
        Try
            If row Is Nothing OrElse row.Cells(nombreColumna).Value Is Nothing OrElse IsDBNull(row.Cells(nombreColumna).Value) Then
                Return 0D
            End If

            Dim valor As Decimal
            If Decimal.TryParse(row.Cells(nombreColumna).Value.ToString(), valor) Then
                Return valor
            End If

            Return 0D
        Catch
            Return 0D
        End Try
    End Function

    Private Sub CalcularLinea(row As DataGridViewRow)
        If row Is Nothing OrElse row.IsNewRow Then Exit Sub

        Dim cantidad As Decimal = ObtenerValorCeldaDecimal(row, "ColCantidad")
        Dim precio As Decimal = ObtenerValorCeldaDecimal(row, "ColPrecio")

        Dim totalLinea As Decimal = Math.Round(cantidad * precio, 2)

        row.Cells("ColTotal").Value = totalLinea
    End Sub

    Private Sub CalcularTotalesFactura()

        Dim subtotal As Decimal = 0D

        For Each row As DataGridViewRow In dgvDetalle.Rows
            If row.IsNewRow Then Continue For

            subtotal += ObtenerValorCeldaDecimal(row, "ColTotal")
        Next

        subtotal = Math.Round(subtotal, 2)

        ' 🔹 ITBIS 18%
        Dim itbis As Decimal = Math.Round(subtotal * 0.18D, 2)

        ' 🔹 TOTAL
        Dim total As Decimal = subtotal + itbis

        ' 🔹 RETENCION ISR (2% del subtotal)
        Dim retencionISR As Decimal = Math.Round(subtotal * 0.02, 2)

        ' 🔹 RETENCION ITBIS (100%)
        Dim retencionITBIS As Decimal = itbis

        ' 🔹 TOTAL PAGADO
        Dim totalPagado As Decimal = total - retencionISR - retencionITBIS

        ' 🔹 ASIGNAR
        txtSubTotal.Text = subtotal.ToString("#,##0.00")
        txtImpuesto.Text = itbis.ToString("#,##0.00")
        txtTotal.Text = total.ToString("#,##0.00")

        txtRetencionIRS.Text = retencionISR.ToString("#,##0.00")

        ' 👇 ESTE CAMPO TIENES QUE CREARLO SI NO EXISTE
        txtRetencionITBIS.Text = retencionITBIS.ToString("#,##0.00")

        ' 👇 ESTE TAMBIÉN
        txtTotalPagado.Text = totalPagado.ToString("#,##0.00")

    End Sub
    Private Sub dgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Try
            If e.RowIndex < 0 Then Exit Sub

            Dim row As DataGridViewRow = dgvDetalle.Rows(e.RowIndex)

            If dgvDetalle.Columns(e.ColumnIndex).Name = "ColCantidad" OrElse
               dgvDetalle.Columns(e.ColumnIndex).Name = "ColPrecio" Then

                CalcularLinea(row)
                CalcularTotalesFactura()
            End If

        Catch ex As Exception
            MsgBox("Error al calcular detalle: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub dgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDetalle.RowsRemoved
        Try
            CalcularTotalesFactura()
        Catch ex As Exception
            MsgBox("Error al recalcular totales: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class