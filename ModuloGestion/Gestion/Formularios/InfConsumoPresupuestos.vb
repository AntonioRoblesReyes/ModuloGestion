Public Class InfConsumoPresupuestos
    Sub ImprimriConsumos()
        Me.EncabezadoConsumoTableAdapter.FillByIdPresupuesto(Me.DsEcabezadoConsumos.EncabezadoConsumo, lblIdPresupuesto.Text)
        Dim rpt As New CryConsumoPorPresupuesto
        rpt.SetDataSource(DsEcabezadoConsumos)
        CrystalReportViewer1.ReportSource = rpt
    End Sub


    Private Sub InfConsumoPresupuestos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEcabezadoConsumos.ConsumosTotalesPresupuesto' Puede moverla o quitarla según sea necesario.
        Me.ConsumosTotalesPresupuestoTableAdapter.Fill(Me.DsEcabezadoConsumos.ConsumosTotalesPresupuesto)

        Me.EncabezadoConsumoTableAdapter.Fill(Me.DsEcabezadoConsumos.EncabezadoConsumo)

    End Sub

End Class