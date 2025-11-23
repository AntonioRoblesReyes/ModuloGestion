Public Class FrmAvanceEmpleados
    Sub Avances()
        Me.AvanceEmpleadosTableAdapter.FillByCedula(Me.DsEmpleados.AvanceEmpleados, Me.CedulaTextBox.Text)
        Me.Show()
    End Sub
    Sub DetallePAgo()
        Dim Registros As Integer = Me.AvnceEmpleadosPagosDataGridView.Rows.Count

        Dim Columna As Integer = 0, Fila As Integer = 0

        If Registros = 0 Then
            Return
        End If

        Me.AvnceEmpleadosPagosDataGridView.CurrentCell = Me.AvnceEmpleadosPagosDataGridView(Columna, Fila)
        Dim a As Integer
        For a = 0 To Registros - 1
            Me.AvnceEmpleadosPagosDataGridView.CurrentCell = Me.AvnceEmpleadosPagosDataGridView(0, Fila)
            Dim IdDetallePago As String = Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(0).Value
            Dim IdPago As String = Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(1).Value
            Dim IdQuincena As String = Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(2).Value
            Dim Monto As Double = Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(3).Value



            Me.AvnceEmpleadosPagosTableAdapter.AnexarDetallePago(IdDetallePago, IdPago, IdQuincena, Monto, False, CedulaTextBox.Text)

            Dim v As Integer = Fila + 1
            Fila = v
        Next
    End Sub
    Sub NuevoAvance()
        Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)
        Me.IdAvanceEmpleadoTextBox.Text = Me.AvanceEmpleadosTableAdapter.SiguienteAvance(Me.CedulaTextBox.Text)
        Me.TxtAvance.Text = Format(0, "#,##0.00")


        Me.AvnceEmpleadosPagosDataGridView.DataSource = Nothing
        Me.Show()

    End Sub
    Private Sub AvanceEmpleadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.AvanceEmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub




    Private Sub FrmAvanceEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        'Me.AvanceEmpleadosTableAdapter.Fill(Me.DsEmpleados.AvanceEmpleados)

        'Me.NominasTableAdapter.Fill(Me.DsEmpleados.Nominas)

        'Me.AvnceEmpleadosPagosTableAdapter.Fill(Me.DsEmpleados.AvnceEmpleadosPagos)
    End Sub



    'Private Sub TxtAvance_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtAvance.Leave
    '    Me.TxtAvance.Text = Format(Me.TxtAvance.Text, "#.##0,00")
    'End Sub

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        If IsNumeric(TxtAvance.Text) AndAlso Convert.ToDecimal(TxtAvance.Text) >= 0 Then
            If TxtCheque.Text <> "" Then
                ' Se supone que aquí se inserta un nuevo avance en la base de datos
                Me.AvanceEmpleadosTableAdapter.NuevoAvance(IdAvanceEmpleadoTextBox.Text, Me.CedulaTextBox.Text, FechaAVanceDateTimePicker.Value, Me.TextBox1.Text, Convert.ToDecimal(TxtAvance.Text), 0, TxtCheque.Text, Convert.ToDecimal(TxtAvance.Text))
                DetallePAgo()
                Me.AvanceEmpleadosTableAdapter.FillByCedula(Me.DsEmpleados.AvanceEmpleados, Me.CedulaTextBox.Text)
                Me.AvnceEmpleadosPagosDataGridView.DataSource = Me.AvnceEmpleadosPagosBindingSource
                'My.Forms.ImpReciboNomina.imprirAvance()
            Else
                MsgBox("Debe poner el número de cheque")
            End If
        Else
            MsgBox("El Avance no puede ser 0 o un valor negativo. Por favor, ingrese una cantidad válida.")
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.ImpReciboNomina.Label1.Text = Me.AvanceEmpleadosDataGridView.CurrentRow.Cells(0).Value
        Me.AvnceEmpleadosPagosBindingSource.MoveFirst()
        Dim inicio As String = Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(2).Value
        My.Forms.ImpReciboNomina.Lblincio.Text = inicio
        Me.AvnceEmpleadosPagosBindingSource.MoveLast()
        Dim fin As String = Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(2).Value
        My.Forms.ImpReciboNomina.LblFin.Text = fin
        My.Forms.ImpReciboNomina.imprirAvance()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.AvnceEmpleadosPagosDataGridView.DataSource = Nothing
            Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)
            Me.AvnceEmpleadosPagosDataGridView.Rows.Clear()

            If IsNumeric(TxtAvance.Text) AndAlso IsNumeric(TextBox1.Text) Then
                Me.TextBox2.Text = Format(CDbl(CDbl(TxtAvance.Text) / CDbl(TextBox1.Text)), "#,##0.00")
                Dim Itotal As Integer = CInt(TextBox1.Text)

                For i As Integer = 0 To Itotal - 1
                    Me.AvnceEmpleadosPagosDataGridView.Rows.Add()
                Next

                Dim Registros As Integer = Me.AvnceEmpleadosPagosDataGridView.Rows.Count

                Dim Columna As Integer = 0, Fila As Integer = 0

                If Registros = 0 Then
                    Return
                End If

                Me.AvnceEmpleadosPagosDataGridView.CurrentCell = Me.AvnceEmpleadosPagosDataGridView(Columna, Fila)

                For a As Integer = 0 To Registros - 1
                    Dim nomina As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Quincena
                    Me.AvnceEmpleadosPagosDataGridView.CurrentCell = Me.AvnceEmpleadosPagosDataGridView(0, Fila)

                    Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(0).Value = Me.IdAvanceEmpleadoTextBox.Text & "-" & nomina
                    Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(1).Value = Me.IdAvanceEmpleadoTextBox.Text
                    Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(2).Value = nomina
                    Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(3).Value = Me.TextBox2.Text
                    Me.AvnceEmpleadosPagosDataGridView.CurrentRow.Cells(4).Value = False
                    Fila += 1
                    Me.NominasBindingSource.MoveNext()
                Next
            Else
                ' Manejar el caso donde los valores en TxtAvance o TextBox1 no son numéricos
                MsgBox("Los valores ingresados deben ser numéricos.")
            End If
        Catch ex As Exception
            MsgBox("Error al procesar los datos: " & ex.Message)
        End Try
    End Sub


    Private Sub AvanceEmpleadosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AvanceEmpleadosDataGridView.CellClick

        Dim IdPago As String = Me.DsEmpleados.AvanceEmpleados(Me.AvanceEmpleadosBindingSource.Position).IdAvanceEmpleado
        Me.AvnceEmpleadosPagosTableAdapter.FillByIdAvance(Me.DsEmpleados.AvnceEmpleadosPagos, IdPago)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NuevoAvance()
    End Sub


End Class