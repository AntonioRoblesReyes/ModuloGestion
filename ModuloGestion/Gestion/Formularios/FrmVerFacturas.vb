Imports System.Data.SqlClient

Public Class FrmVerFacturas

#Region "CARGA Y CIERRE"

    Sub FiltrarProyecto()
        Me.FacturaTableAdapter.FillByIdProyecto(
            Me.DsFacturas.Factura,
            My.Forms.FrmProyectos.TxtIdProyecto.Text
        )
    End Sub

    Private Sub FrmVerFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.FacturaDetalleTableAdapter.Fill(Me.DsFacturas.FacturaDetalle)
            Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
            Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
            Me.FacturaTableAdapter.FillByIdEmpresa(Me.DsFacturas.Factura, "IN")
            Me.EmpresasTableAdapter.FillByIdEmpresa(Me.DsEmpresas.Empresas, "IN")
        Catch ex As Exception
            MsgBox("Error cargando datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmVerFacturas_FormClosing(
        sender As Object,
        e As FormClosingEventArgs
    ) Handles Me.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

#End Region

#Region "BOTONES PRINCIPALES"

    Private Sub EmpresasBindingNavigatorSaveItem_Click(
        sender As Object,
        e As EventArgs
    ) Handles EmpresasBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpresas)
    End Sub

    Private Sub BtnNuevaFactura_Click(sender As Object, e As EventArgs) _
        Handles BtnNuevaFactura.Click

        My.Forms.FrmProyectosFacturacion.Close()
        My.Forms.FrmProyectosFacturacion.Label2.Text =
            My.Forms.FrmProyectos.TxtIdFiscalCliente.Text

        My.Forms.FrmProyectosFacturacion.Show()
    End Sub

    Private Sub BtnVerFactura_Click(sender As Object, e As EventArgs) _
        Handles BtnVerFactura.Click

        If Me.FacturaBindingSource.Position < 0 Then Exit Sub

        Dim idFactura As String =
            Me.DsFacturas.Factura(Me.FacturaBindingSource.Position).IdFactura

        My.Forms.FrmFacturas.Close()
        My.Forms.FrmFacturas.Label2.Text = idFactura
        My.Forms.FrmFacturas.VerFActura()
    End Sub

#End Region

#Region "FACTURA SELECCIONADA"

    Private Sub FacturaDataGridView_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles FacturaDataGridView.SelectionChanged

        If FacturaDataGridView.CurrentRow Is Nothing Then Exit Sub

        Dim idFactura As String =
            FacturaDataGridView.CurrentRow.Cells("IdFactura").Value.ToString()

        If String.IsNullOrWhiteSpace(idFactura) Then Exit Sub

        CargarPagosFactura(idFactura)
        EvaluarPagosCandidatosFactura()

    End Sub

#End Region
    Private Sub BtnBuscarPagoDirecto_Click(
    sender As Object,
    e As EventArgs
) Handles BtnBuscarPagoDirecto.Click

        If FacturaDataGridView.CurrentRow Is Nothing Then
            MsgBox("Seleccione una factura.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim fila = FacturaDataGridView.CurrentRow

        ' Tomar el VALOR del ComboBox (Id_Fiscal)
        If fila.Cells("IdProyecto").Value Is Nothing _
       OrElse IsDBNull(fila.Cells("IdProyecto").Value) Then

            MsgBox("La factura no tiene proyecto asignado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim idFiscalProyecto As String =
        fila.Cells("IdProyecto").Value.ToString().Trim()

        dgvPagosCandidatos.DataSource = Nothing
        dgvPagosCandidatos.AutoGenerateColumns = True

        Try
            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

                Dim sql As String =
                "SELECT 
                    IdPagoClientesDetalle,
                    ID_Cobro,
                    IdFactura,
                    Id_Proyecto,
                    Moneda,
                    TotalPagado AS Monto,
                    Fecha
                 FROM PagosClientesDetalle
                 WHERE Id_Proyecto = @IdProyecto
                 ORDER BY Fecha DESC"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.Add("@IdProyecto", SqlDbType.NVarChar).Value =
                    idFiscalProyecto

                    Using da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        dgvPagosCandidatos.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error buscando pagos del proyecto:" & vbCrLf & ex.Message,
               MsgBoxStyle.Critical)
        End Try

    End Sub

















    Private Sub AplicarPagoAFacturaReal(
    idFactura As String,
    idCobro As String,
    idPresupuesto As String,
    monto As Decimal,
    moneda As String
)

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            Dim cmd As New SqlCommand(
        "INSERT INTO FacturaPagosAplicados
         (IdFactura, ID_Cobro, Id_Presupuesto, MontoAplicado, Moneda, FechaAplicacion)
         VALUES
         (@IdFactura, @ID_Cobro, @Id_Presupuesto, @Monto, @Moneda, GETDATE())", cn)

            cmd.Parameters.AddWithValue("@IdFactura", idFactura)
            cmd.Parameters.AddWithValue("@ID_Cobro", idCobro)
            cmd.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto)
            cmd.Parameters.AddWithValue("@Monto", monto)
            cmd.Parameters.AddWithValue("@Moneda", moneda)

            cn.Open()
            cmd.ExecuteNonQuery()
        End Using

        RecalcularFacturaVB(idFactura)
        CargarPagosFactura(idFactura)
        FacturaTableAdapter.Fill(DsFacturas.Factura)

    End Sub



#Region "SOPORTE SQL"

    Private Function ObtenerPresupuestoDesdePago(idCobro As String) As String

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            Dim cmd As New SqlCommand(
            "SELECT TOP 1 Id_Presupuesto
             FROM PagosClientesDetalle
             WHERE ID_Cobro = @ID_Cobro", cn)

            cmd.Parameters.AddWithValue("@ID_Cobro", idCobro)

            cn.Open()
            Dim r = cmd.ExecuteScalar()

            If r Is Nothing OrElse IsDBNull(r) Then Return Nothing
            Return r.ToString()
        End Using
    End Function

    Private Sub CargarPagosFactura(idFactura As String)

        dgvPagosAplicados.AutoGenerateColumns = True
        dgvPagosAplicados.Columns.Clear()
        dgvPagosAplicados.DataSource = Nothing

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            Dim sql As String =
        "SELECT
            IdPagoClientesDetalle,      
                    Id_Proyecto,
            Moneda,
            TotalPagado AS MontoAplicado,
            Fecha
         FROM PagosClientesDetalle
         WHERE IdFactura = @IdFactura
         ORDER BY Fecha DESC"

            Dim cmd As New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@IdFactura", idFactura)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvPagosAplicados.DataSource = dt
        End Using

        ' Formato monto si existe
        If dgvPagosAplicados.Columns.Contains("MontoAplicado") Then
            dgvPagosAplicados.Columns("MontoAplicado").DefaultCellStyle.Format = "N2"
            dgvPagosAplicados.Columns("MontoAplicado").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight
        End If

    End Sub


    Private Sub RecalcularFacturaVB(idFactura As String)

        If String.IsNullOrWhiteSpace(idFactura) Then
            Throw New ArgumentException("IdFactura no puede estar vacío.")
        End If

        Try
            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlCommand("dbo.RecalcularFacturaPagos", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@IdFactura", SqlDbType.NVarChar, 15).Value = idFactura.Trim()

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As SqlException
            MsgBox("Error SQL al recalcular la factura:" & vbCrLf & ex.Message,
               MsgBoxStyle.Critical)

        Catch ex As Exception
            MsgBox("Error al recalcular la factura:" & vbCrLf & ex.Message,
               MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub BtnAsignarPago_Click(
    sender As Object,
    e As EventArgs
) Handles BtnAsignarPago.Click

        If FacturaBindingSource.Current Is Nothing Then
            MsgBox("Seleccione una factura.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '========================================
        ' GUARDAR POSICIÓN ACTUAL
        '========================================
        Dim posicionActual As Integer = FacturaBindingSource.Position

        ' FACTURA SELECCIONADA
        Dim filaFactura As DataRowView =
        CType(FacturaBindingSource.Current, DataRowView)

        Dim idFactura As String = filaFactura("IdFactura").ToString()

        '========================================
        ' BUSCAR PAGOS VERDES (AUTOMÁTICOS)
        '========================================
        Dim pagosAAsignar As New List(Of DataGridViewRow)
        Dim idsProcesados As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

        For Each r As DataGridViewRow In dgvPagosCandidatos.Rows
            If r.IsNewRow Then Continue For
            If r.DefaultCellStyle.BackColor = Color.LightGreen Then
                pagosAAsignar.Add(r)
            End If
        Next

        '========================================
        ' SI NO HAY VERDES → USAR SELECCIONADO
        '========================================
        If pagosAAsignar.Count = 0 Then

            If dgvPagosCandidatos.CurrentRow Is Nothing Then
                MsgBox("Seleccione un pago para asignar.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            pagosAAsignar.Add(dgvPagosCandidatos.CurrentRow)

        End If

        '========================================
        ' ASIGNAR PAGOS
        '========================================
        Try
            Dim pagosAsignados As Integer = 0
            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                cn.Open()

                For Each filaPago As DataGridViewRow In pagosAAsignar
                    If filaPago.Cells("IdPagoClientesDetalle").Value Is Nothing _
                        OrElse IsDBNull(filaPago.Cells("IdPagoClientesDetalle").Value) Then
                        Continue For
                    End If

                    Dim idDetalle As String =
                    filaPago.Cells("IdPagoClientesDetalle").Value.ToString()

                    If String.IsNullOrWhiteSpace(idDetalle) Then
                        Continue For
                    End If

                    If idsProcesados.Contains(idDetalle) Then
                        Continue For
                    End If

                    idsProcesados.Add(idDetalle)

                    Dim estadoFactura As String = String.Empty
                    If filaPago.Cells("IdFactura").Value IsNot Nothing _
                        AndAlso Not IsDBNull(filaPago.Cells("IdFactura").Value) Then
                        estadoFactura = filaPago.Cells("IdFactura").Value.ToString().Trim()
                    End If

                    If estadoFactura <> String.Empty AndAlso estadoFactura <> "Sin Factura" Then
                        MsgBox("El pago ya está asignado a otra factura.", MsgBoxStyle.Exclamation)
                        Continue For
                    End If

                    Try
                        Using cmd As New SqlCommand("sp_AsignarPagoFactura", cn)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@IdFactura", idFactura)
                            cmd.Parameters.AddWithValue("@IdPagoClientesDetalle", idDetalle)
                            cmd.ExecuteNonQuery()
                        End Using
                        pagosAsignados += 1
                    Catch ex As SqlException
                        MsgBox("El pago no existe o ya está asignado.", MsgBoxStyle.Exclamation)
                    End Try

                Next
            End Using
            If pagosAsignados > 0 Then
                MsgBox("Pago(s) asignado(s) correctamente.", MsgBoxStyle.Information)
            End If

            '========================================
            ' REFRESCAR Y VOLVER A LA MISMA FILA
            '========================================
            FacturaTableAdapter.Fill(DsFacturas.Factura)

            If posicionActual >= 0 AndAlso posicionActual < FacturaBindingSource.Count Then
                FacturaBindingSource.Position = posicionActual
            End If

            FacturaDataGridView_CellClick(Nothing, Nothing)

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        Catch ex As Exception
            MsgBox("Error inesperado: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub





    Private Sub FacturaDataGridView_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles FacturaDataGridView.CellClick

        If FacturaBindingSource.Current Is Nothing Then
            MsgBox("Seleccione una factura.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Tomar directamente del DataSet usando el BindingSource
        Dim filaActual As DataRowView =
        CType(FacturaBindingSource.Current, DataRowView)

        If filaActual.Row.IsNull("IdProyecto") Then
            MsgBox("La factura no tiene proyecto asignado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim idProyecto As String = filaActual("IdProyecto").ToString()

        '===========================================================
        ' CARGAR PagosClientesDetalle POR IdProyecto
        '===========================================================
        dgvPagosCandidatos.AutoGenerateColumns = True
        dgvPagosCandidatos.Columns.Clear()
        dgvPagosCandidatos.DataSource = Nothing

        Dim dt As New DataTable

        Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            Dim sql As String =
        "SELECT 
            IdPagoClientesDetalle,
            ID_Cobro,
            IdFactura,
            Id_Proyecto,
            Moneda,
            TotalPagado AS Monto,
            Fecha
         FROM PagosClientesDetalle
         WHERE Id_Proyecto = @IdProyecto
         ORDER BY Fecha DESC"

            Dim cmd As New SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@IdProyecto", idProyecto)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

        End Using

        '===========================================================
        ' FILTRAR SOLO LOS QUE TENGAN EXACTAMENTE "Sin Factura"
        '===========================================================
        Dim vista As New DataView(dt)
        vista.RowFilter = "IdFactura = 'Sin Factura'"

        dgvPagosCandidatos.DataSource = vista

        ' Formato monto si existe
        If dgvPagosCandidatos.Columns.Contains("Monto") Then
            dgvPagosCandidatos.Columns("Monto").DefaultCellStyle.Format = "N2"
            dgvPagosCandidatos.Columns("Monto").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight
        End If

        If filaActual.Row.IsNull("IdFactura") Then Exit Sub

        Dim idFactura As String = filaActual("IdFactura").ToString()
        CargarPagosFactura(idFactura)

        '===========================================================
        ' 🔑 ESTA LÍNEA ES LA QUE FALTABA
        '===========================================================
        EvaluarPagosCandidatosFactura()

    End Sub

    Private Sub BtnDesasignarPago_Click(
        sender As Object,
        e As EventArgs
    ) Handles BtnDesasignarPago.Click

        If dgvPagosAplicados.CurrentRow Is Nothing Then
            MsgBox("Seleccione un pago asignado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim filaPago = dgvPagosAplicados.CurrentRow
        Dim idDetalle As String =
            filaPago.Cells("IdPagoClientesDetalle").Value.ToString()

        Try
            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlCommand("sp_DesasignarPagoFactura", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@IdPagoClientesDetalle", idDetalle)

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Pago desasignado correctamente.", MsgBoxStyle.Information)

            ' Refrescar datos
            FacturaTableAdapter.Fill(DsFacturas.Factura)
            FacturaDataGridView_CellClick(Nothing, Nothing)

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        Catch ex As Exception
            MsgBox("Error inesperado: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub






#End Region
    Private Sub EvaluarPagosCandidatosFactura()

        ' Validaciones básicas
        If FacturaDataGridView.CurrentRow Is Nothing Then Exit Sub
        If dgvPagosCandidatos.Rows.Count = 0 Then Exit Sub
        If Not FacturaDataGridView.Columns.Contains("Pendiente") Then Exit Sub
        If Not dgvPagosCandidatos.Columns.Contains("Monto") Then Exit Sub

        Dim filaFactura = FacturaDataGridView.CurrentRow
        If IsDBNull(filaFactura.Cells("Pendiente").Value) Then Exit Sub

        ' Pendiente redondeado real
        Dim pendiente As Decimal =
        Math.Round(Convert.ToDecimal(filaFactura.Cells("Pendiente").Value), 2)

        ' Si no hay pendiente, no evaluar
        If pendiente <= 0D Then Exit Sub

        '--------------------------------------------------
        ' 1) Obtener montos de pagos candidatos
        '--------------------------------------------------
        Dim montos As New List(Of Decimal)
        Dim filas = New List(Of DataGridViewRow)

        For Each r As DataGridViewRow In dgvPagosCandidatos.Rows
            If r.IsNewRow Then Continue For

            Dim v = r.Cells("Monto").Value
            If v Is Nothing OrElse IsDBNull(v) Then Continue For

            montos.Add(Math.Round(Convert.ToDecimal(v), 2))
            filas.Add(r)
        Next

        If montos.Count = 0 Then Exit Sub

        '--------------------------------------------------
        ' 2) Limpiar colores previos de pagos
        '--------------------------------------------------
        For Each r As DataGridViewRow In dgvPagosCandidatos.Rows
            r.DefaultCellStyle.BackColor = Color.White
        Next

        '--------------------------------------------------
        ' 3) Evaluar combinación exacta y pintar pagos
        '--------------------------------------------------
        Dim indices As New List(Of Integer)

        If ExisteCombinacionExacta(montos, pendiente, indices) Then
            For Each i In indices
                If i >= 0 AndAlso i < filas.Count Then
                    filas(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        End If

    End Sub






    Private Function ExisteCombinacionExacta(
        montos As List(Of Decimal),
        objetivo As Decimal,
        ByRef indicesResultado As List(Of Integer)
    ) As Boolean

        indicesResultado = Nothing

        Dim target As Integer = CInt(Math.Round(objetivo * 100D))
        If target <= 0 Then Return False

        ' Montos en centavos con índice original
        Dim valores = montos.
            Select(Function(m, i) New With {
                .Valor = CInt(Math.Round(m * 100D)),
                .Index = i
            }).
            Where(Function(x) x.Valor > 0 AndAlso x.Valor <= target).
            ToList()

        ' Diccionario: suma -> índices usados
        Dim dp As New Dictionary(Of Integer, List(Of Integer))
        dp(0) = New List(Of Integer)

        For Each v In valores
            Dim snapshot = dp.ToList()

            For Each kv In snapshot
                Dim nuevaSuma = kv.Key + v.Valor

                If nuevaSuma > target Then Continue For
                If dp.ContainsKey(nuevaSuma) Then Continue For

                Dim nuevaLista = New List(Of Integer)(kv.Value)
                nuevaLista.Add(v.Index)

                dp(nuevaSuma) = nuevaLista

                If nuevaSuma = target Then
                    indicesResultado = nuevaLista
                    Return True
                End If
            Next
        Next

        Return False
    End Function



End Class
