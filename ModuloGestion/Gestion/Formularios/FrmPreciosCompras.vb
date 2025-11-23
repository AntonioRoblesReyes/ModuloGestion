Public Class FrmPreciosCompras




    Sub ActulizarPrecios()
        Dim Proyecto As String = My.Forms.FrmPresupuestos.TxtIdProyecto.Text
        Dim Material As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material
        Dim IdEmpresa As String = My.Forms.FrmPresupuestos.TxtIdEmpresa.Text
        Dim Codigo As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).IdPrecioCopmra

        Dim Precio As Double = Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(2).Value

        Dim Cantidad As Double = Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(4).Value

        Dim totalDeTall As Double = Precio * Cantidad

        Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(6).Value = Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(2).Value * Me.PreciosCompraProyectoDataGridView.CurrentRow.Cells(4).Value
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
        Precios()
    End Sub

    Private Sub TxtPesos_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtPesos.TextChanged

        Try
            Me.TxtDolares.Text = Format(CDbl(CDbl(Me.TxtPesos.Text) / CDbl(Me.TxtTasa.Text)), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub BtnActualizarPrecios_Click(sender As System.Object, e As System.EventArgs) Handles BtnActualizarPrecios.Click

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
                PreciosCompraProyectoDataGridView.CurrentRow.Cells(2).Selected = True

                Exit For

            End If
            Me.PreciosCompraProyectoBindingSource.MoveNext()
        Next
        Dim valor As Double = PreciosCompraProyectoDataGridView.CurrentRow.Cells(2).Value
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
        Me.Label5.Text = Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).Id_Compra
        Dim Itebis As Double = Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).Itebis
        Me.Label7.Text = Format(Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).PrecioUS * 0.18, "#,##0.00")
        Me.Label9.Text = Format(Me.Label7.Text + Me.DsCompras.CompraMaterialesDetalle(Me.CompraMaterialesDetalleBindingSource.Position).PrecioUS, "#,##0.00")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        My.Forms.FrmIngresoCompras.Close()
        My.Forms.FrmIngresoCompras.Label1.Text = Label5.Text
        'My.Forms.FrmIngresoCompras.LblPresupuesto.Text = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Presupuesto
        'My.Forms.FrmIngresoCompras.LblProyecto.Text = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_proyecto_Presupuestos
        My.Forms.FrmIngresoCompras.ModificarCompra()
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