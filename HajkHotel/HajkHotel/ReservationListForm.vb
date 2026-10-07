Imports MySql.Data.MySqlClient

Public Class ReservationListForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub ReservationListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReservations.MultiSelect = False
        dgvReservations.ReadOnly = True

        LoadReservations()
    End Sub

    Private Sub LoadReservations()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT r.res_id, r.res_code, " &
                    "CONCAT(g.surname, ', ', g.firstname) AS guest_name, " &
                    "rm.room_number, r.res_status, " &
                    "r.check_in, r.check_out, r.num_nights, " &
                    "r.total_amount " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "INNER JOIN room rm ON r.room_id = rm.room_id " &
                    "ORDER BY r.res_id DESC"

                Using cmd As New MySqlCommand(query, conn)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        dgvReservations.Rows.Clear()

                        While reader.Read()

                            dgvReservations.Rows.Add(
                                reader("res_id"),
                                reader("res_code"),
                                reader("guest_name"),
                                reader("room_number"),
                                reader("res_status"),
                                Convert.ToDateTime(reader("check_in")).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(reader("check_out")).ToString("yyyy-MM-dd"),
                                reader("num_nights"),
                                Convert.ToDecimal(reader("total_amount")).ToString("N2")
                            )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading reservations: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddReservation.Click
        Dim addReservation As New Reservation()

        If addReservation.ShowDialog() = DialogResult.OK Then
            LoadReservations()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReservations()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" Then
            LoadReservations()
            Exit Sub
        End If

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT r.res_id, r.res_code, " &
                    "CONCAT(g.surname, ', ', g.firstname) AS guest_name, " &
                    "rm.room_number, r.res_status, " &
                    "r.check_in, r.check_out, r.num_nights, " &
                    "r.total_amount " &
                    "FROM reservation r " &
                    "INNER JOIN guest g ON r.guest_id = g.guest_id " &
                    "INNER JOIN room rm ON r.room_id = rm.room_id " &
                    "WHERE r.res_code LIKE @search " &
                    "OR g.surname LIKE @search " &
                    "OR g.firstname LIKE @search " &
                    "OR rm.room_number LIKE @search " &
                    "OR r.res_status LIKE @search " &
                    "ORDER BY r.res_id DESC"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" & searchText & "%"
                    )

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        dgvReservations.Rows.Clear()

                        While reader.Read()

                            dgvReservations.Rows.Add(
                                reader("res_id"),
                                reader("res_code"),
                                reader("guest_name"),
                                reader("room_number"),
                                reader("res_status"),
                                Convert.ToDateTime(reader("check_in")).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(reader("check_out")).ToString("yyyy-MM-dd"),
                                reader("num_nights"),
                                Convert.ToDecimal(reader("total_amount")).ToString("N2")
                            )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error searching reservations: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click
        If dgvReservations.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a reservation to cancel.")
            Exit Sub

        End If

        Dim resID As Integer =
            Convert.ToInt32(
                dgvReservations.SelectedRows(0).Cells("colResID").Value
            )

        Dim resCode As String =
            dgvReservations.SelectedRows(0).Cells("colResCode").Value.ToString()

        Dim status As String =
            dgvReservations.SelectedRows(0).Cells("colStatus").Value.ToString()

        Dim resName As String =
            dgvReservations.SelectedRows(0).Cells("colGuest").Value.ToString()

        If status = "Canceled" Then

            MessageBox.Show("This reservation is already canceled.")
            Exit Sub

        End If

        If status = "Check-Out" Then

            MessageBox.Show("A checked-out reservation cannot be canceled.")
            Exit Sub

        End If

        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to cancel the reservation of " &
                resName & "?",
                "Cancel Reservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

        If answer <> DialogResult.Yes Then Exit Sub

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "UPDATE reservation " &
                    "SET res_status = 'Canceled' " &
                    "WHERE res_id = @resID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@resID", resID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Reservation canceled successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadReservations()

        Catch ex As Exception

            MessageBox.Show(
                "Error canceling reservation: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvReservations.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a reservation to edit.")
            Exit Sub

        End If

        Dim resID As Integer =
        Convert.ToInt32(
            dgvReservations.SelectedRows(0).Cells("colResID").Value
        )

        Dim editReservation As New Reservation(resID)

        If editReservation.ShowDialog() = DialogResult.OK Then
            LoadReservations()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvReservations.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a reservation to delete.")
            Exit Sub

        End If

        Dim resID As Integer =
            Convert.ToInt32(
                dgvReservations.SelectedRows(0).Cells("colResID").Value
            )

        Dim resCode As String =
            dgvReservations.SelectedRows(0).Cells("colResCode").Value.ToString()

        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to permanently delete reservation " &
                resCode & "?",
                "Delete Reservation",
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
                    "DELETE FROM reservation " &
                    "WHERE res_id = @resID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@resID", resID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Reservation deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadReservations()

        Catch ex As MySqlException

            If ex.Number = 1451 Then

                MessageBox.Show(
                    "This reservation cannot be deleted because it has related payment records.",
                    "Cannot Delete",
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
                "Error deleting reservation: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try
    End Sub
End Class