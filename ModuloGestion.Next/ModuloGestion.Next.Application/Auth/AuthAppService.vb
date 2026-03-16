Option Strict On
Option Infer On

Namespace Auth

    Public Class AuthAppService
        Implements IAuthAppService

        Private ReadOnly _repository As IUserAuthRepository

        Public Sub New(repository As IUserAuthRepository)
            _repository = repository
        End Sub

        Public Function Login(request As LoginRequest) As LoginResult Implements IAuthAppService.Login

            If request Is Nothing Then
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "Solicitud inválida"
                }
            End If

            Dim usuario = If(request.Usuario, String.Empty).Trim()
            Dim clave = If(request.Clave, String.Empty)

            If usuario.Length = 0 OrElse clave.Length = 0 Then
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "Debe indicar usuario y clave"
                }
            End If

            Return _repository.TryLogin(usuario, clave)

        End Function

    End Class

End Namespace
