Public Class FrmEmpresaMontaje
    Sub Sumar()
        Dim Facturado As Double
        Dim Pagado As Double
        Dim Pendiente As Double

        'Dim Col As Integer = Me.PagoMontajeDataGridView.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.FacturaMontajeDataGridView.Rows
            Facturado += Val(row.Cells(5).Value)
            Pagado += Val(row.Cells(6).Value)
            Pendiente += Val(row.Cells(7).Value)
        Next
        Label2.Text = Format(Facturado, "#,##0.00")
        Label3.Text = Format(Pagado, "#,##0.00")
        Label5.Text = Format(Pendiente, "#,##0.00")

        Dim Pago As Double
        Dim Asignado As Double
        Dim PendienteAsignar As Double

        For Each row As DataGridViewRow In Me.PagoMontajeDataGridView.Rows
            Pago += Val(row.Cells(2).Value)
            Asignado += Val(row.Cells(3).Value)
            PendienteAsignar += Val(row.Cells(4).Value)
        Next
        Label11.Text = Format(Pago, "#,##0.00")
        Label9.Text = Format(Asignado, "#,##0.00")
        Label7.Text = Format(PendienteAsignar, "#,##0.00")




    End Sub
    Sub Cargar()
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.Show()
        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, IdEmpresaMontajeTextBox.Text)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, IdEmpresaMontajeTextBox.Text)
        Sumar()
    End Sub
    Private Sub EmpresasContratadasMontajeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresasContratadasMontajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresasContratadasMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmEmpresaMontaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsArticulos.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)

        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsProyectos.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)


    End Sub

    Private Sub EmpresasContratadasMontajeBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles EmpresasContratadasMontajeBindingNavigator.RefreshItems
        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, IdEmpresaMontajeTextBox.Text)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, IdEmpresaMontajeTextBox.Text)
        Sumar()
    End Sub

    Private Sub PagoMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PagoMontajeDataGridView.CellClick
        Dim IdPago As String = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
        Me.PagoMontajeDetalleTableAdapter.FillByIdPago(Me.DsPagosMontaje.PagoMontajeDetalle, IdPago)

    End Sub

    Private Sub FacturaMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDataGridView.CellClick
        Dim IdFactura As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje
        Dim Idpresupuesto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Presupuesto
        Me.PagoMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.PagoMontajeDetalle, IdFactura)
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, Idpresupuesto)
        Me.Label18.Text = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descripcion_Presupuesto
        Dim Proyecto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
        Me.ProyectosTableAdapter.FillByProyecto(DsProyectos.Proyectos, Proyecto)
        Me.Label17.Text = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Nombre_Proyecto
        Dim IdCliente As String = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Id_Fiscal
        Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, IdCliente)
        Me.Label14.Text = DsClientes.Clientes(Me.ClientesBindingSource.Position).Nombre_Cliente
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontajeDetalle, IdFactura)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnResumenFactura.Click
        My.Forms.ImpPagoMomtaje.Label1.Text = IdEmpresaMontajeTextBox.Text
        My.Forms.ImpPagoMomtaje.ImprimirResumenFactura()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnResumenPagos.Click
        My.Forms.ImpPagoMomtaje.Label1.Text = IdEmpresaMontajeTextBox.Text
        My.Forms.ImpPagoMomtaje.ImprimirResumenPagos()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.FrmNuevaEmpresaMontaje.Close()
        My.Forms.FrmNuevaEmpresaMontaje.Nueva()
    End Sub
    Private Sub BtnModificarFactura_Click(sender As Object, e As EventArgs) Handles BtnModificarFactura.Click
        Try
            ' Validar que haya datos
            If FacturaMontajeBindingSource.Position < 0 OrElse
               DsPagosMontaje.FacturaMontaje.Count = 0 Then
                MessageBox.Show("No hay factura seleccionada.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Tomar valores
            Dim fila = DsPagosMontaje.FacturaMontaje(FacturaMontajeBindingSource.Position)

            Dim idfactura As String = fila.IdFacturaMontaje
            Dim presupuesto As String = fila.Id_Presupuesto
            Dim proyecto As String = fila.Id_Proyecto
            Dim empresaMontaje As String = fila.IdEmpresaMontaje

            ' Cargar en formulario
            With My.Forms.FrmFacturaMontajeEditar
                .IdFacturaTextBox.Text = idfactura
                .LblPresupuesto.Text = presupuesto
                .LblProyecto.Text = proyecto
                .IdEmpresaMontajeTextBox.Text = empresaMontaje
                .ModificarFactura()
                .Show()
            End With

        Catch ex As Exception
            MessageBox.Show("Error al modificar factura: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class