<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomForm))
        Label1 = New Label()
        dgvRooms = New DataGridView()
        colRoomNumber = New DataGridViewTextBoxColumn()
        colRoomType = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colRoomSize = New DataGridViewTextBoxColumn()
        colStandardCapacity = New DataGridViewTextBoxColumn()
        colMaxCapacity = New DataGridViewTextBoxColumn()
        colRate = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnEdit = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        btnDelete = New Button()
        Panel1 = New Panel()
        btnLogout = New Button()
        PictureBox3 = New PictureBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(dgvRooms, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(229, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 31)
        Label1.TabIndex = 1
        Label1.Text = "Room Management"
        ' 
        ' dgvRooms
        ' 
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRooms.BackgroundColor = Color.Beige
        dgvRooms.BorderStyle = BorderStyle.None
        dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Maroon
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRooms.ColumnHeadersHeight = 47
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRooms.Columns.AddRange(New DataGridViewColumn() {colRoomNumber, colRoomType, colStatus, colRoomSize, colStandardCapacity, colMaxCapacity, colRate})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Maroon
        DataGridViewCellStyle2.SelectionBackColor = Color.Beige
        DataGridViewCellStyle2.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRooms.DefaultCellStyle = DataGridViewCellStyle2
        dgvRooms.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRooms.EnableHeadersVisualStyles = False
        dgvRooms.GridColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        dgvRooms.Location = New Point(144, 187)
        dgvRooms.MultiSelect = False
        dgvRooms.Name = "dgvRooms"
        dgvRooms.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Maroon
        DataGridViewCellStyle3.SelectionBackColor = Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvRooms.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvRooms.RowHeadersWidth = 51
        dgvRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRooms.Size = New Size(882, 274)
        dgvRooms.TabIndex = 2
        ' 
        ' colRoomNumber
        ' 
        colRoomNumber.HeaderText = "Room Number"
        colRoomNumber.MinimumWidth = 6
        colRoomNumber.Name = "colRoomNumber"
        colRoomNumber.ReadOnly = True
        ' 
        ' colRoomType
        ' 
        colRoomType.HeaderText = "Room Type"
        colRoomType.MinimumWidth = 6
        colRoomType.Name = "colRoomType"
        colRoomType.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colRoomSize
        ' 
        colRoomSize.HeaderText = "Room Size"
        colRoomSize.MinimumWidth = 6
        colRoomSize.Name = "colRoomSize"
        colRoomSize.ReadOnly = True
        ' 
        ' colStandardCapacity
        ' 
        colStandardCapacity.HeaderText = "Standard Capacity"
        colStandardCapacity.MinimumWidth = 6
        colStandardCapacity.Name = "colStandardCapacity"
        colStandardCapacity.ReadOnly = True
        ' 
        ' colMaxCapacity
        ' 
        colMaxCapacity.HeaderText = "Max Capacity"
        colMaxCapacity.MinimumWidth = 6
        colMaxCapacity.Name = "colMaxCapacity"
        colMaxCapacity.ReadOnly = True
        ' 
        ' colRate
        ' 
        colRate.HeaderText = "Base Rate"
        colRate.MinimumWidth = 6
        colRate.Name = "colRate"
        colRate.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(144, 135)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(172, 46)
        btnAdd.TabIndex = 6
        btnAdd.Text = "＋ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(316, 135)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(172, 46)
        btnEdit.TabIndex = 7
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.OldLace
        btnBack.Location = New Point(854, 135)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(172, 46)
        btnBack.TabIndex = 8
        btnBack.Text = "← BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.Location = New Point(675, 135)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(172, 46)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "↻ REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(495, 135)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 46)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 490)
        Panel1.TabIndex = 12
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.Beige
        btnLogout.Location = New Point(3, 406)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(126, 42)
        btnLogout.TabIndex = 17
        btnLogout.Text = ChrW(9211) & " Logout"
        btnLogout.UseVisualStyleBackColor = False
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
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.Beige
        Button6.Location = New Point(3, 250)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(126, 42)
        Button6.TabIndex = 5
        Button6.Text = "⚙ Settings"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.Beige
        Button5.Location = New Point(3, 127)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(126, 42)
        Button5.TabIndex = 4
        Button5.Text = "🛏 Rooms Management"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Beige
        Button4.Location = New Point(3, 169)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(126, 42)
        Button4.TabIndex = 3
        Button4.Text = "👥 Staff Management"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Beige
        Button3.Location = New Point(3, 208)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(126, 42)
        Button3.TabIndex = 2
        Button3.Text = "📊 Reports "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Beige
        Button1.Location = New Point(3, 85)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 42)
        Button1.TabIndex = 0
        Button1.Text = "🏠 Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(232, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(370, 15)
        Label4.TabIndex = 16
        Label4.Text = "Manage hotel rooms, update details, and keep track of the availabilty"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(144, 85)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
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
        Panel2.TabIndex = 19
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
        ' RoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1034, 490)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(btnDelete)
        Controls.Add(btnRefresh)
        Controls.Add(btnBack)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvRooms)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "RoomForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Management"
        CType(dgvRooms, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents colRoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents colRoomType As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colRoomSize As DataGridViewTextBoxColumn
    Friend WithEvents colStandardCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colMaxCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colRate As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class