<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
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
        Dim Panel2 As Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox4 = New PictureBox()
        lblTagline = New Label()
        lblHotelName = New Label()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        cmbReportType = New ComboBox()
        btnGenerate = New Button()
        dgvReports = New DataGridView()
        colDate = New DataGridViewTextBoxColumn()
        colResCode = New DataGridViewTextBoxColumn()
        colGuest = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colMethod = New DataGridViewTextBoxColumn()
        lblTotalRevenue = New Label()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        btnSettings = New Button()
        btnLogout = New Button()
        btnReports = New Button()
        btnStaff = New Button()
        btnDashboard = New Button()
        btnRooms = New Button()
        Panel3 = New Panel()
        Panel5 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.Size = New Size(898, 84)
        Panel2.TabIndex = 28
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
        lblTagline.Font = New Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
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
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(9, 137)
        dtpStartDate.Margin = New Padding(4)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(204, 23)
        dtpStartDate.TabIndex = 1
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(9, 197)
        dtpEndDate.Margin = New Padding(4)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(204, 23)
        dtpEndDate.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(9, 109)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 19)
        Label1.TabIndex = 3
        Label1.Text = "▦ Start Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(9, 169)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 19)
        Label2.TabIndex = 4
        Label2.Text = "▦ End Date"
        ' 
        ' cmbReportType
        ' 
        cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbReportType.FormattingEnabled = True
        cmbReportType.Items.AddRange(New Object() {"Daily", "Monthly", "Annual"})
        cmbReportType.Location = New Point(9, 76)
        cmbReportType.Margin = New Padding(4)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(204, 23)
        cmbReportType.TabIndex = 0
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnGenerate.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.Beige
        btnGenerate.Location = New Point(25, 243)
        btnGenerate.Margin = New Padding(4)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(178, 34)
        btnGenerate.TabIndex = 5
        btnGenerate.Text = "▥ GENERATE REPORT"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' dgvReports
        ' 
        dgvReports.AllowUserToAddRows = False
        dgvReports.AllowUserToDeleteRows = False
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Columns.AddRange(New DataGridViewColumn() {colDate, colResCode, colGuest, colAmount, colMethod})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvReports.DefaultCellStyle = DataGridViewCellStyle2
        dgvReports.EnableHeadersVisualStyles = False
        dgvReports.Location = New Point(376, 147)
        dgvReports.Margin = New Padding(4)
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.RowHeadersVisible = False
        dgvReports.RowHeadersWidth = 51
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReports.Size = New Size(647, 326)
        dgvReports.TabIndex = 6
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Payment Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        ' 
        ' colResCode
        ' 
        colResCode.HeaderText = "Reservation Code"
        colResCode.MinimumWidth = 6
        colResCode.Name = "colResCode"
        colResCode.ReadOnly = True
        ' 
        ' colGuest
        ' 
        colGuest.HeaderText = "Guest Name"
        colGuest.MinimumWidth = 6
        colGuest.Name = "colGuest"
        colGuest.ReadOnly = True
        ' 
        ' colAmount
        ' 
        colAmount.HeaderText = "Amount"
        colAmount.MinimumWidth = 6
        colAmount.Name = "colAmount"
        colAmount.ReadOnly = True
        ' 
        ' colMethod
        ' 
        colMethod.HeaderText = "Payment Method"
        colMethod.MinimumWidth = 6
        colMethod.Name = "colMethod"
        colMethod.ReadOnly = True
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.AutoSize = True
        lblTotalRevenue.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblTotalRevenue.Location = New Point(82, 15)
        lblTotalRevenue.Margin = New Padding(4, 0, 4, 0)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(182, 20)
        lblTotalRevenue.TabIndex = 7
        lblTotalRevenue.Text = "Total Revenue: ₱0.00"
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
        Panel1.Size = New Size(131, 555)
        Panel1.TabIndex = 27
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.AntiqueWhite
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(cmbReportType)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(dtpStartDate)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(dtpEndDate)
        Panel3.Controls.Add(btnGenerate)
        Panel3.Location = New Point(143, 147)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(219, 382)
        Panel3.TabIndex = 29
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel5.Controls.Add(PictureBox1)
        Panel5.Controls.Add(Label4)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(219, 34)
        Panel5.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Beige
        Label4.Location = New Point(45, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 16)
        Label4.TabIndex = 31
        Label4.Text = "REPORT FILTERS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(9, 48)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 19)
        Label3.TabIndex = 6
        Label3.Text = "▤ Report Type:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.AntiqueWhite
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(lblTotalRevenue)
        Panel4.Location = New Point(376, 479)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(647, 50)
        Panel4.TabIndex = 30
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 7)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(143, 85)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(82, 46)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 33
        PictureBox5.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label5.Location = New Point(236, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(436, 15)
        Label5.TabIndex = 32
        Label5.Text = "Track hotel revenue, review payment records, and monitor financial performance."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label6.Location = New Point(233, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(190, 24)
        Label6.TabIndex = 31
        Label6.Text = "Financial Reports"
        ' 
        ' ReportsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1029, 555)
        Controls.Add(PictureBox5)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(dgvReports)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ReportsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Financial Reports"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGuest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblHotelName As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
