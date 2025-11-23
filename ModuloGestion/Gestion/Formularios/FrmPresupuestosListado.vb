Public Class FrmPresupuestosListado
    Sub Datos()
        Try


            Dim filas As Integer = Me.PresupuestoDataGridView.RowCount
            If filas <> 0 Then


                Me.PresupuestoBindingSource.MoveFirst()



                Dim f As Integer
                For f = 0 To filas - 1

                    If Me.PresupuestoDataGridView.CurrentRow.Cells("Moneda").Value = "RD$" Then
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Subtotal").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(13).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Impuesto").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(14).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Total").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(15).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Pagado").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(16).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Pendiente").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(17).Value

                    ElseIf Me.PresupuestoDataGridView.CurrentRow.Cells("Moneda").Value = "US$" Then
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Subtotal").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(7).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Impuesto").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(8).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Total").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(9).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Pagado").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(10).Value
                        Me.PresupuestoDataGridView.CurrentRow.Cells("Pendiente").Value = Me.PresupuestoDataGridView.CurrentRow.Cells(11).Value
                    Else
                        MsgBox(Me.PresupuestoDataGridView.CurrentRow.Cells("Moneda").Value)
                    End If
                    Me.PresupuestoBindingSource.MoveNext()
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PresupuestoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestos)

    End Sub

    Private Sub FrmPresupuestosListado_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub FrmPresupuestosListado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsClientes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        Datos()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.TextChanged
        Dim estado As String = Me.ComboBox1.Text
        Me.PresupuestoTableAdapter.FillBySituacion(Me.DsPresupuestos.Presupuesto, estado)
        Datos()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        'Dim cliente As String = Me.ComboBox2.SelectedValue
        'MsgBox(cliente)
        'Me.PresupuestoTableAdapter.FillByIdCliente(Me.DsPresupuestos.Presupuesto, cliente)
        'Datos()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        Datos()
    End Sub

    Private Sub PresupuestoDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        If e.ColumnIndex = 23 Then
            Dim presupuesto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto
            'MsgBox(presupuesto)
            My.Forms.FrmPresupuestos.PorPresupuesto()

        End If
    End Sub
End Class