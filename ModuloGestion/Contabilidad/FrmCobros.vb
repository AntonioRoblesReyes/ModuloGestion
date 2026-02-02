
Imports System.IO


Public Class FrmCobros
    Sub PagoMoneda()
        Dim iTotal As Integer = Me.PagosClientesDataGridView.Rows.Count
        Try

            Me.PagosClientesBindingSource.MoveFirst()
            Dim i As Integer

            For i = 0 To iTotal - 1
                If Me.PagosClientesDataGridView.CurrentRow.Cells(5).Value = "RD$" Then
                    Me.PagosClientesDataGridView.CurrentRow.Cells(6).Value = Me.PagosClientesDataGridView.CurrentRow.Cells(4).Value
                    Me.PagosClientesDataGridView.CurrentRow.Cells(7).Value = 0
                ElseIf Me.PagosClientesDataGridView.CurrentRow.Cells(5).Value = "US$" Then
                    Me.PagosClientesDataGridView.CurrentRow.Cells(6).Value = 0
                    Me.PagosClientesDataGridView.CurrentRow.Cells(7).Value = Me.PagosClientesDataGridView.CurrentRow.Cells(4).Value
                End If
                'MsgBox(Me.PagosClientesDataGridView.CurrentRow.Cells(5).Value & "_" & Me.PagosClientesDataGridView.CurrentRow.Cells(4).Value)
                Me.PagosClientesBindingSource.MoveNext()
            Next

            Dim TotalRD As Double = 0
            Dim TotalUS As Double = 0
            Dim eTotal As Integer = Me.PagosClientesDataGridView.Rows.Count

            If eTotal <> 0 Then

                Try



                    For Each row As DataGridViewRow In Me.PagosClientesDataGridView.Rows
                        TotalRD += Val(row.Cells("RD").Value)
                        TotalUS += Val(row.Cells("US").Value)

                    Next
                    'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..

                    Me.Label2.Text = Format(TotalRD, "#,##0.00")
                    Me.Label4.Text = Format(TotalUS, "#,##0.00")



                Catch ex As Exception
                    MsgBox(ex.Message & "     este")

                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PagosClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub

    Private Sub FrmCobros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientesDetalle.PagosClientesDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesDetalleTableAdapter.Fill(Me.DsPagosClientesDetalle.PagosClientesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientes.PagosClientes' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)

        LlenarComboAño()
        'AplicarFiltroSoloAño()

        LlenarComboMesPorAño()

        PagoMoneda()
    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.InfReciboImgresos.Close()
        My.Forms.InfReciboImgresos.Label1.Text = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro
        My.Forms.InfReciboImgresos.Show()
        My.Forms.InfReciboImgresos.Imprimir()
    End Sub

    Private Sub FrmCobros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub



    Private Sub PagosClientesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PagosClientesDataGridView.CellClick
        Dim Pago As String = Me.DsPagosClientes.PagosClientes(Me.PagosClientesBindingSource.Position).ID_Cobro
        Me.PagosClientesDetalleTableAdapter.FillByIdCobro(Me.DsPagosClientesDetalle.PagosClientesDetalle, Pago)
        Dim total As Double = 0
        For Each row As DataGridViewRow In Me.PagosClientesDetalleDataGridView.Rows
            total += Val(row.Cells(4).Value)
        Next
        Me.Label5.Text = total.ToString
        Dim ValorPago As Double = Me.PagosClientesDataGridView.CurrentRow.Cells(4).Value.ToString
        If ValorPago <> Me.Label5.Text Then
            MsgBox("el registro no cuadra")
        End If
    End Sub
    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged
        AplicarFiltroSoloAño()
        LlenarComboMesPorAño()
    End Sub

    Private Sub AplicarFiltroSoloAño()
        Dim añoSeleccionado As String = cmbAño.Text
        Dim bs As BindingSource = PagosClientesDataGridView.DataSource

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim fecha As Date
            If Not Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) Then
                If bs Is Nothing OrElse bs.Position <> fila.Index Then
                    fila.Visible = False
                End If
                Continue For
            End If

            Dim visible As Boolean = (añoSeleccionado = "Todos") OrElse (fecha.Year.ToString() = añoSeleccionado)
            If bs Is Nothing OrElse bs.Position <> fila.Index Then
                fila.Visible = visible
            End If
        Next
        CalcularTotalesFiltrados()
    End Sub
    Private Sub LlenarComboMesPorAño()
        Dim añoSeleccionado As String = cmbAño.Text
        Dim mesesDisponibles As New HashSet(Of Integer)

        ' Recorre solo las filas visibles y no nuevas
        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow OrElse Not fila.Visible Then Continue For

            Dim fecha As Date
            If Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) Then
                ' Si el año coincide o es "Todos", agrega el mes
                If añoSeleccionado = "Todos" OrElse fecha.Year.ToString() = añoSeleccionado Then
                    mesesDisponibles.Add(fecha.Month)
                End If
            End If
        Next

        cmbMes.Items.Clear()
        cmbMes.Items.Add("Todos")
        ' Agrega los meses ordenados por número
        For Each mes As Integer In mesesDisponibles.OrderBy(Function(x) x)
            cmbMes.Items.Add(MonthName(mes, False)) ' False para nombre completo
        Next
        cmbMes.SelectedIndex = 0
    End Sub
    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        AplicarFiltroAñoYMes()
    End Sub

    Private Sub AplicarFiltroAñoYMes()
        Dim añoSeleccionado As String = cmbAño.Text
        Dim mesSeleccionado As String = cmbMes.Text
        Dim bs As BindingSource = TryCast(PagosClientesDataGridView.DataSource, BindingSource)

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim fecha As Date
            If Not Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) Then
                If bs Is Nothing OrElse bs.Position <> fila.Index Then
                    fila.Visible = False
                End If
                Continue For
            End If

            Dim mostrar As Boolean = True

            If añoSeleccionado <> "Todos" AndAlso fecha.Year.ToString() <> añoSeleccionado Then
                mostrar = False
            End If

            If mesSeleccionado <> "Todos" AndAlso MonthName(fecha.Month) <> mesSeleccionado Then
                mostrar = False
            End If

            If bs Is Nothing OrElse bs.Position <> fila.Index Then
                fila.Visible = mostrar
            End If
        Next
        CalcularTotalesFiltrados()
    End Sub


    Private Sub LlenarComboAño()
        Dim añosDisponibles As New HashSet(Of Integer)

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow Then Continue For

            Dim fecha As Date
            If Date.TryParse(fila.Cells("Fecha").Value?.ToString(), fecha) Then
                añosDisponibles.Add(fecha.Year)
            End If
        Next

        cmbAño.Items.Clear()
        cmbAño.Items.Add("Todos")
        For Each año As Integer In añosDisponibles.OrderBy(Function(x) x)
            cmbAño.Items.Add(año.ToString())
        Next
        cmbAño.SelectedIndex = 0
    End Sub
    Private Sub CalcularTotalesFiltrados()
        Dim totalRD As Double = 0
        Dim totalUS As Double = 0

        For Each fila As DataGridViewRow In PagosClientesDataGridView.Rows
            If fila.IsNewRow OrElse Not fila.Visible Then Continue For

            totalRD += Val(fila.Cells("RD").Value)
            totalUS += Val(fila.Cells("US").Value)

        Next

        Label2.Text = Format(totalRD, "#,##0.00") ' Total RD$
        Label4.Text = Format(totalUS, "#,##0.00") ' Total US$

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class