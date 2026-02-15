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
            Dim TotalAsignado As Double = 0
            Dim iTotalasignado As Integer = PagosClientesDetalleDataGridView.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            'Definimos la variable i para controlar el ciclo for
            Dim i As Integer
            'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
            For i = 0 To iTotalasignado - 1
                'Double.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
                'me.datagridview1(4,i).value <----toma todos los valores de la columna 4... 4 es el numero de columna y i es el numero de fila asi toma todos los 
                'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
                TotalAsignado += CDbl(PagosClientesDetalleDataGridView(4, i).Value)
            Next
            Me.TextBox4.Text = Format(TotalAsignado, "#,##0.00")

            Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, My.Forms.FrmCliente.Id_FiscalTextBox.Text)
        Catch ex As Exception
            Me.TextBox4.Text = Format(0, "#,##0.00")
        End Try
    End Sub
    Sub TotalCobrado()
        Try
            Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, My.Forms.FrmCliente.Id_FiscalTextBox.Text)
            Me.PagosClientesBindingSource.MoveFirst()

            Dim totalPagado As Double = 0
            Dim totalAsignado As Double = 0
            Dim totalPendiente As Double = 0
            Dim totalFilas As Integer = PagosClientesDataGridView.Rows.Count

            For i As Integer = 0 To totalFilas - 1
                totalPagado += CDbl(PagosClientesDataGridView(3, i).Value)     'Columna 3: Pagado
                totalAsignado += CDbl(PagosClientesDataGridView(5, i).Value)  'Columna 5: Asignado
                totalPendiente += CDbl(PagosClientesDataGridView(6, i).Value) 'Columna 6: Pendiente
            Next

            Me.TextBox1.Text = Format(totalPagado, "#,##0.00")
            Me.TextBox2.Text = Format(totalAsignado, "#,##0.00")
            Me.TextBox3.Text = Format(totalPendiente, "#,##0.00")

        Catch ex As Exception
            Me.TextBox1.Text = Format(0, "#,##0.00")
            Me.TextBox2.Text = Format(0, "#,##0.00")
            Me.TextBox3.Text = Format(0, "#,##0.00")
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
        FiltrarDetalle()
        Dim asignado As Double = CDbl(PagosClientesDataGridView.CurrentRow.Cells(5).Value)
        Dim TotalAsignado As Double = TextBox4.Text
        If asignado <> CDbl(TextBox4.Text) Then
            PagosClientesDataGridView.CurrentRow.Cells(5).Value = TextBox4.Text
            PagosClientesDataGridView.CurrentRow.Cells(6).Value = CDbl(PagosClientesDataGridView.CurrentRow.Cells(3).Value) - TotalAsignado

            Me.Validate()
            Me.PagosClientesBindingSource.EndEdit()
            Me.PagosClientesTableAdapter.Update(DsPagosClientes)
            MsgBox("Se actulizo el saldo")
        End If
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If PagosClientesDetalleDataGridView.CurrentRow Is Nothing OrElse PagosClientesDetalleDataGridView.CurrentRow.IsNewRow Then
                MsgBox("Seleccione un detalle de pago con presupuesto.")
                Exit Sub
            End If

            Dim idPresupuesto As String = Convert.ToString(PagosClientesDetalleDataGridView.CurrentRow.Cells(3).Value)
            If String.IsNullOrWhiteSpace(idPresupuesto) Then
                MsgBox("El detalle seleccionado no tiene presupuesto asignado.")
                Exit Sub
            End If

            Dim frm As New FrmEstadoPagosPresupuesto(idPresupuesto)
            frm.Show()
        Catch ex As Exception
            MsgBox("No se pudo abrir el estado de presupuesto: " & ex.Message)
        End Try
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


End Class