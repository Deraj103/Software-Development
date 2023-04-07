Public Class Form1
    Dim mdecBegBalance As Decimal = 1000


    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        'Declarations - Some are public variables
        rtbOutput.Clear()
        Dim decInput As Decimal
        Dim strBadInput As String

        'Input
        decInput = Convert.ToDecimal(txtInput.Text)

        'Processing
        If decInput <= 0 Then
            strBadInput = "That is not a valid amount to deposit."
            rtbOutput.AppendText(strBadInput)
        Else
            mdecBegBalance += decInput
            rtbOutput.AppendText(decInput.ToString("c") & " deposit successful.")
        End If

        'Output
        lblBalance.Text = mdecBegBalance.ToString("c")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBalance.Text = mdecBegBalance.ToString("c")
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        'Declarations - Some are public variables
        rtbOutput.Clear()
        Dim decInput As Decimal
        Dim strBadInput As String

        'Input
        decInput = Convert.ToDecimal(txtInput.Text)

        'Processing
        If decInput > mdecBegBalance Then
            strBadInput = "Cannot withdraw more than you have."
            rtbOutput.AppendText(strBadInput)
        ElseIf decInput <= 0 Then
            strBadInput = "Cannot use 0 or negative numbers."
            rtbOutput.AppendText(strBadInput)
        Else
            mdecBegBalance -= decInput
            rtbOutput.AppendText(decInput.ToString("c") & " withdraw successful.")
        End If

        'Output
        lblBalance.Text = mdecBegBalance.ToString("c")
    End Sub
End Class
