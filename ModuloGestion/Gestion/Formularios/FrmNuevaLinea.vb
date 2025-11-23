Public Class FrmNuevaLinea
    Public Sub NuevaLieneaAreticulo()
        Dim Siguientedetalle As String = My.Forms.FrmNotasEntrega.NotasEntregaDetalleTableAdapter.SiguienteDetalleNotaEntrega(My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text)
        Dim idNotaentrega As String = My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text
        Dim codigo As String = My.Forms.FrmNotasEntrega.Id_ProyectoTextBox.Text & "-" & Me.TextBox1.Text
        Dim CantidadPendiente As Double = 1
        Dim Idherraje As String = Me.TextBox1.Text
        Dim Cantidad As Double = CantidadPendiente
        Dim Precio As Double = 0
        Dim total As Double = Cantidad * Precio
        Dim presupuesto As String = My.Forms.FrmNotasEntrega.Id_PresupuestoTextBox.Text


        My.Forms.FrmNotasEntrega.NotasEntregaDetalleTableAdapter.AgregarDetalle(Siguientedetalle, idNotaentrega, Idherraje, Cantidad, Precio, total, codigo, presupuesto)
        My.Forms.FrmNotasEntrega.UnionSubarticulosHerrajesTableAdapter.Fill(My.Forms.FrmNotasEntrega.DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes)
        My.Forms.FrmNotasEntrega.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(My.Forms.FrmNotasEntrega.DsNotasEntregaDetalle.NotasEntregaDetalle, My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text)

        My.Forms.FrmNotasEntrega.NotasEntregaDetalleBindingSource.MoveLast()
        My.Forms.FrmNotasEntrega.NotasEntregaDetalleDataGridView.CurrentCell = My.Forms.FrmNotasEntrega.NotasEntregaDetalleDataGridView.Rows(My.Forms.FrmNotasEntrega.NotasEntregaDetalleDataGridView.RowCount - 1).Cells(3)
        Me.Validate()
        Me.LieneasEntregaBindingSource.AddNew()
        Me.TableAdapterManager.UpdateAll(Me.DsLineasEntraga)
        Dim Siguiente As String = Me.LieneasEntregaTableAdapter.LineNueva()

        Me.Close()

    End Sub
    Public Sub NuevaLienea()
        Dim Siguientedetalle As String = My.Forms.FrmNotasEntrega.NotasEntregaDetalleTableAdapter.SiguienteDetalleNotaEntrega(My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text)
        Dim idNotaentrega As String = My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text
        Dim codigo As String = My.Forms.FrmNotasEntrega.Id_ProyectoTextBox.Text & "-" & Me.TextBox1.Text
        Dim CantidadPendiente As Double = 1
        Dim Idherraje As String = Me.TextBox1.Text
        Dim Cantidad As Double = CantidadPendiente
        Dim Precio As Double = 0
        Dim total As Double = Cantidad * Precio
        Dim presupuesto As String = My.Forms.FrmNotasEntrega.Id_PresupuestoTextBox.Text


        My.Forms.FrmNotasEntrega.NotasEntregaDetalleTableAdapter.AgregarDetalle(Siguientedetalle, idNotaentrega, Idherraje, Cantidad, Precio, total, codigo, presupuesto)
        My.Forms.FrmNotasEntrega.UnionSubarticulosHerrajesTableAdapter.Fill(My.Forms.FrmNotasEntrega.DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes)
        My.Forms.FrmNotasEntrega.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(My.Forms.FrmNotasEntrega.DsNotasEntregaDetalle.NotasEntregaDetalle, My.Forms.FrmNotasEntrega.Id_Nota_EntregaTextBox.Text)

        My.Forms.FrmNotasEntrega.NotasEntregaDetalleBindingSource.MoveLast()
        My.Forms.FrmNotasEntrega.NotasEntregaDetalleDataGridView.CurrentCell = My.Forms.FrmNotasEntrega.NotasEntregaDetalleDataGridView.Rows(My.Forms.FrmNotasEntrega.NotasEntregaDetalleDataGridView.RowCount - 1).Cells(3)
        Me.Validate()
        Me.LieneasEntregaBindingSource.AddNew()
        Me.TableAdapterManager.UpdateAll(Me.DsLineasEntraga)
        Dim Siguiente As String = Me.LieneasEntregaTableAdapter.LineNueva()

        Me.Close()

    End Sub
    Private Sub LieneasEntregaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.LieneasEntregaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsLineasEntraga)

    End Sub

    Private Sub FrmNuevaLinea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.LieneasEntregaTableAdapter.Fill(Me.DsLineasEntraga.LieneasEntrega)
        Me.TextBox1.Enabled = False


        Me.Button1.Enabled = False

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Me.TextBox1.Text <> "" Then
            Me.Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.LieneasEntregaTableAdapter.Nuevodetalle(Me.TextBox1.Text, Me.TextBox2.Text)

        NuevaLienea()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class