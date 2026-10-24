Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHash

    ' Static salt ensures the hash is always the same
    Private Const Salt As String = "HajkHotelSystemSalt123!"

    Public Shared Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim combined As String = password & Salt
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(combined)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    Public Shared Function VerifyPassword(password As String, storedHash As String) As Boolean
        Return HashPassword(password).Trim() = storedHash.Trim()
    End Function

End Class
