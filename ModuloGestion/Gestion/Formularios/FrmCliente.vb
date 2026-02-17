Imports System.Globalization

Public Class FrmCliente
    Public Sub MostrarComoHijoMDI()
        If Me.MdiParent Is Nothing Then
            Me.MdiParent = My.Forms.FrmGestion
            Me.Dock = DockStyle.Fill
        End If

        If Not Me.Visible Then
            Me.Show()
        Else
            Me.BringToFront()
        End If
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)



        ProyectosDataGridView.Columns("ver").Width = 50

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IO.Directory.Exists(CarpetaDatosTextBox.Text) Then
            Process.Start("explorer.exe", CarpetaDatosTextBox.Text)
        Else
            MsgBox("La carpeta no existe.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub PagosClientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DvgPagoCliente.CellClick

        Dim Pago As String = DsPagosClientes.PagosClientes(PagosClientesBindingSource.Position).ID_Cobro
        PagosClientesDetalleTableAdapter.FillByIdCobro(DsPagosClientesDetalle.PagosClientesDetalle, Pago)
        SumarAsignadoPorMoneda()

    End Sub


    Sub Saldopendiente()
        Dim PendienteRD, PendienteUS, TotalUS, PagadoUS, TotalRD, PagadoRD As Double

        For Each row As DataGridViewRow In PresupuestoDataGridView.Rows
            If row.IsNewRow OrElse row.Cells.Count < 10 Then Continue For

            Dim moneda As String = row.Cells("Moneda").Value?.ToString()
            If moneda = "RD$" Then
                TotalRD += Val(row.Cells("totalrd").Value)
                PagadoRD += Val(row.Cells("pagdord").Value)
                PendienteRD += Val(row.Cells("PendienteRd").Value)
            ElseIf moneda = "US$" Then
                TotalUS += Val(row.Cells("TotalUS").Value)
                PagadoUS += Val(row.Cells("PagadoUS").Value)
                PendienteUS += Val(row.Cells("PendienteUS").Value)
            End If
        Next

        Label6.Text = Format(PendienteUS, "#,###,##0.00")
        Label12.Text = Format(PendienteRD, "#,###,##0.00")
        Label14.Text = Format(TotalUS, "#,###,##0.00")
        Label15.Text = Format(PagadoUS, "#,###,##0.00")
        Label16.Text = Format(TotalRD, "#,###,##0.00")
        Label17.Text = Format(PagadoRD, "#,###,##0.00")

        Label22.Text = If(TotalUS = 0, "0.00%", (PagadoUS / TotalUS).ToString("P2"))
        Label21.Text = If(TotalRD = 0, "0.00%", (PagadoRD / TotalRD).ToString("P2"))
    End Sub
    Sub Rellearpresupuesto()
        For Each fila As DataGridViewRow In PresupuestoDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim moneda As String = fila.Cells("Moneda").Value?.ToString()

            If moneda = "RD$" Then
                fila.Cells("Total").Value = fila.Cells(PresupuestoDataGridView.Columns("TotalRd").Index).Value
                fila.Cells("Pagado").Value = fila.Cells(PresupuestoDataGridView.Columns("PagadoRd").Index).Value
                fila.Cells("Pendiente").Value = fila.Cells(PresupuestoDataGridView.Columns("PendienteRD").Index).Value
                fila.Cells("PagadoP").Value = fila.Cells(PresupuestoDataGridView.Columns("PagadoRd").Index).Value / fila.Cells(PresupuestoDataGridView.Columns("TotalRd").Index).Value
            ElseIf moneda = "US$" Then
                fila.Cells("Total").Value = fila.Cells(PresupuestoDataGridView.Columns("TotalUS").Index).Value
                fila.Cells("Pagado").Value = fila.Cells(PresupuestoDataGridView.Columns("PagadoUS").Index).Value
                fila.Cells("Pendiente").Value = fila.Cells(PresupuestoDataGridView.Columns("PendienteUS").Index).Value
                fila.Cells("PagadoP").Value = fila.Cells(PresupuestoDataGridView.Columns("PagadoUS").Index).Value / fila.Cells(PresupuestoDataGridView.Columns("TotalUS").Index).Value
            End If
        Next
    End Sub




    Private Sub ProyectosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProyectosDataGridView.CellClick

        Try
            ' Validar que la fila sea válida
            If e.RowIndex < 0 OrElse ProyectosDataGridView.CurrentRow Is Nothing Then Exit Sub

            Cursor = Cursors.WaitCursor

            Dim proyectoId As String = DsProyectos.Proyectos(ProyectosBindingSource.Position).Id_Proyecto

            ' Solo hacer fill si no está ya cargado (opcional si tienes muchas filas)
            If Not String.IsNullOrEmpty(proyectoId) Then
                PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, proyectoId, "aprobado", "entregado", "entregado")
                PagosClientesDetalleTableAdapter.FillByProyectoPagos(DsPagosClientesDetalle.PagosClientesDetalle, proyectoId)
            End If
            Rellearpresupuesto()
            SumarAsignadoPorMoneda()
            SumarPresupuestoPorMoneda()

            ' Cálculos y actualizaciones
            LabelTotalRDAsignado.Text = ""




            'Abrir formulario si se hace clic en columna específica
            Select Case e.ColumnIndex
                Case 2 ' Ver proyecto
                    My.Forms.FrmProyectos.Close()
                    My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, proyectoId)
                    My.Forms.FrmProyectos.Show()

                Case 3 ' Estado de cuenta
                    My.Forms.ImpEstadoCuentaCliente.Close()
                    My.Forms.ImpEstadoCuentaCliente.Label2.Text = proyectoId
                    My.Forms.ImpEstadoCuentaCliente.Label3.Text = DsProyectos.Proyectos(ProyectosBindingSource.Position).Id_Fiscal
                    My.Forms.ImpEstadoCuentaCliente.Show()
                    My.Forms.ImpEstadoCuentaCliente.ImprimirEstadoProyecto()
            End Select

        Catch ex As Exception
            MsgBox("Error al seleccionar proyecto: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub



    Private Sub BtnEstadoCliente_Click(sender As System.Object, e As System.EventArgs) Handles BtnEstadoCliente.Click
        If String.IsNullOrWhiteSpace(Id_FiscalTextBox.Text) Then
            MsgBox("Debe seleccionar un cliente antes de ver el estado.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Si el formulario ya está abierto, solo lo traemos al frente
        If My.Forms.FrmEstadoCliente.Visible Then
            My.Forms.FrmEstadoCliente.BringToFront()
        Else
            My.Forms.FrmEstadoCliente.Show()
        End If

        ' Si el método FiltrarCliente requiere el ID, pásalo como argumento
        My.Forms.FrmEstadoCliente.FiltrarCliente()
    End Sub

    Private Sub BtnPagos_Click(sender As Object, e As EventArgs) Handles BtnPagos.Click
        If String.IsNullOrWhiteSpace(Id_FiscalTextBox.Text) Then
            MsgBox("Debe seleccionar un cliente antes de ver los pagos.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' Si el formulario ya está abierto, solo lo traemos al frente
            If My.Forms.FrmPagosClientes.Visible Then
                My.Forms.FrmPagosClientes.BringToFront()
            Else
                My.Forms.FrmPagosClientes.Show()
            End If

            My.Forms.FrmPagosClientes.ClientesTableAdapter.FillByIdFiscal(My.Forms.FrmPagosClientes.DsClientes.Clientes, Id_FiscalTextBox.Text)
            My.Forms.FrmPagosClientes.PagosClientesTableAdapter.FillByIdCliente(My.Forms.FrmPagosClientes.DsPagosClientes.PagosClientes, Id_FiscalTextBox.Text)
            My.Forms.FrmPagosClientes.Id_FiscalTextBox.Text = Id_FiscalTextBox.Text
            My.Forms.FrmPagosClientes.Nombre_ClienteTextBox.Text = Nombre_ClienteTextBox.Text
            My.Forms.FrmPagosClientes.PagosClientes()
        Catch ex As Exception
            MsgBox("Error al cargar los pagos del cliente: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CmdNuevoProyecto_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevoProyecto.Click
        If String.IsNullOrWhiteSpace(Id_FiscalTextBox.Text) Then
            MsgBox("Debe seleccionar un cliente antes de crear un nuevo proyecto.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Si el formulario ya está abierto, solo lo traemos al frente
        If My.Forms.FrmProyectoCliente.Visible Then
            My.Forms.FrmProyectoCliente.BringToFront()
        Else
            My.Forms.FrmProyectoCliente.Show()
        End If

        My.Forms.FrmProyectoCliente.ProyectosBindingSource.AddNew()
        My.Forms.FrmProyectoCliente.Id_FiscalTextBox.Text = Id_FiscalTextBox.Text
        My.Forms.FrmProyectoCliente.Id_FiscalTextBox.Enabled = False
    End Sub
    Sub Cobrado()
        Dim PagadoRD As Double = 0
        Dim PagadoUS As Double = 0

        For Each fila As DataGridViewRow In DvgPagoCliente.Rows
            If fila.IsNewRow OrElse fila.Cells.Count < 4 Then Continue For

            Dim moneda As String = Convert.ToString(fila.Cells("Divisa").Value)
            Dim monto As Double = 0
            If Not IsDBNull(fila.Cells("Valor").Value) Then
                Double.TryParse(fila.Cells("Valor").Value.ToString(), monto)
            End If

            If moneda = "RD$" Then
                PagadoRD += monto
            ElseIf moneda = "US$" Then
                PagadoUS += monto
            End If
        Next

        Label11.Text = Format(PagadoRD, "#,###,##0.00")
        Label10.Text = Format(PagadoUS, "#,###,##0.00")
    End Sub


    Private Sub PresupuestoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        Try
            ' Validar que no se haya hecho clic en el encabezado
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

            Dim filaActual As DataGridViewRow = PresupuestoDataGridView.Rows(e.RowIndex)
            If filaActual Is Nothing Then Exit Sub

            Dim idPresObj As Object = filaActual.Cells("IdPresupuesto").Value
            If idPresObj Is Nothing OrElse IsDBNull(idPresObj) Then Exit Sub

            Dim idPres As String = idPresObj.ToString()

            ' Filtrar los detalles del presupuesto seleccionado
            PagosClientesDetalleTableAdapter.FillByIdPresupuesto(DsPagosClientesDetalle.PagosClientesDetalle, idPres)


            Dim colName As String = PresupuestoDataGridView.Columns(e.ColumnIndex).Name

            If colName = "Ir" Then
                With FrmPresupuestos
                    .Label10.Text = idPres
                    .PorPresupuesto()
                    .Show()
                    .BringToFront()
                End With
            ElseIf colName = "EstadoP" Then
                With FrmPresupuestos
                    My.Forms.ImpEstadoCuentaCliente.Close()
                    My.Forms.ImpEstadoCuentaCliente.Show()

                    My.Forms.ImpEstadoCuentaCliente.Label3.Text = idPres


                    My.Forms.ImpEstadoCuentaCliente.ImprimirEstadoPresupuesto()
                End With
            End If
        Catch ex As Exception
            MsgBox("Error al seleccionar presupuesto: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        SumarAsignadoPorMoneda()
        FiltrarPresupuesto()
    End Sub

    Private Sub FiltrarFactura()

        ' Validar fila actual
        If PagosClientesDetalleDataGridView.CurrentRow Is Nothing Then Exit Sub

        ' Validar columna
        If Not PagosClientesDetalleDataGridView.Columns.Contains("IdFacturaPd") Then Exit Sub

        ' Obtener IdFactura
        Dim idFactura As String =
        PagosClientesDetalleDataGridView.CurrentRow.Cells("IdFacturaPd").Value?.ToString()

        If String.IsNullOrWhiteSpace(idFactura) Then Exit Sub

        ' Cargar detalle de factura
        FacturaDetalleTableAdapter.FillByIdFactura(
        DsFacturas.FacturaDetalle,
        idFactura
    )

    End Sub


    Private Sub FiltrarPresupuesto()

        ' Validar fila actual
        If PresupuestoDataGridView.CurrentRow Is Nothing Then Exit Sub

        ' Validar columna
        If Not PresupuestoDataGridView.Columns.Contains("IdPresupuesto") Then Exit Sub

        ' Obtener IdPresupuesto
        Dim idPresupuesto As String =
        PresupuestoDataGridView.CurrentRow.Cells("IdPresupuesto").Value?.ToString()

        If String.IsNullOrWhiteSpace(idPresupuesto) Then Exit Sub

        ' Cargar detalle del presupuesto
        PresupuestoDetalleTableAdapter.FillByIdPresupuesto(
        DsPresupuestoDetalle.PresupuestoDetalle,
        idPresupuesto
    )

    End Sub



    Private Sub BtnGuardarCliente_Click(sender As Object, e As EventArgs) Handles BtnGuardarCliente.Click
        Try
            If String.IsNullOrWhiteSpace(Id_FiscalTextBox.Text) OrElse String.IsNullOrWhiteSpace(Nombre_ClienteTextBox.Text) Then
                MsgBox("Debe completar al menos el Id Fiscal y el Nombre del cliente.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsClientes)

            ' === CREAR CARPETA DE CLIENTE ===
            Dim nombreCliente As String = Nombre_ClienteTextBox.Text.Trim
            ' Quita caracteres inválidos para nombres de carpeta (Windows)
            For Each c As Char In IO.Path.GetInvalidFileNameChars()
                nombreCliente = nombreCliente.Replace(c, "_")
            Next

            Dim rutaCarpeta As String = "\\PCShernia\d\Carpeta Datos\Proyectos\" & nombreCliente

            If Not IO.Directory.Exists(rutaCarpeta) Then
                IO.Directory.CreateDirectory(rutaCarpeta)
            End If

            ' Guardar la ruta en el campo CarpetaDatos si quieres dejarla registrada
            CarpetaDatosTextBox.Text = rutaCarpeta
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsClientes)

            MsgBox("Cliente guardado correctamente." & vbCrLf &
                  MsgBoxStyle.Information)

            ' Mostrar todos los controles y ocultar el botón de guardar
            For Each ctrl As Control In Me.Controls
                ctrl.Visible = True
            Next
            BtnGuardarCliente.Visible = False

        Catch ex As Exception
            MsgBox("Error al guardar el cliente: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub VerCliente()

        Dim Cliente As String = My.Forms.FrmVerClientes.DsClientes.Clientes(My.Forms.FrmVerClientes.ClientesBindingSource.Position).Id_Fiscal

        Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, Cliente)
        Me.ProyectosTableAdapter.FillByIdCliente(Me.DsProyectos.Proyectos, Cliente)
        Me.PagosClientesTableAdapter.FillByIdCliente(Me.DsPagosClientes.PagosClientes, Cliente)
        Cobrado()
    End Sub
    Sub SumarAsignadoPorMoneda()
        Dim TotalRD As Double = 0
        Dim TotalUS As Double = 0

        For Each fila As DataGridViewRow In PagosClientesDetalleDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim moneda As String = ""
            If Not IsDBNull(fila.Cells("Divisa1").Value) Then
                moneda = fila.Cells("Divisa1").Value.ToString().Trim()
            End If

            Dim monto As Double = 0
            If Not IsDBNull(fila.Cells("TotalAsignado").Value) Then
                Double.TryParse(fila.Cells("TotalAsignado").Value.ToString(), monto)
            End If

            If moneda = "RD$" Then
                TotalRD += monto
            ElseIf moneda = "US$" Then
                TotalUS += monto
            End If
        Next

        ' Asignar a los labels correctos
        LabelTotalRDAsignado.Text = Format(TotalRD, "#,##0.00")
        LabelTotalUSAsignado.Text = Format(TotalUS, "#,##0.00")
    End Sub
    Sub SumarPresupuestoPorMoneda()
        Dim TotalRD As Double = 0
        Dim TotalUS As Double = 0
        Dim PagadoRD As Double = 0
        Dim PagadoUS As Double = 0
        Dim PendienteRD As Double = 0
        Dim PendienteUS As Double = 0

        For Each fila As DataGridViewRow In PresupuestoDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim moneda As String = ""
            If Not IsDBNull(fila.Cells("Moneda").Value) Then
                moneda = fila.Cells("Moneda").Value.ToString().Trim()
            End If

            Dim total As Double = 0
            Dim pagado As Double = 0
            Dim pendiente As Double = 0

            If Not IsDBNull(fila.Cells("Total").Value) Then
                Double.TryParse(fila.Cells("Total").Value.ToString(), total)
            End If
            If Not IsDBNull(fila.Cells("Pagado").Value) Then
                Double.TryParse(fila.Cells("Pagado").Value.ToString(), pagado)
            End If
            If Not IsDBNull(fila.Cells("Pendiente").Value) Then
                Double.TryParse(fila.Cells("Pendiente").Value.ToString(), pendiente)
            End If

            If moneda = "RD$" Then
                TotalRD += total
                PagadoRD += pagado
                PendienteRD += pendiente
            ElseIf moneda = "US$" Then
                TotalUS += total
                PagadoUS += pagado
                PendienteUS += pendiente
            End If
        Next

        ' Asignar los resultados a los Labels ya definidos en el Designer
        Label14.Text = Format(TotalUS, "#,##0.00")
        Label15.Text = Format(PagadoUS, "#,##0.00")
        Label6.Text = Format(PendienteUS, "#,##0.00")

        Label16.Text = Format(TotalRD, "#,##0.00")
        Label17.Text = Format(PagadoRD, "#,##0.00")
        Label12.Text = Format(PendienteRD, "#,##0.00")

        ' Calcular porcentajes de pago
        Label22.Text = If(TotalUS = 0, "0.00%", (PagadoUS / TotalUS).ToString("P2"))
        Label21.Text = If(TotalRD = 0, "0.00%", (PagadoRD / TotalRD).ToString("P2"))
    End Sub



    Private Function ParseDecimal(ByVal value As Object) As Decimal
        ' Manejo robusto de números con distintos separadores y símbolos
        If value Is Nothing OrElse IsDBNull(value) Then Return 0D

        If TypeOf value Is Decimal Then Return DirectCast(value, Decimal)
        If TypeOf value Is Double OrElse TypeOf value Is Single Then Return Convert.ToDecimal(value)

        Dim s As String = value.ToString().Trim()
        If s = "" Then Return 0D

        ' --- Quitar símbolos de moneda y espacios comunes ---
        Dim reemplazos() As String = {"US$", "RD$", "$", "USD", "RD"}
        For Each rep In reemplazos
            s = Replace(s, rep, "", , , CompareMethod.Text) ' CompareMethod.Text ignora mayúsculas/minúsculas
        Next
        s = s.Trim()

        ' --- Culturas a probar (orden razonable para DO/ES/EN) ---
        Dim cultures As CultureInfo() = {
        CultureInfo.GetCultureInfo("es-DO"),
        CultureInfo.GetCultureInfo("es-ES"),
        CultureInfo.GetCultureInfo("en-US"),
        CultureInfo.InvariantCulture
    }

        Dim styles As NumberStyles = NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint Or NumberStyles.AllowLeadingSign
        Dim result As Decimal

        ' --- Intentar parsear con las culturas definidas ---
        For Each ci In cultures
            If Decimal.TryParse(s, styles, ci, result) Then
                Return result
            End If
        Next

        ' --- Intento final: normalizar manualmente (quitar miles y usar punto decimal) ---
        Dim decSepCandidates As Char() = {","c, "."c}
        For Each decSep In decSepCandidates
            Dim other As Char = If(decSep = ","c, "."c, ","c)
            Dim t As String = s.Replace(" ", "")
            ' Si contiene ambos, asumimos que el 'other' es separador de miles
            If t.Contains(other) AndAlso t.Contains(decSep) Then
                t = t.Replace(other.ToString(), "")
            End If
            t = t.Replace(decSep, "."c)
            If Decimal.TryParse(t, NumberStyles.Number, CultureInfo.InvariantCulture, result) Then
                Return result
            End If
        Next

        ' --- Si no se pudo parsear, devolver 0 ---
        Return 0D
    End Function


    Private Sub VerificarPagosPresupuestos()
        Try
            ' === Verificar selección ===
            If PresupuestoDataGridView.CurrentRow Is Nothing Then
                MsgBox("Seleccione un presupuesto para verificar.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim fila As DataGridViewRow = PresupuestoDataGridView.CurrentRow
            Dim idPres As Object = fila.Cells("IdPresupuesto").Value
            If idPres Is Nothing OrElse IsDBNull(idPres) Then
                MsgBox("El presupuesto seleccionado no tiene un Id válido.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' === Datos del presupuesto (usar Decimal) ===
            Dim totalUS As Decimal = ParseDecimal(fila.Cells("TotalUS").Value)
            Dim totalRD As Decimal = ParseDecimal(fila.Cells("TotalRd").Value)
            Dim pagadoUS As Decimal = ParseDecimal(fila.Cells("PagadoUS").Value)
            Dim pagadoRD As Decimal = ParseDecimal(fila.Cells("PagadoRd").Value)
            Dim moneda As String = If(IsDBNull(fila.Cells("Moneda").Value), "", fila.Cells("Moneda").Value.ToString().Trim())

            ' === Totales realmente asignados (desde labels) ===
            Dim totalAsignadoUS As Decimal = ParseDecimal(LabelTotalUSAsignado.Text)
            Dim totalAsignadoRD As Decimal = ParseDecimal(LabelTotalRDAsignado.Text)

            ' Redondear a 2 decimales para comparar y guardar de forma consistente
            pagadoUS = Decimal.Round(pagadoUS, 2, MidpointRounding.AwayFromZero)
            pagadoRD = Decimal.Round(pagadoRD, 2, MidpointRounding.AwayFromZero)
            totalAsignadoUS = Decimal.Round(totalAsignadoUS, 2, MidpointRounding.AwayFromZero)
            totalAsignadoRD = Decimal.Round(totalAsignadoRD, 2, MidpointRounding.AwayFromZero)
            totalUS = Decimal.Round(totalUS, 2, MidpointRounding.AwayFromZero)
            totalRD = Decimal.Round(totalRD, 2, MidpointRounding.AwayFromZero)

            Dim cambiado As Boolean = False

            If moneda = "US$" Then
                If pagadoUS <> totalAsignadoUS Then
                    fila.Cells("PagadoUS").Value = totalAsignadoUS
                    fila.Cells("PendienteUS").Value = Decimal.Round(totalUS - totalAsignadoUS, 2, MidpointRounding.AwayFromZero)
                    cambiado = True
                End If
            ElseIf moneda = "RD$" Then
                If pagadoRD <> totalAsignadoRD Then
                    fila.Cells("PagadoRd").Value = totalAsignadoRD
                    fila.Cells("PendienteRD").Value = Decimal.Round(totalRD - totalAsignadoRD, 2, MidpointRounding.AwayFromZero)
                    cambiado = True
                End If
            Else
                ' Si por alguna razón hay otra moneda, intentamos ajustar ambas por seguridad
                Dim mod1 As Boolean = (pagadoUS <> totalAsignadoUS)
                Dim mod2 As Boolean = (pagadoRD <> totalAsignadoRD)
                If mod1 Then
                    fila.Cells("PagadoUS").Value = totalAsignadoUS
                    fila.Cells("PendienteUS").Value = Decimal.Round(totalUS - totalAsignadoUS, 2, MidpointRounding.AwayFromZero)
                End If
                If mod2 Then
                    fila.Cells("PagadoRd").Value = totalAsignadoRD
                    fila.Cells("PendienteRD").Value = Decimal.Round(totalRD - totalAsignadoRD, 2, MidpointRounding.AwayFromZero)
                End If
                cambiado = mod1 OrElse mod2
            End If

            If cambiado Then
                ' Guardar y refrescar totales
                Me.Validate()
                Me.PresupuestoBindingSource.EndEdit()
                Me.TableAdapterManager4.UpdateAll(Me.DsPresupuestos)

                ' Recalcular sumarios visuales
                SumarPresupuestoPorMoneda()

                MsgBox("Pagos y saldos del presupuesto fueron verificados y ajustados correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Los pagos asignados coinciden con los valores del presupuesto. No se requiere ajuste.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error al verificar pagos del presupuesto: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub PagosClientesDetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PagosClientesDetalleDataGridView.CellClick
        FiltrarFActura()
    End Sub
End Class
