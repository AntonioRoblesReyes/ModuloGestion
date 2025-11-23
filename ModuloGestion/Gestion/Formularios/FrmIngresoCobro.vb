Public Class FrmIngresoCobro

    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PagosClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub
    Sub verificarTasa()
        Try
            Dim fechaHoy As Date = Me.FechaDateTimePicker.Value

            ' Llenar el conjunto de datos y obtener la cantidad de registros
            Dim cantidadRegistros As Integer = Me.TasaTableAdapter.FillByIdFecha(DsTasa.Tasa, fechaHoy)

            ' Verificar si hay registros
            If cantidadRegistros > 0 Then
                ' Si hay registros, obtener la tasa del día y asignarla a TasaTextBox
                Dim tasaMedia As Double = Me.DsTasa.Tasa(TasaBindingSource.Position).Media
                Me.TasaTextBox.Text = tasaMedia
            Else
                ' Si no hay registros, verificar si el formulario FrmAdministrativas está abierto
                Dim administrativasForm As FrmAdministrativas = TryCast(Application.OpenForms("FrmAdministrativas"), FrmAdministrativas)

                If administrativasForm IsNot Nothing AndAlso administrativasForm.Visible Then
                    ' El formulario FrmAdministrativas está abierto, no hacer nada
                Else
                    ' El formulario FrmAdministrativas no está abierto, abrirlo
                    Dim newAdministrativasForm As New FrmAdministrativas()
                    newAdministrativasForm.Show()
                End If
            End If
        Catch ex As Exception
            ' Manejar cualquier excepción que ocurra durante la ejecución
            MessageBox.Show("Se ha producido un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmIngresoCobro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsTasa.Tasa' Puede moverla o quitarla según sea necesario.
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)
        'TODO: esta línea de código carga datos en la tabla 'DsMonedas.Monedas' Puede moverla o quitarla según sea necesario.
        Me.MonedasTableAdapter.Fill(Me.DsMonedas.Monedas)
        'TODO: esta línea de código carga datos en la tabla 'DsEmpresas.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientes.PagosClientes' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)
        Me.ComboBox1.SelectedIndex = 1
        Me.ComboBox2.SelectedIndex = 1

        Dim fechaHoy As Date
        fechaHoy = Date.Today
        Me.TasaTableAdapter.FillByIdFecha(DsTasa.Tasa, fechaHoy)
        verificarTasa()
        If ComboBox2.Text = "DOLARES AMERICANOS" Then
            Me.Label1.Text = "PESOS DOMINICANOS"
        ElseIf ComboBox2.Text = "PESOS DOMINICANOS" Then

            Me.Label1.Text = "DOLARES AMERICANOS"
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            Me.PagosClientesTableAdapter.NuevoPago(ID_CobroTextBox.Text, Id_FiscalTextBox.Text, FechaDateTimePicker.Value, CDbl(ValorTextBox.Text), 0, CDbl(ValorTextBox.Text), ComboBox1.SelectedValue, FormaDePagoComboBox.SelectedText, ObservacionesTextBox.Text, ComboBox2.SelectedValue)
            My.Forms.FrmPagosClientes.actualizarPagos()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            If ComboBox2.Text = "DOLARES AMERICANOS" Then
                Dim valor As Double = CDbl(MonedaRecibidaTextBox.Text) / CDbl(TasaTextBox.Text)
                Me.ValorTextBox.Text = Format(valor, "0.00")
                ObservacionesTextBox.Text = "Se recibieron " & String.Format("{0:N2}", CDbl(MonedaRecibidaTextBox.Text)) & " Pesos Dominicanos. Se le ha aplicado a una tasa de " & TasaTextBox.Text & " que es la media de compraventa del Banco de la República Dominicana."
            ElseIf ComboBox2.Text = "PESOS DOMINICANOS" Then
                Dim valor As Double = CDbl(MonedaRecibidaTextBox.Text) * CDbl(TasaTextBox.Text)
                Me.ValorTextBox.Text = Format(valor, "0.00")
                ObservacionesTextBox.Text = "Se recibieron " & String.Format("{0:N2}", CDbl(MonedaRecibidaTextBox.Text)) & " Dólares Americanos. Se le ha aplicado a una tasa de " & TasaTextBox.Text & " que es la media de compraventa del Banco de la República Dominicana."
            End If

        Catch ex As Exception

        End Try



    End Sub



    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text.Equals("DOLARES AMERICANOS") Then
            Me.Label1.Text = "PESOS"
        ElseIf ComboBox2.Text.Equals("PESOS DOMINICANOS") Then
            Me.Label1.Text = "DOLARES"
        End If

    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTimePicker.ValueChanged
        verificarTasa()
        Button2.PerformClick()

    End Sub
End Class