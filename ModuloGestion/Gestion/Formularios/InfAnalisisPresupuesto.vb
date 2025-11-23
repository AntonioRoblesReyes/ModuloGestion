Public Class InfAnalisisPresupuesto
    Sub AnalisisPresupuesto()
        Dim Presupuesto As String = My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text

        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsAnalisisPresupuesto.Presupuesto, Presupuesto)
        Dim rpt As New CryAnalisisPres
        rpt.SetDataSource(Me.DsAnalisisPresupuesto)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Sub AnalisisPoyecto()
        Try
            Dim Proyecto As String = My.Forms.FrmProyectos.TxtIdProyecto.Text

            Me.AnalisisPresupuestoTableAdapter.FillByIdProyecto(Me.DsAnalisisPresupuesto.AnalisisPresupuesto, Proyecto)
            MsgBox(Proyecto)
            Dim rpt As New CryAnalisisProyecto
            rpt.SetDataSource(Me.DsAnalisisPresupuesto)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub InfAnalisisPresupuesto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAnalisisPresupuesto.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsAnalisisPresupuesto.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsAnalisisPresupuesto.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsAnalisisPresupuesto.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsAnalisisPresupuesto.AnalisisPresupuesto' Puede moverla o quitarla según sea necesario.
        Me.AnalisisPresupuestoTableAdapter.Fill(Me.DsAnalisisPresupuesto.AnalisisPresupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsAnalisisPresupuesto.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsAnalisisPresupuesto.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsAnalisisPresupuesto.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsAnalisisPresupuesto.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsAnalisisPresupuesto.AnalisisPresupuesto' Puede moverla o quitarla según sea necesario.
        Me.AnalisisPresupuestoTableAdapter.Fill(Me.DsAnalisisPresupuesto.AnalisisPresupuesto)


    End Sub
End Class