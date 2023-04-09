Public Class WelcomePage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoginForm.Show()
    End Sub

    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
