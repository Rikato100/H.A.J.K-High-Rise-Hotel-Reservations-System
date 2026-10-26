<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffDashboardHomeControl
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LabelWelcome = New Label()
        lblSubtitle = New Label()
        SuspendLayout()
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.AutoSize = True
        LabelWelcome.Font = New Font("Mongolian Baiti", 17.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelWelcome.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        LabelWelcome.Location = New Point(24, 20)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(245, 24)
        LabelWelcome.TabIndex = 0
        LabelWelcome.Text = "Welcome, Receptionist!"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(89), CByte(15), CByte(27))
        lblSubtitle.Location = New Point(24, 52)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(325, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage reservations, check-ins, and guest profiles efficiently."
        ' 
        ' StaffDashboardHomeControl
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(232), CByte(210))
        Controls.Add(lblSubtitle)
        Controls.Add(LabelWelcome)
        Name = "StaffDashboardHomeControl"
        Size = New Size(1032, 667)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelWelcome As Label
    Friend WithEvents lblSubtitle As Label
End Class