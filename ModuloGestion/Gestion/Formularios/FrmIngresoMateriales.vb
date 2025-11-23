Public Class FrmIngresoMateriales
    Sub Filtrarfamilia()
        Try


            Dim idFamilia As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource1.Position).Id_Material
            Me.MaterialesFamiliaTableAdapter.FillByIdMateria(Me.DsMaterialFamilia.MaterialesFamilia, idFamilia)
            Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, idFamilia)
        Catch ex As Exception

        End Try

    End Sub
    Sub FiltrarMaterial()
        Dim material As String

        Try
            material = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource1.Position).IdMatrialesFamilia
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        Catch ex As Exception
            material = ""
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        End Try

    End Sub
    Private Sub MaterialesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MaterialesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MaterialesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)

    End Sub

    Private Sub FrmIngresoMateriales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion
        Try


            Me.MaterialMedidaCompraTableAdapter.Fill(Me.DsMaterialMedidadCompra.MaterialMedidaCompra)
            'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
            Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
            'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
            Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
            'TODO: esta línea de código carga datos en la tabla 'DsMaterialFamilia.MaterialesFamilia' Puede moverla o quitarla según sea necesario.
            Me.MaterialesFamiliaTableAdapter.Fill(Me.DsMaterialFamilia.MaterialesFamilia)
            'TODO: esta línea de código carga datos en la tabla 'DsMaterial.Materiales' Puede moverla o quitarla según sea necesario.
            Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Filtrarfamilia()
        FiltrarMaterial()
    End Sub







    Private Sub MaterialesFamiliaDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        FiltrarMaterial()
    End Sub







    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ultimo As String
        Try
            ultimo = MaterialesTableAdapter.Siguiente()
        Catch ex As Exception
            ultimo = "MAT-000"
        End Try
        Me.MaterialesTableAdapter.AnexarMaterial(ultimo, "PONER DESCRIPCION")


        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)


    End Sub




    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim idmaterial As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource1.Position).Id_Material
        Dim descripcion As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource1.Position).Descrpcion & " DE"
        Dim nuevo As String = Me.MaterialesFamiliaTableAdapter.Ultimo(idmaterial)
        Dim siguiente As String = Microsoft.VisualBasic.Left(nuevo, 8) & Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Right(nuevo, 3) + 1001, 3)
        Me.MaterialesFamiliaTableAdapter.Anexar(siguiente, descripcion, idmaterial)
        Filtrarfamilia()
        FiltrarMaterial()
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim idmaterial As String = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource1.Position).IdMatrialesFamilia
        Dim descripcion As String = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource1.Position).Descripcion & " DE"
        Dim nuevo As String = Me.MaterilaesDetalleTableAdapter.Siguiente(idmaterial)
        Dim siguiente As String = Microsoft.VisualBasic.Left(nuevo, 12) & Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Right(nuevo, 3) + 1001, 3)

        Me.MaterilaesDetalleTableAdapter.Anexar(siguiente, descripcion, idmaterial)
        Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(DsMaterialDetalle.MaterilaesDetalle, idmaterial)
    End Sub







    Private Sub MaterialesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesDataGridView.CellClick
        Filtrarfamilia()
        FiltrarMaterial()
    End Sub

    Private Sub MaterialesDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesDataGridView.CellEndEdit
        Me.Validate()
        Me.MaterialesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)
    End Sub

    Private Sub MaterialesDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles MaterialesDataGridView.RowsRemoved
        Me.Validate()
        Me.MaterialesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)
    End Sub

    Private Sub MaterilaesDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterilaesDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.MaterilaesDetalleBindingSource1.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DsMaterialDetalle)
    End Sub

    Private Sub MaterialesFamiliaDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesFamiliaDataGridView.CellEndEdit
        Me.Validate()
        Me.MaterialesFamiliaBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsMaterialFamilia)
    End Sub

    Private Sub MaterialesFamiliaDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles MaterialesFamiliaDataGridView.RowsRemoved
        Me.Validate()
        Me.MaterialesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaterial)
    End Sub

    Private Sub MaterilaesDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles MaterilaesDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.MaterilaesDetalleBindingSource1.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DsMaterialDetalle)
    End Sub





    Private Sub MaterialesFamiliaDataGridView_CellClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesFamiliaDataGridView.CellClick
        Dim material As String

        Try
            material = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource1.Position).IdMatrialesFamilia
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        Catch ex As Exception
            material = ""
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        My.Forms.FrmAnexrMediaCompraMaterial.Close()
        My.Forms.FrmAnexrMediaCompraMaterial.Show()

    End Sub

    Private Sub FrmIngresoMateriales_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub


End Class