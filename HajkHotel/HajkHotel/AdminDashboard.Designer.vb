<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        btnRooms = New Button()
        btnReservations = New Button()
        btnReports = New Button()
        btnReset = New Button()
        btnGuests = New Button()
        btnPayments = New Button()
        btnStaff = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(232, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 30)
        Label1.TabIndex = 0
        Label1.Text = "H.A.J.K. Hotel Reservation System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(312, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 30)
        Label2.TabIndex = 1
        Label2.Text = "Welcome Admin!"
        ' 
        ' btnRooms
        ' 
        btnRooms.Location = New Point(276, 142)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(104, 40)
        btnRooms.TabIndex = 2
        btnRooms.Text = "ROOMS"
        btnRooms.UseVisualStyleBackColor = True
        ' 
        ' btnReservations
        ' 
        btnReservations.Location = New Point(276, 198)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(104, 40)
        btnReservations.TabIndex = 3
        btnReservations.Text = "RESERVATIONS"
        btnReservations.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(276, 254)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(104, 40)
        btnReports.TabIndex = 4
        btnReports.Text = "REPORTS"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(276, 312)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(104, 40)
        btnReset.TabIndex = 5
        btnReset.Text = "SYSTEM" & vbCrLf & "RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnGuests
        ' 
        btnGuests.Location = New Point(420, 142)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(103, 40)
        btnGuests.TabIndex = 6
        btnGuests.Text = "GUESTS"
        btnGuests.UseVisualStyleBackColor = True
        ' 
        ' btnPayments
        ' 
        btnPayments.Location = New Point(420, 198)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(103, 40)
        btnPayments.TabIndex = 7
        btnPayments.Text = "PAYMENTS"
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnStaff
        ' 
        btnStaff.Location = New Point(420, 254)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(103, 40)
        btnStaff.TabIndex = 8
        btnStaff.Text = "STAFF" & vbCrLf & "MANAGEMENT" & vbCrLf
        btnStaff.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(420, 312)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(103, 40)
        btnLogout.TabIndex = 9
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogout)
        Controls.Add(btnStaff)
        Controls.Add(btnPayments)
        Controls.Add(btnGuests)
        Controls.Add(btnReset)
        Controls.Add(btnReports)
        Controls.Add(btnReservations)
        Controls.Add(btnRooms)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "H.A.J.K. - Admin Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnLogout As Button
End Class
