Public Class FrmEjecutadoPresupuesto

    Private IdPresupuesto As String

    Private Sub FrmEjecutadoPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Validación del Id
        IdPresupuesto = Label1.Text.Trim()

        If String.IsNullOrWhiteSpace(IdPresupuesto) Then
            MessageBox.Show("Id de presupuesto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        Try
            ' Cargar datos
            Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, IdPresupuesto)
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
            Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, IdPresupuesto)
            CalcularSumasYActualizarPorcentaje()

            ' Bloquear todas las columnas excepto Ejecutado
            For Each col As DataGridViewColumn In PresupuestoDetalleDataGridView.Columns
                If col.Name <> "Ejecutado" Then
                    col.ReadOnly = True
                Else
                    col.ReadOnly = False
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub


    Private Sub PresupuestoDetalleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PresupuestoDetalleBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)
            CalcularSumasYActualizarPorcentaje()
        Catch ex As Exception
            MessageBox.Show("Error al guardar los cambios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Try
            ActualizarTotalesFilaActual()
            CalcularSumasYActualizarPorcentaje()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la fila: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarTotalesFilaActual()
        Dim row = PresupuestoDetalleDataGridView.CurrentRow
        If row Is Nothing OrElse row.IsNewRow Then Exit Sub

        Dim cantidad As Double = ObtenerValorCelda(row, "Cantidad")
        Dim TotalUS As Double = ObtenerValorCelda(row, "TotalUS")
        Dim TotalRD As Double = ObtenerValorCelda(row, "TotalRD")
        Dim Ejecutado As Double = ObtenerValorCelda(row, "Ejecutado")

        row.Cells("EjecutadoUS").Value = Ejecutado * TotalUS
        row.Cells("EjecutadoRD").Value = Ejecutado * TotalRD

        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Dim currentRow As DataRowView = CType(Me.PresupuestoDetalleBindingSource.Current, DataRowView)
        If currentRow IsNot Nothing Then
            currentRow.EndEdit()
            Me.PresupuestoDetalleTableAdapter.Update(currentRow.Row)
        End If
    End Sub

    Private Sub CalcularSumasYActualizarPorcentaje()
        ' 0) Confirmar ediciones en grilla y bindings
        Me.PresupuestoDetalleDataGridView.EndEdit()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.PresupuestoBindingSource.EndEdit()
        Me.Validate()

        ' 1) Sumar lo EJECUTADO (columnas EjecutadoUS / EjecutadoRD del DGV)
        Dim sumEjUS As Double = 0.0
        Dim sumEjRD As Double = 0.0

        For Each row As DataGridViewRow In PresupuestoDetalleDataGridView.Rows
            If Not row.IsNewRow Then
                sumEjUS += ObtenerValorSeguro(row, "EjecutadoUS") ' DataGridViewColumn "EjecutadoUS"
                sumEjRD += ObtenerValorSeguro(row, "EjecutadoRD") ' DataGridViewColumn "EjecutadoRD"
            End If
        Next

        ' 2) Mostrar subtotales ejecutados (solo UI)
        Me.EjSubtotalUSTextBox.Text = sumEjUS.ToString("N2")
        Me.EjSubtotalRDTextBox.Text = sumEjRD.ToString("N2")

        ' 3) Tomar SubTotalUS desde el origen para evitar problemas de cultura/formato
        Dim subtotalUS As Double = 0.0
        Dim drv As DataRowView = TryCast(Me.PresupuestoBindingSource.Current, DataRowView)
        If drv IsNot Nothing AndAlso drv.Row IsNot Nothing Then
            If drv.DataView.Table.Columns.Contains("SubTotalUS") AndAlso Not Convert.IsDBNull(drv("SubTotalUS")) Then
                subtotalUS = Convert.ToDouble(drv("SubTotalUS"))
            End If

            ' 4) Calcular porcentaje (0..1) y escribir al origen (numérico)
            Dim porcentaje As Double = 0.0
            If subtotalUS > 0 Then
                porcentaje = sumEjUS / subtotalUS
                If porcentaje > 1.0 Then porcentaje = 1.0
                If porcentaje < 0.0 Then porcentaje = 0.0
            End If

            ' Guardar también los subtotales ejecutados si existen esas columnas en la tabla
            If drv.DataView.Table.Columns.Contains("EjSubtotalUS") Then drv("EjSubtotalUS") = sumEjUS
            If drv.DataView.Table.Columns.Contains("EjSubtotalRD") Then drv("EjSubtotalRD") = sumEjRD

            ' Guardar porcentaje numérico (ej.: 0.75). El formateo a “P2” se hace por binding.
            If drv.DataView.Table.Columns.Contains("Ejecutado") Then drv("Ejecutado") = porcentaje
        End If

        ' 5) Confirmar cambios y persistir (sin TableAdapterManager.UpdateAll)
        Me.PresupuestoBindingSource.EndEdit()
        Me.PresupuestoDetalleBindingSource.EndEdit()

        ' Primero detalle (si editaste montos ejecutados en el grid)
        Me.PresupuestoDetalleTableAdapter.Update(Me.DsPresupuestoDetalle.PresupuestoDetalle)
        ' Luego encabezado
        Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos.Presupuesto)
    End Sub


    ' Helper robusto para leer números de celdas del DGV
    Private Function ObtenerValorSeguro(row As DataGridViewRow, columnName As String) As Double
        Try
            Dim v = row.Cells(columnName).Value
            If v Is Nothing OrElse IsDBNull(v) Then Return 0.0
            ' Si el valor ya es numérico:
            If TypeOf v Is Decimal OrElse TypeOf v Is Double OrElse TypeOf v Is Single OrElse TypeOf v Is Integer OrElse TypeOf v Is Long Then
                Return Convert.ToDouble(v)
            End If
            ' Si viene como string formateado, intenta con cultura actual
            Dim d As Double
            If Double.TryParse(Convert.ToString(v), Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, d) Then
                Return d
            End If
            ' Como fallback, intenta Invariant
            If Double.TryParse(Convert.ToString(v), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, d) Then
                Return d
            End If
        Catch
            ' Ignora y devuelve 0 si algo raro ocurre
        End Try
        Return 0.0
    End Function


    Private Function ObtenerValorCelda(row As DataGridViewRow, columnName As String) As Double
        Try
            Dim val = row.Cells(columnName).Value
            If val Is Nothing OrElse IsDBNull(val) OrElse val.ToString.Trim() = "" Then Return 0
            Return Convert.ToDouble(val)
        Catch
            Return 0
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Application.OpenForms().OfType(Of RptImprimir).Any() Then
                Application.OpenForms().OfType(Of RptImprimir).First().BringToFront()
            Else
                Dim frm As New RptImprimir()
                frm.Show()
                frm.ImprimirEstadoDetalle()
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el formulario de impresión: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmEjecutadoPresupuesto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, My.Forms.FrmProyectos.TxtIdProyecto.Text)
        Catch
        End Try

        Try
            Cerrardatset(Me)
        Catch
        End Try
        Try
            CerrarGrill(Me)
        Catch
        End Try
    End Sub


End Class
