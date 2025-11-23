Public Class FrmVerClientes
    Dim IdCliente As String

    Sub Vercliente()
        Try
            If Me.MdiParent Is Nothing Then
                Me.MdiParent = My.Forms.FrmGestion
                Me.Dock = DockStyle.Fill
            End If

            Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
            If ClientesDataGridView IsNot Nothing Then
                AplicarEstiloDGV(ClientesDataGridView)
            End If
            Me.Show()
        Catch ex As Exception
            MsgBox("Error al abrir clientes: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AplicarEstiloDGV(dgv As DataGridView)
        With dgv
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 110, 165)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

            .GridColor = Color.LightGray
            .BorderStyle = BorderStyle.FixedSingle

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
        End With
    End Sub

    Private Sub FrmVerClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AplicarEstiloFormulario(Me)
        If ClientesDataGridView IsNot Nothing Then
            AplicarEstiloDGV(ClientesDataGridView)
        End If
    End Sub

    Private Sub TxtBuscar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.MouseEnter
        If TxtBuscar.Text = "Busca Cliente" Then
            TxtBuscar.Text = ""
            TxtBuscar.Focus()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        Try
            If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
                Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
            Else
                Me.ClientesTableAdapter.FillByRazonSocial(Me.DsClientes.Clientes, "%" & TxtBuscar.Text & "%")
            End If
        Catch ex As Exception
            ' Mejor mostrar mensaje si tienes error, o bien ignóralo
        End Try
    End Sub

    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub CmdNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNuevoProyecto.Click
        If ClientesBindingSource.Position < 0 Then
            MsgBox("Seleccione un cliente.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        IdCliente = DsClientes.Clientes(ClientesBindingSource.Position).Id_Fiscal
        My.Forms.FrmProyectos.Show()
        My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, IdCliente)
        My.Forms.FrmProyectos.TxtIdFiscalCliente.Text = IdCliente
        My.Forms.FrmProyectos.ProyectosBindingNavigator.Visible = False
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsClientes)
    End Sub

    Private Sub BtnVerCliente_Click(sender As Object, e As EventArgs) Handles BtnVerCliente.Click
        If ClientesBindingSource.Position < 0 Then
            MsgBox("Seleccione un cliente para ver.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim idFiscal As String = Me.DsClientes.Clientes(ClientesBindingSource.Position).Id_Fiscal

        My.Forms.FrmCliente.Close()
        My.Forms.FrmCliente.MostrarComoHijoMDI()
        My.Forms.FrmCliente.Id_FiscalTextBox.Text = idFiscal
        My.Forms.FrmCliente.verCliente()
        Me.Close()
    End Sub
    Private Sub BtnNuevoCliente_Click(sender As Object, e As EventArgs) Handles BtnNuevoCliente.Click
        ' Cerrar instancia previa si existe
        If My.Forms.FrmCliente.Visible Then My.Forms.FrmCliente.Close()

        ' Llamar al método personalizado en FrmCliente
        My.Forms.FrmCliente.CrearNuevoCliente()
        My.Forms.FrmCliente.MostrarComoHijoMDI()
        Me.Close()
    End Sub

End Class
