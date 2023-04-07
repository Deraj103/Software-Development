<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorld
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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnBye = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(144, 50)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(229, 66)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello, earthling - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "what is your name?"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.Info
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(150, 177)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(200, 23)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Greetings"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(150, 218)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 30)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Done"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnBye
        '
        Me.btnBye.Location = New System.Drawing.Point(252, 218)
        Me.btnBye.Name = "btnBye"
        Me.btnBye.Size = New System.Drawing.Size(98, 30)
        Me.btnBye.TabIndex = 4
        Me.btnBye.Text = "Goodbye"
        Me.btnBye.UseVisualStyleBackColor = True
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(616, 443)
        Me.Controls.Add(Me.btnBye)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHello)
        Me.Name = "HelloWorld"
        Me.Text = "Hello, World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHello As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents btnBye As Button
End Class
