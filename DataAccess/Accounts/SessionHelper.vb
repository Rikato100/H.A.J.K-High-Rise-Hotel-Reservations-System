Public Module SessionHelper
    Public Sub Logout()
        ' 1. Clear the current user
        CurrentUser.AccountID = 0
        CurrentUser.Role = ""
        CurrentUser.Username = ""

        ' 2. Find and show the original login form
        Dim login As loginForm = Nothing
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is loginForm Then
                login = CType(frm, loginForm)
                Exit For
            End If
        Next

        ' If for some reason it's missing, create a new one
        If login Is Nothing Then
            login = New loginForm()
        End If

        ' 3. Show it before closing the current forms
        login.Show()
        login.txtPassword.Clear()
        login.Activate()

        ' 4. Close every other form EXCEPT the login form
        For Each frm As Form In Application.OpenForms.Cast(Of Form)().ToList()
            If Not TypeOf frm Is loginForm Then
                frm.Hide() ' Hide it so it doesn't trigger FormClosing events again
                frm.Dispose() ' Actually destroy it
            End If
        Next
    End Sub

    Public Sub GoToDashboard()
        ' Open the appropriate dashboard based on the logged-in user's role
        If CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            Dim adminDash As New AdminDashboard()
            adminDash.Show()
        Else
            Dim staffDash As New StaffDashboard()
            staffDash.Show()
        End If

        ' Close the current form that triggered the navigation if needed
    End Sub

End Module
