Public Class FrmAnexrMediaCompraMaterial

    Private Sub MaterialesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.MaterialesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)

    End Sub


    Private Sub MaterialesBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles MaterialesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MaterialesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)

    End Sub

    Private Sub FrmAnexrMediaCompraMaterial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialMedidadCompra.MaterialMedidaCompra' Puede moverla o quitarla según sea necesario.
        Me.MaterialMedidaCompraTableAdapter.Fill(Me.DsMaterialMedidadCompra.MaterialMedidaCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompraMateriales.MediasCompraMateriales' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsMaterial.Materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)
        Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, Id_MaterialTextBox.Text)
    End Sub

    Private Sub Id_MaterialTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Id_MaterialTextBox.TextChanged
        Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, Id_MaterialTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Id_MedidaComboBox.SelectedValue <> 0 Then
            Try
                Dim IdMaterial As String = Me.Id_MaterialTextBox.Text
                Dim idmedida As String = CStr(Me.Id_MedidaComboBox.SelectedValue)
                Dim Detalle As String = IdMaterial & "-" & idmedida
                Me.MaterialMedidaCompraTableAdapter.Anexar(Detalle, IdMaterial, idmedida)

                Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, Id_MaterialTextBox.Text)
            Catch ex As Exception

                MsgBox("La medida ya se ecuentra agregada")
            End Try

        Else
            MsgBox("Debe eljir una medida")
        End If
    End Sub

    Private Sub MaterialMedidaCompraDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles MaterialMedidaCompraDataGridView.RowsRemoved
        Me.Validate()
        Me.MaterialMedidaCompraBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsMaterialMedidadCompra)
    End Sub
End Class