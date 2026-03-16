Option Strict On
Option Infer On
Imports Microsoft.Data.SqlClient

Public Class DatabaseConnection

    Private Const connectionString As String =
        "Server=PCShernia;Database=GestionEmpresa;User Id=sa;Password=laura2007;TrustServerCertificate=True;"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class