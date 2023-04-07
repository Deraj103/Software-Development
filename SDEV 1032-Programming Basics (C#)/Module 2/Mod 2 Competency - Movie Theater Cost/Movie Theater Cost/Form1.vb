Public Class Form1
    Dim mdecTicketSubtotal As Decimal
    Dim mdecSnackSubtotal As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTicketSubtotal.Click
        'Declarations
        Const decAdultCost As Decimal = 10
        Const decChildrenCost As Decimal = 6
        Const decSeniorCost As Decimal = 8
        Dim bytAdult As Byte
        Dim bytChildren As Byte
        Dim bytSenior As Byte

        'Input
        bytAdult = Convert.ToByte(nudAdults.Value)
        bytChildren = Convert.ToByte(nudChildren.Value)
        bytSenior = Convert.ToByte(nudSeniors.Value)

        'Processing
        bytAdult = decAdultCost * nudAdults.Value
        bytChildren = decChildrenCost * nudChildren.Value
        bytSenior = decSeniorCost * nudSeniors.Value
        mdecTicketSubtotal = bytAdult + bytChildren + bytSenior

        'Output
        lblTicketSubtotal.Text = mdecTicketSubtotal.ToString("c")

    End Sub

    Private Sub btnSnackSubtotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnackSubtotal.Click
        'Declarations
        Const decPopcornCost As Decimal = 5
        Const decDrinkCost As Decimal = 3
        Dim bytPopcorn As Byte
        Dim bytDrink As Byte

        'Input
        bytPopcorn = Convert.ToByte(nudPopcorn.Value)
        bytDrink = Convert.ToByte(nudDrink.Value)

        'Processing
        bytPopcorn = decPopcornCost * nudPopcorn.Value
        bytDrink = decDrinkCost * nudDrink.Value
        mdecSnackSubtotal = bytPopcorn + bytDrink

        'Output
        lblSnackSubtotal.Text = mdecSnackSubtotal.ToString("c")

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'Declarations
        Dim decTotal As Decimal

        'Input

        'Processing
        decTotal = mdecTicketSubtotal + mdecSnackSubtotal

        'Output
        lblTotal.Text = decTotal.ToString("c")

    End Sub
End Class
