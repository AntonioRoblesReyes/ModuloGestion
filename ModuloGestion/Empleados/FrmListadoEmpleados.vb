Public Class FrmListadoEnpleados
    Sub Activos()
        Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, True)
        Me.Label3.Text = Me.DsEmpleados.Tables("Empleados").Rows.Count
        Me.Show()
    End Sub
    Sub InActivos()
        Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, vbFalse)
        Me.Label3.Text = Me.DsEmpleados.Tables("Empleados").Rows.Count
        Me.Show()
    End Sub
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub

    Private Sub FrmListadoEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub TextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox.TextChanged
        Me.EmpleadosTableAdapter.FillByBuscar(Me.DsEmpleados.Empleados, "%" & TextBox.Text & "%")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        My.Forms.FrmEmpleados.Close()
        My.Forms.FrmEmpleados.NuevoEmpleado()
    End Sub

    Private Sub BtnAvanceEmpleados_Click(sender As System.Object, e As System.EventArgs) Handles BtnAvanceEmpleados.Click
        My.Forms.FrmAvanceEmpleados.Close()
        My.Forms.FrmAvanceEmpleados.CedulaTextBox.Text = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Cedula

        My.Forms.FrmAvanceEmpleados.LblNombre.Text = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Nombre & " " & Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Apellido1 & " " & Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Apellido2
        My.Forms.FrmAvanceEmpleados.Avances()
    End Sub
End Class