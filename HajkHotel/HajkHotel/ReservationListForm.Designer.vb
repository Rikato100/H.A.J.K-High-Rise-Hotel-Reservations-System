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
        lblTitle.Location = New Point(466, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(152, 25)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Reservation List"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(219, 70)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(137, 20)
        lblSearch.TabIndex = 3
        lblSearch.Text = "Search Reservation:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(362, 70)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(274, 23)
        txtSearch.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(652, 70)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 26)
        btnSearch.TabIndex = 5
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(754, 70)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 26)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' dgvReservations
        ' 
        dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservations.Columns.AddRange(New DataGridViewColumn() {colResID, colResCode, colGuest, colRoom, colStatus, colCheckIn, colCheckOut, colNights, colTotal})
        dgvReservations.Location = New Point(71, 145)
        dgvReservations.Name = "dgvReservations"
        dgvReservations.Size = New Size(942, 403)
        dgvReservations.TabIndex = 7
        ' 
        ' colResID
        ' 
        colResID.HeaderText = "ResID"
        colResID.Name = "colResID"
        colResID.ReadOnly = True
        ' 
        ' colResCode
        ' 
        colResCode.HeaderText = "Code"
        colResCode.Name = "colResCode"
        colResCode.ReadOnly = True
        ' 
        ' colGuest
        ' 
        colGuest.HeaderText = "Guest"
        colGuest.Name = "colGuest"
        colGuest.ReadOnly = True
        ' 
        ' colRoom
        ' 
        colRoom.HeaderText = "Room"
        colRoom.Name = "colRoom"
        colRoom.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colCheckIn
        ' 
        colCheckIn.HeaderText = "CheckIn"
        colCheckIn.Name = "colCheckIn"
        colCheckIn.ReadOnly = True
        ' 
        ' colCheckOut
        ' 
        colCheckOut.HeaderText = "CheckOut"
        colCheckOut.Name = "colCheckOut"
        colCheckOut.ReadOnly = True
        ' 
        ' colNights
        ' 
        colNights.HeaderText = "Nights"
        colNights.Name = "colNights"
        colNights.ReadOnly = True
        ' 
        ' colTotal
        ' 
        colTotal.HeaderText = "Total"
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        ' 
        ' btnAddReservation
        ' 
        btnAddReservation.Location = New Point(247, 107)
        btnAddReservation.Name = "btnAddReservation"
        btnAddReservation.Size = New Size(131, 26)
        btnAddReservation.TabIndex = 9
        btnAddReservation.Text = "ADD RESERVATION"
        btnAddReservation.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(395, 107)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(86, 26)
        btnEdit.TabIndex = 10
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancelReservation
        ' 
        btnCancelReservation.Location = New Point(498, 107)
        btnCancelReservation.Name = "btnCancelReservation"
        btnCancelReservation.Size = New Size(138, 26)
        btnCancelReservation.TabIndex = 11
        btnCancelReservation.Text = "CANCEL RESERVATION"
        btnCancelReservation.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(760, 107)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(86, 26)
        btnBack.TabIndex = 12
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(654, 107)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 26)
        btnDelete.TabIndex = 13
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ReservationListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 572)
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
