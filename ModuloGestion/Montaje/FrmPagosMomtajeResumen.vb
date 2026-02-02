Imports System.IO

Public Class FrmPagosMomtajeResumen

    '===========================================================
    '                    SUMAR TOTALES
    '===========================================================
    Sub Sumar()
        Dim SuBtotal As Decimal = 0D
        Dim Itebis As Decimal = 0D
        Dim Total As Decimal = 0D

        If PagoMontajeDataGridView.Rows.Count > 0 Then
            Try
                For Each row As DataGridViewRow In PagoMontajeDataGridView.Rows
                    If Not row.IsNewRow Then
                        SuBtotal += Convert.ToDecimal(If(row.Cells(3).Value, 0))
                        Itebis += Convert.ToDecimal(If(row.Cells(4).Value, 0))
                        Total += Convert.ToDecimal(If(row.Cells(5).Value, 0))
                    End If
                Next

                TxtSubtotal.Text = SuBtotal.ToString("#,##0.00")
                TxtItebis.Text = Itebis.ToString("#,##0.00")
                TxtTotal.Text = Total.ToString("#,##0.00")

            Catch ex As Exception
                MsgBox("Error sumando totales: " & ex.Message)
            End Try
        Else
            TxtSubtotal.Text = "0.00"
            TxtItebis.Text = "0.00"
            TxtTotal.Text = "0.00"
        End If
    End Sub


    '===========================================================
    '                     LOAD DEL FORM
    '===========================================================
    Private Sub FrmEstadoMontajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontajeDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.EmpresasContratadasMontaje' Puede moverla o quitarla según sea necesario.
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.EmpresasContratadasMontaje' Puede moverla o quitarla según sea necesario.
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontajeDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontaje' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeTableAdapter.FillByConSaldoPendiente(Me.DsPagosMontaje.PagoMontaje)


        Sumar()
    End Sub


    '===========================================================
    '                     BUSCAR POR FILTRO
    '===========================================================
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PagoMontajeTableAdapter.FillByIdFiltro(DsPagosMontaje.PagoMontaje, "%" & TextBox1.Text & "%")
        Sumar()
    End Sub


    '===========================================================
    '                     CLICK EN GRID PRINCIPAL
    '===========================================================
    Private Sub PagoMontajeDataGridView_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles PagoMontajeDataGridView.CellClick

        Try
            If e.RowIndex < 0 Then Exit Sub

            Dim pago As String =
            DsPagosMontaje.PagoMontaje(
                PagoMontajeBindingSource.Position).IdPagoMontaje

            PagoMontajeDetalleTableAdapter.FillByIdPago(
            DsPagosMontaje.PagoMontajeDetalle, pago)

            Label5.Text =
            DsPagosMontaje.EmpresasContratadasMontaje(
                EmpresasContratadasMontajeBindingSource.Position).RazonSocial

            Dim colName As String =
            PagoMontajeDataGridView.Columns(e.ColumnIndex).Name

            Select Case colName

                Case "Imprimir"
                    Using f As New ImpPagoMomtaje()
                        f.Label1.Text = pago
                        f.ImprimirPagomontaje()
                        'f.ShowDialog()
                    End Using

                Case "Asignar"

                    Dim estado As Decimal =
                        DsPagosMontaje.PagoMontaje(
                            PagoMontajeBindingSource.Position).PendienteAsignar

                    If estado > 0 Then
                        Using f As New FrmAsignarPagoMontaje()

                            ' Pasar datos al formulario
                            f.IdPagoMontajeTextBox.Text = pago
                            f.IdEmpresaMontajeTextBox.Text =
                                DsPagosMontaje.PagoMontaje(
                                    PagoMontajeBindingSource.Position).IdEmpresaMontaje

                            ' Cargar datos internos del formulario
                            f.AsignarPago()

                            ' Mostrar SIEMPRE como modal
                            If f.ShowDialog(Me) = DialogResult.OK Then
                                ' (opcional) refrescar pagos al volver
                                PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)
                            End If

                        End Using
                    Else
                        MsgBox("Este pago ya está completamente asignado.")
                    End If


                Case "Modificar"

                    Using f As New FrmPagoMontaje()

                        ' Pasar el pago a modificar
                        f.IdPagoMontajeTextBox.Text = pago

                        ' Preparar el formulario (NO mostrar)
                        f.ModificarPago()

                        ' Mostrar SIEMPRE como modal
                        If f.ShowDialog(Me) = DialogResult.OK Then
                            ' Refrescar pagos al cerrar (opcional pero recomendado)
                            PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)
                        End If

                    End Using


                Case "Comprobante"
                    Dim fila As Integer = e.RowIndex
                    Dim comprobante As String = pago

                    PagoMontajeTableAdapter.AñadirComprobante(comprobante, comprobante)
                    PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)

                    PagoMontajeDataGridView.CurrentCell =
                    PagoMontajeDataGridView.Rows(fila).Cells("Comprobante")

                    Dim ruta As String =
                    $"D:\ModuloGestion\Recibos Montaje\{comprobante}.pdf"

                    If File.Exists(ruta) Then
                        Process.Start(ruta)
                    ElseIf OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                        File.Copy(OpenFileDialog1.FileName, ruta, True)
                        Process.Start(ruta)
                    End If

            End Select

        Catch ex As Exception
            MsgBox("Error al seleccionar pago: " & ex.Message)
        End Try

    End Sub




    '===========================================================
    '                 BOTÓN NUEVO PAGO
    '===========================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With My.Forms.FrmPagoMontaje

            .IdPagoMontajeTextBox.Text = PagoMontajeTableAdapter.SiguientePago()
            .NuevoPago()
        End With
    End Sub


    Public Sub Recargar()
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)
        Sumar()
    End Sub


    '===========================================================
    '                 FILTRAR POR EMPRESA
    '===========================================================
    Private Sub EmpresasContratadasMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasContratadasMontajeDataGridView.CellClick
        Try
            Dim empresa As String =
                DsPagosMontaje.EmpresasContratadasMontaje(EmpresasContratadasMontajeBindingSource.Position).IdEmpresaMontaje

            PagoMontajeTableAdapter.FillByIdEmpresa(DsPagosMontaje.PagoMontaje, empresa)
            Sumar()

        Catch ex As Exception
            MsgBox("Error filtrando por empresa: " & ex.Message)
        End Try
    End Sub

    Private Sub PagoMontajeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PagoMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub



    Private Sub BtnPendientes_Click(sender As Object, e As EventArgs) Handles BtnPendientes.Click
        Me.PagoMontajeTableAdapter.FillByConSaldoPendiente(Me.DsPagosMontaje.PagoMontaje)
    End Sub

    Private Sub BtnFiltroTodos_Click(sender As Object, e As EventArgs) Handles BtnFiltroTodos.Click
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)
    End Sub
End Class
