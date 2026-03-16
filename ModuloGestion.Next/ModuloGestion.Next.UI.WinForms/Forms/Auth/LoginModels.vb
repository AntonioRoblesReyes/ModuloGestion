Option Strict On
Option Infer On

Namespace Forms.Auth

    Public Interface IAuthAppService
        Function Login(request As LoginRequest) As LoginResult
    End Interface

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