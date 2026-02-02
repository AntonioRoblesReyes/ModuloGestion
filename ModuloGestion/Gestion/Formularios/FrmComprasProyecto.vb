Public Class FrmComprasProyecto

    ' Bandera para saber cuándo el formulario está cargando datos
    Private cargando As Boolean = False

    Sub ComprasAdministrar()
        Me.lblempresa.Text = "IN"

        Me.MdiParent = My.Forms.FrmGestion
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Me.Show()
    End Sub

    Sub ValidarDetalle()
        Me.Validate()
        Me.CompraMaterialesDetalleBindingSource.EndEdit()
        Me.CompraMaterialesDetalleTableAdapter.Update(DsCompras)
    End Sub

    Sub Compras()

        Me.lblempresa.Text = "IN"

        Me.MdiParent = My.Forms.FrmGestion
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
        Me.MdiParent = My.Forms.FrmContabilidad
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Me.Show()

    End Sub

    Public Sub Filtrarpresupuesto()

        Me.lblempresa.Text = My.Forms.FrmProyectos.DsPresupuestos.Presupuesto(My.Forms.FrmProyectos.PresupuestoBindingSource.Position).Id_empresa
        Me.LblProyecto.Text = My.Forms.FrmProyectos.DsPresupuestos.Presupuesto(My.Forms.FrmProyectos.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
        Me.LblPresupuesto.Text = My.Forms.FrmProyectos.DsPresupuestos.Presupuesto(My.Forms.FrmProyectos.PresupuestoBindingSource.Position).Id_Presupuesto

        Me.MdiParent = My.Forms.FrmGestion
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)

        'Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Dim Proyecto As String = My.Forms.FrmProyectos.DsPresupuestos.Presupuesto(My.Forms.FrmProyectos.PresupuestoBindingSource.Position).Id_proyecto_Presupuestos
        Me.CompraMaterialesTableAdapter.FillByIdProyecto(DsCompras.CompraMateriales, Proyecto)

        'Me.CompraMaterialesTableAdapter.Fill(DsCompras.CompraMateriales)

        Me.Totales()
        Me.Show()
    End Sub

    Public Sub FiltrarProyecto()
        Me.MdiParent = My.Forms.FrmGestion
        'Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)

        'Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Me.BtnNuevaCompra.Enabled = True
        Me.Totales()
        Me.Show()
    End Sub

    Sub Totales()
        ' No recalculamos totales mientras está cargando para no ralentizar
        If cargando Then Exit Sub

        Dim subtotal As Double = 0
        Dim impuesto As Double = 0
        Dim Sumatotal As Double = 0

        Try
            For Each row As DataRow In Me.DsCompras.Tables(0).Rows
                Dim SuUS As Double = CDbl(row("SubTotalCompraUS"))
                Dim ImUS As Double = CDbl(row("ImpuestoCompraUS"))
                Dim ToUS As Double = CDbl(row("TotalCompraUS"))
                subtotal += SuUS
                impuesto += ImUS
                Sumatotal += ToUS
            Next

            Me.LblSubTotal.Text = Format(subtotal, "#,##0.00")
            Me.LblImpuesto.Text = Format(impuesto, "#,##0.00")
            Me.LblTotal.Text = Format(Sumatotal, "#,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub FiltrarProyectoEmpresa()
        Try
            Me.MdiParent = My.Forms.FrmGestion
            Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
            Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
            Me.CompraMaterialesTableAdapter.FillByIdProyectoEmpresa(Me.DsCompras.CompraMateriales, lblempresa.Text, LblProyecto.Text)

            Me.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmComprasProyecto_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cerrardatset(Me)
        CerrarGrill(Me)
    End Sub

    ' LOAD: ahora solo hace cosas ligeras, no carga datos pesados
    Private Sub FrmComprasProyecto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Fecha por defecto
        Dim fechaPredeterminada As Date = Date.Now.AddDays(-7)
        DateTimePicker3.Value = fechaPredeterminada
    End Sub

    ' SHOWN: aquí se hace toda la carga pesada, después de que el formulario ya se ve
    Private Sub FrmComprasProyecto_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cargando = True
        Try
            ' Tasa
            Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)

            ' Proveedores
            Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)

            ' Proyectos
            Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)

            ' CompraMateriales
            Me.CompraMaterialesTableAdapter.FillUltimas500(Me.DsCompras.CompraMateriales)

            ' *** SOLO APROBADOS ***
            Me.PresupuestoTableAdapter.FillByAprobado(Me.DsPresupuestos.Presupuesto)

        Catch ex As Exception
            MsgBox("Error cargando datos: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            cargando = False
        End Try

        ' Calcula totales solo cuando todo terminó de cargar
        Totales()
    End Sub

    Private Sub BtnNuevaCompra_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevaCompra.Click

        Dim Fecha As Date = Date.Now
        Me.TasaTableAdapter.FillByIdFecha(Me.DsTasa.Tasa, Fecha)

        My.Forms.FrmProveedoresListado.Close()
        My.Forms.FrmProveedoresListado.LblEmpresa.Text = Me.lblempresa.Text
        My.Forms.FrmProveedoresListado.LblProyecto.Text = Me.LblProyecto.Text
        My.Forms.FrmProveedoresListado.LblPresupuesto.Text = Me.LblPresupuesto.Text
        My.Forms.FrmProveedoresListado.BtnAceptarProveedorFactura.Visible = False

        My.Forms.FrmProveedoresListado.Nuevacompra()

    End Sub

    Private Sub PreciosCompraDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim IdMaterial As String = Me.DsPreciosCompra.PreciosCompra(Me.PreciosCompraBindingSource.Position).Id_Material
        'Me.CompraMaterialesDetalleTableAdapter.FillByIdMaterial(Me.DsComprasDetalle.CompraMaterialesDetalle, IdMaterial)
    End Sub

    Private Sub BtnVerConmpra_Click(sender As Object, e As EventArgs) Handles BtnVerConmpra.Click
        Try
            Dim idCompra As String = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Compra

            Dim f As New FrmIngresoCompras()

            f.EsNuevaCompra = False   ' ←←← MODO EDICIÓN

            f.CargarCompra(idCompra)
            f.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("No se pudo abrir la compra seleccionada." & vbCrLf & ex.Message)
        End Try
    End Sub


    Private Sub ComprasPorProyectoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComprasPorProyectoDataGridView.CellClick
        Dim Idcompra As String = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Compra
        Me.CompraMaterialesDetalleTableAdapter.FillByIdCompra(Me.DsCompras.CompraMaterialesDetalle, Idcompra)
        Label5.Text = ""
    End Sub

    Private Sub CompraMaterialesDetalleDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellClick
        If e.ColumnIndex = 6 Then
            ' Verificar si hay alguna fila seleccionada en el DataGridView
            If Me.CompraMaterialesDetalleDataGridView.CurrentRow IsNot Nothing Then
                ' Verificar si hay algún presupuesto en la posición actual del PresupuestoBindingSource
                If Me.PresupuestoBindingSource.Position >= 0 AndAlso Me.PresupuestoBindingSource.Count > Me.PresupuestoBindingSource.Position Then
                    Dim IdPresupuesto As String = Me.DsPresupuestos.Presupuesto(Me.PresupuestoBindingSource.Position).Id_Presupuesto

                    ' Forzar la celda en la posición 5 de la fila actual a estar en modo de edición
                    Me.CompraMaterialesDetalleDataGridView.BeginEdit(True)

                    ' Asignar el valor de IdPresupuesto a la celda en la posición 5 de la fila actual
                    Me.CompraMaterialesDetalleDataGridView.CurrentRow.Cells(5).Value = IdPresupuesto
                    Me.Validate()
                    Me.CompraMaterialesDetalleBindingSource.EndEdit()
                    Me.CompraMaterialesDetalleTableAdapter.Update(DsCompras)
                Else
                    MessageBox.Show("No hay presupuesto en la posición actual.")
                End If
            Else
                MessageBox.Show("No hay fila seleccionada en el DataGridView.")
            End If
        End If
    End Sub

    Private Sub CompraMaterialesDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellEndEdit
        ValidarDetalle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Forms.ImpCompras.Close()
        Catch
        End Try

        ' Tomar el ID desde la fila actual del BindingSource (SIEMPRE ES CORRECTO)
        If CompraMaterialesBindingSource.Current Is Nothing Then
            MsgBox("No hay compra seleccionada.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim fila As DataRowView = CType(CompraMaterialesBindingSource.Current, DataRowView)
        Dim idCompra As String = fila("Id_Compra").ToString()

        ' Mostrarlo por seguridad
        MsgBox("ID enviado a impresión: " & idCompra)

        ' Pasar el Id al formulario de impresión
        My.Forms.ImpCompras.LblIdCompra.Text = idCompra

        ' Ejecutar impresión
        My.Forms.ImpCompras.ImprimirCompra()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.FrmCuentasPorPagar.Close()
        My.Forms.FrmCuentasPorPagar.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Forms.FemCuentasPorPagarEmpleados.Close()
        My.Forms.FemCuentasPorPagarEmpleados.Show()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        ' Evita que durante la carga inicial se estén ejecutando filtros
        If cargando Then Exit Sub

        Me.CompraMaterialesTableAdapter.FillByBuscar(DsCompras.CompraMateriales, "%" & TxtBuscar.Text & "%")
    End Sub

    Private Sub TxtBuscar_leave(sender As Object, e As EventArgs) Handles TxtBuscar.Leave
        Totales()
    End Sub

    Private Sub TxtValor_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged
        ' Evita consultas mientras el formulario aún está cargando
        If cargando Then Exit Sub

        Dim filtro As String = TxtValor.Text.Trim()
        If String.IsNullOrEmpty(filtro) Then
            ' Si está vacío, carga todos los datos
            Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Else
            ' Filtra por los campos numéricos usando LIKE
            Me.CompraMaterialesTableAdapter.FillByTotal(Me.DsCompras.CompraMateriales, "%" & filtro & "%")
        End If
    End Sub

    Private Sub BtnFiltrarFecha_Click(sender As Object, e As EventArgs) Handles BtnFiltrarFecha.Click
        Dim fecha As Date = DateTimePicker3.Value.Date
        Me.CompraMaterialesTableAdapter.FillByFecha1(Me.DsCompras.CompraMateriales, fecha)
        Totales()
    End Sub

    Private Sub BtnQuitarFiltroFecha_Click(sender As Object, e As EventArgs) Handles BtnQuitarFiltroFecha.Click
        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        Totales()
    End Sub

End Class
