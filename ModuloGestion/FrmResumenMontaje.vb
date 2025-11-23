Public Class FrmResumenMontaje

    Sub Sumas()
        Dim TotalMontaje As Double = 0
        For Each row As DataGridViewRow In FacturaMontajeDetalleDataGridView.Rows
            TotalMontaje += Val(row.Cells(5).Value)

        Next
        TxtMontaje.Text = Format(TotalMontaje, "#,##0.00")


        Dim totalFacturasus As Double = 0
        Dim totalFacturasRD As Double = 0
        For Each row As DataGridViewRow In CompraMaterialesDetalleDataGridView.Rows
            totalFacturasus += Val(row.Cells(6).Value)
            totalFacturasRD += Val(row.Cells(10).Value)
        Next
        TextBox1.Text = Format(totalFacturasRD, "#,##0.00")
        TextBox2.Text = Format(totalFacturasus, "#,##0.00")

    End Sub
    Sub Proyecto()
        Me.FacturaMontajeDetalleTableAdapter.FillByIdProyecto(Me.DsPagosMontaje.FacturaMontajeDetalle, Label1.Text)
        Me.CompraMaterialesDetalleTableAdapter.FillByIdProyecto(DsCompras.CompraMaterialesDetalle, Label1.Text)

        Me.Show()
        Sumas()
    End Sub
    Sub Presupuesto()
        Me.FacturaMontajeDetalleTableAdapter.FillByPresupuesto(Me.DsPagosMontaje.FacturaMontajeDetalle, Label1.Text)
        Me.CompraMaterialesDetalleTableAdapter.FillByIdPresupuesto(DsCompras.CompraMaterialesDetalle, Label1.Text)

        Me.Show()
        Sumas()

    End Sub

    Private Sub FrmResumenMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Sumas()
    End Sub
End Class