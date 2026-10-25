Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class AdminRepository

    ' Text shown to the admin after a reset (what was removed / changed)
    Public Property LastSummary As String = ""

    ' ==========================================
    ' FACTORY RESET
    ' Wipes transaction history, guest records and resets every room to Available.
    ' Staff/admin accounts and discount settings are kept.
    ' ==========================================
    Public Function FactoryReset() As Boolean
        LastSummary = ""
        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    Dim payments As Integer = Run(conn, transaction, "DELETE FROM payment")
                    Dim reservations As Integer = Run(conn, transaction, "DELETE FROM reservation")
                    Dim guests As Integer = Run(conn, transaction, "DELETE FROM guest")
                    Dim rooms As Integer = Run(conn, transaction, "UPDATE room SET room_status = 'Available'")

                    transaction.Commit()

                    LastSummary =
                        "Payments deleted: " & payments & vbCrLf &
                        "Reservations deleted: " & reservations & vbCrLf &
                        "Guests deleted: " & guests & vbCrLf &
                        "Rooms set to Available: " & rooms
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
    ' SELECTIVE RESET (date range + checkboxes)
    '  - Financials:    payments made between the two dates
    '  - Guest history: finished reservations (Check-Out, Canceled, No-Show) that ended
    '                   between the two dates, and guests left with no reservations
    '  - Rooms:         Occupied rooms with nobody checked in become Available
    ' Everything runs in ONE transaction: all or nothing.
    ' ==========================================
    Public Function SelectiveResetByCheckboxes(startDate As Date, endDate As Date, purgeGuestHistory As Boolean, purgeFinancials As Boolean, resetRooms As Boolean) As Boolean
        LastSummary = ""
        Dim dStart As Date = startDate.Date
        Dim dEnd As Date = endDate.Date

        Using conn As MySqlConnection = DbConnection.GetConnection()
            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    Dim lines As New List(Of String)()

                    ' 1. Financial and billing transactions (by payment date)
                    If purgeFinancials Then
                        Dim n As Integer = Run(conn, transaction,
                            "DELETE FROM payment WHERE DATE(payment_date) BETWEEN @start AND @end",
                            dStart, dEnd)
                        lines.Add("Payments deleted: " & n)
                    End If

                    ' 2. Guest history (finished stays only, by check-out date)
                    If purgeGuestHistory Then
                        Const finished As String = "res_status IN ('Check-Out', 'Canceled', 'No-Show')"

                        ' remember which guests are affected
                        Dim guestIds As New List(Of Integer)()
                        Using cmd As New MySqlCommand(
                            "SELECT DISTINCT guest_id FROM reservation WHERE " & finished &
                            " AND check_out BETWEEN @start AND @end", conn, transaction)
                            cmd.Parameters.AddWithValue("@start", dStart)
                            cmd.Parameters.AddWithValue("@end", dEnd)
                            Using reader As MySqlDataReader = cmd.ExecuteReader()
                                While reader.Read()
                                    guestIds.Add(Convert.ToInt32(reader("guest_id")))
                                End While
                            End Using
                        End Using

                        ' payments of those reservations first (child table)
                        Run(conn, transaction,
                            "DELETE p FROM payment p INNER JOIN reservation r ON p.res_id = r.res_id " &
                            "WHERE r." & finished & " AND r.check_out BETWEEN @start AND @end",
                            dStart, dEnd)

                        Dim resCount As Integer = Run(conn, transaction,
                            "DELETE FROM reservation WHERE " & finished & " AND check_out BETWEEN @start AND @end",
                            dStart, dEnd)

                        ' remove only those guests who now have no reservations at all
                        Dim guestCount As Integer = 0
                        For Each gid As Integer In guestIds
                            Using cmd As New MySqlCommand(
                                "DELETE FROM guest WHERE guest_id = @gid " &
                                "AND NOT EXISTS (SELECT 1 FROM reservation WHERE guest_id = @gid)", conn, transaction)
                                cmd.Parameters.AddWithValue("@gid", gid)
                                guestCount += cmd.ExecuteNonQuery()
                            End Using
                        Next

                        lines.Add("Reservations deleted: " & resCount)
                        lines.Add("Guests deleted: " & guestCount)
                    End If

                    ' 3. Room statuses (never touches rooms with a guest checked in,
                    '    and leaves Out of Order / Under Maintenance alone)
                    If resetRooms Then
                        Dim n As Integer = Run(conn, transaction,
                            "UPDATE room SET room_status = 'Available' " &
                            "WHERE room_status = 'Occupied' " &
                            "AND room_id NOT IN (SELECT room_id FROM reservation WHERE res_status = 'Check-In')")
                        lines.Add("Rooms set to Available: " & n)
                    End If

                    transaction.Commit()
                    LastSummary = String.Join(vbCrLf, lines)
                    Return True
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Selective reset failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Runs one command inside the transaction and returns the number of rows changed.
    ' Pass start/end dates only if the SQL uses @start and @end.
    Private Function Run(conn As MySqlConnection, transaction As MySqlTransaction, sql As String,
                         Optional startDate As Date? = Nothing, Optional endDate As Date? = Nothing) As Integer
        Using cmd As New MySqlCommand(sql, conn, transaction)
            If startDate.HasValue Then cmd.Parameters.AddWithValue("@start", startDate.Value)
            If endDate.HasValue Then cmd.Parameters.AddWithValue("@end", endDate.Value)
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

End Class
