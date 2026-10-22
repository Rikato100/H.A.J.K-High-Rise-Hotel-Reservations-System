Public Class StaffManagementForm

    Private selectedAccountId As Integer = 0

    Private Sub StaffManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRole.Items.Clear()
        cboRole.Items.Add("Admin")
        cboRole.Items.Add("Staff")

        LoadStaffGrid()
    End Sub

    Private Sub LoadStaffGrid()
        Try
            dgvStaff.DataSource = StaffRepository.GetAllAccounts()

            ' Friendlier column headers than the raw database column names
            dgvStaff.Columns("account_id").HeaderText = "ID"
            dgvStaff.Columns("username").HeaderText = "Username"
            dgvStaff.Columns("fullname").HeaderText = "Full Name"
            dgvStaff.Columns("role").HeaderText = "Role"
            dgvStaff.Columns("account_status").HeaderText = "Status"
            dgvStaff.Columns("account_id").FillWeight = 30

        Catch ex As Exception
            MessageBox.Show(
                "Could not load staff accounts: " & ex.Message,
                "Staff Management Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Clicking a row loads that account's details into the form for editing
    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvStaff.Rows(e.RowIndex)

        selectedAccountId = Convert.ToInt32(row.Cells("account_id").Value)
        txtUsername.Text = row.Cells("username").Value.ToString()
        txtFullname.Text = row.Cells("fullname").Value.ToString()
        cboRole.Text = row.Cells("role").Value.ToString()
        txtPassword.Text = "" ' never show the stored password
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" OrElse txtFullname.Text.Trim() = "" OrElse cboRole.Text = "" Then
            MessageBox.Show("Please fill in username, password, full name, and role.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim success As Boolean = StaffRepository.AddAccount(
            txtUsername.Text.Trim(),
            txtPassword.Text,
            txtFullname.Text.Trim(),
            cboRole.Text
        )

        If success Then
            MessageBox.Show("Account created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadStaffGrid()
        Else
            MessageBox.Show("That username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedAccountId = 0 Then
            MessageBox.Show("Select an account from the list first.", "No Account Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        StaffRepository.UpdateAccount(
            selectedAccountId,
            txtFullname.Text.Trim(),
            cboRole.Text,
            txtPassword.Text ' blank = password unchanged
        )

        MessageBox.Show("Account updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
        LoadStaffGrid()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If selectedAccountId = 0 Then
            MessageBox.Show("Select an account from the list first.", "No Account Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Deactivate this account? They will no longer be able to log in.",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm = DialogResult.Yes Then
            StaffRepository.SetAccountStatus(selectedAccountId, "Inactive")
            MessageBox.Show("Account deactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadStaffGrid()
        End If
    End Sub

    Private Sub ClearForm()
        selectedAccountId = 0
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFullname.Text = ""
        cboRole.Text = ""
    End Sub

End Class
