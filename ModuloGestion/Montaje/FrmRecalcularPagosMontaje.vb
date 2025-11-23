Public Class Pasignado
    Sub SPagoDetalle()
        Dim dasignado As Double = 0

        For Each row As DataGridViewRow In PagoMontajeDetalleDataGridView.Rows
            dasignado += Val(row.Cells(3).Value)
        Next
        Me.Label4.Text = Format(dasignado, "#,###,##0.00")

    End Sub
    Sub Sumas()
        Dim PPagado As Double = 0
        Dim Pasignado As Double = 0
        Dim PPendiente As Double = 0

        Dim dasignado As Double = 0

        Dim FSubtotal As Double = 0
        Dim Fitebis As Double = 0
        Dim Ftotal As Double = 0
        Dim Fpagado As Double = 0
        Dim FPendiente As Double = 0

        For Each row As DataGridViewRow In PagoMontajeDataGridView.Rows

            PPagado += Val(row.Cells(2).Value)
            Pasignado += Val(row.Cells(3).Value)
            PPendiente += Val(row.Cells(4).Value)

        Next
        Me.Label1.Text = Format(PPagado, "#,###,##0.00")
        Me.Label2.Text = Format(Pasignado, "#,###,##0.00")
        Me.Label3.Text = Format(PPendiente, "#,###,##0.00")


        For Each row As DataGridViewRow In PagoMontajeDetalleDataGridView.Rows
            dasignado += Val(row.Cells(3).Value)
        Next
        Me.Label4.Text = Format(dasignado, "#,###,##0.00")


        For Each row As DataGridViewRow In FacturaMontajeDataGridView.Rows
            FSubtotal += Val(row.Cells(1).Value)
            Fitebis += Val(row.Cells(2).Value)
            Ftotal += Val(row.Cells(3).Value)
            Fpagado += Val(row.Cells(4).Value)
            FPendiente += Val(row.Cells(5).Value)
        Next
        Me.Label8.Text = Format(FSubtotal, "#,###,##0.00")
        Me.Label9.Text = Format(Fitebis, "#,###,##0.00")
        Me.Label10.Text = Format(Ftotal, "#,###,##0.00")
        Me.Label11.Text = Format(Fpagado, "#,###,##0.00")
        Me.Label12.Text = Format(FPendiente, "#,###,##0.00")



    End Sub
    Private Sub PagoMontajeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PagoMontajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PagoMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmRecalcularPagosMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.FacturaMontaje' Puede moverla o quitarla según sea necesario.
        Me.FacturaMontajeTableAdapter.Fill(Me.DsPagosMontaje.FacturaMontaje)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontajeDetalle' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.PagoMontaje' Puede moverla o quitarla según sea necesario.
        Me.PagoMontajeTableAdapter.Fill(Me.DsPagosMontaje.PagoMontaje)
        Sumas()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)
        Me.PagoMontajeBindingSource.MoveFirst()
        'ITotal toma el valor del numero de registros k tiene latabla
        Dim i As Integer
        Dim iTotal As Integer = PagoMontajeDetalleDataGridView.Rows.Count
        For i = 0 To iTotal - 1
            Dim Pago As String = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
            Me.PagoMontajeDetalleTableAdapter.FillByIdPago(Me.DsPagosMontaje.PagoMontajeDetalle, Pago)
            SPagoDetalle()
            Dim Asignado As Double = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).Asignado
            If Asignado <> Label4.Text Then
                MsgBox("error")
            End If
            Me.PagoMontajeBindingSource.MoveNext()
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PagoMontajeDetalleTableAdapter.Fill(Me.DsPagosMontaje.PagoMontajeDetalle)
        Me.FacturaMontajeBindingSource.MoveFirst()
        'ITotal toma el valor del numero de registros k tiene latabla
        Dim i As Integer
        Dim iTotal As Integer = FacturaMontajeDataGridView.Rows.Count
        For i = 0 To iTotal - 1
            Dim Factura As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje
            Me.PagoMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.PagoMontajeDetalle, Factura)
            SPagoDetalle()
            Dim pagado As Double = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Pagado
            Dim asignado As Double = Label4.Text

            If pagado <> asignado Then
                MsgBox(pagado & "---" & asignado)
            End If


            Me.FacturaMontajeBindingSource.MoveNext()
        Next
    End Sub
End Class