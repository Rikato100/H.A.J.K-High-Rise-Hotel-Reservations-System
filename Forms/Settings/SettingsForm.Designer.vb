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
        TabControl1 = New TabControl()
        TabPageDiscounts = New TabPage()
        lblDiscountTitle = New Label()
        dgvDiscounts = New DataGridView()
        lblSelectDiscount = New Label()
        lblRate = New Label()
        numRate = New NumericUpDown()
        chkBoxVatExempt = New CheckBox()
        lblStartDate = New Label()
        dtpStartDate = New DateTimePicker()
        lblEndDate = New Label()
        dtpEndDate = New DateTimePicker()
        lblNote = New Label()
        btnSaveDiscount = New Button()
        btnCloseDiscount = New Button()
        TabPagePassword = New TabPage()
        lblPasswordTitle = New Label()
        lblCurrentPwd = New Label()
        txtCurrentPwd = New TextBox()
        lblNewPwd = New Label()
        txtNewPwd = New TextBox()
        lblConfirmPwd = New Label()
        txtConfirmPwd = New TextBox()
        lblPwdHint = New Label()
        btnSavePassword = New Button()
        btnCancelPassword = New Button()
        TabControl1.SuspendLayout()
        TabPageDiscounts.SuspendLayout()
        CType(dgvDiscounts, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRate, ComponentModel.ISupportInitialize).BeginInit()
        TabPagePassword.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPageDiscounts)
        TabControl1.Controls.Add(TabPagePassword)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(650, 650)
        TabControl1.TabIndex = 0
        ' 
        ' TabPageDiscounts
        ' 
        TabPageDiscounts.Controls.Add(lblDiscountTitle)
        TabPageDiscounts.Controls.Add(dgvDiscounts)
        TabPageDiscounts.Controls.Add(lblSelectDiscount)
        TabPageDiscounts.Controls.Add(lblRate)
        TabPageDiscounts.Controls.Add(numRate)
        TabPageDiscounts.Controls.Add(chkBoxVatExempt)
        TabPageDiscounts.Controls.Add(lblStartDate)
        TabPageDiscounts.Controls.Add(dtpStartDate)
        TabPageDiscounts.Controls.Add(lblEndDate)
        TabPageDiscounts.Controls.Add(dtpEndDate)
        TabPageDiscounts.Controls.Add(lblNote)
        TabPageDiscounts.Controls.Add(btnSaveDiscount)
        TabPageDiscounts.Controls.Add(btnCloseDiscount)
        TabPageDiscounts.Location = New Point(4, 29)
        TabPageDiscounts.Margin = New Padding(3, 4, 3, 4)
        TabPageDiscounts.Name = "TabPageDiscounts"
        TabPageDiscounts.Padding = New Padding(3, 4, 3, 4)
        TabPageDiscounts.Size = New Size(642, 617)
        TabPageDiscounts.TabIndex = 0
        TabPageDiscounts.Text = "Discount Settings"
        TabPageDiscounts.UseVisualStyleBackColor = True
        ' 
        ' lblDiscountTitle
        ' 
        lblDiscountTitle.AutoSize = True
        lblDiscountTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblDiscountTitle.Location = New Point(20, 25)
        lblDiscountTitle.Name = "lblDiscountTitle"
        lblDiscountTitle.Size = New Size(242, 37)
        lblDiscountTitle.TabIndex = 0
        lblDiscountTitle.Text = "Discount Settings"
        ' 
        ' dgvDiscounts
        ' 
        dgvDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDiscounts.Location = New Point(27, 94)
        dgvDiscounts.Margin = New Padding(3, 4, 3, 4)
        dgvDiscounts.Name = "dgvDiscounts"
        dgvDiscounts.RowHeadersWidth = 51
        dgvDiscounts.RowTemplate.Height = 24
        dgvDiscounts.Size = New Size(585, 188)
        dgvDiscounts.TabIndex = 1
        ' 
        ' lblSelectDiscount
        ' 
        lblSelectDiscount.AutoSize = True
        lblSelectDiscount.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSelectDiscount.Location = New Point(27, 294)
        lblSelectDiscount.Name = "lblSelectDiscount"
        lblSelectDiscount.Size = New Size(198, 23)
        lblSelectDiscount.TabIndex = 2
        lblSelectDiscount.Text = "Select a discount above"
        ' 
        ' lblRate
        ' 
        lblRate.AutoSize = True
        lblRate.Location = New Point(27, 350)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(68, 20)
        lblRate.TabIndex = 3
        lblRate.Text = "Rate (%):"
        ' 
        ' numRate
        ' 
        numRate.DecimalPlaces = 2
        numRate.Location = New Point(100, 348)
        numRate.Margin = New Padding(3, 4, 3, 4)
        numRate.Name = "numRate"
        numRate.Size = New Size(120, 27)
        numRate.TabIndex = 4
        ' 
        ' chkBoxVatExempt
        ' 
        chkBoxVatExempt.AutoSize = True
        chkBoxVatExempt.Location = New Point(260, 350)
        chkBoxVatExempt.Margin = New Padding(3, 4, 3, 4)
        chkBoxVatExempt.Name = "chkBoxVatExempt"
        chkBoxVatExempt.Size = New Size(110, 24)
        chkBoxVatExempt.TabIndex = 5
        chkBoxVatExempt.Text = "VAT exempt"
        chkBoxVatExempt.UseVisualStyleBackColor = True
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Location = New Point(27, 412)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(77, 20)
        lblStartDate.TabIndex = 6
        lblStartDate.Text = "Start date:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(100, 406)
        dtpStartDate.Margin = New Padding(3, 4, 3, 4)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(150, 27)
        dtpStartDate.TabIndex = 7
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Location = New Point(280, 412)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(71, 20)
        lblEndDate.TabIndex = 8
        lblEndDate.Text = "End date:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(355, 406)
        dtpEndDate.Margin = New Padding(3, 4, 3, 4)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(150, 27)
        dtpEndDate.TabIndex = 9
        ' 
        ' lblNote
        ' 
        lblNote.AutoSize = True
        lblNote.ForeColor = Color.Gray
        lblNote.Location = New Point(27, 469)
        lblNote.Name = "lblNote"
        lblNote.Size = New Size(545, 20)
        lblNote.TabIndex = 10
        lblNote.Text = "Changes apply to new reservations only. Existing reservations keep their amounts."
        ' 
        ' btnSaveDiscount
        ' 
        btnSaveDiscount.Location = New Point(27, 525)
        btnSaveDiscount.Margin = New Padding(3, 4, 3, 4)
        btnSaveDiscount.Name = "btnSaveDiscount"
        btnSaveDiscount.Size = New Size(130, 50)
        btnSaveDiscount.TabIndex = 11
        btnSaveDiscount.Text = "SAVE CHANGES"
        btnSaveDiscount.UseVisualStyleBackColor = True
        ' 
        ' btnCloseDiscount
        ' 
        btnCloseDiscount.Location = New Point(482, 525)
        btnCloseDiscount.Margin = New Padding(3, 4, 3, 4)
        btnCloseDiscount.Name = "btnCloseDiscount"
        btnCloseDiscount.Size = New Size(130, 50)
        btnCloseDiscount.TabIndex = 12
        btnCloseDiscount.Text = "CLOSE"
        btnCloseDiscount.UseVisualStyleBackColor = True
        ' 
        ' TabPagePassword
        ' 
        TabPagePassword.Controls.Add(lblPasswordTitle)
        TabPagePassword.Controls.Add(lblCurrentPwd)
        TabPagePassword.Controls.Add(txtCurrentPwd)
        TabPagePassword.Controls.Add(lblNewPwd)
        TabPagePassword.Controls.Add(txtNewPwd)
        TabPagePassword.Controls.Add(lblConfirmPwd)
        TabPagePassword.Controls.Add(txtConfirmPwd)
        TabPagePassword.Controls.Add(lblPwdHint)
        TabPagePassword.Controls.Add(btnSavePassword)
        TabPagePassword.Controls.Add(btnCancelPassword)
        TabPagePassword.Location = New Point(4, 29)
        TabPagePassword.Margin = New Padding(3, 4, 3, 4)
        TabPagePassword.Name = "TabPagePassword"
        TabPagePassword.Padding = New Padding(3, 4, 3, 4)
        TabPagePassword.Size = New Size(642, 617)
        TabPagePassword.TabIndex = 1
        TabPagePassword.Text = "Change Password"
        TabPagePassword.UseVisualStyleBackColor = True
        ' 
        ' lblPasswordTitle
        ' 
        lblPasswordTitle.AutoSize = True
        lblPasswordTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblPasswordTitle.Location = New Point(20, 25)
        lblPasswordTitle.Name = "lblPasswordTitle"
        lblPasswordTitle.Size = New Size(242, 37)
        lblPasswordTitle.TabIndex = 0
        lblPasswordTitle.Text = "Change Password"
        ' 
        ' lblCurrentPwd
        ' 
        lblCurrentPwd.AutoSize = True
        lblCurrentPwd.Location = New Point(50, 138)
        lblCurrentPwd.Name = "lblCurrentPwd"
        lblCurrentPwd.Size = New Size(127, 20)
        lblCurrentPwd.TabIndex = 1
        lblCurrentPwd.Text = "Current password:"
        ' 
        ' txtCurrentPwd
        ' 
        txtCurrentPwd.Location = New Point(200, 134)
        txtCurrentPwd.Margin = New Padding(3, 4, 3, 4)
        txtCurrentPwd.Name = "txtCurrentPwd"
        txtCurrentPwd.PasswordChar = "*"c
        txtCurrentPwd.Size = New Size(350, 27)
        txtCurrentPwd.TabIndex = 2
        ' 
        ' lblNewPwd
        ' 
        lblNewPwd.AutoSize = True
        lblNewPwd.Location = New Point(50, 212)
        lblNewPwd.Name = "lblNewPwd"
        lblNewPwd.Size = New Size(109, 20)
        lblNewPwd.TabIndex = 3
        lblNewPwd.Text = "New password:"
        ' 
        ' txtNewPwd
        ' 
        txtNewPwd.Location = New Point(200, 209)
        txtNewPwd.Margin = New Padding(3, 4, 3, 4)
        txtNewPwd.Name = "txtNewPwd"
        txtNewPwd.PasswordChar = "*"c
        txtNewPwd.Size = New Size(350, 27)
        txtNewPwd.TabIndex = 4
        ' 
        ' lblConfirmPwd
        ' 
        lblConfirmPwd.AutoSize = True
        lblConfirmPwd.Location = New Point(50, 288)
        lblConfirmPwd.Name = "lblConfirmPwd"
        lblConfirmPwd.Size = New Size(163, 20)
        lblConfirmPwd.TabIndex = 5
        lblConfirmPwd.Text = "Confirm new password:"
        ' 
        ' txtConfirmPwd
        ' 
        txtConfirmPwd.Location = New Point(200, 284)
        txtConfirmPwd.Margin = New Padding(3, 4, 3, 4)
        txtConfirmPwd.Name = "txtConfirmPwd"
        txtConfirmPwd.PasswordChar = "*"c
        txtConfirmPwd.Size = New Size(350, 27)
        txtConfirmPwd.TabIndex = 6
        ' 
        ' lblPwdHint
        ' 
        lblPwdHint.AutoSize = True
        lblPwdHint.ForeColor = Color.Gray
        lblPwdHint.Location = New Point(200, 325)
        lblPwdHint.Name = "lblPwdHint"
        lblPwdHint.Size = New Size(293, 20)
        lblPwdHint.TabIndex = 7
        lblPwdHint.Text = "Min. 8 characters, with letters and numbers."
        ' 
        ' btnSavePassword
        ' 
        btnSavePassword.Location = New Point(200, 412)
        btnSavePassword.Margin = New Padding(3, 4, 3, 4)
        btnSavePassword.Name = "btnSavePassword"
        btnSavePassword.Size = New Size(160, 56)
        btnSavePassword.TabIndex = 8
        btnSavePassword.Text = "SAVE"
        btnSavePassword.UseVisualStyleBackColor = True
        ' 
        ' btnCancelPassword
        ' 
        btnCancelPassword.Location = New Point(390, 412)
        btnCancelPassword.Margin = New Padding(3, 4, 3, 4)
        btnCancelPassword.Name = "btnCancelPassword"
        btnCancelPassword.Size = New Size(160, 56)
        btnCancelPassword.TabIndex = 9
        btnCancelPassword.Text = "CANCEL"
        btnCancelPassword.UseVisualStyleBackColor = True
        ' 
        ' SettingsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(650, 650)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "SettingsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "System Settings"
        TabControl1.ResumeLayout(False)
        TabPageDiscounts.ResumeLayout(False)
        TabPageDiscounts.PerformLayout()
        CType(dgvDiscounts, ComponentModel.ISupportInitialize).EndInit()
        CType(numRate, ComponentModel.ISupportInitialize).EndInit()
        TabPagePassword.ResumeLayout(False)
        TabPagePassword.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDiscounts As TabPage
    Friend WithEvents TabPagePassword As TabPage
    Friend WithEvents lblDiscountTitle As Label
    Friend WithEvents dgvDiscounts As DataGridView
    Friend WithEvents lblSelectDiscount As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents numRate As NumericUpDown
    Friend WithEvents chkBoxVatExempt As CheckBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblNote As Label
    Friend WithEvents btnSaveDiscount As Button
    Friend WithEvents btnCloseDiscount As Button
    Friend WithEvents lblPasswordTitle As Label
    Friend WithEvents lblCurrentPwd As Label
    Friend WithEvents txtCurrentPwd As TextBox
    Friend WithEvents lblNewPwd As Label
    Friend WithEvents txtNewPwd As TextBox
    Friend WithEvents lblConfirmPwd As Label
    Friend WithEvents txtConfirmPwd As TextBox
    Friend WithEvents lblPwdHint As Label
    Friend WithEvents btnSavePassword As Button
    Friend WithEvents btnCancelPassword As Button
End Class