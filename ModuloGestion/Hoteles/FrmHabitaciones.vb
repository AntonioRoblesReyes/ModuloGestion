Public Class FrmHabitaciones
    Private Sub HabitacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HabitacionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HabitacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)

    End Sub

    Private Sub FrmHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelesDataSet.HabitacionesDetalle' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesDetalleTableAdapter.Fill(Me.HotelesDataSet.HabitacionesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'HotelesDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.HotelesDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'HotelesDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesTableAdapter.Fill(Me.HotelesDataSet.Habitaciones)

    End Sub

    Private Sub ArticulosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosDataGridView.CellClick
        If e.ColumnIndex = 4 Then

            Dim Iddetalle As String = Me.HotelesDataSet.Habitaciones(Me.HabitacionesBindingSource.Position).IdHabitacionesTipo & "-" & Me.HotelesDataSet.Articulos(Me.ArticulosBindingSource.Position).IdArticulos
            Dim Articulo As String = Me.HotelesDataSet.Articulos(Me.ArticulosBindingSource.Position).IdArticulos
            Dim Descripcion As String = Me.HotelesDataSet.Articulos(Me.ArticulosBindingSource.Position).Descripcion
            Dim IdHabitacion As String = Me.HotelesDataSet.Habitaciones(Me.HabitacionesBindingSource.Position).IdHabitacionesTipo
            Try
                Me.HabitacionesDetalleTableAdapter.Insertar(Iddetalle, Articulo, Descripcion, IdHabitacion, 1)
                Me.HabitacionesDetalleTableAdapter.FillByIdHabitacion(Me.HotelesDataSet.HabitacionesDetalle, IdHabitacion)
            Catch ex As Exception
                MsgBox("Ya se ingreso este elemento")
            End Try

        ElseIf e.ColumnIndex = 2 Then


        End If
    End Sub

    Private Sub HabitacionesDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles HabitacionesDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.HabitacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)
    End Sub

    Private Sub HabitacionesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles HabitacionesDataGridView.CellClick
        Dim IdHabitacion As String = Me.HotelesDataSet.Habitaciones(Me.HabitacionesBindingSource.Position).IdHabitacionesTipo

        Me.HabitacionesDetalleTableAdapter.FillByIdHabitacion(Me.HotelesDataSet.HabitacionesDetalle, IdHabitacion)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.RptHotel.Close()
        My.Forms.RptHotel.ImHabitacion()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.FrmArticulosHoteles.Close()
        My.Forms.FrmArticulosHoteles.Show()
    End Sub

    Private Sub ArticulosDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosDataGridView.CellEndEdit
        Me.Validate()
        Me.HabitacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)
    End Sub

    Private Sub HabitacionesDetalleDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles HabitacionesDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.HabitacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)
    End Sub
End Class