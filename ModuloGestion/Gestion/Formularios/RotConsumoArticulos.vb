Public Class RotConsumoArticulos
    Sub EstudioCostsoResumen()
        Me.PresupuestoTableAdapter.FillBydPresupuesto(Me.DsConsumoArticulosInforme.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryEstudioArticulos
        rpt.SetDataSource(DsConsumoArticulosInforme)

        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Sub SoloConsumos()
        Me.PresupuestoTableAdapter.FillBydPresupuesto(Me.DsConsumoArticulosInforme.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryEstudioCostosArticulo
        rpt.SetDataSource(DsConsumoArticulosInforme)
        CrystalReportViewer1.ReportSource = rpt
        rpt.ReportDefinition.Areas("Area3").AreaFormat.EnableSuppress = True
    End Sub

    Sub EstudioCostos()
        Me.PresupuestoTableAdapter.FillBydPresupuesto(Me.DsConsumoArticulosInforme.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryAriculosConsumo
        rpt.SetDataSource(DsConsumoArticulosInforme)
        CrystalReportViewer1.ReportSource = rpt
        'rpt.ReportDefinition.Sections("DetailSection3").SectionFormat.EnableSuppress = True
    End Sub



    Private Sub RotConsumoArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PresupuestoDetalleTableAdapter1.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
        Me.ArticulosTableAdapter1.Fill(Me.DsArticulos.Articulos)

        Me.ConsumoPinturaArticuloTableAdapter.Fill(Me.DsConsumoArticulosInforme.ConsumoPinturaArticulo)
        Me.PinturaComponentesTableAdapter.Fill(Me.DsConsumoArticulosInforme.PinturaComponentes)
        Me.MedidasCompraTableAdapter.Fill(Me.DsConsumoArticulosInforme.MedidasCompra)
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsConsumoArticulosInforme.MaterilaesDetalle)
        Me.ConsumoMaterialArticulosTableAdapter.Fill(Me.DsConsumoArticulosInforme.ConsumoMaterialArticulos)
        Me.HerrajesTableAdapter.Fill(Me.DsConsumoArticulosInforme.Herrajes)
        Me.PresupuestoTableAdapter.Fill(Me.DsConsumoArticulosInforme.Presupuesto)
        Me.ProyectosTableAdapter.Fill(Me.DsConsumoArticulosInforme.Proyectos)
        Me.ArticulosTableAdapter.Fill(Me.DsConsumoArticulosInforme.Articulos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsConsumoArticulosInforme.PresupuestoDetalle)
        Me.PresupuestoDetalleHerrajesTableAdapter.Fill(Me.DsConsumoArticulosInforme.PresupuestoDetalleHerrajes)

    End Sub



End Class