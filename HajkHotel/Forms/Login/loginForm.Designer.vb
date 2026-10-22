<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        lblHotelName = New Label()
        lblSystemName = New Label()
        lblTagline = New Label()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(48, 201)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 16)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(48, 239)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(72, 16)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(142, 198)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(277, 23)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(142, 236)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(277, 23)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Beige
        btnLogin.ForeColor = Color.Maroon
        btnLogin.Location = New Point(104, 285)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(107, 34)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Beige
        btnExit.ForeColor = Color.Maroon
        btnExit.Location = New Point(274, 285)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(107, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblHotelName
        ' 
        lblHotelName.AutoSize = True
        lblHotelName.Font = New Font("Imprint MT Shadow", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHotelName.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblHotelName.Location = New Point(48, 76)
        lblHotelName.Name = "lblHotelName"
        lblHotelName.Size = New Size(383, 38)
        lblHotelName.TabIndex = 0
        lblHotelName.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' lblSystemName
        ' 
        lblSystemName.AutoSize = True
        lblSystemName.Font = New Font("Mongolian Baiti", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSystemName.ForeColor = Color.White
        lblSystemName.Location = New Point(125, 160)
        lblSystemName.Name = "lblSystemName"
        lblSystemName.Size = New Size(222, 21)
        lblSystemName.TabIndex = 7
        lblSystemName.Text = "Hotel Reservation System"
        ' 
        ' lblTagline
        ' 
        lblTagline.Font = New Font("Monotype Corsiva", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Color.White
        lblTagline.Location = New Point(48, 114)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(383, 36)
        lblTagline.TabIndex = 8
        lblTagline.Text = "Where every stay feels extraordinary"
        lblTagline.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(186, 4)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(109, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(493, -2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(434, 353)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        ClientSize = New Size(925, 349)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(lblTagline)
        Controls.Add(lblSystemName)
        Controls.Add(lblHotelName)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "loginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHotelName As Label
    Friend WithEvents lblSystemName As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
