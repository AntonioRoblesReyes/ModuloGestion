Public Class FemCuentasPorPagarEmpleados
    Private Sub MostrarTotalComuna9()
        Try
            Dim total As Double = 0

            ' Verificar si hay filas en el DataGridView
            If CompraMaterialesDataGridView.Rows.Count > 0 Then
                ' Recorrer las filas del DataGridView
                For Each fila As DataGridViewRow In CompraMaterialesDataGridView.Rows
                    ' Verificar si la celda en la columna de totales no es nula y es convertible a un valor numérico
                    Dim valorCelda As Object = fila.Cells(7).Value
                    If valorCelda IsNot Nothing AndAlso IsNumeric(valorCelda) Then
                        total += CDbl(valorCelda)
                    End If
                Next

                ' Mostrar el total en el Label2
                Label2.Text = total.ToString("N2")
            Else
                ' Si no hay filas en el DataGridView, mostrar un mensaje de error o tomar alguna otra acción
                MessageBox.Show("No hay datos en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Manejar la excepción de manera apropiada, por ejemplo, mostrando un mensaje de error o registrándola en un archivo de registro
            MessageBox.Show("Se produjo un error al calcular el total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' También puedes rellenar el DataGridView si ocurre algún error, como lo estás haciendo en tu código original
            Me.CompraMaterialesTableAdapter.FillByPendientePersonal(Me.DsCompras.CompraMateriales)
        End Try

    End Sub
    Private Sub BancosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BancosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BancosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCompras)

    End Sub

    Private Sub FemCuentasPorPagarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        'TODO: esta línea de código carga datos en la tabla 'DsContabilidad.Bancos' Puede moverla o quitarla según sea necesario.

        Me.CompraMaterialesTableAdapter.FillByPendientePersonal(Me.DsCompras.CompraMateriales)
        MostrarTotalComuna9()
        CompraMaterialesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'CompraMaterialesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CompraMaterialesTableAdapter.FillByPendientePersonal(Me.DsCompras.CompraMateriales)
        MostrarTotalComuna9()
    End Sub

    Private Sub CompraMaterialesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDataGridView.CellClick
        Try


            Dim compra As String = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Compra
            Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, compra)
        Catch ex As Exception

        End Try
    End Sub





End Class