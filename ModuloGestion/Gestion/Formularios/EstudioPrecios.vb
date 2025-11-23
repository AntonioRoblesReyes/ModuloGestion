Imports System.Math

Public Class EstudioPrecios

    Sub DesdeProyecto()
        Try
            ' Llenar tablas de detalles de presupuesto y artículos
            Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
            Dim DetallePresupuesto As String = My.Forms.FrmRevisionArticulos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmRevisionArticulos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Me.PresupuestoDetalleTableAdapter.FillBydDetallePresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, DetallePresupuesto)
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, ArticuloTextBox.Text)
            Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)

            Me.CantidadTextBox.Visible = True
            Me.TotalPartidaTextBox.Visible = True

            ' Cargar detalles de herrajes
            Me.PresupuestoDetalleHerrajesTableAdapter.Fill(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes)
            Me.PresupuestoDetalleHerrajesTableAdapter.FillByIdDetallePresupuesto(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes, IdDetalle_PresupuestoTextBox.Text)

            ' Cargar detalles de materiales
            Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
            Me.ConsumoMaterialArticulosTableAdapter.Fill(Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos)
            Me.ConsumoMaterialArticulosTableAdapter.FillByIdDetallePresupuesto(Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos, IdDetalle_PresupuestoTextBox.Text)

            ' Cargar detalles de pintura
            Me.PinturaComponentesTableAdapter.Fill(Me.DsPinturaComponentes.PinturaComponentes)
            Me.ConsumoPinturaArticuloTableAdapter.Fill(Me.DsCosumoPinturaArticulo.ConsumoPinturaArticulo)
            Me.ConsumoPinturaArticuloTableAdapter.FillByPresupuestoDetalle(Me.DsCosumoPinturaArticulo.ConsumoPinturaArticulo, IdDetalle_PresupuestoTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub DesdePresupuesto()
        Try
            ' Llenar artículos y detalles de presupuesto
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, Label3.Text)
            Me.Descripcion_articuloTextBox.Text = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).Descripcion_articulo
            Me.PresupuestoDetalleTableAdapter.FillBydDetallePresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Label2.Text)

            ' Cargar detalles de consumo
            Me.ConsumoHerrajesArticuloTableAdapter.FillByIdPresupuestoDetalle(Me.DsConsumoHerrajesArticulo.ConsumoHerrajesArticulo, Label2.Text)
            Me.ConsumoMaterialArticulosTableAdapter.FillByIdDetallePresupuesto(Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos, Label2.Text)
            Me.ConsumoPinturaArticuloTableAdapter.FillByPresupuestoDetalle(Me.DsCosumoPinturaArticulo.ConsumoPinturaArticulo, Label2.Text)
            Me.ConsumoFerreteriaArticulosTableAdapter.FillByIdDetallePresupuesto(Me.DsConsumoFerreteriaArticulos.ConsumoFerreteriaArticulos, Label2.Text)

            ' Asignar costo de montaje y mostrar formulario
            My.Forms.EstudioPrecios.CostoMontajeTextBox.Text = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).Montaje

            Me.Show()
            Dim trabajoTaller As Double
            Dim trabajoPintura As Double

            ' Intentar convertir los valores de los TextBox a Double
            If Double.TryParse(TrabajoTallerTextBox.Text, trabajoTaller) AndAlso Double.TryParse(TrabajoPiinturaTextBox.Text, trabajoPintura) Then
                ' Realizar la suma y asignar el resultado al TotalHorasTextBox
                Me.TotalHorasTextBox.Text = (trabajoTaller + trabajoPintura).ToString()
            Else
                ' Manejar el caso en que la conversión falle
                MsgBox("Por favor, asegúrese de que los valores de TrabajoTaller y TrabajoPintura sean números válidos.")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GenerarPrecio()
        Me.ConsumoMaterialArticulosTableAdapter.FillByIdDetallePresupuesto(Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos, Label2.Text)
        Dim verificarpreciosmaterial As Integer = Me.DsConsumoMaterialArticulo.Tables(0).Rows.Count
        Dim Material As Integer
        If verificarpreciosmaterial <> 0 Then
            For Material = 0 To verificarpreciosmaterial - 1
                Dim ValorMaterial As Double = Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos(Me.ConsumoMaterialArticulosBindingSource.Position).PrecioCompra
                Dim MaterialDetalle As String = Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos(Me.ConsumoMaterialArticulosBindingSource.Position).Descripcion
                If ValorMaterial = 0 Then
                    MsgBox(UCase("Verifique los precios los precios de " & MaterialDetalle))
                End If
                Me.ConsumoMaterialArticulosBindingSource.MoveNext()

            Next
            Me.ConsumoMaterialArticulosBindingSource.MoveFirst()
        End If

        Dim verificarpreciosPintura As Integer = Me.DsCosumoPinturaArticulo.Tables(0).Rows.Count

        Dim Pinntura As Integer
        If verificarpreciosPintura <> 0 Then

            Me.ConsumoPinturaArticuloBindingSource.MoveFirst()
            For Pinntura = 0 To verificarpreciosPintura - 1
                Dim ValorMaterial As Double = Me.DsCosumoPinturaArticulo.ConsumoPinturaArticulo(Me.ConsumoPinturaArticuloBindingSource.Position).PrecioCompra
                Dim Pinturadetalle As String = Me.DsCosumoPinturaArticulo.ConsumoPinturaArticulo(Me.ConsumoPinturaArticuloBindingSource.Position).Descripcion
                If ValorMaterial = 0 Then
                    MsgBox(UCase("Verifique los precios los precios de " & Pinturadetalle))
                End If
                Me.ConsumoPinturaArticuloBindingSource.MoveNext()
            Next

        End If

        Dim verificarpreciosHerrajes As Integer = Me.DsConsumoHerrajesArticulo.Tables(0).Rows.Count

        Dim Herrajes As Integer
        If verificarpreciosHerrajes <> 0 Then

            Me.PresupuestoDetalleHerrajesBindingSource.MoveFirst()
            For Herrajes = 0 To verificarpreciosHerrajes - 1
                Dim ValorMaterial As Double = Me.DsConsumoHerrajesArticulo.ConsumoHerrajesArticulo(Me.ConsumoHerrajesArticuloBindingSource.Position).TotalCostodetalle
                Dim Herrajesdetalle As String = Me.DsConsumoHerrajesArticulo.ConsumoHerrajesArticulo(Me.ConsumoHerrajesArticuloBindingSource.Position).Descripcion_Elemento_Herrajes
                If ValorMaterial = 0 Then
                    MsgBox(UCase("Verifique los precios los precios de " & Herrajesdetalle))
                End If
                Me.PresupuestoDetalleHerrajesBindingSource.MoveNext()
            Next

        End If

        Dim verificarpreciosFerreteria As Integer = Me.DsConsumoFerreteriaArticulos.Tables(0).Rows.Count

        Dim ferreteria As Integer
        If verificarpreciosHerrajes <> 0 Then

            Me.ConsumoFerreteriaArticulosBindingSource.MoveFirst()
            For ferreteria = 0 To verificarpreciosFerreteria - 1
                Dim ValorFerreteria As Double = Me.DsConsumoFerreteriaArticulos.ConsumoFerreteriaArticulos(Me.ConsumoFerreteriaArticulosBindingSource.Position).Precio
                Dim Ferreteriadetalle As String = Me.DsConsumoFerreteriaArticulos.ConsumoFerreteriaArticulos(Me.ConsumoFerreteriaArticulosBindingSource.Position).Descripcion_Eemento_Ferreteria
                If ValorFerreteria = 0 Then
                    MsgBox(UCase("Verifique los precios los precios de " & Ferreteriadetalle))
                End If
                Me.ConsumoFerreteriaArticulosBindingSource.MoveNext()
            Next

        End If


        Try

            ''''''''''''''''''Materiales


            Dim Sumatotalmateriales As Double = 0
            Dim iTotalmaterial As Integer = Me.DsConsumoMaterialArticulo.Tables(0).Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            If iTotalmaterial <> 0 Then


                Dim imaterial As Integer
                Try
                    Me.ConsumoMaterialArticulosBindingSource.MoveFirst()

                    For imaterial = 0 To iTotalmaterial - 1
                        Dim valorMaterial As Double = Me.DsConsumoMaterialArticulo.ConsumoMaterialArticulos(Me.ConsumoMaterialArticulosBindingSource.Position).TotalCostoArticulo
                        Sumatotalmateriales += valorMaterial

                        Me.ConsumoMaterialArticulosBindingSource.MoveNext()
                    Next
                    Me.CostoMaderaTextBox.Text = Sumatotalmateriales

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)

                End Try
            Else
                Me.CostoMaderaTextBox.Text = 0
            End If
            ''''''''''''''''''Pintura
            Try

                Dim Sumatotalpintura As Double = 0
                Dim iTotalpintura As Integer = Me.DsCosumoPinturaArticulo.Tables(0).Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
                Dim ipintura As Integer
                If iTotalpintura <> 0 Then

                    Me.ConsumoPinturaArticuloBindingSource.MoveFirst()
                    For ipintura = 0 To iTotalpintura - 1
                        Dim valorPinturas As Double = Me.DsCosumoPinturaArticulo.ConsumoPinturaArticulo(Me.ConsumoPinturaArticuloBindingSource.Position).TotalCostoArticulo

                        Sumatotalpintura += valorPinturas
                        Me.ConsumoPinturaArticuloBindingSource.MoveNext()
                    Next
                    Me.CostoPinturaTextBox.Text = Sumatotalpintura
                Else
                    Me.CostoPinturaTextBox.Text = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            ''''''''''''''''''Herrajes

            Try

                Dim SumatotalHerrajes As Double = 0

                Dim iTotalherrajes As Integer = Me.DsConsumoHerrajesArticulo.Tables(0).Rows.Count
                Dim iHerrajes As Integer
                If iTotalherrajes <> 0 Then
                    Me.ConsumoHerrajesArticuloBindingSource.MoveFirst()
                    For iHerrajes = 0 To iTotalherrajes - 1

                        Dim valorherraje As Double = Me.DsConsumoHerrajesArticulo.ConsumoHerrajesArticulo(Me.ConsumoHerrajesArticuloBindingSource.Position).TotalCostodetalle

                        SumatotalHerrajes += valorherraje

                        Me.ConsumoHerrajesArticuloBindingSource.MoveNext()

                    Next
                    Me.CostoHerrajesTextBox.Text = SumatotalHerrajes

                Else
                    Me.CostoHerrajesTextBox.Text = 0

                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)

            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''''''''''''''''''Ferreteria

        Try

            Dim SumatotalFerreteria As Double = 0

            Dim iTotalFerreteria As Integer = Me.DsConsumoFerreteriaArticulos.Tables(0).Rows.Count
            Dim iFerreteria As Integer
            If iTotalFerreteria <> 0 Then
                Me.ConsumoFerreteriaArticulosBindingSource.MoveFirst()
                For iFerreteria = 0 To iTotalFerreteria - 1

                    Dim valorFerreteria As Double = Me.DsConsumoFerreteriaArticulos.ConsumoFerreteriaArticulos(Me.ConsumoFerreteriaArticulosBindingSource.Position).TotalArticulo

                    SumatotalFerreteria += valorFerreteria

                    Me.ConsumoFerreteriaArticulosBindingSource.MoveNext()

                Next
                CostoFereteriaTextBox.Text = SumatotalFerreteria
            Else
                CostoFereteriaTextBox.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try




        ''''''''''''''''''Calculos
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.PresupuestoDetalleTableAdapter.Update(Me.DsPresupuestoDetalle)
        'Try


        Dim IdDetalle_Presupuesto As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto

        Dim Cantidad As Double = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Cantidad
        Dim CostoMadera As Double = Me.CostoMaderaTextBox.Text

        Dim CostoPintura As Double = Me.CostoPinturaTextBox.Text
        Dim PrecioHora As Double = Me.PrecioHoraTextBox.Text

        Dim TotalHoras As Double = TotalHorasTextBox.Text
        Me.CostoTrabajoTextBox.Text = PrecioHora * TotalHoras

        Dim CostoFereteria As Double = Me.CostoFereteriaTextBox.Text

        Dim OtrosCostos As Integer = Len(Me.OtrosCostosTextBox.Text)
        Dim cOtrosCostosTextBox As Double = Microsoft.VisualBasic.Left(Me.OtrosCostosTextBox.Text, OtrosCostos - 2) / 100

        Dim TotalCostoDirecto As Double = CDbl(Me.CostoMaderaTextBox.Text) + CDbl(Me.CostoPinturaTextBox.Text) + CDbl(Me.CostoFereteriaTextBox.Text) + CDbl(Me.CostoTrabajoTextBox.Text)
        Me.CostoOtrosCostosTextBox.Text = Round(TotalCostoDirecto * cOtrosCostosTextBox, 2)
        Me.SubTotalCostoDirectoTextBox.Text = TotalCostoDirecto + CDbl(Me.CostoOtrosCostosTextBox.Text)




        Me.TotalCostoIdirectoTextBox.Text = TotalHoras * CDbl(CostoIndirectoTextBox.Text)
        Me.TotalcostoTextBox.Text = CDbl(Me.TotalCostoIdirectoTextBox.Text) + CDbl(SubTotalCostoDirectoTextBox.Text)

        Dim CcTransporteEmbalajeTextBox As Integer = Len(TransporteEmbalajeTextBox.Text)
        'MsgBox(CcTransporteEmbalajeTextBox)
        Dim TransporteEmbalaje As Double = Microsoft.VisualBasic.Left(TransporteEmbalajeTextBox.Text, CcTransporteEmbalajeTextBox - 2) / 100
        'MsgBox(TotalcostoTextBox.Text)
        If TotalcostoTextBox.Text = 0 Then
        Else
            Me.CostoTransporteEmbalajeTextBox.Text = Round(CDbl(Me.TotalcostoTextBox.Text) * TransporteEmbalaje, 2)
        End If

        Dim ItebisIncluido As Double = (CostoMadera + CostoPintura + CostoFereteria + CostoHerrajesTextBox.Text + CostoOtrosCostosTextBox.Text) * 0.18
        If Me.InlItebisCheckBox.Checked = True Then
            Me.ItbisIncluidoTextBox.Text = ItebisIncluido
        Else
            Me.ItbisIncluidoTextBox.Text = 0
        End If






        Me.SubTotalCostoTextBox.Text = CDbl(Me.CostoTransporteEmbalajeTextBox.Text) + CDbl(CostoHerrajesTextBox.Text) + CDbl(TotalcostoTextBox.Text) + CDbl(CostoMontajeTextBox.Text)


        If Me.SubTotalCostoTextBox.Text <> 0 Then

            Dim CcBeneficioTextBox As Integer = Len(BeneficioTextBox.Text)
            Dim Beneficio As Double = 1 - Microsoft.VisualBasic.Left(BeneficioTextBox.Text, CcBeneficioTextBox - 2) / 100

            Me.SubtotalVentaTextBox.Text = Round(CDbl(Me.SubTotalCostoTextBox.Text) / Beneficio, 2) + Me.ItbisIncluidoTextBox.Text
            Me.TotalBeneficioTextBox.Text = CDbl(Me.SubtotalVentaTextBox.Text) - CDbl(Me.SubTotalCostoTextBox.Text)

            Dim CcImprevistosTextBox As Integer = Len(ImprevistosTextBox.Text)
            Dim Imprevistos As Double = Microsoft.VisualBasic.Left(ImprevistosTextBox.Text, CcBeneficioTextBox - 2) / 100
            Me.TotalImprevistosTextBox.Text = Round(CDbl(Me.SubtotalVentaTextBox.Text * Imprevistos), 2)
            Me.PrecioGeneradoTextBox.Text = CDbl(Me.TotalImprevistosTextBox.Text) + CDbl(Me.SubtotalVentaTextBox.Text)


            If DescuentoTextBox.Text = 0 Then

                TotalDescuentoTextBox.Text = 0
                PrecioVentaTextBox.Text = Me.PrecioGeneradoTextBox.Text
            Else

                TotalDescuentoTextBox.Text = (Me.PrecioGeneradoTextBox.Text / (1 - DescuentoTextBox.Text)) - Me.PrecioGeneradoTextBox.Text

                PrecioVentaTextBox.Text = (CDbl(Me.PrecioGeneradoTextBox.Text)) + TotalDescuentoTextBox.Text

            End If
            Dim tasa As Double = My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).tasa

            Me.TotalPartidaTextBox.Text = CDbl(Me.PrecioVentaTextBox.Text) * CDbl(Me.CantidadTextBox.Text)
            Me.Precio_AjustadoRD_TextBox.Text = Round(CDbl(tasa) * CDbl(Me.PrecioVentaTextBox.Text) / 10) * 10

            Me.TasaTextBox.Text = tasa
            Me.TotalPartidaRD_TextBox.Text = CDbl(Me.Precio_AjustadoRD_TextBox.Text) * CDbl(Me.CantidadTextBox.Text)
            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)


        Else
            MsgBox("no hay registros que generar en el detalle " & IdDetalle_Presupuesto)
        End If


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try



    End Sub

    Private Sub VerificarPrecios(ds As DataSet, bs As BindingSource, campoPrecio As String, campoDescripcion As String)
        Dim verificarprecios As Integer = ds.Tables(0).Rows.Count
        If verificarprecios <> 0 Then
            bs.MoveFirst()
            For i As Integer = 0 To verificarprecios - 1
                Dim Valor As Double = Convert.ToDouble(ds.Tables(0).Rows(bs.Position)(campoPrecio))
                Dim Detalle As String = ds.Tables(0).Rows(bs.Position)(campoDescripcion).ToString()
                If Valor = 0 Then
                    MsgBox(UCase($"Verifique los precios de {Detalle}"))
                End If
                bs.MoveNext()
            Next
            bs.MoveFirst()
        End If
    End Sub

    Private Sub CalcularCosto(ds As DataSet, bs As BindingSource, campoCosto As String, textBox As TextBox)
        Dim sumaTotal As Double = 0
        Dim iTotal As Integer = ds.Tables(0).Rows.Count
        If iTotal <> 0 Then
            bs.MoveFirst()
            For i As Integer = 0 To iTotal - 1
                Dim valor As Double = Convert.ToDouble(ds.Tables(0).Rows(bs.Position)(campoCosto))
                sumaTotal += valor
                bs.MoveNext()
            Next
            textBox.Text = sumaTotal.ToString("F2")
        Else
            textBox.Text = "0"
        End If
    End Sub

    Private Sub CalcularTotales()
        ' Calcular costos y montos finales
        Dim CostoMadera As Double = Convert.ToDouble(Me.CostoMaderaTextBox.Text)
        Dim CostoPintura As Double = Convert.ToDouble(Me.CostoPinturaTextBox.Text)
        Dim CostoFereteria As Double = Convert.ToDouble(Me.CostoFereteriaTextBox.Text)
        Dim CostoHerrajes As Double = Convert.ToDouble(Me.CostoHerrajesTextBox.Text)
        Dim PrecioHora As Double = Convert.ToDouble(Me.PrecioHoraTextBox.Text)
        Dim TotalHoras As Double = Convert.ToDouble(Me.TotalHorasTextBox.Text)

        ' Costo de trabajo
        Me.CostoTrabajoTextBox.Text = (PrecioHora * TotalHoras).ToString("F2")

        ' Otros costos
        Dim cOtrosCostosTextBox As Double = ExtraerPorcentaje(Me.OtrosCostosTextBox.Text) / 100
        Dim TotalCostoDirecto As Double = CostoMadera + CostoPintura + CostoFereteria + Convert.ToDouble(Me.CostoTrabajoTextBox.Text)
        Me.CostoOtrosCostosTextBox.Text = Round(TotalCostoDirecto * cOtrosCostosTextBox, 2).ToString("F2")
        Me.SubTotalCostoDirectoTextBox.Text = (TotalCostoDirecto + Convert.ToDouble(Me.CostoOtrosCostosTextBox.Text)).ToString("F2")

        ' Costos indirectos y totales
        Me.TotalCostoIdirectoTextBox.Text = (TotalHoras * Convert.ToDouble(CostoIndirectoTextBox.Text)).ToString("F2")
        Me.TotalcostoTextBox.Text = (Convert.ToDouble(Me.TotalCostoIdirectoTextBox.Text) + Convert.ToDouble(SubTotalCostoDirectoTextBox.Text)).ToString("F2")

        ' Transporte y embalaje
        Dim TransporteEmbalaje As Double = ExtraerPorcentaje(TransporteEmbalajeTextBox.Text) / 100
        Me.CostoTransporteEmbalajeTextBox.Text = Round(Convert.ToDouble(Me.TotalcostoTextBox.Text) * TransporteEmbalaje, 2).ToString("F2")

        ' ITBIS incluido
        Dim ItebisIncluido As Double = (CostoMadera + CostoPintura + CostoFereteria + CostoHerrajes + Convert.ToDouble(CostoOtrosCostosTextBox.Text)) * 0.18
        Me.ItbisIncluidoTextBox.Text = If(Me.InlItebisCheckBox.Checked, ItebisIncluido, 0).ToString("F2")

        ' Subtotal de costos
        Me.SubTotalCostoTextBox.Text = (Convert.ToDouble(Me.CostoTransporteEmbalajeTextBox.Text) + CostoHerrajes + Convert.ToDouble(TotalcostoTextBox.Text) + Convert.ToDouble(CostoMontajeTextBox.Text)).ToString("F2")

        If Convert.ToDouble(Me.SubTotalCostoTextBox.Text) <> 0 Then
            ' Beneficio
            Dim Beneficio As Double = 1 - ExtraerPorcentaje(BeneficioTextBox.Text) / 100
            Me.SubtotalVentaTextBox.Text = (Round(Convert.ToDouble(Me.SubTotalCostoTextBox.Text) / Beneficio, 2) + Convert.ToDouble(Me.ItbisIncluidoTextBox.Text)).ToString("F2")
            Me.TotalBeneficioTextBox.Text = (Convert.ToDouble(Me.SubtotalVentaTextBox.Text) - Convert.ToDouble(Me.SubTotalCostoTextBox.Text)).ToString("F2")

            ' Imprevistos
            Dim Imprevistos As Double = ExtraerPorcentaje(ImprevistosTextBox.Text) / 100
            Me.TotalImprevistosTextBox.Text = Round(Convert.ToDouble(Me.SubtotalVentaTextBox.Text) * Imprevistos, 2).ToString("F2")
            Me.PrecioGeneradoTextBox.Text = (Convert.ToDouble(Me.TotalImprevistosTextBox.Text) + Convert.ToDouble(Me.SubtotalVentaTextBox.Text)).ToString("F2")

            ' Descuento
            If String.IsNullOrWhiteSpace(DescuentoTextBox.Text) OrElse DescuentoTextBox.Text = "0" Then
                TotalDescuentoTextBox.Text = "0"
                PrecioVentaTextBox.Text = Me.PrecioGeneradoTextBox.Text
            Else
                Dim Descuento As Double = ExtraerPorcentaje(DescuentoTextBox.Text) / 100
                TotalDescuentoTextBox.Text = ((Convert.ToDouble(Me.PrecioGeneradoTextBox.Text) / (1 - Descuento)) - Convert.ToDouble(Me.PrecioGeneradoTextBox.Text)).ToString("F2")
                PrecioVentaTextBox.Text = (Convert.ToDouble(Me.PrecioGeneradoTextBox.Text) + Convert.ToDouble(TotalDescuentoTextBox.Text)).ToString("F2")
            End If

            ' Cálculos finales y actualización
            Dim tasa As Double = Convert.ToDouble(My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).tasa)
            Me.TotalPartidaTextBox.Text = (Convert.ToDouble(Me.PrecioVentaTextBox.Text) * Convert.ToDouble(Me.CantidadTextBox.Text)).ToString("F2")
            Me.Precio_AjustadoRD_TextBox.Text = (Round(tasa * Convert.ToDouble(Me.PrecioVentaTextBox.Text) / 10) * 10).ToString("F2")
            Me.TasaTextBox.Text = tasa.ToString("F2")
            Me.TotalPartidaRD_TextBox.Text = (Convert.ToDouble(Me.Precio_AjustadoRD_TextBox.Text) * Convert.ToDouble(Me.CantidadTextBox.Text)).ToString("F2")

            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)
        Else
            MsgBox($"No hay registros que generar en el detalle {Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto}")
        End If
    End Sub

    Private Function ExtraerPorcentaje(texto As String) As Double
        Return CDbl(Microsoft.VisualBasic.Left(texto, Len(texto) - 2))
    End Function

    ' Eventos y otros métodos
    Private Sub PresupuestoDetalleBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)
    End Sub

    Private Sub EstudioPrecios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        Me.TrabajoTallerTextBox.Text = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).HorasTrabajoTaller
        Me.CostoMontajeTextBox.Text = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).Montaje
    End Sub

    Private Sub BtnGenerarPrecio_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenerarPrecio.Click
        GenerarPrecio()
    End Sub

    Private Sub CostoMontajeTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles CostoMontajeTextBox.Leave
        Try
            Me.PresupuestoDetalleTableAdapter.ActulizarMontaje(CDbl(CostoMontajeTextBox.Text), Label2.Text)
            ActualizarPresupuesto(My.Forms.FrmPresupuestos)
            Me.PresupuestoDetalleTableAdapter.FillBydDetallePresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Label2.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregarPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregarPresupuesto.Click
        Try
            Dim i As Integer = My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.CurrentRow.Index
            Dim tasa As Double = Convert.ToDouble(My.Forms.FrmPresupuestos.DsPresupuestos.Presupuesto(My.Forms.FrmPresupuestos.PresupuestoBindingSource.Position).tasa)

            Me.Precio_AjustadoTextBox.Text = CDbl(PrecioVentaTextBox.Text).ToString("F2")
            Me.TotalPartidaTextBox.Text = (CDbl(PrecioVentaTextBox.Text) * CDbl(CantidadTextBox.Text)).ToString("F2")
            Me.Precio_AjustadoRD_TextBox.Text = (Round(tasa * CDbl(Me.PrecioVentaTextBox.Text) / 10) * 10).ToString("F2")
            Me.TasaTextBox.Text = tasa.ToString("F2")
            Me.TotalPartidaRD_TextBox.Text = (CDbl(Me.Precio_AjustadoRD_TextBox.Text) * CDbl(Me.CantidadTextBox.Text)).ToString("F2")

            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

            My.Forms.FrmPresupuestos.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
            My.Forms.FrmPresupuestos.CambioPrecio()
            My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.CurrentCell = My.Forms.FrmPresupuestos.PresupuestoDetalleDataGridView.Rows(i).Cells(3)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TrabajoTallerTextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        Try
            Me.ArticulosTableAdapter.ActulizarHoras(Me.TrabajoTallerTextBox.Text, Me.ArticuloTextBox.Text)
            Me.PresupuestoDetalleTableAdapter.ActulizarHorasTrabajo(Me.TrabajoTallerTextBox.Text, MontajeTextBox.Text, Me.ArticuloTextBox.Text)
            Me.PresupuestoDetalleTableAdapter.FillBydDetallePresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Me.IdDetalle_PresupuestoTextBox.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.PresupuestoDetalleTableAdapter.Update(Me.DsPresupuestoDetalle)
    End Sub

    Private Sub CostoMontajeTextBox_TextChanged(sender As Object, e As EventArgs) Handles CostoMontajeTextBox.TextChanged
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.ArticulosTableAdapter.Update(DsArticulos)
    End Sub

    Private Sub ActualizarPresupuesto(frmPresupuestos As FrmPresupuestos)
        Dim indice As Integer = frmPresupuestos.PresupuestoDetalleDataGridView.CurrentRow.Index
        frmPresupuestos.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(frmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle, frmPresupuestos.TxtIdPresupuesto.Text)
        frmPresupuestos.PresupuestoDetalleDataGridView.Rows(indice).Selected = True
        frmPresupuestos.PrecioArticulo()
    End Sub
End Class
