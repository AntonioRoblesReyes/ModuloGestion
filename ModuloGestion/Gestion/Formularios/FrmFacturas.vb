Imports System.Math

Public Class FrmFacturas
    Sub NuevaNotaCredito()
        Try
            Dim empresa As String = My.Forms.FrmVerFacturas.Id_EmpresaTextBox.Text
            Me.Show()
            Me.FacturaTableAdapter.Fill(Me.DsFacturas.Factura)
            Me.FacturaBindingSource.AddNew()
            Me.IdFacturaTextBox.Text = Me.FacturaTableAdapter.SiguienteFactura(empresa)
            Me.NCFTextBox.Text = Me.FacturaTableAdapter.SiguienteNCF(My.Forms.FrmVerFacturas.Id_EmpresaTextBox.Text)
            Me.IdEmpresaTextBox.Text = empresa
            Me.IdClienteTextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).Id_Fiscal
            Me.ClientesTableAdapter.FillByIdCliente(Me.DsFacturas.Clientes, IdClienteTextBox.Text)
            Me.TxtComprobante.Text = Me.DsFacturas.Clientes(Me.ClientesBindingSource.Position).TipoComprobante

            Me.TasaCambioRD_TextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).tasa

            'Me.SubtotalUS_TextBox.Text = 0
            'Me.ImpuestoUS_TextBox.Text = 0
            'Me.TotalUS_TextBox.Text = 0

            'Me.SubTotalRDSTextBox.Text = 0
            'Me.ImpuestolRDSTextBox.Text = 0
            'Me.TotalRDSTextBox.Text = 0

            Me.FechaDateTimePicker.Value = Date.Now
            Me.ValorImpuestoTextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).Impuesto
            Me.MonedaTextBox.Text = My.Forms.FrmProyectosFacturacion.ComboBox1.Text
            Me.AprobadaCheckBox.Checked = False
            Me.Validate()
            Me.FacturaBindingSource.EndEdit()
            Me.FacturaTableAdapter.Update(Me.DsFacturas)
            Me.FacturaDetalleTableAdapter.FillByIdFactura(Me.DsFacturas.FacturaDetalle, IdFacturaTextBox.Text)
            If MonedaTextBox.Text = "US$" Then
                Me.FacturaDetalleDataGridView.Columns(7).Visible = False
                Me.FacturaDetalleDataGridView.Columns(8).Visible = False
                Me.FacturaDetalleDataGridView.Columns(9).Visible = False
            ElseIf MonedaTextBox.Text = "RD$" Then
                Me.FacturaDetalleDataGridView.Columns(4).Visible = False
                Me.FacturaDetalleDataGridView.Columns(5).Visible = False
                Me.FacturaDetalleDataGridView.Columns(6).Visible = False
            End If

            My.Forms.FrmProyectosFacturacion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub FiltrarProyecto()
        Me.FacturaTableAdapter.FillByIdProyecto(Me.DsFacturas.Factura, My.Forms.FrmProyectos.TxtIdProyecto.Text)
    End Sub
    Sub VerFActura()


        Me.FacturaTableAdapter.FillByIdFactura(Me.DsFacturas.Factura, Label2.Text)
        Me.FacturaDetalleTableAdapter.FillByIdFactura(Me.DsFacturas.FacturaDetalle, Label2.Text)

        Me.Show()
        If MonedaTextBox.Text = "US$" Then
            Me.FacturaDetalleDataGridView.Columns(7).Visible = False
            Me.FacturaDetalleDataGridView.Columns(8).Visible = False
            Me.FacturaDetalleDataGridView.Columns(9).Visible = False

            SubTotalRDSTextBox.Visible = False
            ImpuestolRDSTextBox.Visible = False
            TotalRDSTextBox.Visible = False
        ElseIf MonedaTextBox.Text = "RD$" Then
            Me.FacturaDetalleDataGridView.Columns(4).Visible = False
            Me.FacturaDetalleDataGridView.Columns(5).Visible = False
            Me.FacturaDetalleDataGridView.Columns(6).Visible = False
            SubtotalUS_TextBox.Visible = False
            ImpuestoUS_TextBox.Visible = False
            TotalUS_TextBox.Visible = False

        End If
        TotalFactura()
    End Sub

    Sub TotalFactura()
        Try
            Dim SuBtotalUS As Double

            Dim SuBtotalRD As Double



            For Each row As DataGridViewRow In Me.FacturaDetalleDataGridView.Rows
                SuBtotalUS += Val(row.Cells(6).Value)

                SuBtotalRD += Val(row.Cells(9).Value)


            Next



            Me.SubtotalUS_TextBox.Text = SuBtotalUS

            Me.ImpuestoUS_TextBox.Text = SuBtotalUS * ValorImpuestoTextBox.Text
            Me.TotalUS_TextBox.Text = SuBtotalUS + Me.ImpuestoUS_TextBox.Text

            Me.SubTotalRDSTextBox.Text = SuBtotalRD
            Me.ImpuestolRDSTextBox.Text = SuBtotalRD * ValorImpuestoTextBox.Text
            Me.TotalRDSTextBox.Text = SuBtotalRD + Me.ImpuestolRDSTextBox.Text

            Me.Validate()
            Me.FacturaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsFacturas)
            Try
                My.Forms.FrmVerFacturas.FacturaTableAdapter.Fill(My.Forms.FrmVerFacturas.DsFacturas.Factura)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Sub NuevaFactura()
        Try
            Dim empresa As String = My.Forms.FrmVerFacturas.Id_EmpresaTextBox.Text
            'Dim tipocomprobante As String = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).t
            Me.Show()
            Me.FacturaTableAdapter.Fill(Me.DsFacturas.Factura)
            Me.FacturaBindingSource.AddNew()
            Me.IdFacturaTextBox.Text = Me.FacturaTableAdapter.SiguienteFactura(empresa)

            Me.IdEmpresaTextBox.Text = empresa
            Me.IdClienteTextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).Id_Fiscal
            Me.IdProyectoTextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos

            Me.TxtComprobante.Text = My.Forms.FrmProyectosFacturacion.ComboBox2.SelectedValue

            Me.TasaCambioRD_TextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).tasa
            Me.NCFTextBox.Text = Me.ComprobantesFiscalesTableAdapter.Siguiente(empresa, TxtComprobante.Text)

            Me.SubtotalUS_TextBox.Text = 0
            Me.ImpuestoUS_TextBox.Text = 0
            Me.TotalUS_TextBox.Text = 0

            Me.SubTotalRDSTextBox.Text = 0
            Me.ImpuestolRDSTextBox.Text = 0
            Me.TotalRDSTextBox.Text = 0

            Me.FechaDateTimePicker.Value = Date.Now
            Me.ValorImpuestoTextBox.Text = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).Impuesto
            Dim Proyecto As String = My.Forms.FrmProyectosFacturacion.DsPresupuestos.Presupuesto(My.Forms.FrmProyectosFacturacion.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
            Me.MonedaTextBox.Text = My.Forms.FrmProyectosFacturacion.ComboBox1.Text
            Me.AprobadaCheckBox.Checked = False

            Me.FacturaDetalleTableAdapter.FillByIdFactura(Me.DsFacturas.FacturaDetalle, IdFacturaTextBox.Text)
            If MonedaTextBox.Text = "US$" Then
                Me.FacturaDetalleDataGridView.Columns(7).Visible = False
                Me.FacturaDetalleDataGridView.Columns(8).Visible = False
                Me.FacturaDetalleDataGridView.Columns(9).Visible = False
            ElseIf MonedaTextBox.Text = "RD$" Then
                Me.FacturaDetalleDataGridView.Columns(4).Visible = False
                Me.FacturaDetalleDataGridView.Columns(5).Visible = False
                Me.FacturaDetalleDataGridView.Columns(6).Visible = False
            End If

            My.Forms.FrmProyectosFacturacion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub





    Private Sub BtnBuscarPresupuesmyto_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscarPresupuesto.Click
        My.Forms.FrmDetalleFactura.Close()
        My.Forms.FrmDetalleFactura.Show()


    End Sub


    Private Sub FacturaDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FacturaDetalleDataGridView.CellEndEdit
        Try
            ' Obtener referencias a la fila actual
            Dim row = Me.FacturaDetalleDataGridView.CurrentRow

            ' Verificar que la fila actual exista
            If row Is Nothing Then Throw New Exception("No hay una fila seleccionada.")

            ' Declarar variables y convertir explícitamente
            Dim moneda As String = MonedaTextBox.Text.Trim()
            Dim cantidad As Decimal = Convert.ToDecimal(row.Cells(3).Value)
            Dim tasaCambio As Decimal = Convert.ToDecimal(TasaCambioRD_TextBox.Text)
            Dim valorImpuesto As Decimal = Convert.ToDecimal(ValorImpuestoTextBox.Text)

            ' Variables para valores del DataGridView
            Dim precioUS, precioRD, totalPartidaUS, totalPartidaRD, itbisUS, itbisRD As Decimal

            If moneda = "US$" Then
                precioUS = Convert.ToDecimal(row.Cells(4).Value)
                totalPartidaUS = Math.Round(cantidad * precioUS, 4)
                precioRD = Math.Round(precioUS * tasaCambio, 4)
                totalPartidaRD = Math.Round(precioRD * cantidad, 4)
                itbisUS = Math.Round(totalPartidaUS * valorImpuesto, 4)
                itbisRD = Math.Round(totalPartidaRD * valorImpuesto, 4)

                ' Asignar valores a las celdas
                row.Cells(6).Value = totalPartidaUS
                row.Cells(7).Value = precioRD
                row.Cells(8).Value = itbisRD
                row.Cells(9).Value = totalPartidaRD
                row.Cells(5).Value = itbisUS

            ElseIf moneda = "RD$" Then
                precioRD = Convert.ToDecimal(row.Cells(7).Value)
                totalPartidaRD = Math.Round(precioRD * cantidad, 4)
                precioUS = Math.Round(precioRD / tasaCambio, 4)
                totalPartidaUS = Math.Round(precioUS * cantidad, 4)
                itbisUS = Math.Round(totalPartidaUS * valorImpuesto, 4)
                itbisRD = Math.Round(totalPartidaRD * valorImpuesto, 4)

                ' Asignar valores a las celdas
                row.Cells(9).Value = totalPartidaRD
                row.Cells(4).Value = precioUS
                row.Cells(5).Value = itbisUS
                row.Cells(6).Value = totalPartidaUS
                row.Cells(8).Value = itbisRD

            Else
                Throw New Exception("Tipo de moneda no válido. Debe ser 'US$' o 'RD$'.")
            End If

            ' Actualizar DataSet y guardar en base de datos
            Me.Validate()
            Me.FacturaDetalleBindingSource.EndEdit()
            Me.FacturaDetalleTableAdapter.Update(DsFacturas)
            TotalFactura()
            Me.FacturaBindingSource.EndEdit()
            Me.FacturaTableAdapter.Update(DsFacturas)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error al procesar factura")
        End Try

    End Sub

    Private Sub FacturaDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles FacturaDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.FacturaDetalleBindingSource.EndEdit()
        Me.FacturaDetalleTableAdapter.Update(Me.DsFacturas)
        Me.TotalFactura()
    End Sub



    Private Sub BtnImprimirFactura_Click(sender As System.Object, e As System.EventArgs) Handles BtnImprimirFactura.Click

        If AprobadaCheckBox.Checked = False Then
            Dim a As Integer
            a = MsgBox("¿Quieres Aprobar la factura, no podras hacer cambios?", vbYesNo + vbQuestion)
            If a = vbYes Then
                AprobadaCheckBox.Checked = True
                My.Forms.FrmImpFactura.Show()
                My.Forms.FrmImpFactura.ImprimirFactura()
            Else
                MsgBox("La Factura no esta aprobada")
                My.Forms.FrmImpFactura.Show()
                My.Forms.FrmImpFactura.ImprimirFactura()

            End If
        Else



            My.Forms.FrmImpFactura.Show()
            My.Forms.FrmImpFactura.ImprimirFactura()
            '
        End If


    End Sub

    Private Sub AprobadaCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AprobadaCheckBox.CheckedChanged
        If Me.AprobadaCheckBox.Checked = True Then
            Me.TasaCambioRD_TextBox.Enabled = False
            Me.FechaDateTimePicker.Enabled = False
            Me.FacturaDetalleDataGridView.Enabled = False

        Else
            TasaCambioRD_TextBox.Enabled = True
            FechaDateTimePicker.Enabled = True
            Me.FacturaDetalleDataGridView.Enabled = True

        End If
    End Sub



    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        FacturaDetalleBindingSource.AddNew()
        Dim Siguiente As String = Me.FacturaDetalleTableAdapter.NuevoDetalleFactura(IdFacturaTextBox.Text)
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(0).Value = Siguiente
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(1).Value = IdFacturaTextBox.Text
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(2).Value = "Poner descripcion"
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(3).Value = 1
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(4).Value = 0
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(5).Value = 0
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(6).Value = 0
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(7).Value = 0
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(8).Value = 0
        Me.FacturaDetalleDataGridView.CurrentRow.Cells(9).Value = 0

        Me.FacturaDetalleDataGridView.CurrentRow.Cells(10).Value = "sin enlazar"
    End Sub





    Private Sub NotasLabel_Click(sender As System.Object, e As System.EventArgs)
        If Me.NotasTextBox.Visible = False Then
            Me.NotasTextBox.Visible = True
        Else
            Me.NotasTextBox.Visible = False
        End If
    End Sub

    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.FacturaBindingSource.EndEdit()
            Me.FacturaTableAdapter.Update(Me.DsFacturas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmFacturas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub


End Class
