Public Class FrmNuevoPago

    Private Sub PagosClientesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PagosClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub

    Private Sub FrmNuevoPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpresas1.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter1.Fill(Me.DsEmpresas1.Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientesDetalle.PagosClientesDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesDetalleTableAdapter.Fill(Me.DsPagosClientesDetalle.PagosClientesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsEmpresas.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosCliente.PagosClientes' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        '''''''''  Me.PagosClientesTableAdapter.AnexarPago(TxtIdCobro.Text, TxtIdFiscal.Text, FechaDateTimePicker.Value, TxtValor.Text, TxtEmpresa.SelectedValue)
        ''''''''''   My.Forms.FrmPagosClientes.PagosClientesTableAdapter.FillById_Fiscal(My.Forms.FrmPagosClientes.DsPagosClientes.PagosClientes, TxtIdFiscal.Text)
        Me.Close()
    End Sub

    Private Sub PagosClientesBindingSource1BindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PagosClientesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosClientes)

    End Sub

    Private Sub FrmNuevoPago_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosClientes.PagosClientes' Puede moverla o quitarla según sea necesario.
        Me.PagosClientesTableAdapter.Fill(Me.DsPagosClientes.PagosClientes)

    End Sub
End Class