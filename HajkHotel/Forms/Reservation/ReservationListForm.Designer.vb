<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationListForm
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
        lblTitle = New Label()
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
        CType(dgvReservations, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(533, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(195, 32)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Reservation List"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(250, 93)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(175, 25)
        lblSearch.TabIndex = 3
        lblSearch.Text = "Search Reservation:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(414, 93)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(313, 27)
        txtSearch.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(745, 93)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(98, 35)
        btnSearch.TabIndex = 5
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(862, 93)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(98, 35)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' dgvReservations
        ' 
        dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservations.Columns.AddRange(New DataGridViewColumn() {colResID, colResCode, colGuest, colRoom, colStatus, colCheckIn, colCheckOut, colNights, colTotal})
        dgvReservations.Location = New Point(81, 193)
        dgvReservations.Margin = New Padding(3, 4, 3, 4)
        dgvReservations.Name = "dgvReservations"
        dgvReservations.RowHeadersWidth = 51
        dgvReservations.Size = New Size(1077, 537)
        dgvReservations.TabIndex = 7
        ' 
        ' colResID
        ' 
        colResID.HeaderText = "ResID"
        colResID.MinimumWidth = 6
        colResID.Name = "colResID"
        colResID.ReadOnly = True
        colResID.Width = 125
        ' 
        ' colResCode
        ' 
        colResCode.HeaderText = "Code"
        colResCode.MinimumWidth = 6
        colResCode.Name = "colResCode"
        colResCode.ReadOnly = True
        colResCode.Width = 125
        ' 
        ' colGuest
        ' 
        colGuest.HeaderText = "Guest"
        colGuest.MinimumWidth = 6
        colGuest.Name = "colGuest"
        colGuest.ReadOnly = True
        colGuest.Width = 125
        ' 
        ' colRoom
        ' 
        colRoom.HeaderText = "Room"
        colRoom.MinimumWidth = 6
        colRoom.Name = "colRoom"
        colRoom.ReadOnly = True
        colRoom.Width = 125
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 125
        ' 
        ' colCheckIn
        ' 
        colCheckIn.HeaderText = "CheckIn"
        colCheckIn.MinimumWidth = 6
        colCheckIn.Name = "colCheckIn"
        colCheckIn.ReadOnly = True
        colCheckIn.Width = 125
        ' 
        ' colCheckOut
        ' 
        colCheckOut.HeaderText = "CheckOut"
        colCheckOut.MinimumWidth = 6
        colCheckOut.Name = "colCheckOut"
        colCheckOut.ReadOnly = True
        colCheckOut.Width = 125
        ' 
        ' colNights
        ' 
        colNights.HeaderText = "Nights"
        colNights.MinimumWidth = 6
        colNights.Name = "colNights"
        colNights.ReadOnly = True
        colNights.Width = 125
        ' 
        ' colTotal
        ' 
        colTotal.HeaderText = "Total"
        colTotal.MinimumWidth = 6
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        colTotal.Width = 125
        ' 
        ' btnAddReservation
        ' 
        btnAddReservation.Location = New Point(282, 143)
        btnAddReservation.Margin = New Padding(3, 4, 3, 4)
        btnAddReservation.Name = "btnAddReservation"
        btnAddReservation.Size = New Size(150, 35)
        btnAddReservation.TabIndex = 9
        btnAddReservation.Text = "ADD RESERVATION"
        btnAddReservation.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(451, 143)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(98, 35)
        btnEdit.TabIndex = 10
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancelReservation
        ' 
        btnCancelReservation.Location = New Point(569, 143)
        btnCancelReservation.Margin = New Padding(3, 4, 3, 4)
        btnCancelReservation.Name = "btnCancelReservation"
        btnCancelReservation.Size = New Size(158, 35)
        btnCancelReservation.TabIndex = 11
        btnCancelReservation.Text = "CANCEL RESERVATION"
        btnCancelReservation.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(869, 143)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(98, 35)
        btnBack.TabIndex = 12
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(747, 143)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(98, 35)
        btnDelete.TabIndex = 13
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ReservationListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1241, 763)
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
        Controls.Add(lblTitle)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ReservationListForm"
        Text = "ReservationListForm"
        CType(dgvReservations, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
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
End Class
