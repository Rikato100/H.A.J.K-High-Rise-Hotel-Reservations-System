<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SystemResetForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpResetOptions = New System.Windows.Forms.GroupBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.radSelectiveReset = New System.Windows.Forms.RadioButton()
        Me.radFactoryReset = New System.Windows.Forms.RadioButton()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExecuteReset = New System.Windows.Forms.Button()
        Me.grpResetOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpResetOptions
        '
        Me.grpResetOptions.Controls.Add(Me.lblEndDate)
        Me.grpResetOptions.Controls.Add(Me.dtpEndDate)
        Me.grpResetOptions.Controls.Add(Me.lblStartDate)
        Me.grpResetOptions.Controls.Add(Me.dtpStartDate)
        Me.grpResetOptions.Controls.Add(Me.radSelectiveReset)
        Me.grpResetOptions.Controls.Add(Me.radFactoryReset)
        Me.grpResetOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpResetOptions.Name = "grpResetOptions"
        Me.grpResetOptions.Size = New System.Drawing.Size(400, 180)
        Me.grpResetOptions.TabIndex = 0
        Me.grpResetOptions.TabStop = False
        Me.grpResetOptions.Text = "Reset Configuration"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(200, 115)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(55, 13)
        Me.lblEndDate.TabIndex = 5
        Me.lblEndDate.Text = "End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpEndDate.Location = New System.Drawing.Point(260, 112)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpEndDate.TabIndex = 4
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(20, 115)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 3
        Me.lblStartDate.Text = "Start Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpStartDate.Location = New System.Drawing.Point(80, 112)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpStartDate.TabIndex = 2
        '
        'radSelectiveReset
        '
        Me.radSelectiveReset.AutoSize = True
        Me.radSelectiveReset.Location = New System.Drawing.Point(23, 80)
        Me.radSelectiveReset.Name = "radSelectiveReset"
        Me.radSelectiveReset.Size = New System.Drawing.Size(186, 17)
        Me.radSelectiveReset.TabIndex = 1
        Me.radSelectiveReset.Text = "Selective Reset (By Date Range)"
        Me.radSelectiveReset.UseVisualStyleBackColor = True
        '
        'radFactoryReset
        '
        Me.radFactoryReset.AutoSize = True
        Me.radFactoryReset.Checked = True
        Me.radFactoryReset.Location = New System.Drawing.Point(23, 40)
        Me.radFactoryReset.Name = "radFactoryReset"
        Me.radFactoryReset.Size = New System.Drawing.Size(219, 17)
        Me.radFactoryReset.TabIndex = 0
        Me.radFactoryReset.TabStop = True
        Me.radFactoryReset.Text = "Factory Reset (Wipe all transactions && staff)"
        Me.radFactoryReset.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 215)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(172, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Enter Admin Password to confirm:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(15, 235)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(250, 20)
        Me.txtPassword.TabIndex = 2
        '
        'btnExecuteReset
        '
        Me.btnExecuteReset.BackColor = System.Drawing.Color.Firebrick
        Me.btnExecuteReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExecuteReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecuteReset.ForeColor = System.Drawing.Color.White
        Me.btnExecuteReset.Location = New System.Drawing.Point(15, 280)
        Me.btnExecuteReset.Name = "btnExecuteReset"
        Me.btnExecuteReset.Size = New System.Drawing.Size(150, 40)
        Me.btnExecuteReset.TabIndex = 3
        Me.btnExecuteReset.Text = "EXECUTE RESET"
        Me.btnExecuteReset.UseVisualStyleBackColor = False
        '
        'SystemResetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 340)
        Me.Controls.Add(Me.btnExecuteReset)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.grpResetOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SystemResetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Reset"
        Me.grpResetOptions.ResumeLayout(False)
        Me.grpResetOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpResetOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents radSelectiveReset As System.Windows.Forms.RadioButton
    Friend WithEvents radFactoryReset As System.Windows.Forms.RadioButton
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnExecuteReset As System.Windows.Forms.Button

End Class