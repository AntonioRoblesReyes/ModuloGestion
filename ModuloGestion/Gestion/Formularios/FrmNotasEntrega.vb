Public Class FrmNotasEntrega
    Sub NuevaNotaEntregadeproyecto()
        Me.NotasEntregaBindingSource.AddNew()



        Me.Id_Nota_EntregaTextBox.Text = My.Forms.FrmVerNotasEntregas.txtsiguiente.Text
        Me.Id_ProyectoTextBox.Text = My.Forms.FrmVerNotasEntregas.txtproyecto.Text
        Me.Id_PresupuestoTextBox.Text = My.Forms.FrmVerNotasEntregas.txtpresupuesto.Text
        Me.Id_EmpresaTextBox.Text = My.Forms.FrmVerNotasEntregas.txtempresa.Text
        Me.ConductoresTableAdapter.Fill(DsConductores.Conductores)
        Me.VehiculosTransporteTableAdapter.Fill(Me.DsVehiculosTransporte.VehiculosTransporte)
        Me.EmpresasTransporteTableAdapter.Fill(Me.DsEmpresasTransporte.EmpresasTransporte)
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Id_PresupuestoTextBox.Text)
        Me.EstadoentregasTableAdapter.FillByIdPresupuesto(Me.DsEstadoEntregas.Estadoentregas, Id_PresupuestoTextBox.Text)
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
        Me.EstadoEntregasherrajesTableAdapter.FillByIdpresupuesto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Me.Id_PresupuestoTextBox.Text)
    End Sub
    Sub NuevaNotaEntrega()
        Me.NotasEntregaBindingSource.AddNew()

        Me.Id_Nota_EntregaTextBox.Text = My.Forms.FrmVerNotasEntregas.txtsiguiente.Text
        Me.Id_ProyectoTextBox.Text = My.Forms.FrmVerNotasEntregas.txtproyecto.Text
        Me.Id_PresupuestoTextBox.Text = My.Forms.FrmVerNotasEntregas.txtpresupuesto.Text
        Me.Id_EmpresaTextBox.Text = My.Forms.FrmVerNotasEntregas.txtempresa.Text
        Me.ConductoresTableAdapter.Fill(DsConductores.Conductores)
        Me.VehiculosTransporteTableAdapter.Fill(Me.DsVehiculosTransporte.VehiculosTransporte)
        Me.EmpresasTransporteTableAdapter.Fill(Me.DsEmpresasTransporte.EmpresasTransporte)
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Id_PresupuestoTextBox.Text)
        Me.EstadoentregasTableAdapter.FillByIdPresupuesto(Me.DsEstadoEntregas.Estadoentregas, Id_PresupuestoTextBox.Text)
        Me.ArticulosDetalleTableAdapter.Fill(Me.DsArticulosdetalle.ArticulosDetalle)
        Me.EstadoEntregasherrajesTableAdapter.FillByIdpresupuesto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Me.Id_PresupuestoTextBox.Text)
    End Sub
    Sub Vernotaentrega()
        Dim NotaEntrega As String = My.Forms.FrmVerNotasEntregas.DsNotasEntrega.NotasEntrega(My.Forms.FrmVerNotasEntregas.NotasEntregaBindingSource.Position).Id_Nota_Entrega
        Me.ConductoresTableAdapter.Fill(Me.DsConductores.Conductores)
        Me.NotasEntregaTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntrega.NotasEntrega, NotaEntrega)
        Me.UnionSubarticulosHerrajesTableAdapter.Fill(Me.DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes)
        Me.EmpresasTransporteTableAdapter.Fill(Me.DsEmpresasTransporte.EmpresasTransporte)
        Me.SubArticulosTableAdapter.Fill(Me.DsSubArticulos.SubArticulos)
        Me.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, NotaEntrega)
        Me.EstadoentregasTableAdapter.FillByIdProyecto(Me.DsEstadoEntregas.Estadoentregas, Id_ProyectoTextBox.Text)
        Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Me.PresupuestoDetalleTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDetalle.PresupuestoDetalle, Me.Id_PresupuestoTextBox.Text)

        Me.ArticulosAprobadosTableAdapter.FillByIdProyecto(Me.DsArticulosAprobados.ArticulosAprobados, Id_ProyectoTextBox.Text)
        Dim Articulo As String = Me.DsArticulosAprobados.ArticulosAprobados(Me.ArticulosAprobadosBindingSource.Position).Articulo
        Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, Articulo)
        Me.EstadoEntregasherrajesTableAdapter.FillByIdpresupuesto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Me.Id_PresupuestoTextBox.Text)
    End Sub



    Sub Siguientedetalle()

        Dim filaIndex As Integer = Me.EstadoentregasDataGridView1.CurrentRow.Index


        Me.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, Id_Nota_EntregaTextBox.Text)
        Me.EstadoentregasTableAdapter.FillByIdProyecto(Me.DsEstadoEntregas.Estadoentregas, Id_ProyectoTextBox.Text)
        Me.EstadoentregasDataGridView1.CurrentCell = EstadoentregasDataGridView1.Rows(filaIndex).Cells(0)
        Me.NotasEntregaDetalleBindingSource.MoveLast()
        Me.NotasEntregaDetalleDataGridView.CurrentCell = NotasEntregaDetalleDataGridView.Rows(NotasEntregaDetalleDataGridView.RowCount - 1).Cells(3)
    End Sub
    Sub Filtradetalle()
        Try
            Me.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, Id_Nota_EntregaTextBox.Text)
            Me.PresupuestoDetalleTableAdapter.FillByArticulosAprobados(Me.DsPresupuestoDetalle.PresupuestoDetalle, Id_ProyectoTextBox.Text)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub NotasEntregaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles NotasEntregaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.NotasEntregaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub FrmNotasEntrega_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsLineasEntraga.LieneasEntrega' Puede moverla o quitarla según sea necesario.
        Me.LieneasEntregaTableAdapter.Fill(Me.DsLineasEntraga.LieneasEntrega)

        Me.HerrajesTableAdapter.Fill(Me.DsHerrajes.Herrajes)
        Me.UnionSubarticulosHerrajesTableAdapter.Fill(Me.DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes)

        Me.Id_EmpresaTransporteTextBox.Visible = False
        Me.CedulaTextBox.Visible = False
        Me.PlacaTextBox.Visible = False

        Me.CmbConductor.Enabled = True
        Me.CmbHehiculo.Enabled = True

    End Sub

    Private Sub CmdNuecoDetalle_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadirSubArticulo.Click

        Try
            Me.Validate()
            Me.NotasEntregaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)


            Dim Siguientedetalle As String = Me.NotasEntregaDetalleTableAdapter.SiguienteDetalleNotaEntrega(Me.Id_Nota_EntregaTextBox.Text)
            Dim idNotaentrega As String = Me.Id_Nota_EntregaTextBox.Text
            Dim codigo As String = Me.DsEstadoEntregas.Estadoentregas(Me.EstadoentregasBindingSource.Position).Codigo
            Dim CantidadPendiente As Double = Me.DsEstadoEntregas.Estadoentregas(Me.EstadoentregasBindingSource.Position).Pendiente
            Dim IdSubArticulo As String = Me.DsEstadoEntregas.Estadoentregas(Me.EstadoentregasBindingSource.Position).ID_Sub_Articulo
            Dim Cantidad As Double = CantidadPendiente
            Dim Precio As Double = 0
            Dim total As Double = Cantidad * Precio
            Dim filaIndex As Integer = Me.EstadoentregasDataGridView1.CurrentRow.Index
            Dim presupuesto As String = Me.Id_PresupuestoTextBox.Text
            Me.NotasEntregaDetalleTableAdapter.AgregarDetalle(Siguientedetalle, idNotaentrega, IdSubArticulo, Cantidad, Precio, total, codigo, presupuesto)
            Me.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, Id_Nota_EntregaTextBox.Text)
            Me.EstadoentregasTableAdapter.FillByIdProyecto(Me.DsEstadoEntregas.Estadoentregas, Id_ProyectoTextBox.Text)
            Me.EstadoentregasDataGridView1.CurrentCell = EstadoentregasDataGridView1.Rows(filaIndex).Cells(0)
            Me.NotasEntregaDetalleBindingSource.MoveLast()
            Me.NotasEntregaDetalleDataGridView.CurrentCell = NotasEntregaDetalleDataGridView.Rows(NotasEntregaDetalleDataGridView.RowCount - 1).Cells(3)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Id_ProyectoTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Id_ProyectoTextBox.TextChanged
        'Me.EstadoentregasTableAdapter.FillByIdProyecto(Me.DsEstadoEntregas.Estadoentregas, My.Forms.FrmProyectos.TxtIdProyecto.Text)
        'Me.EstadoEntregasherrajesTableAdapter.FillByIdProyecto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Id_ProyectoTextBox.Text)
        'Me.ArticulosDetalleTableAdapter.ArticulosPorProyecto(Id_ProyectoTextBox.Text)

    End Sub

    Private Sub NotasEntregaDetalleDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NotasEntregaDetalleDataGridView.CellEndEdit
        Me.Validate()
        Me.NotasEntregaDetalleBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsNotasEntregaDetalle)
        Me.EstadoEntregasherrajesTableAdapter.FillByIdpresupuesto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Id_PresupuestoTextBox.Text)
        Me.EstadoentregasTableAdapter.FillByIdPresupuesto(Me.DsEstadoEntregas.Estadoentregas, Id_PresupuestoTextBox.Text)
    End Sub

    Private Sub NotasEntregaDetalleDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles NotasEntregaDetalleDataGridView.RowsRemoved
        Me.Validate()
        Me.NotasEntregaDetalleBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsNotasEntregaDetalle)
        Me.EstadoEntregasherrajesTableAdapter.FillByIdpresupuesto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Id_PresupuestoTextBox.Text)
        Me.EstadoentregasTableAdapter.FillByIdPresupuesto(Me.DsEstadoEntregas.Estadoentregas, Id_PresupuestoTextBox.Text)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        My.Forms.ImprimirNotaEntrega.Close()
        My.Forms.ImprimirNotaEntrega.Show()
        My.Forms.ImprimirNotaEntrega.ImrimirNotaEntrega()
    End Sub

    Private Sub ArticulosDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArticulosDetalleDataGridView.CellClick
        Me.ArticulosDetalleTableAdapter.ArticulosPorProyecto(Id_ProyectoTextBox.Text)
        Dim IdSubArticulo As String = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
        Me.EstadoentregasTableAdapter.FillByPresupuestoArticulo(Me.DsEstadoEntregas.Estadoentregas, IdSubArticulo, Id_PresupuestoTextBox.Text)
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try


            Me.Validate()
            Me.NotasEntregaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
            My.Forms.FrmKtCompleto.Close()
            My.Forms.FrmKtCompleto.Show()
            My.Forms.FrmKtCompleto.Filtro()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

        If Me.CmbTransportista.Text = "" Then
            MsgBox("El campo empresa de transporte no puede estar vacío")
            Me.CmbTransportista.Focus()
        ElseIf CmbHehiculo.Text = "" Then
            MsgBox("El campo vehículo no puede estar vacío")
            Me.CmbHehiculo.Focus()
        ElseIf CmbConductor.Text = "" Then
            MsgBox("El campo vehículo no puede estar vacío")
            Me.CmbConductor.Focus()
        Else
            Me.Validate()
            Me.NotasEntregaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)


            My.Forms.ImprimirNotaEntrega.Close()
            My.Forms.ImprimirNotaEntrega.Show()
            My.Forms.ImprimirNotaEntrega.ImrimirNotaEntrega()

        End If


    End Sub





    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbTransportista.SelectedIndexChanged
        Try


            Me.Validate()
            Me.NotasEntregaDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
            If CmbTransportista.Text <> "" Then
                Me.VehiculosTransporteTableAdapter.FillByIdEmpresaTransporte(Me.DsVehiculosTransporte.VehiculosTransporte, Me.CmbTransportista.SelectedValue)
                Me.CmbHehiculo.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbHehiculo.SelectedIndexChanged

        Try

            Me.Validate()
            Me.NotasEntregaDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
            If CmbHehiculo.Text <> "" Then
                Me.ConductoresTableAdapter.FillByEmpresa(Me.DsConductores.Conductores, Me.CmbTransportista.SelectedValue)
                Me.CmbConductor.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbConductor.SelectedIndexChanged
        Me.CedulaTextBox.Text = Me.CmbConductor.SelectedValue
        Me.Validate()
        Me.NotasEntregaDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
    End Sub




    Private Sub PresupuestoDetalleDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellClick
        Try
            Dim Articulo As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
            Me.ArticulosDetalleTableAdapter.FillByIdArticulo(Me.DsArticulosdetalle.ArticulosDetalle, Articulo)
            Me.ArticulosDetalleTableAdapter.ArticulosPorProyecto(Id_ProyectoTextBox.Text)
            Dim IdSubArticulo As String = Me.DsArticulosdetalle.ArticulosDetalle(Me.ArticulosDetalleBindingSource.Position).ID_Sub_Articulo
            Me.EstadoentregasTableAdapter.FillByPresupuestoArticulo(Me.DsEstadoEntregas.Estadoentregas, IdSubArticulo, Id_PresupuestoTextBox.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnAñadirHerraje.Click

        Try
            Me.Validate()
            Me.NotasEntregaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
            Me.UnionSubarticulosHerrajesTableAdapter.Fill(Me.DsUnionSubarticulosHerrajes.UnionSubarticulosHerrajes)
            Dim Siguientedetalle As String = Me.NotasEntregaDetalleTableAdapter.SiguienteDetalleNotaEntrega(Me.Id_Nota_EntregaTextBox.Text)
            Dim idNotaentrega As String = Me.Id_Nota_EntregaTextBox.Text
            Dim codigo As String = Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes(Me.EstadoEntregasherrajesBindingSource.Position).Codigo2
            Dim CantidadPendiente As Double = Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes(Me.EstadoEntregasherrajesBindingSource.Position).Pendientes
            Dim Idherraje As String = Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes(Me.EstadoEntregasherrajesBindingSource.Position).Id_Herraje
            Dim Cantidad As Double = CantidadPendiente
            Dim Precio As Double = 0
            Dim total As Double = Cantidad * Precio
            Dim filaIndex As Integer = Me.EstadoEntregasherrajesDataGridView.CurrentRow.Index
            Dim presupuesto As String = Me.Id_PresupuestoTextBox.Text
            Me.NotasEntregaDetalleTableAdapter.AgregarDetalle(Siguientedetalle, idNotaentrega, Idherraje, Cantidad, Precio, total, codigo, presupuesto)
            Me.NotasEntregaDetalleTableAdapter.FillByIdNotaEntrega(Me.DsNotasEntregaDetalle.NotasEntregaDetalle, Id_Nota_EntregaTextBox.Text)
            Me.EstadoEntregasherrajesTableAdapter.FillByIdpresupuesto(Me.DsEstadoEntregasHerrajes.EstadoEntregasherrajes, Id_PresupuestoTextBox.Text)
            Me.EstadoEntregasherrajesDataGridView.CurrentCell = EstadoEntregasherrajesDataGridView.Rows(filaIndex).Cells(0)
            Me.NotasEntregaDetalleBindingSource.MoveLast()
            Me.NotasEntregaDetalleDataGridView.CurrentCell = NotasEntregaDetalleDataGridView.Rows(NotasEntregaDetalleDataGridView.RowCount - 1).Cells(3)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnAnadirLinea_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnadirLinea.Click
        My.Forms.FrmNuevaLinea.Close()
        Dim Siguiente As String = My.Forms.FrmNuevaLinea.LieneasEntregaTableAdapter.LineNueva()
        My.Forms.FrmNuevaLinea.TextBox1.Text = My.Forms.FrmNuevaLinea.LieneasEntregaTableAdapter.LineNueva
        My.Forms.FrmNuevaLinea.Show()


    End Sub
    Private Sub FrmNotasEntrega_closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim articulo As String = Me.DsPresupuestoDetalle.PresupuestoDetalle(Me.PresupuestoDetalleBindingSource.Position).Articulo
            Me.ArticulosTableAdapter.FillByArticulo(Me.DsArticulos.Articulos, articulo)
            Dim Descripcion As String = Me.DsArticulos.Articulos(Me.ArticulosBindingSource.Position).Descripcion_articulo

            My.Forms.FrmNuevaLinea.Close()
            Dim Siguiente As String = My.Forms.FrmNuevaLinea.LieneasEntregaTableAdapter.LineNueva()
            My.Forms.FrmNuevaLinea.TextBox1.Text = My.Forms.FrmNuevaLinea.LieneasEntregaTableAdapter.LineNueva
            My.Forms.FrmNuevaLinea.TextBox2.Text = Descripcion
            My.Forms.FrmNuevaLinea.Show()
            Me.ArticulosTableAdapter.Fill(Me.DsArticulos.Articulos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Me.Validate()
        'Me.NotasEntregaBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DsNotasEntrega)
    End Sub
End Class