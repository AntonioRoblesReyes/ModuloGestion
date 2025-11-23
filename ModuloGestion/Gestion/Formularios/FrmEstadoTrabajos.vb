Public Class FrmEstadoTrabajos

    Private Sub FrmEstadoTrabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosIniciales()
    End Sub

    ' Método para carga inicial de datos.
    Private Sub CargarDatosIniciales()
        Try
            ArticulosTableAdapter.Fill(DsEstadoTrabajos.Articulos)
            ProyectosTableAdapter.FillByAprobados(DsEstadoTrabajos.Proyectos)

            If ProyectosBindingSource.Count > 0 Then
                Dim proyectoActual As String = ObtenerIdProyectoSeleccionado()
                CargarPresupuestos(proyectoActual)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos iniciales: " & ex.Message)
        End Try
    End Sub

    ' Obtener el IdProyecto de la fila seleccionada actualmente.
    Private Function ObtenerIdProyectoSeleccionado() As String
        Dim drv As DataRowView = TryCast(ProyectosBindingSource.Current, DataRowView)
        Return If(drv IsNot Nothing, drv("Id_Proyecto").ToString(), String.Empty)
    End Function

    ' Obtener el IdPresupuesto de la fila seleccionada actualmente.
    Private Function ObtenerIdPresupuestoSeleccionado() As String
        Dim drv As DataRowView = TryCast(PresupuestoBindingSource.Current, DataRowView)
        Return If(drv IsNot Nothing, drv("Id_Presupuesto").ToString(), String.Empty)
    End Function

    ' Cargar presupuestos y detalles por proyecto.
    Private Sub CargarPresupuestos(ByVal idProyecto As String)
        PresupuestoTableAdapter.FillByIdProyecto(DsEstadoTrabajos.Presupuesto, idProyecto)
        PresupuestoDetalleTableAdapter.FillByIdProyecto(DsEstadoTrabajos.PresupuestoDetalle, idProyecto)
    End Sub

    ' Cargar detalles del presupuesto seleccionado.
    Private Sub CargarDetallesPresupuesto(ByVal idPresupuesto As String)
        PresupuestoDetalleTableAdapter.FillByIdPresupuesto(DsEstadoTrabajos.PresupuestoDetalle, idPresupuesto)
    End Sub

    Private Sub ProyectosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProyectosDataGridView.CellClick
        Dim proyectoActual As String = ObtenerIdProyectoSeleccionado()

        If Not String.IsNullOrEmpty(proyectoActual) Then
            CargarPresupuestos(proyectoActual)
        End If
    End Sub

    Private Sub PresupuestoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDataGridView.CellClick
        Dim presupuestoActual As String = ObtenerIdPresupuestoSeleccionado()

        If Not String.IsNullOrEmpty(presupuestoActual) Then
            CargarDetallesPresupuesto(presupuestoActual)
        End If
    End Sub
    Private Sub PresupuestoDetalleDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestoDetalleDataGridView.CellEndEdit
        Dim filaActual As DataGridViewRow = PresupuestoDetalleDataGridView.CurrentRow

        ' Validar fila
        If filaActual Is Nothing Then Exit Sub

        ' Obtener valores actuales de forma segura
        Dim valorCelda6 As Boolean = ObtenerValorBooleano(filaActual.Cells(6).Value)
        Dim valorCelda5 As Boolean = ObtenerValorBooleano(filaActual.Cells(5).Value)
        Dim valorCelda4 As Boolean = ObtenerValorBooleano(filaActual.Cells(4).Value)

        Select Case e.ColumnIndex
            Case 6
                If valorCelda6 Then
                    filaActual.Cells(5).Value = True
                    filaActual.Cells(4).Value = True
                    filaActual.Cells(3).Value = True
                End If

            Case 5
                If valorCelda5 Then
                    filaActual.Cells(4).Value = True
                    filaActual.Cells(3).Value = True
                Else
                    filaActual.Cells(6).Value = False
                End If

            Case 4
                If valorCelda4 Then
                    filaActual.Cells(3).Value = True
                Else
                    filaActual.Cells(5).Value = False
                    filaActual.Cells(6).Value = False
                End If
        End Select

        GuardarCambios()
    End Sub

    ' Método para obtener valor booleano con seguridad
    Private Function ObtenerValorBooleano(valor As Object) As Boolean
        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return False
        Else
            Return CBool(valor)
        End If
    End Function


    ' Método para validar y guardar cambios en la base de datos.
    Private Sub GuardarCambios()
        Try
            Me.Validate()
            Me.PresupuestoDetalleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(DsEstadoTrabajos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar cambios: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.ImpEstadoTrabajos.Close()
        My.Forms.ImpEstadoTrabajos.Show()
    End Sub

End Class
