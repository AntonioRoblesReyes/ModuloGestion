Public Class FrmEmpresaMontaje
    Sub Sumar()
        Dim Facturado As Double
        Dim Pagado As Double
        Dim Pendiente As Double

        For Each row As DataGridViewRow In Me.FacturaMontajeDataGridView.Rows
            Facturado += Val(row.Cells(5).Value)
            Pagado += Val(row.Cells(6).Value)
            Pendiente += Val(row.Cells(7).Value)
        Next
        Label2.Text = Format(Facturado, "#,##0.00")
        Label3.Text = Format(Pagado, "#,##0.00")
        Label5.Text = Format(Pendiente, "#,##0.00")

        Dim Pago As Double
        Dim Asignado As Double
        Dim PendienteAsignar As Double

        For Each row As DataGridViewRow In Me.PagoMontajeDataGridView.Rows
            Pago += Val(row.Cells(2).Value)
            Asignado += Val(row.Cells(3).Value)
            PendienteAsignar += Val(row.Cells(4).Value)
        Next
        Label11.Text = Format(Pago, "#,##0.00")
        Label9.Text = Format(Asignado, "#,##0.00")
        Label7.Text = Format(PendienteAsignar, "#,##0.00")
    End Sub

    Private Sub ConfigurarGrid(grid As DataGridView)
        grid.Dock = DockStyle.Fill
        grid.BackgroundColor = Color.WhiteSmoke
        grid.BorderStyle = BorderStyle.None
        grid.RowHeadersVisible = False
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.MultiSelect = False
        grid.ReadOnly = True
        grid.EnableHeadersVisualStyles = False
        grid.ColumnHeadersHeight = 34

        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grid.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215)
        grid.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub AplicarEstiloGrids()
        ConfigurarGrid(FacturaMontajeDataGridView)
        ConfigurarGrid(FacturaMontajeB11DataGridView)
        ConfigurarGrid(FacturaMontajeDetalleDataGridView)
        ConfigurarGrid(PagoMontajeDataGridView)
        ConfigurarGrid(PagoMontajeDetalleDataGridView)

        If FacturaMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn2") Then FacturaMontajeDataGridView.Columns("DataGridViewTextBoxColumn2").Width = 70
        If FacturaMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn11") Then FacturaMontajeDataGridView.Columns("DataGridViewTextBoxColumn11").Width = 90
        If FacturaMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn13") Then FacturaMontajeDataGridView.Columns("DataGridViewTextBoxColumn13").Width = 110
        If FacturaMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn14") Then FacturaMontajeDataGridView.Columns("DataGridViewTextBoxColumn14").Width = 95
        If FacturaMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn15") Then FacturaMontajeDataGridView.Columns("DataGridViewTextBoxColumn15").Width = 80
        If FacturaMontajeDataGridView.Columns.Contains("Total") Then FacturaMontajeDataGridView.Columns("Total").Width = 95
        If FacturaMontajeDataGridView.Columns.Contains("Pagado") Then FacturaMontajeDataGridView.Columns("Pagado").Width = 95
        If FacturaMontajeDataGridView.Columns.Contains("PendienteInstalador") Then FacturaMontajeDataGridView.Columns("PendienteInstalador").Width = 95

        If FacturaMontajeB11DataGridView.Columns.Contains("IdFacturaB11") Then FacturaMontajeB11DataGridView.Columns("IdFacturaB11").Width = 80
        If FacturaMontajeB11DataGridView.Columns.Contains("Fecha") Then FacturaMontajeB11DataGridView.Columns("Fecha").Width = 90
        If FacturaMontajeB11DataGridView.Columns.Contains("SubTotal") Then FacturaMontajeB11DataGridView.Columns("SubTotal").Width = 95
        If FacturaMontajeB11DataGridView.Columns.Contains("ITBIS") Then FacturaMontajeB11DataGridView.Columns("ITBIS").Width = 80
        If FacturaMontajeB11DataGridView.Columns.Contains("RetencionISR") Then FacturaMontajeB11DataGridView.Columns("RetencionISR").Width = 95
        If FacturaMontajeB11DataGridView.Columns.Contains("DataGridViewTextBoxColumn16") Then FacturaMontajeB11DataGridView.Columns("DataGridViewTextBoxColumn16").Width = 95
        If FacturaMontajeB11DataGridView.Columns.Contains("Imprimir") Then FacturaMontajeB11DataGridView.Columns("Imprimir").Width = 60
        If FacturaMontajeB11DataGridView.Columns.Contains("Anular") Then FacturaMontajeB11DataGridView.Columns("Anular").Width = 60
        If FacturaMontajeB11DataGridView.Columns.Contains("Modificar") Then FacturaMontajeB11DataGridView.Columns("Modificar").Width = 70

        If PagoMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn17") Then PagoMontajeDataGridView.Columns("DataGridViewTextBoxColumn17").Width = 80
        If PagoMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn20") Then PagoMontajeDataGridView.Columns("DataGridViewTextBoxColumn20").Width = 90
        If PagoMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn21") Then PagoMontajeDataGridView.Columns("DataGridViewTextBoxColumn21").Width = 95
        If PagoMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn22") Then PagoMontajeDataGridView.Columns("DataGridViewTextBoxColumn22").Width = 95
        If PagoMontajeDataGridView.Columns.Contains("DataGridViewTextBoxColumn23") Then PagoMontajeDataGridView.Columns("DataGridViewTextBoxColumn23").Width = 110
    End Sub

    Private Sub AjustarSplitters()
        SplitContainerPrincipal.SplitterDistance = Math.Max(220, Math.Min(SplitContainerPrincipal.Height - 180, CInt(Me.Height * 0.42)))
        SplitContainerSuperior.Panel2MinSize = 360
        Dim splitSuperiorDeseado As Integer = CInt(Me.Width * 0.68)
        splitSuperiorDeseado = Math.Min(SplitContainerSuperior.Width - SplitContainerSuperior.Panel2MinSize, splitSuperiorDeseado)
        SplitContainerSuperior.SplitterDistance = Math.Max(400, splitSuperiorDeseado)
        SplitContainerInferior.SplitterDistance = Math.Max(300, Math.Min(SplitContainerInferior.Width - 320, CInt(Me.Width * 0.6)))
    End Sub

    Sub Cargar()
        Me.EmpresasContratadasMontajeTableAdapter.FillByActivas(Me.DsPagosMontaje.EmpresasContratadasMontaje)
        Me.Show()
        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, IdEmpresaMontajeTextBox.Text)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, IdEmpresaMontajeTextBox.Text)
        Sumar()
    End Sub

    Private Sub EmpresasContratadasMontajeBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresasContratadasMontajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresasContratadasMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)
    End Sub

    Private Sub FrmEmpresaMontaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, IdEmpresaMontajeTextBox.Text)
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)

        AplicarEstiloGrids()
        AjustarSplitters()
        AddHandler Me.Resize, Sub() AjustarSplitters()
    End Sub

    Private Sub EmpresasContratadasMontajeBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles EmpresasContratadasMontajeBindingNavigator.RefreshItems
        Me.FacturaMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.FacturaMontaje, IdEmpresaMontajeTextBox.Text)
        Me.PagoMontajeTableAdapter.FillByIdEmpresa(Me.DsPagosMontaje.PagoMontaje, IdEmpresaMontajeTextBox.Text)
        Me.FacturaMontajeB11TableAdapter.FillByIdEmpresaMontaje(Me.DsMontajeB11.FacturaMontajeB11, IdEmpresaMontajeTextBox.Text)
        Sumar()
    End Sub

    Private Sub PagoMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PagoMontajeDataGridView.CellClick
        Dim IdPago As String = Me.DsPagosMontaje.PagoMontaje(Me.PagoMontajeBindingSource.Position).IdPagoMontaje
        Me.PagoMontajeDetalleTableAdapter.FillByIdPago(Me.DsPagosMontaje.PagoMontajeDetalle, IdPago)
    End Sub

    Private Sub FacturaMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDataGridView.CellClick
        Dim IdFactura As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).IdFacturaMontaje
        Dim Idpresupuesto As String = Me.DsPagosMontaje.FacturaMontaje(Me.FacturaMontajeBindingSource.Position).Id_Presupuesto
        Me.PagoMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.PagoMontajeDetalle, IdFactura)
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, Idpresupuesto)
        Me.Label18.Text = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descripcion_Presupuesto
        Dim Proyecto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
        Me.ProyectosTableAdapter.FillByProyecto(DsProyectos.Proyectos, Proyecto)
        Me.Label17.Text = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Nombre_Proyecto
        Dim IdCliente As String = DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Id_Fiscal
        Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, IdCliente)
        Me.Label14.Text = DsClientes.Clientes(Me.ClientesBindingSource.Position).Nombre_Cliente
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontajeDetalle, IdFactura)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnResumenFactura.Click
        My.Forms.ImpPagoMomtaje.Label1.Text = IdEmpresaMontajeTextBox.Text
        My.Forms.ImpPagoMomtaje.ImprimirResumenFactura()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnResumenPagos.Click
        My.Forms.ImpPagoMomtaje.Label1.Text = IdEmpresaMontajeTextBox.Text
        My.Forms.ImpPagoMomtaje.ImprimirResumenPagos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.FrmNuevaEmpresaMontaje.Close()
        My.Forms.FrmNuevaEmpresaMontaje.Nueva()
    End Sub

    Private Sub BtnModificarFactura_Click(sender As Object, e As EventArgs) Handles BtnModificarFactura.Click
        Try
            If FacturaMontajeBindingSource.Position < 0 OrElse DsPagosMontaje.FacturaMontaje.Count = 0 Then
                MessageBox.Show("No hay factura seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim fila = DsPagosMontaje.FacturaMontaje(FacturaMontajeBindingSource.Position)

            Dim idfactura As String = fila.IdFacturaMontaje
            Dim presupuesto As String = fila.Id_Presupuesto
            Dim proyecto As String = fila.Id_Proyecto
            Dim empresaMontaje As String = fila.IdEmpresaMontaje

            With My.Forms.FrmFacturaMontajeEditar
                .IdFacturaTextBox.Text = idfactura
                .LblPresupuesto.Text = presupuesto
                .LblProyecto.Text = proyecto
                .IdEmpresaMontajeTextBox.Text = empresaMontaje
                .ModificarFactura()
                .Show()
            End With

        Catch ex As Exception
            MessageBox.Show("Error al modificar factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnFacturaB11_Click(sender As Object, e As EventArgs) Handles BtnFacturaB11.Click
        If EmpresasContratadasMontajeBindingSource.Current Is Nothing Then
            MsgBox("Seleccione una empresa.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim idEmpresa As String = CType(EmpresasContratadasMontajeBindingSource.Current, DataRowView)("IdEmpresaMontaje").ToString()

        Dim cn As New SqlClient.SqlConnection(My.Settings.GestionEmpresaConnectionString)
        Dim cmd As New SqlClient.SqlCommand("SELECT dbo.SiguienteFacturaB11()", cn)

        cn.Open()
        Dim idFactura As String = cmd.ExecuteScalar().ToString()
        cn.Close()

        Dim f As New FrmFacturaMontajeB11
        f.IdEmpresaSeleccionada = idEmpresa
        f.IdFacturaGenerada = idFactura
        f.ShowDialog()
    End Sub

    Private Sub FacturaMontajeB11DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeB11DataGridView.CellClick
        If e.RowIndex < 0 Then Exit Sub

        If FacturaMontajeB11DataGridView.Columns(e.ColumnIndex).Name = "Imprimir" Then
            Dim idFactura As String = FacturaMontajeB11DataGridView.Rows(e.RowIndex).Cells("IdFacturaB11").Value.ToString()
            Dim frm As New ImpPagoMomtaje
            frm.IdFacturaSeleccionada = idFactura
            frm.ImprimirFacturaNfc()
        End If
    End Sub
End Class
