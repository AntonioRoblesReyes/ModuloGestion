Option Strict On
Option Infer On

Namespace Auth

    Public Interface IAuthAppService
        Function Login(request As LoginRequest) As LoginResult
    End Interface

End Namespace
