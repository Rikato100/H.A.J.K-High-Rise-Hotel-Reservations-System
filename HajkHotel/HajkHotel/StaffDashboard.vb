Public Class StaffDashboard
    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Dim rooms As New RoomForm()
        rooms.ShowDialog()
    End Sub

    Private Sub btnGuests_Click(sender As Object, e As EventArgs) Handles btnGuests.Click
        Dim guests As New GuestForm()

        guests.ShowDialog()
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        Dim reservations As New ReservationListForm()
        reservations.ShowDialog()
    End Sub
End Class