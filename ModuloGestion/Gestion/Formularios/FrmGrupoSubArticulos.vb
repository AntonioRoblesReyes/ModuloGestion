Public Class FrmGrupoSubArticulos




    Private Sub FrGrupoSubArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsArticulosdetalle.ArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulosDetalle.SubArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)
        Me.MdiParent = My.Forms.FrmGestion
        'Me.Show()
        'TODO: esta línea de código carga datos en la tabla 'DsDescripciones.Descripciones' Puede moverla o quitarla según sea necesario.
        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)
        Dim descripcion As String = Me.DsDescripciones.Descripciones(Me.DescripcionesBindingSource.Position).Id_descripcion
        'MsgBox(descripcion)
        Me.SubArticulosTableAdapter.FillByIdGrupo(Me.DsSubArticulos.SubArticulos, descripcion)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim siguiente As String = Me.DescripcionesTableAdapter.Siguiente()
        Me.DescripcionesTableAdapter.InsertarNuevaDescripcion(siguiente)
        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)
        Me.DescripcionesTableAdapter.FillByIdDescripcion(Me.DsDescripciones.Descripciones, siguiente)

    End Sub



    Private Sub DescripcionesDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DescripcionesDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.DescripcionesDetalleBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsDescripcionesdetalle)
    End Sub

    Private Sub DescripcionesDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DescripcionesDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.DescripcionesDetalleBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsDescripcionesdetalle)
    End Sub

    Private Sub DescrpcionFamiliaSubArticulosTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DescrpcionFamiliaSubArticulosTextBox.TextChanged
        Me.Validate()
        Me.DescripcionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsDescripciones)

    End Sub



    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim siguiente As String = Me.DescripcionesTableAdapter.Siguiente()
        Me.DescripcionesTableAdapter.InsertarNuevaDescripcion(siguiente)
        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)
        Me.DescripcionesBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim siguientedetalle As String = Me.DescripcionesDetalleTableAdapter.DescripciondetalleSiguiente(IdFamilaSubArticulosTextBox.Text)
        Me.DescripcionesDetalleTableAdapter.Anexar(siguientedetalle, DescrpcionFamiliaSubArticulosTextBox.Text, IdFamilaSubArticulosTextBox.Text)
        Me.DescripcionesDetalleTableAdapter.FillByPorDescripcion(Me.DsDescripcionesdetalle.DescripcionesDetalle, IdFamilaSubArticulosTextBox.Text)
    End Sub

    Private Sub IdFamilaSubArticulosTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles IdFamilaSubArticulosTextBox.TextChanged
        Me.DescripcionesDetalleTableAdapter.FillByPorDescripcion(Me.DsDescripcionesdetalle.DescripcionesDetalle, IdFamilaSubArticulosTextBox.Text)
        Me.SubArticulosTableAdapter.FillByIdGrupo(Me.DsSubArticulos.SubArticulos, IdFamilaSubArticulosTextBox.Text)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.DescripcionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(DsDescripciones)

    End Sub

    Private Sub SubArticulosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubArticulosDataGridView.CellClick
        Dim Subarticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(DsSubArticulosDetalle.SubArticulosDetalle, Subarticulo)
        Me.ArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsArticulosdetalle.ArticulosDetalle, Subarticulo)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.CodigoTextBox.Text = TextBox1.Text + "-" + TextBox2.Text + "-" + TextBox3.Text

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SubArticulosTableAdapter.FillByIdMa(DsSubArticulos.SubArticulos, IdFamilaSubArticulosTextBox.Text, "%" & TextBox3.Text & "%")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.SubArticulosTableAdapter.Update(DsSubArticulos)
        Me.SubArticulosBindingSource.MoveNext()
        Dim Subarticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(DsSubArticulosDetalle.SubArticulosDetalle, Subarticulo)

    End Sub
End Class