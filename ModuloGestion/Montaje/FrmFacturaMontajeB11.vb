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

            If String.IsNullOrWhiteSpace(idFactura) Then
                MessageBox.Show("No hay número de factura.")
                Exit Sub
            End If

            If cboEmpresa.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una empresa.")
                Exit Sub
            End If

            ' 🔹 CREAR DATATABLE PARA EL DETALLE (TVP)
            Dim dtDetalle As New DataTable()
            dtDetalle.Columns.Add("IdDetalle", GetType(String))
            dtDetalle.Columns.Add("Descripcion", GetType(String))
            dtDetalle.Columns.Add("Cantidad", GetType(Decimal))
            dtDetalle.Columns.Add("Precio", GetType(Decimal))
            dtDetalle.Columns.Add("Total", GetType(Decimal))

            ' 🔹 LLENAR DESDE EL GRID
            For Each row As DataGridViewRow In dgvDetalle.Rows

                If row.IsNewRow Then Continue For

                dtDetalle.Rows.Add(
                Convert.ToString(row.Cells("ColIdDetalle").Value),
                Convert.ToString(row.Cells("ColDescripcion").Value),
                ObtenerDecimal(row.Cells("ColCantidad").Value),
                ObtenerDecimal(row.Cells("ColPrecio").Value),
                ObtenerDecimal(row.Cells("ColTotal").Value)
            )

            Next

            ' 🔹 LLAMAR AL STORED PROCEDURE
            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlCommand("sp_GuardarFacturaB11", cn)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add("@IdFacturaB11", SqlDbType.NVarChar, 25).Value = idFactura
                    cmd.Parameters.Add("@IdEmpresaMontaje", SqlDbType.NVarChar, 20).Value = cboEmpresa.SelectedValue
                    cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = dtpFechaFactura.Value
                    cmd.Parameters.Add("@NCF", SqlDbType.NVarChar, 20).Value = txtNCFB11.Text

                    ' 🔹 DECIMALES (IMPORTANTE)
                    Dim pSub As SqlParameter = cmd.Parameters.Add("@SubTotal", SqlDbType.Decimal)
                    pSub.Precision = 18 : pSub.Scale = 2
                    pSub.Value = ObtenerDecimal(txtSubTotal.Text)

                    Dim pItbis As SqlParameter = cmd.Parameters.Add("@ITBIS", SqlDbType.Decimal)
                    pItbis.Precision = 18 : pItbis.Scale = 2
                    pItbis.Value = ObtenerDecimal(txtImpuesto.Text)

                    Dim pRet As SqlParameter = cmd.Parameters.Add("@RetencionISR", SqlDbType.Decimal)
                    pRet.Precision = 18 : pRet.Scale = 2
                    pRet.Value = ObtenerDecimal(txtRetencionIRS.Text)

                    Dim pTotal As SqlParameter = cmd.Parameters.Add("@Total", SqlDbType.Decimal)
                    pTotal.Precision = 18 : pTotal.Scale = 2
                    pTotal.Value = ObtenerDecimal(txtTotal.Text)

                    ' 🔥 PARAMETRO TIPO TABLA (TVP)
                    Dim pDetalle As New SqlParameter("@Detalle", SqlDbType.Structured)
                    pDetalle.TypeName = "dbo.TipoDetalleFacturaB11"
                    pDetalle.Value = dtDetalle
                    cmd.Parameters.Add(pDetalle)

                    cn.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Factura guardada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error guardando: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub GuardarDetalle()

        If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
            Throw New Exception("No hay factura.")
        End If

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            cn.Open()

            ' 🔥 BORRAR DETALLE ANTERIOR (para evitar duplicados)
            Using cmdDelete As New SqlCommand("
            DELETE FROM FacturaMontajeB11Detalle
            WHERE IdFacturaB11 = @IdFactura", cn)

                cmdDelete.Parameters.AddWithValue("@IdFactura", txtIdFactura.Text)
                cmdDelete.ExecuteNonQuery()
            End Using

            ' 🔥 INSERTAR DETALLE NUEVO
            For Each row As DataGridViewRow In dgvDetalle.Rows

                If row.IsNewRow Then Continue For

                Using cmd As New SqlCommand("
                INSERT INTO FacturaMontajeB11Detalle
                (IdDetalle, IdFacturaB11, Descripcion, Cantidad, Precio, Total)
                VALUES
                (@IdDetalle, @IdFactura, @Descripcion, @Cantidad, @Precio, @Total)", cn)

                    cmd.Parameters.AddWithValue("@IdDetalle", row.Cells("ColIdDetalle").Value)
                    cmd.Parameters.AddWithValue("@IdFactura", txtIdFactura.Text)
                    cmd.Parameters.AddWithValue("@Descripcion", row.Cells("ColDescripcion").Value)
                    cmd.Parameters.AddWithValue("@Cantidad", ObtenerDecimal(row.Cells("ColCantidad").Value))
                    cmd.Parameters.AddWithValue("@Precio", ObtenerDecimal(row.Cells("ColPrecio").Value))
                    cmd.Parameters.AddWithValue("@Total", ObtenerDecimal(row.Cells("ColTotal").Value))

                    cmd.ExecuteNonQuery()
                End Using

            Next

        End Using

    End Sub
    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click

        Dim id As String = txtIdFactura.Text

        If MessageBox.Show("¿Seguro que desea anular esta factura?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Using cmd As New SqlCommand("sp_AnularFacturaB11", cn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdFacturaB11", id)

                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using

        MessageBox.Show("Factura anulada correctamente.")

    End Sub

    Private Sub TxtValorOriginal_TextChanged(sender As Object, e As EventArgs) Handles TxtValorOriginal.TextChanged
        Try
            If TxtValorOriginal.Text.Trim <> "" Then
                Dim valorOriginal As Decimal

                If Decimal.TryParse(TxtValorOriginal.Text, valorOriginal) Then
                    TxtValorConIRS.Text = (valorOriginal / 0.98D).ToString("#,##0.00")
                Else
                    TxtValorConIRS.Text = ""
                End If
            Else
                TxtValorConIRS.Text = ""
            End If
        Catch ex As Exception
            TxtValorConIRS.Text = ""
        End Try
    End Sub
End Class