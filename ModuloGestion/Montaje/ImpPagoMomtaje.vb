Public Class ImpPagoMomtaje

    Public Property IdFacturaSeleccionada As String

    Sub ImprimirPagomontaje()
        MsgBox(Label1.Text)
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, Label1.Text)
        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, Label1.Text)
        Dim rpt As New CrysResumenPagos
        rpt.SetDataSource(DsPagosMontaje)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()

    End Sub
    Sub ImprimirFacturaMontaje()
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.PresupuestoTableAdapter.Fill(Me.DsPagosMontaje.Presupuesto)
        Me.FacturaMontajeTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontaje, Label1.Text)
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontajeDetalle, Label1.Text)
        Me.ProyectosTableAdapter.Fill(Me.DsPagosMontaje.Proyectos)
        Me.PagoMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.PagoMontajeDetalle, Label1.Text)



        Dim rpt As New CryFacturaMontaje
        rpt.SetDataSource(DsPagosMontaje)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub
    Sub ImprimirFacturaNfc()
        MsgBox(IdFacturaSeleccionada)


        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.FacturaMontajeB11TableAdapter.FillByIdNCF(Me.DsMontajeB11.FacturaMontajeB11, IdFacturaSeleccionada)
        Me.FacturaMontajeB11DetalleTableAdapter.FillByIdNCF(Me.DsMontajeB11.FacturaMontajeB11Detalle,IdFacturaSeleccionada)

        Dim rpt As New CryFacturaIns
        rpt.SetDataSource(DsMontajeB11)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub
    Sub ImprimirResumenPagos()
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, Label1.Text)
        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, Label1.Text)
        Dim rpt As New CrysResumenPagos
        rpt.SetDataSource(DsPagosMontaje)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()

    End Sub
    Sub ImprimirResumenFactura()




        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, Label1.Text)

        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)

        Dim rpt As New CryResumenPagosMontaje
        rpt.SetDataSource(DsPagosMontaje)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()

    End Sub
    Private Sub EmpresasContratadasMontajeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EmpresasContratadasMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub ImpPagoMomtaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        '
        Me.PresupuestoTableAdapter1.Fill(Me.DsPresupuestos.Presupuesto)


    End Sub

End Class