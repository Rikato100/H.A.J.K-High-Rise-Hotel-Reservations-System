Public Class Account
    Public Property AccountId As Integer
    Public Property Username As String
    Public Property Password As String
    Public Property FullName As String
    Public Property Role As String ' "Admin" or "Employee"

    Public Sub New(accountId As Integer, username As String, password As String, fullName As String, role As String)
        Me.AccountId = accountId
        Me.Username = username
        Me.Password = password
        Me.FullName = fullName
        Me.Role = role
    End Sub
End Class
