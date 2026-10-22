Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        ' Checks if Current User is Admin
        If CurrentUser.Role <> "Admin" Then
            MessageBox.Show("Access Denied. Admin privileges required.", 
                            "Security Error", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Stop)
            Me.Close()
            Exit Sub
        End If
        
        ' Set the window title to show who is logged in
        Me.Text = "Admin Dashboard - Logged in as: " & CurrentUser.Username
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        Dim rooms As New RoomForm()
        rooms.ShowDialog()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staff As New StaffManagementForm()
        staff.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        'Dim reports As New ReportsForm()
        'reports.ShowDialog()
    End Sub

End Class
