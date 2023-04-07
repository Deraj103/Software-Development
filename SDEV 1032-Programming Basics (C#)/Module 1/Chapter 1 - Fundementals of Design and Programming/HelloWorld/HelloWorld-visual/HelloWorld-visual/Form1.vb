Public Class HelloWorld
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHello.Click

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim username As String
        username = txtName.Text
        lblResult.Text = "Greetings, " & username
    End Sub

    Private Sub btnBye_Click(sender As Object, e As EventArgs) Handles btnBye.Click
        Dim username As String
        username = txtName.Text
        lblResult.Text = "Goodbye, " & username
    End Sub
End Class
