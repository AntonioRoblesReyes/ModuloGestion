Public Class Form1

    Sub Recalcular()
        Try
            Dim Cuenta As Double = 0
            Dim icuenta As Integer = SubArticulosDetalleDataGridView.Rows.Count 'ITotal toma el valor del numero de registros k tiene latabla
            'Definimos la variable i para controlar el ciclo for
            Dim i As Integer
            'Definimos del ciclo que va desde que i vale cero hasta que i valga itotal menos uno, osea el penultimo regsitro de la tabla
            For i = 0 To icuenta - 1
                Dim IdDetalleSubArticulo As String = Me.DsSubArticulosDetalle.SubArticulosDetalle(Me.SubArticulosDetalleBindingSource.Position).Id_detalle_Sub_Articulo
                Me.PresupuestoDetalleElementosTableAdapter.FillByIddetalleSubArticulo(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos, IdDetalleSubArticulo)
                Me.SubArticulosDetalleBindingSource.MoveNext()

            Next
            MsgBox("listo")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubArticulosDetalleBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SubArticulosDetalleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsSubArticulosDetalle)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.PresupuestoDetalleElementosTableAdapter.Fill(Me.DsPresupuestoDetalleElementos.PresupuestoDetalleElementos)

        Me.SubArticulosDetalleTableAdapter.Fill(Me.DsSubArticulosDetalle.SubArticulosDetalle)
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1

        End If
        recalcular()
    End Sub




End Class