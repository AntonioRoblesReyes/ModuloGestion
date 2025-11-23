Imports System.IO
Public Class FrmProyectos
    Sub Permisosclientes()

        Dim CategotiaUsuario As String = My.Forms.FrmGestion.Label1.Text

        Select Case CategotiaUsuario
            Case "2"
                BtnFacturas.Visible = False
                BtnEstadoProyecto.Visible = False
            Case "3"
                BtnFacturas.Visible = False
                BtnEstadoProyecto.Visible = False
                'Me.BtnIrPresupuesto.Visible = False

        End Select
    End Sub


    Sub DuplicarPre()
        Dim Ano As Integer = CInt(DateTime.Now().ToString("yyyy"))
        Dim Empresa As String = Id_EmpresaTextBox.Text
        Dim SiguientePresupuestos As String = PresupuestoTableAdapter.SiguientePresupuesto(Empresa, Ano)
        Me.Label2.Text = SiguientePresupuestos
        Dim Idpresupuesto As String = Me.PresupuestoDataGridView.CurrentRow.Cells(1).Value
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, Idpresupuesto)

        Dim fila As DataRow = Me.DsPresupuestos.Presupuesto.Rows(0)
        ' Manejar DBNull en los campos principales
        Dim Descripcion_Presupuesto As String = If(IsDBNull(fila("Descripcion_Presupuesto")), "", fila("Descripcion_Presupuesto").ToString())
        Dim DEstado_Presupuesto As String = If(IsDBNull(fila("Estado_Presupuesto")), "", fila("Estado_Presupuesto").ToString())
        Dim Id_proyecto_Presupuestos As String = If(IsDBNull(fila("Id_proyecto_Presupuestos")), "", fila("Id_proyecto_Presupuestos").ToString())
        Dim Itbis As Boolean = If(IsDBNull(fila("Itbis")), False, Convert.ToBoolean(fila("Itbis")))
        Dim Leyenda_Presupuesto As String = If(IsDBNull(fila("Leyenda_Presupuesto")), "", fila("Leyenda_Presupuesto").ToString())
        Dim fecha As Date = Date.Now()
        Dim Id_empresa As String = If(IsDBNull(fila("Id_empresa")), "", fila("Id_empresa").ToString())
        Dim Precio_Hora As Double = If(IsDBNull(fila("Precio_Hora")), 0, Convert.ToDouble(fila("Precio_Hora")))
        Dim Otros_Gastos As Double = If(IsDBNull(fila("Otros_Gastos")), 0, Convert.ToDouble(fila("Otros_Gastos")))
        Dim Gastos_Indierectos As Double = If(IsDBNull(fila("Gastos_Indierectos")), 0, Convert.ToDouble(fila("Gastos_Indierectos")))
        Dim Gastos_Imprevistos As Double = If(IsDBNull(fila("Gastos_Imprevistos")), 0, Convert.ToDouble(fila("Gastos_Imprevistos")))
        Dim Beneficio As Double = If(IsDBNull(fila("Beneficio")), 0, Convert.ToDouble(fila("Beneficio")))
        Dim TarnsporteEmbalaje As Double = If(IsDBNull(fila("Tarnsporte_Embalaje")), 0, Convert.ToDouble(fila("Tarnsporte_Embalaje")))
        Dim Otros As Double = If(IsDBNull(fila("Otros")), 0, Convert.ToDouble(fila("Otros")))
        Dim Descuento As Double = If(IsDBNull(fila("Descuento")), 0, Convert.ToDouble(fila("Descuento")))
        Dim Impuesto As Double = If(IsDBNull(fila("Impuesto")), 0, Convert.ToDouble(fila("Impuesto")))
        Dim Benficio_Herrajes As Double = If(IsDBNull(fila("Benficio_Herrajes")), 0, Convert.ToDouble(fila("Benficio_Herrajes")))
        Dim Carpeta_Datos As String = If(IsDBNull(fila("Carpeta_Datos")), "", fila("Carpeta_Datos").ToString())
        Dim Id_Fiscal As String = If(IsDBNull(fila("Id_Fiscal")), "", fila("Id_Fiscal").ToString())
        Dim Moneda As String = If(IsDBNull(fila("Moneda")), "", fila("Moneda").ToString())
        Dim tasa As Double = If(IsDBNull(fila("tasa")), 0, Convert.ToDouble(fila("tasa")))

        Me.Label1.Text = Idpresupuesto

        Me.PresupuestoTableAdapter.DuplicarPresupuesto(
        TxtIdProyecto.Text, Label2.Text, "pendiente", fecha, Id_EmpresaTextBox.Text, Id_Fiscal, Moneda, Carpeta_Datos,
        Descripcion_Presupuesto, Precio_Hora, Otros_Gastos, Gastos_Indierectos, Gastos_Imprevistos, Beneficio,
        TarnsporteEmbalaje, Otros, Descuento, Leyenda_Presupuesto
    )
    End Sub

    Sub DuplicarDatosPresupuesto()
        DuplicarPre()

        Dim PresupuestoOriginal As String = Label1.Text
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Label1.Text)

        Try
            Dim iTotalDetallePresu As Integer = Me.DsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows.Count
            Dim Contador As Integer = 1000

            For A = 0 To iTotalDetallePresu - 1
                Contador += 1
                Dim fila As DataRow = Me.DsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(A)

                ' == Strings y numéricos, todos seguros contra DBNull ==
                Dim Articulo As String = If(IsDBNull(fila("Articulo")), "", fila("Articulo").ToString())
                Dim Id_Proyecto As String = If(IsDBNull(fila("Id_Proyecto")), "", fila("Id_Proyecto").ToString())
                Dim Presupuesto As String = Label2.Text
                Dim IdDetalle_Presupuesto As String = Label2.Text & "-" & Microsoft.VisualBasic.Right(Contador, 3)
                Dim Cantidad As Double = If(IsDBNull(fila("Cantidad")), 0, Convert.ToDouble(fila("Cantidad")))
                Dim CostoMadera As Double = If(IsDBNull(fila("CostoMadera")), 0, Convert.ToDouble(fila("CostoMadera")))
                Dim CostoPintura As Double = If(IsDBNull(fila("CostoPintura")), 0, Convert.ToDouble(fila("CostoPintura")))
                Dim PrecioHora As Double = If(IsDBNull(fila("PrecioHora")), 0, Convert.ToDouble(fila("PrecioHora")))
                Dim TrabajoTaller As Double = If(IsDBNull(fila("TrabajoTaller")), 0, Convert.ToDouble(fila("TrabajoTaller")))
                Dim TrabajoPiintura As Double = If(IsDBNull(fila("TrabajoPiintura")), 0, Convert.ToDouble(fila("TrabajoPiintura")))
                Dim TotalHoras As Double = If(IsDBNull(fila("TotalHoras")), 0, Convert.ToDouble(fila("TotalHoras")))
                Dim CostoTrabajo As Double = If(IsDBNull(fila("CostoTrabajo")), 0, Convert.ToDouble(fila("CostoTrabajo")))
                Dim CostoFereteria As Double = If(IsDBNull(fila("CostoFereteria")), 0, Convert.ToDouble(fila("CostoFereteria")))
                Dim SubTotalCostoDirecto As Double = If(IsDBNull(fila("SubTotalCostoDirecto")), 0, Convert.ToDouble(fila("SubTotalCostoDirecto")))
                Dim OtrosCostos As Double = If(IsDBNull(fila("OtrosCostos")), 0, Convert.ToDouble(fila("OtrosCostos")))
                Dim CostoOtrosCostos As Double = If(IsDBNull(fila("CostoOtrosCostos")), 0, Convert.ToDouble(fila("CostoOtrosCostos")))
                Dim TotalCostoDirecto As Double = If(IsDBNull(fila("TotalCostoDirecto")), 0, Convert.ToDouble(fila("TotalCostoDirecto")))
                Dim CostoIdirecto As Double = If(IsDBNull(fila("CostoIdirecto")), 0, Convert.ToDouble(fila("CostoIdirecto")))
                Dim TotalCostoIdirecto As Double = If(IsDBNull(fila("TotalCostoIdirecto")), 0, Convert.ToDouble(fila("TotalCostoIdirecto")))
                Dim TransporteEmbalaje As Double = If(IsDBNull(fila("TransporteEmbalaje")), 0, Convert.ToDouble(fila("TransporteEmbalaje")))
                Dim Totalcosto As Double = If(IsDBNull(fila("Totalcosto")), 0, Convert.ToDouble(fila("Totalcosto")))
                Dim CostoTransporteEmbalaje As Double = If(IsDBNull(fila("CostoTransporteEmbalaje")), 0, Convert.ToDouble(fila("CostoTransporteEmbalaje")))
                Dim CostoHerrajes As Double = If(IsDBNull(fila("CostoHerrajes")), 0, Convert.ToDouble(fila("CostoHerrajes")))
                Dim Montaje As Double = If(IsDBNull(fila("Montaje")), 0, Convert.ToDouble(fila("Montaje")))
                Dim CostoMontaje As Double = If(IsDBNull(fila("CostoMontaje")), 0, Convert.ToDouble(fila("CostoMontaje")))
                Dim SubTotalCosto As Double = If(IsDBNull(fila("SubTotalCosto")), 0, Convert.ToDouble(fila("SubTotalCosto")))
                Dim Beneficio As Double = If(IsDBNull(fila("Beneficio")), 0, Convert.ToDouble(fila("Beneficio")))
                Dim TotalBeneficio As Double = If(IsDBNull(fila("TotalBeneficio")), 0, Convert.ToDouble(fila("TotalBeneficio")))
                Dim Imprevistos As Double = If(IsDBNull(fila("Imprevistos")), 0, Convert.ToDouble(fila("Imprevistos")))
                Dim TotalImprevistos As Double = If(IsDBNull(fila("TotalImprevistos")), 0, Convert.ToDouble(fila("TotalImprevistos")))
                Dim SubtotalVenta As Double = If(IsDBNull(fila("SubtotalVenta")), 0, Convert.ToDouble(fila("SubtotalVenta")))
                Dim Descuento As Double = If(IsDBNull(fila("Descuento")), 0, Convert.ToDouble(fila("Descuento")))
                Dim TotalDescuento As Double = If(IsDBNull(fila("TotalDescuento")), 0, Convert.ToDouble(fila("TotalDescuento")))
                Dim PrecioGenerado As Double = If(IsDBNull(fila("PrecioGenerado")), 0, Convert.ToDouble(fila("PrecioGenerado")))
                Dim PrecioVenta As Double = If(IsDBNull(fila("PrecioVenta")), 0, Convert.ToDouble(fila("PrecioVenta")))
                Dim Precio_Ajustado As Double = If(IsDBNull(fila("Precio_Ajustado")), 0, Convert.ToDouble(fila("Precio_Ajustado")))
                Dim TotalPartida As Double = If(IsDBNull(fila("TotalPartida")), 0, Convert.ToDouble(fila("TotalPartida")))
                Dim Id_Empresa As String = If(IsDBNull(fila("Id_Empresa")), "", fila("Id_Empresa").ToString())
                Dim Tasa As Double = If(IsDBNull(fila("Tasa")), 0, Convert.ToDouble(fila("Tasa")))
                Dim Moneda As String = If(IsDBNull(fila("Moneda")), "", fila("Moneda").ToString())
                Dim EstadoPresupuesto As String = If(IsDBNull(fila("EstadoPresupuesto")), "", fila("EstadoPresupuesto").ToString())
                Dim Precio_AjustadoRD As Double = If(IsDBNull(fila("_Precio_AjustadoRD_")), 0, Convert.ToDouble(fila("_Precio_AjustadoRD_")))
                Dim TotalPartidaRD As Double = If(IsDBNull(fila("TotalPartidaRD")), 0, Convert.ToDouble(fila("TotalPartidaRD")))
                Dim EnProduccion As Boolean = False
                Dim EnPintura As Boolean = False
                Dim Enobra As Boolean = False
                Dim Instalado As Boolean = False
                Dim Itbisincluido As Double = 0

                Me.PresupuestoDetalleTableAdapter.DoblarPresupuesto(
                Articulo, Presupuesto, IdDetalle_Presupuesto, Cantidad, Descuento, Precio_Ajustado, TotalPartida, Id_Empresa, Id_Proyecto,
                Beneficio, CostoFereteria, CostoHerrajes, CostoIdirecto, CostoMadera, CostoMontaje, CostoOtrosCostos, CostoPintura,
                CostoTransporteEmbalaje, Imprevistos, Montaje, OtrosCostos, PrecioHora, PrecioVenta, SubTotalCosto, SubTotalCostoDirecto,
                SubtotalVenta, TotalBeneficio, TotalCostoDirecto, TotalCostoIdirecto, TotalDescuento, TotalImprevistos, TrabajoPiintura,
                TrabajoTaller, TransporteEmbalaje, CostoTrabajo, TotalHoras, Totalcosto, PrecioGenerado, EstadoPresupuesto, Moneda,
                Precio_AjustadoRD, Tasa, TotalPartidaRD, Itbisincluido
            )
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            ' === Detalle Pintura ===
            Me.PresupuestoDetallePinturaTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetallePintura.PresupuestoDetallePintura, Label1.Text)
            Dim iTotalDetallePint As Integer = Me.DsPresupuestoDetallePintura.Tables("PresupuestoDetallePintura").Rows.Count

            For E = 0 To iTotalDetallePint - 1
                Dim fila As DataRow = Me.DsPresupuestoDetallePintura.Tables("PresupuestoDetallePintura").Rows(E)
                ' Manejo de DBNull en todos los campos relevantes
                Dim IdPinturaTipoPresupuesto As String = Label2.Text & Microsoft.VisualBasic.Right(If(IsDBNull(fila("IdPinturaTipoPresupuesto")), "", fila("IdPinturaTipoPresupuesto").ToString()), 46)
                Dim Id_Proyecto As String = TxtIdProyecto.Text
                Dim IdPresupuesto As String = Label2.Text
                Dim IdDetallePresupuesto As String = Label2.Text & Microsoft.VisualBasic.Right(If(IsDBNull(fila("IdDetallePresupuesto")), "", fila("IdDetallePresupuesto").ToString()), 4)
                Dim IdArticulo As String = If(IsDBNull(fila("IdArticulo")), "", fila("IdArticulo").ToString())
                Dim IdsubArticulo As String = If(IsDBNull(fila("IdsubArticulo")), "", fila("IdsubArticulo").ToString())
                Dim CantidadArticulos As Double = If(IsDBNull(fila("CantidadArticulos")), 0, Convert.ToDouble(fila("CantidadArticulos")))
                Dim CantidadSubarticulo As Double = If(IsDBNull(fila("CantidadSubarticulo")), 0, Convert.ToDouble(fila("CantidadSubarticulo")))
                Dim IdPinturaComponente As String = If(IsDBNull(fila("IdPinturaComponente")), "", fila("IdPinturaComponente").ToString())
                Dim MetrosCuadrados As Double = If(IsDBNull(fila("MetrosCuadrados")), 0, Convert.ToDouble(fila("MetrosCuadrados")))
                Dim ConsumoPorMetro As Double = If(IsDBNull(fila("ConsumoPorMetro")), 0, Convert.ToDouble(fila("ConsumoPorMetro")))
                Dim TotalConsumo As Double = If(IsDBNull(fila("TotalConsumo")), 0, Convert.ToDouble(fila("TotalConsumo")))
                Dim Desperdicio As Double = If(IsDBNull(fila("Desperdicio")), 0, Convert.ToDouble(fila("Desperdicio")))
                Dim TotalDesperdicio As Double = If(IsDBNull(fila("TotalDesperdicio")), 0, Convert.ToDouble(fila("TotalDesperdicio")))
                Dim TotalNecesidad As Double = If(IsDBNull(fila("TotalNecesidad")), 0, Convert.ToDouble(fila("TotalNecesidad")))
                Dim Estado_Presupuesto As String = If(IsDBNull(fila("Estado_Presupuesto")), "", fila("Estado_Presupuesto").ToString())
                Dim Id_Empresa As String = If(IsDBNull(fila("Id_Empresa")), "", fila("Id_Empresa").ToString())
                Dim Id_Detalle_Articulos As String = If(IsDBNull(fila("Id_Detalle_Articulos")), "", fila("Id_Detalle_Articulos").ToString())
                Dim Codigo As String = If(IsDBNull(fila("Codigo")), "", fila("Codigo").ToString())
                Dim PrecioCompra As Double = If(IsDBNull(fila("PrecioCompra")), 0, Convert.ToDouble(fila("PrecioCompra")))
                Dim TotalCosto As Double = If(IsDBNull(fila("TotalCosto")), 0, Convert.ToDouble(fila("TotalCosto")))
                Dim CosumoArticulo As Double = If(IsDBNull(fila("CosumoArticulo")), 0, Convert.ToDouble(fila("CosumoArticulo")))
                Dim TotalDesperdicioArticulo As Double = If(IsDBNull(fila("TotalDesperdicioArticulo")), 0, Convert.ToDouble(fila("TotalDesperdicioArticulo")))
                Dim TotalNecesidadarticulo As Double = If(IsDBNull(fila("TotalNecesidadarticulo")), 0, Convert.ToDouble(fila("TotalNecesidadarticulo")))
                Dim TotalCostoArticulo As Double = If(IsDBNull(fila("TotalCostoArticulo")), 0, Convert.ToDouble(fila("TotalCostoArticulo")))
                Dim CosumoPresupuesto As Double = If(IsDBNull(fila("CosumoPresupuesto")), 0, Convert.ToDouble(fila("CosumoPresupuesto")))
                Dim TotalDesperdicioPresupuesto As Double = If(IsDBNull(fila("TotalDesperdicioPresupuesto")), 0, Convert.ToDouble(fila("TotalDesperdicioPresupuesto")))
                Dim TotalNecesidadPresupuesto As Double = If(IsDBNull(fila("TotalNecesidadPresupuesto")), 0, Convert.ToDouble(fila("TotalNecesidadPresupuesto")))
                Dim TotalCostoPresupuesto As Double = If(IsDBNull(fila("TotalCostoPresupuesto")), 0, Convert.ToDouble(fila("TotalCostoPresupuesto")))
                Dim Id_Medida As String = If(IsDBNull(fila("Id_Medida")), "", fila("Id_Medida").ToString())
                Dim ConsumoXlitro As Double = If(IsDBNull(fila("ConsumoXlitro")), 0, Convert.ToDouble(fila("ConsumoXlitro")))
                Dim IdPinturaTipo As String = If(IsDBNull(fila("IdPinturaTipo")), "", fila("IdPinturaTipo").ToString())

                PresupuestoDetallePinturaTableAdapter.InsertarPintura(
                IdPinturaTipoPresupuesto, Id_Proyecto, IdPresupuesto, IdDetallePresupuesto, IdArticulo, IdsubArticulo,
                CantidadArticulos, CantidadSubarticulo, IdPinturaComponente, MetrosCuadrados, ConsumoPorMetro, TotalConsumo,
                Desperdicio, TotalDesperdicio, TotalNecesidad, Estado_Presupuesto, Id_Empresa, Id_Detalle_Articulos, Codigo,
                PrecioCompra, TotalCosto, CosumoArticulo, TotalDesperdicioArticulo, TotalNecesidadarticulo, TotalCostoArticulo,
                CosumoPresupuesto, TotalDesperdicioPresupuesto, TotalNecesidadPresupuesto, TotalCostoPresupuesto,
                Id_Medida, ConsumoXlitro, IdPinturaTipo
            )
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' === Detalle Herrajes ===
        Me.PresupuestoDetalleHerrajesTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes, Label1.Text)
        Dim iTotalDetalleHerr As Integer = Me.DsPresupuestoDetalleHerrajes.Tables("PresupuestoDetalleHerrajes").Rows.Count

        For i = 0 To iTotalDetalleHerr - 1
            Dim fila As DataRow = Me.DsPresupuestoDetalleHerrajes.Tables("PresupuestoDetalleHerrajes").Rows(i)
            Dim id_detalle_Herrajes As String = Label2.Text & Microsoft.VisualBasic.Right(If(IsDBNull(fila("Id_detalle_Herrajes")), "", fila("Id_detalle_Herrajes").ToString()), 8)
            Dim IdProyecto As String = TxtIdProyecto.Text
            Dim IdPresupuesto As String = Label2.Text
            Dim IdDetalle_Presupuesto As String = Label2.Text & Microsoft.VisualBasic.Right(If(IsDBNull(fila("IdDetalle_Presupuesto")), "", fila("IdDetalle_Presupuesto").ToString()), 4)
            Dim CantidadDetallepresupuesto As Double = If(IsDBNull(fila("CantidadDetallepresupuesto")), 0, Convert.ToDouble(fila("CantidadDetallepresupuesto")))
            Dim Id_Herraje As String = If(IsDBNull(fila("Id_Herraje")), "", fila("Id_Herraje").ToString())
            Dim CantidadHerrajesDetalle As Double = If(IsDBNull(fila("CantidadHerrajesDetalle")), 0, Convert.ToDouble(fila("CantidadHerrajesDetalle")))
            Dim TotalPresupuestoHerrajes As Double = If(IsDBNull(fila("TotalPresupuestoHerrajes")), 0, Convert.ToDouble(fila("TotalPresupuestoHerrajes")))
            Dim Id_Medida As String = If(IsDBNull(fila("Id_Medida")), "", fila("Id_Medida").ToString())
            Dim Id_Empresa As String = If(IsDBNull(fila("Id_Empresa")), "", fila("Id_Empresa").ToString())
            Dim Estado_Presupuesto As String = "Pendiente"
            Dim PrecioCompraHerrajes As Double = If(IsDBNull(fila("PrecioCompraHerrajes")), 0, Convert.ToDouble(fila("PrecioCompraHerrajes")))
            Dim TotalCostodetalle As Double = If(IsDBNull(fila("TotalCostodetalle")), 0, Convert.ToDouble(fila("TotalCostodetalle")))
            Dim TotalCostoPrespuesto As Double = If(IsDBNull(fila("TotalCostoPrespuesto")), 0, Convert.ToDouble(fila("TotalCostoPrespuesto")))
            Dim Codigo As String = Label2.Text & "-" & Id_Herraje

            Me.PresupuestoDetalleHerrajesTableAdapter.AnexarHerraje(
            id_detalle_Herrajes, IdProyecto, IdPresupuesto, IdDetalle_Presupuesto,
            CantidadDetallepresupuesto, Id_Herraje, CantidadHerrajesDetalle,
            TotalPresupuestoHerrajes, Id_Medida, Id_Empresa, Estado_Presupuesto,
            PrecioCompraHerrajes, TotalCostodetalle, TotalCostoPrespuesto, Codigo
        )
        Next

        My.Forms.FrmPresupuestos.Close()
        My.Forms.FrmPresupuestos.Label10.Text = Label2.Text
        My.Forms.FrmPresupuestos.PresupuestoDoblado()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DuplicarDatosPresupuesto()
    End Sub


    Sub Estado()
        Try


            Dim estado As String = DsPresupuestos.Presupuesto(PresupuestoBindingSource.Position).Estado_Presupuesto


            If estado = "Aprobado" Then
                BtmNotasEntrega.Enabled = True
            ElseIf estado = "Cerrado" Then
                BtmNotasEntrega.Enabled = True
            Else
                BtmNotasEntrega.Enabled = False

            End If

        Catch ex As Exception

        End Try
        Try
            Dim orden As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).OrdenDeCompra

            If orden <> "" Then
                BtnVerOrden.Enabled = True

            Else
                BtnVerOrden.Enabled = False

            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub TotalesProyecto()
        Try
            Dim ImpuestoUS As Double = 0
            Dim TotalUs As Double = 0
            Dim SubtotalUS As Double = 0
            Dim ImpuestoRD As Double = 0
            Dim TotalRD As Double = 0
            Dim SubtotalRD As Double = 0

            Dim isubTotal As Integer = PresupuestoDataGridView.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            'Definimos la variable i para controlar el ciclo for

            For Each row As DataGridViewRow In PresupuestoDataGridView.Rows
                SubtotalUS += Val(row.Cells(3).Value)
                ImpuestoUS += Val(row.Cells(4).Value)
                TotalUs += Val(row.Cells(5).Value)
                SubtotalRD += Val(row.Cells(6).Value)
                ImpuestoRD += Val(row.Cells(7).Value)
                TotalRD += Val(row.Cells(8).Value)
            Next

            'Mostramos el total en la caja de texto TxtTotal, en este caso la caja de texto tiene definido un formato como se mostrara el resultado, como dinero..
            TxtSubTotal.Text = Format(SubtotalUS, "#,##0.00")
            TxtTotal.Text = Format(TotalUs, "#,##0.00")
            TxtImpuesto.Text = Format(ImpuestoUS, "#,##0.00")

            SubRD.BackColor = Color.RoyalBlue
            ImpRD.BackColor = Color.RoyalBlue
            TotRD.BackColor = Color.RoyalBlue
            SubRD.Text = Format(SubtotalRD, "#,##0.00")
            ImpRD.Text = Format(ImpuestoRD, "#,##0.00")
            TotRD.Text = Format(TotalRD, "#,##0.00")

        Catch ex As Exception

        End Try





    End Sub




    Private Sub ProyectosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProyectosBindingNavigatorSaveItem.Click
        Validate()
        ProyectosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.DsProyectos)

    End Sub


    Private Sub FrmProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPreciosCompraProyecto.PreciosCompraProyecto' Puede moverla o quitarla según sea necesario.
        Me.PreciosCompraProyectoTableAdapter.Fill(Me.DsPreciosCompraProyecto.PreciosCompraProyecto)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleHerrajesTableAdapter.Fill(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetallePintura.PresupuestoDetallePintura' Puede moverla o quitarla según sea necesario.
        'Me.PresupuestoDetallePinturaTableAdapter.Fill(Me.DsPresupuestoDetallePintura.PresupuestoDetallePintura)

        MdiParent = My.Forms.FrmGestion
        Me.Dock = DockStyle.Fill
        DsClientes.EnforceConstraints = False
        ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)
        PresupuestoTableAdapter.Fill(DsPresupuestos.Presupuesto)
        ProyectosDetalleTableAdapter.Fill(Me.DsProyectosDetalle.ProyectosDetalle)
        BtnVerOrden.Enabled = False


        PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "Aprobado", "Pendiente", "Entregado")


        ProyectosDetalleTableAdapter.Fill(Me.DsProyectosDetalle.ProyectosDetalle)
        PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        'Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "Aprobado", "Pendiente", "Entregado")
        CmbBuscraEstado.SelectedIndex = -1

        txtdatos.Enabled = True

        TotalesProyecto()
        BtmNotasEntrega.Enabled = False

        Permisosclientes()




    End Sub
    Private Sub Id_ProyectoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdProyecto.TextChanged
        PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "Aprobado", "Pendiente", "Entregado")
        Id_EmpresaTextBox.Text = "IN"
        CmbBuscraEstado.Text = ""
        TotalesProyecto()
    End Sub

    Private Sub CmbBuscraEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBuscraEstado.SelectedIndexChanged
        PresupuestoTableAdapter.FillByEstado(Me.DsPresupuestos.Presupuesto, CmbBuscraEstado.Text, TxtIdProyecto.Text)
        TotalesProyecto()
    End Sub

    Private Sub CmbBuscarEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Id_EmpresaTextBox.Text.LongCount <> 0 And CmbBuscraEstado.Text.LongCount = 0 Then
            PresupuestoTableAdapter.FillByEmpresa(Me.DsPresupuestos.Presupuesto, TxtIdProyecto.Text, Id_EmpresaTextBox.Text)
        ElseIf Id_EmpresaTextBox.Text.LongCount <> 0 And CmbBuscraEstado.Text.LongCount <> 0 Then
            PresupuestoTableAdapter.FillByEstadoEmpresa(Me.DsPresupuestos.Presupuesto, TxtIdProyecto.Text, CmbBuscraEstado.Text, Id_EmpresaTextBox.Text)
        ElseIf Id_EmpresaTextBox.Text.LongCount = 0 And CmbBuscraEstado.Text.LongCount = 0 Then
            PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "Aprobado", "Cerrado", "Entregado")
        ElseIf Id_EmpresaTextBox.Text.LongCount = 0 And CmbBuscraEstado.Text.LongCount <> 0 Then
            PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "Aprobado", "Cerrado", "Entregado")
        End If
        TotalesProyecto()
    End Sub

    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click
        Validate()
        ProyectosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.DsProyectos)
    End Sub

    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCerrar.Click
        Close()
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        CmbBuscraEstado.Text = ""
        PresupuestoTableAdapter.FillByIdProyecto(DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "Aprobado", "Cerrado", "Entregado")
    End Sub


    Private Sub CmdNotasEntrega_Click(sender As System.Object, e As System.EventArgs) Handles BtmNotasEntrega.Click

        My.Forms.FrmVerNotasEntregas.Close()
        My.Forms.FrmVerNotasEntregas.txtpresupuesto.Text = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
        My.Forms.FrmVerNotasEntregas.txtproyecto.Text = TxtIdProyecto.Text
        My.Forms.FrmVerNotasEntregas.txtempresa.Text = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_empresa
        My.Forms.FrmVerNotasEntregas.txtsiguiente.Text = My.Forms.FrmVerNotasEntregas.NotasEntregaTableAdapter.SiguienteNotaEntrega(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto)

        My.Forms.FrmVerNotasEntregas.Show()
        My.Forms.FrmVerNotasEntregas.VerNotasEntraga()



    End Sub

    Private Sub BtnCarpetas_Click(sender As System.Object, e As System.EventArgs) Handles BtnCarpetas.Click
        ClientesTableAdapter.FillByIdFiscal(DsClientes.Clientes, TxtIdFiscalCliente.Text)
        If txtdatos.Text <> "" Then
            Shell("explorer.exe root =" + txtdatos.Text, vbNormalFocus)

        ElseIf txtdatos.Text = "" Then
            Dim CarpetaDatos As String = DsClientes.Clientes(Me.ClientesBindingSource.Position).CarpetaDatos

            MsgBox(CarpetaDatos + "\" + TxtNombre.Text)

            Dim carpeta As String = CarpetaDatos + "\" + TxtNombre.Text
            'Dim nuevacarpeta As String = TxtNombre.Text


            System.IO.Directory.CreateDirectory(carpeta)
            txtdatos.Text = carpeta
            Validate()
            ProyectosBindingSource.EndEdit()
            ProyectosTableAdapter.Update(Me.DsProyectos.Proyectos)
            Shell("explorer.exe root =" + txtdatos.Text, vbNormalFocus)

        End If
        Dim Subcarpeta As String = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Datos
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Documentos Cliente")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Presentaciones")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Presupuestos")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Informes")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Diseños")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Compras")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Compras" + "\" + "Ordenes Compra")
        System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Compras" + "\" + "Cotizaciones Clientes")

    End Sub

    Private Sub BtnIrPresupuesto_Click(sender As System.Object, e As System.EventArgs)
        Dim presupuesto As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
        My.Forms.FrmPresupuestos.PorPresupuesto()



    End Sub

    Private Sub BtnCompras_Click(sender As System.Object, e As System.EventArgs) Handles BtnCompras.Click
        My.Forms.FrmComprasProyecto.Close()


        My.Forms.FrmComprasProyecto.lblempresa.Text = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_empresa
        My.Forms.FrmComprasProyecto.LblProyecto.Text = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
        My.Forms.FrmComprasProyecto.LblPresupuesto.Text = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
        My.Forms.FrmComprasProyecto.FiltrarProyecto()







    End Sub

    Private Sub CmdNuevoPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevoPresupuesto.Click

        My.Forms.FrmPresupuestos.Close()

        Dim Ano As Integer = DateTime.Now.Year
        Dim IdFiscal As String = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Id_Fiscal
        Dim Empresa As String = Id_EmpresaTextBox.Text
        Dim Moneda As String = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).MonedaPresupuesto
        Dim fecha As Date = Date.Now()
        Dim carpetas As String = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Datos

        If Not String.IsNullOrWhiteSpace(Empresa) Then
            Dim SiguientePresupuestos As String = PresupuestoTableAdapter.SiguientePresupuesto(Empresa, Ano)
            Dim Presupuesto As String

            If String.IsNullOrWhiteSpace(SiguientePresupuestos) Then
                Presupuesto = Empresa & "-0001-" & Microsoft.VisualBasic.Right(Ano.ToString(), 2)
            Else
                Presupuesto = SiguientePresupuestos
            End If



            PresupuestoTableAdapter.NuecoPresupuesto(TxtIdProyecto.Text, SiguientePresupuestos, "pendiente", fecha, Id_EmpresaTextBox.Text, IdFiscal, Moneda, carpetas)

            My.Forms.FrmPresupuestos.Show()
            My.Forms.FrmPresupuestos.MdiParent = My.Forms.FrmGestion

            My.Forms.FrmPresupuestos.PresupuestoTableAdapter.FillByIdPresupuesto(My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto, Presupuesto)
        Else
            MsgBox("Por favor seleccione una Empresa")
        End If

    End Sub

    Private Sub BtnFacturas_Click(sender As System.Object, e As System.EventArgs) Handles BtnFacturas.Click
        My.Forms.FrmVerFacturas.Close()
        My.Forms.FrmVerFacturas.Show()
        My.Forms.FrmVerFacturas.FiltrarProyecto()

    End Sub


    Private Sub BtnEstadoProyecto_Click(sender As System.Object, e As System.EventArgs) Handles BtnEstadoProyecto.Click
        My.Forms.FrmEstadoCliente.Close()
        My.Forms.FrmEstadoCliente.filtrarCliente()
    End Sub

    Private Sub BtnEstadoEntregas_Click(sender As System.Object, e As System.EventArgs) Handles BtnEstadoEntregas.Click
        My.Forms.ImpEstadoEntregas.Close()
        My.Forms.ImpEstadoEntregas.Show()
        My.Forms.ImpEstadoEntregas.EstadoEntregas()
    End Sub

    Private Sub BtnPendienteEntregas_Click(sender As System.Object, e As System.EventArgs) Handles BtnPendienteEntregas.Click
        My.Forms.ImpEstadoEntregas.Close()
        My.Forms.ImpEstadoEntregas.Show()
        My.Forms.ImpEstadoEntregas.Pendiente()
    End Sub

    Private Sub BtnRevisionArticulos_Click(sender As System.Object, e As System.EventArgs) Handles BtnRevisionArticulos.Click
        My.Forms.FrmRevisionArticulos.Close()
        My.Forms.FrmRevisionArticulos.Show()
        My.Forms.FrmRevisionArticulos.PorProyecto()


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.RptImprimir.Show()
        My.Forms.RptImprimir.ImprimirDesdeProyecto()

    End Sub



    Private Sub PresupuestoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        ' Evitar errores si se hace clic en el encabezado o en una columna inválida
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Try
            ' Verificar que el BindingSource tiene datos
            If Me.PresupuestoBindingSource.Position >= 0 AndAlso DsPresupuestos.Presupuesto.Count > 0 Then
                Dim presupuesto As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
                Dim columnaClickeada As String = PresupuestoDataGridView.Columns(e.ColumnIndex).Name

                Select Case columnaClickeada
                    Case "Orden"
                        BuscarYAbrirOrden(e.RowIndex)

                    Case "Ver"
                        With FrmPresupuestos
                            .Label10.Text = presupuesto

                            .PorPresupuesto()
                            .Show()
                            .BringToFront()
                        End With

                    Case "Ejecutado"
                        With FrmEjecutadoPresupuesto
                            .Label1.Text = presupuesto


                            .Label2.Text = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descripcion_Presupuesto

                            .Show()
                            .BringToFront()
                        End With
                End Select
            End If

        Catch ex As Exception
            MessageBox.Show("Error al procesar la acción: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Método para seleccionar un archivo PDF y guardarlo en la celda de la columna 10
    Private Sub BuscarYAbrirOrden(filaIndex As Integer)
        ' 1. Obtener lo que hay en la celda (puede ser nombre de archivo o ruta)
        Dim valorCelda As Object = PresupuestoDataGridView.Rows(filaIndex).Cells(10).Value
        Dim rutaArchivo As String = If(valorCelda IsNot Nothing AndAlso Not IsDBNull(valorCelda), valorCelda.ToString(), "")
        Dim carpetaBase As String = Path.Combine(txtdatos.Text, "Ordenes Compra")
        Dim rutaCompleta As String = rutaArchivo

        ' 2. Si solo tiene el nombre, armar la ruta completa
        If Not String.IsNullOrWhiteSpace(rutaArchivo) AndAlso Not File.Exists(rutaArchivo) Then
            ' Si no existe como ruta absoluta, intentamos en la carpeta base
            rutaCompleta = Path.Combine(carpetaBase, rutaArchivo)
        End If

        ' 3. Probar abrir si existe
        If Not String.IsNullOrWhiteSpace(rutaCompleta) AndAlso File.Exists(rutaCompleta) Then
            Try
                Process.Start(rutaCompleta)
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("No se pudo abrir el archivo: " & ex.Message)
            End Try
        End If

        ' 4. Si no existe o está vacío, preguntar y guardar
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.InitialDirectory = carpetaBase
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
            openFileDialog.Title = "Seleccionar Orden de Compra"
            openFileDialog.Multiselect = False

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                rutaCompleta = openFileDialog.FileName
                Dim soloNombre As String = Path.GetFileName(rutaCompleta)
                PresupuestoDataGridView.Rows(filaIndex).Cells(10).Value = soloNombre

                ' Actualizar el DataTable si está enlazado (MUY IMPORTANTE)
                PresupuestoBindingSource.EndEdit()
                PresupuestoTableAdapter.Update(CType(PresupuestoBindingSource.DataSource, DataTable))

                ' Si tienes un TableAdapterManager global, puedes usar:
                ' TableAdapterManager7.UpdateAll(DsPresupuestos)

                Try
                    Process.Start(rutaCompleta)
                Catch ex As Exception
                    MessageBox.Show("No se pudo abrir el archivo: " & ex.Message)
                End Try
            End If
        End Using
    End Sub










    Private Sub BtnVerOrden_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerOrden.Click

        Try


            Dim NumerodeOrden As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto + "-" + DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).OrdenDeCompra

            If File.Exists("\\PORTATIL-DELL\Users\Public\Carpeta Datos\Ordenes Compra Cliente\" & NumerodeOrden & ".pdf") Then

                System.Diagnostics.Process.Start("\\PORTATIL-DELL\Users\Public\Carpeta Datos\Ordenes Compra Cliente\" & NumerodeOrden & ".pdf")
            Else

                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                msg = "Desea Abrir la carpeta de oredenes clientes para buscarla?"   ' Define message.
                style = MsgBoxStyle.DefaultButton2 Or
                   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                title = "Ordenes de compra"   ' Define title.
                ' Display message.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then   ' User chose Yes.
                    Shell("explorer.exe root = \\PORTATIL-DELL\Users\Public\Carpeta Datos\Ordenes Compra Cliente", vbNormalFocus)
                Else

                End If
            End If
        Catch ex As Exception
            Dim msg As String
            Dim title As String
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            msg = "Desea añadir la orden al presupuesto"   ' Define message.
            style = MsgBoxStyle.DefaultButton2 Or
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            title = "Añadir de Orden de Compra"   ' Define title.
            ' Display message.
            response = MsgBox(msg, style, title)
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                Dim presupuesto As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
                My.Forms.FrmPresupuestos.PorPresupuesto()
            Else

            End If
        End Try
    End Sub

    Private Sub BtnResumenMontaje_Click(sender As System.Object, e As System.EventArgs) Handles BtnResumenMontaje.Click

        My.Forms.FrmGastosProyecto.Close()
        My.Forms.FrmGastosProyecto.Label1.Text = TxtIdProyecto.Text



        My.Forms.FrmGastosProyecto.Show()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Forms.FrmComprasProyecto.Close()

        My.Forms.FrmComprasProyecto.LblProyecto.Text = Me.TxtIdProyecto.Text
        My.Forms.FrmComprasProyecto.lblempresa.Text = "IN"
        My.Forms.FrmComprasProyecto.LblPresupuesto.Text = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
        My.Forms.FrmComprasProyecto.FiltrarProyectoEmpresa()
    End Sub

    Private Sub BtnAnalisisProyecto_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnalisisProyecto.Click
        My.Forms.InfAnalisisPresupuesto.Close()
        My.Forms.InfAnalisisPresupuesto.Show()
        My.Forms.InfAnalisisPresupuesto.AnalisisPoyecto()
    End Sub



    Private Sub PresupuestoDataGridView_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDataGridView.RowEnter
        Dim EstadoPresupuesto As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Estado_Presupuesto
        If EstadoPresupuesto = "Aprobado" Then
            BtmNotasEntrega.Enabled = True
        Else
            BtmNotasEntrega.Enabled = False
        End If
    End Sub

    Private Sub PresupuestoDataGridView_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles PresupuestoDataGridView.CellFormatting
        PresupuestoDataGridView.Columns(6).DefaultCellStyle.BackColor = Color.RoyalBlue
        PresupuestoDataGridView.Columns(7).DefaultCellStyle.BackColor = Color.RoyalBlue
        PresupuestoDataGridView.Columns(8).DefaultCellStyle.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try


            My.Forms.FrmFacturaMontajeEditar.Close()
            My.Forms.FrmFacturaMontajeEditar.LblPresupuesto.Text = PresupuestoDataGridView.CurrentRow.Cells(1).Value
            My.Forms.FrmFacturaMontajeEditar.LblProyecto.Text = TxtIdProyecto.Text
            My.Forms.FrmFacturaMontajeEditar.EmpresasContratadasMontajeTableAdapter.Fill(My.Forms.FrmFacturaMontajeEditar.DsPagosMontaje.EmpresasContratadasMontaje)
            My.Forms.FrmFacturaMontajeEditar.NuevaFActura()
        Catch ex As Exception
            MsgBox("No hay Presupuesto")
        End Try

    End Sub

    Private Sub PresupuestoDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellEndEdit
        Try


            If e.ColumnIndex = 12 Then
                Dim presupuesto As String = DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
                Dim Ejecuatado As Double = PresupuestoDataGridView.CurrentRow.Cells(12).Value
                PresupuestoTableAdapter.Ejecutado(Ejecuatado, presupuesto)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        My.Forms.FrmFacturaMontajeResumen.FmProyecto()
        My.Forms.FrmFacturaMontajeResumen.Label9.Text = TxtIdProyecto.Text
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Forms.FrmDuplicarPreciosCompra.Close()
        My.Forms.FrmDuplicarPreciosCompra.Show()
    End Sub
End Class
