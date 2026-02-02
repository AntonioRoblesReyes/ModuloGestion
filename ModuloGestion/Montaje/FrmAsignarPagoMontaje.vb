Public Class FrmAsignarPagoMontaje
    Sub AsignarPago()
        Me.PagoMontajeTableAdapter.FillByIdPago(
        DsPagosMontaje.PagoMontaje,
        IdPagoMontajeTextBox.Text)

        Me.FacturaMontajeTableAdapter.FillByFacturasPendientes(
        DsPagosMontaje.FacturaMontaje,
        IdEmpresaMontajeTextBox.Text)
    End Sub

    Private Sub FacturaMontajeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaMontajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagosMontaje)

    End Sub

    Private Sub FrmAsignarPagoMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub




    Private Sub FacturaMontajeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturaMontajeDataGridView.CellClick

        Dim pendientePago As Double = FacturaMontajeDataGridView.CurrentRow.Cells("PendienteInstalador").Value
        Dim pendienteA As Double = PendienteAsignarTextBox.Text
        Dim Facturamontaje As String = FacturaMontajeDataGridView.CurrentRow.Cells("IdFactura").Value
        Dim IdPresupuesto As String = FacturaMontajeDataGridView.CurrentRow.Cells("Id_Presupuesto").Value
        Me.FacturaMontajeDetalleTableAdapter.FillByIdFactura(Me.DsPagosMontaje.FacturaMontajeDetalle, Facturamontaje)
        Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsPresupuestos.Presupuesto, IdPresupuesto)
        Me.Label2.Text = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Descripcion_Presupuesto
        If pendientePago <= PendienteAsignarTextBox.Text Then
            Me.TextBox1.Text = Format(pendientePago, "#,##0.00")
        Else
            Me.TextBox1.Text = Format(pendienteA, "#,##0.00")
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        ' ==========================
        ' VALIDACIONES BÁSICAS
        ' ==========================
        If FacturaMontajeDataGridView.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione una factura.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Indique el monto a asignar.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim montoAsignar As Decimal
        If Not Decimal.TryParse(TextBox1.Text, montoAsignar) OrElse montoAsignar <= 0 Then
            MessageBox.Show("El monto a asignar no es válido.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ==========================
        ' DATOS CLAVE
        ' ==========================
        Dim idPago As String =
            IdPagoMontajeTextBox.Text.Trim()

        Dim idFactura As String =
            FacturaMontajeDataGridView.CurrentRow.Cells("IdFactura").Value.ToString()

        ' ==========================
        ' EJECUTA TODA LA LÓGICA EN SQL
        ' ==========================
        Try
            Using cn As New SqlClient.SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlClient.SqlCommand("dbo.sp_AsignarPagoFacturaMontaje", cn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add("@IdPagoMontaje", SqlDbType.NVarChar, 25).Value = idPago
                    cmd.Parameters.Add("@IdFacturaMontaje", SqlDbType.NVarChar, 25).Value = idFactura
                    cmd.Parameters.Add("@MontoAsignar", SqlDbType.Decimal).Value = montoAsignar

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' ==========================
            ' REFRESCO DE PANTALLA
            ' ==========================
            PagoMontajeTableAdapter.Fill(DsPagosMontaje.PagoMontaje)

            FacturaMontajeTableAdapter.FillByFacturasPendientes(
                DsPagosMontaje.FacturaMontaje,
                IdEmpresaMontajeTextBox.Text.Trim()
            )

            MessageBox.Show("Pago asignado correctamente.",
                            "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' 🔄 Refrescar formulario resumen si está abierto
            If Application.OpenForms.OfType(Of FrmFacturaMontajeResumen).Any() Then
                With My.Forms.FrmPagosMomtajeResumen
                    .PagoMontajeTableAdapter.FillByConSaldoPendiente(.DsPagosMontaje.PagoMontaje)
                End With
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al asignar el pago: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class