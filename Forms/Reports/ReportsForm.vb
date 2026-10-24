Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
