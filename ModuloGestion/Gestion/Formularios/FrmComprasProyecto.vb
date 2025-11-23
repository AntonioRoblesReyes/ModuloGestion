Public Class FrmComprasProyecto

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
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub FrmComprasProyecto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMateriales' Puede moverla o quitarla según sea necesario.
        Me.CompraMaterialesTableAdapter.Fill(Me.DsCompras.CompraMateriales)
        'TODO: esta línea de código carga datos en la tabla 'DsPreciosCompra.PreciosCompra' Puede moverla o quitarla según sea necesario.
        Me.PreciosCompraTableAdapter.Fill(Me.DsPreciosCompra.PreciosCompra)
        'TODO: esta línea de código carga datos en la tabla 'DsTasa.Tasa' Puede moverla o quitarla según sea necesario.
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)
        'TODO: esta línea de código carga datos en la tabla 'DsProyectos.Proyectos' Puede moverla o quitarla según sea necesario.
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        'TODO: esta línea de código carga datos en la tabla 'DsProveedores.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DsProveedores.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestos.Presupuesto' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.Fill(Me.DsPresupuestos.Presupuesto)
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMaterialesDetalle' Puede moverla o quitarla según sea necesario.
        Me.CompraMaterialesDetalleTableAdapter.Fill(Me.DsCompras.CompraMaterialesDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsTasa.Tasa' Puede moverla o quitarla según sea necesario.
        Me.TasaTableAdapter.Fill(Me.DsTasa.Tasa)
        'TODO: esta línea de código carga datos en la tabla 'DsCompras.CompraMaterialesDetalle' Puede moverla o quitarla según sea necesario.
        Me.PresupuestoTableAdapter.FillByAprobado(DsPresupuestos.Presupuesto)
        Dim fechaPredeterminada As Date = Date.Now.AddDays(-7)
        DateTimePicker3.Value = fechaPredeterminada
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








    Private Sub BtmynVerConmpra_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerConmpra.Click

        My.Forms.FrmIngresoCompras.Close()
        My.Forms.FrmIngresoCompras.Label1.Text = Me.DsCompras.CompraMateriales(Me.CompraMaterialesBindingSource.Position).Id_Compra

        My.Forms.FrmIngresoCompras.ModificarCompra()
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
                    ' Manejar el caso donde no hay presupuesto en la posición actual (opcional)
                    ' Puedes mostrar un mensaje o realizar alguna acción adicional
                    MessageBox.Show("No hay presupuesto en la posición actual.")
                End If
            Else
                ' Manejar el caso donde no hay fila seleccionada en el DataGridView (opcional)
                ' Puedes mostrar un mensaje o realizar alguna acción adicional
                MessageBox.Show("No hay fila seleccionada en el DataGridView.")
            End If
        End If


    End Sub

    Private Sub CompraMaterialesDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CompraMaterialesDetalleDataGridView.CellEndEdit
        ValidarDetalle()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.ImpCompras.Close()
        My.Forms.ImpCompras.ImprimirListado()
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

        Me.CompraMaterialesTableAdapter.FillByBuscar(DsCompras.CompraMateriales, "%" & TxtBuscar.Text & "%")
    End Sub

    Private Sub TxtBuscar_leave(sender As Object, e As EventArgs) Handles TxtBuscar.Leave

        Totales()
    End Sub


    Private Sub TxtValor_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged
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