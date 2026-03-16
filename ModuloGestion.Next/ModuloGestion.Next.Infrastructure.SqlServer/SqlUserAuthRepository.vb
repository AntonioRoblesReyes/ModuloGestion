Option Strict On
Option Infer On

Imports Microsoft.Data.SqlClient
Imports ModuloGestion.Next.Application.Auth

Public Class SqlUserAuthRepository
    Implements IUserAuthRepository

    Public Function TryLogin(usuario As String, clave As String) As LoginResult Implements IUserAuthRepository.TryLogin

        Const sql As String = "SELECT TOP (1) Id_Usuario, Usuario, Nombre FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Clave"

        Using cn = DatabaseConnection.GetConnection()
            Using cmd As New SqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@Usuario", usuario)
                cmd.Parameters.AddWithValue("@Clave", clave)

                cn.Open()

                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        Dim idUsuario = Convert.ToInt32(rd("Id_Usuario"))
                        Dim nombre As String = If(rd("Nombre") Is DBNull.Value, usuario, rd("Nombre").ToString())

                        Return New LoginResult With {
                            .Exitoso = True,
                            .IdUsuario = idUsuario,
                            .Usuario = usuario,
                            .NombreCompleto = nombre
                        }
                    End If
                End Using

            End Using
        End Using

        Return New LoginResult With {
            .Exitoso = False,
            .Mensaje = "Usuario o contraseña incorrectos"
        }

    End Function

End Class
