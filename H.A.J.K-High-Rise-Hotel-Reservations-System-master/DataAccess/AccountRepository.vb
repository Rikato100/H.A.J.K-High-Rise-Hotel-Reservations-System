Imports MySql.Data.MySqlClient

Public Class AccountRepository

    Public Shared Function GetAccountByUsername(username As String) As Account
        Dim account As Account = Nothing

        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            Dim query As String =
                "SELECT account_id, username, password_hash, fullname, role " &
                "FROM account WHERE username = @username"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        account = New Account(
                            reader.GetInt32("account_id"),
                            reader.GetString("username"),
                            reader.GetString("password_hash"),
                            reader.GetString("fullname"),
                            reader.GetString("role")
                        )
                    End If
                End Using
            End Using
        End Using

        Return account
    End Function

End Class
