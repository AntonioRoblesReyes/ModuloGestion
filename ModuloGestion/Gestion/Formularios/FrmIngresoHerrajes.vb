Imports System.IO
Public Class FrmIngresoHerrajes
    Public Sub Nuevvoherraje()
        Me.MdiParent = My.Forms.FrmGestion

        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)

        Me.HerrajesFamiliaTableAdapter.Fill(Me.DsHerrajesFamilia.HerrajesFamilia)

        Me.TxtIdherrajes.Enabled = False
        Me.HerrajesTableAdapter.Fill(Me.DsHerrajes.Herrajes)

        Me.ImajenTextBox.Enabled = False
        If ImajenTextBox.TextLength = 0 Then
            Button1.Text = "Cargar imajen"
        Else
            Button1.Text = "Cambiar imajen"

        End If
        Me.Medidad_Elementos_HerrajesTextBox.Visible = False
        Me.Tipo_herrajeTextBox.Visible = False
        Me.Label1.Visible = False
        Me.Validate()
        Me.HerrajesBindingSource.AddNew()
        Me.TableAdapterManager.UpdateAll(Me.DsHerrajes)

        Me.Show()
    End Sub


    Public Sub Editarherraje()

        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        Me.MdiParent = My.Forms.FrmGestion
        Me.HerrajesFamiliaTableAdapter.Fill(Me.DsHerrajesFamilia.HerrajesFamilia)

        Me.TxtIdherrajes.Enabled = False
        Me.HerrajesTableAdapter.Fill(Me.DsHerrajes.Herrajes)
        Me.HerrajesTableAdapter.FillBydHerraje(Me.DsHerrajes.Herrajes, Me.Label1.Text)
        Me.ImajenTextBox.Enabled = False
        If ImajenTextBox.TextLength = 0 Then
            Button1.Text = "Cargar imajen"
        Else
            Button1.Text = "Cambiar imajen"

        End If
        Me.Medidad_Elementos_HerrajesTextBox.Visible = False
        Me.Tipo_herrajeTextBox.Visible = False
        Me.Label1.Visible = False
        Me.Show()

    End Sub
    Private Sub HerrajesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles HerrajesBindingNavigatorSaveItem.Click
        Me.Medidad_Elementos_HerrajesTextBox.Visible = False
        Me.Tipo_herrajeTextBox.Visible = False
        If Me.TxtIdherrajes.TextLength = 0 Then
            Me.TxtIdherrajes.Text = Me.HerrajesTableAdapter.Siguiente()
        End If



        If Me.Descripcion_Elemento_HerrajesTextBox.TextLength <> 0 Then
            Me.Validate()
            Me.HerrajesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsHerrajes)
        Else
            MsgBox("Descripcion no puede estar vacio")
        End If


    End Sub

    Private Sub FrmIngresoHerrajes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub



    Private Sub IdHerrajeTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIdherrajes.TextChanged


        Try
            Dim Imagen As String
            Imagen = DsHerrajes.Herrajes(Me.HerrajesBindingSource.Position).Imajen
            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Me.TxtIdherrajes.TextLength <> 0 Then

            Try


                Dim archivo As String
                OpenFileDialog1.ShowDialog()
                Path.GetFileName(TxtIdherrajes.Text)
                archivo = OpenFileDialog1.FileName
                Me.ImajenTextBox.Text = "\\antonio-dell\Users\Public\Carpeta Datos\Imajenes\Imajenes Herrajes\" + Path.GetFileName(Me.OpenFileDialog1.FileName)

                Me.Validate()
                Me.HerrajesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsHerrajes)

                Try
                    Dim Imagen As String
                    Imagen = DsHerrajes.Herrajes(Me.HerrajesBindingSource.Position).Imajen
                    Me.PictureBox1.Image = Image.FromFile(Imagen)
                Catch ex As Exception
                    Me.PictureBox1.Image = Nothing
                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim Imagen As String
                Imagen = DsHerrajes.Herrajes(Me.HerrajesBindingSource.Position).Imajen
                Me.PictureBox1.Image = Image.FromFile(Imagen)
            Catch ex As Exception
                Me.PictureBox1.Image = Nothing
            End Try
        Else
            MsgBox("Todabia no a creado el herraje" & vbCrLf & "Debe crear el herraje primero", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub ImajenTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ImajenTextBox.TextChanged
        If ImajenTextBox.TextLength = 0 Then
            Button1.Text = "Cargar imajen"
        Else
            Button1.Text = "Cambiar imajen"
        End If
        Me.Validate()
        Me.HerrajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsHerrajes)

        Try
            Dim Imagen As String
            Imagen = DsHerrajes.Herrajes(Me.HerrajesBindingSource.Position).Imajen
            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            Me.Validate()
            Me.HerrajesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsHerrajes)
            Me.HerrajesBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub CmbTipoHerraje_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbTipoHerraje.SelectedIndexChanged
        Me.Tipo_herrajeTextBox.Text = CmbTipoHerraje.SelectedValue
    End Sub

    Private Sub ComboBox1_Selected(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Medidad_Elementos_HerrajesTextBox.Text = ComboBox1.SelectedValue
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Forms.FrmTipoHerraje.Close()
        My.Forms.FrmTipoHerraje.Show()
    End Sub
End Class