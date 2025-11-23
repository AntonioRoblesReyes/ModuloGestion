Public Class FrmNuevoConductor
    Sub NuevoConductor()
        Dim Empresa As String = My.Forms.FrmNuevoTransportista.Id_EmpresaTransporteTextBox.Text
        Me.Id_EmpresaTransporteTextBox.Text = Empresa
        Me.Id_EmpresaTransporteTextBox.Enabled = False
        Me.ActivoCheckBox.Text = -1
    End Sub
    Sub ModificarDatos()
        Dim conductor As String = My.Forms.FrmConductores.DsConductores.Conductores(My.Forms.FrmConductores.ConductoresBindingSource.Position).Cedula
        Me.ConductoresTableAdapter.FillByConductor(Me.DsConductores.Conductores, conductor)
    End Sub
    Private Sub ConductoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ConductoresBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ConductoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsConductores)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub FrmNuevoConductor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsConductores.Conductores' Puede moverla o quitarla según sea necesario.
        Me.ConductoresTableAdapter.Fill(Me.DsConductores.Conductores)

    End Sub

End Class