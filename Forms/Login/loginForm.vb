Imports MySql.Data.MySqlClient

Public Class loginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
    End Sub

Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
    If e.KeyCode = Keys.Down Then
        txtPassword.Focus()
        e.SuppressKeyPress = True
    End If
End Sub

Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
    If e.KeyCode = Keys.Up Then
        txtUsername.Focus()
        e.SuppressKeyPress = True
    End If
End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()

                conn.Open()

                ' The password is checked in code (hashed), not in SQL
                Dim query As String =
                "SELECT account_id, role, password_hash, account_status FROM account " &
                "WHERE username = @username"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@username", username)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() AndAlso PasswordHash.VerifyPassword(password, reader("password_hash").ToString()) Then

                            ' Correct password but the account is switched off
                            If reader("account_status").ToString() <> "Active" Then
                                MessageBox.Show("This account has been deactivated. Please contact the administrator.",
                                                "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If

                            Dim role As String = reader("role").ToString()

                            CurrentUser.AccountID = Convert.ToInt32(reader("account_id"))
                            CurrentUser.Role = role
                            CurrentUser.Username = username

                            If role = "Admin" Then

                                Dim admin As New AdminDashboard()
                                admin.Show()
                                Me.Hide()

                            ElseIf role = "Staff" Then

                                Dim staff As New StaffDashboard()
                                staff.Show()
                                Me.Hide()

                            End If

                        Else

                            MessageBox.Show("Invalid username or password.")

                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub
End Class
