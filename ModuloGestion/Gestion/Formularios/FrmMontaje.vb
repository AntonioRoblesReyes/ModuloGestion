Imports System.Math
Public Class FrmMontaje

    Sub Inicio()
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Dim proyecto As String = My.Forms.FrmProyectos.TxtIdProyecto.Text


        Me.Show()
        Try


            Me.PresupuestoDetalleTableAdapter.FillByPagoMontajeEstudio(Me.DsPresupuestoDetalle.PresupuestoDetalle, TextBox1.Text)
            Dim registro As Integer = Me.PresupuestoDetalleDataGridView.RowCount
            If registro <> 0 Then
                Me.PresupuestoDetalleBindingSource.MoveFirst()

                Dim I As Integer

                For I = 0 To registro - 1
                    Dim Precio As Double = Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(4).Value
                    Dim Tasa As Double = Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(6).Value
                    If Precio = 0 Then
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(9).Value = 0
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(10).Value = 0
                    ElseIf Tasa = 0 Then
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(9).Value = 0
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(10).Value = 0
                    Else
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(9).Value = Round((Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(4).Value * Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(6).Value) / 10, 0) * 10
                        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(10).Value = Round((Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(4).Value * Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(6).Value) / 10, 0) * 10 * Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value
                    End If

                    Me.PresupuestoDetalleBindingSource.MoveNext()
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub PresupuestoDetalleBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestoDetalleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDetalle)

    End Sub

    Private Sub FrmMontaje_FormClosing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)


    End Sub


    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Dim cantidad As Double = Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(3).Value
        Dim Precioacordado As Double = Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(11).Value
        MsgBox(cantidad)
        MsgBox(Precioacordado)
        Me.PresupuestoDetalleDataGridView.CurrentRow.Cells(12).Value = cantidad * Precioacordado
    End Sub

    Private Sub FrmMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class