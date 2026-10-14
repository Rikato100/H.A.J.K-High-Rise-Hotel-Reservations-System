Imports MySql.Data.MySqlClient

Public Class RoomForm

    Private Sub RoomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRooms()
    End Sub


    ' =========================
    ' LOAD ROOMS
    ' =========================
    Private Sub LoadRooms()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT r.room_id, r.room_number, rt.type_name, " &
                    "r.floor, r.room_status, rt.base_rate " &
                    "FROM room r " &
                    "INNER JOIN room_type rt ON r.room_type_id = rt.room_type_id " &
                    "ORDER BY r.room_number"

                Using cmd As New MySqlCommand(query, conn)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        dgvRooms.Rows.Clear()

                        While reader.Read()

                            dgvRooms.Rows.Add(
                                reader("room_id"),
                                reader("room_number"),
                                reader("type_name"),
                                reader("floor"),
                                reader("room_status"),
                                reader("base_rate")
                            )

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading rooms: " & ex.Message)

        End Try

    End Sub


    ' =========================
    ' ADD ROOM
    ' =========================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim addRoom As New AddRoomForm()

        If addRoom.ShowDialog() = DialogResult.OK Then

            LoadRooms()

        End If

    End Sub


    ' =========================
    ' EDIT ROOM
    ' =========================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If dgvRooms.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a room to edit.")

            Exit Sub

        End If


        ' Get the Room ID from the selected row
        Dim roomID As Integer =
            Convert.ToInt32(
                dgvRooms.SelectedRows(0).Cells("colRoomID").Value
            )


        ' IMPORTANT:
        ' Pass the Room ID to AddRoomForm
        Dim editRoom As New AddRoomForm(roomID)


        If editRoom.ShowDialog() = DialogResult.OK Then

            LoadRooms()

        End If

    End Sub


    ' =========================
    ' DELETE ROOM
    ' =========================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvRooms.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a room to delete.")

            Exit Sub

        End If


        Dim roomID As Integer =
            Convert.ToInt32(
                dgvRooms.SelectedRows(0).Cells("colRoomID").Value
            )


        Dim roomNumber As String =
            dgvRooms.SelectedRows(0).Cells("colRoomNumber").Value.ToString()


        ' Confirmation
        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to delete Room " & roomNumber & "?",
                "Delete Room",
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
                    "DELETE FROM room WHERE room_id = @roomID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@roomID", roomID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using


            MessageBox.Show(
                "Room deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            ' Refresh the table
            LoadRooms()


        Catch ex As MySqlException

            ' Room is being used by a reservation
            If ex.Number = 1451 Then

                MessageBox.Show(
                    "This room cannot be deleted because it is connected to an existing reservation.",
                    "Cannot Delete Room",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Else

                MessageBox.Show(
                    "Database error: " & ex.Message
                )

            End If


        Catch ex As Exception

            MessageBox.Show(
                "Error deleting room: " & ex.Message
            )

        End Try

    End Sub


    ' =========================
    ' REFRESH
    ' =========================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadRooms()

    End Sub


    ' =========================
    ' BACK
    ' =========================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

End Class