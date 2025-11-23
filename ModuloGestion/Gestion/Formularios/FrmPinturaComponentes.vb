Public Class FrmPinturaComponentes

    Private Sub PinturaComponentesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PinturaComponentesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPinturaComponentes)

    End Sub

    Private Sub FrmPinturaComponetes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = My.Forms.FrmGestion
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        Me.PinturaFamiliasTableAdapter.Fill(Me.DsPinturasFamilia.PinturaFamilias)
        Me.PinturaFamiliasTableAdapter.Fill(Me.DsPinturasFamilia.PinturaFamilias)
        Me.PinturaComponentesTableAdapter.Fill(Me.DsPinturaComponentes.PinturaComponentes)
        Me.CmbIdFamilia.Text = "Filtrar por tipo"
        Me.BtnAñadirComponente.Visible = False

    End Sub

    Private Sub PinturaComponentesDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PinturaComponentesDataGridView.CellEndEdit
        Me.Validate()
        Me.PinturaComponentesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPinturaComponentes)
    End Sub

    Private Sub PinturaComponentesDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PinturaComponentesDataGridView.RowsRemoved
        Try
            Me.Validate()
            Me.PinturaComponentesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPinturaComponentes)
        Catch ex As Exception
            MsgBox("No se puede eliminar, ya esta asignado")
        End Try
    End Sub

    Private Sub BtnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAñadirComponente.Click
        My.Forms.FrmPinturaAplicacoon.AñadirComponente()
    End Sub

    Private Sub CmbIdFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbIdFamilia.SelectedIndexChanged
        Try
            Me.PinturaComponentesTableAdapter.FillByIdPinturaFamilia(Me.DsPinturaComponentes.PinturaComponentes, CmbIdFamilia.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnNuevoComponete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoComponete.Click


        Dim FamiliaPintura As String = Me.CmbIdFamilia.SelectedValue

        Dim siguienteComponente As String = Me.PinturaComponentesTableAdapter.Siguiente(FamiliaPintura)
        If Me.CmbIdFamilia.Text <> "Filtrar por tipo" Then
            Me.PinturaComponentesTableAdapter.InsertarNuevoComponente(siguienteComponente, FamiliaPintura)
            Me.PinturaComponentesTableAdapter.FillByIdPinturaFamilia(Me.DsPinturaComponentes.PinturaComponentes, CmbIdFamilia.SelectedValue)
        Else
            MsgBox("Debe elejir un grupo de pintura")
        End If



    End Sub

    Private Sub BtnFichaTecnica_Click(sender As System.Object, e As System.EventArgs) Handles BtnFichaTecnica.Click

        Dim FichaTecnica As String = Me.DsPinturaComponentes.PinturaComponentes(Me.PinturaComponentesBindingSource.Position).FichaTecnica




    End Sub
End Class