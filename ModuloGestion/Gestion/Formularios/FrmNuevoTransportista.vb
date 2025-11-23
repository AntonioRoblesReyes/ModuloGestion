Public Class FrmNuevoTransportista
    Sub EmpresaDetalles()
        Dim empresa As String = My.Forms.FrmEmpresasTransporte.DsEmpresasTransporte.EmpresasTransporte(My.Forms.FrmEmpresasTransporte.EmpresasTransporteBindingSource.Position).Id_EmpresaTransporte
        Me.EmpresasTransporteTableAdapter.FillByIdEmpresa(Me.DsEmpresasTransporte.EmpresasTransporte, empresa)
    End Sub
    Sub NuevoTransportista()
        Me.EmpresasTransporteBindingSource.AddNew()
    End Sub
    Private Sub EmpresasTransporteBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresasTransporteBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmpresasTransporteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsEmpresasTransporte)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmNuevoTransportista_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpresasTransporte.EmpresasTransporte' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTransporteTableAdapter.Fill(Me.DsEmpresasTransporte.EmpresasTransporte)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        My.Forms.FrmNuevoConductor.Close()
        My.Forms.FrmNuevoConductor.Show()
        My.Forms.FrmNuevoConductor.ConductoresBindingSource.AddNew()
        My.Forms.FrmNuevoConductor.NuevoConductor()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.FrmNuevoVheiculo.Close()
        My.Forms.FrmNuevoVheiculo.Show()

        My.Forms.FrmNuevoVheiculo.NuevoVehiculo()
    End Sub
End Class