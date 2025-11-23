Public Class Frmherrajes

    Private Sub Frmherrajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MedidasCompraTableAdapter.Fill(DsMedidasCompra.MedidasCompra)
            HerrajesFamiliaTableAdapter.Fill(DsHerrajesFamilia.HerrajesFamilia)
            HerrajesTableAdapter.Fill(DsHerrajes.Herrajes)
            TxtTipoHerraje.Text = "Filtrar Por Tipo"
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtTipoHerraje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTipoHerraje.SelectedIndexChanged
        Try
            HerrajesTableAdapter.FillByTipoHerraje(DsHerrajes.Herrajes, TxtTipoHerraje.SelectedValue)
        Catch ex As Exception
            MessageBox.Show("Error al filtrar por tipo de herraje: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtTipoHerraje_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTipoHerraje.MouseEnter
        TxtTipoHerraje.Text = ""
    End Sub

    Private Sub TxtTipoHerraje_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTipoHerraje.MouseLeave
        If TxtTipoHerraje.Text = "" Then TxtTipoHerraje.Text = "Filtrar Por Tipo"
    End Sub

    Private Sub HerrajesDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HerrajesDataGridView.CellEndEdit
        Try
            Validate()
            HerrajesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsHerrajes)
        Catch ex As Exception
            MessageBox.Show("Error al guardar cambios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HerrajesDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles HerrajesDataGridView.RowsRemoved
        Try
            Validate()
            HerrajesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsHerrajes)
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar el herraje, está asignado a algún presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAñadirHerraje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAñadirHerraje.Click
        Try
            Dim detallePresupuesto = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
            Dim Siguiente As String = My.Forms.FrmIngresoHerrajePintura.PresupuestoDetalleHerrajesTableAdapter.SiguientedetalleHerraje(detallePresupuesto)

            If String.IsNullOrEmpty(Siguiente) Then
                Siguiente = detallePresupuesto & "-001"
            End If

            Dim IdHerraje = DsHerrajes.Herrajes(HerrajesBindingSource.Position).IdHerraje
            Dim Cantidadpresupuesto = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).Cantidad
            Dim totalPresupuesto = Cantidadpresupuesto
            Dim Proyecto = My.Forms.FrmPresupuestos.TxtIdProyecto.Text
            Dim presupuesto = My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text
            Dim Medida = DsHerrajes.Herrajes(HerrajesBindingSource.Position).Medidad_Elementos_Herrajes
            Dim estado = My.Forms.FrmPresupuestos.TxtEstado.Text
            Dim Empresa = My.Forms.FrmPresupuestos.TxtIdEmpresa.Text
            Dim codigo = $"{presupuesto}-{IdHerraje}"

            My.Forms.FrmPresupuestos.PreciosCompraProyectoTableAdapter.FillByIdCodigo(My.Forms.FrmPresupuestos.DsPreciosCompraProyecto.PreciosCompraProyecto, codigo)
            Dim VerificarPrecio = My.Forms.FrmPresupuestos.DsPreciosCompraProyecto.Tables("PreciosCompraProyecto").Rows.Count
            Dim precio = If(VerificarPrecio > 0, My.Forms.FrmPresupuestos.DsPreciosCompraProyecto.PreciosCompraProyecto(My.Forms.FrmPresupuestos.PreciosCompraProyectoBindingSource.Position).Precio_Compra, 0)
            Dim costoDetallePresupuesto = precio * Cantidadpresupuesto

            My.Forms.FrmIngresoHerrajePintura.PresupuestoDetalleHerrajesTableAdapter.AnexarHerraje(Siguiente, Proyecto, presupuesto, detallePresupuesto, Cantidadpresupuesto, IdHerraje, 1, totalPresupuesto, Medida, Empresa, estado, precio, costoDetallePresupuesto, 0, codigo)
            Close()
        Catch ex As Exception
            MessageBox.Show("Se produjo una excepción: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HerrajesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HerrajesDataGridView.CellClick
        Try
            Dim Imagen = DsHerrajes.Herrajes(HerrajesBindingSource.Position).Imajen
            PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            HerrajesTableAdapter.FillByDescripcion(DsHerrajes.Herrajes, "%" & TextBox1.Text & "%")
        Catch ex As Exception
            MessageBox.Show("Error al filtrar por descripción: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim Herraje = DsHerrajes.Herrajes(HerrajesBindingSource.Position).IdHerraje
            My.Forms.FrmIngresoHerrajes.Close()
            My.Forms.FrmIngresoHerrajes.Label1.Text = Herraje
            My.Forms.FrmIngresoHerrajes.Editarherraje()
        Catch ex As Exception
            MessageBox.Show("Error al editar herraje: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmHerrajes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            My.Forms.FrmIngresoHerrajePintura.Filtrar()
        Catch ex As Exception
            MessageBox.Show("Se produjo una excepción al actualizar el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
