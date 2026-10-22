' Remembers who is logged in (set by loginForm after a successful login)
Public Class CurrentUser
    Public Shared Property AccountID As Integer = 0
    Public Shared Property Role As String = ""
    Public Shared Property Username As String = ""
End Class
