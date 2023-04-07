Public Class Form1

    Private Sub StartUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        radLarge.Checked = True
        radWhite.Checked = True
        rtbOutput.AppendText("•Size:" & vbNewLine)
        rtbOutput.AppendText("•Bread:" & vbNewLine)
        rtbOutput.AppendText("•Meat(s):" & vbNewLine)
        rtbOutput.AppendText("•Cheese(s):" & vbNewLine)
        rtbOutput.AppendText("•Vegetable(s):" & vbNewLine)
        rtbOutput.AppendText("•Condiment(s):" & vbNewLine)
        lblPrice.Text = "Total:"
    End Sub


    Private Sub btnNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewOrder.Click
        'Clears settings and starts over for new order
        radLarge.Checked = True
        radWhite.Checked = True
        chkTurkey.Checked = False
        chkHam.Checked = False
        chkRoastBeef.Checked = False
        chkLettuce.Checked = False
        chkSpinich.Checked = False
        chkTomato.Checked = False
        chkPickle.Checked = False
        chkCheddar.Checked = False
        chkSwiss.Checked = False
        chkProvolone.Checked = False
        chkMayo.Checked = False
        chkMustard.Checked = False
        chkRanch.Checked = False
        rtbOutput.Clear()
        lblPrice.Text = "Total:"

        rtbOutput.AppendText("•Size:" & vbNewLine)
        rtbOutput.AppendText("•Bread:" & vbNewLine)
        rtbOutput.AppendText("•Meat(s):" & vbNewLine)
        rtbOutput.AppendText("•Cheese(s):" & vbNewLine)
        rtbOutput.AppendText("•Vegetable(s):" & vbNewLine)
        rtbOutput.AppendText("•Condiment(s):" & vbNewLine)

    End Sub

    Private Sub btnPlaceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        'Declarations
        Const decLargeSize As Decimal = 4
        Const decSmallSize As Decimal = 2
        Const decMeats As Decimal = 1
        Const decVegatable As Decimal = 0.5
        Const decCheeses As Decimal = 1
        Const decCondiments As Decimal = 0.25
        Dim decPrice As Decimal
        Dim strSize As String
        Dim strMeats As String
        Dim strVegetable As String
        Dim strBread As String
        Dim strCheeses As String
        Dim strCondiments As String


        'Processing
        'Get size
        If radLarge.Checked Then
            decPrice += decLargeSize
            strSize = "Large"
        Else
            decPrice += decSmallSize
            strSize = "Small"
        End If

        'Get Bread type
        If radWhite.Checked Then
            strBread = "White"
        ElseIf radWheat.Checked Then
            strBread = "Wheat"
        Else
            strBread = "Wrap"
        End If

        'Get Meats
        If chkTurkey.Checked Then
            decPrice += decMeats
            strMeats += "Turkey "
        End If
        If chkHam.Checked Then
            decPrice += decMeats
            strMeats += "Ham "
        End If
        If chkRoastBeef.Checked Then
            decPrice += decMeats
            strMeats += "Roast Beef "
        End If

        'Get Vegetables
        If chkLettuce.Checked Then
            decPrice += decVegatable
            strVegetable += "Lettuce "
        End If
        If chkSpinich.Checked Then
            decPrice += decVegatable
            strVegetable += "Spinich "
        End If
        If chkTomato.Checked Then
            decPrice += decVegatable
            strVegetable += "Tomato "
        End If
        If chkPickle.Checked Then
            decPrice += decVegatable
            strVegetable += "Pickle "
        End If

        'Get Cheeses
        If chkCheddar.Checked Then
            decPrice += decCheeses
            strCheeses += "Cheddar "
        End If
        If chkSwiss.Checked Then
            decPrice += decCheeses
            strCheeses += "Swiss "
        End If
        If chkProvolone.Checked Then
            decPrice += decCheeses
            strCheeses += "Provolone "
        End If

        'Get Condiments
        If chkMayo.Checked Then
            decPrice += decCondiments
            strCondiments += "Mayo "
        End If
        If chkMustard.Checked Then
            decPrice += decCondiments
            strCondiments += "Mustard "
        End If
        If chkRanch.Checked Then
            decPrice += decCondiments
            strCondiments += "Ranch "
        End If

        'Output
        rtbOutput.Clear()
        rtbOutput.AppendText("•Size:" & strSize & " " & "Sandwich" & vbNewLine)
        rtbOutput.AppendText("•Bread:" & strBread & " " & "Bread" & vbNewLine)
        rtbOutput.AppendText("•Meat(s):" & strMeats & vbNewLine)
        rtbOutput.AppendText("•Cheese(s):" & strCheeses & vbNewLine)
        rtbOutput.AppendText("•Vegetable(s):" & strVegetable & vbNewLine)
        rtbOutput.AppendText("•Condiment(s):" & strCondiments & vbNewLine)
        lblPrice.Text = "Total:" & decPrice.ToString("c") & vbNewLine

    End Sub

End Class
