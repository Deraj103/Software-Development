Public Class Form1

    Private Sub btnCalcFutVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcFutVal.Click
        'Declarations
        Dim decInitialAmt As Decimal
        Dim decGrowthRate As Decimal
        Dim intNumCycles As Integer
        Dim decGrowth As Decimal
        Dim intCycleCounter As Integer
        'Input
        decInitialAmt = Convert.ToDecimal(txtInitialGrowth.Text)
        decGrowthRate = Convert.ToDecimal(txtGrowthRate.Text)
        intNumCycles = Convert.ToInt32(txtNumCycles.Text)
        'Processing
        decGrowthRate /= 100
        intCycleCounter = 1
        For intCycleCounter = 1 To intNumCycles
            decGrowth = decInitialAmt * decGrowthRate
            decInitialAmt += decGrowth
        Next
        intCycleCounter += 1
        'Output
        lblOutput.Text = decInitialAmt.ToString("c") & vbNewLine

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Declarations
        Dim decInitialAmt As Decimal
        Dim decGrowthRate As Decimal
        Dim decGrowth As Decimal
        Dim decTargetAmt As Decimal
        Dim decCycleCounter As Decimal
        'Input
        decInitialAmt = Convert.ToDecimal(txtInitialGrowth.Text)
        decGrowthRate = Convert.ToDecimal(txtGrowthRate.Text)
        decTargetAmt = Convert.ToDecimal(txtTargetAmt.Text)
        'Processing
        decGrowthRate /= 100
        Do While decInitialAmt <= decTargetAmt
            decGrowth = decInitialAmt * decGrowthRate
            decInitialAmt += decGrowth
            decCycleCounter += 1
        Loop
        'Output
        lblOutput.Text = "Number of Cycles:" & " " & decCycleCounter.ToString
    End Sub
End Class
