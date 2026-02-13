Public Class FrmGastosProyecto

    Private Sub EstiloDGV(dgv As DataGridView)
        With dgv
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

            .BorderStyle = BorderStyle.None
            .GridColor = Color.LightGray

            .RowHeadersVisible = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
        End With
    End Sub




    '==========================================================
    ' FUNCIÓN PARA SUMAR LOS VALORES DE AMBOS GRID
    '==========================================================
    Sub Sumas()

        ' Variables de totales facturas de montaje
        Dim SM As Double = 0   ' Subtotal montaje
        Dim IM As Double = 0   ' Impuesto montaje
        Dim TM As Double = 0   ' Total montaje
        Dim PM As Double = 0   ' Pagado montaje
        Dim PEM As Double = 0  ' Pendiente montaje
        Dim PEMF As Double = 0  ' Pendiente montaje

        ' Variables de totales compras del proyecto
        Dim SG As Double = 0   ' Subtotal compras
        Dim IG As Double = 0   ' Impuesto compras
        Dim TG As Double = 0   ' Total compras
        Dim TP As Double = 0   ' Pagado compras

        '==========================================================
        ' SUMAS DE FACTURAS DE MONTAJE
        '==========================================================
        For Each row As DataGridViewRow In FacturaMontajeDataGridView.Rows
            If row.IsNewRow Then Continue For

            SM += SafeSum(row.Cells(1).Value)
            IM += SafeSum(row.Cells(2).Value)
            TM += SafeSum(row.Cells(3).Value)
            PM += SafeSum(row.Cells(4).Value)
            PEM += SafeSum(row.Cells("Pendiente").Value)
            PEMF += SafeSum(row.Cells("SubTotal").Value) - SafeSum(row.Cells("Pagado").Value)
        Next

        '==========================================================
        ' SUMAS DE COSTOS DE COMPRAS
        '==========================================================
        For Each row As DataGridViewRow In CostoComprasProyectoDataGridView.Rows
            If row.IsNewRow Then Continue For

            SG += SafeSum(row.Cells(3).Value)
            IG += SafeSum(row.Cells(4).Value)
            TG += SafeSum(row.Cells(5).Value)
            TP += SafeSum(row.Cells(6).Value)
        Next

        '==========================================================
        ' MOSTRAR RESULTADOS
        '==========================================================
        TextBox1.Text = SM.ToString("#,##0.00")
        TextBox2.Text = IM.ToString("#,##0.00")
        TextBox3.Text = TM.ToString("#,##0.00")

        TextBox4.Text = SG.ToString("#,##0.00")
        TextBox5.Text = IG.ToString("#,##0.00")
        TextBox6.Text = TG.ToString("#,##0.00")

        TextBox8.Text = PM.ToString("#,##0.00")
        TextBox9.Text = PEMF.ToString("#,##0.00")
        TextBox10.Text = TP.ToString("#,##0.00")

        ' Diferencia entre total de compras y lo pagado compras
        TextBox11.Text = (TG - TP).ToString("#,##0.00")

        ' Total general: total montaje + total compras
        TextBox7.Text = (TM + TG).ToString("#,##0.00")

    End Sub

    '==========================================================
    ' FUNCIÓN SEGURA PARA SUMAR (EVITA NULLS Y ERRORES)
    '==========================================================
    Private Function SafeSum(value As Object) As Double
        If value Is Nothing OrElse IsDBNull(value) Then Return 0
        Dim num As Double = 0
        Double.TryParse(value.ToString(), num)
        Return num
    End Function

    '==========================================================
    ' LOAD DEL FORMULARIO
    '==========================================================
    Private Sub FrmGastosProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Limpia antes de cargar
        Me.DsCompras.CostoComprasProyecto.Clear()

        ' Cargar compras y facturas
        Me.CostoComprasProyectoTableAdapter.Fill(Me.DsCompras.CostoComprasProyecto)
        Me.FacturaMontajeTableAdapter.FillByIdProyrcto(Me.DsPagosMontaje.FacturaMontaje, Label1.Text)
        Me.CostoComprasProyectoTableAdapter.FillByIdProyecto(Me.DsCompras.CostoComprasProyecto, Label1.Text)
        txtTasaCambio.Text = My.Settings.TasaCambio.ToString("N2")

        ConfigurarAnchosColumnas()

        ' Realizar sumatorias
        EstiloDGV(FacturaMontajeDataGridView)
        EstiloDGV(FacturaMontajeDetalleDataGridView)
        EstiloDGV(CostoComprasProyectoDataGridView)
        EstiloDGV(CompraMaterialesDetalleDataGridView)

        Sumas()
        CalcularResumenFinal()
    End Sub

    '==========================================================
    ' CLICK EN GRID DE MONTAJE — CARGAR DETALLE
    '==========================================================
    Private Sub FacturaMontajeDataGridView_CellClick _
        (sender As Object, e As DataGridViewCellEventArgs) _
        Handles FacturaMontajeDataGridView.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim IdFactura As String =
            Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje

        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, IdFactura)

    End Sub

    '==========================================================
    ' CLICK EN GRID DE COMPRAS — CARGAR DETALLE
    '==========================================================
    Private Sub CostoComprasProyectoDataGridView_CellClick _
        (sender As Object, e As DataGridViewCellEventArgs)

        If e.RowIndex < 0 Then Exit Sub

        Dim IdCompra As String =
            Me.DsCompras.CostoComprasProyecto(Me.CostoComprasProyectoBindingSource.Position).Id_Compra

        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, IdCompra)

    End Sub
    Private Sub txtTasaCambio_Leave(sender As Object, e As EventArgs) Handles txtTasaCambio.Leave

        Dim tasa As Decimal

        If Decimal.TryParse(txtTasaCambio.Text, tasa) Then
            My.Settings.TasaCambio = tasa
            My.Settings.Save()
        Else
            MessageBox.Show("Tasa inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTasaCambio.Focus()
        End If

        CalcularResumenFinal()



    End Sub

    Private Sub CalcularResumenFinal()

        Dim totalMontaje As Decimal
        Dim totalCompras As Decimal
        Dim totalGastosRD As Decimal
        Dim tasa As Decimal
        Dim subtotalProyecto As Decimal

        Decimal.TryParse(TextBox3.Text, totalMontaje)
        Decimal.TryParse(TextBox6.Text, totalCompras)
        Decimal.TryParse(TextBox7.Text, totalGastosRD)
        Decimal.TryParse(txtTasaCambio.Text, tasa)
        Decimal.TryParse(lblSubTotalProyecto.Text, subtotalProyecto)

        '-------------------------
        ' GASTOS EN USD
        '-------------------------
        Dim gastosUSD As Decimal = 0D

        If tasa > 0 Then
            gastosUSD = totalGastosRD / tasa
        End If

        lblGastosUSD.Text = gastosUSD.ToString("N2")

        '-------------------------
        ' BENEFICIO
        '-------------------------
        Dim beneficio As Decimal = subtotalProyecto - gastosUSD
        lblBeneficio.Text = beneficio.ToString("N2")

        '-------------------------
        ' % BENEFICIO
        '-------------------------
        If subtotalProyecto > 0 Then
            lblPorcentajeBeneficio.Text =
                ((beneficio / subtotalProyecto) * 100D).ToString("N2") & " %"
        Else
            lblPorcentajeBeneficio.Text = "0.00 %"
        End If

    End Sub

    Private Sub CostoComprasProyectoDataGridView_CellClick_1(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles CostoComprasProyectoDataGridView.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim idCompra As String =
            CostoComprasProyectoDataGridView.
            Rows(e.RowIndex).
            Cells("IdCompraDataGridViewTextBoxColumn").
            Value.ToString()

        If String.IsNullOrWhiteSpace(idCompra) Then Exit Sub

        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(
            DsCompras.CompraMaterialesDetalle,
            idCompra
        )

    End Sub


    Private Sub ConfigurarAnchosColumnas()
        ConfigurarGrid(
            CostoComprasProyectoDataGridView,
            New Dictionary(Of String, Integer) From {
                {"RazonSocialDataGridViewTextBoxColumn", 220},
                {"SubtotalDataGridViewTextBoxColumn", 110},
                {"ItebisDataGridViewTextBoxColumn", 100},
                {"TotalDataGridViewTextBoxColumn", 110},
                {"PagadoRD", 110}
            }
        )

        ConfigurarGrid(
            CompraMaterialesDetalleDataGridView,
            New Dictionary(Of String, Integer) From {
                {"DataGridViewTextBoxColumn32", 240},
                {"DataGridViewTextBoxColumn10", 95},
                {"DataGridViewTextBoxColumn24", 110},
                {"DataGridViewTextBoxColumn25", 100},
                {"DataGridViewTextBoxColumn26", 110}
            }
        )

        ConfigurarGrid(
            FacturaMontajeDataGridView,
            New Dictionary(Of String, Integer) From {
                {"DataGridViewTextBoxColumn1", 110},
                {"SubTotal", 105},
                {"Itebis", 95},
                {"Total", 105},
                {"Pagado", 105},
                {"Pendiente", 105},
                {"TotalIrs", 95}
            }
        )

        ConfigurarGrid(
            FacturaMontajeDetalleDataGridView,
            New Dictionary(Of String, Integer) From {
                {"DataGridViewTextBoxColumn15", 240},
                {"DataGridViewTextBoxColumn16", 110},
                {"DataGridViewTextBoxColumn17", 110}
            }
        )
    End Sub

    Private Sub ConfigurarGrid(grid As DataGridView, anchos As Dictionary(Of String, Integer))
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        grid.AllowUserToResizeColumns = True

        For Each column As DataGridViewColumn In grid.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            If anchos.ContainsKey(column.Name) Then
                column.Width = anchos(column.Name)
            End If
        Next
    End Sub

End Class
