Public Class FrmFacturasProveedor







    Sub Totales()
        Dim totalFacturas As Double = 0.0
        Dim totalFacturasSinPago As Double = 0.0

        For Each row As DataGridViewRow In Me.FacturaProveedorDataGridView.Rows
            If Not row.IsNewRow Then
                Dim valorCelda As Object = row.Cells("TotalDataGridViewTextBoxColumn").Value
                Dim formaDePago As String = String.Empty

                If row.Cells("FormaDePagoDataGridViewTextBoxColumn").Value IsNot Nothing AndAlso
                   Not IsDBNull(row.Cells("FormaDePagoDataGridViewTextBoxColumn").Value) Then
                    formaDePago = row.Cells("FormaDePagoDataGridViewTextBoxColumn").Value.ToString().Trim().ToUpperInvariant()
                End If

                ' Verificar si la celda no es nula y es un número válido
                If Not IsDBNull(valorCelda) AndAlso IsNumeric(valorCelda) Then
                    Dim totalFila As Double = Convert.ToDouble(valorCelda)
                    totalFacturas += totalFila

                    If String.IsNullOrWhiteSpace(formaDePago) OrElse
                        formaDePago = "SIN PAGO" OrElse
                        formaDePago = "PENDIENTE" OrElse
                        formaDePago = "CREDITO" Then
                        totalFacturasSinPago += totalFila
                    End If
                End If
            End If
        Next

        Me.TxtTotales.Text = totalFacturas.ToString("N2")
        Me.TxtTotalSinPago.Text = totalFacturasSinPago.ToString("N2")
    End Sub

    Sub Filtrar()
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

        Me.FacturaProveedorTableAdapter.Fill(Me.DsContabilidad.FacturaProveedor)
        Me.FacturaProveedorBindingSource.MoveLast()
    End Sub
    Private Sub FacturaProveedorBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)



    End Sub
    Private Sub FrmFacturasProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Establecer el formulario padre y maximizar
        MdiParent = My.Forms.FrmContabilidad
        Me.WindowState = FormWindowState.Maximized

        Try
            ' Cargar los datos de proveedores
            Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

            ' Cargar los datos de FacturaProveedor
            Me.FacturaProveedorTableAdapter.Fill(Me.DsContabilidad.FacturaProveedor)

            ' Calcular los totales
            Totales()

        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnIngresarFactura_Click(sender As Object, e As EventArgs) Handles BtnIngresarFactura.Click
        ' Verificar si el formulario ya está abierto
        If Application.OpenForms().OfType(Of FrmProveedoresListado).Any() Then
            ' Si está abierto, cerrarlo
            My.Forms.FrmProveedoresListado.Close()
        End If

        ' Crear una nueva instancia del formulario
        Dim frmListado As New FrmProveedoresListado
        frmListado.Listado()
        frmListado.Show()
    End Sub

    Private Sub FacturaProveedorDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaProveedorDataGridView.CellEndEdit
        Try
            ' Verificar que la fila y columna sean válidas
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Validar los cambios
                Me.Validate()

                ' Finalizar edición del BindingSource
                Me.FacturaProveedorBindingSource.EndEdit()

                ' Actualizar solo el registro actual
                Me.FacturaProveedorTableAdapter.Update(Me.DsContabilidad.FacturaProveedor)

                ' Recalcular los totales después de la edición
                Totales()
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar el registro: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRecargar_Click(sender As Object, e As EventArgs) Handles BtnRecargar.Click
        Try
            ' Recargar Proveedores
            Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

            ' Recargar FacturaProveedor
            Me.FacturaProveedorTableAdapter.Fill(Me.DsContabilidad.FacturaProveedor)

            ' Verificar si hay registros antes de mover al último
            If Me.FacturaProveedorBindingSource.Count > 0 Then
                Me.FacturaProveedorBindingSource.MoveLast()
            End If

            ' Recalcular los totales
            Totales()

        Catch ex As Exception
            MsgBox("Error al recargar los datos: " & ex.Message)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBuscar.TextChanged
        Try


            Me.FacturaProveedorTableAdapter.FillByTexto(Me.DsContabilidad.FacturaProveedor, "%" & TxtBuscar.Text & "%")
            Totales()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimeInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimeInicio.ValueChanged
        Try
            Dim fechaInicio As Date = DateTimeInicio.Value
            Dim fechaFinal As Date = DateTimeFinal.Value
            If fechaInicio <= fechaFinal Then
                Me.FacturaProveedorTableAdapter.FillByFechas(DsContabilidad.FacturaProveedor, fechaInicio, fechaFinal)
                Totales()
            Else
                MsgBox(" La fecha de Inicio no puede ser posterior a la final")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DateTimeFinal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimeFinal.ValueChanged
        Try
            Dim fechaInicio As Date = DateTimeInicio.Value
            Dim fechaFinal As Date = DateTimeFinal.Value
            If fechaInicio <= fechaFinal Then
                Me.FacturaProveedorTableAdapter.FillByFechas(DsContabilidad.FacturaProveedor, fechaInicio, fechaFinal)
                Totales()
            Else
                MsgBox(" La fecha de Inicio no puede ser posterior a la final")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
