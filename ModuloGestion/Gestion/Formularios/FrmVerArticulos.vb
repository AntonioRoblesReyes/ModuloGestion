Public Class FrmVerArticulos

    Private Sub Modelo_ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeloArticuloBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ModeloArticuloBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsModeloArticulos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar cambios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmVerArticulos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Cerrardatset(Me)
            CerrarGrill(Me)
        Catch ex As Exception
            MessageBox.Show("Error al cerrar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmVerArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)

            If Me.DsArticulos.Articulos.Count > 0 Then
                Dim IdArticulo As String = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).IdArticulo
                Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, IdArticulo)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmdAgregarpresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregarpresupuesto.Click
        Try
            Dim SiguienteDetalles As String = My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.SiguienteDetalle(My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)

            If Me.DsArticulos.Articulos.Count = 0 Then
                MessageBox.Show("No hay artículos seleccionados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim currentArticulo = Me.DsArticulos.Articulos(ArticulosBindingSource.Position)
            Dim Idarticulo As String = currentArticulo.IdArticulo
            Dim Descripcion As String = currentArticulo.Descripcion_articulo
            Dim trabajoTaller As Double = currentArticulo.HorasTrabajoTaller

            Dim currentPresupuesto = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position)
            Dim Presupuesto As String = currentPresupuesto.Id_Presupuesto
            Dim Proyecto As String = currentPresupuesto.Id_proyecto_Presupuestos
            Dim otroscosto As Double = currentPresupuesto.Otros_Gastos
            Dim precioHora As Double = currentPresupuesto.Precio_Hora
            Dim Descuento As Double = currentPresupuesto.Descuento
            Dim Montaje As Double = currentPresupuesto.Costo_Montaje
            Dim CostoIndirecto As Double = currentPresupuesto.Gastos_Indierectos
            Dim TransporteEmbalaje As Double = currentPresupuesto.Tarnsporte_Embalaje
            Dim beneficio As Double = currentPresupuesto.Beneficio
            Dim imprevistos As Double = currentPresupuesto.Gastos_Imprevistos
            Dim Empresa As String = currentPresupuesto.Id_empresa
            Dim estado As String = currentPresupuesto.Estado_Presupuesto
            Dim ItbisIncluido As Boolean = currentPresupuesto.ItbisIncluido

            My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.AnexarDetalle(
                Idarticulo, Proyecto, Presupuesto, SiguienteDetalles, precioHora, trabajoTaller, otroscosto, CostoIndirecto,
                TransporteEmbalaje, beneficio, imprevistos, Descuento, Empresa, estado, ItbisIncluido
            )

            My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(
                My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text
            )

            Dim lastRowIndex As Integer = My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.RowCount - 1
            If lastRowIndex >= 0 Then
                My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.CurrentCell =
                    My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.Rows(lastRowIndex).Cells(2)
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al agregar el presupuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.ArticulosTableAdapter.FillByDescripcion(Me.DsArticulos.Articulos, "%" & TextBox1.Text & "%")
        Catch ex As Exception
            MessageBox.Show("Error al filtrar artículos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btnverarticulo_Click(sender As Object, e As EventArgs) Handles btnverarticulo.Click
        Try
            If Me.DsArticulos.Articulos.Count = 0 Then
                MessageBox.Show("No hay artículos seleccionados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If My.Forms.FrmArticulo.Visible Then
                My.Forms.FrmArticulo.Close()
            End If

            Dim articulo As String = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).IdArticulo
            My.Forms.FrmArticulo.lblInicioFormulario.Text = articulo
            My.Forms.FrmArticulo.FiltrarArticulo()
            My.Forms.FrmArticulo.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir el artículo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ArticulosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArticulosDataGridView.CellClick
        Try
            If Me.DsArticulos.Articulos.Count = 0 Then Exit Sub
            Dim IdArticulo As String = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).IdArticulo
            Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, IdArticulo)
            Me.PresupuestoDetalleTableAdapter.FillByAriculosAsignados(DsPresupuestoDetalle.PresupuestoDetalle, IdArticulo)
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar artículo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class