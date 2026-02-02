Public Class FrmPresopuestosAprobados
    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PresupuestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)

    End Sub

    Private Sub FrmPresopuestosAprobados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsClientes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsProyectos.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)

        PresupuestoTableAdapter.FillByAprobado(DsPresupuestos.Presupuesto)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim presupuesto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
        My.Forms.FrmComprasProyecto.CompraMaterialesDetalleDataGridView.CurrentRow.Cells(11).Value = presupuesto
        My.Forms.FrmComprasProyecto.ValidarDetalle()
        Close()
    End Sub
End Class