Public Class FrmVerFacturas
    Sub FiltrarProyecto()
        Me.FacturaTableAdapter.FillByIdProyecto(Me.DsFacturas.Factura, My.Forms.FrmProyectos.TxtIdProyecto.Text)
    End Sub
    Private Sub EmpresasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpresas)

    End Sub

    Private Sub FrmVerFacturas_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub FrmVerFacturas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)

        Me.FacturaDetalleTableAdapter.Fill(Me.DsFacturas.FacturaDetalle)
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.FacturaTableAdapter.FillByIdEmpresa(Me.DsFacturas.Factura, "IN")
        Me.EmpresasTableAdapter.FillByIdEmpresa(Me.DsEmpresas.Empresas, "IN")

    End Sub

    Private Sub BtnNuevaFactura_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevaFactura.Click
        My.Forms.FrmProyectosFacturacion.Close()
        My.Forms.FrmProyectosFacturacion.Label2.Text = My.Forms.FrmProyectos.TxtIdFiscalCliente.Text

        My.Forms.FrmProyectosFacturacion.Show()




    End Sub

    Private Sub BtnVerFactura_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerFactura.Click
        My.Forms.FrmFacturas.Close()
        Dim Factura As String = Me.DsFacturas.Factura(Me.FacturaBindingSource.Position).IdFactura
        My.Forms.FrmFacturas.Label2.Text = Factura


        My.Forms.FrmFacturas.VerFActura()
    End Sub


End Class