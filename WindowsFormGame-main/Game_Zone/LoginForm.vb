Imports System.Data.OleDb

Public Class LoginForm
    ReadOnly con As New OleDbConnection(My.Settings.LoginFormConnectionString)

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If (Guna2TextBox1.Text = Nothing Or Guna2TextBox2.Text = Nothing) Then
            MessageBox.Show("Enter some credential ")
            Exit Sub
        End If

        If (con.State = ConnectionState.Closed) Then
            con.Open()
        End If
        Using Command As New OleDbCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Passoword = @Passoword ", con)
            Command.Parameters.AddWithValue("@UserName", OleDbType.VarChar).Value = Guna2TextBox1.Text.Trim
            Command.Parameters.AddWithValue("@Passoword", OleDbType.VarChar).Value = Guna2TextBox2.Text.Trim
            Dim count = Convert.ToInt32(Command.ExecuteScalar())
            If (count > 0) Then
                MessageBox.Show("Login Found")
                GameShows.Show()
            Else
                MessageBox.Show("Invalid user")
            End If
        End Using
        con.Close()

    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        QuizGame.Show()
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton2.Click
        TypingGame.Show()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        If (Guna2TextBox1.Text = Nothing Or Guna2TextBox2.Text = Nothing) Then
            MessageBox.Show("Enter some credential ")
            Exit Sub
        End If
        If (con.State = ConnectionState.Closed) Then
            con.Open()
        End If

        Using create As New OleDbCommand("INSERT INTO Users(UserName,Passoword) VALUES(@UserName,@Passoword)", con)
            create.Parameters.Add("@UserName", OleDbType.VarChar).Value = Guna2TextBox1.Text.Trim
            create.Parameters.Add("@Passoword", OleDbType.VarChar).Value = Guna2TextBox2.Text.Trim

            If (create.ExecuteNonQuery) Then
                MessageBox.Show("Account created")
            Else
                MessageBox.Show("Error")
            End If
        End Using
        con.Close()



    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Close()
        WelcomePage.Show()
    End Sub
End Class