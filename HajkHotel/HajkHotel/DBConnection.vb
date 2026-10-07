Imports MySql.Data.MySqlClient

Public Class DBConnection

    Public Shared Function GetConnection() As MySqlConnection

        Dim connectionString As String =
            "Server=localhost;" &
            "Database=hajk;" &
            "Uid=root;" &
            "Pwd=;"

        Return New MySqlConnection(connectionString)

    End Function

End Class