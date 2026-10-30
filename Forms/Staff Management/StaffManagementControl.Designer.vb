<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffManagementControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffManagementControl))
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
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtFullName = New TextBox()
        lblPasswordHint = New Label()
        lblRole = New Label()
        cboRole = New ComboBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDeactivate = New Button()
        btnReactivate = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F)
        lblSearch.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblSearch.Location = New Point(15, 83)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(73, 25)
        lblSearch.TabIndex = 16
        lblSearch.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(94, 83)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Username or full name"
        txtSearch.Size = New Size(228, 28)
        txtSearch.TabIndex = 17
        ' 
        ' lblStatusFilter
        ' 
        lblStatusFilter.AutoSize = True
        lblStatusFilter.Font = New Font("Segoe UI", 11.25F)
        lblStatusFilter.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblStatusFilter.Location = New Point(333, 83)
        lblStatusFilter.Name = "lblStatusFilter"
        lblStatusFilter.Size = New Size(66, 25)
        lblStatusFilter.TabIndex = 18
        lblStatusFilter.Text = "Status:"
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Location = New Point(395, 80)
        cboStatusFilter.Margin = New Padding(3, 4, 3, 4)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(148, 28)
        cboStatusFilter.TabIndex = 19
        ' 
        ' lblRoleFilter
        ' 
        lblRoleFilter.AutoSize = True
        lblRoleFilter.Font = New Font("Segoe UI", 11.25F)
        lblRoleFilter.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblRoleFilter.Location = New Point(554, 83)
        lblRoleFilter.Name = "lblRoleFilter"
        lblRoleFilter.Size = New Size(52, 25)
        lblRoleFilter.TabIndex = 20
        lblRoleFilter.Text = "Role:"
        ' 
        ' cboRoleFilter
        ' 
        cboRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoleFilter.FormattingEnabled = True
        cboRoleFilter.Location = New Point(609, 80)
        cboRoleFilter.Margin = New Padding(3, 4, 3, 4)
        cboRoleFilter.Name = "cboRoleFilter"
        cboRoleFilter.Size = New Size(148, 28)
        cboRoleFilter.TabIndex = 21
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnClearFilter.FlatAppearance.BorderColor = Color.Silver
        btnClearFilter.FlatStyle = FlatStyle.Flat
        btnClearFilter.ForeColor = Color.Beige
        btnClearFilter.Location = New Point(771, 81)
        btnClearFilter.Margin = New Padding(3, 4, 3, 4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(97, 31)
        btnClearFilter.TabIndex = 22
        btnClearFilter.Text = "✕ CLEAR"
        btnClearFilter.UseVisualStyleBackColor = False
        ' 
        ' dgvStaff
        ' 
        dgvStaff.AllowUserToAddRows = False
        dgvStaff.AllowUserToDeleteRows = False
        dgvStaff.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStaff.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStaff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStaff.DefaultCellStyle = DataGridViewCellStyle2
        dgvStaff.EnableHeadersVisualStyles = False
        dgvStaff.Location = New Point(15, 123)
        dgvStaff.Margin = New Padding(3, 4, 3, 4)
        dgvStaff.MultiSelect = False
        dgvStaff.Name = "dgvStaff"
        dgvStaff.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvStaff.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvStaff.RowHeadersWidth = 51
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaff.Size = New Size(669, 491)
        dgvStaff.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(9, 52)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 23)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(14, 83)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(285, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblFullname.Location = New Point(9, 120)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(92, 23)
        lblFullname.TabIndex = 4
        lblFullname.Text = "Full Name:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(14, 216)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(285, 27)
        txtPassword.TabIndex = 5
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblPassword.Location = New Point(9, 187)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 23)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(14, 149)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(285, 27)
        txtFullName.TabIndex = 7
        ' 
        ' lblPasswordHint
        ' 
        lblPasswordHint.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPasswordHint.ForeColor = Color.Gray
        lblPasswordHint.Location = New Point(14, 248)
        lblPasswordHint.Name = "lblPasswordHint"
        lblPasswordHint.Size = New Size(280, 40)
        lblPasswordHint.TabIndex = 8
        lblPasswordHint.Text = "Min. 8 chars. When editing, leave blank to keep current password."
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblRole.Location = New Point(14, 292)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(48, 23)
        lblRole.TabIndex = 9
        lblRole.Text = "Role:"
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.FormattingEnabled = True
        cboRole.Location = New Point(14, 319)
        cboRole.Margin = New Padding(3, 4, 3, 4)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(285, 28)
        cboRole.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnAdd.FlatAppearance.BorderColor = Color.Silver
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(697, 493)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(149, 45)
        btnAdd.TabIndex = 11
        btnAdd.Text = "⊕ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUpdate.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnUpdate.FlatAppearance.BorderColor = Color.Silver
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.Beige
        btnUpdate.Location = New Point(863, 493)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(149, 45)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "✎ UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDeactivate
        ' 
        btnDeactivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDeactivate.BackColor = Color.Maroon
        btnDeactivate.FlatAppearance.BorderColor = Color.Silver
        btnDeactivate.FlatStyle = FlatStyle.Flat
        btnDeactivate.ForeColor = Color.Beige
        btnDeactivate.Location = New Point(697, 553)
        btnDeactivate.Margin = New Padding(3, 4, 3, 4)
        btnDeactivate.Name = "btnDeactivate"
        btnDeactivate.Size = New Size(149, 45)
        btnDeactivate.TabIndex = 13
        btnDeactivate.Text = "⊖ DEACTIVATE"
        btnDeactivate.UseVisualStyleBackColor = False
        ' 
        ' btnReactivate
        ' 
        btnReactivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnReactivate.BackColor = Color.AntiqueWhite
        btnReactivate.FlatAppearance.BorderColor = Color.Silver
        btnReactivate.FlatStyle = FlatStyle.Flat
        btnReactivate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnReactivate.Location = New Point(863, 553)
        btnReactivate.Margin = New Padding(3, 4, 3, 4)
        btnReactivate.Name = "btnReactivate"
        btnReactivate.Size = New Size(149, 45)
        btnReactivate.TabIndex = 15
        btnReactivate.Text = "↻ REACTIVATE"
        btnReactivate.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel3.BackColor = Color.AntiqueWhite
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(lblUsername)
        Panel3.Controls.Add(txtUsername)
        Panel3.Controls.Add(lblPassword)
        Panel3.Controls.Add(txtFullName)
        Panel3.Controls.Add(lblFullname)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(lblPasswordHint)
        Panel3.Controls.Add(lblRole)
        Panel3.Controls.Add(cboRole)
        Panel3.Location = New Point(697, 123)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(314, 363)
        Panel3.TabIndex = 25
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(314, 45)
        Panel4.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 15.75F, FontStyle.Bold)
        Label2.ForeColor = Color.Beige
        Label2.Location = New Point(49, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 29)
        Label2.TabIndex = 31
        Label2.Text = "Staff Information"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(21, 7)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 61)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 30
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(120, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(356, 20)
        Label4.TabIndex = 29
        Label4.Text = "Manage staff accounts, roles, and status information."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(115, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 30)
        Label1.TabIndex = 28
        Label1.Text = "Staff Management"
        ' 
        ' StaffManagementControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Controls.Add(btnReactivate)
        Controls.Add(btnDeactivate)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dgvStaff)
        Controls.Add(btnClearFilter)
        Controls.Add(cboRoleFilter)
        Controls.Add(lblRoleFilter)
        Controls.Add(cboStatusFilter)
        Controls.Add(lblStatusFilter)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Margin = New Padding(3, 4, 3, 4)
        Name = "StaffManagementControl"
        Size = New Size(1032, 637)
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblStatusFilter As Label
    Friend WithEvents cboStatusFilter As ComboBox
    Friend WithEvents lblRoleFilter As Label
    Friend WithEvents cboRoleFilter As ComboBox
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblFullname As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPasswordHint As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents btnReactivate As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFullName As TextBox
End Class