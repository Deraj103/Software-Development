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
        Me.btnNewProblem = New System.Windows.Forms.Button()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewProblem
        '
        Me.btnNewProblem.Location = New System.Drawing.Point(40, 47)
        Me.btnNewProblem.Name = "btnNewProblem"
        Me.btnNewProblem.Size = New System.Drawing.Size(388, 51)
        Me.btnNewProblem.TabIndex = 0
        Me.btnNewProblem.Text = "Get New Problem"
        Me.btnNewProblem.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radSubtraction)
        Me.grpType.Controls.Add(Me.radAddition)
        Me.grpType.Location = New System.Drawing.Point(108, 120)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(254, 138)
        Me.grpType.TabIndex = 1
        Me.grpType.TabStop = False
        Me.grpType.Text = "What Type?"
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(7, 79)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(222, 35)
        Me.radSubtraction.TabIndex = 1
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "Subtraction"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Location = New System.Drawing.Point(7, 38)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(171, 35)
        Me.radAddition.TabIndex = 0
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "Addition"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'lblTop
        '
        Me.lblTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTop.Location = New System.Drawing.Point(269, 306)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(93, 71)
        Me.lblTop.TabIndex = 2
        Me.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBottom
        '
        Me.lblBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBottom.Location = New System.Drawing.Point(269, 393)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(93, 71)
        Me.lblBottom.TabIndex = 3
        Me.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(240, 492)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(122, 38)
        Me.txtAnswer.TabIndex = 4
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(40, 567)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(388, 51)
        Me.btnCheckAnswer.TabIndex = 5
        Me.btnCheckAnswer.Text = "Check My Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'lblSymbol
        '
        Me.lblSymbol.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymbol.Location = New System.Drawing.Point(192, 418)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(51, 46)
        Me.lblSymbol.TabIndex = 6
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(71, 652)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(326, 80)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(482, 819)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnNewProblem)
        Me.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Flash Cards"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewProblem As Button
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radSubtraction As RadioButton
    Friend WithEvents radAddition As RadioButton
    Friend WithEvents lblTop As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnCheckAnswer As Button
    Friend WithEvents lblSymbol As Label
    Friend WithEvents lblOutput As Label
End Class
