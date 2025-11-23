Public Class FrmMarco
    Private Sub SubArticulosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

    End Sub

    Private Sub FrmMarco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulosDetalle.SubArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulos.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)

    End Sub
End Class