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
        lblSearch.Location = New Point(13, 62)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(56, 20)
        lblSearch.TabIndex = 16
        lblSearch.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(82, 62)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Username or full name"
        txtSearch.Size = New Size(200, 22)
        txtSearch.TabIndex = 17
        ' 
        ' lblStatusFilter
        ' 
        lblStatusFilter.AutoSize = True
        lblStatusFilter.Font = New Font("Segoe UI", 11.25F)
        lblStatusFilter.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblStatusFilter.Location = New Point(291, 62)
        lblStatusFilter.Name = "lblStatusFilter"
        lblStatusFilter.Size = New Size(52, 20)
        lblStatusFilter.TabIndex = 18
        lblStatusFilter.Text = "Status:"
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Location = New Point(346, 60)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(130, 23)
        cboStatusFilter.TabIndex = 19
        ' 
        ' lblRoleFilter
        ' 
        lblRoleFilter.AutoSize = True
        lblRoleFilter.Font = New Font("Segoe UI", 11.25F)
        lblRoleFilter.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblRoleFilter.Location = New Point(485, 62)
        lblRoleFilter.Name = "lblRoleFilter"
        lblRoleFilter.Size = New Size(42, 20)
        lblRoleFilter.TabIndex = 20
        lblRoleFilter.Text = "Role:"
        ' 
        ' cboRoleFilter
        ' 
        cboRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoleFilter.FormattingEnabled = True
        cboRoleFilter.Location = New Point(533, 60)
        cboRoleFilter.Name = "cboRoleFilter"
        cboRoleFilter.Size = New Size(130, 23)
        cboRoleFilter.TabIndex = 21
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnClearFilter.FlatAppearance.BorderColor = Color.Silver
        btnClearFilter.FlatStyle = FlatStyle.Flat
        btnClearFilter.ForeColor = Color.Beige
        btnClearFilter.Location = New Point(675, 61)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(85, 23)
        btnClearFilter.TabIndex = 22
        btnClearFilter.Text = "✕ CLEAR"
        btnClearFilter.UseVisualStyleBackColor = False
        ' 
        ' dgvStaff
        ' 
        dgvStaff.AllowUserToAddRows = False
        dgvStaff.AllowUserToDeleteRows = False
        dgvStaff.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles)
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStaff.BackgroundColor = Color.White
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaff.Location = New Point(13, 92)
        dgvStaff.MultiSelect = False
        dgvStaff.Name = "dgvStaff"
        dgvStaff.ReadOnly = True
        dgvStaff.RowHeadersVisible = False
        dgvStaff.RowHeadersWidth = 51
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaff.Size = New Size(585, 368)
        dgvStaff.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(8, 39)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(74, 19)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(12, 62)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(250, 23)
        txtUsername.TabIndex = 3
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblFullname.Location = New Point(8, 90)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(76, 19)
        lblFullname.TabIndex = 4
        lblFullname.Text = "Full Name:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(12, 162)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(250, 23)
        txtPassword.TabIndex = 5
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblPassword.Location = New Point(8, 140)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(71, 19)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(12, 112)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(250, 23)
        txtFullName.TabIndex = 7
        ' 
        ' lblPasswordHint
        ' 
        lblPasswordHint.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPasswordHint.ForeColor = Color.Gray
        lblPasswordHint.Location = New Point(12, 186)
        lblPasswordHint.Name = "lblPasswordHint"
        lblPasswordHint.Size = New Size(245, 30)
        lblPasswordHint.TabIndex = 8
        lblPasswordHint.Text = "Min. 8 chars. When editing, leave blank to keep current password."
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblRole.Location = New Point(12, 219)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(40, 19)
        lblRole.TabIndex = 9
        lblRole.Text = "Role:"
        ' 
        ' cboRole
        ' 
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.FormattingEnabled = True
        cboRole.Location = New Point(12, 239)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(250, 23)
        cboRole.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        btnAdd.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnAdd.FlatAppearance.BorderColor = Color.Silver
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(610, 370)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(130, 34)
        btnAdd.TabIndex = 11
        btnAdd.Text = "⊕ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        btnUpdate.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnUpdate.FlatAppearance.BorderColor = Color.Silver
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.Beige
        btnUpdate.Location = New Point(755, 370)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(130, 34)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "✎ UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDeactivate
        ' 
        btnDeactivate.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        btnDeactivate.BackColor = Color.Maroon
        btnDeactivate.FlatAppearance.BorderColor = Color.Silver
        btnDeactivate.FlatStyle = FlatStyle.Flat
        btnDeactivate.ForeColor = Color.Beige
        btnDeactivate.Location = New Point(610, 415)
        btnDeactivate.Name = "btnDeactivate"
        btnDeactivate.Size = New Size(130, 34)
        btnDeactivate.TabIndex = 13
        btnDeactivate.Text = "⊖ DEACTIVATE"
        btnDeactivate.UseVisualStyleBackColor = False
        ' 
        ' btnReactivate
        ' 
        btnReactivate.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
        btnReactivate.BackColor = Color.AntiqueWhite
        btnReactivate.FlatAppearance.BorderColor = Color.Silver
        btnReactivate.FlatStyle = FlatStyle.Flat
        btnReactivate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnReactivate.Location = New Point(755, 415)
        btnReactivate.Name = "btnReactivate"
        btnReactivate.Size = New Size(130, 34)
        btnReactivate.TabIndex = 15
        btnReactivate.Text = "↻ REACTIVATE"
        btnReactivate.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles)
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
        Panel3.Location = New Point(610, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(275, 272)
        Panel3.TabIndex = 25
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(275, 34)
        Panel4.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 15.75F, FontStyle.Bold)
        Label2.ForeColor = Color.Beige
        Label2.Location = New Point(43, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 23)
        Label2.TabIndex = 31
        Label2.Text = "Staff Information"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 30
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(105, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(307, 15)
        Label4.TabIndex = 29
        Label4.Text = "Manage staff accounts, roles, and status information."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(101, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 24)
        Label1.TabIndex = 28
        Label1.Text = "Staff Management"
        ' 
        ' StaffManagementControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        Name = "StaffManagementControl"
        Size = New Size(903, 478)
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