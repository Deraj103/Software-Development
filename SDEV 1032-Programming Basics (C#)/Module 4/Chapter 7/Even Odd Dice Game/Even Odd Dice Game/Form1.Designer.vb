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
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.btnEven = New System.Windows.Forms.Button()
        Me.btnOdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOddOrEven = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblDice2 = New System.Windows.Forms.Label()
        Me.lblDice1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPoints
        '
        Me.lblPoints.BackColor = System.Drawing.SystemColors.Info
        Me.lblPoints.Location = New System.Drawing.Point(51, 40)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(270, 63)
        Me.lblPoints.TabIndex = 0
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You Risk"
        '
        'txtRisk
        '
        Me.txtRisk.Location = New System.Drawing.Point(202, 142)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(119, 40)
        Me.txtRisk.TabIndex = 2
        Me.txtRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEven
        '
        Me.btnEven.BackColor = System.Drawing.Color.Crimson
        Me.btnEven.Location = New System.Drawing.Point(57, 204)
        Me.btnEven.Name = "btnEven"
        Me.btnEven.Size = New System.Drawing.Size(105, 68)
        Me.btnEven.TabIndex = 3
        Me.btnEven.Text = "Even"
        Me.btnEven.UseVisualStyleBackColor = False
        '
        'btnOdd
        '
        Me.btnOdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOdd.Location = New System.Drawing.Point(213, 204)
        Me.btnOdd.Name = "btnOdd"
        Me.btnOdd.Size = New System.Drawing.Size(108, 68)
        Me.btnOdd.TabIndex = 4
        Me.btnOdd.Text = "Odd"
        Me.btnOdd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Result"
        '
        'lblOddOrEven
        '
        Me.lblOddOrEven.Location = New System.Drawing.Point(220, 507)
        Me.lblOddOrEven.Name = "lblOddOrEven"
        Me.lblOddOrEven.Size = New System.Drawing.Size(101, 89)
        Me.lblOddOrEven.TabIndex = 6
        Me.lblOddOrEven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.Aqua
        Me.lblOutput.Location = New System.Drawing.Point(57, 659)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(264, 70)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDice2
        '
        Me.lblDice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDice2.Location = New System.Drawing.Point(213, 305)
        Me.lblDice2.Name = "lblDice2"
        Me.lblDice2.Size = New System.Drawing.Size(108, 89)
        Me.lblDice2.TabIndex = 8
        Me.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDice1
        '
        Me.lblDice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDice1.Location = New System.Drawing.Point(57, 305)
        Me.lblDice1.Name = "lblDice1"
        Me.lblDice1.Size = New System.Drawing.Size(105, 89)
        Me.lblDice1.TabIndex = 9
        Me.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(57, 507)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(110, 89)
        Me.lblResult.TabIndex = 10
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(371, 804)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblDice1)
        Me.Controls.Add(Me.lblDice2)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblOddOrEven)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOdd)
        Me.Controls.Add(Me.btnEven)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPoints)
        Me.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Even Odd Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPoints As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRisk As TextBox
    Friend WithEvents btnEven As Button
    Friend WithEvents btnOdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOddOrEven As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblDice2 As Label
    Friend WithEvents lblDice1 As Label
    Friend WithEvents lblResult As Label
End Class
