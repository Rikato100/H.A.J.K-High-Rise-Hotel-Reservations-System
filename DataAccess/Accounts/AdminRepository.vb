Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class AdminRepository

    ' FULL RESET
    Public Function FactoryReset() As Boolean
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' 1. Delete Payments (Child of reservation)
                    Using cmd As New MySqlCommand("DELETE FROM payment", conn, transaction)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 2. Delete Reservations
                    Using cmd As New MySqlCommand("DELETE FROM reservation", conn, transaction)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 3. Delete Guests
                    Using cmd As New MySqlCommand("DELETE FROM guest", conn, transaction)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 4. Reset Rooms to Available (Using your ENUM column)
                    Using cmd As New MySqlCommand("UPDATE room SET room_status = 'Available'", conn, transaction)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 5. Delete all Staff EXCEPT the logged-in Admin
                    Using cmd As New MySqlCommand("DELETE FROM account WHERE account_id != @CurrentID", conn, transaction)
                        cmd.Parameters.AddWithValue("@CurrentID", CurrentUser.AccountId)
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    Return True
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Reset failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' SELECTIVE RESET (By Date Range)
    Public Function SelectiveReset(startDate As Date, endDate As Date) As Boolean
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' Delete Payments linked to reservations within the date range
                    Dim queryPay As String = "DELETE p FROM payment p INNER JOIN reservation r ON p.res_id = r.res_id WHERE r.check_out BETWEEN @start AND @end"
                    Using cmd As New MySqlCommand(queryPay, conn, transaction)
                        cmd.Parameters.AddWithValue("@start", startDate)
                        cmd.Parameters.AddWithValue("@end", endDate)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Delete Reservations within the date range
                    Dim queryRes As String = "DELETE FROM reservation WHERE check_out BETWEEN @start AND @end"
                    Using cmd As New MySqlCommand(queryRes, conn, transaction)
                        cmd.Parameters.AddWithValue("@start", startDate)
                        cmd.Parameters.AddWithValue("@end", endDate)
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    Return True
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Selective reset failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

End Class