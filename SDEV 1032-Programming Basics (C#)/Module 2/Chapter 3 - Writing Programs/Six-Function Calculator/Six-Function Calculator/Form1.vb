Public Class Form1
    Private Sub btnAddition_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles btnAddition.Click
        'Declarations
        Dim shoLeftNum As Short
        Dim shoRightNum As Short
        Dim decCalculations As Integer

        'Input
        shoLeftNum = txtLeftNum.Text
        shoRightNum = txtRightNum.Text

        'Processing
        decCalculations = shoLeftNum + shoRightNum

        'Output
        lblCalculations.Text = decCalculations.ToString("N2")
    End Sub

    Private Sub btnSubtraction_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles btnSubtraction.Click
        'Declarations
        Dim shoLeftNum As Short
        Dim shoRightNum As Short
        Dim decCalculations As Integer

        'Input
        shoLeftNum = txtLeftNum.Text
        shoRightNum = txtRightNum.Text

        'Processing
        decCalculations = shoLeftNum - shoRightNum

        'Output
        lblCalculations.Text = decCalculations.ToString("N2")
    End Sub

    Private Sub btnMulitplication_Click(ByVal sender As System.Object,
                                        ByVal e As System.EventArgs) Handles btnMulitplication.Click
        'Declarations
        Dim shoLeftNum As Short
        Dim shoRightNum As Short
        Dim decCalculations As Integer

        'Input
        shoLeftNum = txtLeftNum.Text
        shoRightNum = txtRightNum.Text

        'Processing
        decCalculations = shoLeftNum * shoRightNum

        'Output
        lblCalculations.Text = decCalculations.ToString("N2")
    End Sub

    Private Sub btnLongDivision_Click(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles btnLongDivision.Click
        'Declarations
        Dim decLeftNum As Decimal
        Dim decRightNum As Decimal
        Dim decCalculations As Decimal

        'Input
        decLeftNum = txtLeftNum.Text
        decRightNum = txtRightNum.Text

        'Processing
        decCalculations = decLeftNum / decRightNum

        'Output
        lblCalculations.Text = decCalculations.ToString("N2")
    End Sub

    Private Sub btnIntegerDivision_Click(ByVal sender As System.Object,
                                         ByVal e As System.EventArgs) Handles btnIntegerDivision.Click
        'Declarations
        Dim shoLeftNum As Short
        Dim shoRightNum As Short
        Dim decCalculations As Integer

        'Input
        shoLeftNum = txtLeftNum.Text
        shoRightNum = txtRightNum.Text

        'Processing
        decCalculations = shoLeftNum \ shoRightNum

        'Output
        lblCalculations.Text = decCalculations.ToString("N2")
    End Sub

    Private Sub btnModulusDivision_Click(ByVal sender As System.Object,
                                         ByVal e As System.EventArgs) Handles btnModulusDivision.Click
        'Declarations
        Dim shoLeftNum As Short
        Dim shoRightNum As Short
        Dim decCalculations As Integer

        'Input
        shoLeftNum = txtLeftNum.Text
        shoRightNum = txtRightNum.Text

        'Processing
        decCalculations = shoLeftNum Mod shoRightNum

        'Output
        lblCalculations.Text = decCalculations.ToString("N2")
    End Sub
End Class
