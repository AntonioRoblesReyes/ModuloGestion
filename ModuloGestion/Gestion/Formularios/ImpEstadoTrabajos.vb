Public Class ImpEstadoTrabajos


    Private Sub ImpEstadoTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoTrabajos.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsEstadoTrabajos.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoTrabajos.PresupuestoDetalle' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsEstadoTrabajos.PresupuestoDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoTrabajos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsEstadoTrabajos.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoTrabajos.EstadoTrabajos' Puede moverla o quitarla según sea necesario.
        Me.EstadoTrabajosTableAdapter.Fill(Me.DsEstadoTrabajos.EstadoTrabajos)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoTrabajos.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsEstadoTrabajos.Articulos)

        Me.ProyectosTableAdapter.FillByAprobados(Me.DsEstadoTrabajos.Proyectos)

        Dim rpt As New CryEstadoTrabajos
        rpt.SetDataSource(DsEstadoTrabajos)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class