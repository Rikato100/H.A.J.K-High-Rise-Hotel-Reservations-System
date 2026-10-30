<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomControl))
        Label1 = New Label()
        dgvRooms = New DataGridView()
        colRoomNumber = New DataGridViewTextBoxColumn()
        colRoomType = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colRoomSize = New DataGridViewTextBoxColumn()
        colStandardCapacity = New DataGridViewTextBoxColumn()
        colMaxCapacity = New DataGridViewTextBoxColumn()
        colRate = New DataGridViewTextBoxColumn()
        colAmenities = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnEdit = New Button()
        btnRefresh = New Button()
        btnDelete = New Button()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        CType(dgvRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(120, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 30)
        Label1.TabIndex = 1
        Label1.Text = "Room Management"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgvRooms
        ' 
        dgvRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRooms.BackgroundColor = Color.Beige
        dgvRooms.BorderStyle = BorderStyle.None
        dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRooms.ColumnHeadersHeight = 47
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRooms.Columns.AddRange(New DataGridViewColumn() {colRoomNumber, colRoomType, colStatus, colRoomSize, colStandardCapacity, colMaxCapacity, colRate, colAmenities})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Beige
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRooms.DefaultCellStyle = DataGridViewCellStyle2
        dgvRooms.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRooms.EnableHeadersVisualStyles = False
        dgvRooms.GridColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        dgvRooms.Location = New Point(19, 159)
        dgvRooms.Margin = New Padding(3, 4, 3, 4)
        dgvRooms.MultiSelect = False
        dgvRooms.Name = "dgvRooms"
        dgvRooms.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.Beige
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.SelectionBackColor = Color.Bisque
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvRooms.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvRooms.RowHeadersWidth = 51
        dgvRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRooms.Size = New Size(993, 453)
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
        colRoomType.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colRoomSize
        ' 
        colRoomSize.HeaderText = "Room Size"
        colRoomSize.MinimumWidth = 6
        colRoomSize.Name = "colRoomSize"
        colRoomSize.ReadOnly = True
        colRoomSize.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colStandardCapacity
        ' 
        colStandardCapacity.HeaderText = "Standard Capacity"
        colStandardCapacity.MinimumWidth = 6
        colStandardCapacity.Name = "colStandardCapacity"
        colStandardCapacity.ReadOnly = True
        colStandardCapacity.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colMaxCapacity
        ' 
        colMaxCapacity.HeaderText = "Max Capacity"
        colMaxCapacity.MinimumWidth = 6
        colMaxCapacity.Name = "colMaxCapacity"
        colMaxCapacity.ReadOnly = True
        colMaxCapacity.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colRate
        ' 
        colRate.HeaderText = "Base Rate"
        colRate.MinimumWidth = 6
        colRate.Name = "colRate"
        colRate.ReadOnly = True
        colRate.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colAmenities
        ' 
        colAmenities.DataPropertyName = "amenities"
        colAmenities.HeaderText = "Amenities"
        colAmenities.MinimumWidth = 6
        colAmenities.Name = "colAmenities"
        colAmenities.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnAdd.ForeColor = Color.Beige
        btnAdd.Location = New Point(19, 89)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(197, 61)
        btnAdd.TabIndex = 6
        btnAdd.Text = "＋ ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.OldLace
        btnEdit.ForeColor = Color.Maroon
        btnEdit.Location = New Point(223, 89)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(197, 61)
        btnEdit.TabIndex = 7
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.Location = New Point(630, 89)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(197, 61)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "↻ REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OldLace
        btnDelete.ForeColor = Color.Maroon
        btnDelete.Location = New Point(426, 89)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(197, 61)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(123, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(472, 20)
        Label4.TabIndex = 16
        Label4.Text = "Manage hotel rooms, update details, and keep track of the availability"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(30, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(87, 59)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' RoomControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(btnDelete)
        Controls.Add(btnRefresh)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvRooms)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "RoomControl"
        Size = New Size(1032, 637)
        CType(dgvRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents colRoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents colRoomType As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colRoomSize As DataGridViewTextBoxColumn
    Friend WithEvents colStandardCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colMaxCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colRate As DataGridViewTextBoxColumn
    Friend WithEvents colAmenities As DataGridViewTextBoxColumn
End Class