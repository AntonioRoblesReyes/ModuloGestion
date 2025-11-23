Public Class FrmProveedoresPago


    Private Sub FrmProveedoresPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProveedoresPagos1.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter1.Fill(Me.DsProveedoresPagos1.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DsProveedoresPagos.Proveedores' Puede moverla o quitarla según sea necesario.

    End Sub


End Class