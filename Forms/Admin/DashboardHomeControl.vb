Imports MySql.Data.MySqlClient

Public Class DashboardHomeControl

    Private Sub DashboardHomeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize and Start the Live Date & Time Timer
        tmrDashboard.Interval = 1000
        tmrDashboard.Start()

        ' Set initial timestamp immediately upon loading
        lblDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy hh:mm:ss tt")

        ' Load Live Data
        LoadDashboardCounts()
    End Sub

    Private Sub tmrDashboard_Tick(sender As Object, e As EventArgs) Handles tmrDashboard.Tick
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

                ' Daily Revenue
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM payment WHERE DATE(payment_date) = CURDATE()", conn)
                    lblDailyRevenue.Text = "₱" & Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2")
                End Using

                ' Monthly Revenue
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM payment WHERE MONTH(payment_date) = MONTH(CURDATE()) AND YEAR(payment_date) = YEAR(CURDATE())", conn)
                    lblMonthlyRevenue.Text = "₱" & Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2")
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

End Class