Imports MySql.Data.MySqlClient
Imports System.Data

Public Class AddRoomForm

    Private roomID As Integer = 0


    Public Sub New()

        InitializeComponent()

        roomID = 0

    End Sub


    Public Sub New(id As Integer)

        InitializeComponent()

        roomID = id

    End Sub

    Private Sub AddRoomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRoomTypes()
        LoadStatuses()

        If roomID <> 0 Then

            Me.Text = "Edit Room"
            lblTitle.Text = "Edit Room"

            LoadRoomData()

        Else

            Me.Text = "Add Room"
            lblTitle.Text = "Add Room"

        End If

    End Sub


    Private Sub LoadRoomTypes()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT room_type_id, type_name " &
                    "FROM room_type " &
                    "ORDER BY room_type_id"

                Using adapter As New MySqlDataAdapter(query, conn)

                    Dim table As New DataTable()

                    adapter.Fill(table)

                    cmbRoomType.DataSource = table
                    cmbRoomType.DisplayMember = "type_name"
                    cmbRoomType.ValueMember = "room_type_id"

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading room types: " & ex.Message)

        End Try

    End Sub


    Private Sub LoadStatuses()

        cmbStatus.Items.Clear()

        cmbStatus.Items.Add("Available")
        cmbStatus.Items.Add("Occupied")
        cmbStatus.Items.Add("Out of Order")
        cmbStatus.Items.Add("Under Maintenance")

        cmbStatus.SelectedIndex = 0

    End Sub

    Private Sub LoadRoomData()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT room_number, room_type_id, floor, " &
                    "room_status, amenities " &
                    "FROM room " &
                    "WHERE room_id = @roomID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@roomID", roomID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            txtRoomNumber.Text =
                                reader("room_number").ToString()

                            numFloor.Value =
                                Convert.ToDecimal(reader("floor"))

                            txtAmenities.Text =
                                reader("amenities").ToString()

                            cmbRoomType.SelectedValue =
                                Convert.ToInt32(reader("room_type_id"))

                            cmbStatus.SelectedItem =
                                reader("room_status").ToString()

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading room: " & ex.Message)

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtRoomNumber.Text.Trim() = "" Then

            MessageBox.Show("Please enter the room number.")
            Exit Sub

        End If


        If cmbRoomType.SelectedIndex = -1 Then

            MessageBox.Show("Please select a room type.")
            Exit Sub

        End If


        If cmbStatus.SelectedIndex = -1 Then

            MessageBox.Show("Please select a room status.")
            Exit Sub

        End If


        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String

                If roomID = 0 Then

                    query =
                        "INSERT INTO room " &
                        "(room_type_id, room_number, floor, room_status, amenities) " &
                        "VALUES " &
                        "(@roomTypeID, @roomNumber, @floor, @status, @amenities)"

                Else

                    query =
                        "UPDATE room SET " &
                        "room_type_id = @roomTypeID, " &
                        "room_number = @roomNumber, " &
                        "floor = @floor, " &
                        "room_status = @status, " &
                        "amenities = @amenities " &
                        "WHERE room_id = @roomID"

                End If


                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                        "@roomTypeID",
                        cmbRoomType.SelectedValue
                    )

                    cmd.Parameters.AddWithValue(
                        "@roomNumber",
                        txtRoomNumber.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@floor",
                        numFloor.Value
                    )

                    cmd.Parameters.AddWithValue(
                        "@status",
                        cmbStatus.Text
                    )

                    cmd.Parameters.AddWithValue(
                        "@amenities",
                        txtAmenities.Text.Trim()
                    )


                    If roomID <> 0 Then

                        cmd.Parameters.AddWithValue(
                            "@roomID",
                            roomID
                        )

                    End If


                    cmd.ExecuteNonQuery()

                End Using

            End Using

            If roomID = 0 Then

                MessageBox.Show(
                    "Room added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Else

                MessageBox.Show(
                    "Room updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If


            Me.DialogResult = DialogResult.OK

            Me.Close()


        Catch ex As MySqlException

            If ex.Number = 1062 Then

                MessageBox.Show(
                    "That room number already exists.",
                    "Duplicate Room",
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
                "Error: " & ex.Message
            )

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel

        Me.Close()

    End Sub

End Class