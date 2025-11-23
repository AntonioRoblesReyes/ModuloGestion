Public Class FrmFerreteria

    Private Sub FerreteriaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.FerreteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsFerreteria)

    End Sub

    Private Sub FrmFerreteria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsMedidasCompra.MedidasCompra' Puede moverla o quitarla según sea necesario.
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsFerreteria.Ferreteria' Puede moverla o quitarla según sea necesario.
        Me.FerreteriaTableAdapter.Fill(Me.DsFerreteria.Ferreteria)
        Me.Medidad_Elementos_FerreteriaTextBox.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim siguiente As String = Me.FerreteriaTableAdapter.Siguiente()
        Me.FerreteriaBindingSource.AddNew()
        Me.IdFerreteriaTextBox.Text = siguiente
        Me.Descripcion_Eemento_FerreteriaTextBox.Text = "Poner descripcion"

    End Sub

    Private Sub Id_MedidaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Id_MedidaComboBox.SelectedIndexChanged
        Me.Medidad_Elementos_FerreteriaTextBox.Text = Me.Id_MedidaComboBox.SelectedValue
    End Sub


    Private Sub BtnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles BtnGuardar.Click
        If Me.Descripcion_Eemento_FerreteriaTextBox.Text = "Poner descripcion" Then
            MsgBox("Debe Poner una descripcion")
        ElseIf Me.Medidad_Elementos_FerreteriaTextBox.Text = "" Then
            MsgBox("Debe Poner una Medida de compra")
        Else
            Me.FerreteriaTableAdapter.AnexarFerreteria(IdFerreteriaTextBox.Text, Descripcion_Eemento_FerreteriaTextBox.Text, Medidad_Elementos_FerreteriaTextBox.Text)
            Try
                My.Forms.FrmSubArticulo.FerreteriaTableAdapter.Fill(My.Forms.FrmSubArticulo.DsFerreteria.Ferreteria)
            Catch ex As Exception

            End Try


            Try
                My.Forms.FrmCompraFerreteria.FerreteriaTableAdapter.Fill(My.Forms.FrmCompraFerreteria.DsFerreteria.Ferreteria)
            Catch ex As Exception

            End Try

            Me.Close()
        End If








    End Sub


End Class