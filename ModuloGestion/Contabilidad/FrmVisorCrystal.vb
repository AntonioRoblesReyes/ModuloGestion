Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmVisorCrystal



    Public Sub ImprimirFactura(
        dtFactura As DataTable,
        dtPagos As DataTable
    )

        Dim rpt As New RptFacturaResumen()

        ' Tabla principal (Factura)
        rpt.SetDataSource(dtFactura)

        '' Subreporte (Pagos)
        'rpt.Subreports(0).SetDataSource(dtPagos)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()

    End Sub

End Class