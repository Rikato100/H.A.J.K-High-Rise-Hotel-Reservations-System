Imports MySql.Data.MySqlClient

Public Class Reservation

    Private reservationID As Integer = 0
    Public Sub New()
        InitializeComponent()
        reservationID = 0
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        reservationID = id
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRoomRate.ReadOnly = True
        txtNights.ReadOnly = True
        txtSubtotal.ReadOnly = True
        txtDiscountAmount.ReadOnly = True
        txtVAT.ReadOnly = True
        txtTotal.ReadOnly = True

        ' Guest settings
        cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList

        ' Room settings
        cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList

        ' Discount settings
        cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList

        ' Load database data
        LoadGuests()
        LoadRooms()
        LoadDiscounts()

        ' Default values
        dtpCheckIn.Value = DateTime.Today
        dtpCheckOut.Value = DateTime.Today.AddDays(1)

        numAdults.Minimum = 1
        numAdults.Value = 1

        numChildren.Minimum = 0
        numChildren.Value = 0

        CalculateNights()

        If reservationID <> 0 Then
            Me.Text = "Edit Reservation"
            lblTitle.Text = "Edit Reservation"
            LoadReservationData()
        Else
            Me.Text = "Add Reservation"
            lblTitle.Text = "Add Reservation"
        End If

    End Sub

    Private Sub LoadGuests()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT guest_id, " &
                "CONCAT(surname, ', ', firstname, " &
                "IF(middlename IS NULL OR middlename = '', '', CONCAT(' ', middlename))) AS guest_name " &
                "FROM guest " &
                "ORDER BY surname, firstname"

                Using adapter As New MySqlDataAdapter(query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    cmbGuest.DataSource = Nothing
                    cmbGuest.DataSource = table
                    cmbGuest.DisplayMember = "guest_name"
                    cmbGuest.ValueMember = "guest_id"

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
            "Error loading guests: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub


    Private Sub LoadRooms()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT r.room_id, r.room_number, " &
                    "rt.type_name, rt.base_rate " &
                    "FROM room r " &
                    "INNER JOIN room_type rt " &
                    "ON r.room_type_id = rt.room_type_id " &
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
                                    Convert.ToDecimal(reader("base_rate"))
                                )
                            )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading rooms: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub LoadDiscounts()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT discount_id, discount_name, " &
                    "discount_rate, vat_exempt " &
                    "FROM discount " &
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

            MessageBox.Show(
                "Error loading discounts: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged
        If cmbRoom.SelectedItem Is Nothing Then Exit Sub

        Dim selectedRoom As RoomComboItem =
            CType(cmbRoom.SelectedItem, RoomComboItem)

        txtRoomRate.Text =
            selectedRoom.BaseRate.ToString("N2")

        CalculateTotal()
    End Sub

    Private Sub cmbDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiscount.SelectedIndexChanged
        CalculateTotal()
    End Sub

    Private Sub txtNights_TextChanged(sender As Object, e As EventArgs) Handles txtNights.TextChanged

    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        CalculateNights()
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        CalculateNights()
    End Sub

    Private Sub CalculateNights()

        Dim nights As Integer =
            CInt((dtpCheckOut.Value.Date -
                  dtpCheckIn.Value.Date).TotalDays)

        If nights < 1 Then
            nights = 1
        End If

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

        Dim selectedRoom As RoomComboItem =
            CType(cmbRoom.SelectedItem, RoomComboItem)

        Dim nights As Integer = 1

        If IsNumeric(txtNights.Text) Then
            nights = Convert.ToInt32(txtNights.Text)
        End If

        Dim adults As Integer =
            Convert.ToInt32(numAdults.Value)

        Dim roomCharge As Decimal =
            selectedRoom.BaseRate * nights

        ' First 2 adults are included.
        Dim extraAdults As Integer =
            Math.Max(0, adults - 2)

        Dim extraPersonFee As Decimal =
            extraAdults * 800D * nights

        Dim subtotal As Decimal =
            roomCharge + extraPersonFee

        Dim discountAmount As Decimal = 0D
        Dim vatAmount As Decimal = 0D

        If cmbDiscount.SelectedItem IsNot Nothing Then

            Dim selectedDiscount As DiscountComboItem =
                CType(cmbDiscount.SelectedItem, DiscountComboItem)

            discountAmount =
                subtotal * (selectedDiscount.DiscountRate / 100D)

            Dim netAmount As Decimal =
                subtotal - discountAmount

            If selectedDiscount.VATExempt = False Then
                vatAmount = netAmount * 0.12D
            End If

        End If

        Dim net As Decimal =
            subtotal - discountAmount

        If cmbDiscount.SelectedItem Is Nothing Then
            vatAmount = net * 0.12D
        End If

        Dim total As Decimal =
            net + vatAmount

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



    Public Class RoomComboItem

        Public Property RoomID As Integer
        Public Property RoomNumber As String
        Public Property RoomType As String
        Public Property BaseRate As Decimal

        Public Sub New(
            id As Integer,
            number As String,
            typeName As String,
            rate As Decimal
        )

            RoomID = id
            RoomNumber = number
            RoomType = typeName
            BaseRate = rate

        End Sub

        Public Overrides Function ToString() As String

            Return RoomNumber & " - " &
                   RoomType & " (₱" &
                   BaseRate.ToString("N2") & ")"

        End Function

    End Class

    Public Class DiscountComboItem

        Public Property DiscountID As Integer
        Public Property DiscountName As String
        Public Property DiscountRate As Decimal
        Public Property VATExempt As Boolean

        Public Sub New(
            id As Integer,
            name As String,
            rate As Decimal,
            vatExempt As Boolean
        )

            DiscountID = id
            DiscountName = name
            DiscountRate = rate
            vatExempt = vatExempt

        End Sub

        Public Overrides Function ToString() As String

            Return DiscountName & " (" &
                   DiscountRate.ToString("0") & "%)"

        End Function

    End Class

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbGuest.SelectedIndex = -1 Then
            MessageBox.Show("Please select a guest.")
            Exit Sub
        End If

        ' Check room
        If cmbRoom.SelectedIndex = -1 Then
            MessageBox.Show("Please select a room.")
            Exit Sub
        End If

        ' Check discount
        If cmbDiscount.SelectedIndex = -1 Then
            MessageBox.Show("Please select a discount.")
            Exit Sub
        End If

        ' Check dates
        If dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date Then
            MessageBox.Show("Check-out date must be after check-in date.")
            Exit Sub
        End If

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                ' Selected guest
                Dim guestID As Integer =
                Convert.ToInt32(cmbGuest.SelectedValue)

                ' Selected room
                Dim selectedRoom As RoomComboItem =
                CType(cmbRoom.SelectedItem, RoomComboItem)

                Dim roomID As Integer = selectedRoom.RoomID
                Dim baseRate As Decimal = selectedRoom.BaseRate

                ' Selected discount
                Dim selectedDiscount As DiscountComboItem =
                CType(cmbDiscount.SelectedItem, DiscountComboItem)

                Dim discountID As Integer =
                selectedDiscount.DiscountID

                ' Values
                Dim nights As Integer =
                Convert.ToInt32(txtNights.Text)

                Dim adults As Integer =
                Convert.ToInt32(numAdults.Value)

                Dim children As Integer =
                Convert.ToInt32(numChildren.Value)

                Dim extraAdults As Integer =
                Math.Max(0, adults - 2)

                Dim extraPerson As Decimal =
                extraAdults * 800D * nights

                Dim subtotal As Decimal =
                Convert.ToDecimal(txtSubtotal.Text)

                Dim discountAmount As Decimal =
                Convert.ToDecimal(txtDiscountAmount.Text)

                Dim netAmount As Decimal =
                subtotal - discountAmount

                Dim vatAmount As Decimal =
                Convert.ToDecimal(txtVAT.Text)

                Dim totalAmount As Decimal =
                Convert.ToDecimal(txtTotal.Text)


                ' ==========================================
                ' ADD NEW RESERVATION
                ' ==========================================

                If reservationID = 0 Then

                    Dim resCode As String =
                    DateTime.Now.ToString("yyyyMMdd") & "-" &
                    Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper()

                    Dim query As String =
                    "INSERT INTO reservation " &
                    "(guest_id, room_id, discount_id, created_by, " &
                    "res_code, res_status, check_in, check_out, num_nights, " &
                    "adults, children, base_rate, extra_adult_fee, extra_person, " &
                    "subtotal, discount_amount, net_amount, vat_amount, total_amount) " &
                    "VALUES " &
                    "(@guestID, @roomID, @discountID, @createdBy, " &
                    "@resCode, 'Pending', @checkIn, @checkOut, @nights, " &
                    "@adults, @children, @baseRate, @extraAdultFee, @extraPerson, " &
                    "@subtotal, @discountAmount, @netAmount, @vatAmount, @totalAmount)"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@guestID", guestID)
                        cmd.Parameters.AddWithValue("@roomID", roomID)
                        cmd.Parameters.AddWithValue("@discountID", discountID)

                        ' Temporary Admin account
                        cmd.Parameters.AddWithValue("@createdBy", 1)

                        cmd.Parameters.AddWithValue("@resCode", resCode)
                        cmd.Parameters.AddWithValue("@checkIn", dtpCheckIn.Value.Date)
                        cmd.Parameters.AddWithValue("@checkOut", dtpCheckOut.Value.Date)
                        cmd.Parameters.AddWithValue("@nights", nights)
                        cmd.Parameters.AddWithValue("@adults", adults)
                        cmd.Parameters.AddWithValue("@children", children)
                        cmd.Parameters.AddWithValue("@baseRate", baseRate)
                        cmd.Parameters.AddWithValue("@extraAdultFee", 800D)
                        cmd.Parameters.AddWithValue("@extraPerson", extraPerson)
                        cmd.Parameters.AddWithValue("@subtotal", subtotal)
                        cmd.Parameters.AddWithValue("@discountAmount", discountAmount)
                        cmd.Parameters.AddWithValue("@netAmount", netAmount)
                        cmd.Parameters.AddWithValue("@vatAmount", vatAmount)
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount)

                        cmd.ExecuteNonQuery()

                    End Using

                    MessageBox.Show(
                    "Reservation saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


                    ' ==========================================
                    ' UPDATE EXISTING RESERVATION
                    ' ==========================================

                Else

                    Dim query As String =
                    "UPDATE reservation SET " &
                    "guest_id = @guestID, " &
                    "room_id = @roomID, " &
                    "discount_id = @discountID, " &
                    "check_in = @checkIn, " &
                    "check_out = @checkOut, " &
                    "num_nights = @nights, " &
                    "adults = @adults, " &
                    "children = @children, " &
                    "base_rate = @baseRate, " &
                    "extra_adult_fee = @extraAdultFee, " &
                    "extra_person = @extraPerson, " &
                    "subtotal = @subtotal, " &
                    "discount_amount = @discountAmount, " &
                    "net_amount = @netAmount, " &
                    "vat_amount = @vatAmount, " &
                    "total_amount = @totalAmount " &
                    "WHERE res_id = @resID"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@guestID", guestID)
                        cmd.Parameters.AddWithValue("@roomID", roomID)
                        cmd.Parameters.AddWithValue("@discountID", discountID)
                        cmd.Parameters.AddWithValue("@checkIn", dtpCheckIn.Value.Date)
                        cmd.Parameters.AddWithValue("@checkOut", dtpCheckOut.Value.Date)
                        cmd.Parameters.AddWithValue("@nights", nights)
                        cmd.Parameters.AddWithValue("@adults", adults)
                        cmd.Parameters.AddWithValue("@children", children)
                        cmd.Parameters.AddWithValue("@baseRate", baseRate)
                        cmd.Parameters.AddWithValue("@extraAdultFee", 800D)
                        cmd.Parameters.AddWithValue("@extraPerson", extraPerson)
                        cmd.Parameters.AddWithValue("@subtotal", subtotal)
                        cmd.Parameters.AddWithValue("@discountAmount", discountAmount)
                        cmd.Parameters.AddWithValue("@netAmount", netAmount)
                        cmd.Parameters.AddWithValue("@vatAmount", vatAmount)
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount)
                        cmd.Parameters.AddWithValue("@resID", reservationID)

                        cmd.ExecuteNonQuery()

                    End Using

                    MessageBox.Show(
                    "Reservation updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                End If

            End Using

            ' Tell ReservationListForm that something changed
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As MySqlException

            MessageBox.Show(
            "Database error: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        Catch ex As Exception

            MessageBox.Show(
            "Error saving reservation: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try
    End Sub

    Private Sub ClearReservationForm()

        cmbGuest.SelectedIndex = -1
        cmbRoom.SelectedIndex = -1
        cmbDiscount.SelectedIndex = -1

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

    Private Sub LoadReservationData()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT guest_id, room_id, discount_id, " &
                    "check_in, check_out, adults, children " &
                    "FROM reservation " &
                    "WHERE res_id = @resID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@resID", reservationID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            cmbGuest.SelectedValue =
                                Convert.ToInt32(reader("guest_id"))

                            Dim roomID As Integer =
                                Convert.ToInt32(reader("room_id"))

                            For i As Integer = 0 To cmbRoom.Items.Count - 1

                                Dim room As RoomComboItem =
                                    CType(cmbRoom.Items(i), RoomComboItem)

                                If room.RoomID = roomID Then
                                    cmbRoom.SelectedIndex = i
                                    Exit For
                                End If

                            Next

                            dtpCheckIn.Value =
                                Convert.ToDateTime(reader("check_in"))

                            dtpCheckOut.Value =
                                Convert.ToDateTime(reader("check_out"))

                            numAdults.Value =
                                Convert.ToDecimal(reader("adults"))

                            numChildren.Value =
                                Convert.ToDecimal(reader("children"))

                            If Not IsDBNull(reader("discount_id")) Then

                                Dim discountID As Integer =
                                    Convert.ToInt32(reader("discount_id"))

                                For i As Integer = 0 To cmbDiscount.Items.Count - 1

                                    Dim discount As DiscountComboItem =
                                        CType(cmbDiscount.Items(i),
                                              DiscountComboItem)

                                    If discount.DiscountID = discountID Then
                                        cmbDiscount.SelectedIndex = i
                                        Exit For
                                    End If

                                Next

                            End If

                        End If

                    End Using

                End Using

            End Using

            CalculateNights()
            CalculateTotal()

        Catch ex As Exception

            MessageBox.Show(
                "Error loading reservation: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class