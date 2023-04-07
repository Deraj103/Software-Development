Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        'Declarations
        Dim intArraySize As Integer
        intArraySize = Convert.ToInt16(txtInput.Text)
        Dim shoArray(intArraySize - 1) As Short
        Dim i As Short
        Dim shoTotal As Short
        Dim sngAverage As Single
        Dim shoSmallest As Short = 10000
        Dim shoLargest As Short

        rtbOutput.Clear()

        For i = 0 To intArraySize - 1
            'Input
            shoArray(i) = InputBox("Enter a positive integer.")

            'Processing
            shoTotal = shoTotal + shoArray(i)

            If shoArray(i) < shoSmallest Then
                shoSmallest = shoArray(i)
            End If

            If shoArray(i) > shoLargest Then
                shoLargest = shoArray(i)
            End If

            'Output
            rtbOutput.AppendText(shoArray(i).ToString & vbNewLine)
        Next i

        'Output
        sngAverage = shoTotal / i

        rtbOutput.AppendText("Total: " & shoTotal.ToString & vbNewLine)
        rtbOutput.AppendText("Average: " & sngAverage.ToString & vbNewLine)
        rtbOutput.AppendText("Smallest: " & shoSmallest.ToString & vbNewLine)
        rtbOutput.AppendText("Largest: " & shoLargest.ToString & vbNewLine)
    End Sub

End Class
