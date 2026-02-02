Public Class FormPagoClienteModificar

    Private Sub ActualizarPago()
        Dim montoPesos As Double
        Dim tasa As Double
        Dim valorCalculado As Double

        ' Validar y convertir TextBox1 (Monto en pesos)
        If Not Double.TryParse(TextBox1.Text.Trim().Replace(",", "."), montoPesos) Then
            MessageBox.Show("Ingrese un monto válido en pesos (TextBox1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' Validar y convertir TextBox2 (Tasa)
        If Not Double.TryParse(TextBox2.Text.Trim().Replace(",", "."), tasa) Then
            MessageBox.Show("Ingrese una tasa válida (TextBox2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' Validar TextBox3 (Monto convertido o asignado)
        If Not Double.TryParse(TextBox3.Text.Trim().Replace(",", "."), valorCalculado) Then
            MessageBox.Show("El valor convertido en TextBox3 no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' Actualiza cajas destino
        ValorTextBox.Text = valorCalculado.ToString("N2")
        AsignadoTextBox.Text = valorCalculado.ToString("N2")
        TasaTextBox.Text = tasa.ToString("N4")

        ' Observaciones siempre controladas
        ObservacionesTextBox.Text =
            $"Se recibieron {montoPesos.ToString("N2")} Pesos Dominicanos. " &
            $"Se le ha aplicado la tasa {tasa.ToString("N4")} correspondiente a la media ponderada de compra/venta del Banco Central."

        ' Guardar cambios
        Try
            Validate()
            PagosClientesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsPagosClientes)
            MessageBox.Show("Operación completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CambioPagoDetalle()
        Try
            If PagosClientesDetalleDataGridView.RowCount >= 1 AndAlso
               PagosClientesDetalleDataGridView.CurrentRow IsNot Nothing Then

                PagosClientesDetalleDataGridView.CurrentRow.Cells(2).Value = TextBox3.Text
            End If

            Validate()
            PagosClientesDetalleBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsPagosClientes)

        Catch ex As Exception
            MessageBox.Show("Error al actualizar detalle: " & ex.Message)
        End Try
    End Sub


    Private Sub CambioPago()
        Dim monto As Double
        Dim tasa As Double

        If Not Double.TryParse(TextBox1.Text.Trim().Replace(",", "."), monto) OrElse monto <= 0 Then
            MessageBox.Show("Ingrese un monto válido en pesos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Double.TryParse(TextBox2.Text.Trim().Replace(",", "."), tasa) OrElse tasa <= 0 Then
            MessageBox.Show("Ingrese una tasa válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim resultado As Double = monto / tasa
        TextBox3.Text = Math.Round(resultado, 2).ToString("N2")
    End Sub


    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PagosClientesBindingNavigatorSaveItem.Click
        Validate()
        PagosClientesBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DsPagosClientes)
    End Sub


    Private Sub FormPagoClienteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        PagosClientesDetalleTableAdapter.FillByIdPago(DsPagosClientes.PagosClientesDetalle, Label1.Text)
        PagosClientesTableAdapter.FillByIdCobro(DsPagosClientes.PagosClientes, Label1.Text)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CambioPago()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ActualizarPago()
        CambioPagoDetalle()
    End Sub

End Class
