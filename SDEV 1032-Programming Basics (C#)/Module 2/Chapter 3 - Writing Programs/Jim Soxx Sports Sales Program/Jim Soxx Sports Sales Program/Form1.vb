Public Class Form1
    Private Sub Button2_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'Declarations
        Const decPriceFootballs As Decimal = 44.95
        Const decPriceBasketballs As Decimal = 49.95
        Const decPriceVolleyballs As Decimal = 39.95
        Const sngSalesTax As Single = 0.05
        Dim shoNumFootballs As Short
        Dim shoNumBasketballs As Short
        Dim shoNumVolleyballs As Short
        Dim shoTotalItems As Short
        Dim decSubtotalFootballs As Decimal
        Dim decSubtotalBasketballs As Decimal
        Dim decSubtotalVolleyballs As Decimal
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotal As Decimal

        'Input
        shoNumBasketballs = Convert.ToInt16(txtNumBasketballs.Text)
        shoNumFootballs = Convert.ToInt16(txtNumFootballs.Text)
        shoNumVolleyballs = Convert.ToInt16(txtNumVolleyballs.Text)

        'Processing
        'Find total number of items
        shoTotalItems = shoNumFootballs + shoNumBasketballs + shoNumVolleyballs
        'Calculate cost of each item
        decSubtotalFootballs = shoNumFootballs * decPriceFootballs
        decSubtotalBasketballs = shoNumBasketballs * decPriceBasketballs
        decSubtotalVolleyballs = shoNumVolleyballs * decPriceVolleyballs
        'Calculate total
        decSubtotal = decSubtotalFootballs + decSubtotalBasketballs + decSubtotalVolleyballs
        'Calculate sales tax
        decSalesTax = decSubtotal * sngSalesTax
        'Calculate Total
        decTotal = decSalesTax + decSubtotal

        'Output
        lblTotalItems.Text = shoTotalItems.ToString("n0")
        lblSubtotalFootballs.Text = decSubtotalFootballs.ToString("c2")
        lblSubtotalBasketballs.Text = decSubtotalBasketballs.ToString("c2")
        lblSubtotalVolleyballs.Text = decSubtotalVolleyballs.ToString("c2")
        lblSubtotal.Text = decSubtotal.ToString("c2")
        lblSalesTax.Text = decSalesTax.ToString("c2")
        lblTotal.Text = decTotal.ToString("c2")
    End Sub
End Class
