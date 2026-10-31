
Imports MySql.Data.MySqlClient

Public Class GuestStayHistoryForm

    Private selectedGuestID As Integer
    Private selectedGuestName As String

    ' Receive the selected guest's information
    Public Sub New(guestID As Integer, guestName As String)
        InitializeComponent()

        selectedGuestID = guestID
        selectedGuestName = guestName
    End Sub

    ' Load the guest's reservation history
    Private Sub LoadStayHistory()
        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT res.res_code, r.room_number, " &
                    "res.check_in, res.check_out, " &
                    "res.res_status, res.total_amount " &
                    "FROM reservation res " &
                    "INNER JOIN room r ON res.room_id = r.room_id " &
                    "WHERE res.guest_id = @guestID " &
                    "ORDER BY res.check_in DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@guestID", selectedGuestID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvStayHistory.Rows.Clear()

                        While reader.Read()
                            dgvStayHistory.Rows.Add(
                                reader("res_code").ToString(),
                                reader("room_number").ToString(),
                                Convert.ToDateTime(reader("check_in")).ToString("MMM dd, yyyy"),
                                Convert.ToDateTime(reader("check_out")).ToString("MMM dd, yyyy"),
                                reader("res_status").ToString(),
                                Convert.ToDecimal(reader("total_amount")).ToString("₱#,##0.00")
                            )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error loading stay history: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    ' Display the selected guest's information
    Private Sub GuestStayHistoryForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblGuestName.Text = "Guest: " & selectedGuestName
        lblGuestID.Text = "Guest ID: " & selectedGuestID.ToString()

        LoadStayHistory()
    End Sub

    ' Close the form
    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClose.Click

        Me.Close()
    End Sub

End Class
