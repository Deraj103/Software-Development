Public Class Form1

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Declarations
        Dim intMonth As Integer
        Dim intDay As Integer
        Dim intYear As Integer
        Dim intAddDays As Integer
        Dim intTotalDays As Integer
        Dim intMonthDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim i As Integer
        Dim intAnswer As Integer

        'Input
        intMonth = nudMonth.Value
        intDay = nudDay.Value
        intYear = nudYear.Value
        intAddDays = nudDaysAdded.Value


        'Processing
        'Calls procedure to check for leap year and wrong number of days
        intMonthDays(1) = Answer(intAnswer, intYear)
        i = intMonthDays(intMonth - 1)

        Call WrongNumDays(intDay, i)

        intTotalDays = intDay + intAddDays

        Do
            If intTotalDays > intMonthDays(intMonth - 1) Then
                intTotalDays -= intMonthDays(intMonth - 1)
                intMonthDays(1) = Answer(intAnswer, intYear)
                intMonth += 1
                If intMonth > 12 Then
                    intMonth = 1
                    intYear += 1
                    i = intMonthDays(intMonth - 1)
                    Call WrongNumDays(intDay, i)
                End If
            End If
        Loop Until intTotalDays <= intMonthDays(intMonth - 1)

        'Output
        lblOutput.Text = intMonth.ToString & "/" & intTotalDays.ToString & "/" & intYear.ToString

        'Displays nothing if wrong number of days were chosen for given month.
        If intDay > i Then
            lblOutput.Text = " "
        End If

    End Sub


    'Checks for leap year
    Private Function Answer(ByVal intAnswer As Integer, ByVal intYear As Integer) As Integer
        If intYear Mod 4 <> 0 Then
            intAnswer = 28
        ElseIf intYear Mod 400 = 0 Then
            intAnswer = 29
        ElseIf intYear Mod 100 = 0 Then
            intAnswer = 28
        Else
            intAnswer = 29
        End If

        Return intAnswer

    End Function

    'Displays a message for invalid number of days
    Private Sub WrongNumDays(intDay As Integer, i As Integer)
        If intDay > i Then
            MessageBox.Show("Wrong number of days for this month.")
        End If
    End Sub

End Class