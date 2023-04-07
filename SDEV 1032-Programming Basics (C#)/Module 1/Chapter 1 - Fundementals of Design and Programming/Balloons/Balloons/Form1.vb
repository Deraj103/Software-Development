Public Class Form1
    Private Sub BtnCalc_Click(ByVal sender As System.Object,
                             ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim shoBalloons As Short
        Dim decCost As Decimal
        shoBalloons = txtBalloons.Text
        decCost = shoBalloons * 3.5
        lblCost.Text = decCost.ToString
    End Sub
End Class
