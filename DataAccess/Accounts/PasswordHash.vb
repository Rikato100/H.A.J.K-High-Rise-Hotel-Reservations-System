Imports System.Security.Cryptography

Public Class PasswordHash

    Private Const Iterations As Integer = 100000

    ' Turns "staff123" into "salt:hash" for storing in password_hash
    Public Shared Function HashPassword(password As String) As String
        Dim salt As Byte() = RandomNumberGenerator.GetBytes(16)
        Dim hash As Byte() = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32)
        Return Convert.ToBase64String(salt) & ":" & Convert.ToBase64String(hash)
    End Function

    ' Checks a typed password against the stored "salt:hash"
    Public Shared Function VerifyPassword(password As String, stored As String) As Boolean
        Dim parts() As String = stored.Split(":"c)
        If parts.Length <> 2 Then Return False

        Dim salt As Byte() = Convert.FromBase64String(parts(0))
        Dim expected As Byte() = Convert.FromBase64String(parts(1))
        Dim actual As Byte() = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, expected.Length)

        Return CryptographicOperations.FixedTimeEquals(actual, expected)
    End Function

End Class