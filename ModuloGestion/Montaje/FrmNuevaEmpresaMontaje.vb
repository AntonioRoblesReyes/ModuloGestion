Public Class FrmNuevaEmpresaMontaje

    Sub Nueva()
        Me.EmpresasContratadasMontajeTableAdapter.Fill(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.EmpresasContratadasMontajeBindingSource.AddNew()
        Show()
    End Sub

    Private Sub EmpresasContratadasMontajeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresasContratadasMontajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresasContratadasMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmNuevaEmpresaMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagosMontaje.EmpresasContratadasMontaje' Puede moverla o quitarla según sea necesario.


    End Sub


End Class