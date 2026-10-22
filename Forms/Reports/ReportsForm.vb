Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default date range: First day of current month to Today
        dtpStartDate.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpEndDate.Value = DateTime.Today

        ' Set up the grid
        dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReports.ReadOnly = True
        dgvReports.AllowUserToAddRows = False
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If dtpStartDate.Value.Date > dtpEndDate.Value.Date Then
            MessageBox.Show("Start Date cannot be after End Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim startDate As String = dtpStartDate.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dtpEndDate.Value.ToString("yyyy-MM-dd")

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' Query to get payments joined with reservation and guest details
                Dim query As String =
                    "SELECT p.payment_date, r.res_code, " &
                    "CONCAT(g.surname, ', ', g.firstname) AS guest_name, " &
                    "p.amount, p.payment_method " &
                    "FROM payment p " &
                    "INNER JOIN reservation r ON p.res_id = r.res_id " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "WHERE DATE(p.payment_date) BETWEEN @start AND @end " &
                    "ORDER BY p.payment_date DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@start", startDate)
                    cmd.Parameters.AddWithValue("@end", endDate)

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

                        lblTotalRevenue.Text = "Total Revenue: ₱" & grandTotal.ToString("N2")
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