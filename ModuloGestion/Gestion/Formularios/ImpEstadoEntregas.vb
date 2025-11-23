Public Class ImpEstadoEntregas

    Sub EstadoEntregas()
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsEstadoEntregas.SubArticulos)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsEstadoEntregas.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.Estadoentregas' Puede moverla o quitarla según sea necesario.
        Me.EstadoentregasTableAdapter.Fill(Me.DsEstadoEntregas.Estadoentregas)
        Me.ProyectosTableAdapter.FillByIdProyecto(Me.DsEstadoEntregas.Proyectos, My.Forms.FrmProyectos.TxtIdProyecto.Text)
        Dim rpt As New CryeEstadoEntregas
        rpt.SetDataSource(DsEstadoEntregas)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
    Sub Pendiente()
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsEstadoEntregas.SubArticulos)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsEstadoEntregas.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.Estadoentregas' Puede moverla o quitarla según sea necesario.
        Me.EstadoentregasTableAdapter.Fill(Me.DsEstadoEntregas.Estadoentregas)
        Me.EstadoentregasTableAdapter.FillByPendiente(Me.DsEstadoEntregas.Estadoentregas, My.Forms.FrmProyectos.TxtIdProyecto.Text)
        Dim rpt As New CryeEstadoEntregas
        rpt.SetDataSource(DsEstadoEntregas)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub ImpEstadoEntregas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class