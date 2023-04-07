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
        Me.btnCalcPay = New System.Windows.Forms.Button()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the button to read the data from a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "file and calculate the weekly payroll." &
    ""
        '
        'btnCalcPay
        '
        Me.btnCalcPay.Location = New System.Drawing.Point(230, 115)
        Me.btnCalcPay.Name = "btnCalcPay"
        Me.btnCalcPay.Size = New System.Drawing.Size(265, 77)
        Me.btnCalcPay.TabIndex = 1
        Me.btnCalcPay.Text = "Calculate Pay"
        Me.btnCalcPay.UseVisualStyleBackColor = True
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(67, 233)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(581, 317)
        Me.rtbOutput.TabIndex = 2
        Me.rtbOutput.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(722, 618)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.btnCalcPay)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Payroll with Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcPay As Button
    Friend WithEvents rtbOutput As RichTextBox
End Class
