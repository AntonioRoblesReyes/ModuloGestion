Public Class FrmFacturaMontajeResumen

    Sub SumarValores()
        Dim Subtotal As Double
        Dim Impuesto As Double
        Dim Total As Double
        Dim Pagado As Double
        Dim Pendiente As Double

        'Dim Col As Integer = Me.PagoMontajeDataGridView.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.FacturaMontajeDataGridView.Rows
            Subtotal += Val(row.Cells(5).Value)
            Impuesto += Val(row.Cells(6).Value)
            Total += Val(row.Cells(7).Value)
            Pagado += Val(row.Cells(8).Value)
            Pendiente += Val(row.Cells(9).Value)
        Next
        Label1.Text = Format(Subtotal, "#,##0.00")
        Label2.Text = Format(Impuesto, "#,##0.00")
        Label3.Text = Format(Total, "#,##0.00")
        Label4.Text = Format(Pagado, "#,##0.00")
        Label5.Text = Format(Pendiente, "#,##0.00")






    End Sub
    Sub FmProyecto()

        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)

        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)

        Try
            Dim Proyecto As String = My.Forms.FrmProyectos.TxtIdProyecto.Text
            Me.ResumenComprasProyectoTableAdapter.FillByIdProyecto(Me.DsCompras.ResumenComprasProyecto, Proyecto)

            FacturaMontajeTableAdapter.FillByIdProyrcto(DsPagosMontaje.FacturaMontaje, Proyecto)
            Me.FacturaMontajeDetalleDataGridView.Visible = True
            Show()
            SumarValores()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub Todos()
        Me.FacturaMontajeTableAdapter.Fill(Me.DsPagosMontaje.FacturaMontaje)
        Show()
        SumarValores()
    End Sub

    Private Sub FrmFacturaMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.EmpresasContratadasMontaje' Puede moverla o quitarla según sea necesario.
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)



    End Sub



    Private Sub FacturaMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDataGridView.CellClick
        Dim Proyecto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Proyecto
        Dim presupuesto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Presupuesto
        Dim EmpresaMontaje As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdEmpresaMontaje
        EmpresasContratadasMontajeTableAdapter.FillById(DsPagosMontaje.EmpresasContratadasMontaje, EmpresaMontaje)
        Label10.Text = Me.DsPagosMontaje.EmpresasContratadasMontaje(EmpresasContratadasMontajeBindingSource.Position).RazonSocial
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, presupuesto)
        Me.Label8.Text = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descripcion_Presupuesto
        Me.ProyectosTableAdapter.FillByProyecto(Me.DsProyectos.Proyectos, Proyecto)
        Me.Label9.Text = Me.DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Nombre_Proyecto
        Dim IdFactura As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje
        If e.ColumnIndex = 11 Then

            My.Forms.FrmFacturaMontajeEditar.IdFacturaTextBox.Text = IdFactura
            My.Forms.FrmFacturaMontajeEditar.LblPresupuesto.Text = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Presupuesto
            My.Forms.FrmFacturaMontajeEditar.LblProyecto.Text = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Proyecto
            My.Forms.FrmFacturaMontajeEditar.IdEmpresaMontajeTextBox.Text = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdEmpresaMontaje

            My.Forms.FrmFacturaMontajeEditar.ModificarFactura()
        ElseIf e.ColumnIndex = 12 Then
            My.Forms.ImpPagoMomtaje.Label1.Text = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje
            My.Forms.ImpPagoMomtaje.ImprimirFacturaMontaje()

        End If
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, IdFactura)
        Me.PagoMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.PagoMontajeDetalle, IdFactura)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FacturaMontajeBindingSource.MoveFirst()
        'ITotal toma el valor del numero de registros k tiene latabla
        Dim i As Integer
        Dim iTotal As Integer = FacturaMontajeDataGridView.Rows.Count
        For i = 0 To iTotal - 1
            Dim IdFactura As String = Me.FacturaMontajeDataGridView.CurrentRow.Cells(0).Value

            Me.PagoMontajeDetalleTableAdapter.TotalPagodoFactura(IdFactura)
            Try
                Dim TotalPagado As Double = Me.PagoMontajeDetalleTableAdapter.TotalPagodoFactura(IdFactura)
                Dim PagadoEnFactura As Double = Me.FacturaMontajeDataGridView.CurrentRow.Cells(8).Value
                If PagadoEnFactura <> TotalPagado Then
                    Me.FacturaMontajeDataGridView.CurrentRow.Cells(8).Value = TotalPagado
                    Me.FacturaMontajeDataGridView.CurrentRow.Cells(9).Value = Me.FacturaMontajeDataGridView.CurrentRow.Cells(7).Value - TotalPagado
                    MsgBox("se cambio el registro")
                End If
            Catch ex As Exception
                Dim TotalPagado As Double = 0
                Dim PagadoEnFactura As Double = Me.FacturaMontajeDataGridView.CurrentRow.Cells(8).Value
                If PagadoEnFactura <> TotalPagado Then
                    Me.FacturaMontajeDataGridView.CurrentRow.Cells(8).Value = TotalPagado
                    Me.FacturaMontajeDataGridView.CurrentRow.Cells(9).Value = Me.FacturaMontajeDataGridView.CurrentRow.Cells(7).Value - TotalPagado
                    MsgBox("se cambio el registro")
                End If

            End Try
            Me.Validate()
            Me.FacturaMontajeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsPagosMontaje)

            Me.FacturaMontajeBindingSource.MoveNext()
        Next

    End Sub

End Class