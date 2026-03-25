Imports System.Data.SqlClient
Imports System.Globalization
Partial Public Class FrmFacturaMontajeB11


    Public IdEmpresaSeleccionada As String
    Private Sub FrmFacturaMontajeB11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EmpresasContratadasMontajeTableAdapter.FillByActivas(DsPagosMontaje.EmpresasContratadasMontaje)

            If Not String.IsNullOrEmpty(IdEmpresaSeleccionada) Then
                cboEmpresa.SelectedValue = IdEmpresaSeleccionada
            End If

            LimpiarPantallaNuevaFactura()

        Catch ex As Exception
            MessageBox.Show("Error cargando formulario B11: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNuevaFactura_Click(sender As Object, e As EventArgs) Handles BtnNuevaFactura.Click
        Try
            If cboEmpresa.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una empresa instaladora.")
                Exit Sub
            End If

            Dim nuevoId As String = Convert.ToString(FacturaMontajeTableAdapter.SiguienteFactura())
            If String.IsNullOrWhiteSpace(nuevoId) Then
                MessageBox.Show("No se pudo generar el Id de factura.")
                Exit Sub
            End If

            txtIdFactura.Text = nuevoId
            Dim idEmpresa As String = Convert.ToString(cboEmpresa.SelectedValue)

            If Convert.ToInt32(FacturaMontajeTableAdapter.ExisteFactura(nuevoId)) > 0 Then
                MessageBox.Show("La factura ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim subTotal As Decimal = ObtenerDecimal(txtSubTotal.Text)
            Dim total As Decimal = ObtenerDecimal(txtTotal.Text)

            FacturaMontajeTableAdapter.Nueva(
                nuevoId,
                idEmpresa,
                dtpFechaFactura.Value,
                "B11",
                "B11",
                subTotal,
                0D,
                total,
                "Factura B11",
                0D,
                total
            )

            GuardarCabecera(nuevoId)
            CargarFactura(nuevoId)

            MessageBox.Show("Factura B11 creada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error creando factura B11: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
                MessageBox.Show("Primero debe crear una factura nueva.")
                Exit Sub
            End If

            GuardarCabecera(txtIdFactura.Text.Trim())
            CargarFactura(txtIdFactura.Text.Trim())

            MessageBox.Show("Cabecera de factura guardada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error guardando factura B11: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnRecalcular_Click(sender As Object, e As EventArgs) Handles BtnRecalcular.Click
        Try
            If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
                MessageBox.Show("No hay factura para recalcular.")
                Exit Sub
            End If

            RecalcularCabecera(txtIdFactura.Text.Trim())
            CargarFactura(txtIdFactura.Text.Trim())
        Catch ex As Exception
            MessageBox.Show("Error al recalcular: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnImprimirB11_Click(sender As Object, e As EventArgs) Handles BtnImprimirB11.Click
        If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
            MessageBox.Show("No hay factura para imprimir.")
            Exit Sub
        End If

        MessageBox.Show("Placeholder: impresión de comprobante B11 para factura " & txtIdFactura.Text,
                        "Imprimir B11", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GuardarCabecera(idFactura As String)
        Dim idEmpresa As String = Convert.ToString(cboEmpresa.SelectedValue)
        If String.IsNullOrWhiteSpace(idEmpresa) Then
            Throw New Exception("Debe seleccionar una empresa instaladora.")
        End If

        Dim impuesto As Decimal = ObtenerDecimal(txtImpuesto.Text)
        Dim retencion As Decimal = ObtenerDecimal(txtRetencionIRS.Text)
        Dim subTotal As Decimal = ObtenerDecimal(txtSubTotal.Text)
        Dim total As Decimal = ObtenerDecimal(txtTotal.Text)
        Dim ncf As String = txtNCFB11.Text.Trim()

        Dim detalle As DataTable = ConstruirTablaDetalleFacturaB11(idFactura)

        GuardarCabeceraConTvp(idFactura, idEmpresa, dtpFechaFactura.Value, ncf, impuesto, retencion, subTotal, total, detalle)
    End Sub

    Private Sub RecalcularCabecera(idFactura As String)
        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Using cmd As New SqlCommand("sp_RecalcularFacturaMontaje", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdFactura", idFactura)
                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub CargarFactura(idFactura As String)
        FacturaMontajeTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontaje, idFactura)

        If FacturaMontajeBindingSource.Current Is Nothing Then Exit Sub

        Dim fila As DataRowView = CType(FacturaMontajeBindingSource.Current, DataRowView)
        cboEmpresa.SelectedValue = Convert.ToString(fila("IdEmpresaMontaje"))
    End Sub

    Private Sub LimpiarPantallaNuevaFactura()
        txtIdFactura.Text = ""
        txtNCFB11.Text = ""
        txtImpuesto.Text = "0"
        txtRetencionIRS.Text = "0"
        txtSubTotal.Text = "0"
        txtTotal.Text = "0"
        dtpFechaFactura.Value = Date.Today
    End Sub

    Private Function ObtenerDecimal(valorTexto As String) As Decimal
        Dim valor As Decimal
        If Decimal.TryParse(valorTexto, NumberStyles.Any, CultureInfo.CurrentCulture, valor) Then
            Return valor
        End If
        If Decimal.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, valor) Then
            Return valor
        End If
        Return 0D
    End Function

    Private Sub GuardarCabeceraConTvp(idFactura As String,
                                      idEmpresa As String,
                                      fechaFactura As Date,
                                      ncf As String,
                                      impuesto As Decimal,
                                      retencion As Decimal,
                                      subTotal As Decimal,
                                      total As Decimal,
                                      detalle As DataTable)
        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Using cmd As New SqlCommand("dbo.sp_FacturaMontajeB11_Upsert", cn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@IdFacturaB11", SqlDbType.NVarChar, 25).Value = idFactura.Trim()
                cmd.Parameters.Add("@IdEmpresaMontaje", SqlDbType.NVarChar, 25).Value = idEmpresa.Trim()
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = fechaFactura.Date
                cmd.Parameters.Add("@NCF", SqlDbType.NVarChar, 25).Value = ncf

                Dim pItbis = cmd.Parameters.Add("@ITBIS", SqlDbType.Decimal)
                pItbis.Precision = 18
                pItbis.Scale = 2
                pItbis.Value = impuesto

                Dim pRetencion = cmd.Parameters.Add("@RetencionISR", SqlDbType.Decimal)
                pRetencion.Precision = 18
                pRetencion.Scale = 2
                pRetencion.Value = retencion

                Dim pSubTotal = cmd.Parameters.Add("@SubTotal", SqlDbType.Decimal)
                pSubTotal.Precision = 18
                pSubTotal.Scale = 2
                pSubTotal.Value = subTotal

                Dim pTotal = cmd.Parameters.Add("@Total", SqlDbType.Decimal)
                pTotal.Precision = 18
                pTotal.Scale = 2
                pTotal.Value = total

                Dim pDetalle = cmd.Parameters.Add("@Detalle", SqlDbType.Structured)
                pDetalle.TypeName = "dbo.TipoDetalleFacturaB11"
                pDetalle.Value = detalle

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function ConstruirTablaDetalleFacturaB11(idFactura As String) As DataTable
        Dim tabla As New DataTable()
        tabla.Columns.Add("IdDetalle", GetType(String))
        tabla.Columns.Add("Descripcion", GetType(String))
        tabla.Columns.Add("Cantidad", GetType(Decimal))
        tabla.Columns.Add("Precio", GetType(Decimal))
        tabla.Columns.Add("Total", GetType(Decimal))

        Dim grid As DataGridView = ObtenerGridDetalleB11()
        If grid Is Nothing Then
            Return tabla
        End If

        Dim secuencia As Integer = 1
        For Each row As DataGridViewRow In grid.Rows
            If row.IsNewRow Then Continue For

            Dim idDetalle As String = ObtenerTextoCeldaFija(row, "ColIdDetalle")
            If String.IsNullOrWhiteSpace(idDetalle) Then
                idDetalle = idFactura.Trim() & "-" & secuencia.ToString("000")
            End If

            Dim dr = tabla.NewRow()
            dr("IdDetalle") = LimpiarTexto(idDetalle, 25)
            dr("Descripcion") = LimpiarTexto(ObtenerTextoCeldaFija(row, "ColDescripcion"), 500)
            dr("Cantidad") = ObtenerDecimalCeldaFija(row, "ColCantidad")
            dr("Precio") = ObtenerDecimalCeldaFija(row, "ColPrecio")
            dr("Total") = ObtenerDecimalCeldaFija(row, "ColTotal")
            tabla.Rows.Add(dr)

            secuencia += 1
        Next

        Return tabla
    End Function

    Private Function ObtenerGridDetalleB11() As DataGridView
        For Each c As Control In Me.Controls
            Dim grid As DataGridView = TryCast(c, DataGridView)
            If grid Is Nothing Then Continue For

            If grid.Columns.Contains("ColIdDetalle") AndAlso
               grid.Columns.Contains("ColDescripcion") AndAlso
               grid.Columns.Contains("ColCantidad") AndAlso
               grid.Columns.Contains("ColPrecio") AndAlso
               grid.Columns.Contains("ColTotal") Then
                Return grid
            End If
        Next

        Return Nothing
    End Function

    Private Function ObtenerTextoCeldaFija(row As DataGridViewRow, nombreColumna As String) As String
        If row Is Nothing OrElse row.DataGridView Is Nothing Then Return String.Empty
        If Not row.DataGridView.Columns.Contains(nombreColumna) Then Return String.Empty

        Dim valor = row.Cells(nombreColumna).Value
        If valor Is Nothing OrElse valor Is DBNull.Value Then Return String.Empty
        Return Convert.ToString(valor).Trim()
    End Function

    Private Function ObtenerDecimalCeldaFija(row As DataGridViewRow, nombreColumna As String) As Decimal
        If row Is Nothing OrElse row.DataGridView Is Nothing Then Return 0D
        If Not row.DataGridView.Columns.Contains(nombreColumna) Then Return 0D

        Dim valor = row.Cells(nombreColumna).Value
        If valor Is Nothing OrElse valor Is DBNull.Value Then Return 0D
        Return ObtenerDecimal(Convert.ToString(valor))
    End Function

    Private Function LimpiarTexto(valor As String, maximo As Integer) As String
        If String.IsNullOrWhiteSpace(valor) Then Return String.Empty
        Dim texto = valor.Trim()
        If texto.Length <= maximo Then Return texto
        Return texto.Substring(0, maximo)
    End Function

End Class
