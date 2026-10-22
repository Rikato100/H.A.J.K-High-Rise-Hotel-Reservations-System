Imports MySql.Data.MySqlClient

Public Class DbConnection

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return "Server=localhost;" &
                   "Database=hajk;" &
                   "Uid=root;" &
                   "Pwd=;"
        End Get
    End Property

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

End Class