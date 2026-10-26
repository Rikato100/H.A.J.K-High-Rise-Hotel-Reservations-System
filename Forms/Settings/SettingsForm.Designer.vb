<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsControl))
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
        TabPageReset = New TabPage()
        PanelResetHeader = New Panel()
        PictureBox3 = New PictureBox()
        LabelResetDesc = New Label()
        LabelResetTitle = New Label()
        grpResetConfig = New GroupBox()
        rbFactoryReset = New RadioButton()
        rbSelectiveReset = New RadioButton()
        lblResetStartDate = New Label()
        dtpResetStartDate = New DateTimePicker()
        lblResetEndDate = New Label()
        dtpResetEndDate = New DateTimePicker()
        chkDeleteGuestHistory = New CheckBox()
        chkDeleteFinancial = New CheckBox()
        chkResetRoomStatus = New CheckBox()
        lblAdminPwdConfirm = New Label()
        txtAdminPwdConfirm = New TextBox()
        btnExecuteReset = New Button()
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
        TabPageReset.SuspendLayout()
        PanelResetHeader.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        grpResetConfig.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPageDiscounts)
        TabControl1.Controls.Add(TabPagePassword)
        TabControl1.Controls.Add(TabPageReset)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(3, 2, 3, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(903, 500)
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
        TabPageDiscounts.Margin = New Padding(3, 2, 3, 2)
        TabPageDiscounts.Name = "TabPageDiscounts"
        TabPageDiscounts.Padding = New Padding(3, 2, 3, 2)
        TabPageDiscounts.Size = New Size(895, 472)
        TabPageDiscounts.TabIndex = 0
        TabPageDiscounts.Text = "Discount Settings"
        ' 
        ' dgvDiscounts
        ' 
        dgvDiscounts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDiscounts.BackgroundColor = Color.Beige
        dgvDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDiscounts.Location = New Point(12, 52)
        dgvDiscounts.Margin = New Padding(3, 2, 3, 2)
        dgvDiscounts.Name = "dgvDiscounts"
        dgvDiscounts.ReadOnly = True
        dgvDiscounts.RowHeadersWidth = 51
        dgvDiscounts.RowTemplate.Height = 24
        dgvDiscounts.Size = New Size(590, 278)
        dgvDiscounts.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
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
        Panel3.Location = New Point(623, 52)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(248, 278)
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
        Panel4.Size = New Size(248, 26)
        Panel4.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 21)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Beige
        Label2.Location = New Point(38, 4)
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
        lblSelectDiscount.Location = New Point(15, 30)
        lblSelectDiscount.Name = "lblSelectDiscount"
        lblSelectDiscount.Size = New Size(167, 20)
        lblSelectDiscount.TabIndex = 2
        lblSelectDiscount.Text = "Select a discount below"
        ' 
        ' lblRate
        ' 
        lblRate.AutoSize = True
        lblRate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblRate.Location = New Point(38, 65)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(54, 15)
        lblRate.TabIndex = 3
        lblRate.Text = "Rate (%):"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(104, 106)
        dtpStartDate.Margin = New Padding(3, 2, 3, 2)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(116, 23)
        dtpStartDate.TabIndex = 7
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblStartDate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblStartDate.Location = New Point(38, 110)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(61, 15)
        lblStartDate.TabIndex = 6
        lblStartDate.Text = "Start date:"
        ' 
        ' numRate
        ' 
        numRate.DecimalPlaces = 2
        numRate.Location = New Point(104, 64)
        numRate.Margin = New Padding(3, 2, 3, 2)
        numRate.Name = "numRate"
        numRate.Size = New Size(92, 23)
        numRate.TabIndex = 4
        ' 
        ' btnSaveDiscount
        ' 
        btnSaveDiscount.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSaveDiscount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSaveDiscount.ForeColor = Color.Beige
        btnSaveDiscount.Location = New Point(61, 238)
        btnSaveDiscount.Margin = New Padding(3, 2, 3, 2)
        btnSaveDiscount.Name = "btnSaveDiscount"
        btnSaveDiscount.Size = New Size(137, 28)
        btnSaveDiscount.TabIndex = 11
        btnSaveDiscount.Text = "SAVE CHANGES"
        btnSaveDiscount.UseVisualStyleBackColor = False
        ' 
        ' lblNote
        ' 
        lblNote.AutoSize = True
        lblNote.ForeColor = Color.Gray
        lblNote.Location = New Point(3, 197)
        lblNote.Name = "lblNote"
        lblNote.Size = New Size(219, 15)
        lblNote.TabIndex = 10
        lblNote.Text = "Changes apply to new reservations only."
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblEndDate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblEndDate.Location = New Point(38, 154)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(56, 15)
        lblEndDate.TabIndex = 8
        lblEndDate.Text = "End date:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(104, 152)
        dtpEndDate.Margin = New Padding(3, 2, 3, 2)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(116, 23)
        dtpEndDate.TabIndex = 9
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(14, 2)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(74, 47)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 36
        PictureBox5.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label5.Location = New Point(95, 31)
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
        Label6.Location = New Point(93, 3)
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
        TabPagePassword.Margin = New Padding(3, 2, 3, 2)
        TabPagePassword.Name = "TabPagePassword"
        TabPagePassword.Padding = New Padding(3, 2, 3, 2)
        TabPagePassword.Size = New Size(895, 472)
        TabPagePassword.TabIndex = 1
        TabPagePassword.Text = "Change Password"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel6.Controls.Add(PictureBox2)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label3)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(3, 2)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(889, 52)
        Panel6.TabIndex = 13
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(14, 2)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(74, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Beige
        Label1.Location = New Point(95, 31)
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
        Label3.Location = New Point(93, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 24)
        Label3.TabIndex = 37
        Label3.Text = "Change Password"
        ' 
        ' lblCurrentPwd
        ' 
        lblCurrentPwd.AutoSize = True
        lblCurrentPwd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCurrentPwd.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblCurrentPwd.Location = New Point(17, 73)
        lblCurrentPwd.Name = "lblCurrentPwd"
        lblCurrentPwd.Size = New Size(143, 21)
        lblCurrentPwd.TabIndex = 1
        lblCurrentPwd.Text = "Current password:"
        ' 
        ' txtCurrentPwd
        ' 
        txtCurrentPwd.Location = New Point(235, 75)
        txtCurrentPwd.Margin = New Padding(3, 2, 3, 2)
        txtCurrentPwd.Name = "txtCurrentPwd"
        txtCurrentPwd.PasswordChar = "*"c
        txtCurrentPwd.Size = New Size(269, 23)
        txtCurrentPwd.TabIndex = 2
        ' 
        ' lblNewPwd
        ' 
        lblNewPwd.AutoSize = True
        lblNewPwd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblNewPwd.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblNewPwd.Location = New Point(17, 118)
        lblNewPwd.Name = "lblNewPwd"
        lblNewPwd.Size = New Size(121, 21)
        lblNewPwd.TabIndex = 3
        lblNewPwd.Text = "New password:"
        ' 
        ' txtNewPwd
        ' 
        txtNewPwd.Location = New Point(235, 121)
        txtNewPwd.Margin = New Padding(3, 2, 3, 2)
        txtNewPwd.Name = "txtNewPwd"
        txtNewPwd.PasswordChar = "*"c
        txtNewPwd.Size = New Size(269, 23)
        txtNewPwd.TabIndex = 4
        ' 
        ' lblConfirmPwd
        ' 
        lblConfirmPwd.AutoSize = True
        lblConfirmPwd.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblConfirmPwd.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblConfirmPwd.Location = New Point(17, 163)
        lblConfirmPwd.Name = "lblConfirmPwd"
        lblConfirmPwd.Size = New Size(181, 21)
        lblConfirmPwd.TabIndex = 5
        lblConfirmPwd.Text = "Confirm new password:"
        ' 
        ' txtConfirmPwd
        ' 
        txtConfirmPwd.Location = New Point(235, 166)
        txtConfirmPwd.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPwd.Name = "txtConfirmPwd"
        txtConfirmPwd.PasswordChar = "*"c
        txtConfirmPwd.Size = New Size(269, 23)
        txtConfirmPwd.TabIndex = 6
        ' 
        ' lblPwdHint
        ' 
        lblPwdHint.AutoSize = True
        lblPwdHint.ForeColor = Color.Gray
        lblPwdHint.Location = New Point(235, 191)
        lblPwdHint.Name = "lblPwdHint"
        lblPwdHint.Size = New Size(237, 15)
        lblPwdHint.TabIndex = 7
        lblPwdHint.Text = "Min. 8 characters, with letters and numbers."
        ' 
        ' btnSavePassword
        ' 
        btnSavePassword.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSavePassword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSavePassword.ForeColor = Color.Beige
        btnSavePassword.Location = New Point(236, 322)
        btnSavePassword.Margin = New Padding(3, 2, 3, 2)
        btnSavePassword.Name = "btnSavePassword"
        btnSavePassword.Size = New Size(122, 28)
        btnSavePassword.TabIndex = 8
        btnSavePassword.Text = "SAVE"
        btnSavePassword.UseVisualStyleBackColor = False
        ' 
        ' btnCancelPassword
        ' 
        btnCancelPassword.BackColor = Color.Beige
        btnCancelPassword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnCancelPassword.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCancelPassword.Location = New Point(382, 322)
        btnCancelPassword.Margin = New Padding(3, 2, 3, 2)
        btnCancelPassword.Name = "btnCancelPassword"
        btnCancelPassword.Size = New Size(122, 28)
        btnCancelPassword.TabIndex = 9
        btnCancelPassword.Text = "CANCEL"
        btnCancelPassword.UseVisualStyleBackColor = False
        ' 
        ' TabPageReset
        ' 
        TabPageReset.AutoScroll = True
        TabPageReset.BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        TabPageReset.Controls.Add(PanelResetHeader)
        TabPageReset.Controls.Add(grpResetConfig)
        TabPageReset.Location = New Point(4, 24)
        TabPageReset.Margin = New Padding(3, 2, 3, 2)
        TabPageReset.Name = "TabPageReset"
        TabPageReset.Padding = New Padding(3, 2, 3, 2)
        TabPageReset.Size = New Size(895, 472)
        TabPageReset.TabIndex = 2
        TabPageReset.Text = "System Reset"
        ' 
        ' PanelResetHeader
        ' 
        PanelResetHeader.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        PanelResetHeader.Controls.Add(PictureBox3)
        PanelResetHeader.Controls.Add(LabelResetDesc)
        PanelResetHeader.Controls.Add(LabelResetTitle)
        PanelResetHeader.Dock = DockStyle.Top
        PanelResetHeader.Location = New Point(3, 2)
        PanelResetHeader.Margin = New Padding(3, 2, 3, 2)
        PanelResetHeader.Name = "PanelResetHeader"
        PanelResetHeader.Size = New Size(889, 52)
        PanelResetHeader.TabIndex = 14
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(14, 2)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(74, 47)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 40
        PictureBox3.TabStop = False
        ' 
        ' LabelResetDesc
        ' 
        LabelResetDesc.AutoSize = True
        LabelResetDesc.ForeColor = Color.Beige
        LabelResetDesc.Location = New Point(95, 31)
        LabelResetDesc.Name = "LabelResetDesc"
        LabelResetDesc.Size = New Size(301, 15)
        LabelResetDesc.TabIndex = 38
        LabelResetDesc.Text = "Perform factory resets or wipe transaction logs securely."
        ' 
        ' LabelResetTitle
        ' 
        LabelResetTitle.AutoSize = True
        LabelResetTitle.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        LabelResetTitle.ForeColor = Color.Beige
        LabelResetTitle.Location = New Point(93, 3)
        LabelResetTitle.Name = "LabelResetTitle"
        LabelResetTitle.Size = New Size(146, 24)
        LabelResetTitle.TabIndex = 37
        LabelResetTitle.Text = "System Reset"
        ' 
        ' grpResetConfig
        ' 
        grpResetConfig.Controls.Add(rbFactoryReset)
        grpResetConfig.Controls.Add(rbSelectiveReset)
        grpResetConfig.Controls.Add(lblResetStartDate)
        grpResetConfig.Controls.Add(dtpResetStartDate)
        grpResetConfig.Controls.Add(lblResetEndDate)
        grpResetConfig.Controls.Add(dtpResetEndDate)
        grpResetConfig.Controls.Add(chkDeleteGuestHistory)
        grpResetConfig.Controls.Add(chkDeleteFinancial)
        grpResetConfig.Controls.Add(chkResetRoomStatus)
        grpResetConfig.Controls.Add(lblAdminPwdConfirm)
        grpResetConfig.Controls.Add(txtAdminPwdConfirm)
        grpResetConfig.Controls.Add(btnExecuteReset)
        grpResetConfig.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        grpResetConfig.Location = New Point(126, 68)
        grpResetConfig.Margin = New Padding(3, 2, 3, 2)
        grpResetConfig.Name = "grpResetConfig"
        grpResetConfig.Padding = New Padding(3, 2, 3, 2)
        grpResetConfig.Size = New Size(542, 322)
        grpResetConfig.TabIndex = 0
        grpResetConfig.TabStop = False
        grpResetConfig.Text = "Reset Configuration"
        ' 
        ' rbFactoryReset
        ' 
        rbFactoryReset.AutoSize = True
        rbFactoryReset.Checked = True
        rbFactoryReset.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        rbFactoryReset.Location = New Point(22, 26)
        rbFactoryReset.Margin = New Padding(3, 2, 3, 2)
        rbFactoryReset.Name = "rbFactoryReset"
        rbFactoryReset.Size = New Size(216, 19)
        rbFactoryReset.TabIndex = 0
        rbFactoryReset.TabStop = True
        rbFactoryReset.Text = "Factory Reset (Wipe all transactions)"
        rbFactoryReset.UseVisualStyleBackColor = True
        ' 
        ' rbSelectiveReset
        ' 
        rbSelectiveReset.AutoSize = True
        rbSelectiveReset.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        rbSelectiveReset.Location = New Point(22, 56)
        rbSelectiveReset.Margin = New Padding(3, 2, 3, 2)
        rbSelectiveReset.Name = "rbSelectiveReset"
        rbSelectiveReset.Size = New Size(191, 19)
        rbSelectiveReset.TabIndex = 1
        rbSelectiveReset.Text = "Selective Reset (By Date Range)"
        rbSelectiveReset.UseVisualStyleBackColor = True
        ' 
        ' lblResetStartDate
        ' 
        lblResetStartDate.AutoSize = True
        lblResetStartDate.Location = New Point(39, 82)
        lblResetStartDate.Name = "lblResetStartDate"
        lblResetStartDate.Size = New Size(61, 15)
        lblResetStartDate.TabIndex = 2
        lblResetStartDate.Text = "Start Date:"
        ' 
        ' dtpResetStartDate
        ' 
        dtpResetStartDate.Format = DateTimePickerFormat.Short
        dtpResetStartDate.Location = New Point(109, 79)
        dtpResetStartDate.Margin = New Padding(3, 2, 3, 2)
        dtpResetStartDate.Name = "dtpResetStartDate"
        dtpResetStartDate.Size = New Size(114, 23)
        dtpResetStartDate.TabIndex = 3
        ' 
        ' lblResetEndDate
        ' 
        lblResetEndDate.AutoSize = True
        lblResetEndDate.Location = New Point(245, 82)
        lblResetEndDate.Name = "lblResetEndDate"
        lblResetEndDate.Size = New Size(57, 15)
        lblResetEndDate.TabIndex = 4
        lblResetEndDate.Text = "End Date:"
        ' 
        ' dtpResetEndDate
        ' 
        dtpResetEndDate.Format = DateTimePickerFormat.Short
        dtpResetEndDate.Location = New Point(311, 79)
        dtpResetEndDate.Margin = New Padding(3, 2, 3, 2)
        dtpResetEndDate.Name = "dtpResetEndDate"
        dtpResetEndDate.Size = New Size(114, 23)
        dtpResetEndDate.TabIndex = 5
        ' 
        ' chkDeleteGuestHistory
        ' 
        chkDeleteGuestHistory.AutoSize = True
        chkDeleteGuestHistory.Location = New Point(22, 112)
        chkDeleteGuestHistory.Margin = New Padding(3, 2, 3, 2)
        chkDeleteGuestHistory.Name = "chkDeleteGuestHistory"
        chkDeleteGuestHistory.Size = New Size(204, 19)
        chkDeleteGuestHistory.TabIndex = 6
        chkDeleteGuestHistory.Text = "Delete Guest History (Date Range)"
        chkDeleteGuestHistory.UseVisualStyleBackColor = True
        ' 
        ' chkDeleteFinancial
        ' 
        chkDeleteFinancial.AutoSize = True
        chkDeleteFinancial.Location = New Point(22, 139)
        chkDeleteFinancial.Margin = New Padding(3, 2, 3, 2)
        chkDeleteFinancial.Name = "chkDeleteFinancial"
        chkDeleteFinancial.Size = New Size(237, 19)
        chkDeleteFinancial.TabIndex = 7
        chkDeleteFinancial.Text = "Delete Financial and Billing Transactions"
        chkDeleteFinancial.UseVisualStyleBackColor = True
        ' 
        ' chkResetRoomStatus
        ' 
        chkResetRoomStatus.AutoSize = True
        chkResetRoomStatus.Location = New Point(22, 165)
        chkResetRoomStatus.Margin = New Padding(3, 2, 3, 2)
        chkResetRoomStatus.Name = "chkResetRoomStatus"
        chkResetRoomStatus.Size = New Size(163, 19)
        chkResetRoomStatus.TabIndex = 8
        chkResetRoomStatus.Text = "Reset Room Statuses Only"
        chkResetRoomStatus.UseVisualStyleBackColor = True
        ' 
        ' lblAdminPwdConfirm
        ' 
        lblAdminPwdConfirm.AutoSize = True
        lblAdminPwdConfirm.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblAdminPwdConfirm.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblAdminPwdConfirm.Location = New Point(22, 206)
        lblAdminPwdConfirm.Name = "lblAdminPwdConfirm"
        lblAdminPwdConfirm.Size = New Size(222, 19)
        lblAdminPwdConfirm.TabIndex = 9
        lblAdminPwdConfirm.Text = "Enter Admin Password to confirm:"
        ' 
        ' txtAdminPwdConfirm
        ' 
        txtAdminPwdConfirm.Location = New Point(22, 229)
        txtAdminPwdConfirm.Margin = New Padding(3, 2, 3, 2)
        txtAdminPwdConfirm.Name = "txtAdminPwdConfirm"
        txtAdminPwdConfirm.PasswordChar = "*"c
        txtAdminPwdConfirm.Size = New Size(269, 23)
        txtAdminPwdConfirm.TabIndex = 10
        ' 
        ' btnExecuteReset
        ' 
        btnExecuteReset.BackColor = Color.FromArgb(CByte(165), CByte(42), CByte(42))
        btnExecuteReset.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnExecuteReset.ForeColor = Color.Beige
        btnExecuteReset.Location = New Point(22, 266)
        btnExecuteReset.Margin = New Padding(3, 2, 3, 2)
        btnExecuteReset.Name = "btnExecuteReset"
        btnExecuteReset.Size = New Size(158, 34)
        btnExecuteReset.TabIndex = 11
        btnExecuteReset.Text = "EXECUTE RESET"
        btnExecuteReset.UseVisualStyleBackColor = False
        ' 
        ' SettingsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(TabControl1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SettingsControl"
        Size = New Size(903, 500)
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
        TabPageReset.ResumeLayout(False)
        PanelResetHeader.ResumeLayout(False)
        PanelResetHeader.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        grpResetConfig.ResumeLayout(False)
        grpResetConfig.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDiscounts As TabPage
    Friend WithEvents TabPagePassword As TabPage
    Friend WithEvents TabPageReset As TabPage
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelResetHeader As Panel
    Friend WithEvents LabelResetDesc As Label
    Friend WithEvents LabelResetTitle As Label
    Friend WithEvents grpResetConfig As GroupBox
    Friend WithEvents rbFactoryReset As RadioButton
    Friend WithEvents rbSelectiveReset As RadioButton
    Friend WithEvents lblResetStartDate As Label
    Friend WithEvents dtpResetStartDate As DateTimePicker
    Friend WithEvents lblResetEndDate As Label
    Friend WithEvents dtpResetEndDate As DateTimePicker
    Friend WithEvents chkDeleteGuestHistory As CheckBox
    Friend WithEvents chkDeleteFinancial As CheckBox
    Friend WithEvents chkResetRoomStatus As CheckBox
    Friend WithEvents lblAdminPwdConfirm As Label
    Friend WithEvents txtAdminPwdConfirm As TextBox
    Friend WithEvents btnExecuteReset As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class