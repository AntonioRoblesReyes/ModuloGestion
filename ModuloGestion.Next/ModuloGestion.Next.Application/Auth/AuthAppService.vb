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

            request.Usuario = If(request.Usuario, String.Empty).Trim()
            request.Clave = If(request.Clave, String.Empty)
            request.NombreEquipo = If(request.NombreEquipo, String.Empty).Trim()

            If request.Usuario.Length = 0 OrElse request.Clave.Length = 0 Then
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "Debe indicar usuario y clave"
                }
            End If

            Return _repository.TryLogin(request)

        End Function

    End Class

End Namespace
