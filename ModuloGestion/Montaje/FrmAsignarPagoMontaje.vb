Public Class FrmAsignarPagoMontaje
    Sub AsignarPago()
        Me.PagoMontajeTableAdapter.FillByIdPago(DsPagosMontaje.PagoMontaje, IdPagoMontajeTextBox.Text)
        Me.FacturaMontajeTableAdapter.FillByFacturasPendientes(DsPagosMontaje.FacturaMontaje, IdEmpresaMontajeTextBox.Text)
        Me.Show()
    End Sub
    Private Sub FacturaMontajeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmAsignarPagoMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.FacturaMontajeDetalle' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsProyectos.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsClientes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontajeDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim totalFactura As Double = FacturaMontajeDataGridView.CurrentRow.Cells(1).Value

        Dim Pagado As Double = FacturaMontajeDataGridView.CurrentRow.Cells(2).Value

        Dim Pendiente As Double = FacturaMontajeDataGridView.CurrentRow.Cells(3).Value

        Dim Factura As String = FacturaMontajeDataGridView.CurrentRow.Cells(0).Value


        Dim NuevoPagado As Double = Pagado + CDbl(TextBox1.Text)
        Dim NuevoPendiente As Double = totalFactura - NuevoPagado

        Me.FacturaMontajeTableAdapter.ActulizarPagoFactura(NuevoPagado, NuevoPendiente, Factura)


        Dim Asignado As Double = DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).Asignado
        Dim NuevoAsignado As Double = Asignado + CDbl(TextBox1.Text)
        Dim TotalPago As Double = DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).valor
        Dim NuevoPendiet As Double = TotalPago - NuevoAsignado
        Dim pago As String = DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
        Dim fecha As String = DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).Fecha


        Me.PagoMontajeTableAdapter.ActulizarAsignado(NuevoAsignado, NuevoPendiet, pago)
        My.Forms.FrmPagosMomtajeResumen.PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)


        Dim siguiente As String = Me.PagoMontajeDetalleTableAdapter.Siguiente(pago)
        Dim presupuesto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Presupuesto
        Dim Proyecto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Proyecto
        Me.PagoMontajeDetalleTableAdapter.NuevoDetallePago(siguiente, pago, Proyecto, presupuesto, "RD$", CDbl(TextBox1.Text), fecha, Factura)



        Me.Close()
    End Sub

    Private Sub FacturaMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDataGridView.CellClick

        Dim pendientePago As Double = FacturaMontajeDataGridView.CurrentRow.Cells(3).Value
        Dim pendienteA As Double = PendienteAsignarTextBox.Text
        Dim Facturamontaje As String = FacturaMontajeDataGridView.CurrentRow.Cells(0).Value
        Dim IdPresupuesto As String = FacturaMontajeDataGridView.CurrentRow.Cells(4).Value
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, Facturamontaje)
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, IdPresupuesto)
        Me.Label2.Text = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descripcion_Presupuesto
        If pendientePago <= PendienteAsignarTextBox.Text Then
            Me.TextBox1.Text = Format(pendientePago, "#,##0.00")
        Else
            Me.TextBox1.Text = Format(pendienteA, "#,##0.00")
        End If
    End Sub

End Class