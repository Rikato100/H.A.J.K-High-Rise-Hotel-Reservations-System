Public Class StaffManagementControl

    Private selectedAccountId As Integer = 0
    Private selectedRole As String = ""
    Private selectedStatus As String = ""
    Private isLoading As Boolean = True

    Private Sub StaffManagementControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.Clear()
        cboRole.Items.Add("Admin")
        cboRole.Items.Add("Staff")

        cboStatusFilter.Items.AddRange(New Object() {"All", "Active", "Inactive"})
        cboRoleFilter.Items.AddRange(New Object() {"All", "Admin", "Staff"})
        cboStatusFilter.SelectedIndex = 0
        cboRoleFilter.SelectedIndex = 0

        isLoading = False
        LoadStaffGrid()
    End Sub

    ' ---------- Grid, search and filters ----------

    Private Sub LoadStaffGrid()
        Try
            Dim status As String = If(cboStatusFilter.Text = "All", "", cboStatusFilter.Text)
            Dim role As String = If(cboRoleFilter.Text = "All", "", cboRoleFilter.Text)

            dgvStaff.DataSource = StaffRepository.GetAllAccounts(txtSearch.Text.Trim(), status, role)

            dgvStaff.Columns("account_id").HeaderText = "ID"
            dgvStaff.Columns("username").HeaderText = "Username"
            dgvStaff.Columns("fullname").HeaderText = "Full Name"
            dgvStaff.Columns("role").HeaderText = "Role"
            dgvStaff.Columns("account_status").HeaderText = "Status"
            dgvStaff.Columns("account_id").FillWeight = 30

            ' Gray out deactivated accounts
            For Each row As DataGridViewRow In dgvStaff.Rows
                If row.Cells("account_status").Value.ToString() = "Inactive" Then
                    row.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Could not load staff accounts: " & ex.Message, "Staff Management Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not isLoading Then LoadStaffGrid()
    End Sub

    Private Sub cboStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusFilter.SelectedIndexChanged
        If Not isLoading Then LoadStaffGrid()
    End Sub

    Private Sub cboRoleFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoleFilter.SelectedIndexChanged
        If Not isLoading Then LoadStaffGrid()
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        isLoading = True
        
        ' Reset the search and filters
        txtSearch.Text = ""
        cboStatusFilter.SelectedIndex = 0
        cboRoleFilter.SelectedIndex = 0
        
        ' FIX: Clear the form textboxes and reset selections
        ClearForm()
        
        isLoading = False
        LoadStaffGrid()
    End Sub

    ' Clicking a row loads that account's details into the form for editing
    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvStaff.Rows(e.RowIndex)

        selectedAccountId = Convert.ToInt32(row.Cells("account_id").Value)
        selectedRole = row.Cells("role").Value.ToString()
        selectedStatus = row.Cells("account_status").Value.ToString()

        txtUsername.Text = row.Cells("username").Value.ToString()
        txtFullName.Text = row.Cells("fullname").Value.ToString()
        cboRole.Text = selectedRole
        txtPassword.Text = "" ' never show the stored password
    End Sub

    ' ---------- Validation ----------

    Private Function GetUsernameProblem(username As String) As String
        If username.Length < 3 Then Return "Username must be at least 3 characters."
        If username.Contains(" ") Then Return "Username cannot contain spaces."
        Return ""
    End Function

    Private Function GetPasswordProblem(password As String) As String
        If password.Length < 8 Then Return "Password must be at least 8 characters."
        If Not password.Any(Function(c) Char.IsLetter(c)) OrElse Not password.Any(Function(c) Char.IsDigit(c)) Then
            Return "Password must contain at least one letter and one number."
        End If
        Return ""
    End Function

    Private Sub ShowWarning(message As String)
        MessageBox.Show(message, "Cannot Continue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    ' ---------- Add / Update / Deactivate / Reactivate ----------

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" OrElse txtFullName.Text.Trim() = "" OrElse cboRole.Text = "" Then
            ShowWarning("Please fill in username, password, full name, and role.")
            Exit Sub
        End If

        Dim problem As String = GetUsernameProblem(txtUsername.Text.Trim())
        If problem = "" Then problem = GetPasswordProblem(txtPassword.Text)
        If problem <> "" Then
            ShowWarning(problem)
            Exit Sub
        End If

        Try
            Dim success As Boolean = StaffRepository.AddAccount(
                txtUsername.Text.Trim(),
                txtPassword.Text,
                txtFullName.Text.Trim(),
                cboRole.Text
            )

            If success Then
                MessageBox.Show("Account created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadStaffGrid()
            Else
                ShowWarning("That username is already taken.")
            End If
        Catch ex As Exception
            MessageBox.Show("Could not create account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedAccountId = 0 Then
            ShowWarning("Select an account from the list first.")
            Exit Sub
        End If

        If txtFullName.Text.Trim() = "" OrElse cboRole.Text = "" Then
            ShowWarning("Full name and role cannot be empty.")
            Exit Sub
        End If

        Dim problem As String = GetUsernameProblem(txtUsername.Text.Trim())
        If problem = "" AndAlso txtPassword.Text <> "" Then problem = GetPasswordProblem(txtPassword.Text)
        If problem <> "" Then
            ShowWarning(problem)
            Exit Sub
        End If

        Try
            ' Lockout protection: don't remove the Admin role from yourself or the last active Admin
            Dim demoting As Boolean = (selectedRole = "Admin" AndAlso cboRole.Text <> "Admin")
            If demoting Then
                If selectedAccountId = CurrentUser.AccountID Then
                    ShowWarning("You can't remove your own Admin role.")
                    Exit Sub
                End If
                If selectedStatus = "Active" AndAlso StaffRepository.CountOtherActiveAdmins(selectedAccountId) = 0 Then
                    ShowWarning("This is the only active Admin account. Make another Admin first.")
                    Exit Sub
                End If
            End If

            Dim success As Boolean = StaffRepository.UpdateAccount(
                selectedAccountId,
                txtUsername.Text.Trim(),
                txtFullName.Text.Trim(),
                cboRole.Text,
                txtPassword.Text ' blank = password unchanged
            )

            If success Then
                MessageBox.Show("Account updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadStaffGrid()
            Else
                ShowWarning("That username is already taken.")
            End If
        Catch ex As Exception
            MessageBox.Show("Could not update account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If selectedAccountId = 0 Then
            ShowWarning("Select an account from the list first.")
            Exit Sub
        End If

        If selectedStatus = "Inactive" Then
            ShowWarning("This account is already inactive.")
            Exit Sub
        End If

        Try
            ' Lockout protection
            If selectedAccountId = CurrentUser.AccountID Then
                ShowWarning("You can't deactivate the account you are logged in with.")
                Exit Sub
            End If
            If selectedRole = "Admin" AndAlso StaffRepository.CountOtherActiveAdmins(selectedAccountId) = 0 Then
                ShowWarning("This is the only active Admin account and can't be deactivated.")
                Exit Sub
            End If

            Dim confirm As DialogResult = MessageBox.Show(
                "Deactivate this account? They will no longer be able to log in.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.Yes Then
                StaffRepository.SetAccountStatus(selectedAccountId, "Inactive")
                MessageBox.Show("Account deactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadStaffGrid()
            End If
        Catch ex As Exception
            MessageBox.Show("Could not deactivate account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReactivate_Click(sender As Object, e As EventArgs) Handles btnReactivate.Click
        If selectedAccountId = 0 Then
            ShowWarning("Select an account from the list first.")
            Exit Sub
        End If

        If selectedStatus = "Active" Then
            ShowWarning("This account is already active.")
            Exit Sub
        End If

        Try
            Dim confirm As DialogResult = MessageBox.Show(
                "Reactivate this account? They will be able to log in again.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.Yes Then
                StaffRepository.SetAccountStatus(selectedAccountId, "Active")
                MessageBox.Show("Account reactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadStaffGrid()
            End If
        Catch ex As Exception
            MessageBox.Show("Could not reactivate account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        selectedAccountId = 0
        selectedRole = ""
        selectedStatus = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFullName.Text = ""
        cboRole.Text = ""
    End Sub

End Class
