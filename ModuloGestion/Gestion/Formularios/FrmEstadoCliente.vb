Public Class FrmEstadoCliente

#Region "Constantes de columnas (ajusta los índices si cambian)"
    ' Usa estos nombres en vez de números mágicos.
    Private Const COL_CONTRATADO As Integer = 23
    Private Const COL_PAGADO As Integer = 24
    Private Const COL_PENDIENTE As Integer = 25
    Private Const COL_MONEDA As Integer = 9
    ' ... (agrega aquí todos los índices de columnas que uses, con comentarios)
#End Region

#Region "Funciones Auxiliares"

    ''' <summary>
    ''' Convierte un valor a Double, devuelve 0 si es nulo o vacío.
    ''' </summary>
    Private Function ToDouble(valor As Object) As Double
        If IsDBNull(valor) OrElse valor Is Nothing OrElse valor.ToString.Trim = "" Then Return 0
        Return Convert.ToDouble(valor)
    End Function

    ''' <summary>
    ''' Divide dos valores y devuelve 0 si el divisor es 0.
    ''' </summary>
    Private Function SafeDivide(numerador As Object, denominador As Object) As Double
        Dim num = ToDouble(numerador)
        Dim den = ToDouble(denominador)
        If den = 0 Then Return 0
        Return num / den
    End Function

    ''' <summary>
    ''' Devuelve el valor de una celda DataGridView por nombre (más seguro que por índice).
    ''' </summary>
    Private Function GetCellValue(row As DataGridViewRow, colIndex As Integer) As Object
        If row Is Nothing OrElse colIndex >= row.Cells.Count Then Return 0
        Return row.Cells(colIndex).Value
    End Function

#End Region

#Region "Totales"

    ''' <summary>
    ''' Calcula y muestra los totales de contratado, pagado, pendiente y porcentaje saldado.
    ''' </summary>
    Sub Totales()
        Try
            Dim sumaContratado As Double = 0
            Dim sumaPagado As Double = 0
            Dim sumaPendiente As Double = 0

            For Each row As DataGridViewRow In PresupuestoDataGridView.Rows
                If Not row.IsNewRow Then
                    sumaContratado += ToDouble(GetCellValue(row, COL_CONTRATADO))
                    sumaPagado += ToDouble(GetCellValue(row, COL_PAGADO))
                    sumaPendiente += ToDouble(GetCellValue(row, COL_PENDIENTE))
                End If
            Next

            TxtContratado.Text = Format(sumaContratado, "#,##0.00")
            TxTTotalSaldado.Text = Format(sumaPagado, "#,##0.00")
            TxtSaldoPendiente.Text = Format(sumaPendiente, "#,##0.00")
            TxtPorciento.Text = If(sumaContratado <> 0, Format(sumaPagado / sumaContratado, "0.00%"), "0.00%")

        Catch ex As Exception
            MsgBox("Error al calcular totales: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Suma la columna 4 del detalle de pagos asignados al presupuesto seleccionado.
    ''' </summary>
    Sub TotalAsignado()
        Try
            Dim sumaTotal As Double = 0
            For Each row As DataGridViewRow In PagosClientesDetalleDataGridView.Rows
                If Not row.IsNewRow Then
                    sumaTotal += ToDouble(row.Cells(4).Value)
                End If
            Next
            TxtTotalAsignado.Text = Format(sumaTotal, "#,##0.00")
        Catch ex As Exception
            MsgBox("Error al calcular total asignado: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Filtros y Carga de Datos"

    ''' <summary>
    ''' Filtra el detalle de pagos por el presupuesto actualmente seleccionado.
    ''' </summary>
    Sub Filtrarpresupuesto()
        Try
            Dim presupuesto As String = DsPresupuestos.Presupuesto(PresupuestoBindingSource.Position).Id_Presupuesto
            PagosClientesDetalleTableAdapter.FillByIdPresupuesto(DsPagosClientesDetalle.PagosClientesDetalle, presupuesto)
        Catch ex As Exception
            MsgBox("Error al filtrar detalle de pagos: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Carga los presupuestos asociados a un proyecto seleccionado.
    ''' </summary>
    Sub FiltrarProyectoEstado()
        Try
            PresupuestoTableAdapter.FillByProyectoEstado(DsPresupuestos.Presupuesto, My.Forms.FrmProyectos.TxtIdProyecto.Text)
        Catch ex As Exception
            MsgBox("Error al filtrar por proyecto: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Filtra los datos por cliente y prepara la vista con totales y columnas en moneda local y dólar.
    ''' </summary>
    Sub FiltrarCliente()
        Try
            Dim idclientes As String = My.Forms.FrmCliente.Id_FiscalTextBox.Text
            PresupuestoTableAdapter.FillByProyectoEstado(DsPresupuestos.Presupuesto, My.Forms.FrmProyectos.TxtIdProyecto.Text)
            ClientesTableAdapter.FillByIdFiscal(DsClientes.Clientes, idclientes)
            PresupuestoTableAdapter.FillByRealizados(DsPresupuestos.Presupuesto, idclientes)
            ProyectosTableAdapter.FillByIdCliente(DsProyectos.Proyectos, idclientes)

            Me.Show()

            Dim filas As Integer = PresupuestoDataGridView.RowCount()
            If filas > 0 Then
                PresupuestoBindingSource.MoveFirst()
                For i As Integer = 0 To filas - 1
                    Dim row = PresupuestoDataGridView.CurrentRow
                    Dim moneda As String = CStr(GetCellValue(row, COL_MONEDA))

                    Try
                        If moneda = "US$" Then
                            ' Dólares: copia columnas de USD a columnas "locales" para cálculos y vistas homogéneas
                            row.Cells(21).Value = row.Cells(10).Value ' Total USD
                            row.Cells(22).Value = row.Cells(11).Value ' Adelanto USD
                            row.Cells(23).Value = row.Cells(12).Value ' Contratado USD
                            row.Cells(24).Value = row.Cells(13).Value ' Pagado USD
                            row.Cells(25).Value = row.Cells(14).Value ' Pendiente USD
                            row.Cells(26).Value = SafeDivide(row.Cells(13).Value, row.Cells(12).Value) ' % Saldado
                        ElseIf moneda = "RD$" Then
                            ' Pesos: copia columnas de RD$ a columnas "locales"
                            row.Cells(21).Value = row.Cells(15).Value
                            row.Cells(22).Value = row.Cells(16).Value
                            row.Cells(23).Value = row.Cells(17).Value
                            row.Cells(24).Value = row.Cells(19).Value
                            row.Cells(25).Value = row.Cells(20).Value
                            row.Cells(26).Value = SafeDivide(row.Cells(19).Value, row.Cells(17).Value)
                        End If
                    Catch ex2 As Exception
                        MsgBox("Error al asignar moneda en fila " & i & ": " & ex2.Message)
                    End Try

                    PresupuestoBindingSource.MoveNext()
                Next
                Totales()
            End If

        Catch ex As Exception
            MsgBox("Error al filtrar por cliente: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos y UI"

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsClientes)
        Catch ex As Exception
            MsgBox("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmEstadoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        ' Si quieres cargar datos al inicio, puedes hacerlo aquí
    End Sub

    Private Sub PresupuestoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        Filtrarpresupuesto()
        TotalAsignado()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        With My.Forms.ImpEstadoCuentaCliente
            .Close()
            .Show()
            .ImprimirEstadoClientePorPago()
        End With
    End Sub

    Private Sub BtnPorPresupuesto_Click(sender As Object, e As EventArgs) Handles BtnPorPresupuesto.Click
        With My.Forms.ImpEstadoCuentaCliente
            .Close()
            .Label1.Text = Me.Id_FiscalTextBox.Text
            .Show()
            .ImprimirEstadoClientePorCliente()
        End With
    End Sub

    Private Sub BtnEstadoCompleto_Click(sender As Object, e As EventArgs) Handles BtnEstadoCompleto.Click
        With My.Forms.ImpEstadoCuentaCliente
            .Close()
            .Show()
            .ImprimirEstadoCompleto()
        End With
    End Sub

    Private Sub ProyectosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProyectosDataGridView.CellClick
        ' Por claridad, comprueba que haya al menos dos columnas y que la columna 2 sea la que debe accionar el informe
        If e.ColumnIndex = 2 AndAlso ProyectosDataGridView.CurrentRow IsNot Nothing Then
            With My.Forms.ImpEstadoCuentaCliente
                .Close()
                .Label2.Text = Me.DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Id_Proyecto
                .Label3.Text = Me.DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Id_Fiscal
                .Show()
                .ImprimirEstadoProyecto()
            End With
        End If
    End Sub

#End Region

End Class
