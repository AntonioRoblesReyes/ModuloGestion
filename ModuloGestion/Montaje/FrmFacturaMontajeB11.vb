Imports System.Data.SqlClient

Public Class FrmFacturaMontajeB11
    Inherits FrmFacturaMontajeEditar

    Private lblNcfB11 As Label
    Private txtNcfB11 As TextBox
    Private btnGuardarB11 As Button
    Private btnRecalcularB11 As Button

    Private Sub FrmFacturaMontajeB11_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ConfigurarInterfazB11()
    End Sub

    Private Sub ConfigurarInterfazB11()
        Me.Text = "FrmFacturaMontajeB11"

        BtnAprobarPago.Text = "Nueva factura"
        BtnNuevalínea.Text = "Añadir línea"
        Button2.Text = "Imprimir"

        If lblNcfB11 Is Nothing Then
            lblNcfB11 = New Label()
            lblNcfB11.AutoSize = True
            lblNcfB11.Location = New Point(560, 236)
            lblNcfB11.Name = "lblNcfB11"
            lblNcfB11.Text = "NCF B11:"
            Controls.Add(lblNcfB11)
        End If

        If txtNcfB11 Is Nothing Then
            txtNcfB11 = New TextBox()
            txtNcfB11.Location = New Point(640, 233)
            txtNcfB11.Name = "txtNcfB11"
            txtNcfB11.Size = New Size(190, 31)
            Controls.Add(txtNcfB11)
        End If

        If btnGuardarB11 Is Nothing Then
            btnGuardarB11 = New Button()
            btnGuardarB11.BackColor = Color.WhiteSmoke
            btnGuardarB11.FlatStyle = FlatStyle.Flat
            btnGuardarB11.FlatAppearance.BorderSize = 0
            btnGuardarB11.Cursor = Cursors.Hand
            btnGuardarB11.Location = New Point(844, 233)
            btnGuardarB11.Size = New Size(102, 28)
            btnGuardarB11.Text = "Guardar"
            Controls.Add(btnGuardarB11)
            AddHandler btnGuardarB11.Click, AddressOf BtnGuardarB11_Click
        End If

        If btnRecalcularB11 Is Nothing Then
            btnRecalcularB11 = New Button()
            btnRecalcularB11.BackColor = Color.WhiteSmoke
            btnRecalcularB11.FlatStyle = FlatStyle.Flat
            btnRecalcularB11.FlatAppearance.BorderSize = 0
            btnRecalcularB11.Cursor = Cursors.Hand
            btnRecalcularB11.Location = New Point(960, 233)
            btnRecalcularB11.Size = New Size(110, 28)
            btnRecalcularB11.Text = "Recalcular"
            Controls.Add(btnRecalcularB11)
            AddHandler btnRecalcularB11.Click, AddressOf BtnRecalcularB11_Click
        End If


        RemoveHandler Button2.Click, AddressOf BtnImprimirB11_Click
        AddHandler Button2.Click, AddressOf BtnImprimirB11_Click

        CargarNCFActual()
    End Sub


    Private Sub BtnGuardarB11_Click(sender As Object, e As EventArgs)
        GuardarFacturaB11()
    End Sub

    Private Sub BtnRecalcularB11_Click(sender As Object, e As EventArgs)
        SumaTotal()
        CargarNCFActual()
    End Sub

    Private Sub BtnImprimirB11_Click(sender As Object, e As EventArgs)
        Try
            GuardarFacturaB11()
            My.Forms.ImpPagoMomtaje.Label1.Text = IdFacturaTextBox.Text
            My.Forms.ImpPagoMomtaje.ImprimirFacturaNfc()
        Catch ex As Exception
            MessageBox.Show("Error al imprimir comprobante B11: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarNCFActual()
        Try
            If FacturaMontajeBindingSource.Current Is Nothing Then Exit Sub
            Dim fila As DataRowView = CType(FacturaMontajeBindingSource.Current, DataRowView)
            txtNcfB11.Text = Convert.ToString(fila("NCF"))
        Catch
        End Try
    End Sub

    Private Sub GuardarFacturaB11()
        Try
            If String.IsNullOrWhiteSpace(IdFacturaTextBox.Text) Then
                MessageBox.Show("Debe seleccionar o crear una factura.")
                Exit Sub
            End If

            Dim ncf As String = txtNcfB11.Text.Trim()

            Using cn As New SqlConnection(My.Settings.GestionEmpresaConnectionString)
                Using cmd As New SqlCommand("UPDATE FacturaMontaje SET NCF=@NCF WHERE IdFacturaMontaje=@IdFactura", cn)
                    cmd.Parameters.AddWithValue("@NCF", ncf)
                    cmd.Parameters.AddWithValue("@IdFactura", IdFacturaTextBox.Text)
                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            FacturaMontajeTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontaje, IdFacturaTextBox.Text)
            FacturaMontajeDetalleTableAdapter.FillByIdFactura(DsPagosMontaje.FacturaMontajeDetalle, IdFacturaTextBox.Text)
            SumaTotal()

            MessageBox.Show("Factura B11 guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al guardar factura B11: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
