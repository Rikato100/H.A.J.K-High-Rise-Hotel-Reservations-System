Imports MySql.Data.MySqlClient

Public Class ReservationListForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.TopLevel = False
        Me.Close()
    End Sub

    Private Sub ReservationListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservations.MultiSelect = False
        dgvReservations.ReadOnly = True

        colResID.Visible = False

        LoadReservations()

        ' Wire up the manually added buttons
        AddHandler btnCheckIn.Click, AddressOf btnCheckIn_Click
        AddHandler btnCheckOut.Click, AddressOf btnCheckOut_Click
        AddHandler btnProcessPayment.Click, AddressOf btnProcessPayment_Click
        AddHandler btnPrintReceipt.Click, AddressOf btnPrintReceipt_Click
    End Sub

    Private Sub LoadReservations()
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
                    "ORDER BY r.res_id DESC"

                Using cmd As New MySqlCommand(query, conn)
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
            MessageBox.Show("Error loading reservations: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                    "OR r.res_status LIKE @search " &
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
    ' PRINT RECEIPT BUTTON
    ' ==========================================
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs)
        If dgvReservations.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a reservation to print.")
            Exit Sub
        End If

        printPreview.Document = printDoc
        printPreview.ShowDialog()
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
        Dim resID As Integer = Convert.ToInt32(dgvReservations.SelectedRows(0).Cells("colResID").Value)
        Dim resCode As String = ""
        Dim guestName As String = ""
        Dim roomNo As String = ""
        Dim checkIn As String = ""
        Dim checkOut As String = ""
        Dim totalAmount As Decimal = 0
        Dim totalPaid As Decimal = 0
        Dim paymentMethod As String = "N/A"
        Dim refNo As String = "N/A"

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim q1 As String =
                    "SELECT r.res_code, CONCAT(g.firstname, ' ', g.surname) AS guest, " &
                    "rm.room_number, r.check_in, r.check_out, r.total_amount " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "INNER JOIN room rm ON r.room_id = rm.room_id " &
                    "WHERE r.res_id = @resID"

                Using cmd As New MySqlCommand(q1, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            resCode = reader("res_code").ToString()
                            guestName = reader("guest").ToString()
                            roomNo = reader("room_number").ToString()
                            checkIn = Convert.ToDateTime(reader("check_in")).ToString("MMM dd, yyyy")
                            checkOut = Convert.ToDateTime(reader("check_out")).ToString("MMM dd, yyyy")
                            totalAmount = Convert.ToDecimal(reader("total_amount"))
                        End If
                    End Using
                End Using

                Dim q2 As String = "SELECT SUM(amount) AS paid, MAX(payment_method) AS method, MAX(reference_no) AS ref FROM payment WHERE res_id = @resID"
                Using cmd As New MySqlCommand(q2, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not IsDBNull(reader("paid")) Then totalPaid = Convert.ToDecimal(reader("paid"))
                            If Not IsDBNull(reader("method")) Then paymentMethod = reader("method").ToString()
                            If Not IsDBNull(reader("ref")) Then refNo = reader("ref").ToString()
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
        Dim fontHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim y As Integer = 50

        g.DrawString("H.A.J.K HIGH RISE HOTEL", fontTitle, brush, 100, y) : y += 30
        g.DrawString("123 Luxury Boulevard, Metro Manila", fontBody, brush, 100, y) : y += 20
        g.DrawString("Contact: +63 (2) 8888-0000", fontBody, brush, 100, y) : y += 40

        g.DrawString("OFFICIAL RECEIPT / FOLIO", fontHeader, brush, 100, y) : y += 30
        g.DrawString("Ref Code: " & resCode, fontBody, brush, 100, y) : y += 20
        g.DrawString("Date: " & DateTime.Now.ToString("MMM dd, yyyy"), fontBody, brush, 100, y) : y += 30

        g.DrawString("Guest Name: " & guestName, fontBody, brush, 100, y) : y += 20
        g.DrawString("Room: " & roomNo, fontBody, brush, 100, y) : y += 20
        g.DrawString("Stay: " & checkIn & " to " & checkOut, fontBody, brush, 100, y) : y += 40

        g.DrawString("--------------------------------------------------------", fontBody, brush, 100, y) : y += 20
        g.DrawString("Total Amount Due:", fontHeader, brush, 100, y)
        g.DrawString("PHP " & totalAmount.ToString("N2"), fontHeader, brush, 350, y) : y += 25

        g.DrawString("Amount Paid:", fontBody, brush, 100, y)
        g.DrawString("PHP " & totalPaid.ToString("N2"), fontBody, brush, 350, y) : y += 25

        Dim balance As Decimal = totalAmount - totalPaid
        g.DrawString("Balance:", fontBody, brush, 100, y)
        g.DrawString("PHP " & balance.ToString("N2"), fontBody, brush, 350, y) : y += 20
        g.DrawString("--------------------------------------------------------", fontBody, brush, 100, y) : y += 30

        g.DrawString("Payment Method: " & paymentMethod, fontBody, brush, 100, y) : y += 20
        g.DrawString("Reference No: " & refNo, fontBody, brush, 100, y) : y += 50

        g.DrawString("_________________________", fontBody, brush, 100, y)
        g.DrawString("_________________________", fontBody, brush, 350, y) : y += 20
        g.DrawString("Guest Signature", fontBody, brush, 120, y)
        g.DrawString("Authorized Front Desk", fontBody, brush, 350, y)
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        Dim reservations As New ReservationListForm
        reservations.ShowDialog()
    End Sub

    Private Sub btnGuests_Click(sender As Object, e As EventArgs) Handles btnGuests.Click
        Me.Controls.Clear()

        Dim guests As New GuestForm
        guests.TopLevel = False
        guests.FormBorderStyle = FormBorderStyle.None
        guests.Dock = DockStyle.Fill

        Me.Controls.Add(guests)
        guests.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New loginForm()
        login.Show()


        Dim parentForm As Form = Me.FindForm()
        If parentForm IsNot Nothing AndAlso Not TypeOf parentForm Is ReservationListForm Then
            parentForm.Close()
        Else
            ' Fallback loop to catch any open dashboard variant
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is AdminDashboard OrElse TypeOf frm Is StaffDashboard Then
                    frm.Close()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Controls.Clear()

        ' 2. Create an instance of your AdminDashboard
        Dim mainDashboard As New StaffDashboard()
        mainDashboard.TopLevel = False
        mainDashboard.FormBorderStyle = FormBorderStyle.None
        mainDashboard.Dock = DockStyle.Fill

        Me.Controls.Add(mainDashboard)
        mainDashboard.Show()
    End Sub

    Private Sub dgvReservations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservations.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("Design not done yet.")
    End Sub
End Class