Option Explicit On
Option Strict On

Public Class FrmProvedoresProductos

    Private Sub FrmProvedoresProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MedidasCompraTableAdapter.Fill(Me.DsMedidasCompra.MedidasCompra)


        Me.ProveedoresProductoTableAdapter.Fill(Me.DsProveedoresProducto.ProveedoresProducto)


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        '' Validar código del proveedor
        'If String.IsNullOrWhiteSpace(TxtArticuloProvveedor.Text) Then
        '    MessageBox.Show(
        '    "Debe introducir el código del artículo del proveedor.",
        '    "Dato requerido",
        '    MessageBoxButtons.OK,
        '    MessageBoxIcon.Warning)

        '    TxtArticuloProvveedor.Focus()
        '    Exit Sub
        'End If

        ' Validar descripción
        If String.IsNullOrWhiteSpace(TxtDescripcionProveedor.Text) Then
            MessageBox.Show(
            "Debe introducir una descripción.",
            "Dato requerido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            TxtDescripcionProveedor.Focus()
            Exit Sub
        End If

        ' Validar medida
        If ComboBox1.SelectedValue Is Nothing OrElse
       ComboBox1.Text.Trim().ToUpper() = "PONER MEDIDA" Then

            MessageBox.Show(
            "Debe seleccionar una medida válida.",
            "Dato requerido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            ComboBox1.Focus()
            Exit Sub
        End If

        Try
            Button1.Enabled = False

            Dim idUnico As String = TxtIdUnico.Text.Trim()
            Dim idProveedor As String = TxtIdProvedore.Text.Trim()
            Dim descripcion As String = TxtDescripcionProveedor.Text.Trim()
            Dim codigoProveedor As String = TxtArticuloProvveedor.Text.Trim()
            Dim idMedida As Decimal = Convert.ToDecimal(ComboBox1.SelectedValue)

            Me.ProveedoresProductoTableAdapter.Insertar(
            idUnico,
            idProveedor,
            descripcion,
            codigoProveedor,
            0D,
            0D,
            idMedida)

            My.Forms.FrmProductos.ProveedoresProductoTableAdapter.FillByIdProveedor(
            My.Forms.FrmProductos.DsProveedoresProducto.ProveedoresProducto,
            idProveedor)

            My.Forms.FrmProductos.ProveedoresProductoBindingSource.MoveLast()

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(
            "Ocurrió un error al guardar el producto:" & vbCrLf & vbCrLf & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        Finally
            Button1.Enabled = True
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    


End Class