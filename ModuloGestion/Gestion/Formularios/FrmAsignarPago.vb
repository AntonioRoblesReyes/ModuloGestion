Imports System.Math
Public Class FrmAsignarPago

    Sub FiltraPago()
        Try



            Dim pago As String = My.Forms.FrmPagosClientes.DsPagosClientes.PagosClientes(My.Forms.FrmPagosClientes.PagosClientesBindingSource.Position).ID_Cobro
            Dim cliente As String = My.Forms.FrmPagosClientes.Id_FiscalTextBox.Text
            Me.PagosClientesTableAdapter.FillByIdCobro(Me.DsPagosClientes.PagosClientes, pago)
            Me.PresupuestoTableAdapter.FillByPendientePagos(Me.DsPresupuestos.Presupuesto, cliente)


            Me.Show()
            Datapresupuesto()
        Catch ex As Exception
            MsgBox("AQUI  " & ex.Message)
        End Try
    End Sub

    Sub Datapresupuesto()


        Dim filas As Integer = Me.PresupuestoDataGridView.RowCount
        If filas <> 0 Then


            Me.PresupuestoBindingSource.MoveFirst()



            Dim f As Integer
            For f = 0 To filas - 1
                Dim moneda As String = Me.PresupuestoDataGridView.CurrentRow.Cells("Moneda").Value

                If moneda = "RD$" Then

                    Me.PresupuestoDataGridView.CurrentRow.Cells("Total").Value = Me.PresupuestoDataGridView.CurrentRow.Cells("TotalRD").Value
                    Me.PresupuestoDataGridView.CurrentRow.Cells("Pagado").Value = Me.PresupuestoDataGridView.CurrentRow.Cells("PagadoRD").Value
                    Me.PresupuestoDataGridView.CurrentRow.Cells("Pendiente").Value = Me.PresupuestoDataGridView.CurrentRow.Cells("PendienteRDS").Value



                ElseIf moneda = "US$" Then
                    Me.PresupuestoDataGridView.CurrentRow.Cells("Total").Value = Me.PresupuestoDataGridView.CurrentRow.Cells("TotalUS").Value
                    Me.PresupuestoDataGridView.CurrentRow.Cells("Pagado").Value = Me.PresupuestoDataGridView.CurrentRow.Cells("PagadoUS").Value
                    Me.PresupuestoDataGridView.CurrentRow.Cells("Pendiente").Value = Me.PresupuestoDataGridView.CurrentRow.Cells("PendienteUS").Value

                Else
                    'MsgBox(Me.PresupuestoDataGridView.CurrentRow.Cells("Moneda").Value)
                End If
                Me.PresupuestoBindingSource.MoveNext()
            Next

        End If

    End Sub

    Private Sub BtnAsignar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAsignar.Click
        '---- helpers ----
        Dim SafeDec As Func(Of Object, Decimal) = Function(v As Object) As Decimal
                                                      If v Is Nothing OrElse v Is DBNull.Value Then Return 0D
                                                      Dim d As Decimal
                                                      If Decimal.TryParse(Convert.ToString(v), Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, d) Then Return d
                                                      If Decimal.TryParse(Convert.ToString(v), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, d) Then Return d
                                                      Return 0D
                                                  End Function
        Dim SafeStr As Func(Of Object, String) = Function(v As Object) As String
                                                     If v Is Nothing OrElse v Is DBNull.Value Then Return String.Empty
                                                     Return Convert.ToString(v).Trim()
                                                 End Function

        '---- validaciones básicas ----
        If PresupuestoDataGridView Is Nothing OrElse PresupuestoDataGridView.CurrentRow Is Nothing Then
            MessageBox.Show("No hay un presupuesto seleccionado.", "Asignar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim monto As Decimal
        If Not Decimal.TryParse(TextBox1.Text, Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, monto) AndAlso
       Not Decimal.TryParse(TextBox1.Text, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, monto) Then
            MessageBox.Show("El valor a asignar no es válido.", "Asignar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If monto <= 0D Then
            MessageBox.Show("El valor a asignar debe ser mayor a 0.", "Asignar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(ID_CobroTextBox.Text) Then
            MessageBox.Show("Falta el ID del cobro.", "Asignar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim r As DataGridViewRow = PresupuestoDataGridView.CurrentRow

        '---- lecturas según tu diseñador ----
        Dim idPresupuesto As String = r.Cells("Presupuesto").Value

        Dim pagadoUS As Decimal = SafeDec(r.Cells("PagadoUS").Value)
        Dim pendUS As Decimal = SafeDec(r.Cells("PendienteUS").Value)
        Dim pagadoRD As Decimal = SafeDec(r.Cells("PagadoRD").Value)
        Dim pendRD As Decimal = SafeDec(r.Cells("PendienteRD").Value)
        Dim tasa As Decimal = SafeDec(r.Cells("tasa").Value)
        Dim proyecto As String = SafeStr(r.Cells("Proyecto").Value)
        Dim monedaPago As String = SafeStr(Me.MonedaTextBox.Text)
        If String.IsNullOrEmpty(monedaPago) Then monedaPago = SafeStr(r.Cells("Moneda").Value)

        '---- cálculo equivalentes por MONEDA DEL PAGO ----
        Dim incrUS As Decimal, incrRD As Decimal
        If monedaPago.ToUpper().Contains("US") Then
            incrUS = monto
            incrRD = monto * tasa
        Else
            If tasa <= 0D Then
                MessageBox.Show("La tasa debe ser mayor a 0 para convertir RD$ ↔ US$.", "Asignar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            incrRD = monto
            incrUS = monto / tasa
        End If

        ' Nuevos valores
        Dim nuevoPagadoUS As Decimal = pagadoUS + incrUS
        Dim nuevoPendUS As Decimal = If(pendUS - incrUS < 0D, 0D, pendUS - incrUS)
        Dim nuevoPagadoRD As Decimal = pagadoRD + incrRD
        Dim nuevoPendRD As Decimal = If(pendRD - incrRD < 0D, 0D, pendRD - incrRD)

        Try
            '==== 🔹 LIMPIAR DATASET antes de insertar ====
            Me.DsPagosClientesDetalle.PagosClientesDetalle.Clear()

            '---- generar ID siguiente ----
            Dim Siguiente As String = Me.PagosClientesDetalleTableAdapter.SiguienteAsignado(ID_CobroTextBox.Text)

            Me.PagosClientesDetalleTableAdapter.AnexarPagpDetalle(Siguiente, ID_CobroTextBox.Text, proyecto, "", idPresupuesto, monedaPago, TextBox1.Text, FechaTextBox.Text)



            '==== 🔹 LIMPIAR NUEVAMENTE TRAS INSERTAR ====
            Me.DsPagosClientesDetalle.PagosClientesDetalle.Clear()

            '---- actualizar cabecera de cobro ----
            Me.PagosClientesTableAdapter.FillByIdCobro(Me.DsPagosClientes.PagosClientes, ID_CobroTextBox.Text)
            Dim totalAsignado As Decimal = SafeDec(Me.PagosClientesDetalleTableAdapter.TotalAsignado(ID_CobroTextBox.Text))

            Dim cobrado As Decimal = 0D
            If My.Forms.FrmPagosClientes IsNot Nothing AndAlso
           My.Forms.FrmPagosClientes.PagosClientesDataGridView IsNot Nothing AndAlso
           My.Forms.FrmPagosClientes.PagosClientesDataGridView.CurrentRow IsNot Nothing Then
                cobrado = SafeDec(My.Forms.FrmPagosClientes.PagosClientesDataGridView.CurrentRow.Cells(3).Value)
            End If

            Me.PagosClientesTableAdapter.ActulizarAsignado(CDbl(totalAsignado), CDbl(cobrado - totalAsignado), ID_CobroTextBox.Text)

            '---- refrescar datos ----
            My.Forms.FrmPagosClientes.PagosClientesTableAdapter.FillByIdCliente(
            My.Forms.FrmPagosClientes.DsPagosClientes.PagosClientes,
            My.Forms.FrmPagosClientes.Id_FiscalTextBox.Text
        )
            Me.PagosClientesDetalleTableAdapter.FillByIdPresupuesto(Me.DsPagosClientesDetalle.PagosClientesDetalle, idPresupuesto)

            '---- actualizar presupuesto ----
            Me.PresupuestoTableAdapter.ActualizarPago(
            CDbl(nuevoPagadoUS),
            CDbl(nuevoPendUS),
            CDbl(nuevoPagadoRD),
            CDbl(nuevoPendRD),
            idPresupuesto
        )

            '---- refrescar visual ----
            r.Cells("PagadoUS").Value = nuevoPagadoUS
            r.Cells("PendienteUS").Value = nuevoPendUS
            r.Cells("PagadoRD").Value = nuevoPagadoRD
            r.Cells("PendienteRD").Value = nuevoPendRD

            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()
            Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos.Presupuesto)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al asignar el pago: " & ex.Message, "Asignar pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub PresupuestoDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        Try
            Dim ParaAsignar As Double = Val(Me.PresupuestoDataGridView.CurrentRow.Cells("Pendiente").Value)
            Dim pendienteA As Double = PendienteAsignarTextBox.Text

            If pendienteA >= ParaAsignar Then
                Me.TextBox1.Text = Format(ParaAsignar, "#,##0.00")
            Else
                Me.TextBox1.Text = Format(pendienteA, "#,##0.00")
            End If
        Catch ex As Exception
            MsgBox("Error al calcular el monto a asignar: " & ex.Message)
        End Try
    End Sub



    Private Sub FrmAsignarPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
        TextBox1.Text = 0
    End Sub
    Private Sub PresupuestoDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)


        If e.RowIndex < 0 Then Return
        If e.ColumnIndex < 0 Then Return

        Dim row As DataGridViewRow = PresupuestoDataGridView.Rows(e.RowIndex)
        Dim drv As DataRowView = TryCast(row.DataBoundItem, DataRowView)
        If drv Is Nothing Then Return
        Dim dr As DataRow = drv.Row

        ' Moneda de la fila
        Dim mon As String = If(dr.Table.Columns.Contains("Moneda") AndAlso Not dr.IsNull("Moneda"),
                           Convert.ToString(dr("Moneda")).Trim(), "")
        Dim isUSD As Boolean = (String.Equals(mon, "US$", StringComparison.OrdinalIgnoreCase) _
                         OrElse String.Equals(mon, "USD", StringComparison.OrdinalIgnoreCase) _
                         OrElse mon.ToUpperInvariant().Contains("DOLAR"))

        ' Helper local para leer decimales de forma segura
        Dim GetVal As Func(Of String, Decimal) =
        Function(col As String) As Decimal
            If Not dr.Table.Columns.Contains(col) OrElse dr.IsNull(col) Then Return 0D
            Dim d As Decimal
            If Decimal.TryParse(Convert.ToString(dr(col), Globalization.CultureInfo.CurrentCulture),
                                Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, d) Then
                Return d
            End If
            Return 0D
        End Function

        Select Case PresupuestoDataGridView.Columns(e.ColumnIndex).Name

            Case "colVTotal"
                If isUSD Then
                    e.Value = If(dr.Table.Columns.Contains("TotalUS"),
                             GetVal("TotalUS"),
                             GetVal("SubTotalUS") + GetVal("ValorImpuestoUs")) ' <- ValorImpuestoUs (Us)
                Else
                    e.Value = If(dr.Table.Columns.Contains("TotalPresupuestoRD"),
                             GetVal("TotalPresupuestoRD"),
                             GetVal("SubTotalRD") + GetVal("ValorImpuestoRD"))
                End If
                e.FormattingApplied = True

            Case "colVPagado"
                If isUSD Then
                    e.Value = If(dr.Table.Columns.Contains("PagadoUS"),
                             GetVal("PagadoUS"),
                             GetVal("PagadoUS"))
                Else
                    e.Value = If(dr.Table.Columns.Contains("PagadoRD"),
                             GetVal("PagadoRD"),
                             GetVal("Pagado"))
                End If
                e.FormattingApplied = True

            Case "colVPendiente"
                If isUSD Then
                    Dim pen As Decimal = If(dr.Table.Columns.Contains("PendienteUS"), GetVal("PendienteUS"), 0D)
                    If pen = 0D Then
                        Dim tot = If(dr.Table.Columns.Contains("TotalUS"),
                                 GetVal("TotalUS"),
                                 GetVal("SubTotalUS") + GetVal("ValorImpuestoUs")) ' <- ValorImpuestoUs (Us)
                        Dim pag = If(dr.Table.Columns.Contains("PagadoUS"),
                                 GetVal("PagadoUS"),
                                 GetVal("PagadoUS"))
                        pen = tot - pag
                    End If
                    e.Value = pen
                Else
                    Dim pen As Decimal = If(dr.Table.Columns.Contains("PendienteRDS"), GetVal("PendienteRDS"), 0D)
                    If pen = 0D Then
                        Dim tot = If(dr.Table.Columns.Contains("TotalRD"),
                                 GetVal("TotalRD"),
                                 GetVal("SubTotalRD") + GetVal("ValorImpuestoRD"))
                        Dim pag = If(dr.Table.Columns.Contains("PagadoRD"),
                                 GetVal("PagadoRD"),
                                 GetVal("Pagado"))
                        pen = tot - pag
                    End If
                    e.Value = pen
                End If
                e.FormattingApplied = True

        End Select
    End Sub


End Class