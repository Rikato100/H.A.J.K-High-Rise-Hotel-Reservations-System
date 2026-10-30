Imports MySql.Data.MySqlClient

Public Class GuestControl
    Private Sub GuestControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuests.MultiSelect = False
        dgvGuests.ReadOnly = True

        LoadGuests()
    End Sub

    Private Sub LoadGuests()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                ' Subquery to count total visits
                Dim query As String =
                    "SELECT g.guest_id, g.surname, g.firstname, g.middlename, " &
                    "g.contact, g.email, g.valid_id_type, g.valid_id_number, " &
                    "(SELECT COUNT(*) FROM reservation r WHERE r.guest_id = g.guest_id) AS total_visits " &
                    "FROM guest g " &
                    "ORDER BY g.surname, g.firstname"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvGuests.Rows.Clear()

                        While reader.Read()
                            dgvGuests.Rows.Add(
                                reader("guest_id"),
                                reader("surname"),
                                reader("firstname"),
                                reader("middlename"),
                                reader("contact"),
                                reader("email"),
                                reader("valid_id_type"),
                                reader("valid_id_number"),
                                reader("total_visits")
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading guests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SessionHelper.GoToDashboard()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addGuest As New AddGuestForm()
        If addGuest.ShowDialog() = DialogResult.OK Then
            LoadGuests()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvGuests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a guest to edit.")
            Exit Sub
        End If

        Dim guestID As Integer = Convert.ToInt32(dgvGuests.SelectedRows(0).Cells("colGuestID").Value)
        Dim editGuest As New AddGuestForm(guestID)

        If editGuest.ShowDialog() = DialogResult.OK Then
            LoadGuests()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvGuests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a guest to delete.")
            Exit Sub
        End If

        Dim guestID = Convert.ToInt32(dgvGuests.SelectedRows(0).Cells("colGuestID").Value)
        Dim surname = dgvGuests.SelectedRows(0).Cells("colSurname").Value.ToString
        Dim firstname = dgvGuests.SelectedRows(0).Cells("colFirstname").Value.ToString

        Dim answer = MessageBox.Show(
            "Are you sure you want to delete " & firstname & " " & surname & "?",
            "Delete Guest", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If answer <> DialogResult.Yes Then Exit Sub

        Try
            Using conn = DbConnection.GetConnection
                conn.Open()
                Dim query = "DELETE FROM guest WHERE guest_id = @guestID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@guestID", guestID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Guest deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGuests()

        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("This guest cannot be deleted because they are connected to an existing reservation.",
                    "Cannot Delete Guest", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting guest: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchGuests()
    End Sub

    Private Sub SearchGuests()
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" Then
            LoadGuests()
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT g.guest_id, g.surname, g.firstname, g.middlename, " &
                    "g.contact, g.email, g.valid_id_type, g.valid_id_number, " &
                    "(SELECT COUNT(*) FROM reservation r WHERE r.guest_id = g.guest_id) AS total_visits " &
                    "FROM guest g " &
                    "WHERE g.surname LIKE @search " &
                    "OR g.firstname LIKE @search " &
                    "OR g.middlename LIKE @search " &
                    "OR g.contact LIKE @search " &
                    "OR g.email LIKE @search " &
                    "OR g.valid_id_number LIKE @search " &
                    "ORDER BY g.surname, g.firstname"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvGuests.Rows.Clear()

                        While reader.Read()
                            dgvGuests.Rows.Add(
                                reader("guest_id"),
                                reader("surname"),
                                reader("firstname"),
                                reader("middlename"),
                                reader("contact"),
                                reader("email"),
                                reader("valid_id_type"),
                                reader("valid_id_number"),
                                reader("total_visits")
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching guests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadGuests()
    End Sub

    Private Sub btnStayHistory_Click(sender As Object, e As EventArgs) Handles btnStayHistory.Click
        If dgvGuests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a guest first.", "No Guest Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dgvGuests.SelectedRows(0)
        Dim guestID As Integer = Convert.ToInt32(selectedRow.Cells("colGuestID").Value)
        Dim surname As String = selectedRow.Cells("colSurname").Value.ToString()
        Dim firstname As String = selectedRow.Cells("colFirstname").Value.ToString()
        Dim guestName As String = firstname & " " & surname

        Dim historyForm As New GuestStayHistoryForm(guestID, guestName)
        historyForm.ShowDialog()
    End Sub

    ' Empty events
    Private Sub dgvGuests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuests.CellContentClick
    End Sub
    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub
End Class