Imports MySql.Data.MySqlClient

Public Class SystemResetForm

    ' Toggle the DatePickers when the RadioButtons are clicked
    Private Sub radSelectiveReset_CheckedChanged(sender As Object, e As EventArgs) Handles radSelectiveReset.CheckedChanged
        dtpStartDate.Enabled = radSelectiveReset.Checked
        dtpEndDate.Enabled = radSelectiveReset.Checked
    End Sub

    Private Sub radFactoryReset_CheckedChanged(sender As Object, e As EventArgs) Handles radFactoryReset.CheckedChanged
        dtpStartDate.Enabled = radSelectiveReset.Checked
        dtpEndDate.Enabled = radSelectiveReset.Checked
    End Sub

    ' The Main Execution Button
    Private Sub btnExecuteReset_Click(sender As Object, e As EventArgs) Handles btnExecuteReset.Click

        ' 1. Validate Password Input
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your Admin password to proceed.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not VerifyAdminPassword(txtPassword.Text) Then
            MessageBox.Show("Incorrect password. Reset aborted.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            Return
        End If

        ' 2. Execute based on selection
        Dim repo As New AdminRepository()

        If radFactoryReset.Checked Then
            ' Double-check warning for Factory Reset
            Dim result As DialogResult = MessageBox.Show(
                "WARNING: This will permanently delete ALL reservations, guests, payments, and other staff accounts." & vbCrLf & vbCrLf &
                "Your current Admin account will be preserved." & vbCrLf & vbCrLf &
                "Are you absolutely sure you want to proceed?",
                "Confirm Factory Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop)

            If result = DialogResult.Yes Then
                If repo.FactoryReset() Then
                    MessageBox.Show("Factory reset completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' Close the form after success
                End If
            End If

        ElseIf radSelectiveReset.Checked Then
            If dtpStartDate.Value.Date >= dtpEndDate.Value.Date Then
                MessageBox.Show("Start Date must be before End Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete all reservations and payments from {dtpStartDate.Value.ToShortDateString()} to {dtpEndDate.Value.ToShortDateString()}?",
                "Confirm Selective Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                If repo.SelectiveReset(dtpStartDate.Value, dtpEndDate.Value) Then
                    MessageBox.Show("Selective reset completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("Please select a reset type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Clear password field after execution
        txtPassword.Clear()
    End Sub

    ' Helper function to verify the Admin's password against the database
    Private Function VerifyAdminPassword(inputPassword As String) As Boolean
        Dim storedHash As String = ""

        ' Fetch the current logged-in user's hash from the DB
        Using conn As MySqlConnection = DbConnection.GetConnection()
            Dim query As String = "SELECT password_hash FROM account WHERE account_id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", CurrentUser.AccountId)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        storedHash = reader("password_hash").ToString()
                    End If
                End Using
            End Using
        End Using

        If String.IsNullOrEmpty(storedHash) Then Return False

        ' 100% secure hash verification
        Return PasswordHash.VerifyPassword(inputPassword, storedHash)
    End Function

End Class