Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnDays.Click
        'Declarations
        Dim strMonths() As String = {"January", "Feburary", "March", "April", "May", "June", "July", "August", "September",
            "October", "November", "December"}
        Dim intDays() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim strInput As String
        Dim i As Integer

        'Clear Label
        lblOutput.Text = " "

        'Input
        strInput = Convert.ToDecimal(txtInput.Text)
        i = strInput - 1

        'Processing
        If strInput = intDays(i) Then
            intDays(i) = strInput
        End If

        If strInput = strMonths(i) Then
            strMonths(i) = strInput
        End If

        'Output
        lblOutput.Text = "There are " & intDays(i).ToString & " days in " & strMonths(i).ToString & vbNewLine
    End Sub
End Class
