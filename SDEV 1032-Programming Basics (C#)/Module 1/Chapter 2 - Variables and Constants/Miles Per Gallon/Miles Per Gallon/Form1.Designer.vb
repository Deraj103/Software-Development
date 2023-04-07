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
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.btnCalcMPG = New System.Windows.Forms.Button()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many miles traveled?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How many gallons used?"
        '
        'txtMiles
        '
        Me.txtMiles.BackColor = System.Drawing.SystemColors.Window
        Me.txtMiles.Location = New System.Drawing.Point(475, 94)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(123, 38)
        Me.txtMiles.TabIndex = 2
        '
        'txtGallons
        '
        Me.txtGallons.BackColor = System.Drawing.SystemColors.Window
        Me.txtGallons.Location = New System.Drawing.Point(475, 177)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(123, 38)
        Me.txtGallons.TabIndex = 3
        '
        'btnCalcMPG
        '
        Me.btnCalcMPG.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCalcMPG.Location = New System.Drawing.Point(131, 281)
        Me.btnCalcMPG.Name = "btnCalcMPG"
        Me.btnCalcMPG.Size = New System.Drawing.Size(227, 57)
        Me.btnCalcMPG.TabIndex = 4
        Me.btnCalcMPG.Text = "Calculate MPG"
        Me.btnCalcMPG.UseVisualStyleBackColor = False
        '
        'lblMPG
        '
        Me.lblMPG.BackColor = System.Drawing.SystemColors.Info
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMPG.Location = New System.Drawing.Point(475, 293)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(123, 38)
        Me.lblMPG.TabIndex = 5
        Me.lblMPG.Text = "MPG"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 527)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.btnCalcMPG)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "MPG by Jared Tims"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents btnCalcMPG As Button
    Friend WithEvents lblMPG As Label
End Class
