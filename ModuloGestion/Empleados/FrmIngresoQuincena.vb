
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class FrmIngresoQuincena


    Private Sub FrmIngresoQuincena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorariosEmpleadosTableAdapter.Fill(Me.DsEmpleados.HorariosEmpleados)
        Me.CalendarioTableAdapter.Fill(Me.DsEmpleados.Calendario)
        Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, 1)
        Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)
        Me.CalendarioTableAdapter.FillByDiasPorQuincena(Me.DsEmpleados.Calendario, QuincenaComboBox.Text)
        Me.TextBox1.Text = "8"
        Me.TextBox2.Text = "12"
        Me.TextBox3.Text = "13"
        Me.TextBox4.Text = "15"
    End Sub


    Private Sub QuincenaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuincenaComboBox.SelectedIndexChanged
        Dim Qa As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Quincena
        Me.CalendarioTableAdapter.FillByQActiva(Me.DsEmpleados.Calendario, Qa)

    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Me.HorariosEmpleadosTableAdapter.EliminarHorario(QuincenaComboBox.Text)

        Try
            Dim iTotales As Integer = Me.DsEmpleados.Tables("Empleados").Rows.Count
            Dim iTotalC As Integer = Me.DsEmpleados.Tables("Calendario").Rows.Count
            Dim Qa As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Quincena

            For ir As Integer = 0 To iTotales - 1
                Dim cedula As String = Me.DsEmpleados.Empleados(ir).Cedula

                For ic As Integer = 0 To iTotalC - 1
                    Dim Tipodia As String = Me.DsEmpleados.Calendario(ic).TipoDia
                    Dim fecha1 As Date = Me.DsEmpleados.Calendario(ic).IdFecha

                    Dim ano As String = fecha1.Year.ToString()
                    Dim Mes As String = fecha1.Month.ToString("D2")
                    Dim dia As String = fecha1.Day.ToString("D2")

                    Dim fecha As String = $"{ano}-{Mes}-{dia}"
                    Dim IdNomina As String = $"{ano}-{Mes}-{dia}-{cedula}"

                    If Tipodia = "Jornada" Then
                        Me.HorariosEmpleadosTableAdapter.Insertar(IdNomina, fecha, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, cedula, "Jornada", 8, 8, 0, 0, 0, Qa, "")
                    ElseIf Tipodia = "Media Jornada" Then
                        Me.HorariosEmpleadosTableAdapter.Insertar(IdNomina, fecha, TextBox1.Text, TextBox2.Text, 0, 0, cedula, "Media Jornada", 4, 4, 0, 0, 0, Qa, "")
                    ElseIf Tipodia = "Festivo" Then
                        Me.HorariosEmpleadosTableAdapter.Insertar(IdNomina, fecha, TextBox1.Text, TextBox2.Text, 0, 0, cedula, "Media Jornada", 0, 0, 0, 0, 0, Qa, "")

                    End If
                Next
            Next

        Catch ex As Exception
            MsgBox("Error al ejecutar: " & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
        MsgBox("Horario actualizado")
        Me.Close()
    End Sub




End Class