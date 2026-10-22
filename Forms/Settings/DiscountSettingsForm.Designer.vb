<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiscountSettingsForm
    Inherits System.Windows.Forms.Form

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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvDiscounts = New System.Windows.Forms.DataGridView()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.numRate = New System.Windows.Forms.NumericUpDown()
        Me.chkVatExempt = New System.Windows.Forms.CheckBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvDiscounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(20, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(230, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Discount Settings"
        '
        'dgvDiscounts
        '
        Me.dgvDiscounts.AllowUserToAddRows = False
        Me.dgvDiscounts.AllowUserToDeleteRows = False
        Me.dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDiscounts.BackgroundColor = System.Drawing.Color.White
        Me.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiscounts.Location = New System.Drawing.Point(20, 64)
        Me.dgvDiscounts.MultiSelect = False
        Me.dgvDiscounts.Name = "dgvDiscounts"
        Me.dgvDiscounts.ReadOnly = True
        Me.dgvDiscounts.RowHeadersVisible = False
        Me.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDiscounts.Size = New System.Drawing.Size(740, 170)
        Me.dgvDiscounts.TabIndex = 1
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSelected.Location = New System.Drawing.Point(22, 252)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(200, 20)
        Me.lblSelected.TabIndex = 2
        Me.lblSelected.Text = "Select a discount above"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(24, 292)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(55, 15)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rate (%):"
        '
        'numRate
        '
        Me.numRate.DecimalPlaces = 2
        Me.numRate.Location = New System.Drawing.Point(110, 289)
        Me.numRate.Name = "numRate"
        Me.numRate.Size = New System.Drawing.Size(100, 23)
        Me.numRate.TabIndex = 4
        '
        'chkVatExempt
        '
        Me.chkVatExempt.AutoSize = True
        Me.chkVatExempt.Location = New System.Drawing.Point(240, 291)
        Me.chkVatExempt.Name = "chkVatExempt"
        Me.chkVatExempt.Size = New System.Drawing.Size(86, 19)
        Me.chkVatExempt.TabIndex = 5
        Me.chkVatExempt.Text = "VAT exempt"
        Me.chkVatExempt.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(24, 332)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(62, 15)
        Me.lblStart.TabIndex = 6
        Me.lblStart.Text = "Start date:"
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpStart.Location = New System.Drawing.Point(110, 329)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowCheckBox = True
        Me.dtpStart.Size = New System.Drawing.Size(130, 23)
        Me.dtpStart.TabIndex = 7
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(280, 332)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(55, 15)
        Me.lblEnd.TabIndex = 8
        Me.lblEnd.Text = "End date:"
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpEnd.Location = New System.Drawing.Point(345, 329)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowCheckBox = True
        Me.dtpEnd.Size = New System.Drawing.Size(130, 23)
        Me.dtpEnd.TabIndex = 9
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.ForeColor = System.Drawing.Color.Gray
        Me.lblNote.Location = New System.Drawing.Point(24, 372)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(400, 15)
        Me.lblNote.TabIndex = 10
        Me.lblNote.Text = "Changes apply to new reservations only. Existing reservations keep their amounts."
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(20, 410)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 38)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE CHANGES"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(640, 410)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 38)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DiscountSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 470)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.chkVatExempt)
        Me.Controls.Add(Me.numRate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.dgvDiscounts)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DiscountSettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Discount Settings"
        CType(Me.dgvDiscounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents dgvDiscounts As System.Windows.Forms.DataGridView
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents numRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkVatExempt As System.Windows.Forms.CheckBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
