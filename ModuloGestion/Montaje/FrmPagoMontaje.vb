Public Class FrmPagoMontaje

    Public Sub ModificarPago()

        btnGuardar.Text = "Guardar Cambios"

        ' Cargar empresas para permitir cambiarla
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(
        Me.DsPagosMontaje.EmpresasContratadasMontaje)

        ' Cargar pago
        Me.PagoMontajeTableAdapter.FillByIdPago(
        Me.DsPagosMontaje.PagoMontaje,
        IdPagoMontajeTextBox.Text)

        ' El botón debe estar visible
        Me.btnGuardar.Visible = True

    End Sub



    Sub NuevoPago()
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        btnGuardar.Text = "Registrar Pago"

        ' Limpieza recomendada
        IdPagoMontajeTextBox.Clear()
        ValorTextBox.Text = "0,00"
        ObservacionesTextBox.Clear()
        FormaDePagoTextBox.Clear()

        Me.Show()
    End Sub

    Private Sub EmpresasContratadasMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasContratadasMontajeDataGridView.CellClick
        Me.IdEmpresaMontajeTextBox.Text =
            Me.DsPagosMontaje.EmpresasContratadasMontaje(Me.EmpresasContratadasMontajeBindingSource.Position).IdEmpresaMontaje
    End Sub



    Private Sub ValorTextBox_Leave(sender As Object, e As EventArgs) Handles ValorTextBox.Leave

    End Sub




    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Validar monto
            Dim monto As Decimal = ValorTextBox.Text


            ' ¿Es nuevo pago o modificación?
            Dim esNuevo As Boolean = String.IsNullOrWhiteSpace(IdPagoMontajeTextBox.Text)

            If esNuevo Then
                '===== NUEVO PAGO =====
                IdPagoMontajeTextBox.Text = PagoMontajeTableAdapter.SiguientePago()

                Me.PagoMontajeTableAdapter.NuevoPago(
                IdPagoMontajeTextBox.Text,
                IdEmpresaMontajeTextBox.Text,
                FechaDateTimePicker.Value,
                monto,
                0,
                monto,
                "IN",
                FormaDePagoTextBox.Text,
                ObservacionesTextBox.Text,
                MonedaTextBox.Text
            )

                MsgBox("Pago registrado correctamente.", MsgBoxStyle.Information)


            Else
                '===== MODIFICAR PAGO =====

                Dim Asignado As Decimal = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).Asignado
                Dim Pendiente As Decimal = monto - Asignado

                Me.PagoMontajeTableAdapter.Actualizar(
                IdEmpresaMontajeTextBox.Text,
                FechaDateTimePicker.Value,
                monto,
                Asignado,
                Pendiente,
                "IN",
                FormaDePagoTextBox.Text,
                ObservacionesTextBox.Text,
                MonedaTextBox.Text,
                IdPagoMontajeTextBox.Text
            )

                MsgBox("Pago modificado correctamente.", MsgBoxStyle.Information)
            End If

            ' Refrescar resumen
            My.Forms.FrmPagosMomtajeResumen.Recargar()


            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmPagoMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
