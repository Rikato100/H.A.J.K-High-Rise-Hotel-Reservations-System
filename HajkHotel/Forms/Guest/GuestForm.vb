Imports MySql.Data.MySqlClient

Public Class GuestForm
    Private Sub GuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuests.MultiSelect = False
        dgvGuests.ReadOnly = True

        LoadGuests()
    End Sub

    Private Sub LoadGuests()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
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


        Dim guestID As Integer =
            Convert.ToInt32(
                dgvGuests.SelectedRows(0).Cells("colGuestID").Value
            )


        Dim surname As String =
            dgvGuests.SelectedRows(0).Cells("colSurname").Value.ToString()

        Dim firstname As String =
            dgvGuests.SelectedRows(0).Cells("colFirstname").Value.ToString()


        Dim answer As DialogResult =
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

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
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

            Using conn As MySqlConnection = DBConnection.GetConnection()

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

    Private Sub dgvGuests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuests.CellContentClick

    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click

    End Sub
End Class