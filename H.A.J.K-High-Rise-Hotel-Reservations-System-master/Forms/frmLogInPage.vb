Imports System.Diagnostics.Eventing.Reader

Partial Public Class frmLogInPage

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim inputUsername As String = txtUserID.Text.Trim()
        Dim inputPassword As String = txtPassword.Text

        Dim account = AccountRepository.GetAccountByUsername(inputUsername)

        If inputUsername = "" OrElse inputPassword = "" Then
            MessageBox.Show("Please input ID and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf account Is Nothing Then
            MessageBox.Show("Account not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf account.Password <> inputPassword Then
            MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Welcome! " & txtUserID.Text, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim dash As New dashboard()
        dash.Show()
        Me.Hide()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDay.Text = DateTime.Now.ToString("dddd")
    End Sub

End Class
