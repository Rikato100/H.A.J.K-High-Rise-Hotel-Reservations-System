Imports MySql.Data.MySqlClient

Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Dim rooms As New RoomForm()
        rooms.ShowDialog()
    End Sub

    Private Sub btnGuests_Click(sender As Object, e As EventArgs)
        Dim guests As New GuestForm
        guests.ShowDialog
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs)
        Dim reservations As New ReservationListForm
        reservations.ShowDialog
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs)
        'Dim payments As New PaymentsForm()
        'payments.ShowDialog()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        ' Fixed: Updated from StaffManagementForm to StaffManagement
        Dim staff As New StaffManagement()
        staff.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs)
        'Dim reports As New ReportsForm()
        'reports.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class