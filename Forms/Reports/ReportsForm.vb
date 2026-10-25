Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

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

        ' "Export PDF" button, created here (placed under the Generate button)
        Dim btnPdf As New Button()
        btnPdf.Text = "EXPORT PDF"
        btnPdf.BackColor = btnGenerate.BackColor
        btnPdf.ForeColor = btnGenerate.ForeColor
        btnPdf.Font = btnGenerate.Font
        btnPdf.Size = btnGenerate.Size
        btnPdf.Margin = btnGenerate.Margin
        btnPdf.Location = New Point(btnGenerate.Left, btnGenerate.Bottom + 10)
        btnPdf.UseVisualStyleBackColor = False
        AddHandler btnPdf.Click, AddressOf btnExportPdf_Click
        btnGenerate.Parent.Controls.Add(btnPdf)
    End Sub

    ' ==========================================
    ' PDF EXPORT (prints the grid to the "Microsoft Print to PDF" printer)
    ' ==========================================
    Private printRowIndex As Integer = 0

    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs)
        If dgvReports.Rows.Count = 0 OrElse (dgvReports.Rows.Count = 1 AndAlso dgvReports.Rows(0).IsNewRow) Then
            MessageBox.Show("Generate a report first.", "Nothing to export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "PDF file (*.pdf)|*.pdf"
            sfd.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd_HHmm") & ".pdf"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                printRowIndex = 0
                Dim doc As New PrintDocument()
                AddHandler doc.PrintPage, AddressOf reportDoc_PrintPage
                doc.PrinterSettings.PrinterName = "Microsoft Print to PDF"

                If doc.PrinterSettings.IsValid Then
                    doc.PrinterSettings.PrintToFile = True
                    doc.PrinterSettings.PrintFileName = sfd.FileName
                    doc.Print()
                    MessageBox.Show("Saved to:" & vbCrLf & sfd.FileName, "PDF exported", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' No PDF printer on this PC: show a preview; choose a PDF printer from there
                    MessageBox.Show("The 'Microsoft Print to PDF' printer was not found. A print preview will open instead.", "PDF printer missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Using preview As New PrintPreviewDialog()
                        preview.Document = doc
                        preview.ShowDialog(Me)
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Could not export the PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub reportDoc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim left As Integer = e.MarginBounds.Left
        Dim width As Integer = e.MarginBounds.Width
        Dim y As Single = e.MarginBounds.Top

        Dim widths() As Single = {0.19F, 0.2F, 0.27F, 0.15F, 0.19F}

        Using fTitle As New Font("Arial", 16, FontStyle.Bold),
              fHead As New Font("Arial", 10, FontStyle.Bold),
              fBody As New Font("Arial", 10)

            g.DrawString("H.A.J.K High Rise Hotel", fTitle, Brushes.Black, left, y)
            y += 32
            g.DrawString(lblTotalRevenue.Text, fHead, Brushes.Black, New RectangleF(left, y, width, 40))
            y += 45

            ' column headings on every page
            Dim x As Single = left
            For c As Integer = 0 To dgvReports.Columns.Count - 1
                g.DrawString(dgvReports.Columns(c).HeaderText, fHead, Brushes.Black, New RectangleF(x, y, width * widths(c), 20))
                x += width * widths(c)
            Next
            y += 22
            g.DrawLine(Pens.Black, left, y, left + width, y)
            y += 4

            ' rows
            While printRowIndex < dgvReports.Rows.Count
                Dim row As DataGridViewRow = dgvReports.Rows(printRowIndex)
                If row.IsNewRow Then
                    printRowIndex += 1
                    Continue While
                End If
                If y + 22 > e.MarginBounds.Bottom Then Exit While

                x = left
                For c As Integer = 0 To dgvReports.Columns.Count - 1
                    Dim text As String = If(row.Cells(c).Value Is Nothing, "", row.Cells(c).Value.ToString())
                    g.DrawString(text, fBody, Brushes.Black, New RectangleF(x, y, width * widths(c) - 4, 20))
                    x += width * widths(c)
                Next
                y += 22
                printRowIndex += 1
            End While
        End Using

        If printRowIndex < dgvReports.Rows.Count Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            printRowIndex = 0
        End If
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
