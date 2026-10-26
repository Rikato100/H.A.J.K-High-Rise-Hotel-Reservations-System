<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsControl))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        dgvReports.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles)
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Columns.AddRange(New DataGridViewColumn() {colDate, colResCode, colGuest, colAmount, colMethod})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvReports.DefaultCellStyle = DataGridViewCellStyle2
        dgvReports.EnableHeadersVisualStyles = False
        dgvReports.Location = New Point(245, 69)
        dgvReports.Margin = New Padding(4)
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.RowHeadersVisible = False
        dgvReports.RowHeadersWidth = 51
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReports.Size = New Size(647, 345)
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
        lblTotalRevenue.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRevenue.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblTotalRevenue.Location = New Point(82, 15)
        lblTotalRevenue.Margin = New Padding(4, 0, 4, 0)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(182, 20)
        lblTotalRevenue.TabIndex = 7
        lblTotalRevenue.Text = "Total Revenue: ₱0.00"
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
        Panel3.Location = New Point(13, 69)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(219, 396)
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
        Label4.Font = New Font("Mongolian Baiti", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Panel4.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles)
        Panel4.BackColor = Color.AntiqueWhite
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(lblTotalRevenue)
        Panel4.Location = New Point(245, 420)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(647, 45)
        Panel4.TabIndex = 30
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 4)
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
        PictureBox5.Location = New Point(13, 7)
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
        Label5.Location = New Point(106, 34)
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
        Label6.Location = New Point(103, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(190, 24)
        Label6.TabIndex = 31
        Label6.Text = "Financial Reports"
        ' 
        ' ReportsControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(PictureBox5)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(dgvReports)
        Name = "ReportsControl"
        Size = New Size(903, 478)
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colResCode As DataGridViewTextBoxColumn
    Friend WithEvents colGuest As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colMethod As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalRevenue As Label
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