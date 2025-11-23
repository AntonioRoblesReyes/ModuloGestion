Imports System.IO
Public Class FrmArticulosHoteles
    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArticulosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)

    End Sub

    Private Sub FrmArticulosHoteles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelesDataSet.ArticuloDetalle' Puede moverla o quitarla según sea necesario.
        Me.ArticuloDetalleTableAdapter.Fill(Me.HotelesDataSet.ArticuloDetalle)
        'TODO: esta línea de código carga datos en la tabla 'HotelesDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.HotelesDataSet.Articulos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try


            Dim archivo As String
            OpenFileDialog1.ShowDialog()
            Path.GetFileName(IdArticulosTextBox.Text)
            archivo = OpenFileDialog1.FileName
            Me.FotoTextBox.Text = "C:\Users\Public\Carpeta Datos\Proyectos\D & L SINERGIA EMPRESARIAL\HOTEL CHIC ROYALTON\Imajenes\" + Path.GetFileName(Me.OpenFileDialog1.FileName)

            Me.Validate()
            Me.ArticulosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HotelesDataSet)

            Try
                Dim Imagen As String
                Imagen = HotelesDataSet.Articulos(Me.ArticulosBindingSource.Position).Foto
                Me.PictureBox1.Image = Image.FromFile(Imagen)
            Catch ex As Exception
                Me.PictureBox1.Image = Nothing
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim Imagen As String
            Imagen = HotelesDataSet.Articulos(Me.ArticulosBindingSource.Position).Foto
            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try

    End Sub

End Class