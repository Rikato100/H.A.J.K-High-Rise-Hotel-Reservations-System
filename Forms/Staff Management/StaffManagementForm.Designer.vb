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
        Dim Panel2 As Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffManagementForm))
        PictureBox4 = New PictureBox()
        lblTagline = New Label()
        lblHotelName = New Label()
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
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        btnSettings = New Button()
        btnLogout = New Button()
        btnReports = New Button()
        btnStaff = New Button()
        btnDashboard = New Button()
        btnRooms = New Button()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(lblTagline)
        Panel2.Controls.Add(lblHotelName)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(131, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(898, 84)
        Panel2.TabIndex = 27
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(446, 0)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(457, 84)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' lblTagline
        ' 
        lblTagline.AutoSize = True
        lblTagline.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Color.Beige
        lblTagline.Location = New Point(11, 44)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(220, 18)
        lblTagline.TabIndex = 15
        lblTagline.Text = "Where every stay feels extraordinary"
        ' 
        ' lblHotelName
        ' 
        lblHotelName.AutoSize = True
        lblHotelName.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold)
        lblHotelName.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblHotelName.Location = New Point(6, 9)
        lblHotelName.Name = "lblHotelName"
        lblHotelName.Size = New Size(326, 32)
        lblHotelName.TabIndex = 0
        lblHotelName.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F)
        lblSearch.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblSearch.Location = New Point(144, 146)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(56, 20)
        lblSearch.TabIndex = 16
        lblSearch.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(213, 146)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Username or full name"
        txtSearch.Size = New Size(235, 22)
        txtSearch.TabIndex = 17
        ' 
        ' lblStatusFilter
        ' 
        lblStatusFilter.AutoSize = True
        lblStatusFilter.Font = New Font("Segoe UI", 11.25F)
        lblStatusFilter.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblStatusFilter.Location = New Point(452, 146)
        lblStatusFilter.Name = "lblStatusFilter"
        lblStatusFilter.Size = New Size(52, 20)
        lblStatusFilter.TabIndex = 18
        lblStatusFilter.Text = "Status:"
        ' 
        ' cboStatusFilter
        ' 
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusFilter.FormattingEnabled = True
        cboStatusFilter.Location = New Point(507, 144)
        cboStatusFilter.Name = "cboStatusFilter"
        cboStatusFilter.Size = New Size(150, 23)
        cboStatusFilter.TabIndex = 19
        ' 
        ' lblRoleFilter
        ' 
        lblRoleFilter.AutoSize = True
        lblRoleFilter.Font = New Font("Segoe UI", 11.25F)
        lblRoleFilter.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblRoleFilter.Location = New Point(670, 146)
        lblRoleFilter.Name = "lblRoleFilter"
        lblRoleFilter.Size = New Size(42, 20)
        lblRoleFilter.TabIndex = 20
        lblRoleFilter.Text = "Role:"
        ' 
        ' cboRoleFilter
        ' 
        cboRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoleFilter.FormattingEnabled = True
        cboRoleFilter.Location = New Point(721, 144)
        cboRoleFilter.Name = "cboRoleFilter"
        cboRoleFilter.Size = New Size(150, 23)
        cboRoleFilter.TabIndex = 21
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnClearFilter.FlatAppearance.BorderColor = Color.Silver
        btnClearFilter.FlatStyle = FlatStyle.Flat
        btnClearFilter.ForeColor = Color.Beige
        btnClearFilter.Location = New Point(907, 146)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(111, 22)
        btnClearFilter.TabIndex = 22
        btnClearFilter.Text = "✕ CLEAR"
        btnClearFilter.UseVisualStyleBackColor = False
        ' 
        ' dgvStaff
        ' 
        dgvStaff.AllowUserToAddRows = False
        dgvStaff.AllowUserToDeleteRows = False
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStaff.BackgroundColor = Color.White
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaff.Location = New Point(143, 176)
        dgvStaff.MultiSelect = False
        dgvStaff.Name = "dgvStaff"
        dgvStaff.ReadOnly = True
        dgvStaff.RowHeadersVisible = False
        dgvStaff.RowHeadersWidth = 51
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaff.Size = New Size(572, 350)
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
        txtUsername.Size = New Size(260, 23)
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
        txtPassword.Size = New Size(260, 23)
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
        txtFullName.Size = New Size(260, 23)
        txtFullName.TabIndex = 7
        ' 
        ' lblPasswordHint
        ' 
        lblPasswordHint.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPasswordHint.ForeColor = Color.Gray
        lblPasswordHint.Location = New Point(12, 186)
        lblPasswordHint.Name = "lblPasswordHint"
        lblPasswordHint.Size = New Size(250, 30)
        lblPasswordHint.TabIndex = 8
        lblPasswordHint.Text = "Min. 8 characters, with letters and numbers." & vbLf & "When editing, leave blank to keep the current password."
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
        cboRole.Size = New Size(260, 23)
        cboRole.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnAdd.FlatAppearance.BorderColor = Color.Silver
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(731, 452)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(140, 34)
        btnAdd.TabIndex = 11
        btnAdd.Text = "⊕ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnUpdate.FlatAppearance.BorderColor = Color.Silver
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.Beige
        btnUpdate.Location = New Point(890, 453)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(128, 34)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "✎ UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDeactivate
        ' 
        btnDeactivate.BackColor = Color.Maroon
        btnDeactivate.FlatAppearance.BorderColor = Color.Silver
        btnDeactivate.FlatStyle = FlatStyle.Flat
        btnDeactivate.ForeColor = Color.Beige
        btnDeactivate.Location = New Point(731, 492)
        btnDeactivate.Name = "btnDeactivate"
        btnDeactivate.Size = New Size(140, 34)
        btnDeactivate.TabIndex = 13
        btnDeactivate.Text = "⊖ DEACTIVATE"
        btnDeactivate.UseVisualStyleBackColor = False
        ' 
        ' btnReactivate
        ' 
        btnReactivate.BackColor = Color.AntiqueWhite
        btnReactivate.FlatAppearance.BorderColor = Color.Silver
        btnReactivate.FlatStyle = FlatStyle.Flat
        btnReactivate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnReactivate.Location = New Point(890, 492)
        btnReactivate.Name = "btnReactivate"
        btnReactivate.Size = New Size(128, 34)
        btnReactivate.TabIndex = 15
        btnReactivate.Text = "↻ REACTIVATE"
        btnReactivate.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
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
        Panel3.Location = New Point(731, 176)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(287, 272)
        Panel3.TabIndex = 25
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(287, 34)
        Panel4.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Beige
        Label2.Location = New Point(43, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 24)
        Label2.TabIndex = 31
        Label2.Text = "Staff Information"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnStaff)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnRooms)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 555)
        Panel1.TabIndex = 26
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 6)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(109, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.Transparent
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Mongolian Baiti", 11.25F)
        btnSettings.ForeColor = Color.Beige
        btnSettings.Location = New Point(3, 252)
        btnSettings.Margin = New Padding(3, 2, 3, 2)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(126, 42)
        btnSettings.TabIndex = 5
        btnSettings.Text = "⚙ Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Mongolian Baiti", 11.25F)
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 406)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(126, 42)
        btnLogout.TabIndex = 9
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Transparent
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Mongolian Baiti", 11.25F)
        btnReports.ForeColor = Color.Beige
        btnReports.Location = New Point(3, 210)
        btnReports.Margin = New Padding(3, 2, 3, 2)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(126, 42)
        btnReports.TabIndex = 2
        btnReports.Text = "📊 Reports "
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.Transparent
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Mongolian Baiti", 11.25F)
        btnStaff.ForeColor = Color.Beige
        btnStaff.Location = New Point(3, 168)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(126, 42)
        btnStaff.TabIndex = 8
        btnStaff.Text = "👥 Staff Management"
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.Beige
        btnDashboard.Location = New Point(3, 85)
        btnDashboard.Margin = New Padding(3, 2, 3, 2)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(126, 42)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "🏠 Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnRooms
        ' 
        btnRooms.BackColor = Color.Transparent
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRooms.ForeColor = Color.Beige
        btnRooms.Location = New Point(3, 126)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(126, 42)
        btnRooms.TabIndex = 2
        btnRooms.Text = "🛏 Rooms Management"
        btnRooms.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(143, 85)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
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
        Label4.Location = New Point(236, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(414, 15)
        Label4.TabIndex = 29
        Label4.Text = "Manage guest information, update guest details, and keep records organized."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(233, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 24)
        Label1.TabIndex = 28
        Label1.Text = "Staff Management"
        ' 
        ' StaffManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1029, 555)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
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
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "StaffManagementForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Staff Management"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
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
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordHint As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDeactivate As System.Windows.Forms.Button
    Friend WithEvents btnReactivate As System.Windows.Forms.Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblHotelName As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFullName As TextBox

End Class