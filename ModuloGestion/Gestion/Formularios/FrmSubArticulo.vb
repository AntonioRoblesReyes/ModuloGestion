Public Class FrmSubArticulo
    Sub VerificarArticulosDetalle()
        Try

            ArticulosDetalleTableAdapter.FillByIdSubArticulo(DsArticulosdetalle.ArticulosDetalle, TxtIdSubarticulo.Text)
            Dim Contar As Integer = DsArticulosdetalle.Tables(0).Rows.Count

            If Contar <> 0 Then

                ArticulosDetalleTableAdapter.ActulizarTiempoPintura(TxtTiempoTrabajo.Text / 60, TxtM2Pintura.Text, TxtIdSubarticulo.Text)
                Try
                    If EstaAbierto(FrmArticulo) Then
                        My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.FillByIdArticulo(My.Forms.FrmArticulo.DsArticulosdetalle.ArticulosDetalle, My.Forms.FrmArticulo.TxtIdArticulo.Text)
                        My.Forms.FrmArticulo.Sumardetalles()
                    Else

                    End If

                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Inicio()
        Try

            MdiParent = My.Forms.FrmGestion
            lblInicio.Visible = True

            If lblInicio.Text <> "" Then
                SubArticulosTableAdapter.FillByIdSubArticulo(DsSubArticulos.SubArticulos, lblInicio.Text)
                FerreteriaTableAdapter.Fill(DsFerreteria.Ferreteria)
                SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, lblInicio.Text)
                Dim IdGrupo As String = DsSubArticulos.SubArticulos(SubArticulosBindingSource.Position).GrupoSubArticulos
                DescripcionesTableAdapter.FillByIdDescripcion(DsDescripciones.Descripciones, IdGrupo)
                LblGrupo.Text = DsDescripciones.Descripciones(DescripcionesBindingSource.Position).descripcion
                Try
                    MedidasCompraTableAdapter.Fill(DsMedidasCompra.MedidasCompra)
                Catch ex As Exception
                    MsgBox("MedidasCompra")
                End Try
                Try
                    DescripcionesDetalleTableAdapter.Fill(DsDescripcionesdetalle.DescripcionesDetalle)
                Catch ex As Exception
                    MsgBox("DescripcionesDetalle")
                End Try
                Try
                    MaterilaesDetalleTableAdapter.Fill(DsMaterialDetalle.MaterilaesDetalle)
                Catch ex As Exception
                    MsgBox("MaterilaesDetalleTableAdapter" & Chr(13) & ex.Message)
                End Try
                Try
                    SubArticulosDetalleTableAdapter.FillByIdSubArticulo(DsSubArticulosDetalle.SubArticulosDetalle, lblInicio.Text)
                Catch ex As Exception
                    MsgBox("SubArticulosDetalleTableAdapter")
                End Try

            Else

            End If

            Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SubarticuloM2Pintura()
        Try

            Dim TotalM2SubArticulo As Double = 0

            For Each row As DataGridViewRow In DgwSubarticuloDetalle.Rows
                TotalM2SubArticulo += Val(row.Cells("SubM2PinuturaUnidadtotal").Value)

            Next
            If IsDBNull(TotalM2SubArticulo) Then
                TxtM2Pintura.Text = 0
            Else
                TxtM2Pintura.Text = TotalM2SubArticulo

            End If

        Catch ex As Exception
            MsgBox("error en la suma de pintura " & ex.Message)
        End Try

    End Sub

    Sub DuplicarRegistro()
        ' Mover al primer registro del BindingSource
        SubArticulosDetalleBindingSource.MoveFirst()

        ' Obtener el siguiente identificador para el subart culo
        Dim siguiente As String = SubArticulosTableAdapter.SubArticulosiguiente()

        Try
            ' Duplicar el registro del subart culo
            SubArticulosTableAdapter.DuplicarRegistro(
            siguiente,
            TxtDescripcion.Text & " Registro Duplicado",
            CDbl(TxtTiempoTrabajo.Text),
            TxtIdGrupo.Text,
            TxtM2Pintura.Text,
            MontajeTextBox.Text
        )

            ' Duplicar los detalles del subart culo
            Dim filas As Integer = DgwSubarticuloDetalle.RowCount()
            For i As Integer = 0 To filas - 1
                ' Obtener los valores del registro actual
                Dim Subarticulo As String = siguiente
                Dim idSubarticuloDetalle As String = SubArticulosDetalleTableAdapter.SiguienteDetalle(siguiente)
                Dim Descripcion As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddescripcionDetalle").Value
                Dim Largo As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value
                Dim Ancho As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value
                Dim Grueso As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                Dim Cantidad As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubCantidad").Value
                Dim Material As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubidMaterialDetalle").Value
                Dim Medida As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIdMedida").Value

                ' Duplicar el detalle del subart culo
                SubArticulosDetalleTableAdapter.DuplicarDetalleSubarticulo(
                idSubarticuloDetalle,
                Subarticulo,
                Descripcion,
                Largo,
                Ancho,
                Grueso,
                Cantidad,
                Material,
                Medida
            )

                ' Mover al siguiente registro en el BindingSource
                SubArticulosDetalleBindingSource.MoveNext()
            Next
        Catch ex As Exception
            ' Manejar cualquier excepci n que ocurra durante el proceso
            MsgBox(ex.Message)
        End Try

        ' Rellenar los datos para mostrar el nuevo subart culo duplicado
        SubArticulosTableAdapter.FillByIdSubArticulo(DsSubArticulos.SubArticulos, siguiente)
        DescripcionesDetalleTableAdapter.Fill(DsDescripcionesdetalle.DescripcionesDetalle)
        MaterilaesDetalleTableAdapter.Fill(DsMaterialDetalle.MaterilaesDetalle)
        MedidasCompraTableAdapter.Fill(DsMedidasCompra.MedidasCompra)
        DescripcionesTableAdapter.Fill(DsDescripciones.Descripciones)
        SubArticulosDetalleTableAdapter.FillByIdSubArticulo(DsSubArticulosDetalle.SubArticulosDetalle, siguiente)
    End Sub

    Sub Actualizar()
        'Try

        Dim Descripcion As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddescripcionDetalle").Value

        Dim Material As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubidMaterialDetalle").Value

        MaterilaesDetalleTableAdapter.FillByIdMaterial(DsMaterialDetalle.MaterilaesDetalle, Material)
        Dim desperdicio As Double = DsMaterialDetalle.MaterilaesDetalle(MaterilaesDetalleBindingSource.Position).Desperdicio

        Dim Medida As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIdMedida").Value

        MaterilaesDetalleTableAdapter.Fill(DsMaterialDetalle.MaterilaesDetalle)

        Dim largo As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value

        Dim Ancho As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value
        Dim Grueso As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
        Dim Cantidad As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubCantidad").Value
        'MsgBox("1")
        DescripcionesDetalleTableAdapter.FillByDescripcionDetalle(DsDescripcionesdetalle.DescripcionesDetalle, Descripcion)
        'MsgBox("2")
        Dim CaraPintada As Integer = DsDescripcionesdetalle.DescripcionesDetalle(DescripcionesDetalleBindingSource.Position).Pintura_Caras
        'MsgBox("CaraPintada " & CaraPintada)
        Dim CantoPintada As Integer = DsDescripcionesdetalle.DescripcionesDetalle(DescripcionesDetalleBindingSource.Position).Pintura_Canto
        'MsgBox("CantoPintada " & CantoPintada)
        Dim CabezaPintada As Integer = DsDescripcionesdetalle.DescripcionesDetalle(DescripcionesDetalleBindingSource.Position).Pintura_cabeza
        DescripcionesDetalleTableAdapter.FillByPorDescripcion(DsDescripcionesdetalle.DescripcionesDetalle, TxtIdGrupo.Text)
        'MsgBox("CabezaPintada " & CabezaPintada)
        'MsgBox("3")

        Select Case Medida

            Case 3 'Pies tablares
                Dim largoPies As Double = Math.Round((largo + 5) / 7.62) / 4

                Dim AnchoPulgadas As Double = Ancho + 0.3
                Select Case AnchoPulgadas
                    Case 0 To 0.635
                        AnchoPulgadas = 0.25
                    Case 0.636 To 1.27
                        AnchoPulgadas = 0.5
                    Case 1.271 To 1.9
                        AnchoPulgadas = 0.75
                    Case 1.91 To 2.54
                        AnchoPulgadas = 1
                    Case 2.541 To 3.81
                        AnchoPulgadas = 1.5
                    Case 3.82 To 4.445
                        AnchoPulgadas = 1.75
                    Case 4.446 To 5.08
                        AnchoPulgadas = 2
                    Case 5.09 To 7.62
                        AnchoPulgadas = 3
                    Case 7.63 To 10.16
                        AnchoPulgadas = 4
                    Case 10.17 To 12.7
                        AnchoPulgadas = 5
                    Case 12.701 To 15.24
                        AnchoPulgadas = 6
                    Case 15.241 To 17.78
                        AnchoPulgadas = 7
                    Case 17.781 To 20.32
                        AnchoPulgadas = 8
                    Case 20.321 To 25.4
                        AnchoPulgadas = 10
                    Case 25.41 To 30.48
                        AnchoPulgadas = 12
                    Case 30.49 To 35.56
                        AnchoPulgadas = 14
                    Case 35.57 To 40.64
                        AnchoPulgadas = 16

                    Case Else
                        MsgBox("No hay Variable")
                End Select

                Dim GruesoPulgadas As Double = Grueso + 0.3
                Select Case GruesoPulgadas
                    Case 0 To 0.635
                        GruesoPulgadas = 0.25
                    Case 0.636 To 1.27
                        GruesoPulgadas = 0.5
                    Case 1.271 To 1.9
                        GruesoPulgadas = 0.75
                    Case 1.91 To 2.54
                        GruesoPulgadas = 1
                    Case 2.541 To 3.81
                        GruesoPulgadas = 1.5
                    Case 3.82 To 4.445
                        GruesoPulgadas = 1.75
                    Case 4.446 To 5.08
                        GruesoPulgadas = 2
                    Case 5.09 To 7.62
                        GruesoPulgadas = 3
                    Case 7.63 To 10.16
                        GruesoPulgadas = 4
                    Case 10.17 To 12.7
                        GruesoPulgadas = 5
                    Case 12.701 To 15.24
                        GruesoPulgadas = 6
                    Case 15.241 To 17.78
                        GruesoPulgadas = 7
                    Case 17.781 To 20.32
                        GruesoPulgadas = 8
                    Case 20.321 To 25.4
                        GruesoPulgadas = 10
                    Case 25.41 To 30.48
                        GruesoPulgadas = 12
                    Case 30.49 To 35.56
                        GruesoPulgadas = 14
                    Case 35.57 To 40.64
                        GruesoPulgadas = 16
                    Case Else
                        'MsgBox("No hay Variable")
                End Select

                Dim PiesTablares As Double = (largoPies * AnchoPulgadas * GruesoPulgadas) / 12
                Dim M2Cara As Double = (largo * Ancho) / 10000

                Dim M2Canto As Double = (largo * Grueso) / 10000
                'MsgBox("M2Canto " & M2Canto)
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal * desperdicio) + (consumoTotal)

                Dim PinturCara As Double = M2Cara * CaraPintada
                'MsgBox("PinturCara" & PinturCara & "  " & CaraPintada)
                Dim PinturCanto As Double = M2Canto * CantoPintada
                'MsgBox("PinturCanto " & PinturCanto & "  " & CantoPintada)
                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada
                'MsgBox("PinturCabeza " & PinturCabeza)
                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                'MsgBox("M2Pinturaunidad " & M2Pinturaunidad)
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad

                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '
            Case 12 'planchas 244x122
                Dim planchalargo As Double = 2.44
                Dim planchaancho As Double = 1.22
                Dim largoPies As Double = largo

                Dim AnchoPulgadas As Double = Ancho

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = ((largoPies * AnchoPulgadas) / 10000) / (planchaancho * planchalargo)

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada
                'MsgBox("PinturCara " & M2Cara & "X" & CaraPintada & "=" & PinturCara)
                Dim PinturCanto As Double = M2Canto * CantoPintada
                'MsgBox("PinturCanto " & M2Canto & "X" & CantoPintada & "=" & PinturCanto)
                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada
                'MsgBox("PinturCabeza " & M2Cabeza & "X" & CabezaPintada & "=" & PinturCabeza)
                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                'MsgBox("M2Pinturaunidad " & PinturCara & "+" & PinturCanto & "+" & PinturCabeza & "=" & M2Pinturaunidad)
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad

                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '
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
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '
            Case 7 'unidades

                Dim largoPies As Integer = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value

                Dim AnchoPulgadas As Integer = DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value

                Dim GruesoPulgadas As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                Dim PiesTablares As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubCantidad").Value

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad
                Dim TotalDeperdicio As Double = consumoTotal * desperdicio
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '
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
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '

            Case 5 'metros lineales
                Dim largoPies As Double = 0
                Dim AnchoPulgadas As Double = 0
                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value / 100

                Dim M2Cara As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value * DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value
                Dim M2canto As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value * DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                Dim M2Cabeza As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value * DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                DgwSubarticuloDetalle.CurrentRow.Cells("SubIdMedida").Value = Medida
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = CDbl(M2Cara / 10000)
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = CDbl(M2canto / 10000)
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = CDbl(M2Cabeza / 10000)
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = Cantidad * PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = (M2Cabeza + M2canto + M2Cara) / 10000
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = (M2Cabeza + M2canto + M2Cara) * Cantidad / 10000 'desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = Cantidad * PiesTablares * desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = (Cantidad * desperdicio * PiesTablares) + (Cantidad * PiesTablares)

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

                Dim PinturCara As Double = M2Cara * DsDescripcionesdetalle.DescripcionesDetalle(DescripcionesDetalleBindingSource.Position).Pintura_Caras
                Dim PinturCanto As Double = M2Canto * DsDescripcionesdetalle.DescripcionesDetalle(DescripcionesDetalleBindingSource.Position).Pintura_Canto
                Dim PinturCabeza As Double = M2Cabeza * DsDescripcionesdetalle.DescripcionesDetalle(DescripcionesDetalleBindingSource.Position).Pintura_cabeza
                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '

            Case 6 'Pies lineales
                Dim largoPies As Double = CDbl(CInt((DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value + 7.62) / 15.24) / 2)
                Dim AnchoPulgadas As Double = 0
                Dim GruesoPulgadas As Double = Ancho
                Dim PiesTablares As Double = largo
                Dim M2Cara As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value * DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value
                Dim M2canto As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value * DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                Dim M2Cabeza As Double = DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value * DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                DgwSubarticuloDetalle.CurrentRow.Cells("SubIdMedida").Value = Medida
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = CDbl(M2Cara / 10000)
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = CDbl(M2canto / 10000)
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = CDbl(M2Cabeza / 10000)
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = Cantidad * PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = (M2Cabeza + M2canto + M2Cara) / 10000
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = (M2Cabeza + M2canto + M2Cara) * Cantidad / 10000 'desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = Cantidad * PiesTablares * desperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = (Cantidad * desperdicio * PiesTablares) + (Cantidad * PiesTablares)

                '            'Validate()
                '            'SubArticulosDetalleBindingSource.EndEdit()
                '            'SubArticulosDetalleTableAdapter.Update(DsSubArticulosDetalle)
                '            'DescripcionesDetalleTableAdapter.FillByDescripcionDetalle(DsDescripcionesdetalle.DescripcionesDetalle, Descripcion)
                '            '    Case 4 'Pies cubicos
                '            '        Dim largoPies As Double = CDbl(CInt(( DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value + 7.62) / 15.24) / 2)
                '            '        Dim AnchoPulgadas As Double = CDbl(CInt(( DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value + 7.62) / 15.24) / 2)
                '            '        Dim GruesoPulgadas As Double = CDbl(CInt(( DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value + 7.62) / 15.24) / 2)
                '            '        Dim PiesTablares As Double = largoPies * AnchoPulgadas * GruesoPulgadas
                '            '        Dim cantidad As Double = DgwSubarticuloDetalle.Item(6, DgwSubarticuloDetalle.CurrentRow.Index).Value
                '            '        Dim M2Cara As Double =  DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value *  DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value
                '            '        Dim M2canto As Double =  DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value *  DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                '            '        Dim M2Cabeza As Double =  DgwSubarticuloDetalle.CurrentRow.Cells("SubAncho").Value *  DgwSubarticuloDetalle.CurrentRow.Cells("SubGrueso").Value
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubIdMedida").Value = medida
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = CDbl(M2Cara / 10000)
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = CDbl(M2canto / 10000)
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = CDbl(M2Cabeza / 10000)
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = cantidad * PiesTablares
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = (M2Cabeza + M2canto + M2Cara) / 10000
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = (M2Cabeza + M2canto + M2Cara) * cantidad / 10000 'desperdicio
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = desperdicio
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = cantidad * PiesTablares * desperdicio
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = (cantidad * desperdicio * PiesTablares) + (cantidad * PiesTablares)
                '            '       DgwSubarticuloDetalle.CurrentRow.Cells("NuevoIdDataGridViewTextBoxColumn").Value = "NUEVA ID"
                '            '        Validate()
                '            '        SubArticulosDetalleBindingSource.EndEdit()
                '            '        SubArticulosDetalleTableAdapter.Update(DsSubArticulosDetalle)
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
                Dim TotalDeperdicio As Double = 0
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '

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
                Dim TotalDeperdicio As Double = 0
                Dim Totalcompra As Double = (consumoTotal + TotalDeperdicio)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = TotalDeperdicio
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '

            Case 16 'Por Plancha 244x122
                Dim planchalargo As Double = 244
                Dim planchaancho As Double = 122

                Dim largoPies As Integer = largo 'Math.Floor

                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = (1 / ((CInt((planchalargo / largo) - 0.5)) * (CInt((planchaancho / AnchoPulgadas) - 0.5)))) + 0.009

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares

                Dim Totalcompra As Double = (consumoTotal)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '
            Case 17 'Por Plancha 244x122
                Dim planchalargo As Double = 210
                Dim planchaancho As Double = 244

                Dim largoPies As Integer = largo 'Math.Floor

                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = (1 / ((CInt((planchalargo / largo) - 0.5)) * (CInt((planchaancho / AnchoPulgadas) - 0.5)))) + 0.009

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares

                Dim Totalcompra As Double = (consumoTotal)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra
                '
            Case 19 'Por Plancha 285x210
                Dim planchalargo As Double = 280
                Dim planchaancho As Double = 205

                Dim largoPies As Integer = largo 'Math.Floor

                Dim AnchoPulgadas As Integer = Ancho  'Math.Floor

                Dim GruesoPulgadas As Double = 0
                Dim PiesTablares As Double = (1 / ((CInt((planchalargo / largo) - 0.5)) * (CInt((planchaancho / AnchoPulgadas) - 0.5)))) + 0.009

                Dim M2Cara As Double = (largo * Ancho) / 10000
                Dim M2Canto As Double = (largo * Grueso) / 10000
                Dim M2Cabeza As Double = (Grueso * Ancho) / 10000
                Dim consumoTotal As Double = Cantidad * PiesTablares

                Dim Totalcompra As Double = (consumoTotal)

                Dim PinturCara As Double = M2Cara * CaraPintada

                Dim PinturCanto As Double = M2Canto * CantoPintada

                Dim PinturCabeza As Double = M2Cabeza * CabezaPintada

                Dim M2Pinturaunidad As Double = PinturCara + PinturCanto + PinturCabeza
                Dim M2PinturaTotal As Double = M2Pinturaunidad * Cantidad
                Dim IdDetalle As String = DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value

                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesLargo").Value = largoPies
                DgwSubarticuloDetalle.CurrentRow.Cells("SubAnchopulgadas").Value = AnchoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubGruesoPulgadas").Value = GruesoPulgadas
                DgwSubarticuloDetalle.CurrentRow.Cells("SubPiesUnidad").Value = PiesTablares
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cara").Value = M2Cara
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Canto").Value = M2Canto
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2Cabeza").Value = M2Cabeza
                DgwSubarticuloDetalle.CurrentRow.Cells("SubConsumoTotal").Value = consumoTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidad").Value = M2Pinturaunidad
                DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = M2PinturaTotal
                DgwSubarticuloDetalle.CurrentRow.Cells("SubDesperdicioMaterial").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalDesperdicio").Value = 0
                DgwSubarticuloDetalle.CurrentRow.Cells("SubTotalCompra").Value = Totalcompra

        End Select

        Try
            Validate()
            SubArticulosDetalleBindingSource.EndEdit()
            SubArticulosDetalleTableAdapter.Update(DsSubArticulosDetalle)
            SubarticuloM2Pintura()

            'MsgBox("correcto")
        Catch ex As Exception
            MsgBox("aqui en los datoas actulizados  " & ex.Message)
        End Try

    End Sub

    Private Sub Sub_ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Try
            Validate()
            SubArticulosBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsSubArticulos)
        Catch ex As Exception

            MsgBox(ex.Message & " este")
        End Try

    End Sub

    Private Sub FrmSubArticulo_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        VerificarArticulosDetalle()
        DsSubArticulosDetalle.Dispose()
        DgwSubarticuloDetalle.DataSource = Nothing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

    Private Sub FrmSubArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l nea de c digo carga datos en la tabla 'DsArticulosdetalle.ArticulosDetalle' Puede moverla o quitarla seg n sea necesario.
        ArticulosDetalleTableAdapter.Fill(DsArticulosdetalle.ArticulosDetalle)

        KeyPreview = True
        TxtIdGrupo.Visible = False
        lblInicio.Visible = False
        DgwFerreteriaDetalle.Visible = False
        BtnAñadirFerreteria.Visible = False

        CmdFerreteria.Text = "Ver Ferreteria"
    End Sub

    Private Sub CmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevo.Click

        Try

            Validate()
            SubArticulosDetalleBindingSource.EndEdit()
            SubArticulosDetalleTableAdapter.Update(DsSubArticulosDetalle)
            Dim Siguiente As String = SubArticulosDetalleTableAdapter.SiguienteDetalle(TxtIdSubarticulo.Text)
            SubArticulosDetalleTableAdapter.SiguienteDetalle(TxtIdSubarticulo.Text)

            SubArticulosDetalleBindingSource.AddNew()
            DgwSubarticuloDetalle.CurrentRow.Cells("SubIddetalleSubArticulo").Value = Siguiente
            DgwSubarticuloDetalle.CurrentRow.Cells(1).Value = TxtIdSubarticulo.Text
            DgwSubarticuloDetalle.CurrentRow.Cells("SubM2PinuturaUnidadtotal").Value = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CmdVerConsumos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmSubArticulosCosumo.Close()
        My.Forms.FrmSubArticulosCosumo.Show()
        My.Forms.FrmSubArticulosCosumo.ConsumoMatereialSubArticulosTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulosCosumo.DsConsumoMaterialSubarticulos.ConsumoMatereialSubArticulos, TxtIdSubarticulo.Text)
    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwFerreteriaDetalle.CellEndEdit
        Try
            Validate()
            SubArticulosDetalleFerreteriaBindingSource.EndEdit()
            SubArticulosDetalleFerreteriaTableAdapter.Update(DsSubArticulosFerreteria)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnDuplicarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDuplicarRegistro.Click

        DuplicarRegistro()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Forms.FrmIngresoMateriales.Close()
        My.Forms.FrmIngresoMateriales.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.FrmGrupoSubArticulos.Close()
        My.Forms.FrmGrupoSubArticulos.Show()
    End Sub

    Private Sub SubArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Try
            Validate()
            SubArticulosBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsSubArticulos)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Descripcion_Sub_ArticuloLabel_Click(sender As System.Object, e As System.EventArgs) Handles Descripcion_Sub_ArticuloLabel.Click
        SubarticuloM2Pintura()
    End Sub

    Private Sub DataGridView2_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DgwFerreteriaDetalle.RowsRemoved
        Validate()
        SubArticulosDetalleFerreteriaBindingSource.EndEdit()
        SubArticulosDetalleFerreteriaTableAdapter.Update(DsSubArticulosFerreteria)
    End Sub

    Private Sub CmdFerreteria_Click_1(sender As System.Object, e As System.EventArgs) Handles CmdFerreteria.Click
        If DgwFerreteriaDetalle.Visible = True Then
            DgwFerreteriaDetalle.Visible = False
            CmdFerreteria.Text = "Ver Ferreteria"
            BtnAñadirFerreteria.Visible = False

        Else
            DgwFerreteriaDetalle.Visible = True
            DgwFerreteriaDetalle.BringToFront()
            CmdFerreteria.Text = "Ocultar Ferreteria"
            BtnAñadirFerreteria.Visible = True

            SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, TxtIdSubarticulo.Text)
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        Close()

    End Sub

    Private Sub DgwSubarticuloDetalle_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DgwSubarticuloDetalle.RowsRemoved
        Try
            Validate()
            SubArticulosDetalleBindingSource.EndEdit()
            SubArticulosDetalleTableAdapter.Update(DsSubArticulosDetalle)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmSubArticulo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.Alt + Keys.A Then
            My.Forms.Form1.Show()
        End If
    End Sub

    Private Sub BtnCambioMAterial_Click(sender As System.Object, e As System.EventArgs) Handles BtnCambioMAterial.Click
        My.Forms.FrmCambioMaterial.Close()
        My.Forms.FrmCambioMaterial.LblIdSubArticulo.Text = TxtIdSubarticulo.Text
        My.Forms.FrmCambioMaterial.Cambio()
    End Sub

    Private Sub BtnAñadirFerreteria_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadirFerreteria.Click
        My.Forms.FrmVerFerreteria.Close()
        My.Forms.FrmVerFerreteria.Show()
    End Sub

    Private Sub DgwSubarticuloDetalle_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwSubarticuloDetalle.CellEndEdit
        If DgwSubarticuloDetalle.CurrentRow.Cells("SubLargo").Value.ToString <> "" And DgwSubarticuloDetalle.CurrentRow.Cells("Subancho").Value.ToString <> "" And DgwSubarticuloDetalle.CurrentRow.Cells("Subgrueso").Value.ToString <> "" Then
            Actualizar()
        End If

    End Sub

    Private Sub DgwSubarticuloDetalle_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgwSubarticuloDetalle.CellClick
        Try

            DescripcionesDetalleTableAdapter.FillByPorDescripcion(DsDescripcionesdetalle.DescripcionesDetalle, TxtIdGrupo.Text)
            'Dim IdDetalleSubArticulo As String = DsSubArticulosDetalle.SubArticulosDetalle(SubArticulosDetalleBindingSource.Position).Id_detalle_Sub_Articulo

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try

            If e.ColumnIndex = 3 Then
                My.Forms.FrmIngresoMaterial.Close()
                My.Forms.FrmIngresoMaterial.Show()
            ElseIf e.ColumnIndex = 2 Then
                DescripcionesDetalleTableAdapter.FillByPorDescripcion(DsDescripcionesdetalle.DescripcionesDetalle, TxtIdGrupo.Text)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgwFerreteriaDetalle_UserDeletingRow(sender As Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DgwFerreteriaDetalle.UserDeletingRow
        Try

            Dim idFerreteria As String = DsSubArticulosFerreteria.SubArticulosDetalleFerreteria(SubArticulosDetalleFerreteriaBindingSource.Position).Id_Eemento_Ferreteria
            Dim idsubarticulo As String = DsSubArticulosFerreteria.SubArticulosDetalleFerreteria(SubArticulosDetalleFerreteriaBindingSource.Position).Id_SubArticulo
            My.Forms.FrmPresupuestos.PresupuestoDetalleFerreteriaTableAdapter.EliminadoEnSubAriculo(idFerreteria, idsubarticulo)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class