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
        Me.txtInitialGrowth = New System.Windows.Forms.TextBox()
        Me.txtGrowthRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumCycles = New System.Windows.Forms.TextBox()
        Me.btnCalcFutVal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTargetAmt = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(119, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(142, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Growth Rate"
        '
        'txtInitialGrowth
        '
        Me.txtInitialGrowth.Location = New System.Drawing.Point(343, 79)
        Me.txtInitialGrowth.Name = "txtInitialGrowth"
        Me.txtInitialGrowth.Size = New System.Drawing.Size(100, 39)
        Me.txtInitialGrowth.TabIndex = 2
        '
        'txtGrowthRate
        '
        Me.txtGrowthRate.Location = New System.Drawing.Point(343, 137)
        Me.txtGrowthRate.Name = "txtGrowthRate"
        Me.txtGrowthRate.Size = New System.Drawing.Size(100, 39)
        Me.txtGrowthRate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(27, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(607, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "For Future Value of Amount After Specified Cycles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(84, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Number of Cycles"
        '
        'txtNumCycles
        '
        Me.txtNumCycles.Location = New System.Drawing.Point(343, 261)
        Me.txtNumCycles.Name = "txtNumCycles"
        Me.txtNumCycles.Size = New System.Drawing.Size(100, 39)
        Me.txtNumCycles.TabIndex = 6
        '
        'btnCalcFutVal
        '
        Me.btnCalcFutVal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcFutVal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcFutVal.Location = New System.Drawing.Point(169, 327)
        Me.btnCalcFutVal.Name = "btnCalcFutVal"
        Me.btnCalcFutVal.Size = New System.Drawing.Size(328, 55)
        Me.btnCalcFutVal.TabIndex = 7
        Me.btnCalcFutVal.Text = "Calculate Future Value"
        Me.btnCalcFutVal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(39, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(562, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "For Number of Cycles to Reach Target Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(113, 515)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 33)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Target Amount"
        '
        'txtTargetAmt
        '
        Me.txtTargetAmt.Location = New System.Drawing.Point(343, 509)
        Me.txtTargetAmt.Name = "txtTargetAmt"
        Me.txtTargetAmt.Size = New System.Drawing.Size(100, 39)
        Me.txtTargetAmt.TabIndex = 10
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(103, 554)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(430, 96)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "Calculate How Long to Reach Target"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(84, 656)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 33)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Answer"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblOutput.Location = New System.Drawing.Point(198, 666)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(335, 103)
        Me.lblOutput.TabIndex = 13
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(663, 852)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTargetAmt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalcFutVal)
        Me.Controls.Add(Me.txtNumCycles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGrowthRate)
        Me.Controls.Add(Me.txtInitialGrowth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Money Growth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInitialGrowth As TextBox
    Friend WithEvents txtGrowthRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumCycles As TextBox
    Friend WithEvents btnCalcFutVal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTargetAmt As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOutput As Label
End Class
