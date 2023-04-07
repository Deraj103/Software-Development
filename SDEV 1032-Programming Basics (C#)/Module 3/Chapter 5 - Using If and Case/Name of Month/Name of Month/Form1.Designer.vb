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
        Me.txtDateNum = New System.Windows.Forms.TextBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.btnDateName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(84, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the Month"
        '
        'txtDateNum
        '
        Me.txtDateNum.Location = New System.Drawing.Point(292, 80)
        Me.txtDateNum.Name = "txtDateNum"
        Me.txtDateNum.Size = New System.Drawing.Size(92, 40)
        Me.txtDateNum.TabIndex = 1
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(90, 280)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(294, 96)
        Me.rtbOutput.TabIndex = 2
        Me.rtbOutput.Text = ""
        '
        'btnDateName
        '
        Me.btnDateName.Location = New System.Drawing.Point(110, 193)
        Me.btnDateName.Name = "btnDateName"
        Me.btnDateName.Size = New System.Drawing.Size(249, 49)
        Me.btnDateName.TabIndex = 3
        Me.btnDateName.Text = "Click for the Name"
        Me.btnDateName.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(498, 479)
        Me.Controls.Add(Me.btnDateName)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.txtDateNum)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form1"
        Me.Text = "Name of Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateNum As TextBox
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents btnDateName As Button
End Class
