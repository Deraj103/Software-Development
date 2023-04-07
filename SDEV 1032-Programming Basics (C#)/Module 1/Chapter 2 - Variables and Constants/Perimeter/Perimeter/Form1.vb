Public Class Form1
    Private Sub btnExit_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCalcPeri_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles btnCalcPeri.Click
        Dim shoLength As Short
        'creates the variable for the length'
        Dim shoWidth As Short
        'creates the variable for the width'
        Dim shoPerimeter As Short
        'creates the variable for the perimeter'
        shoLength = txtLength.Text
        'Tells the program where to store the input'
        shoWidth = txtWidth.Text
        'Tells the program where to store the input'
        shoPerimeter = 2 * (shoLength + shoWidth)
        'Tells the program where to store the input and how to perform the calculations'
        lblPerimeter.Text = shoPerimeter.ToString
        'Tells the program where to print the output'
    End Sub

    Private Sub btnCalcArea_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles btnCalcArea.Click
        Dim shoLength As Short
        Dim shoWidth As Short
        Dim shoArea As Short
        shoLength = txtLength.Text
        shoWidth = txtWidth.Text
        shoArea = shoLength * shoWidth
        lblArea.Text = shoArea.ToString
    End Sub
End Class
