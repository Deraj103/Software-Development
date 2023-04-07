Public Class Form1
    Private Sub btnCalcDays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcDays.Click
        'Declarations
        Dim decInput As Decimal
        Dim shoFebDays As Short
        Dim decAnswer As Decimal

        'Input
        decInput = Convert.ToDecimal(txtInput.Text)

        'Processing
        'Call Function
        decAnswer = CalcDays(shoFebDays, decInput)

        'Output
        'Call Procedure
        Call DisplayOutput(decAnswer, decInput)

    End Sub

    Private Function CalcDays(ByVal shoFebDays As Short, ByVal decInput As Decimal) As Decimal
        'Function to determine how many days in Feb for given year.

        If decInput Mod 4 <> 0 Then
            shoFebDays = 28
        ElseIf decInput Mod 400 = 0 Then
            shoFebDays = 29
        ElseIf decInput Mod 100 = 0 Then
            shoFebDays = 28
        Else
            shoFebDays = 29
        End If

        CalcDays = shoFebDays

    End Function

    Private Sub DisplayOutput(ByVal decAnswer As Decimal, ByVal decInput As Decimal)
        'Display output into lblOutput.

        lblOutput.Text = "There are " & decAnswer.ToString & " days in February of the year, " & decInput.ToString & "."

    End Sub
End Class
