Public Class Form1

    Private Sub btnNumTimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumTimes.Click
        'Declarations
        Dim bytDie As Byte
        Dim intRollCounter As Integer
        Dim intNumRolls As Integer
        Dim bytDieNum1 As Byte
        Dim bytDieNum2 As Byte
        Dim bytDieNum3 As Byte
        Dim bytDieNum4 As Byte
        Dim bytDieNum5 As Byte
        Dim bytDieNum6 As Byte


        'Input
        intNumRolls = nudInput.Value

        'Processing
        rtbOutput.Clear()
        lblOutput.Text = ""
        rtbOutput.AppendText("Results:" & vbNewLine)
        intRollCounter = 1
        For intRollCounter = 1 To intNumRolls
            bytDie = Int(Rnd() * 6 + 1)
            Select Case bytDie
                Case = 1
                    bytDieNum1 += 1
                Case = 2
                    bytDieNum2 += 1
                Case = 3
                    bytDieNum3 += 1
                Case = 4
                    bytDieNum4 += 1
                Case = 5
                    bytDieNum5 += 1
                Case = 6
                    bytDieNum6 += 1
            End Select

        Next
        intRollCounter += 1
        'Output
        rtbOutput.AppendText("Rolled 1:" & " " & bytDieNum1.ToString & vbNewLine)
        rtbOutput.AppendText("Rolled 2:" & " " & bytDieNum2.ToString & vbNewLine)
        rtbOutput.AppendText("Rolled 3:" & " " & bytDieNum3.ToString & vbNewLine)
        rtbOutput.AppendText("Rolled 4:" & " " & bytDieNum4.ToString & vbNewLine)
        rtbOutput.AppendText("Rolled 5:" & " " & bytDieNum5.ToString & vbNewLine)
        rtbOutput.AppendText("Rolled 6:" & " " & bytDieNum6.ToString & vbNewLine)
    End Sub

    Private Sub btnTarget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTarget.Click
        'Declarations
        Dim bytDie As Byte
        Dim intTargetNum As Integer
        Dim intRollCounter As Integer

        'Input
        intTargetNum = nudInput.Value

        'Processing
        rtbOutput.Clear()
        rtbOutput.AppendText("Results:" & vbNewLine)
        intRollCounter = 1
        If intTargetNum > 6 Then
            lblOutput.Text = "Invalid input, use numbers 1 to 6."
        Else
            Do Until intTargetNum = bytDie
                lblOutput.Text = "Number of rolls:" & " " & intRollCounter
                bytDie = Int(Rnd() * 6 + 1)
                'Output
                rtbOutput.AppendText(bytDie.ToString & vbNewLine)
                intRollCounter += 1
            Loop
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()

    End Sub
End Class
