Public Class FrmDuplicarPreciosCompra
    Private Sub FrmDuplicarPreciosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPreciosCompraProyecto.PreciosCompraProyecto' Puede moverla o quitarla según sea necesario.
        Me.PreciosCompraProyectoTableAdapter.Fill(Me.DsPreciosCompraProyecto.PreciosCompraProyecto)

    End Sub
    Sub DuplicarPrecioCompraPresupuesto()
        Try
            Dim Presupuesto As String = TextBox1.Text
            Me.PreciosCompraProyectoTableAdapter.FillByIdPresupuesto(Me.DsPreciosCompraProyecto.PreciosCompraProyecto, Presupuesto)

            Dim iTotalPreciosCompra As Integer = Me.DsPreciosCompraProyecto.PreciosCompraProyecto.Rows.Count
            Dim i As Integer

            For i = 0 To iTotalPreciosCompra - 1
                Dim IdPrecioCompra As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).IdPrecioCopmra
                IdPrecioCompra = TextBox2.Text + IdPrecioCompra.Substring(10) ' Eliminar los primeros 6 caracteres de IdPrecioCompra
                Dim Proyecto As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_Proyecto
                Dim IdMaterial As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_material
                Dim PrecioCompra As Double = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Precio_Compra
                Dim Cantidad As Double = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).CantidadNecesaria
                Dim IdMedida As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_Medida
                Dim IdEmpresa As String = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).Id_Empresa
                Dim TotalCosto As Double = Me.DsPreciosCompraProyecto.PreciosCompraProyecto(Me.PreciosCompraProyectoBindingSource.Position).TotalCosto
                Dim fecha As Date = Now.Date
                Me.PreciosCompraProyectoTableAdapter.DuplicarPrecio(IdPrecioCompra, IdMaterial, Proyecto, TotalCosto, IdEmpresa, fecha, IdMedida, TextBox2.Text, Cantidad, PrecioCompra)
                Me.PreciosCompraProyectoBindingSource.MoveNext()
            Next

            ' Mensaje de confirmación después de que se completa la duplicación
            MessageBox.Show("La duplicación de precios al presupuesto se ha realizado correctamente.", "Duplicación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Cerrar el formulario después de mostrar el mensaje de confirmación
            Me.Close()

        Catch ex As Exception
            ' Mensaje de error en caso de que ocurra una excepción
            MessageBox.Show("Se ha producido un error durante la duplicación de precios al presupuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PreciosCompraProyectoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PreciosCompraProyectoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPreciosCompraProyecto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DuplicarPrecioCompraPresupuesto()
    End Sub
End Class