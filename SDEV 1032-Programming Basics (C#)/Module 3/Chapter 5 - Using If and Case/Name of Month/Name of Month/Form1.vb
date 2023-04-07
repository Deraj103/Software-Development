Public Class Form1
    Private Sub btnDateName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateName.Click
        rtbOutput.Clear()

        'Declarations
        Dim strDateNum As String
        Dim decNumInput As Decimal

        'Input
        txtDateNum.Text = Convert.ToDecimal(txtDateNum.Text)
        decNumInput = txtDateNum.Text
        strDateNum = txtDateNum.Text

        'Processing
        Select Case strDateNum
            Case Is = 1
                strDateNum = "January"
            Case Is = 2
                strDateNum = "February"
            Case Is = 3
                strDateNum = "March"
            Case Is = 4
                strDateNum = "April"
            Case Is = 5
                strDateNum = "May"
            Case Is = 6
                strDateNum = "June"
            Case Is = 7
                strDateNum = "July"
            Case Is = 8
                strDateNum = "August"
            Case Is = 9
                strDateNum = "September"
            Case Is = 10
                strDateNum = "October"
            Case Is = 11
                strDateNum = "November"
            Case Is = 12
                strDateNum = "December"
            Case Else
                strDateNum = "Unknown"
        End Select
        'Output
        rtbOutput.AppendText("The name of month " & decNumInput.ToString & " is " & strDateNum.ToString & vbNewLine)

    End Sub
End Class
