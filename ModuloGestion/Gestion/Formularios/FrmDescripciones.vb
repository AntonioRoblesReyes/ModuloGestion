Public Class FrmDescripciones

    Private Sub DescripcionesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DescripcionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDescripciones)

    End Sub

    Private Sub FrmDescripciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion
        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)



    End Sub


    Private Sub BtnNuevoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoGrupo.Click

    End Sub

    Private Sub BtnNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoDetalle.Click
        Dim Descripcion As String

        Descripcion = Me.DsDescripciones.Descripciones(Me.DescripcionesBindingSource.Position).Id_descripcion


        Me.DsDescripcionesdetalle.Tables(0).Rows.Add()
        Me.Update()
        Me.Validate()
        Me.DescripcionesDetalleBindingSource.EndEdit()

        Dim unused As DataGridViewCell = Me.DescripcionesDetalleDataGridView.CurrentCell
        Dim cell As DataGridViewCell = Me.DescripcionesDetalleDataGridView.Rows(Me.DescripcionesDetalleDataGridView.RowCount - 1).Cells(1)
        Me.DescripcionesDetalleDataGridView.CurrentCell = cell


    End Sub

    Private Sub DescripcionesDetalleDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DescripcionesDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.DescripcionesDetalleBindingSource.EndEdit()
        Me.DescripcionesDetalleTableAdapter.Update(Me.DsDescripcionesdetalle)
    End Sub

    Private Sub DescripcionesDetalleDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DescripcionesDetalleDataGridView.RowsRemoved
        Try
            Me.Validate()
            Me.DescripcionesDetalleBindingSource.EndEdit()
            Me.DescripcionesDetalleTableAdapter.Update(Me.DsDescripcionesdetalle)
        Catch ex As Exception
            MsgBox("No se puede eliminar" & vbCrLf & "Ya tiene asigando un registro")
        End Try

    End Sub

    Private Sub DescripcionesDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DescripcionesDataGridView.CellEndEdit
        Try
            Me.Validate()
            Me.DescripcionesBindingSource.EndEdit()
            Me.DescripcionesTableAdapter.Update(Me.DsDescripciones)
        Catch ex As Exception
            MsgBox("Introduce una descripcion")
        End Try

    End Sub

    Private Sub DescripcionesDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DescripcionesDataGridView.RowsRemoved
        Try
            Me.Validate()
            Me.DescripcionesBindingSource.EndEdit()
            Me.DescripcionesTableAdapter.Update(Me.DsDescripciones)
        Catch ex As Exception
            MsgBox("No se puede eliminar" & vbCrLf & "Ya tiene asigando un registro")
        End Try


    End Sub
End Class