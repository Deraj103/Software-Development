Public Class Form1
    Private Sub btnCalcEuros_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles btnCalcEuros.Click
        Dim decDollars As Decimal
        Dim decEuros As Decimal
        decDollars = txtDollars.Text
        decEuros = decDollars * 0.81
        lblEuros.Text = decEuros.ToString
    End Sub

    Private Sub btnCalcYen_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles btnCalcYen.Click
        Dim decDollars As Decimal
        Dim decYen As Decimal
        decDollars = txtDollars.Text
        decYen = decDollars * 106
        lblYen.Text = decYen.ToString
    End Sub

    Private Sub btnCalcPesos_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles btnCalcPesos.Click
        Dim decDollars As Decimal
        Dim decPesos As Decimal
        decDollars = txtDollars.Text
        decPesos = decDollars * 18.45
        lblPesos.Text = decPesos.ToString
    End Sub
End Class
