Imports System.Data.SqlClient
Public Class FrmCambioMaterial

    Sub FiltrarMaterial()
        Dim material As String

        Try
            material = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource.Position).IdMatrialesFamilia
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        Catch ex As Exception
            material = ""
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        End Try

    End Sub
    Sub Filtrarfamilia()
        Try


            Dim idFamilia As String = Me.DsMaterial.Materiales(Me.MaterialesBindingSource.Position).Id_Material
            Me.MaterialesFamiliaTableAdapter.FillByIdMateria(Me.DsMaterialFamilia.MaterialesFamilia, idFamilia)
            'Me.MaterialMedidaCompraTableAdapter.FillByIdMaterial(Me.DsMaterialMedidadCompra.MaterialMedidaCompra, idFamilia)
        Catch ex As Exception

        End Try

    End Sub


    Sub FiltrarPorMaterial()
        Dim material As String = Me.DataGridView1.CurrentRow.Cells("Id_Material_Detalle").Value

        Dim subString As String = Microsoft.VisualBasic.Left(material, 7)

        Me.SubArticulosDetalleTableAdapter.FillByPorMaterial(Me.DsSubArticulosDetalle.SubArticulosDetalle, LblIdSubArticulo.Text, material)
        Me.MaterialesTableAdapter.FillByIdMaterial(Me.DsMaterial.Materiales, subString)

    End Sub






    Sub Cambio()
        Try


            Dim cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
            Dim cmd As New SqlCommand("PorMaterial", cn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Connection.Open()
            'cmd.ExecuteNonQuery()
            'cmd.Connection.Close()
            'cn.Open()
            Dim param As New SqlParameter("@Id_Sub_Articulo", SqlDbType.NVarChar) With {
                .Size = 50,
                .Value = Me.LblIdSubArticulo.Text
            }

            cmd.Parameters.Add(param)


            Dim da As New SqlDataAdapter With {
                .SelectCommand = cmd
            }

            da.SelectCommand.Connection = cn


            Dim ds As New DataSet
            da.Fill(ds, "Material")

            Me.DataGridView1.DataSource = ds.Tables("material")
            Me.DataGridView1.AutoResizeColumns()
            Me.DataGridView1.Columns(0).Visible = False
            Me.DataGridView1.Columns("Cuenta").Visible = False
            Me.DataGridView1.Columns("Id_Material_Detalle").DisplayIndex = 0
            Me.DataGridView1.Columns("Id_Material_Detalle").Width = 100
            Me.DataGridView1.Columns("Descripcion").Width = 300
            Me.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub FrmCambioMaterial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMaterial.Materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.DsMaterial.Materiales)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialFamilia.MaterialesFamilia' Puede moverla o quitarla según sea necesario.
        Me.MaterialesFamiliaTableAdapter.Fill(Me.DsMaterialFamilia.MaterialesFamilia)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)

    End Sub

    Private Sub MaterialesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesDataGridView.CellClick
        filtrarfamilia()
        FiltrarMaterial()
    End Sub

    Private Sub MaterialesFamiliaDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MaterialesFamiliaDataGridView.CellClick
        Dim material As String

        Try
            material = Me.DsMaterialFamilia.MaterialesFamilia(Me.MaterialesFamiliaBindingSource.Position).IdMatrialesFamilia
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        Catch ex As Exception
            material = ""
            Me.MaterilaesDetalleTableAdapter.FillByIdMaterialFamilia(Me.DsMaterialDetalle.MaterilaesDetalle, material)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        filtrarPorMaterial()
    End Sub

    Private Sub BtnCambiarMaterial_Click(sender As System.Object, e As System.EventArgs) Handles BtnCambiarMaterial.Click
        Try



            Dim NuevoMaterial As String = Me.DsMaterialDetalle.MaterilaesDetalle(Me.MaterilaesDetalleBindingSource.Position).Id_Material_Detalle
            Dim material As String = Me.DataGridView1.CurrentRow.Cells("Id_Material_Detalle").Value
            Me.SubArticulosDetalleTableAdapter.CambiarMaterial(NuevoMaterial, LblIdSubArticulo.Text, material)
            Me.SubArticulosDetalleTableAdapter.FillByPorMaterial(Me.DsSubArticulosDetalle.SubArticulosDetalle, LblIdSubArticulo.Text, NuevoMaterial)
            'My.Forms.FrmSubArticulo.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulo.DsSubArticulosDetalle.SubArticulosDetalle, My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text)
            Dim itotal As Integer = Me.DsSubArticulosDetalle.Tables(0).Rows.Count

            Me.SubArticulosDetalleBindingSource.MoveFirst()
            Dim i As Integer
            For i = 0 To itotal - 1
                Dim idDetalle As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Id_detalle_Sub_Articulo

                'My.Forms.FrmSubArticulo.SubArticulosDetalleTableAdapter.FillByIdDetalle(My.Forms.FrmSubArticulo.DsSubArticulosDetalle.SubArticulosDetalle, idDetalle)

                Me.SubArticulosDetalleBindingSource.MoveNext()
            Next

            My.Forms.FrmSubArticulo.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulo.DsSubArticulosDetalle.SubArticulosDetalle, My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text)
            Me.cambio()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnRefrescarMaterilales_Click(sender As System.Object, e As System.EventArgs) Handles BtnRefrescarMaterilales.Click
        cambio()

    End Sub
End Class