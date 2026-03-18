Option Strict On
Option Infer On

Namespace Auth

    Public Interface IUserAuthRepository
        Function TryLogin(request As LoginRequest) As LoginResult
    End Interface

End Namespace
