Public Class FrmPrecios

    Private Sub PreciosCompraProyectoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PreciosCompraProyectoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPreciosCompraProyecto)

    End Sub

    Private Sub FrmPrecios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPreciosCompraProyecto.PreciosCompraProyecto' Puede moverla o quitarla según sea necesario.
        Me.PreciosCompraProyectoTableAdapter.Fill(Me.DsPreciosCompraProyecto.PreciosCompraProyecto)
        Me.PreciosCompraProyectoTableAdapter.FillBySinPrecio(Me.DsPreciosCompraProyecto.PreciosCompraProyecto)
    End Sub

    Private Sub PreciosCompraProyectoBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PreciosCompraProyectoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PreciosCompraProyectoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPreciosCompraProyecto)
        Dim Material As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material
    End Sub
End Class