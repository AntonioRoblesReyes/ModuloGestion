Public Class FrmNuevoVheiculo
    Sub NuevoVehiculo()
        Me.VehiculosTransporteBindingSource.AddNew()
        Dim empresa As String = My.Forms.FrmNuevoTransportista.Id_EmpresaTransporteTextBox.Text
        Me.Id_EmpresaTransporteTextBox.Text = empresa
        Me.Id_EmpresaTransporteTextBox.Enabled = False
    End Sub

    Private Sub VehiculosTransporteBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles VehiculosTransporteBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.VehiculosTransporteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsVehiculosTransporte)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub FrmNuevoVheiculo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsVehiculosTransporte.VehiculosTransporte' Puede moverla o quitarla según sea necesario.
        Me.VehiculosTransporteTableAdapter.Fill(Me.DsVehiculosTransporte.VehiculosTransporte)

    End Sub
End Class