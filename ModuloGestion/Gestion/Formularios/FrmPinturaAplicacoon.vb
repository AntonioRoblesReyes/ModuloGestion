Public Class FrmPinturaAplicacoon

    Sub ConsumoPintura()
        Try
            ' Obtener información del proyecto, empresa, presupuesto, detalle y artículo
            Dim Proyecto As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
            Dim Empresas As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Id_empresa
            Dim Presupuesto As String = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Id_Presupuesto
            Dim IdpresupuestoDetalle As String = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Dim Articulo As String = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).Articulo

            ' Eliminar registros anteriores del detalle de pintura
            Me.PresupuestoDetallePinturaTableAdapter.Eliminar(IdpresupuestoDetalle)

            ' Cargar el artículo y obtener los metros cuadrados de pintura
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, Articulo)
            Dim m2Pinturasubarticulo As Double = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).M2Pintura

            ' Iterar sobre los detalles de los artículos
            For Each detalleArticuloRow As DataRow In DsArticulosdetalle.Tables(0).Rows
                Me.PinturaAplicacionDetalleBindingSource.MoveFirst()

                ' Iterar sobre los detalles de aplicación de pintura
                For Each aplicacionDetalleRow As DataRow In DsPinturaAplicacionDetalle.Tables(0).Rows
                    FiltrarPinturadetalle()

                    ' Iterar sobre los consumos por litro
                    For Each consumoDetalleRow As DataRow In Me.DsPinturaDetalle.Tables(0).Rows
                        ' Calcular los valores necesarios
                        Dim CantidadPorLitro As Double = consumoDetalleRow("CantidadXlitro")
                        Dim M2Total As Double = detalleArticuloRow("M2Pintura")
                        Dim ConsumoPoMetro As Double = aplicacionDetalleRow("ConsumoM2")
                        Dim DetalleArticulo As String = detalleArticuloRow("Id_Detalle_Articulos")
                        Dim Detalleaplicacion As String = aplicacionDetalleRow("IdPinturaTipoDetalle")
                        Dim DetalleComponente As String = consumoDetalleRow("IdPinturaDetalle")
                        Dim IdPinturaTipoPresupuesto As String = $"{IdpresupuestoDetalle}-{DetalleArticulo}-{Detalleaplicacion}-{DetalleComponente}"
                        Dim Subarticulo As String = detalleArticuloRow("ID_Sub_Articulo")
                        Dim CantidadArticulos As String = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).Cantidad
                        Dim Cantidadsubarticulos As String = detalleArticuloRow("Cantidad")
                        Dim IDPinturaComponente As String = consumoDetalleRow("IdPinturaComponente")

                        ' Calcular consumo, desperdicio y necesidades
                        Dim TotalConsumo As Double = M2Total * CantidadPorLitro * ConsumoPoMetro
                        Dim Desperdicio As Double = aplicacionDetalleRow("Desperdicio")
                        Dim TotalDesperdicio As Double = TotalConsumo * Desperdicio
                        Dim TotalNecesidad As Double = TotalConsumo + TotalDesperdicio
                        Dim ConsumoArticulo As Double = TotalConsumo * Cantidadsubarticulos
                        Dim TotalDesperdicioArticulo As Double = ConsumoArticulo * Desperdicio
                        Dim TotalNecesidadarticulo As Double = ConsumoArticulo + TotalDesperdicioArticulo
                        Dim ConsumoPresupuesto As Double = ConsumoArticulo * CantidadArticulos
                        Dim TotalDesperdiciopresupuesto As Double = ConsumoPresupuesto * Desperdicio
                        Dim TotalNecesidadPresupuesto As Double = ConsumoPresupuesto + TotalDesperdiciopresupuesto

                        ' Obtener el precio de compra
                        Me.PinturaComponentesTableAdapter.FillByIdPinturaComponente(Me.DsPinturaComponentes.PinturaComponentes, IDPinturaComponente)
                        Dim MedidaCompra As Integer = Me.DsPinturaComponentes.PinturaComponentes(Me.PinturaComponentesBindingSource.Position).MedidaCompra
                        Dim ConsumoXlitro As String = consumoDetalleRow("CantidadXlitro")
                        Dim tipodeAplicacion As String = aplicacionDetalleRow("IdPinturaTipo")
                        Me.PreciosCompraProyectoTableAdapter.FillByIdCodigo(Me.DsPreciosCompraProyecto.PreciosCompraProyecto, $"{Presupuesto}-{IDPinturaComponente}")
                        Dim VerificarPrecio As Integer = Me.DsPreciosCompraProyecto.Tables("PreciosCompraProyecto").Rows.Count
                        Dim precio As Double = If(VerificarPrecio > 0, Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Precio_Compra, 0)

                        ' Insertar detalles en la base de datos
                        Me.PresupuestoDetallePinturaTableAdapter.InsertarPintura(
                            IdPinturaTipoPresupuesto, Proyecto, Presupuesto, IdpresupuestoDetalle, Articulo, Subarticulo,
                            CantidadArticulos, Cantidadsubarticulos, IDPinturaComponente, m2Pinturasubarticulo, ConsumoPoMetro,
                            TotalConsumo, Desperdicio, TotalDesperdicio, TotalNecesidad, My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).Estado_Presupuesto,
                            Empresas, DetalleArticulo, $"{Presupuesto}-{IDPinturaComponente}", precio, TotalConsumo * precio,
                            ConsumoArticulo, TotalDesperdicioArticulo, TotalNecesidadarticulo, TotalNecesidadarticulo * precio,
                            ConsumoPresupuesto, TotalDesperdiciopresupuesto, TotalNecesidadPresupuesto,
                            TotalNecesidadPresupuesto * precio, MedidaCompra, ConsumoXlitro, tipodeAplicacion)

                        Me.PinturaDetalleBindingSource.MoveNext()
                    Next

                    Me.PinturaAplicacionDetalleBindingSource.MoveNext()
                Next

                Me.ArticulosDetalleBindingSource.MoveNext()
            Next

            ' Llamar a la función de tiempo de pintura y cerrar formularios
            Me.TiempoPintura()
            Me.Close()
            My.Forms.FrmIngresoHerrajePintura.Close()

        Catch ex As Exception
            ' Manejo de errores
            Me.TextBox1.Visible = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TiempoPintura()
        Try
            ' Obtener el ID del detalle del presupuesto
            Dim DetallePresupuesto As String = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto

            ' Obtener el número total de filas en la tabla de detalles de aplicación de pintura
            Dim iTotal As Integer = DsPinturaAplicacionDetalle.Tables(0).Rows.Count

            ' Inicializar el total de tiempo de pintura
            Dim TotalPintura As Double = 0

            ' Calcular el tiempo total de aplicación de pintura
            Me.PinturaAplicacionDetalleBindingSource.MoveFirst()
            For i As Integer = 0 To iTotal - 1
                Dim PinturaTiempo As Double = Me.DsPinturaAplicacionDetalle.PinturaAplicacionDetalle(Me.PinturaAplicacionDetalleBindingSource.Position).TiempoAolicacion
                TotalPintura += PinturaTiempo
                Me.PinturaAplicacionDetalleBindingSource.MoveNext()
            Next

            ' Calcular el tiempo total en horas para la pintura
            Dim metro2 As Double = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).M2Pintura
            Dim HorasPintura As Double = (TotalPintura * metro2) / 60
            Dim horasTaller As Double = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).TrabajoTaller
            Dim TotalHora As Double = HorasPintura + horasTaller

            ' Actualizar el tiempo de pintura en la base de datos
            Me.PresupuestoDetalleTableAdapter.ActualizarTiempoPintura(HorasPintura, TotalHora, DetallePresupuesto)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AñadirComponente()
        Try
            Dim IdPinturas As String = Me.DsPinturaAplicacionDetalle.PinturaAplicacionDetalle(Me.PinturaAplicacionDetalleBindingSource.Position).IdPintura
            Dim Siguiente As String = Me.PinturaDetalleTableAdapter.Siguiente(IdPinturas)
            Dim componente As String = My.Forms.FrmPinturaComponentes.DsPinturaComponentes.PinturaComponentes(My.Forms.FrmPinturaComponentes.PinturaComponentesBindingSource.Position).IdPinturaComponente
            Dim MedidaCompra As Integer = My.Forms.FrmPinturaComponentes.DsPinturaComponentes.PinturaComponentes(My.Forms.FrmPinturaComponentes.PinturaComponentesBindingSource.Position).MedidaCompra

            Me.PinturaDetalleTableAdapter.NuevoDetallePintura(Siguiente, componente, IdPinturas, MedidaCompra)
            My.Forms.FrmPinturaComponentes.Close()
            FiltrarPinturadetalle()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SiguientePinturadetalles()
        Try
            Dim idpinturatipo As String = Me.DsPinturaAplicacion.PinturaAplicacion(Me.PinturaAplicacionBindingSource.Position).IdPinturaTipo
            Dim IdPintura As String = My.Forms.FrmPintura.DsPintura.Pintura(My.Forms.FrmPintura.PinturaBindingSource.Position).IdPintura
            Dim m2 As Double = My.Forms.FrmPintura.DsPintura.Pintura(My.Forms.FrmPintura.PinturaBindingSource.Position).ConsumoM2
            Dim Desperdicio As Double = My.Forms.FrmPintura.DsPintura.Pintura(My.Forms.FrmPintura.PinturaBindingSource.Position).Desperdicio
            Dim Tiempoaplicacion As Double = My.Forms.FrmPintura.DsPintura.Pintura(My.Forms.FrmPintura.PinturaBindingSource.Position).TiempoAolicacion
            Dim siguiente As String = Me.PinturaAplicacionDetalleTableAdapter.Siguiente(idpinturatipo)
            Me.PinturaAplicacionDetalleTableAdapter.NuevoDetalle(siguiente, IdPintura, m2, Desperdicio, Tiempoaplicacion, idpinturatipo)
            FiltrarPinturaAplicacionDetalle()
            My.Forms.FrmPintura.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ActulizarPinturaAplicacion()
        Try
            Me.Validate()
            Me.PinturaAplicacionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPinturaAplicacion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ActulizarPinturaAplicaciondetalle()
        Try
            Me.Validate()
            Me.PinturaAplicacionDetalleBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsPinturaAplicacionDetalle)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub FiltrarPinturaAplicacionDetalle()
        Try
            Dim IdPinturaAplicadion As String = Me.DsPinturaAplicacion.PinturaAplicacion(Me.PinturaAplicacionBindingSource.Position).IdPinturaTipo
            Me.PinturaAplicacionDetalleTableAdapter.FillByIdPinturaTipo(Me.DsPinturaAplicacionDetalle.PinturaAplicacionDetalle, IdPinturaAplicadion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub FiltrarPinturadetalle()
        Try
            Dim IdPinturaAplicacionDetalle As String = Me.DsPinturaAplicacionDetalle.PinturaAplicacionDetalle(Me.PinturaAplicacionDetalleBindingSource.Position).IdPintura
            Me.PinturaDetalleTableAdapter.FillBydPintura(Me.DsPinturaDetalle.PinturaDetalle, IdPinturaAplicacionDetalle)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmPinturaAplicacoon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ' Cargar datos en las tablas necesarias
            Me.PreciosCompraProyectoTableAdapter.Fill(Me.DsPreciosCompraProyecto.PreciosCompraProyecto)
            Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
            Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
            Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
            Me.PresupuestoDetallePinturaTableAdapter.Fill(Me.DsPresupuestoDetallePintura.PresupuestoDetallePintura)
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
            Me.PinturaComponentesTableAdapter.Fill(Me.DsPinturaComponentes.PinturaComponentes)
            Me.PinturaDetalleTableAdapter.Fill(Me.DsPinturaDetalle.PinturaDetalle)
            Me.PinturaTableAdapter.Fill(Me.DsPintura.Pintura)
            Me.PinturaAplicacionDetalleTableAdapter.Fill(Me.DsPinturaAplicacionDetalle.PinturaAplicacionDetalle)
            Me.PinturaAplicacionTableAdapter.Fill(Me.DsPinturaAplicacion.PinturaAplicacion)

            ' Filtrar detalles de pintura
            FiltrarPinturaAplicacionDetalle()
            FiltrarPinturadetalle()

            ' Cargar detalles del artículo seleccionado
            Dim articulo As String = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).Articulo
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, articulo)
            Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, articulo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PinturaAplicacionDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaAplicacionDataGridView.CellContentClick
        FiltrarPinturaAplicacionDetalle()
        FiltrarPinturadetalle()
    End Sub

    Private Sub PinturaAplicacionDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PinturaAplicacionDataGridView.RowsRemoved
        ActulizarPinturaAplicacion()
    End Sub

    Private Sub PinturaAplicacionDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaAplicacionDataGridView.CellEndEdit
        ActulizarPinturaAplicacion()
        FiltrarPinturadetalle()
    End Sub

    Private Sub PinturaAplicacionDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PinturaAplicacionDetalleDataGridView.RowsRemoved
        ActulizarPinturaAplicaciondetalle()
    End Sub

    Private Sub PinturaAplicacionDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaAplicacionDetalleDataGridView.CellClick
        FiltrarPinturadetalle()
        ActulizarPinturaAplicaciondetalle()
    End Sub

    Private Sub PinturaAplicacionDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaAplicacionDetalleDataGridView.CellEndEdit
        ActulizarPinturaAplicaciondetalle()
    End Sub

    Private Sub BtnNuevaPintura_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevaAplicacion.Click
        My.Forms.FrmNuevaPintura.Close()
        My.Forms.FrmNuevaPintura.Show()
        My.Forms.FrmNuevaPintura.SiguientePintura()
    End Sub

    Private Sub BtnNuevoDetallePintura_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevaPintura.Click
        Dim AplicacionTipo As String = Me.DsPinturaAplicacion.PinturaAplicacion(Me.PinturaAplicacionBindingSource.Position).IdPinturaTipo
        My.Forms.FrmPintura.Close()
        My.Forms.FrmPintura.Show()
    End Sub

    Private Sub BtnNuevoDetallePintura_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnNuevoDetallePintura.Click
        My.Forms.FrmPinturaComponentes.Close()
        My.Forms.FrmPinturaComponentes.Show()
        My.Forms.FrmPinturaComponentes.BtnAñadirComponente.Visible = True
    End Sub

    Private Sub PinturaDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.PinturaDetalleBindingSource.EndEdit()
        Me.TableAdapterManager3.UpdateAll(Me.DsPinturaDetalle)
    End Sub

    Private Sub PinturaDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PinturaDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.PinturaDetalleBindingSource.EndEdit()
        Me.TableAdapterManager3.UpdateAll(Me.DsPinturaDetalle)
    End Sub

    Private Sub PinturaAplicacionDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaAplicacionDataGridView.CellClick
        FiltrarPinturaAplicacionDetalle()
        FiltrarPinturadetalle()
    End Sub

    Private Sub Btnanadirpintutrapresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles btnanadirpintutrapDetalle.Click
        Me.ConsumoPintura()
    End Sub

End Class
