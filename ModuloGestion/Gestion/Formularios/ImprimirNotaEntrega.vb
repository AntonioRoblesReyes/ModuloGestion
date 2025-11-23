Public Class ImprimirNotaEntrega
    Sub ImrimirNota()
        Dim nota As String = My.Forms.FrmVerNotasEntregas.DsNotasEntrega.NotasEntrega(My.Forms.FrmVerNotasEntregas.NotasEntregaBindingSource.Position).Id_Nota_Entrega

        Me.ConsultaNotasEntregaTableAdapter.FillByIdNota(Me.DsImrpimirNotasEntregas.ConsultaNotasEntrega, nota)

        Dim rpt As New Cryentregas
        rpt.SetDataSource(Me.DsImrpimirNotasEntregas)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Sub ImrimirNotaEntrega()
        Dim IdNotaEntrega As String = My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text


        Me.ConsultaNotasEntregaTableAdapter.FillByIdNota(Me.DsImrpimirNotasEntregas.ConsultaNotasEntrega, IdNotaEntrega)

        Dim rpt As New Cryentregas
        rpt.SetDataSource(Me.DsImrpimirNotasEntregas)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.ClientesBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DsImrpimirNotasEntregas)

    End Sub

    Private Sub ImprimirNotaEntrega_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.NotasEntregaTableAdapter.Fill(Me.DsImrpimirNotasEntregas.NotasEntrega)


        Me.ConsultaNotasEntregaTableAdapter.Fill(Me.DsImrpimirNotasEntregas.ConsultaNotasEntrega)

        Me.UnionSubarticulosHerrajesTableAdapter.Fill(Me.DsImrpimirNotasEntregas.UnionSubarticulosHerrajes)

        Me.VehiculosTransporteTableAdapter.Fill(Me.DsImrpimirNotasEntregas.VehiculosTransporte)

        Me.ProyectosTableAdapter.Fill(Me.DsImrpimirNotasEntregas.Proyectos)

        Me.EmpresasTransporteTableAdapter.Fill(Me.DsImrpimirNotasEntregas.EmpresasTransporte)

        Me.EmpresasTableAdapter.Fill(Me.DsImrpimirNotasEntregas.Empresas)

        Me.DetalleEntregaImpresionTableAdapter.Fill(Me.DsImrpimirNotasEntregas.DetalleEntregaImpresion)

        Me.ConductoresTableAdapter.Fill(Me.DsImrpimirNotasEntregas.Conductores)

        Me.ClientesTableAdapter.Fill(Me.DsImrpimirNotasEntregas.Clientes)


    End Sub
End Class