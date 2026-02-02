Imports System.IO
Public Class FrmEmpleados
    Sub Pruebas()

        '    Try
        '        Dim date1 As Date = CDate(Me.FechaSalidaDateTimePicker.Value)
        '        Dim date2 As Date = CDate(FechaSalidaDateTimePicker.Value)
        '        If date2.Year < date1.Year Then
        '            Me.LabelResult.Text = "Rango de fechas es invalido"
        '        ElseIf date2.Month < date1.Month Then
        '            Me.LabelResult.Text = "Rango de fechas es invalido"
        '        Else
        '            Me.LabelResult.Text = "Su edad actual es: " & CStr(date2.Year - date1.Year) & " Años y " & CStr(date2.Month - date1.Month) & " meses"
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, "Error")
        '    End Try


    End Sub
    Sub CalcularTiempo()

        Try


            Dim años, meses, dias, dias_sobran As Integer
            Dim años_str, meses_str, dias_str As String
            Dim PriFec As Date = Me.DsEmpleados.Empleados(Me.EmpleadosBindingSource.Position).FechaEntrada
            Dim SecFec As Date = Date.Now
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
            Label10.Text = Trim(años_str & meses_str & dias_str)
            'txtperiodo.Text = años & " año(s), " & meses & " mes(es), " & dias & " dia(s)"
        Catch ex As Exception

        End Try
    End Sub
    Sub Totales()
        Dim nomina As Double = 0
        Dim Horas35 As Double = 0
        Dim Horas50 As Double = 0
        Dim Horas100 As Double = 0
        Dim Seguro As Double = 0
        Dim Ars As Double = 0
        Dim Renta As Double = 0
        Dim Liquido As Double = 0
        Dim SeguroEmpresa As Double = 0
        Dim ArsEmpresa As Double = 0
        Dim TotalEmpresa As Double = 0


        For Each row As DataGridViewRow In Me.NominasDetalleDataGridView.Rows
            nomina += Val(row.Cells(2).Value)
            Horas35 += Val(row.Cells(3).Value)
            Horas50 += Val(row.Cells(4).Value)
            Horas100 += Val(row.Cells(5).Value)
            Seguro += Val(row.Cells(7).Value)
            Ars += Val(row.Cells(9).Value)
            Renta += Val(row.Cells(11).Value)
            Liquido += Val(row.Cells(12).Value)
            SeguroEmpresa += Val(row.Cells(8).Value)
            ArsEmpresa += Val(row.Cells(10).Value)
            TotalEmpresa += Val(row.Cells(13).Value)

        Next
        Me.LblNomina.Text = Format(nomina, "#,##0.00")
        Me.Lbl35.Text = Format(Horas35, "#,##0.00")
        Me.Lbl50.Text = Format(Horas50, "#,##0.00")
        Me.Lbl100.Text = Format(Horas100, "#,##0.00")
        Me.LblSeguro.Text = Format(Seguro, "#,##0.00")
        Me.LblArs.Text = Format(Ars, "#,##0.00")
        Me.LblRenta.Text = Format(Renta, "#,##0.00")
        Me.LblLiquido.Text = Format(Liquido, "#,##0.00")

        Me.LblSeguroEmpresa.Text = Format(SeguroEmpresa, "#,##0.00")
        Me.LblArsEmpresa.Text = Format(ArsEmpresa, "#,##0.00")
        Me.LblTotalEmpresa.Text = Format(TotalEmpresa, "#,##0.00")

    End Sub
    Sub MantenimientoEmpleadosActivos()
        Try
            Me.CategoriaTableAdapter.Fill(Me.DsEmpleados.Categoria)
            Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, True)
            Me.Show()
            Me.NominasDetalleTableAdapter.FillByCedula(Me.DsEmpleados.NominasDetalle, CedulaTextBox.Text)
            Totales()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub MantenimientoEmpleadosInActivos()
        Try
            Me.CategoriaTableAdapter.Fill(Me.DsEmpleados.Categoria)
            Me.EmpleadosTableAdapter.FillByActivos(Me.DsEmpleados.Empleados, False)
            Me.Show()
            Me.NominasDetalleTableAdapter.FillByCedula(Me.DsEmpleados.NominasDetalle, CedulaTextBox.Text)
            Totales()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub NuevoEmpleado()
        Try
            Me.CategoriaTableAdapter.Fill(Me.DsEmpleados.Categoria)
            Me.EmpleadosTableAdapter.Fill(Me.DsEmpleados.Empleados)
            'Me.Validate()
            'Me.EmpleadosBindingSource.AddNew()
            'Dim siguiente As String = Me.EmpleadosTableAdapter.Siguiente()
            'Me.IdEmpleadoTextBox.Text = siguiente

            FechaSalidaDateTimePicker.Visible = False
            PuestoComboBox.Enabled = False
            PuestoTextBox.Visible = False
            Me.Show()
            Me.EmpleadosBindingSource.AddNew()
            EstadoCheckBox.Checked = False
            EstadoCheckBox.Text = "Pendiente"
            Me.IdEmpleadoTextBox.Text = Me.EmpleadosTableAdapter.Siguiente
            Me.IdEmpleadoTextBox.Enabled = False
            Me.DescripcionCategoriaComboBox.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Try


            Me.Validate()
            Me.EmpleadosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
        'TODO: esta línea de código carga datos en la tabla 'DsEmpleados.NominasDetalle' Puede moverla o quitarla según sea necesario.
        Me.NominasDetalleTableAdapter.Fill(Me.DsEmpleados.NominasDetalle)


        MdiParent = My.Forms.FrmContabilidad

    End Sub

    Private Sub EstadoCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles EstadoCheckBox.CheckedChanged
        If EstadoCheckBox.Checked = True Then
            EstadoCheckBox.Text = "Activo"
        ElseIf EstadoCheckBox.Checked = False Then
            EstadoCheckBox.Text = "Cancelado"
        Else
            EstadoCheckBox.Text = "Pendiente"

        End If
    End Sub

    Private Sub BtnCargarFoto_Click(sender As System.Object, e As System.EventArgs) Handles BtnCargarFoto.Click



        Try


            Dim archivo As String
            OpenFileDialog1.ShowDialog()
            Path.GetFileName(FotografiaTextBox.Text)
            archivo = OpenFileDialog1.FileName
            Me.FotografiaTextBox.Text = "\\antonio-dell\Public\Carpeta Datos\Imajenes\Fotos Empleados\" + Path.GetFileName(Me.OpenFileDialog1.FileName)
            Me.PictureBox1.Image = Image.FromFile(Me.FotografiaTextBox.Text)




        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
            MsgBox(ex.Message)
        End Try
        '



    End Sub


    Private Sub DescripcionCategoriaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionCategoriaComboBox.SelectedIndexChanged
        Me.CategoriaTextBox.Text = DescripcionCategoriaComboBox.Text
        If DescripcionCategoriaComboBox.Text <> "" Then

            Me.CategoriaPuestoTableAdapter.FillByIdCategoria(Me.DsEmpleados.CategoriaPuesto, DescripcionCategoriaComboBox.SelectedValue)

            PuestoTextBox.Visible = True
            PuestoComboBox.Enabled = True
        End If

    End Sub

    Private Sub PuestoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles PuestoComboBox.SelectedIndexChanged
        PuestoTextBox.Text = PuestoComboBox.Text
    End Sub

    Private Sub EmpleadosBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingNavigator.RefreshItems
        Me.NominasDetalleTableAdapter.FillByCedula(Me.DsEmpleados.NominasDetalle, CedulaTextBox.Text)
        Totales()
        CalcularTiempo()
    End Sub

    Private Sub FechaEntradaLabel_Click(sender As Object, e As EventArgs)
        Pruebas()
    End Sub

End Class