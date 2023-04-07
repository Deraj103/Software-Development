Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        'Declarations
        Dim intRndNum(5) As Integer
        Dim intLargest As Integer
        Dim intSmallest As Integer = 10000
        Dim i As Integer

        'Processing - Assigning Random Numbers to the Array Elements and finding
        'the Largest/ Smallest number
        For i = 0 To 5
            'Random Number Generator
            intRndNum(i) = Int(Rnd() * 100 + 1)

            'Finding the Largest Number
            If intRndNum(i) > intLargest Then
                intLargest = intRndNum(i)
            End If

            'Finding the Smallest Number
            If intRndNum(i) < intSmallest Then
                intSmallest = intRndNum(i)
            End If
        Next i

        'Output
        lbl1.Text = intRndNum(0).ToString
        lbl2.Text = intRndNum(1).ToString
        lbl3.Text = intRndNum(2).ToString
        lbl4.Text = intRndNum(3).ToString
        lbl5.Text = intRndNum(4).ToString
        lbl6.Text = intRndNum(5).ToString
        lblLargest.Text = intLargest.ToString
        lblSmallest.Text = intSmallest.ToString

    End Sub

End Class
