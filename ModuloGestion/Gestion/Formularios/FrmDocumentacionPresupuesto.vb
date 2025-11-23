Imports System.IO

Public Class FrmDocumentacionPresupuesto
    Sub Presupuesto()

        Me.PresupuestoDocumentosTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDocumentos.PresupuestoDocumentos, My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto)
        Me.LblCarpeta.Text = My.Forms.FrmPresupuestos.Carpeta_DatosTextBox.Text
        Me.Show()
    End Sub
    Private Sub PresupuestoDocumentosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestoDocumentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PresupuestoDocumentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDocumentos)

    End Sub

    Private Sub FrmDocumentacionPresupuesto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPresupuestoDocumentos.PresupuestoDocumentos' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click
        Dim presupuesto As String = My.Forms.FrmPresupuestos.TxtIdPresupuesto.Text

        Me.OpenFileDialog1.InitialDirectory = Me.LblCarpeta.Text
        Me.OpenFileDialog1.ShowDialog()

        Dim archivo As String = Path.GetFileName(Me.OpenFileDialog1.FileName)
        Dim Presupuestdetalle = My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto
        Dim ruta As String = Me.OpenFileDialog1.FileName
        Me.LblRuta.Text = Me.OpenFileDialog1.FileName
        Dim codigo As String = presupuesto & "-" & archivo
        Try
            Me.PresupuestoDocumentosTableAdapter.InsertarDocumento(codigo, presupuesto, ruta, archivo, Presupuestdetalle)
            Me.PresupuestoDocumentosTableAdapter.FillByIdPresupuesto(Me.DsPresupuestoDocumentos.PresupuestoDocumentos, My.Forms.FrmPresupuestos.DsPresupuestoDetalle.PresupuestoDetalle(My.Forms.FrmPresupuestos.PresupuestoDetalleBindingSource.Position).IdDetalle_Presupuesto)
        Catch ex As Exception
            MsgBox("Ya esta agregado")
        End Try


    End Sub

    Private Sub PresupuestoDocumentosDataGridView_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles PresupuestoDocumentosDataGridView.RowsRemoved
        Me.Validate()
        Me.PresupuestoDocumentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDocumentos)

    End Sub

    Private Sub PresupuestoDocumentosDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PresupuestoDocumentosDataGridView.CellEndEdit
        Me.Validate()
        Me.PresupuestoDocumentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPresupuestoDocumentos)

    End Sub

    Private Sub BtnVer_Click(sender As System.Object, e As System.EventArgs) Handles BtnVer.Click

        Dim archivo As String = Me.DsPresupuestoDocumentos.PresupuestoDocumentos(Me.PresupuestoDocumentosBindingSource.Position).Ruta

        System.Diagnostics.Process.Start(archivo)
    End Sub
End Class