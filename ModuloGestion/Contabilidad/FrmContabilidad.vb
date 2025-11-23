Public Class FrmContabilidad

    ''' <summary>
    ''' Retorna la fecha actual.
    ''' </summary>
    Private Function ObtenerFechaActual() As Date
        Return Date.Now()
    End Function







    Private Sub FacturaDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaDeVentaToolStripMenuItem.Click
        With My.Forms.FrmVerFacturas
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        With My.Forms.FrmProveedores
            If Not .Visible Then
                .VerProveedorContabilidad()
                .Show()
            End If
        End With
    End Sub

    Private Sub FacturaProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaProveedoresToolStripMenuItem.Click
        With My.Forms.FrmFacturasProveedor
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub NuecoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuecoToolStripMenuItem.Click
        With My.Forms.FrmCliente
            If Not .Visible Then
                '.NuevoCliente()
                .Show()
            End If
        End With
    End Sub

    Private Sub IngresoTiempoTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoTiempoTrabajoToolStripMenuItem.Click
        With My.Forms.FrmHorarios
            If Not .Visible Then
                .Inicio()
                .Show()
            End If
        End With
    End Sub

    Private Sub NominaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NominaToolStripMenuItem.Click
        With My.Forms.FrmNomina
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub ListadoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoProveedoresToolStripMenuItem.Click
        With My.Forms.FrmProveedoresListado
            If Not .Visible Then
                .Listado()
                .Show()
            End If
        End With
    End Sub

    Private Sub MantenimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem1.Click
        With My.Forms.FrmProveedores
            .ProveedoresTableAdapter.Fill(.DsProveedores.Proveedores)
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub OrdenesDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesDeCompraToolStripMenuItem.Click
        With My.Forms.FrmComprasProyecto
            If Not .Visible Then
                .Compras()
                .Show()
            End If
        End With
    End Sub

    Private Sub PagosRecibidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosRecibidosToolStripMenuItem.Click
        With My.Forms.FrmCobros
            If Not .Visible Then .Show()
        End With
    End Sub




    Private Sub ActivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem1.Click
        With My.Forms.FrmEmpleados
            If Not .Visible Then
                .MantenimientoEmpleadosActivos()
                .Show()
            End If
        End With
    End Sub

    Private Sub InActivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InActivosToolStripMenuItem1.Click
        With My.Forms.FrmEmpleados
            If Not .Visible Then
                .MantenimientoEmpleadosInActivos()
                .Show()
            End If
        End With
    End Sub

    Private Sub NuevaOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaOrdenToolStripMenuItem.Click
        With My.Forms.FrmProveedoresListado
            If Not .Visible Then
                .Nuevacompra()
                .Show()
            End If
        End With
    End Sub

    Private Sub VerOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerOrdenToolStripMenuItem.Click
        With My.Forms.FrmComprasProyecto
            If Not .Visible Then
                .Compras()
                .Show()
            End If
        End With
    End Sub

    Private Sub ConsultaPreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPreciosToolStripMenuItem.Click
        With My.Forms.FrmConsultaPrecios
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub PagosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem1.Click
        With My.Forms.FrmPagosMomtajeResumen
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub EmpresaMontajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaMontajeToolStripMenuItem.Click
        With My.Forms.FrmEmpresaMontaje
            If Not .Visible Then
                .Cargar()
                .Show()
            End If
        End With
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        With My.Forms.FrmFacturaMontajeResumen
            If Not .Visible Then
                .Todos()
                .Show()
            End If
        End With
    End Sub

    Private Sub ContratoObraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratoObraToolStripMenuItem.Click
        With My.Forms.FrmContratoObra
            If Not .Visible Then .Show()
        End With
    End Sub

    Private Sub AvanceEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvanceEmpleadosToolStripMenuItem.Click
        With My.Forms.FrmListadoEnpleados
            If Not .Visible Then
                .Activos()
                .Show()
            End If
        End With
    End Sub

    Private Sub FrmContabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuStrip1.BackColor = Color.FromArgb(40, 116, 166) ' Azul moderno
        MenuStrip1.ForeColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 9, FontStyle.Regular)

        ' Estilo moderno en Items del Menú
        For Each item As ToolStripMenuItem In MenuStrip1.Items
            item.Padding = New Padding(5, 2, 5, 2)
        Next

        ' Maximiza la ventana para mejor presentación
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.WhiteSmoke

    End Sub
End Class
