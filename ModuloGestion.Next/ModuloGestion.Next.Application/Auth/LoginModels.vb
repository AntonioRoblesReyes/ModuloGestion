Option Strict On
Option Infer On

Namespace Auth

    Public Class LoginRequest
        Public Property Usuario As String
        Public Property Clave As String
    End Class

    Public Class LoginResult
        Public Property Exitoso As Boolean
        Public Property Mensaje As String
        Public Property IdUsuario As Integer
        Public Property Usuario As String
        Public Property NombreCompleto As String
    End Class

End Namespace
