Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHash
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
        ' Trim to remove any accidental invisible spaces
        Dim inputHash As String = HashPassword(password).Trim()
        Dim dbHash As String = storedHash.Trim()

        Return inputHash = dbHash
    End Function

End Class
