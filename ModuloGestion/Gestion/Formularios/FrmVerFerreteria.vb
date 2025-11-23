Imports System.IO

Public Class FrmVerFerreteria

    Private Sub FerreteriaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FerreteriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FerreteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsFerreteria)

    End Sub

    Private Sub FrmVerFerreteria_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)

    End Sub

    Private Sub FrmVerFerreteria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsFerreteria.Ferreteria' Puede moverla o quitarla según sea necesario.
        Me.FerreteriaTableAdapter.Fill(Me.DsFerreteria.Ferreteria)

    End Sub




    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.FerreteriaTableAdapter.FillByDescripcionFerreteria(Me.DsFerreteria.Ferreteria, "%" & TextBox1.Text & "%")
    End Sub

    Private Sub BtnAñadirFerreteria_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub FerreteriaDataGridView_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FerreteriaDataGridView.RowEnter


    End Sub

    Private Sub FerreteriaDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FerreteriaDataGridView.CellClick
        If e.ColumnIndex = 2 Then
            Try
                Dim Siguiente As String = My.Forms.FrmSubArticulo.SubArticulosDetalleFerreteriaTableAdapter.Siguiente(My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text)
                Dim Subarticulo As String = My.Forms.FrmSubArticulo.TxtIdSubarticulo.Text
                Dim IdFerreteria As String = Me.DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).IdFerreteria
                Dim Cantidad As Double = 1
                My.Forms.FrmSubArticulo.SubArticulosDetalleFerreteriaTableAdapter.InsertarDetalleferreteria(Siguiente, Subarticulo, IdFerreteria)
                My.Forms.FrmSubArticulo.SubArticulosDetalleFerreteriaTableAdapter.FillByIdSubArticulo(My.Forms.FrmSubArticulo.DsSubArticulosFerreteria.SubArticulosDetalleFerreteria, Subarticulo)

                'My.Forms.FrmIngresoHerrajePintura.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Try

            Dim Imagen As String
            Imagen = DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).Imajen
            Me.PictureBox1.Image = Image.FromFile(Imagen)
            Me.LinkLabel1.Visible = False
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
            Me.LinkLabel1.Visible = True
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If IsDBNull(Me.FerreteriaDataGridView.CurrentRow.Cells("Imajen").Value) Then
            Dim archivo As String
            OpenFileDialog1.ShowDialog()
            'Path.GetFileName(Me.OpenFileDialog1.FileName)
            archivo = OpenFileDialog1.FileName

            PictureBox1.Text = archivo
            Me.FerreteriaDataGridView.CurrentRow.Cells("imajen").Value = archivo
            Me.Validate()
            Me.FerreteriaDataGridView.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsFerreteria)


            'Dim idfere As String = Me.DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).IdFerreteria

        Else



            Try


                Dim archivo As String
                OpenFileDialog1.ShowDialog()
                Path.GetFileName(Me.DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).Imajen)
                archivo = OpenFileDialog1.FileName
                PictureBox1.Text = "\\PORTATIL-DELL\Users\Public\Imajenes Herrajes\" + Path.GetFileName(Me.OpenFileDialog1.FileName)

                Me.Validate()
                Me.FerreteriaDataGridView.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsFerreteria)

                Try
                    Dim Imagen As String
                    Imagen = DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).Imajen
                    Me.PictureBox1.Image = Image.FromFile(Imagen)
                Catch ex As Exception
                    Me.PictureBox1.Image = Nothing
                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim Imagen As String
                Imagen = DsFerreteria.Ferreteria(Me.FerreteriaBindingSource.Position).Imajen
                Me.PictureBox1.Image = Image.FromFile(Imagen)
            Catch ex As Exception
                Me.PictureBox1.Image = Nothing
            End Try

            '    MsgBox("Todabia no a creado el herraje" & vbCrLf & "Debe crear el herraje primero", MsgBoxStyle.Critical)

        End If

    End Sub




    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        My.Forms.FrmFerreteria.Close()
        My.Forms.FrmFerreteria.Show()

    End Sub
End Class