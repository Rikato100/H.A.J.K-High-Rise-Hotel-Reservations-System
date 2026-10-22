<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestStayHistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestStayHistoryForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnLogout = New Button()
        Panel1 = New Panel()
        btnClose = New Button()
        Button6 = New Button()
        PictureBox3 = New PictureBox()
        Button2 = New Button()
        btnGuests = New Button()
        btnReservations = New Button()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
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
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvStayHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 400)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(126, 42)
        btnLogout.TabIndex = 24
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnGuests)
        Panel1.Controls.Add(btnReservations)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 588)
        Panel1.TabIndex = 14
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = Color.Beige
        btnClose.Location = New Point(3, 358)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(126, 42)
        btnClose.TabIndex = 25
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.Beige
        Button6.Location = New Point(3, 208)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(126, 42)
        Button6.TabIndex = 21
        Button6.Text = "⚙ Settings"
        Button6.UseVisualStyleBackColor = False
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
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Beige
        Button2.Location = New Point(3, 82)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 42)
        Button2.TabIndex = 20
        Button2.Text = "🏠 Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnGuests
        ' 
        btnGuests.BackColor = Color.Transparent
        btnGuests.FlatStyle = FlatStyle.Flat
        btnGuests.ForeColor = Color.Beige
        btnGuests.Location = New Point(3, 166)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(126, 42)
        btnGuests.TabIndex = 23
        btnGuests.Text = "♟ Guest Management"
        btnGuests.UseVisualStyleBackColor = False
        ' 
        ' btnReservations
        ' 
        btnReservations.BackColor = Color.Transparent
        btnReservations.FlatStyle = FlatStyle.Flat
        btnReservations.ForeColor = Color.Beige
        btnReservations.Location = New Point(3, 124)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(126, 42)
        btnReservations.TabIndex = 22
        btnReservations.Text = "▤ Reservation"
        btnReservations.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(131, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(902, 75)
        Panel2.TabIndex = 21
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(446, 0)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(457, 75)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Beige
        Label3.Location = New Point(118, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 15)
        Label3.TabIndex = 15
        Label3.Text = "Where every stay feels extraordinary"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(5, 9)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Location = New Point(113, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(303, 31)
        Label2.TabIndex = 0
        Label2.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(164, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 31)
        Label1.TabIndex = 22
        Label1.Text = "Guest Stay History"
        ' 
        ' lblGuestName
        ' 
        lblGuestName.AutoSize = True
        lblGuestName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGuestName.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblGuestName.Location = New Point(173, 134)
        lblGuestName.Name = "lblGuestName"
        lblGuestName.Size = New Size(49, 20)
        lblGuestName.TabIndex = 23
        lblGuestName.Text = "Guest:"
        ' 
        ' lblGuestID
        ' 
        lblGuestID.AutoSize = True
        lblGuestID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGuestID.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblGuestID.Location = New Point(173, 166)
        lblGuestID.Name = "lblGuestID"
        lblGuestID.Size = New Size(68, 20)
        lblGuestID.TabIndex = 24
        lblGuestID.Text = "Guest ID:"
        ' 
        ' dgvStayHistory
        ' 
        dgvStayHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStayHistory.BackgroundColor = Color.Beige
        dgvStayHistory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Maroon
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStayHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStayHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStayHistory.Columns.AddRange(New DataGridViewColumn() {colResCode, colRoomNumber, colCheckIn, colCheckOut, colStatus, colTotalAmount})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStayHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvStayHistory.EnableHeadersVisualStyles = False
        dgvStayHistory.GridColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        dgvStayHistory.Location = New Point(164, 200)
        dgvStayHistory.Name = "dgvStayHistory"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvStayHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvStayHistory.RowHeadersWidth = 51
        dgvStayHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvStayHistory.Size = New Size(830, 350)
        dgvStayHistory.TabIndex = 25
        ' 
        ' colResCode
        ' 
        colResCode.HeaderText = "Reservation Code"
        colResCode.Name = "colResCode"
        colResCode.ReadOnly = True
        ' 
        ' colRoomNumber
        ' 
        colRoomNumber.HeaderText = "Room Number"
        colRoomNumber.Name = "colRoomNumber"
        colRoomNumber.ReadOnly = True
        ' 
        ' colCheckIn
        ' 
        colCheckIn.HeaderText = "Check-In"
        colCheckIn.Name = "colCheckIn"
        colCheckIn.ReadOnly = True
        ' 
        ' colCheckOut
        ' 
        colCheckOut.HeaderText = "Check-Out"
        colCheckOut.Name = "colCheckOut"
        colCheckOut.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colTotalAmount
        ' 
        colTotalAmount.HeaderText = "Total Amount"
        colTotalAmount.Name = "colTotalAmount"
        colTotalAmount.ReadOnly = True
        ' 
        ' GuestStayHistoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1033, 588)
        Controls.Add(dgvStayHistory)
        Controls.Add(lblGuestID)
        Controls.Add(lblGuestName)
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvStayHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
