Imports System.Math
Public Class FrmDetalleFactura
    Sub FiltrarDetalle()
        Dim presupuesto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, presupuesto)
    End Sub
    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)

    End Sub

    Private Sub FrmDetalleFactura_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        cerrardatset(Me)
        cerrarGrill(Me)
        'Me.PresupuestoDataGridView.DataSource = Nothing
        'Me.PresupuestoDetalleDataGridView.DataSource = Nothing
        'Me.ArticulosDataGridView.DataSource = Nothing
        'Me.DsArticulos.Dispose()
        'Me.DsPresupuestoDetalle.Dispose()
        'Me.DsPresupuestos.Dispose()
    End Sub

    Private Sub FrmDetalleFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try


            Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)

            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)

            Me.PresupuestoTableAdapter.FillByProyectoAprobado(Me.DsPresupuestos.Presupuesto, My.Forms.FrmFacturas.IdProyectoTextBox.Text)

            Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
            filtrarDetalle()
        Catch ex As Exception
            MsgBox("No Hay ningun presupuesto aprobado")
        End Try
    End Sub

    Private Sub PresupuestoDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        filtrarDetalle()
    End Sub

    Private Sub BtnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadir.Click
        Try
            FrmFacturas.FacturaDetalleBindingSource.AddNew()

            Dim siguiente As String = My.Forms.FrmFacturas.FacturaDetalleTableAdapter.NuevoDetalleFactura(My.Forms.FrmFacturas.IdFacturaTextBox.Text)
            Dim tasa As Double = My.Forms.FrmFacturas.TasaCambioRD_TextBox.Text


            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(0).Value = siguiente
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(1).Value = My.Forms.FrmFacturas.IdFacturaTextBox.Text
            Dim Articulo As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, Articulo)

            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(2).Value = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).Descripcion_articulo
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(3).Value = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(4).Value = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Precio_Ajustado
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(5).Value = Round(Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Precio_Ajustado * My.Forms.FrmFacturas.ValorImpuestoTextBox.Text, 2) * Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(6).Value = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).TotalPartida
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(7).Value = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position)._Precio_AjustadoRD_
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(8).Value = Round(Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position)._TotalPartidaRD_ * My.Forms.FrmFacturas.ValorImpuestoTextBox.Text, 2)
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(9).Value = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position)._TotalPartidaRD_
            My.Forms.FrmFacturas.FacturaDetalleDataGridView.CurrentRow.Cells(10).Value = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto

            Me.Close()
            My.Forms.FrmFacturas.Validate()
            My.Forms.FrmFacturas.FacturaDetalleBindingSource.EndEdit()
            My.Forms.FrmFacturas.FacturaDetalleTableAdapter.Update(My.Forms.FrmFacturas.DsFacturas)
            My.Forms.FrmFacturas.FacturaDetalleTableAdapter.FillByIdFactura(My.Forms.FrmFacturas.DsFacturas.FacturaDetalle, My.Forms.FrmFacturas.Label2.Text)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


End Class