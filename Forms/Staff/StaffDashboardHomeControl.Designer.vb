<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffDashboardHomeControl
    Inherits System.Windows.Forms.UserControl

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
        components = New ComponentModel.Container()
        LabelWelcome = New Label()
        lblSubtitle = New Label()
        groupReservations = New Panel()
        reservationCardsGrid = New TableLayoutPanel()
        lblReservationsGroupTitle = New Label()
        cardsSubGrid = New TableLayoutPanel()
        cardArriving = New Panel()
        topStrip2 = New Panel()
        lblTitleArrivingToday = New Label()
        lblArrivingToday = New Label()
        cardInHouse = New Panel()
        topStrip4 = New Panel()
        lblTitleInHouse = New Label()
        lblInHouse = New Label()
        cardDeparting = New Panel()
        topStrip3 = New Panel()
        lblTitleDepartingToday = New Label()
        lblDepartingToday = New Label()
        cardOccupancy = New Panel()
        topStrip6 = New Panel()
        lblTitleOccupancyRate = New Label()
        lblOccupancyRate = New Label()
        cardRooms = New Panel()
        topStrip1 = New Panel()
        lblTitleAvailableRooms = New Label()
        lblAvailableRooms = New Label()
        tmrDashboard = New Timer(components)
        lblDateTime = New Label()
        staffDashboardGrid = New TableLayoutPanel()
        groupReservations.SuspendLayout()
        reservationCardsGrid.SuspendLayout()
        cardsSubGrid.SuspendLayout()
        cardArriving.SuspendLayout()
        cardInHouse.SuspendLayout()
        cardDeparting.SuspendLayout()
        cardOccupancy.SuspendLayout()
        cardRooms.SuspendLayout()
        staffDashboardGrid.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.AutoSize = True
        LabelWelcome.Font = New Font("Mongolian Baiti", 18.0F, FontStyle.Bold)
        LabelWelcome.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        LabelWelcome.Location = New Point(18, 11)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(270, 25)
        LabelWelcome.TabIndex = 0
        LabelWelcome.Text = "Welcome, Receptionist!"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSubtitle.Location = New Point(19, 38)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(365, 17)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage reservations, check-ins, and guest profiles efficiently."
        ' 
        ' groupReservations
        ' 
        groupReservations.BackColor = Color.FromArgb(CByte(250), CByte(245), CByte(235))
        groupReservations.BorderStyle = BorderStyle.FixedSingle
        groupReservations.Controls.Add(reservationCardsGrid)
        groupReservations.Dock = DockStyle.Fill
        groupReservations.Location = New Point(577, 8)
        groupReservations.Margin = New Padding(8)
        groupReservations.Name = "groupReservations"
        staffDashboardGrid.SetRowSpan(groupReservations, 2)
        groupReservations.Size = New Size(270, 383)
        groupReservations.TabIndex = 30
        ' 
        ' reservationCardsGrid
        ' 
        reservationCardsGrid.BackColor = Color.Transparent
        reservationCardsGrid.ColumnCount = 1
        reservationCardsGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        reservationCardsGrid.Controls.Add(lblReservationsGroupTitle, 0, 0)
        reservationCardsGrid.Controls.Add(cardsSubGrid, 0, 1)
        reservationCardsGrid.Dock = DockStyle.Fill
        reservationCardsGrid.Location = New Point(0, 0)
        reservationCardsGrid.Margin = New Padding(0)
        reservationCardsGrid.Name = "reservationCardsGrid"
        reservationCardsGrid.RowCount = 2
        reservationCardsGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0F))
        reservationCardsGrid.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        reservationCardsGrid.Size = New Size(268, 381)
        reservationCardsGrid.TabIndex = 1
        ' 
        ' lblReservationsGroupTitle
        ' 
        lblReservationsGroupTitle.Dock = DockStyle.Fill
        lblReservationsGroupTitle.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold)
        lblReservationsGroupTitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblReservationsGroupTitle.Location = New Point(3, 0)
        lblReservationsGroupTitle.Name = "lblReservationsGroupTitle"
        lblReservationsGroupTitle.Size = New Size(262, 45)
        lblReservationsGroupTitle.TabIndex = 0
        lblReservationsGroupTitle.Text = "Reservations"
        lblReservationsGroupTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cardsSubGrid
        ' 
        cardsSubGrid.BackColor = Color.Transparent
        cardsSubGrid.ColumnCount = 1
        cardsSubGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        cardsSubGrid.Controls.Add(cardArriving, 0, 0)
        cardsSubGrid.Controls.Add(cardInHouse, 0, 1)
        cardsSubGrid.Controls.Add(cardDeparting, 0, 2)
        cardsSubGrid.Dock = DockStyle.Fill
        cardsSubGrid.Location = New Point(8, 45)
        cardsSubGrid.Margin = New Padding(8, 0, 8, 8)
        cardsSubGrid.Name = "cardsSubGrid"
        cardsSubGrid.RowCount = 3
        cardsSubGrid.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        cardsSubGrid.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        cardsSubGrid.RowStyles.Add(New RowStyle(SizeType.Percent, 33.34F))
        cardsSubGrid.Size = New Size(252, 328)
        cardsSubGrid.TabIndex = 1
        ' 
        ' cardArriving
        ' 
        cardArriving.BackColor = Color.Beige
        cardArriving.BorderStyle = BorderStyle.FixedSingle
        cardArriving.Controls.Add(topStrip2)
        cardArriving.Controls.Add(lblTitleArrivingToday)
        cardArriving.Controls.Add(lblArrivingToday)
        cardArriving.Dock = DockStyle.Fill
        cardArriving.Location = New Point(4, 4)
        cardArriving.Margin = New Padding(4)
        cardArriving.Name = "cardArriving"
        cardArriving.Size = New Size(244, 101)
        cardArriving.TabIndex = 19
        ' 
        ' topStrip2
        ' 
        topStrip2.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip2.Dock = DockStyle.Top
        topStrip2.Location = New Point(0, 0)
        topStrip2.Margin = New Padding(3, 2, 3, 2)
        topStrip2.Name = "topStrip2"
        topStrip2.Size = New Size(242, 2)
        topStrip2.TabIndex = 0
        ' 
        ' lblTitleArrivingToday
        ' 
        lblTitleArrivingToday.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitleArrivingToday.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleArrivingToday.ForeColor = Color.DimGray
        lblTitleArrivingToday.Location = New Point(13, 10)
        lblTitleArrivingToday.Name = "lblTitleArrivingToday"
        lblTitleArrivingToday.Size = New Size(217, 28)
        lblTitleArrivingToday.TabIndex = 2
        lblTitleArrivingToday.Text = "Arriving"
        lblTitleArrivingToday.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblArrivingToday
        ' 
        lblArrivingToday.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblArrivingToday.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblArrivingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblArrivingToday.Location = New Point(13, 38)
        lblArrivingToday.Name = "lblArrivingToday"
        lblArrivingToday.Size = New Size(217, 55)
        lblArrivingToday.TabIndex = 3
        lblArrivingToday.Text = "0"
        lblArrivingToday.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cardInHouse
        ' 
        cardInHouse.BackColor = Color.Beige
        cardInHouse.BorderStyle = BorderStyle.FixedSingle
        cardInHouse.Controls.Add(topStrip4)
        cardInHouse.Controls.Add(lblTitleInHouse)
        cardInHouse.Controls.Add(lblInHouse)
        cardInHouse.Dock = DockStyle.Fill
        cardInHouse.Location = New Point(4, 113)
        cardInHouse.Margin = New Padding(4)
        cardInHouse.Name = "cardInHouse"
        cardInHouse.Size = New Size(244, 101)
        cardInHouse.TabIndex = 21
        ' 
        ' topStrip4
        ' 
        topStrip4.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip4.Dock = DockStyle.Top
        topStrip4.Location = New Point(0, 0)
        topStrip4.Margin = New Padding(3, 2, 3, 2)
        topStrip4.Name = "topStrip4"
        topStrip4.Size = New Size(242, 2)
        topStrip4.TabIndex = 0
        ' 
        ' lblTitleInHouse
        ' 
        lblTitleInHouse.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitleInHouse.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleInHouse.ForeColor = Color.DimGray
        lblTitleInHouse.Location = New Point(13, 10)
        lblTitleInHouse.Name = "lblTitleInHouse"
        lblTitleInHouse.Size = New Size(217, 32)
        lblTitleInHouse.TabIndex = 2
        lblTitleInHouse.Text = "In-house"
        lblTitleInHouse.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblInHouse
        ' 
        lblInHouse.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblInHouse.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblInHouse.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblInHouse.Location = New Point(13, 38)
        lblInHouse.Name = "lblInHouse"
        lblInHouse.Size = New Size(217, 55)
        lblInHouse.TabIndex = 3
        lblInHouse.Text = "0"
        lblInHouse.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cardDeparting
        ' 
        cardDeparting.BackColor = Color.Beige
        cardDeparting.BorderStyle = BorderStyle.FixedSingle
        cardDeparting.Controls.Add(topStrip3)
        cardDeparting.Controls.Add(lblTitleDepartingToday)
        cardDeparting.Controls.Add(lblDepartingToday)
        cardDeparting.Dock = DockStyle.Fill
        cardDeparting.Location = New Point(4, 222)
        cardDeparting.Margin = New Padding(4)
        cardDeparting.Name = "cardDeparting"
        cardDeparting.Size = New Size(244, 102)
        cardDeparting.TabIndex = 20
        ' 
        ' topStrip3
        ' 
        topStrip3.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip3.Dock = DockStyle.Top
        topStrip3.Location = New Point(0, 0)
        topStrip3.Margin = New Padding(3, 2, 3, 2)
        topStrip3.Name = "topStrip3"
        topStrip3.Size = New Size(242, 2)
        topStrip3.TabIndex = 0
        ' 
        ' lblTitleDepartingToday
        ' 
        lblTitleDepartingToday.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitleDepartingToday.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold)
        lblTitleDepartingToday.ForeColor = Color.DimGray
        lblTitleDepartingToday.Location = New Point(13, 4)
        lblTitleDepartingToday.Name = "lblTitleDepartingToday"
        lblTitleDepartingToday.Size = New Size(217, 38)
        lblTitleDepartingToday.TabIndex = 2
        lblTitleDepartingToday.Text = "Departing"
        lblTitleDepartingToday.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDepartingToday
        ' 
        lblDepartingToday.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblDepartingToday.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblDepartingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDepartingToday.Location = New Point(13, 38)
        lblDepartingToday.Name = "lblDepartingToday"
        lblDepartingToday.Size = New Size(217, 56)
        lblDepartingToday.TabIndex = 3
        lblDepartingToday.Text = "0"
        lblDepartingToday.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cardOccupancy
        ' 
        cardOccupancy.BackColor = Color.Beige
        cardOccupancy.BorderStyle = BorderStyle.FixedSingle
        cardOccupancy.Controls.Add(topStrip6)
        cardOccupancy.Controls.Add(lblTitleOccupancyRate)
        cardOccupancy.Controls.Add(lblOccupancyRate)
        cardOccupancy.Dock = DockStyle.Fill
        cardOccupancy.Location = New Point(8, 207)
        cardOccupancy.Margin = New Padding(8)
        cardOccupancy.Name = "cardOccupancy"
        cardOccupancy.Size = New Size(553, 184)
        cardOccupancy.TabIndex = 29
        ' 
        ' topStrip6
        ' 
        topStrip6.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip6.Dock = DockStyle.Top
        topStrip6.Location = New Point(0, 0)
        topStrip6.Margin = New Padding(3, 2, 3, 2)
        topStrip6.Name = "topStrip6"
        topStrip6.Size = New Size(551, 2)
        topStrip6.TabIndex = 0
        ' 
        ' lblTitleOccupancyRate
        ' 
        lblTitleOccupancyRate.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitleOccupancyRate.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold)
        lblTitleOccupancyRate.ForeColor = Color.DimGray
        lblTitleOccupancyRate.Location = New Point(35, 14)
        lblTitleOccupancyRate.Name = "lblTitleOccupancyRate"
        lblTitleOccupancyRate.Size = New Size(479, 57)
        lblTitleOccupancyRate.TabIndex = 2
        lblTitleOccupancyRate.Text = "Occupancy Rate"
        lblTitleOccupancyRate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOccupancyRate
        ' 
        lblOccupancyRate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblOccupancyRate.Font = New Font("Segoe UI", 60.0F, FontStyle.Bold)
        lblOccupancyRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblOccupancyRate.Location = New Point(18, 62)
        lblOccupancyRate.Name = "lblOccupancyRate"
        lblOccupancyRate.Size = New Size(517, 106)
        lblOccupancyRate.TabIndex = 3
        lblOccupancyRate.Text = "0%"
        lblOccupancyRate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cardRooms
        ' 
        cardRooms.BackColor = Color.Beige
        cardRooms.BorderStyle = BorderStyle.FixedSingle
        cardRooms.Controls.Add(topStrip1)
        cardRooms.Controls.Add(lblTitleAvailableRooms)
        cardRooms.Controls.Add(lblAvailableRooms)
        cardRooms.Dock = DockStyle.Fill
        cardRooms.Location = New Point(8, 8)
        cardRooms.Margin = New Padding(8)
        cardRooms.Name = "cardRooms"
        cardRooms.Size = New Size(553, 183)
        cardRooms.TabIndex = 28
        ' 
        ' topStrip1
        ' 
        topStrip1.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip1.Dock = DockStyle.Top
        topStrip1.Location = New Point(0, 0)
        topStrip1.Margin = New Padding(3, 2, 3, 2)
        topStrip1.Name = "topStrip1"
        topStrip1.Size = New Size(551, 2)
        topStrip1.TabIndex = 0
        ' 
        ' lblTitleAvailableRooms
        ' 
        lblTitleAvailableRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitleAvailableRooms.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleAvailableRooms.ForeColor = Color.DimGray
        lblTitleAvailableRooms.Location = New Point(35, 14)
        lblTitleAvailableRooms.Name = "lblTitleAvailableRooms"
        lblTitleAvailableRooms.Size = New Size(479, 51)
        lblTitleAvailableRooms.TabIndex = 2
        lblTitleAvailableRooms.Text = "Available Rooms"
        lblTitleAvailableRooms.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblAvailableRooms.Font = New Font("Segoe UI", 64.0F, FontStyle.Bold)
        lblAvailableRooms.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblAvailableRooms.Location = New Point(18, 56)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(517, 111)
        lblAvailableRooms.TabIndex = 3
        lblAvailableRooms.Text = "0"
        lblAvailableRooms.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tmrDashboard
        ' 
        tmrDashboard.Interval = 1000
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Segoe UI", 9.0F)
        lblDateTime.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDateTime.Location = New Point(696, 11)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(0, 15)
        lblDateTime.TabIndex = 31
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' staffDashboardGrid
        ' 
        staffDashboardGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        staffDashboardGrid.BackColor = Color.Transparent
        staffDashboardGrid.ColumnCount = 2
        staffDashboardGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.66F))
        staffDashboardGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.34F))
        staffDashboardGrid.Controls.Add(cardRooms, 0, 0)
        staffDashboardGrid.Controls.Add(cardOccupancy, 0, 1)
        staffDashboardGrid.Controls.Add(groupReservations, 1, 0)
        staffDashboardGrid.Location = New Point(22, 68)
        staffDashboardGrid.Margin = New Padding(0)
        staffDashboardGrid.Name = "staffDashboardGrid"
        staffDashboardGrid.RowCount = 2
        staffDashboardGrid.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        staffDashboardGrid.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        staffDashboardGrid.Size = New Size(855, 399)
        staffDashboardGrid.TabIndex = 32
        ' 
        ' StaffDashboardHomeControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(staffDashboardGrid)
        Controls.Add(lblDateTime)
        Controls.Add(lblSubtitle)
        Controls.Add(LabelWelcome)
        Name = "StaffDashboardHomeControl"
        Size = New Size(903, 478)
        groupReservations.ResumeLayout(False)
        reservationCardsGrid.ResumeLayout(False)
        cardsSubGrid.ResumeLayout(False)
        cardArriving.ResumeLayout(False)
        cardInHouse.ResumeLayout(False)
        cardDeparting.ResumeLayout(False)
        cardOccupancy.ResumeLayout(False)
        cardRooms.ResumeLayout(False)
        staffDashboardGrid.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelWelcome As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents groupReservations As Panel
    Friend WithEvents lblReservationsGroupTitle As Label
    Friend WithEvents reservationCardsGrid As TableLayoutPanel
    Friend WithEvents cardsSubGrid As TableLayoutPanel
    Friend WithEvents cardArriving As Panel
    Friend WithEvents topStrip2 As Panel
    Friend WithEvents lblTitleArrivingToday As Label
    Friend WithEvents lblArrivingToday As Label
    Friend WithEvents cardInHouse As Panel
    Friend WithEvents topStrip4 As Panel
    Friend WithEvents lblTitleInHouse As Label
    Friend WithEvents lblInHouse As Label
    Friend WithEvents cardDeparting As Panel
    Friend WithEvents topStrip3 As Panel
    Friend WithEvents lblTitleDepartingToday As Label
    Friend WithEvents lblDepartingToday As Label
    Friend WithEvents cardOccupancy As Panel
    Friend WithEvents topStrip6 As Panel
    Friend WithEvents lblTitleOccupancyRate As Label
    Friend WithEvents lblOccupancyRate As Label
    Friend WithEvents cardRooms As Panel
    Friend WithEvents topStrip1 As Panel
    Friend WithEvents lblTitleAvailableRooms As Label
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents tmrDashboard As Timer
    Friend WithEvents lblDateTime As Label
    Friend WithEvents staffDashboardGrid As TableLayoutPanel
End Class