Imports MySql.Data.MySqlClient

Public Class SystemResetForm

    Private Sub radSelectiveReset_CheckedChanged(sender As Object, e As EventArgs) Handles radSelectiveReset.CheckedChanged
        Dim isSelective As Boolean = radSelectiveReset.Checked
        dtpStartDate.Enabled = isSelective
        dtpEndDate.Enabled = isSelective
        chkGuestHistory.Enabled = isSelective
        chkFinancials.Enabled = isSelective
        chkRoomStatuses.Enabled = isSelective
    End Sub

    Private Sub radFactoryReset_CheckedChanged(sender As Object, e As EventArgs) Handles radFactoryReset.CheckedChanged
        Dim isSelective As Boolean = radSelectiveReset.Checked
        dtpStartDate.Enabled = isSelective
        dtpEndDate.Enabled = isSelective
        chkGuestHistory.Enabled = isSelective
        chkFinancials.Enabled = isSelective
        chkRoomStatuses.Enabled = isSelective
    End Sub

    Private Sub btnExecuteReset_Click(sender As Object, e As EventArgs) Handles btnExecuteReset.Click
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your Admin password to proceed.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not VerifyAdminPassword(txtPassword.Text) Then
            MessageBox.Show("Incorrect password. Reset aborted.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            Return
        End If

        Dim repo As New AdminRepository()

        If radFactoryReset.Checked Then
            Dim result As DialogResult = MessageBox.Show(
                "WARNING: This will permanently delete ALL reservations, guests and payments, and set every room to Available." & vbCrLf & vbCrLf &
                "Staff accounts and discount settings are kept." & vbCrLf & vbCrLf &
                "Are you absolutely sure you want to proceed?",
                "Confirm Factory Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

            If result = DialogResult.Yes Then
                If repo.FactoryReset() Then
                    MessageBox.Show("Factory reset completed." & vbCrLf & vbCrLf & repo.LastSummary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If

        ElseIf radSelectiveReset.Checked Then
            ' FIXED: Allows single day reset (removed =)
            If dtpStartDate.Value.Date > dtpEndDate.Value.Date Then
                MessageBox.Show("Start Date cannot be after End Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not chkGuestHistory.Checked AndAlso Not chkFinancials.Checked AndAlso Not chkRoomStatuses.Checked Then
                MessageBox.Show("Please select at least one option to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to perform the selected actions for " & dtpStartDate.Value.ToShortDateString() & " to " & dtpEndDate.Value.ToShortDateString() & "? This cannot be undone." & vbCrLf & vbCrLf &
                "(Room statuses are not limited by the date range.)",
                "Confirm Selective Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                If repo.SelectiveResetByCheckboxes(dtpStartDate.Value, dtpEndDate.Value, chkGuestHistory.Checked, chkFinancials.Checked, chkRoomStatuses.Checked) Then
                    MessageBox.Show("Selective reset completed." & vbCrLf & vbCrLf & repo.LastSummary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        Else
            MessageBox.Show("Please select a reset type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        txtPassword.Clear()
    End Sub

    Private Function VerifyAdminPassword(inputPassword As String) As Boolean
        Dim storedHash As String = ""
        Using conn As MySqlConnection = DbConnection.GetConnection()
            Dim query As String = "SELECT password_hash FROM account WHERE account_id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", CurrentUser.AccountID)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        storedHash = reader("password_hash").ToString()
                    End If
                End Using
            End Using
        End Using

        If String.IsNullOrEmpty(storedHash) Then Return False
        Return PasswordHash.VerifyPassword(inputPassword, storedHash)
    End Function
End Class
