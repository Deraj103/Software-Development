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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudMonth = New System.Windows.Forms.NumericUpDown()
        Me.nudDay = New System.Windows.Forms.NumericUpDown()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblDaysAdded = New System.Windows.Forms.Label()
        Me.nudDaysAdded = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.nudMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDaysAdded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year"
        '
        'nudMonth
        '
        Me.nudMonth.Location = New System.Drawing.Point(56, 70)
        Me.nudMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMonth.Name = "nudMonth"
        Me.nudMonth.Size = New System.Drawing.Size(48, 41)
        Me.nudMonth.TabIndex = 3
        Me.nudMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDay
        '
        Me.nudDay.Location = New System.Drawing.Point(168, 70)
        Me.nudDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDay.Name = "nudDay"
        Me.nudDay.Size = New System.Drawing.Size(48, 41)
        Me.nudDay.TabIndex = 4
        Me.nudDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(269, 70)
        Me.nudYear.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(95, 41)
        Me.nudYear.TabIndex = 5
        Me.nudYear.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalc.Location = New System.Drawing.Point(68, 192)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(250, 54)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'lblDaysAdded
        '
        Me.lblDaysAdded.BackColor = System.Drawing.SystemColors.Info
        Me.lblDaysAdded.Location = New System.Drawing.Point(39, 122)
        Me.lblDaysAdded.Name = "lblDaysAdded"
        Me.lblDaysAdded.Size = New System.Drawing.Size(222, 45)
        Me.lblDaysAdded.TabIndex = 7
        Me.lblDaysAdded.Text = "Added Days (1 to 60)"
        Me.lblDaysAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudDaysAdded
        '
        Me.nudDaysAdded.Location = New System.Drawing.Point(280, 133)
        Me.nudDaysAdded.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudDaysAdded.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDaysAdded.Name = "nudDaysAdded"
        Me.nudDaysAdded.Size = New System.Drawing.Size(63, 41)
        Me.nudDaysAdded.TabIndex = 8
        Me.nudDaysAdded.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 37)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "New Date"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(104, 299)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(169, 47)
        Me.lblOutput.TabIndex = 10
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 427)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudDaysAdded)
        Me.Controls.Add(Me.lblDaysAdded)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.nudDay)
        Me.Controls.Add(Me.nudMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Form1"
        Me.Text = "Future Date"
        CType(Me.nudMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDaysAdded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudMonth As NumericUpDown
    Friend WithEvents nudDay As NumericUpDown
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblDaysAdded As Label
    Friend WithEvents nudDaysAdded As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOutput As Label
End Class
