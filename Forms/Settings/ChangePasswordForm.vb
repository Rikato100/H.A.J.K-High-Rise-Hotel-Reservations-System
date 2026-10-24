Imports MySql.Data.MySqlClient

Public Class ChangePasswordForm
    '======================================================================
    '======================================================================
    '======================================================================

    'THIS IS ALREADY COMBINED WITH DISCOUNTSETTINS.VB IN SETTINGSFORM.VB
    '                   (delete after reading)

    '======================================================================
    '======================================================================
    '======================================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CurrentUser.AccountID = 0 Then ' FIXED: Capital D
            MessageBox.Show("No logged-in account was found. Please log in again.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtCurrent.Text = "" OrElse txtNew.Text = "" OrElse txtConfirm.Text = "" Then
            MessageBox.Show("Please fill in all three fields.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNew.Text <> txtConfirm.Text Then
            MessageBox.Show("The new passwords do not match.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNew.Text = txtCurrent.Text Then
            MessageBox.Show("The new password must be different from the current one.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim problem As String = GetPasswordProblem(txtNew.Text)
        If problem <> "" Then
            MessageBox.Show(problem, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim storedHash As String = ""
                Using cmd As New MySqlCommand("SELECT password_hash FROM account WHERE account_id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", CurrentUser.AccountID) ' FIXED
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then storedHash = result.ToString()
                End Using

                If storedHash = "" OrElse Not PasswordHash.VerifyPassword(txtCurrent.Text, storedHash) Then
                    MessageBox.Show("The current password is incorrect.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Using cmd As New MySqlCommand("UPDATE account SET password_hash = @hash WHERE account_id = @id", conn)
                    cmd.Parameters.AddWithValue("@hash", PasswordHash.HashPassword(txtNew.Text))
                    cmd.Parameters.AddWithValue("@id", CurrentUser.AccountID) ' FIXED
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Your password has been changed.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Could not change the password: " & ex.Message, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function GetPasswordProblem(password As String) As String
        If password.Length < 8 Then Return "Password must be at least 8 characters."
        If Not password.Any(Function(c) Char.IsLetter(c)) OrElse Not password.Any(Function(c) Char.IsDigit(c)) Then
            Return "Password must contain at least one letter and one number."
        End If
        Return ""
    End Function

    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '======================================================================
    '======================================================================
    '======================================================================

    'THIS IS ALREADY COMBINED WITH DISCOUNTSETTINS.VB IN SETTINGSFORM.VB
    '                   (delete after reading)

    '======================================================================
    '======================================================================
    '======================================================================

End Class
