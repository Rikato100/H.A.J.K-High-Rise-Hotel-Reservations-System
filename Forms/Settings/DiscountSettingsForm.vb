Imports MySql.Data.MySqlClient

'======================================================================
'======================================================================
'======================================================================

'THIS IS ALREADY COMBINED WITH CHANGEPASSWORD IN SETTINGSFORM.VB 
'                   (delete after reading)

'======================================================================
'======================================================================
'======================================================================


' Admin screen to edit discount rates, dates and VAT exemption.
' Open with:  Using f As New DiscountSettingsForm() : f.ShowDialog(Me) : End Using
Public Class DiscountSettingsForm

    Private selectedId As Integer = 0
    Private selectedType As String = ""

    Private Sub DiscountSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numRate.Minimum = 0
        numRate.Maximum = 100
        SetEditorEnabled(False)
        LoadDiscounts()
    End Sub

    Private Sub LoadDiscounts()
        Try
            Dim dt As New DataTable()
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String =
                    "SELECT discount_id, discount_name, discount_type, discount_rate, " &
                    "start_date, end_date, vat_exempt FROM discount ORDER BY discount_id"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvDiscounts.DataSource = dt
            dgvDiscounts.Columns("discount_id").HeaderText = "ID"
            dgvDiscounts.Columns("discount_id").FillWeight = 25
            dgvDiscounts.Columns("discount_name").HeaderText = "Name"
            dgvDiscounts.Columns("discount_type").HeaderText = "Type"
            dgvDiscounts.Columns("discount_rate").HeaderText = "Rate (%)"
            dgvDiscounts.Columns("discount_rate").DefaultCellStyle.Format = "0.00"
            dgvDiscounts.Columns("start_date").HeaderText = "Start Date"
            dgvDiscounts.Columns("start_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvDiscounts.Columns("end_date").HeaderText = "End Date"
            dgvDiscounts.Columns("end_date").DefaultCellStyle.Format = "yyyy-MM-dd"
            dgvDiscounts.Columns("vat_exempt").HeaderText = "VAT Exempt"

        Catch ex As Exception
            MessageBox.Show("Could not load discounts: " & ex.Message, "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetEditorEnabled(enabled As Boolean)
        numRate.Enabled = enabled
        chkVatExempt.Enabled = enabled
        dtpStart.Enabled = enabled
        dtpEnd.Enabled = enabled
        btnSave.Enabled = enabled
    End Sub

    Private Sub dgvDiscounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiscounts.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvDiscounts.Rows(e.RowIndex)
        selectedId = Convert.ToInt32(row.Cells("discount_id").Value)
        selectedType = row.Cells("discount_type").Value.ToString()
        lblSelected.Text = row.Cells("discount_name").Value.ToString()

        numRate.Value = Convert.ToDecimal(row.Cells("discount_rate").Value)
        chkVatExempt.Checked = Convert.ToBoolean(row.Cells("vat_exempt").Value)

        LoadDate(dtpStart, row.Cells("start_date").Value)
        LoadDate(dtpEnd, row.Cells("end_date").Value)

        ' "None" is always 0% and has no dates, so it is read-only
        SetEditorEnabled(selectedType <> "None")
    End Sub

    Private Sub LoadDate(picker As DateTimePicker, value As Object)
        If value Is Nothing OrElse IsDBNull(value) Then
            picker.Value = DateTime.Today
            picker.Checked = False
        Else
            picker.Value = Convert.ToDateTime(value)
            picker.Checked = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If selectedId = 0 Then
            MessageBox.Show("Select a discount from the list first.", "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpStart.Checked AndAlso dtpEnd.Checked AndAlso dtpEnd.Value.Date < dtpStart.Value.Date Then
            MessageBox.Show("The end date cannot be before the start date.", "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If selectedType = "Statutory" Then
            Dim answer As DialogResult = MessageBox.Show(
                "The Statutory discount (Senior Citizen / PWD) is set by law. Change it anyway?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer <> DialogResult.Yes Then Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String =
                    "UPDATE discount SET discount_rate = @rate, start_date = @start, " &
                    "end_date = @end, vat_exempt = @vat WHERE discount_id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rate", numRate.Value)
                    cmd.Parameters.AddWithValue("@start", If(dtpStart.Checked, CObj(dtpStart.Value.Date), DBNull.Value))
                    cmd.Parameters.AddWithValue("@end", If(dtpEnd.Checked, CObj(dtpEnd.Value.Date), DBNull.Value))
                    cmd.Parameters.AddWithValue("@vat", chkVatExempt.Checked)
                    cmd.Parameters.AddWithValue("@id", selectedId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Discount updated.", "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selectedId = 0
            lblSelected.Text = "Select a discount above"
            SetEditorEnabled(False)
            LoadDiscounts()

        Catch ex As Exception
            MessageBox.Show("Could not save the discount: " & ex.Message, "Discount Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '======================================================================
    '======================================================================
    '======================================================================

    'THIS IS ALREADY COMBINED WITH CHANGEPASSWORD IN SETTINGSFORM.VB
    '                   (delete after reading)

    '======================================================================
    '======================================================================
    '======================================================================



End Class
