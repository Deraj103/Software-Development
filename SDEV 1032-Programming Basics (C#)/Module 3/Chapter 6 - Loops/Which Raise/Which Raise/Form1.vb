Public Class Form1
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Declarations
        Dim decPenny As Decimal
        Dim intDay As Integer
        Dim decRaise As Decimal

        'Input
        decRaise = Convert.ToDecimal(txtInputRaise.Text)

        'Processing
        rtbOutput.Clear()
        rtbRec.Clear()
        rtbOutput.AppendText("Penny will grow:" & vbNewLine)

        intDay = 1
        decPenny = 0.01
        For intDay = 1 To 31 Step 1
            decPenny *= 2
            rtbOutput.AppendText("Day" & " " & intDay.ToString & " " & decPenny.ToString("c") & vbNewLine)
        Next
        intDay += 1

        If decRaise > decPenny Then
            rtbRec.AppendText("Choose the" & " " & decRaise.ToString("c") & " " & "raise!")
        Else
            rtbRec.AppendText("Choose the doubling penny!")
        End If

        'Output
        lblOutput.Text = decPenny.ToString("c")

    End Sub
End Class
