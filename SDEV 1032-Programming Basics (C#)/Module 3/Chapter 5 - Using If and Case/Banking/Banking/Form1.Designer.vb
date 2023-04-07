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
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount of Change"
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Info
        Me.lblBalance.Location = New System.Drawing.Point(420, 84)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(238, 34)
        Me.lblBalance.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(426, 144)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(232, 40)
        Me.txtInput.TabIndex = 3
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(108, 213)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(198, 51)
        Me.btnDeposit.TabIndex = 4
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(442, 213)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(216, 51)
        Me.btnWithdraw.TabIndex = 5
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(108, 339)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(549, 109)
        Me.rtbOutput.TabIndex = 6
        Me.rtbOutput.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(799, 556)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bahnschrift SemiBold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Jared's Banking Services"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents rtbOutput As RichTextBox
End Class
