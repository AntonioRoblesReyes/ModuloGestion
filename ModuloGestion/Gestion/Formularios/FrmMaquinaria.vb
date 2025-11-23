Public Class FrmMaquinaria
    Sub Cargarimagen()
        Try

            Dim Imagen As String
            Imagen = Me.DsMaquinarias.FotoMaquina(Me.FotoMaquinaBindingSource.Position).Fotografia
            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try
    End Sub

    Sub CargarFormulario()

        'Me.MaqinariaTableAdapter.Fill(Me.DsMaquinarias.Maqinaria)
        'Me.FotoMaquinaTableAdapter.Fill(Me.DsMaquinarias.FotoMaquina)
        'If ElectricidadCheckBox.Checked = True Then
        '    Me.GbElectricidad.Visible = True
        'Else
        '    Me.GbElectricidad.Visible = False
        'End If
        ''cargarimagen()
        'Me.Show()

    End Sub
    Private Sub MaqinariaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MaqinariaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MaqinariaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsMaquinarias)

    End Sub

    Private Sub FrmMaquinaria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMaquinarias.Aire' Puede moverla o quitarla según sea necesario.
        'Me.AireTableAdapter.Fill(Me.DsMaquinarias.Aire)
        'TODO: esta línea de código carga datos en la tabla 'DsMaquinarias.FotoMaquina' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsMaquinarias.Electricidad' Puede moverla o quitarla según sea necesario.

        'Me.MaqinariaTableAdapter.Fill(Me.DsMaquinarias.Maqinaria)

    End Sub


    Private Sub ElectricidadCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ElectricidadCheckBox.CheckedChanged
        If ElectricidadCheckBox.Checked = True Then
            Me.GbElectricidad.Visible = True
        Else
            Me.GbElectricidad.Visible = False
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem1.Click
        cargarimagen()
    End Sub

    Private Sub BindingNavigatorMoveNextItem1_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorMoveNextItem1.Click

    End Sub

    Private Sub FillIdMaquinariaToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillIdMaquinariaToolStripButton.Click
        Try
            'Me.FotoMaquinaTableAdapter.FillIdMaquinaria(Me.DsMaquinarias.FotoMaquina, IdMaquinariaToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class