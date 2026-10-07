Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT account_id, role FROM account " &
                "WHERE username = @username " &
                "AND password_hash = @password " &
                "AND account_status = 'Active'"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            Dim role As String = reader("role").ToString()

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
End Class
