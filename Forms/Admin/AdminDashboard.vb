Imports MySql.Data.MySqlClient

Public Class AdminDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Dim rooms As New RoomForm()
        rooms.ShowDialog()
    End Sub
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        ' Fixed: Updated from StaffManagementForm to StaffManagement
        Dim staff As New StaffManagementForm()
        staff.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        'Dim reports As New ReportsForm()
        'reports.ShowDialog()
    End Sub
End Class