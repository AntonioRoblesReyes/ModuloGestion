
Imports System.IO

Public Class FrmPagosMomtajeResumen
    Sub Sumar()
        Dim SuBtotal As Double = 0
        Dim Itebis As Double = 0
        Dim Total As Double = 0
        Dim iTotal As Integer = PagoMontajeDataGridView.Rows.Count

        If iTotal <> 0 Then

            Try



                For Each row As DataGridViewRow In Me.PagoMontajeDataGridView.Rows
                    SuBtotal += Val(row.Cells(3).Value)
                    Itebis += Val(row.Cells(4).Value)
                    Total += Val(row.Cells(5).Value)
                Next




                Me.TxtSubtotal.Text = Format(SuBtotal, "#,##0.00")
                Me.TxtItebis.Text = Format(Itebis, "#,##0.00")
                Me.TxtTotal.Text = Format(Total, "#,##0.00")




            Catch ex As Exception
                MsgBox(ex.Message & "     este")

            End Try
        Else
            Me.TxtSubtotal.Text = Format(0, "#,##0.00")
            Me.TxtItebis.Text = Format(0, "#,##0.00")
            Me.TxtTotal.Text = Format(0, "#,##0.00")
        End If
    End Sub
    Private Sub PagoMontajeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PagoMontajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagoMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmEstadoMontajes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter1.Fill(Me.DsPresupuestos.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontajeDetalle' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.EmpresasContratadasMontaje' Puede moverla o quitarla según sea necesario.
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsPagosMontaje.Presupuesto)
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)
        Sumar()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.PagoMontajeTableAdapter.FillByIdFiltro(Me.DsPagosMontaje.PagoMontaje, "%" & TextBox1.Text & "%")
        Sumar()
    End Sub

    Private Sub PagoMontajeDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PagoMontajeDataGridView.CellClick
        Dim pago As String = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
        Me.PagoMontajeDetalleTableAdapter.FillByIdPago(Me.DsPagosMontaje.PagoMontajeDetalle, pago)

        Me.Label5.Text = Me.DsPagosMontaje.EmpresasContratadasMontaje(EmpresasContratadasMontajeBindingSource.Position).RazonSocial
        If e.ColumnIndex = 8 Then
            My.Forms.ImpPagoMomtaje.Close()
            My.Forms.ImpPagoMomtaje.Label1.Text = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje

            My.Forms.ImpPagoMomtaje.ImprimirPagomontaje()

        ElseIf e.ColumnIndex = 9 Then
            Dim estado As Integer = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).PendienteAsignar
            If estado <> 0 Then


                My.Forms.FrmAsignarPagoMontaje.Close()
                My.Forms.FrmAsignarPagoMontaje.IdPagoMontajeTextBox.Text = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
                My.Forms.FrmAsignarPagoMontaje.IdEmpresaMontajeTextBox.Text = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdEmpresaMontaje


                My.Forms.FrmAsignarPagoMontaje.AsignarPago()
            Else
                MsgBox("Este pago ya se realizo")
                'My.Forms.ImpPagoMomtaje.Close()
                'My.Forms.ImpPagoMomtaje.Label1.Text = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
                'My.Forms.ImpPagoMomtaje.Show()
            End If
        ElseIf e.ColumnIndex = 10 Then
            My.Forms.FrmPagoMontaje.Close()
            'Dim Pago As String = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
            My.Forms.FrmPagoMontaje.IdPagoMontajeTextBox.Text = pago
            My.Forms.FrmPagoMontaje.ModificarPago()

            'My.Forms.FrmPagosMontaje.Show()
        ElseIf e.ColumnIndex = 11 Then



            Dim comprobante As String = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
            Dim fila As Integer = Me.PagoMontajeDataGridView.CurrentCell.RowIndex
            MsgBox(fila)


            Me.PagoMontajeTableAdapter.AñadirComprobante(comprobante, comprobante)
            Me.PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)
            Me.PagoMontajeDataGridView.CurrentCell = Me.PagoMontajeDataGridView.Rows(fila).Cells(11)

            If File.Exists(My.Computer.Name & "\\d\ModuloGestion\Recibos Montaje\" & comprobante & ".pdf") Then


                System.Diagnostics.Process.Start(My.Computer.Name & "\\d\ModuloGestion\Recibos Montaje\" & comprobante & ".pdf")
            Else

                Dim archivo As String
                OpenFileDialog1.ShowDialog()
                'Path.GetFileName(TxtIdherrajes.Text)
                archivo = OpenFileDialog1.FileName
                'Me.ImajenTextBox.Text = My.Computer.Name & "\\d\ModuloGestion\Recibos Montaje\" + Path.GetFileName(Me.OpenFileDialog1.FileName)



            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.FrmPagoMontaje.Close()
        My.Forms.FrmPagoMontaje.IdPagoMontajeTextBox.Text = (Me.PagoMontajeTableAdapter.SiguientePago())
        My.Forms.FrmPagoMontaje.NuevoPago()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PresupuestoTableAdapter.Fill(Me.DsPagosMontaje.Presupuesto)
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)
        Sumar()
    End Sub

    Private Sub EmpresasContratadasMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasContratadasMontajeDataGridView.CellClick
        Dim empresa As String = Me.DsPagosMontaje.EmpresasContratadasMontaje(Me.EmpresasContratadasMontajeBindingSource.Position).IdEmpresaMontaje
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(DsPagosMontaje.PagoMontaje, empresa)
        Sumar()
    End Sub


End Class