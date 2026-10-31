Imports System.Security.Cryptography
Imports System.Text

' Handles password hashing so plain-text passwords are never stored in the database.
Public Class PasswordHash

    ' A fixed extra string added to every password before hashing.
    Private Const Salt As String = "HajkHotelSystemSalt123!"

    ' Turns a plain password into a hashed string that is safe to store.
    Public Shared Function HashPassword(password As String) As String
        ' SHA256 is the hashing algorithm; "Using" disposes it automatically when done.
        Using sha256 As SHA256 = SHA256.Create()

            ' Add the salt to the password before hashing.
            Dim combined As String = password & Salt

            ' Convert the text into bytes, because the hash works on bytes.
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(combined)

            ' Compute the one-way hash (it can't be turned back into the password).
            Dim hash As Byte() = sha256.ComputeHash(bytes)

            ' Convert the bytes to a Base64 text string so it can be saved in the database.
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    ' Checks if a typed password matches the hash stored in the database. Used on the login screen.
    Public Shared Function VerifyPassword(password As String, storedHash As String) As Boolean
        ' Hash the typed password the same way, so the two hashes can be compared.
        ' Trim removes any accidental invisible spaces.
        Dim inputHash As String = HashPassword(password).Trim()
        Dim dbHash As String = storedHash.Trim()

        ' True only if both hashes are exactly the same.
        Return inputHash = dbHash
    End Function

End Class
