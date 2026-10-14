Imports MySql.Data.MySqlClient

Public Class StaffRepository

    ' Returns all staff/admin accounts for display in a DataGridView
    Public Shared Function GetAllAccounts() As DataTable
        Dim dt As New DataTable()

        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            Dim query As String =
                "SELECT account_id, username, fullname, role, account_status " &
                "FROM account ORDER BY account_id"

            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
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
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@fullname", fullname)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function

    Public Shared Sub UpdateAccount(accountId As Integer, fullname As String, role As String, Optional newPassword As String = "")
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()

            Dim query As String
            If newPassword <> "" Then
                query = "UPDATE account SET fullname = @fullname, role = @role, password_hash = @password WHERE account_id = @id"
            Else
                query = "UPDATE account SET fullname = @fullname, role = @role WHERE account_id = @id"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fullname", fullname)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.Parameters.AddWithValue("@id", accountId)
                If newPassword <> "" Then
                    cmd.Parameters.AddWithValue("@password", newPassword)
                End If
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


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