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

        ' Initialize and Start the Live Date & Time Timer
        tmrDashboard.Interval = 1000
        tmrDashboard.Start()

        ' Set initial timestamp immediately upon loading
        lblDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy hh:mm:ss tt")

        ' Load Live Data
        LoadDashboardCounts()
    End Sub

    Private Sub tmrDashboard_Tick(sender As Object, e As EventArgs) Handles tmrDashboard.Tick
        ' Updates the date and time label every second
        lblDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy hh:mm:ss tt")
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
                    Dim occupancy As Decimal = (CDec(occupiedRooms) / totalRooms) * 100
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
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim login As New loginForm()
            login.Show()
            Me.Close()
        End If
    End Sub

    ' Rooms, Staff, Reports and Settings open as pop-ups so the dashboard is not wiped
    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Using f As New RoomForm()
            f.ShowDialog(Me)
        End Using
        LoadDashboardCounts()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Using f As New StaffManagementForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Using f As New ReportsForm()
            f.ShowDialog(Me)
        End Using
    End Sub

    ' Settings contains Discounts, Change Password and (Admin only) System Reset
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Using f As New SettingsForm()
            f.ShowDialog(Me)
        End Using
        LoadDashboardCounts()
    End Sub

    Private Sub cardDeparting_Paint(sender As Object, e As PaintEventArgs) Handles cardDeparting.Paint

    End Sub

    Private Sub lblArrivingToday_Click(sender As Object, e As EventArgs) Handles lblArrivingToday.Click

    End Sub
End Class
