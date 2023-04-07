Public Class Form1
    Private Sub btnCalcMPG_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles btnCalcMPG.Click
        Dim decMiles As Decimal
        'This creates the variable for decMiles'
        Dim decGallons As Decimal
        'This creates the variable for decGallons'
        Dim decMPG As Decimal
        'This creates the variable for decMPG'
        decMiles = txtMiles.Text
        'This tells the program where to store the input'
        decGallons = txtGallons.Text
        'This tells the program where to store the input'
        decMPG = decMiles / decGallons
        'This tells the program how to do the calculations'
        lblMPG.Text = decMPG.ToString
        'This tells the program where to print the results after the calculation'
    End Sub
End Class
