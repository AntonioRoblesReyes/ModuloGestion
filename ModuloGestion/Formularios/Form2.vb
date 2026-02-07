Public Class Form2
    Sub Validar()
        Me.Validate()
        Me.CompraMaterialesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsCompras)

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMateriales' Puede moverla o quitarla según sea necesario.
        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Me.Text = "Ingreso de Compras"
        Me.Label1.Text = String.Empty
        Me.LblProveedor.Text = String.Empty
        Me.LblPresupuesto.Text = String.Empty
        Me.LblProyecto.Text = String.Empty

    End Sub
End Class
