
Option Explicit On
Option Strict On
Imports System.Globalization
Imports System.Threading

Public Class FrmGestion




    Public Sub Usuarios()
        Dim CategotiaUsuario As String = Me.Label1.Text
        Select Case CategotiaUsuario
            Case "2"
                FacturasToolStripMenuItem.Visible = False
                EmpresasToolStripMenuItem.Visible = False
                mantenimientousuariosToolStripMenuItem1.Visible = False
            Case "3"
                ArticulosToolStripMenuItem.Visible = False
                FacturasToolStripMenuItem.Visible = False
                EmpresasToolStripMenuItem.Visible = False
                mantenimientousuariosToolStripMenuItem1.Visible = False
                GrupoSubArticuloToolStripMenuItem.Visible = False
                PresupuestosToolStripMenuItem.Visible = False
                NuevoPresupuestoToolStripMenuItem.Visible = False
                GargarProyectosToolStripMenuItem.Visible = False

            Case "4"
                ArticulosToolStripMenuItem.Visible = False
                GargarProyectosToolStripMenuItem.Visible = False
                GrupoSubArticuloToolStripMenuItem.Visible = False
                Trasportes.Visible = False
                mantenimientousuariosToolStripMenuItem1.Visible = False
                NuevoPresupuestoToolStripMenuItem.Visible = False
                GargarProyectosToolStripMenuItem.Visible = False
        End Select
    End Sub

    Private Sub VerEmpresasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerEmpresasToolStripMenuItem.Click
        My.Forms.FrmVerEmpresas.Close()
        My.Forms.FrmVerEmpresas.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        My.Forms.FrmEmpresa.Close()
        My.Forms.FrmEmpresa.Show()
    End Sub

    Private Sub NuevaEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaEmpresaToolStripMenuItem.Click
        My.Forms.FrmEmpresa.Close()
        My.Forms.FrmEmpresa.Show()
        My.Forms.FrmEmpresa.EmpresasBindingSource.AddNew()
        My.Forms.FrmEmpresa.EmpresasBindingNavigator.Visible = False
        My.Forms.FrmEmpresa.CmdCargarNuevoProyecto.Visible = False
        My.Forms.FrmEmpresa.CmdCancelar.Text = "Cerrar"
    End Sub



    Private Sub ProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProyectoToolStripMenuItem.Click
        My.Forms.FrmProyectos.Close()
        My.Forms.FrmProyectos.ProyectosTableAdapter.Fill(My.Forms.FrmProyectos.DsProyectos.Proyectos)
        My.Forms.FrmProyectos.Show()

    End Sub





    Private Sub VerPresupuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerPresupuestosToolStripMenuItem.Click
        'My.Forms.FrmPresupuestos.Close()
        'My.Forms.FrmPresupuestos.Label2.Text = Label1.Text
        'My.Forms.FrmPresupuestos.todosLosPresupuestos()
        'My.Forms.FrmPresupuestos.Show()
        My.Forms.FrmEstadoPresupuestos.Close()
        My.Forms.FrmEstadoPresupuestos.Show()




    End Sub

    Private Sub NuevoPresupuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoPresupuestoToolStripMenuItem.Click
        My.Forms.FrmIntroducirEmpresa.Close()
        My.Forms.FrmIntroducirEmpresa.Show()
    End Sub









    Private Sub VerHerrajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    Private Sub NuevoSubArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CompoenetesvPinturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.FrmPinturaComponentes.Show()
    End Sub

    Private Sub ArticulosListadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArticulosListadoToolStripMenuItem.Click
        My.Forms.FrmVerArticulos.Close()
        My.Forms.FrmVerArticulos.Show()
        My.Forms.FrmVerArticulos.ArticulosTableAdapter.Fill(My.Forms.FrmVerArticulos.DsArticulos.Articulos)
    End Sub


    Private Sub SubArticulosListadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticulosListadoToolStripMenuItem.Click
        My.Forms.FrmVerSubarticulos.Close()
        My.Forms.FrmVerSubarticulos.Show()
    End Sub

    Private Sub SubArticuloNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticuloNuevoToolStripMenuItem.Click
        My.Forms.FormGrupoSubArticulos.Close()
        My.Forms.FormGrupoSubArticulos.Show()




    End Sub


    Private Sub ReporteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteToolStripMenuItem.Click

    End Sub

    Private Sub ArticuloNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArticuloNuevoToolStripMenuItem.Click
        My.Forms.FrmArticulo.Close()
        My.Forms.FrmArticulo.Show()

        My.Forms.FrmArticulo.NuevoArticulo()


    End Sub



    Private Sub SubArticulosDetalleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubArticulosDetalleToolStripMenuItem.Click
        Try


            My.Forms.FrmSubArticulo.Close()
            'My.Forms.FrmSubArticulo.lblInicio.Text = subArticulo
            My.Forms.FrmSubArticulo.Inicio()
        Catch ex As Exception
            MsgBox("No hay SubArticulos" & vbCrLf & "Primero debes intoducir un SubArticulo")
        End Try
    End Sub

    Private Sub VerProyectosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerProyectosToolStripMenuItem.Click
        My.Forms.FrmVerProyectos.Close()
        My.Forms.FrmVerProyectos.Show()
    End Sub



    Private Sub IngresoHerrajesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub GargarProyectosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GargarProyectosToolStripMenuItem.Click

    End Sub

    Private Sub VerPinturaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        My.Forms.FrmPinturaAplicacoon.Close()
        My.Forms.FrmPinturaAplicacoon.Show()

    End Sub

    Private Sub GrupoSubArticuloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GrupoSubArticuloToolStripMenuItem.Click
        My.Forms.FrmGrupoSubArticulos.Close()
        My.Forms.FrmGrupoSubArticulos.Show()



    End Sub


    Private Sub FacturasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        My.Forms.FrmVerFacturas.Close()
        My.Forms.FrmVerFacturas.Show()

    End Sub
    Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
        My.Forms.FrmInicioSesion.Close()
    End Sub
    Private Sub FrmGestion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-es")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-es")
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
        Usuarios()
        If UsuarioActual.ToUpper() <> "ANTONIO" Then
            AdministrativasToolStripMenuItem.Visible = False
            ProgramasToolStripMenuItem.Visible = False
        End If
    End Sub



    Private Sub EmpresaTransporteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresaTransporteToolStripMenuItem.Click
        My.Forms.FrmEmpresasTransporte.Close()
        My.Forms.FrmEmpresasTransporte.Show()

    End Sub

    Private Sub ConductoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConductoresToolStripMenuItem.Click
        My.Forms.FrmConductores.Close()
        My.Forms.FrmConductores.Show()
    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VehiculosToolStripMenuItem.Click
        My.Forms.FrmVehiculos.Close()
        My.Forms.FrmVehiculos.Show()

    End Sub



    Private Sub MantenimientousuariosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles mantenimientousuariosToolStripMenuItem1.Click
        My.Forms.FrmUsuarios.Close()
        My.Forms.FrmUsuarios.Show()

    End Sub

    Private Sub PmstUsuarios_Click(sender As System.Object, e As System.EventArgs) Handles mstUsuarios.Click
        My.Forms.FrmUsuarios.Close()
        My.Forms.FrmUsuarios.Show()
        My.Forms.FrmUsuarios.CambioContrasena()


    End Sub
    Private Sub Formpresupuestos_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        Dim usuario As String = My.Forms.FrmInicioSesion.DsUsuarios.Usuarios(My.Forms.FrmInicioSesion.UsuariosBindingSource.Position).Id_Usuario

        Dim desconexion As Date = DateAndTime.Now()

        Me.UsuariosTableAdapter.desconexion(desconexion, usuario)
        My.Forms.FrmInicioSesion.Close()
        cerrardatset(Me)
        cerrarGrill(Me)
    End Sub



    Private Sub ProveedoresListadoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ProveedoresListadoToolStripMenuItem1.Click
        My.Forms.FrmProveedoresListado.Close()
        My.Forms.FrmProveedoresListado.Listado()
    End Sub

    Private Sub MaderaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaderaToolStripMenuItem.Click
        My.Forms.FrmIngresoMateriales.Close()
        My.Forms.FrmIngresoMateriales.Show()
    End Sub

    Private Sub VerPinturaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles VerPinturaToolStripMenuItem1.Click
        Try
            My.Forms.FrmPinturaAplicacoon.Close()
            My.Forms.FrmPinturaAplicacoon.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComponentesPinturaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComponentesPinturaToolStripMenuItem.Click
        My.Forms.FrmPinturaComponentes.Close()
        My.Forms.FrmPinturaComponentes.Show()
    End Sub

    Private Sub VerHerrajesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles VerHerrajesToolStripMenuItem1.Click
        My.Forms.Frmherrajes.Close()
        My.Forms.Frmherrajes.Show()
    End Sub

    Private Sub IngresoHerrajesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles IngresoHerrajesToolStripMenuItem1.Click
        My.Forms.FrmIngresoHerrajes.Close()
        My.Forms.FrmIngresoHerrajes.nuevvoherraje()
    End Sub

    Private Sub MaquinariasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaquinariasToolStripMenuItem.Click
        My.Forms.FrmMaquinaria.Close()
        My.Forms.FrmMaquinaria.CargarFormulario()

    End Sub

    Private Sub ProveedorNuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProveedorNuevoToolStripMenuItem.Click
        My.Forms.FrmProveedores.Close()
        My.Forms.FrmProveedores.Nuevo()

    End Sub

    Private Sub ContabilidadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContabilidadToolStripMenuItem.Click
        My.Forms.FrmContabilidad.Close()
        My.Forms.FrmContabilidad.Show()
    End Sub

    Private Sub ProveedorMantenimientoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProveedorMantenimientoToolStripMenuItem.Click
        My.Forms.FrmProveedores.Close()

        My.Forms.FrmProveedores.Mantenimiento()

    End Sub

    Private Sub VerListadoPresupuestoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerListadoPresupuestoToolStripMenuItem.Click
        My.Forms.FrmPresupuestosListado.Close()
        My.Forms.FrmPresupuestosListado.Show()


    End Sub


    Private Sub MontajesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MontajesToolStripMenuItem1.Click
        My.Forms.FrmPagosMomtajeResumen.Close()
        My.Forms.FrmPagosMomtajeResumen.Show()
    End Sub

    Private Sub EmpresaMontajesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresaMontajesToolStripMenuItem.Click
        My.Forms.FrmEmpresaMontaje.Close()
        My.Forms.FrmEmpresaMontaje.Cargar()

    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem1.Click
        My.Forms.FrmFacturaMontajeResumen.Close()
        My.Forms.FrmFacturaMontajeResumen.Todos()

    End Sub

    Private Sub ConsultaPreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPreciosToolStripMenuItem.Click
        My.Forms.FrmConsultaPrecios.Close()
        My.Forms.FrmConsultaPrecios.Show()
    End Sub

    Private Sub ActulizarTasaDiariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActulizarTasaDiariaToolStripMenuItem.Click
        My.Forms.FrmAdministrativas.Close()
        My.Forms.FrmAdministrativas.Show()
    End Sub

    Private Sub EstadoPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoPresupuestoToolStripMenuItem.Click
        My.Forms.FrmEstadoTrabajos.Close()
        My.Forms.FrmEstadoTrabajos.Show()

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        My.Forms.FrmComprasProyecto.Close()
        My.Forms.FrmComprasProyecto.ComprasAdministrar()

    End Sub

    Private Sub RecalcularPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecalcularPagosToolStripMenuItem.Click
        My.Forms.Pasignado.Close()
        My.Forms.Pasignado.Show()

    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        My.Forms.FrmProveedoresPago.Close()
        My.Forms.FrmProveedoresPago.Show()
    End Sub

    Private Sub HotelesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Forms.FrmHoteles.Close()
        My.Forms.FrmHoteles.Show()
    End Sub

    Private Sub TotalesComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesComprasToolStripMenuItem.Click
        My.Forms.FrmTotalesCompraProveedor.Close()
        My.Forms.FrmTotalesCompraProveedor.Show()

    End Sub

    Private Sub FrmGestion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each control As Control In Me.Controls
            ' Verifica si el control es un DataGridView
            If TypeOf control Is DataGridView Then
                ' Ajusta automáticamente las columnas al ancho del DataGridView
                DirectCast(control, DataGridView).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Next
    End Sub

    Private Sub GizelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GizelToolStripMenuItem.Click
        Process.Start("\\Portatil-dell\d\Programas Visual\Gizeh\gizeh.application")

    End Sub

    Private Sub SueldoAntonioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SueldoAntonioToolStripMenuItem.Click
        Process.Start("\\Portatil-dell\d\Programas Visual\SueldoAntonio\SueldoAntonio.application")

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        My.Forms.FrmVerClientes.Close()
        My.Forms.FrmVerClientes.Vercliente()

        My.Forms.FrmVerClientes.ClientesBindingNavigator.Visible = False

    End Sub

    Private Sub OptimizadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimizadorToolStripMenuItem.Click
        Process.Start("C:\CuttingWin\CuttingWin.exe")
    End Sub



End Class