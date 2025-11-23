Public Class ImpEstadoCuentaCliente

    ' MÉTODO AUXILIAR para mostrar el reporte Crystal
    Private Sub MostrarReporte(ByVal reporte As ReportClass)
        Try
            reporte.SetDataSource(Me.DsEstadoClientes)
            CrystalReportViewer1.ReportSource = reporte
        Catch ex As Exception
            MessageBox.Show("Error al cargar el reporte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' MÉTODO AUXILIAR para limpiar el dataset antes de cada impresión si es necesario
    Private Sub LimpiarDatos()
        Try
            Me.DsEstadoClientes.Clear()
        Catch ex As Exception
            ' Ignorar error si no es necesario limpiar (opcional)
        End Try
    End Sub

    ' ESTADO DE CUENTA DE EMPRESA - SOLO PENDIENTES
    Sub ImprimirEstadoEmpresaPendiente()
        LimpiarDatos()
        Try
            ' Cargar solo los datos relevantes
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PagosClientesDetalleTableAdapter.Fill(Me.DsEstadoClientes.PagosClientesDetalle)
            Me.PagosClientesTableAdapter.Fill(Me.DsEstadoClientes.PagosClientes)
            Me.ClientesTableAdapter.Fill(Me.DsEstadoClientes.Clientes)
            Me.ProyectosTableAdapter.Fill(Me.DsEstadoClientes.Proyectos)
            Me.PresupuestoTableAdapter.FillByICobrosPendientes(Me.DsEstadoClientes.Presupuesto, "in")

            If Me.DsEstadoClientes.Presupuesto.Rows.Count = 0 Then
                MessageBox.Show("No hay presupuestos pendientes para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim rpt As New CryEstadoEmpresa
            MostrarReporte(rpt)
            rpt.ReportDefinition.Sections("GroupFooterSection1").SectionFormat.EnableSuppress = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' ESTADO DE CUENTA DE EMPRESA COMPLETO
    Sub ImprimirEstadoEmpresa()
        LimpiarDatos()
        Try
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PresupuestoTableAdapter.Fill(Me.DsEstadoClientes.Presupuesto)
            Me.PagosClientesDetalleTableAdapter.Fill(Me.DsEstadoClientes.PagosClientesDetalle)
            Me.PagosClientesTableAdapter.Fill(Me.DsEstadoClientes.PagosClientes)
            Me.EmpresasTableAdapter.Fill(Me.DsEstadoClientes.Empresas)
            Me.ClientesTableAdapter.Fill(Me.DsEstadoClientes.Clientes)
            Me.ProyectosTableAdapter.Fill(Me.DsEstadoClientes.Proyectos)
            Me.PresupuestoTableAdapter.FillByActuales(Me.DsEstadoClientes.Presupuesto, "in")
            Me.EmpresasTableAdapter.FillByIdEmpresa(Me.DsEstadoClientes.Empresas, My.Forms.FrmEmpresa.TxtIdfiscal.Text)

            Dim rpt As New CryEstadoEmpresa
            MostrarReporte(rpt)
            rpt.ReportDefinition.Sections("GroupFooterSection1").SectionFormat.EnableSuppress = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' ESTADO POR PRESUPUESTO (SELECCIONADO)
    Sub ImprimirEstadoPresupuesto()
        Dim idFiscal As String = ""
        Dim idProyecto As String = ""
        Dim idPresupuesto As String = ""

        If My.Forms.FrmCliente IsNot Nothing Then
            If My.Forms.FrmCliente.Id_FiscalTextBox IsNot Nothing Then
                idFiscal = My.Forms.FrmCliente.Id_FiscalTextBox.Text
            End If
            If My.Forms.FrmCliente.ProyectosDataGridView IsNot Nothing AndAlso
                My.Forms.FrmCliente.ProyectosDataGridView.CurrentRow IsNot Nothing Then
                idProyecto = My.Forms.FrmCliente.ProyectosDataGridView.CurrentRow.Cells(0).Value.ToString()
            End If
            If My.Forms.FrmCliente.PresupuestoDataGridView IsNot Nothing AndAlso
                My.Forms.FrmCliente.PresupuestoDataGridView.CurrentRow IsNot Nothing Then
                idPresupuesto = My.Forms.FrmCliente.PresupuestoDataGridView.CurrentRow.Cells(0).Value.ToString()
            End If
        End If

        LimpiarDatos()
        Try
            Me.ClientesTableAdapter.FillByIdCliente(Me.DsEstadoClientes.Clientes, idFiscal)
            Me.EmpresasTableAdapter.Fill(Me.DsEstadoClientes.Empresas)
            Me.ProyectosTableAdapter.FillByIdProyecto(Me.DsEstadoClientes.Proyectos, idProyecto)
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PresupuestoTableAdapter.FillByIdPresupuesto(Me.DsEstadoClientes.Presupuesto, idPresupuesto, "in")
            Me.PagosClientesTableAdapter.FillByIdFiscal(Me.DsEstadoClientes.PagosClientes, idFiscal)
            Me.PagosClientesDetalleTableAdapter.FillByIdPrespuesto(Me.DsEstadoClientes.PagosClientesDetalle, idPresupuesto)

            Dim rpt As New CryProyecto
            MostrarReporte(rpt)
            rpt.ReportDefinition.Sections("GroupFooterSection1").SectionFormat.EnableSuppress = True
            rpt.ReportDefinition.Sections("GroupFooterSection2").SectionFormat.EnableSuppress = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' ESTADO POR PROYECTO
    Sub ImprimirEstadoProyecto()
        LimpiarDatos()
        Try
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PresupuestoTableAdapter.Fill(Me.DsEstadoClientes.Presupuesto)
            Me.PagosClientesDetalleTableAdapter.Fill(Me.DsEstadoClientes.PagosClientesDetalle)
            Me.PagosClientesTableAdapter.Fill(Me.DsEstadoClientes.PagosClientes)
            Me.EmpresasTableAdapter.Fill(Me.DsEstadoClientes.Empresas)
            Me.ClientesTableAdapter.Fill(Me.DsEstadoClientes.Clientes)
            Me.ProyectosTableAdapter.Fill(Me.DsEstadoClientes.Proyectos)
            Me.ClientesTableAdapter.FillByIdCliente(Me.DsEstadoClientes.Clientes, Me.Label3.Text)
            Me.PagosClientesTableAdapter.FillByIdFiscal(Me.DsEstadoClientes.PagosClientes, Me.Label3.Text)
            Me.ProyectosTableAdapter.FillByIdProyecto(Me.DsEstadoClientes.Proyectos, Me.Label2.Text)
            Me.PresupuestoTableAdapter.FillByActuales(Me.DsEstadoClientes.Presupuesto, "in")
            Me.PagosClientesDetalleTableAdapter.FillByIdProyecto(Me.DsEstadoClientes.PagosClientesDetalle, Me.Label2.Text)

            Dim rpt As New CryProyecto
            MostrarReporte(rpt)
            rpt.ReportDefinition.Sections("GroupFooterSection1").SectionFormat.EnableSuppress = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' ESTADO POR CLIENTE
    Sub ImprimirEstadoClientePorCliente()
        LimpiarDatos()
        Try
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PresupuestoTableAdapter.Fill(Me.DsEstadoClientes.Presupuesto)
            Me.PagosClientesDetalleTableAdapter.Fill(Me.DsEstadoClientes.PagosClientesDetalle)
            Me.PagosClientesTableAdapter.Fill(Me.DsEstadoClientes.PagosClientes)
            Me.EmpresasTableAdapter.Fill(Me.DsEstadoClientes.Empresas)
            Me.ClientesTableAdapter.Fill(Me.DsEstadoClientes.Clientes)
            Me.PresupuestoTableAdapter.FillByIdCliente(Me.DsEstadoClientes.Presupuesto, Label1.Text, "in")

            Dim rpt As New CrypresupuestoPago
            MostrarReporte(rpt)
            'rpt.ReportDefinition.Sections("GroupFooterSection5").SectionFormat.EnableSuppress = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' ESTADO COMPLETO
    Sub ImprimirEstadoCompleto()
        LimpiarDatos()
        Try
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PresupuestoTableAdapter.Fill(Me.DsEstadoClientes.Presupuesto)
            Me.PagosClientesDetalleTableAdapter.Fill(Me.DsEstadoClientes.PagosClientesDetalle)
            Me.PagosClientesTableAdapter.Fill(Me.DsEstadoClientes.PagosClientes)
            Me.EmpresasTableAdapter.Fill(Me.DsEstadoClientes.Empresas)
            Me.ClientesTableAdapter.Fill(Me.DsEstadoClientes.Clientes)
            Me.ProyectosTableAdapter.Fill(Me.DsEstadoClientes.Proyectos)
            Me.ClientesTableAdapter.FillByIdCliente(Me.DsEstadoClientes.Clientes, My.Forms.FrmEstadoCliente.Id_FiscalTextBox.Text)
            Me.PagosClientesTableAdapter.FillByIdFiscal(Me.DsEstadoClientes.PagosClientes, My.Forms.FrmEstadoCliente.Id_FiscalTextBox.Text)
            Me.PresupuestoTableAdapter.FillByActuales(Me.DsEstadoClientes.Presupuesto, "in")

            Dim rpt As New CryProyecto
            MostrarReporte(rpt)
            rpt.ReportDefinition.Sections("GroupFooterSection5").SectionFormat.EnableSuppress = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' ESTADO POR PAGO
    Sub ImprimirEstadoClientePorPago()
        LimpiarDatos()
        Try
            Me.ProyectosDetalleTableAdapter.Fill(Me.DsEstadoClientes.ProyectosDetalle)
            Me.PresupuestoTableAdapter.Fill(Me.DsEstadoClientes.Presupuesto)
            Me.PagosClientesDetalleTableAdapter.Fill(Me.DsEstadoClientes.PagosClientesDetalle)
            Me.PagosClientesTableAdapter.Fill(Me.DsEstadoClientes.PagosClientes)
            Me.EmpresasTableAdapter.Fill(Me.DsEstadoClientes.Empresas)
            Me.ClientesTableAdapter.Fill(Me.DsEstadoClientes.Clientes)
            Me.ClientesTableAdapter.FillByIdCliente(Me.DsEstadoClientes.Clientes, My.Forms.FrmEstadoCliente.Id_FiscalTextBox.Text)

            Dim rpt As New CryCobrosDetalle
            MostrarReporte(rpt)

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    ' EVENTOS Y GUARDADO
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.ClientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsEstadoClientes)
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub ImpEstadoCuentaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puedes cargar datos generales aquí si lo ves necesario
    End Sub

End Class
