Public Class Form1
    Private Sub btnCalcPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcPay.Click
        'Declarations
        Dim strFirst As String
        Dim strLast As String
        Dim dblPayRate As Double
        Dim dblMon As Double
        Dim dblTues As Double
        Dim dblWed As Double
        Dim dblThurs As Double
        Dim dblFri As Double
        Dim srdFile As System.IO.StreamReader
        Dim decTotalPay As Decimal
        Dim decPay As Decimal
        Dim decHours As Decimal
        Dim strRecord() As String
        Dim strLine As String

        'Display Header
        rtbOutput.Clear()
        rtbOutput.AppendText("Student Name      Rate:       Hours:       Pay:" & vbNewLine & vbNewLine)

        'Open File
        srdFile = New System.IO.StreamReader("Payroll.txt")

        Do Until srdFile.Peek = -1
            strLine = srdFile.ReadLine
            strRecord = strLine.Split(",")
            strFirst = strRecord(0)
            strLast = strRecord(1)
            dblPayRate = Convert.ToDouble(strRecord(2))
            dblMon = Convert.ToDouble(strRecord(3))
            dblTues = Convert.ToDouble(strRecord(4))
            dblWed = Convert.ToDouble(strRecord(5))
            dblThurs = Convert.ToDouble(strRecord(6))
            dblFri = Convert.ToDouble(strRecord(7))

            'Processing
            decHours = dblMon + dblTues + dblWed + dblThurs + dblFri
            decPay = decHours * dblPayRate
            decTotalPay += decPay

            'Output
            rtbOutput.AppendText(strFirst.PadRight(8) & strLast.PadRight(10) & dblPayRate.ToString("c").PadRight(12) & decHours.ToString.PadRight(12) & decPay.ToString("c").PadRight(10) & vbNewLine)

        Loop

        'Postprocessing
        srdFile.Close()

        'Display Total
        rtbOutput.AppendText(vbNewLine)
        rtbOutput.AppendText("Total Pay:" & decTotalPay.ToString("c"))
    End Sub
End Class
