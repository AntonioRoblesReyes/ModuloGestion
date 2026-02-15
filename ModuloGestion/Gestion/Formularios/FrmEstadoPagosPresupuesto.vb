Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmEstadoPagosPresupuesto
    Inherits Form

    Private ReadOnly txtPresupuesto As TextBox
    Private ReadOnly btnBuscar As Button
    Private ReadOnly dgvPagos As DataGridView
    Private ReadOnly dgvFacturas As DataGridView
    Private ReadOnly lblResumen As Label

    Public Sub New()
        Me.New(String.Empty)
    End Sub

    Public Sub New(ByVal idPresupuesto As String)
        Me.Text = "Estado de pagos por presupuesto"
        Me.Width = 1200
        Me.Height = 700
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim panelSuperior As New Panel() With {
            .Dock = DockStyle.Top,
            .Height = 50
        }

        Dim lbl As New Label() With {
            .Text = "Presupuesto:",
            .AutoSize = True,
            .Left = 10,
            .Top = 17
        }

        txtPresupuesto = New TextBox() With {
            .Left = 95,
            .Top = 12,
            .Width = 220,
            .Text = idPresupuesto
        }

        btnBuscar = New Button() With {
            .Text = "Buscar",
            .Left = 325,
            .Top = 10,
            .Width = 100
        }

        AddHandler btnBuscar.Click, AddressOf BtnBuscar_Click

        lblResumen = New Label() With {
            .AutoSize = True,
            .Left = 440,
            .Top = 17,
            .Text = ""
        }

        panelSuperior.Controls.Add(lbl)
        panelSuperior.Controls.Add(txtPresupuesto)
        panelSuperior.Controls.Add(btnBuscar)
        panelSuperior.Controls.Add(lblResumen)

        Dim split As New SplitContainer() With {
            .Dock = DockStyle.Fill,
            .Orientation = Orientation.Horizontal,
            .SplitterDistance = 300
        }

        dgvPagos = New DataGridView() With {
            .Dock = DockStyle.Fill,
            .ReadOnly = True,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .MultiSelect = False
        }

        dgvFacturas = New DataGridView() With {
            .Dock = DockStyle.Fill,
            .ReadOnly = True,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .MultiSelect = False
        }

        split.Panel1.Controls.Add(dgvPagos)
        split.Panel2.Controls.Add(dgvFacturas)

        Me.Controls.Add(split)
        Me.Controls.Add(panelSuperior)

        If Not String.IsNullOrWhiteSpace(idPresupuesto) Then
            CargarDatos(idPresupuesto.Trim())
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim id As String = txtPresupuesto.Text.Trim()
        If String.IsNullOrWhiteSpace(id) Then
            MessageBox.Show("Indique el Id de presupuesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPresupuesto.Focus()
            Return
        End If

        CargarDatos(id)
    End Sub

    Private Sub CargarDatos(ByVal idPresupuesto As String)
        Dim connectionString As String = My.Settings.GestionEmpresaConnectionString
        If String.IsNullOrWhiteSpace(connectionString) Then
            MessageBox.Show("No hay cadena de conexión configurada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim sqlPagos As String = "SELECT d.IdPagoClientesDetalle, d.ID_Cobro, d.Fecha, d.IdFactura, d.Moneda, d.TotalPagado, " &
                                 "c.FormaDePago, c.Observaciones " &
                                 "FROM PagosClientesDetalle d " &
                                 "LEFT JOIN PagosClientes c ON d.ID_Cobro = c.ID_Cobro " &
                                 "WHERE d.Id_Presupuesto = @IdPresupuesto " &
                                 "ORDER BY d.Fecha, d.ID_Cobro"

        Dim sqlFacturas As String = "SELECT f.IdFactura, f.Fecha, f.Moneda, f.[TotalUS$], f.TotalRDS, " &
                                    "ISNULL(SUM(d.TotalPagado), 0) AS TotalPagadoAplicado, " &
                                    "f.Pagado, f.Pendiente " &
                                    "FROM Factura f " &
                                    "INNER JOIN (SELECT DISTINCT IdFactura FROM PagosClientesDetalle WHERE Id_Presupuesto = @IdPresupuesto AND IdFactura IS NOT NULL AND IdFactura <> '') x " &
                                    "ON f.IdFactura = x.IdFactura " &
                                    "LEFT JOIN PagosClientesDetalle d ON d.IdFactura = f.IdFactura AND d.Id_Presupuesto = @IdPresupuesto " &
                                    "GROUP BY f.IdFactura, f.Fecha, f.Moneda, f.[TotalUS$], f.TotalRDS, f.Pagado, f.Pendiente " &
                                    "ORDER BY f.Fecha, f.IdFactura"

        Try
            Using cn As New SqlConnection(connectionString)
                cn.Open()

                Dim tablaPagos As New DataTable()
                Using daPagos As New SqlDataAdapter(sqlPagos, cn)
                    daPagos.SelectCommand.Parameters.AddWithValue("@IdPresupuesto", idPresupuesto)
                    daPagos.Fill(tablaPagos)
                End Using

                Dim tablaFacturas As New DataTable()
                Using daFacturas As New SqlDataAdapter(sqlFacturas, cn)
                    daFacturas.SelectCommand.Parameters.AddWithValue("@IdPresupuesto", idPresupuesto)
                    daFacturas.Fill(tablaFacturas)
                End Using

                dgvPagos.DataSource = tablaPagos
                dgvFacturas.DataSource = tablaFacturas

                Dim totalPagado As Decimal = 0D
                For Each fila As DataRow In tablaPagos.Rows
                    If Not IsDBNull(fila("TotalPagado")) Then
                        totalPagado += Convert.ToDecimal(fila("TotalPagado"))
                    End If
                Next

                lblResumen.Text = String.Format("Pagos: {0} | Facturas: {1} | Total aplicado: {2:N2}",
                                                tablaPagos.Rows.Count,
                                                tablaFacturas.Rows.Count,
                                                totalPagado)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error cargando datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
