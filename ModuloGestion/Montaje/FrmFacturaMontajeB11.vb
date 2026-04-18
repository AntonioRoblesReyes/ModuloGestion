Imports System.Data
Imports System.Data.SqlClient

Partial Public Class FrmFacturaMontajeB11

    Public Property IdEmpresaSeleccionada As String

    Private Sub FrmFacturaMontajeB11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            EmpresasContratadasMontajeTableAdapter.FillByActivas(DsPagosMontaje.EmpresasContratadasMontaje)

            If Not String.IsNullOrWhiteSpace(IdEmpresaSeleccionada) Then
                cboEmpresa.SelectedValue = IdEmpresaSeleccionada
            End If

            PrepararNuevaFactura()

        Catch ex As Exception
            MessageBox.Show("Error cargando formulario B11: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PrepararNuevaFactura()

        LimpiarPantallaNuevaFactura()

        Dim nuevoNCF As String = ObtenerSiguienteNCFB11()

        txtIdFactura.Text = nuevoNCF
        txtNCFB11.Text = nuevoNCF

        dgvDetalle.Rows.Clear()

        txtIdFactura.Focus()

    End Sub

    Private Function ObtenerSiguienteNCFB11() As String

        Dim numero As Integer = 1

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            cn.Open()

            Dim sql As String =
                "SELECT TOP 1 IdFacturaB11
                 FROM FacturaMontajeB11
                 WHERE IdFacturaB11 LIKE 'B11%'
                 ORDER BY CAST(SUBSTRING(IdFacturaB11,4,8) AS INT) DESC"

            Using cmd As New SqlCommand(sql, cn)

                Dim resultado As Object = cmd.ExecuteScalar()

                If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then

                    Dim ultimoNCF As String = resultado.ToString()

                    If ultimoNCF.Length >= 11 Then
                        Integer.TryParse(ultimoNCF.Substring(3, 8), numero)
                        numero += 1
                    End If

                End If

            End Using

        End Using

        Return "B11" & numero.ToString("00000000")

    End Function

    Private Sub BtnNuevaFactura_Click(sender As Object, e As EventArgs) Handles BtnNuevaFactura.Click

        Try

            If cboEmpresa.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una empresa instaladora.",
                                "Factura B11",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idFactura As String = txtIdFactura.Text.Trim()
            Dim idEmpresa As String = cboEmpresa.SelectedValue.ToString()

            If String.IsNullOrWhiteSpace(idFactura) Then
                MessageBox.Show("No hay número de factura.",
                                "Factura B11",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

                cn.Open()

                Dim sql As String =
                    "INSERT INTO FacturaMontajeB11
                    (IdFacturaB11, IdEmpresaMontaje, Fecha, NCF, SubTotal, ITBIS, RetencionISR, Total)
                    VALUES
                    (@IdFactura, @IdEmpresa, @Fecha, @NCF, @SubTotal, @ITBIS, @RetencionISR, @Total)"

                Using cmd As New SqlCommand(sql, cn)

                    cmd.Parameters.Add("@IdFactura", SqlDbType.NVarChar, 25).Value = idFactura
                    cmd.Parameters.Add("@IdEmpresa", SqlDbType.NVarChar, 20).Value = idEmpresa
                    cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = dtpFechaFactura.Value
                    cmd.Parameters.Add("@NCF", SqlDbType.NVarChar, 25).Value = txtNCFB11.Text.Trim()

                    Dim pSubTotal = cmd.Parameters.Add("@SubTotal", SqlDbType.Decimal)
                    pSubTotal.Precision = 18
                    pSubTotal.Scale = 2
                    pSubTotal.Value = txtSubTotal.Text
                    Dim pITBIS = cmd.Parameters.Add("@ITBIS", SqlDbType.Decimal)
                    pITBIS.Precision = 18
                    pITBIS.Scale = 2
                    pITBIS.Value = txtImpuesto.Text
                    Dim pRetencion = cmd.Parameters.Add("@RetencionISR", SqlDbType.Decimal)
                    pRetencion.Precision = 18
                    pRetencion.Scale = 2
                    pRetencion.Value = txtRetencionIRS.Text

                    Dim pTotal = cmd.Parameters.Add("@Total", SqlDbType.Decimal)
                    pTotal.Precision = 18
                    pTotal.Scale = 2
                    pTotal.Value = txtTotal.Text
                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Factura creada correctamente.",
                            "Factura B11",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            BtnNuevaFactura.Enabled = False
            BtnGuardar.Enabled = True
            BtnNuevoDetalle.Enabled = True

        Catch exSql As SqlException When exSql.Number = 2627 OrElse exSql.Number = 2601

            MessageBox.Show("Ya existe una factura con ese número. Se generará un nuevo consecutivo.",
                            "Factura duplicada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Dim nuevoNCF As String = ObtenerSiguienteNCFB11()
            txtIdFactura.Text = nuevoNCF
            txtNCFB11.Text = nuevoNCF

        Catch ex As Exception

            MessageBox.Show("Error creando factura: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub LimpiarPantallaNuevaFactura()

        txtSubTotal.Text = "0.00"
        txtImpuesto.Text = "0.00"
        txtRetencionIRS.Text = "0.00"

        If txtRetencionITBIS IsNot Nothing Then
            txtRetencionITBIS.Text = "0.00"
        End If

        txtTotal.Text = "0.00"

        If txtTotalPagado IsNot Nothing Then
            txtTotalPagado.Text = "0.00"
        End If

        dtpFechaFactura.Value = Date.Today

    End Sub



    Private Sub BtnNuevoDetalle_Click(sender As Object, e As EventArgs) Handles BtnNuevoDetalle.Click

        Try

            If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
                MessageBox.Show("Debe crear la factura primero.",
                            "Detalle B11",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim consecutivo As Integer = 1

            For Each row As DataGridViewRow In dgvDetalle.Rows

                If row.IsNewRow Then Continue For

                consecutivo += 1

            Next

            Dim idDetalle As String =
            txtIdFactura.Text.Trim() & "-" & consecutivo.ToString("000")

            Dim fila As Integer = dgvDetalle.Rows.Add()

            With dgvDetalle.Rows(fila)

                .Cells("ColIdDetalle").Value = idDetalle
                .Cells("ColIdFactura").Value = txtIdFactura.Text.Trim()
                .Cells("ColDescripcion").Value = ""
                .Cells("ColCantidad").Value = 1D
                .Cells("ColPrecio").Value = 0D
                .Cells("ColTotal").Value = 0D

            End With

            dgvDetalle.CurrentCell = dgvDetalle.Rows(fila).Cells("ColDescripcion")
            dgvDetalle.BeginEdit(True)

        Catch ex As Exception

            MessageBox.Show("Error agregando detalle: " & ex.Message,
                        "Detalle B11",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try

            If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
                MessageBox.Show("Debe crear la factura primero.")
                Exit Sub
            End If

            If dgvDetalle.Rows.Count = 0 Then
                MessageBox.Show("Debe agregar al menos un detalle.")
                Exit Sub
            End If

            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

                cn.Open()

                ' Verificar que exista la cabecera
                Dim existe As Integer

                Using cmdExiste As New SqlCommand("
                SELECT COUNT(*)
                FROM FacturaMontajeB11
                WHERE IdFacturaB11 = @IdFactura", cn)

                    cmdExiste.Parameters.Add("@IdFactura", SqlDbType.NVarChar, 25).Value =
                    txtIdFactura.Text.Trim()

                    existe = CInt(cmdExiste.ExecuteScalar())

                End Using

                If existe = 0 Then
                    MessageBox.Show("Primero debe pulsar 'Nueva factura'.")
                    Exit Sub
                End If

                ' Borrar detalle anterior
                Using cmdDelete As New SqlCommand("
                DELETE FROM FacturaMontajeB11Detalle
                WHERE IdFacturaB11 = @IdFactura", cn)

                    cmdDelete.Parameters.Add("@IdFactura", SqlDbType.NVarChar, 25).Value =
                    txtIdFactura.Text.Trim()

                    cmdDelete.ExecuteNonQuery()

                End Using

                ' Guardar detalle
                For Each row As DataGridViewRow In dgvDetalle.Rows

                    If row.IsNewRow Then Continue For

                    Using cmd As New SqlCommand("
                    INSERT INTO FacturaMontajeB11Detalle
                    (IdDetalle, IdFacturaB11, Descripcion, Cantidad, Precio, Total)
                    VALUES
                    (@IdDetalle, @IdFactura, @Descripcion, @Cantidad, @Precio, @Total)", cn)

                        cmd.Parameters.Add("@IdDetalle", SqlDbType.NVarChar, 50).Value =
                        Convert.ToString(row.Cells("ColIdDetalle").Value)

                        cmd.Parameters.Add("@IdFactura", SqlDbType.NVarChar, 25).Value =
                        txtIdFactura.Text.Trim()

                        cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 500).Value =
                        Convert.ToString(row.Cells("ColDescripcion").Value)

                        cmd.Parameters.Add("@Cantidad", SqlDbType.Decimal).Value =
                        Convert.ToDecimal(row.Cells("ColCantidad").Value)

                        cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value =
                        Convert.ToDecimal(row.Cells("ColPrecio").Value)

                        cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value =
                        Convert.ToDecimal(row.Cells("ColTotal").Value)

                        cmd.ExecuteNonQuery()

                    End Using

                Next

                ' Actualizar cabecera
                Using cmdUpdate As New SqlCommand("
                UPDATE FacturaMontajeB11
                SET SubTotal = @SubTotal,
                    ITBIS = @ITBIS,
                    RetencionISR = @RetencionISR,
                    Total = @Total
                WHERE IdFacturaB11 = @IdFactura", cn)

                    cmdUpdate.Parameters.Add("@IdFactura", SqlDbType.NVarChar, 25).Value =
                    txtIdFactura.Text.Trim()

                    cmdUpdate.Parameters.Add("@SubTotal", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(txtSubTotal.Text)

                    cmdUpdate.Parameters.Add("@ITBIS", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(txtImpuesto.Text)

                    cmdUpdate.Parameters.Add("@RetencionISR", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(txtRetencionIRS.Text)

                    cmdUpdate.Parameters.Add("@Total", SqlDbType.Decimal).Value =
                    Convert.ToDecimal(txtTotal.Text)

                    cmdUpdate.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Factura guardada correctamente.")

        Catch ex As Exception

            MessageBox.Show("Error guardando factura: " & ex.Message)

        End Try

    End Sub

    Private Sub dgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit

        Try

            If e.RowIndex < 0 Then Exit Sub

            Dim fila As DataGridViewRow = dgvDetalle.Rows(e.RowIndex)

            Dim cantidad As Decimal = fila.Cells("ColCantidad").Value
            Dim precio As Decimal = fila.Cells("ColPrecio").Value

            Dim totalLinea As Decimal = cantidad * precio

            fila.Cells("ColTotal").Value = totalLinea.ToString("N2")

            Dim subTotal As Decimal = 0D

            For Each row As DataGridViewRow In dgvDetalle.Rows

                If row.IsNewRow Then Continue For

                subTotal += row.Cells("ColTotal").Value

            Next

            txtSubTotal.Text = subTotal.ToString("N2")
            txtImpuesto.Text = (subTotal * 0.18D).ToString("N2")
            txtTotal.Text = (subTotal + (subTotal * 0.18D)).ToString("N2")
            txtRetencionIRS.Text = (subTotal * 0.02D).ToString("N2")
            txtRetencionITBIS.Text = (subTotal * 0.18D).ToString("N2")

        Catch ex As Exception

            MessageBox.Show("Error recalculando detalle: " & ex.Message,
                    "Detalle B11",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

        End Try

    End Sub
End Class