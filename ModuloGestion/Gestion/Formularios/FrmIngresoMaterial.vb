Public Class FrmIngresoMaterial
    Public Sub Filtrar()
        Dim Material As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource.Position).Id_Material
        Me.MaterialesFamiliaTableAdapter.FillByIdMateria(Me.DsMaterialFamilia.MaterialesFamilia, Material)
        Dim Familia As String = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource.Position).IdMatrialesFamilia
        Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, Familia)
        Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, Material)
    End Sub

    Private Sub MaterialesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MaterialesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MaterialesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)

    End Sub

    Private Sub FrmIngresoMaterial_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)



    End Sub

    Private Sub FrmIngresoMaterial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialMedidadCompra.MaterialMedidaCompra' Puede moverla o quitarla según sea necesario.
        Me.MaterialMedidaCompraTableAdapter.Fill(Me.DsMaterialMedidadCompra.MaterialMedidaCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialFamilia.MaterialesFamilia' Puede moverla o quitarla según sea necesario.
        Me.MaterialesFamiliaTableAdapter.Fill(Me.DsMaterialFamilia.MaterialesFamilia)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterial.Materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)
        Filtrar()
    End Sub


    Private Sub MaterialesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesDataGridView.CellClick
        Filtrar()
    End Sub

    Private Sub MaterialesFamiliaDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesFamiliaDataGridView.CellClick
        Dim Material As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource.Position).Id_Material

        Dim Familia As String = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource.Position).IdMatrialesFamilia
        Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, Familia)
        Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, Material)
    End Sub

    Private Sub Añaadir_Click(sender As System.Object, e As System.EventArgs) Handles Añaadir.Click
        Try
            Dim materialDetalle As String = Me.DsMaterialDetalle.MaterilaesDetalle(Me.MaterilaesDetalleBindingSource.Position).Id_Material_Detalle
            My.Forms.FrmSubArticulo.DgwSubarticuloDetalle.CurrentRow.Cells(3).Value = materialDetalle
            Dim medidas As String = Me.DsMaterialMedidadCompra.MaterialMedidaCompra(Me.MaterialMedidaCompraBindingSource.Position).Id_Medida
            My.Forms.FrmSubArticulo.DgwSubarticuloDetalle.CurrentRow.Cells(8).Value = medidas
            If Not IsDBNull(My.Forms.FrmSubArticulo.DgwSubarticuloDetalle.CurrentRow.Cells(4).Value) Then

                If Not IsDBNull(My.Forms.FrmSubArticulo.DgwSubarticuloDetalle.CurrentRow.Cells(5).Value) Then
                    If Not IsDBNull(My.Forms.FrmSubArticulo.DgwSubarticuloDetalle.CurrentRow.Cells(6).Value) Then
                        If Not IsDBNull(My.Forms.FrmSubArticulo.DgwSubarticuloDetalle.CurrentRow.Cells(7).Value) Then
                            My.Forms.FrmSubArticulo.actualizar()
                        End If
                    End If
                End If
            Else

            End If


            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class