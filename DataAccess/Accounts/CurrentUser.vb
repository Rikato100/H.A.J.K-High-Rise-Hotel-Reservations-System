' Remembers who is logged in (set by loginForm after a successful login)
Public Class CurrentUser
    Public Shared Property AccountId As Integer = 0
    Public Shared Property Role As String = ""
End Class