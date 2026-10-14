<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGuestForm
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
        txtSurname = New TextBox()
        txtFirstName = New TextBox()
        txtMiddle = New TextBox()
        txtContact = New TextBox()
        txtEmail = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cmbValidIDType = New ComboBox()
        Label7 = New Label()
        txtValidIDNumber = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(164, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(148, 32)
        lblTitle.TabIndex = 1
        lblTitle.Text = "ADD GUEST"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 2
        Label2.Text = "Surname:"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(164, 112)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(253, 23)
        txtSurname.TabIndex = 3
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(164, 154)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(253, 23)
        txtFirstName.TabIndex = 4
        ' 
        ' txtMiddle
        ' 
        txtMiddle.Location = New Point(164, 196)
        txtMiddle.Name = "txtMiddle"
        txtMiddle.Size = New Size(253, 23)
        txtMiddle.TabIndex = 5
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(164, 237)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(253, 23)
        txtContact.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(164, 276)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(253, 23)
        txtEmail.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 21)
        Label1.TabIndex = 8
        Label1.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 21)
        Label3.TabIndex = 9
        Label3.Text = "Middle Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 21)
        Label4.TabIndex = 10
        Label4.Text = "Contact Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(89, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 21)
        Label5.TabIndex = 11
        Label5.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(38, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 21)
        Label6.TabIndex = 12
        Label6.Text = "Valid ID Type:"
        ' 
        ' cmbValidIDType
        ' 
        cmbValidIDType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbValidIDType.FormattingEnabled = True
        cmbValidIDType.Items.AddRange(New Object() {"Senior Citizen ID", "PWD ID", "Driver's License", "Passport", "National ID", "Other"})
        cmbValidIDType.Location = New Point(164, 318)
        cmbValidIDType.Name = "cmbValidIDType"
        cmbValidIDType.Size = New Size(253, 23)
        cmbValidIDType.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 360)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 21)
        Label7.TabIndex = 14
        Label7.Text = "Valid ID Number:"
        ' 
        ' txtValidIDNumber
        ' 
        txtValidIDNumber.Location = New Point(164, 360)
        txtValidIDNumber.Name = "txtValidIDNumber"
        txtValidIDNumber.Size = New Size(253, 23)
        txtValidIDNumber.TabIndex = 15
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(119, 414)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 40)
        btnSave.TabIndex = 16
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(229, 414)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(104, 40)
        btnCancel.TabIndex = 17
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' AddGuestForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 519)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtValidIDNumber)
        Controls.Add(Label7)
        Controls.Add(cmbValidIDType)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtEmail)
        Controls.Add(txtContact)
        Controls.Add(txtMiddle)
        Controls.Add(txtFirstName)
        Controls.Add(txtSurname)
        Controls.Add(Label2)
        Controls.Add(lblTitle)
        Name = "AddGuestForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddGuestForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbValidIDType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValidIDNumber As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
