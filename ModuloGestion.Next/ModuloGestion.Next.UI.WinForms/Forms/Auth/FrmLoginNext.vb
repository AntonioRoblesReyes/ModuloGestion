Namespace Forms.Auth
    Partial Public Class FrmLoginNext

        Public ReadOnly Property Usuario As String
            Get
                Return txtUsuario.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property Clave As String
            Get
                Return txtClave.Text
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnEntrar_Click(sender As Object, e As Global.System.EventArgs) Handles btnEntrar.Click
            If Not ValidarCampos() Then
                Me.DialogResult = Global.System.Windows.Forms.DialogResult.None
            End If
        End Sub

        Private Sub txtUsuario_TextChanged(sender As Object, e As Global.System.EventArgs) Handles txtUsuario.TextChanged
            LimpiarTooltipError()
        End Sub

        Private Sub txtClave_TextChanged(sender As Object, e As Global.System.EventArgs) Handles txtClave.TextChanged
            LimpiarTooltipError()
        End Sub

        Private Function ValidarCampos() As Boolean
            If String.IsNullOrWhiteSpace(Usuario) Then
                MostrarValidacion("Debe indicar el usuario.")
                txtUsuario.Focus()
                Return False
            End If

            If String.IsNullOrWhiteSpace(Clave) Then
                MostrarValidacion("Debe indicar la clave.")
                txtClave.Focus()
                Return False
            End If

            Return True
        End Function

        Private Sub MostrarValidacion(mensaje As String)
            Global.System.Windows.Forms.MessageBox.Show(Me, mensaje, "Validación", Global.System.Windows.Forms.MessageBoxButtons.OK, Global.System.Windows.Forms.MessageBoxIcon.Warning)
        End Sub

        Private Sub LimpiarTooltipError()
            ' Punto de extensión para validación visual futura.
        End Sub
    End Class
End Namespace
