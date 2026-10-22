Imports MySql.Data.MySqlClient

Public Class StaffRepository

    ' Returns accounts for the grid. Leave a filter blank to ignore it.
    Public Shared Function GetAllAccounts(Optional search As String = "", Optional status As String = "", Optional role As String = "") As DataTable
        Dim dt As New DataTable()

        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            Dim query As String =
                "SELECT account_id, username, fullname, role, account_status " &
                "FROM account " &
                "WHERE (@search = '' OR username LIKE @like OR fullname LIKE @like) " &
                "AND (@status = '' OR account_status = @status) " &
                "AND (@role = '' OR role = @role) " &
                "ORDER BY account_id"

            Using cmd As New MySqlCommand(query, conn)
                Dim escaped As String = search.Replace("\", "\\").Replace("%", "\%").Replace("_", "\_")
                cmd.Parameters.AddWithValue("@search", search)
                cmd.Parameters.AddWithValue("@like", "%" & escaped & "%")
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@role", role)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    ' Active Admin accounts other than the given one (used to prevent lockout)
    Public Shared Function CountOtherActiveAdmins(excludeAccountId As Integer) As Integer
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM account WHERE role = 'Admin' AND account_status = 'Active' AND account_id <> @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", excludeAccountId)
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function


    Public Shared Function AddAccount(username As String, password As String, fullname As String, role As String) As Boolean
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            ' Check for duplicate username first
            Dim checkQuery As String = "SELECT COUNT(*) FROM account WHERE username = @username"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@username", username)
                Dim count As Long = Convert.ToInt64(checkCmd.ExecuteScalar())
                If count > 0 Then
                    Return False ' username already exists
                End If
            End Using

            Dim insertQuery As String =
                "INSERT INTO account (username, password_hash, fullname, role, account_status) " &
                "VALUES (@username, @password, @fullname, @role, 'Active')"

            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", PasswordHash.HashPassword(password))
                cmd.Parameters.AddWithValue("@fullname", fullname)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function

    ' Returns False if the new username is already used by another account
    Public Shared Function UpdateAccount(accountId As Integer, username As String, fullname As String, role As String, Optional newPassword As String = "") As Boolean
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM account WHERE username = @username AND account_id <> @id"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@username", username)
                checkCmd.Parameters.AddWithValue("@id", accountId)
                If Convert.ToInt64(checkCmd.ExecuteScalar()) > 0 Then
                    Return False
                End If
            End Using

            Dim query As String
            If newPassword <> "" Then
                query = "UPDATE account SET username = @username, fullname = @fullname, role = @role, password_hash = @password WHERE account_id = @id"
            Else
                query = "UPDATE account SET username = @username, fullname = @fullname, role = @role WHERE account_id = @id"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@fullname", fullname)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.Parameters.AddWithValue("@id", accountId)
                If newPassword <> "" Then
                    cmd.Parameters.AddWithValue("@password", PasswordHash.HashPassword(newPassword))
                End If
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function


    Public Shared Sub SetAccountStatus(accountId As Integer, status As String)
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            Dim query As String = "UPDATE account SET account_status = @status WHERE account_id = @id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@id", accountId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class