<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestControl
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

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestControl))
        dgvGuests = New DataGridView()
        colGuestID = New DataGridViewTextBoxColumn()
        colSurname = New DataGridViewTextBoxColumn()
        colFirstname = New DataGridViewTextBoxColumn()
        colMiddlename = New DataGridViewTextBoxColumn()
        colContact = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        colIDType = New DataGridViewTextBoxColumn()
        colIDNumber = New DataGridViewTextBoxColumn()
        colVisits = New DataGridViewTextBoxColumn()
        btnBack = New Button()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        lblSearch = New Label()
        btnRefresh = New Button()
        btnStayHistory = New Button()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        CType(dgvGuests, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGuests
        ' 
        dgvGuests.AllowUserToAddRows = False
        dgvGuests.AllowUserToDeleteRows = False
        dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGuests.BackgroundColor = Color.Beige
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvGuests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuests.Columns.AddRange(New DataGridViewColumn() {colGuestID, colSurname, colFirstname, colMiddlename, colContact, colEmail, colIDType, colIDNumber, colVisits})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvGuests.DefaultCellStyle = DataGridViewCellStyle2
        dgvGuests.EnableHeadersVisualStyles = False
        dgvGuests.Location = New Point(16, 170)
        dgvGuests.Margin = New Padding(4, 5, 4, 5)
        dgvGuests.Name = "dgvGuests"
        dgvGuests.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvGuests.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvGuests.RowHeadersWidth = 51
        dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuests.Size = New Size(1001, 443)
        dgvGuests.TabIndex = 0
        ' 
        ' colGuestID
        ' 
        colGuestID.HeaderText = "ID"
        colGuestID.MinimumWidth = 6
        colGuestID.Name = "colGuestID"
        colGuestID.ReadOnly = True
        colGuestID.Visible = False
        ' 
        ' colSurname
        ' 
        colSurname.HeaderText = "Surname"
        colSurname.MinimumWidth = 6
        colSurname.Name = "colSurname"
        colSurname.ReadOnly = True
        ' 
        ' colFirstname
        ' 
        colFirstname.HeaderText = "First Name"
        colFirstname.MinimumWidth = 6
        colFirstname.Name = "colFirstname"
        colFirstname.ReadOnly = True
        ' 
        ' colMiddlename
        ' 
        colMiddlename.HeaderText = "Middle Name"
        colMiddlename.MinimumWidth = 6
        colMiddlename.Name = "colMiddlename"
        colMiddlename.ReadOnly = True
        ' 
        ' colContact
        ' 
        colContact.HeaderText = "Contact"
        colContact.MinimumWidth = 6
        colContact.Name = "colContact"
        colContact.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.HeaderText = "Email"
        colEmail.MinimumWidth = 6
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' colIDType
        ' 
        colIDType.HeaderText = "ID Type"
        colIDType.MinimumWidth = 6
        colIDType.Name = "colIDType"
        colIDType.ReadOnly = True
        ' 
        ' colIDNumber
        ' 
        colIDNumber.HeaderText = "ID Number"
        colIDNumber.MinimumWidth = 6
        colIDNumber.Name = "colIDNumber"
        colIDNumber.ReadOnly = True
        ' 
        ' colVisits
        ' 
        colVisits.HeaderText = "Total Visits"
        colVisits.MinimumWidth = 6
        colVisits.Name = "colVisits"
        colVisits.ReadOnly = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(27, 877)
        btnBack.Margin = New Padding(4, 5, 4, 5)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 46)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(16, 120)
        btnAdd.Margin = New Padding(4, 5, 4, 5)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(133, 40)
        btnAdd.TabIndex = 2
        btnAdd.Text = "+ ADD GUEST"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(172, 120)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(133, 40)
        btnEdit.TabIndex = 3
        btnEdit.Text = "EDIT GUEST"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(328, 120)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(133, 40)
        btnDelete.TabIndex = 4
        btnDelete.Text = "DELETE GUEST"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.OldLace
        btnSearch.ForeColor = Color.Maroon
        btnSearch.Location = New Point(339, 80)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 32)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(85, 83)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(239, 27)
        txtSearch.TabIndex = 6
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F)
        lblSearch.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSearch.Location = New Point(16, 83)
        lblSearch.Margin = New Padding(4, 0, 4, 0)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(73, 25)
        lblSearch.TabIndex = 7
        lblSearch.Text = "Search:"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.ForeColor = Color.Maroon
        btnRefresh.Location = New Point(437, 80)
        btnRefresh.Margin = New Padding(4, 5, 4, 5)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 32)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnStayHistory
        ' 
        btnStayHistory.BackColor = Color.OldLace
        btnStayHistory.ForeColor = Color.Maroon
        btnStayHistory.Location = New Point(484, 120)
        btnStayHistory.Margin = New Padding(4, 5, 4, 5)
        btnStayHistory.Name = "btnStayHistory"
        btnStayHistory.Size = New Size(160, 40)
        btnStayHistory.TabIndex = 9
        btnStayHistory.Text = "VIEW STAY HISTORY"
        btnStayHistory.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(87, 66)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(106, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(539, 20)
        Label4.TabIndex = 24
        Label4.Text = "Manage reservations, track check-in schedules, and keep stay records up to date."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(102, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 30)
        Label1.TabIndex = 23
        Label1.Text = "Guest Management"
        ' 
        ' GuestControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(btnStayHistory)
        Controls.Add(btnRefresh)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(btnBack)
        Controls.Add(dgvGuests)
        Margin = New Padding(4, 5, 4, 5)
        Name = "GuestControl"
        Size = New Size(1032, 637)
        CType(dgvGuests, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dgvGuests As DataGridView
    Friend WithEvents colGuestID As DataGridViewTextBoxColumn
    Friend WithEvents colSurname As DataGridViewTextBoxColumn
    Friend WithEvents colFirstname As DataGridViewTextBoxColumn
    Friend WithEvents colMiddlename As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colIDType As DataGridViewTextBoxColumn
    Friend WithEvents colIDNumber As DataGridViewTextBoxColumn
    Friend WithEvents colVisits As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnStayHistory As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class