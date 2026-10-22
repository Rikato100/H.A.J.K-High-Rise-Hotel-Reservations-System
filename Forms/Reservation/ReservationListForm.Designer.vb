<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationListForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationListForm))
        lblSearch = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnRefresh = New Button()
        dgvReservations = New DataGridView()
        colResID = New DataGridViewTextBoxColumn()
        colResCode = New DataGridViewTextBoxColumn()
        colGuest = New DataGridViewTextBoxColumn()
        colRoom = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colCheckIn = New DataGridViewTextBoxColumn()
        colCheckOut = New DataGridViewTextBoxColumn()
        colNights = New DataGridViewTextBoxColumn()
        colTotal = New DataGridViewTextBoxColumn()
        btnAddReservation = New Button()
        btnEdit = New Button()
        btnCancelReservation = New Button()
        btnBack = New Button()
        btnDelete = New Button()
        Panel1 = New Panel()
        btnLogout = New Button()
        btnReservations = New Button()
        PictureBox3 = New PictureBox()
        Button6 = New Button()
        btnGuests = New Button()
        btnDashboard = New Button()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        CType(dgvReservations, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSearch.Location = New Point(142, 137)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(137, 20)
        lblSearch.TabIndex = 3
        lblSearch.Text = "Search Reservation:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(292, 137)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(274, 23)
        txtSearch.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.OldLace
        btnSearch.ForeColor = Color.Maroon
        btnSearch.Location = New Point(582, 137)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 26)
        btnSearch.TabIndex = 5
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.ForeColor = Color.Maroon
        btnRefresh.Location = New Point(684, 137)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 26)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "↻ REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvReservations
        ' 
        dgvReservations.AllowUserToResizeRows = False
        dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReservations.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Maroon
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservations.Columns.AddRange(New DataGridViewColumn() {colResID, colResCode, colGuest, colRoom, colStatus, colCheckIn, colCheckOut, colNights, colTotal})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvReservations.DefaultCellStyle = DataGridViewCellStyle2
        dgvReservations.EnableHeadersVisualStyles = False
        dgvReservations.Location = New Point(142, 211)
        dgvReservations.Name = "dgvReservations"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvReservations.RowHeadersWidth = 51
        dgvReservations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvReservations.Size = New Size(882, 350)
        dgvReservations.TabIndex = 7
        ' 
        ' colResID
        ' 
        colResID.HeaderText = "ResID"
        colResID.MinimumWidth = 6
        colResID.Name = "colResID"
        colResID.ReadOnly = True
        colResID.Visible = False
        ' 
        ' colResCode
        ' 
        colResCode.HeaderText = "Code"
        colResCode.MinimumWidth = 6
        colResCode.Name = "colResCode"
        colResCode.ReadOnly = True
        ' 
        ' colGuest
        ' 
        colGuest.HeaderText = "Guest"
        colGuest.MinimumWidth = 6
        colGuest.Name = "colGuest"
        colGuest.ReadOnly = True
        ' 
        ' colRoom
        ' 
        colRoom.HeaderText = "Room"
        colRoom.MinimumWidth = 6
        colRoom.Name = "colRoom"
        colRoom.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colCheckIn
        ' 
        colCheckIn.HeaderText = "CheckIn"
        colCheckIn.MinimumWidth = 6
        colCheckIn.Name = "colCheckIn"
        colCheckIn.ReadOnly = True
        ' 
        ' colCheckOut
        ' 
        colCheckOut.HeaderText = "CheckOut"
        colCheckOut.MinimumWidth = 6
        colCheckOut.Name = "colCheckOut"
        colCheckOut.ReadOnly = True
        ' 
        ' colNights
        ' 
        colNights.HeaderText = "Nights"
        colNights.MinimumWidth = 6
        colNights.Name = "colNights"
        colNights.ReadOnly = True
        ' 
        ' colTotal
        ' 
        colTotal.HeaderText = "Total"
        colTotal.MinimumWidth = 6
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        ' 
        ' btnAddReservation
        ' 
        btnAddReservation.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnAddReservation.ForeColor = Color.Beige
        btnAddReservation.Location = New Point(138, 164)
        btnAddReservation.Name = "btnAddReservation"
        btnAddReservation.Size = New Size(172, 46)
        btnAddReservation.TabIndex = 9
        btnAddReservation.Text = "＋ADD RESERVATION"
        btnAddReservation.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(317, 164)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(172, 46)
        btnEdit.TabIndex = 10
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnCancelReservation
        ' 
        btnCancelReservation.BackColor = Color.OldLace
        btnCancelReservation.ForeColor = Color.Maroon
        btnCancelReservation.Location = New Point(495, 164)
        btnCancelReservation.Name = "btnCancelReservation"
        btnCancelReservation.Size = New Size(172, 46)
        btnCancelReservation.TabIndex = 11
        btnCancelReservation.Text = "CANCEL RESERVATION"
        btnCancelReservation.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.OldLace
        btnBack.ForeColor = Color.Maroon
        btnBack.Location = New Point(852, 164)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(172, 46)
        btnBack.TabIndex = 12
        btnBack.Text = "← BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(674, 164)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 46)
        btnDelete.TabIndex = 13
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
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
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 588)
        Panel1.TabIndex = 14
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Mongolian Baiti", 11.25F)
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 403)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(126, 42)
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
        btnReservations.Location = New Point(3, 127)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(126, 42)
        btnReservations.TabIndex = 26
        btnReservations.Text = "▤ Reservation"
        btnReservations.UseVisualStyleBackColor = False
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
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Mongolian Baiti", 11.25F)
        Button6.ForeColor = Color.Beige
        Button6.Location = New Point(3, 208)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(126, 42)
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
        btnGuests.Location = New Point(3, 169)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(126, 42)
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
        btnDashboard.Location = New Point(3, 85)
        btnDashboard.Margin = New Padding(3, 2, 3, 2)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(126, 42)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "🏠 Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(142, 85)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(235, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(432, 15)
        Label4.TabIndex = 21
        Label4.Text = "Manage reservations, track check-in schedules, and keep stay records up to date."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(232, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 24)
        Label1.TabIndex = 20
        Label1.Text = "Reservation List"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(131, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(903, 84)
        Panel2.TabIndex = 23
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic)
        Label3.ForeColor = Color.Beige
        Label3.Location = New Point(11, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 18)
        Label3.TabIndex = 15
        Label3.Text = "Where every stay feels extraordinary"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Imprint MT Shadow", 19.8000011F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Location = New Point(6, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(326, 32)
        Label2.TabIndex = 0
        Label2.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' ReservationListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1034, 588)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnDelete)
        Controls.Add(btnBack)
        Controls.Add(btnCancelReservation)
        Controls.Add(btnEdit)
        Controls.Add(btnAddReservation)
        Controls.Add(dgvReservations)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Name = "ReservationListForm"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterParent
        Text = "ReservationListForm"
        CType(dgvReservations, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvReservations As DataGridView
    Friend WithEvents btnAddReservation As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancelReservation As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents colResID As DataGridViewTextBoxColumn
    Friend WithEvents colResCode As DataGridViewTextBoxColumn
    Friend WithEvents colCheckIn As DataGridViewTextBoxColumn
    Friend WithEvents colCheckOut As DataGridViewTextBoxColumn
    Friend WithEvents colNights As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colGuest As DataGridViewTextBoxColumn
    Friend WithEvents colRoom As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class