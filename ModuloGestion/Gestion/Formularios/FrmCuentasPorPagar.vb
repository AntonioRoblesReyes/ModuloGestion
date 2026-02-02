Public Class FrmCuentasPorPagar

    Private Sub FrmCuentasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Evita ObjectDisposedException por iconos en MDI
        Me.ShowIcon = False

        AjustarColumnasPorMoneda()

        Try
            Me.CompraMaterialesTableAdapter.FillByFacturasPendientes(Me.DsCompras.CompraMateriales)

            Me.DsCompras.EnforceConstraints = False
            Me.ProveedoresTableAdapter.FillByFacturasPendientes(Me.DsCompras.Proveedores)
            Me.DsCompras.EnforceConstraints = True

        Catch ex As ConstraintException
            MessageBox.Show("Error de restricciones en el DataSet: " & ex.Message, "ConstraintException")
            Exit Sub
        End Try

        LabelTotalGeneralRD.Visible = True
        LabelTotalGeneralUS.Visible = True
        LabelTotalSeleccionRD.Visible = False
        LabelTotalSeleccionUS.Visible = False

        LabelTotalSeleccionRD.Text = 0
        LabelTotalSeleccionUS.Text = 0

        CalcularTotalGeneral()
    End Sub

    Private Sub AjustarColumnasPorMoneda()

        ' Ocultar todas primero
        For Each col As DataGridViewColumn In CompraMaterialesDataGridView.Columns
            col.Visible = False
        Next

        ' Las que siempre deben verse
        Mostrar("Id_Compra")
        Mostrar("Fecha")
        Mostrar("Factura")
        Mostrar("Moneda")
        Mostrar("Pagar")
        Mostrar("TotalUS")
        Mostrar("DataGridViewTextBoxColumn24") 'PagadoUS
        Mostrar("PendienteUS")
        Mostrar("TotalRD")
        Mostrar("DataGridViewTextBoxColumn26") 'PagadoRD
        Mostrar("PendienteRD")




    End Sub

    Private Sub Mostrar(nombre As String)
        If CompraMaterialesDataGridView.Columns.Contains(nombre) Then
            CompraMaterialesDataGridView.Columns(nombre).Visible = True
        End If
    End Sub




    Private Sub CalcularTotalGeneral()
        Dim totalRD As Double = 0
        Dim totalUS As Double = 0

        For Each fila As DataGridViewRow In CompraMaterialesDataGridView.Rows
            If Not fila.IsNewRow Then
                If IsNumeric(fila.Cells("TotalRD").Value) Then
                    totalRD += CDbl(fila.Cells("TotalRD").Value)
                End If
                If IsNumeric(fila.Cells("TotalUS").Value) Then
                    totalUS += CDbl(fila.Cells("TotalUS").Value)
                End If
            End If
        Next

        LabelTotalGeneralRD.Text = "Total RD: " & totalRD.ToString("N2")
        LabelTotalGeneralUS.Text = "Total US: " & totalUS.ToString("N2")
    End Sub

    Private Sub CalcularTotalesSeleccionados()
        Dim sumaRD As Double = 0
        Dim sumaUS As Double = 0

        For Each fila As DataGridViewRow In CompraMaterialesDataGridView.Rows
            If Not fila.IsNewRow AndAlso Convert.ToBoolean(fila.Cells("Pagar").Value) Then
                Dim moneda As String = fila.Cells("Moneda").Value?.ToString()

                If moneda = "RD$" Then
                    If IsNumeric(fila.Cells("PendienteRD").Value) Then
                        sumaRD += CDbl(fila.Cells("PendienteRD").Value)
                    End If
                ElseIf moneda = "US$" Then
                    If IsNumeric(fila.Cells("PendienteUS").Value) Then
                        sumaUS += CDbl(fila.Cells("PendienteUS").Value)
                    End If
                End If
            End If
        Next

        LabelTotalSeleccionRD.Text = "Total Pago RD: " & sumaRD.ToString("N2")
        LabelTotalSeleccionUS.Text = "Total Pago US: " & sumaUS.ToString("N2")
    End Sub


    Private Sub CompraMaterialesDataGridView_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles CompraMaterialesDataGridView.CurrentCellDirtyStateChanged
        If CompraMaterialesDataGridView.IsCurrentCellDirty Then
            CompraMaterialesDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub CompraMaterialesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDataGridView.CellClick
        If e.ColumnIndex = CompraMaterialesDataGridView.Columns("Pagar").Index AndAlso e.RowIndex >= 0 Then
            CompraMaterialesDataGridView.BeginEdit(True)
        Else
        End If
    End Sub

    Private Sub ProveedoresDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellClick
        Dim idProveedor As String = Me.DsCompras.Proveedores(Me.ProveedoresBindingSource.Position).Id_Proveedor
        Me.CompraMaterialesTableAdapter.FillByPendientePorProveedor(Me.DsCompras.CompraMateriales, idProveedor)

        CalcularTotalGeneral()
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCompras)
    End Sub

    Private Sub CompraMaterialesDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDataGridView.CellValueChanged
        LabelTotalSeleccionRD.Visible = True
        LabelTotalSeleccionUS.Visible = True
        If CompraMaterialesDataGridView.Columns.Contains("Pagar") AndAlso
           e.ColumnIndex = CompraMaterialesDataGridView.Columns("Pagar").Index Then
            CalcularTotalesSeleccionados()
        End If
    End Sub
    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        ' Paso 1: Validar conflicto de monedas
        If HayConflictoDeMonedas() Then
            MessageBox.Show("No se puede procesar el pago porque hay facturas marcadas en diferentes monedas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Paso 2: Obtener montos desde los Label
        Dim montoTextoRD As String = LabelTotalSeleccionRD.Text.Replace("Total Pago RD:", "").Trim()
        Dim montoTextoUS As String = LabelTotalSeleccionUS.Text.Replace("Total Pago US:", "").Trim()

        Dim montoRD As Double = 0
        Dim montoUS As Double = 0

        Double.TryParse(montoTextoRD, Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, montoRD)
        Double.TryParse(montoTextoUS, Globalization.NumberStyles.Any, Globalization.CultureInfo.CurrentCulture, montoUS)

        ' Paso 3: Cargar el formulario FrmPagarCompra
        With FrmPagarCompra
            ' Asignar el monto y la moneda
            If montoRD > 0 Then
                .MontoPago = montoRD
                .MonedaPago = "RD$"
            Else
                .MontoPago = montoUS
                .MonedaPago = "US$"
            End If

            ' Paso 4: Preparar la tabla
            With .TablaFacturasSeleccionadas
                .Clear()
                If .Columns.Count > 0 Then .Columns.Clear()

                .Columns.Add("Id_Compra")
                .Columns.Add("Fecha")
                .Columns.Add("Proveedor")
                .Columns.Add("Monto")
                .Columns.Add("Pendiente")
                .Columns.Add("MontoAPagar") ' Editable
                .Columns.Add("Moneda")
            End With

            ' Paso 5: Llenar la tabla según la moneda
            For Each row As DataGridViewRow In CompraMaterialesDataGridView.Rows
                If Not row.IsNewRow AndAlso Convert.ToBoolean(row.Cells("Pagar").Value) Then
                    Dim moneda As String = row.Cells("Moneda").Value.ToString()
                    Dim monto As Double = 0
                    Dim pendiente As Double = 0

                    If moneda = "RD$" Then
                        monto = Convert.ToDouble(row.Cells("TotalRD").Value)
                        pendiente = Convert.ToDouble(row.Cells("PendienteRD").Value)
                    ElseIf moneda = "US$" Then
                        monto = Convert.ToDouble(row.Cells("TotalUS").Value)
                        pendiente = Convert.ToDouble(row.Cells("PendienteUS").Value)
                    End If

                    .TablaFacturasSeleccionadas.Rows.Add(
                    row.Cells("Id_Compra").Value.ToString(),
                    Convert.ToDateTime(row.Cells("Fecha").Value).ToShortDateString(),
                    row.Cells("Proveedor").Value.ToString(),
                    monto.ToString("N2"),
                    pendiente.ToString("N2"),
                    pendiente.ToString("N2"), ' Inicialmente igual a pendiente
                    moneda
                )
                End If
            Next

            ' Paso 6: Mostrar datos en el DataGridView
            .DgvFacturasSeleccionadas.DataSource = Nothing ' Asegura refresco
            .DgvFacturasSeleccionadas.DataSource = .TablaFacturasSeleccionadas

            ' Paso 7: Aplicar formato y edición
            With .DgvFacturasSeleccionadas
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AllowUserToAddRows = False
                .ReadOnly = False ' necesario para habilitar edición puntual

                ' Todas en solo lectura excepto MontoAPagar
                For Each col As DataGridViewColumn In .Columns
                    col.ReadOnly = True
                Next

                If .Columns.Contains("MontoAPagar") Then
                    .Columns("MontoAPagar").ReadOnly = False
                    .Columns("MontoAPagar").DefaultCellStyle.Format = "N2"
                    .Columns("MontoAPagar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If

                If .Columns.Contains("Monto") Then
                    .Columns("Monto").DefaultCellStyle.Format = "N2"
                    .Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If

                If .Columns.Contains("Pendiente") Then
                    .Columns("Pendiente").DefaultCellStyle.Format = "N2"
                    .Columns("Pendiente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            End With

            ' Paso 8: Mostrar formulario
            .ShowDialog()
        End With
    End Sub







    Private Function HayConflictoDeMonedas() As Boolean
        Dim hayRD As Boolean = Val(LabelTotalSeleccionRD.Text.Replace("Total Pago RD:", "").Trim()) > 0
        Dim hayUS As Boolean = Val(LabelTotalSeleccionUS.Text.Replace("Total Pago US:", "").Trim()) > 0
        Return hayRD AndAlso hayUS
    End Function
    ' FILTRO EN TIEMPO REAL PARA PROVEEDORES
    Private Sub TxtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProveedor.TextChanged
        Try
            Dim texto As String = TxtBuscarProveedor.Text.Trim()

            If String.IsNullOrEmpty(texto) Then
                ProveedoresBindingSource.RemoveFilter()
            Else
                Dim filtroSeguro As String = texto.Replace("'", "''")
                ProveedoresBindingSource.Filter =
                $"Convert(Id_Proveedor, 'System.String') LIKE '%{filtroSeguro}%' OR RazonSocial LIKE '%{filtroSeguro}%'"
            End If

            ActualizarComprasDelProveedorActual()

        Catch ex As Exception
            MsgBox("Error en el filtro: " & ex.Message)
        End Try
    End Sub


    ' ACTUALIZA LAS COMPRAS CADA VEZ QUE SE FILTRA UN PROVEEDOR
    Private Sub ActualizarComprasDelProveedorActual()
        Try
            If ProveedoresBindingSource.Count = 0 Then
                DsCompras.CompraMateriales.Clear()
                LabelTotalGeneralRD.Text = "Total RD: 0.00"
                LabelTotalGeneralUS.Text = "Total US: 0.00"
                Exit Sub
            End If

            Dim fila As DataRowView = CType(ProveedoresBindingSource.Current, DataRowView)
            Dim idProveedor As String = fila("Id_Proveedor").ToString()

            Me.CompraMaterialesTableAdapter.FillByPendientePorProveedor(Me.DsCompras.CompraMateriales, idProveedor)

            CalcularTotalGeneral()

        Catch ex As Exception
            MsgBox("Error actualizando compras del proveedor: " & ex.Message)
        End Try
    End Sub


End Class
