<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        components = New ComponentModel.Container()
        Dim Panel2 As Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        PictureBox4 = New PictureBox()
        lblTagline = New Label()
        lblHotelName = New Label()
        btnRooms = New Button()
        btnStaff = New Button()
        btnLogout = New Button()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        btnSettings = New Button()
        btnReports = New Button()
        btnDashboard = New Button()
        Label1 = New Label()
        lblSubtitle = New Label()
        lblDateTime = New Label()
        tmrDashboard = New Timer(components)
        cardRooms = New Panel()
        topStrip1 = New Panel()
        lblIconRooms = New Label()
        lblTitleAvailableRooms = New Label()
        lblAvailableRooms = New Label()
        cardArriving = New Panel()
        topStrip2 = New Panel()
        lblIconArriving = New Label()
        lblTitleArrivingToday = New Label()
        lblArrivingToday = New Label()
        cardDeparting = New Panel()
        topStrip3 = New Panel()
        lblIconDeparting = New Label()
        lblTitleDepartingToday = New Label()
        lblDepartingToday = New Label()
        cardInHouse = New Panel()
        topStrip4 = New Panel()
        lblIconInHouse = New Label()
        lblTitleInHouse = New Label()
        lblInHouse = New Label()
        cardRevenue = New Panel()
        topStrip5 = New Panel()
        lblIconRevenue = New Label()
        lblTitleDailyRevenue = New Label()
        lblDailyRevenue = New Label()
        cardOccupancy = New Panel()
        topStrip6 = New Panel()
        lblIconOccupancy = New Label()
        lblTitleOccupancyRate = New Label()
        lblOccupancyRate = New Label()
        Panel2 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        cardRooms.SuspendLayout()
        cardArriving.SuspendLayout()
        cardDeparting.SuspendLayout()
        cardInHouse.SuspendLayout()
        cardRevenue.SuspendLayout()
        cardOccupancy.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(lblTagline)
        Panel2.Controls.Add(lblHotelName)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(131, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(903, 84)
        Panel2.TabIndex = 15
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(446, 0)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(457, 84)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' lblTagline
        ' 
        lblTagline.AutoSize = True
        lblTagline.Font = New Font("Monotype Corsiva", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Color.Beige
        lblTagline.Location = New Point(11, 44)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(220, 18)
        lblTagline.TabIndex = 15
        lblTagline.Text = "Where every stay feels extraordinary"
        ' 
        ' lblHotelName
        ' 
        lblHotelName.AutoSize = True
        lblHotelName.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold)
        lblHotelName.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblHotelName.Location = New Point(6, 9)
        lblHotelName.Name = "lblHotelName"
        lblHotelName.Size = New Size(326, 32)
        lblHotelName.TabIndex = 0
        lblHotelName.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' btnRooms
        ' 
        btnRooms.BackColor = Color.Transparent
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRooms.ForeColor = Color.Beige
        btnRooms.Location = New Point(3, 126)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(126, 42)
        btnRooms.TabIndex = 2
        btnRooms.Text = "🛏 Rooms Management"
        btnRooms.UseVisualStyleBackColor = False
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.Transparent
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Mongolian Baiti", 11.25F)
        btnStaff.ForeColor = Color.Beige
        btnStaff.Location = New Point(3, 168)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(126, 42)
        btnStaff.TabIndex = 8
        btnStaff.Text = "👥 Staff Management"
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Mongolian Baiti", 11.25F)
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 406)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(126, 42)
        btnLogout.TabIndex = 9
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnStaff)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnRooms)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 562)
        Panel1.TabIndex = 14
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 6)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(109, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.Transparent
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Mongolian Baiti", 11.25F)
        btnSettings.ForeColor = Color.Beige
        btnSettings.Location = New Point(3, 252)
        btnSettings.Margin = New Padding(3, 2, 3, 2)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(126, 42)
        btnSettings.TabIndex = 5
        btnSettings.Text = "⚙ Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Transparent
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Mongolian Baiti", 11.25F)
        btnReports.ForeColor = Color.Beige
        btnReports.Location = New Point(3, 210)
        btnReports.Margin = New Padding(3, 2, 3, 2)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(126, 42)
        btnReports.TabIndex = 2
        btnReports.Text = "📊 Reports "
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.Beige
        btnDashboard.Location = New Point(3, 85)
        btnDashboard.Margin = New Padding(3, 2, 3, 2)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(126, 42)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "🏠 Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(235, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 24)
        Label1.TabIndex = 17
        Label1.Text = "Welcome, Admin!"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSubtitle.Location = New Point(235, 112)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(311, 15)
        lblSubtitle.TabIndex = 25
        lblSubtitle.Text = "Here's what's happening at H.A.J.K High Rise Hotel today."
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Segoe UI", 9.0F)
        lblDateTime.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDateTime.Location = New Point(893, 86)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(104, 15)
        lblDateTime.TabIndex = 24
        lblDateTime.Text = "Mon, Mar 19, 2026"
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tmrDashboard
        ' 
        tmrDashboard.Interval = 1000
        ' 
        ' cardRooms
        ' 
        cardRooms.BackColor = Color.White
        cardRooms.Controls.Add(topStrip1)
        cardRooms.Controls.Add(lblIconRooms)
        cardRooms.Controls.Add(lblTitleAvailableRooms)
        cardRooms.Controls.Add(lblAvailableRooms)
        cardRooms.Location = New Point(162, 146)
        cardRooms.Margin = New Padding(3, 2, 3, 2)
        cardRooms.Name = "cardRooms"
        cardRooms.Size = New Size(266, 98)
        cardRooms.TabIndex = 18
        ' 
        ' topStrip1
        ' 
        topStrip1.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip1.Dock = DockStyle.Top
        topStrip1.Location = New Point(0, 0)
        topStrip1.Margin = New Padding(3, 2, 3, 2)
        topStrip1.Name = "topStrip1"
        topStrip1.Size = New Size(266, 3)
        topStrip1.TabIndex = 0
        ' 
        ' lblIconRooms
        ' 
        lblIconRooms.AutoSize = True
        lblIconRooms.Font = New Font("Segoe UI", 12.0F)
        lblIconRooms.Location = New Point(13, 14)
        lblIconRooms.Name = "lblIconRooms"
        lblIconRooms.Size = New Size(32, 21)
        lblIconRooms.TabIndex = 1
        lblIconRooms.Text = "🛏️"
        ' 
        ' lblTitleAvailableRooms
        ' 
        lblTitleAvailableRooms.AutoSize = True
        lblTitleAvailableRooms.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTitleAvailableRooms.ForeColor = Color.DimGray
        lblTitleAvailableRooms.Location = New Point(44, 16)
        lblTitleAvailableRooms.Name = "lblTitleAvailableRooms"
        lblTitleAvailableRooms.Size = New Size(98, 15)
        lblTitleAvailableRooms.TabIndex = 2
        lblTitleAvailableRooms.Text = "Available Rooms"
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblAvailableRooms.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblAvailableRooms.Location = New Point(13, 44)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(77, 37)
        lblAvailableRooms.TabIndex = 3
        lblAvailableRooms.Text = "0/50"
        ' 
        ' cardArriving
        ' 
        cardArriving.BackColor = Color.White
        cardArriving.Controls.Add(topStrip2)
        cardArriving.Controls.Add(lblIconArriving)
        cardArriving.Controls.Add(lblTitleArrivingToday)
        cardArriving.Controls.Add(lblArrivingToday)
        cardArriving.Location = New Point(446, 146)
        cardArriving.Margin = New Padding(3, 2, 3, 2)
        cardArriving.Name = "cardArriving"
        cardArriving.Size = New Size(266, 98)
        cardArriving.TabIndex = 19
        ' 
        ' topStrip2
        ' 
        topStrip2.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip2.Dock = DockStyle.Top
        topStrip2.Location = New Point(0, 0)
        topStrip2.Margin = New Padding(3, 2, 3, 2)
        topStrip2.Name = "topStrip2"
        topStrip2.Size = New Size(266, 3)
        topStrip2.TabIndex = 0
        ' 
        ' lblIconArriving
        ' 
        lblIconArriving.AutoSize = True
        lblIconArriving.Font = New Font("Segoe UI", 12.0F)
        lblIconArriving.Location = New Point(13, 14)
        lblIconArriving.Name = "lblIconArriving"
        lblIconArriving.Size = New Size(32, 21)
        lblIconArriving.TabIndex = 1
        lblIconArriving.Text = "📥"
        ' 
        ' lblTitleArrivingToday
        ' 
        lblTitleArrivingToday.AutoSize = True
        lblTitleArrivingToday.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTitleArrivingToday.ForeColor = Color.DimGray
        lblTitleArrivingToday.Location = New Point(44, 16)
        lblTitleArrivingToday.Name = "lblTitleArrivingToday"
        lblTitleArrivingToday.Size = New Size(49, 15)
        lblTitleArrivingToday.TabIndex = 2
        lblTitleArrivingToday.Text = "Arrivals"
        ' 
        ' lblArrivingToday
        ' 
        lblArrivingToday.AutoSize = True
        lblArrivingToday.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblArrivingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblArrivingToday.Location = New Point(13, 44)
        lblArrivingToday.Name = "lblArrivingToday"
        lblArrivingToday.Size = New Size(33, 37)
        lblArrivingToday.TabIndex = 3
        lblArrivingToday.Text = "0"
        ' 
        ' cardDeparting
        ' 
        cardDeparting.BackColor = Color.White
        cardDeparting.Controls.Add(topStrip3)
        cardDeparting.Controls.Add(lblIconDeparting)
        cardDeparting.Controls.Add(lblTitleDepartingToday)
        cardDeparting.Controls.Add(lblDepartingToday)
        cardDeparting.Location = New Point(731, 146)
        cardDeparting.Margin = New Padding(3, 2, 3, 2)
        cardDeparting.Name = "cardDeparting"
        cardDeparting.Size = New Size(266, 98)
        cardDeparting.TabIndex = 20
        ' 
        ' topStrip3
        ' 
        topStrip3.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip3.Dock = DockStyle.Top
        topStrip3.Location = New Point(0, 0)
        topStrip3.Margin = New Padding(3, 2, 3, 2)
        topStrip3.Name = "topStrip3"
        topStrip3.Size = New Size(266, 3)
        topStrip3.TabIndex = 0
        ' 
        ' lblIconDeparting
        ' 
        lblIconDeparting.AutoSize = True
        lblIconDeparting.Font = New Font("Segoe UI", 12.0F)
        lblIconDeparting.Location = New Point(13, 14)
        lblIconDeparting.Name = "lblIconDeparting"
        lblIconDeparting.Size = New Size(32, 21)
        lblIconDeparting.TabIndex = 1
        lblIconDeparting.Text = "📤"
        ' 
        ' lblTitleDepartingToday
        ' 
        lblTitleDepartingToday.AutoSize = True
        lblTitleDepartingToday.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTitleDepartingToday.ForeColor = Color.DimGray
        lblTitleDepartingToday.Location = New Point(44, 16)
        lblTitleDepartingToday.Name = "lblTitleDepartingToday"
        lblTitleDepartingToday.Size = New Size(70, 15)
        lblTitleDepartingToday.TabIndex = 2
        lblTitleDepartingToday.Text = "Departures"
        ' 
        ' lblDepartingToday
        ' 
        lblDepartingToday.AutoSize = True
        lblDepartingToday.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblDepartingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDepartingToday.Location = New Point(13, 44)
        lblDepartingToday.Name = "lblDepartingToday"
        lblDepartingToday.Size = New Size(77, 37)
        lblDepartingToday.TabIndex = 3
        lblDepartingToday.Text = "0/50"
        ' 
        ' cardInHouse
        ' 
        cardInHouse.BackColor = Color.White
        cardInHouse.Controls.Add(topStrip4)
        cardInHouse.Controls.Add(lblIconInHouse)
        cardInHouse.Controls.Add(lblTitleInHouse)
        cardInHouse.Controls.Add(lblInHouse)
        cardInHouse.Location = New Point(162, 259)
        cardInHouse.Margin = New Padding(3, 2, 3, 2)
        cardInHouse.Name = "cardInHouse"
        cardInHouse.Size = New Size(266, 98)
        cardInHouse.TabIndex = 21
        ' 
        ' topStrip4
        ' 
        topStrip4.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip4.Dock = DockStyle.Top
        topStrip4.Location = New Point(0, 0)
        topStrip4.Margin = New Padding(3, 2, 3, 2)
        topStrip4.Name = "topStrip4"
        topStrip4.Size = New Size(266, 3)
        topStrip4.TabIndex = 0
        ' 
        ' lblIconInHouse
        ' 
        lblIconInHouse.AutoSize = True
        lblIconInHouse.Font = New Font("Segoe UI", 12.0F)
        lblIconInHouse.Location = New Point(13, 14)
        lblIconInHouse.Name = "lblIconInHouse"
        lblIconInHouse.Size = New Size(32, 21)
        lblIconInHouse.TabIndex = 1
        lblIconInHouse.Text = "👥"
        ' 
        ' lblTitleInHouse
        ' 
        lblTitleInHouse.AutoSize = True
        lblTitleInHouse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTitleInHouse.ForeColor = Color.DimGray
        lblTitleInHouse.Location = New Point(44, 16)
        lblTitleInHouse.Name = "lblTitleInHouse"
        lblTitleInHouse.Size = New Size(99, 15)
        lblTitleInHouse.TabIndex = 2
        lblTitleInHouse.Text = "In-House Guests"
        ' 
        ' lblInHouse
        ' 
        lblInHouse.AutoSize = True
        lblInHouse.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblInHouse.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblInHouse.Location = New Point(13, 44)
        lblInHouse.Name = "lblInHouse"
        lblInHouse.Size = New Size(33, 37)
        lblInHouse.TabIndex = 3
        lblInHouse.Text = "0"
        ' 
        ' cardRevenue
        ' 
        cardRevenue.BackColor = Color.White
        cardRevenue.Controls.Add(topStrip5)
        cardRevenue.Controls.Add(lblIconRevenue)
        cardRevenue.Controls.Add(lblTitleDailyRevenue)
        cardRevenue.Controls.Add(lblDailyRevenue)
        cardRevenue.Location = New Point(446, 259)
        cardRevenue.Margin = New Padding(3, 2, 3, 2)
        cardRevenue.Name = "cardRevenue"
        cardRevenue.Size = New Size(266, 98)
        cardRevenue.TabIndex = 22
        ' 
        ' topStrip5
        ' 
        topStrip5.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip5.Dock = DockStyle.Top
        topStrip5.Location = New Point(0, 0)
        topStrip5.Margin = New Padding(3, 2, 3, 2)
        topStrip5.Name = "topStrip5"
        topStrip5.Size = New Size(266, 3)
        topStrip5.TabIndex = 0
        ' 
        ' lblIconRevenue
        ' 
        lblIconRevenue.AutoSize = True
        lblIconRevenue.Font = New Font("Segoe UI", 12.0F)
        lblIconRevenue.Location = New Point(13, 14)
        lblIconRevenue.Name = "lblIconRevenue"
        lblIconRevenue.Size = New Size(32, 21)
        lblIconRevenue.TabIndex = 1
        lblIconRevenue.Text = "💵"
        ' 
        ' lblTitleDailyRevenue
        ' 
        lblTitleDailyRevenue.AutoSize = True
        lblTitleDailyRevenue.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTitleDailyRevenue.ForeColor = Color.DimGray
        lblTitleDailyRevenue.Location = New Point(44, 16)
        lblTitleDailyRevenue.Name = "lblTitleDailyRevenue"
        lblTitleDailyRevenue.Size = New Size(87, 15)
        lblTitleDailyRevenue.TabIndex = 2
        lblTitleDailyRevenue.Text = "Daily Revenue"
        ' 
        ' lblDailyRevenue
        ' 
        lblDailyRevenue.AutoSize = True
        lblDailyRevenue.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblDailyRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDailyRevenue.Location = New Point(13, 44)
        lblDailyRevenue.Name = "lblDailyRevenue"
        lblDailyRevenue.Size = New Size(89, 37)
        lblDailyRevenue.TabIndex = 3
        lblDailyRevenue.Text = "₱0.00"
        ' 
        ' cardOccupancy
        ' 
        cardOccupancy.BackColor = Color.White
        cardOccupancy.Controls.Add(topStrip6)
        cardOccupancy.Controls.Add(lblIconOccupancy)
        cardOccupancy.Controls.Add(lblTitleOccupancyRate)
        cardOccupancy.Controls.Add(lblOccupancyRate)
        cardOccupancy.Location = New Point(731, 259)
        cardOccupancy.Margin = New Padding(3, 2, 3, 2)
        cardOccupancy.Name = "cardOccupancy"
        cardOccupancy.Size = New Size(266, 98)
        cardOccupancy.TabIndex = 23
        ' 
        ' topStrip6
        ' 
        topStrip6.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip6.Dock = DockStyle.Top
        topStrip6.Location = New Point(0, 0)
        topStrip6.Margin = New Padding(3, 2, 3, 2)
        topStrip6.Name = "topStrip6"
        topStrip6.Size = New Size(266, 3)
        topStrip6.TabIndex = 0
        ' 
        ' lblIconOccupancy
        ' 
        lblIconOccupancy.AutoSize = True
        lblIconOccupancy.Font = New Font("Segoe UI", 12.0F)
        lblIconOccupancy.Location = New Point(13, 14)
        lblIconOccupancy.Name = "lblIconOccupancy"
        lblIconOccupancy.Size = New Size(32, 21)
        lblIconOccupancy.TabIndex = 1
        lblIconOccupancy.Text = "📈"
        ' 
        ' lblTitleOccupancyRate
        ' 
        lblTitleOccupancyRate.AutoSize = True
        lblTitleOccupancyRate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTitleOccupancyRate.ForeColor = Color.DimGray
        lblTitleOccupancyRate.Location = New Point(44, 16)
        lblTitleOccupancyRate.Name = "lblTitleOccupancyRate"
        lblTitleOccupancyRate.Size = New Size(96, 15)
        lblTitleOccupancyRate.TabIndex = 2
        lblTitleOccupancyRate.Text = "Occupancy Rate"
        ' 
        ' lblOccupancyRate
        ' 
        lblOccupancyRate.AutoSize = True
        lblOccupancyRate.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblOccupancyRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblOccupancyRate.Location = New Point(13, 44)
        lblOccupancyRate.Name = "lblOccupancyRate"
        lblOccupancyRate.Size = New Size(56, 37)
        lblOccupancyRate.TabIndex = 3
        lblOccupancyRate.Text = "0%"
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1034, 562)
        Controls.Add(cardOccupancy)
        Controls.Add(cardRevenue)
        Controls.Add(cardInHouse)
        Controls.Add(cardDeparting)
        Controls.Add(cardArriving)
        Controls.Add(cardRooms)
        Controls.Add(lblDateTime)
        Controls.Add(lblSubtitle)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "H.A.J.K High Rise Hotel Reservation System"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        cardRooms.ResumeLayout(False)
        cardRooms.PerformLayout()
        cardArriving.ResumeLayout(False)
        cardArriving.PerformLayout()
        cardDeparting.ResumeLayout(False)
        cardDeparting.PerformLayout()
        cardInHouse.ResumeLayout(False)
        cardInHouse.PerformLayout()
        cardRevenue.ResumeLayout(False)
        cardRevenue.PerformLayout()
        cardOccupancy.ResumeLayout(False)
        cardOccupancy.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblDepartingToday As Label
    Friend WithEvents lblArrivingToday As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblHotelName As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents tmrDashboard As Timer
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents lblInHouse As Label
    Friend WithEvents lblOccupancyRate As Label
    Friend WithEvents lblDailyRevenue As Label

    ' Card Containers & Icons
    Friend WithEvents cardRooms As Panel
    Friend WithEvents cardArriving As Panel
    Friend WithEvents cardDeparting As Panel
    Friend WithEvents cardInHouse As Panel
    Friend WithEvents cardRevenue As Panel
    Friend WithEvents cardOccupancy As Panel
    Friend WithEvents lblIconRooms As Label
    Friend WithEvents lblIconArriving As Label
    Friend WithEvents lblIconDeparting As Label
    Friend WithEvents lblIconInHouse As Label
    Friend WithEvents lblIconRevenue As Label
    Friend WithEvents lblIconOccupancy As Label
    Friend WithEvents lblTitleAvailableRooms As Label
    Friend WithEvents lblTitleArrivingToday As Label
    Friend WithEvents lblTitleDepartingToday As Label
    Friend WithEvents lblTitleInHouse As Label
    Friend WithEvents lblTitleDailyRevenue As Label
    Friend WithEvents lblTitleOccupancyRate As Label
    Friend WithEvents topStrip1 As Panel
    Friend WithEvents topStrip2 As Panel
    Friend WithEvents topStrip3 As Panel
    Friend WithEvents topStrip4 As Panel
    Friend WithEvents topStrip5 As Panel
    Friend WithEvents topStrip6 As Panel
End Class