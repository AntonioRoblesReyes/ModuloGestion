Public Class FrmProveedoresListado

#Region "=== MÉTODOS PÚBLICOS DE APERTURA ==="

    Public Sub AbrirParaNuevaCompra()
        AbrirListado(True)
    End Sub

    Public Sub AbrirListadoGeneral()
        AbrirListado(False)
    End Sub

#End Region
#Region "=== MÉTODOS PÚBLICOS LEGADOS (NO ELIMINAR) ==="

    ' === MANTENER COMPATIBILIDAD CON EL SISTEMA EXISTENTE ===

    Public Sub Listado()
        AbrirListado(False)
    End Sub

    Public Sub Nuevacompra()
        AbrirListado(True)
    End Sub

    Public Sub NuevaFactura()
        AbrirListado(True)
    End Sub

#End Region




#Region "=== EVENTOS DEL FORMULARIO ==="


    Private Sub FrmProveedoresListado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

#End Region



#Region "=== BOTONES ==="

    Private Sub BtnVerProveedor_Click(sender As Object, e As EventArgs) Handles BtnVerProveedor.Click
        If ProveedoresBindingSource.Current Is Nothing Then Exit Sub

        My.Forms.FrmProveedores.LblIdProveedor.Text =
            DsProveedores.Proveedores(ProveedoresBindingSource.Position).Id_Proveedor

        My.Forms.FrmProveedores.VerProveedor()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        My.Forms.FrmProveedores.Nuevo()
    End Sub

    Private Sub BtnAceptarProveedor_Click(sender As Object, e As EventArgs) Handles BtnAceptarProveedor.Click
        Try
            If ProveedoresBindingSource.Position < 0 Then
                MessageBox.Show("No hay proveedor seleccionado.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            PrepararNuevaCompra()
            Me.Close()

        Catch ex As Exception
            MostrarError("Error al seleccionar el proveedor.", ex)
        End Try
    End Sub

#End Region

#Region "=== LÓGICA DE NEGOCIO ==="

    Private Sub PrepararNuevaCompra()

        Try

            If ProveedoresBindingSource.Current Is Nothing Then
                MessageBox.Show("Debe seleccionar un proveedor.",
                            "Proveedor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim row As DsProveedores.ProveedoresRow =
            CType(CType(ProveedoresBindingSource.Current, DataRowView).Row,
                  DsProveedores.ProveedoresRow)

            Dim frm As FrmIngresoCompras = My.Forms.FrmIngresoCompras

            frm.EsNuevaCompra = True

            ' Mostrar primero el formulario para asegurar que Load ya se ejecutó
            If Not frm.Visible Then
                frm.Show()
            End If

            ' ============================
            ' DATOS DEL PROVEEDOR
            ' ============================
            frm.LblProveedor.Text = row.Id_Proveedor
            frm.Id_ProveedorTextBox.Text = row.Id_Proveedor
            frm.Id_EmpresaTextBox.Text = "IN"

            If row.IsItebis1Null() Then
                frm.PorcientoImpuestoTextBox.Text = "0.18"
            Else
                frm.PorcientoImpuestoTextBox.Text = row.Itebis1.ToString()
            End If

            If row.IsMonedaNull() Then
                frm.MonedaTextBox.Text = "US$"
            Else
                frm.MonedaTextBox.Text = row.Moneda.ToString().Trim().ToUpper()
            End If

            ' ============================
            ' CONTEXTO
            ' ============================
            frm.LblPresupuesto.Text = Me.LblPresupuesto.Text
            frm.LblProyecto.Text = Me.LblProyecto.Text

            ' ============================
            ' NUEVO ID DE COMPRA
            ' ============================
            Dim nuevoId As Object =
            frm.CompraMaterialesTableAdapter.Siguiente("IN")

            If nuevoId Is Nothing OrElse IsDBNull(nuevoId) OrElse nuevoId.ToString.Trim = "" Then
                frm.Id_CompraTextBox.Text = "IN-0001"
            Else
                frm.Id_CompraTextBox.Text = nuevoId.ToString()
            End If

            ' ============================
            ' CARGAR TASA DEL DÍA
            ' ============================
            CargarTasaDelDia(frm)

            ' Si no encontró tasa, dejar 1 para evitar errores
            If String.IsNullOrWhiteSpace(frm.TasaTextBox.Text) Then
                frm.TasaTextBox.Text = "1"
            End If

            ' ============================
            ' REFRESCAR GRID Y TOTALES
            ' ============================
            frm.DataGrid()
            frm.Totales()

            frm.BringToFront()

        Catch ex As Exception

            MessageBox.Show(
            "Error preparando la nueva compra:" & vbCrLf & vbCrLf &
            ex.Message & vbCrLf & vbCrLf &
            ex.StackTrace,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub CargarTasaDelDia(frm As FrmIngresoCompras)

        Dim hoy As Date = Date.Today
        frm.TasaTableAdapter.FillByIdFecha(frm.DsTasa.Tasa, hoy)

        If frm.DsTasa.Tasa.Rows.Count = 0 Then

            MessageBox.Show(
                $"No existe tasa registrada para hoy ({hoy.ToShortDateString()}).",
                "Tasa no encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            My.Forms.FrmAdministrativas.ShowDialog()
            frm.TasaTableAdapter.FillByIdFecha(frm.DsTasa.Tasa, hoy)

            If frm.DsTasa.Tasa.Rows.Count = 0 Then
                Throw New Exception("No se ha registrado la tasa del día.")
            End If

        End If

        frm.TasaTextBox.Text = frm.DsTasa.Tasa(0)("Media").ToString()

    End Sub

#End Region

#Region "=== BÚSQUEDA Y GRILLAS ==="

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ProveedoresTableAdapter.FillByBuscar(
            DsProveedores.Proveedores,
            "%" & TxtBuscar.Text & "%"
        )
    End Sub

    Private Sub ProveedoresDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles ProveedoresDataGridView.CellClick

        If ProveedoresBindingSource.Current Is Nothing Then Exit Sub

        Dim proveedor As String =
            DsProveedores.Proveedores(ProveedoresBindingSource.Position).Id_Proveedor

        CompraMaterialesTableAdapter.FillByIdProveedor(
            DsCompras.CompraMateriales,
            proveedor
        )

    End Sub

    Private Sub ProveedoresDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) _
        Handles ProveedoresDataGridView.CellEndEdit

        Try
            Validate()
            ProveedoresBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsProveedores)
        Catch ex As Exception
            MostrarError("Error al actualizar el proveedor.", ex)
        End Try

    End Sub

#End Region

#Region "=== UTILIDADES ==="

    Private Sub MostrarError(mensaje As String, ex As Exception)
        MessageBox.Show(
            mensaje & vbCrLf & vbCrLf & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
    End Sub

    Private Sub AbrirListado(Optional esNuevaCompra As Boolean = False)

        BtnVerProveedor.Visible = True
        BtnAceptarProveedor.Visible = True

        ' 1️⃣ Limpiar antes (opcional pero sano)
        DsProveedores.Proveedores.Clear()
        DsCompras.CompraMateriales.Clear()

        ' 2️⃣ Cargar datos
        ProveedoresTableAdapter.Fill(DsProveedores.Proveedores)
        CompraMaterialesTableAdapter.Fill(DsCompras.CompraMateriales)

        ' 3️⃣ Mostrar formulario
        If Not Me.Visible Then Me.Show()

    End Sub

    Private Sub FrmProveedoresListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BtnVerProveedor.Visible = True
            BtnAceptarProveedor.Visible = True
            ProveedoresTableAdapter.Fill(DsProveedores.Proveedores)
            CompraMaterialesTableAdapter.Fill(DsCompras.CompraMateriales)



        Catch ex As Exception
            MostrarError("Error al abrir el listado de proveedores.", ex)
        End Try
    End Sub

#End Region

End Class
