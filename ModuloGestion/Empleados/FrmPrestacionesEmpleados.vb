Public Class FrmPrestacionesEmpleados
    Sub CalcularTiempo()
        Dim años, meses, dias, dias_sobran As Integer
        Dim años_str, meses_str, dias_str As String
        Dim PriFec As Date = Me.EmpleadosDataGridView.CurrentRow.Cells(5).Value
        Dim SecFec As Date = Me.DateTimePicker1.Value
        Dim DiasTotales As Long = DateDiff(DateInterval.Day, PriFec, SecFec)
        años = DiasTotales \ 365
        dias_sobran = DiasTotales Mod 365
        meses = dias_sobran \ 30
        dias = dias_sobran Mod 30
        If (años > 0) Then
            años_str = años & " año(s) "
        Else
            años_str = ""
        End If
        If (meses > 0) Then
            meses_str = meses & " mes(es) "
        Else
            meses_str = ""
        End If
        If (dias > 0) Then
            dias_str = dias & " dia(s)"
        Else
            dias_str = ""
        End If
        txtperiodo.Text = Trim(años_str & meses_str & dias_str)
        'txtperiodo.Text = años & " año(s), " & meses & " mes(es), " & dias & " dia(s)"
    End Sub
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub

    Private Sub FrmPrestacionesEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpleados.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, True)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CalcularTiempo()
    End Sub

    Private Sub EmpleadosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellClick
        CalcularTiempo()
    End Sub

    Private Sub EmpleadosBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigator.RefreshItems
        Try
            CalcularTiempo()
        Catch ex As Exception

        End Try

    End Sub
End Class