
Module Utilidades

    Public Sub VerificarDatosFechaActual(dsTasa As DataSet, tasaAdapter As Object, Optional mostrarMensaje As Boolean = True)
        Try
            Dim fechaActual As Date = DateTime.Now.Date

            ' Llena el conjunto de datos con los datos para la fecha actual
            tasaAdapter.FillByIdFecha(dsTasa.Tables("Tasa"), fechaActual)

            ' Verifica si hay alguna fila en el conjunto de datos
            If dsTasa.Tables("Tasa").Rows.Count = 0 Then
                ' No hay datos para la fecha actual
                If mostrarMensaje Then
                    MsgBox("No hay datos para la fecha actual.")
                End If

                ' Abre el formulario FrmAdministrativas
                Dim frmAdmin As New FrmAdministrativas()
                frmAdmin.Show()
            End If
        Catch ex As Exception
            ' Muestra el mensaje de la excepción y la pila de llamadas.
            MsgBox($"Error: {ex.Message}{Environment.NewLine}{ex.StackTrace}")
        End Try
    End Sub

End Module





