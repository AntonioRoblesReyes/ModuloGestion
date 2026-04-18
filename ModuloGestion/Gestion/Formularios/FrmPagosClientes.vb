Imports System.Globalization
Public Class FrmPagosClientes
    Sub EliminarPagodetalle()

        Me.PagosClientesDetalleBindingSource.MoveFirst()

        For i As Integer = 0 To PagosClientesDetalleDataGridView.Rows.Count - 1
            Dim fila As DataGridViewRow = PagosClientesDetalleDataGridView.Rows(i)

            ' Verifica que no sea una nueva fila y que esté marcada para eliminar
            If Not fila.IsNewRow AndAlso Convert.ToBoolean(fila.Cells(5).Value) = True Then

                Dim IDcobroDetalle As String = fila.Cells(0).Value.ToString()
                Dim IDcobro As String = fila.Cells(1).Value.ToString()
                Dim presupuesto As String = fila.Cells(3).Value.ToString()
                Dim AsignadoDetalle As Double = CDbl(fila.Cells(4).Value)

                ' === Obtener valores del cobro actual ===
                Me.PagosClientesTableAdapter.FillByIdCobro(Me.DsPagosClientes.PagosClientes, IDcobro)

                Dim pago As Double = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).valor
                Dim asignadoActual As Double = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).Asignado

                ' Actualizar valores en PagosClientes
                Dim nuevoAsignado As Double = asignadoActual - AsignadoDetalle
                Dim nuevoPendiente As Double = pago - nuevoAsignado

                Me.PagosClientesTableAdapter.ActulizarAsignado(nuevoAsignado, nuevoPendiente, IDcobro)

                ' === Actualizar saldos del presupuesto ===
                Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, presupuesto)

                Dim moneda As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Moneda
                Dim tasa As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa

                Dim TotalUS As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).TotalPresupuestoUS
                Dim PagadoUS As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).PagadopresupuestoUS
                Dim TotalRD As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).TotalPresupuestoRD
                Dim PagadoRD As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position)._PagadoRD_

                If moneda = "RD$" Then
                    Me.PresupuestoTableAdapter.ActulizarSaldo(
                    PagadoUS - (AsignadoDetalle / tasa),
                    TotalUS - PagadoUS + (AsignadoDetalle / tasa),
                    PagadoRD - AsignadoDetalle,
                    TotalRD - PagadoRD + AsignadoDetalle,
                    presupuesto)
                ElseIf moneda = "US$" Then
                    Me.PresupuestoTableAdapter.ActulizarSaldo(
                    PagadoUS - AsignadoDetalle,
                    TotalUS - PagadoUS + AsignadoDetalle,
                    PagadoRD - (AsignadoDetalle * tasa),
                    TotalRD - PagadoRD + (AsignadoDetalle * tasa),
                    presupuesto)
                End If

                ' === Eliminar detalle ===
                Me.PagosClientesDetalleTableAdapter.EliminarPagoDetalle(IDcobroDetalle)

            End If
        Next

        ' Recargar datos actualizados
        Me.PagosClientesTableAdapter.FillByIdCliente(Me.DsPagosClientes.PagosClientes, Id_FiscalTextBox.Text)
    End Sub

    Sub PagosClientes()
        Try
            Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)
            Me.PagosClientesTableAdapter.FillByIdCliente(Me.DsPagosClientes.PagosClientes, Id_FiscalTextBox.Text)
            FiltrarDetalle()
            Me.Show()
        Catch ex As Exception
            Me.Show()
        End Try


    End Sub

    Sub TotalAsignadoDetalle()
        Try
            Me.PagosClientesDetalleBindingSource.MoveFirst()

            Dim totalAsignado As Decimal = 0D

            For Each fila As DataGridViewRow In PagosClientesDetalleDataGridView.Rows

                If fila.IsNewRow Then Continue For

                If fila.Cells(4).Value IsNot Nothing AndAlso
               Not IsDBNull(fila.Cells(4).Value) Then

                    Dim valor As Decimal

                    If Decimal.TryParse(
                    fila.Cells(4).Value.ToString(),
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    valor) Then

                        totalAsignado += valor
                    End If
                End If
            Next

            TextBox4.Text = totalAsignado.ToString("N2", CultureInfo.CurrentCulture)

            Me.ClientesTableAdapter.FillByIdFiscal(
            Me.DsClientes.Clientes,
            My.Forms.FrmCliente.Id_FiscalTextBox.Text)

        Catch ex As Exception
            TextBox4.Text = 0D.ToString("N2", CultureInfo.CurrentCulture)
        End Try
    End Sub
    Sub TotalCobrado()
        Try
            Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, My.Forms.FrmCliente.Id_FiscalTextBox.Text)
            Me.PagosClientesBindingSource.MoveFirst()

            Dim totalPagado As Decimal = 0D
            Dim totalAsignado As Decimal = 0D
            Dim totalPendiente As Decimal = 0D

            For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows

                If fila.IsNewRow Then Continue For

                If fila.Cells(3).Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells(3).Value) Then
                    totalPagado += Convert.ToDecimal(fila.Cells(3).Value)
                End If

                If fila.Cells(5).Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells(5).Value) Then
                    totalAsignado += Convert.ToDecimal(fila.Cells(5).Value)
                End If

                If fila.Cells(6).Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells(6).Value) Then
                    totalPendiente += Convert.ToDecimal(fila.Cells(6).Value)
                End If
            Next

            TextBox1.Text = totalPagado.ToString("N2", CultureInfo.CurrentCulture)
            TextBox2.Text = totalAsignado.ToString("N2", CultureInfo.CurrentCulture)
            TextBox3.Text = totalPendiente.ToString("N2", CultureInfo.CurrentCulture)

        Catch ex As Exception
            TextBox1.Text = 0D.ToString("N2", CultureInfo.CurrentCulture)
            TextBox2.Text = 0D.ToString("N2", CultureInfo.CurrentCulture)
            TextBox3.Text = 0D.ToString("N2", CultureInfo.CurrentCulture)
        End Try
    End Sub


    Sub ActualizarPagos()
        Me.PagosClientesTableAdapter.FillByIdCliente(DsPagosClientes.PagosClientes, Id_FiscalTextBox.Text)
        TotalCobrado()
    End Sub
    Sub FiltrarDetalle()

        Dim cobro As String = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro
        Me.PagosClientesDetalleTableAdapter.FillByIdCobro(Me.DsPagosClientesDetalle.PagosClientesDetalle, cobro)

        TotalAsignadoDetalle()
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsClientes)

    End Sub

    Private Sub FrmPagosClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)

    End Sub

    Private Sub FrmPagosClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestos.Presupuesto' Puede moverla o quitarla según sea necesario.

        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        TotalCobrado()
        CargarValoresMonto()
        AjustarAnchoColumnasPagos()

    End Sub

    Private Sub BtnNuevoPago_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevoPago.Click
        My.Forms.FrmIngresoCobro.Close()

        Dim siguientePago As String = Me.PagosClientesTableAdapter.SiguientePago(Id_FiscalTextBox.Text)

        My.Forms.FrmIngresoCobro.PagosClientesBindingSource.AddNew()
        My.Forms.FrmIngresoCobro.ID_CobroTextBox.Text = siguientePago
        My.Forms.FrmIngresoCobro.Id_FiscalTextBox.Text = Me.Id_FiscalTextBox.Text
        My.Forms.FrmIngresoCobro.FechaDateTimePicker.Value = Date.Now

        My.Forms.FrmIngresoCobro.Show()


    End Sub

    Private Sub BtnImprimirRecibo_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimirRecibo.Click
        Dim Asignado As Integer = PagosClientesDetalleDataGridView.Rows.Count
        If Asignado <> 0 Then



            My.Forms.InfReciboImgresos.Close()
            My.Forms.InfReciboImgresos.Label1.Text = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro
            My.Forms.InfReciboImgresos.Show()
            My.Forms.InfReciboImgresos.Imprimir()
        Else
            MsgBox("Debe Asignar un pago antes de imprimir")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Pendieteasignar As Double = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).PendienteAsignar

        If Pendieteasignar > 0 Then
            Try
                My.Forms.FrmAsignarPago.Close()

                My.Forms.FrmAsignarPago.FiltraPago()

            Catch ex As Exception
                My.Forms.FrmAsignarPago.Close()
                MsgBox("No hay Pago")

            End Try
        Else
            MsgBox("Ya asigno todo el pago")
        End If


    End Sub








    Private Sub PagosClientesDataGridView_UserDeletedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles PagosClientesDataGridView.UserDeletedRow
        Dim RegistrosAsociados As Integer = Me.PagosClientesDetalleDataGridView.RowCount
        Dim PAgo As String = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro

        If RegistrosAsociados = 0 Then
            Me.PagosClientesTableAdapter.EliminarPago(PAgo)

        Else
            If RegistrosAsociados > 1 Then
                MsgBox("Antes debe eliminar los " & RegistrosAsociados & " registros asociados")
            Else
                MsgBox("Antes debe eliminar el " & RegistrosAsociados & " registro asociado")
            End If


        End If
    End Sub

    Private Sub PagosClientesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PagosClientesDataGridView.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If PagosClientesDataGridView.CurrentRow Is Nothing Then Exit Sub

            FiltrarDetalle()

            Dim asignadoActual As Decimal = 0D
            Dim totalAsignado As Decimal = 0D
            Dim valorPago As Decimal = 0D

            ' Valor actual asignado
            If PagosClientesDataGridView.CurrentRow.Cells(5).Value IsNot Nothing AndAlso
           Not IsDBNull(PagosClientesDataGridView.CurrentRow.Cells(5).Value) Then

                Decimal.TryParse(
                PagosClientesDataGridView.CurrentRow.Cells(5).Value.ToString(),
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                asignadoActual)
            End If

            ' Valor de TextBox4 (por ejemplo 10.676,25)
            If Not Decimal.TryParse(
            TextBox4.Text,
            NumberStyles.Any,
            CultureInfo.CurrentCulture,
            totalAsignado) Then

                MessageBox.Show("No se pudo convertir el monto: " & TextBox4.Text)
                Exit Sub
            End If

            ' Valor total del pago
            If PagosClientesDataGridView.CurrentRow.Cells(3).Value IsNot Nothing AndAlso
           Not IsDBNull(PagosClientesDataGridView.CurrentRow.Cells(3).Value) Then

                Decimal.TryParse(
                PagosClientesDataGridView.CurrentRow.Cells(3).Value.ToString(),
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                valorPago)
            End If

            If asignadoActual <> totalAsignado Then

                PagosClientesDataGridView.CurrentRow.Cells(5).Value = totalAsignado
                PagosClientesDataGridView.CurrentRow.Cells(6).Value = valorPago - totalAsignado

                Me.Validate()
                Me.PagosClientesBindingSource.EndEdit()
                Me.PagosClientesTableAdapter.Update(Me.DsPagosClientes)

                MsgBox("Se actualizó el saldo")

                TotalCobrado()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el saldo: " & ex.Message)
        End Try
    End Sub

    Private Sub PagosClientesDetalleDataGridView_UserDeletedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles PagosClientesDetalleDataGridView.UserDeletedRow

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' Marcar todas las filas como seleccionadas para eliminar
        For Each fila As DataGridViewRow In PagosClientesDetalleDataGridView.Rows
            If Not fila.IsNewRow Then
                fila.Cells(5).Value = True
            End If
        Next

        ' Ejecutar eliminación
        EliminarPagodetalle()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.FormPagoClienteModificar.Close()
        My.Forms.FormPagoClienteModificar.Label1.Text = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro

        My.Forms.FormPagoClienteModificar.Show()

    End Sub
    Private Sub CargarValoresMonto()
        ' Limpiar los ítems existentes
        cmbFiltroMonto.Items.Clear()
        cmbFiltroMonto.Items.Add("Todos")

        ' Crear una lista temporal para almacenar los valores únicos
        Dim listaMontos As New HashSet(Of Double)()

        ' Recorrer las filas del DataGridView
        For Each row As DataGridViewRow In PagosClientesDataGridView.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("valor").Value) AndAlso IsNumeric(row.Cells("valor").Value) Then
                Dim valorMonto As Double = Convert.ToDouble(row.Cells("valor").Value)
                listaMontos.Add(valorMonto)
            End If
        Next

        ' Ordenar los valores y agregarlos al ComboBox
        For Each monto In listaMontos.OrderBy(Function(m) m)
            cmbFiltroMonto.Items.Add(monto)
        Next

        ' Seleccionar el primer elemento ("Todos")
        cmbFiltroMonto.SelectedIndex = 0
    End Sub

    Private Sub cmbFiltroMonto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroMonto.SelectedIndexChanged
        AplicarFiltroMonto()
    End Sub

    Private Sub AplicarFiltroMonto()
        ' Obtener el valor seleccionado
        Dim valorSeleccionado As String = cmbFiltroMonto.SelectedItem.ToString()

        ' Si se selecciona "Todos", se quita el filtro
        If valorSeleccionado = "Todos" Then
            PagosClientesBindingSource.RemoveFilter()
        Else
            ' Aplicar el filtro por monto
            Dim montoFiltrar As Double
            If Double.TryParse(valorSeleccionado, montoFiltrar) Then
                PagosClientesBindingSource.Filter = "valor = " & montoFiltrar.ToString(System.Globalization.CultureInfo.InvariantCulture)
            End If
        End If
    End Sub
    Private Sub AjustarAnchoColumnasPagos()
        Try
            With PagosClientesDataGridView
                ' Ejemplo de ajuste manual de columnas (puedes modificar según tus nombres)
                .Columns("ID_Cobro").Width = 100
                .Columns("Fecha").Width = 80
                .Columns("valor").Width = 75
                .Columns("Asignado").Width = 75
                .Columns("Sin_Asignar").Width = 75
                .Columns("Moneda").Width = 70
                .Columns("EliminarP").Width = 70

                ' Alinear columnas numéricas a la derecha EliminarP
                .Columns("valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("Asignado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("Sin_Asignar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
        Catch ex As Exception
            ' Silenciar errores si alguna columna no existe
        End Try
    End Sub
    Private Sub PagosClientesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles PagosClientesDataGridView.DataError
        e.ThrowException = False

        MessageBox.Show(
            "El número ingresado no tiene un formato válido." & vbCrLf &
            "Ejemplo correcto en tu PC: 10.676,25",
            "Formato incorrecto",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
    End Sub

End Class