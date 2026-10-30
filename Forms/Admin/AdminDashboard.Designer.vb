<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationListControl
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationListControl))
        lblSearch = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnRefresh = New Button()
        cmbStatusFilter = New ComboBox()
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
        btnDelete = New Button()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        btnCheckIn = New Button()
        btnCheckOut = New Button()
        btnProcessPayment = New Button()
        printDoc = New Printing.PrintDocument()
        printPreview = New PrintPreviewDialog()
        btnExport = New Button()
        cmbInvoiceType = New ComboBox()
        btnPrintInvoice = New Button()
        CType(dgvReservations, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSearch.Location = New Point(12, 75)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(175, 25)
        lblSearch.TabIndex = 3
        lblSearch.Text = "Search Reservation:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(184, 74)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(250, 27)
        txtSearch.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.OldLace
        btnSearch.ForeColor = Color.Maroon
        btnSearch.Location = New Point(445, 70)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 32)
        btnSearch.TabIndex = 5
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.ForeColor = Color.Maroon
        btnRefresh.Location = New Point(545, 70)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(95, 32)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "↻ REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' cmbStatusFilter
        ' 
        cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatusFilter.FormattingEnabled = True
        cmbStatusFilter.Items.AddRange(New Object() {"All", "Pending", "Check-In", "Check-Out", "No-Show", "Canceled"})
        cmbStatusFilter.Location = New Point(650, 73)
        cmbStatusFilter.Name = "cmbStatusFilter"
        cmbStatusFilter.Size = New Size(140, 28)
        cmbStatusFilter.TabIndex = 31
        ' 
        ' dgvReservations
        ' 
        dgvReservations.AllowUserToResizeRows = False
        dgvReservations.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReservations.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservations.Columns.AddRange(New DataGridViewColumn() {colResID, colResCode, colGuest, colRoom, colStatus, colCheckIn, colCheckOut, colNights, colTotal})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvReservations.DefaultCellStyle = DataGridViewCellStyle2
        dgvReservations.EnableHeadersVisualStyles = False
        dgvReservations.Location = New Point(12, 165)
        dgvReservations.Margin = New Padding(3, 4, 3, 4)
        dgvReservations.Name = "dgvReservations"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvReservations.RowHeadersWidth = 51
        dgvReservations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvReservations.Size = New Size(1008, 380)
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
        btnAddReservation.Location = New Point(12, 115)
        btnAddReservation.Margin = New Padding(3, 4, 3, 4)
        btnAddReservation.Name = "btnAddReservation"
        btnAddReservation.Size = New Size(180, 40)
        btnAddReservation.TabIndex = 9
        btnAddReservation.Text = "＋ADD RESERVATION"
        btnAddReservation.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(200, 115)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(120, 40)
        btnEdit.TabIndex = 10
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnCancelReservation
        ' 
        btnCancelReservation.BackColor = Color.OldLace
        btnCancelReservation.ForeColor = Color.Maroon
        btnCancelReservation.Location = New Point(328, 115)
        btnCancelReservation.Margin = New Padding(3, 4, 3, 4)
        btnCancelReservation.Name = "btnCancelReservation"
        btnCancelReservation.Size = New Size(170, 40)
        btnCancelReservation.TabIndex = 11
        btnCancelReservation.Text = "CANCEL RESERVATION"
        btnCancelReservation.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(506, 115)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.TabIndex = 13
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 62)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(105, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(539, 20)
        Label4.TabIndex = 21
        Label4.Text = "Manage reservations, track check-in schedules, and keep stay records up to date."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(101, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 30)
        Label1.TabIndex = 20
        Label1.Text = "Reservation List"
        ' 
        ' btnCheckIn
        ' 
        btnCheckIn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCheckIn.BackColor = Color.OldLace
        btnCheckIn.ForeColor = Color.Maroon
        btnCheckIn.Location = New Point(12, 565)
        btnCheckIn.Margin = New Padding(3, 4, 3, 4)
        btnCheckIn.Name = "btnCheckIn"
        btnCheckIn.Size = New Size(140, 45)
        btnCheckIn.TabIndex = 24
        btnCheckIn.Text = "Check-In"
        btnCheckIn.UseVisualStyleBackColor = False
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCheckOut.BackColor = Color.OldLace
        btnCheckOut.ForeColor = Color.Maroon
        btnCheckOut.Location = New Point(160, 565)
        btnCheckOut.Margin = New Padding(3, 4, 3, 4)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(140, 45)
        btnCheckOut.TabIndex = 25
        btnCheckOut.Text = "Check-Out"
        btnCheckOut.UseVisualStyleBackColor = False
        ' 
        ' btnProcessPayment
        ' 
        btnProcessPayment.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnProcessPayment.BackColor = Color.OldLace
        btnProcessPayment.ForeColor = Color.Maroon
        btnProcessPayment.Location = New Point(308, 565)
        btnProcessPayment.Margin = New Padding(3, 4, 3, 4)
        btnProcessPayment.Name = "btnProcessPayment"
        btnProcessPayment.Size = New Size(180, 45)
        btnProcessPayment.TabIndex = 26
        btnProcessPayment.Text = "Process Payment"
        btnProcessPayment.UseVisualStyleBackColor = False
        ' 
        ' printDoc
        ' 
        ' 
        ' printPreview
        ' 
        printPreview.AutoScrollMargin = New Size(0, 0)
        printPreview.AutoScrollMinSize = New Size(0, 0)
        printPreview.ClientSize = New Size(400, 300)
        printPreview.Enabled = True
        printPreview.Icon = CType(resources.GetObject("printPreview.Icon"), Icon)
        printPreview.Name = "printPreview"
        printPreview.Visible = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.OldLace
        btnExport.ForeColor = Color.Maroon
        btnExport.Location = New Point(614, 115)
        btnExport.Margin = New Padding(3, 4, 3, 4)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(100, 40)
        btnExport.TabIndex = 28
        btnExport.Text = "EXPORT"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' cmbInvoiceType
        ' 
        cmbInvoiceType.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmbInvoiceType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbInvoiceType.FormattingEnabled = True
        cmbInvoiceType.Items.AddRange(New Object() {"Pre-payment Quote", "Advance Payment Receipt", "Final Checkout Folio"})
        cmbInvoiceType.Location = New Point(610, 572)
        cmbInvoiceType.Name = "cmbInvoiceType"
        cmbInvoiceType.Size = New Size(240, 28)
        cmbInvoiceType.TabIndex = 29
        ' 
        ' btnPrintInvoice
        ' 
        btnPrintInvoice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnPrintInvoice.BackColor = Color.OldLace
        btnPrintInvoice.ForeColor = Color.Maroon
        btnPrintInvoice.Location = New Point(858, 565)
        btnPrintInvoice.Margin = New Padding(3, 4, 3, 4)
        btnPrintInvoice.Name = "btnPrintInvoice"
        btnPrintInvoice.Size = New Size(162, 45)
        btnPrintInvoice.TabIndex = 30
        btnPrintInvoice.Text = "Print Invoice"
        btnPrintInvoice.UseVisualStyleBackColor = False
        ' 
        ' ReservationListControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(cmbStatusFilter)
        Controls.Add(btnPrintInvoice)
        Controls.Add(cmbInvoiceType)
        Controls.Add(btnExport)
        Controls.Add(btnProcessPayment)
        Controls.Add(btnCheckOut)
        Controls.Add(btnCheckIn)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnCancelReservation)
        Controls.Add(btnEdit)
        Controls.Add(btnAddReservation)
        Controls.Add(dgvReservations)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Name = "ReservationListControl"
        Size = New Size(1032, 637)
        CType(dgvReservations, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cmbStatusFilter As ComboBox
    Friend WithEvents dgvReservations As DataGridView
    Friend WithEvents btnAddReservation As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancelReservation As Button
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents printPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnExport As Button
    Friend WithEvents cmbInvoiceType As ComboBox
    Friend WithEvents btnPrintInvoice As Button
End Class
