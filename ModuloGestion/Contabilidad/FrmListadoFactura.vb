Public Class FrmListadoFactura
    Sub Moneda()
        Try

            If Me.FacturaDataGridView.CurrentRow.Cells("Moneda1").Value = "RD$" Then
                Me.FacturaDataGridView.CurrentRow.Cells("Subtotal").Value = Me.FacturaDataGridView.CurrentRow.Cells("Subtotalrd").Value
                Me.FacturaDataGridView.CurrentRow.Cells("itebis").Value = Me.FacturaDataGridView.CurrentRow.Cells("ImpuestolRDS").Value
                Me.FacturaDataGridView.CurrentRow.Cells("Total").Value = Me.FacturaDataGridView.CurrentRow.Cells("TotalRD").Value
            ElseIf Me.FacturaDataGridView.CurrentRow.Cells("Moneda1").Value = "US$" Then
                Me.FacturaDataGridView.CurrentRow.Cells("Subtotal").Value = Me.FacturaDataGridView.CurrentRow.Cells("Subtotalus").Value
                Me.FacturaDataGridView.CurrentRow.Cells("itebis").Value = Me.FacturaDataGridView.CurrentRow.Cells("ImpuestolUS").Value
                Me.FacturaDataGridView.CurrentRow.Cells("Total").Value = Me.FacturaDataGridView.CurrentRow.Cells("TotalUS").Value
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsFacturas)

    End Sub

    Private Sub FrmListadoFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AplicarEstiloFormulario(Me)
        'TODO: esta línea de código carga datos en la tabla 'DsClientes.Clientes' Puede moverla o quitarla según sea necesario.

        MdiParent = My.Forms.FrmContabilidad
        Me.ClientesTableAdapter.Fill(Me.DsFacturas.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsFacturas.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.DsFacturas.Factura)
        Moneda()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.FacturaTableAdapter.FillByFiltro(Me.DsFacturas.Factura, "%" & TextBox1.Text & "%")
        Moneda()
    End Sub


End Class