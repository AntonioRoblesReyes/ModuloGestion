Public Class FrmTotalesCompraProveedor
    Private Sub FrmTotalesCompraProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsImprimirCompras.TotalCompraPoveedor' Puede moverla o quitarla según sea necesario.
        Me.TotalCompraPoveedorTableAdapter.Fill(Me.DsImprimirCompras.TotalCompraPoveedor)
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMateriales' Puede moverla o quitarla según sea necesario.


    End Sub
End Class