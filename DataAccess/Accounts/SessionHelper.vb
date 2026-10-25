Public Module SessionHelper
    Public Sub Logout()
        ' Reuse the original (hidden) login form instead of making a new one
        Dim login As loginForm = Application.OpenForms.OfType(Of loginForm)().FirstOrDefault()
        If login Is Nothing Then login = New loginForm()

        ' Close everything that is not the login form
        For Each frm As Form In Application.OpenForms.Cast(Of Form).ToList()
            If Not TypeOf frm Is loginForm Then frm.Close()
        Next

        CurrentUser.AccountID = 0
        CurrentUser.Role = ""
        CurrentUser.Username = ""

        login.txtPassword.Clear()
        login.Show()
        login.Activate()
    End Sub
End Module