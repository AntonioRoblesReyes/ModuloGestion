Public Class FrmSubArticuloDetalle



    Private Sub SubArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

    End Sub

    Private Sub FrmSubArticuloDetalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialFamilia.MaterialesFamilia' Puede moverla o quitarla según sea necesario.
        Me.MaterialesFamiliaTableAdapter.Fill(Me.DsMaterialFamilia.MaterialesFamilia)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterial.Materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulosDetalle.SubArticulosDetalle' Puede moverla o quitarla según sea necesario.
        'Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsDescripcionesdetalle.DescripcionesDetalle' Puede moverla o quitarla según sea necesario.
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulos.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)


        Me.txtDetalle.Enabled = False

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.FrmGrupoSubArticulos.Close()
        My.Forms.FrmGrupoSubArticulos.Show()
    End Sub




    Private Sub IdMatrialesFamiliaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles IdMatrialesFamiliaComboBox.SelectedIndexChanged
        Try
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, IdMatrialesFamiliaComboBox.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        '    Try


        '        Dim iddetalleSubarticulos As String = txtDetalle.Text
        '        Dim idSubarticulos As String = Id_Sub_ArticuloTextBox.Text
        '        Dim IdDescripcion As String = Id_descripcion_DetalleComboBox.SelectedValue
        '    Dim largo As Decimal = LargoTextBox.Text
        '    Dim Ancho As Decimal = AnchoTextBox.Text
        '    Dim grueso As Decimal = GruesoTextBox.Text
        '    Dim Cantidad As Integer = CantidadTextBox.Text
        '        Dim idmaterial As String = Id_Material_DetalleComboBox.SelectedValue
        '        Dim idmedida As Integer = Id_MedidaComboBox.SelectedValue

        '        'Me.SubArticulosDetalleTableAdapter.Anexar(iddetalleSubarticulos, idSubarticulos, IdDescripcion, largo, Ancho, grueso, Cantidad, idmaterial, idmedida)
        '        My.Forms.FrmSubArticulo.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulo.DsSubArticulosDetalle.SubArticulosDetalle, My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text)
        '        My.Forms.FrmSubArticulo.actualizar()
        '        Me.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
    End Sub

End Class