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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuestForm))
        lblSearch = New Label()
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
        Panel1 = New Panel()
        Button6 = New Button()
        PictureBox3 = New PictureBox()
        btnLogout = New Button()
        Button2 = New Button()
        btnGuests = New Button()
        btnReservations = New Button()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(dgvGuests, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearch.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSearch.Location = New Point(234, 138)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(97, 20)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search Guest:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(342, 138)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(342, 23)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.OldLace
        btnSearch.ForeColor = Color.Maroon
        btnSearch.Location = New Point(707, 136)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 26)
        btnSearch.TabIndex = 3
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.ForeColor = Color.Maroon
        btnRefresh.Location = New Point(806, 136)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 26)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "↻ REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvGuests
        ' 
        dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGuests.BackgroundColor = Color.Beige
        dgvGuests.BorderStyle = BorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Maroon
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.Beige
        DataGridViewCellStyle4.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle4.SelectionForeColor = Color.Beige
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvGuests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuests.Columns.AddRange(New DataGridViewColumn() {colGuestID, colSurname, colFirstName, colMiddle, colContact, colEmail, colValidIDType, colValidIDNumber})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Beige
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.Maroon
        DataGridViewCellStyle5.SelectionBackColor = Color.Beige
        DataGridViewCellStyle5.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvGuests.DefaultCellStyle = DataGridViewCellStyle5
        dgvGuests.EnableHeadersVisualStyles = False
        dgvGuests.GridColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        dgvGuests.Location = New Point(142, 215)
        dgvGuests.Name = "dgvGuests"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.Beige
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.Maroon
        DataGridViewCellStyle6.SelectionBackColor = Color.Beige
        DataGridViewCellStyle6.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvGuests.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvGuests.RowHeadersWidth = 51
        dgvGuests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvGuests.Size = New Size(882, 265)
        dgvGuests.TabIndex = 5
        ' 
        ' colGuestID
        ' 
        colGuestID.HeaderText = "Guest ID"
        colGuestID.MinimumWidth = 6
        colGuestID.Name = "colGuestID"
        colGuestID.ReadOnly = True
        ' 
        ' colSurname
        ' 
        colSurname.HeaderText = "Surname"
        colSurname.MinimumWidth = 6
        colSurname.Name = "colSurname"
        colSurname.ReadOnly = True
        ' 
        ' colFirstName
        ' 
        colFirstName.HeaderText = "First Name"
        colFirstName.MinimumWidth = 6
        colFirstName.Name = "colFirstName"
        colFirstName.ReadOnly = True
        ' 
        ' colMiddle
        ' 
        colMiddle.HeaderText = "Middle"
        colMiddle.MinimumWidth = 6
        colMiddle.Name = "colMiddle"
        colMiddle.ReadOnly = True
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
        ' colValidIDType
        ' 
        colValidIDType.HeaderText = "Valid ID Type"
        colValidIDType.MinimumWidth = 6
        colValidIDType.Name = "colValidIDType"
        colValidIDType.ReadOnly = True
        ' 
        ' colValidIDNumber
        ' 
        colValidIDNumber.HeaderText = "Valid ID Number"
        colValidIDNumber.MinimumWidth = 6
        colValidIDNumber.Name = "colValidIDNumber"
        colValidIDNumber.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(198, 165)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(172, 46)
        btnAdd.TabIndex = 8
        btnAdd.Text = "＋ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(388, 165)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(172, 46)
        btnEdit.TabIndex = 9
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(578, 165)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 46)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.OldLace
        btnBack.ForeColor = Color.Maroon
        btnBack.Location = New Point(767, 165)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(172, 46)
        btnBack.TabIndex = 11
        btnBack.Text = "← BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnGuests)
        Panel1.Controls.Add(btnReservations)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 490)
        Panel1.TabIndex = 13
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.Beige
        Button6.Location = New Point(3, 206)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(126, 42)
        Button6.TabIndex = 21
        Button6.Text = "⚙ Settings"
        Button6.UseVisualStyleBackColor = False
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
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 400)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(126, 42)
        btnLogout.TabIndex = 24
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Beige
        Button2.Location = New Point(3, 82)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 42)
        Button2.TabIndex = 20
        Button2.Text = "🏠 Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnGuests
        ' 
        btnGuests.BackColor = Color.Transparent
        btnGuests.FlatStyle = FlatStyle.Flat
        btnGuests.ForeColor = Color.Beige
        btnGuests.Location = New Point(3, 166)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(126, 42)
        btnGuests.TabIndex = 23
        btnGuests.Text = "♟ Guest Management"
        btnGuests.UseVisualStyleBackColor = False
        ' 
        ' btnReservations
        ' 
        btnReservations.BackColor = Color.Transparent
        btnReservations.FlatStyle = FlatStyle.Flat
        btnReservations.ForeColor = Color.Beige
        btnReservations.Location = New Point(3, 124)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(126, 42)
        btnReservations.TabIndex = 22
        btnReservations.Text = "▤ Reservation"
        btnReservations.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(144, 85)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(225, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(414, 15)
        Label4.TabIndex = 18
        Label4.Text = "Manage guest information, update guest details, and keep records organized."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(221, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 31)
        Label1.TabIndex = 17
        Label1.Text = "Guest Management"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(131, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(903, 75)
        Panel2.TabIndex = 20
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(446, 0)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(457, 75)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Beige
        Label3.Location = New Point(118, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 15)
        Label3.TabIndex = 15
        Label3.Text = "Where every stay feels extraordinary"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(5, 9)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Location = New Point(113, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(303, 31)
        Label2.TabIndex = 0
        Label2.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' GuestForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1034, 490)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnBack)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvGuests)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Name = "GuestForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "GuestManagement"
        CType(dgvGuests, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
