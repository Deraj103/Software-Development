Public Class Form1
    Private Sub BtnReversIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReversIt.Click
        'Declarations
        Dim strNameInput As String
        Dim strTrimmed As String
        Dim strFirst As String
        Dim strLast As String
        Dim intIndex As Integer
        Dim strRevFirst As String
        Dim strRevLast As String
        Dim strLength As String

        'Input
        strNameInput = txtInput.Text

        'Processing
        strTrimmed = strNameInput.Trim.ToLower
        intIndex = strTrimmed.IndexOf(" ")
        strFirst = strTrimmed.Substring(0, intIndex)
        strLast = strTrimmed.Substring(intIndex + 1)

        'Reverses the first name and capitalizes the first letter
        strLength = strFirst.Length
        For intIndex = strLength - 1 To 0 Step -1
            strRevFirst &= strFirst.Substring(intIndex, 1)
            If strRevFirst.Length = 1 Then
                strRevFirst = strRevFirst.ToUpper
            End If
        Next

        'Reverses the last name and capitalizes the first letter
        strLength = strLast.Length
        For intIndex = strLength - 1 To 0 Step -1
            strRevLast &= strLast.Substring(intIndex, 1)
            If strRevLast.Length = 1 Then
                strRevLast = strRevLast.ToUpper
            End If
        Next

        'Output
        lblOutput.Text = strRevFirst & " " & strRevLast

    End Sub
End Class
