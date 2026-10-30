<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddGuestForm
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
        pnlHeader = New Panel()
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
        txtNotes = New TextBox()
        lblNotes = New Label()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Font = New Font("Mongolian Baiti", 18.0F, FontStyle.Bold)
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(862, 100)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Mongolian Baiti", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Beige
        lblTitle.Location = New Point(334, 33)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(194, 31)
        lblTitle.TabIndex = 1
        lblTitle.Text = "ADD GUEST"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Location = New Point(14, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 25)
        Label2.TabIndex = 2
        Label2.Text = "Surname:"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(187, 163)
        txtSurname.Margin = New Padding(3, 4, 3, 4)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(289, 27)
        txtSurname.TabIndex = 3
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(187, 219)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(289, 27)
        txtFirstName.TabIndex = 4
        ' 
        ' txtMiddle
        ' 
        txtMiddle.Location = New Point(187, 275)
        txtMiddle.Margin = New Padding(3, 4, 3, 4)
        txtMiddle.Name = "txtMiddle"
        txtMiddle.Size = New Size(289, 27)
        txtMiddle.TabIndex = 5
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(187, 329)
        txtContact.Margin = New Padding(3, 4, 3, 4)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(289, 27)
        txtContact.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(187, 381)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(289, 27)
        txtEmail.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(14, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 25)
        Label1.TabIndex = 8
        Label1.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label3.Location = New Point(14, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 25)
        Label3.TabIndex = 9
        Label3.Text = "Middle Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label4.Location = New Point(14, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 25)
        Label4.TabIndex = 10
        Label4.Text = "Contact Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label5.Location = New Point(14, 381)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 25)
        Label5.TabIndex = 11
        Label5.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label6.Location = New Point(14, 439)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 25)
        Label6.TabIndex = 12
        Label6.Text = "Valid ID Type:"
        ' 
        ' cmbValidIDType
        ' 
        cmbValidIDType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbValidIDType.FormattingEnabled = True
        cmbValidIDType.Items.AddRange(New Object() {"Senior Citizen ID", "PWD ID", "Driver's License", "Passport", "National ID", "Other"})
        cmbValidIDType.Location = New Point(187, 437)
        cmbValidIDType.Margin = New Padding(3, 4, 3, 4)
        cmbValidIDType.Name = "cmbValidIDType"
        cmbValidIDType.Size = New Size(289, 28)
        cmbValidIDType.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label7.Location = New Point(14, 493)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 25)
        Label7.TabIndex = 14
        Label7.Text = "Valid ID Number:"
        ' 
        ' txtValidIDNumber
        ' 
        txtValidIDNumber.Location = New Point(187, 493)
        txtValidIDNumber.Margin = New Padding(3, 4, 3, 4)
        txtValidIDNumber.Name = "txtValidIDNumber"
        txtValidIDNumber.Size = New Size(289, 27)
        txtValidIDNumber.TabIndex = 15
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Beige
        btnSave.Location = New Point(571, 587)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(109, 51)
        btnSave.TabIndex = 16
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Beige
        btnCancel.Location = New Point(695, 587)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(109, 51)
        btnCancel.TabIndex = 17
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtNotes
        ' 
        txtNotes.BackColor = Color.Beige
        txtNotes.Location = New Point(534, 199)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(269, 324)
        txtNotes.TabIndex = 18
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblNotes.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblNotes.Location = New Point(534, 163)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(69, 25)
        lblNotes.TabIndex = 19
        lblNotes.Text = "Notes:"
        ' 
        ' AddGuestForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(221))
        ClientSize = New Size(862, 692)
        Controls.Add(lblNotes)
        Controls.Add(txtNotes)
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
        Controls.Add(pnlHeader)
        ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddGuestForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Guest"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
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
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
End Class