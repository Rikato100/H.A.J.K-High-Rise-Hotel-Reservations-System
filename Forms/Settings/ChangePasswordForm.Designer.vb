<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePasswordForm
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
        lblTitle = New Label()
        lblCurrent = New Label()
        txtCurrent = New TextBox()
        lblNew = New Label()
        txtNew = New TextBox()
        lblConfirm = New Label()
        txtConfirm = New TextBox()
        lblHint = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.Location = New Point(23, 21)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(242, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Change Password"
        ' 
        ' lblCurrent
        ' 
        lblCurrent.AutoSize = True
        lblCurrent.Location = New Point(27, 93)
        lblCurrent.Name = "lblCurrent"
        lblCurrent.Size = New Size(127, 20)
        lblCurrent.TabIndex = 1
        lblCurrent.Text = "Current password:"
        ' 
        ' txtCurrent
        ' 
        txtCurrent.Location = New Point(183, 89)
        txtCurrent.Margin = New Padding(3, 4, 3, 4)
        txtCurrent.Name = "txtCurrent"
        txtCurrent.Size = New Size(251, 27)
        txtCurrent.TabIndex = 2
        txtCurrent.UseSystemPasswordChar = True
        ' 
        ' lblNew
        ' 
        lblNew.AutoSize = True
        lblNew.Location = New Point(27, 147)
        lblNew.Name = "lblNew"
        lblNew.Size = New Size(109, 20)
        lblNew.TabIndex = 3
        lblNew.Text = "New password:"
        ' 
        ' txtNew
        ' 
        txtNew.Location = New Point(183, 143)
        txtNew.Margin = New Padding(3, 4, 3, 4)
        txtNew.Name = "txtNew"
        txtNew.Size = New Size(251, 27)
        txtNew.TabIndex = 4
        txtNew.UseSystemPasswordChar = True
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.Location = New Point(27, 200)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(163, 20)
        lblConfirm.TabIndex = 5
        lblConfirm.Text = "Confirm new password:"
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Location = New Point(183, 196)
        txtConfirm.Margin = New Padding(3, 4, 3, 4)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(251, 27)
        txtConfirm.TabIndex = 6
        txtConfirm.UseSystemPasswordChar = True
        ' 
        ' lblHint
        ' 
        lblHint.AutoSize = True
        lblHint.ForeColor = Color.Gray
        lblHint.Location = New Point(27, 245)
        lblHint.Name = "lblHint"
        lblHint.Size = New Size(293, 20)
        lblHint.TabIndex = 7
        lblHint.Text = "Min. 8 characters, with letters and numbers."
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.White
        btnSave.FlatAppearance.BorderColor = Color.Silver
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(183, 299)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 51)
        btnSave.TabIndex = 8
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.FlatAppearance.BorderColor = Color.Silver
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(314, 299)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 51)
        btnCancel.TabIndex = 9
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' ChangePasswordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 387)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(lblHint)
        Controls.Add(txtConfirm)
        Controls.Add(lblConfirm)
        Controls.Add(txtNew)
        Controls.Add(lblNew)
        Controls.Add(txtCurrent)
        Controls.Add(lblCurrent)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ChangePasswordForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Change Password"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
