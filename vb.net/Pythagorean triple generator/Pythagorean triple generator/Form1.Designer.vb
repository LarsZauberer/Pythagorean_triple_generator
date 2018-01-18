<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LTo
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
        Me.From = New System.Windows.Forms.NumericUpDown()
        Me.ToN = New System.Windows.Forms.NumericUpDown()
        Me.LFrom = New System.Windows.Forms.Label()
        Me.LToN = New System.Windows.Forms.Label()
        Me.BTNStart = New System.Windows.Forms.Button()
        Me.LBOutput = New System.Windows.Forms.ListBox()
        Me.LOutput = New System.Windows.Forms.Label()
        CType(Me.From, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'From
        '
        Me.From.Location = New System.Drawing.Point(55, 276)
        Me.From.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(144, 20)
        Me.From.TabIndex = 0
        Me.From.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ToN
        '
        Me.ToN.Location = New System.Drawing.Point(236, 276)
        Me.ToN.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.ToN.Name = "ToN"
        Me.ToN.Size = New System.Drawing.Size(144, 20)
        Me.ToN.TabIndex = 1
        Me.ToN.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'LFrom
        '
        Me.LFrom.AutoSize = True
        Me.LFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LFrom.Location = New System.Drawing.Point(9, 276)
        Me.LFrom.Name = "LFrom"
        Me.LFrom.Size = New System.Drawing.Size(40, 17)
        Me.LFrom.TabIndex = 2
        Me.LFrom.Text = "From"
        '
        'LToN
        '
        Me.LToN.AutoSize = True
        Me.LToN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LToN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LToN.Location = New System.Drawing.Point(205, 276)
        Me.LToN.Name = "LToN"
        Me.LToN.Size = New System.Drawing.Size(25, 17)
        Me.LToN.TabIndex = 3
        Me.LToN.Text = "To"
        '
        'BTNStart
        '
        Me.BTNStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNStart.Location = New System.Drawing.Point(416, 273)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.Size = New System.Drawing.Size(75, 23)
        Me.BTNStart.TabIndex = 4
        Me.BTNStart.Text = "Start"
        Me.BTNStart.UseVisualStyleBackColor = True
        '
        'LBOutput
        '
        Me.LBOutput.FormattingEnabled = True
        Me.LBOutput.Location = New System.Drawing.Point(12, 29)
        Me.LBOutput.Name = "LBOutput"
        Me.LBOutput.Size = New System.Drawing.Size(127, 238)
        Me.LBOutput.TabIndex = 5
        '
        'LOutput
        '
        Me.LOutput.AutoSize = True
        Me.LOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LOutput.Location = New System.Drawing.Point(13, 13)
        Me.LOutput.Name = "LOutput"
        Me.LOutput.Size = New System.Drawing.Size(39, 13)
        Me.LOutput.TabIndex = 6
        Me.LOutput.Text = "Output"
        '
        'LTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 308)
        Me.Controls.Add(Me.LOutput)
        Me.Controls.Add(Me.LBOutput)
        Me.Controls.Add(Me.BTNStart)
        Me.Controls.Add(Me.LToN)
        Me.Controls.Add(Me.LFrom)
        Me.Controls.Add(Me.ToN)
        Me.Controls.Add(Me.From)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LTo"
        Me.Text = "Tripel generator"
        CType(Me.From, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents From As NumericUpDown
    Friend WithEvents ToN As NumericUpDown
    Friend WithEvents LFrom As Label
    Friend WithEvents LToN As Label
    Friend WithEvents BTNStart As Button
    Friend WithEvents LBOutput As ListBox
    Friend WithEvents LOutput As Label
End Class
