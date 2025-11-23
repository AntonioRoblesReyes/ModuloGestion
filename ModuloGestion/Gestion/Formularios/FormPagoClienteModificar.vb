Public Class FormPagoClienteModificar
    Sub ActulizarPago()
        Dim valorTextBox3 As Double
        Dim valorTextBox2 As Double

        ' Mensaje para ObservacionesTextBox
        Me.ObservacionesTextBox.Text = "Se recibieron " & String.Format("{0:N2}", CDbl(TextBox1.Text)) & " Pesos Dominicanos. Se le ha aplicado a una tasa de " & TasaTextBox.Text & " que es la media de compraventa del Banco de la República Dominicana."

        ' Convertir el valor de TextBox3 a un número doble
        If Double.TryParse(TextBox3.Text, valorTextBox3) Then
            Me.ValorTextBox.Text = valorTextBox3.ToString()
            Me.AsignadoTextBox.Text = valorTextBox3.ToString()
        Else
            ' Manejar el caso en que TextBox3 no contenga un número válido
            MessageBox.Show("El valor en TextBox3 no es un número válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Salir de la operación si la conversión falla
            Exit Sub
        End If

        ' Convertir el valor de TextBox2 a un número doble
        If Double.TryParse(TextBox2.Text, valorTextBox2) Then
            Me.TasaTextBox.Text = valorTextBox2.ToString()
        Else
            ' Manejar el caso en que TextBox2 no contenga un número válido
            MessageBox.Show("El valor en TextBox2 no es un número válido.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Salir de la operación si la conversión falla
            Exit Sub
        End If

        ' Realizar validación y actualización de datos
        Try
            Me.Validate()
            Me.PagosClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)
            ' Operación completada con éxito
            MessageBox.Show("Operación completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Manejar cualquier otra excepción durante la actualización
            MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Sub CambioPagoDetalle()
        Dim numeroDeFilas As Integer = PagosClientesDetalleDataGridView.RowCount

        If numeroDeFilas = 1 Then
            ' Verifica que haya al menos una fila antes de intentar acceder a la celda
            If PagosClientesDetalleDataGridView.CurrentRow IsNot Nothing Then
                PagosClientesDetalleDataGridView.CurrentRow.Cells(2).Value = TextBox3.Text
            End If
        End If

        Me.Validate()
        Me.PagosClientesDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub
    Sub CambioPago()
        Try
            ' Verificar si TextBox1 y TextBox2 tienen datos válidos
            If Not String.IsNullOrEmpty(TextBox1.Text) AndAlso Not String.IsNullOrEmpty(TextBox2.Text) Then
                ' Verificar si los valores en TextBox1 y TextBox2 son números válidos
                If Double.TryParse(TextBox1.Text, Nothing) AndAlso Double.TryParse(TextBox2.Text, Nothing) Then
                    ' Convertir los valores a números y realizar la división
                    Dim valor1 As Double = Double.Parse(TextBox1.Text)
                    Dim valor2 As Double = Double.Parse(TextBox2.Text)

                    ' Verificar si el divisor (valor2) no es cero antes de realizar la división
                    If valor2 <> 0 Then
                        ' Realizar la división y verificar si el resultado es un número válido
                        Dim resultado As Double
                        If Double.TryParse((valor1 / valor2).ToString(), resultado) Then
                            ' Redondear el resultado a dos decimales
                            Dim resultadoRedondeado As Double = Math.Round(resultado, 2)

                            ' Mostrar el resultado redondeado en TextBox3
                            TextBox3.Text = resultadoRedondeado.ToString()
                        Else
                            ' Manejar el caso en el que el resultado no es un número válido
                            MessageBox.Show("La división produjo un resultado no válido.")
                        End If

                    Else
                        ' Manejar la división entre cero
                        MessageBox.Show("No se puede dividir entre cero.")
                    End If
                Else
                    ' Manejar valores no válidos
                    MessageBox.Show("Ingrese números válidos en TextBox1 y TextBox2.")
                End If
            Else
                ' Manejar la falta de datos en TextBox1 o TextBox2
                MessageBox.Show("Ingrese valores en TextBox1 y TextBox2.")
            End If
        Catch ex As Exception
            ' Manejar cualquier otra excepción
            MessageBox.Show("Error al realizar la división: " & ex.Message)
        End Try


    End Sub
    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PagosClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub

    Private Sub FormPagoClienteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientes.PagosClientesDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesDetalleTableAdapter.FillByIdPago(Me.DsPagosClientes.PagosClientesDetalle, Label1.Text)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientes.PagosClientes' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesTableAdapter.FillByIdCobro(Me.DsPagosClientes.PagosClientes, Label1.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CambioPago()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ActulizarPago()
        CambioPagoDetalle()
    End Sub
End Class