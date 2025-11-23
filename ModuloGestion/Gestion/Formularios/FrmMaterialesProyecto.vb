Public Class FrmMaterialesProyecto
    Sub CambiarColorcantidad1()
        Try



            Dim cantRegistros As Integer = EstadoCopmraProyectoTotalDataGridView.RowCount




            For cantRegistros = 0 To EstadoCopmraProyectoTotalDataGridView.RowCount - 1

                Dim posicion As Integer = EstadoCopmraProyectoTotalDataGridView.CurrentRow.Index


                Dim CantidadP As Double = 0
                Dim CantidadC As Double = 0


                If CantidadP < CantidadC And CantidadC > 0 Then
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(5).Style.BackColor = Color.MediumVioletRed
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(9).Style.BackColor = Color.MediumVioletRed
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumVioletRed

                ElseIf CantidadP = CantidadC And CantidadC > 0 Then
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(5).Style.BackColor = Color.MediumSeaGreen
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumSeaGreen
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(9).Style.BackColor = Color.MediumSeaGreen

                ElseIf CantidadP > CantidadC And CantidadC > 0 Then
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(5).Style.BackColor = Color.MediumSlateBlue
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumSlateBlue
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumSlateBlue
                End If



                Me.EstadoCopmraProyectoTotalBindingSource.MoveNext()

            Next

        Catch ex As Exception

        End Try




    End Sub






    Sub CambiarColorPrecio1()
        Try


            Me.EstadoCopmraProyectoTotalBindingSource.MoveFirst()


            Dim cantRegistros As Integer = EstadoCopmraProyectoTotalDataGridView.RowCount
            For cantRegistros = 0 To EstadoCopmraProyectoTotalDataGridView.RowCount - 1
                Dim PrecioP As Double = 0
                Dim PrecioC As Double = 0
                If PrecioP < PrecioC And PrecioC > 0 Then
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(6).Style.BackColor = Color.MediumVioletRed
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(10).Style.BackColor = Color.MediumVioletRed

                ElseIf PrecioP > PrecioC And PrecioC > 0 Then
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(6).Style.BackColor = Color.MediumSlateBlue
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(10).Style.BackColor = Color.MediumSlateBlue
                ElseIf PrecioP = PrecioC And PrecioC > 0 Then
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(6).Style.BackColor = Color.MediumSeaGreen
                    EstadoCopmraProyectoTotalDataGridView.CurrentRow.Cells(10).Style.BackColor = Color.MediumSeaGreen

                End If
                Me.EstadoCopmraProyectoTotalBindingSource.MoveNext()
            Next
            Me.EstadoCopmraProyectoTotalDataGridView.CurrentRow.Selected = False
        Catch ex As Exception

        End Try
    End Sub
    Sub CambiarColorPrecio()
        Try





            Dim cantRegistros As Integer = EstadoComprasProyectoDataGridView.RowCount
            For cantRegistros = 0 To EstadoComprasProyectoDataGridView.RowCount - 1
                Dim PrecioP As Double = 0
                Dim PrecioC As Double = 0
                If PrecioP < PrecioC And PrecioC > 0 Then
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(6).Style.BackColor = Color.MediumVioletRed
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(10).Style.BackColor = Color.MediumVioletRed

                ElseIf PrecioP > PrecioC And PrecioC > 0 Then
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(6).Style.BackColor = Color.MediumSlateBlue
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(10).Style.BackColor = Color.MediumSlateBlue
                ElseIf PrecioP = PrecioC And PrecioC > 0 Then
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(6).Style.BackColor = Color.MediumSeaGreen
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(10).Style.BackColor = Color.MediumSeaGreen

                End If

            Next
            Me.EstadoComprasProyectoDataGridView.CurrentRow.Selected = False
        Catch ex As Exception

        End Try
    End Sub
    Sub CambiarColorcantidad()
        Try



            Dim cantRegistros As Integer = EstadoComprasProyectoDataGridView.RowCount




            For cantRegistros = 0 To EstadoComprasProyectoDataGridView.RowCount - 1

                Dim posicion As Integer = EstadoComprasProyectoDataGridView.CurrentRow.Index


                Dim CantidadP As Double = 0
                Dim CantidadC As Double = 0


                If CantidadP < CantidadC And CantidadC > 0 Then
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(5).Style.BackColor = Color.MediumVioletRed
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(9).Style.BackColor = Color.MediumVioletRed
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumVioletRed

                ElseIf CantidadP = CantidadC And CantidadC > 0 Then
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(5).Style.BackColor = Color.MediumSeaGreen
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumSeaGreen
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(9).Style.BackColor = Color.MediumSeaGreen

                ElseIf CantidadP > CantidadC And CantidadC > 0 Then
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(5).Style.BackColor = Color.MediumSlateBlue
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(8).Style.BackColor = Color.MediumSlateBlue
                    EstadoComprasProyectoDataGridView.CurrentRow.Cells(9).Style.BackColor = Color.MediumSlateBlue
                End If





            Next

        Catch ex As Exception

        End Try




    End Sub



    Private Sub FrmMaterialesProyecto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion

        Me.ParaDescripcionesComprasTableAdapter.Fill(Me.DsEntradaPrecios1.ParaDescripcionesCompras)
        'TODO: esta línea de código carga datos en la tabla 'DsEntradaPrecios.ParaDescripcionesCompras' Puede moverla o quitarla según sea necesario.
        Me.ParaDescripcionesComprasTableAdapter.Fill(Me.DsEntradaPrecios.ParaDescripcionesCompras)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoCompraProyectoTotal.EstadoCopmraProyectoTotal' Puede moverla o quitarla según sea necesario.

        Me.MdiParent = My.Forms.FrmGestion
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsEntradaPrecios.EntradaPrecios' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsEstadoComprasProyecto.EstadoComprasProyecto' Puede moverla o quitarla según sea necesario.


        If My.Forms.FrmProyectos.Id_EmpresaTextBox.Text.Length = 0 Then
            Me.EstadoComprasProyectoDataGridView.Visible = False
        Else
            Me.EstadoCopmraProyectoTotalDataGridView.Visible = False
        End If



        CambiarColorcantidad()
        cambiarColorPrecio()
        CambiarColorcantidad1()
        cambiarColorPrecio1()

    End Sub

    Private Sub CmdNuevaCompra_Click(sender As System.Object, e As System.EventArgs) Handles CmdNuevaCompra.Click



    End Sub





End Class