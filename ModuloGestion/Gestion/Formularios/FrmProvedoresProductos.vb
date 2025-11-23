Option Explicit On
Option Strict On

Public Class FrmProvedoresProductos

    Private Sub FrmProvedoresProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)


        Me.ProveedoresProductoTableAdapter.Fill(Me.DsProveedoresProducto.ProveedoresProducto)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TxtArticuloProvveedor.Text <> "" Then
            If TxtDescripcionProveedor.Text <> "" Then

                If ComboBox1.Text <> "PONER MEDIDA" Then


                    Try

                        Me.ProveedoresProductoTableAdapter.Insertar(TxtIdUnico.Text, TxtIdProvedore.Text, TxtDescripcionProveedor.Text, TxtArticuloProvveedor.Text, 0, 0, CDec(Me.ComboBox1.SelectedValue))
                        My.Forms.FrmProductos.ProveedoresProductoTableAdapter.FillByIdProveedor(My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto, TxtIdProvedore.Text)
                        My.Forms.FrmProductos.ProveedoresProductoBindingSource.MoveLast()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Me.Button1.Enabled = False
                    End Try
                Else
                    MsgBox("Debe poner una medida")
                End If

            Else
                MsgBox("Debe poner una descripcion")
            End If
        Else
            MsgBox("Debe poner el codigo del proveedor")

        End If


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    


End Class