Imports MySql.Data.MySqlClient

Public Class Reservation

    Private reservationID As Integer = 0
    Private selectedGuestID As Integer = 0

    Public Class GuestComboItem
        Public Property GuestID As Integer
        Public Property FirstName As String
        Public Property MiddleName As String
        Public Property Surname As String
        Public Property Contact As String
        Public Property Email As String
        Public Property ValidIDType As String
        Public Property ValidIDNumber As String

        Public Sub New(id As Integer, first As String, middle As String,
                       surname As String, contact As String, email As String,
                       idType As String, idNumber As String)

            GuestID = id
            FirstName = first
            MiddleName = middle
            Me.Surname = surname
            Me.Contact = contact
            Me.Email = email
            ValidIDType = idType
            ValidIDNumber = idNumber
        End Sub

        Public Overrides Function ToString() As String
            Return Surname & ", " & FirstName &
                If(MiddleName = "", "", " " & MiddleName)
        End Function
    End Class

    Public Class RoomComboItem
        Public Property RoomID As Integer
        Public Property RoomNumber As String
        Public Property RoomType As String
        Public Property BaseRate As Decimal
        Public Property StandardCapacity As Integer
        Public Property MaxCapacity As Integer
        Public Property Amenities As String

        Public Sub New(id As Integer, number As String, typeName As String,
                       rate As Decimal, stdCap As Integer, maxCap As Integer, amens As String)
            RoomID = id
            RoomNumber = number
            RoomType = typeName
            BaseRate = rate
            StandardCapacity = stdCap
            MaxCapacity = maxCap
            Amenities = amens
        End Sub

        Public Overrides Function ToString() As String
            Return RoomNumber & " - " & RoomType &
                " (₱" & BaseRate.ToString("N2") & ")"
        End Function
    End Class

    Public Class DiscountComboItem
        Public Property DiscountID As Integer
        Public Property DiscountName As String
        Public Property DiscountRate As Decimal
        Public Property VATExempt As Boolean

        Public Sub New(id As Integer, name As String, rate As Decimal,
                       vatExempt As Boolean)
            DiscountID = id
            DiscountName = name
            DiscountRate = rate
            Me.VATExempt = vatExempt
        End Sub

        Public Overrides Function ToString() As String
            Return DiscountName & " (" & DiscountRate.ToString("0") & "%)"
        End Function
    End Class

    Public Sub New()
        InitializeComponent()
        reservationID = 0
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        reservationID = id
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResCode.ReadOnly = True
        txtRoomRate.ReadOnly = True
        txtNights.ReadOnly = True
        txtSubtotal.ReadOnly = True
        txtDiscountAmount.ReadOnly = True
        txtVAT.ReadOnly = True
        txtTotal.ReadOnly = True

        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList

        LoadStatuses()
        LoadPaymentMethods()
        LoadGuests()
        LoadRooms()
        LoadDiscounts()

        dtpCheckIn.Value = DateTime.Today
        dtpCheckOut.Value = DateTime.Today.AddDays(1)

        numAdults.Minimum = 1
        numAdults.Value = 1
        numChildren.Minimum = 0
        numChildren.Value = 0

        CalculateNights()

        If reservationID <> 0 Then
            Me.Text = "EDIT RESERVATION"
            lblTitle.Text = "EDIT RESERVATION"
            LoadReservationData()
        Else
            Me.Text = "ADD RESERVATION"
            lblTitle.Text = "ADD RESERVATION"
            txtResCode.Text = GenerateReservationCode()
        End If
    End Sub

    Private Function GenerateReservationCode() As String
        Return DateTime.Now.ToString("yyyyMMdd") & "-" &
            Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper()
    End Function

    Private Sub LoadStatuses()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Check-In")
        cmbStatus.Items.Add("Check-Out")
        cmbStatus.Items.Add("No-Show")
        cmbStatus.Items.Add("Canceled")
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadPaymentMethods()
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("GCash")
        cmbPaymentMethod.Items.Add("Maya")
        cmbPaymentMethod.Items.Add("PayPal")
        cmbPaymentMethod.Items.Add("Card")
        cmbPaymentMethod.Items.Add("Bank Transfer")
        cmbPaymentMethod.SelectedIndex = 0
    End Sub

    Private Sub LoadGuests()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT guest_id, firstname, middlename, surname, " &
                    "contact, email, valid_id_type, valid_id_number " &
                    "FROM guest ORDER BY surname, firstname"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbGuest.Items.Clear()

                        While reader.Read()
                            Dim guest As New GuestComboItem(
                                Convert.ToInt32(reader("guest_id")),
                                reader("firstname").ToString(),
                                If(IsDBNull(reader("middlename")), "", reader("middlename").ToString()),
                                reader("surname").ToString(),
                                If(IsDBNull(reader("contact")), "", reader("contact").ToString()),
                                If(IsDBNull(reader("email")), "", reader("email").ToString()),
                                If(IsDBNull(reader("valid_id_type")), "", reader("valid_id_type").ToString()),
                                If(IsDBNull(reader("valid_id_number")), "", reader("valid_id_number").ToString())
                            )

                            cmbGuest.Items.Add(guest)
                        End While
                    End Using
                End Using
            End Using

            cmbGuest.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading guests: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbGuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGuest.SelectedIndexChanged
        If cmbGuest.SelectedItem Is Nothing Then
            selectedGuestID = 0
            Exit Sub
        End If

        Dim guest As GuestComboItem = CType(cmbGuest.SelectedItem, GuestComboItem)

        selectedGuestID = guest.GuestID
        txtFirstName.Text = guest.FirstName
        txtMiddleName.Text = guest.MiddleName
        txtSurname.Text = guest.Surname
        txtContact.Text = guest.Contact
        txtEmail.Text = guest.Email
        txtValidIdType.Text = guest.ValidIDType
        txtValidIdNumber.Text = guest.ValidIDNumber
    End Sub

    Private Sub LoadRooms()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' FIX: Added rt.amenities to match the new schema
                Dim query As String =
                    "SELECT r.room_id, r.room_number, rt.type_name, " &
                    "rt.base_rate, rt.standard_capacity, rt.max_capacity, rt.amenities " &
                    "FROM room r " &
                    "INNER JOIN room_type rt ON r.room_type_id = rt.room_type_id " &
                    "WHERE r.room_status = 'Available' " &
                    "ORDER BY r.room_number"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbRoom.Items.Clear()

                        While reader.Read()
                            cmbRoom.Items.Add(
                                New RoomComboItem(
                                    Convert.ToInt32(reader("room_id")),
                                    reader("room_number").ToString(),
                                    reader("type_name").ToString(),
                                    Convert.ToDecimal(reader("base_rate")),
                                    Convert.ToInt32(reader("standard_capacity")),
                                    Convert.ToInt32(reader("max_capacity")),
                                    If(IsDBNull(reader("amenities")), "", reader("amenities").ToString())
                                )
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading rooms: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDiscounts()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' Filter discounts by date
                Dim query As String =
                    "SELECT discount_id, discount_name, discount_rate, vat_exempt " &
                    "FROM discount " &
                    "WHERE (start_date IS NULL AND end_date IS NULL) " &
                    "OR (CURDATE() BETWEEN start_date AND end_date) " &
                    "ORDER BY discount_id"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbDiscount.Items.Clear()

                        While reader.Read()
                            cmbDiscount.Items.Add(
                                New DiscountComboItem(
                                    Convert.ToInt32(reader("discount_id")),
                                    reader("discount_name").ToString(),
                                    Convert.ToDecimal(reader("discount_rate")),
                                    Convert.ToBoolean(reader("vat_exempt"))
                                )
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading discounts: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged
        If cmbRoom.SelectedItem Is Nothing Then Exit Sub

        Dim selectedRoom As RoomComboItem = CType(cmbRoom.SelectedItem, RoomComboItem)
        txtRoomRate.Text = selectedRoom.BaseRate.ToString("N2")
        CalculateTotal()
    End Sub

    Private Sub cmbDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiscount.SelectedIndexChanged
        CalculateTotal()
    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        CalculateNights()
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        CalculateNights()
    End Sub

    Private Sub CalculateNights()
        Dim nights As Integer =
            CInt((dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).TotalDays)

        If nights < 1 Then nights = 1

        txtNights.Text = nights.ToString()
        CalculateTotal()
    End Sub

    Private Sub numAdults_ValueChanged(sender As Object, e As EventArgs) Handles numAdults.ValueChanged
        CalculateTotal()
    End Sub

    Private Sub numChildren_ValueChanged(sender As Object, e As EventArgs) Handles numChildren.ValueChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        If cmbRoom.SelectedItem Is Nothing Then Exit Sub

        Dim selectedRoom As RoomComboItem = CType(cmbRoom.SelectedItem, RoomComboItem)
        Dim nights As Integer = 1

        If IsNumeric(txtNights.Text) Then
            nights = Convert.ToInt32(txtNights.Text)
        End If

        Dim adults As Integer = Convert.ToInt32(numAdults.Value)
        
        If adults > selectedRoom.MaxCapacity Then
            txtTotal.Text = "Exceeds Max Capacity!"
            txtSubtotal.Text = "0.00"
            txtVAT.Text = "0.00"
            txtDiscountAmount.Text = "0.00"
            Exit Sub
        End If

        Dim roomCharge As Decimal = selectedRoom.BaseRate * nights
        Dim extraAdults As Integer = Math.Max(0, adults - selectedRoom.StandardCapacity)
        
        Dim extraPersonFee As Decimal = extraAdults * 800D * nights

        Dim subtotal As Decimal = roomCharge + extraPersonFee
        Dim discountAmount As Decimal = 0D
        Dim vatAmount As Decimal = 0D

        If cmbDiscount.SelectedItem IsNot Nothing Then
            Dim selectedDiscount As DiscountComboItem =
                CType(cmbDiscount.SelectedItem, DiscountComboItem)

            discountAmount = subtotal * (selectedDiscount.DiscountRate / 100D)

            Dim netAmount As Decimal = subtotal - discountAmount

            If Not selectedDiscount.VATExempt Then
                vatAmount = netAmount * 0.12D
            End If
        Else
            vatAmount = subtotal * 0.12D
        End If

        Dim net As Decimal = subtotal - discountAmount
        Dim total As Decimal = net + vatAmount

        txtSubtotal.Text = subtotal.ToString("N2")
        txtDiscountAmount.Text = discountAmount.ToString("N2")
        txtVAT.Text = vatAmount.ToString("N2")
        txtTotal.Text = total.ToString("N2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearReservationForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ClearReservationForm()
        selectedGuestID = 0
        cmbGuest.SelectedIndex = -1

        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtSurname.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        txtValidIdType.Clear()
        txtValidIdNumber.Clear()

        cmbStatus.SelectedIndex = 0
        cmbRoom.SelectedIndex = -1
        cmbDiscount.SelectedIndex = -1
        cmbPaymentMethod.SelectedIndex = 0
        txtReferenceNo.Clear()

        dtpCheckIn.Value = DateTime.Today
        dtpCheckOut.Value = DateTime.Today.AddDays(1)

        numAdults.Value = 1
        numChildren.Value = 0

        txtRoomRate.Clear()
        txtNights.Clear()
        txtSubtotal.Clear()
        txtDiscountAmount.Clear()
        txtVAT.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtSurname.Text) Then

            MessageBox.Show("Please enter the guest's First Name and Surname.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbRoom.SelectedIndex = -1 Then
            MessageBox.Show("Please select a room.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date Then
            MessageBox.Show("Check-out date must be after check-in date.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRoomItem As RoomComboItem = CType(cmbRoom.SelectedItem, RoomComboItem)
        If numAdults.Value > selectedRoomItem.MaxCapacity Then
            MessageBox.Show("The number of adults exceeds the maximum capacity for this room type.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim guestId As Integer = 0

                If selectedGuestID > 0 Then
                    guestId = selectedGuestID
                Else
                    Dim insertGuestQuery As String =
                        "INSERT INTO guest " &
                        "(firstname, middlename, surname, contact, email, valid_id_type, valid_id_number) " &
                        "VALUES (@fname, @mname, @sname, @contact, @email, @idType, @idNum)"

                    Using insertGuestCmd As New MySqlCommand(insertGuestQuery, conn)
                        insertGuestCmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim())
                        insertGuestCmd.Parameters.AddWithValue("@mname", txtMiddleName.Text.Trim())
                        insertGuestCmd.Parameters.AddWithValue("@sname", txtSurname.Text.Trim())
                        insertGuestCmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
                        insertGuestCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                        insertGuestCmd.Parameters.AddWithValue("@idType", txtValidIdType.Text.Trim())
                        insertGuestCmd.Parameters.AddWithValue("@idNum", txtValidIdNumber.Text.Trim())

                        insertGuestCmd.ExecuteNonQuery()
                        guestId = CInt(insertGuestCmd.LastInsertedId)
                    End Using
                End If

                Dim selectedRoom As RoomComboItem = CType(cmbRoom.SelectedItem, RoomComboItem)
                Dim roomID As Integer = selectedRoom.RoomID
                Dim baseRate As Decimal = selectedRoom.BaseRate

                Dim discountID As Object = DBNull.Value

                If cmbDiscount.SelectedItem IsNot Nothing Then
                    Dim selectedDiscount As DiscountComboItem =
                        CType(cmbDiscount.SelectedItem, DiscountComboItem)

                    discountID = selectedDiscount.DiscountID
                End If

                Dim nights As Integer = Convert.ToInt32(txtNights.Text)
                Dim adults As Integer = Convert.ToInt32(numAdults.Value)
                Dim children As Integer = Convert.ToInt32(numChildren.Value)
                Dim subtotal As Decimal = Convert.ToDecimal(txtSubtotal.Text)
                Dim discountAmount As Decimal = Convert.ToDecimal(txtDiscountAmount.Text)
                Dim netAmount As Decimal = subtotal - discountAmount
                Dim vatAmount As Decimal = Convert.ToDecimal(txtVAT.Text)
                Dim totalAmount As Decimal = Convert.ToDecimal(txtTotal.Text)
                
                Dim extraAdults As Integer = Math.Max(0, adults - selectedRoom.StandardCapacity)
                Dim extraPersonFee As Decimal = extraAdults * 800D * nights

                If reservationID = 0 Then
                    Dim resCode As String = txtResCode.Text.Trim()

                    ' FIX: Added extra_adult_fee to the INSERT query
                    Dim query As String =
                        "INSERT INTO reservation " &
                        "(guest_id, room_id, discount_id, created_by, res_code, res_status, " &
                        "check_in, check_out, num_nights, adults, children, base_rate, " &
                        "extra_adult_fee, extra_person, subtotal, discount_amount, net_amount, vat_amount, total_amount) " &
                        "VALUES (@guestID, @roomID, @discountID, @createdBy, @resCode, @status, " &
                        "@checkIn, @checkOut, @nights, @adults, @children, @baseRate, " &
                        "@extraAdultFee, @extraPerson, @subtotal, @discountAmount, @netAmount, @vatAmount, @totalAmount)"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@guestID", guestId)
                        cmd.Parameters.AddWithValue("@roomID", roomID)
                        cmd.Parameters.AddWithValue("@discountID", discountID)
                        cmd.Parameters.AddWithValue("@createdBy", CurrentUser.AccountID)
                        cmd.Parameters.AddWithValue("@resCode", resCode)
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
                        cmd.Parameters.AddWithValue("@checkIn", dtpCheckIn.Value.Date)
                        cmd.Parameters.AddWithValue("@checkOut", dtpCheckOut.Value.Date)
                        cmd.Parameters.AddWithValue("@nights", nights)
                        cmd.Parameters.AddWithValue("@adults", adults)
                        cmd.Parameters.AddWithValue("@children", children)
                        cmd.Parameters.AddWithValue("@baseRate", baseRate)
                        cmd.Parameters.AddWithValue("@extraAdultFee", 800D) ' FIX
                        cmd.Parameters.AddWithValue("@extraPerson", extraPersonFee)
                        cmd.Parameters.AddWithValue("@subtotal", subtotal)
                        cmd.Parameters.AddWithValue("@discountAmount", discountAmount)
                        cmd.Parameters.AddWithValue("@netAmount", netAmount)
                        cmd.Parameters.AddWithValue("@vatAmount", vatAmount)
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount)

                        cmd.ExecuteNonQuery()
                    End Using

                    If dtpCheckIn.Value.Date = DateTime.Today Then
                        Dim updateRoomQuery As String =
                            "UPDATE room SET room_status = 'Occupied' WHERE room_id = @roomID"

                        Using updateCmd As New MySqlCommand(updateRoomQuery, conn)
                            updateCmd.Parameters.AddWithValue("@roomID", roomID)
                            updateCmd.ExecuteNonQuery()
                        End Using
                    End If

                    MessageBox.Show("Reservation saved successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Dim oldRoomID As Integer = 0
                    Using getOldRoomCmd As New MySqlCommand("SELECT room_id FROM reservation WHERE res_id = @resID", conn)
                        getOldRoomCmd.Parameters.AddWithValue("@resID", reservationID)
                        oldRoomID = Convert.ToInt32(getOldRoomCmd.ExecuteScalar())
                    End Using

                    ' FIX: Added extra_adult_fee to the UPDATE query
                    Dim query As String =
                        "UPDATE reservation SET " &
                        "guest_id = @guestID, room_id = @roomID, discount_id = @discountID, " &
                        "res_status = @status, check_in = @checkIn, check_out = @checkOut, " &
                        "num_nights = @nights, adults = @adults, children = @children, " &
                        "base_rate = @baseRate, extra_adult_fee = @extraAdultFee, extra_person = @extraPerson, subtotal = @subtotal, discount_amount = @discountAmount, " &
                        "net_amount = @netAmount, vat_amount = @vatAmount, total_amount = @totalAmount " &
                        "WHERE res_id = @resID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@guestID", guestId)
                        cmd.Parameters.AddWithValue("@roomID", roomID)
                        cmd.Parameters.AddWithValue("@discountID", discountID)
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
                        cmd.Parameters.AddWithValue("@checkIn", dtpCheckIn.Value.Date)
                        cmd.Parameters.AddWithValue("@checkOut", dtpCheckOut.Value.Date)
                        cmd.Parameters.AddWithValue("@nights", nights)
                        cmd.Parameters.AddWithValue("@adults", adults)
                        cmd.Parameters.AddWithValue("@children", children)
                        cmd.Parameters.AddWithValue("@baseRate", baseRate)
                        cmd.Parameters.AddWithValue("@extraAdultFee", 800D) ' FIX
                        cmd.Parameters.AddWithValue("@extraPerson", extraPersonFee)
                        cmd.Parameters.AddWithValue("@subtotal", subtotal)
                        cmd.Parameters.AddWithValue("@discountAmount", discountAmount)
                        cmd.Parameters.AddWithValue("@netAmount", netAmount)
                        cmd.Parameters.AddWithValue("@vatAmount", vatAmount)
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount)
                        cmd.Parameters.AddWithValue("@resID", reservationID)

                        cmd.ExecuteNonQuery()
                    End Using
                    
                    If dtpCheckIn.Value.Date = DateTime.Today Then
                        If oldRoomID <> roomID Then
                            Dim freeOldRoom As String = "UPDATE room SET room_status = 'Available' WHERE room_id = @oldRoomID"
                            Using freeCmd As New MySqlCommand(freeOldRoom, conn)
                                freeCmd.Parameters.AddWithValue("@oldRoomID", oldRoomID)
                                freeCmd.ExecuteNonQuery()
                            End Using

                            Dim occupyNewRoom As String = "UPDATE room SET room_status = 'Occupied' WHERE room_id = @newRoomID"
                            Using occCmd As New MySqlCommand(occupyNewRoom, conn)
                                occCmd.Parameters.AddWithValue("@newRoomID", roomID)
                                occCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End If

                    MessageBox.Show("Reservation updated successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving reservation: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadReservationData()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT r.*, g.firstname, g.middlename, g.surname, " &
                    "g.contact, g.email, g.valid_id_type, g.valid_id_number " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "WHERE r.res_id = @resID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@resID", reservationID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtResCode.Text = reader("res_code").ToString()

                            Dim savedStatus As String = reader("res_status").ToString()
                            If cmbStatus.Items.Contains(savedStatus) Then
                                cmbStatus.SelectedItem = savedStatus
                            End If

                            Dim savedGuestID As Integer = Convert.ToInt32(reader("guest_id"))
                            cmbGuest.SelectedIndex = -1

                            For i As Integer = 0 To cmbGuest.Items.Count - 1
                                Dim guest As GuestComboItem =
                                    CType(cmbGuest.Items(i), GuestComboItem)

                                If guest.GuestID = savedGuestID Then
                                    cmbGuest.SelectedIndex = i
                                    Exit For
                                End If
                            Next

                            If cmbGuest.SelectedIndex = -1 Then
                                selectedGuestID = savedGuestID

                                txtFirstName.Text = reader("firstname").ToString()
                                txtMiddleName.Text =
                                    If(IsDBNull(reader("middlename")), "", reader("middlename").ToString())
                                txtSurname.Text = reader("surname").ToString()
                                txtContact.Text =
                                    If(IsDBNull(reader("contact")), "", reader("contact").ToString())
                                txtEmail.Text =
                                    If(IsDBNull(reader("email")), "", reader("email").ToString())
                                txtValidIdType.Text =
                                    If(IsDBNull(reader("valid_id_type")), "", reader("valid_id_type").ToString())
                                txtValidIdNumber.Text =
                                    If(IsDBNull(reader("valid_id_number")), "", reader("valid_id_number").ToString())
                            End If

                            Dim roomID As Integer = Convert.ToInt32(reader("room_id"))

                            For i As Integer = 0 To cmbRoom.Items.Count - 1
                                Dim room As RoomComboItem = CType(cmbRoom.Items(i), RoomComboItem)

                                If room.RoomID = roomID Then
                                    cmbRoom.SelectedIndex = i
                                    Exit For
                                End If
                            Next

                            dtpCheckIn.Value = Convert.ToDateTime(reader("check_in"))
                            dtpCheckOut.Value = Convert.ToDateTime(reader("check_out"))

                            numAdults.Value = Math.Max(numAdults.Minimum,
                                Math.Min(numAdults.Maximum, Convert.ToDecimal(reader("adults"))))

                            numChildren.Value = Math.Max(numChildren.Minimum,
                                Math.Min(numChildren.Maximum, Convert.ToDecimal(reader("children"))))

                            If Not IsDBNull(reader("discount_id")) Then
                                Dim discountID As Integer = Convert.ToInt32(reader("discount_id"))

                                For i As Integer = 0 To cmbDiscount.Items.Count - 1
                                    Dim discount As DiscountComboItem =
                                        CType(cmbDiscount.Items(i), DiscountComboItem)

                                    If discount.DiscountID = discountID Then
                                        cmbDiscount.SelectedIndex = i
                                        Exit For
                                    End If
                                Next
                            Else
                                cmbDiscount.SelectedIndex = -1
                            End If
                        End If
                    End Using
                End Using
            End Using

            CalculateNights()
            CalculateTotal()

        Catch ex As Exception
            MessageBox.Show("Error loading reservation: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtMiddleName_TextChanged(sender As Object, e As EventArgs) Handles txtMiddleName.TextChanged
    End Sub

    Private Sub grpGuest_Enter(sender As Object, e As EventArgs) Handles grpGuest.Enter
    End Sub

End Class
