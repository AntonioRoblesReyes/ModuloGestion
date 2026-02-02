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


    Private Sub FacturaMontajeDataGridView_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles FacturaMontajeDataGridView.CellClick

        ' ===== Validaciones básicas =====
        If e.RowIndex < 0 Then Exit Sub
        If FacturaMontajeBindingSource.Current Is Nothing Then Exit Sub

        Dim fila = DirectCast(FacturaMontajeBindingSource.Current, DataRowView)
        Dim factura = DirectCast(fila.Row, DsPagosMontaje.FacturaMontajeRow)

        Dim Proyecto As String = factura.Id_Proyecto
        Dim presupuesto As String = factura.Id_Presupuesto
        Dim EmpresaMontaje As String = factura.IdEmpresaMontaje
        Dim IdFactura As String = factura.IdFacturaMontaje

        ' ===== Empresa =====
        EmpresasContratadasMontajeTableAdapter.FillById(
        DsPagosMontaje.EmpresasContratadasMontaje, EmpresaMontaje)

        If EmpresasContratadasMontajeBindingSource.Count > 0 Then
            Label10.Text =
            DsPagosMontaje.EmpresasContratadasMontaje(0).RazonSocial
        Else
            Label10.Text = ""
        End If

        ' ===== Presupuesto =====
        PresupuestoTableAdapter.FillByIdPresupuesto(
        DsPresupuestos.Presupuesto, presupuesto)

        If PresupuestoBindingSource.Count > 0 Then
            Label8.Text =
            DsPresupuestos.Presupuesto(0).Descripcion_Presupuesto
        Else
            Label8.Text = ""
        End If

        ' ===== Proyecto =====
        ProyectosTableAdapter.FillByProyecto(
        DsProyectos.Proyectos, Proyecto)

        If ProyectosBindingSource.Count > 0 Then
            Label9.Text =
            DsProyectos.Proyectos(0).Nombre_Proyecto
        Else
            Label9.Text = ""
        End If

        ' ===== Botones =====
        Dim nombreColumna As String =
        FacturaMontajeDataGridView.Columns(e.ColumnIndex).Name

        Select Case nombreColumna

            Case "Modificar"
                With My.Forms.FrmFacturaMontajeEditar
                    .IdFacturaTextBox.Text = IdFactura
                    .LblPresupuesto.Text = presupuesto
                    .LblProyecto.Text = Proyecto
                    .IdEmpresaMontajeTextBox.Text = EmpresaMontaje
                    .ModificarFactura()
                End With

            Case "Imprimir"
                With My.Forms.ImpPagoMomtaje
                    .Label1.Text = IdFactura
                    .ImprimirFacturaMontaje()

                End With
            Case "FacturaNcf"
                With My.Forms.ImpPagoMomtaje
                    .Label1.Text = IdFactura
                    .ImprimirFacturaNfc()

                End With

        End Select

        ' ===== Detalle y pagos =====
        FacturaMontajeDetalleTableAdapter.FillByIdFactura(
        DsPagosMontaje.FacturaMontajeDetalle, IdFactura)

        PagoMontajeDetalleTableAdapter.FillByIdFactura(
        DsPagosMontaje.PagoMontajeDetalle, IdFactura)

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
    Private Sub txtFiltro_TextChanged(
    sender As Object,
    e As EventArgs
) Handles TxtFiltro.TextChanged

        Dim filtro As String = TxtFiltro.Text.Trim()

        If filtro = "" Then
            ' Quitar filtro
            FacturaMontajeBindingSource.RemoveFilter()
        Else
            ' Filtrar por proyecto
            FacturaMontajeBindingSource.Filter =
            "Id_Proyecto LIKE '%" & filtro.Replace("'", "''") & "%'"
        End If

        'SumarValores()

    End Sub

End Class