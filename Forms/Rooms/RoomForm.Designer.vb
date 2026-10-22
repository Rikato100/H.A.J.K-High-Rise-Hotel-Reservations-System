<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomForm))
        Label1 = New Label()
        dgvRooms = New DataGridView()
        colRoomNumber = New DataGridViewTextBoxColumn()
        colRoomType = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colRoomSize = New DataGridViewTextBoxColumn()
        colStandardCapacity = New DataGridViewTextBoxColumn()
        colMaxCapacity = New DataGridViewTextBoxColumn()
        colRate = New DataGridViewTextBoxColumn()
        colAmenities = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnEdit = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        btnDelete = New Button()
        Panel1 = New Panel()
        btnLogout = New Button()
        PictureBox3 = New PictureBox()
        btnSettings = New Button()
        btnRooms = New Button()
        btnStaff = New Button()
        btnReports = New Button()
        btnDashboard = New Button()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        lblTagline = New Label()
        PictureBox4 = New PictureBox()
        lblHotelName = New Label()
        CType(dgvRooms, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(232, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 24)
        Label1.TabIndex = 1
        Label1.Text = "Room Management"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgvRooms
        ' 
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRooms.BackgroundColor = Color.Beige
        dgvRooms.BorderStyle = BorderStyle.None
        dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Maroon
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRooms.ColumnHeadersHeight = 47
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRooms.Columns.AddRange(New DataGridViewColumn() {colRoomNumber, colRoomType, colStatus, colRoomSize, colStandardCapacity, colMaxCapacity, colRate, colAmenities})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRooms.DefaultCellStyle = DataGridViewCellStyle2
        dgvRooms.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRooms.EnableHeadersVisualStyles = False
        dgvRooms.GridColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        dgvRooms.Location = New Point(144, 187)
        dgvRooms.MultiSelect = False
        dgvRooms.Name = "dgvRooms"
        dgvRooms.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvRooms.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvRooms.RowHeadersWidth = 51
        dgvRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRooms.Size = New Size(882, 274)
        dgvRooms.TabIndex = 2
        ' 
        ' colRoomNumber
        ' 
        colRoomNumber.HeaderText = "Room Number"
        colRoomNumber.MinimumWidth = 6
        colRoomNumber.Name = "colRoomNumber"
        colRoomNumber.ReadOnly = True
        ' 
        ' colRoomType
        ' 
        colRoomType.HeaderText = "Room Type"
        colRoomType.MinimumWidth = 6
        colRoomType.Name = "colRoomType"
        colRoomType.ReadOnly = True
        colRoomType.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colRoomSize
        ' 
        colRoomSize.HeaderText = "Room Size"
        colRoomSize.MinimumWidth = 6
        colRoomSize.Name = "colRoomSize"
        colRoomSize.ReadOnly = True
        colRoomSize.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colStandardCapacity
        ' 
        colStandardCapacity.HeaderText = "Standard Capacity"
        colStandardCapacity.MinimumWidth = 6
        colStandardCapacity.Name = "colStandardCapacity"
        colStandardCapacity.ReadOnly = True
        colStandardCapacity.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colMaxCapacity
        ' 
        colMaxCapacity.HeaderText = "Max Capacity"
        colMaxCapacity.MinimumWidth = 6
        colMaxCapacity.Name = "colMaxCapacity"
        colMaxCapacity.ReadOnly = True
        colMaxCapacity.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colRate
        ' 
        colRate.HeaderText = "Base Rate"
        colRate.MinimumWidth = 6
        colRate.Name = "colRate"
        colRate.ReadOnly = True
        colRate.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colAmenities
        ' 
        colAmenities.DataPropertyName = "amenities"
        colAmenities.HeaderText = "Amenities"
        colAmenities.Name = "colAmenities"
        colAmenities.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(144, 135)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(172, 46)
        btnAdd.TabIndex = 6
        btnAdd.Text = "＋ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(316, 135)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(172, 46)
        btnEdit.TabIndex = 7
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.OldLace
        btnBack.Location = New Point(854, 135)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(172, 46)
        btnBack.TabIndex = 8
        btnBack.Text = "← BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.Location = New Point(675, 135)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(172, 46)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "↻ REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(495, 135)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 46)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(btnRooms)
        Panel1.Controls.Add(btnStaff)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 555)
        Panel1.TabIndex = 12
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
        btnLogout.TabIndex = 17
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
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
        btnSettings.Location = New Point(3, 250)
        btnSettings.Margin = New Padding(3, 2, 3, 2)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(126, 42)
        btnSettings.TabIndex = 5
        btnSettings.Text = "⚙ Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnRooms
        ' 
        btnRooms.BackColor = Color.Transparent
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.Font = New Font("Mongolian Baiti", 11.25F)
        btnRooms.ForeColor = Color.Beige
        btnRooms.Location = New Point(3, 126)
        btnRooms.Margin = New Padding(3, 2, 3, 2)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(126, 42)
        btnRooms.TabIndex = 4
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
        btnStaff.Margin = New Padding(3, 2, 3, 2)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(126, 42)
        btnStaff.TabIndex = 3
        btnStaff.Text = "👥 Staff Management"
        btnStaff.UseVisualStyleBackColor = False
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(235, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(370, 15)
        Label4.TabIndex = 16
        Label4.Text = "Manage hotel rooms, update details, and keep track of the availabilty"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(144, 85)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(lblTagline)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(lblHotelName)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(131, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(898, 84)
        Panel2.TabIndex = 19
        ' 
        ' lblTagline
        ' 
        lblTagline.AutoSize = True
        lblTagline.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTagline.ForeColor = Color.Beige
        lblTagline.Location = New Point(11, 44)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(220, 18)
        lblTagline.TabIndex = 17
        lblTagline.Text = "Where every stay feels extraordinary"
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
        ' RoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1029, 555)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(btnDelete)
        Controls.Add(btnRefresh)
        Controls.Add(btnBack)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvRooms)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "RoomForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Room Management"
        CType(dgvRooms, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHotelName As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents colRoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents colRoomType As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colRoomSize As DataGridViewTextBoxColumn
    Friend WithEvents colStandardCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colMaxCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colRate As DataGridViewTextBoxColumn
    Friend WithEvents colAmenities As DataGridViewTextBoxColumn
End Class