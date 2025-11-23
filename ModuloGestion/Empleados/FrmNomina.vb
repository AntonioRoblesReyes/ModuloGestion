Imports System.Math


Public Class FrmNomina
    Sub AplicarPagoAvance()
        Dim cedula As String = Me.DsEmpleados.NominasDetalle(Me.NominasDetalleBindingSource.Position).Cedula
        Dim nomina As String = Me.DsEmpleados.NominasDetalle(Me.NominasDetalleBindingSource.Position).Cedula

    End Sub

    Sub Avances()
        Dim cedula As String = Me.DsEmpleados.NominasDetalle(Me.NominasDetalleBindingSource.Position).Cedula
        Me.AvanceEmpleadosTableAdapter.FillByCedula(Me.DsEmpleados.AvanceEmpleados, cedula)
        Dim registro As Integer = Me.AvanceEmpleadosDataGridView.RowCount
        Me.Label3.Text = 0
        If registro <> 0 Then
            Dim IdAvance As String = Me.DsEmpleados.AvanceEmpleados(Me.AvanceEmpleadosBindingSource.Position).IdAvanceEmpleado
            Dim Adelantado As String = Me.DsEmpleados.AvanceEmpleados(Me.AvanceEmpleadosBindingSource.Position).TotalAvance
            Me.AvnceEmpleadosPagosTableAdapter.FillByPagoAvance(Me.DsEmpleados.AvnceEmpleadosPagos, Me.ComboBox1.SelectedValue, IdAvance)
            Dim IdPago As String = Me.DsEmpleados.AvnceEmpleadosPagos(Me.AvnceEmpleadosPagosBindingSource.Position).IdPagoAvanceEmpleado
            Dim aplicado As Integer = Me.DsEmpleados.AvnceEmpleadosPagos(Me.AvnceEmpleadosPagosBindingSource.Position).Aplicado
            Dim montoAplicar As Double = Me.DsEmpleados.AvnceEmpleadosPagos(Me.AvnceEmpleadosPagosBindingSource.Position).Monto

            Me.AvnceEmpleadosPagosTableAdapter.AplicarPago(IdPago)
            Dim TotalAbonado As Double = Me.AvnceEmpleadosPagosTableAdapter.TotalPagado(IdAvance)
            Dim Pendiente As Double = Adelantado - TotalAbonado
            Me.AvanceEmpleadosTableAdapter.ActulizarSaldo(TotalAbonado, Pendiente, IdAvance)
            Me.Label3.Text = montoAplicar
        End If

    End Sub

    Sub IngresoNominas()

        Try

            Try
                Me.CalendarioTableAdapter.FillByDiasPorQuincena(Me.DsEmpleados.Calendario, ComboBox1.Text)
                Dim festivo As Integer = 0


                Dim iTotal As Integer = Me.DsEmpleados.Tables("calendario").Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
                'Definimos la variable i para controlar el ciclo for
                Dim i As Integer
                'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
                For i = 0 To iTotal - 1
                    Dim tipodia As String = Me.DsEmpleados.Calendario(Me.CalendarioBindingSource.Position).TipoDia
                    Dim Diasemana As String = Me.DsEmpleados.Calendario(Me.CalendarioBindingSource.Position).DiaSemana
                    If tipodia = "Festivo" Then
                        If Diasemana = "sabado" Then
                            festivo += 0.5
                        ElseIf Diasemana = "Domingo" Then
                            festivo += 0
                        Else
                            festivo += 1
                        End If


                    End If

                    Me.CalendarioBindingSource.MoveNext()
                Next



                Dim HorasNomina As Double = 0
                Dim festivos As Double = festivo

                For Each row As DataGridViewRow In Me.CalendarioDataGridView.Rows
                    HorasNomina += Val(row.Cells(4).Value)


                Next
                Dim Jornada As Double = HorasNomina + (festivo * 8)
                Me.Label2.Text = CDbl(Jornada)
                Me.Label6.Text = CDbl(festivo)




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim Quincena As String = Me.ComboBox1.SelectedValue
            Dim datos As Integer = Me.DsEmpleados.Tables("HorariosEmpleados").Rows.Count
            If datos <> 0 Then
                Me.EmpleadosBindingSource.MoveFirst()
                Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, True)

                Dim iTotal As Integer = Me.DsEmpleados.Tables("Empleados").Rows.Count

                Me.NominasDetalleTableAdapter.EliminarDatos(Quincena)
                Me.NominasDetalleTableAdapter.FillByIdNomina(DsEmpleados.NominasDetalle, Quincena)
                Me.AvnceEmpleadosPagosTableAdapter.EliminarPagoAvance(Quincena)
                Dim i As Integer

                For i = 0 To iTotal - 1


                    Dim Cedula As String = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Cedula


                    Dim Nomina As String = Me.ComboBox1.SelectedValue
                    Try
                        Me.AvnceEmpleadosPagosTableAdapter.FillByPagoAvanceQuincena(DsEmpleados.AvnceEmpleadosPagos, Nomina, Cedula)
                        Dim Registro As Integer = 0

                        ' Accede directamente a la tabla AvanceEmpleadosPagos
                        Dim AvnceEmpleadosPagos As DataTable = DsEmpleados.Tables("AvnceEmpleadosPagos")

                        ' Obtiene el número de registros en la tabla AvanceEmpleadosPagos
                        Registro = AvnceEmpleadosPagos.Rows.Count

                        If Registro > 0 Then
                            ' Suma los valores de la columna "monto"
                            Dim totalMonto As Decimal = 0

                            For Each fila As DataRow In AvnceEmpleadosPagos.Rows
                                totalMonto += Convert.ToDecimal(fila("monto")) ' Suma el valor de la columna "monto"

                                Me.Label3.Text = totalMonto.ToString("n2")
                                Me.AvnceEmpleadosPagosTableAdapter.AplicarPagoAvance(Quincena)
                            Next



                        End If


                    Catch ex As Exception

                    End Try

                    Dim avance As Double
                    Try
                        avance = Me.AvnceEmpleadosPagosTableAdapter.PagoAvances(Cedula, Nomina)
                    Catch ex As Exception
                        avance = 0
                    End Try


                    Dim IdNomina As String = Nomina & "-" & Cedula
                    Me.HorariosEmpleadosTableAdapter.FillByQuincena(Me.DsEmpleados.HorariosEmpleados, Cedula, Nomina)
                    Dim totalHoras As Double = 0
                    Dim totalHorasNomina As Double = 0
                    Dim totalHorasExtras1 As Double = 0
                    Dim totalHorasExtras2 As Double = 0
                    Dim totalHorasExtras3 As Double = 0
                    Dim sueldo As Double = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Sueldo
                    Dim PrecioHoraNormal As Double = Round(sueldo / 23.83 / 8, 2)
                    Dim PrecioExtra1 As Double = Round(PrecioHoraNormal * 1.35, 2)
                    Dim PrecioExtra2 As Double = Round(PrecioHoraNormal * 1.5, 2)
                    Dim PrecioExtra3 As Double = Round(PrecioHoraNormal * 2, 2)

                    For Each row As DataGridViewRow In Me.HorariosEmpleadosDataGridView.Rows
                        totalHoras += Val(row.Cells("TotalHorasH").Value)
                        totalHorasNomina += Val(row.Cells("HorasNominaH").Value)

                        totalHorasExtras1 += Val(row.Cells("HorasExtras1H").Value)
                        totalHorasExtras2 += Val(row.Cells("HorasExtras2H").Value)
                        totalHorasExtras3 += Val(row.Cells("HorasExtras3H").Value)


                    Next

                    'Dim nominavalor As Double = 0
                    Dim NominaCumpliada As Double = (sueldo / 2 / CDbl(Label2.Text)) * CDbl(totalHorasNomina + (Label6.Text * 8))



                    Dim totalnomina As Double = NominaCumpliada



                    Dim totalExtras1 As Double = Round(PrecioExtra1 * totalHorasExtras1, 2)
                    Dim totalExtras2 As Double = Round(PrecioExtra2 * totalHorasExtras2, 2)
                    Dim totalExtras3 As Double = Round(PrecioExtra3 * totalHorasExtras3, 2)
                    Dim totalGenerado As Double = totalnomina + totalExtras1 + totalExtras2 + totalExtras3
                    Dim SeguroAfiliado As Double = Round(totalGenerado * (Me.DsEmpleados.SeguroSocial(Me.SeguroSocialBindingSource.Position).SeguroAfiliado / 100), 2)
                    Dim PensionAfiliado As Double = Round(totalGenerado * (Me.DsEmpleados.SeguroSocial(Me.SeguroSocialBindingSource.Position).PensionAfiliado / 100), 2)
                    Me.NominasTableAdapter.FillByMes(Me.DsEmpleados.Nominas, ComboBox1.Text)
                    Dim mes As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Mes

                    Dim totalmes As Double = Me.NominasDetalleTableAdapter.GanadoMes(mes, Cedula) + totalGenerado


                    Me.RentaTableAdapter.FillByRenta(Me.DsEmpleados.Renta, totalmes)


                    Dim IdImpuesto As Double = Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).idRenta

                    Dim minimo As Double = Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).Minimo
                    Dim Adcional As Double = Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).Adiconal
                    Dim Renta As Double = 0

                    Select Case IdImpuesto
                        Case 1
                            Renta = Round(totalmes * Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).Tasa, 2)
                        Case 2

                            Renta = Round((totalmes - minimo) * Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).Tasa, 2)
                        Case 3
                            Renta = Round(((totalmes - minimo) * Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).Tasa) + Adcional, 2)
                        Case 4
                            Renta = Round(((totalmes - minimo) * Me.DsEmpleados.Renta(Me.RentaBindingSource.Position).Tasa) + Adcional, 2)
                    End Select
                    Dim SeguroAdicional As Double = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).SeguroAdicional / 2
                    Dim totalliquido As Double = totalGenerado - SeguroAfiliado - PensionAfiliado - Renta - avance - SeguroAdicional
                    Dim SeguroEmpleador As Double = Round(totalGenerado * (Me.DsEmpleados.SeguroSocial(Me.SeguroSocialBindingSource.Position).SeguroEmpleador / 100), 2)
                    Dim PensionEmpleador As Double = Round(totalGenerado * (Me.DsEmpleados.SeguroSocial(Me.SeguroSocialBindingSource.Position).PensionEmpleador / 100), 2)
                    Dim TotalEmpresa As Double = totalliquido + PensionEmpleador + SeguroEmpleador
                    Dim totalliquidoBanco As Double = (totalGenerado - SeguroAfiliado - PensionAfiliado - Renta - avance - SeguroAdicional).ToString().Replace(",", ".")

                    Try


                        Me.NominasDetalleTableAdapter.NuevoDetalle(Nomina, IdNomina, Cedula, totalHoras, totalHorasNomina, totalHorasExtras1, totalHorasExtras2, totalHorasExtras3, sueldo, PrecioHoraNormal, PrecioExtra1, PrecioExtra2, PrecioExtra3, totalnomina, totalExtras1, totalExtras2, totalExtras3, totalGenerado, SeguroAfiliado, PensionAfiliado, Renta, totalliquido, PensionEmpleador, SeguroEmpleador, TotalEmpresa, avance, SeguroAdicional)
                    Catch ex As Exception
                        'Me.NominasDetalleTableAdapter.NuevoDetalle(Nomina, IdNomina, Cedula, 0, 0, 0, 0, 0, sueldo, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                    End Try
                    Me.EmpleadosBindingSource.MoveNext()

                Next

            End If
            MsgBox("Nomina generada correctamente")
            Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Quincena)
        Catch ex As Exception
            MsgBox(ex.Message & " aqui")
        End Try
        Me.AvanceEmpleadosTableAdapter.ActulizarSaldoAvances()
    End Sub

    Private Sub RentaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub

    Private Sub FrmNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)

        Try
            ' Cargar datos en las tablas del dataset DsEmpleados
            CargarDatos()

            ' Marcar RadioButton1 como seleccionado
            Me.RadioButton1.Checked = True

            ' Obtener el valor seleccionado en ComboBox1 para Quincena
            Dim Quincena As String = Me.ComboBox1.SelectedValue

            ' Llenar los detalles de la nómina y horarios de empleados con el valor de Quincena
            Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Quincena)
            Me.HorariosEmpleadosTableAdapter.FillByPeriodo(Me.DsEmpleados.HorariosEmpleados, Quincena)

        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarDatos()
        ' Llenar las tablas con los datos del dataset DsEmpleados
        Me.AvnceEmpleadosPagosTableAdapter.Fill(Me.DsEmpleados.AvnceEmpleadosPagos)
        Try
            'Me.CalendarioTableAdapter.Fill(Me.DsEmpleados.Calendario)
        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar los calendario: " & ex.Message)
        End Try

        Me.AvanceEmpleadosTableAdapter.Fill(Me.DsEmpleados.AvanceEmpleados)
        Me.HorariosEmpleadosTableAdapter.Fill(Me.DsEmpleados.HorariosEmpleados)
        Me.EmpleadosTableAdapter.Fill(Me.DsEmpleados.Empleados)
        Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)
        Me.SeguroSocialTableAdapter.Fill(Me.DsEmpleados.SeguroSocial)
        Me.RentaTableAdapter.Fill(Me.DsEmpleados.Renta)
    End Sub




    Private Sub RentaBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub



    Private Sub BtnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimir.Click

        My.Forms.ImpReciboNomina.Close()
        My.Forms.ImpReciboNomina.ImrimirRecibos()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        My.Forms.ImpReciboNomina.Close()
        My.Forms.ImpReciboNomina.ImrimirNominaCompleta()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Quincena As String = Me.ComboBox1.SelectedValue

        'AvnceEmpleadosPagosTableAdapter.ActulizarPago(Quincena)

        IngresoNominas()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)
            Dim Quincena As String = Me.ComboBox1.SelectedValue
            Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Quincena)
            Me.HorariosEmpleadosTableAdapter.FillByPeriodo(Me.DsEmpleados.HorariosEmpleados, Quincena)
            Me.Button2.Visible = True
            Me.NominasTableAdapter.FillByQuincena(Me.DsEmpleados.Nominas, Quincena)
            Dim empieza As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Empieza
            Dim termina As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Termina
            Me.Label1.Text = "Nomina del " & empieza & " al " & termina
            Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)


        Else
            Me.NominasTableAdapter.FillByCerrada(Me.DsEmpleados.Nominas)
            Dim Quincena As String = Me.ComboBox1.SelectedValue
            Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Quincena)
            Me.HorariosEmpleadosTableAdapter.FillByPeriodo(Me.DsEmpleados.HorariosEmpleados, Quincena)
            Me.Button2.Visible = False
            Me.NominasTableAdapter.FillByQuincena(Me.DsEmpleados.Nominas, Quincena)
            Dim empieza As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Empieza
            Dim termina As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Termina
            Me.Label1.Text = "Nomina del " & empieza & " al " & termina
            Me.NominasTableAdapter.FillByAbierta(Me.DsEmpleados.Nominas)
        End If
    End Sub



    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            Me.NominasTableAdapter.CerrarQincena(Me.ComboBox1.Text)
            MsgBox("la quincena " & ComboBox1.Text & " se cerro corectamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub





    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.CalendarioTableAdapter.FillByDiasPorQuincena(Me.DsEmpleados.Calendario, ComboBox1.Text)
            Dim HorasNomina As Double = 0
            For Each row As DataGridViewRow In Me.CalendarioDataGridView.Rows
                HorasNomina += Val(row.Cells(4).Value)


            Next
            Dim Jornada As Double = HorasNomina
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnArchivoBanco_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchivoBanco.Click

        Try


            Dim Intru As Object
            Dim archivo As Object
            Dim Nomina As String = DateTime.Now.ToString("ddMMyyyy")
            Dim pc As String = My.Computer.Name
            Dim i As Integer
            'MsgBox(Nomina)
            Intru = CreateObject("Scripting.FileSystemObject")
            archivo = Intru.CreateTextFile("\\" & pc & "\d\Carpeta Datos\Nominas Banco\" & "PAGO " & Nomina & ".txt", True)

            Dim Empleados As Integer = Me.NominasDetalleDataGridView.RowCount()
            ' MsgBox(Empleados)
            Me.NominasDetalleBindingSource.MoveFirst()
            For i = 0 To Empleados - 1

                Dim cedula As String = Me.NominasDetalleDataGridView.CurrentRow.Cells(2).Value
                Dim TotalLiquido As String = Format(Me.DsEmpleados.NominasDetalle(Me.NominasDetalleBindingSource.Position).TotalLiquido + 0.0001, "##0.00")


                Dim totalBancoString As String = TotalLiquido.ToString() ' Convierte el número en una cadena
                totalBancoString = totalBancoString.Replace(",", ".") ' Reemplaza la coma por un punto







                Me.EmpleadosTableAdapter.FillByCedula(Me.DsEmpleados.Empleados, cedula)
                Dim Nombre As String = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Nombre
                Dim Apellido1 As String = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Apellido1
                Dim Apellido2 As String = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).Apellido2
                Dim NombreCompleto As String
                If String.IsNullOrEmpty(Apellido2) Then
                    NombreCompleto = Apellido1 & " " & Nombre

                    NombreCompleto = NombreCompleto.Replace("ñ", "n")
                    NombreCompleto = NombreCompleto.Replace("Ñ", "N")

                Else
                    NombreCompleto = Apellido1 & " " & Apellido2 & " " & Nombre
                    NombreCompleto = NombreCompleto.Replace("ñ", "n")
                    NombreCompleto = NombreCompleto.Replace("Ñ", "N")
                End If
                ' MsgBox(NombreCompleto)
                Dim Cuenta As String = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).NumeroCuentaBanco
                If Cuenta <> "Sin Numero" Then

                    Dim Linea As String = "100017100007829," & Cuenta & "," & totalBancoString & "," & Microsoft.VisualBasic.Left(NombreCompleto, 40)
                    archivo.writeLine(Linea)
                End If



                Me.NominasDetalleBindingSource.MoveNext()
            Next
            archivo.close()
            Process.Start("notepad.exe", "\\" & pc & "\d\Carpeta Datos\Nominas Banco\" & "PAGO " & Nomina & ".txt")
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NominasDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NominasDetalleDataGridView.CellClick
        Avances()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Quincena As String = Me.ComboBox1.SelectedValue
        Me.NominasTableAdapter.FillByMes(Me.DsEmpleados.Nominas, Quincena)
        Dim mes As String = Me.DsEmpleados.Nominas(Me.NominasBindingSource.Position).Mes

        My.Forms.ImpReciboNomina.Label1.Text = mes
        My.Forms.ImpReciboNomina.ImprirTSS()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        My.Forms.ImpReciboNomina.Close()
        My.Forms.ImpReciboNomina.LblAño.Text = TextBox1.Text
        If RadioButton3.Checked = True Then
            My.Forms.ImpReciboNomina.LblTipo.Text = "B"
        ElseIf RadioButton5.Checked = True Then
            My.Forms.ImpReciboNomina.LblTipo.Text = "N"
        ElseIf RadioButton4.Checked = True Then
            My.Forms.ImpReciboNomina.LblTipo.Text = "v"

        End If


        My.Forms.ImpReciboNomina.ImprirBonos()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Me.NominasTableAdapter.FillByCerrada(DsEmpleados.Nominas)
        End If
    End Sub
End Class