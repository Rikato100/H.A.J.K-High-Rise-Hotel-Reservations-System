Imports MySql.Data.MySqlClient

Public Class SettingsForm

    ' --- Discount Settings State Variables ---
    Private selectedId As Integer = 0
    Private selectedType As String = ""

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize Discount Tab
        numRate.Minimum = 0
        numRate.Maximum = 100
        SetEditorEnabled(False)
        LoadDiscounts()
    End Sub

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
                    "start_date, end_date, vat_exempt FROM discount ORDER BY discount_id"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvDiscounts.DataSource = dt
            dgvDiscounts.Columns("discount_id").HeaderText = "ID"
            dgvDiscounts.Columns("discount_id").FillWeight = 25
            dgvDiscounts.Columns("discount_name").HeaderText = "Name"
            dgvDiscounts.Columns("discount_type").HeaderText = "Type"
            dgvDiscounts.Columns("discount_rate").HeaderText = "Rate (%)"
            dgvDiscounts.Columns("discount_rate").DefaultCellStyle.Format = "0.00"
            dgvDiscounts.Columns("start_date").HeaderText = "Start Date"
            dgvDiscounts.Columns("start_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvDiscounts.Columns("end_date").HeaderText = "End Date"
            dgvDiscounts.Columns("end_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvDiscounts.Columns("vat_exempt").HeaderText = "VAT Exempt"

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
        selectedId = Convert.ToInt32(row.Cells("discount_id").Value)
        selectedType = row.Cells("discount_type").Value.ToString()
        lblSelectDiscount.Text = row.Cells("discount_name").Value.ToString()

        numRate.Value = Convert.ToDecimal(row.Cells("discount_rate").Value)

        LoadDate(dtpStartDate, row.Cells("start_date").Value)
        LoadDate(dtpEndDate, row.Cells("end_date").Value)

        ' "None" is always 0% and has no dates, so it is read-only
        SetEditorEnabled(selectedType <> "None")
    End Sub

    Private Sub LoadDate(picker As DateTimePicker, value As Object)
        If value Is Nothing OrElse IsDBNull(value) Then
            picker.Value = DateTime.Today
            picker.Checked = False
        Else
            picker.Value = Convert.ToDateTime(value)
            picker.Checked = True
        End If
    End Sub

    Private Sub btnSaveDiscount_Click(sender As Object, e As EventArgs) Handles btnSaveDiscount.Click
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

    Private Sub btnCloseDiscount_Click(sender As Object, e As EventArgs)
        Close()
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
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Could not change the password: " & ex.Message, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelPassword_Click(sender As Object, e As EventArgs) Handles btnCancelPassword.Click
        Me.Close()
    End Sub

    Private Function GetPasswordProblem(password As String) As String
        If password.Length < 8 Then Return "Password must be at least 8 characters."
        If Not password.Any(Function(c) Char.IsLetter(c)) OrElse Not password.Any(Function(c) Char.IsDigit(c)) Then
            Return "Password must contain at least one letter and one number."
        End If
        Return ""
    End Function

End Class