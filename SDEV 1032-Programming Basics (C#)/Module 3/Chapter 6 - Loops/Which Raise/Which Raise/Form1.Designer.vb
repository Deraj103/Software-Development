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
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.txtInputRaise = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.rtbRec = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(36, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What is the raise amount?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(81, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 68)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A penny doubled " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "each day will be:"
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(42, 380)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(554, 353)
        Me.rtbOutput.TabIndex = 2
        Me.rtbOutput.Text = ""
        '
        'txtInputRaise
        '
        Me.txtInputRaise.Location = New System.Drawing.Point(396, 56)
        Me.txtInputRaise.Name = "txtInputRaise"
        Me.txtInputRaise.Size = New System.Drawing.Size(200, 40)
        Me.txtInputRaise.TabIndex = 3
        Me.txtInputRaise.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblOutput.Location = New System.Drawing.Point(396, 145)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(200, 42)
        Me.lblOutput.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(54, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Recommendation"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(396, 225)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(200, 56)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'rtbRec
        '
        Me.rtbRec.Location = New System.Drawing.Point(60, 274)
        Me.rtbRec.Name = "rtbRec"
        Me.rtbRec.Size = New System.Drawing.Size(278, 74)
        Me.rtbRec.TabIndex = 7
        Me.rtbRec.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 773)
        Me.Controls.Add(Me.rtbRec)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInputRaise)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "What Kind of Raise?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents txtInputRaise As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents rtbRec As RichTextBox
End Class
