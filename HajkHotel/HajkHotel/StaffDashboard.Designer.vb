<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDashboard
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
        btnLogout = New Button()
        btnPayments = New Button()
        btnGuests = New Button()
        btnReset = New Button()
        btnReports = New Button()
        btnReservations = New Button()
        btnRooms = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(233, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 30)
        Label1.TabIndex = 1
        Label1.Text = "H.A.J.K. Hotel Reservation System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(320, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 30)
        Label2.TabIndex = 2
        Label2.Text = "Welcome Staff!"
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(421, 232)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(103, 40)
        btnLogout.TabIndex = 16
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnPayments
        ' 
        btnPayments.Location = New Point(421, 176)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(103, 40)
        btnPayments.TabIndex = 15
        btnPayments.Text = "PAYMENTS"
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' btnGuests
        ' 
        btnGuests.Location = New Point(421, 120)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(103, 40)
        btnGuests.TabIndex = 14
        btnGuests.Text = "GUESTS"
        btnGuests.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(277, 290)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(104, 40)
        btnReset.TabIndex = 13
        btnReset.Text = "SYSTEM" & vbCrLf & "RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(277, 232)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(104, 40)
        btnReports.TabIndex = 12
        btnReports.Text = "REPORTS"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnReservations
        ' 
        btnReservations.Location = New Point(277, 176)
        btnReservations.Name = "btnReservations"
        btnReservations.Size = New Size(104, 40)
        btnReservations.TabIndex = 11
        btnReservations.Text = "RESERVATIONS"
        btnReservations.UseVisualStyleBackColor = True
        ' 
        ' btnRooms
        ' 
        btnRooms.Location = New Point(277, 120)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(104, 40)
        btnRooms.TabIndex = 10
        btnRooms.Text = "ROOMS"
        btnRooms.UseVisualStyleBackColor = True
        ' 
        ' StaffDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogout)
        Controls.Add(btnPayments)
        Controls.Add(btnGuests)
        Controls.Add(btnReset)
        Controls.Add(btnReports)
        Controls.Add(btnReservations)
        Controls.Add(btnRooms)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "StaffDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "H.A.J.K. - Staff Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnRooms As Button
End Class
