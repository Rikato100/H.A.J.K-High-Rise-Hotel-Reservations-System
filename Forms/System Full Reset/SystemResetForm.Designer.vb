<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SystemResetForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpResetOptions = New GroupBox()
        chkRoomStatuses = New CheckBox()
        chkFinancials = New CheckBox()
        chkGuestHistory = New CheckBox()
        lblEndDate = New Label()
        dtpEndDate = New DateTimePicker()
        lblStartDate = New Label()
        dtpStartDate = New DateTimePicker()
        radSelectiveReset = New RadioButton()
        radFactoryReset = New RadioButton()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnExecuteReset = New Button()
        grpResetOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpResetOptions
        ' 
        grpResetOptions.Controls.Add(chkRoomStatuses)
        grpResetOptions.Controls.Add(chkFinancials)
        grpResetOptions.Controls.Add(chkGuestHistory)
        grpResetOptions.Controls.Add(lblEndDate)
        grpResetOptions.Controls.Add(dtpEndDate)
        grpResetOptions.Controls.Add(lblStartDate)
        grpResetOptions.Controls.Add(dtpStartDate)
        grpResetOptions.Controls.Add(radSelectiveReset)
        grpResetOptions.Controls.Add(radFactoryReset)
        grpResetOptions.Location = New Point(14, 16)
        grpResetOptions.Margin = New Padding(3, 4, 3, 4)
        grpResetOptions.Name = "grpResetOptions"
        grpResetOptions.Padding = New Padding(3, 4, 3, 4)
        grpResetOptions.Size = New Size(457, 307)
        grpResetOptions.TabIndex = 0
        grpResetOptions.TabStop = False
        grpResetOptions.Text = "Reset Configuration"
        ' 
        ' chkRoomStatuses
        ' 
        chkRoomStatuses.AutoSize = True
        chkRoomStatuses.Enabled = False
        chkRoomStatuses.Location = New Point(26, 260)
        chkRoomStatuses.Margin = New Padding(3, 4, 3, 4)
        chkRoomStatuses.Name = "chkRoomStatuses"
        chkRoomStatuses.Size = New Size(203, 24)
        chkRoomStatuses.TabIndex = 8
        chkRoomStatuses.Text = "Reset Room Statuses Only"
        chkRoomStatuses.UseVisualStyleBackColor = True
        ' 
        ' chkFinancials
        ' 
        chkFinancials.AutoSize = True
        chkFinancials.Enabled = False
        chkFinancials.Location = New Point(26, 227)
        chkFinancials.Margin = New Padding(3, 4, 3, 4)
        chkFinancials.Name = "chkFinancials"
        chkFinancials.Size = New Size(297, 24)
        chkFinancials.TabIndex = 7
        chkFinancials.Text = "Delete Financial and Billing Transactions"
        chkFinancials.UseVisualStyleBackColor = True
        ' 
        ' chkGuestHistory
        ' 
        chkGuestHistory.AutoSize = True
        chkGuestHistory.Enabled = False
        chkGuestHistory.Location = New Point(26, 193)
        chkGuestHistory.Margin = New Padding(3, 4, 3, 4)
        chkGuestHistory.Name = "chkGuestHistory"
        chkGuestHistory.Size = New Size(259, 24)
        chkGuestHistory.TabIndex = 6
        chkGuestHistory.Text = "Delete Guest History (Date Range)"
        chkGuestHistory.UseVisualStyleBackColor = True
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Location = New Point(229, 153)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(73, 20)
        lblEndDate.TabIndex = 5
        lblEndDate.Text = "End Date:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Enabled = False
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(297, 149)
        dtpEndDate.Margin = New Padding(3, 4, 3, 4)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(137, 27)
        dtpEndDate.TabIndex = 4
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Location = New Point(23, 153)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(79, 20)
        lblStartDate.TabIndex = 3
        lblStartDate.Text = "Start Date:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Enabled = False
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(91, 149)
        dtpStartDate.Margin = New Padding(3, 4, 3, 4)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(125, 27)
        dtpStartDate.TabIndex = 2
        ' 
        ' radSelectiveReset
        ' 
        radSelectiveReset.AutoSize = True
        radSelectiveReset.Location = New Point(26, 107)
        radSelectiveReset.Margin = New Padding(3, 4, 3, 4)
        radSelectiveReset.Name = "radSelectiveReset"
        radSelectiveReset.Size = New Size(241, 24)
        radSelectiveReset.TabIndex = 1
        radSelectiveReset.Text = "Selective Reset (By Date Range)"
        radSelectiveReset.UseVisualStyleBackColor = True
        ' 
        ' radFactoryReset
        ' 
        radFactoryReset.AutoSize = True
        radFactoryReset.Checked = True
        radFactoryReset.Location = New Point(26, 53)
        radFactoryReset.Margin = New Padding(3, 4, 3, 4)
        radFactoryReset.Name = "radFactoryReset"
        radFactoryReset.Size = New Size(269, 24)
        radFactoryReset.TabIndex = 0
        radFactoryReset.TabStop = True
        radFactoryReset.Text = "Factory Reset (Wipe all transactions)"
        radFactoryReset.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(14, 340)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(232, 20)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Enter Admin Password to confirm:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(17, 367)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(285, 27)
        txtPassword.TabIndex = 2
        ' 
        ' btnExecuteReset
        ' 
        btnExecuteReset.BackColor = Color.Firebrick
        btnExecuteReset.FlatStyle = FlatStyle.Flat
        btnExecuteReset.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        btnExecuteReset.ForeColor = Color.White
        btnExecuteReset.Location = New Point(17, 420)
        btnExecuteReset.Margin = New Padding(3, 4, 3, 4)
        btnExecuteReset.Name = "btnExecuteReset"
        btnExecuteReset.Size = New Size(171, 53)
        btnExecuteReset.TabIndex = 3
        btnExecuteReset.Text = "EXECUTE RESET"
        btnExecuteReset.UseVisualStyleBackColor = False
        ' 
        ' SystemResetForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(491, 493)
        Controls.Add(btnExecuteReset)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(grpResetOptions)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "SystemResetForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "System Reset"
        grpResetOptions.ResumeLayout(False)
        grpResetOptions.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpResetOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents radSelectiveReset As System.Windows.Forms.RadioButton
    Friend WithEvents radFactoryReset As System.Windows.Forms.RadioButton
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnExecuteReset As System.Windows.Forms.Button
    Friend WithEvents chkRoomStatuses As System.Windows.Forms.CheckBox
    Friend WithEvents chkFinancials As System.Windows.Forms.CheckBox
    Friend WithEvents chkGuestHistory As System.Windows.Forms.CheckBox
End Class
