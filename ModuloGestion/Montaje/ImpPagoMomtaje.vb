Imports CrystalDecisions.CrystalReports.Engine

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

        Me.DsMontajeB11.FacturaMontajeB11.Clear()
        Me.DsMontajeB11.FacturaMontajeB11Detalle.Clear()

        Dim filasFactura As Integer = Me.FacturaMontajeB11TableAdapter.FillByIdNCF(Me.DsMontajeB11.FacturaMontajeB11, IdFacturaSeleccionada)
        Dim filasDetalle As Integer = Me.FacturaMontajeB11DetalleTableAdapter.FillByIdNCF(Me.DsMontajeB11.FacturaMontajeB11Detalle, IdFacturaSeleccionada)

        If filasFactura = 0 Then
            MessageBox.Show("No se encontró la factura " & IdFacturaSeleccionada & ".", "Crystal Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Me.DsPagosMontaje.EmpresasContratadasMontaje.Clear()
        If Not IsDBNull(Me.DsMontajeB11.FacturaMontajeB11(0).IdEmpresaMontaje) Then
            Me.EmpresasContratadasMontajeTableAdapter.FillById(Me.DsPagosMontaje.EmpresasContratadasMontaje, Me.DsMontajeB11.FacturaMontajeB11(0).IdEmpresaMontaje)
        End If

        Dim rpt As New CryFacturaIns
        VincularTablaReporte(rpt, DsMontajeB11, DsPagosMontaje)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.RefreshReport()

        If filasDetalle = 0 Then
            MessageBox.Show("La factura " & IdFacturaSeleccionada & " no tiene líneas de detalle.", "Crystal Reports", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Show()
    End Sub

    Private Sub VincularTablaReporte(rpt As ReportClass, ParamArray dataSets() As DataSet)
        For Each tablaReporte As Table In rpt.Database.Tables
            Dim tablaEncontrada As DataTable = Nothing

            For Each ds As DataSet In dataSets
                If ds IsNot Nothing AndAlso ds.Tables.Contains(tablaReporte.Name) Then
                    tablaEncontrada = ds.Tables(tablaReporte.Name)
                    Exit For
                End If
            Next

            If tablaEncontrada IsNot Nothing Then
                tablaReporte.SetDataSource(tablaEncontrada)
            End If
        Next
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
