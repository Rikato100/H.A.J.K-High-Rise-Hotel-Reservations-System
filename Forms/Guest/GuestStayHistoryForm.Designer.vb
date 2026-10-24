<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestStayHistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestStayHistoryForm))
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnLogout = New Button()
        btnReservations = New Button()
        PictureBox3 = New PictureBox()
        Button6 = New Button()
        btnGuests = New Button()
        btnDashboard = New Button()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        lblGuestName = New Label()
        lblGuestID = New Label()
        dgvStayHistory = New DataGridView()
        colResCode = New DataGridViewTextBoxColumn()
        colRoomNumber = New DataGridViewTextBoxColumn()
        colCheckIn = New DataGridViewTextBoxColumn()
        colCheckOut = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colTotalAmount = New DataGridViewTextBoxColumn()
        btnClose = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStayHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnReservations)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(btnGuests)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(150, 784)
        Panel1.TabIndex = 14
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Mongolian Baiti", 11.25F)
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 537)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(144, 56)
        btnLogout.TabIndex = 29
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnReservations
        ' 
        btnReservations.BackColor = Color.Transparent
        btnReservations.FlatStyle = FlatStyle.Flat
        btnReservations.Font = New Font("Mongolian Baiti", 11.25F)
        btnReservations.ForeColor = Color.Beige
        btnReservations.Location = New Point(3, 169)
        btnReservations.Margin = New Padding(3, 4, 3, 4)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(144, 56)
        btnReservations.TabIndex = 26
        btnReservations.Text = "▤ Reservation"
        btnReservations.UseVisualStyleBackColor = False
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
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Mongolian Baiti", 11.25F)
        Button6.ForeColor = Color.Beige
        Button6.Location = New Point(3, 277)
        Button6.Name = "Button6"
        Button6.Size = New Size(144, 56)
        Button6.TabIndex = 5
        Button6.Text = "⚙ Settings"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' btnGuests
        ' 
        btnGuests.BackColor = Color.Transparent
        btnGuests.FlatStyle = FlatStyle.Flat
        btnGuests.Font = New Font("Mongolian Baiti", 11.25F)
        btnGuests.ForeColor = Color.Beige
        btnGuests.Location = New Point(3, 225)
        btnGuests.Margin = New Padding(3, 4, 3, 4)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(144, 56)
        btnGuests.TabIndex = 27
        btnGuests.Text = "♟ Guest Management"
        btnGuests.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
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
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(150, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1032, 112)
        Panel2.TabIndex = 23
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
        Label3.Font = New Font("Monotype Corsiva", 12.0F, FontStyle.Italic)
        Label3.ForeColor = Color.Beige
        Label3.Location = New Point(13, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(264, 24)
        Label3.TabIndex = 15
        Label3.Text = "Where every stay feels extraordinary"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Location = New Point(7, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(404, 40)
        Label2.TabIndex = 0
        Label2.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(162, 113)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 61)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(269, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(410, 20)
        Label4.TabIndex = 21
        Label4.Text = "View detailed stay history and records for the selected guest."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(265, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 30)
        Label1.TabIndex = 20
        Label1.Text = "Guest Stay History"
        ' 
        ' lblGuestName
        ' 
        lblGuestName.AutoSize = True
        lblGuestName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblGuestName.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblGuestName.Location = New Point(162, 200)
        lblGuestName.Name = "lblGuestName"
        lblGuestName.Size = New Size(73, 25)
        lblGuestName.TabIndex = 23
        lblGuestName.Text = "Guest: "
        ' 
        ' lblGuestID
        ' 
        lblGuestID.AutoSize = True
        lblGuestID.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblGuestID.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblGuestID.Location = New Point(450, 200)
        lblGuestID.Name = "lblGuestID"
        lblGuestID.Size = New Size(98, 25)
        lblGuestID.TabIndex = 24
        lblGuestID.Text = "Guest ID: "
        ' 
        ' dgvStayHistory
        ' 
        dgvStayHistory.AllowUserToResizeRows = False
        dgvStayHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStayHistory.BackgroundColor = Color.Beige
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Maroon
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle7.ForeColor = Color.Beige
        DataGridViewCellStyle7.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle7.SelectionForeColor = Color.Beige
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvStayHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvStayHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStayHistory.Columns.AddRange(New DataGridViewColumn() {colResCode, colRoomNumber, colCheckIn, colCheckOut, colStatus, colTotalAmount})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.Beige
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle8.ForeColor = Color.Maroon
        DataGridViewCellStyle8.SelectionBackColor = Color.Beige
        DataGridViewCellStyle8.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvStayHistory.DefaultCellStyle = DataGridViewCellStyle8
        dgvStayHistory.EnableHeadersVisualStyles = False
        dgvStayHistory.Location = New Point(162, 245)
        dgvStayHistory.Margin = New Padding(3, 4, 3, 4)
        dgvStayHistory.Name = "dgvStayHistory"
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.Beige
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle9.ForeColor = Color.Maroon
        DataGridViewCellStyle9.SelectionBackColor = Color.Beige
        DataGridViewCellStyle9.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvStayHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvStayHistory.RowHeadersWidth = 51
        dgvStayHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvStayHistory.Size = New Size(1008, 430)
        dgvStayHistory.TabIndex = 25
        ' 
        ' colResCode
        ' 
        colResCode.HeaderText = "Reservation Code"
        colResCode.MinimumWidth = 6
        colResCode.Name = "colResCode"
        colResCode.ReadOnly = True
        ' 
        ' colRoomNumber
        ' 
        colRoomNumber.HeaderText = "Room Number"
        colRoomNumber.MinimumWidth = 6
        colRoomNumber.Name = "colRoomNumber"
        colRoomNumber.ReadOnly = True
        ' 
        ' colCheckIn
        ' 
        colCheckIn.HeaderText = "Check-In"
        colCheckIn.MinimumWidth = 6
        colCheckIn.Name = "colCheckIn"
        colCheckIn.ReadOnly = True
        ' 
        ' colCheckOut
        ' 
        colCheckOut.HeaderText = "Check-Out"
        colCheckOut.MinimumWidth = 6
        colCheckOut.Name = "colCheckOut"
        colCheckOut.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colTotalAmount
        ' 
        colTotalAmount.HeaderText = "Total Amount"
        colTotalAmount.MinimumWidth = 6
        colTotalAmount.Name = "colTotalAmount"
        colTotalAmount.ReadOnly = True
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.OldLace
        btnClose.ForeColor = Color.Maroon
        btnClose.Location = New Point(973, 690)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(197, 50)
        btnClose.TabIndex = 25
        btnClose.Text = "← BACK"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' GuestStayHistoryForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1182, 784)
        Controls.Add(btnClose)
        Controls.Add(PictureBox2)
        Controls.Add(dgvStayHistory)
        Controls.Add(lblGuestID)
        Controls.Add(lblGuestName)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "GuestStayHistoryForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "GuestStayHistoryForm"
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStayHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents dgvStayHistory As DataGridView
    Friend WithEvents colResCode As DataGridViewTextBoxColumn
    Friend WithEvents colRoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCheckIn As DataGridViewTextBoxColumn
    Friend WithEvents colCheckOut As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
End Class