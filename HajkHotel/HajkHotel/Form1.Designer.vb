<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblUsername = New Label()
        Label1 = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(109, 136)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 21)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(200, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 60)
        Label1.TabIndex = 1
        Label1.Text = "H.A.J.K. Hotel Reservation " & vbCrLf & "                System"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(114, 193)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(206, 138)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(277, 23)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(206, 191)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(277, 23)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(223, 241)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(107, 34)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(346, 241)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(107, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 378)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(Label1)
        Controls.Add(lblUsername)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button

End Class
