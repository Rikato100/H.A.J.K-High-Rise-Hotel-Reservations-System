
Imports MySql.Data.MySqlClient

Public Class PaymentForm

    Private resID As Integer
    Private totalAmount As Decimal
    Private selectedPaymentMethod As String
    Private referenceNumber As String

    ' Receive reservation details and payment information
    Public Sub New(reservationID As Integer,
                   guestName As String,
                   total As Decimal,
                   paymentMethod As String,
                   referenceNo As String)

        InitializeComponent()

        resID = reservationID
        totalAmount = total
        selectedPaymentMethod = paymentMethod
        referenceNumber = referenceNo

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

        ' Automatically select the payment method from Reservation
        If cmbMethod.Items.Contains(selectedPaymentMethod) Then
            cmbMethod.SelectedItem = selectedPaymentMethod
        Else
            cmbMethod.SelectedIndex = 0
        End If

        ' Automatically fill the reference number
        txtReference.Text = referenceNumber

        lblTotalAmount.Text = "₱" & totalAmount.ToString("N2")

        UpdateBalance()

    End Sub

    Private Sub UpdateBalance()

        Dim totalPaid As Decimal = 0

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(
                    "SELECT IFNULL(SUM(amount), 0) FROM payment WHERE res_id = @resID", conn)

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

        Dim totalPaid As Decimal = 0

        Try
            Using conn As MySqlConnection = DbConnection.GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(
                    "SELECT IFNULL(SUM(amount), 0) FROM payment WHERE res_id = @resID", conn)

                    cmd.Parameters.AddWithValue("@resID", resID)
                    totalPaid = Convert.ToDecimal(cmd.ExecuteScalar())

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error checking balance: " & ex.Message)
            Exit Sub
        End Try

        Dim remainingBalance As Decimal = totalAmount - totalPaid

        If amountPaid > remainingBalance Then
            MessageBox.Show(
                "The amount exceeds the remaining balance of ₱" &
                remainingBalance.ToString("N2") & ".",
                "Overpayment Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub
        End If

        If cmbMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please select a payment method.")
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

            MessageBox.Show(
                "Payment recorded successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(
                "Error saving payment: " & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' Constructor for processing payments from Reservation List
    Public Sub New(reservationID As Integer, guestName As String, total As Decimal)
        Me.New(reservationID, guestName, total, "Cash", "")
    End Sub

End Class
