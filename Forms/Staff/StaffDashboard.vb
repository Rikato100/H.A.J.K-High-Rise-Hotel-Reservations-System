Imports System.Data.SqlTypes

Public Class StaffDashboard

    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if current user is Staff/Receptionist or Admin
        If CurrentUser.Role <> "Staff" AndAlso CurrentUser.Role <> "Admin" Then
            MessageBox.Show("Access Denied. Staff privileges required.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
            Exit Sub
        End If

        Me.Text = "Logged in as: " & CurrentUser.Username

        ' Sidebar tab order (top to bottom)
        btnDashboard.TabIndex = 0
        btnReservations.TabIndex = 1
        btnGuests.TabIndex = 2
        btnSettings.TabIndex = 3
        btnLogout.TabIndex = 4

        ' Load default home view inside pnlContent
        LoadView(New StaffDashboardHomeControl())
    End Sub

    ' Helper method to swap views seamlessly inside pnlContent without losing sidebar or header
    Public Sub LoadView(userControl As UserControl)
        pnlContent.Controls.Clear()
        userControl.Dock = DockStyle.Fill
        pnlContent.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadView(New StaffDashboardHomeControl())
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        LoadView(New ReservationListControl())
    End Sub

    Private Sub btnGuests_Click(sender As Object, e As EventArgs) Handles btnGuests.Click
        LoadView(New GuestControl())
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        LoadView(New SettingsControl())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SessionHelper.Logout()
        End If
    End Sub

End Class
