Imports System.Data.SqlTypes
Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadView(New DashboardHomeControl())
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
        Me.Text = "Logged in as: " & CurrentUser.Username
    End Sub

    ' Helper method to swap views seamlessly inside pnlContent without losing the title bar or sidebar
    Public Sub LoadView(userControl As UserControl)
        pnlContent.Controls.Clear()
        userControl.Dock = DockStyle.Fill
        pnlContent.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SessionHelper.Logout()
        End If
    End Sub

    ' Navigation: Switch content cleanly inside pnlContent instead of opening a separate popup window
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadView(New DashboardHomeControl())
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        LoadView(New RoomControl())
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        LoadView(New StaffManagementControl())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        LoadView(New ReportsControl())
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        LoadView(New SettingsControl())
    End Sub
End Class