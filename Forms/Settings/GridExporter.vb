Imports System.IO
Imports System.Text

' Exports a DataGridView to a CSV file that opens in Excel.
' Usage:  GridExporter.ExportToCsv(dgvReservations, "Reservations")
Public Class GridExporter

    Public Shared Sub ExportToCsv(grid As DataGridView, defaultName As String)
        If grid.Rows.Count = 0 Then
            MessageBox.Show("There is nothing to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Using dlg As New SaveFileDialog()
            dlg.Filter = "Excel-compatible CSV (*.csv)|*.csv"
            dlg.FileName = defaultName & "_" & DateTime.Now.ToString("yyyyMMdd_HHmm") & ".csv"

            If dlg.ShowDialog() <> DialogResult.OK Then Exit Sub

            Try
                Dim sb As New StringBuilder()

                ' Header row (visible columns only)
                Dim headers As New List(Of String)
                For Each col As DataGridViewColumn In grid.Columns
                    If col.Visible Then headers.Add(Escape(col.HeaderText))
                Next
                sb.AppendLine(String.Join(",", headers))

                ' Data rows, exactly as shown in the grid
                For Each row As DataGridViewRow In grid.Rows
                    If row.IsNewRow Then Continue For
                    Dim cells As New List(Of String)
                    For Each col As DataGridViewColumn In grid.Columns
                        If col.Visible Then
                            Dim v As Object = row.Cells(col.Index).Value
                            cells.Add(Escape(If(v Is Nothing, "", v.ToString())))
                        End If
                    Next
                    sb.AppendLine(String.Join(",", cells))
                Next

                ' UTF-8 with BOM so Excel reads symbols correctly
                File.WriteAllText(dlg.FileName, sb.ToString(), New UTF8Encoding(True))

                MessageBox.Show("Exported to:" & vbCrLf & dlg.FileName, "Export complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As IOException
                MessageBox.Show("Could not save the file. If it is open in Excel, close it and try again." & vbCrLf & ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Export failed: " & ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Shared Function Escape(value As String) As String
        If value.Contains(",") OrElse value.Contains("""") OrElse value.Contains(vbCr) OrElse value.Contains(vbLf) Then
            Return """" & value.Replace("""", """""") & """"
        End If
        Return value
    End Function

End Class
