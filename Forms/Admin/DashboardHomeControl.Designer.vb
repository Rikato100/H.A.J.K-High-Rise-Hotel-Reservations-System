<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardHomeControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label1 = New Label()
        lblSubtitle = New Label()
        lblDateTime = New Label()
        cardRooms = New Panel()
        topStrip1 = New Panel()
        lblIconRooms = New Label()
        lblTitleAvailableRooms = New Label()
        lblAvailableRooms = New Label()
        cardOccupancy = New Panel()
        topStrip6 = New Panel()
        lblIconOccupancy = New Label()
        lblTitleOccupancyRate = New Label()
        lblOccupancyRate = New Label()
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
        cardRevenue = New Panel()
        topStrip5 = New Panel()
        lblIconRevenue = New Label()
        lblTitleDailyRevenue = New Label()
        lblDailyRevenue = New Label()
        cardMonthlyRevenue = New Panel()
        topStrip7 = New Panel()
        lblIconMonthlyRevenue = New Label()
        lblTitleMonthlyRevenue = New Label()
        lblMonthlyRevenue = New Label()
        tmrDashboard = New Timer(components)
        cardRooms.SuspendLayout()
        cardOccupancy.SuspendLayout()
        groupReservations.SuspendLayout()
        cardArriving.SuspendLayout()
        cardInHouse.SuspendLayout()
        cardDeparting.SuspendLayout()
        cardRevenue.SuspendLayout()
        cardMonthlyRevenue.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(24, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 24)
        Label1.TabIndex = 17
        Label1.Text = "Welcome, Admin!"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSubtitle.Location = New Point(24, 38)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(311, 15)
        lblSubtitle.TabIndex = 25
        lblSubtitle.Text = "Here's what's happening at H.A.J.K High Rise Hotel today."
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Segoe UI", 9F)
        lblDateTime.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDateTime.Location = New Point(714, 11)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(104, 15)
        lblDateTime.TabIndex = 24
        lblDateTime.Text = "Mon, Mar 19, 2026"
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cardRooms
        ' 
        cardRooms.BackColor = Color.Beige
        cardRooms.BorderStyle = BorderStyle.FixedSingle
        cardRooms.Controls.Add(topStrip1)
        cardRooms.Controls.Add(lblIconRooms)
        cardRooms.Controls.Add(lblTitleAvailableRooms)
        cardRooms.Controls.Add(lblAvailableRooms)
        cardRooms.Location = New Point(24, 72)
        cardRooms.Name = "cardRooms"
        cardRooms.Size = New Size(265, 160)
        cardRooms.TabIndex = 18
        ' 
        ' topStrip1
        ' 
        topStrip1.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip1.Dock = DockStyle.Top
        topStrip1.Location = New Point(0, 0)
        topStrip1.Name = "topStrip1"
        topStrip1.Size = New Size(263, 3)
        topStrip1.TabIndex = 0
        ' 
        ' lblIconRooms
        ' 
        lblIconRooms.AutoSize = True
        lblIconRooms.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconRooms.Location = New Point(15, 18)
        lblIconRooms.Name = "lblIconRooms"
        lblIconRooms.Size = New Size(34, 25)
        lblIconRooms.TabIndex = 1
        lblIconRooms.Text = "🛏️"
        ' 
        ' lblTitleAvailableRooms
        ' 
        lblTitleAvailableRooms.AutoSize = True
        lblTitleAvailableRooms.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleAvailableRooms.ForeColor = Color.DimGray
        lblTitleAvailableRooms.Location = New Point(52, 18)
        lblTitleAvailableRooms.Name = "lblTitleAvailableRooms"
        lblTitleAvailableRooms.Size = New Size(169, 25)
        lblTitleAvailableRooms.TabIndex = 2
        lblTitleAvailableRooms.Text = "Available Rooms"
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableRooms.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblAvailableRooms.Location = New Point(92, 69)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(56, 65)
        lblAvailableRooms.TabIndex = 3
        lblAvailableRooms.Text = "0"
        ' 
        ' cardOccupancy
        ' 
        cardOccupancy.BackColor = Color.Beige
        cardOccupancy.BorderStyle = BorderStyle.FixedSingle
        cardOccupancy.Controls.Add(topStrip6)
        cardOccupancy.Controls.Add(lblIconOccupancy)
        cardOccupancy.Controls.Add(lblTitleOccupancyRate)
        cardOccupancy.Controls.Add(lblOccupancyRate)
        cardOccupancy.Location = New Point(318, 72)
        cardOccupancy.Name = "cardOccupancy"
        cardOccupancy.Size = New Size(265, 160)
        cardOccupancy.TabIndex = 23
        ' 
        ' topStrip6
        ' 
        topStrip6.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip6.Dock = DockStyle.Top
        topStrip6.Location = New Point(0, 0)
        topStrip6.Name = "topStrip6"
        topStrip6.Size = New Size(263, 3)
        topStrip6.TabIndex = 0
        ' 
        ' lblIconOccupancy
        ' 
        lblIconOccupancy.AutoSize = True
        lblIconOccupancy.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconOccupancy.Location = New Point(15, 18)
        lblIconOccupancy.Name = "lblIconOccupancy"
        lblIconOccupancy.Size = New Size(34, 25)
        lblIconOccupancy.TabIndex = 1
        lblIconOccupancy.Text = "📈"
        ' 
        ' lblTitleOccupancyRate
        ' 
        lblTitleOccupancyRate.AutoSize = True
        lblTitleOccupancyRate.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleOccupancyRate.ForeColor = Color.DimGray
        lblTitleOccupancyRate.Location = New Point(52, 18)
        lblTitleOccupancyRate.Name = "lblTitleOccupancyRate"
        lblTitleOccupancyRate.Size = New Size(160, 25)
        lblTitleOccupancyRate.TabIndex = 2
        lblTitleOccupancyRate.Text = "Occupancy Rate"
        ' 
        ' lblOccupancyRate
        ' 
        lblOccupancyRate.AutoSize = True
        lblOccupancyRate.Font = New Font("Segoe UI", 36F, FontStyle.Bold)
        lblOccupancyRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblOccupancyRate.Location = New Point(80, 69)
        lblOccupancyRate.Name = "lblOccupancyRate"
        lblOccupancyRate.Size = New Size(98, 65)
        lblOccupancyRate.TabIndex = 3
        lblOccupancyRate.Text = "0%"
        ' 
        ' groupReservations
        ' 
        groupReservations.BackColor = Color.FromArgb(CByte(250), CByte(245), CByte(235))
        groupReservations.BorderStyle = BorderStyle.FixedSingle
        groupReservations.Controls.Add(lblReservationsGroupTitle)
        groupReservations.Controls.Add(cardArriving)
        groupReservations.Controls.Add(cardInHouse)
        groupReservations.Controls.Add(cardDeparting)
        groupReservations.Location = New Point(605, 72)
        groupReservations.Name = "groupReservations"
        groupReservations.Size = New Size(265, 335)
        groupReservations.TabIndex = 27
        ' 
        ' lblReservationsGroupTitle
        ' 
        lblReservationsGroupTitle.AutoSize = True
        lblReservationsGroupTitle.Font = New Font("Segoe UI Black", 13F, FontStyle.Bold)
        lblReservationsGroupTitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblReservationsGroupTitle.Location = New Point(69, 8)
        lblReservationsGroupTitle.Name = "lblReservationsGroupTitle"
        lblReservationsGroupTitle.Size = New Size(127, 25)
        lblReservationsGroupTitle.TabIndex = 0
        lblReservationsGroupTitle.Text = "Reservations"
        ' 
        ' cardArriving
        ' 
        cardArriving.BackColor = Color.Beige
        cardArriving.BorderStyle = BorderStyle.FixedSingle
        cardArriving.Controls.Add(topStrip2)
        cardArriving.Controls.Add(lblIconArriving)
        cardArriving.Controls.Add(lblTitleArrivingToday)
        cardArriving.Controls.Add(lblArrivingToday)
        cardArriving.Location = New Point(23, 43)
        cardArriving.Name = "cardArriving"
        cardArriving.Size = New Size(216, 85)
        cardArriving.TabIndex = 19
        ' 
        ' topStrip2
        ' 
        topStrip2.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip2.Dock = DockStyle.Top
        topStrip2.Location = New Point(0, 0)
        topStrip2.Name = "topStrip2"
        topStrip2.Size = New Size(214, 3)
        topStrip2.TabIndex = 0
        ' 
        ' lblIconArriving
        ' 
        lblIconArriving.AutoSize = True
        lblIconArriving.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconArriving.Location = New Point(10, 12)
        lblIconArriving.Name = "lblIconArriving"
        lblIconArriving.Size = New Size(34, 25)
        lblIconArriving.TabIndex = 1
        lblIconArriving.Text = "📥"
        ' 
        ' lblTitleArrivingToday
        ' 
        lblTitleArrivingToday.AutoSize = True
        lblTitleArrivingToday.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleArrivingToday.ForeColor = Color.DimGray
        lblTitleArrivingToday.Location = New Point(45, 12)
        lblTitleArrivingToday.Name = "lblTitleArrivingToday"
        lblTitleArrivingToday.Size = New Size(89, 25)
        lblTitleArrivingToday.TabIndex = 2
        lblTitleArrivingToday.Text = "Arriving"
        ' 
        ' lblArrivingToday
        ' 
        lblArrivingToday.AutoSize = True
        lblArrivingToday.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblArrivingToday.Location = New Point(90, 42)
        lblArrivingToday.Name = "lblArrivingToday"
        lblArrivingToday.Size = New Size(28, 32)
        lblArrivingToday.TabIndex = 3
        lblArrivingToday.Text = "0"
        ' 
        ' cardInHouse
        ' 
        cardInHouse.BackColor = Color.Beige
        cardInHouse.BorderStyle = BorderStyle.FixedSingle
        cardInHouse.Controls.Add(topStrip4)
        cardInHouse.Controls.Add(lblIconInHouse)
        cardInHouse.Controls.Add(lblTitleInHouse)
        cardInHouse.Controls.Add(lblInHouse)
        cardInHouse.Location = New Point(23, 137)
        cardInHouse.Name = "cardInHouse"
        cardInHouse.Size = New Size(216, 85)
        cardInHouse.TabIndex = 21
        ' 
        ' topStrip4
        ' 
        topStrip4.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip4.Dock = DockStyle.Top
        topStrip4.Location = New Point(0, 0)
        topStrip4.Name = "topStrip4"
        topStrip4.Size = New Size(214, 3)
        topStrip4.TabIndex = 0
        ' 
        ' lblIconInHouse
        ' 
        lblIconInHouse.AutoSize = True
        lblIconInHouse.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconInHouse.Location = New Point(10, 12)
        lblIconInHouse.Name = "lblIconInHouse"
        lblIconInHouse.Size = New Size(34, 25)
        lblIconInHouse.TabIndex = 1
        lblIconInHouse.Text = "👥"
        ' 
        ' lblTitleInHouse
        ' 
        lblTitleInHouse.AutoSize = True
        lblTitleInHouse.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleInHouse.ForeColor = Color.DimGray
        lblTitleInHouse.Location = New Point(45, 12)
        lblTitleInHouse.Name = "lblTitleInHouse"
        lblTitleInHouse.Size = New Size(95, 25)
        lblTitleInHouse.TabIndex = 2
        lblTitleInHouse.Text = "In-house"
        ' 
        ' lblInHouse
        ' 
        lblInHouse.AutoSize = True
        lblInHouse.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblInHouse.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblInHouse.Location = New Point(90, 45)
        lblInHouse.Name = "lblInHouse"
        lblInHouse.Size = New Size(26, 30)
        lblInHouse.TabIndex = 3
        lblInHouse.Text = "0"
        ' 
        ' cardDeparting
        ' 
        cardDeparting.BackColor = Color.Beige
        cardDeparting.BorderStyle = BorderStyle.FixedSingle
        cardDeparting.Controls.Add(topStrip3)
        cardDeparting.Controls.Add(lblIconDeparting)
        cardDeparting.Controls.Add(lblTitleDepartingToday)
        cardDeparting.Controls.Add(lblDepartingToday)
        cardDeparting.Location = New Point(23, 230)
        cardDeparting.Name = "cardDeparting"
        cardDeparting.Size = New Size(216, 85)
        cardDeparting.TabIndex = 20
        ' 
        ' topStrip3
        ' 
        topStrip3.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip3.Dock = DockStyle.Top
        topStrip3.Location = New Point(0, 0)
        topStrip3.Name = "topStrip3"
        topStrip3.Size = New Size(214, 3)
        topStrip3.TabIndex = 0
        ' 
        ' lblIconDeparting
        ' 
        lblIconDeparting.AutoSize = True
        lblIconDeparting.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconDeparting.Location = New Point(10, 12)
        lblIconDeparting.Name = "lblIconDeparting"
        lblIconDeparting.Size = New Size(34, 25)
        lblIconDeparting.TabIndex = 1
        lblIconDeparting.Text = "📤"
        ' 
        ' lblTitleDepartingToday
        ' 
        lblTitleDepartingToday.AutoSize = True
        lblTitleDepartingToday.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleDepartingToday.ForeColor = Color.DimGray
        lblTitleDepartingToday.Location = New Point(45, 12)
        lblTitleDepartingToday.Name = "lblTitleDepartingToday"
        lblTitleDepartingToday.Size = New Size(106, 25)
        lblTitleDepartingToday.TabIndex = 2
        lblTitleDepartingToday.Text = "Departing"
        ' 
        ' lblDepartingToday
        ' 
        lblDepartingToday.AutoSize = True
        lblDepartingToday.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblDepartingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDepartingToday.Location = New Point(90, 45)
        lblDepartingToday.Name = "lblDepartingToday"
        lblDepartingToday.Size = New Size(26, 30)
        lblDepartingToday.TabIndex = 3
        lblDepartingToday.Text = "0"
        ' 
        ' cardRevenue
        ' 
        cardRevenue.BackColor = Color.Beige
        cardRevenue.BorderStyle = BorderStyle.FixedSingle
        cardRevenue.Controls.Add(topStrip5)
        cardRevenue.Controls.Add(lblIconRevenue)
        cardRevenue.Controls.Add(lblTitleDailyRevenue)
        cardRevenue.Controls.Add(lblDailyRevenue)
        cardRevenue.Location = New Point(24, 247)
        cardRevenue.Name = "cardRevenue"
        cardRevenue.Size = New Size(265, 160)
        cardRevenue.TabIndex = 22
        ' 
        ' topStrip5
        ' 
        topStrip5.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip5.Dock = DockStyle.Top
        topStrip5.Location = New Point(0, 0)
        topStrip5.Name = "topStrip5"
        topStrip5.Size = New Size(263, 3)
        topStrip5.TabIndex = 0
        ' 
        ' lblIconRevenue
        ' 
        lblIconRevenue.AutoSize = True
        lblIconRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconRevenue.Location = New Point(15, 18)
        lblIconRevenue.Name = "lblIconRevenue"
        lblIconRevenue.Size = New Size(34, 25)
        lblIconRevenue.TabIndex = 1
        lblIconRevenue.Text = "💵"
        ' 
        ' lblTitleDailyRevenue
        ' 
        lblTitleDailyRevenue.AutoSize = True
        lblTitleDailyRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleDailyRevenue.ForeColor = Color.DimGray
        lblTitleDailyRevenue.Location = New Point(54, 18)
        lblTitleDailyRevenue.Name = "lblTitleDailyRevenue"
        lblTitleDailyRevenue.Size = New Size(146, 25)
        lblTitleDailyRevenue.TabIndex = 2
        lblTitleDailyRevenue.Text = "Daily Revenue"
        ' 
        ' lblDailyRevenue
        ' 
        lblDailyRevenue.AutoSize = True
        lblDailyRevenue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblDailyRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDailyRevenue.Location = New Point(35, 75)
        lblDailyRevenue.Name = "lblDailyRevenue"
        lblDailyRevenue.Size = New Size(111, 47)
        lblDailyRevenue.TabIndex = 3
        lblDailyRevenue.Text = "₱0.00"
        ' 
        ' cardMonthlyRevenue
        ' 
        cardMonthlyRevenue.BackColor = Color.Beige
        cardMonthlyRevenue.BorderStyle = BorderStyle.FixedSingle
        cardMonthlyRevenue.Controls.Add(topStrip7)
        cardMonthlyRevenue.Controls.Add(lblIconMonthlyRevenue)
        cardMonthlyRevenue.Controls.Add(lblTitleMonthlyRevenue)
        cardMonthlyRevenue.Controls.Add(lblMonthlyRevenue)
        cardMonthlyRevenue.Location = New Point(318, 247)
        cardMonthlyRevenue.Name = "cardMonthlyRevenue"
        cardMonthlyRevenue.Size = New Size(265, 160)
        cardMonthlyRevenue.TabIndex = 26
        ' 
        ' topStrip7
        ' 
        topStrip7.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip7.Dock = DockStyle.Top
        topStrip7.Location = New Point(0, 0)
        topStrip7.Name = "topStrip7"
        topStrip7.Size = New Size(263, 3)
        topStrip7.TabIndex = 0
        ' 
        ' lblIconMonthlyRevenue
        ' 
        lblIconMonthlyRevenue.AutoSize = True
        lblIconMonthlyRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblIconMonthlyRevenue.Location = New Point(15, 18)
        lblIconMonthlyRevenue.Name = "lblIconMonthlyRevenue"
        lblIconMonthlyRevenue.Size = New Size(34, 25)
        lblIconMonthlyRevenue.TabIndex = 1
        lblIconMonthlyRevenue.Text = "💰"
        ' 
        ' lblTitleMonthlyRevenue
        ' 
        lblTitleMonthlyRevenue.AutoSize = True
        lblTitleMonthlyRevenue.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleMonthlyRevenue.ForeColor = Color.DimGray
        lblTitleMonthlyRevenue.Location = New Point(52, 18)
        lblTitleMonthlyRevenue.Name = "lblTitleMonthlyRevenue"
        lblTitleMonthlyRevenue.Size = New Size(178, 25)
        lblTitleMonthlyRevenue.TabIndex = 2
        lblTitleMonthlyRevenue.Text = "Monthly Revenue"
        ' 
        ' lblMonthlyRevenue
        ' 
        lblMonthlyRevenue.AutoSize = True
        lblMonthlyRevenue.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblMonthlyRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblMonthlyRevenue.Location = New Point(35, 75)
        lblMonthlyRevenue.Name = "lblMonthlyRevenue"
        lblMonthlyRevenue.Size = New Size(111, 47)
        lblMonthlyRevenue.TabIndex = 3
        lblMonthlyRevenue.Text = "₱0.00"
        ' 
        ' tmrDashboard
        ' 
        tmrDashboard.Interval = 1000
        ' 
        ' DashboardHomeControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(groupReservations)
        Controls.Add(cardMonthlyRevenue)
        Controls.Add(cardOccupancy)
        Controls.Add(cardRevenue)
        Controls.Add(cardRooms)
        Controls.Add(lblDateTime)
        Controls.Add(lblSubtitle)
        Controls.Add(Label1)
        Name = "DashboardHomeControl"
        Size = New Size(903, 478)
        cardRooms.ResumeLayout(False)
        cardRooms.PerformLayout()
        cardOccupancy.ResumeLayout(False)
        cardOccupancy.PerformLayout()
        groupReservations.ResumeLayout(False)
        groupReservations.PerformLayout()
        cardArriving.ResumeLayout(False)
        cardArriving.PerformLayout()
        cardInHouse.ResumeLayout(False)
        cardInHouse.PerformLayout()
        cardDeparting.ResumeLayout(False)
        cardDeparting.PerformLayout()
        cardRevenue.ResumeLayout(False)
        cardRevenue.PerformLayout()
        cardMonthlyRevenue.ResumeLayout(False)
        cardMonthlyRevenue.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents tmrDashboard As Timer
End Class