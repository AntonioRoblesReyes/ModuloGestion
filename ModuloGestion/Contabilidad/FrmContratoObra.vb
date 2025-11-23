Public Class FrmContratoObra
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub

    Private Sub FrmContratoObra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpleados.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.FillByContratoObra(Me.DsEmpleados.Empleados)

    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick
        Try
            Dim Cedula As String = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Cedula
            My.Forms.ImpReciboNomina.Lblincio.Text = Cedula
            My.Forms.ImpReciboNomina.Show()

            My.Forms.ImpReciboNomina.ContratoObra()
        Catch ex As Exception

        End Try

    End Sub
End Class