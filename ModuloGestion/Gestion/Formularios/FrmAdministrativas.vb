Public Class FrmAdministrativas
    Sub ActulizarTasaCompras()

    End Sub
    Private Sub TasaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TasaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTasa)

    End Sub

    Private Sub FrmAdministrativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)

    End Sub

    Private Sub BrnActulizarTasaCompra_Click(sender As Object, e As EventArgs)

        Me.CompraMaterialesDetalleTableAdapter.Fill(Me.DsCompras.CompraMaterialesDetalle)

        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)

        Dim regitros As Integer = Me.TasaDataGridView.Rows.Count


        Me.TasaBindingSource.MoveFirst()

        Dim cuenta As Integer
        For cuenta = 0 To regitros - 1

            Dim compra As Double = Me.TasaDataGridView.CurrentRow.Cells(1).Value
            Dim venta As Double = Me.TasaDataGridView.CurrentRow.Cells(2).Value



            If compra = 0 Then

                MsgBox(compra)
                Me.TasaBindingSource.MovePrevious()
                Dim Ncompra As Double = Me.TasaDataGridView.CurrentRow.Cells(1).Value
                Dim Nventa As Double = Me.TasaDataGridView.CurrentRow.Cells(2).Value

                Me.TasaBindingSource.MoveNext()
                Me.TasaDataGridView.CurrentRow.Cells(1).Value = Ncompra
                Me.TasaDataGridView.CurrentRow.Cells(2).Value = Nventa
                Me.Validate()
                Me.TasaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsTasa)


                MsgBox("actulizado")
            End If
            Me.TasaBindingSource.MoveNext()
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fecha As Date = Me.MonthCalendar1.SelectionStart
            Dim Compra As Double = Convert.ToDouble(TextBox1.Text)
            Dim Venta As Double = Convert.ToDouble(TextBox2.Text)
            Dim media As Double = Math.Round((Compra + Venta) / 2, 4)

            Me.TasaTableAdapter.Nueva(fecha, Compra, Venta, media)
            Me.TasaTableAdapter.Fill(DsTasa.Tasa)
        Catch ex As Exception
            ' Muestra el mensaje de la excepción y la pila de llamadas.
            MsgBox($"Error: {ex.Message}{Environment.NewLine}{ex.StackTrace}")
        End Try


    End Sub

    Private Sub TasaDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TasaDataGridView.CellEndEdit
        Me.Validate()
        Me.TasaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTasa)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.bancentral.gov.do/a/d/2538-mercado-cambiario")
    End Sub
End Class