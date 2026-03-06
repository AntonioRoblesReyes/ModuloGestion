Imports System.Data.SqlClient

Public Class FrmCambioMaterial

    Private Function TryGetCurrentMaterialRow(ByRef row As DataGridViewRow) As Boolean
        row = Me.DataGridView1.CurrentRow
        Return row IsNot Nothing AndAlso Not row.IsNewRow
    End Function

    Sub FiltrarMaterial()

        Dim material As String

        Try
            material = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource.Position).IdMatrialesFamilia
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        Catch
            material = ""
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        End Try

    End Sub


    Sub Filtrarfamilia()

        Try

            Dim idFamilia As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource.Position).Id_Material
            Me.MaterialesFamiliaTableAdapter.FillByIdMateria(Me.DsMaterialFamilia.MaterialesFamilia, idFamilia)

        Catch
        End Try

    End Sub


    Sub FiltrarPorMaterial()
        Dim currentRow As DataGridViewRow = Nothing
        If Not TryGetCurrentMaterialRow(currentRow) Then
            Exit Sub
        End If

        If Not Me.DataGridView1.Columns.Contains("Id_Material_Detalle") Then
            Exit Sub
        End If

        Dim material As String = Convert.ToString(currentRow.Cells("Id_Material_Detalle").Value)
        If String.IsNullOrWhiteSpace(material) OrElse material.Length < 7 Then
            Exit Sub
        End If

        Dim currentRow As DataGridViewRow = Nothing
        If Not TryGetCurrentMaterialRow(currentRow) Then Exit Sub

        If Not Me.DataGridView1.Columns.Contains("Id_Material_Detalle") Then Exit Sub

        Dim material As String = Convert.ToString(currentRow.Cells("Id_Material_Detalle").Value)

        If String.IsNullOrWhiteSpace(material) OrElse material.Length < 7 Then Exit Sub

        Dim subString As String = Microsoft.VisualBasic.Left(material, 7)

        Me.SubArticulosDetalleTableAdapter.FillByPorMaterial(Me.DsSubArticulosDetalle.SubArticulosDetalle, LblIdSubArticulo.Text, material)
        Me.MaterialesTableAdapter.FillByIdMaterial(Me.DsMaterial.Materiales, subString)

    End Sub


    Sub Cambio()

        Try

            Dim cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)

            Dim cmd As New SqlCommand("
                SELECT *
                FROM SubArticulosDetalle
                WHERE Id_Sub_Articulo = @Id_Sub_Articulo
            ", cn)

            cmd.CommandType = CommandType.Text

            Dim param As New SqlParameter("@Id_Sub_Articulo", SqlDbType.NVarChar) With {
                .Size = 50,
                .Value = Me.LblIdSubArticulo.Text
            }

            cmd.Parameters.Add(param)

            Dim da As New SqlDataAdapter(cmd)

            Dim ds As New DataSet
            Const tableName As String = "Material"
            da.Fill(ds, tableName)

            If Not ds.Tables.Contains(tableName) Then
                Exit Sub
            End If

            Me.DataGridView1.DataSource = ds.Tables(tableName)
            Me.DataGridView1.AutoResizeColumns()

            If Me.DataGridView1.Columns.Count > 0 Then
                Me.DataGridView1.Columns(0).Visible = False
            End If

            If Me.DataGridView1.Columns.Contains("Cuenta") Then
                Me.DataGridView1.Columns("Cuenta").Visible = False
            End If

            If Me.DataGridView1.Columns.Contains("Id_Material_Detalle") Then
                Me.DataGridView1.Columns("Id_Material_Detalle").DisplayIndex = 0
                Me.DataGridView1.Columns("Id_Material_Detalle").Width = 100
            End If

            If Me.DataGridView1.Columns.Contains("Descripcion") Then
                Me.DataGridView1.Columns("Descripcion").Width = 300
            End If
            Me.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub FrmCambioMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)
        Me.MaterialesFamiliaTableAdapter.Fill(Me.DsMaterialFamilia.MaterialesFamilia)
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)

    End Sub


    Private Sub MaterialesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MaterialesDataGridView.CellClick

        Filtrarfamilia()
        FiltrarMaterial()

    End Sub


    Private Sub MaterialesFamiliaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MaterialesFamiliaDataGridView.CellClick

        Dim material As String

        Try
            material = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource.Position).IdMatrialesFamilia
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        Catch
            material = ""
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        filtrarPorMaterial()
    End Sub


    Private Sub BtnCambiarMaterial_Click(sender As Object, e As EventArgs) Handles BtnCambiarMaterial.Click

        Try

            If Me.MaterilaesDetalleBindingSource.Position < 0 OrElse
                Me.MaterilaesDetalleBindingSource.Position >= Me.DsMaterialDetalle.MaterilaesDetalle.Count Then Exit Sub

            Dim currentRow As DataGridViewRow = Nothing
            If Not TryGetCurrentMaterialRow(currentRow) Then Exit Sub

            If Not Me.DataGridView1.Columns.Contains("Id_Material_Detalle") Then Exit Sub

            If Me.MaterilaesDetalleBindingSource.Position < 0 OrElse
                Me.MaterilaesDetalleBindingSource.Position >= Me.DsMaterialDetalle.MaterilaesDetalle.Count Then
                Exit Sub
            End If

            Dim currentRow As DataGridViewRow = Nothing
            If Not TryGetCurrentMaterialRow(currentRow) Then
                Exit Sub
            End If

            If Not Me.DataGridView1.Columns.Contains("Id_Material_Detalle") Then
                Exit Sub
            End If

            Dim NuevoMaterial As String = Me.DsMaterialDetalle.MaterilaesDetalle(Me.MaterilaesDetalleBindingSource.Position).Id_Material_Detalle
            Dim material As String = Convert.ToString(currentRow.Cells("Id_Material_Detalle").Value)
            If String.IsNullOrWhiteSpace(material) Then
                Exit Sub
            End If
            Me.SubArticulosDetalleTableAdapter.CambiarMaterial(NuevoMaterial, LblIdSubArticulo.Text, material)

            Me.SubArticulosDetalleTableAdapter.FillByPorMaterial(Me.DsSubArticulosDetalle.SubArticulosDetalle, LblIdSubArticulo.Text, NuevoMaterial)

            My.Forms.FrmSubArticulo.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(
                My.Forms.FrmSubArticulo.DsSubArticulosDetalle.SubArticulosDetalle,
                My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text)

            Cambio()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub BtnRefrescarMaterilales_Click(sender As Object, e As EventArgs) Handles BtnRefrescarMaterilales.Click
        Cambio()
    End Sub
End Class
