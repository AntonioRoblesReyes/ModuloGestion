Public Class FrmKtCompleto
    Sub Filtro()
        Dim Articulo As String = My.Forms.FrmNotasEntrega.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmNotasEntrega.PresupuestoDetalleBindingSource.Position).Articulo

        Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, Articulo)
        Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, Articulo)
        Me.TextBox1.Text = 0

    End Sub

    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsArticulos)

    End Sub

    Private Sub FrmKtCompleto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes' Puede moverla o quitarla según sea necesario.
        'Me.PresupuestoDetalleHerrajesTableAdapter.Fill(Me.DsPresupuestoDetalleHerrajes.PresupuestoDetalleHerrajes)
        'TODO: esta línea de código carga datos en la tabla 'DsEstadoEntregas.Estadoentregas' Puede moverla o quitarla según sea necesario.
        'Me.EstadoentregasTableAdapter.Fill(Me.DsEstadoEntregas.Estadoentregas)
        'TODO: esta línea de código carga datos en la tabla 'DsNotasEntregaDetalle.NotasEntregaDetalle' Puede moverla o quitarla según sea necesario.
        'Me.NotasEntregaDetalleTableAdapter.Fill(Me.DsNotasEntregaDetalle.NotasEntregaDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulos.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
        'TODO: esta línea de código carga datos en la tabla 'DsArticulosdetalle.ArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsArticulos.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.TextBox1.Text <> 0 Then
            Me.ArticulosDetalleBindingSource.MoveFirst()

            Dim iTotal As Integer = ArticulosDetalleDataGridView.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            'Definimos la variable i para controlar el ciclo for
            Dim i As Integer
            'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
            For i = 0 To iTotal - 1
                Dim idNotaentrega As String = My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text
                Dim Siguientedetalle As String = Me.NotasEntregaDetalleTableAdapter.SiguienteDetalleNotaEntrega(idNotaentrega)

                Dim IdSubArticulo As String = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
                Dim codigo As String = My.Forms.FrmNotasEntrega.Id_PresupuestoTextBox.Text & "-" & IdSubArticulo
                Dim presupuesto As String = My.Forms.FrmNotasEntrega.Id_PresupuestoTextBox.Text
                'Dim CantidadPendiente As Double = Me.DsEstadoEntregas.Estadoentregas(Me.EstadoentregasBindingSource.Position).Pendiente

                Dim Cantidad As Double = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).Cantidad * Me.TextBox1.Text
                Dim Precio As Double = 0
                Dim total As Double = Cantidad * Precio

                Me.NotasEntregaDetalleTableAdapter.AgregarDetalle(Siguientedetalle, idNotaentrega, IdSubArticulo, Cantidad, Precio, total, codigo, presupuesto)
                Me.ArticulosDetalleBindingSource.MoveNext()


            Next
            My.Forms.FrmNotasEntrega.siguientedetalle()
            Me.Close()
        ElseIf Me.TextBox1.Text = 0 Then
            MsgBox("Debe poner una cantidad")

        End If

    End Sub
End Class