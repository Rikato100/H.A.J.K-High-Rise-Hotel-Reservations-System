Imports MySql.Data.MySqlClient

Public Class loginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
        LoadAccounts()
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

                ' Include is_deleted in the query to check if the account is archived
                Dim query As String =
                "SELECT account_id, role, password_hash, account_status, is_deleted FROM account " &
                "WHERE username = @username"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@username", username)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() AndAlso PasswordHash.VerifyPassword(password, reader("password_hash").ToString()) Then

                            ' If the account is soft-deleted/archived
                            If Convert.ToInt32(reader("is_deleted")) = 1 Then
                                MessageBox.Show("Invalid username or password.")
                                Exit Sub
                            End If

                            ' Correct password but the account is manually deactivated
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
        Application.Exit()
    End Sub

    Private Sub loginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Only trigger this if they clicked the 'X' button
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.No Then
                ' Cancel the closing action and keep the login screen open
                e.Cancel = True
            Else
                ' They said Yes. Force the whole app to close.
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub LoadAccounts()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' Gets ALL accounts (Active and Inactive)
                Dim query As String = "SELECT username FROM account WHERE is_deleted = 0 ORDER BY role, username"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear any existing autocomplete sources
                        txtUsername.AutoCompleteCustomSource.Clear()

                        While reader.Read()
                            ' Add the username to the TextBox's autocomplete list
                            txtUsername.AutoCompleteCustomSource.Add(reader("username").ToString())
                        End While
                    End Using
                End Using
            End Using

            ' Turn on the autofill magic
            txtUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource

        Catch ex As Exception
            ' Silently fail if DB is not connected
        End Try
    End Sub
End Class
