Public Class frmRoomTypes
    Private Sub FrmRoomTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvRoomTypes.Rows.Add(
        "Standard Room",
        "18 m²",
        "2",
        "3",
        "₱2,500"
    )

        dgvRoomTypes.Rows.Add(
        "Deluxe Room",
        "24 m²",
        "2",
        "4",
        "₱3,500"
    )

        dgvRoomTypes.Rows.Add(
        "Superior Room",
        "28 m²",
        "2",
        "4",
        "₱4,000"
    )

        dgvRoomTypes.Rows.Add(
        "Family Room",
        "35 m²",
        "4",
        "6",
        "₱5,500"
    )

        dgvRoomTypes.Rows.Add(
        "Suite Room",
        "50 m²",
        "2",
        "4",
        "₱8,000"
    )

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoomTypes.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class