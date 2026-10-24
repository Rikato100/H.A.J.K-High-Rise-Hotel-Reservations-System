<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        lblTagline = New Label()
        lblHotelName = New Label()
        TabControl1 = New TabControl()
        TabPageDiscounts = New TabPage()
        dgvDiscounts = New DataGridView()
        Panel3 = New Panel()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblSelectDiscount = New Label()
        lblRate = New Label()
        dtpStartDate = New DateTimePicker()
        lblStartDate = New Label()
        numRate = New NumericUpDown()
        btnSaveDiscount = New Button()
        lblNote = New Label()
        lblEndDate = New Label()
        dtpEndDate = New DateTimePicker()
        PictureBox5 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        TabPagePassword = New TabPage()
        Panel6 = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        lblCurrentPwd = New Label()
        txtCurrentPwd = New TextBox()
        lblNewPwd = New Label()
        txtNewPwd = New TextBox()
        lblConfirmPwd = New Label()
        txtConfirmPwd = New TextBox()
        lblPwdHint = New Label()
        btnSavePassword = New Button()
        btnCancelPassword = New Button()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        btnSettings = New Button()
        btnLogout = New Button()
        btnReports = New Button()
        btnStaff = New Button()
        btnDashboard = New Button()
        btnRooms = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPageDiscounts.SuspendLayout()
        CType(dgvDiscounts, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRate, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TabPagePassword.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.Size = New Size(903, 84)
        Panel2.TabIndex = 29
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
        lblTagline.Font = New Font("Monotype Corsiva", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
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
        ' TabControl1
        '
        TabControl1.Controls.Add(TabPageDiscounts)
        TabControl1.Controls.Add(TabPagePassword)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(131, 84)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(903, 478)
        TabControl1.TabIndex = 0
        '
        ' TabPageDiscounts
        '
        TabPageDiscounts.BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        TabPageDiscounts.Controls.Add(dgvDiscounts)
        TabPageDiscounts.Controls.Add(Panel3)
        TabPageDiscounts.Controls.Add(PictureBox5)
        TabPageDiscounts.Controls.Add(Label5)
        TabPageDiscounts.Controls.Add(Label6)
        TabPageDiscounts.Location = New Point(4, 24)
        TabPageDiscounts.Name = "TabPageDiscounts"
        TabPageDiscounts.Padding = New Padding(3)
        TabPageDiscounts.Size = New Size(895, 450)
        TabPageDiscounts.TabIndex = 0
        TabPageDiscounts.Text = "Discount Settings"
        TabPageDiscounts.UseVisualStyleBackColor = True
        '
        ' dgvDiscounts
        '
        dgvDiscounts.BackgroundColor = Color.Beige
        dgvDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDiscounts.Location = New Point(14, 53)
        dgvDiscounts.Name = "dgvDiscounts"
        dgvDiscounts.RowHeadersWidth = 51
        dgvDiscounts.RowTemplate.Height = 24
        dgvDiscounts.Size = New Size(604, 371)
        dgvDiscounts.TabIndex = 1
        '
        ' Panel3
        '
        Panel3.BackColor = Color.AntiqueWhite
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(lblSelectDiscount)
        Panel3.Controls.Add(lblRate)
        Panel3.Controls.Add(dtpStartDate)
        Panel3.Controls.Add(lblStartDate)
        Panel3.Controls.Add(numRate)
        Panel3.Controls.Add(btnSaveDiscount)
        Panel3.Controls.Add(lblNote)
        Panel3.Controls.Add(lblEndDate)
        Panel3.Controls.Add(dtpEndDate)
        Panel3.Location = New Point(631, 53)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(258, 371)
        Panel3.TabIndex = 37
        '
        ' Panel4
        '
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(258, 34)
        Panel4.TabIndex = 12
        '
        ' PictureBox1
        '
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Beige
        Label2.Location = New Point(43, 5)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 24)
        Label2.TabIndex = 31
        Label2.Text = "Discount"
        '
        ' lblSelectDiscount
        '
        lblSelectDiscount.AutoSize = True
        lblSelectDiscount.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSelectDiscount.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblSelectDiscount.Location = New Point(17, 40)
        lblSelectDiscount.Name = "lblSelectDiscount"
        lblSelectDiscount.Size = New Size(167, 20)
        lblSelectDiscount.TabIndex = 2
        lblSelectDiscount.Text = "Select a discount below"
        '
        ' lblRate
        '
        lblRate.AutoSize = True
        lblRate.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblRate.Location = New Point(19, 85)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(54, 15)
        lblRate.TabIndex = 3
        lblRate.Text = "Rate (%):"
        '
        ' dtpStartDate
        '
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(88, 140)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(132, 23)
        dtpStartDate.TabIndex = 7
        '
        ' lblStartDate
        '
        lblStartDate.AutoSize = True
        lblStartDate.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblStartDate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblStartDate.Location = New Point(19, 144)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(61, 15)
        lblStartDate.TabIndex = 6
        lblStartDate.Text = "Start date:"
        '
        ' numRate
        '
        numRate.DecimalPlaces = 2
        numRate.Location = New Point(88, 83)
        numRate.Name = "numRate"
        numRate.Size = New Size(105, 23)
        numRate.TabIndex = 4
        '
        ' btnSaveDiscount
        '
        btnSaveDiscount.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSaveDiscount.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSaveDiscount.ForeColor = Color.Beige
        btnSaveDiscount.Location = New Point(70, 316)
        btnSaveDiscount.Name = "btnSaveDiscount"
        btnSaveDiscount.Size = New Size(114, 38)
        btnSaveDiscount.TabIndex = 11
        btnSaveDiscount.Text = "SAVE CHANGES"
        btnSaveDiscount.UseVisualStyleBackColor = False
        '
        ' lblNote
        '
        lblNote.AutoSize = True
        lblNote.ForeColor = Color.Gray
        lblNote.Location = New Point(18, 276)
        lblNote.Name = "lblNote"
        lblNote.Size = New Size(219, 15)
        lblNote.TabIndex = 10
        lblNote.Text = "Changes apply to new reservations only."
        '
        ' lblEndDate
        '
        lblEndDate.AutoSize = True
        lblEndDate.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblEndDate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblEndDate.Location = New Point(19, 204)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(56, 15)
        lblEndDate.TabIndex = 8
        lblEndDate.Text = "End date:"
        '
        ' dtpEndDate
        '
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(88, 200)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(132, 23)
        dtpEndDate.TabIndex = 9
        '
        ' PictureBox5
        '
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(16, 2)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(82, 46)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 36
        PictureBox5.TabStop = False
        '
        ' Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label5.Location = New Point(109, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(414, 15)
        Label5.TabIndex = 35
        Label5.Text = "Manage discount rates, configure eligibility, and set discount validity periods."
        '
        ' Label6
        '
        Label6.AutoSize = True
        Label6.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label6.Location = New Point(106, 4)
        Label6.Name = "Label6"
        Label6.Size = New Size(191, 24)
        Label6.TabIndex = 34
        Label6.Text = "Discount Settings"
        '
        ' TabPagePassword
        '
        TabPagePassword.BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        TabPagePassword.Controls.Add(Panel6)
        TabPagePassword.Controls.Add(lblCurrentPwd)
        TabPagePassword.Controls.Add(txtCurrentPwd)
        TabPagePassword.Controls.Add(lblNewPwd)
        TabPagePassword.Controls.Add(txtNewPwd)
        TabPagePassword.Controls.Add(lblConfirmPwd)
        TabPagePassword.Controls.Add(txtConfirmPwd)
        TabPagePassword.Controls.Add(lblPwdHint)
        TabPagePassword.Controls.Add(btnSavePassword)
        TabPagePassword.Controls.Add(btnCancelPassword)
        TabPagePassword.Location = New Point(4, 24)
        TabPagePassword.Name = "TabPagePassword"
        TabPagePassword.Padding = New Padding(3)
        TabPagePassword.Size = New Size(895, 450)
        TabPagePassword.TabIndex = 1
        TabPagePassword.Text = "Change Password"
        TabPagePassword.UseVisualStyleBackColor = True
        '
        ' Panel6
        '
        Panel6.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel6.Controls.Add(PictureBox2)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label3)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(3, 3)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(889, 69)
        Panel6.TabIndex = 13
        '
        ' PictureBox2
        '
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 7)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = Color.Beige
        Label1.Location = New Point(102, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 15)
        Label1.TabIndex = 38
        Label1.Text = "Update your account password to help keep your information secure."
        '
        ' Label3
        '
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Beige
        Label3.Location = New Point(98, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 24)
        Label3.TabIndex = 37
        Label3.Text = "Change Password"
        '
        ' lblCurrentPwd
        '
        lblCurrentPwd.AutoSize = True
        lblCurrentPwd.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblCurrentPwd.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblCurrentPwd.Location = New Point(144, 115)
        lblCurrentPwd.Name = "lblCurrentPwd"
        lblCurrentPwd.Size = New Size(167, 25)
        lblCurrentPwd.TabIndex = 1
        lblCurrentPwd.Text = "Current password:"
        '
        ' txtCurrentPwd
        '
        txtCurrentPwd.Location = New Point(394, 118)
        txtCurrentPwd.Name = "txtCurrentPwd"
        txtCurrentPwd.PasswordChar = "*"c
        txtCurrentPwd.Size = New Size(307, 23)
        txtCurrentPwd.TabIndex = 2
        '
        ' lblNewPwd
        '
        lblNewPwd.AutoSize = True
        lblNewPwd.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblNewPwd.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblNewPwd.Location = New Point(144, 175)
        lblNewPwd.Name = "lblNewPwd"
        lblNewPwd.Size = New Size(141, 25)
        lblNewPwd.TabIndex = 3
        lblNewPwd.Text = "New password:"
        '
        ' txtNewPwd
        '
        txtNewPwd.Location = New Point(394, 179)
        txtNewPwd.Name = "txtNewPwd"
        txtNewPwd.PasswordChar = "*"c
        txtNewPwd.Size = New Size(307, 23)
        txtNewPwd.TabIndex = 4
        '
        ' lblConfirmPwd
        '
        lblConfirmPwd.AutoSize = True
        lblConfirmPwd.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblConfirmPwd.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblConfirmPwd.Location = New Point(144, 235)
        lblConfirmPwd.Name = "lblConfirmPwd"
        lblConfirmPwd.Size = New Size(212, 25)
        lblConfirmPwd.TabIndex = 5
        lblConfirmPwd.Text = "Confirm new password:"
        '
        ' txtConfirmPwd
        '
        txtConfirmPwd.Location = New Point(394, 239)
        txtConfirmPwd.Name = "txtConfirmPwd"
        txtConfirmPwd.PasswordChar = "*"c
        txtConfirmPwd.Size = New Size(307, 23)
        txtConfirmPwd.TabIndex = 6
        '
        ' lblPwdHint
        '
        lblPwdHint.AutoSize = True
        lblPwdHint.ForeColor = Color.Gray
        lblPwdHint.Location = New Point(394, 273)
        lblPwdHint.Name = "lblPwdHint"
        lblPwdHint.Size = New Size(237, 15)
        lblPwdHint.TabIndex = 7
        lblPwdHint.Text = "Min. 8 characters, with letters and numbers."
        '
        ' btnSavePassword
        '
        btnSavePassword.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSavePassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSavePassword.ForeColor = Color.Beige
        btnSavePassword.Location = New Point(394, 310)
        btnSavePassword.Name = "btnSavePassword"
        btnSavePassword.Size = New Size(140, 38)
        btnSavePassword.TabIndex = 8
        btnSavePassword.Text = "SAVE"
        btnSavePassword.UseVisualStyleBackColor = False
        '
        ' btnCancelPassword
        '
        btnCancelPassword.BackColor = Color.Beige
        btnCancelPassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnCancelPassword.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCancelPassword.Location = New Point(560, 310)
        btnCancelPassword.Name = "btnCancelPassword"
        btnCancelPassword.Size = New Size(140, 38)
        btnCancelPassword.TabIndex = 9
        btnCancelPassword.Text = "CANCEL"
        btnCancelPassword.UseVisualStyleBackColor = False
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
        Panel1.Size = New Size(131, 562)
        Panel1.TabIndex = 28
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
        ' SettingsForm
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1034, 562)
        Controls.Add(TabControl1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "SettingsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "System Settings"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPageDiscounts.ResumeLayout(False)
        TabPageDiscounts.PerformLayout()
        CType(dgvDiscounts, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(numRate, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TabPagePassword.ResumeLayout(False)
        TabPagePassword.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDiscounts As TabPage
    Friend WithEvents TabPagePassword As TabPage
    Friend WithEvents dgvDiscounts As DataGridView
    Friend WithEvents lblSelectDiscount As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents numRate As NumericUpDown
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblNote As Label
    Friend WithEvents btnSaveDiscount As Button
    Friend WithEvents lblCurrentPwd As Label
    Friend WithEvents txtCurrentPwd As TextBox
    Friend WithEvents lblNewPwd As Label
    Friend WithEvents txtNewPwd As TextBox
    Friend WithEvents lblConfirmPwd As Label
    Friend WithEvents txtConfirmPwd As TextBox
    Friend WithEvents lblPwdHint As Label
    Friend WithEvents btnSavePassword As Button
    Friend WithEvents btnCancelPassword As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblHotelName As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class