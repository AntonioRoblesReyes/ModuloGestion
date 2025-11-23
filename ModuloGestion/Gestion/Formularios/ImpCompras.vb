Public Class ImpCompras



    Sub ImprimirListado()




    End Sub


    Sub TotalesCompra()

        Me.ProveedoresTableAdapter.Fill(Me.DsImprimirCompras.Proveedores)


        'Me.CompraMaterialesTableAdapter.Fill(DsImprimirCompras.CompraMateriales)

        Me.CompraMaterialesTableAdapter.TotalCompra()

        Dim rpt As New CryTc
        rpt.SetDataSource(DsImprimirCompras)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub
    Sub ImprimirCompra()


        Me.ProveedoresTableAdapter.Fill(Me.DsImprimirCompras.Proveedores)
        Me.EmpresasTableAdapter.Fill(Me.DsImprimirCompras.Empresas)

        Me.CompraMaterialesTableAdapter.Fill(Me.DsImprimirCompras.CompraMateriales)

        Me.MedidasCompraTableAdapter.Fill(Me.DsImprimirCompras.MedidasCompra)
        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsImprimirCompras.CompraMaterialesDetalle, My.Forms.FrmIngresoCompras.Id_CompraTextBox.Text)
        Dim rpt As New CryCompras
        rpt.SetDataSource(DsImprimirCompras)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub
    Private Sub CompraMaterialesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CompraMaterialesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsImprimirCompras)

    End Sub

    Private Sub ImpCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter1.Fill(Me.DsCompras.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMateriales' Puede moverla o quitarla según sea necesario.






    End Sub
End Class