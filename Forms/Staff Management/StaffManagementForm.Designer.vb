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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblStatusFilter = New System.Windows.Forms.Label()
        Me.cboStatusFilter = New System.Windows.Forms.ComboBox()
        Me.lblRoleFilter = New System.Windows.Forms.Label()
        Me.cboRoleFilter = New System.Windows.Forms.ComboBox()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPasswordHint = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnReactivate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(20, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Staff Management"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 63)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(48, 15)
        Me.lblSearch.TabIndex = 16
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(75, 60)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Username or full name"
        Me.txtSearch.Size = New System.Drawing.Size(220, 23)
        Me.txtSearch.TabIndex = 17
        '
        'lblStatusFilter
        '
        Me.lblStatusFilter.AutoSize = True
        Me.lblStatusFilter.Location = New System.Drawing.Point(315, 63)
        Me.lblStatusFilter.Name = "lblStatusFilter"
        Me.lblStatusFilter.Size = New System.Drawing.Size(42, 15)
        Me.lblStatusFilter.TabIndex = 18
        Me.lblStatusFilter.Text = "Status:"
        '
        'cboStatusFilter
        '
        Me.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusFilter.FormattingEnabled = True
        Me.cboStatusFilter.Location = New System.Drawing.Point(365, 60)
        Me.cboStatusFilter.Name = "cboStatusFilter"
        Me.cboStatusFilter.Size = New System.Drawing.Size(110, 23)
        Me.cboStatusFilter.TabIndex = 19
        '
        'lblRoleFilter
        '
        Me.lblRoleFilter.AutoSize = True
        Me.lblRoleFilter.Location = New System.Drawing.Point(495, 63)
        Me.lblRoleFilter.Name = "lblRoleFilter"
        Me.lblRoleFilter.Size = New System.Drawing.Size(34, 15)
        Me.lblRoleFilter.TabIndex = 20
        Me.lblRoleFilter.Text = "Role:"
        '
        'cboRoleFilter
        '
        Me.cboRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoleFilter.FormattingEnabled = True
        Me.cboRoleFilter.Location = New System.Drawing.Point(540, 60)
        Me.cboRoleFilter.Name = "cboRoleFilter"
        Me.cboRoleFilter.Size = New System.Drawing.Size(110, 23)
        Me.cboRoleFilter.TabIndex = 21
        '
        'btnClearFilter
        '
        Me.btnClearFilter.BackColor = System.Drawing.Color.White
        Me.btnClearFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilter.Location = New System.Drawing.Point(670, 58)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(100, 27)
        Me.btnClearFilter.TabIndex = 22
        Me.btnClearFilter.Text = "CLEAR"
        Me.btnClearFilter.UseVisualStyleBackColor = False
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.AllowUserToDeleteRows = False
        Me.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(20, 92)
        Me.dgvStaff.MultiSelect = False
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.RowHeadersVisible = False
        Me.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaff.Size = New System.Drawing.Size(840, 212)
        Me.dgvStaff.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(20, 330)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(63, 15)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(110, 327)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 23)
        Me.txtUsername.TabIndex = 3
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Location = New System.Drawing.Point(340, 330)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(62, 15)
        Me.lblFullname.TabIndex = 4
        Me.lblFullname.Text = "Full Name:"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(430, 327)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(240, 23)
        Me.txtFullname.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 375)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 15)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(110, 372)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 23)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPasswordHint
        '
        Me.lblPasswordHint.AutoSize = True
        Me.lblPasswordHint.ForeColor = System.Drawing.Color.Gray
        Me.lblPasswordHint.Location = New System.Drawing.Point(110, 399)
        Me.lblPasswordHint.Name = "lblPasswordHint"
        Me.lblPasswordHint.Size = New System.Drawing.Size(268, 15)
        Me.lblPasswordHint.TabIndex = 8
        Me.lblPasswordHint.Text = "Min. 8 characters, with letters and numbers. When editing, leave blank to keep the current password"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(340, 375)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(34, 15)
        Me.lblRole.TabIndex = 9
        Me.lblRole.Text = "Role:"
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(430, 372)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(140, 23)
        Me.cboRole.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(20, 440)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 38)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(150, 440)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 38)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BackColor = System.Drawing.Color.White
        Me.btnDeactivate.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeactivate.Location = New System.Drawing.Point(280, 440)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(140, 38)
        Me.btnDeactivate.TabIndex = 13
        Me.btnDeactivate.Text = "DEACTIVATE"
        Me.btnDeactivate.UseVisualStyleBackColor = False
        '
        'btnReactivate
        '
        Me.btnReactivate.BackColor = System.Drawing.Color.White
        Me.btnReactivate.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnReactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReactivate.Location = New System.Drawing.Point(430, 440)
        Me.btnReactivate.Name = "btnReactivate"
        Me.btnReactivate.Size = New System.Drawing.Size(140, 38)
        Me.btnReactivate.TabIndex = 15
        Me.btnReactivate.Text = "REACTIVATE"
        Me.btnReactivate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(740, 440)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 38)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'StaffManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 500)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReactivate)
        Me.Controls.Add(Me.btnDeactivate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblPasswordHint)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.btnClearFilter)
        Me.Controls.Add(Me.cboRoleFilter)
        Me.Controls.Add(Me.lblRoleFilter)
        Me.Controls.Add(Me.cboStatusFilter)
        Me.Controls.Add(Me.lblStatusFilter)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StaffManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Management"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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