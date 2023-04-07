Public Class Form1
    Dim mintRndTotal As Integer
    Dim mintRndNum1 As Integer
    Dim mintRndNum2 As Integer

    Private Sub Rnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Randomize()
    End Sub

    Private Sub btnNewProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProblem.Click
        'Clears the outputs for new problem
        txtAnswer.Clear()
        lblOutput.Text = " "
        'Calls sub that displays the two random numbers 
        Call Display()
    End Sub

    Private Sub btnCheckAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAnswer.Click
        Dim intAnswer As Integer
        'Calls funstion to check the user's answer
        intAnswer = CalcAnswer(mintRndTotal, mintRndNum1, mintRndNum2)
        'Clears the radio buttons to prepare for new flash card
        radAddition.Checked = False
        radSubtraction.Checked = False
    End Sub

    'Function that generates the two random numbers
    Private Function RandomNumber()
        Dim bytRndNum As Byte

        bytRndNum = Int(Rnd() * 50 + 1)

        Return bytRndNum
    End Function

    'Function that calculates the user's answer and provides feedback
    Private Function CalcAnswer(ByVal mintRndTotal As Integer, ByVal mintRndNum1 As Integer, ByVal mintRndNum2 As Integer)
        Dim intAnswer As Integer
        'Determines what mathematics is needed based on what radio button is pressed
        If radAddition.Checked Then
            mintRndTotal = mintRndNum1 + mintRndNum2
        Else
            mintRndTotal = mintRndNum1 - mintRndNum2
        End If
        'Provides feedback if answer is correct or wrong
        If txtAnswer.Text = mintRndTotal Then
            lblOutput.Text = "Excellent! You are correct!"
        Else
            lblOutput.Text = "Whoops, that is not correct, try again."
        End If

        Return intAnswer
    End Function

    'Sub that displays the generated numbers and provides which math symbol is needed
    Private Sub Display()

        mintRndNum1 = RandomNumber()
        mintRndNum2 = RandomNumber()
        'Displays the two generated numbers and displays them based on what number is higher or lower
        If mintRndNum1 > mintRndNum2 Then
            lblTop.Text = mintRndNum1
            lblBottom.Text = mintRndNum2
        Else
            lblBottom.Text = mintRndNum1
            lblTop.Text = mintRndNum2
        End If
        'Checks to see what math symbol is needed based on what radio button is pressed
        If radAddition.Checked Then
            lblSymbol.Text = "+"
        Else
            lblSymbol.Text = "-"
        End If
    End Sub
End Class
