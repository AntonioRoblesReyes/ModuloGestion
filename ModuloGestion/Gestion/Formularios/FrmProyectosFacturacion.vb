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

        ' 🔒 Validar selección
        If PresupuestoBindingSource.Position < 0 Then
            MsgBox("Debe seleccionar un presupuesto.")
            Exit Sub
        End If

        If ComboBox1.Text = "" Then
            MsgBox("Debe elegir una moneda a facturar")
            Exit Sub
        End If

        If ComboBox2.SelectedValue Is Nothing Then
            MsgBox("Debe elegir un tipo de comprobante")
            Exit Sub
        End If

        ' 📌 Obtener datos
        Dim fila = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position)

        Dim proyecto As String = fila.Id_proyecto_Presupuestos
        Dim cliente As String = fila.Id_Fiscal
        Dim impuesto As Double = fila.Impuesto

        ' 🔥 ESTE ES EL CLAVE (usa IDComprobante: B11, FCF, NC...)
        Dim tipoComprobante As String = ComboBox2.SelectedValue.ToString().Trim().ToUpper()

        ' 🚀 Abrir formulario según tipo
        Select Case tipoComprobante

            Case "NC"
                ' Nota de crédito
                With My.Forms.FrmFacturas
                    .Show()
                    .NuevaNotaCredito()
                End With

            Case "FCF"
                ' Factura crédito fiscal
                With My.Forms.FrmFacturas
                    .Show()
                    .NuevaFactura()
                End With

            Case "FDC"
                ' Factura de consumo
                With My.Forms.FrmFacturas
                    .Show()
                    .NuevaFactura()
                End With

            Case "B11"
                ' Compras (si tienes otro form cámbialo aquí)
                With My.Forms.FrmFacturas
                    .Show()
                    .ComprobanteB11()
                End With

            Case Else
                ' Cualquier otro
                With My.Forms.FrmFacturas
                    .Show()
                    .NuevaFactura()
                End With

        End Select

    End Sub




End Class