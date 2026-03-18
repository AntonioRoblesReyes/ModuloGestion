Option Strict On
Option Infer On

Imports System.Data
Imports Microsoft.Data.SqlClient
Imports ModuloGestion.Next.Application.Auth

Public Class SqlUserAuthRepository
    Implements IUserAuthRepository

    Private Const MaxIntentosFallidos As Integer = 5

    Public Function TryLogin(request As LoginRequest) As LoginResult Implements IUserAuthRepository.TryLogin

        Using cn = DatabaseConnection.GetConnection()
            cn.Open()

            Dim usuarioData = ObtenerUsuario(cn, request.Usuario)
            If usuarioData Is Nothing Then
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "Usuario o contraseña incorrectos"
                }
            End If

            If Not usuarioData.Activo Then
                RegistrarSesion(cn, usuarioData.IdUsuario, "LOCKED", request.NombreEquipo, "Usuario inactivo")
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "El usuario está inactivo"
                }
            End If

            If usuarioData.IntentosFallidos >= MaxIntentosFallidos Then
                RegistrarSesion(cn, usuarioData.IdUsuario, "LOCKED", request.NombreEquipo, "Usuario bloqueado por intentos fallidos")
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "Usuario bloqueado. Contacta al administrador"
                }
            End If

            If Not AuthPasswordHasher.VerifyPassword(request.Clave, usuarioData.SalHash, usuarioData.ClaveHash) Then
                RegistrarLoginFallido(cn, usuarioData.IdUsuario, request.NombreEquipo)
                Return New LoginResult With {
                    .Exitoso = False,
                    .Mensaje = "Usuario o contraseña incorrectos"
                }
            End If

            RegistrarLoginExitoso(cn, usuarioData.IdUsuario, request.NombreEquipo)

            Return New LoginResult With {
                .Exitoso = True,
                .IdUsuario = usuarioData.IdUsuario,
                .Usuario = usuarioData.Usuario,
                .NombreCompleto = usuarioData.NombreCompleto,
                .Categoria = usuarioData.Categoria,
                .DebeCambiarClave = usuarioData.DebeCambiarClave
            }
        End Using

    End Function

    Private Shared Function ObtenerUsuario(cn As SqlConnection, usuario As String) As UsuarioAuthData

        Using cmd As New SqlCommand("auth.sp_Login", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Usuario", usuario)

            Using rd = cmd.ExecuteReader()
                If Not rd.Read() Then
                    Return Nothing
                End If

                Return New UsuarioAuthData With {
                    .IdUsuario = Convert.ToInt32(rd("IdUsuario")),
                    .Usuario = rd("Usuario").ToString(),
                    .NombreCompleto = rd("NombreCompleto").ToString(),
                    .Categoria = Convert.ToInt32(rd("Categoria")),
                    .Activo = Convert.ToBoolean(rd("Activo")),
                    .IntentosFallidos = Convert.ToInt32(rd("IntentosFallidos")),
                    .DebeCambiarClave = Convert.ToBoolean(rd("DebeCambiarClave")),
                    .ClaveHash = DirectCast(rd("ClaveHash"), Byte()),
                    .SalHash = DirectCast(rd("SalHash"), Byte())
                }
            End Using
        End Using

    End Function

    Private Shared Sub RegistrarLoginExitoso(cn As SqlConnection, idUsuario As Integer, nombreEquipo As String)

        Using cmd As New SqlCommand("auth.sp_LoginSuccess", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
            cmd.Parameters.AddWithValue("@NombreEquipo", If(String.IsNullOrWhiteSpace(nombreEquipo), CType(DBNull.Value, Object), nombreEquipo))
            cmd.ExecuteNonQuery()
        End Using

    End Sub

    Private Shared Sub RegistrarLoginFallido(cn As SqlConnection, idUsuario As Integer, nombreEquipo As String)

        Using cmd As New SqlCommand("auth.sp_LoginFailure", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
            cmd.Parameters.AddWithValue("@NombreEquipo", If(String.IsNullOrWhiteSpace(nombreEquipo), CType(DBNull.Value, Object), nombreEquipo))
            cmd.ExecuteNonQuery()
        End Using

    End Sub

    Private Shared Sub RegistrarSesion(cn As SqlConnection, idUsuario As Integer, resultado As String, nombreEquipo As String, observacion As String)

        Using cmd As New SqlCommand("auth.sp_RegistrarSesion", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
            cmd.Parameters.AddWithValue("@Resultado", resultado)
            cmd.Parameters.AddWithValue("@NombreEquipo", If(String.IsNullOrWhiteSpace(nombreEquipo), CType(DBNull.Value, Object), nombreEquipo))
            cmd.Parameters.AddWithValue("@IpOrigen", DBNull.Value)
            cmd.Parameters.AddWithValue("@Observacion", If(String.IsNullOrWhiteSpace(observacion), CType(DBNull.Value, Object), observacion))
            cmd.ExecuteNonQuery()
        End Using

    End Sub

    Private NotInheritable Class UsuarioAuthData
        Public Property IdUsuario As Integer
        Public Property Usuario As String
        Public Property NombreCompleto As String
        Public Property Categoria As Integer
        Public Property Activo As Boolean
        Public Property IntentosFallidos As Integer
        Public Property DebeCambiarClave As Boolean
        Public Property ClaveHash As Byte()
        Public Property SalHash As Byte()
    End Class

End Class
