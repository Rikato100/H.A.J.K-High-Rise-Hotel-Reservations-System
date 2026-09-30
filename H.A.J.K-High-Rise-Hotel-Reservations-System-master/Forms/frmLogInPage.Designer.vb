<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogInPage
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogInPage))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        txtUserID = New TextBox()
        txtPassword = New TextBox()
        btnLogIn = New Button()
        Timer1 = New Timer(components)
        lblDate = New Label()
        lblTime = New Label()
        lblDay = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(538, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(498, 517)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        PictureBox2.Location = New Point(208, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(154, 106)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(95, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 40)
        Label1.TabIndex = 2
        Label1.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(140, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(288, 18)
        Label2.TabIndex = 3
        Label2.Text = "Where Every Stay Feels High Quality."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(115, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(332, 27)
        Label3.TabIndex = 4
        Label3.Text = "HOTEL RESERVATION SYSTEM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(123, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 5
        Label4.Text = "User ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(123, 313)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 20)
        Label6.TabIndex = 7
        Label6.Text = "Password:"
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(208, 269)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(220, 27)
        txtUserID.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(208, 312)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(220, 27)
        txtPassword.TabIndex = 9
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.Yellow
        btnLogIn.Location = New Point(268, 360)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(94, 29)
        btnLogIn.TabIndex = 10
        btnLogIn.Text = "LOG IN"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.ForeColor = Color.Yellow
        lblDate.Location = New Point(12, 385)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(41, 20)
        lblDate.TabIndex = 11
        lblDate.Text = "Date"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.ForeColor = Color.Yellow
        lblTime.Location = New Point(12, 405)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(42, 20)
        lblTime.TabIndex = 12
        lblTime.Text = "Time"
        ' 
        ' lblDay
        ' 
        lblDay.AutoSize = True
        lblDay.ForeColor = Color.Yellow
        lblDay.Location = New Point(13, 364)
        lblDay.Name = "lblDay"
        lblDay.Size = New Size(35, 20)
        lblDay.TabIndex = 13
        lblDay.Text = "Day"
        ' 
        ' frmLogInPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(61), CByte(2), CByte(2))
        ClientSize = New Size(1018, 434)
        Controls.Add(lblDay)
        Controls.Add(lblTime)
        Controls.Add(lblDate)
        Controls.Add(btnLogIn)
        Controls.Add(txtPassword)
        Controls.Add(txtUserID)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmLogInPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel Reservation System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDay As Label

End Class
