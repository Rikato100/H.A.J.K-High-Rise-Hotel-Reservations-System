Imports MySql.Data.MySqlClient

Public Class SettingsControl

    ' --- Discount Settings State Variables ---
    Private selectedId As Integer = 0
    Private selectedType As String = ""

    Private Sub SettingsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDiscounts.AllowUserToAddRows = False
        ' Initialize Discount Tab
        numRate.Minimum = 0
        numRate.Maximum = 100
        SetEditorEnabled(False)
        LoadDiscounts()

        ' Initialize System Reset Defaults
        dtpResetStartDate.Enabled = False
        dtpResetEndDate.Enabled = False
        chkDeleteGuestHistory.Enabled = False
        chkDeleteFinancial.Enabled = False
        chkResetRoomStatus.Enabled = False

        ' Staff only get Change Password: remove the Discount and System Reset tabs
        If CurrentUser.Role <> "Admin" Then HideAdminTabs()
    End Sub

    ' Finds the tab pages that hold the discount grid and the reset options (by the controls
    ' inside them, so it does not depend on what the tabs are named) and removes them.
    Private Sub HideAdminTabs()
        For Each tc As TabControl In GetAllTabControls(Me)
            For Each page As TabPage In tc.TabPages.Cast(Of TabPage)().ToList()
                If page.Controls.Find("dgvDiscounts", True).Length > 0 OrElse
                   page.Controls.Find("rbFactoryReset", True).Length > 0 Then
                    tc.TabPages.Remove(page)
                End If
            Next
        Next
    End Sub

    Private Function GetAllTabControls(parent As Control) As List(Of TabControl)
        Dim found As New List(Of TabControl)()
        For Each c As Control In parent.Controls
            If TypeOf c Is TabControl Then found.Add(DirectCast(c, TabControl))
            found.AddRange(GetAllTabControls(c))
        Next
        Return found
    End Function

    ' ==========================================
    ' TAB 1: DISCOUNT SETTINGS LOGIC
    ' ==========================================

    Private Sub LoadDiscounts()
        Try
            Dim dt As New DataTable()
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String =
                    "SELECT discount_id, discount_name, discount_type, discount_rate, " &
                    "start_date, end_date FROM discount ORDER BY discount_id"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvDiscounts.DataSource = dt

            ' Make columns stretch evenly across the grid width
            dgvDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Hide the ID column so it doesn't appear or look cut off
            If dgvDiscounts.Columns.Contains("discount_id") Then
                dgvDiscounts.Columns("discount_id").Visible = False
            End If

            dgvDiscounts.Columns("discount_name").HeaderText = "Name"
            dgvDiscounts.Columns("discount_type").HeaderText = "Type"
            dgvDiscounts.Columns("discount_rate").HeaderText = "Rate (%)"
            dgvDiscounts.Columns("discount_rate").DefaultCellStyle.Format = "0.00"
            dgvDiscounts.Columns("start_date").HeaderText = "Start Date"
            dgvDiscounts.Columns("start_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvDiscounts.Columns("end_date").HeaderText = "End Date"
            dgvDiscounts.Columns("end_date").DefaultCellStyle.Format = "yyyy-MM-dd"

        Catch ex As Exception
            MessageBox.Show("Could not load discounts: " & ex.Message, "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetEditorEnabled(enabled As Boolean)
        numRate.Enabled = enabled
        dtpStartDate.Enabled = enabled
        dtpEndDate.Enabled = enabled
        btnSaveDiscount.Enabled = enabled
    End Sub

    Private Sub dgvDiscounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiscounts.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvDiscounts.Rows(e.RowIndex)

        selectedId = If(IsDBNull(row.Cells("discount_id").Value), 0, Convert.ToInt32(row.Cells("discount_id").Value))
        selectedType = If(IsDBNull(row.Cells("discount_type").Value), "", row.Cells("discount_type").Value.ToString())
        lblSelectDiscount.Text = If(IsDBNull(row.Cells("discount_name").Value), "", row.Cells("discount_name").Value.ToString())

        Dim rateValue = row.Cells("discount_rate").Value
        numRate.Value = If(IsDBNull(rateValue), 0D, Convert.ToDecimal(rateValue))

        LoadDate(dtpStartDate, row.Cells("start_date").Value)
        LoadDate(dtpEndDate, row.Cells("end_date").Value)

        ' "None" is always 0% and has no dates, so it is read-only
        SetEditorEnabled(selectedType <> "None")
    End Sub

    Private Sub LoadDate(picker As DateTimePicker, value As Object)
        If value Is Nothing OrElse IsDBNull(value) OrElse String.IsNullOrEmpty(value.ToString()) Then
            picker.Value = DateTime.Today
            picker.Checked = False
        Else
            DateTime.TryParse(value.ToString(), picker.Value)
            picker.Checked = True
        End If
    End Sub

    Private Sub btnSaveDiscount_Click(sender As Object, e As EventArgs) Handles btnSaveDiscount.Click
        If CurrentUser.Role <> "Admin" Then Exit Sub

        If selectedId = 0 Then
            MessageBox.Show("Select a discount from the list first.", "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpStartDate.Checked AndAlso dtpEndDate.Checked AndAlso dtpEndDate.Value.Date < dtpStartDate.Value.Date Then
            MessageBox.Show("The end date cannot be before the start date.", "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If selectedType = "Statutory" Then
            Dim answer As DialogResult = MessageBox.Show(
                "The Statutory discount (Senior Citizen / PWD) is set by law. Change it anyway?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer <> DialogResult.Yes Then Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String =
                    "UPDATE discount SET discount_rate = @rate, start_date = @start, " &
                    "end_date = @end WHERE discount_id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rate", numRate.Value)
                    cmd.Parameters.AddWithValue("@start", If(dtpStartDate.Checked, CObj(dtpStartDate.Value.Date), DBNull.Value))
                    cmd.Parameters.AddWithValue("@end", If(dtpEndDate.Checked, CObj(dtpEndDate.Value.Date), DBNull.Value))
                    cmd.Parameters.AddWithValue("@id", selectedId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Discount updated.", "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selectedId = 0
            lblSelectDiscount.Text = "Select a discount above"
            SetEditorEnabled(False)
            LoadDiscounts()

        Catch ex As Exception
            MessageBox.Show("Could not save the discount: " & ex.Message, "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ==========================================
    ' TAB 2: CHANGE PASSWORD LOGIC
    ' ==========================================

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        If CurrentUser.AccountID = 0 Then
            MessageBox.Show("No logged-in account was found. Please log in again.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtCurrentPwd.Text = "" OrElse txtNewPwd.Text = "" OrElse txtConfirmPwd.Text = "" Then
            MessageBox.Show("Please fill in all three fields.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNewPwd.Text <> txtConfirmPwd.Text Then
            MessageBox.Show("The new passwords do not match.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNewPwd.Text = txtCurrentPwd.Text Then
            MessageBox.Show("The new password must be different from the current one.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim problem As String = GetPasswordProblem(txtNewPwd.Text)
        If problem <> "" Then
            MessageBox.Show(problem, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim storedHash As String = ""
                Using cmd As New MySqlCommand("SELECT password_hash FROM account WHERE account_id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", CurrentUser.AccountID)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then storedHash = result.ToString()
                End Using

                If storedHash = "" OrElse Not PasswordHash.VerifyPassword(txtCurrentPwd.Text, storedHash) Then
                    MessageBox.Show("The current password is incorrect.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Using cmd As New MySqlCommand("UPDATE account SET password_hash = @hash WHERE account_id = @id", conn)
                    cmd.Parameters.AddWithValue("@hash", PasswordHash.HashPassword(txtNewPwd.Text))
                    cmd.Parameters.AddWithValue("@id", CurrentUser.AccountID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Your password has been changed.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearPasswordFields()

        Catch ex As Exception
            MessageBox.Show("Could not change the password: " & ex.Message, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelPassword_Click(sender As Object, e As EventArgs) Handles btnCancelPassword.Click
        ClearPasswordFields()
    End Sub

    Private Sub ClearPasswordFields()
        txtCurrentPwd.Clear()
        txtNewPwd.Clear()
        txtConfirmPwd.Clear()
    End Sub

    Private Function GetPasswordProblem(password As String) As String
        If password.Length < 8 Then Return "Password must be at least 8 characters."
        If Not password.Any(Function(c) Char.IsLetter(c)) OrElse Not password.Any(Function(c) Char.IsDigit(c)) Then
            Return "Password must contain at least one letter and one number."
        End If
        Return ""
    End Function


    ' ==========================================
    ' TAB 3: SYSTEM RESET LOGIC
    ' ==========================================

    Private Sub rbSelectiveReset_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelectiveReset.CheckedChanged
        Dim isSelective As Boolean = rbSelectiveReset.Checked
        dtpResetStartDate.Enabled = isSelective
        dtpResetEndDate.Enabled = isSelective
        chkDeleteGuestHistory.Enabled = isSelective
        chkDeleteFinancial.Enabled = isSelective
        chkResetRoomStatus.Enabled = isSelective
    End Sub

    Private Sub rbFactoryReset_CheckedChanged(sender As Object, e As EventArgs) Handles rbFactoryReset.CheckedChanged
        Dim isSelective As Boolean = rbSelectiveReset.Checked
        dtpResetStartDate.Enabled = isSelective
        dtpResetEndDate.Enabled = isSelective
        chkDeleteGuestHistory.Enabled = isSelective
        chkDeleteFinancial.Enabled = isSelective
        chkResetRoomStatus.Enabled = isSelective
    End Sub

    Private Sub btnExecuteReset_Click(sender As Object, e As EventArgs) Handles btnExecuteReset.Click
        If CurrentUser.Role <> "Admin" Then Exit Sub

        If String.IsNullOrWhiteSpace(txtAdminPwdConfirm.Text) Then
            MessageBox.Show("Please enter your Admin password to proceed.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not VerifyAdminPassword(txtAdminPwdConfirm.Text) Then
            MessageBox.Show("Incorrect password. Reset aborted.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAdminPwdConfirm.Clear()
            Return
        End If

        Dim repo As New AdminRepository()

        If rbFactoryReset.Checked Then
            Dim result As DialogResult = MessageBox.Show(
                "WARNING: This will permanently delete ALL reservations, guests and payments, and set every room to Available." & vbCrLf & vbCrLf &
                "Staff accounts and discount settings are kept." & vbCrLf & vbCrLf &
                "Are you absolutely sure you want to proceed?",
                "Confirm Factory Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

            If result = DialogResult.Yes Then
                If repo.FactoryReset() Then
                    MessageBox.Show("Factory reset completed." & vbCrLf & vbCrLf & repo.LastSummary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        ElseIf rbSelectiveReset.Checked Then
            If dtpResetStartDate.Value.Date > dtpResetEndDate.Value.Date Then
                MessageBox.Show("Start Date cannot be after End Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not chkDeleteGuestHistory.Checked AndAlso Not chkDeleteFinancial.Checked AndAlso Not chkResetRoomStatus.Checked Then
                MessageBox.Show("Please select at least one option to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to perform the selected actions for " & dtpResetStartDate.Value.ToShortDateString() & " to " & dtpResetEndDate.Value.ToShortDateString() & "? This cannot be undone." & vbCrLf & vbCrLf &
                "(Room statuses are not limited by the date range.)",
                "Confirm Selective Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                If repo.SelectiveResetByCheckboxes(dtpResetStartDate.Value, dtpResetEndDate.Value, chkDeleteGuestHistory.Checked, chkDeleteFinancial.Checked, chkResetRoomStatus.Checked) Then
                    MessageBox.Show("Selective reset completed." & vbCrLf & vbCrLf & repo.LastSummary, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Please select a reset type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        txtAdminPwdConfirm.Clear()
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
