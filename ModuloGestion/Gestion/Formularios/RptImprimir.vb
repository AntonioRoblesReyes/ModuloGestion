Public Class RptImprimir
    Sub ImprimirPagos()
        Try
            ' Obtener el IdPresupuesto del formulario FrmPresupuestos
            Dim IdPresupuesto As String = My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text

            ' Llenar el dataset con los datos necesarios
            Me.PresupuestoTableAdapter.FillByIPresupuesto(DsPresuImprir.Presupuesto, IdPresupuesto)
            Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(DsPresuImprir.PresupuestoDetalle, IdPresupuesto)
            Me.ArticulosTableAdapter.Fill(DsPresuImprir.Articulos)

            ' Crear un objeto de informe Crystal Reports
            Dim rpt As New CrysEstudioAvancesPrespuestos

            ' Establecer el origen de datos del informe
            rpt.SetDataSource(DsPresuImprir)

            ' Mostrar el informe en el CrystalReportViewer
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir durante la impresión
            MessageBox.Show("Error al imprimir el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub ImprimirEstadoDetalle()
        Me.EmpresasTableAdapter.Fill(Me.DsPresuImprir.Empresas)
        Me.ProyectosTableAdapter.Fill(Me.DsPresuImprir.Proyectos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresuImprir.PresupuestoDetalle)
        Me.ArticulosTableAdapter.Fill(Me.DsPresuImprir.Articulos)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresuImprir.Presupuesto)
        Me.PresupuestoTableAdapter.FillByIPresupuesto(Me.DsPresuImprir.Presupuesto, My.Forms.FrmEjecutadoPresupuesto.Label1.Text)
        'MsgBox(My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryEsPr
        rpt.SetDataSource(DsPresuImprir)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Sub ImprimirDesdeClientes()
        Me.EmpresasTableAdapter.Fill(Me.DsPresuImprir.Empresas)
        Me.ProyectosTableAdapter.Fill(Me.DsPresuImprir.Proyectos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresuImprir.PresupuestoDetalle)
        Me.ArticulosTableAdapter.Fill(Me.DsPresuImprir.Articulos)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresuImprir.Presupuesto)
        Dim Presupuesto As String = My.Forms.FrmCliente.DsPresupuestos.Presupuesto(My.Forms.FrmCliente.PresupuestoBindingSource.Position).Id_Presupuesto
        Me.PresupuestoTableAdapter.FillByIPresupuesto(Me.DsPresuImprir.Presupuesto, Presupuesto)
        Dim rpt As New CryPresupu
        rpt.SetDataSource(DsPresuImprir)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Sub Proforma()
        Me.ProyectosTableAdapter.Fill(Me.DsPresuImprir.Proyectos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresuImprir.PresupuestoDetalle)
        Me.ArticulosTableAdapter.Fill(Me.DsPresuImprir.Articulos)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresuImprir.Presupuesto)
        Me.PresupuestoTableAdapter.FillByIPresupuesto(Me.DsPresuImprir.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryProforma
        rpt.SetDataSource(DsPresuImprir)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
    Sub ImprimirDesdeProyecto()
        Me.EmpresasTableAdapter.Fill(Me.DsPresuImprir.Empresas)
        Me.ProyectosTableAdapter.Fill(Me.DsPresuImprir.Proyectos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresuImprir.PresupuestoDetalle)
        Me.ArticulosTableAdapter.Fill(Me.DsPresuImprir.Articulos)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresuImprir.Presupuesto)
        Dim Presupuesto As String = My.Forms.FrmProyectos.DsPresupuestos.Presupuesto(My.Forms.FrmProyectos.PresupuestoBindingSource.Position).Id_Presupuesto
        Me.PresupuestoTableAdapter.FillByIPresupuesto(Me.DsPresuImprir.Presupuesto, Presupuesto)
        Dim rpt As New CryPresupu
        rpt.SetDataSource(DsPresuImprir)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Sub ImprimirPresupuesto()
        Me.EmpresasTableAdapter.Fill(Me.DsPresuImprir.Empresas)
        Me.ProyectosTableAdapter.Fill(Me.DsPresuImprir.Proyectos)
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresuImprir.PresupuestoDetalle)
        Me.ArticulosTableAdapter.Fill(Me.DsPresuImprir.Articulos)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresuImprir.Presupuesto)
        Me.PresupuestoTableAdapter.FillByIPresupuesto(Me.DsPresuImprir.Presupuesto, My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        'MsgBox(My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text)
        Dim rpt As New CryPresupu
        rpt.SetDataSource(DsPresuImprir)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub RptImprimir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsPresuImprir.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.PresupuestoDetalle' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoDetalleTableAdapter.Fill(Me.DsPresuImprir.PresupuestoDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.DsPresuImprir.Empresas)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsPresuImprir.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsPresuImprir.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsPresuImprir.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsPresuImprir.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsPresuImprir.Empresas' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTableAdapter.Fill(Me.DsPresuImprir.Empresas)


    End Sub




    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresuImprir)

    End Sub

    Private Sub PresupuestoBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresuImprir)

    End Sub


End Class