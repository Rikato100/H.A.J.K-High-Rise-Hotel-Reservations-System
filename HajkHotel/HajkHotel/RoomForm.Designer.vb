<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomForm
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
        Label1 = New Label()
        dgvRooms = New DataGridView()
        colRoomID = New DataGridViewTextBoxColumn()
        colRoomNumber = New DataGridViewTextBoxColumn()
        colRoomType = New DataGridViewTextBoxColumn()
        colFloor = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colRate = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnEdit = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        btnDelete = New Button()
        CType(dgvRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(303, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 30)
        Label1.TabIndex = 1
        Label1.Text = "Room Management"
        ' 
        ' dgvRooms
        ' 
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRooms.Columns.AddRange(New DataGridViewColumn() {colRoomID, colRoomNumber, colRoomType, colFloor, colStatus, colRate})
        dgvRooms.Location = New Point(81, 125)
        dgvRooms.MultiSelect = False
        dgvRooms.Name = "dgvRooms"
        dgvRooms.ReadOnly = True
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRooms.Size = New Size(643, 313)
        dgvRooms.TabIndex = 2
        ' 
        ' colRoomID
        ' 
        colRoomID.HeaderText = "RoomID"
        colRoomID.Name = "colRoomID"
        colRoomID.ReadOnly = True
        ' 
        ' colRoomNumber
        ' 
        colRoomNumber.HeaderText = "Room Number"
        colRoomNumber.Name = "colRoomNumber"
        colRoomNumber.ReadOnly = True
        ' 
        ' colRoomType
        ' 
        colRoomType.HeaderText = "Room Type"
        colRoomType.Name = "colRoomType"
        colRoomType.ReadOnly = True
        ' 
        ' colFloor
        ' 
        colFloor.HeaderText = "Floor"
        colFloor.Name = "colFloor"
        colFloor.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colRate
        ' 
        colRate.HeaderText = "Base Rate"
        colRate.Name = "colRate"
        colRate.ReadOnly = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(102, 76)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(107, 34)
        btnAdd.TabIndex = 6
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(226, 76)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(107, 34)
        btnEdit.TabIndex = 7
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(596, 76)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(107, 34)
        btnBack.TabIndex = 8
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(474, 76)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(107, 34)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(352, 76)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(107, 34)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' RoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnRefresh)
        Controls.Add(btnBack)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dgvRooms)
        Controls.Add(Label1)
        Name = "RoomForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Management"
        CType(dgvRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents colRoomID As DataGridViewTextBoxColumn
    Friend WithEvents colRoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents colRoomType As DataGridViewTextBoxColumn
    Friend WithEvents colFloor As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colRate As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
