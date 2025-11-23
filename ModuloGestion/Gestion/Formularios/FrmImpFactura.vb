Public Class FrmImpFactura

    Sub ImprimirFactura()
        Me.FacturaTableAdapter.FillByIdFactura(Me.DsFacturas.Factura, My.Forms.FrmFacturas.IdFacturaTextBox.Text)
        Dim rpt As New CryFactura
        rpt.SetDataSource(Me.DsFacturas)
        CrystalReportViewer1.ReportSource = rpt
    End Sub




    Private Sub FrmImpFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsFacturas.ComprobantesFiscales' Puede moverla o quitarla según sea necesario.

        Try
            Me.ComprobantesFiscalesTableAdapter.Fill(Me.DsFacturas.ComprobantesFiscales)
            Me.ProyectosTableAdapter.Fill(Me.DsFacturas.Proyectos)
            Me.FacturaDetalleTableAdapter.Fill(Me.DsFacturas.FacturaDetalle)
            Me.EmpresasTableAdapter.Fill(Me.DsFacturas.Empresas)
            Me.FacturaTableAdapter.Fill(Me.DsFacturas.Factura)
            Me.ClientesTableAdapter.Fill(Me.DsFacturas.Clientes)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class