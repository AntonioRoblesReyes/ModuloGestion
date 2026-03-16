Option Strict On
Option Infer On

Namespace Forms.Auth

    Public Class AuthAppService
        Implements IAuthAppService

        Public Function Login(request As LoginRequest) As LoginResult Implements IAuthAppService.Login

            ' LOGIN TEMPORAL PARA PROBAR EL SISTEMA

            If request.Usuario = "admin" AndAlso request.Clave = "1234" Then
                Return New LoginResult With {
                    .Exitoso = True,
                    .Usuario = request.Usuario,
                    .NombreCompleto = "Administrador",
                    .IdUsuario = 1
                }
            End If

            Return New LoginResult With {
                .Exitoso = False,
                .Mensaje = "Usuario o contraseña incorrectos"
            }

        End Function

    End Class

End Namespace