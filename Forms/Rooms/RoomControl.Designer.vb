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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Label1.Location = New Point(105, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 24)
        Label1.TabIndex = 1
        Label1.Text = "Room Management"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgvRooms
        ' 
        dgvRooms.Anchor = CType((AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right), AnchorStyles)
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRooms.BackgroundColor = Color.Beige
        dgvRooms.BorderStyle = BorderStyle.None
        dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.Maroon
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Beige
        DataGridViewCellStyle7.SelectionBackColor = Color.Maroon
        DataGridViewCellStyle7.SelectionForeColor = Color.Beige
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvRooms.ColumnHeadersHeight = 47
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRooms.Columns.AddRange(New DataGridViewColumn() {colRoomNumber, colRoomType, colStatus, colRoomSize, colStandardCapacity, colMaxCapacity, colRate, colAmenities})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.Beige
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle8.ForeColor = Color.Maroon
        DataGridViewCellStyle8.SelectionBackColor = Color.Beige
        DataGridViewCellStyle8.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvRooms.DefaultCellStyle = DataGridViewCellStyle8
        dgvRooms.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRooms.EnableHeadersVisualStyles = False
        dgvRooms.GridColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        dgvRooms.Location = New Point(17, 119)
        dgvRooms.MultiSelect = False
        dgvRooms.Name = "dgvRooms"
        dgvRooms.ReadOnly = True
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.Beige
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle9.ForeColor = Color.Maroon
        DataGridViewCellStyle9.SelectionBackColor = Color.Beige
        DataGridViewCellStyle9.SelectionForeColor = Color.Maroon
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvRooms.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvRooms.RowHeadersWidth = 51
        dgvRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRooms.Size = New Size(869, 340)
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
        btnAdd.Location = New Point(17, 67)
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
        btnEdit.Location = New Point(195, 67)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(172, 46)
        btnEdit.TabIndex = 7
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.OldLace
        btnRefresh.Location = New Point(551, 67)
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
        btnDelete.Location = New Point(373, 67)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(172, 46)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(108, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(370, 15)
        Label4.TabIndex = 16
        Label4.Text = "Manage hotel rooms, update details, and keep track of the availability"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 17)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(82, 46)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' RoomControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        Name = "RoomControl"
        Size = New Size(903, 478)
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