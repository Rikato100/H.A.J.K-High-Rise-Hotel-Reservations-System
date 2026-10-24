Public Class StaffDashboard
    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim login As New loginForm()
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Dim rooms As New RoomForm
        rooms.ShowDialog
    End Sub

    Private Sub btnGuests_Click(sender As Object, e As EventArgs) Handles btnGuests.Click
        Me.Controls.Clear()

        Dim guests As New GuestForm
        guests.TopLevel = False
        guests.FormBorderStyle = FormBorderStyle.None
        guests.Dock = DockStyle.Fill

        Me.Controls.Add(guests)
        guests.Show()


        'guests.ShowDialog()
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        Me.Controls.Clear()

        Dim reservations As New ReservationListForm()
        reservations.TopLevel = False
        reservations.FormBorderStyle = FormBorderStyle.None
        reservations.Dock = DockStyle.Fill

        Me.Controls.Add(reservations)
        reservations.Show()
        'reservations.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        MessageBox.Show("Design not done yet.")
    End Sub
End Class