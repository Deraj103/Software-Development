'Prologue

Public Class frmDustyLenzkapp
    Dim mdecTotalSales As Decimal
    'Total sales for the day


    Private Sub frmDustyLenzkapp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Clears the rtb and adds a header
        rtbOutput.Clear()
        rtbOutput.AppendText("         Dusty Lenzkapp's Camerarama" & vbNewLine)
        rtbOutput.AppendText("             Daily Sales Totals" & vbNewLine & vbNewLine)
        rtbOutput.AppendText("Employee        Sales   Rate  Commission" & vbNewLine)

        'Finds and displays today's date

        Dim datToday As Date

        datToday = Now()

        lblDate.Text = datToday.ToLongDateString

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clears the rtb and adds a header
        mdecTotalSales = 0
        rtbOutput.Clear()
        txtName.Clear()
        txtSales.Clear()
        rtbOutput.AppendText("         Dusty Lenzkapp's Camerarama" & vbNewLine)
        rtbOutput.AppendText("             Daily Sales Totals" & vbNewLine & vbNewLine)
        rtbOutput.AppendText("Employee        Sales   Rate  Commission" & vbNewLine)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'Calculates commission and adds a detail line

        'Declarations
        Dim strName As String
        Dim decSales As Decimal
        Dim decCommRate As Decimal
        Dim decComm As Decimal
        Dim strOut As String

        'Input
        strName = txtName.Text
        decSales = Convert.ToDecimal(txtSales.Text)
        decCommRate = nudCommRate.Value

        'Processing
        decCommRate = decCommRate / 100
        decComm = decCommRate * decSales
        mdecTotalSales = mdecTotalSales + decSales

        'Output
        strOut = strName & ControlChars.Tab & decSales.ToString("c") & ControlChars.Tab & decCommRate.ToString("P") & ControlChars.Tab & decComm.ToString("c") & vbNewLine
        rtbOutput.AppendText(strOut)


    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'Display total
        rtbOutput.AppendText("Total       " & mdecTotalSales.ToString("c") & vbNewLine)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

End Class
