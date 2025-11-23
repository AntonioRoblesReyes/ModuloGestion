Imports System.ComponentModel

Public Class FrmFacturaMontajeEditar



    Sub ModificarFactura()


        Me.Show()
        Me.ArticulosTableAdapter.Fill(DsArticulos.Articulos)
        Me.FacturaMontajeTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontaje, IdFacturaTextBox.Text)
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, IdFacturaTextBox.Text)
        Dim Presupuesto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Presupuesto
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPagosMontaje.PresupuestoDetalle, Presupuesto)
        'Me.EmpresasContratadasMontajeTableAdapter.FillByRazonSocial(Me.DsPagosMontaje.EmpresasContratadasMontaje, IdEmpresaMontajeTextBox.Text)

    End Sub
    Sub AprobarDetalleFactura()

        Try
            Dim Registros As Integer = FacturaMontajeDetalleDataGridView.Rows.Count

            If Registros <> 0 Then
                For Each row As DataGridViewRow In FacturaMontajeDetalleDataGridView.Rows
                    Dim idDetalle As String = row.Cells(0).Value.ToString()
                    Dim IdPago As String = row.Cells(1).Value.ToString()
                    Dim IdDetallePresupuesto As String = row.Cells(2).Value.ToString()
                    Dim IdArticulo As String = row.Cells(3).Value.ToString()
                    Dim Descripcion As String = row.Cells(4).Value.ToString()
                    Dim Cantidad As Double
                    Dim Precio As Double
                    Dim TotalPartida As Double

                    ' Verificar y convertir valores numéricos
                    If Double.TryParse(row.Cells(5).Value.ToString(), Cantidad) AndAlso
                       Double.TryParse(row.Cells(6).Value.ToString(), Precio) AndAlso
                       Double.TryParse(row.Cells(7).Value.ToString(), TotalPartida) Then

                        ' Lógica de procesamiento
                        PagoMontajeDetalleTableAdapter.NuevoDetallePago(idDetalle, IdPago, IdDetallePresupuesto, IdArticulo, Descripcion, Cantidad, Precio, TotalPartida)
                    Else
                        ' Manejar error de conversión
                        Throw New FormatException("Error de formato en valores numéricos.")
                    End If
                Next
            End If
        Catch ex As FormatException
            ' Manejar error de formato
            Console.WriteLine("Error de formato: " & ex.Message)
        Catch ex As Exception
            ' Manejar excepción genérica
            Console.WriteLine("Error: " & ex.Message)
            Dim IdDetalle As String = $"{IdFacturaTextBox.Text}-001"
            Dim IdDetallePresupuesto As String = $"{LblPresupuesto.Text}-001"

            PagoMontajeDetalleTableAdapter.NuevoDetallePago(IdDetalle, IdFacturaTextBox.Text, IdDetallePresupuesto, "sin articulo", "PONER DESCRIPCION", 1, 0, 0)
        End Try

    End Sub

    Sub SumaTotal()
        Try
            Dim suma As Double = 0

            For Each row As DataGridViewRow In FacturaMontajeDetalleDataGridView.Rows
                suma += CDbl(Val(row.Cells(7).Value))
            Next

            SubTotalTextBox.Text = Format(suma, "#,##0.0")

            If Double.TryParse(ImpuestoTextBox.Text, Nothing) Then
                ItebisTextBox.Text = Format(suma * CDbl(ImpuestoTextBox.Text), "#,##0.0")
            Else
                ItebisTextBox.Text = Format(0, "#,##0.0")
            End If

            TotalTextBox.Text = Format(suma + CDbl(ItebisTextBox.Text), "#,##0.0")

            If Double.TryParse(PagadoTextBox.Text, Nothing) Then
                PendienteTextBox.Text = Format(CDbl(TotalTextBox.Text) - CDbl(PagadoTextBox.Text), "#,##0.0")
            Else
                PendienteTextBox.Text = Format(0, "#,##0.0")
            End If

            Validate()
            FacturaMontajeBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsPagosMontaje)

        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            MessageBox.Show($"Error al calcular la suma total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Sub NuevaLinea()
        Try
            ' Obtener el próximo detalle de la factura
            Dim Siguiente As String = Me.FacturaMontajeDetalleTableAdapter.SiguienteDetalle(IdFacturaTextBox.Text)

            ' Llenar el DataSet con información relevante
            ArticulosTableAdapter.FillByIdArticulo(DsArticulos.Articulos, PresupuestoDetalleDataGridView.CurrentRow.Cells(1).Value)
            Dim DetallePresupuesto As String = Me.PresupuestoDetalleBindingSource.Current("IdDetalle_Presupuesto").ToString()
            Dim Articulo As String = Me.PresupuestoDetalleBindingSource.Current("Articulo").ToString()
            Dim Descripcion As String = "PONER DESCRIPCION"
            Dim Cantidad As Double = 0
            Dim previsto As Double = 0
            Dim Total As Double = 0

            ' Agregar un nuevo detalle a la factura
            Me.FacturaMontajeDetalleTableAdapter.NuevoDetalleFactura(Siguiente, IdFacturaTextBox.Text, DetallePresupuesto, Articulo, Descripcion, Cantidad, previsto, Total, LblPresupuesto.Text)

            ' Actualizar el DataGridView de detalles de la factura
            Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, IdFacturaTextBox.Text)
            Me.FacturaMontajeDetalleBindingSource.MoveLast()

            ' Calcular la suma total
            SumaTotal()

            ' Actualizar la lista de artículos
            ArticulosTableAdapter.Fill(DsArticulos.Articulos)
        Catch ex As Exception
            ' Manejar la excepción
            MsgBox("Error al agregar nueva línea: " & ex.Message)
        End Try
    End Sub

    Sub NuevoApuntePresupuesto()
        Try
            ' Añadir nueva fila al DataGridView de FacturaMontajeDetalle
            Dim nuevaFila As DataGridViewRow = FacturaMontajeDetalleDataGridView.Rows(FacturaMontajeDetalleDataGridView.Rows.Add())

            ' Configurar la nueva fila
            With nuevaFila
                .Selected = False
                .Cells(0).Value = .Index
                .Cells(1).Value = IdFacturaTextBox.Text
                .Cells(2).Value = PresupuestoDetalleDataGridView.CurrentRow.Cells(0).Value
                .Cells(3).Value = PresupuestoDetalleDataGridView.CurrentRow.Cells(1).Value
                .Cells(4).Value = ArticulosDataGridView.CurrentRow.Cells(1).Value
                .Cells(5).Value = PresupuestoDetalleDataGridView.CurrentRow.Cells(2).Value
                .Cells(6).Value = PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value
                .Cells(7).Value = 0
            End With

            ' Seleccionar la nueva fila
            FacturaMontajeDetalleDataGridView.ClearSelection()
            FacturaMontajeDetalleDataGridView.CurrentCell = nuevaFila.Cells(0)

        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            MessageBox.Show($"Error al agregar nuevo apunte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub NuevaFactura()
        Try
            ' Llenar la tabla de Artículos
            ArticulosTableAdapter.Fill(DsArticulos.Articulos)

            ' Obtener el próximo número de factura
            IdFacturaTextBox.Text = FacturaMontajeTableAdapter.SiguienteFactura()

            ' Llenar el detalle de presupuesto según el presupuesto actual
            PresupuestoDetalleTableAdapter.FillByIdPresupuesto(DsPagosMontaje.PresupuestoDetalle, LblPresupuesto.Text)

            ' Mostrar el formulario
            Me.Show()

        Catch ex As Exception
            ' Manejar cualquier excepción
            MessageBox.Show($"Error al crear nueva factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub EmpresasContratadasMontajeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresasContratadasMontajeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmpresasContratadasMontajeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)
            MessageBox.Show("Los cambios se guardaron exitosamente.", "Guardar Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FrmPagosMontaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Llenar el DataSet con la tabla Presupuesto
        Me.PresupuestoTableAdapter.Fill(Me.DsPagosMontaje.Presupuesto)

        ' Llenar el DataSet con la tabla PagoMontaje
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)

        ' Llenar el DataSet con las empresas contratadas activas para el montaje
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(DsPagosMontaje.EmpresasContratadasMontaje)


    End Sub






    Private Sub BtnNuevoPagp_Click(sender As System.Object, e As System.EventArgs)

        NuevaFActura()



    End Sub

    Private Sub PresupuestoDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellClick
        Try
            If Not String.IsNullOrEmpty(IdFacturaTextBox.Text) Then
                If e.ColumnIndex = 5 Then
                    Dim siguiente As String = FacturaMontajeDetalleTableAdapter.SiguienteDetalle(IdFacturaTextBox.Text)

                    ' Obtener información del artículo seleccionado en el PresupuestoDetalle
                    Dim articuloId As String = PresupuestoDetalleDataGridView.CurrentRow.Cells(1).Value.ToString()
                    ArticulosTableAdapter.FillByIdArticulo(DsArticulos.Articulos, articuloId)
                    Dim descripcion As String = DsArticulos.Articulos(0).Descripcion_articulo
                    Dim cantidad As Double = Convert.ToDouble(PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value)
                    Dim previsto As Double = Convert.ToDouble(PresupuestoDetalleDataGridView.CurrentRow.Cells(4).Value)
                    Dim total As Double = cantidad * previsto

                    ' Agregar nuevo detalle a la factura
                    FacturaMontajeDetalleTableAdapter.NuevoDetalleFactura(siguiente, IdFacturaTextBox.Text, PresupuestoDetalleDataGridView.CurrentRow.Cells(0).Value.ToString(), articuloId, descripcion, cantidad, previsto, total, LblPresupuesto.Text)

                    ' Actualizar el DataGridView de detalles de la factura
                    FacturaMontajeDetalleTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontajeDetalle, IdFacturaTextBox.Text)
                    FacturaMontajeDetalleBindingSource.MoveFirst()

                    ' Calcular la suma total
                    SumaTotal()

                    ' Actualizar la lista de artículos
                    ArticulosTableAdapter.Fill(DsArticulos.Articulos)
                End If
            Else
                MsgBox("Debe crear una nueva factura antes de agregar detalles.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox($"Error al agregar detalle a la factura: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        NuevaLinea()
    End Sub



    Private Sub BtnAprobarPago_Click(sender As System.Object, e As System.EventArgs) Handles BtnAprobarPago.Click
        Try
            ' Verificar si la factura ya existe
            If FacturaMontajeTableAdapter.ExisteFactura(IdFacturaTextBox.Text) Then
                MsgBox("La factura ya ha sido creada.", MsgBoxStyle.Exclamation)
            Else
                ' Crear una nueva factura de montaje
                FacturaMontajeTableAdapter.Nueva(IdFacturaTextBox.Text, IdEmpresaMontajeTextBox.Text, FechaPAgoDateTimePicker.Value, LblProyecto.Text, LblPresupuesto.Text, 0, 0, 0, "", 0, 0, 0)

                ' Recargar el detalle del presupuesto
                PresupuestoDetalleTableAdapter.FillByIdPresupuesto(DsPagosMontaje.PresupuestoDetalle, LblPresupuesto.Text)

                ' Reiniciar el valor de PagadoTextBox
                PagadoTextBox.Text = "0"

                MsgBox("Factura creada exitosamente.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox($"Error al crear factura: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Forms.ImpPagoMomtaje.Close()
        My.Forms.ImpPagoMomtaje.Label1.Text = IdFacturaTextBox.Text
        My.Forms.ImpPagoMomtaje.ImprimirFacturaMontaje()
    End Sub





    Private Sub RazonSocialComboBox_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FacturaMontajeDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDetalleDataGridView.CellEndEdit
        Try
            If e.ColumnIndex = 5 OrElse e.ColumnIndex = 6 Then
                Dim cantidad As Double = Convert.ToDouble(Me.FacturaMontajeDetalleDataGridView.CurrentRow.Cells(5).Value)
                Dim precio As Double = Convert.ToDouble(Me.FacturaMontajeDetalleDataGridView.CurrentRow.Cells(6).Value)
                Dim total As Double = cantidad * precio

                Me.FacturaMontajeDetalleDataGridView.CurrentRow.Cells(7).Value = total
                SumaTotal()

                'Dim pagado As Double = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Pagado
                '' Realiza aquí las operaciones adicionales que necesites con la variable "Pagado"
            End If
        Catch ex As FormatException
            ' Manejar errores de conversión de tipo
            MsgBox("Error de formato en valores numéricos.")
        Catch ex As Exception
            ' Manejar otras excepciones
            MsgBox("Error: " & ex.Message)
        End Try

        Me.Validate()
        Me.FacturaMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsPagosMontaje)

    End Sub

    Private Sub FrmFacturaMontajeEditar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try


            'Dim fila As String = My.Forms.FrmFacturaMontajeResumen.FacturaMontajeDataGridView.CurrentRow.Index
            My.Forms.FrmFacturaMontajeResumen.FacturaMontajeTableAdapter.Fill(My.Forms.FrmFacturaMontajeResumen.DsPagosMontaje.FacturaMontaje)
            'My.Forms.FrmFacturaMontajeResumen.FacturaMontajeDataGridView.Rows(fila).Selected = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FacturaMontajeDetalleDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles FacturaMontajeDetalleDataGridView.RowsRemoved
        SumaTotal()
        Me.Validate()
        Me.FacturaMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsPagosMontaje)

    End Sub







    Private Sub ImpuestoTextBox_Leave(sender As Object, e As EventArgs) Handles ImpuestoTextBox.Leave
        Me.Validate()
        Me.FacturaMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsPagosMontaje)
        SumaTotal()
    End Sub
End Class