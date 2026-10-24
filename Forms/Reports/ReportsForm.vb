Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        ' Default date range to today
        dtpStartDate.Value = DateTime.Today
        dtpEndDate.Value = DateTime.Today

        ' Set up the dropdown
        cmbReportType.Items.Clear()
        cmbReportType.Items.Add("Daily")
        cmbReportType.Items.Add("Monthly")
        cmbReportType.Items.Add("Annual")
        cmbReportType.SelectedIndex = 0 ' Default to Daily
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim filterQuery As String = ""
        Dim title As String = ""

        ' 1. Choose the SQL filter based on the dropdown
        Select Case cmbReportType.Text
            Case "Daily"
                filterQuery = "DATE(p.payment_date) = @selectedDate"
                title = "Daily Report for " & dtpStartDate.Value.ToString("MMM dd, yyyy")
            Case "Monthly"
                filterQuery = "MONTH(p.payment_date) = MONTH(@selectedDate) AND YEAR(p.payment_date) = YEAR(@selectedDate)"
                title = "Monthly Report for " & dtpStartDate.Value.ToString("MMMM yyyy")
            Case "Annual"
                filterQuery = "YEAR(p.payment_date) = YEAR(@selectedDate)"
                title = "Annual Report for " & dtpStartDate.Value.ToString("yyyy")
        End Select

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT p.payment_date, r.res_code, " &
                    "CONCAT(g.surname, ', ', g.firstname) AS guest_name, " &
                    "p.amount, p.payment_method " &
                    "FROM payment p " &
                    "INNER JOIN reservation r ON p.res_id = r.res_id " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "WHERE " & filterQuery & " " &
                    "ORDER BY p.payment_date DESC"

                Using cmd As New MySqlCommand(query, conn)
                    ' We use dtpStartDate as the reference date for all reports
                    cmd.Parameters.AddWithValue("@selectedDate", dtpStartDate.Value.Date)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvReports.Rows.Clear()
                        Dim grandTotal As Decimal = 0

                        While reader.Read()
                            Dim amount As Decimal = Convert.ToDecimal(reader("amount"))
                            grandTotal += amount

                            dgvReports.Rows.Add(
                                Convert.ToDateTime(reader("payment_date")).ToString("yyyy-MM-dd HH:mm"),
                                reader("res_code").ToString(),
                                reader("guest_name").ToString(),
                                amount.ToString("N2"),
                                reader("payment_method").ToString()
                            )
                        End While

                        lblTotalRevenue.Text = title & " | Total Revenue: ₱" & grandTotal.ToString("N2")
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Controls.Clear()

        Dim mainDashboard As New AdminDashboard()
        mainDashboard.TopLevel = False
        mainDashboard.FormBorderStyle = FormBorderStyle.None
        mainDashboard.Dock = DockStyle.Fill

        Me.Controls.Add(mainDashboard)
        mainDashboard.Show()

    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Me.Controls.Clear()

        Dim rooms As New RoomForm()
        rooms.TopLevel = False
        rooms.FormBorderStyle = FormBorderStyle.None
        rooms.Dock = DockStyle.Fill

        Me.Controls.Add(rooms)
        rooms.Show()

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Me.Controls.Clear()

        Dim staffManagement As New StaffManagementForm()
        staffManagement.TopLevel = False
        staffManagement.FormBorderStyle = FormBorderStyle.None
        staffManagement.Dock = DockStyle.Fill

        Me.Controls.Add(staffManagement)
        staffManagement.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim login As New loginForm()
            login.Show()

            ' Loop safely through a copy of open forms to close active dashboards
            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToList()
                If TypeOf frm Is AdminDashboard OrElse TypeOf frm Is StaffDashboard Then
                    frm.Close()
                End If
            Next
        End If
    End Sub
End Class
