Public Class FrmCostosPrespuestos
    Sub Cargar()
        Me.CompraMaterialesDetalleTableAdapter.FillByIdPresupuesto(Me.DsCompras.CompraMaterialesDetalle, Label1.Text)
        Me.FacturaMontajeDetalleTableAdapter.FillByPresupuesto(DsPagosMontaje.FacturaMontajeDetalle, Label1.Text)
        Me.Show()
    End Sub
    Private Sub CompraMaterialesDetalleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CompraMaterialesDetalleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompraMaterialesDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCompras)

    End Sub

    Private Sub FrmCostosPrespuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class