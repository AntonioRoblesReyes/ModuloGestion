Public Class FrmSubArticulosCosumo

    Private Sub FrmSubArticulosMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ConsumoMatereialSubArticulosTableAdapter.Fill(Me.DsConsumoMaterialSubarticulos.ConsumoMatereialSubArticulos)
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsConsumoMaterialSubarticulos.ConsumoMatereialSubArticulos' Puede moverla o quitarla según sea necesario.
        Me.MdiParent = My.Forms.FrmGestion
        Me.LblIdSubarticulo.Text = My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text
        Me.Label4.Text = My.Forms.FrmSubArticulo.TxtDescripcion.Text

    End Sub


    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCerrar.Click
        Me.Close()
    End Sub


End Class