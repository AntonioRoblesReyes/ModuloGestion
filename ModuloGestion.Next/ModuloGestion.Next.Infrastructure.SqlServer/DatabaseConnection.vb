Option Strict On
Option Infer On

Imports Microsoft.Data.SqlClient

Public Class DatabaseConnection

    Private Shared ReadOnly _connectionString As String =
        Environment.GetEnvironmentVariable("MODULOGESTION_NEXT_CONNECTION_STRING")

    Public Shared Function GetConnection() As SqlConnection

        If String.IsNullOrWhiteSpace(_connectionString) Then
            Throw New InvalidOperationException(
                "No se encontró la variable de entorno MODULOGESTION_NEXT_CONNECTION_STRING.")
        End If

        Return New SqlConnection(_connectionString)

    End Function

End Class
