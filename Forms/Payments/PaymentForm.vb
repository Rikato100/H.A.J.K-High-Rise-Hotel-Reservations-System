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
                Using cmd As New MySqlCommand("SELECT SUM(amount) FROM payment WHERE res_id = @resID", conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        totalPaid = Convert.ToDecimal(result)
                    End If
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Please enter an amount.")
            Exit Sub
        End If

        Dim amountPaid As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amountPaid) Then
            MessageBox.Show("Please enter a valid number for the amount.")
            Exit Sub
        End If

        If amountPaid <= 0 Then
            MessageBox.Show("Amount must be greater than zero.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Dim query As String =
                    "INSERT INTO payment (res_id, amount, payment_method, reference_no) " &
                    "VALUES (@resID, @amount, @method, @refNo)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@resID", resID)
                    cmd.Parameters.AddWithValue("@amount", amountPaid)
                    cmd.Parameters.AddWithValue("@method", cmbMethod.Text)

                    If String.IsNullOrWhiteSpace(txtReference.Text) Then
                        cmd.Parameters.AddWithValue("@refNo", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@refNo", txtReference.Text.Trim())
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Payment recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving payment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class