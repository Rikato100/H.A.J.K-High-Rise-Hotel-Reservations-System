Public Class Account
    Public Property AccountId As Integer
    Public Property Username As String
    Public Property PasswordHash As String          ' Store hash, never plain password
    Public Property Role As AccountRole
    Public Property AccountStatus As AccountStatus

    Public Sub New(accountId As Integer,
                   username As String,
                   passwordHash As String,
                   role As AccountRole,
                   status As AccountStatus)
        Me.AccountId = accountId
        Me.Username = username
        Me.PasswordHash = passwordHash
        Me.Role = role
        Me.AccountStatus = status
    End Sub
End Class

Public Enum AccountRole
    Admin
    Staff
End Enum

Public Enum AccountStatus
    Active
    Inactive
End Enum