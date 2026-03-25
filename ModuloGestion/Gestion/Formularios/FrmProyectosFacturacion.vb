Public Class FrmProyectosFacturacion

    Private Sub ProyectosDetalleBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProyectosDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsProyectosDetalle)

    End Sub

    Private Sub FrmProyectosFacturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsFacturas.ComprobantesFiscales' Puede moverla o quitarla según sea necesario.
        Me.ComprobantesFiscalesTableAdapter.FillByActivos(Me.DsFacturas.ComprobantesFiscales)
        'TODO: esta línea de código carga datos en la tabla 'DsFacturas.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.DsFacturas.Clientes)
        Me.PresupuestoTableAdapter.FillByParaFacturar(Me.DsPresupuestos.Presupuesto, Label2.Text)



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim proyecto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos

        Dim Cliente As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Fiscal
        Dim impuesto As Double = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Impuesto

        If ComboBox1.Text = "" Then
            MsgBox("Debe elejir una moneda a facturar")
            Exit Sub
        End If

        If ComboBox2.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(ComboBox2.SelectedValue.ToString()) Then
            MsgBox("Debe elegir un tipo de comprobante")
            Exit Sub
        End If

        My.Forms.FrmFacturas.Close()

        Dim tipoComprobante As String = ComboBox2.SelectedValue.ToString().Trim().ToUpper()

        If tipoComprobante = "NC" Then
            My.Forms.FrmFacturas.NuevaNotaCredito()
        Else
            My.Forms.FrmFacturas.NuevaFactura()
        End If

    End Sub




End Class