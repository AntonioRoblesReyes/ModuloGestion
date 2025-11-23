Public Class FrmIngresoHerrajePintura
    Sub CargarDataset()
        Try
            Me.PinturaAplicacionTableAdapter.Fill(Me.DsPinturaAplicacion.PinturaAplicacion)
            Me.TrabajoTallerM2PinturaArticuloTableAdapter.Fill(Me.DsTrabajoTallerM2PinturaArticulo.TrabajoTallerM2PinturaArticulo)
            Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
            Me.PresupuestoDetallePinturaTableAdapter.Fill(Me.DsPresupuestoDetallePintura.PresupuestoDetallePintura)
            Me.HerrajesTableAdapter.Fill(Me.DsHerrajes.Herrajes)
            Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
            Filtrar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Filtrar()
        Try
            Me.PresupuestoDetalleHerrajesTableAdapter.FillByIdDetallePresupuesto(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes, TxtdDetallePresupuesto.Text)
        Catch ex As Exception
            MessageBox.Show("Error al filtrar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ArticulosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ArticulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsArticulos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAñadirHerraje_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadirHerraje.Click
        Try
            My.Forms.Frmherrajes.Close()
            My.Forms.Frmherrajes.Show()
        Catch ex As Exception
            MessageBox.Show("Error al añadir herraje: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAñadirPintura_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadirPintura.Click
        Try
            Me.TrabajoTallerM2PinturaArticuloTableAdapter.FillByIdArticulo(Me.DsTrabajoTallerM2PinturaArticulo.TrabajoTallerM2PinturaArticulo, IdArticuloTextBox.Text)
            My.Forms.FrmPinturaAplicacoon.Close()
            My.Forms.FrmPinturaAplicacoon.btnanadirpintutrapDetalle.Visible = True
            My.Forms.FrmPinturaAplicacoon.Show()
        Catch ex As Exception
            MessageBox.Show("Error al añadir pintura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Descripcion_articuloTextBox_Click(sender As System.Object, e As System.EventArgs) Handles Descripcion_articuloTextBox.Click
        Try
            Me.LblTipoPinturaPresupuestada.Text = Me.PresupuestoDetallePinturaTableAdapter.TipoDePinturaPresupuestada(TxtdDetallePresupuesto.Text)
        Catch ex As Exception
            MessageBox.Show("Error al obtener tipo de pintura presupuestada: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PresupuestoDetalleHerrajesDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDetalleHerrajesDataGridView.CellEndEdit
        Dim cantidad As Double = Convert.ToDouble(Me.PresupuestoDetalleHerrajesDataGridView.CurrentRow.Cells(2).Value)
        Dim detalle As String = Me.PresupuestoDetalleHerrajesDataGridView.CurrentRow.Cells(0).Value

        ' Llamada al método para actualizar la cantidad
        PresupuestoDetalleHerrajesTableAdapter.ActulizarCantidadDetalle(cantidad, detalle)
    End Sub



    Private Sub PresupuestoDetalleHerrajesDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles PresupuestoDetalleHerrajesDataGridView.UserDeletingRow
        Try
            Dim IdDetalleHeraje As String = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).Id_detalle_Herrajes


            PresupuestoDetalleHerrajesTableAdapter.EliminarDetalle(IdDetalleHeraje)
        Catch ex As Exception

        End Try

    End Sub


End Class
