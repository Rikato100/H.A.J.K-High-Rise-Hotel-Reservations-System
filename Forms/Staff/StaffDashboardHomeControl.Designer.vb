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
        cardOccupancy = New Panel()
        topStrip6 = New Panel()
        lblIconOccupancy = New Label()
        lblTitleOccupancyRate = New Label()
        lblOccupancyRate = New Label()
        cardRooms = New Panel()
        topStrip1 = New Panel()
        lblIconRooms = New Label()
        lblTitleAvailableRooms = New Label()
        lblAvailableRooms = New Label()
        tmrDashboard = New Timer(components)
        lblDateTime = New Label()
        groupReservations.SuspendLayout()
        cardArriving.SuspendLayout()
        cardInHouse.SuspendLayout()
        cardDeparting.SuspendLayout()
        cardOccupancy.SuspendLayout()
        cardRooms.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.AutoSize = True
        LabelWelcome.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold)
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
        groupReservations.Controls.Add(lblReservationsGroupTitle)
        groupReservations.Controls.Add(cardArriving)
        groupReservations.Controls.Add(cardInHouse)
        groupReservations.Controls.Add(cardDeparting)
        groupReservations.Location = New Point(587, 69)
        groupReservations.Name = "groupReservations"
        groupReservations.Size = New Size(285, 389)
        groupReservations.TabIndex = 30
        ' 
        ' lblReservationsGroupTitle
        ' 
        lblReservationsGroupTitle.AutoSize = True
        lblReservationsGroupTitle.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        lblReservationsGroupTitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblReservationsGroupTitle.Location = New Point(88, 9)
        lblReservationsGroupTitle.Name = "lblReservationsGroupTitle"
        lblReservationsGroupTitle.Size = New Size(112, 21)
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
        cardArriving.Location = New Point(16, 38)
        cardArriving.Name = "cardArriving"
        cardArriving.Size = New Size(252, 109)
        cardArriving.TabIndex = 19
        ' 
        ' topStrip2
        ' 
        topStrip2.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip2.Dock = DockStyle.Top
        topStrip2.Location = New Point(0, 0)
        topStrip2.Margin = New Padding(3, 2, 3, 2)
        topStrip2.Name = "topStrip2"
        topStrip2.Size = New Size(250, 2)
        topStrip2.TabIndex = 0
        ' 
        ' lblIconArriving
        ' 
        lblIconArriving.AutoSize = True
        lblIconArriving.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        lblIconArriving.Location = New Point(13, 9)
        lblIconArriving.Name = "lblIconArriving"
        lblIconArriving.Size = New Size(33, 21)
        lblIconArriving.TabIndex = 1
        lblIconArriving.Text = "📥"
        ' 
        ' lblTitleArrivingToday
        ' 
        lblTitleArrivingToday.AutoSize = True
        lblTitleArrivingToday.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold)
        lblTitleArrivingToday.ForeColor = Color.DimGray
        lblTitleArrivingToday.Location = New Point(48, 10)
        lblTitleArrivingToday.Name = "lblTitleArrivingToday"
        lblTitleArrivingToday.Size = New Size(72, 20)
        lblTitleArrivingToday.TabIndex = 2
        lblTitleArrivingToday.Text = "Arriving"
        ' 
        ' lblArrivingToday
        ' 
        lblArrivingToday.AutoSize = True
        lblArrivingToday.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblArrivingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblArrivingToday.Location = New Point(101, 45)
        lblArrivingToday.Name = "lblArrivingToday"
        lblArrivingToday.Size = New Size(44, 51)
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
        cardInHouse.Location = New Point(16, 154)
        cardInHouse.Name = "cardInHouse"
        cardInHouse.Size = New Size(252, 109)
        cardInHouse.TabIndex = 21
        ' 
        ' topStrip4
        ' 
        topStrip4.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip4.Dock = DockStyle.Top
        topStrip4.Location = New Point(0, 0)
        topStrip4.Margin = New Padding(3, 2, 3, 2)
        topStrip4.Name = "topStrip4"
        topStrip4.Size = New Size(250, 2)
        topStrip4.TabIndex = 0
        ' 
        ' lblIconInHouse
        ' 
        lblIconInHouse.AutoSize = True
        lblIconInHouse.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        lblIconInHouse.Location = New Point(13, 9)
        lblIconInHouse.Name = "lblIconInHouse"
        lblIconInHouse.Size = New Size(33, 21)
        lblIconInHouse.TabIndex = 1
        lblIconInHouse.Text = "👥"
        ' 
        ' lblTitleInHouse
        ' 
        lblTitleInHouse.AutoSize = True
        lblTitleInHouse.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold)
        lblTitleInHouse.ForeColor = Color.DimGray
        lblTitleInHouse.Location = New Point(48, 10)
        lblTitleInHouse.Name = "lblTitleInHouse"
        lblTitleInHouse.Size = New Size(72, 20)
        lblTitleInHouse.TabIndex = 2
        lblTitleInHouse.Text = "In-house"
        ' 
        ' lblInHouse
        ' 
        lblInHouse.AutoSize = True
        lblInHouse.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblInHouse.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblInHouse.Location = New Point(101, 45)
        lblInHouse.Name = "lblInHouse"
        lblInHouse.Size = New Size(44, 51)
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
        cardDeparting.Location = New Point(16, 270)
        cardDeparting.Name = "cardDeparting"
        cardDeparting.Size = New Size(252, 109)
        cardDeparting.TabIndex = 20
        ' 
        ' topStrip3
        ' 
        topStrip3.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip3.Dock = DockStyle.Top
        topStrip3.Location = New Point(0, 0)
        topStrip3.Margin = New Padding(3, 2, 3, 2)
        topStrip3.Name = "topStrip3"
        topStrip3.Size = New Size(250, 2)
        topStrip3.TabIndex = 0
        ' 
        ' lblIconDeparting
        ' 
        lblIconDeparting.AutoSize = True
        lblIconDeparting.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        lblIconDeparting.Location = New Point(13, 9)
        lblIconDeparting.Name = "lblIconDeparting"
        lblIconDeparting.Size = New Size(33, 21)
        lblIconDeparting.TabIndex = 1
        lblIconDeparting.Text = "📤"
        ' 
        ' lblTitleDepartingToday
        ' 
        lblTitleDepartingToday.AutoSize = True
        lblTitleDepartingToday.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold)
        lblTitleDepartingToday.ForeColor = Color.DimGray
        lblTitleDepartingToday.Location = New Point(48, 10)
        lblTitleDepartingToday.Name = "lblTitleDepartingToday"
        lblTitleDepartingToday.Size = New Size(83, 20)
        lblTitleDepartingToday.TabIndex = 2
        lblTitleDepartingToday.Text = "Departing"
        ' 
        ' lblDepartingToday
        ' 
        lblDepartingToday.AutoSize = True
        lblDepartingToday.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblDepartingToday.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblDepartingToday.Location = New Point(101, 45)
        lblDepartingToday.Name = "lblDepartingToday"
        lblDepartingToday.Size = New Size(44, 51)
        lblDepartingToday.TabIndex = 3
        lblDepartingToday.Text = "0"
        ' 
        ' cardOccupancy
        ' 
        cardOccupancy.BackColor = Color.Beige
        cardOccupancy.BorderStyle = BorderStyle.FixedSingle
        cardOccupancy.Controls.Add(topStrip6)
        cardOccupancy.Controls.Add(lblIconOccupancy)
        cardOccupancy.Controls.Add(lblTitleOccupancyRate)
        cardOccupancy.Controls.Add(lblOccupancyRate)
        cardOccupancy.Location = New Point(23, 262)
        cardOccupancy.Name = "cardOccupancy"
        cardOccupancy.Size = New Size(535, 196)
        cardOccupancy.TabIndex = 29
        ' 
        ' topStrip6
        ' 
        topStrip6.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip6.Dock = DockStyle.Top
        topStrip6.Location = New Point(0, 0)
        topStrip6.Margin = New Padding(3, 2, 3, 2)
        topStrip6.Name = "topStrip6"
        topStrip6.Size = New Size(533, 2)
        topStrip6.TabIndex = 0
        ' 
        ' lblIconOccupancy
        ' 
        lblIconOccupancy.AutoSize = True
        lblIconOccupancy.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold)
        lblIconOccupancy.Location = New Point(18, 14)
        lblIconOccupancy.Name = "lblIconOccupancy"
        lblIconOccupancy.Size = New Size(34, 25)
        lblIconOccupancy.TabIndex = 1
        lblIconOccupancy.Text = "📈"
        ' 
        ' lblTitleOccupancyRate
        ' 
        lblTitleOccupancyRate.AutoSize = True
        lblTitleOccupancyRate.Font = New Font("Segoe UI Black", 13F, FontStyle.Bold)
        lblTitleOccupancyRate.ForeColor = Color.DimGray
        lblTitleOccupancyRate.Location = New Point(61, 14)
        lblTitleOccupancyRate.Name = "lblTitleOccupancyRate"
        lblTitleOccupancyRate.Size = New Size(152, 25)
        lblTitleOccupancyRate.TabIndex = 2
        lblTitleOccupancyRate.Text = "Occupancy Rate"
        ' 
        ' lblOccupancyRate
        ' 
        lblOccupancyRate.AutoSize = True
        lblOccupancyRate.Font = New Font("Segoe UI", 60F, FontStyle.Bold)
        lblOccupancyRate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblOccupancyRate.Location = New Point(166, 64)
        lblOccupancyRate.Name = "lblOccupancyRate"
        lblOccupancyRate.Size = New Size(160, 106)
        lblOccupancyRate.TabIndex = 3
        lblOccupancyRate.Text = "0%"
        ' 
        ' cardRooms
        ' 
        cardRooms.BackColor = Color.Beige
        cardRooms.BorderStyle = BorderStyle.FixedSingle
        cardRooms.Controls.Add(topStrip1)
        cardRooms.Controls.Add(lblIconRooms)
        cardRooms.Controls.Add(lblTitleAvailableRooms)
        cardRooms.Controls.Add(lblAvailableRooms)
        cardRooms.Location = New Point(22, 68)
        cardRooms.Name = "cardRooms"
        cardRooms.Size = New Size(536, 188)
        cardRooms.TabIndex = 28
        ' 
        ' topStrip1
        ' 
        topStrip1.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        topStrip1.Dock = DockStyle.Top
        topStrip1.Location = New Point(0, 0)
        topStrip1.Margin = New Padding(3, 2, 3, 2)
        topStrip1.Name = "topStrip1"
        topStrip1.Size = New Size(534, 2)
        topStrip1.TabIndex = 0
        ' 
        ' lblIconRooms
        ' 
        lblIconRooms.AutoSize = True
        lblIconRooms.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold)
        lblIconRooms.Location = New Point(18, 14)
        lblIconRooms.Name = "lblIconRooms"
        lblIconRooms.Size = New Size(34, 25)
        lblIconRooms.TabIndex = 1
        lblIconRooms.Text = "🛏️"
        ' 
        ' lblTitleAvailableRooms
        ' 
        lblTitleAvailableRooms.AutoSize = True
        lblTitleAvailableRooms.Font = New Font("Segoe UI Black", 13F, FontStyle.Bold)
        lblTitleAvailableRooms.ForeColor = Color.DimGray
        lblTitleAvailableRooms.Location = New Point(61, 14)
        lblTitleAvailableRooms.Name = "lblTitleAvailableRooms"
        lblTitleAvailableRooms.Size = New Size(162, 25)
        lblTitleAvailableRooms.TabIndex = 2
        lblTitleAvailableRooms.Text = "Available Rooms"
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Segoe UI", 64F, FontStyle.Bold)
        lblAvailableRooms.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblAvailableRooms.Location = New Point(200, 56)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(97, 114)
        lblAvailableRooms.TabIndex = 3
        lblAvailableRooms.Text = "0"
        ' 
        ' tmrDashboard
        ' 
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Segoe UI", 9F)
        lblDateTime.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDateTime.Location = New Point(712, 11)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(0, 15)
        lblDateTime.TabIndex = 31
        lblDateTime.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' StaffDashboardHomeControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(lblDateTime)
        Controls.Add(groupReservations)
        Controls.Add(cardOccupancy)
        Controls.Add(cardRooms)
        Controls.Add(lblSubtitle)
        Controls.Add(LabelWelcome)
        Name = "StaffDashboardHomeControl"
        Size = New Size(903, 478)
        groupReservations.ResumeLayout(False)
        groupReservations.PerformLayout()
        cardArriving.ResumeLayout(False)
        cardArriving.PerformLayout()
        cardInHouse.ResumeLayout(False)
        cardInHouse.PerformLayout()
        cardDeparting.ResumeLayout(False)
        cardDeparting.PerformLayout()
        cardOccupancy.ResumeLayout(False)
        cardOccupancy.PerformLayout()
        cardRooms.ResumeLayout(False)
        cardRooms.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelWelcome As Label
    Friend WithEvents lblSubtitle As Label
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
    Friend WithEvents cardOccupancy As Panel
    Friend WithEvents topStrip6 As Panel
    Friend WithEvents lblIconOccupancy As Label
    Friend WithEvents lblTitleOccupancyRate As Label
    Friend WithEvents lblOccupancyRate As Label
    Friend WithEvents cardRooms As Panel
    Friend WithEvents topStrip1 As Panel
    Friend WithEvents lblIconRooms As Label
    Friend WithEvents lblTitleAvailableRooms As Label
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents tmrDashboard As Timer
    Friend WithEvents lblDateTime As Label
End Class