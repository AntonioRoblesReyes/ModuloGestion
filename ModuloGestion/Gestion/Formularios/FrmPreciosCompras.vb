Public Class FrmPreciosCompras

    Private Function TryGetCurrentPrecioRow(ByRef row As DataGridViewRow) As Boolean
        row = Me.PreciosCompraProyectoDataGridView.CurrentRow
        Return row IsNot Nothing AndAlso Not row.IsNewRow
    End Function

    Private Function ToDoubleSafe(value As Object) As Double
        If value Is Nothing OrElse IsDBNull(value) Then
            Return 0
        End If

        Dim parsed As Double
        If Double.TryParse(value.ToString(), parsed) Then
            Return parsed
        End If

        Return 0
    End Function

    Sub ActulizarPrecios()
        Dim row As DataGridViewRow = Nothing
        If Not TryGetCurrentPrecioRow(row) Then
            Exit Sub
        End If

        If Me.PreciosCompraProyectoBindingSource.Position < 0 OrElse
            Me.PreciosCompraProyectoBindingSource.Position >= Me.DsPreciosCompraProyecto.PreciosCompraProyecto.Count Then
            Exit Sub
        End If

        Dim Proyecto As String = My.Forms.FrmPresupuestos.TxtIdProyecto.Text
        Dim Material As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material
        Dim IdEmpresa As String = My.Forms.FrmPresupuestos.TxtIdEmpresa.Text
        Dim Codigo As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).IdPrecioCopmra

        Dim Precio As Double = ToDoubleSafe(row.Cells(2).Value)

        Dim Cantidad As Double = ToDoubleSafe(row.Cells(4).Value)

        Dim totalDeTall As Double = Precio * Cantidad

        row.Cells(6).Value = totalDeTall
        Try



            Me.Validate()
            Me.PreciosCompraProyectoBindingSource.EndEdit()
            Me.PreciosCompraProyectoTableAdapter.Update(Me.DsPreciosCompraProyecto)

            Me.PresupuestoDetalleElementosTableAdapter.ActulizarPreciosCompra(Precio, Codigo)

            Me.PresupuestoDetallePinturaTableAdapter.ActulizarPrecio(Precio, Codigo)

            Me.PresupuestoDetalleHerrajesTableAdapter.ActulizarPrecioCompra(Precio, Codigo)

            Me.PresupuestoDetalleFerreteriaTableAdapter.ActulizarPrecio(Precio, Codigo)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub Presupuesto()



        Me.PrecioCompraConsultaTableAdapter.Fill(Me.DsPreciosCompraConsulta.PrecioCompraConsulta)

        Me.UnionNombreMaterialesTableAdapter.Fill(Me.DsUnionMaterialesNombre.UnionNombreMateriales)

        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)

        Me.PreciosCompraProyectoTableAdapter.Fill(Me.DsPreciosCompraProyecto.PreciosCompraProyecto)
        Dim proyecto As String = My.Forms.FrmPresupuestos.TxtIdProyecto.Text
        Dim presupuesto As String = My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text
        Me.PrecioCompraConsultaTableAdapter.FillByIdProyecto(Me.DsPreciosCompraConsulta.PrecioCompraConsulta, proyecto)
        Me.PreciosCompraProyectoTableAdapter.FillByIdPresupuesto(Me.DsPreciosCompraProyecto.PreciosCompraProyecto, presupuesto)
        Me.Show()
    End Sub

    Sub VerificarPrecios()
        ModificarPrecios()
        Dim Proyecto As String = My.Forms.FrmPresupuestos.TxtIdProyecto.Text
        Dim IdEmpresa As String = My.Forms.FrmPresupuestos.TxtIdEmpresa.Text
        Me.PreciosCompraProyectoTableAdapter.FillByIdProyectoEmpresa(Me.DsPreciosCompraProyecto.PreciosCompraProyecto, Proyecto, IdEmpresa)

        Dim registro As Integer = Me.PreciosCompraProyectoDataGridView.RowCount
        For i1 = 0 To registro - 1




            Dim Material As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material

            Dim IdDtalle As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).IdPrecioCopmra

            Dim Precio As Double = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Precio_Compra
            Dim Cantidad As Double = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).CantidadNecesaria
            Dim total As Double = Precio * Cantidad
            MsgBox(IdDtalle)
            Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(6).Value = Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(2).Value * Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(4).Value

            Try
                Me.Validate()
                Me.PreciosCompraProyectoBindingSource.EndEdit()
                Me.PreciosCompraProyectoTableAdapter.Update(Me.DsPreciosCompraProyecto)
                Me.PresupuestoDetalleElementosTableAdapter.ActulizarPreciosCompra(Precio, IdDtalle)

                Me.PresupuestoDetallePinturaTableAdapter.ActulizarPrecio(Precio, IdDtalle)

                Me.PresupuestoDetalleHerrajesTableAdapter.ActulizarPrecioCompra(Precio, IdDtalle)


                Me.PreciosCompraProyectoBindingSource.MoveNext()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Next



    End Sub




    Sub Precios()
        Dim material As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material

        Me.PrecioCompraConsultaTableAdapter.FillByIdMaterial(Me.DsPreciosCompraConsulta.PrecioCompraConsulta, material)

        Me.PreciosCompraTableAdapter.FillByIdMaterial(Me.DsPreciosCompra.PreciosCompra, material)
    End Sub



    Sub ModificarPrecios()
        Me.PreciosCompraProyectoTableAdapter.EliminarMaterial()
        Dim Presupuesto As String = My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text
        Dim Empresa As String = My.Forms.FrmPresupuestos.TxtIdEmpresa.Text
        Me.PreciosCompraProyectoTableAdapter.FillByIdProyectoEmpresa(Me.DsPreciosCompraProyecto.PreciosCompraProyecto, Presupuesto, Empresa)
        Me.PreciosCompraProyectoTableAdapter.EliminarMaterial()
        Try
            Me.AnexarMaterialCompraTableAdapter.AnexarCompraMaterial(Presupuesto)
        Catch ex As Exception

        End Try
        Try
            Me.AnrxarPinturaCompraTableAdapter.AnexarPinturaCompra(Presupuesto)
            Me.AnexarHerrajesCompraTableAdapter.AnexarHerrajeCompra(Presupuesto)
            Me.PreciosCompraProyectoTableAdapter.ActulizarCantidadMaterial(Presupuesto)
            Me.PreciosCompraProyectoTableAdapter.ActulizarCantidadPinntura(Presupuesto)
        Catch ex As Exception

        End Try




    End Sub





    Private Sub FrmPreciosCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMaterialesDetalle' Puede moverla o quitarla según sea necesario.
        Me.CompraMaterialesDetalleTableAdapter.Fill(Me.DsCompras.CompraMaterialesDetalle)




        Me.TxtPesos.Text = Format(0, "#,##0.00")
        Me.TxtTasa.Text = Format(47, "#,##0.00")
        Me.TxtDolares.Text = Format(0, "#,##0.00")


    End Sub

    Private Sub PreciosCompraProyectoDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PreciosCompraProyectoDataGridView.CellEndEdit

        ActulizarPrecios()
    End Sub



    Private Sub PreciosCompraProyectoDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PreciosCompraProyectoDataGridView.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Precios()
    End Sub

    Private Sub TxtPesos_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtPesos.TextChanged

        Try
            Me.TxtDolares.Text = Format(CDbl(CDbl(Me.TxtPesos.Text) / CDbl(Me.TxtTasa.Text)), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub BtnActualizarPrecios_Click(sender As System.Object, e As System.EventArgs) Handles BtnActualizarPrecios.Click

        If PreciosCompraProyectoDataGridView.Rows.Count = 0 Then
            Exit Sub
        End If

        Me.PreciosCompraProyectoBindingSource.MoveFirst()

        Dim iTotal As Integer = PreciosCompraProyectoDataGridView.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
        'Definimos la variable i para controlar el ciclo for
        Dim i As Integer
        Dim contador As Integer = 0
        For i = 0 To iTotal - 1
            Dim v As Integer = contador + 1
            contador = v
            Dim precioCompra As Double = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Precio_Compra
            If precioCompra = 0 Then
                MsgBox("No puede haber un material sin precio, Modifica el valor")
                Dim currentRow As DataGridViewRow = Nothing
                If TryGetCurrentPrecioRow(currentRow) Then
                    currentRow.Cells(2).Selected = True
                End If

                Exit For

            End If
            Me.PreciosCompraProyectoBindingSource.MoveNext()
        Next
        Dim valor As Double = 0
        Dim lastRow As DataGridViewRow = Nothing
        If TryGetCurrentPrecioRow(lastRow) Then
            valor = ToDoubleSafe(lastRow.Cells(2).Value)
        End If
        If iTotal = contador And valor <> 0 Then
            Me.Close()

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Dim material As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material
    End Sub

    Private Sub TxtTasa_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTasa.TextChanged
        Try
            Me.TxtDolares.Text = Format(CDbl(CDbl(Me.TxtPesos.Text) / CDbl(Me.TxtTasa.Text)), "#,##0.00")
        Catch ex As Exception

        End Try

    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        Me.CompraMaterialesDetalleTableAdapter.FillByBuscar(Me.DsCompras.CompraMaterialesDetalle, "%" & TextBox1.Text & "%")

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Me.PrecioCompraConsultaTableAdapter.FillByDescripcion(Me.DsPreciosCompraConsulta.PrecioCompraConsulta, "%" & TextBox2.Text & "%")
    End Sub

    Private Sub PreciosCompraDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PreciosCompraDataGridView.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If Me.CompraMaterialesDetalleBindingSource.Position < 0 OrElse
            Me.CompraMaterialesDetalleBindingSource.Position >= Me.DsCompras.CompraMaterialesDetalle.Count Then
            Exit Sub
        End If

        Me.Label5.Text = Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).Id_Compra
        Dim precioUS As Double = Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).PrecioUS
        Dim itebisValor As Double = precioUS * 0.18
        Me.Label7.Text = Format(itebisValor, "#,##0.00")
        Me.Label9.Text = Format(itebisValor + precioUS, "#,##0.00")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        My.Forms.FrmIngresoCompras.Close()
        My.Forms.FrmIngresoCompras.Label1.Text = Label5.Text

    End Sub '

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class