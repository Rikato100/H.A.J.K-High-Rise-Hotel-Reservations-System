<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestForm
    Inherits System.Windows.Forms.Form

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvGuests = New System.Windows.Forms.DataGridView()
        Me.colGuestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiddlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVisits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnStayHistory = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        ' dgvGuests
        '
        Me.dgvGuests.AllowUserToAddRows = False
        Me.dgvGuests.AllowUserToDeleteRows = False
        Me.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colGuestID, Me.colSurname, Me.colFirstname, Me.colMiddlename, Me.colContact, Me.colEmail, Me.colIDType, Me.colIDNumber, Me.colVisits})
        Me.dgvGuests.Location = New System.Drawing.Point(20, 150)
        Me.dgvGuests.Name = "dgvGuests"
        Me.dgvGuests.ReadOnly = True
        Me.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuests.Size = New System.Drawing.Size(900, 400)
        Me.dgvGuests.TabIndex = 0
        '
        ' colGuestID
        '
        Me.colGuestID.HeaderText = "ID"
        Me.colGuestID.Name = "colGuestID"
        Me.colGuestID.ReadOnly = True
        Me.colGuestID.Visible = False
        '
        ' colSurname
        '
        Me.colSurname.HeaderText = "Surname"
        Me.colSurname.Name = "colSurname"
        Me.colSurname.ReadOnly = True
        '
        ' colFirstname
        '
        Me.colFirstname.HeaderText = "First Name"
        Me.colFirstname.Name = "colFirstname"
        Me.colFirstname.ReadOnly = True
        '
        ' colMiddlename
        '
        Me.colMiddlename.HeaderText = "Middle Name"
        Me.colMiddlename.Name = "colMiddlename"
        Me.colMiddlename.ReadOnly = True
        '
        ' colContact
        '
        Me.colContact.HeaderText = "Contact"
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        '
        ' colEmail
        '
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        '
        ' colIDType
        '
        Me.colIDType.HeaderText = "ID Type"
        Me.colIDType.Name = "colIDType"
        Me.colIDType.ReadOnly = True
        '
        ' colIDNumber
        '
        Me.colIDNumber.HeaderText = "ID Number"
        Me.colIDNumber.Name = "colIDNumber"
        Me.colIDNumber.ReadOnly = True
        '
        ' colVisits
        '
        Me.colVisits.HeaderText = "Total Visits"
        Me.colVisits.Name = "colVisits"
        Me.colVisits.ReadOnly = True
        '
        ' btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(20, 570)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        ' btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(20, 100)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Guest"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        ' btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(130, 100)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 30)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit Guest"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        ' btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(240, 100)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Guest"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        ' btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(400, 60)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        ' txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(200, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 20)
        Me.txtSearch.TabIndex = 6
        '
        ' lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(150, 68)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(44, 13)
        Me.lblSearch.TabIndex = 7
        Me.lblSearch.Text = "Search:"
        '
        ' btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(520, 60)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        ' btnStayHistory
        '
        Me.btnStayHistory.Location = New System.Drawing.Point(350, 100)
        Me.btnStayHistory.Name = "btnStayHistory"
        Me.btnStayHistory.Size = New System.Drawing.Size(120, 30)
        Me.btnStayHistory.TabIndex = 9
        Me.btnStayHistory.Text = "View Stay History"
        Me.btnStayHistory.UseVisualStyleBackColor = True
        '
        ' Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 50)
        Me.Panel1.TabIndex = 10
        '
        ' Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "GUEST MANAGEMENT"
        '
        ' Button11
        '
        Me.Button11.Location = New System.Drawing.Point(0, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(0, 0)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        ' GuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 620)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnStayHistory)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvGuests)
        Me.Name = "GuestForm"
        Me.Text = "Guest Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button11 As Button
End Class
