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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblLargest = New System.Windows.Forms.Label()
        Me.lblSmallest = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(174, 52)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(129, 38)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Info
        Me.lbl1.Enabled = False
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(12, 118)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(57, 45)
        Me.lbl1.TabIndex = 1
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.SystemColors.Info
        Me.lbl2.Enabled = False
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl2.Location = New System.Drawing.Point(91, 118)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(57, 45)
        Me.lbl2.TabIndex = 2
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.SystemColors.Info
        Me.lbl3.Enabled = False
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl3.Location = New System.Drawing.Point(170, 118)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(57, 45)
        Me.lbl3.TabIndex = 3
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.SystemColors.Info
        Me.lbl6.Enabled = False
        Me.lbl6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl6.Location = New System.Drawing.Point(404, 118)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(57, 45)
        Me.lbl6.TabIndex = 6
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.SystemColors.Info
        Me.lbl5.Enabled = False
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl5.Location = New System.Drawing.Point(325, 118)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(57, 45)
        Me.lbl5.TabIndex = 5
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.SystemColors.Info
        Me.lbl4.Enabled = False
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl4.Location = New System.Drawing.Point(246, 118)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(57, 45)
        Me.lbl4.TabIndex = 4
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLargest
        '
        Me.lblLargest.BackColor = System.Drawing.SystemColors.Info
        Me.lblLargest.Enabled = False
        Me.lblLargest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLargest.Location = New System.Drawing.Point(246, 183)
        Me.lblLargest.Name = "lblLargest"
        Me.lblLargest.Size = New System.Drawing.Size(57, 45)
        Me.lblLargest.TabIndex = 7
        Me.lblLargest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSmallest
        '
        Me.lblSmallest.BackColor = System.Drawing.SystemColors.Info
        Me.lblSmallest.Enabled = False
        Me.lblSmallest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSmallest.Location = New System.Drawing.Point(246, 255)
        Me.lblSmallest.Name = "lblSmallest"
        Me.lblSmallest.Size = New System.Drawing.Size(57, 45)
        Me.lblSmallest.TabIndex = 8
        Me.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 27)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Largest"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 27)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Smallest"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 356)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSmallest)
        Me.Controls.Add(Me.lblLargest)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnGo)
        Me.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Random Number Array Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblLargest As Label
    Friend WithEvents lblSmallest As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
