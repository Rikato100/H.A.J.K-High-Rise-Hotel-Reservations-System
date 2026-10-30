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
        tmrDashboard = New Timer(components)
        pnlContent = New Panel()
        groupReservations = New Panel()
        lblReservationsGroupTitle = New Label()
        cardArriving = New Panel()
        topStrip2 = New Panel()
        lblIconArriving = New Label()
        lblTitleArrivingToday = New Label()
        lblArrivingToday = New Label()
        cardInHouse = New Panel()
        topStrip4 = New Panel()
        lblIconInHouse = New Label()
        lblTitleInHouse = New Label()
        lblInHouse = New Label()
        cardDeparting = New Panel()
        topStrip3 = New Panel()
        lblIconDeparting = New Label()
        lblTitleDepartingToday = New Label()
        lblDepartingToday = New Label()
        cardMonthlyRevenue = New Panel()
        topStrip7 = New Panel()
        lblIconMonthlyRevenue = New Label()
        lblTitleMonthlyRevenue = New Label()
        lblMonthlyRevenue = New Label()
        cardOccupancy = New Panel()
        topStrip6 = New Panel()
        lblIconOccupancy = New Label()
        lblTitleOccupancyRate = New Label()
        lblOccupancyRate = New Label()
        cardRevenue = New Panel()
        topStrip5 = New Panel()
        lblIconRevenue = New Label()
        lblTitleDailyRevenue = New Label()
        lblDailyRevenue = New Label()
        cardRooms = New Panel()
        topStrip1 = New Panel()
        lblIconRooms = New Label()
        lblTitleAvailableRooms = New Label()
        lblAvailableRooms = New Label()
        lblDateTime = New Label()
        lblSubtitle = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        pnlContent.SuspendLayout()
        groupReservations.SuspendLayout()
        cardArriving.SuspendLayout()
        cardInHouse.SuspendLayout()
        cardDeparting.SuspendLayout()
        cardMonthlyRevenue.SuspendLayout()
        cardOccupancy.SuspendLayout()
        cardRevenue.SuspendLayout()
        cardRooms.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(lblTagline)
        Panel2.Controls.Add(lblHotelName)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(150, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 112)
        Panel2.TabIndex = 15
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
        ' lblTagline
        ' 
        lblTagline.AutoSize = True
        lblTagline.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Color.Beige
        lblTagline.Location = New Point(13, 59)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(264, 24)
        lblTagline.TabIndex = 15
        lblTagline.Text = "Where every stay feels extraordinary"
        ' 
        ' lblHotelName
        ' 
        lblHotelName.AutoSize = True
        lblHotelName.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold)
        lblHotelName.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblHotelName.Location = New Point(7, 12)
        lblHotelName.Name = "lblHotelName"
        lblHotelName.Size = New Size(404, 40)
        lblHotelName.TabIndex = 0
        lblHotelName.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' btnRooms
        ' 
        btnRooms.BackColor = Color.Transparent
        btnRooms.FlatAppearance.BorderColor = Color.Beige
        btnRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRooms.ForeColor = Color.Beige
        btnRooms.Location = New Point(3, 168)
        btnRooms.Margin = New Padding(3, 4, 3, 4)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(144, 56)
        btnRooms.TabIndex = 2
        btnRooms.Text = "🛏 Rooms Management"
        btnRooms.UseVisualStyleBackColor = False
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = Color.Transparent
        btnStaff.FlatAppearance.BorderColor = Color.Beige
        btnStaff.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Mongolian Baiti", 11.25F)
        btnStaff.ForeColor = Color.Beige
        btnStaff.Location = New Point(3, 224)
        btnStaff.Margin = New Padding(3, 4, 3, 4)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(144, 56)
        btnStaff.TabIndex = 8
        btnStaff.Text = "👥 Staff Management"
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderColor = Color.Beige
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Mongolian Baiti", 11.25F)
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 541)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(144, 56)
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(150, 749)
        Panel1.TabIndex = 14
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
        btnSettings.FlatAppearance.BorderColor = Color.Beige
        btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Mongolian Baiti", 11.25F)
        btnSettings.ForeColor = Color.Beige
        btnSettings.Location = New Point(3, 336)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(144, 56)
        btnSettings.TabIndex = 5
        btnSettings.Text = "⚙ Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Transparent
        btnReports.FlatAppearance.BorderColor = Color.Beige
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Mongolian Baiti", 11.25F)
        btnReports.ForeColor = Color.Beige
        btnReports.Location = New Point(3, 280)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(144, 56)
        btnReports.TabIndex = 2
        btnReports.Text = "📊 Reports "
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.FlatAppearance.BorderColor = Color.Beige
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(105), CByte(20), CByte(35))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.Beige
        btnDashboard.Location = New Point(3, 113)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(144, 56)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "🏠 Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' tmrDashboard
        ' 
        tmrDashboard.Interval = 1000
        ' 
        ' pnlContent
        ' 
        pnlContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlContent.BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        pnlContent.Controls.Add(groupReservations)
        pnlContent.Controls.Add(cardMonthlyRevenue)
        pnlContent.Controls.Add(cardOccupancy)
        pnlContent.Controls.Add(cardRevenue)
        pnlContent.Controls.Add(cardRooms)
        pnlContent.Controls.Add(lblDateTime)
        pnlContent.Controls.Add(lblSubtitle)
        pnlContent.Controls.Add(Label1)
        pnlContent.Location = New Point(150, 112)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1032, 637)
        pnlContent.TabIndex = 28
        ' 
        ' groupReservations
        ' 
        groupReservations.BackColor = Color.FromArgb(CByte(250), CByte(245), CByte(235))
        groupReservations.BorderStyle = BorderStyle.FixedSingle
        groupReservations.Controls.Add(lblReservationsGroupTitle)
        groupReservations.Controls.Add(cardArriving)
        groupReservations.Controls.Add(cardInHouse)
        groupReservations.Controls.Add(cardDeparting)
        groupReservations.Location = New Point(691, 96)
        groupReservations.Margin = New Padding(3, 4, 3, 4)
        groupReservations.Name = "groupReservations"
        groupReservations.Size = New Size(303, 446)
        groupReservations.TabIndex = 27
        ' 
        ' lblReservationsGroupTitle
        ' 
        lblReservationsGroupTitle.AutoSize = True
        lblReservationsGroupTitle.Font = New Font("Segoe UI Black", 13F, FontStyle.Bold)
        lblReservationsGroupTitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblReservationsGroupTitle.Location = New Point(79, 11)
        lblReservationsGroupTitle.Name = "lblReservationsGroupTitle"
        lblReservationsGroupTitle.Size = New Size(153, 30)
        lblReservationsGroupTitle.TabIndex = 0
        lblReservationsGroupTitle.Text = "Reservations"
        ' 
        ' cardArriving
        ' 
        cardArriving.BackColor = Color.White
        cardArriving.BorderStyle = BorderStyle.FixedSingle
        cardArriving.Controls.Add(topStrip2)
        cardArriving.Controls.Add(lblIconArriving)
        cardArriving.Controls.Add(lblTitleArrivingToday)
        cardArriving.Controls.Add(lblArrivingToday)
        cardArriving.Location = New Point(26, 57)
        cardArriving.Name = "cardArriving"
        cardArriving.Size = New Size(247, 113)
        cardArriving.TabIndex = 19
        ' 
        ' topStrip2
        ' 
        topStrip2.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip2.Dock = DockStyle.Top
        topStrip2.Location = New Point(0, 0)
        topStrip2.Margin = New Padding(3, 4, 3, 4)
        topStrip2.Name = "topStrip2"
        topStrip2.Size = New Size(245, 4)
        topStrip2.TabIndex = 0
        ' 
        ' lblIconArriving
        ' 
        lblIconArriving.AutoSize = True
        lblIconArriving.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconArriving.Location = New Point(11, 16)
        lblIconArriving.Name = "lblIconArriving"
        lblIconArriving.Size = New Size(48, 32)
        lblIconArriving.TabIndex = 1
        lblIconArriving.Text = "📥"
        ' 
        ' lblTitleArrivingToday
        ' 
        lblTitleArrivingToday.AutoSize = True
        lblTitleArrivingToday.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleArrivingToday.ForeColor = Color.DimGray
        lblTitleArrivingToday.Location = New Point(51, 16)
        lblTitleArrivingToday.Name = "lblTitleArrivingToday"
        lblTitleArrivingToday.Size = New Size(110, 32)
        lblTitleArrivingToday.TabIndex = 2
        lblTitleArrivingToday.Text = "Arriving"
        ' 
        ' lblArrivingToday
        ' 
        lblArrivingToday.AutoSize = True
        lblArrivingToday.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblArrivingToday.Location = New Point(103, 56)
        lblArrivingToday.Name = "lblArrivingToday"
        lblArrivingToday.Size = New Size(35, 41)
        lblArrivingToday.TabIndex = 3
        lblArrivingToday.Text = "0"
        ' 
        ' cardInHouse
        ' 
        cardInHouse.BackColor = Color.White
        cardInHouse.BorderStyle = BorderStyle.FixedSingle
        cardInHouse.Controls.Add(topStrip4)
        cardInHouse.Controls.Add(lblIconInHouse)
        cardInHouse.Controls.Add(lblTitleInHouse)
        cardInHouse.Controls.Add(lblInHouse)
        cardInHouse.Location = New Point(26, 183)
        cardInHouse.Name = "cardInHouse"
        cardInHouse.Size = New Size(247, 113)
        cardInHouse.TabIndex = 21
        ' 
        ' topStrip4
        ' 
        topStrip4.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip4.Dock = DockStyle.Top
        topStrip4.Location = New Point(0, 0)
        topStrip4.Margin = New Padding(3, 4, 3, 4)
        topStrip4.Name = "topStrip4"
        topStrip4.Size = New Size(245, 4)
        topStrip4.TabIndex = 0
        ' 
        ' lblIconInHouse
        ' 
        lblIconInHouse.AutoSize = True
        lblIconInHouse.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconInHouse.Location = New Point(11, 16)
        lblIconInHouse.Name = "lblIconInHouse"
        lblIconInHouse.Size = New Size(48, 32)
        lblIconInHouse.TabIndex = 1
        lblIconInHouse.Text = "👥"
        ' 
        ' lblTitleInHouse
        ' 
        lblTitleInHouse.AutoSize = True
        lblTitleInHouse.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleInHouse.ForeColor = Color.DimGray
        lblTitleInHouse.Location = New Point(51, 16)
        lblTitleInHouse.Name = "lblTitleInHouse"
        lblTitleInHouse.Size = New Size(117, 32)
        lblTitleInHouse.TabIndex = 2
        lblTitleInHouse.Text = "In-house"
        ' 
        ' lblInHouse
        ' 
        lblInHouse.AutoSize = True
        lblInHouse.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblInHouse.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblInHouse.Location = New Point(103, 60)
        lblInHouse.Name = "lblInHouse"
        lblInHouse.Size = New Size(33, 37)
        lblInHouse.TabIndex = 3
        lblInHouse.Text = "0"
        ' 
        ' cardDeparting
        ' 
        cardDeparting.BackColor = Color.White
        cardDeparting.BorderStyle = BorderStyle.FixedSingle
        cardDeparting.Controls.Add(topStrip3)
        cardDeparting.Controls.Add(lblIconDeparting)
        cardDeparting.Controls.Add(lblTitleDepartingToday)
        cardDeparting.Controls.Add(lblDepartingToday)
        cardDeparting.Location = New Point(26, 307)
        cardDeparting.Name = "cardDeparting"
        cardDeparting.Size = New Size(247, 113)
        cardDeparting.TabIndex = 20
        ' 
        ' topStrip3
        ' 
        topStrip3.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip3.Dock = DockStyle.Top
        topStrip3.Location = New Point(0, 0)
        topStrip3.Margin = New Padding(3, 4, 3, 4)
        topStrip3.Name = "topStrip3"
        topStrip3.Size = New Size(245, 4)
        topStrip3.TabIndex = 0
        ' 
        ' lblIconDeparting
        ' 
        lblIconDeparting.AutoSize = True
        lblIconDeparting.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconDeparting.Location = New Point(11, 16)
        lblIconDeparting.Name = "lblIconDeparting"
        lblIconDeparting.Size = New Size(48, 32)
        lblIconDeparting.TabIndex = 1
        lblIconDeparting.Text = "📤"
        ' 
        ' lblTitleDepartingToday
        ' 
        lblTitleDepartingToday.AutoSize = True
        lblTitleDepartingToday.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleDepartingToday.ForeColor = Color.DimGray
        lblTitleDepartingToday.Location = New Point(51, 16)
        lblTitleDepartingToday.Name = "lblTitleDepartingToday"
        lblTitleDepartingToday.Size = New Size(130, 32)
        lblTitleDepartingToday.TabIndex = 2
        lblTitleDepartingToday.Text = "Departing"
        ' 
        ' lblDepartingToday
        ' 
        lblDepartingToday.AutoSize = True
        lblDepartingToday.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblDepartingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDepartingToday.Location = New Point(103, 60)
        lblDepartingToday.Name = "lblDepartingToday"
        lblDepartingToday.Size = New Size(33, 37)
        lblDepartingToday.TabIndex = 3
        lblDepartingToday.Text = "0"
        ' 
        ' cardMonthlyRevenue
        ' 
        cardMonthlyRevenue.BackColor = Color.White
        cardMonthlyRevenue.BorderStyle = BorderStyle.FixedSingle
        cardMonthlyRevenue.Controls.Add(topStrip7)
        cardMonthlyRevenue.Controls.Add(lblIconMonthlyRevenue)
        cardMonthlyRevenue.Controls.Add(lblTitleMonthlyRevenue)
        cardMonthlyRevenue.Controls.Add(lblMonthlyRevenue)
        cardMonthlyRevenue.Location = New Point(363, 329)
        cardMonthlyRevenue.Name = "cardMonthlyRevenue"
        cardMonthlyRevenue.Size = New Size(303, 213)
        cardMonthlyRevenue.TabIndex = 26
        ' 
        ' topStrip7
        ' 
        topStrip7.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip7.Dock = DockStyle.Top
        topStrip7.Location = New Point(0, 0)
        topStrip7.Margin = New Padding(3, 4, 3, 4)
        topStrip7.Name = "topStrip7"
        topStrip7.Size = New Size(301, 4)
        topStrip7.TabIndex = 0
        ' 
        ' lblIconMonthlyRevenue
        ' 
        lblIconMonthlyRevenue.AutoSize = True
        lblIconMonthlyRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconMonthlyRevenue.Location = New Point(17, 24)
        lblIconMonthlyRevenue.Name = "lblIconMonthlyRevenue"
        lblIconMonthlyRevenue.Size = New Size(48, 32)
        lblIconMonthlyRevenue.TabIndex = 1
        lblIconMonthlyRevenue.Text = "💰"
        ' 
        ' lblTitleMonthlyRevenue
        ' 
        lblTitleMonthlyRevenue.AutoSize = True
        lblTitleMonthlyRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleMonthlyRevenue.ForeColor = Color.DimGray
        lblTitleMonthlyRevenue.Location = New Point(59, 24)
        lblTitleMonthlyRevenue.Name = "lblTitleMonthlyRevenue"
        lblTitleMonthlyRevenue.Size = New Size(220, 32)
        lblTitleMonthlyRevenue.TabIndex = 2
        lblTitleMonthlyRevenue.Text = "Monthly Revenue"
        ' 
        ' lblMonthlyRevenue
        ' 
        lblMonthlyRevenue.AutoSize = True
        lblMonthlyRevenue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblMonthlyRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblMonthlyRevenue.Location = New Point(40, 100)
        lblMonthlyRevenue.Name = "lblMonthlyRevenue"
        lblMonthlyRevenue.Size = New Size(140, 60)
        lblMonthlyRevenue.TabIndex = 3
        lblMonthlyRevenue.Text = "₱0.00"
        ' 
        ' cardOccupancy
        ' 
        cardOccupancy.BackColor = Color.White
        cardOccupancy.BorderStyle = BorderStyle.FixedSingle
        cardOccupancy.Controls.Add(topStrip6)
        cardOccupancy.Controls.Add(lblIconOccupancy)
        cardOccupancy.Controls.Add(lblTitleOccupancyRate)
        cardOccupancy.Controls.Add(lblOccupancyRate)
        cardOccupancy.Location = New Point(363, 96)
        cardOccupancy.Name = "cardOccupancy"
        cardOccupancy.Size = New Size(303, 213)
        cardOccupancy.TabIndex = 23
        ' 
        ' topStrip6
        ' 
        topStrip6.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip6.Dock = DockStyle.Top
        topStrip6.Location = New Point(0, 0)
        topStrip6.Margin = New Padding(3, 4, 3, 4)
        topStrip6.Name = "topStrip6"
        topStrip6.Size = New Size(301, 4)
        topStrip6.TabIndex = 0
        ' 
        ' lblIconOccupancy
        ' 
        lblIconOccupancy.AutoSize = True
        lblIconOccupancy.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconOccupancy.Location = New Point(17, 24)
        lblIconOccupancy.Name = "lblIconOccupancy"
        lblIconOccupancy.Size = New Size(48, 32)
        lblIconOccupancy.TabIndex = 1
        lblIconOccupancy.Text = "📈"
        ' 
        ' lblTitleOccupancyRate
        ' 
        lblTitleOccupancyRate.AutoSize = True
        lblTitleOccupancyRate.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleOccupancyRate.ForeColor = Color.DimGray
        lblTitleOccupancyRate.Location = New Point(59, 24)
        lblTitleOccupancyRate.Name = "lblTitleOccupancyRate"
        lblTitleOccupancyRate.Size = New Size(199, 32)
        lblTitleOccupancyRate.TabIndex = 2
        lblTitleOccupancyRate.Text = "Occupancy Rate"
        ' 
        ' lblOccupancyRate
        ' 
        lblOccupancyRate.AutoSize = True
        lblOccupancyRate.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        lblOccupancyRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblOccupancyRate.Location = New Point(97, 92)
        lblOccupancyRate.Name = "lblOccupancyRate"
        lblOccupancyRate.Size = New Size(122, 81)
        lblOccupancyRate.TabIndex = 3
        lblOccupancyRate.Text = "0%"
        ' 
        ' cardRevenue
        ' 
        cardRevenue.BackColor = Color.White
        cardRevenue.BorderStyle = BorderStyle.FixedSingle
        cardRevenue.Controls.Add(topStrip5)
        cardRevenue.Controls.Add(lblIconRevenue)
        cardRevenue.Controls.Add(lblTitleDailyRevenue)
        cardRevenue.Controls.Add(lblDailyRevenue)
        cardRevenue.Location = New Point(27, 329)
        cardRevenue.Name = "cardRevenue"
        cardRevenue.Size = New Size(303, 213)
        cardRevenue.TabIndex = 22
        ' 
        ' topStrip5
        ' 
        topStrip5.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip5.Dock = DockStyle.Top
        topStrip5.Location = New Point(0, 0)
        topStrip5.Margin = New Padding(3, 4, 3, 4)
        topStrip5.Name = "topStrip5"
        topStrip5.Size = New Size(301, 4)
        topStrip5.TabIndex = 0
        ' 
        ' lblIconRevenue
        ' 
        lblIconRevenue.AutoSize = True
        lblIconRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconRevenue.Location = New Point(17, 24)
        lblIconRevenue.Name = "lblIconRevenue"
        lblIconRevenue.Size = New Size(48, 32)
        lblIconRevenue.TabIndex = 1
        lblIconRevenue.Text = "💵"
        ' 
        ' lblTitleDailyRevenue
        ' 
        lblTitleDailyRevenue.AutoSize = True
        lblTitleDailyRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleDailyRevenue.ForeColor = Color.DimGray
        lblTitleDailyRevenue.Location = New Point(62, 24)
        lblTitleDailyRevenue.Name = "lblTitleDailyRevenue"
        lblTitleDailyRevenue.Size = New Size(179, 32)
        lblTitleDailyRevenue.TabIndex = 2
        lblTitleDailyRevenue.Text = "Daily Revenue"
        ' 
        ' lblDailyRevenue
        ' 
        lblDailyRevenue.AutoSize = True
        lblDailyRevenue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblDailyRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDailyRevenue.Location = New Point(40, 100)
        lblDailyRevenue.Name = "lblDailyRevenue"
        lblDailyRevenue.Size = New Size(140, 60)
        lblDailyRevenue.TabIndex = 3
        lblDailyRevenue.Text = "₱0.00"
        ' 
        ' cardRooms
        ' 
        cardRooms.BackColor = Color.White
        cardRooms.BorderStyle = BorderStyle.FixedSingle
        cardRooms.Controls.Add(topStrip1)
        cardRooms.Controls.Add(lblIconRooms)
        cardRooms.Controls.Add(lblTitleAvailableRooms)
        cardRooms.Controls.Add(lblAvailableRooms)
        cardRooms.Location = New Point(27, 96)
        cardRooms.Name = "cardRooms"
        cardRooms.Size = New Size(303, 213)
        cardRooms.TabIndex = 18
        ' 
        ' topStrip1
        ' 
        topStrip1.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip1.Dock = DockStyle.Top
        topStrip1.Location = New Point(0, 0)
        topStrip1.Margin = New Padding(3, 4, 3, 4)
        topStrip1.Name = "topStrip1"
        topStrip1.Size = New Size(301, 4)
        topStrip1.TabIndex = 0
        ' 
        ' lblIconRooms
        ' 
        lblIconRooms.AutoSize = True
        lblIconRooms.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconRooms.Location = New Point(17, 24)
        lblIconRooms.Name = "lblIconRooms"
        lblIconRooms.Size = New Size(48, 32)
        lblIconRooms.TabIndex = 1
        lblIconRooms.Text = "🛏️"
        ' 
        ' lblTitleAvailableRooms
        ' 
        lblTitleAvailableRooms.AutoSize = True
        lblTitleAvailableRooms.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleAvailableRooms.ForeColor = Color.DimGray
        lblTitleAvailableRooms.Location = New Point(59, 24)
        lblTitleAvailableRooms.Name = "lblTitleAvailableRooms"
        lblTitleAvailableRooms.Size = New Size(209, 32)
        lblTitleAvailableRooms.TabIndex = 2
        lblTitleAvailableRooms.Text = "Available Rooms"
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableRooms.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblAvailableRooms.Location = New Point(114, 92)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(70, 81)
        lblAvailableRooms.TabIndex = 3
        lblAvailableRooms.Text = "0"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Segoe UI", 9F)
        lblDateTime.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDateTime.Location = New Point(798, 15)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(131, 20)
        lblDateTime.TabIndex = 24
        lblDateTime.Text = "Mon, Mar 19, 2026"
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSubtitle.Location = New Point(27, 51)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(388, 20)
        lblSubtitle.TabIndex = 25
        lblSubtitle.Text = "Here's what's happening at H.A.J.K High Rise Hotel today."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(27, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 30)
        Label1.TabIndex = 17
        Label1.Text = "Welcome, Admin!"
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1182, 749)
        Controls.Add(pnlContent)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "H.A.J.K High Rise Hotel Reservation System"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        groupReservations.ResumeLayout(False)
        groupReservations.PerformLayout()
        cardArriving.ResumeLayout(False)
        cardArriving.PerformLayout()
        cardInHouse.ResumeLayout(False)
        cardInHouse.PerformLayout()
        cardDeparting.ResumeLayout(False)
        cardDeparting.PerformLayout()
        cardMonthlyRevenue.ResumeLayout(False)
        cardMonthlyRevenue.PerformLayout()
        cardOccupancy.ResumeLayout(False)
        cardOccupancy.PerformLayout()
        cardRevenue.ResumeLayout(False)
        cardRevenue.PerformLayout()
        cardRooms.ResumeLayout(False)
        cardRooms.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnRooms As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblHotelName As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents tmrDashboard As Timer
    Friend WithEvents pnlContent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents cardRooms As Panel
    Friend WithEvents topStrip1 As Panel
    Friend WithEvents lblIconRooms As Label
    Friend WithEvents lblTitleAvailableRooms As Label
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents cardOccupancy As Panel
    Friend WithEvents topStrip6 As Panel
    Friend WithEvents lblIconOccupancy As Label
    Friend WithEvents lblTitleOccupancyRate As Label
    Friend WithEvents lblOccupancyRate As Label
    Friend WithEvents groupReservations As Panel
    Friend WithEvents lblReservationsGroupTitle As Label
    Friend WithEvents cardArriving As Panel
    Friend WithEvents topStrip2 As Panel
    Friend WithEvents lblIconArriving As Label
    Friend WithEvents lblTitleArrivingToday As Label
    Friend WithEvents lblArrivingToday As Label
    Friend WithEvents cardInHouse As Panel
    Friend WithEvents topStrip4 As Panel
    Friend WithEvents lblIconInHouse As Label
    Friend WithEvents lblTitleInHouse As Label
    Friend WithEvents lblInHouse As Label
    Friend WithEvents cardDeparting As Panel
    Friend WithEvents topStrip3 As Panel
    Friend WithEvents lblIconDeparting As Label
    Friend WithEvents lblTitleDepartingToday As Label
    Friend WithEvents lblDepartingToday As Label
    Friend WithEvents cardRevenue As Panel
    Friend WithEvents topStrip5 As Panel
    Friend WithEvents lblIconRevenue As Label
    Friend WithEvents lblTitleDailyRevenue As Label
    Friend WithEvents lblDailyRevenue As Label
    Friend WithEvents cardMonthlyRevenue As Panel
    Friend WithEvents topStrip7 As Panel
    Friend WithEvents lblIconMonthlyRevenue As Label
    Friend WithEvents lblTitleMonthlyRevenue As Label
    Friend WithEvents lblMonthlyRevenue As Label
End Class
