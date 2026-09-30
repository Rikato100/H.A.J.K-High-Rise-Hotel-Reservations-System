<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(210, 653)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Log_in_page.Resources.Screenshot_2026_09_24_175004_removebg_preview
        PictureBox1.Location = New Point(53, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
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
        ' Button2
        ' 
        Button2.Location = New Point(749, 150)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
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
        ' Button7
        ' 
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.White
        Button7.Location = New Point(12, 545)
        Button7.Name = "Button7"
        Button7.Size = New Size(190, 45)
        Button7.TabIndex = 11
        Button7.Text = " 🚪  Logout  "
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Beige
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(210, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(972, 653)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(38, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(357, 54)
        Label3.TabIndex = 0
        Label3.Text = "Welcome, Admin!"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(447, 23)
        Label4.TabIndex = 1
        Label4.Text = "Here's what's happening at H.A.J.K High Rise Hotel today."
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Khaki
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(38, 150)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(210, 140)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 653)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
End Class
