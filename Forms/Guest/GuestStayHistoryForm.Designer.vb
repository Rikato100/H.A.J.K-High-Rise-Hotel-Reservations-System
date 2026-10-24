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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelTop = New Panel()
        lblTitle = New Label()
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
        PanelTop.SuspendLayout()
        CType(dgvStayHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' PanelTop
        '
        PanelTop.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        PanelTop.Controls.Add(lblTitle)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(0, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(950, 70)
        PanelTop.TabIndex = 0
        '
        ' lblTitle
        '
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Mongolian Baiti", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(950, 70)
        lblTitle.TabIndex = 0
        lblTitle.Text = "GUEST STAY HISTORY"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblGuestName
        '
        lblGuestName.AutoSize = True
        lblGuestName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblGuestName.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblGuestName.Location = New Point(30, 95)
        lblGuestName.Name = "lblGuestName"
        lblGuestName.Size = New Size(73, 25)
        lblGuestName.TabIndex = 1
        lblGuestName.Text = "Guest: "
        '
        ' lblGuestID
        '
        lblGuestID.AutoSize = True
        lblGuestID.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblGuestID.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblGuestID.Location = New Point(450, 95)
        lblGuestID.Name = "lblGuestID"
        lblGuestID.Size = New Size(98, 25)
        lblGuestID.TabIndex = 2
        lblGuestID.Text = "Guest ID: "
        '
        ' dgvStayHistory
        '
        dgvStayHistory.AllowUserToResizeRows = False
        dgvStayHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStayHistory.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Maroon
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStayHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStayHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStayHistory.Columns.AddRange(New DataGridViewColumn() {colResCode, colRoomNumber, colCheckIn, colCheckOut, colStatus, colTotalAmount})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStayHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvStayHistory.EnableHeadersVisualStyles = False
        dgvStayHistory.Location = New Point(30, 140)
        dgvStayHistory.Margin = New Padding(3, 4, 3, 4)
        dgvStayHistory.Name = "dgvStayHistory"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvStayHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvStayHistory.RowHeadersWidth = 51
        dgvStayHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvStayHistory.Size = New Size(890, 400)
        dgvStayHistory.TabIndex = 3
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
        btnClose.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnClose.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnClose.Location = New Point(775, 555)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(145, 45)
        btnClose.TabIndex = 4
        btnClose.Text = "BACK"
        btnClose.UseVisualStyleBackColor = False
        '
        ' GuestStayHistoryForm
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(950, 620)
        Controls.Add(btnClose)
        Controls.Add(dgvStayHistory)
        Controls.Add(lblGuestID)
        Controls.Add(lblGuestName)
        Controls.Add(PanelTop)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "GuestStayHistoryForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Guest Stay History"
        PanelTop.ResumeLayout(False)
        CType(dgvStayHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblTitle As Label
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