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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTicketSubtotal = New System.Windows.Forms.Button()
        Me.btnSnackSubtotal = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSnackSubtotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTicketSubtotal = New System.Windows.Forms.Label()
        Me.nudAdults = New System.Windows.Forms.NumericUpDown()
        Me.nudChildren = New System.Windows.Forms.NumericUpDown()
        Me.nudSeniors = New System.Windows.Forms.NumericUpDown()
        Me.nudPopcorn = New System.Windows.Forms.NumericUpDown()
        Me.nudDrink = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudAdults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeniors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(56, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Ticket Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(106, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "# of Adults"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(106, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "# of Children"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(106, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "# of Seniors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(56, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Snacks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(106, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Popcorn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(106, 549)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Drink"
        '
        'btnTicketSubtotal
        '
        Me.btnTicketSubtotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTicketSubtotal.Location = New System.Drawing.Point(139, 315)
        Me.btnTicketSubtotal.Name = "btnTicketSubtotal"
        Me.btnTicketSubtotal.Size = New System.Drawing.Size(377, 49)
        Me.btnTicketSubtotal.TabIndex = 7
        Me.btnTicketSubtotal.Text = "Subtotal for Tickets"
        Me.btnTicketSubtotal.UseVisualStyleBackColor = False
        '
        'btnSnackSubtotal
        '
        Me.btnSnackSubtotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSnackSubtotal.Location = New System.Drawing.Point(139, 652)
        Me.btnSnackSubtotal.Name = "btnSnackSubtotal"
        Me.btnSnackSubtotal.Size = New System.Drawing.Size(377, 49)
        Me.btnSnackSubtotal.TabIndex = 8
        Me.btnSnackSubtotal.Text = "Subtotal for Snacks"
        Me.btnSnackSubtotal.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTotal.Location = New System.Drawing.Point(139, 766)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(377, 49)
        Me.btnTotal.TabIndex = 9
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(586, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 32)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "$10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(586, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 32)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "$6"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(586, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 32)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "$8"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(586, 480)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 32)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "$5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(586, 549)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 32)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "$3"
        '
        'lblSnackSubtotal
        '
        Me.lblSnackSubtotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSnackSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSnackSubtotal.Location = New System.Drawing.Point(705, 652)
        Me.lblSnackSubtotal.Name = "lblSnackSubtotal"
        Me.lblSnackSubtotal.Size = New System.Drawing.Size(106, 49)
        Me.lblSnackSubtotal.TabIndex = 20
        Me.lblSnackSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(705, 766)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(106, 49)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTicketSubtotal
        '
        Me.lblTicketSubtotal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTicketSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTicketSubtotal.Location = New System.Drawing.Point(705, 315)
        Me.lblTicketSubtotal.Name = "lblTicketSubtotal"
        Me.lblTicketSubtotal.Size = New System.Drawing.Size(106, 49)
        Me.lblTicketSubtotal.TabIndex = 22
        Me.lblTicketSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudAdults
        '
        Me.nudAdults.Location = New System.Drawing.Point(705, 108)
        Me.nudAdults.Name = "nudAdults"
        Me.nudAdults.Size = New System.Drawing.Size(106, 39)
        Me.nudAdults.TabIndex = 23
        '
        'nudChildren
        '
        Me.nudChildren.Location = New System.Drawing.Point(705, 169)
        Me.nudChildren.Name = "nudChildren"
        Me.nudChildren.Size = New System.Drawing.Size(106, 39)
        Me.nudChildren.TabIndex = 24
        '
        'nudSeniors
        '
        Me.nudSeniors.Location = New System.Drawing.Point(705, 231)
        Me.nudSeniors.Name = "nudSeniors"
        Me.nudSeniors.Size = New System.Drawing.Size(106, 39)
        Me.nudSeniors.TabIndex = 25
        '
        'nudPopcorn
        '
        Me.nudPopcorn.Location = New System.Drawing.Point(705, 478)
        Me.nudPopcorn.Name = "nudPopcorn"
        Me.nudPopcorn.Size = New System.Drawing.Size(106, 39)
        Me.nudPopcorn.TabIndex = 26
        '
        'nudDrink
        '
        Me.nudDrink.Location = New System.Drawing.Point(705, 547)
        Me.nudDrink.Name = "nudDrink"
        Me.nudDrink.Size = New System.Drawing.Size(106, 39)
        Me.nudDrink.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(938, 874)
        Me.Controls.Add(Me.nudDrink)
        Me.Controls.Add(Me.nudPopcorn)
        Me.Controls.Add(Me.nudSeniors)
        Me.Controls.Add(Me.nudChildren)
        Me.Controls.Add(Me.nudAdults)
        Me.Controls.Add(Me.lblTicketSubtotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSnackSubtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnSnackSubtotal)
        Me.Controls.Add(Me.btnTicketSubtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Fax", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Jared's Movie Theater Pricing"
        CType(Me.nudAdults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudChildren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeniors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTicketSubtotal As Button
    Friend WithEvents btnSnackSubtotal As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblSnackSubtotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTicketSubtotal As Label
    Friend WithEvents nudAdults As NumericUpDown
    Friend WithEvents nudChildren As NumericUpDown
    Friend WithEvents nudSeniors As NumericUpDown
    Friend WithEvents nudPopcorn As NumericUpDown
    Friend WithEvents nudDrink As NumericUpDown
End Class
