Public Class FrmProyectoCliente

    Sub Guardar()
        Try
            Me.Validate()
            Me.ProyectosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DsProyectos)
            Dim idPoryectodetalle As String = Me.Id_ProyectoTextBox.Text & "- IN"
            Me.ProyectosDetalleTableAdapter.AgregarProyecto(idPoryectodetalle, Me.Id_ProyectoTextBox.Text, "IN", Nombre_ProyectoTextBox.Text)
            My.Forms.FrmCliente.ProyectosTableAdapter.FillByIdCliente(My.Forms.FrmCliente.DsProyectos.Proyectos, My.Forms.FrmCliente.Id_FiscalTextBox.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub ProyectosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProyectosBindingNavigatorSaveItem.Click

        Guardar()


    End Sub

    Private Sub FrmProyectoCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProyectosDetalle.ProyectosDetalle' Puede moverla o quitarla según sea necesario.
        Me.ProyectosDetalleTableAdapter.Fill(Me.DsProyectosDetalle.ProyectosDetalle)
        'TODO: esta línea de código carga datos en la tabla 'DsClientes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DsClientes.Clientes)
        Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, Id_FiscalTextBox.Text)
        Me.MdiParent = My.Forms.FrmGestion
        Me.ProyectosTableAdapter.Fill(Me.DsProyectos.Proyectos)
        DatosTextBox.Enabled = False
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnVerDAtos.Click


        If DatosTextBox.Text <> "" Then
            Shell("explorer.exe root =" + DatosTextBox.Text, vbNormalFocus)

        Else
            MsgBox("La carpeta no esta creada")
        End If



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnCrearCarpetea.Click
        Try



            If DatosTextBox.Text = "" Then
                Dim carpeta As String = Me.DsClientes.Clientes(Me.ClientesBindingSource.Position).CarpetaDatos
                Dim nuevacarpeta As String = Me.Nombre_ProyectoTextBox.Text

                System.IO.Directory.CreateDirectory(carpeta + "\" + nuevacarpeta)
                Me.DatosTextBox.Text = carpeta + "\" + nuevacarpeta
                Dim Subcarpeta As String = Me.DsProyectos.Proyectos(Me.ProyectosBindingSource.Position).Datos


                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Documentos Cliente")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Presentaciones")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Presupuestos")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Informes")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Diseños")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Compras")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Compras" + "\" + "Ordenes Compra")
                System.IO.Directory.CreateDirectory(Subcarpeta + "\" + "Compras" + "\" + "Cotizaciones Clientes")
                Me.Validate()
                Me.ProyectosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DsProyectos)

            Else
                MsgBox("la carpeta ya se a creado")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Id_FiscalTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Id_FiscalTextBox.TextChanged
        Me.ClientesTableAdapter.FillByIdFiscal(Me.DsClientes.Clientes, Id_FiscalTextBox.Text)

    End Sub
End Class