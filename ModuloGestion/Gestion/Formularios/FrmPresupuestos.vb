Imports System.Math
Imports System.IO

Public Class FrmPresupuestos

    Private Sub FrmPresupuestos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        TxtOrdenDeCompra.ReadOnly = True
        TxtOrdenDeCompra.BackColor = SystemColors.Window ' Fondo blanco como normal
        TxtOrdenDeCompra.Cursor = Cursors.Hand          ' Cambia el cursor para indicar clic
        Carpeta_DatosTextBox.Text = True
        Carpeta_DatosTextBox.BackColor = SystemColors.Window ' Fondo blanco como normal


    End Sub



    Private Sub ActualizarTotales()
        Totales()
    End Sub

    Sub EstadoPresupuesto()
        With Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position)
            Dim TotalUS As Double = .TotalPresupuestoUS
            Dim pagadoUS As Double = .PagadopresupuestoUS
            Dim EstadoUS As Double = TotalUS - pagadoUS
            Dim TotalRD As Double = .TotalPresupuestoRD
            Dim pagadoRD As Double = ._PagadoRD_
            Dim PendienteRD As Double = TotalRD - pagadoRD
        End With
    End Sub

    Sub CargarPresupuestoDetalles()
        Try
            MdiParent = My.Forms.FrmGestion
            Permisosclientes()
            Me.GrbPresupuestodetalles.Visible = False
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
            Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, Label10.Text)
            Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Label10.Text)
            Me.Show()
            Totales()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub PresupuestoDoblado()
        CargarPresupuestoDetalles()
        Actulizarconsumos()
    End Sub

    Public Sub PorPresupuesto()
        CargarPresupuestoDetalles()
    End Sub

    Public Sub Permisosclientes()
        Dim CategotiaUsuario As String = My.Forms.FrmGestion.Label1.Text
        Select Case CategotiaUsuario
            Case "2"
                ' Implementar permisos específicos si es necesario
            Case "3"
                Me.GroupBox1.Enabled = False
                Me.GroupBox3.Enabled = False
                Me.GroupBox2.Enabled = False
                BtnNotaEntrega.Enabled = True
                Me.TxtOrdenDeCompra.Enabled = True
            Case "4"
                Me.GroupBox3.Enabled = False
                Me.PresupuestoDetalleDataGridView.Enabled = False
                Me.CmdGenerles.Enabled = False
                Me.TxtFecha.Enabled = False
                Me.DateTimePicker1.Enabled = False
                Me.TxtDescripcion.Enabled = False
                Me.Leyenda_PresupuestoTextBox.Enabled = False
        End Select
    End Sub

    Public Sub TodosLosPresupuestos()
        Try
            Permisosclientes()
            Me.GrbPresupuestodetalles.Visible = False
            Me.GroupBox1.Text = UCase("Proyecto ")
            Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
            Dim presupuesto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
            Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, presupuesto)
            Me.Show()
            Me.MdiParent = My.Forms.FrmGestion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub PrecioArticulo()
        With Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position)
            Dim IdDetalle_Presupuesto As String = .IdDetalle_Presupuesto
            Dim Cantidad As Double = .Cantidad
            Dim CostoMadera As Double = .CostoMadera
            Dim CostoPintura As Double = .CostoPintura
            Dim PrecioHora As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Precio_Hora
            Dim TotalHoras As Double = .TotalHoras
            Dim CostoTrabajo As Double = PrecioHora * TotalHoras
            Dim CostoFereteria As Double = .CostoFereteria
            Dim OtrosCostos As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Otros_Gastos
            Dim TotalCostoDirecto As Double = CostoMadera + CostoPintura + CostoFereteria + CostoTrabajo
            Dim CostoOtrosCostos As Double = TotalCostoDirecto * OtrosCostos
            Dim SubTotalCostoDirecto As Double = TotalCostoDirecto + CostoOtrosCostos
            Dim CostoIdirecto As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Gastos_Indierectos
            Dim TotalCostoIdirecto As Double = TotalHoras * CostoIdirecto
            Dim TransporteEmbalaje As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Tarnsporte_Embalaje
            Dim Totalcosto As Double = SubTotalCostoDirecto + TotalCostoIdirecto
            Dim CostoTransporteEmbalaje As Double = Totalcosto * TransporteEmbalaje
            Dim CostoHerrajes As Double = .CostoHerrajes
            Dim Montaje As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Costo_Montaje
            Dim CostoMontaje As Double = .CostoMontaje
            Dim SubTotalCosto As Double = Totalcosto + CostoTransporteEmbalaje + CostoHerrajes + CostoMontaje

            If SubTotalCosto <> 0 Then
                Dim Beneficio As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Beneficio
                Dim TotalBeneficio As Double = (SubTotalCosto / (1 - Beneficio)) - SubTotalCosto
                Dim Imprevistos As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Gastos_Imprevistos
                Dim SubtotalVenta As Double = SubTotalCosto + TotalBeneficio
                Dim TotalImprevistos As Double = SubtotalVenta * Imprevistos
                Dim Descuento As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descuento
                Dim PrecioGenerado As Double = SubtotalVenta + TotalImprevistos
                Dim TotalDescuento As Double = PrecioGenerado * Descuento
                Dim PrecioVenta As Double = PrecioGenerado - TotalDescuento
                Dim Precio_Ajustado As Double = PrecioVenta
                Dim TotalPartida As Double = PrecioVenta * Cantidad
                Dim tasa As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa
                Dim precioRd As Double = Round(tasa * Precio_Ajustado / 10) * 10
                Dim totalRd As Double = precioRd * Cantidad

                Me.PresupuestoDetalleTableAdapter.ActulizarPresipuestoGenerales(PrecioHora, CostoTrabajo, SubTotalCostoDirecto, OtrosCostos, CostoOtrosCostos, SubTotalCostoDirecto, CostoIdirecto, TotalCostoIdirecto, TransporteEmbalaje, Totalcosto, CostoTransporteEmbalaje, CostoHerrajes, CostoMontaje, SubTotalCosto, Beneficio, TotalBeneficio, Imprevistos, TotalImprevistos, SubtotalVenta, Descuento, TotalDescuento, PrecioGenerado, PrecioVenta, Precio_Ajustado, TotalPartida, precioRd, totalRd, IdDetalle_Presupuesto)
            Else
                MsgBox("No hay registros que generar en el detalle " & IdDetalle_Presupuesto)
            End If
        End With
    End Sub

    Public Sub CambioPrecio()
        Try
            ' Verificar si hay una fila seleccionada en el DataGridView
            If Me.PresupuestoDetalleDataGridView.CurrentRow Is Nothing Then
                Exit Sub
            End If

            ' Obtener valores asegurando que no sean nulos y sean numéricos
            Dim Cantidad As Double = 0
            Dim Precio As Double = 0
            Dim tasa As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa

            ' Validación de Cantidad
            If Not IsDBNull(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("CantidadView").Value) AndAlso
           IsNumeric(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("CantidadView").Value) Then
                Cantidad = CDbl(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("CantidadView").Value)
            End If

            ' Validación de Precio
            If Not IsDBNull(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("Precioview").Value) AndAlso
           IsNumeric(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("Precioview").Value) Then
                Precio = CDbl(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("Precioview").Value)
            End If

            ' Validación de Tasa de Cambio
            If Me.DsPresupuestos.Presupuesto.Count > 0 AndAlso
           Not IsDBNull(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa) AndAlso
           IsNumeric(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa) Then
                tasa = CDbl(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa)
            End If

            ' Cálculos
            Dim PrecioRD As Double = Math.Round((Precio * tasa) / 10, 0) * 10
            Dim totalPartida As Double = Cantidad * Precio
            Dim totalPartidaRd As Double = Cantidad * PrecioRD

            ' Asignar valores a las celdas correspondientes
            Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("totalview").Value = totalPartida
            Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("PrecioRDview").Value = PrecioRD
            Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("totalRdview").Value = totalPartidaRd

            ' Actualizar totales y guardar cambios
            Totales()
            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.PresupuestoDetalleTableAdapter.Update(Me.DsPresupuestoDetalle)

        Catch ex As Exception
            MessageBox.Show("Error en CambioPrecio(): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub Totales()
        Dim SuBtotal As Double = 0
        Dim SuBtotalRD As Double = 0

        For Each row As DataGridViewRow In Me.PresupuestoDetalleDataGridView.Rows
            SuBtotal += Val(row.Cells("TotalView").Value)
            SuBtotalRD += Val(row.Cells("TotalrdView").Value)
        Next

        With DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position)
            Dim ItbisIncluido As Boolean = .ItbisIncluido
            Dim Impuesto As Double = .Impuesto
            Dim ValorImpuesto As Double = If(ItbisIncluido, (SuBtotal / 10) * Impuesto, SuBtotal * Impuesto)
            Dim ValorImpuestoRd As Double = If(ItbisIncluido, (SuBtotalRD / 10) * Impuesto, SuBtotalRD * Impuesto)
            Dim totalUS As Double = SuBtotal + ValorImpuesto
            Dim totalrd As Double = SuBtotalRD + ValorImpuestoRd
            Dim pagadoUS As Double = .PagadopresupuestoUS
            Dim pagadoRD As Double = ._PagadoRD_
            Dim estadoUS As Double = totalUS - pagadoUS
            Dim estadoRD As Double = totalrd - pagadoRD

            Me.SubTotalUSTextBox.Text = Format(SuBtotal, "#,##0.00")
            Me.ValorImpuestoUsTextBox.Text = Format(ValorImpuesto, "#,##0.00")
            Me.TotalPresupuestoUSTextBox.Text = Format(totalUS, "#,##0.00")
            Me.SubTotalRDTextBox.Text = Format(SuBtotalRD, "#,##0.00")
            Me.ValorImpuestoRDTextBox.Text = Format(ValorImpuestoRd, "#,##0.00")
            Me.TotalPresupuestoRDTextBox.Text = Format(totalrd, "#,##0.00")
            Me.LblImpuesto.Text = Format("Impuesto " & (Impuesto * 100) & "%")
            Me.PresupuestoTableAdapter.ActulizarTotal(SuBtotal, totalUS, ValorImpuesto, SuBtotalRD, ValorImpuestoRd, totalrd, estadoUS, estadoRD, TxtIdPresupuesto.Text)
        End With
    End Sub

    Private Sub TxtDescripcion_Leave(sender As System.Object, e As System.EventArgs) Handles TxtDescripcion.Leave
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
    End Sub


    Private Sub MonedaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles MonedaComboBox.SelectedIndexChanged
        Try
            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()
            Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub NuevoDetalleFerreteria()
        Try
            Dim Articulos As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
            Dim IdDetallePresupuesto As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Dim Proyecto As String = Me.TxtIdProyecto.Text
            Dim Presupuesto As String = Me.TxtIdPresupuesto.Text
            Dim Empresa As String = Me.TxtIdEmpresa.Text
            Dim EstadoPresupuesto As String = Me.TxtEstado.Text

            Me.TotalFerreteriaArticuloTableAdapter.FillByIdArticulo(Me.DsTotalFerreteriaArticulo.TotalFerreteriaArticulo, Articulos)
            For Each row As DataRow In Me.DsTotalFerreteriaArticulo.TotalFerreteriaArticulo.Rows
                Dim IdDetlleArticulo As String = row("Id_Detalle_Articulos").ToString()
                Dim IdSubarticulo As String = row("ID_Sub_Articulo").ToString()
                Dim IdDetlleFerreteria As String = row("Id_detalle_Ferreteria").ToString()
                Dim IdFerreteria As String = row("Id_Eemento_Ferreteria").ToString()
                Dim IdPresupuestoFerreteria As String = $"{IdDetallePresupuesto}-{IdDetlleArticulo}-{IdDetlleFerreteria}-{IdFerreteria}"
                Dim CantidadDetalleFerreteria As Integer = Convert.ToInt32(row("Cantidad_Ferreteria"))
                Dim medida As String = row("Medidad_Elementos_Ferreteria").ToString()
                Dim CantidadSubarticulos As Integer = Convert.ToInt32(row("Cantidad"))
                Dim CantidadPresupuesto As Integer = Convert.ToInt32(Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad)
                Dim totalSubarticulo As Integer = CantidadDetalleFerreteria
                Dim totalArticulo As Integer = CantidadDetalleFerreteria * CantidadSubarticulos
                Dim totalPresupuesto As Integer = totalArticulo * 1
                Dim codigo As String = $"{Presupuesto}-{IdFerreteria}"

                Me.PresupuestoDetalleFerreteriaTableAdapter.AnexarFerreteria(IdPresupuestoFerreteria, Proyecto, Presupuesto, IdDetallePresupuesto, IdFerreteria, CantidadDetalleFerreteria, CantidadSubarticulos, CantidadPresupuesto, 0, totalSubarticulo, totalArticulo, totalPresupuesto, 0, 0, 0, codigo, medida, Empresa, EstadoPresupuesto, IdSubarticulo)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CambioGenericoPresupuesto()
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, TxtIdPresupuesto.Text)
        For Each row As DataRow In Me.DsPresupuestoDetalle.PresupuestoDetalle.Rows
            With Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position)
                Dim IdDetalle_Presupuesto As String = row("IdDetalle_Presupuesto").ToString()
                Dim Cantidad As Double = Convert.ToDouble(row("Cantidad"))
                Dim CostoMadera As Double = Convert.ToDouble(row("CostoMadera"))
                Dim CostoPintura As Double = Convert.ToDouble(row("CostoPintura"))
                Dim PrecioHora As Double = .Precio_Hora
                Dim TotalHoras As Double = Convert.ToDouble(row("TotalHoras"))
                Dim CostoTrabajo As Double = PrecioHora * TotalHoras
                Dim CostoFereteria As Double = Convert.ToDouble(row("CostoFereteria"))
                Dim OtrosCostosPresupuesto As Double = .Otros_Gastos
                Dim OtrosCostosDetalle As Double = Convert.ToDouble(row("OtrosCostos"))
                Dim otroscostos As Double = If(OtrosCostosPresupuesto <> OtrosCostosDetalle, OtrosCostosDetalle, OtrosCostosPresupuesto)
                Dim TotalCostoDirecto As Double = CostoMadera + CostoPintura + CostoFereteria + CostoTrabajo
                Dim CostoOtrosCostos As Double = TotalCostoDirecto * otroscostos
                Dim SubTotalCostoDirecto As Double = TotalCostoDirecto + CostoOtrosCostos
                Dim CostoIdirecto As Double = .Gastos_Indierectos
                Dim TotalCostoIdirecto As Double = TotalHoras * CostoIdirecto
                Dim TransporteEmbalajepresupuesto As Double = .Tarnsporte_Embalaje
                Dim TransporteEmbalajeDetalle As Double = Convert.ToDouble(row("TransporteEmbalaje"))
                Dim TransporteEmbalaje As Double = If(TransporteEmbalajepresupuesto <> TransporteEmbalajeDetalle, TransporteEmbalajeDetalle, TransporteEmbalajepresupuesto)
                Dim Totalcosto As Double = SubTotalCostoDirecto + TotalCostoIdirecto
                Dim CostoTransporteEmbalaje As Double = Totalcosto * TransporteEmbalaje
                Dim CostoHerrajes As Double = Convert.ToDouble(row("CostoHerrajes"))
                Dim Montaje As Double = .Costo_Montaje
                Dim CostoMontaje As Double = Convert.ToDouble(row("CostoMontaje"))
                Dim SubTotalCosto As Double = Totalcosto + CostoTransporteEmbalaje + CostoHerrajes + CostoMontaje

                If SubTotalCosto <> 0 Then
                    Dim BeneficioPresupuesto As Double = .Beneficio
                    Dim BeneficioDetalle As Double = Convert.ToDouble(row("Beneficio"))
                    Dim Beneficio As Double = If(BeneficioPresupuesto <> BeneficioDetalle, BeneficioDetalle, BeneficioPresupuesto)
                    Dim TotalBeneficio As Double = (SubTotalCosto / (1 - Beneficio)) - SubTotalCosto
                    Dim Imprevistos As Double = .Gastos_Imprevistos
                    Dim SubtotalVenta As Double = SubTotalCosto + TotalBeneficio
                    Dim TotalImprevistos As Double = SubtotalVenta * Imprevistos
                    Dim DescuentoPresupuesto As Double = .Descuento
                    Dim DescuentoDetalle As Double = Convert.ToDouble(row("Descuento"))
                    Dim Descuento As Double = If(DescuentoPresupuesto <> DescuentoDetalle, DescuentoDetalle, DescuentoPresupuesto)
                    Dim PrecioGenerado As Double = SubtotalVenta + TotalImprevistos
                    Dim TotalDescuento As Double = PrecioGenerado * Descuento
                    Dim PrecioVenta As Double = PrecioGenerado - TotalDescuento
                    Dim Precio_Ajustado As Double = PrecioVenta
                    Dim TotalPartida As Double = PrecioVenta * Cantidad
                    Dim tasa As Double = Convert.ToDouble(TasaTextBox.Text)
                    Dim precioRd As Double = Round(tasa * Precio_Ajustado / 10) * 10
                    Dim totalRd As Double = precioRd * Cantidad

                    Me.PresupuestoDetalleTableAdapter.ActulizarPresipuestoGenerales(PrecioHora, CostoTrabajo, SubTotalCostoDirecto, otroscostos, CostoOtrosCostos, SubTotalCostoDirecto, CostoIdirecto, TotalCostoIdirecto, TransporteEmbalaje, Totalcosto, CostoTransporteEmbalaje, CostoHerrajes, CostoMontaje, SubTotalCosto, Beneficio, TotalBeneficio, Imprevistos, TotalImprevistos, SubtotalVenta, Descuento, TotalDescuento, PrecioGenerado, PrecioVenta, Precio_Ajustado, TotalPartida, precioRd, totalRd, IdDetalle_Presupuesto)
                Else
                    MsgBox("No hay registros que generar en el detalle " & IdDetalle_Presupuesto)
                End If
            End With
        Next

        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, TxtIdPresupuesto.Text)
    End Sub

    Sub NuevoPresupuestoDetalleElemento()
        Try
            Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
            Dim empresa As String = TxtIdEmpresa.Text
            Dim Proyecto As String = TxtIdProyecto.Text
            Dim presupuesto As String = TxtIdPresupuesto.Text
            Dim estaddopresupuesto As String = TxtEstado.Text
            Dim IdDetallePresupuesto As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Dim IdArticulo As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
            Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, IdArticulo)
            Dim CantidadArticulos As Double = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad

            For Each row As DataRow In Me.DsArticulosdetalle.ArticulosDetalle.Rows
                Dim IdSubarticulo As String = row("ID_Sub_Articulo").ToString()
                Dim cantidadSubarticulos As Double = Convert.ToDouble(row("Cantidad"))
                Dim IdDetalleArticulos As String = row("Id_Detalle_Articulos").ToString()
                Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, IdSubarticulo)

                For Each subRow As DataRow In Me.DsSubArticulosDetalle.SubArticulosDetalle.Rows
                    Dim IddetalleSubarticulo As String = subRow("Id_detalle_Sub_Articulo").ToString()
                    Dim IdeDetllepresupuestoelementos As String = $"{Proyecto}-{presupuesto}-{IdDetallePresupuesto}-{IdArticulo}-{IdSubarticulo}-{IddetalleSubarticulo}"
                    Dim material As String = subRow("Id_Material_Detalle").ToString()
                    Dim canntidadelementos As Double = Convert.ToDouble(subRow("Cantidad"))
                    Dim DesperdicioMaterial As Double = Convert.ToDouble(subRow("DesperdicioMaterial"))
                    Dim TotalDesperdicio As Double = Convert.ToDouble(subRow("TotalDesperdicio"))
                    Dim ConsumoTotal As Double = Convert.ToDouble(subRow("ConsumoTotal"))
                    Dim TotalCompra As Double = Convert.ToDouble(subRow("TotalCompra"))
                    Dim idMedida As String = subRow("Id_Medida").ToString()
                    Dim M2PinturaUnidad As Double = Convert.ToDouble(subRow("M2PinuturaUnidad"))
                    Dim M2PinturaTotal As Double = Convert.ToDouble(subRow("M2PinuturaUnidadtotal"))
                    Dim TotalConsumoArticulos As Double = cantidadSubarticulos * ConsumoTotal
                    Dim TotalDesperdicioArticulo As Double = DesperdicioMaterial * TotalConsumoArticulos
                    Dim TotalcompraArticulos As Double = TotalConsumoArticulos + TotalDesperdicioArticulo
                    Dim TotalConsumoPresupuesto As Double = CantidadArticulos * TotalConsumoArticulos
                    Dim TotalDesperdicioPresupuesto As Double = CantidadArticulos * TotalDesperdicioArticulo
                    Dim TotalcompraPresupuesto As Double = TotalConsumoPresupuesto + TotalDesperdicioPresupuesto
                    Dim Codigo As String = $"{presupuesto}-{material}"
                    Me.PreciosCompraProyectoTableAdapter.FillByIdCodigo(Me.DsPreciosCompraProyecto.PreciosCompraProyecto, Codigo)
                    Dim VerificarPrecio As Integer = Me.DsPreciosCompraProyecto.Tables("PreciosCompraProyecto").Rows.Count
                    Dim precio As Double = If(VerificarPrecio > 0, Convert.ToDouble(Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Precio_Compra), 0)
                    Dim Costoelemento As Double = precio * TotalCompra
                    Dim CostoArtilculo As Double = precio * TotalcompraArticulos
                    Dim CostoPresupuesto As Double = precio * TotalcompraPresupuesto

                    Me.PresupuestoDetalleElementosTableAdapter.InsertarPresupuestoDetalleElementos(IdeDetllepresupuestoelementos, Proyecto, presupuesto, IdDetallePresupuesto, IdArticulo, IdSubarticulo, IddetalleSubarticulo, CantidadArticulos, cantidadSubarticulos, canntidadelementos, material, ConsumoTotal, DesperdicioMaterial, TotalDesperdicio, TotalCompra, idMedida, empresa, estaddopresupuesto, precio, Costoelemento, IdDetalleArticulos, M2PinturaUnidad, M2PinturaTotal, TotalConsumoArticulos, TotalDesperdicioArticulo, TotalcompraArticulos, CostoArtilculo, TotalConsumoPresupuesto, TotalDesperdicioPresupuesto, TotalcompraPresupuesto, CostoPresupuesto, Codigo)
                Next
            Next
            NuevoDetalleFerreteria()
        Catch ex As Exception
            MsgBox(ex.Message & " " & Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos(Me.PresupuestoDetalleElementosBindingSource.Position).IdArticulo)
        End Try
    End Sub

    Sub ActulizarconsumosArticulo()
        Dim DetallePresupuesto As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
        Try
            Me.PresupuestoDetalleElementosTableAdapter.Eliminar(DetallePresupuesto)
            NuevoPresupuestoDetalleElemento()
        Catch ex As Exception
            MsgBox(ex.Message & "este2")
        End Try
    End Sub

    Sub Actualizarcampo()
        Try
            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()
            Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
            With Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position)
                Dim precioHora As Double = .Precio_Hora
                Dim otrosGastos As Double = .Otros_Gastos
                Dim gastosindirectos As Double = .Gastos_Indierectos
                Dim gastosimprevistos As Double = .Gastos_Imprevistos
                Dim beneficio As Double = .Beneficio
                Dim transporteembalje As Double = .Tarnsporte_Embalaje
                Dim otros As Double = .Otros
                Dim descuento As Double = .Descuento
                Dim impuesto As Double = .Impuesto
                Dim tasa As Double = .tasa
                Me.PresupuestoTableAdapter.ActulizarCampo(TxtDescripcion.Text, Leyenda_PresupuestoTextBox.Text, precioHora, otrosGastos, gastosindirectos, gastosimprevistos, beneficio, transporteembalje, otros, descuento, impuesto, tasa, TxtIdPresupuesto.Text)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Anecharcompras()
        Try
            Me.PreciosCompraProyectoTableAdapter.EliminarMaterial()
            Me.AnexarMaterialCompraTableAdapter.AnexarCompraMaterial(Me.TxtIdPresupuesto.Text)
            Me.AnrxarPinturaCompraTableAdapter.AnexarPinturaCompra(Me.TxtIdPresupuesto.Text)
            Me.AnexarHerrajesCompraTableAdapter.AnexarHerrajeCompra(Me.TxtIdPresupuesto.Text)
            Me.AnexarFerreteriaCompraTableAdapter.AnexarFerreteriaCompra(Me.TxtIdPresupuesto.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub FiltrarHerrajes()
        Try
            Me.ConsultaHerrajePresupuestoDetalleTableAdapter.Fill(Me.DsConsultaHerrajesPresupuestoDetalle.ConsultaHerrajePresupuestoDetalle)
            Dim idPresupuestodetalle As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Dim TipoAplicacion As String = Me.PresupuestoDetallePinturaTableAdapter.TipoDePinturaPresupuestada(idPresupuestodetalle)
            Me.LblPintura.Text = If(TipoAplicacion <> "", TipoAplicacion, "NO HAY PINTURA ASIGNADA AL ARTICULO")
            Me.ConsultaHerrajePresupuestoDetalleTableAdapter.FillByIdPresupuestoDetalle(Me.DsConsultaHerrajesPresupuestoDetalle.ConsultaHerrajePresupuestoDetalle, idPresupuestodetalle)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Actulizarconsumos()
        Me.PresupuestoDetalleBindingSource.MoveFirst()
        For Each row As DataRow In Me.DsPresupuestoDetalle.PresupuestoDetalle.Rows
            Dim DetallePresupuesto As String = row("IdDetalle_Presupuesto").ToString()
            Try
                Me.PresupuestoDetalleElementosTableAdapter.Eliminar(DetallePresupuesto)
                NuevoPresupuestoDetalleElemento()
            Catch ex As Exception
                MsgBox(ex.Message & "este")
            End Try
            Me.PresupuestoDetalleBindingSource.MoveNext()
        Next
        MsgBox("Se Han Actulizado los consumos de material")
    End Sub

    Sub DetallePresupuesto()
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, TxtIdPresupuesto.Text)
    End Sub

    Sub ActulizarConsumospresupuestos()
        Try
            Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("TotalView").Value = Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("CantidadView").Value * Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("Precioview").Value
            Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("TotalrdView").Value = Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("CantidadView").Value * Me.PresupuestoDetalleDataGridView.CurrentRow.Cells("Preciordview").Value

            Dim IdPresupuestodetalle As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Dim Cantidad As Double = Convert.ToDouble(Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad)

            Me.PresupuestoDetalleElementosTableAdapter.FillByIdDetallePresupuesto(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos, IdPresupuestodetalle)
            For Each row As DataRow In Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos.Rows
                Dim IdDetalleElemento As String = row("IdPresupuestoDetalleElemento").ToString()
                Dim precioEle As Double = Convert.ToDouble(row("PrecioCompra"))
                Dim totalPartida As Double = Cantidad * precioEle
                Dim consumoArticulo As Double = Convert.ToDouble(row("ConsumoTotalArticulo"))
                Dim ConsumoTotalPresupuesto As Double = consumoArticulo * Cantidad
                Dim desperdicio As Double = Convert.ToDouble(row("DesperdicioMaterial"))
                Dim TotalDesperdicioPresupuesto As Double = ConsumoTotalPresupuesto * desperdicio
                Dim TotalCompraPresupuesto As Double = ConsumoTotalPresupuesto + TotalDesperdicioPresupuesto
                Dim TotalCostoPresupuesto As Double = TotalCompraPresupuesto * precioEle
                Me.PresupuestoDetalleElementosTableAdapter.ActulizarConsumoPresupuesto(Cantidad, ConsumoTotalPresupuesto, TotalDesperdicioPresupuesto, TotalCompraPresupuesto, TotalCostoPresupuesto, IdDetalleElemento)
            Next

            Me.PresupuestoDetallePinturaTableAdapter.FillByIdDetallePresupuesto(Me.DsPresupuestoDetallePintura.PresupuestoDetallePintura, IdPresupuestodetalle)
            For Each row As DataRow In Me.DsPresupuestoDetallePintura.PresupuestoDetallePintura.Rows
                Dim IdDetallePintura As String = row("IdPinturaTipoPresupuesto").ToString()
                Dim precio As Double = Convert.ToDouble(row("PrecioCompra"))
                Dim totalPartida As Double = Cantidad * precio
                Dim consumoArticulo As Double = Convert.ToDouble(row("CosumoArticulo"))
                Dim ConsumoTotalPresupuesto As Double = consumoArticulo * Cantidad
                Dim desperdicio As Double = Convert.ToDouble(row("Desperdicio"))
                Dim TotalDesperdicioPresupuesto As Double = ConsumoTotalPresupuesto * desperdicio
                Dim TotalCompraPresupuesto As Double = ConsumoTotalPresupuesto + TotalDesperdicioPresupuesto
                Dim TotalCostoPresupuesto As Double = TotalCompraPresupuesto * precio
                Me.PresupuestoDetallePinturaTableAdapter.ActulizarConsumoPresupuesto(ConsumoTotalPresupuesto, TotalDesperdicioPresupuesto, TotalCompraPresupuesto, TotalCostoPresupuesto, IdDetallePintura)
            Next

            Me.PresupuestoDetalleHerrajesTableAdapter.FillByIdDetallePresupuesto(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes, IdPresupuestodetalle)
            For Each row As DataRow In Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes.Rows
                Dim IdDetalleHerraje As String = row("Id_detalle_Herrajes").ToString()
                Dim precio As Double = Convert.ToDouble(row("PrecioCompraHerrajes"))
                Dim consumoArticulo As Double = Convert.ToDouble(row("CantidadHerrajesDetalle"))
                Dim totalPartida As Double = Cantidad * consumoArticulo
                Dim TotalCostoDetalle As Double = consumoArticulo * precio
                Dim ConsumoTotalPresupuesto As Double = consumoArticulo * Cantidad
                Dim TotalCostoPresupuesto As Double = ConsumoTotalPresupuesto * precio
                Me.PresupuestoDetalleHerrajesTableAdapter.ActualizarConsumoPreupuestos(precio, Cantidad, TotalCostoDetalle, totalPartida, TotalCostoPresupuesto, IdDetalleHerraje)
            Next

            Me.PresupuestoDetalleFerreteriaTableAdapter.FillIdDetallePresupuesto(Me.DsPresupuestoDetalleferreteria.PresupuestoDetalleFerreteria, IdPresupuestodetalle)
            For Each row As DataRow In Me.DsPresupuestoDetalleferreteria.PresupuestoDetalleFerreteria.Rows
                Dim IdDetalleFerreteria As String = row("IdDetalleFerreteria").ToString()
                Dim precio As Double = Convert.ToDouble(row("Precio"))
                Dim consumoArticulo As Double = Convert.ToDouble(row("TotalArticulo"))
                Dim totalPartida As Double = Cantidad * consumoArticulo
                Dim ConsumoTotalPresupuesto As Double = consumoArticulo * Cantidad
                Dim TotalCostoPresupuesto As Double = ConsumoTotalPresupuesto * precio
                Me.PresupuestoDetalleFerreteriaTableAdapter.ActualizarConsumosPresupuesto(Cantidad, ConsumoTotalPresupuesto, TotalCostoPresupuesto, IdDetalleFerreteria)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ValidarDetallepresupuesto()
        Try
            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.DsPresupuestoDetalle)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnPreciosArticulo_Click(sender As System.Object, e As System.EventArgs) Handles BtnPreciosArticulo.Click
        My.Forms.EstudioPrecios.Close()
        My.Forms.EstudioPrecios.Label2.Text = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
        My.Forms.EstudioPrecios.Label3.Text = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
        My.Forms.EstudioPrecios.DesdePresupuesto()
    End Sub

    Private Sub BtnAnexarPrecios_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnexarPrecios.Click
        Me.Anecharcompras()
        My.Forms.FrmPreciosCompras.Close()
        My.Forms.FrmPreciosCompras.Presupuesto()
    End Sub

    Private Sub CmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles CmdAceptar.Click
        Try
            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()
            Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
            Me.GrbPresupuestodetalles.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmdNuevoArticulo_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevoArticulo.Click
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        My.Forms.FrmVerArticulos.Close()
        My.Forms.FrmVerArticulos.Show()
        My.Forms.FrmVerArticulos.CmdAgregarpresupuesto.Visible = True
        My.Forms.FrmVerArticulos.TextBox1.Focus()
    End Sub

    Private Sub BtnVerArticulo_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerArticulo.Click
        Try
            My.Forms.FrmArticulo.Close()
            Dim articulo As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
            My.Forms.FrmArticulo.lblInicioFormulario.Text = articulo
            My.Forms.FrmArticulo.FiltrarArticulo()
        Catch ex As Exception
            MsgBox("No hay ningun articulo")
        End Try
    End Sub

    Private Sub CmdHerrajePintura_Click(sender As System.Object, e As System.EventArgs) Handles CmdHerrajePintura.Click
        Try
            My.Forms.FrmIngresoHerrajePintura.Close()
            Dim Articulo As String = DsPresupuestoDetalle.PresupuestoDetalle(PresupuestoDetalleBindingSource.Position).Articulo
            Dim IdDetallePresupuesto As String = DsPresupuestoDetalle.PresupuestoDetalle(PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            My.Forms.FrmIngresoHerrajePintura.CargarDataset()
            My.Forms.FrmIngresoHerrajePintura.TxtdDetallePresupuesto.Text = IdDetallePresupuesto
            My.Forms.FrmIngresoHerrajePintura.PresupuestoDetalleHerrajesTableAdapter.FillByIdDetallePresupuesto(My.Forms.FrmIngresoHerrajePintura.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes, IdDetallePresupuesto)
            My.Forms.FrmIngresoHerrajePintura.PresupuestoDetalleTableAdapter.FillBydDetallePresupuesto(My.Forms.FrmIngresoHerrajePintura.DsPresupuestoDetalle.PresupuestoDetalle, IdDetallePresupuesto)
            My.Forms.FrmIngresoHerrajePintura.ArticulosTableAdapter.FillByIdArticulo(My.Forms.FrmIngresoHerrajePintura.DsArticulos.Articulos, Articulo)
            My.Forms.FrmIngresoHerrajePintura.PresupuestoDetallePinturaTableAdapter.FillByIdDetallePresupuesto(My.Forms.FrmIngresoHerrajePintura.DsPresupuestoDetallePintura.PresupuestoDetallePintura, IdDetallePresupuesto)
            My.Forms.FrmIngresoHerrajePintura.Show()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Try
            ' Declarar la variable tasa
            Dim tasa As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa


            ' Obtener la tasa de cambio desde la base de datos si existe un valor válido
            If Me.DsPresupuestos.Presupuesto.Count > 0 AndAlso
       Not IsDBNull(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa) AndAlso
       Double.TryParse(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa.ToString(), tasa) Then
                tasa = CDbl(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).tasa)
            End If

            ' Verificar si se edita la columna 3 o 4
            If e.ColumnIndex = 3 Or e.ColumnIndex = 4 Then
                CambioPrecio()
                ActulizarConsumospresupuestos() ' Se mantiene el nombre original
                EstadoPresupuesto()
                Totales()

                ' Si se edita la columna 6 (Cantidad)
            ElseIf e.ColumnIndex = 6 Then
                ' Verificar si la fila actual no es nula
                If Me.PresupuestoDetalleDataGridView.CurrentRow IsNot Nothing Then
                    Dim precioUnitario As Double = 0
                    Dim cantidad As Double = 0

                    ' Validar precio unitario
                    If Not IsDBNull(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value) AndAlso
               Double.TryParse(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value.ToString(), precioUnitario) Then
                        precioUnitario = CDbl(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value)
                    End If

                    ' Validar cantidad
                    If Not IsDBNull(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(6).Value) AndAlso
               Double.TryParse(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(6).Value.ToString(), cantidad) Then
                        cantidad = CDbl(Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(6).Value)
                    End If

                    ' Calcular el total solo si los valores son válidos
                    Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(7).Value = precioUnitario * cantidad

                    ' Calcular el precio en otra moneda si la tasa es válida
                    If tasa > 0 Then
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(4).Value = cantidad / tasa
                    Else
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(4).Value = 0
                    End If

                    ' Validar y actualizar la base de datos
                    Me.Validate()
                    Me.PresupuestoDetalleBindingSource.EndEdit()
                    Me.TableAdapterManager1.UpdateAll(Me.DsPresupuestoDetalle)

                    ' Recalcular totales
                    Totales()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al procesar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CmdGenerles_Click(sender As System.Object, e As System.EventArgs) Handles CmdGenerles.Click
        Me.GrbPresupuestodetalles.Visible = True
    End Sub

    Private Sub TxtEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TxtEstado.SelectedIndexChanged
        Try
            Dim estado As String = Me.TxtEstado.Text
            Me.PresupuestoDetalleTableAdapter.ActualizarEstado(estado, Me.TxtIdPresupuesto.Text)
            Me.PresupuestoDetalleHerrajesTableAdapter.ActulizarEstado(estado, Me.TxtIdPresupuesto.Text)
            Me.PresupuestoDetallePinturaTableAdapter.AutulizarEstado(estado, Me.TxtIdPresupuesto.Text)
            Me.PresupuestoDetalleElementosTableAdapter.ActulizarEstado(estado, Me.TxtIdPresupuesto.Text)

            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()
            Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)

            My.Forms.FrmProyectos.PresupuestoTableAdapter.FillByIdProyecto(My.Forms.FrmProyectos.DsPresupuestos.Presupuesto, TxtIdProyecto.Text, "pendiente", "Aprobado", "entregado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PresupuestoDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PresupuestoDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsPresupuestoDetalle)
        Totales()
    End Sub

    Private Sub BtnAnalisisPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnalisisPresupuesto.Click
        My.Forms.InfAnalisisPresupuesto.Close()
        My.Forms.InfAnalisisPresupuesto.Show()
        My.Forms.InfAnalisisPresupuesto.AnalisisPresupuesto()
    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellClick
        FiltrarHerrajes()
    End Sub

    Private Sub BtnActualizarConsumos_Click(sender As System.Object, e As System.EventArgs) Handles BtnActualizarConsumos1.Click
        Actulizarconsumos()
    End Sub

    Private Sub BtnNotaEntrega_Click(sender As System.Object, e As System.EventArgs) Handles BtnNotaEntrega.Click
        My.Forms.FrmVerNotasEntregas.Close()
        My.Forms.FrmVerNotasEntregas.txtpresupuesto.Text = Me.TxtIdPresupuesto.Text
        My.Forms.FrmVerNotasEntregas.txtproyecto.Text = Me.TxtIdProyecto.Text
        My.Forms.FrmVerNotasEntregas.txtempresa.Text = Me.TxtIdEmpresa.Text
        My.Forms.FrmVerNotasEntregas.txtsiguiente.Text = My.Forms.FrmVerNotasEntregas.NotasEntregaTableAdapter.SiguienteNotaEntrega(Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto)
        My.Forms.FrmVerNotasEntregas.Show()
        My.Forms.FrmVerNotasEntregas.VerNotasEntraga()
    End Sub

    Private Sub BtnSoloConsumos_Click(sender As System.Object, e As System.EventArgs) Handles BtnSoloConsumos.Click
        My.Forms.RotConsumoArticulos.Close()
        My.Forms.RotConsumoArticulos.Show()
        My.Forms.RotConsumoArticulos.SoloConsumos()
    End Sub

    Private Sub BtnIngresarMano_Click(sender As System.Object, e As System.EventArgs) Handles BtnCambioProyecto.Click
        My.Forms.FrmCambioProyecto.Close()
        My.Forms.FrmCambioProyecto.Show()
    End Sub

    Private Sub BtnKitArticulos_Click(sender As System.Object, e As System.EventArgs) Handles BtnKitArticulos.Click
        My.Forms.ImpKitArticulo.Close()
        My.Forms.ImpKitArticulo.Show()
        My.Forms.ImpKitArticulo.FiltraPresupuesto()
    End Sub

    Private Sub BtnConsumoPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsumoPresupuesto.Click
        My.Forms.InfConsumoPresupuestos.lblIdPresupuesto.Text = Me.TxtIdPresupuesto.Text
        My.Forms.InfConsumoPresupuestos.Show()
        My.Forms.InfConsumoPresupuestos.ImprimriConsumos()
    End Sub

    Private Sub BtnImprimirPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimirPresupuesto.Click
        Me.PresupuestoDetalleBindingSource.MoveFirst()
        For Each row As DataRow In Me.DsPresupuestoDetalle.PresupuestoDetalle.Rows
            Me.PresupuestoDetalleBindingSource.MoveNext()
        Next
        My.Forms.RptImprimir.Show()
        My.Forms.RptImprimir.ImprimirPresupuesto()
    End Sub

    Private Sub FrmPresupuestos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, TxtIdProyecto.Text)
        Totales()

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Carpeta_DatosTextBox.Text <> "" Then
            Shell("explorer.exe root =" + Carpeta_DatosTextBox.Text, vbNormalFocus)
        Else
            MsgBox("La carpeta no está creada")
        End If
    End Sub

    Private Sub BtnCostoArticulos_Click(sender As System.Object, e As System.EventArgs) Handles BtnCostoArticulos.Click
        My.Forms.RotConsumoArticulos.Close()
        My.Forms.RotConsumoArticulos.Show()
        My.Forms.RotConsumoArticulos.EstudioCostos()
    End Sub

    Private Sub Btnimprimirarticulos_Click(sender As System.Object, e As System.EventArgs) Handles Btnimprimirarticulos.Click
        My.Forms.RotConsumoArticulos.Close()
        My.Forms.RotConsumoArticulos.Show()
        My.Forms.RotConsumoArticulos.EstudioCostsoResumen()
    End Sub



    Private Sub BtnImprimirProforma_Click(sender As Object, e As EventArgs) Handles BtnImprimirProforma.Click
        My.Forms.RptImprimir.Close()
        My.Forms.RptImprimir.Show()
        My.Forms.RptImprimir.Proforma()

    End Sub

    Private Sub CmdDuplicarHerraje_Click(sender As Object, e As EventArgs) Handles cmdDuplicarHerraje.Click
        ' Limpiar los textos de los labels antes de comenzar
        Me.LblRegistroADuplicar.Text = ""
        Me.lblDesdeelregistro.Text = ""

        ' Obtener el ID del detalle de presupuesto actual
        Dim nuevoDetallePresupuesto As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto

        ' Mostrar InputBox para verificar el registro que se quiere duplicar
        Dim strrfc As String = InputBox("Verifique el registro que quiere duplicar", nuevoDetallePresupuesto, nuevoDetallePresupuesto)

        If strrfc <> "" Then
            Me.Label7.Visible = True
            Me.LblRegistroADuplicar.Text = nuevoDetallePresupuesto
            Me.LblRegistroADuplicar.Visible = True

            ' Mostrar segundo InputBox para obtener el registro desde el cual se quiere duplicar
            Dim strrfc2 As String = InputBox("Desde el registro que quiere duplicar")

            If strrfc2 <> "" Then
                Me.Label9.Visible = True
                Me.lblDesdeelregistro.Text = strrfc2
                Me.lblDesdeelregistro.Visible = True

                Try
                    ' Llenar el dataset con los herrajes del registro especificado
                    Me.PresupuestoDetalleHerrajesTableAdapter.FillByIdDetallePresupuesto(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes, Me.lblDesdeelregistro.Text)
                    Me.PresupuestoDetalleHerrajesBindingSource.MoveFirst()

                    ' Obtener el número total de registros en la tabla de herrajes
                    Dim iTotal As Integer = Me.DsPresupuestoDetalleHerrajes.Tables("PresupuestoDetalleHerrajes").Rows.Count

                    ' Ciclo para duplicar cada registro de herrajes
                    For i As Integer = 0 To iTotal - 1
                        Dim IdHerraje As String = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).Id_Herraje
                        Dim Siguiente As String = PresupuestoDetalleHerrajesTableAdapter.SiguientedetalleHerraje(Me.LblRegistroADuplicar.Text)

                        ' Llenar los detalles del presupuesto
                        Me.PresupuestoDetalleTableAdapter.FillBydDetallePresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Me.LblRegistroADuplicar.Text)
                        Dim Cantidadpresupuesto As Double = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad
                        Dim CantidadHerrajes As Double = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).CantidadHerrajesDetalle
                        Dim totalPresupuesto As Double = Cantidadpresupuesto * CantidadHerrajes
                        Dim Proyecto As String = Me.TxtIdProyecto.Text
                        Dim presupuesto As String = Me.TxtIdPresupuesto.Text
                        Dim Medida As String = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).Id_Medida
                        Dim estado As String = Me.TxtEstado.Text
                        Dim Empresa As String = Me.TxtIdEmpresa.Text
                        Dim codigo As String = presupuesto & "-" & IdHerraje
                        Dim totalPresupuestoherrajes As Double = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).TotalPresupuestoHerrajes
                        Dim PrecioCompraHerrajes As Double = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).PrecioCompraHerrajes
                        Dim TotalCostodetalle As Double = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).TotalCostodetalle
                        Dim TotalCostoPrespuesto As Double = Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes(Me.PresupuestoDetalleHerrajesBindingSource.Position).TotalCostoPrespuesto

                        Try
                            ' Anexar el nuevo registro duplicado
                            Me.PresupuestoDetalleHerrajesTableAdapter.AnexarHerraje(Siguiente, Proyecto, presupuesto, strrfc, Cantidadpresupuesto, IdHerraje, CantidadHerrajes, totalPresupuestoherrajes, Medida, Empresa, estado, PrecioCompraHerrajes, TotalCostodetalle, TotalCostoPrespuesto, codigo)
                        Catch ex As Exception
                            MsgBox("Error al anexar el herraje: " & ex.Message)
                        End Try

                        ' Mover al siguiente registro de la tabla
                        Me.PresupuestoDetalleHerrajesBindingSource.MoveNext()
                    Next
                Catch ex As Exception
                    MsgBox("Error al procesar los herrajes: " & ex.Message)
                End Try
            Else
                ' Si el usuario no ingresa un registro, limpiar los labels
                Me.LblRegistroADuplicar.Text = ""
                Me.lblDesdeelregistro.Text = ""
            End If
        Else
            ' Si el usuario no ingresa un registro en el primer InputBox, limpiar los labels
            Me.LblRegistroADuplicar.Text = ""
            Me.lblDesdeelregistro.Text = ""
        End If

        ' Refrescar los datos del presupuesto
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, TxtIdPresupuesto.Text)
    End Sub


    Private Sub TxtDescripcion_LostFocus(sender As Object, e As EventArgs) Handles TxtDescripcion.LostFocus
        Try
            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
        End Try
    End Sub





    Private Sub BuscarYAbrirOrden()
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Seleccionar Orden de Compra"
        ofd.Filter = "Archivos PDF (*.pdf)|*.pdf"
        ofd.Multiselect = False

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim rutaArchivo As String = ofd.FileName
            TxtOrdenDeCompra.Text = Path.GetFileName(rutaArchivo)
            Carpeta_DatosTextBox.Text = Path.GetDirectoryName(rutaArchivo)

            Try
                GuardarOrdenEnBaseDeDatos(rutaArchivo)
            Catch ex As Exception
                MessageBox.Show("Error al guardar la orden: " & ex.Message)
            End Try
        End If
    End Sub



    ' Método para guardar el valor en la base de datos
    Private Sub GuardarOrdenEnBaseDeDatos(nombreArchivo As String)
        Try
            ' Asegurar que el BindingSource tenga los cambios reflejados
            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()

            ' Guardar en la base de datos
            Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)

            MessageBox.Show("Orden de compra guardada correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al guardar la orden en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Leyenda_PresupuestoTextBox_Leave(sender As Object, e As EventArgs) Handles Leyenda_PresupuestoTextBox.Leave
        Try
            ' Finaliza la edición del control vinculado
            Me.Validate()
            Me.PresupuestoBindingSource.EndEdit()

            ' Guarda en la base de datos
            Me.PresupuestoTableAdapter.Update(Me.DsPresupuestos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtOrdenDeCompra_Click(sender As Object, e As EventArgs) Handles TxtOrdenDeCompra.Click
        Dim carpetaBase As String = Path.Combine(Carpeta_DatosTextBox.Text, "Ordenes Compra")
        Dim nombreArchivo As String = TxtOrdenDeCompra.Text
        Dim rutaArchivo As String = ""

        If Not String.IsNullOrWhiteSpace(nombreArchivo) Then
            rutaArchivo = Path.Combine(carpetaBase, nombreArchivo)
            If File.Exists(rutaArchivo) Then
                Process.Start(rutaArchivo)
                Exit Sub
            Else
                MessageBox.Show("El archivo no existe en la ruta esperada. Seleccione el archivo manualmente.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        Using openFileDialog As New OpenFileDialog()
            openFileDialog.InitialDirectory = carpetaBase
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
            openFileDialog.Title = "Seleccionar Orden de Compra"
            openFileDialog.Multiselect = False

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim nuevoNombreArchivo As String = Path.GetFileName(openFileDialog.FileName)
                TxtOrdenDeCompra.Text = nuevoNombreArchivo

                ' Si quieres copiar el archivo a la carpeta base, puedes hacerlo aquí (opcional)
                'Dim destino As String = Path.Combine(carpetaBase, nuevoNombreArchivo)
                'If openFileDialog.FileName <> destino Then
                '    File.Copy(openFileDialog.FileName, destino, True)
                'End If

                ' PROCESO PARA GUARDAR EL NOMBRE EN LA BASE DE DATOS:
                Try
                    ' Asegúrate de que tu TableAdapter y BindingSource se llamen así
                    ' PresupuestoBindingSource.EndEdit()
                    ' PresupuestoTableAdapter.Update(DsPresupuestos.Presupuesto)

                    ' Si tienes ID, lo puedes sacar de tu textbox, por ejemplo:
                    Dim idPresupuesto As String = TxtIdPresupuesto.Text ' o el ID correspondiente

                    ' Guardar usando un TableAdapter con UPDATE típico
                    ' Supón que tienes un método así: PresupuestoTableAdapter.ActualizarOrdenDeCompra(nombreArchivo, idPresupuesto)
                    PresupuestoTableAdapter.ActualizarOrdenDeCompra(nuevoNombreArchivo, idPresupuesto)

                    MessageBox.Show("Ruta de orden de compra guardada correctamente en la base de datos.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al guardar la ruta en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Process.Start(openFileDialog.FileName)
            End If
        End Using
    End Sub



End Class
