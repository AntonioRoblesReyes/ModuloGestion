Public Class InfReciboImgresos
    Sub ImprimirCliente()

        Dim idpago As String = My.Forms.FrmCliente.DsPagosClientes.PagosClientes(My.Forms.FrmCliente.ClientesBindingSource.Position).ID_Cobro
        MsgBox(idpago)
        'My.Forms.FrmPagosClientes.DsPagosClientes.PagosClientes(My.Forms.FrmPagosClientes.PagosClientesBindingSource.Position).ID_Cobro

        'Me.PagosClientesTableAdapter.FillByIdCobro(Me.DsRecibosClientes.PagosClientes, idpago)
        'Dim rpt As New CryReciboPago
        'rpt.SetDataSource(Me.DsRecibosClientes)
        'CrystalReportViewer1.ReportSource = rpt


    End Sub
    Sub Imprimir()

        Dim idpago As String = Me.Label1.Text

        'My.Forms.FrmPagosClientes.DsPagosClientes.PagosClientes(My.Forms.FrmPagosClientes.PagosClientesBindingSource.Position).ID_Cobro

        Me.PagosClientesTableAdapter.FillByIdCobro(Me.DsRecibosClientes.PagosClientes, idpago)
        Me.PagosClientesDetalleTableAdapter.FillByIdCobro(Me.DsRecibosClientes.PagosClientesDetalle, idpago)
        Dim rpt As New CryReciboPago
        rpt.SetDataSource(Me.DsRecibosClientes)
        CrystalReportViewer1.ReportSource = rpt

    End Sub


    Private Sub InfReciboImgresos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsRecibosClientes.PagosClientesDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesDetalleTableAdapter.Fill(Me.DsRecibosClientes.PagosClientesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsRecibosClientes.Monedas' Puede moverla o quitarla según sea necesario.
        Me.MonedasTableAdapter.Fill(Me.DsRecibosClientes.Monedas)
        'TODO: esta línea de código carga datos en la tabla 'DsRecibosClientes.PagosClientes' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesTableAdapter.Fill(Me.DsRecibosClientes.PagosClientes)
        'TODO: esta línea de código carga datos en la tabla 'DsRecibosClientes.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter1.Fill(Me.DsRecibosClientes.Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsRecibosClientes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter1.Fill(Me.DsRecibosClientes.Clientes)


    End Sub
End Class