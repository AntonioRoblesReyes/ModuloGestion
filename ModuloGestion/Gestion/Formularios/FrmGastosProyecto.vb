Public Class FrmGastosProyecto

    Private Sub EstiloDGV(dgv As DataGridView)
        With dgv
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 31, 61)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 31, 61)
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)

            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 232, 250)
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 31, 61)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 255)

            .BorderStyle = BorderStyle.None
            .GridColor = Color.FromArgb(223, 228, 240)

            .RowHeadersVisible = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        End With
    End Sub

    Private Sub AplicarTemaPremium()
        BackColor = Color.FromArgb(236, 240, 248)
        Font = New Font("Segoe UI", 9)

        PanelHeader.BackColor = Color.FromArgb(15, 28, 63)
        Label1.ForeColor = Color.White
        Label1.Font = New Font("Segoe UI Semibold", 12.0!, FontStyle.Bold)

        PanelTotales.BackColor = Color.White
        PanelTotales.BorderStyle = BorderStyle.FixedSingle
        PanelResumen.BackColor = Color.White
        PanelResumen.BorderStyle = BorderStyle.FixedSingle

        Label4.ForeColor = Color.FromArgb(20, 31, 61)
        Label4.Font = New Font("Segoe UI Semibold", 10.5!, FontStyle.Bold)

        EstiloCajaResumen(TextBox1)
        EstiloCajaResumen(TextBox2)
        EstiloCajaResumen(TextBox3)
        EstiloCajaResumen(TextBox4)
        EstiloCajaResumen(TextBox5)
        EstiloCajaResumen(TextBox6)
        EstiloCajaResumen(TextBox7)
        EstiloCajaResumen(TextBox8)
        EstiloCajaResumen(TextBox9)
        EstiloCajaResumen(TextBox10)
        EstiloCajaResumen(TextBox11)
        EstiloCajaResumen(txtTasaCambio, True)
    End Sub

    Private Sub EstiloCajaResumen(txt As TextBox, Optional editable As Boolean = False)
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.BackColor = If(editable, Color.White, Color.FromArgb(248, 250, 255))
        txt.ForeColor = Color.FromArgb(32, 42, 74)
        txt.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
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

            ' El subtotal de montaje para análisis se toma con IRS.
            SM += SafeSum(row.Cells("TotalIrs").Value)
            IM += SafeSum(row.Cells("Itebis").Value)
            TM += SafeSum(row.Cells("Total").Value)
            PM += SafeSum(row.Cells("Pagado").Value)
            PEM += SafeSum(row.Cells("Pendiente").Value)
            PEMF += SafeSum(row.Cells("TotalIrs").Value) - SafeSum(row.Cells("Pagado").Value)
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

        AplicarTemaPremium()
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

        Dim subtotalMontaje As Decimal
        Dim subtotalCompras As Decimal
        Dim totalGastosRD As Decimal
        Dim tasa As Decimal
        Dim subtotalProyecto As Decimal

        ' Para beneficio se comparan valores sin ITBIS,
        ' porque el subtotal del proyecto (lblSubTotalProyecto)
        ' también viene antes de ITBIS.
        Decimal.TryParse(TextBox1.Text, subtotalMontaje)
        Decimal.TryParse(TextBox4.Text, subtotalCompras)
        totalGastosRD = subtotalMontaje + subtotalCompras
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
