Public Class FrmVerNotasEntregas

    Private Sub NotasEntregaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.NotasEntregaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)


    End Sub
    Sub VerNotasEntraga()
        NotasEntregaTableAdapter.FillByIdPresupuesto(Me.DsNotasEntrega.NotasEntrega, Me.txtpresupuesto.Text)

        'Me.txtpresupuesto.Text = "Notas entrega Presupuesto " & My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text & " " & My.Forms.FrmPresupuestos.TxtDescripcion.Text
        Me.EstadoentregasTableAdapter.FillByIdPresupuesto(Me.DsEstadoEntregas.Estadoentregas, Me.txtpresupuesto.Text)

    End Sub
    Private Sub VerNotasEntregas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes' Puede moverla o quitarla según sea necesario.
        Me.UnionSubarticulosHerrajesTableAdapter.Fill(Me.DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes)

        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)

        Me.MdiParent = My.Forms.FrmGestion
        Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)
        txtpresupuesto.Visible = True
        txtempresa.Visible = False
        txtproyecto.Visible = False
        txtsiguiente.Visible = False
        Label2.Visible = False

    End Sub


    Private Sub CmdVerDetalle_Click(sender As System.Object, e As System.EventArgs) Handles CmdVerDetalle.Click

        Try
            Dim NotaEntrega As String = DsNotasEntrega.NotasEntrega(NotasEntregaBindingSource.Position).Id_Nota_Entrega
            My.Forms.FrmNotasEntrega.Close()
            My.Forms.FrmNotasEntrega.Show()
            My.Forms.FrmNotasEntrega.vernotaentrega()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub EstadoentregasDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EstadoentregasDataGridView.CellClick
        Dim codigo As String = Me.DsEstadoEntregas.Estadoentregas(Me.EstadoentregasBindingSource.Position).Codigo
        Me.NotasEntregaDetalleTableAdapter.FillByCodigo(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, codigo)
    End Sub

    Private Sub BtnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimir.Click

        My.Forms.ImprimirNotaEntrega.Close()
        My.Forms.ImprimirNotaEntrega.Show()
        My.Forms.ImprimirNotaEntrega.ImrimirNota()
    End Sub

    Private Sub BtnNuevaNotaEntrega_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevaNotaEntrega.Click


        My.Forms.FrmNotasEntrega.Close()

        My.Forms.FrmNotasEntrega.Show()
        My.Forms.FrmNotasEntrega.NuevaNotaEntrega()
    End Sub

    Private Sub NotasEntregaDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NotasEntregaDataGridView.CellClick
        Try
            Dim notaentrega As String = Me.DsNotasEntrega.NotasEntrega(Me.NotasEntregaBindingSource.Position).Id_Nota_Entrega
            Me.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, notaentrega)
        Catch ex As Exception


        End Try


    End Sub
End Class