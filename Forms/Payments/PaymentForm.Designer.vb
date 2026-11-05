<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblGuestName = New Label()
        Label1 = New Label()
        lblTotalAmount = New Label()
        Label3 = New Label()
        lblTotalPaid = New Label()
        Label5 = New Label()
        lblBalance = New Label()
        Label7 = New Label()
        txtAmount = New TextBox()
        cmbMethod = New ComboBox()
        Label8 = New Label()
        txtReference = New TextBox()
        Label9 = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        pnlHeader.Controls.Add(lblGuestName)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(433, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' lblGuestName
        ' 
        lblGuestName.AutoSize = True
        lblGuestName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGuestName.ForeColor = Color.Beige
        lblGuestName.Location = New Point(24, 21)
        lblGuestName.Margin = New Padding(4, 0, 4, 0)
        lblGuestName.Name = "lblGuestName"
        lblGuestName.Size = New Size(120, 25)
        lblGuestName.TabIndex = 0
        lblGuestName.Text = "Guest Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 98)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 17)
        Label1.TabIndex = 1
        Label1.Text = "Total Amount:"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(151, 98)
        lblTotalAmount.Margin = New Padding(4, 0, 4, 0)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(33, 17)
        lblTotalAmount.TabIndex = 2
        lblTotalAmount.Text = "0.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 133)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 3
        Label3.Text = "Total Paid:"
        ' 
        ' lblTotalPaid
        ' 
        lblTotalPaid.AutoSize = True
        lblTotalPaid.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPaid.Location = New Point(151, 133)
        lblTotalPaid.Margin = New Padding(4, 0, 4, 0)
        lblTotalPaid.Name = "lblTotalPaid"
        lblTotalPaid.Size = New Size(32, 17)
        lblTotalPaid.TabIndex = 4
        lblTotalPaid.Text = "0.00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 167)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 17)
        Label5.TabIndex = 5
        Label5.Text = "Balance:"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBalance.ForeColor = Color.Firebrick
        lblBalance.Location = New Point(151, 167)
        lblBalance.Margin = New Padding(4, 0, 4, 0)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(33, 17)
        lblBalance.TabIndex = 6
        lblBalance.Text = "0.00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 219)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 17)
        Label7.TabIndex = 7
        Label7.Text = "Amount Paying:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 9F)
        txtAmount.Location = New Point(151, 217)
        txtAmount.Margin = New Padding(4)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(186, 23)
        txtAmount.TabIndex = 8
        ' 
        ' cmbMethod
        ' 
        cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMethod.Font = New Font("Segoe UI", 9F)
        cmbMethod.FormattingEnabled = True
        cmbMethod.Location = New Point(151, 257)
        cmbMethod.Margin = New Padding(4)
        cmbMethod.Name = "cmbMethod"
        cmbMethod.Size = New Size(186, 23)
        cmbMethod.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(24, 260)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 17)
        Label8.TabIndex = 10
        Label8.Text = "Payment Method:"
        ' 
        ' txtReference
        ' 
        txtReference.Font = New Font("Segoe UI", 9F)
        txtReference.Location = New Point(151, 298)
        txtReference.Margin = New Padding(4)
        txtReference.Name = "txtReference"
        txtReference.Size = New Size(186, 23)
        txtReference.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(24, 300)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 17)
        Label9.TabIndex = 12
        Label9.Text = "Reference #:"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Beige
        btnSave.Location = New Point(52, 364)
        btnSave.Margin = New Padding(4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(129, 40)
        btnSave.TabIndex = 13
        btnSave.Text = "Save Payment"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Beige
        btnCancel.Location = New Point(192, 364)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(129, 40)
        btnCancel.TabIndex = 14
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(221))
        ClientSize = New Size(433, 433)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(Label9)
        Controls.Add(txtReference)
        Controls.Add(Label8)
        Controls.Add(cmbMethod)
        Controls.Add(txtAmount)
        Controls.Add(Label7)
        Controls.Add(lblBalance)
        Controls.Add(Label5)
        Controls.Add(lblTotalPaid)
        Controls.Add(Label3)
        Controls.Add(lblTotalAmount)
        Controls.Add(Label1)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = " "
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblGuestName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPaid As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class