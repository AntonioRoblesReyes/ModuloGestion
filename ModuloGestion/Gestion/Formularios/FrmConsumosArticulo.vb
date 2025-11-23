Public Class FrmConsumosArticulo


    Private Sub FrmConsumosArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsArticulos.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, My.Forms.FrmArticulo.TxtIdArticulo.Text)
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsConsumoArticulosResumen.DsConsumoMaterialArticulo1Total' Puede moverla o quitarla según sea necesario.
        Me.DsConsumoMaterialArticulo1TotalTableAdapter.Fill(Me.DsConsumoArticulosResumen.DsConsumoMaterialArticulo1Total)
        Me.DsConsumoMaterialArticulo1TotalTableAdapter.FillByIdArticulo(Me.DsConsumoArticulosResumen.DsConsumoMaterialArticulo1Total, IdArticuloTextBox.Text)

    End Sub
End Class