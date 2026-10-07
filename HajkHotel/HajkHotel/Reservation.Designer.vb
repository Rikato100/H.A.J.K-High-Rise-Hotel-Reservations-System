<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        lblGuest = New Label()
        lblRoom = New Label()
        lblCheckIn = New Label()
        lblCheckOut = New Label()
        lblAdults = New Label()
        lblDiscount = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        cmbGuest = New ComboBox()
        cmbRoom = New ComboBox()
        lblRoomRate = New Label()
        txtRoomRate = New TextBox()
        dtpCheckIn = New DateTimePicker()
        dtpCheckOut = New DateTimePicker()
        lblNights = New Label()
        txtNights = New TextBox()
        numAdults = New NumericUpDown()
        lblChildren = New Label()
        numChildren = New NumericUpDown()
        cmbDiscount = New ComboBox()
        txtSubtotal = New TextBox()
        txtDiscountAmount = New TextBox()
        txtVAT = New TextBox()
        txtTotal = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        btnClear = New Button()
        CType(numAdults, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChildren, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(263, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(169, 28)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Add Reservation"
        ' 
        ' lblGuest
        ' 
        lblGuest.AutoSize = True
        lblGuest.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGuest.Location = New Point(101, 109)
        lblGuest.Name = "lblGuest"
        lblGuest.Size = New Size(49, 20)
        lblGuest.TabIndex = 3
        lblGuest.Text = "Guest:"
        ' 
        ' lblRoom
        ' 
        lblRoom.AutoSize = True
        lblRoom.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRoom.Location = New Point(98, 151)
        lblRoom.Name = "lblRoom"
        lblRoom.Size = New Size(52, 20)
        lblRoom.TabIndex = 4
        lblRoom.Text = "Room:"
        ' 
        ' lblCheckIn
        ' 
        lblCheckIn.AutoSize = True
        lblCheckIn.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckIn.Location = New Point(98, 210)
        lblCheckIn.Name = "lblCheckIn"
        lblCheckIn.Size = New Size(69, 20)
        lblCheckIn.TabIndex = 5
        lblCheckIn.Text = "Check-In:"
        ' 
        ' lblCheckOut
        ' 
        lblCheckOut.AutoSize = True
        lblCheckOut.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckOut.Location = New Point(98, 247)
        lblCheckOut.Name = "lblCheckOut"
        lblCheckOut.Size = New Size(81, 20)
        lblCheckOut.TabIndex = 6
        lblCheckOut.Text = "Check-Out:"
        ' 
        ' lblAdults
        ' 
        lblAdults.AutoSize = True
        lblAdults.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAdults.Location = New Point(98, 311)
        lblAdults.Name = "lblAdults"
        lblAdults.Size = New Size(54, 20)
        lblAdults.TabIndex = 7
        lblAdults.Text = "Adults:"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDiscount.Location = New Point(98, 367)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(70, 20)
        lblDiscount.TabIndex = 8
        lblDiscount.Text = "Discount:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(98, 423)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 9
        Label5.Text = "Subtotal:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(98, 459)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 10
        Label6.Text = "Discount:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(98, 492)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 20)
        Label7.TabIndex = 11
        Label7.Text = "VAT:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(98, 526)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 20)
        Label8.TabIndex = 12
        Label8.Text = "Total:"
        ' 
        ' cmbGuest
        ' 
        cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGuest.FormattingEnabled = True
        cmbGuest.Location = New Point(203, 108)
        cmbGuest.Name = "cmbGuest"
        cmbGuest.Size = New Size(191, 25)
        cmbGuest.TabIndex = 13
        ' 
        ' cmbRoom
        ' 
        cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(203, 146)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(191, 25)
        cmbRoom.TabIndex = 14
        ' 
        ' lblRoomRate
        ' 
        lblRoomRate.AutoSize = True
        lblRoomRate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRoomRate.Location = New Point(419, 151)
        lblRoomRate.Name = "lblRoomRate"
        lblRoomRate.Size = New Size(42, 20)
        lblRoomRate.TabIndex = 15
        lblRoomRate.Text = "Rate:"
        ' 
        ' txtRoomRate
        ' 
        txtRoomRate.Location = New Point(467, 146)
        txtRoomRate.Name = "txtRoomRate"
        txtRoomRate.ReadOnly = True
        txtRoomRate.Size = New Size(100, 25)
        txtRoomRate.TabIndex = 16
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.Format = DateTimePickerFormat.Short
        dtpCheckIn.Location = New Point(203, 210)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(177, 25)
        dtpCheckIn.TabIndex = 17
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.Format = DateTimePickerFormat.Short
        dtpCheckOut.Location = New Point(203, 247)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(177, 25)
        dtpCheckOut.TabIndex = 18
        ' 
        ' lblNights
        ' 
        lblNights.AutoSize = True
        lblNights.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNights.Location = New Point(406, 247)
        lblNights.Name = "lblNights"
        lblNights.Size = New Size(55, 20)
        lblNights.TabIndex = 19
        lblNights.Text = "Nights:"
        ' 
        ' txtNights
        ' 
        txtNights.Location = New Point(467, 247)
        txtNights.Name = "txtNights"
        txtNights.ReadOnly = True
        txtNights.Size = New Size(87, 25)
        txtNights.TabIndex = 20
        ' 
        ' numAdults
        ' 
        numAdults.Location = New Point(203, 306)
        numAdults.Name = "numAdults"
        numAdults.Size = New Size(67, 25)
        numAdults.TabIndex = 21
        ' 
        ' lblChildren
        ' 
        lblChildren.AutoSize = True
        lblChildren.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblChildren.Location = New Point(313, 311)
        lblChildren.Name = "lblChildren"
        lblChildren.Size = New Size(67, 20)
        lblChildren.TabIndex = 22
        lblChildren.Text = "Children:"
        ' 
        ' numChildren
        ' 
        numChildren.Location = New Point(416, 306)
        numChildren.Name = "numChildren"
        numChildren.Size = New Size(67, 25)
        numChildren.TabIndex = 23
        ' 
        ' cmbDiscount
        ' 
        cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDiscount.FormattingEnabled = True
        cmbDiscount.Location = New Point(214, 367)
        cmbDiscount.Name = "cmbDiscount"
        cmbDiscount.Size = New Size(125, 25)
        cmbDiscount.TabIndex = 24
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(214, 418)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(112, 25)
        txtSubtotal.TabIndex = 25
        ' 
        ' txtDiscountAmount
        ' 
        txtDiscountAmount.Location = New Point(214, 454)
        txtDiscountAmount.Name = "txtDiscountAmount"
        txtDiscountAmount.ReadOnly = True
        txtDiscountAmount.Size = New Size(112, 25)
        txtDiscountAmount.TabIndex = 26
        ' 
        ' txtVAT
        ' 
        txtVAT.Location = New Point(214, 487)
        txtVAT.Name = "txtVAT"
        txtVAT.ReadOnly = True
        txtVAT.Size = New Size(112, 25)
        txtVAT.TabIndex = 27
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(214, 521)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(112, 25)
        txtTotal.TabIndex = 28
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(419, 413)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 40)
        btnSave.TabIndex = 29
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(419, 506)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(104, 40)
        btnCancel.TabIndex = 30
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(419, 460)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(104, 40)
        btnClear.TabIndex = 31
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 656)
        Controls.Add(btnClear)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtTotal)
        Controls.Add(txtVAT)
        Controls.Add(txtDiscountAmount)
        Controls.Add(txtSubtotal)
        Controls.Add(cmbDiscount)
        Controls.Add(numChildren)
        Controls.Add(lblChildren)
        Controls.Add(numAdults)
        Controls.Add(txtNights)
        Controls.Add(lblNights)
        Controls.Add(dtpCheckOut)
        Controls.Add(dtpCheckIn)
        Controls.Add(txtRoomRate)
        Controls.Add(lblRoomRate)
        Controls.Add(cmbRoom)
        Controls.Add(cmbGuest)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblDiscount)
        Controls.Add(lblAdults)
        Controls.Add(lblCheckOut)
        Controls.Add(lblCheckIn)
        Controls.Add(lblRoom)
        Controls.Add(lblGuest)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        CType(numAdults, ComponentModel.ISupportInitialize).EndInit()
        CType(numChildren, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGuest As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblAdults As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbGuest As ComboBox
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents lblRoomRate As Label
    Friend WithEvents txtRoomRate As TextBox
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents lblNights As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents numAdults As NumericUpDown
    Friend WithEvents lblChildren As Label
    Friend WithEvents numChildren As NumericUpDown
    Friend WithEvents cmbDiscount As ComboBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
End Class
