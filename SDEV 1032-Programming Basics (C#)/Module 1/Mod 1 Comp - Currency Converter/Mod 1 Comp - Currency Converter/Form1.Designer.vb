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
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.btnCalcEuros = New System.Windows.Forms.Button()
        Me.btnCalcYen = New System.Windows.Forms.Button()
        Me.btnCalcPesos = New System.Windows.Forms.Button()
        Me.lblEuros = New System.Windows.Forms.Label()
        Me.lblYen = New System.Windows.Forms.Label()
        Me.lblPesos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many US dollars?"
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(323, 66)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(104, 35)
        Me.txtDollars.TabIndex = 1
        '
        'btnCalcEuros
        '
        Me.btnCalcEuros.Location = New System.Drawing.Point(105, 150)
        Me.btnCalcEuros.Name = "btnCalcEuros"
        Me.btnCalcEuros.Size = New System.Drawing.Size(153, 42)
        Me.btnCalcEuros.TabIndex = 2
        Me.btnCalcEuros.Text = "Calculate Euros"
        Me.btnCalcEuros.UseVisualStyleBackColor = True
        '
        'btnCalcYen
        '
        Me.btnCalcYen.Location = New System.Drawing.Point(105, 237)
        Me.btnCalcYen.Name = "btnCalcYen"
        Me.btnCalcYen.Size = New System.Drawing.Size(153, 42)
        Me.btnCalcYen.TabIndex = 3
        Me.btnCalcYen.Text = "Calculate Yen"
        Me.btnCalcYen.UseVisualStyleBackColor = True
        '
        'btnCalcPesos
        '
        Me.btnCalcPesos.Location = New System.Drawing.Point(105, 331)
        Me.btnCalcPesos.Name = "btnCalcPesos"
        Me.btnCalcPesos.Size = New System.Drawing.Size(153, 42)
        Me.btnCalcPesos.TabIndex = 4
        Me.btnCalcPesos.Text = "Calculate Pesos"
        Me.btnCalcPesos.UseVisualStyleBackColor = True
        '
        'lblEuros
        '
        Me.lblEuros.BackColor = System.Drawing.SystemColors.Info
        Me.lblEuros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuros.Location = New System.Drawing.Point(323, 157)
        Me.lblEuros.Name = "lblEuros"
        Me.lblEuros.Size = New System.Drawing.Size(104, 35)
        Me.lblEuros.TabIndex = 5
        '
        'lblYen
        '
        Me.lblYen.BackColor = System.Drawing.SystemColors.Info
        Me.lblYen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYen.Location = New System.Drawing.Point(323, 243)
        Me.lblYen.Name = "lblYen"
        Me.lblYen.Size = New System.Drawing.Size(104, 35)
        Me.lblYen.TabIndex = 6
        '
        'lblPesos
        '
        Me.lblPesos.BackColor = System.Drawing.SystemColors.Info
        Me.lblPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPesos.Location = New System.Drawing.Point(323, 337)
        Me.lblPesos.Name = "lblPesos"
        Me.lblPesos.Size = New System.Drawing.Size(104, 35)
        Me.lblPesos.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 520)
        Me.Controls.Add(Me.lblPesos)
        Me.Controls.Add(Me.lblYen)
        Me.Controls.Add(Me.lblEuros)
        Me.Controls.Add(Me.btnCalcPesos)
        Me.Controls.Add(Me.btnCalcYen)
        Me.Controls.Add(Me.btnCalcEuros)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.Text = "Currency Converter by Jared Tims"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDollars As TextBox
    Friend WithEvents btnCalcEuros As Button
    Friend WithEvents btnCalcYen As Button
    Friend WithEvents btnCalcPesos As Button
    Friend WithEvents lblEuros As Label
    Friend WithEvents lblYen As Label
    Friend WithEvents lblPesos As Label
End Class
