Public Class FrmVehiculos

    Private Sub VehiculosTransporteBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles VehiculosTransporteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehiculosTransporteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsVehiculosTransporte)

    End Sub

    Private Sub FrmVehiculos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsVehiculosTransporte.VehiculosTransporte' Puede moverla o quitarla según sea necesario.
        Me.VehiculosTransporteTableAdapter.Fill(Me.DsVehiculosTransporte.VehiculosTransporte)

    End Sub
End Class