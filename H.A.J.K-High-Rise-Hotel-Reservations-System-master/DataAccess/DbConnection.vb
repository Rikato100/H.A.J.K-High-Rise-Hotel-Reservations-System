Imports MySql.Data.MySqlClient

Public Class DbConnection
    ' EDIT these to match your local MySQL setup
    Private Const Server As String = "localhost"
    Private Const Database As String = "hajk_hotel_db"
    Private Const Uid As String = "root"
    Private Const Pwd As String = "" ' your MySQL root password

    Public Shared Function GetConnection() As MySqlConnection
        Dim connString As String =
            $"Server={Server};Database={Database};Uid={Uid};Pwd={Pwd};"
        Return New MySqlConnection(connString)
    End Function
End Class
