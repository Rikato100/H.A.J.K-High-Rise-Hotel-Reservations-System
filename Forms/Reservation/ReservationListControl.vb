Imports MySql.Data.MySqlClient

Public Class ReservationListControl

    Private Sub ReservationListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservations.MultiSelect = False
        dgvReservations.ReadOnly = True

        colResID.Visible = False

        cmbStatusFilter.SelectedIndex = 0 ' Default to "All"

        LoadReservations()

        ' Wire up the manually added buttons
        AddHandler btnCheckIn.Click, AddressOf btnCheckIn_Click
        AddHandler btnCheckOut.Click, AddressOf btnCheckOut_Click
        AddHandler btnProcessPayment.Click, AddressOf btnProcessPayment_Click
    End Sub

    Private Sub LoadReservations()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim statusFilter As String = If(cmbStatusFilter.SelectedIndex = -1, "All", cmbStatusFilter.Text)

                Dim query As String =
                    "SELECT r.res_id, r.res_code, " &
                    "CONCAT(g.surname, ', ', g.firstname) AS guest_name, " &
                    "rm.room_number, r.res_status, " &
                    "r.check_in, r.check_out, r.num_nights, " &
                    "r.total_amount " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "INNER JOIN room rm ON r.room_id = rm.room_id " &
                    "WHERE (@status = 'All' OR r.res_status = @status) " &
                    "ORDER BY r.res_id DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@status", statusFilter)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvReservations.Rows.Clear()

                        While reader.Read()
                            dgvReservations.Rows.Add(
                                reader("res_id"),
                                reader("res_code"),
                                reader("guest_name"),
                                reader("room_number"),
                                reader("res_status"),
                                Convert.ToDateTime(reader("check_in")).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(reader("check_out")).ToString("yyyy-MM-dd"),
                                reader("num_nights"),
                                Convert.ToDecimal(reader("total_amount")).ToString("₱#,##0.00")
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading reservations: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusFilter.SelectedIndexChanged
        LoadReservations()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddReservation.Click
        Dim addReservation As New Reservation()
        If addReservation.ShowDialog() = DialogResult.OK Then
            LoadReservations()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReservations()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" Then
            LoadReservations()
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT r.res_id, r.res_code, " &
                    "CONCAT(g.surname, ', ', g.firstname) AS guest_name, " &
                    "rm.room_number, r.res_status, " &
                    "r.check_in, r.check_out, r.num_nights, " &
                    "r.total_amount " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "INNER JOIN room rm ON r.room_id = rm.room_id " &
                    "WHERE r.res_code LIKE @search " &
                    "OR g.surname LIKE @search " &
                    "OR g.firstname LIKE @search " &
                    "OR rm.room_number LIKE @search " &
                    "ORDER BY r.res_id DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvReservations.Rows.Clear()

                        While reader.Read()
                            dgvReservations.Rows.Add(
                                reader("res_id"),
                                reader("res_code"),
                                reader("guest_name"),
                                reader("room_number"),
                                reader("res_status"),
                                Convert.ToDateTime(reader("check_in")).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(reader("check_out")).ToString("yyyy-MM-dd"),
                                reader("num_nights"),
                                Convert.ToDecimal(reader("total_amount")).ToString("N2")
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching reservations: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to cancel.")
            Exit Sub
        End If

        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim status As String = dgvReservations.SelectedRows(0).Cells("colStatus").Value.ToString()
        Dim resName As String = dgvReservations.SelectedRows(0).Cells("colGuest").Value.ToString()

        If status = "Canceled" Then
            MessageBox.Show("This reservation is already canceled.")
            Exit Sub
        End If

        If status = "Check-Out" Then
            MessageBox.Show("A checked-out reservation cannot be canceled.")
            Exit Sub
        End If

        Dim answer As DialogResult = MessageBox.Show(
            "Are you sure you want to cancel the reservation of " & resName & "?",
            "Cancel Reservation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If answer <> DialogResult.Yes Then Exit Sub

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim roomID As Integer = 0
                Dim findRoomQuery As String = "SELECT room_id FROM reservation WHERE res_id = @resID"
                Using findCmd As New MySqlCommand(findRoomQuery, conn)
                    findCmd.Parameters.AddWithValue("@resID", resID)
                    Dim result = findCmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        roomID = Convert.ToInt32(result)
                    End If
                End Using

                Dim query As String = "UPDATE reservation SET res_status = 'Canceled' WHERE res_id = @resID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    cmd.ExecuteNonQuery()
                End Using

                If roomID <> 0 Then
                    Dim freeRoomQuery As String = "UPDATE room SET room_status = 'Available' WHERE room_id = @roomID"
                    Using freeCmd As New MySqlCommand(freeRoomQuery, conn)
                        freeCmd.Parameters.AddWithValue("@roomID", roomID)
                        freeCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            MessageBox.Show("Reservation canceled successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReservations()

        Catch ex As Exception
            MessageBox.Show("Error canceling reservation: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to edit.")
            Exit Sub
        End If

        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim editReservation As New Reservation(resID)

        If editReservation.ShowDialog() = DialogResult.OK Then
            LoadReservations()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to delete.")
            Exit Sub
        End If

        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim resCode As String = dgvReservations.SelectedRows(0).Cells("colResCode").Value.ToString()

        Dim answer As DialogResult = MessageBox.Show(
            "Are you sure you want to permanently delete reservation " & resCode & "?",
            "Delete Reservation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If answer <> DialogResult.Yes Then Exit Sub

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim roomID As Integer = 0
                Using findCmd As New MySqlCommand("SELECT room_id FROM reservation WHERE res_id = @resID", conn)
                    findCmd.Parameters.AddWithValue("@resID", resID)
                    Dim result = findCmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        roomID = Convert.ToInt32(result)
                    End If
                End Using

                Dim currentStatus As String = dgvReservations.SelectedRows(0).Cells("colStatus").Value.ToString()
                If roomID <> 0 AndAlso currentStatus <> "Canceled" Then
                    Using freeCmd As New MySqlCommand("UPDATE room SET room_status = 'Available' WHERE room_id = @roomID", conn)
                        freeCmd.Parameters.AddWithValue("@roomID", roomID)
                        freeCmd.ExecuteNonQuery()
                    End Using
                End If

                Dim query As String = "DELETE FROM reservation WHERE res_id = @resID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Reservation deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReservations()

        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("This reservation cannot be deleted because it has related payment records.",
                                "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Database error: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting reservation: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==========================================
    ' CHECK-IN BUTTON
    ' ==========================================
    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs)
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to check-in.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim status As String = dgvReservations.SelectedRows(0).Cells("colStatus").Value.ToString()
        Dim resName As String = dgvReservations.SelectedRows(0).Cells("colGuest").Value.ToString()

        If status <> "Pending" Then
            MessageBox.Show("Only 'Pending' reservations can be checked in.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show($"Are you sure you want to check-in {resName}?", "Confirm Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = DbConnection.GetConnection()
                    conn.Open()

                    Dim roomID As Integer = 0
                    Using findCmd As New MySqlCommand("SELECT room_id FROM reservation WHERE res_id = @resID", conn)
                        findCmd.Parameters.AddWithValue("@resID", resID)
                        roomID = Convert.ToInt32(findCmd.ExecuteScalar())
                    End Using

                    Using resCmd As New MySqlCommand("UPDATE reservation SET res_status = 'Check-In' WHERE res_id = @resID", conn)
                        resCmd.Parameters.AddWithValue("@resID", resID)
                        resCmd.ExecuteNonQuery()
                    End Using

                    If roomID <> 0 Then
                        Using roomCmd As New MySqlCommand("UPDATE room SET room_status = 'Occupied' WHERE room_id = @roomID", conn)
                            roomCmd.Parameters.AddWithValue("@roomID", roomID)
                            roomCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                MessageBox.Show("Guest successfully checked in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadReservations()

            Catch ex As Exception
                MessageBox.Show("Error checking in: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ==========================================
    ' CHECK-OUT BUTTON
    ' ==========================================
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs)
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to check-out.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim status As String = dgvReservations.SelectedRows(0).Cells("colStatus").Value.ToString()
        Dim resName As String = dgvReservations.SelectedRows(0).Cells("colGuest").Value.ToString()

        If status <> "Check-In" Then
            MessageBox.Show("Only 'Check-In' reservations can be checked out.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim totalAmount As Decimal = 0
                Using totalCmd As New MySqlCommand("SELECT total_amount FROM reservation WHERE res_id = @resID", conn)
                    totalCmd.Parameters.AddWithValue("@resID", resID)
                    totalAmount = Convert.ToDecimal(totalCmd.ExecuteScalar())
                End Using

                Dim totalPaid As Decimal = 0
                Using paidCmd As New MySqlCommand("SELECT SUM(amount) FROM payment WHERE res_id = @resID", conn)
                    paidCmd.Parameters.AddWithValue("@resID", resID)
                    Dim result = paidCmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then totalPaid = Convert.ToDecimal(result)
                End Using

                Dim balance As Decimal = totalAmount - totalPaid
                If balance > 0 Then
                    MessageBox.Show($"Cannot check-out. Guest still has a balance of ₱{balance.ToString("N2")}. Please process payment first.",
                                    "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim roomID As Integer = 0
                Using findCmd As New MySqlCommand("SELECT room_id FROM reservation WHERE res_id = @resID", conn)
                    findCmd.Parameters.AddWithValue("@resID", resID)
                    roomID = Convert.ToInt32(findCmd.ExecuteScalar())
                End Using

                Using resCmd As New MySqlCommand("UPDATE reservation SET res_status = 'Check-Out' WHERE res_id = @resID", conn)
                    resCmd.Parameters.AddWithValue("@resID", resID)
                    resCmd.ExecuteNonQuery()
                End Using

                If roomID <> 0 Then
                    Using roomCmd As New MySqlCommand("UPDATE room SET room_status = 'Available' WHERE room_id = @roomID", conn)
                        roomCmd.Parameters.AddWithValue("@roomID", roomID)
                        roomCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            MessageBox.Show("Guest successfully checked out! Room is now available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReservations()

        Catch ex As Exception
            MessageBox.Show("Error checking out: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==========================================
    ' PROCESS PAYMENT BUTTON
    ' ==========================================
    Private Sub btnProcessPayment_Click(sender As Object, e As EventArgs)
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to process payment for.")
            Exit Sub
        End If

        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim resName As String = dgvReservations.SelectedRows(0).Cells("colGuest").Value.ToString()

        Dim totalAmount As Decimal = 0
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT total_amount FROM reservation WHERE res_id = @resID", conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    totalAmount = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting total: " & ex.Message)
            Exit Sub
        End Try

        Dim payForm As New PaymentForm(resID, resName, totalAmount)
        If payForm.ShowDialog() = DialogResult.OK Then
            LoadReservations()
        End If
    End Sub

    ' ==========================================
    ' INVOICE PRINTING (Dropdown + Detailed Layout)
    ' ==========================================
    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to print.")
            Exit Sub
        End If

        If cmbInvoiceType.SelectedIndex = -1 Then
            MessageBox.Show("Please select an invoice type from the dropdown.")
            Exit Sub
        End If

        printPreview.Document = printDoc
        printPreview.ShowDialog()
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim resCode As String = ""
        Dim guestName As String = ""
        Dim roomNo As String = ""
        Dim roomType As String = ""
        Dim checkIn As String = ""
        Dim checkOut As String = ""
        Dim nights As Integer = 0
        Dim totalAmount As Decimal = 0
        Dim totalPaid As Decimal = 0
        Dim paymentMethod As String = "N/A"
        Dim refNo As String = "N/A"

        Dim baseRate As Decimal = 0
        Dim extraPersonFee As Decimal = 0
        Dim subtotal As Decimal = 0
        Dim discountAmount As Decimal = 0
        Dim vatAmount As Decimal = 0

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim q1 As String =
                    "SELECT r.res_code, CONCAT(g.surname, ', ', g.firstname) AS guest, " &
                    "rm.room_number, rt.type_name, r.check_in, r.check_out, r.num_nights, " &
                    "r.total_amount, r.base_rate, r.extra_person, r.subtotal, r.discount_amount, r.vat_amount " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "INNER JOIN room rm ON r.room_id = rm.room_id " &
                    "INNER JOIN room_type rt ON rm.room_type_id = rt.room_type_id " &
                    "WHERE r.res_id = @resID"

                Using cmd As New MySqlCommand(q1, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            resCode = reader("res_code").ToString()
                            guestName = reader("guest").ToString()
                            roomNo = reader("room_number").ToString()
                            roomType = reader("type_name").ToString()
                            checkIn = Convert.ToDateTime(reader("check_in")).ToString("MMM dd, yyyy")
                            checkOut = Convert.ToDateTime(reader("check_out")).ToString("MMM dd, yyyy")
                            nights = Convert.ToInt32(reader("num_nights"))
                            totalAmount = Convert.ToDecimal(reader("total_amount"))
                            baseRate = Convert.ToDecimal(reader("base_rate"))
                            extraPersonFee = Convert.ToDecimal(reader("extra_person"))
                            subtotal = Convert.ToDecimal(reader("subtotal"))
                            discountAmount = Convert.ToDecimal(reader("discount_amount"))
                            vatAmount = Convert.ToDecimal(reader("vat_amount"))
                        End If
                    End Using
                End Using

                Using paidCmd As New MySqlCommand("SELECT SUM(amount) FROM payment WHERE res_id = @resID", conn)
                    paidCmd.Parameters.AddWithValue("@resID", resID)
                    Dim result = paidCmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then totalPaid = Convert.ToDecimal(result)
                End Using

                Dim q2 As String = "SELECT payment_method, reference_no FROM payment WHERE res_id = @resID ORDER BY payment_id DESC LIMIT 1"
                Using cmd As New MySqlCommand(q2, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not IsDBNull(reader("payment_method")) Then paymentMethod = reader("payment_method").ToString()
                            If Not IsDBNull(reader("reference_no")) Then refNo = reader("reference_no").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching receipt data: " & ex.Message)
            Exit Sub
        End Try

        Dim g As Graphics = e.Graphics
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 11, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim fontSmall As New Font("Arial", 8)
        Dim brush As New SolidBrush(Color.Black)
        Dim pen As New Pen(Color.Black, 1)

        Dim y As Integer = 50

        g.DrawString("H.A.J.K HIGH RISE HOTEL", fontTitle, brush, 50, y) : y += 25
        g.DrawString("123 Luxury Boulevard, Metro Manila, Philippines", fontBody, brush, 50, y) : y += 20
        g.DrawString("Contact: +63 (2) 8888-0000 | info@hajkhigrise.com", fontBody, brush, 50, y) : y += 30

        Dim invType As String = cmbInvoiceType.Text.ToUpper()
        g.DrawString("OFFICIAL " & invType, fontHeader, brush, 50, y)

        g.DrawString("Ref Code: " & resCode, fontBody, brush, 450, y) : y += 15
        g.DrawString("Date: " & DateTime.Now.ToString("MMM dd, yyyy"), fontBody, brush, 450, y) : y += 30

        g.DrawLine(pen, 50, y, 750, y) : y += 10

        g.DrawString("Guest Information:", fontHeader, brush, 50, y)
        g.DrawString("Stay Information:", fontHeader, brush, 400, y)
        y += 20
        g.DrawString("Guest Name: " & guestName, fontBody, brush, 50, y)
        g.DrawString("Check-In: " & checkIn & " | Check-Out: " & checkOut, fontBody, brush, 400, y)
        y += 20
        g.DrawString("Room No: " & roomNo & " (" & roomType & ")", fontBody, brush, 400, y)
        y += 20
        g.DrawString("Duration: " & nights & " Nights", fontBody, brush, 400, y)
        y += 20

        g.DrawLine(pen, 50, y, 750, y) : y += 15

        g.DrawString("ITEM DESCRIPTION", fontHeader, brush, 50, y)
        g.DrawString("RATE / NIGHT", fontHeader, brush, 400, y)
        g.DrawString("QTY / NIGHTS", fontHeader, brush, 520, y)
        g.DrawString("TOTAL AMOUNT", fontHeader, brush, 650, y)
        y += 15
        g.DrawLine(pen, 50, y, 750, y) : y += 10

        Dim roomCharge As Decimal = baseRate * nights
        g.DrawString(roomType & " Accommodation", fontBody, brush, 50, y)
        g.DrawString("₱" & baseRate.ToString("N2"), fontBody, brush, 400, y)
        g.DrawString(nights.ToString(), fontBody, brush, 540, y)
        g.DrawString("₱" & roomCharge.ToString("N2"), fontBody, brush, 650, y)
        y += 20

        If extraPersonFee > 0 Then
            g.DrawString("Extra Person Charge", fontBody, brush, 50, y)
            g.DrawString("₱800.00", fontBody, brush, 400, y)
            g.DrawString(nights.ToString(), fontBody, brush, 540, y)
            g.DrawString("₱" & extraPersonFee.ToString("N2"), fontBody, brush, 650, y)
            y += 20
        End If

        y += 10
        g.DrawLine(pen, 400, y, 750, y) : y += 10

        g.DrawString("SUBTOTAL:", fontHeader, brush, 450, y)
        g.DrawString("₱" & subtotal.ToString("N2"), fontHeader, brush, 650, y) : y += 20

        If discountAmount > 0 Then
            g.DrawString("Less: Discount", fontBody, brush, 450, y)
            g.DrawString("-₱" & discountAmount.ToString("N2"), fontBody, brush, 650, y) : y += 20
        End If

        g.DrawString("Value Added Tax (12%):", fontBody, brush, 450, y)
        g.DrawString("₱" & vatAmount.ToString("N2"), fontBody, brush, 650, y) : y += 20

        g.DrawString("TOTAL AMOUNT DUE:", fontHeader, brush, 450, y)
        g.DrawString("₱" & totalAmount.ToString("N2"), fontHeader, brush, 650, y) : y += 25

        g.DrawLine(pen, 50, y, 750, y) : y += 10
        Dim balance As Decimal = totalAmount - totalPaid
        g.DrawString("Payment Method: " & paymentMethod & If(refNo = "N/A", "", " (Ref #" & refNo & ")"), fontBody, brush, 50, y)
        g.DrawString("Amount Paid: ₱" & totalPaid.ToString("N2"), fontBody, brush, 400, y)
        g.DrawString("Balance Due: ₱" & balance.ToString("N2"), fontBody, brush, 600, y)
        y += 40

        g.DrawString("_________________________", fontBody, brush, 100, y)
        g.DrawString("_________________________", fontBody, brush, 500, y) : y += 20
        g.DrawString("Guest Signature over Printed Name", fontSmall, brush, 100, y)
        g.DrawString("Authorized Front Desk", fontSmall, brush, 500, y)
    End Sub

    ' ==========================================
    ' EXPORT TO CSV
    ' ==========================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        GridExporter.ExportToCsv(dgvReservations, "Reservations")
    End Sub
End Class