<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblSearch = New Label()
        txtSearch = New TextBox()
        lblStatusFilter = New Label()
        cboStatusFilter = New ComboBox()
        lblRoleFilter = New Label()
        cboRoleFilter = New ComboBox()
        btnClearFilter = New Button()
        dgvStaff = New DataGridView()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblFullname = New Label()
        txtFullname = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblPasswordHint = New Label()
        lblRole = New Label()
        cboRole = New ComboBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDeactivate = New Button()
        btnReactivate = New Button()
        btnClose = New Button()
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.Location = New Point(23, 21)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(255, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Staff Management"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(23, 84)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(56, 20)
        lblSearch.TabIndex = 16
        lblSearch.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(86, 80)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Username or full name"
        txtSearch.Size = New Size(251, 27)
        txtSearch.TabIndex = 17
        ' 
        ' lblStatusFilter
        ' 
        lblStatusFilter.AutoSize = True
        lblStatusFilter.Location = New Point(360, 84)
        lblStatusFilter.Name = "lblStatusFilter"
        lblStatusFilter.Size = New Size(52, 20)
        lblStatusFilter.TabIndex = 18
        lblStatusFilter.Text = "Status:"
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Location = New Point(417, 80)
        cboStatusFilter.Margin = New Padding(3, 4, 3, 4)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(125, 28)
        cboStatusFilter.TabIndex = 19
        ' 
        ' lblRoleFilter
        ' 
        lblRoleFilter.AutoSize = True
        lblRoleFilter.Location = New Point(566, 84)
        lblRoleFilter.Name = "lblRoleFilter"
        lblRoleFilter.Size = New Size(42, 20)
        lblRoleFilter.TabIndex = 20
        lblRoleFilter.Text = "Role:"
        ' 
        ' cboRoleFilter
        ' 
        cboRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoleFilter.FormattingEnabled = True
        cboRoleFilter.Location = New Point(617, 80)
        cboRoleFilter.Margin = New Padding(3, 4, 3, 4)
        cboRoleFilter.Name = "cboRoleFilter"
        cboRoleFilter.Size = New Size(125, 28)
        cboRoleFilter.TabIndex = 21
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.BackColor = Color.White
        btnClearFilter.FlatAppearance.BorderColor = Color.Silver
        btnClearFilter.FlatStyle = FlatStyle.Flat
        btnClearFilter.Location = New Point(766, 77)
        btnClearFilter.Margin = New Padding(3, 4, 3, 4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(114, 36)
        btnClearFilter.TabIndex = 22
        btnClearFilter.Text = "CLEAR"
        btnClearFilter.UseVisualStyleBackColor = False
        ' 
        ' dgvStaff
        ' 
        dgvStaff.AllowUserToAddRows = False
        dgvStaff.AllowUserToDeleteRows = False
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStaff.BackgroundColor = Color.White
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaff.Location = New Point(23, 123)
        dgvStaff.Margin = New Padding(3, 4, 3, 4)
        dgvStaff.MultiSelect = False
        dgvStaff.Name = "dgvStaff"
        dgvStaff.ReadOnly = True
        dgvStaff.RowHeadersVisible = False
        dgvStaff.RowHeadersWidth = 51
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaff.Size = New Size(960, 283)
        dgvStaff.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(23, 440)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(78, 20)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(126, 436)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(228, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.Location = New Point(389, 440)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(79, 20)
        lblFullname.TabIndex = 4
        lblFullname.Text = "Full Name:"
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(491, 436)
        txtFullname.Margin = New Padding(3, 4, 3, 4)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(274, 27)
        txtFullname.TabIndex = 5
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(23, 500)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(73, 20)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(126, 496)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(228, 27)
        txtPassword.TabIndex = 7
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPasswordHint
        ' 
        lblPasswordHint.AutoSize = True
        lblPasswordHint.ForeColor = Color.Gray
        lblPasswordHint.Location = New Point(126, 532)
        lblPasswordHint.Name = "lblPasswordHint"
        lblPasswordHint.Size = New Size(664, 20)
        lblPasswordHint.TabIndex = 8
        lblPasswordHint.Text = "Min. 8 characters, with letters and numbers. When editing, leave blank to keep the current password"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(389, 500)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(42, 20)
        lblRole.TabIndex = 9
        lblRole.Text = "Role:"
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.FormattingEnabled = True
        cboRole.Location = New Point(491, 496)
        cboRole.Margin = New Padding(3, 4, 3, 4)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(159, 28)
        cboRole.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.White
        btnAdd.FlatAppearance.BorderColor = Color.Silver
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(23, 587)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(137, 51)
        btnAdd.TabIndex = 11
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.White
        btnUpdate.FlatAppearance.BorderColor = Color.Silver
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Location = New Point(171, 587)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(137, 51)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDeactivate
        ' 
        btnDeactivate.BackColor = Color.White
        btnDeactivate.FlatAppearance.BorderColor = Color.Silver
        btnDeactivate.FlatStyle = FlatStyle.Flat
        btnDeactivate.Location = New Point(320, 587)
        btnDeactivate.Margin = New Padding(3, 4, 3, 4)
        btnDeactivate.Name = "btnDeactivate"
        btnDeactivate.Size = New Size(160, 51)
        btnDeactivate.TabIndex = 13
        btnDeactivate.Text = "DEACTIVATE"
        btnDeactivate.UseVisualStyleBackColor = False
        ' 
        ' btnReactivate
        ' 
        btnReactivate.BackColor = Color.White
        btnReactivate.FlatAppearance.BorderColor = Color.Silver
        btnReactivate.FlatStyle = FlatStyle.Flat
        btnReactivate.Location = New Point(491, 587)
        btnReactivate.Margin = New Padding(3, 4, 3, 4)
        btnReactivate.Name = "btnReactivate"
        btnReactivate.Size = New Size(160, 51)
        btnReactivate.TabIndex = 15
        btnReactivate.Text = "REACTIVATE"
        btnReactivate.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.White
        btnClose.FlatAppearance.BorderColor = Color.Silver
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(846, 587)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(137, 51)
        btnClose.TabIndex = 14
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' StaffManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 773)
        Controls.Add(btnClose)
        Controls.Add(btnReactivate)
        Controls.Add(btnDeactivate)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(cboRole)
        Controls.Add(lblRole)
        Controls.Add(lblPasswordHint)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtFullname)
        Controls.Add(lblFullname)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(dgvStaff)
        Controls.Add(btnClearFilter)
        Controls.Add(cboRoleFilter)
        Controls.Add(lblRoleFilter)
        Controls.Add(cboStatusFilter)
        Controls.Add(lblStatusFilter)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "StaffManagementForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff Management"
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusFilter As System.Windows.Forms.Label
    Friend WithEvents cboStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoleFilter As System.Windows.Forms.Label
    Friend WithEvents cboRoleFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnClearFilter As System.Windows.Forms.Button
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordHint As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDeactivate As System.Windows.Forms.Button
    Friend WithEvents btnReactivate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class