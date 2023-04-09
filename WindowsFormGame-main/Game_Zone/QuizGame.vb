Public Class QuizGame
    Dim quotes(5) As String
    Dim indexposition As Integer = 0

    Dim answer1(5) As String
    Dim answerposition As String = 0

    Dim answer2(5) As String
    Dim answerpozition As String = 0

    Dim FinalResult As String



    Private Sub QuizGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Questions
        quotes(0) = "Long term of PC"
        quotes(1) = "Who is founder of microsoft"
        quotes(2) = "Does a phone has OS"
        quotes(3) = "Long term of Dh"
        quotes(4) = "Is a project awesome?"
        quotes(5) = "How many Mbs in one GB"
        NextarrayItem(0)

        'Answers radiobutton one
        answer1(0) = "Personal computer"
        answer1(1) = "Billgate"
        answer1(2) = "Yes "
        answer1(3) = "Dining hall"
        answer1(4) = "Yes"
        answer1(5) = "1024Mbs"
        NextarrayAnswer1(0)

        'Answers radiobutton two
        answer2(0) = "Per centmeter"
        answer2(1) = "Elon mask"
        answer2(2) = "No"
        answer2(3) = "Dancing hell"
        answer2(4) = "No"
        answer2(5) = "1000mbs"
        NextarrayAnswer2(0)
    End Sub
    'A function which call different questions in label text one

    Private Sub NextarrayItem(Index As Integer)
        indexposition += Index
        If (indexposition < 0) Then
            indexposition = 5
        ElseIf (indexposition > 5) Then
            indexposition = 0
        End If
        Label1.Text = quotes(indexposition)
    End Sub
    'A function which call different answers in radio button one
    Private Sub NextarrayAnswer1(Index As Integer)
        answerposition += Index

        If (answerposition < 0) Then
            answerposition = 5
        ElseIf (answerposition > 5) Then
            answerposition = 0
        End If
        RadioButton1.Text = answer1(answerposition)
    End Sub

    'A function which call different answers in radio button two
    Private Sub NextarrayAnswer2(Index As Integer)
        answerpozition += Index
        'Avoiding going over an array
        If (answerpozition < 0) Then
            answerpozition = 5
        ElseIf (answerpozition > 5) Then
            answerpozition = 0
        End If
        RadioButton2.Text = answer2(answerpozition)
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click, RadioButton1.AppearanceChanged
        Guna2GradientButton1.Invalidate()

        If (RadioButton1.Checked = True) Then
            MessageBox.Show("Correct")
            corectAnswer.Text = corectAnswer.Text + 1
        Else
            MessageBox.Show("Wrong")
            wrongAnswer.Text = wrongAnswer.Text + 1
        End If
        NextarrayItem(+1)
        NextarrayAnswer1(+1)
        NextarrayAnswer2(+1)
        Finaesult(+1)
        'Dim Rand As New Random()
        'Dim Index As Integer = Rand.Next(0, quotes.Length - 1)
        'Label1.Text = quotes(Index)
    End Sub
    Private Sub Finaesult(Index As Integer)
        FinalResult += Index
        If (FinalResult < 0) Then
            FinalResult = 5
        ElseIf (FinalResult > 5) Then
            scorePanel.Show()
        End If
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs)
        scorePanel.Show()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class