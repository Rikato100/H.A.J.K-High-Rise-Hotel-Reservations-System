Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Checks if Current User is Admin
        If CurrentUser.Role <> "Admin" Then
            MessageBox.Show("Access Denied. Admin privileges required.",
                            "Security Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
            Me.Close()
            Exit Sub
        End If

        ' Set the window title to show who is logged in
        Me.Text = "Admin Dashboard - Logged in as: " & CurrentUser.Username

        ' Load Live Data
        LoadDashboardCounts()
    End Sub

    Private Sub LoadDashboardCounts()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' Available Rooms
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM room WHERE room_status = 'Available'", conn)
                    lblAvailableRooms.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' Arriving Today (Pending)
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM reservation WHERE check_in = CURDATE() AND res_status = 'Pending'", conn)
                    lblArrivingToday.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' Departing Today (Check-In)
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM reservation WHERE check_out = CURDATE() AND res_status = 'Check-In'", conn)
                    lblDepartingToday.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' In-House (Currently Checked In)
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM reservation WHERE res_status = 'Check-In'", conn)
                    lblInHouse.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' Daily Revenue (Sum of payments today)
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM payment WHERE DATE(payment_date) = CURDATE()", conn)
                    lblDailyRevenue.Text = "₱" & Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2")
                End Using

                ' Occupancy Rate
                Dim totalRooms As Integer = 0
                Dim occupiedRooms As Integer = 0

                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM room", conn)
                    totalRooms = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM room WHERE room_status = 'Occupied'", conn)
                    occupiedRooms = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If totalRooms > 0 Then
                    Dim occupancy As Decimal = (occupiedRooms / totalRooms) * 100
                    lblOccupancyRate.Text = occupancy.ToString("0.0") & "%"
                Else
                    lblOccupancyRate.Text = "0%"
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New loginForm()
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        'clears out the current screen's contents
        Me.Controls.Clear()

        Dim rooms As New RoomForm()
        rooms.TopLevel = False
        rooms.FormBorderStyle = FormBorderStyle.None
        rooms.Dock = DockStyle.Fill

        'rooms.ShowDialog()

        Me.Controls.Add(rooms)
        rooms.Show()

        LoadDashboardCounts()

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click

        MessageBox.Show("Design not done yet.")
        'Me.Controls.Clear()

        'Dim staff As New StaffManagementForm()
        'staff.TopLevel = False
        'staff.FormBorderStyle = FormBorderStyle.None
        'staff.Dock = DockStyle.Fill

        'Me.Controls.Add(staff)
        'staff.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        MessageBox.Show("Design not done yet.")
        'Dim reports As New ReportsForm()
        'reports.ShowDialog()
    End Sub

    ' --- Updated for combined settings ---
    'Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
    '    Using f As New SettingsForm()
    '        f.ShowDialog(Me)
    '    End Using
    'End Sub

    'Private Sub btnDiscountSettings_Click(sender As Object, e As EventArgs) Handles btnDiscountSettings.Click
    '    Using f As New SettingsForm()
    '        f.ShowDialog(Me)
    '    End Using
    'End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        MessageBox.Show("Design not done yet.")
        'Using f As New SettingsForm()
        '    f.ShowDialog(Me)
        'End Using
    End Sub

End Class