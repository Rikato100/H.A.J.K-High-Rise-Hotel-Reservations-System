Imports MySql.Data.MySqlClient

Public Class RoomControl

    Private Sub RoomControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRooms.AllowUserToAddRows = False
        LoadRooms()
    End Sub

    ' =========================
    ' LOAD ROOMS (WITH ROOM STATUS)
    ' =========================
    Private Sub LoadRooms()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT r.room_number, rt.type_name, r.room_status, " &
                    "rt.room_size, rt.standard_capacity, rt.max_capacity, " &
                    "rt.base_rate, rt.amenities " &
                    "FROM room r " &
                    "INNER JOIN room_type rt ON r.room_type_id = rt.room_type_id " &
                    "ORDER BY r.room_number"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvRooms.Rows.Clear()

                        While reader.Read()
                            dgvRooms.Rows.Add(
                                reader("room_number"),
                                reader("type_name"),
                                reader("room_status"),
                                reader("room_size"),
                                reader("standard_capacity"),
                                reader("max_capacity"),
                                Convert.ToDecimal(reader("base_rate")).ToString("₱#,##0.00"),
                                reader("amenities")
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

        Dim roomNumber As String = dgvRooms.SelectedRows(0).Cells("colRoomNumber").Value.ToString()
        Dim editRoom As New AddRoomForm(roomNumber)

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

        Dim roomNumber As String = dgvRooms.SelectedRows(0).Cells("colRoomNumber").Value.ToString()

        Dim answer As DialogResult = MessageBox.Show(
            "Are you sure you want to delete Room " & roomNumber & "?",
            "Delete Room",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If answer <> DialogResult.Yes Then Exit Sub

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM room WHERE room_number = @roomNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRooms()

        Catch ex As MySqlException
            If ex.Number = 1451 Then
                MessageBox.Show("This room cannot be deleted because it is connected to an existing reservation.", "Cannot Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Database error: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting room: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' REFRESH
    ' =========================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRooms()
    End Sub

End Class
