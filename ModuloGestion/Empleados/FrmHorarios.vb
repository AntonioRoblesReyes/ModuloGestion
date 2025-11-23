Imports System.Math
Public Class FrmHorarios

    Sub Totales()
        Try


            Dim TotaLHoras As Double = 0
            Dim TotalNomina As Double = 0
            Dim TotalExtra1 As Double = 0
            Dim TotalExtra2 As Double = 0
            Dim TotalExtra3 As Double = 0


            For Each row As DataGridViewRow In Me.HorariosEmpleadosDataGridView.Rows
                TotaLHoras += Val(row.Cells("TotalView").Value)
                TotalNomina += Val(row.Cells("TotalrdView").Value)
                TotalExtra1 += Val(row.Cells("TotalrdView").Value)
                TotalExtra2 += Val(row.Cells("TotalrdView").Value)
                TotalExtra3 += Val(row.Cells("TotalrdView").Value)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Inicio()
        Try


            Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, True)

            Me.CalendarioTableAdapter.Fill(Me.DsEmpleados.Calendario)
            Me.NominasTableAdapter.Fill(Me.DsEmpleados.Nominas)
            Me.HorariosEmpleadosTableAdapter.Fill(Me.DsEmpleados.HorariosEmpleados)


            Me.TextBox1.Text = Format(8, "#,##0.00")
            Me.TextBox2.Text = Format(12, "#,##0.00")
            Me.TextBox3.Text = Format(13, "#,##0.00")
            Me.TextBox4.Text = Format(17, "#,##0.00")



            Me.Show()
            nombre()
            FiltrarFecha()
        Catch ex As Exception

        End Try

    End Sub
    Sub FiltrarFecha()
        Dim fecha As Date = Microsoft.VisualBasic.Left(CStr(DateTimePicker1.Value), 10)

        Me.CalendarioTableAdapter.FillByIdFecha(Me.DsEmpleados.Calendario, fecha)
        Dim Quincenas As String = Me.DsEmpleados.Calendario(Me.CalendarioBindingSource.Position).Quincena
        Me.NominasTableAdapter.FillByQuincena(Me.DsEmpleados.Nominas, Quincenas)
        Dim estado As Integer = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Cerrada
        'MsgBox(Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Cerrada)
        If estado = True Then
            Me.Button2.Enabled = False
            Me.HorariosEmpleadosDataGridView.Enabled = False
        ElseIf estado = False Then
            Me.Button2.Enabled = True
            Me.HorariosEmpleadosDataGridView.Enabled = True
        End If
        Me.HorariosEmpleadosTableAdapter.FillByQuincena(Me.DsEmpleados.HorariosEmpleados, CedulaTextBox.Text, Quincenas)
    End Sub
    Sub CalculoHoras()
        Try

            Dim horaentradamanana As Double = Round(CDbl(TextBox1.Text) - 0.1)
            Dim minutosentradamanana As Double = Round((CDbl(TextBox1.Text) - horaentradamanana) / 60 * 100, 2)
            Dim entradMananas As Double = horaentradamanana + minutosentradamanana

            Dim horasalidamanana As Double = Round(CDbl(TextBox2.Text) - 0.1)
            Dim minutossalidaamanana As Double = Round((CDbl(TextBox2.Text) - horasalidamanana) / 60 * 100, 2)
            Dim SalidaMananas As Double = horasalidamanana + minutossalidaamanana

            Dim horaentradatarde As Double = Round(CDbl(TextBox3.Text) - 0.1)
            Dim minutosentradatarde As Double = Round((CDbl(TextBox3.Text) - horaentradatarde) / 60 * 100, 2)
            Dim entradtarde As Double = horaentradatarde + minutosentradatarde


            Dim horasalidaTarde As Double = Round(CDbl(TextBox4.Text) - 0.1)
            Dim minutossalidatarde As Double = Round((CDbl(TextBox4.Text) - horasalidaTarde) / 60 * 100, 2)
            Dim Salidatarde As Double = horasalidaTarde + minutossalidatarde

            Dim totalhoras As Double = (SalidaMananas - entradMananas) + (Salidatarde - entradtarde)
            FiltrarFecha()
            Dim diaSemana As String = Me.DsEmpleados.Calendario(Me.CalendarioBindingSource.Position).TipoDia
            Dim Quincena As String = Me.DsEmpleados.Calendario(Me.CalendarioBindingSource.Position).Quincena
            Dim fechaunion As Date = CStr(DateTimePicker1.Value)
            Dim ano As String = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(fechaunion, 10), 4)
            Dim Mes As String = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(fechaunion, 5), 2)
            Dim dia As String = Microsoft.VisualBasic.Left(fechaunion, 2)
            Dim idregistro As String = ano & "-" & Mes & "-" & dia & "-" & CedulaTextBox.Text
            Me.HorariosEmpleadosTableAdapter.FillByComprobacion(DsEmpleados.HorariosEmpleados, idregistro)
            Dim verificarRegistro As Integer = Me.DsEmpleados.Tables("HorariosEmpleados").Rows.Count


            If diaSemana = "Jornada" Then


                Select Case totalhoras
                    Case 0 To 8
                        Me.Label9.Text = totalhoras
                        Me.Label11.Text = 0
                        Me.Label12.Text = 0
                        Me.Label13.Text = 0
                    Case 8.01 To 11
                        Me.Label9.Text = 8
                        Me.Label11.Text = totalhoras - 8
                        Me.Label12.Text = 0
                        Me.Label13.Text = 0
                    Case 11.01 To 24
                        Me.Label9.Text = 8
                        Me.Label11.Text = 3
                        Me.Label12.Text = totalhoras - 11
                        Me.Label13.Text = 0



                End Select
            ElseIf diaSemana = "Media Jornada" Then
                Select Case totalhoras

                    Case 0 To 4

                        Me.Label9.Text = totalhoras
                        Me.Label11.Text = 0
                        Me.Label12.Text = 0
                        Me.Label13.Text = 0
                    Case 4.01 To 24
                        Me.Label9.Text = 4
                        Me.Label11.Text = 0
                        Me.Label12.Text = 0
                        Me.Label13.Text = totalhoras - 4

                End Select
            ElseIf diaSemana = "Festivo" Then
                Select Case totalhoras
                    Case 0 To 24
                        'MsgBox(totalhoras)
                        Me.Label9.Text = 0
                        Me.Label11.Text = 0
                        Me.Label12.Text = 0
                        Me.Label13.Text = totalhoras

                End Select

            End If
            Me.Label9.Text = Format(CDbl(Label9.Text), "#,##0.00")
            Me.Label11.Text = Format(CDbl(Label11.Text), "#,##0.00")
            Me.Label12.Text = Format(CDbl(Label12.Text), "#,##0.00")
            Me.Label13.Text = Format(CDbl(Label13.Text), "#,##0.00")

            If verificarRegistro = 0 Then

                Me.HorariosEmpleadosTableAdapter.Insertar(idregistro, fechaunion, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, CedulaTextBox.Text, diaSemana, totalhoras, Label9.Text, Label11.Text, Label12.Text, Label13.Text, Quincena, TextBox5.Text)
                FiltrarFecha()
                MsgBox("El registro se guardo correctamente")
            Else
                Dim msg As String
                Dim title As String
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                msg = "El Registro ya fue creado"
                style = MsgBoxStyle.DefaultButton2 Or _
                   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                title = "Modificar Registro"   ' Define title.
                ' Display message.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then   ' User chose Yes.
                    Me.HorariosEmpleadosTableAdapter.Eliminar(idregistro)
                    Me.HorariosEmpleadosTableAdapter.Insertar(idregistro, fechaunion, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, CedulaTextBox.Text, diaSemana, totalhoras, Label9.Text, Label11.Text, Label12.Text, Label13.Text, Quincena, TextBox5.Text)

                    FiltrarFecha()
                    MsgBox("El registro se modifico correctamente")
                Else

                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Nombre()
        Me.Label1.Text = NombreTextBox.Text & " " & Apellido1TextBox.Text & " " & Apellido2TextBox.Text


    End Sub
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub



    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.Leave
        Me.TextBox1.Text = Format(CDbl(Me.TextBox1.Text), "#,##0.00")
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.Leave
        Me.TextBox2.Text = Format(CDbl(Me.TextBox2.Text), "#,##0.00")
    End Sub
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.Leave
        Me.TextBox3.Text = Format(CDbl(Me.TextBox3.Text), "#,##0.00")
    End Sub
    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.Leave
        Me.TextBox4.Text = Format(CDbl(Me.TextBox4.Text), "#,##0.00")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        calculoHoras()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        FiltrarFecha()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        calculoHoras()
    End Sub


    Private Sub EmpleadosBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingNavigator.RefreshItems

        Try
            nombre()
            FiltrarFecha()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmHorarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
    End Sub

    Private Sub HorariosEmpleadosDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles HorariosEmpleadosDataGridView.RowsRemoved
        Try
            Me.Validate()
            Me.HorariosEmpleadosBindingSource.EndEdit()
            Me.HorariosEmpleadosTableAdapter.Update(Me.DsEmpleados)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.FrmIngresoQuincena.Close()
        My.Forms.FrmIngresoQuincena.Show()

    End Sub


End Class