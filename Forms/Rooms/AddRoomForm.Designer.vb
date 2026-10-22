<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddRoomForm
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
        lblTitle = New Label()
        Label2 = New Label()
        txtRoomNumber = New TextBox()
        Label3 = New Label()
        cmbRoomType = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        numFloor = New NumericUpDown()
        cmbStatus = New ComboBox()
        txtAmenities = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        Panel1 = New Panel()
        CType(numFloor, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblTitle.Location = New Point(170, 21)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(195, 34)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ADD ROOM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label2.Location = New Point(70, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 1
        Label2.Text = "Room Number:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.BackColor = Color.White
        txtRoomNumber.ForeColor = Color.Maroon
        txtRoomNumber.Location = New Point(219, 100)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(219, 23)
        txtRoomNumber.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label3.Location = New Point(70, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 3
        Label3.Text = "Room Type:"
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.BackColor = Color.White
        cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoomType.ForeColor = Color.Black
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(219, 138)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(219, 23)
        cmbRoomType.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label4.Location = New Point(70, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 5
        Label4.Text = "Floor:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label5.Location = New Point(70, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 6
        Label5.Text = "Status:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label6.Location = New Point(70, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 20)
        Label6.TabIndex = 7
        Label6.Text = "Amenities:"
        ' 
        ' numFloor
        ' 
        numFloor.BackColor = Color.White
        numFloor.ForeColor = Color.Maroon
        numFloor.Location = New Point(219, 176)
        numFloor.Name = "numFloor"
        numFloor.Size = New Size(219, 23)
        numFloor.TabIndex = 8
        numFloor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.White
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.ForeColor = Color.Black
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(219, 213)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(219, 23)
        cmbStatus.TabIndex = 10
        ' 
        ' txtAmenities
        ' 
        txtAmenities.BackColor = Color.White
        txtAmenities.ForeColor = Color.Maroon
        txtAmenities.Location = New Point(219, 250)
        txtAmenities.Multiline = True
        txtAmenities.Name = "txtAmenities"
        txtAmenities.Size = New Size(219, 52)
        txtAmenities.TabIndex = 11
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSave.Location = New Point(140, 322)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 36)
        btnSave.TabIndex = 12
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.OldLace
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnCancel.Location = New Point(271, 322)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(114, 36)
        btnCancel.TabIndex = 13
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.Maroon
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(539, 76)
        Panel1.TabIndex = 15
        ' 
        ' AddRoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(539, 385)
        Controls.Add(Panel1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtAmenities)
        Controls.Add(cmbStatus)
        Controls.Add(numFloor)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmbRoomType)
        Controls.Add(Label3)
        Controls.Add(txtRoomNumber)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddRoomForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Room"
        CType(numFloor, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numFloor As NumericUpDown
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtAmenities As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
End Class