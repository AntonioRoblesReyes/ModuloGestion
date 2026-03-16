Option Strict On
Option Infer On

Namespace Auth

    Public Interface IUserAuthRepository
        Function TryLogin(usuario As String, clave As String) As LoginResult
    End Interface

End Namespace
