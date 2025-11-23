Public Class RptHotel



    Sub ImHabitacion()

        Me.ArticulosTableAdapter.Fill(Me.HotelesDataSet.Articulos)
        Me.HabitacionesTableAdapter.Fill(Me.HotelesDataSet.Habitaciones)
        Me.HabitacionesDetalleTableAdapter.Fill(Me.HotelesDataSet.HabitacionesDetalle)
        Me.EdificiosDetalleTableAdapter.Fill(Me.HotelesDataSet.EdificiosDetalle)
        Dim rpt As New CryHabitaciones
        rpt.SetDataSource(HotelesDataSet)
        CrystalReportViewer1.ReportSource = rpt
        Me.Show()
    End Sub

    Private Sub RptHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '

        'Me.EdificiosTableAdapter.Fill(Me.HotelesDataSet.Edificios)

        'Me.PlantasDetalleTableAdapter.Fill(Me.HotelesDataSet.PlantasDetalle)

        'Me.PlantasTableAdapter.Fill(Me.HotelesDataSet.Plantas)

        'Me.HotelesTableAdapter.Fill(Me.HotelesDataSet.Hoteles)

    End Sub


End Class