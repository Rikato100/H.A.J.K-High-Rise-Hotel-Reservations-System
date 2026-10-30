<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservation
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
        grpGuest = New GroupBox()
        Label1 = New Label()
        cmbGuest = New ComboBox()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        lblMiddleName = New Label()
        txtMiddleName = New TextBox()
        lblSurname = New Label()
        txtSurname = New TextBox()
        lblContact = New Label()
        txtContact = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblIdType = New Label()
        txtValidIdType = New TextBox()
        lblIdNumber = New Label()
        txtValidIdNumber = New TextBox()
        grpGeneral = New GroupBox()
        lblCode = New Label()
        txtResCode = New TextBox()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        lblRoomSelect = New Label()
        cmbRoom = New ComboBox()
        lblRoomRate = New Label()
        txtRoomRate = New TextBox()
        lblCheckIn = New Label()
        dtpCheckIn = New DateTimePicker()
        lblCheckOut = New Label()
        dtpCheckOut = New DateTimePicker()
        lblNights = New Label()
        txtNights = New TextBox()
        lblAdults = New Label()
        numAdults = New NumericUpDown()
        lblChildren = New Label()
        numChildren = New NumericUpDown()
        grpPayment = New GroupBox()
        lblDiscount = New Label()
        cmbDiscount = New ComboBox()
        lblPayMethod = New Label()
        cmbPaymentMethod = New ComboBox()
        lblRefNo = New Label()
        txtReferenceNo = New TextBox()
        lblSubtotal = New Label()
        txtSubtotal = New TextBox()
        lblDiscountAmt = New Label()
        txtDiscountAmount = New TextBox()
        lblVAT = New Label()
        txtVAT = New TextBox()
        lblTotal = New Label()
        txtTotal = New TextBox()
        btnSave = New Button()
        btnClear = New Button()
        btnCancel = New Button()
        lblTitle = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        grpGuest.SuspendLayout()
        grpGeneral.SuspendLayout()
        CType(numAdults, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChildren, ComponentModel.ISupportInitialize).BeginInit()
        grpPayment.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpGuest
        ' 
        grpGuest.Controls.Add(Label1)
        grpGuest.Controls.Add(cmbGuest)
        grpGuest.Controls.Add(lblFirstName)
        grpGuest.Controls.Add(txtFirstName)
        grpGuest.Controls.Add(lblMiddleName)
        grpGuest.Controls.Add(txtMiddleName)
        grpGuest.Controls.Add(lblSurname)
        grpGuest.Controls.Add(txtSurname)
        grpGuest.Controls.Add(lblContact)
        grpGuest.Controls.Add(txtContact)
        grpGuest.Controls.Add(lblEmail)
        grpGuest.Controls.Add(txtEmail)
        grpGuest.Controls.Add(lblIdType)
        grpGuest.Controls.Add(txtValidIdType)
        grpGuest.Controls.Add(lblIdNumber)
        grpGuest.Controls.Add(txtValidIdNumber)
        grpGuest.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpGuest.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        grpGuest.Location = New Point(18, 65)
        grpGuest.Name = "grpGuest"
        grpGuest.Size = New Size(325, 360)
        grpGuest.TabIndex = 1
        grpGuest.TabStop = False
        grpGuest.Text = "Guest Information"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        Label1.Location = New Point(18, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 17)
        Label1.TabIndex = 15
        Label1.Text = "Select existing guest:"
        ' 
        ' cmbGuest
        ' 
        cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGuest.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGuest.FormattingEnabled = True
        cmbGuest.Location = New Point(18, 60)
        cmbGuest.Name = "cmbGuest"
        cmbGuest.Size = New Size(282, 29)
        cmbGuest.TabIndex = 14
        cmbGuest.Tag = ""
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblFirstName.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblFirstName.Location = New Point(18, 105)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(79, 17)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 9.5F)
        txtFirstName.Location = New Point(115, 100)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(185, 29)
        txtFirstName.TabIndex = 1
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblMiddleName.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblMiddleName.Location = New Point(18, 140)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(95, 17)
        lblMiddleName.TabIndex = 2
        lblMiddleName.Text = "Middle Name:"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Segoe UI", 9.5F)
        txtMiddleName.Location = New Point(115, 135)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(185, 29)
        txtMiddleName.TabIndex = 3
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblSurname.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSurname.Location = New Point(18, 175)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(66, 17)
        lblSurname.TabIndex = 4
        lblSurname.Text = "Surname:"
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Segoe UI", 9.5F)
        txtSurname.Location = New Point(115, 170)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(185, 29)
        txtSurname.TabIndex = 5
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblContact.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblContact.Location = New Point(18, 210)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(59, 17)
        lblContact.TabIndex = 6
        lblContact.Text = "Contact:"
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 9.5F)
        txtContact.Location = New Point(115, 205)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(185, 29)
        txtContact.TabIndex = 7
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblEmail.Location = New Point(18, 245)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 17)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 9.5F)
        txtEmail.Location = New Point(115, 240)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(185, 29)
        txtEmail.TabIndex = 9
        ' 
        ' lblIdType
        ' 
        lblIdType.AutoSize = True
        lblIdType.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblIdType.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblIdType.Location = New Point(18, 280)
        lblIdType.Name = "lblIdType"
        lblIdType.Size = New Size(59, 17)
        lblIdType.TabIndex = 10
        lblIdType.Text = "ID Type:"
        ' 
        ' txtValidIdType
        ' 
        txtValidIdType.Font = New Font("Segoe UI", 9.5F)
        txtValidIdType.Location = New Point(115, 275)
        txtValidIdType.Name = "txtValidIdType"
        txtValidIdType.Size = New Size(185, 29)
        txtValidIdType.TabIndex = 11
        ' 
        ' lblIdNumber
        ' 
        lblIdNumber.AutoSize = True
        lblIdNumber.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblIdNumber.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblIdNumber.Location = New Point(18, 315)
        lblIdNumber.Name = "lblIdNumber"
        lblIdNumber.Size = New Size(81, 17)
        lblIdNumber.TabIndex = 12
        lblIdNumber.Text = "ID Number:"
        ' 
        ' txtValidIdNumber
        ' 
        txtValidIdNumber.Font = New Font("Segoe UI", 9.5F)
        txtValidIdNumber.Location = New Point(115, 310)
        txtValidIdNumber.Name = "txtValidIdNumber"
        txtValidIdNumber.Size = New Size(185, 29)
        txtValidIdNumber.TabIndex = 13
        ' 
        ' grpGeneral
        ' 
        grpGeneral.Controls.Add(lblCode)
        grpGeneral.Controls.Add(txtResCode)
        grpGeneral.Controls.Add(lblStatus)
        grpGeneral.Controls.Add(cmbStatus)
        grpGeneral.Controls.Add(lblRoomSelect)
        grpGeneral.Controls.Add(cmbRoom)
        grpGeneral.Controls.Add(lblRoomRate)
        grpGeneral.Controls.Add(txtRoomRate)
        grpGeneral.Controls.Add(lblCheckIn)
        grpGeneral.Controls.Add(dtpCheckIn)
        grpGeneral.Controls.Add(lblCheckOut)
        grpGeneral.Controls.Add(dtpCheckOut)
        grpGeneral.Controls.Add(lblNights)
        grpGeneral.Controls.Add(txtNights)
        grpGeneral.Controls.Add(lblAdults)
        grpGeneral.Controls.Add(numAdults)
        grpGeneral.Controls.Add(lblChildren)
        grpGeneral.Controls.Add(numChildren)
        grpGeneral.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpGeneral.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        grpGeneral.Location = New Point(358, 65)
        grpGeneral.Name = "grpGeneral"
        grpGeneral.Size = New Size(325, 360)
        grpGeneral.TabIndex = 2
        grpGeneral.TabStop = False
        grpGeneral.Text = "Booking Information"
        ' 
        ' lblCode
        ' 
        lblCode.AutoSize = True
        lblCode.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblCode.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblCode.Location = New Point(18, 35)
        lblCode.Name = "lblCode"
        lblCode.Size = New Size(72, 17)
        lblCode.TabIndex = 0
        lblCode.Text = "Res. Code:"
        ' 
        ' txtResCode
        ' 
        txtResCode.Font = New Font("Segoe UI", 9.5F)
        txtResCode.Location = New Point(115, 30)
        txtResCode.Name = "txtResCode"
        txtResCode.ReadOnly = True
        txtResCode.Size = New Size(185, 29)
        txtResCode.TabIndex = 1
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblStatus.Location = New Point(18, 70)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(50, 17)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Status:"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Font = New Font("Segoe UI", 9.5F)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(115, 65)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(185, 29)
        cmbStatus.TabIndex = 3
        ' 
        ' lblRoomSelect
        ' 
        lblRoomSelect.AutoSize = True
        lblRoomSelect.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblRoomSelect.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblRoomSelect.Location = New Point(18, 105)
        lblRoomSelect.Name = "lblRoomSelect"
        lblRoomSelect.Size = New Size(48, 17)
        lblRoomSelect.TabIndex = 4
        lblRoomSelect.Text = "Room:"
        ' 
        ' cmbRoom
        ' 
        cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoom.Font = New Font("Segoe UI", 9.5F)
        cmbRoom.FormattingEnabled = True
        cmbRoom.Location = New Point(115, 100)
        cmbRoom.Name = "cmbRoom"
        cmbRoom.Size = New Size(185, 29)
        cmbRoom.TabIndex = 5
        ' 
        ' lblRoomRate
        ' 
        lblRoomRate.AutoSize = True
        lblRoomRate.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblRoomRate.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblRoomRate.Location = New Point(18, 140)
        lblRoomRate.Name = "lblRoomRate"
        lblRoomRate.Size = New Size(71, 17)
        lblRoomRate.TabIndex = 6
        lblRoomRate.Text = "Base Rate:"
        ' 
        ' txtRoomRate
        ' 
        txtRoomRate.Font = New Font("Segoe UI", 9.5F)
        txtRoomRate.Location = New Point(115, 135)
        txtRoomRate.Name = "txtRoomRate"
        txtRoomRate.ReadOnly = True
        txtRoomRate.Size = New Size(185, 29)
        txtRoomRate.TabIndex = 7
        ' 
        ' lblCheckIn
        ' 
        lblCheckIn.AutoSize = True
        lblCheckIn.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblCheckIn.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblCheckIn.Location = New Point(18, 175)
        lblCheckIn.Name = "lblCheckIn"
        lblCheckIn.Size = New Size(64, 17)
        lblCheckIn.TabIndex = 8
        lblCheckIn.Text = "Check In:"
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.Font = New Font("Segoe UI", 9.5F)
        dtpCheckIn.Format = DateTimePickerFormat.Short
        dtpCheckIn.Location = New Point(115, 170)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(185, 29)
        dtpCheckIn.TabIndex = 9
        ' 
        ' lblCheckOut
        ' 
        lblCheckOut.AutoSize = True
        lblCheckOut.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblCheckOut.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblCheckOut.Location = New Point(18, 210)
        lblCheckOut.Name = "lblCheckOut"
        lblCheckOut.Size = New Size(75, 17)
        lblCheckOut.TabIndex = 10
        lblCheckOut.Text = "Check Out:"
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.Font = New Font("Segoe UI", 9.5F)
        dtpCheckOut.Format = DateTimePickerFormat.Short
        dtpCheckOut.Location = New Point(115, 205)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(185, 29)
        dtpCheckOut.TabIndex = 11
        ' 
        ' lblNights
        ' 
        lblNights.AutoSize = True
        lblNights.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblNights.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblNights.Location = New Point(18, 245)
        lblNights.Name = "lblNights"
        lblNights.Size = New Size(53, 17)
        lblNights.TabIndex = 12
        lblNights.Text = "Nights:"
        ' 
        ' txtNights
        ' 
        txtNights.Font = New Font("Segoe UI", 9.5F)
        txtNights.Location = New Point(115, 240)
        txtNights.Name = "txtNights"
        txtNights.ReadOnly = True
        txtNights.Size = New Size(185, 29)
        txtNights.TabIndex = 13
        ' 
        ' lblAdults
        ' 
        lblAdults.AutoSize = True
        lblAdults.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblAdults.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblAdults.Location = New Point(18, 280)
        lblAdults.Name = "lblAdults"
        lblAdults.Size = New Size(52, 17)
        lblAdults.TabIndex = 14
        lblAdults.Text = "Adults:"
        ' 
        ' numAdults
        ' 
        numAdults.Font = New Font("Segoe UI", 9.5F)
        numAdults.Location = New Point(115, 275)
        numAdults.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numAdults.Name = "numAdults"
        numAdults.Size = New Size(185, 29)
        numAdults.TabIndex = 15
        numAdults.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblChildren
        ' 
        lblChildren.AutoSize = True
        lblChildren.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblChildren.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblChildren.Location = New Point(18, 315)
        lblChildren.Name = "lblChildren"
        lblChildren.Size = New Size(64, 17)
        lblChildren.TabIndex = 16
        lblChildren.Text = "Children:"
        ' 
        ' numChildren
        ' 
        numChildren.Font = New Font("Segoe UI", 9.5F)
        numChildren.Location = New Point(115, 310)
        numChildren.Name = "numChildren"
        numChildren.Size = New Size(185, 29)
        numChildren.TabIndex = 17
        ' 
        ' grpPayment
        ' 
        grpPayment.Controls.Add(lblDiscount)
        grpPayment.Controls.Add(cmbDiscount)
        grpPayment.Controls.Add(lblPayMethod)
        grpPayment.Controls.Add(cmbPaymentMethod)
        grpPayment.Controls.Add(lblRefNo)
        grpPayment.Controls.Add(txtReferenceNo)
        grpPayment.Controls.Add(lblSubtotal)
        grpPayment.Controls.Add(txtSubtotal)
        grpPayment.Controls.Add(lblDiscountAmt)
        grpPayment.Controls.Add(txtDiscountAmount)
        grpPayment.Controls.Add(lblVAT)
        grpPayment.Controls.Add(txtVAT)
        grpPayment.Controls.Add(lblTotal)
        grpPayment.Controls.Add(txtTotal)
        grpPayment.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpPayment.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        grpPayment.Location = New Point(698, 65)
        grpPayment.Name = "grpPayment"
        grpPayment.Size = New Size(325, 360)
        grpPayment.TabIndex = 3
        grpPayment.TabStop = False
        grpPayment.Text = "Payment Information"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblDiscount.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDiscount.Location = New Point(18, 35)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(67, 17)
        lblDiscount.TabIndex = 0
        lblDiscount.Text = "Discount:"
        ' 
        ' cmbDiscount
        ' 
        cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDiscount.Font = New Font("Segoe UI", 9.5F)
        cmbDiscount.FormattingEnabled = True
        cmbDiscount.Location = New Point(125, 30)
        cmbDiscount.Name = "cmbDiscount"
        cmbDiscount.Size = New Size(180, 29)
        cmbDiscount.TabIndex = 1
        ' 
        ' lblPayMethod
        ' 
        lblPayMethod.AutoSize = True
        lblPayMethod.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblPayMethod.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblPayMethod.Location = New Point(18, 70)
        lblPayMethod.Name = "lblPayMethod"
        lblPayMethod.Size = New Size(86, 17)
        lblPayMethod.TabIndex = 2
        lblPayMethod.Text = "Pay Method:"
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMethod.Font = New Font("Segoe UI", 9.5F)
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(125, 65)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(180, 29)
        cmbPaymentMethod.TabIndex = 3
        ' 
        ' lblRefNo
        ' 
        lblRefNo.AutoSize = True
        lblRefNo.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblRefNo.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblRefNo.Location = New Point(18, 105)
        lblRefNo.Name = "lblRefNo"
        lblRefNo.Size = New Size(94, 17)
        lblRefNo.TabIndex = 4
        lblRefNo.Text = "Reference No:"
        ' 
        ' txtReferenceNo
        ' 
        txtReferenceNo.Font = New Font("Segoe UI", 9.5F)
        txtReferenceNo.Location = New Point(125, 100)
        txtReferenceNo.Name = "txtReferenceNo"
        txtReferenceNo.Size = New Size(180, 29)
        txtReferenceNo.TabIndex = 5
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblSubtotal.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSubtotal.Location = New Point(18, 155)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(64, 17)
        lblSubtotal.TabIndex = 6
        lblSubtotal.Text = "Subtotal:"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Font = New Font("Segoe UI", 9.5F)
        txtSubtotal.Location = New Point(125, 150)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(180, 29)
        txtSubtotal.TabIndex = 7
        ' 
        ' lblDiscountAmt
        ' 
        lblDiscountAmt.AutoSize = True
        lblDiscountAmt.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblDiscountAmt.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblDiscountAmt.Location = New Point(18, 190)
        lblDiscountAmt.Name = "lblDiscountAmt"
        lblDiscountAmt.Size = New Size(97, 17)
        lblDiscountAmt.TabIndex = 8
        lblDiscountAmt.Text = "Discount Amt:"
        ' 
        ' txtDiscountAmount
        ' 
        txtDiscountAmount.Font = New Font("Segoe UI", 9.5F)
        txtDiscountAmount.Location = New Point(125, 185)
        txtDiscountAmount.Name = "txtDiscountAmount"
        txtDiscountAmount.ReadOnly = True
        txtDiscountAmount.Size = New Size(180, 29)
        txtDiscountAmount.TabIndex = 9
        ' 
        ' lblVAT
        ' 
        lblVAT.AutoSize = True
        lblVAT.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold)
        lblVAT.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblVAT.Location = New Point(18, 225)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(36, 17)
        lblVAT.TabIndex = 10
        lblVAT.Text = "VAT:"
        ' 
        ' txtVAT
        ' 
        txtVAT.Font = New Font("Segoe UI", 9.5F)
        txtVAT.Location = New Point(125, 220)
        txtVAT.Name = "txtVAT"
        txtVAT.ReadOnly = True
        txtVAT.Size = New Size(180, 29)
        txtVAT.TabIndex = 11
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblTotal.Location = New Point(18, 262)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(52, 21)
        lblTotal.TabIndex = 12
        lblTotal.Text = "Total:"
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        txtTotal.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        txtTotal.Location = New Point(125, 258)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(180, 29)
        txtTotal.TabIndex = 13
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSave.ForeColor = Color.Beige
        btnSave.Location = New Point(680, 442)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 38)
        btnSave.TabIndex = 4
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(245), CByte(235), CByte(220))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnClear.Location = New Point(797, 442)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(105, 38)
        btnClear.TabIndex = 5
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(245), CByte(235), CByte(220))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        btnCancel.Location = New Point(914, 442)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 38)
        btnCancel.TabIndex = 6
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        lblTitle.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Beige
        lblTitle.Location = New Point(401, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 30)
        lblTitle.TabIndex = 7
        lblTitle.Text = "ADD RESERVATION"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        FlowLayoutPanel1.Location = New Point(0, -3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1045, 50)
        FlowLayoutPanel1.TabIndex = 8
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        ClientSize = New Size(1045, 500)
        Controls.Add(lblTitle)
        Controls.Add(btnCancel)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(grpPayment)
        Controls.Add(grpGeneral)
        Controls.Add(grpGuest)
        Controls.Add(FlowLayoutPanel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add Reservation"
        grpGuest.ResumeLayout(False)
        grpGuest.PerformLayout()
        grpGeneral.ResumeLayout(False)
        grpGeneral.PerformLayout()
        CType(numAdults, ComponentModel.ISupportInitialize).EndInit()
        CType(numChildren, ComponentModel.ISupportInitialize).EndInit()
        grpPayment.ResumeLayout(False)
        grpPayment.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpGuest As GroupBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblIdType As Label
    Friend WithEvents txtValidIdType As TextBox
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents txtValidIdNumber As TextBox

    Friend WithEvents grpGeneral As GroupBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtResCode As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblRoomSelect As Label
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents lblRoomRate As Label
    Friend WithEvents txtRoomRate As TextBox
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents lblNights As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lblAdults As Label
    Friend WithEvents numAdults As NumericUpDown
    Friend WithEvents lblChildren As Label
    Friend WithEvents numChildren As NumericUpDown

    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents cmbDiscount As ComboBox
    Friend WithEvents lblPayMethod As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents lblRefNo As Label
    Friend WithEvents txtReferenceNo As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents lblDiscountAmt As Label
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents lblVAT As Label
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox

    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbGuest As ComboBox
End Class
