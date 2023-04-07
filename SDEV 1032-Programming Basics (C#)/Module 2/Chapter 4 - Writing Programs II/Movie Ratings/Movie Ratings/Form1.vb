Public Class Form1
    Dim mdecAverageRating As Decimal
    Dim mintRateItClicks As Integer
    Dim mdecTotalStars As Decimal

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRateIt.Click
        rtbThankYou.Clear()

        'Declarations
        Dim decStars As Decimal
        Dim strWordRating As String

        'Input
        decStars = nudStars.Value
        strWordRating = txtWordRating.Text

        'Processing
        mdecTotalStars = mdecTotalStars + decStars
        mintRateItClicks = mintRateItClicks + 1

        'Output
        rtbThankYou.AppendText("Thank you for rating this " & strWordRating.ToString & " movie with " & decStars.ToString & " stars!")

    End Sub

    Private Sub btnAverageRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverageRating.Click
        'Declarations are module-level

        'Processing
        mdecAverageRating = mdecTotalStars / mintRateItClicks
        mdecAverageRating = mdecAverageRating

        'Output
        lblAverageRating.Text = mdecAverageRating

    End Sub
End Class
