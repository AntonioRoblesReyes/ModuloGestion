Public Class FrmEmpresa
    Sub BuscarLogo()

        Dim subString As String = Microsoft.VisualBasic.Left(LogoTextBox.Text, 32)
        If subString = "\\antonio-dell\Users\Public\Carpeta Datos\Imajenes\Logos\" Then


        Else
            LogoTextBox.Text = "No hay Logo asignado"
            Me.Validate()
            Me.EmpresasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsEmpresas)
        End If
    End Sub
    Sub Cargarimagen()
        Try
            Me.EmpresasTableAdapter.FillByIdEmpresa(Me.DsEmpresas.Empresas, TxtIdEmpresa.Text)
            Dim Imagen As String
            Imagen = DsEmpresas.Empresas(Me.EmpresasBindingSource.Position).Logo

            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try
    End Sub
    Private Sub EmpresasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpresasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsEmpresas)

    End Sub

    Private Sub FrmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.MdiParent = My.Forms.FrmGestion
        'Me.ProyectosDetalleTableAdapter.Fill(Me.DsProyectosDetalle.ProyectosDetalle)
        'Me.ProyectosDetalleTableAdapter.FillByEmpresa(Me.DsProyectosDetalle.ProyectosDetalle, TxtIdEmpresa.Text)
        Me.EmpresasTableAdapter.Fill(Me.DsEmpresas.Empresas)



    End Sub

    Private Sub TxtIdEmpresa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdEmpresa.TextChanged
        Me.ProyectosDetalleTableAdapter.FillByEmpresa(Me.DsProyectosDetalle.ProyectosDetalle, TxtIdEmpresa.Text)
        Try

            Dim Imagen As String
            Imagen = LogoTextBox.Text
            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try
    End Sub




    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click
        If TxtIdEmpresa.Text.LongCount = 0 Then
            MsgBox("Id Empresa" + Chr(13) + "No puede estar Vacio")
        ElseIf TxtIdfiscal.Text.LongCount = 0 Then
            MsgBox("Id Fiscal" + Chr(13) + "No puede estar Vacio")
        ElseIf TxtRazonSocial.Text.LongCount = 0 Then
            MsgBox("Razon Social" + Chr(13) + "No puede estar Vacio")
        Else
            Me.Validate()
            Me.EmpresasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsEmpresas)
        End If
    End Sub

    Private Sub CmdSAlir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Close()
    End Sub

    ReadOnly IdProyecto As String


    Private Sub CmdCargarNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCargarNuevoProyecto.Click
        My.Forms.FrmCargarProyecto.Close()
        My.Forms.FrmCargarProyecto.Show()
        My.Forms.FrmCargarProyecto.LblInformacion.Text = UCase("Cargar nuevo proyecto a la empresa " & TxtRazonSocial.Text)

    End Sub


    Private Sub LogoTextBox_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LogoTextBox.DoubleClick
        Dim archivo As String
        OpenFileDialog1.ShowDialog()
        archivo = OpenFileDialog1.FileName
        Me.LogoTextBox.Text = archivo
        Me.EmpresasTableAdapter.ActulizarLogo(archivo, TxtIdEmpresa.Text)
        cargarimagen()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.FrmProyectos.Close()

        Dim Proyecto As String
        Proyecto = DsProyectosDetalle.ProyectosDetalle(ProyectosDetalleBindingSource.Position).Id_Proyecto
        My.Forms.FrmProyectos.Close()
        My.Forms.FrmProyectos.Show()
        My.Forms.FrmProyectos.ProyectosTableAdapter.FillByProyecto(My.Forms.FrmProyectos.DsProyectos.Proyectos, Proyecto)
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Try

            Dim Imagen As String
            Imagen = LogoTextBox.Text
            Me.PictureBox1.Image = Image.FromFile(Imagen)
        Catch ex As Exception
            Me.PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub BtnFacturas_Click(sender As System.Object, e As System.EventArgs) Handles BtnFacturas.Click
        My.Forms.FrmVerFacturas.Close()
        My.Forms.FrmVerFacturas.Show()
    End Sub




    Private Sub BtnFacturaProveedor_Click(sender As System.Object, e As System.EventArgs) Handles BtnFacturaProveedor.Click
        My.Forms.FrmFacturasProveedor.Close()
        My.Forms.FrmFacturasProveedor.LblRncEmpresa.Text = Me.TxtIdfiscal.Text


    End Sub




    Private Sub CobrosRealizadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        My.Forms.ImpEstadoCuentaCliente.Close()
        My.Forms.ImpEstadoCuentaCliente.Show()
        My.Forms.ImpEstadoCuentaCliente.ImprimirEstadoEmpresa()
    End Sub







    Private Sub TotalContratadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalContratadoToolStripMenuItem.Click
        My.Forms.ImpEstadoCuentaCliente.Close()
        My.Forms.ImpEstadoCuentaCliente.Show()
        My.Forms.ImpEstadoCuentaCliente.ImprimirEstadoEmpresa()
    End Sub

    Private Sub TotalPendienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalPendienteToolStripMenuItem.Click
        My.Forms.ImpEstadoCuentaCliente.Close()
        My.Forms.ImpEstadoCuentaCliente.Show()
        My.Forms.ImpEstadoCuentaCliente.ImprimirEstadoEmpresaPendiente()
    End Sub
End Class