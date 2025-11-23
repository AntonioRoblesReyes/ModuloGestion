Public Class FrmEstadoPresupuestos
    Sub Sumar()
        Dim totalRD As Double = 0
        Dim pagadoRD As Double = 0
        Dim pendienteRD As Double = 0

        Dim totalUS As Double = 0
        Dim pagadoUS As Double = 0
        Dim pendienteUS As Double = 0

        For Each row As DataGridViewRow In Me.PresupuestoDataGridView.Rows
            If Not row.IsNewRow Then
                Dim moneda As String = If(row.Cells(5).Value, "").ToString()

                If moneda = "RD$" Then
                    totalRD += If(IsDBNull(row.Cells(9).Value), 0, Convert.ToDouble(row.Cells(9).Value))
                    pagadoRD += If(IsDBNull(row.Cells(10).Value), 0, Convert.ToDouble(row.Cells(10).Value))
                    pendienteRD += If(IsDBNull(row.Cells(11).Value), 0, Convert.ToDouble(row.Cells(11).Value))
                ElseIf moneda = "US$" Then
                    totalUS += If(IsDBNull(row.Cells(6).Value), 0, Convert.ToDouble(row.Cells(6).Value))
                    pagadoUS += If(IsDBNull(row.Cells(7).Value), 0, Convert.ToDouble(row.Cells(7).Value))
                    pendienteUS += If(IsDBNull(row.Cells(8).Value), 0, Convert.ToDouble(row.Cells(8).Value))
                End If
            End If
        Next

        Label5.Text = totalRD.ToString("N2")
        Label6.Text = pagadoRD.ToString("N2")
        Label7.Text = pendienteRD.ToString("N2")
        Label9.Text = totalUS.ToString("N2")
        Label10.Text = pagadoUS.ToString("N2")
        Label11.Text = pendienteUS.ToString("N2")
    End Sub

    Sub Rellearpresupuesto()
        For Each row As DataGridViewRow In Me.PresupuestoDataGridView.Rows
            If Not row.IsNewRow Then
                Dim moneda As String = If(row.Cells(5).Value, "").ToString()

                If moneda = "RD$" Then
                    row.Cells(12).Value = row.Cells(9).Value
                    row.Cells(13).Value = row.Cells(10).Value
                    row.Cells(14).Value = row.Cells(11).Value
                ElseIf moneda = "US$" Then
                    row.Cells(12).Value = row.Cells(6).Value
                    row.Cells(13).Value = row.Cells(7).Value
                    row.Cells(14).Value = row.Cells(8).Value
                End If
            End If
        Next
        Sumar()
    End Sub

    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PresupuestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)
    End Sub

    Private Sub FrmEstadoPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmGestion
        Me.WindowState = FormWindowState.Normal
        Me.Text = "Estado de Presupuestos"


        AplicarEstiloFormulario(Me)
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        RadioButton3.Checked = True
        Rellearpresupuesto()
    End Sub

    Private Sub CargarPresupuestosPorEstado(estado As String)
        Me.PresupuestoTableAdapter.FillByPorEstado(DsPresupuestos.Presupuesto, estado)
        Rellearpresupuesto()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
            Sumar()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            CargarPresupuestosPorEstado("Cerrado")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            CargarPresupuestosPorEstado("Aprobado")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            CargarPresupuestosPorEstado("Pendiente")
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            CargarPresupuestosPorEstado("Rechazado")
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            CargarPresupuestosPorEstado("Entregado")
        End If
    End Sub

    Private Sub PresupuestoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        If e.ColumnIndex = 15 Then
            Dim presupuesto As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
            My.Forms.FrmPresupuestos.Close()
            My.Forms.FrmPresupuestos.Label10.Text = presupuesto
            My.Forms.FrmPresupuestos.PorPresupuesto()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Forms.FrmFacturaMontajeEditar.Close()
            My.Forms.FrmFacturaMontajeEditar.LblPresupuesto.Text = PresupuestoDataGridView.CurrentRow.Cells(2).Value
            My.Forms.FrmFacturaMontajeEditar.LblProyecto.Text = PresupuestoDataGridView.CurrentRow.Cells(1).Value
            My.Forms.FrmFacturaMontajeEditar.EmpresasContratadasMontajeTableAdapter.Fill(My.Forms.FrmFacturaMontajeEditar.DsPagosMontaje.EmpresasContratadasMontaje)
            My.Forms.FrmFacturaMontajeEditar.NuevaFactura()
        Catch ex As Exception
            MsgBox("No hay Presupuesto")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In Me.PresupuestoDataGridView.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells(18).Value) AndAlso row.Cells(18).Value = True Then
                Dim estado As String = Me.ComboBox1.Text
                Dim presupuesto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
                Me.PresupuestoTableAdapter.ActualizarEstado(estado, presupuesto)

                My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.ActualizarEstado(estado, presupuesto)
                My.Forms.FrmPresupuestos.PresupuestoDetalleHerrajesTableAdapter.ActulizarEstado(estado, presupuesto)
                My.Forms.FrmPresupuestos.PresupuestoDetallePinturaTableAdapter.AutulizarEstado(estado, presupuesto)
                My.Forms.FrmPresupuestos.PresupuestoDetalleElementosTableAdapter.ActulizarEstado(estado, presupuesto)

                Me.Validate()
                Me.PresupuestoBindingSource.EndEdit()
                Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
            End If
        Next

        Try
            Dim estado As String = Me.ComboBox1.Text
            Dim filtro As String = If(RadioButton2.Checked, "Cerrado",
                            If(RadioButton6.Checked, "Entregado",
                            If(RadioButton3.Checked, "Aprobado",
                            If(RadioButton4.Checked, "Pendiente",
                            If(RadioButton5.Checked, "Rechazados", "")))))

            If Not String.IsNullOrEmpty(filtro) Then
                CargarPresupuestosPorEstado(filtro)
            End If

            MsgBox("Se cambió el estado a " & estado)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PresupuestoDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellEndEdit
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
    End Sub
    Private Sub TxtFiltroPresupuesto_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltroPresupuesto.TextChanged
        ' Verifica si el TextBox tiene texto
        If String.IsNullOrWhiteSpace(TxtFiltroPresupuesto.Text) Then
            ' Si está vacío, elimina el filtro
            Me.PresupuestoBindingSource.RemoveFilter()
        Else
            ' Aplica el filtro a la columna "Presupuesto"
            Me.PresupuestoBindingSource.Filter = $"Id_Presupuesto LIKE '%{TxtFiltroPresupuesto.Text}%'"
        End If
    End Sub

End Class
