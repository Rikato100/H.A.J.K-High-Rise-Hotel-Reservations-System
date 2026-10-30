<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffDashboard))
        btnLogout = New Button()
        btnGuests = New Button()
        btnReservations = New Button()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        btnSettings = New Button()
        btnDashboard = New Button()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        pnlContent = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Mongolian Baiti", 11.25F)
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 537)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(144, 56)
        btnLogout.TabIndex = 16
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnGuests
        ' 
        btnGuests.BackColor = Color.Transparent
        btnGuests.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnGuests.FlatStyle = FlatStyle.Flat
        btnGuests.Font = New Font("Mongolian Baiti", 11.25F)
        btnGuests.ForeColor = Color.Beige
        btnGuests.Location = New Point(3, 225)
        btnGuests.Margin = New Padding(3, 4, 3, 4)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(144, 56)
        btnGuests.TabIndex = 14
        btnGuests.Text = "♟ Guest Management"
        btnGuests.UseVisualStyleBackColor = False
        ' 
        ' btnReservations
        ' 
        btnReservations.BackColor = Color.Transparent
        btnReservations.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnReservations.FlatStyle = FlatStyle.Flat
        btnReservations.Font = New Font("Mongolian Baiti", 11.25F)
        btnReservations.ForeColor = Color.Beige
        btnReservations.Location = New Point(3, 169)
        btnReservations.Margin = New Padding(3, 4, 3, 4)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(144, 56)
        btnReservations.TabIndex = 11
        btnReservations.Text = "▤ Reservation"
        btnReservations.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnGuests)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnReservations)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(150, 749)
        Panel1.TabIndex = 17
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 8)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 92)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.Transparent
        btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Mongolian Baiti", 11.25F)
        btnSettings.ForeColor = Color.Beige
        btnSettings.Location = New Point(3, 277)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(144, 56)
        btnSettings.TabIndex = 5
        btnSettings.Text = "⚙ Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Mongolian Baiti", 11.25F)
        btnDashboard.ForeColor = Color.Beige
        btnDashboard.Location = New Point(3, 113)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(144, 56)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "🏠 Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(150, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 112)
        Panel2.TabIndex = 21
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(510, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(522, 112)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic)
        Label3.ForeColor = Color.Beige
        Label3.Location = New Point(13, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(264, 24)
        Label3.TabIndex = 15
        Label3.Text = "Where every stay feels extraordinary"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label4.Location = New Point(7, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(404, 40)
        Label4.TabIndex = 0
        Label4.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(150, 112)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1032, 637)
        pnlContent.TabIndex = 22
        ' 
        ' StaffDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 749)
        Controls.Add(pnlContent)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "StaffDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "H.A.J.K High Rise Hotel Reservation System"
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlContent As Panel
End Class
