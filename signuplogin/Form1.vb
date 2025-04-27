Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        login.TopLevel = False
        sidepanel.Controls.Add(login)
        login.BringToFront()
        login.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsingup.Click


        signup.TopLevel = False
        sidepanel.Controls.Add(signup)
        signup.BringToFront()
        signup.Show()

    End Sub

    Private Sub btnexit1_Click(sender As Object, e As EventArgs) Handles btnexit2.Click
        Me.Close()
    End Sub
End Class
