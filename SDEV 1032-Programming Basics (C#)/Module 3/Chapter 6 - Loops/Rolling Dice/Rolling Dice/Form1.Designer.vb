<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudInput = New System.Windows.Forms.NumericUpDown()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnTarget = New System.Windows.Forms.Button()
        Me.btnNumTimes = New System.Windows.Forms.Button()
        CType(Me.nudInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roll to a target or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Roll a number of times."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the target or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the number of rolls."
        '
        'nudInput
        '
        Me.nudInput.Location = New System.Drawing.Point(326, 152)
        Me.nudInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInput.Name = "nudInput"
        Me.nudInput.Size = New System.Drawing.Size(86, 43)
        Me.nudInput.TabIndex = 2
        Me.nudInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(62, 229)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(238, 388)
        Me.rtbOutput.TabIndex = 3
        Me.rtbOutput.Text = ""
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblOutput.Location = New System.Drawing.Point(55, 660)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(486, 37)
        Me.lblOutput.TabIndex = 4
        '
        'btnTarget
        '
        Me.btnTarget.Location = New System.Drawing.Point(326, 250)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(215, 159)
        Me.btnTarget.TabIndex = 6
        Me.btnTarget.Text = "Roll to Target"
        Me.btnTarget.UseVisualStyleBackColor = True
        '
        'btnNumTimes
        '
        Me.btnNumTimes.Location = New System.Drawing.Point(326, 448)
        Me.btnNumTimes.Name = "btnNumTimes"
        Me.btnNumTimes.Size = New System.Drawing.Size(215, 169)
        Me.btnNumTimes.TabIndex = 7
        Me.btnNumTimes.Text = "Roll a Number of Times"
        Me.btnNumTimes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(604, 738)
        Me.Controls.Add(Me.btnNumTimes)
        Me.Controls.Add(Me.btnTarget)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.nudInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Form1"
        Me.Text = "Rolling Dice"
        CType(Me.nudInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudInput As NumericUpDown
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnTarget As Button
    Friend WithEvents btnNumTimes As Button
End Class
