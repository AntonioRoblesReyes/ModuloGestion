Public Class FrmArticulo

    Sub Sumardetalles()
        Try
            Dim tHoras, tMetros, tMontaje As Double

            ' Iterar sobre cada fila en el DataTable
            For Each row As DataRow In Me.DsArticulosdetalle.ArticulosDetalle.Rows
                ' Sumar las horas de trabajo del taller, metros cuadrados de pintura y montaje
                tHoras += If(IsDBNull(row("HorasTrabajoTallerTotal")), 0, Convert.ToDouble(row("HorasTrabajoTallerTotal")))
                tMetros += If(IsDBNull(row("M2Pinturatota")), 0, Convert.ToDouble(row("M2Pinturatota")))
                tMontaje += If(IsDBNull(row("TotalMonatje")), 0, Convert.ToDouble(row("TotalMonatje"))) ' Verifica el nombre de la columna
            Next

            ' Mostrar los valores calculados en los TextBox correspondientes
            Me.HorasTrabajoTallerTextBox.Text = tHoras.ToString("#,##0.00")
            Me.M2PinturaTextBox.Text = tMetros.ToString("#,##0.00")
            Me.MontajeTextBox.Text = tMontaje.ToString("#,##0.00")

            ' Hacer visible el TextBox para Horas de Trabajo Taller
            Me.HorasTrabajoTallerTextBox.Visible = True

            ' Actualización de datos comentada (descomentar si es necesario)
            Me.ArticulosTableAdapter.ActulizarHorasM2Pintura(tHoras, tMetros, tMontaje, TxtIdArticulo.Text)
        Catch ex As Exception
            ' Manejar cualquier error que ocurra
            MsgBox("Error al sumar detalles: " & ex.Message)
        End Try
    End Sub

    Sub FiltrarArticulo()
        Try
            Dim Articulo As String = Me.lblInicioFormulario.Text
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, Articulo)
            Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, Articulo)
            Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
            Me.DiseñoArticuloTextBox.Enabled = False
            Me.lblInicioFormulario.Visible = False
            Me.ArticulosBindingNavigator.Visible = True
            Me.TxtIdArticulo.Enabled = False

            If Me.DsArticulosdetalle.Tables(0).Rows.Count <> 0 Then
                Me.TrabajoTallerM2PinturaArticuloTableAdapter.FillByIdArticulo(Me.DsTrabajoTallerM2PinturaArticulo.TrabajoTallerM2PinturaArticulo, Articulo)
                Try
                    Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)
                    Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
                    Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo)
                Catch ex As Exception
                    Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, "")
                End Try
            End If
            Me.Show()
        Catch ex As Exception
            MsgBox("Error al filtrar artículo: " & ex.Message)
        End Try
    End Sub

    Sub NuevoArticulo()
        Try
            Dim siguiente As String = Me.ArticulosTableAdapter.Siguiente()
            Me.ArticulosTableAdapter.anexar(siguiente, "Nuevo Articulo", ModeloTextBox.Text)
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, siguiente)
        Catch ex As Exception
            MsgBox("Error al crear un nuevo artículo: " & ex.Message)
        End Try
    End Sub

    Sub ActualizarArticulo()
        Try
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, Me.TxtIdArticulo.Text)
        Catch ex As Exception
            MsgBox("Error al actualizar el artículo: " & ex.Message)
        End Try
    End Sub

    Sub SiguienteArticulo()
        Try


            Dim CSubarticulos As Integer = Me.DsArticulosdetalle.Tables(0).Rows.Count
            Dim articulo As String = Me.TxtIdArticulo.Text
            Dim siguiente As String = Me.ArticulosTableAdapter.Siguiente()
            Me.ArticulosTableAdapter.anexar(siguiente, Descripcion_articuloTextBox.Text + " Registro duplicado", ModeloTextBox.Text)

            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, siguiente)
            Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, siguiente)
            If CSubarticulos <> 0 Then
                Dim Respuesta As MsgBoxResult
                Respuesta = MsgBox("Desea copiar los SubArticulos tambien", MsgBoxStyle.YesNo, "Duplicar SubArticulos")
                If Respuesta = MsgBoxResult.Yes Then
                    Me.DataGridView.Visible = False

                    Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, articulo)
                    Dim DSuarticulo As Integer = Me.DsArticulosdetalle.Tables(0).Rows.Count
                    Me.ArticulosDetalleBindingSource.MoveFirst()
                    Dim M2Articulo As Double = 0
                    Dim TrabajoArticulo As Double = 0

                    Dim i As Integer
                    For i = 0 To DSuarticulo - 1
                        Dim SiguienteDetalle As String = Me.ArticulosDetalleTableAdapter.SiguienteDetalle(siguiente)

                        Dim subarticulo As String = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
                        Dim Cantidad As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).Cantidad
                        Dim HorasTrabajoTaller As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).HorasTrabajoTaller
                        Dim M2pintura As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).M2Pintura
                        Dim HorasTrabajoTallerTotal As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).HorasTrabajoTallerTotal
                        Dim M2pinturaTotal As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).M2Pinturatota
                        Dim Montaje As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).PrecioMontaje
                        Dim TotalMontaje As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).TotalMonatje
                        Me.ArticulosDetalleTableAdapter.AnexarSubArticulo(SiguienteDetalle, siguiente, subarticulo, Cantidad, HorasTrabajoTaller, M2pintura, HorasTrabajoTallerTotal, M2pinturaTotal, Montaje, TotalMontaje)
                        Me.ArticulosDetalleBindingSource.MoveNext()
                    Next
                    Me.DataGridView.Visible = True
                    Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, TxtIdArticulo.Text)
                    Sumardetalles()


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Forms.FrmPresupuestos.ArticulosTableAdapter.Fill(My.Forms.FrmPresupuestos.DsArticulos.Articulos)

            Dim SiguienteDetalles As String = My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.SiguienteDetalle(My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)

            Dim Idarticulo As String = Me.DsArticulos.Articulos(ArticulosBindingSource.Position).IdArticulo
            Dim Descripcion As String = Me.DsArticulos.Articulos(ArticulosBindingSource.Position).Descripcion_articulo
            Dim Presupuesto As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Id_Presupuesto
            Dim Proyecto As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
            Dim otroscosto As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Otros_Gastos
            Dim trabajoTaller As Double = Me.DsArticulos.Articulos(ArticulosBindingSource.Position).HorasTrabajoTaller
            Dim precioHora As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Precio_Hora
            Dim Descuento As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Descuento
            Dim Montaje As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Costo_Montaje
            Dim CostoIndirecto As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Gastos_Indierectos
            Dim TransporteEmbalaje As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Tarnsporte_Embalaje
            Dim beneficio As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Beneficio
            Dim imprevistos As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Gastos_Imprevistos
            Dim Empresa As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Id_empresa
            Dim estado As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Estado_Presupuesto
            Dim ItebisIncluido As Boolean = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).ItbisIncluido
            My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.AnexarDetalle(Idarticulo, Proyecto, Presupuesto, SiguienteDetalles, precioHora, trabajoTaller, otroscosto, CostoIndirecto, TransporteEmbalaje, beneficio, imprevistos, Descuento, Empresa, estado, ItebisIncluido)

            My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
            Dim cell As DataGridViewCell = My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.CurrentCell
            cell = My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.Rows(My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.RowCount - 1).Cells(2)
            My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.CurrentCell = cell
            MsgBox("Se guardo Correctamente")
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each row As DataRow In Me.DsArticulosdetalle.ArticulosDetalle.Rows
                Dim CantidadOriginal As Double = Convert.ToDouble(row("Cantidad"))
                Dim multiplicador As Double = Convert.ToDouble(TextBox1.Text)

                Me.DataGridView.CurrentRow.Cells(2).Value = CantidadOriginal * multiplicador
                Me.DataGridView.CurrentRow.Cells(4).Value = CantidadOriginal * multiplicador * Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(2).Value)
                Me.DataGridView.CurrentRow.Cells(6).Value = CantidadOriginal * multiplicador * Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(5).Value)
                Me.DataGridView.CurrentRow.Cells(8).Value = CantidadOriginal * multiplicador * Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(7).Value)
            Next

            Me.Validate()
            Me.ArticulosDetalleBindingSource.EndEdit()
            Me.ArticulosDetalleTableAdapter.Update(Me.DsArticulosdetalle)
            Sumardetalles()
        Catch ex As Exception
            MsgBox("Error al actualizar cantidades: " & ex.Message)
        End Try
    End Sub

    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ArticulosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ArticulosBindingSource.EndEdit()
            Me.ArticulosTableAdapter.Update(Me.DsArticulos)
        Catch ex As Exception
            MsgBox("Error al guardar cambios: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmArticulo_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Try
            Cerrardatset(Me)
            CerrarGrill(Me)
        Catch ex As Exception
            MsgBox("Error al cerrar el formulario: " & ex.Message)
        End Try
    End Sub

    Private Sub Bbtnduplicar_Click(sender As System.Object, e As System.EventArgs) Handles Bbtnduplicar.Click
        SiguienteArticulo()
    End Sub

    Private Sub CmdNuevoElemento_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevoElemento.Click
        Try
            My.Forms.FrmVerSubarticulos.Close()
            My.Forms.FrmVerSubarticulos.CmdAgregarArticulo.Visible = True
            My.Forms.FrmVerSubarticulos.BtnCambiarSubArticulo.Visible = False
            My.Forms.FrmVerSubarticulos.Show()
        Catch ex As Exception
            MsgBox("Error al abrir la ventana de subartículos: " & ex.Message)
        End Try
    End Sub



    Private Sub DataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        Try
            Dim subArticulo As String = DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
            Dim IDDetalle As String = Me.DataGridView.CurrentRow.Cells(0).Value
            Dim cantidad As Double = Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(2).Value)
            Dim horas As Double = Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(5).Value)
            Me.DataGridView.CurrentRow.Cells(6).Value = cantidad * horas
            Dim m2 As Double = Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(7).Value)
            Me.DataGridView.CurrentRow.Cells(8).Value = cantidad * m2
            Dim montaje As Double = Convert.ToDouble(Me.DataGridView.CurrentRow.Cells(3).Value)
            Me.DataGridView.CurrentRow.Cells(4).Value = cantidad * montaje

            Me.SubArticulosTableAdapter.ActualizarMontaje(montaje, subArticulo)

            Me.Validate()
            Me.ArticulosDetalleBindingSource.EndEdit()
            Me.ArticulosDetalleTableAdapter.Update(Me.DsArticulosdetalle)
            My.Forms.FrmPresupuestos.ActulizarconsumosArticulo()
            Sumardetalles()
        Catch ex As Exception
            MsgBox("Error al editar celda: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView.RowsRemoved
        Try
            Me.Validate()
            Me.ArticulosDetalleBindingSource.EndEdit()
            Me.ArticulosDetalleTableAdapter.Update(Me.DsArticulosdetalle)
            Me.Sumardetalles()
        Catch ex As Exception
            MsgBox("Error al eliminar fila: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
        Try
            Me.PresupuestoDetalleTableAdapter.FillByIdArticulo(Me.DsPresupuestoDetalle.PresupuestoDetalle, TxtIdArticulo.Text)
            Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
            Me.MdiParent = My.Forms.FrmGestion
        Catch ex As Exception
            MsgBox("Error al cargar el formulario: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Try
            Dim subArticulo As String = DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
            If e.ColumnIndex = 9 Then
                My.Forms.FrmSubArticulo.Close()
                Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, subArticulo)
                My.Forms.FrmSubArticulo.lblInicio.Text = subArticulo
                My.Forms.FrmSubArticulo.Inicio()
            Else
                Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, subArticulo)
            End If
            Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)
            Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
            Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        Catch ex As Exception
            MsgBox("Error al seleccionar celda: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCambiarSubArticulo_Click(sender As System.Object, e As System.EventArgs) Handles BtnCambiarSubArticulo.Click
        Try
            My.Forms.FrmVerSubarticulos.Close()
            My.Forms.FrmVerSubarticulos.Label1.Text = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).Id_Detalle_Articulos
            My.Forms.FrmVerSubarticulos.CmdAgregarArticulo.Visible = False
            My.Forms.FrmVerSubarticulos.Show()
        Catch ex As Exception
            MsgBox("Error al cambiar subartículo: " & ex.Message)
        End Try
    End Sub

    Private Sub HorasTrabajoTallerTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles HorasTrabajoTallerTextBox.TextChanged
        Try
            Me.Validate()
            Me.ArticulosBindingSource.EndEdit()
            Me.ArticulosTableAdapter.Update(Me.DsArticulos)
        Catch ex As Exception
            MsgBox("Error al actualizar las horas de trabajo: " & ex.Message)
        End Try
    End Sub

End Class

