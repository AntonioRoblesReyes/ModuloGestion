Public Class FrmNuevaPintura
    Sub SiguientePintura()
        Me.PinturaAplicacionBindingSource.AddNew()
        Me.TxtIdPinturaAplicacion.Text = Me.PinturaAplicacionTableAdapter.SiguientePinturaTipo()
    End Sub

    Private Sub FrmNuevaPintura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPinturaAplicacion.PinturaAplicacion' Puede moverla o quitarla según sea necesario.
        Me.PinturaAplicacionTableAdapter.Fill(Me.DsPinturaAplicacion.PinturaAplicacion)



    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PinturaAplicacionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PinturaAplicacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PinturaAplicacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPinturaAplicacion)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.TxtDescripcion.Text <> "" Then
            Me.Validate()
            Me.PinturaAplicacionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsPinturaAplicacion)
        Else
            MsgBox("Debe poner una descripcion")
        End If
    End Sub
End Class