Public Class FrmVerSubarticulos

    Private Sub SubArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)

    End Sub





    Private Sub FrmVerSubarticulos1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Try


        'TODO: esta línea de código carga datos en la tabla 'DsMaterialFamilia.MaterialesFamilia' Puede moverla o quitarla según sea necesario.
        Me.MaterialesFamiliaTableAdapter.Fill(Me.DsMaterialFamilia.MaterialesFamilia)
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsMaterialDetalle.MaterilaesDetalle' Puede moverla o quitarla según sea necesario.
        Me.MaterilaesDetalleTableAdapter.Fill(Me.DsMaterialDetalle.MaterilaesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsDescripcionesdetalle.DescripcionesDetalle' Puede moverla o quitarla según sea necesario.
        Me.DescripcionesDetalleTableAdapter.Fill(Me.DsDescripcionesdetalle.DescripcionesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulosDetalle.SubArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulosDetalle.SubArticulosDetalle' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsDescripciones.Descripciones' Puede moverla o quitarla según sea necesario.
        Me.DescripcionesTableAdapter.Fill(Me.DsDescripciones.Descripciones)
        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulosFamilia.SubarticulosFamilias' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsSubArticulos.SubArticulos' Puede moverla o quitarla según sea necesario.
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
        Dim subarticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, subarticulo)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub CmdAgregarArticulo_Click(sender As System.Object, e As System.EventArgs) Handles CmdAgregarArticulo.Click

        Dim iTotal As Integer = My.Forms.FrmArticulo.DsArticulosdetalle.Tables(0).Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla


        Dim subarticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
        If iTotal <> 0 Then
            My.Forms.FrmArticulo.ArticulosDetalleBindingSource.MoveFirst()
            Dim contador As Integer = 0
            'Definimos la variable i para controlar el ciclo for
            Dim i As Integer
            'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla

            For i = 0 To iTotal - 1


                Dim Subarticuloexistente As String = My.Forms.FrmArticulo.DsArticulosdetalle.ArticulosDetalle(My.Forms.FrmArticulo.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo

                If Subarticuloexistente <> subarticulo Then


                ElseIf Subarticuloexistente = subarticulo Then
                    contador += 1
                    MsgBox("este subarticulo ya esta, cambia la cantida si necita mas")
                    Me.Close()
                    Exit For

                End If

                My.Forms.FrmArticulo.ArticulosDetalleBindingSource.MoveNext()
            Next



            If contador = 0 Then

                Try
                    My.Forms.FrmArticulo.SubArticulosTableAdapter.Fill(My.Forms.FrmArticulo.DsSubArticulos.SubArticulos)               'Dim verficaringresados As Integer = My.Forms.FrmArticulo.DsDescripcionesdetalle.Tables(0).Rows.Count





                    Dim IdSubArticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
                    Dim articulo As String = My.Forms.FrmArticulo.TxtIdArticulo.Text
                    Dim tiempoTrabajo As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Minutos__Trabajo_Sub_Articulo / 60
                    Dim M2Pintura As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).M2Pintura
                    Dim Montaje As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Montaje
                    Dim idDetalle As String = My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.SiguienteDetalle(articulo)

                    My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.AnexarSubArticulo(idDetalle, articulo, IdSubArticulo, 1, tiempoTrabajo, M2Pintura, tiempoTrabajo, M2Pintura, Montaje, Montaje)

                    My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.FillByIdArticulo(My.Forms.FrmArticulo.DsArticulosdetalle.ArticulosDetalle, articulo)
                    My.Forms.FrmArticulo.sumardetalles()
                    My.Forms.FrmArticulo.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(My.Forms.FrmArticulo.DsSubArticulosDetalle.SubArticulosDetalle, IdSubArticulo)

                Catch ex As Exception

                    MsgBox(ex.Message.ToString)
                End Try

                Me.Close()

            End If
        Else
            Try
                My.Forms.FrmArticulo.SubArticulosTableAdapter.Fill(My.Forms.FrmArticulo.DsSubArticulos.SubArticulos)               'Dim verficaringresados As Integer = My.Forms.FrmArticulo.DsDescripcionesdetalle.Tables(0).Rows.Count





                Dim IdSubArticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
                Dim articulo As String = My.Forms.FrmArticulo.TxtIdArticulo.Text
                Dim tiempoTrabajo As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Minutos__Trabajo_Sub_Articulo / 60
                Dim M2Pintura As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).M2Pintura
                Dim Montaje As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Montaje

                Dim idDetalle As String = My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.SiguienteDetalle(articulo)

                My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.AnexarSubArticulo(idDetalle, articulo, IdSubArticulo, 1, tiempoTrabajo, M2Pintura, tiempoTrabajo, M2Pintura, Montaje, Montaje)

                My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.FillByIdArticulo(My.Forms.FrmArticulo.DsArticulosdetalle.ArticulosDetalle, articulo)
                My.Forms.FrmArticulo.sumardetalles()


            Catch ex As Exception

                MsgBox(ex.Message.ToString)
            End Try

            Me.Close()

        End If





    End Sub





    Private Sub CmbDescripcion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbDescripcion.SelectedIndexChanged
        Try
            Me.SubArticulosTableAdapter.FillByIdGrupo(Me.DsSubArticulos.SubArticulos, CmbDescripcion.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SubArticulosDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubArticulosDataGridView.CellEndEdit
        Me.Validate()
        Me.SubArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulos)
    End Sub

    Private Sub SubArticulosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubArticulosDataGridView.CellClick
        Dim subarticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
        Me.SubArticulosDetalleTableAdapter.FillByIdSubArticulo(Me.DsSubArticulosDetalle.SubArticulosDetalle, subarticulo)
    End Sub

    Private Sub BtnSubarticulos_Click(sender As System.Object, e As System.EventArgs) Handles BtnSubarticulos.Click
        Try
            Dim subArticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo

            My.Forms.FrmSubArticulo.Close()
            My.Forms.FrmSubArticulo.lblInicio.Text = subArticulo


            My.Forms.FrmSubArticulo.Inicio()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)


        End Try
    End Sub

    Private Sub TxtPorDescripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtPorDescripcion.TextChanged
        Me.SubArticulosTableAdapter.FillByPorDescripcio(Me.DsSubArticulos.SubArticulos, "%" & TxtPorDescripcion.Text & "%")
    End Sub
    Private Sub FrmVerSubarticulos1_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)

    End Sub

    Private Sub BtnCambiarSubArticulo_Click(sender As System.Object, e As System.EventArgs) Handles BtnCambiarSubArticulo.Click
        Try
            My.Forms.FrmArticulo.SubArticulosTableAdapter.Fill(My.Forms.FrmArticulo.DsSubArticulos.SubArticulos)


            Dim verficaringresados As Integer = My.Forms.FrmArticulo.DsDescripcionesdetalle.Tables(0).Rows.Count





            Dim IdSubArticulo As String = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Id_Sub_Articulo
            Dim articulo As String = My.Forms.FrmArticulo.TxtIdArticulo.Text
            Dim tiempoTrabajo As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).Minutos__Trabajo_Sub_Articulo / 60
            Dim M2Pintura As Double = Me.DsSubArticulos.SubArticulos(Me.SubArticulosBindingSource.Position).M2Pintura
            Dim idDetalle As String = My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.SiguienteDetalle(articulo)

            My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.CambiarSubArticulo(IdSubArticulo, 1, tiempoTrabajo, M2Pintura, tiempoTrabajo, M2Pintura, Me.Label1.Text)

            My.Forms.FrmArticulo.ArticulosDetalleTableAdapter.FillByIdArticulo(My.Forms.FrmArticulo.DsArticulosdetalle.ArticulosDetalle, articulo)
            My.Forms.FrmArticulo.sumardetalles()

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)
        Me.SubArticulosTableAdapter.FillByPorDescripcio(Me.DsSubArticulos.SubArticulos, "%" & TxtPorDescripcion.Text & "%")
    End Sub

    Private Sub SubArticulosDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubArticulosDataGridView.CellContentClick

    End Sub
End Class