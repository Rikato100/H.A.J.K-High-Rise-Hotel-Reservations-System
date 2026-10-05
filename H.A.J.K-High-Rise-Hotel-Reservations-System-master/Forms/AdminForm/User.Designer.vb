<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Panel1 = New Panel()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        Panel8 = New Panel()
        Label17 = New Label()
        PictureBox3 = New PictureBox()
        Label16 = New Label()
        Class110 = New Class1()
        Label31 = New Label()
        Label30 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        ComboBox2 = New ComboBox()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        colUser = New DataGridViewTextBoxColumn()
        colFullname = New DataGridViewTextBoxColumn()
        colUsername = New DataGridViewTextBoxColumn()
        colemail = New DataGridViewTextBoxColumn()
        colrole = New DataGridViewTextBoxColumn()
        colstatus = New DataGridViewTextBoxColumn()
        coledit = New DataGridViewButtonColumn()
        Button8 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Class110.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(61), CByte(2), CByte(2))
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(210, 583)
        Panel1.TabIndex = 3
        ' 
        ' Button7
        ' 
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.White
        Button7.Location = New Point(12, 495)
        Button7.Name = "Button7"
        Button7.Size = New Size(190, 45)
        Button7.TabIndex = 11
        Button7.Text = " 🚪  Logout  "
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.White
        Button6.Location = New Point(12, 334)
        Button6.Name = "Button6"
        Button6.Size = New Size(190, 45)
        Button6.TabIndex = 10
        Button6.Text = "⚙   General Settings  "
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.White
        Button5.Location = New Point(12, 290)
        Button5.Name = "Button5"
        Button5.Size = New Size(190, 45)
        Button5.TabIndex = 9
        Button5.Text = "📊   Reports "
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.White
        Button4.Location = New Point(12, 243)
        Button4.Name = "Button4"
        Button4.Size = New Size(190, 45)
        Button4.TabIndex = 8
        Button4.Text = "👥   Users "
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(12, 196)
        Button3.Name = "Button3"
        Button3.Size = New Size(190, 45)
        Button3.TabIndex = 7
        Button3.Text = "🏨   Hotel Management"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(749, 150)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 45)
        Button1.TabIndex = 5
        Button1.Text = " 🏠   Home"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 4.20000029F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(39, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 10)
        Label2.TabIndex = 4
        Label2.Text = "Where Every Stay Feels Ordinary."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(61), CByte(2), CByte(2))
        Label1.Font = New Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(22, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 20)
        Label1.TabIndex = 3
        Label1.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Khaki
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(29, 150)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(0, 0)
        Panel3.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Monotype Corsiva", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 21)
        Label5.TabIndex = 0
        Label5.Text = "Available Rooms"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(4, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(61, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(4, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 54)
        Label7.TabIndex = 2
        Label7.Text = "28/50"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Khaki
        Panel8.Controls.Add(Label16)
        Panel8.Controls.Add(PictureBox3)
        Panel8.Controls.Add(Label17)
        Panel8.Location = New Point(36, 323)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(0, 0)
        Panel8.TabIndex = 21
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Monotype Corsiva", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(3, 49)
        Label17.Name = "Label17"
        Label17.Size = New Size(133, 21)
        Label17.TabIndex = 0
        Label17.Text = "Available Rooms"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(4, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(61, 47)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(4, 78)
        Label16.Name = "Label16"
        Label16.Size = New Size(133, 54)
        Label16.TabIndex = 2
        Label16.Text = "28/50"
        ' 
        ' Class110
        ' 
        Class110.Controls.Add(Label30)
        Class110.Controls.Add(Label31)
        Class110.Location = New Point(18, 323)
        Class110.Name = "Class110"
        Class110.Size = New Size(0, 0)
        Class110.TabIndex = 22
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.BackColor = Color.Transparent
        Label31.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(42, 17)
        Label31.Name = "Label31"
        Label31.Size = New Size(53, 31)
        Label31.TabIndex = 2
        Label31.Text = "106"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.BackColor = Color.Transparent
        Label30.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(31, 50)
        Label30.Name = "Label30"
        Label30.Size = New Size(79, 23)
        Label30.TabIndex = 1
        Label30.Text = "Available"
        Label30.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(2, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(340, 50)
        Label3.TabIndex = 23
        Label3.Text = "User Management"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(412, 23)
        Label4.TabIndex = 24
        Label4.Text = "Manage staff accounts, roles, and access permissions"
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.BackColor = Color.Beige
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Class110)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(210, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(879, 583)
        Panel2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(13, 96)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(317, 48)
        TextBox1.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(10, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 23)
        Label6.TabIndex = 25
        Label6.Text = "Search staff"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(13, 168)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(10, 144)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 23)
        Label8.TabIndex = 27
        Label8.Text = "Role"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(179, 167)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(176, 144)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 23)
        Label9.TabIndex = 29
        Label9.Text = "Account Status"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colUser, colFullname, colUsername, colemail, colrole, colstatus, coledit})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(13, 205)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 30
        DataGridView1.Size = New Size(854, 366)
        DataGridView1.TabIndex = 30
        ' 
        ' colUser
        ' 
        colUser.HeaderText = "User ID"
        colUser.MinimumWidth = 6
        colUser.Name = "colUser"
        colUser.Width = 125
        ' 
        ' colFullname
        ' 
        colFullname.HeaderText = "Full Name"
        colFullname.MinimumWidth = 6
        colFullname.Name = "colFullname"
        colFullname.Width = 125
        ' 
        ' colUsername
        ' 
        colUsername.HeaderText = "Username"
        colUsername.MinimumWidth = 6
        colUsername.Name = "colUsername"
        colUsername.Width = 125
        ' 
        ' colemail
        ' 
        colemail.HeaderText = "Email Address"
        colemail.MinimumWidth = 6
        colemail.Name = "colemail"
        colemail.Width = 125
        ' 
        ' colrole
        ' 
        colrole.HeaderText = "Role"
        colrole.MinimumWidth = 6
        colrole.Name = "colrole"
        colrole.Width = 125
        ' 
        ' colstatus
        ' 
        colstatus.HeaderText = "Status"
        colstatus.MinimumWidth = 6
        colstatus.Name = "colstatus"
        colstatus.Width = 125
        ' 
        ' coledit
        ' 
        coledit.HeaderText = "Action"
        coledit.MinimumWidth = 6
        coledit.Name = "coledit"
        coledit.Text = "Edit"
        coledit.UseColumnTextForButtonValue = True
        coledit.Width = 125
        ' 
        ' Button8
        ' 
        Button8.FlatStyle = FlatStyle.Popup
        Button8.Location = New Point(776, 96)
        Button8.Name = "Button8"
        Button8.Size = New Size(91, 48)
        Button8.TabIndex = 31
        Button8.Text = "+ Add"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 583)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "User"
        Text = "User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Class110.ResumeLayout(False)
        Class110.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Class110 As Class1
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents colUser As DataGridViewTextBoxColumn
    Friend WithEvents colFullname As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colemail As DataGridViewTextBoxColumn
    Friend WithEvents colrole As DataGridViewTextBoxColumn
    Friend WithEvents colstatus As DataGridViewTextBoxColumn
    Friend WithEvents coledit As DataGridViewButtonColumn
    Friend WithEvents Button8 As Button
End Class
