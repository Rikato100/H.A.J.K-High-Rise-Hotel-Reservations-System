<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestForm
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
        lblSearch = New Label()
        lblTitle = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnRefresh = New Button()
        dgvGuests = New DataGridView()
        colGuestID = New DataGridViewTextBoxColumn()
        colSurname = New DataGridViewTextBoxColumn()
        colFirstName = New DataGridViewTextBoxColumn()
        colMiddle = New DataGridViewTextBoxColumn()
        colContact = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        colValidIDType = New DataGridViewTextBoxColumn()
        colValidIDNumber = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnBack = New Button()
        CType(dgvGuests, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(176, 65)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(97, 20)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search Guest:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(409, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(186, 25)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Guest Management"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(281, 65)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(342, 23)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(646, 64)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 26)
        btnSearch.TabIndex = 3
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(745, 64)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 26)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' dgvGuests
        ' 
        dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuests.Columns.AddRange(New DataGridViewColumn() {colGuestID, colSurname, colFirstName, colMiddle, colContact, colEmail, colValidIDType, colValidIDNumber})
        dgvGuests.Location = New Point(74, 148)
        dgvGuests.Name = "dgvGuests"
        dgvGuests.Size = New Size(842, 376)
        dgvGuests.TabIndex = 5
        ' 
        ' colGuestID
        ' 
        colGuestID.HeaderText = "Guest ID"
        colGuestID.Name = "colGuestID"
        colGuestID.ReadOnly = True
        ' 
        ' colSurname
        ' 
        colSurname.HeaderText = "Surname"
        colSurname.Name = "colSurname"
        colSurname.ReadOnly = True
        ' 
        ' colFirstName
        ' 
        colFirstName.HeaderText = "First Name"
        colFirstName.Name = "colFirstName"
        colFirstName.ReadOnly = True
        ' 
        ' colMiddle
        ' 
        colMiddle.HeaderText = "Middle"
        colMiddle.Name = "colMiddle"
        colMiddle.ReadOnly = True
        ' 
        ' colContact
        ' 
        colContact.HeaderText = "Contact"
        colContact.Name = "colContact"
        colContact.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.HeaderText = "Email"
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' colValidIDType
        ' 
        colValidIDType.HeaderText = "Valid ID Type"
        colValidIDType.Name = "colValidIDType"
        colValidIDType.ReadOnly = True
        ' 
        ' colValidIDNumber
        ' 
        colValidIDNumber.HeaderText = "Valid ID Number"
        colValidIDNumber.Name = "colValidIDNumber"
        colValidIDNumber.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(307, 104)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(86, 26)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(409, 104)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(86, 26)
        btnEdit.TabIndex = 9
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(509, 104)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 26)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(612, 104)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(86, 26)
        btnBack.TabIndex = 11
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' GuestForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(992, 555)
        Controls.Add(btnBack)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvGuests)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblTitle)
        Controls.Add(lblSearch)
        Name = "GuestForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GuestManagement"
        CType(dgvGuests, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvGuests As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents colGuestID As DataGridViewTextBoxColumn
    Friend WithEvents colSurname As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colMiddle As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colValidIDType As DataGridViewTextBoxColumn
    Friend WithEvents colValidIDNumber As DataGridViewTextBoxColumn
End Class
