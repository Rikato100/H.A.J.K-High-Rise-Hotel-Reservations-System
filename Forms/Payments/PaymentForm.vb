Imports MySql.Data.MySqlClient

Public Class PaymentForm

    Private resID As Integer
    Private totalAmount As Decimal

    ' We pass the Reservation ID and Total Amount when opening this form
    Public Sub New(reservationID As Integer, guestName As String, total As Decimal)
        InitializeComponent()
        resID = reservationID
        totalAmount = total
        lblGuestName.Text = "Guest: " & guestName
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMethod.Items.Clear()
        cmbMethod.Items.Add("Cash")
        cmbMethod.Items.Add("GCash")
        cmbMethod.Items.Add("Maya")
        cmbMethod.Items.Add("PayPal")
        cmbMethod.Items.Add("Card")
        cmbMethod.Items.Add("Bank Transfer")
        cmbMethod.SelectedIndex = 0

        lblTotalAmount.Text = "₱" & totalAmount.ToString("N2")
        UpdateBalance()
    End Sub

    Private Sub UpdateBalance()
    Dim totalPaid As Decimal = 0
    Try
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand("SELECT IFNULL(SUM(amount), 0) FROM payment WHERE res_id = @resID", conn)
                cmd.Parameters.AddWithValue("@resID", resID)
                totalPaid = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
    Catch ex As Exception
        MessageBox.Show("Error checking balance: " & ex.Message)
    End Try

    Dim balance As Decimal = totalAmount - totalPaid

    lblTotalPaid.Text = "₱" & totalPaid.ToString("N2")
    lblBalance.Text = "₱" & balance.ToString("N2")

    ' Auto-fill the amount textbox with the remaining balance
    txtAmount.Text = balance.ToString("N2")
End Sub

Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.DialogResult = DialogResult.Cancel
    Me.Close()
End Sub

End Class
