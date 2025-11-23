Public Class ImpKitArticulo
    Sub FiltraPresupuesto()
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsKitArticulos.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.Herrajes' Puede moverla o quitarla según sea necesario.
        Me.HerrajesTableAdapter.Fill(Me.DsKitArticulos.Herrajes)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.PresupuestoDetalleHerrajes' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleHerrajesTableAdapter.Fill(Me.DsKitArticulos.PresupuestoDetalleHerrajes)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsKitArticulos.SubArticulos)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.PresupuestoDetalle' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsKitArticulos.PresupuestoDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsKitArticulos.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.ArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsKitArticulos.ArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsKitArticulos.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsKitArticulos.Articulos)
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsKitArticulos.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryKitDetalle
        rpt.SetDataSource(DsKitArticulos)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsKitArticulos)

    End Sub

    Private Sub ImpKitArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class