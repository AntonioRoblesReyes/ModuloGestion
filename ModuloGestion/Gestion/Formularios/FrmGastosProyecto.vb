Public Class FrmGastosProyecto
    Sub Sumas()

        Dim TotalGastos As Integer = CostoComprasProyectoDataGridView.Rows.Count 'Total toma el valor del número de registros que tiene la tabla
        Dim SM As Double = 0
        Dim IM As Double = 0
        Dim TM As Double = 0
        Dim SG As Double = 0
        Dim IG As Double = 0
        Dim TG As Double = 0
        Dim PM As Double = 0
        Dim PEM As Double = 0
        Dim TP As Double = 0

        For Each row As DataGridViewRow In FacturaMontajeDataGridView.Rows
            If Not IsDBNull(row.Cells(1).Value) Then SM += Convert.ToDouble(row.Cells(1).Value)
            If Not IsDBNull(row.Cells(2).Value) Then IM += Convert.ToDouble(row.Cells(2).Value)
            If Not IsDBNull(row.Cells(3).Value) Then TM += Convert.ToDouble(row.Cells(3).Value)
            If Not IsDBNull(row.Cells(4).Value) Then PM += Convert.ToDouble(row.Cells(4).Value)
            If Not IsDBNull(row.Cells(5).Value) Then PEM += Convert.ToDouble(row.Cells(5).Value)
        Next

        For Each row As DataGridViewRow In CostoComprasProyectoDataGridView.Rows
            ' Puedes descomentar estas líneas si necesitas sumar valores de CostoComprasProyecto
            If Not IsDBNull(row.Cells(3).Value) Then SG += Convert.ToDouble(row.Cells(3).Value)
            If Not IsDBNull(row.Cells(4).Value) Then IG += Convert.ToDouble(row.Cells(4).Value)
            If Not IsDBNull(row.Cells(5).Value) Then TG += Convert.ToDouble(row.Cells(5).Value)
            If Not IsDBNull(row.Cells(6).Value) Then TP += Convert.ToDouble(row.Cells(6).Value)
        Next

        ' Formatear las sumas y mostrar en los TextBox
        TextBox1.Text = Format(SM, "#,##0.00")
        TextBox2.Text = Format(IM, "#,##0.00")
        TextBox3.Text = Format(TM, "#,##0.00")
        TextBox4.Text = Format(SG, "#,##0.00")
        TextBox5.Text = Format(IG, "#,##0.00")
        TextBox6.Text = Format(TG, "#,##0.00")
        TextBox8.Text = Format(PM, "#,##0.00")
        TextBox9.Text = Format(PEM, "#,##0.00")
        TextBox10.Text = Format(TP, "#,##0.00")
        TextBox11.Text = Format(TG - TP, "#,##0.00")

        ' Sumar PM y TG y mostrar en TextBox7
        Me.TextBox7.Text = Format(PM + TG, "#,##0.00")
    End Sub

    Private Sub FrmGastosProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DsCompras.CostoComprasProyecto.Clear()
        Me.CostoComprasProyectoTableAdapter.Fill(Me.DsCompras.CostoComprasProyecto)
        Me.FacturaMontajeTableAdapter.FillByIdProyrcto(Me.DsPagosMontaje.FacturaMontaje, Label1.Text)
        Me.CostoComprasProyectoTableAdapter.FillByIdProyecto(Me.DsCompras.CostoComprasProyecto, Label1.Text)
        Sumas()
    End Sub

    Private Sub FacturaMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDataGridView.CellClick
        Dim IdFactura As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, IdFactura)
    End Sub

    Private Sub CostoComprasProyectoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim IdFactura As String = Me.DsCompras.CostoComprasProyecto(Me.CostoComprasProyectoBindingSource.Position).Id_Compra
        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, IdFactura)
    End Sub
End Class
