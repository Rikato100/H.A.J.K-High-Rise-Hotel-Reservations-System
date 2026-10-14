Imports MySql.Data.MySqlClient

Public Class DbTest

    Public Shared Function TestConnection() As Boolean

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Return True
            End Using

        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message)
            Return False
        End Try

    End Function

End Class