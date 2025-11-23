Public Class FrmSubarticulosGenerar
    Sub ActulizarDetallePresupuesto()
        Try


            Dim IdDetalleSubArticulo As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Id_detalle_Sub_Articulo
            'Me.PresupuestoDetalleElementosTableAdapter.FillByIdDetalleArticulo(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos, IdDetalleSubArticulo)

            Dim proyecto As String = Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos(Me.PresupuestoDetalleElementosBindingSource.Position).Id_Proyecto
            Dim empresa As String = Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos(Me.PresupuestoDetalleElementosBindingSource.Position).Id_Empresa

            Me.PresupuestoDetalleElementosTableAdapter.FillByIddetalleSubArticulo(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos, IdDetalleSubArticulo)
            Dim Cantidad As Double = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Cantidad
            Dim Material As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Id_Material_Detalle
            Dim ConsumoTotal As Double = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).ConsumoTotal
            Dim Totaldesperdicio As Double = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).TotalDesperdicio
            Dim TotalCompra As Double = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).TotalCompra
            Dim IdMedida As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Id_Medida
            Dim PrecioCompra As Double = Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos(Me.PresupuestoDetalleElementosBindingSource.Position).PrecioCompra
            Dim cantidadSubArticulo As Double = Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos(Me.PresupuestoDetalleElementosBindingSource.Position).CantidadSubarticulo
            Dim ConsumoTotalarticulo As Double = cantidadSubArticulo * ConsumoTotal
            Dim desperdicoTotalArticulo As Double = cantidadSubArticulo * Totaldesperdicio
            Dim TotalCompraArticulo As Double = ConsumoTotalarticulo + desperdicoTotalArticulo
            Dim TotalcostoArticulo As Double = PrecioCompra * TotalCompraArticulo
            Dim cantidadDetallePresupuesto As Double = Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos(Me.PresupuestoDetalleElementosBindingSource.Position).CantidadArticulos
            Dim TotalDetallePresupuesto As Double = cantidadDetallePresupuesto * ConsumoTotalarticulo
            Dim TotalDesperdicioDetallePresupuesto As Double = cantidadDetallePresupuesto * desperdicoTotalArticulo
            Dim totalCompraDetallepresupuesto As Double = TotalDetallePresupuesto + TotalDesperdicioDetallePresupuesto
            Dim Codigo As String = empresa & "-" & proyecto & "-" & Material & "-" & IdMedida
            Dim totalcostopresupuesto As Double = PrecioCompra * totalCompraDetallepresupuesto
            Me.PresupuestoDetalleElementosTableAdapter.ActualizarElemnetosPresupuesto(Cantidad, Material, ConsumoTotal, Totaldesperdicio, TotalCompra, IdMedida, Codigo, ConsumoTotalarticulo, desperdicoTotalArticulo, TotalCompraArticulo, TotalcostoArticulo, TotalDetallePresupuesto, TotalDesperdicioDetallePresupuesto, totalCompraDetallepresupuesto, totalcostopresupuesto, IdDetalleSubArticulo)
            Me.PresupuestoDetalleElementosTableAdapter.FillByIddetalleSubArticulo(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos, IdDetalleSubArticulo)
        Catch ex As Exception

        End Try

    End Sub
    Sub SubarticuloM2Pintura()
        Try

            Dim TotalM2SubArticulo As Double = 0
            Dim TotalM2 As Integer = SubArticulosDetalleDataGridView.Rows.Count

            Dim M2 As Integer
            For M2 = 0 To TotalM2 - 1
                '        'Double.parse()<---es para convertir a double el valor que se encuentre entre lso parentesis
                '        'me.datagridview1(4,i).value <----toma todos los valores de la columna 4... 4 es el numero de columna y i es el numero de fila asi toma todos los 
                '        'valores de esa columna, recuerda que las columnas inician en 0... asi que la 4 enrealidad sera la 5 visualmente
                TotalM2SubArticulo += CDbl(SubArticulosDetalleDataGridView(18, M2).Value)

            Next
            Me.TxtM2Pintura.Text = TotalM2SubArticulo
            Me.Validate()
            Me.SubArticulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

        Catch ex As Exception

        End Try


    End Sub
    Sub Subarticulo()
        Dim Subarticulo As String = My.Forms.FrmArticulo.DsArticulosdetalle.ArticulosDetalle(My.Forms.FrmArticulo.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
        Me.SubArticulosTableAdapter.FillByIdSubArticulo(Me.DsSubArticulos.SubArticulos, Subarticulo)
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, Subarticulo)
    End Sub
    Sub DuplicarRegistro()
        Me.SubArticulosDetalleBindingSource.MoveFirst()

        Dim siguiente As String = Me.SubArticulosTableAdapter.SubArticulosiguiente()

        Me.SubArticulosTableAdapter.DuplicarRegistro(siguiente, TxtDescripcion.Text & " Registro Duplicado", CDbl(TxtTiempoTrabajo.Text), TxtGrupoSubarticulo.Text, TxtM2Pintura.Text, 0)
        Dim filas As Integer = Me.SubArticulosDetalleDataGridView.RowCount() - 1
        For siguentefila = 0 To filas - 1

            Dim Subarticulo As String = siguiente
            Dim idSubarticuloDetalle As String = Me.SubArticulosDetalleTableAdapter.SiguienteDetalle(siguiente)
            Dim Descripcion As String = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(2).Value
            Dim largo As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(3).Value
            Dim Ancho As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(4).Value
            Dim Grueso As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(5).Value
            Dim Cantidad As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(6).Value
            Dim Material As String = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(7).Value
            Dim Medida As String = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(8).Value
            Me.SubArticulosDetalleTableAdapter.DuplicarDetalleSubarticulo(idSubarticuloDetalle, Subarticulo, Descripcion, largo, Ancho, Grueso, Cantidad, Material, Medida)

            Me.SubArticulosDetalleBindingSource.MoveNext()

        Next
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)
        Me.SubArticulosTableAdapter.FillByIdSubArticulo(Me.DsSubArticulos.SubArticulos, siguiente)
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, TxtIdSubarticulo.Text)

    End Sub


    Sub MetrosPintura()
        Dim Iddescripcion As String = SubArticulosDetalleDataGridView.Item(2, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
        Me.DescripcionesDetalleTableAdapter.FillByPorDescripcion(Me.DsDescripcionesdetalle.DescripcionesDetalle, Iddescripcion)
        Dim caras As Integer = Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_Caras
        Dim cantos As Integer = Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_Canto
        Dim Cabeza As Integer = Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_cabeza
        Dim M2Cara As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
        Dim M2canto As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
        Dim M2Cabeza As Double = SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
        Dim cantidad As Double = SubArticulosDetalleDataGridView.Item(6, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
        Dim MetrosPinuturaunidad As Double = ((caras * M2Cara) + (cantos * M2canto) + (Cabeza * M2Cabeza)) / 10000
        Dim TotalMetrosPinturaDetalle As Double = cantidad * MetrosPinuturaunidad
        SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = MetrosPinuturaunidad
        SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = TotalMetrosPinturaDetalle
        Me.Validate()
        Me.SubArticulosDetalleBindingSource.EndEdit()
        Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)


    End Sub

    Sub Actualizar()

        Dim Subarticulo As String = TxtIdSubarticulo.Text
        Dim idSubarticuloDetalle As String = Me.SubArticulosDetalleTableAdapter.SiguienteDetalle(TxtIdSubarticulo.Text)
        Dim IdMaterial As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(SubArticulosDetalleBindingSource.Position).Id_Material_Detalle
        Dim Descripcion As String = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(2).Value

        Dim Material As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(7).Value
        Me.MaterilaesDetalleTableAdapter.FillByIdMaterial(Me.DsMaterialDetalle.MaterilaesDetalle, Material)
        Dim desperdicio As Double = Me.DsMaterialDetalle.MaterilaesDetalle(Me.MaterilaesDetalleBindingSource.Position).Desperdicio
        Dim Medida As String = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(8).Value

        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)

        Dim largo As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(3).Value
        Dim Ancho As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(4).Value
        Dim Grueso As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(5).Value
        Dim Cantidad As Double = Me.SubArticulosDetalleDataGridView.CurrentRow.Cells(6).Value

        Me.DescripcionesDetalleTableAdapter.FillByDescripcionDetalle(Me.DsDescripcionesdetalle.DescripcionesDetalle, Descripcion)

        Dim CaraPintada As Integer = Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_Caras

        Dim CantoPintada As Integer = Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_Canto

        Dim CabezaPintada As Integer = Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_cabeza







        Select Case Medida

            Case 3 'Pies tablares
                Dim largoPies As Double = Math.Round((largo + 8.62) / 15.24) / 2

                Dim AnchoPulgadas As Double = (Math.Round(((Ancho + 0.5) / 1.27))) / 2
                Dim GruesoPulgadas As Double = (Math.Round(((Grueso + 0.317) / 0.635))) / 4
                Dim PiesTablares As Double = (largoPies * AnchoPulgadas * GruesoPulgadas) / 12
                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal * desperdicio) + (consumoTotal)

                Dim PinturCara As Double = M2Cara * CaraPintada
                Dim PinturCanto As Double = M2Canto * CantoPintada
                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
            Case 12 'planchas 244x122
                Dim planchalargo As Double = 2.44
                Dim planchaancho As Double = 1.22
                Dim largoPies As Integer = largo 'Math.Floor


                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = ((largoPies * AnchoPulgadas) / 10000) / (planchaancho * planchalargo)

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
            Case 13 'planchas 366x183
                Dim planchalargo As Double = 3.66
                Dim planchaancho As Double = 1.83
                Dim largoPies As Integer = largo 'Math.Floor


                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = ((largoPies * AnchoPulgadas) / 10000) / (planchaancho * planchalargo)

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
            Case 1 ' metros cuadrados

                Dim largoPies As Double = largo
                Dim AnchoPulgadas As Double = Ancho
                Dim GruesoPulgadas As Double = Grueso
                Dim PiesTablares As Double = (largo * Ancho) / 10000
                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal * desperdicio) + (consumoTotal)

                Dim PinturCara As Double = M2Cara * CaraPintada
                Dim PinturCanto As Double = M2Canto * CantoPintada
                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada
                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
            Case 5 'metros lineales
                Dim largoPies As Double = 0
                Dim AnchoPulgadas As Double = 0
                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = (SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value) / 100

                Dim M2Cara As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                Dim M2canto As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                Dim M2Cabeza As Double = SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                SubArticulosDetalleDataGridView.CurrentRow.Cells(8).Value = Medida
                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = CDbl(M2Cara / 10000)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = CDbl(M2canto / 10000)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = CDbl(M2Cabeza / 10000)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = Cantidad * PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = (M2Cabeza + M2canto + M2Cara) / 10000
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = (M2Cabeza + M2canto + M2Cara) * Cantidad / 10000 'desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = Cantidad * PiesTablares * desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = (Cantidad * desperdicio * PiesTablares) + (Cantidad * PiesTablares)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "NUEVA ID"
                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)

                '    Case 2 'metros cubicos
                '        Dim largoPies As Double = 0
                '        Dim AnchoPulgadas As Double = 0
                '        Dim GruesoPulgadas As Double = 0
                '        Dim PiesTablares As Double = (SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value) / 1000000
                '        Dim cantidad As Double = SubArticulosDetalleDataGridView.Item(6, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        Dim M2Cara As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        Dim M2canto As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        Dim M2Cabeza As Double = SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(8).Value = medida
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = CDbl(M2Cara / 10000)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = CDbl(M2canto / 10000)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = CDbl(M2Cabeza / 10000)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = cantidad * PiesTablares
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = (M2Cabeza + M2canto + M2Cara) / 10000
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = (M2Cabeza + M2canto + M2Cara) * cantidad / 10000 'desperdicio
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = cantidad * PiesTablares * desperdicio
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = (cantidad * desperdicio * PiesTablares) + (cantidad * PiesTablares)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "NUEVA ID"
                '        Me.Validate()
                '        Me.SubArticulosDetalleBindingSource.EndEdit()
                '        Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)

            Case 8 'Pies cuadrados
                Dim largoPies As Double = largo / 30.48
                Dim AnchoPulgadas As Double = Ancho / 30.48
                Dim GruesoPulgadas As Double = Grueso
                Dim PiesTablares As Double = (largoPies * AnchoPulgadas)
                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal * desperdicio) + (consumoTotal)

                Dim PinturCara As Double = M2Cara * Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_Caras
                Dim PinturCanto As Double = M2Canto * Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_Canto
                Dim PinturCabeza As Double = M2Cabeza * Me.DsDescripcionesdetalle.DescripcionesDetalle(Me.DescripcionesDetalleBindingSource.Position).Pintura_cabeza
                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)

            Case 6 'Pies lineales
                Dim largoPies As Double = CDbl(CInt((SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value + 7.62) / 15.24) / 2)
                Dim AnchoPulgadas As Double = 0
                Dim GruesoPulgadas As Double = Ancho
                Dim PiesTablares As Double = largo
                Dim M2Cara As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                Dim M2canto As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                Dim M2Cabeza As Double = SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                SubArticulosDetalleDataGridView.CurrentRow.Cells(8).Value = Medida
                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = CDbl(M2Cara / 10000)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = CDbl(M2canto / 10000)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = CDbl(M2Cabeza / 10000)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = Cantidad * PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = (M2Cabeza + M2canto + M2Cara) / 10000
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = (M2Cabeza + M2canto + M2Cara) * Cantidad / 10000 'desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = Cantidad * PiesTablares * desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = (Cantidad * desperdicio * PiesTablares) + (Cantidad * PiesTablares)
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "NUEVA ID"
                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)

                '    Case 4 'Pies cubicos
                '        Dim largoPies As Double = CDbl(CInt((SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value + 7.62) / 15.24) / 2)
                '        Dim AnchoPulgadas As Double = CDbl(CInt((SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value + 7.62) / 15.24) / 2)
                '        Dim GruesoPulgadas As Double = CDbl(CInt((SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value + 7.62) / 15.24) / 2)
                '        Dim PiesTablares As Double = largoPies * AnchoPulgadas * GruesoPulgadas
                '        Dim cantidad As Double = SubArticulosDetalleDataGridView.Item(6, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        Dim M2Cara As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        Dim M2canto As Double = SubArticulosDetalleDataGridView.Item(3, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        Dim M2Cabeza As Double = SubArticulosDetalleDataGridView.Item(4, SubArticulosDetalleDataGridView.CurrentRow.Index).Value * SubArticulosDetalleDataGridView.Item(5, SubArticulosDetalleDataGridView.CurrentRow.Index).Value
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(8).Value = medida
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = CDbl(M2Cara / 10000)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = CDbl(M2canto / 10000)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = CDbl(M2Cabeza / 10000)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = cantidad * PiesTablares
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = (M2Cabeza + M2canto + M2Cara) / 10000
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = (M2Cabeza + M2canto + M2Cara) * cantidad / 10000 'desperdicio
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = cantidad * PiesTablares * desperdicio
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = (cantidad * desperdicio * PiesTablares) + (cantidad * PiesTablares)
                '        SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "NUEVA ID"
                '        Me.Validate()
                '        Me.SubArticulosDetalleBindingSource.EndEdit()
                '        Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
            Case 14 'planchas 243.84X213.36
                Dim planchalargo As Double = 2.44
                Dim planchaancho As Double = 2.13
                Dim largoPies As Integer = largo 'Math.Floor


                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = ((largoPies * AnchoPulgadas) / 10000) / (planchaancho * planchalargo)

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)

            Case 15 'planchas 243.84X200
                Dim planchalargo As Double = 2.44
                Dim planchaancho As Double = 2
                Dim largoPies As Integer = largo 'Math.Floor


                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = ((largoPies * AnchoPulgadas) / 10000) / (planchaancho * planchalargo)

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value


                SubArticulosDetalleDataGridView.CurrentRow.Cells(9).Value = largoPies
                SubArticulosDetalleDataGridView.CurrentRow.Cells(10).Value = AnchoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(11).Value = GruesoPulgadas
                SubArticulosDetalleDataGridView.CurrentRow.Cells(12).Value = PiesTablares
                SubArticulosDetalleDataGridView.CurrentRow.Cells(13).Value = M2Cara
                SubArticulosDetalleDataGridView.CurrentRow.Cells(14).Value = M2Canto
                SubArticulosDetalleDataGridView.CurrentRow.Cells(15).Value = M2Cabeza
                SubArticulosDetalleDataGridView.CurrentRow.Cells(16).Value = consumoTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(17).Value = M2Pinturaunidad
                SubArticulosDetalleDataGridView.CurrentRow.Cells(18).Value = M2PinturaTotal
                SubArticulosDetalleDataGridView.CurrentRow.Cells(19).Value = desperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(20).Value = TotalDeperdicio
                SubArticulosDetalleDataGridView.CurrentRow.Cells(21).Value = Totalcompra
                SubArticulosDetalleDataGridView.CurrentRow.Cells(22).Value = "ID NUEVA"

                Me.Validate()
                Me.SubArticulosDetalleBindingSource.EndEdit()
                Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
        End Select

        Try
            SubarticuloM2Pintura()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Sub_ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

    End Sub
    Private Sub FrmSubarticulosGenerar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetalleElementos.PresupuestoDetalleElementos' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleElementosTableAdapter.Fill(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos)
        'TODO: esta línea de código carga datos en la tabla 'DsArticulosdetalle.ArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DescricionesDetalle1.DescripcionesDetalle' Puede moverla o quitarla según sea necesario.
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)
        Me.MdiParent = My.Forms.FrmGestion

        Dim Subarticulo As String = Me.TxtIdSubarticulo.Text

        Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)

        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)

        Me.FerreteriaTableAdapter.Fill(Me.DsFerreteria.Ferreteria)

        Me.SubArticulosDetalleFerreteriaTableAdapter.Fill(Me.DsSubArticulosFerreteria.SubArticulosDetalleFerreteria)



        Me.SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, TxtIdSubarticulo.Text)

        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)

        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)

        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)

        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)


        Me.DataGridView2.Visible = False
        Me.CmdFerreteria.Text = "Ver Ferreteria"
        Me.CmdNuevoDetaleferreteria.Visible = False

        Me.Button3.Visible = False
        Me.Button4.Visible = False
        Me.TxtGrupoSubarticulo.Visible = False


    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Try
            actualizar()
            Me.Validate()
            Me.SubArticulosDetalleBindingSource.EndEdit()
            Me.TableAdapterManager2.UpdateAll(DsSubArticulosDetalle)

        Catch ex As Exception

        End Try
        Dim Siguiente As String = Me.SubArticulosDetalleTableAdapter.SiguienteDetalle(TxtIdSubarticulo.Text)


        Me.SubArticulosDetalleTableAdapter.SiguienteDetalle(Me.TxtIdSubarticulo.Text)

        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

        Me.SubArticulosDetalleBindingSource.AddNew()
        SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value = Siguiente
        SubArticulosDetalleDataGridView.CurrentRow.Cells(1).Value = Me.TxtIdSubarticulo.Text



    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        My.Forms.FrmSubArticulosCosumo.Close()
        My.Forms.FrmSubArticulosCosumo.Show()
        My.Forms.FrmSubArticulosCosumo.ConsumoMatereialSubArticulosTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulosCosumo.DsConsumoMaterialSubarticulos.ConsumoMatereialSubArticulos, Me.TxtIdSubarticulo.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim siguiente As String = SubArticulosDetalleFerreteriaTableAdapter.Siguiente(TxtIdSubarticulo.Text)
        Me.SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, Me.TxtIdSubarticulo.Text)
        Dim dr As DataRow
        dr = Me.DsSubArticulosFerreteria.Tables(0).NewRow()
        'Le inserto el contenido a cada columna
        dr("Id_detalle_Ferreteria") = siguiente
        dr("Id_SubArticulo") = TxtIdSubarticulo.Text
        dr("Cantidad_Ferreteria") = 1
        dr("Id_Eemento_Ferreteria") = "FER-0000"
        Me.CmdNuevoDetaleferreteria.Enabled = False

        Me.DsSubArticulosFerreteria.Tables(0).Rows.Add(dr)
        Dim unused As DataGridViewCell = DataGridView2.CurrentCell
        Try
            Dim cell As DataGridViewCell = SubArticulosDetalleDataGridView.Rows(DataGridView2.RowCount - 2).Cells(2)
            SubArticulosDetalleDataGridView.CurrentCell = cell
        Catch ex As Exception

        End Try

        Try
            Me.Validate()
            Me.SubArticulosDetalleFerreteriaBindingSource.EndEdit()
            Me.SubArticulosDetalleFerreteriaTableAdapter.Update(Me.DsSubArticulosFerreteria)
            Me.CmdNuevoDetaleferreteria.Enabled = True
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Me.Validate()
        Me.SubArticulosDetalleFerreteriaBindingSource.EndEdit()
        Me.SubArticulosDetalleFerreteriaTableAdapter.Update(Me.DsSubArticulosFerreteria)
        Me.CmdNuevoDetaleferreteria.Enabled = True
    End Sub

    Private Sub SubArticulosDetalleDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs)
        Me.Validate()
        Me.SubArticulosDetalleBindingSource.EndEdit()
        Me.SubArticulosDetalleTableAdapter.Update(Me.DsSubArticulosDetalle)
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        DuplicarRegistro()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Forms.FrmIngresoMateriales.Close()
        My.Forms.FrmIngresoMateriales.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        My.Forms.FrmSubArticuloDetalle.Close()
        My.Forms.FrmSubArticuloDetalle.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        My.Forms.FrmGrupoSubArticulos.Close()
        My.Forms.FrmGrupoSubArticulos.Show()
    End Sub

    Private Sub SubArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

    End Sub

    Private Sub SubArticulosDetalleDataGridView_DataError( _
        ByVal sender As Object, _
        ByVal e As DataGridViewDataErrorEventArgs)

        ' Excepción
        Dim ex As Exception = e.Exception


        MessageBox.Show(ex.Message)

        '  e.Cancel = True

    End Sub

    Private Sub Descripcion_Sub_ArticuloLabel_Click(sender As System.Object, e As System.EventArgs) Handles Descripcion_Sub_ArticuloLabel.Click
        SubarticuloM2Pintura()
    End Sub

    Private Sub TxtIdSubarticulo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIdSubarticulo.TextChanged
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, TxtIdSubarticulo.Text)
        Me.SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, TxtIdSubarticulo.Text)
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)

        SubarticuloM2Pintura()
        Me.ArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsArticulosdetalle.ArticulosDetalle, TxtIdSubarticulo.Text)
        Me.ArticulosDetalleTableAdapter.ActulizarDetalleArticulos(TxtTiempoTrabajo.Text / 60, TxtM2Pintura.Text, TxtIdSubarticulo.Text)
        TextBox1.Text = Me.DsDescripciones.Descripciones(Me.DescripcionesBindingSource.Position).descripcion
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsSubArticulos)
        My.Forms.FormGrupoSubArticulos.Show()

    End Sub

    Private Sub SubArticulosDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubArticulosDetalleDataGridView.CellEndEdit




        Try
            actualizar()
            Me.ArticulosDetalleTableAdapter.ActulizarDetalleArticulos(TxtTiempoTrabajo.Text / 60, TxtM2Pintura.Text, TxtIdSubarticulo.Text)
            Me.ArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsArticulosdetalle.ArticulosDetalle, TxtIdSubarticulo.Text)
            Me.ArticulosDetalleTableAdapter.ActulizarTotales(TxtIdSubarticulo.Text)
            Me.ArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsArticulosdetalle.ArticulosDetalle, TxtIdSubarticulo.Text)
        Catch ex As Exception

        End Try
        Try
            ActulizarDetallePresupuesto()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView2.RowsRemoved
        Me.Validate()
        Me.SubArticulosDetalleFerreteriaBindingSource.EndEdit()
        Me.SubArticulosDetalleFerreteriaTableAdapter.Update(Me.DsSubArticulosFerreteria)
    End Sub

    Private Sub BindingNavigatorPositionItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorPositionItem.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, TxtIdSubarticulo.Text)
        Me.SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, TxtIdSubarticulo.Text)
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)
        SubarticuloM2Pintura()
    End Sub

    Private Sub SubArticulosDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubArticulosDetalleDataGridView.CellClick
        Try


            Dim IdDetalleSubArticulo As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Id_detalle_Sub_Articulo
            Me.PresupuestoDetalleElementosTableAdapter.FillByIddetalleSubArticulo(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos, IdDetalleSubArticulo)
        Catch ex As Exception

        End Try
        Dim columna As String = SubArticulosDetalleDataGridView.CurrentCellAddress.X
        Try
            Dim Vacia As String = SubArticulosDetalleDataGridView.CurrentRow.Cells(0).Value

            If columna = 7 Then
                My.Forms.FrmIngresoMaterial.Close()
                My.Forms.FrmIngresoMaterial.Show()
            ElseIf columna = 2 Then
                Me.DescripcionesDetalleTableAdapter.FillByPorDescripcion(Me.DsDescripcionesdetalle.DescripcionesDetalle, TxtGrupoSubarticulo.Text)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub CmdFerreteria_Click_1(sender As System.Object, e As System.EventArgs) Handles CmdFerreteria.Click
        If DataGridView2.Visible = True Then
            DataGridView2.Visible = False
            CmdFerreteria.Text = "Ver Ferreteria"
            CmdNuevoDetaleferreteria.Visible = False
            Button4.Visible = False
        Else
            DataGridView2.Visible = True
            CmdFerreteria.Text = "Ocultar Ferreteria"
            CmdNuevoDetaleferreteria.Visible = True
            Button4.Visible = True
        End If
    End Sub

    Private Sub TxtGrupoSubarticulo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtGrupoSubarticulo.TextChanged
        Try
            Me.DescripcionesDetalleTableAdapter.FillByPorDescripcion(DsDescripcionesdetalle.DescripcionesDetalle, TxtGrupoSubarticulo.Text)
        Catch ex As Exception

        End Try
        Me.DescripcionesTableAdapter.FillByIdDescripcion(Me.DsDescripciones.Descripciones, TxtGrupoSubarticulo.Text)
        TextBox1.Text = Me.DsDescripciones.Descripciones(Me.DescripcionesBindingSource.Position).descripcion
    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub

    Private Sub TxtTiempoTrabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTiempoTrabajo.TextChanged
        Try
            Me.ArticulosDetalleTableAdapter.ActulizarDetalleArticulos(TxtTiempoTrabajo.Text / 60, TxtM2Pintura.Text, TxtIdSubarticulo.Text)
            Me.ArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsArticulosdetalle.ArticulosDetalle, TxtIdSubarticulo.Text)
            Me.ArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsArticulosdetalle.ArticulosDetalle, TxtIdSubarticulo.Text)
            Me.Validate()
            Me.SubArticulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)
        Catch ex As Exception

        End Try

    End Sub


End Class