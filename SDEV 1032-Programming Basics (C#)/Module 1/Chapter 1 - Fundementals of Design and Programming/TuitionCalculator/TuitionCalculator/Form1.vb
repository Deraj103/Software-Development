Public Class Form1
    Private Sub btnExit_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnTuition_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles btnTuition.Click
        Dim shoCredits As Short
        Dim decTuition As Decimal
        shoCredits = txtCredits.Text
        decTuition = shoCredits * 125
        lblTuition.Text = decTuition.ToString
    End Sub
End Class
