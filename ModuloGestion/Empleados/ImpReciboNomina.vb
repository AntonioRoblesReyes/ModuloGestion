Public Class ImpReciboNomina
    Sub ImprirBonos()



        Me.PagasExtrasTableAdapter.FillByTipo(Me.DsEmpleados.PagasExtras, LblAño.Text, LblTipo.Text)

        Dim rpt As New CryreciboExtras
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub

    Sub ImprirTSS()
        Dataset()



        Me.TSSTableAdapter.FillByMes(Me.DsEmpleados.TSS, Label1.Text)

        Dim rpt As New CryTSS
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub



    Sub Dataset()

        Me.HorariosEmpleadosTableAdapter.Fill(Me.DsEmpleados.HorariosEmpleados)
        Me.AvanceEmpleadosTableAdapter.Fill(Me.DsEmpleados.AvanceEmpleados)
        Me.NominasDetalleTableAdapter.Fill(Me.DsEmpleados.NominasDetalle)
        Me.TSSTableAdapter.Fill(Me.DsEmpleados.TSS)
        Me.EmpleadosTableAdapter.Fill(Me.DsEmpleados.Empleados)


    End Sub
    Sub ImprirAvance()
        Dataset()
        Dim Recibo As String = Me.Label1.Text
        Me.AvanceEmpleadosTableAdapter.FillByIdRecibo(Me.DsEmpleados.AvanceEmpleados, Recibo)

        Dim rpt As New CryReciboAvance
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub
    Sub ImrimirNominaMes()
        Dataset()
        Dim Nomina As String = My.Forms.FrmNomina.ComboBox1.SelectedValue
        Me.NominasTableAdapter.FillByQuincena(Me.DsEmpleados.Nominas, Nomina)
        Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Nomina)

        Dim rpt As New CryNominaCompleta
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()

    End Sub
    Sub ImrimirRecibos()
        Dataset()
        Dim Nomina As String = My.Forms.FrmNomina.ComboBox1.SelectedValue
        Me.NominasTableAdapter.FillByQuincena(Me.DsEmpleados.Nominas, Nomina)
        Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Nomina)
        Me.HorariosEmpleadosTableAdapter.FillByPeriodo(Me.DsEmpleados.HorariosEmpleados, Nomina)
        Dim rpt As New CryReciboNomina
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()

    End Sub
    Sub ImrimirNominaCompleta()
        Dataset()
        Dim Nomina As String = My.Forms.FrmNomina.ComboBox1.SelectedValue
        Me.NominasDetalleTableAdapter.FillByIdNomina(Me.DsEmpleados.NominasDetalle, Nomina)
        Me.NominasTableAdapter.FillByQuincena(Me.DsEmpleados.Nominas, Nomina)
        Dim rpt As New CryNominaCompleta
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()

    End Sub
    Sub ContratoObra()

        Dim Recibo As String = Me.Lblincio.Text
        Me.EmpleadosTableAdapter.FillByCedula(Me.DsEmpleados.Empleados, Recibo)

        Dim rpt As New CryContratos
        rpt.SetDataSource(Me.DsEmpleados)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpleados)

    End Sub

    Private Sub ImpReciboNomina_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsEmpleados.PagasExtras' Puede moverla o quitarla según sea necesario.






    End Sub


End Class