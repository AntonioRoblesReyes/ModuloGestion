Public Class FormGrupoSubArticulos

    Private Sub DescripcionesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles DescripcionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DescripcionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDescripciones)

    End Sub

    Private Sub FormGrupoSubArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsDescripciones.Descripciones' Puede moverla o quitarla según sea necesario.
        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)

    End Sub
    Sub NuevoSubArticulo()
        Dim Grupo As String = Me.DsDescripciones.Descripciones(Me.DescripcionesBindingSource.Position).Id_descripcion
        Dim descripcion As String = Me.DsDescripciones.Descripciones(Me.DescripcionesBindingSource.Position).descripcion
        Dim siguiente As String = My.Forms.FrmSubArticulo.SubArticulosTableAdapter.SubArticulosiguiente()

        My.Forms.FrmSubArticulo.Show()
        My.Forms.FrmSubArticulo.SubArticulosBindingSource.AddNew()
        My.Forms.FrmSubArticulo.SubArticulosTableAdapter.CrearSubarticulo(siguiente, descripcion & " de ", Grupo)


        My.Forms.FrmSubArticulo.SubArticulosTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulo.DsSubArticulos.SubArticulos, siguiente)
        'My.Forms.FrmSubArticulo.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulo.DsSubArticulosDetalle.SubArticulosDetalle, siguiente)

        My.Forms.FrmSubArticulo.Validate()
        My.Forms.FrmSubArticulo.SubArticulosBindingSource.EndEdit()
        My.Forms.FrmSubArticulo.TableAdapterManager.UpdateAll(My.Forms.FrmSubArticulo.DsSubArticulos)


    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        NuevoSubArticulo()
        Me.Close()
    End Sub

    Private Sub DescripcionesDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DescripcionesDataGridView.CellEndEdit
        Me.Validate()
        Me.DescripcionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDescripciones)
    End Sub
End Class