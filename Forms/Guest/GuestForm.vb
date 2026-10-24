Imports MySql.Data.MySqlClient

Public Class GuestForm
    Private Sub GuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuests.MultiSelect = False
        dgvGuests.ReadOnly = True

        LoadGuests()
    End Sub

    Private Sub LoadGuests()

        Try

            Using conn As MySqlConnection = DbConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT guest_id, surname, firstname, middlename, " &
                    "contact, email, valid_id_type, valid_id_number " &
                    "FROM guest " &
                    "ORDER BY surname, firstname"

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
                                reader("valid_id_number")
                            )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading guests: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

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


        Dim guestID As Integer =
            Convert.ToInt32(
                dgvGuests.SelectedRows(0).Cells("colGuestID").Value
            )


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


        Dim guestID =
            Convert.ToInt32(
                dgvGuests.SelectedRows(0).Cells("colGuestID").Value
            )


        Dim surname =
            dgvGuests.SelectedRows(0).Cells("colSurname").Value.ToString

        Dim firstname =
            dgvGuests.SelectedRows(0).Cells("colFirstname").Value.ToString


        Dim answer =
            MessageBox.Show(
                "Are you sure you want to delete " &
                firstname & " " & surname & "?",
                "Delete Guest",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )


        If answer <> DialogResult.Yes Then

            Exit Sub

        End If


        Try

            Using conn = DbConnection.GetConnection

                conn.Open()

                Dim query =
                    "DELETE FROM guest WHERE guest_id = @guestID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@guestID", guestID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using


            MessageBox.Show(
                "Guest deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadGuests()


        Catch ex As MySqlException

            ' Guest is already connected to a reservation
            If ex.Number = 1451 Then

                MessageBox.Show(
                    "This guest cannot be deleted because they are connected to an existing reservation.",
                    "Cannot Delete Guest",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Else

                MessageBox.Show(
                    "Database error: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Error deleting guest: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchGuests()

    End Sub


    Private Sub SearchGuests()

        Dim searchText As String =
            txtSearch.Text.Trim()


        If searchText = "" Then

            LoadGuests()

            Exit Sub

        End If


        Try

            Using conn As MySqlConnection = DbConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT guest_id, surname, firstname, middlename, " &
                    "contact, email, valid_id_type, valid_id_number " &
                    "FROM guest " &
                    "WHERE surname LIKE @search " &
                    "OR firstname LIKE @search " &
                    "OR middlename LIKE @search " &
                    "OR contact LIKE @search " &
                    "OR email LIKE @search " &
                    "OR valid_id_number LIKE @search " &
                    "ORDER BY surname, firstname"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" & searchText & "%"
                    )


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
                                reader("valid_id_number")
                            )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error searching guests: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()

        LoadGuests()
    End Sub

    Private Sub btnStayHistory_Click(sender As Object, e As EventArgs) Handles btnStayHistory.Click
        ' Check if a guest is selected
        If dgvGuests.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Please select a guest first.",
                "No Guest Selected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        ' Get the selected guest's information
        Dim selectedRow As DataGridViewRow = dgvGuests.SelectedRows(0)

        Dim guestID As Integer =
            Convert.ToInt32(selectedRow.Cells("colGuestID").Value)

        Dim surname As String =
            selectedRow.Cells("colSurname").Value.ToString()

        Dim firstname As String =
            selectedRow.Cells("colFirstname").Value.ToString()

        Dim guestName As String = firstname & " " & surname

        ' Open the stay history form
        Dim historyForm As New GuestStayHistoryForm(guestID, guestName)
        historyForm.ShowDialog()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New loginForm()
        login.Show()

        'Loop through all open forms and close any active dashboards
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is AdminDashboard OrElse TypeOf frm Is StaffDashboard Then
                frm.Close()
                Exit For
            End If
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Controls.Clear()

        ' 2. Create an instance of your AdminDashboard
        Dim mainDashboard As New StaffDashboard()
        mainDashboard.TopLevel = False
        mainDashboard.FormBorderStyle = FormBorderStyle.None
        mainDashboard.Dock = DockStyle.Fill

        ' 3. Add it to this form and show it
        Me.Controls.Add(mainDashboard)
        mainDashboard.Show()

    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        Me.Controls.Clear()

        Dim reservations As New ReservationListForm()
        reservations.TopLevel = False
        reservations.FormBorderStyle = FormBorderStyle.None
        reservations.Dock = DockStyle.Fill

        Me.Controls.Add(reservations)
        reservations.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Controls.Clear()

        Dim mainDashboard As New StaffDashboard()
        mainDashboard.TopLevel = False
        mainDashboard.FormBorderStyle = FormBorderStyle.None
        mainDashboard.Dock = DockStyle.Fill

        Me.Controls.Add(mainDashboard)
        mainDashboard.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        MessageBox.Show("Design not done yet.")
    End Sub
End Class
