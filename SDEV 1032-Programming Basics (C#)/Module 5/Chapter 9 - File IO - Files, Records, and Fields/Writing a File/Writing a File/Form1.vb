Public Class Form1
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllDone.Click
        End
    End Sub

    Private Sub btnStoreData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStoreData.Click
        'Decclarations
        Dim strFirst As String
        Dim strLast As String
        Dim strPayRate As String
        Dim strMon As String
        Dim strTues As String
        Dim strWed As String
        Dim strThurs As String
        Dim strFri As String
        Dim swrFile As System.IO.StreamWriter
        Dim strDetail As String

        'Preprocessing
        swrFile = IO.File.AppendText("Payroll.txt")

        'Input
        strFirst = txtFirst.Text
        strLast = txtLast.Text
        strPayRate = txtPayRate.Text
        strMon = txtMon.Text
        strTues = txtTues.Text
        strWed = txtWed.Text
        strThurs = txtThurs.Text
        strFri = txtFri.Text

        'Processing
        strDetail = strFirst & "," & strLast & "," & strPayRate & "," &
            strMon & "," & strTues & "," & strWed & "," & strThurs & "," & strFri

        'Output
        swrFile.WriteLine(strDetail)

        'Postprocessing
        swrFile.Close()
        txtFirst.Clear()
        txtLast.Clear()
        txtPayRate.Clear()
        txtMon.Clear()
        txtTues.Clear()
        txtWed.Clear()
        txtThurs.Clear()
        txtFri.Clear()
    End Sub
End Class
