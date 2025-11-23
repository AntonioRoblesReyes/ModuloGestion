Public Class FrmEmpresasTransporte

    Private Sub EmpresasTransporteBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresasTransporteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresasTransporteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpresasTransporte)

    End Sub

    Private Sub FrmEmpresasTransporte_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpresasTransporte.EmpresasTransporte' Puede moverla o quitarla según sea necesario.
        Me.EmpresasTransporteTableAdapter.Fill(Me.DsEmpresasTransporte.EmpresasTransporte)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.FrmNuevoTransportista.Close()
        My.Forms.FrmNuevoTransportista.Show()
        My.Forms.FrmNuevoTransportista.NuevoTransportista()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Forms.FrmNuevoTransportista.Close()
        My.Forms.FrmNuevoTransportista.Show()
        My.Forms.FrmNuevoTransportista.empresaDetalles()
    End Sub
End Class