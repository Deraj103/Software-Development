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
        Me.nudStars = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWordRating = New System.Windows.Forms.TextBox()
        Me.btnRateIt = New System.Windows.Forms.Button()
        Me.lblAverageRating = New System.Windows.Forms.Label()
        Me.rtbThankYou = New System.Windows.Forms.RichTextBox()
        Me.btnAverageRating = New System.Windows.Forms.Button()
        CType(Me.nudStars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(160, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please rate the movie " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with 0 to 5 stars" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(67, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How  many stars?"
        '
        'nudStars
        '
        Me.nudStars.Location = New System.Drawing.Point(304, 168)
        Me.nudStars.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudStars.Name = "nudStars"
        Me.nudStars.Size = New System.Drawing.Size(120, 34)
        Me.nudStars.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(469, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 56)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "(0 is worst, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 is best)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(67, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 84)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "What one word " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "describes the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movie?"
        '
        'txtWordRating
        '
        Me.txtWordRating.Location = New System.Drawing.Point(304, 254)
        Me.txtWordRating.Name = "txtWordRating"
        Me.txtWordRating.Size = New System.Drawing.Size(169, 34)
        Me.txtWordRating.TabIndex = 5
        '
        'btnRateIt
        '
        Me.btnRateIt.Location = New System.Drawing.Point(304, 324)
        Me.btnRateIt.Name = "btnRateIt"
        Me.btnRateIt.Size = New System.Drawing.Size(120, 43)
        Me.btnRateIt.TabIndex = 6
        Me.btnRateIt.Text = "Rate it!"
        Me.btnRateIt.UseVisualStyleBackColor = True
        '
        'lblAverageRating
        '
        Me.lblAverageRating.BackColor = System.Drawing.SystemColors.Info
        Me.lblAverageRating.Location = New System.Drawing.Point(334, 521)
        Me.lblAverageRating.Name = "lblAverageRating"
        Me.lblAverageRating.Size = New System.Drawing.Size(90, 37)
        Me.lblAverageRating.TabIndex = 9
        '
        'rtbThankYou
        '
        Me.rtbThankYou.Location = New System.Drawing.Point(95, 410)
        Me.rtbThankYou.Name = "rtbThankYou"
        Me.rtbThankYou.Size = New System.Drawing.Size(378, 54)
        Me.rtbThankYou.TabIndex = 10
        Me.rtbThankYou.Text = ""
        '
        'btnAverageRating
        '
        Me.btnAverageRating.Location = New System.Drawing.Point(95, 502)
        Me.btnAverageRating.Name = "btnAverageRating"
        Me.btnAverageRating.Size = New System.Drawing.Size(189, 65)
        Me.btnAverageRating.TabIndex = 11
        Me.btnAverageRating.Text = "Average Rating"
        Me.btnAverageRating.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(693, 726)
        Me.Controls.Add(Me.btnAverageRating)
        Me.Controls.Add(Me.rtbThankYou)
        Me.Controls.Add(Me.lblAverageRating)
        Me.Controls.Add(Me.btnRateIt)
        Me.Controls.Add(Me.txtWordRating)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudStars)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Jared's Reliable Movie Rating"
        CType(Me.nudStars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudStars As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWordRating As TextBox
    Friend WithEvents btnRateIt As Button
    Friend WithEvents lblAverageRating As Label
    Friend WithEvents rtbThankYou As RichTextBox
    Friend WithEvents btnAverageRating As Button
End Class
