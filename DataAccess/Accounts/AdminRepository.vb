Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class AdminRepository

    ' ==========================================
    ' FACTORY RESET
    ' ==========================================
    Public Function FactoryReset() As Boolean
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' 1. Delete Payments
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

                    ' 4. Reset Rooms to Available
                    Using cmd As New MySqlCommand("UPDATE room SET room_status = 'Available'", conn, transaction)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 5. FIX: Unlink discounts from other admins to prevent foreign key crash
                    Using unlinkCmd As New MySqlCommand("UPDATE discount SET created_by = @CurrentID WHERE created_by != @CurrentID", conn, transaction)
                        unlinkCmd.Parameters.AddWithValue("@CurrentID", CurrentUser.AccountID)
                        unlinkCmd.ExecuteNonQuery()
                    End Using

                    ' 6. Delete all Staff EXCEPT the logged-in Admin
                    Using cmd As New MySqlCommand("DELETE FROM account WHERE account_id != @CurrentID", conn, transaction)
                        cmd.Parameters.AddWithValue("@CurrentID", CurrentUser.AccountID)
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

    ' ==========================================
    ' SELECTIVE RESET (By Checkboxes)
    ' ==========================================
    Public Function SelectiveResetByCheckboxes(startDate As Date, endDate As Date, purgeGuestHistory As Boolean, purgeFinancials As Boolean, resetRooms As Boolean) As Boolean
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' 1. Delete Financials (Payments & Reservations)
                    If purgeFinancials Then
                        ' Delete payments first (Child table)
                        Dim qPay As String = "DELETE p FROM payment p INNER JOIN reservation r ON p.res_id = r.res_id WHERE r.check_out BETWEEN @start AND @end"
                        Using cmd As New MySqlCommand(qPay, conn, transaction)
                            cmd.Parameters.AddWithValue("@start", startDate)
                            cmd.Parameters.AddWithValue("@end", endDate)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Delete reservations
                        Dim qRes As String = "DELETE FROM reservation WHERE check_out BETWEEN @start AND @end"
                        Using cmd As New MySqlCommand(qRes, conn, transaction)
                            cmd.Parameters.AddWithValue("@start", startDate)
                            cmd.Parameters.AddWithValue("@end", endDate)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' 2. Delete Guest History (Guests who have no reservations left)
                    If purgeGuestHistory Then
                        ' Delete guests that don't have any active reservations to prevent foreign key errors
                        Dim qGuest As String = "DELETE FROM guest WHERE guest_id NOT IN (SELECT guest_id FROM reservation)"
                        Using cmd As New MySqlCommand(qGuest, conn, transaction)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' 3. Reset Room Statuses
                    If resetRooms Then
                        Dim qRooms As String = "UPDATE room SET room_status = 'Available'"
                        Using cmd As New MySqlCommand(qRooms, conn, transaction)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

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
