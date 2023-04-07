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
        Me.txtLeftNum = New System.Windows.Forms.TextBox()
        Me.txtRightNum = New System.Windows.Forms.TextBox()
        Me.lblCalculations = New System.Windows.Forms.Label()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnMulitplication = New System.Windows.Forms.Button()
        Me.btnIntegerDivision = New System.Windows.Forms.Button()
        Me.btnModulusDivision = New System.Windows.Forms.Button()
        Me.btnLongDivision = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLeftNum
        '
        Me.txtLeftNum.Location = New System.Drawing.Point(105, 47)
        Me.txtLeftNum.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtLeftNum.Name = "txtLeftNum"
        Me.txtLeftNum.Size = New System.Drawing.Size(210, 35)
        Me.txtLeftNum.TabIndex = 0
        Me.txtLeftNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRightNum
        '
        Me.txtRightNum.Location = New System.Drawing.Point(360, 47)
        Me.txtRightNum.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRightNum.Name = "txtRightNum"
        Me.txtRightNum.Size = New System.Drawing.Size(210, 35)
        Me.txtRightNum.TabIndex = 1
        Me.txtRightNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCalculations
        '
        Me.lblCalculations.BackColor = System.Drawing.SystemColors.Info
        Me.lblCalculations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalculations.Location = New System.Drawing.Point(253, 125)
        Me.lblCalculations.Name = "lblCalculations"
        Me.lblCalculations.Size = New System.Drawing.Size(166, 46)
        Me.lblCalculations.TabIndex = 2
        '
        'btnAddition
        '
        Me.btnAddition.Location = New System.Drawing.Point(105, 206)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(210, 49)
        Me.btnAddition.TabIndex = 3
        Me.btnAddition.Text = "Addition"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnMulitplication
        '
        Me.btnMulitplication.Location = New System.Drawing.Point(105, 294)
        Me.btnMulitplication.Name = "btnMulitplication"
        Me.btnMulitplication.Size = New System.Drawing.Size(210, 49)
        Me.btnMulitplication.TabIndex = 4
        Me.btnMulitplication.Text = "Multiplication"
        Me.btnMulitplication.UseVisualStyleBackColor = True
        '
        'btnIntegerDivision
        '
        Me.btnIntegerDivision.Location = New System.Drawing.Point(105, 387)
        Me.btnIntegerDivision.Name = "btnIntegerDivision"
        Me.btnIntegerDivision.Size = New System.Drawing.Size(210, 62)
        Me.btnIntegerDivision.TabIndex = 5
        Me.btnIntegerDivision.Text = "Integer Division"
        Me.btnIntegerDivision.UseVisualStyleBackColor = True
        '
        'btnModulusDivision
        '
        Me.btnModulusDivision.Location = New System.Drawing.Point(360, 387)
        Me.btnModulusDivision.Name = "btnModulusDivision"
        Me.btnModulusDivision.Size = New System.Drawing.Size(210, 62)
        Me.btnModulusDivision.TabIndex = 8
        Me.btnModulusDivision.Text = "Modulus Division"
        Me.btnModulusDivision.UseVisualStyleBackColor = True
        '
        'btnLongDivision
        '
        Me.btnLongDivision.Location = New System.Drawing.Point(360, 294)
        Me.btnLongDivision.Name = "btnLongDivision"
        Me.btnLongDivision.Size = New System.Drawing.Size(210, 49)
        Me.btnLongDivision.TabIndex = 7
        Me.btnLongDivision.Text = "Long Division"
        Me.btnLongDivision.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Location = New System.Drawing.Point(360, 206)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(210, 49)
        Me.btnSubtraction.TabIndex = 6
        Me.btnSubtraction.Text = "Subtraction"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(679, 544)
        Me.Controls.Add(Me.btnModulusDivision)
        Me.Controls.Add(Me.btnLongDivision)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnIntegerDivision)
        Me.Controls.Add(Me.btnMulitplication)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.lblCalculations)
        Me.Controls.Add(Me.txtRightNum)
        Me.Controls.Add(Me.txtLeftNum)
        Me.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.Text = "Six-Function Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLeftNum As TextBox
    Friend WithEvents txtRightNum As TextBox
    Friend WithEvents lblCalculations As Label
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnMulitplication As Button
    Friend WithEvents btnIntegerDivision As Button
    Friend WithEvents btnModulusDivision As Button
    Friend WithEvents btnLongDivision As Button
    Friend WithEvents btnSubtraction As Button
End Class
