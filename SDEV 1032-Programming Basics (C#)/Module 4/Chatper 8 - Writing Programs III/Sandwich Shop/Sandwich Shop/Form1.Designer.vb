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
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpMeats = New System.Windows.Forms.GroupBox()
        Me.chkRoastBeef = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkTurkey = New System.Windows.Forms.CheckBox()
        Me.grpVegetable = New System.Windows.Forms.GroupBox()
        Me.chkPickle = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkSpinich = New System.Windows.Forms.CheckBox()
        Me.grpBread = New System.Windows.Forms.GroupBox()
        Me.radWrap = New System.Windows.Forms.RadioButton()
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.grpCheeses = New System.Windows.Forms.GroupBox()
        Me.chkProvolone = New System.Windows.Forms.CheckBox()
        Me.chkCheddar = New System.Windows.Forms.CheckBox()
        Me.chkSwiss = New System.Windows.Forms.CheckBox()
        Me.grpCondiments = New System.Windows.Forms.GroupBox()
        Me.chkRanch = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpSize.SuspendLayout()
        Me.grpMeats.SuspendLayout()
        Me.grpVegetable.SuspendLayout()
        Me.grpBread.SuspendLayout()
        Me.grpCheeses.SuspendLayout()
        Me.grpCondiments.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpSize.Location = New System.Drawing.Point(44, 52)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(200, 130)
        Me.grpSize.TabIndex = 0
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 78)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(120, 35)
        Me.radLarge.TabIndex = 1
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(6, 37)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(120, 35)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpMeats
        '
        Me.grpMeats.Controls.Add(Me.chkRoastBeef)
        Me.grpMeats.Controls.Add(Me.chkHam)
        Me.grpMeats.Controls.Add(Me.chkTurkey)
        Me.grpMeats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpMeats.Location = New System.Drawing.Point(302, 52)
        Me.grpMeats.Name = "grpMeats"
        Me.grpMeats.Size = New System.Drawing.Size(213, 166)
        Me.grpMeats.TabIndex = 1
        Me.grpMeats.TabStop = False
        Me.grpMeats.Text = "Meats"
        '
        'chkRoastBeef
        '
        Me.chkRoastBeef.AutoSize = True
        Me.chkRoastBeef.Location = New System.Drawing.Point(6, 120)
        Me.chkRoastBeef.Name = "chkRoastBeef"
        Me.chkRoastBeef.Size = New System.Drawing.Size(206, 35)
        Me.chkRoastBeef.TabIndex = 2
        Me.chkRoastBeef.Text = "Roast Beef"
        Me.chkRoastBeef.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(6, 79)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(87, 35)
        Me.chkHam.TabIndex = 1
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkTurkey
        '
        Me.chkTurkey.AutoSize = True
        Me.chkTurkey.Location = New System.Drawing.Point(6, 37)
        Me.chkTurkey.Name = "chkTurkey"
        Me.chkTurkey.Size = New System.Drawing.Size(138, 35)
        Me.chkTurkey.TabIndex = 0
        Me.chkTurkey.Text = "Turkey"
        Me.chkTurkey.UseVisualStyleBackColor = True
        '
        'grpVegetable
        '
        Me.grpVegetable.Controls.Add(Me.chkPickle)
        Me.grpVegetable.Controls.Add(Me.chkTomato)
        Me.grpVegetable.Controls.Add(Me.chkLettuce)
        Me.grpVegetable.Controls.Add(Me.chkSpinich)
        Me.grpVegetable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpVegetable.Location = New System.Drawing.Point(561, 52)
        Me.grpVegetable.Name = "grpVegetable"
        Me.grpVegetable.Size = New System.Drawing.Size(200, 211)
        Me.grpVegetable.TabIndex = 1
        Me.grpVegetable.TabStop = False
        Me.grpVegetable.Text = "Vegetable"
        '
        'chkPickle
        '
        Me.chkPickle.AutoSize = True
        Me.chkPickle.Location = New System.Drawing.Point(11, 162)
        Me.chkPickle.Name = "chkPickle"
        Me.chkPickle.Size = New System.Drawing.Size(138, 35)
        Me.chkPickle.TabIndex = 6
        Me.chkPickle.Text = "Pickle"
        Me.chkPickle.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(11, 121)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(138, 35)
        Me.chkTomato.TabIndex = 5
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(11, 38)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(155, 35)
        Me.chkLettuce.TabIndex = 3
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkSpinich
        '
        Me.chkSpinich.AutoSize = True
        Me.chkSpinich.Location = New System.Drawing.Point(11, 80)
        Me.chkSpinich.Name = "chkSpinich"
        Me.chkSpinich.Size = New System.Drawing.Size(155, 35)
        Me.chkSpinich.TabIndex = 4
        Me.chkSpinich.Text = "Spinich"
        Me.chkSpinich.UseVisualStyleBackColor = True
        '
        'grpBread
        '
        Me.grpBread.Controls.Add(Me.radWrap)
        Me.grpBread.Controls.Add(Me.radWheat)
        Me.grpBread.Controls.Add(Me.radWhite)
        Me.grpBread.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpBread.Location = New System.Drawing.Point(44, 294)
        Me.grpBread.Name = "grpBread"
        Me.grpBread.Size = New System.Drawing.Size(200, 166)
        Me.grpBread.TabIndex = 2
        Me.grpBread.TabStop = False
        Me.grpBread.Text = "Bread"
        '
        'radWrap
        '
        Me.radWrap.AutoSize = True
        Me.radWrap.Location = New System.Drawing.Point(6, 118)
        Me.radWrap.Name = "radWrap"
        Me.radWrap.Size = New System.Drawing.Size(103, 35)
        Me.radWrap.TabIndex = 2
        Me.radWrap.TabStop = True
        Me.radWrap.Text = "Wrap"
        Me.radWrap.UseVisualStyleBackColor = True
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(6, 77)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(120, 35)
        Me.radWheat.TabIndex = 1
        Me.radWheat.TabStop = True
        Me.radWheat.Text = "Wheat"
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Location = New System.Drawing.Point(6, 36)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(120, 35)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'grpCheeses
        '
        Me.grpCheeses.Controls.Add(Me.chkProvolone)
        Me.grpCheeses.Controls.Add(Me.chkCheddar)
        Me.grpCheeses.Controls.Add(Me.chkSwiss)
        Me.grpCheeses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpCheeses.Location = New System.Drawing.Point(302, 294)
        Me.grpCheeses.Name = "grpCheeses"
        Me.grpCheeses.Size = New System.Drawing.Size(213, 166)
        Me.grpCheeses.TabIndex = 1
        Me.grpCheeses.TabStop = False
        Me.grpCheeses.Text = "Cheeses"
        '
        'chkProvolone
        '
        Me.chkProvolone.AutoSize = True
        Me.chkProvolone.Location = New System.Drawing.Point(11, 119)
        Me.chkProvolone.Name = "chkProvolone"
        Me.chkProvolone.Size = New System.Drawing.Size(189, 35)
        Me.chkProvolone.TabIndex = 8
        Me.chkProvolone.Text = "Provolone"
        Me.chkProvolone.UseVisualStyleBackColor = True
        '
        'chkCheddar
        '
        Me.chkCheddar.AutoSize = True
        Me.chkCheddar.Location = New System.Drawing.Point(11, 36)
        Me.chkCheddar.Name = "chkCheddar"
        Me.chkCheddar.Size = New System.Drawing.Size(155, 35)
        Me.chkCheddar.TabIndex = 6
        Me.chkCheddar.Text = "Cheddar"
        Me.chkCheddar.UseVisualStyleBackColor = True
        '
        'chkSwiss
        '
        Me.chkSwiss.AutoSize = True
        Me.chkSwiss.Location = New System.Drawing.Point(11, 78)
        Me.chkSwiss.Name = "chkSwiss"
        Me.chkSwiss.Size = New System.Drawing.Size(121, 35)
        Me.chkSwiss.TabIndex = 7
        Me.chkSwiss.Text = "Swiss"
        Me.chkSwiss.UseVisualStyleBackColor = True
        '
        'grpCondiments
        '
        Me.grpCondiments.Controls.Add(Me.chkRanch)
        Me.grpCondiments.Controls.Add(Me.chkMayo)
        Me.grpCondiments.Controls.Add(Me.chkMustard)
        Me.grpCondiments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpCondiments.Location = New System.Drawing.Point(561, 294)
        Me.grpCondiments.Name = "grpCondiments"
        Me.grpCondiments.Size = New System.Drawing.Size(200, 166)
        Me.grpCondiments.TabIndex = 1
        Me.grpCondiments.TabStop = False
        Me.grpCondiments.Text = "Condiments"
        '
        'chkRanch
        '
        Me.chkRanch.AutoSize = True
        Me.chkRanch.Location = New System.Drawing.Point(6, 120)
        Me.chkRanch.Name = "chkRanch"
        Me.chkRanch.Size = New System.Drawing.Size(121, 35)
        Me.chkRanch.TabIndex = 11
        Me.chkRanch.Text = "Ranch"
        Me.chkRanch.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(6, 37)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(104, 35)
        Me.chkMayo.TabIndex = 9
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(6, 79)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(155, 35)
        Me.chkMustard.TabIndex = 10
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(50, 528)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(208, 80)
        Me.btnNewOrder.TabIndex = 3
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(498, 528)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(263, 80)
        Me.btnPlaceOrder.TabIndex = 4
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Info
        Me.lblPrice.Location = New System.Drawing.Point(859, 470)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(257, 29)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(865, 122)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(332, 325)
        Me.rtbOutput.TabIndex = 6
        Me.rtbOutput.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(859, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Order Summary"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1305, 765)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.grpCondiments)
        Me.Controls.Add(Me.grpCheeses)
        Me.Controls.Add(Me.grpBread)
        Me.Controls.Add(Me.grpVegetable)
        Me.Controls.Add(Me.grpMeats)
        Me.Controls.Add(Me.grpSize)
        Me.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpMeats.ResumeLayout(False)
        Me.grpMeats.PerformLayout()
        Me.grpVegetable.ResumeLayout(False)
        Me.grpVegetable.PerformLayout()
        Me.grpBread.ResumeLayout(False)
        Me.grpBread.PerformLayout()
        Me.grpCheeses.ResumeLayout(False)
        Me.grpCheeses.PerformLayout()
        Me.grpCondiments.ResumeLayout(False)
        Me.grpCondiments.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpMeats As GroupBox
    Friend WithEvents chkRoastBeef As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkTurkey As CheckBox
    Friend WithEvents grpVegetable As GroupBox
    Friend WithEvents chkPickle As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkSpinich As CheckBox
    Friend WithEvents grpBread As GroupBox
    Friend WithEvents radWrap As RadioButton
    Friend WithEvents radWheat As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents grpCheeses As GroupBox
    Friend WithEvents chkProvolone As CheckBox
    Friend WithEvents chkCheddar As CheckBox
    Friend WithEvents chkSwiss As CheckBox
    Friend WithEvents grpCondiments As GroupBox
    Friend WithEvents chkRanch As CheckBox
    Friend WithEvents chkMayo As CheckBox
    Friend WithEvents chkMustard As CheckBox
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents Label2 As Label
End Class
