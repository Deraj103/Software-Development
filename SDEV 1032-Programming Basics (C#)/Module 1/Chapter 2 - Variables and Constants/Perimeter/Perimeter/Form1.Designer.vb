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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcPeri = New System.Windows.Forms.Button()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.btnCalcArea = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(309, 97)
        Me.txtLength.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(172, 34)
        Me.txtLength.TabIndex = 0
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(309, 173)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(5)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(172, 34)
        Me.txtWidth.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width"
        '
        'btnCalcPeri
        '
        Me.btnCalcPeri.Location = New System.Drawing.Point(198, 239)
        Me.btnCalcPeri.Name = "btnCalcPeri"
        Me.btnCalcPeri.Size = New System.Drawing.Size(204, 82)
        Me.btnCalcPeri.TabIndex = 4
        Me.btnCalcPeri.Text = "Calculate Perimeter"
        Me.btnCalcPeri.UseVisualStyleBackColor = True
        '
        'lblPerimeter
        '
        Me.lblPerimeter.BackColor = System.Drawing.SystemColors.Window
        Me.lblPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPerimeter.Location = New System.Drawing.Point(309, 353)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(172, 34)
        Me.lblPerimeter.TabIndex = 5
        '
        'btnCalcArea
        '
        Me.btnCalcArea.Location = New System.Drawing.Point(198, 424)
        Me.btnCalcArea.Name = "btnCalcArea"
        Me.btnCalcArea.Size = New System.Drawing.Size(204, 82)
        Me.btnCalcArea.TabIndex = 6
        Me.btnCalcArea.Text = "Calculate Area"
        Me.btnCalcArea.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Perimeter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 540)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Area"
        '
        'lblArea
        '
        Me.lblArea.BackColor = System.Drawing.SystemColors.Window
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArea.Location = New System.Drawing.Point(309, 540)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(172, 34)
        Me.lblArea.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(198, 607)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(204, 54)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(638, 769)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcArea)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.btnCalcPeri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Permeter and Area Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalcPeri As Button
    Friend WithEvents lblPerimeter As Label
    Friend WithEvents btnCalcArea As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents btnExit As Button
End Class
