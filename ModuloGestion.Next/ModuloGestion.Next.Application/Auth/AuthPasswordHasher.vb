Option Strict On
Option Infer On

Imports System.Security.Cryptography
Imports System.Text

Namespace Auth

    Public Module AuthPasswordHasher

        Public Function ComputeHash(clave As String, salHash As Byte()) As Byte()

            Dim passwordBytes = Encoding.Unicode.GetBytes(If(clave, String.Empty))
            Dim combined(salHash.Length + passwordBytes.Length - 1) As Byte

            Buffer.BlockCopy(salHash, 0, combined, 0, salHash.Length)
            Buffer.BlockCopy(passwordBytes, 0, combined, salHash.Length, passwordBytes.Length)

            Using sha = SHA512.Create()
                Return sha.ComputeHash(combined)
            End Using

        End Function

        Public Function VerifyPassword(clave As String, salHash As Byte(), claveHash As Byte()) As Boolean

            Dim computedHash = ComputeHash(clave, salHash)
            Return CryptographicOperations.FixedTimeEquals(computedHash, claveHash)

        End Function

    End Module

End Namespace
