<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomtypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomtypes))
        Panel1 = New Panel()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnAddRoomType = New Button()
        dgvRoomTypes = New DataGridView()
        colRoomType = New DataGridViewTextBoxColumn()
        colRoomSize = New DataGridViewTextBoxColumn()
        colStandardCapacity = New DataGridViewTextBoxColumn()
        colMaxCapacity = New DataGridViewTextBoxColumn()
        colBaseRate = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        Label3 = New Label()
        Button9 = New Button()
        Button8 = New Button()
        Label6 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvRoomTypes, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(61), CByte(2), CByte(2))
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(210, 583)
        Panel1.TabIndex = 1
        ' 
        ' Button7
        ' 
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.White
        Button7.Location = New Point(12, 495)
        Button7.Name = "Button7"
        Button7.Size = New Size(190, 45)
        Button7.TabIndex = 11
        Button7.Text = " 🚪  Logout  "
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.White
        Button6.Location = New Point(12, 334)
        Button6.Name = "Button6"
        Button6.Size = New Size(190, 45)
        Button6.TabIndex = 10
        Button6.Text = "⚙   General Settings  "
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.White
        Button5.Location = New Point(12, 290)
        Button5.Name = "Button5"
        Button5.Size = New Size(190, 45)
        Button5.TabIndex = 9
        Button5.Text = "📊   Reports "
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.White
        Button4.Location = New Point(12, 243)
        Button4.Name = "Button4"
        Button4.Size = New Size(190, 45)
        Button4.TabIndex = 8
        Button4.Text = "👥   Users "
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(12, 196)
        Button3.Name = "Button3"
        Button3.Size = New Size(190, 45)
        Button3.TabIndex = 7
        Button3.Text = "🏨   Hotel Management"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(749, 150)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 45)
        Button1.TabIndex = 5
        Button1.Text = " 🏠   Home"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 4.20000029F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(39, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 10)
        Label2.TabIndex = 4
        Label2.Text = "Where Every Stay Feels Ordinary."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(61), CByte(2), CByte(2))
        Label1.Font = New Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(22, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 20)
        Label1.TabIndex = 3
        Label1.Text = "H.A.J.K High Rise Hotel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Beige
        Panel2.Controls.Add(btnAddRoomType)
        Panel2.Controls.Add(dgvRoomTypes)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(210, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(879, 583)
        Panel2.TabIndex = 2
        ' 
        ' btnAddRoomType
        ' 
        btnAddRoomType.FlatStyle = FlatStyle.Popup
        btnAddRoomType.Location = New Point(700, 54)
        btnAddRoomType.Name = "btnAddRoomType"
        btnAddRoomType.Size = New Size(150, 40)
        btnAddRoomType.TabIndex = 8
        btnAddRoomType.Text = "+ Add Room Type"
        btnAddRoomType.UseVisualStyleBackColor = True
        ' 
        ' dgvRoomTypes
        ' 
        dgvRoomTypes.AllowUserToOrderColumns = True
        dgvRoomTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRoomTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoomTypes.Columns.AddRange(New DataGridViewColumn() {colRoomType, colRoomSize, colStandardCapacity, colMaxCapacity, colBaseRate, colEdit, colDelete})
        dgvRoomTypes.Location = New Point(15, 100)
        dgvRoomTypes.Name = "dgvRoomTypes"
        dgvRoomTypes.RowHeadersWidth = 51
        dgvRoomTypes.Size = New Size(835, 440)
        dgvRoomTypes.TabIndex = 7
        ' 
        ' colRoomType
        ' 
        colRoomType.HeaderText = "Room Type"
        colRoomType.MinimumWidth = 6
        colRoomType.Name = "colRoomType"
        ' 
        ' colRoomSize
        ' 
        colRoomSize.HeaderText = "Room Size"
        colRoomSize.MinimumWidth = 6
        colRoomSize.Name = "colRoomSize"
        ' 
        ' colStandardCapacity
        ' 
        colStandardCapacity.HeaderText = "Standard Capacity"
        colStandardCapacity.MinimumWidth = 6
        colStandardCapacity.Name = "colStandardCapacity"
        ' 
        ' colMaxCapacity
        ' 
        colMaxCapacity.HeaderText = "Max Capacity"
        colMaxCapacity.MinimumWidth = 6
        colMaxCapacity.Name = "colMaxCapacity"
        ' 
        ' colBaseRate
        ' 
        colBaseRate.HeaderText = "Base Rate"
        colBaseRate.MinimumWidth = 6
        colBaseRate.Name = "colBaseRate"
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Action"
        colEdit.MinimumWidth = 6
        colEdit.Name = "colEdit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        ' 
        ' colDelete
        ' 
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(321, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(241, 44)
        Label3.TabIndex = 6
        Label3.Text = "Room Types"
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Beige
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Location = New Point(158, 23)
        Button9.Name = "Button9"
        Button9.Size = New Size(145, 29)
        Button9.TabIndex = 5
        Button9.Text = "Room Inventory"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Beige
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(15, 23)
        Button8.Name = "Button8"
        Button8.Size = New Size(145, 29)
        Button8.TabIndex = 4
        Button8.Text = "Room Types"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 3
        Label6.Text = "Label6"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Khaki
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(38, 150)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(0, 0)
        Panel3.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(4, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 54)
        Label7.TabIndex = 2
        Label7.Text = "28/50"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(4, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(61, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Monotype Corsiva", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 21)
        Label5.TabIndex = 0
        Label5.Text = "Available Rooms"
        ' 
        ' roomtypes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1089, 583)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "roomtypes"
        Text = "roomTypes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvRoomTypes, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents dgvRoomTypes As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents colRoomType As DataGridViewTextBoxColumn
    Friend WithEvents colRoomSize As DataGridViewTextBoxColumn
    Friend WithEvents colStandardCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colMaxCapacity As DataGridViewTextBoxColumn
    Friend WithEvents colBaseRate As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents btnAddRoomType As Button
End Class
