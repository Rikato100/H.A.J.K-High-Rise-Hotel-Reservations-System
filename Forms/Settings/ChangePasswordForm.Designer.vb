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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(20, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(190, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Change Password"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(24, 70)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(107, 15)
        Me.lblCurrent.TabIndex = 1
        Me.lblCurrent.Text = "Current password:"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(160, 67)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(220, 23)
        Me.txtCurrent.TabIndex = 2
        Me.txtCurrent.UseSystemPasswordChar = True
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(24, 110)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(90, 15)
        Me.lblNew.TabIndex = 3
        Me.lblNew.Text = "New password:"
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(160, 107)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(220, 23)
        Me.txtNew.TabIndex = 4
        Me.txtNew.UseSystemPasswordChar = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(24, 150)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(124, 15)
        Me.lblConfirm.TabIndex = 5
        Me.lblConfirm.Text = "Confirm new password:"
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(160, 147)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(220, 23)
        Me.txtConfirm.TabIndex = 6
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.ForeColor = System.Drawing.Color.Gray
        Me.lblHint.Location = New System.Drawing.Point(24, 184)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(290, 15)
        Me.lblHint.TabIndex = 7
        Me.lblHint.Text = "Min. 8 characters, with letters and numbers."
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(160, 224)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 38)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(275, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 38)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 290)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
