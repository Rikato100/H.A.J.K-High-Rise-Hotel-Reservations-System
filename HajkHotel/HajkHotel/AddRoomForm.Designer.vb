<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRoomForm
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
        TextBox1 = New TextBox()
        CType(numFloor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(158, 31)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(167, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ADD ROOM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(91, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 21)
        Label2.TabIndex = 1
        Label2.Text = "Room Number:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(214, 126)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(178, 23)
        txtRoomNumber.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 21)
        Label3.TabIndex = 3
        Label3.Text = "Room Type:"
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Location = New Point(214, 164)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(178, 23)
        cmbRoomType.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(91, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 21)
        Label4.TabIndex = 5
        Label4.Text = "Floor:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(91, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 21)
        Label5.TabIndex = 6
        Label5.Text = "Status:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(91, 281)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 21)
        Label6.TabIndex = 7
        Label6.Text = "Amenities:"
        ' 
        ' numFloor
        ' 
        numFloor.Location = New Point(214, 202)
        numFloor.Name = "numFloor"
        numFloor.Size = New Size(178, 23)
        numFloor.TabIndex = 8
        numFloor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(214, 240)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(178, 23)
        cmbStatus.TabIndex = 10
        ' 
        ' txtAmenities
        ' 
        txtAmenities.Location = New Point(214, 279)
        txtAmenities.Name = "txtAmenities"
        txtAmenities.Size = New Size(178, 23)
        txtAmenities.TabIndex = 11
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(143, 349)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 40)
        btnSave.TabIndex = 12
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(253, 349)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(104, 40)
        btnCancel.TabIndex = 13
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(214, 315)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(178, 23)
        TextBox1.TabIndex = 14
        ' 
        ' AddRoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 443)
        Controls.Add(TextBox1)
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
        Controls.Add(lblTitle)
        Name = "AddRoomForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Room"
        CType(numFloor, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
End Class
