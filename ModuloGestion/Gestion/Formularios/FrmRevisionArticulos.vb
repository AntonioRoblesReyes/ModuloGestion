Public Class FrmRevisionArticulos
    Sub FiltrarDetallePresupuesto()
        Dim Articulo As String = Me.DsArticulosAprobados.ArticulosAprobados(Me.ArticulosAprobadosBindingSource.Position).Articulo
        Me.PresupuestoDetalleTableAdapter.FillByProyectoArticulo(Me.DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmProyectos.TxtIdProyecto.Text, Articulo)
    End Sub
    Sub PorProyecto()
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
        Me.ArticulosAprobadosTableAdapter.FillByIdProyecto(Me.DsArticulosAprobados.ArticulosAprobados, My.Forms.FrmProyectos.TxtIdProyecto.Text)
        Dim Articulo As String = Me.DsArticulosAprobados.ArticulosAprobados(Me.ArticulosAprobadosBindingSource.Position).Articulo
        Me.PresupuestoDetalleTableAdapter.FillByProyectoArticulo(Me.DsPresupuestoDetalle.PresupuestoDetalle, My.Forms.FrmProyectos.TxtIdProyecto.Text, Articulo)
    End Sub
    Private Sub FrmRevisionArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'DsArticulos.Articulos' Puede moverla o quitarla según sea necesario.
        '
        ''TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDetalle.PresupuestoDetalle' Puede moverla o quitarla según sea necesario.
        'Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresupuestoDetalle.PresupuestoDetalle)
        ''TODO: esta línea de código carga datos en la tabla 'DsArticulosAprobados.ArticulosAprobados' Puede moverla o quitarla según sea necesario.
        'Me.ArticulosAprobadosTableAdapter.Fill(Me.DsArticulosAprobados.ArticulosAprobados)

    End Sub


    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsPresupuestoDetalle)

    End Sub


    Private Sub ArticulosAprobadosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArticulosAprobadosDataGridView.CellClick
        FiltrarDetallePresupuesto()
    End Sub

    Private Sub BtnEstudioPrecios_Click(sender As System.Object, e As System.EventArgs) Handles BtnEstudioPrecios.Click
        My.Forms.EstudioPrecios.Close()
        My.Forms.EstudioPrecios.Show()
        My.Forms.EstudioPrecios.DesdeProyecto()
    End Sub
    Private Sub FrmRevisionArticulos_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)

    End Sub


End Class