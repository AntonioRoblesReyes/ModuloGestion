Imports System.Data.SqlClient
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

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Using cmd As New SqlCommand("UPDATE FacturaMontaje SET IdEmpresaMontaje=@IdEmpresa, FechaPAgo=@Fecha, NCF=@NCF, Impuesto=@Impuesto, RetencionIRS=@RetencionIRS, SubTotal=@SubTotal, Total=@Total WHERE IdFacturaMontaje=@IdFactura", cn)
                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa)
                cmd.Parameters.AddWithValue("@Fecha", dtpFechaFactura.Value)
                cmd.Parameters.AddWithValue("@NCF", ncf)
                cmd.Parameters.AddWithValue("@Impuesto", impuesto)
                cmd.Parameters.AddWithValue("@RetencionIRS", retencion)
                cmd.Parameters.AddWithValue("@SubTotal", subTotal)
                cmd.Parameters.AddWithValue("@Total", total)
                cmd.Parameters.AddWithValue("@IdFactura", idFactura)

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
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
        If Decimal.TryParse(valorTexto, valor) Then
            Return valor
        End If
        Return 0D
    End Function

End Class
