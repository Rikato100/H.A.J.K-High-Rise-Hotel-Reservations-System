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
        pnlHeader.BackColor = Color.FromArgb(64, 0, 0)
        pnlHeader.Controls.Add(lblGuestName)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(427, 100)
        pnlHeader.TabIndex = 0
        ' 
        ' lblGuestName
        ' 
        lblGuestName.AutoSize = True
        lblGuestName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblGuestName.ForeColor = Color.Beige
        lblGuestName.Location = New Point(27, 28)
        lblGuestName.Margin = New Padding(4, 0, 4, 0)
        lblGuestName.Name = "lblGuestName"
        lblGuestName.Size = New Size(153, 32)
        lblGuestName.TabIndex = 0
        lblGuestName.Text = "Guest Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.Location = New Point(27, 131)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 23)
        Label1.TabIndex = 1
        Label1.Text = "Total Amount:"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblTotalAmount.Location = New Point(173, 131)
        lblTotalAmount.Margin = New Padding(4, 0, 4, 0)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(45, 23)
        lblTotalAmount.TabIndex = 2
        lblTotalAmount.Text = "0.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label3.Location = New Point(27, 177)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 23)
        Label3.TabIndex = 3
        Label3.Text = "Total Paid:"
        ' 
        ' lblTotalPaid
        ' 
        lblTotalPaid.AutoSize = True
        lblTotalPaid.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblTotalPaid.Location = New Point(173, 177)
        lblTotalPaid.Margin = New Padding(4, 0, 4, 0)
        lblTotalPaid.Name = "lblTotalPaid"
        lblTotalPaid.Size = New Size(41, 23)
        lblTotalPaid.TabIndex = 4
        lblTotalPaid.Text = "0.00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label5.Location = New Point(27, 223)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 23)
        Label5.TabIndex = 5
        Label5.Text = "Balance:"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblBalance.ForeColor = Color.Firebrick
        lblBalance.Location = New Point(173, 223)
        lblBalance.Margin = New Padding(4, 0, 4, 0)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(45, 23)
        lblBalance.TabIndex = 6
        lblBalance.Text = "0.00"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label7.Location = New Point(27, 292)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 23)
        Label7.TabIndex = 7
        Label7.Text = "Amount Paying:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 9.0F)
        txtAmount.Location = New Point(173, 289)
        txtAmount.Margin = New Padding(4, 5, 4, 5)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(212, 27)
        txtAmount.TabIndex = 8
        ' 
        ' cmbMethod
        ' 
        cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMethod.Font = New Font("Segoe UI", 9.0F)
        cmbMethod.FormattingEnabled = True
        cmbMethod.Location = New Point(173, 343)
        cmbMethod.Margin = New Padding(4, 5, 4, 5)
        cmbMethod.Name = "cmbMethod"
        cmbMethod.Size = New Size(212, 28)
        cmbMethod.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label8.Location = New Point(27, 346)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(145, 23)
        Label8.TabIndex = 10
        Label8.Text = "Payment Method:"
        ' 
        ' txtReference
        ' 
        txtReference.Font = New Font("Segoe UI", 9.0F)
        txtReference.Location = New Point(173, 397)
        txtReference.Margin = New Padding(4, 5, 4, 5)
        txtReference.Name = "txtReference"
        txtReference.Size = New Size(212, 27)
        txtReference.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label9.Location = New Point(27, 400)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 23)
        Label9.TabIndex = 12
        Label9.Text = "Reference #:"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(64, 0, 0)
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnSave.ForeColor = Color.Beige
        btnSave.Location = New Point(60, 485)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(147, 54)
        btnSave.TabIndex = 13
        btnSave.Text = "Save Payment"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(64, 0, 0)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnCancel.ForeColor = Color.Beige
        btnCancel.Location = New Point(220, 485)
        btnCancel.Margin = New Padding(4, 5, 4, 5)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(147, 54)
        btnCancel.TabIndex = 14
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(245, 239, 221)
        ClientSize = New Size(427, 577)
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
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Process Payment"
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