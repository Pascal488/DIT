
Imports System.Timers

Public Class TypingGame


    Dim Index = 0
    Dim Play As Boolean = False
    Dim Pause As Boolean = False

    Private Sub TypingGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()

        Me.Dispose()
    End Sub

    Private Sub TypingGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If Play = False Then Exit Sub

        Try

            '----------------------------------

            Dim Key As String = (e.KeyChar)

            '----------------------------------

            If RichTextBox1.Text.Length - 1 = Index Then

                Typing_Stop()

                Test(Key)

                Dim Err = LblErrors.Text * 100 / RichTextBox1.Text.Length
                MsgBox("Your Errors is : " & LblErrors.Text & " Letters (" & CInt(Err) & " %)" & vbNewLine & "Of " & RichTextBox1.Text.Length & " Letters ..." & vbNewLine &
                       "By " & LblTime.Text & " Sec ...", MsgBoxStyle.Information, "Result ...")

                Typing_Reset()

            Else

                Test(Key)

                Try
                    Dim NextKey = RichTextBox1.Text.Substring(Index, 1)
                    LoadPIC(NextKey)
                Catch ex As Exception
                End Try

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text += Timer1.Interval / 1000
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click

        If Play = True Then

            Typing_Stop()

            PlayToolStripMenuItem.Text = "Play"
            LblPause.Visible = True

        Else

            PlayToolStripMenuItem.Text = "Pause"
            LblPause.Visible = False

            If Pause Then

                Typing_Play()

            Else

                Typing_Reset()

                Typing_Play()

            End If

        End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Typing_Reset()
    End Sub

    Private Sub NewTextToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewTextToolStripMenuItem.Click
        FrmInsert.ShowDialog()
    End Sub



    Sub Typing_Play()
        Timer1.Start()

        Play = True
        Pause = False
        PlayToolStripMenuItem.Text = "Stop"
        LblNext.Visible = True

        Try
            Dim Key As Char = RichTextBox1.Text.Substring(Index, 1)
            LoadPIC(Key)
        Catch ex As Exception

        End Try

        NewTextToolStripMenuItem.Enabled = False

    End Sub

    Sub Typing_Reset()

        Index = 0

        Try
            RichTextBox1.Select(0, RichTextBox1.Text.Length - 1)
            '----
            RichTextBox1.SelectionColor = Color.Gray
            RichTextBox1.Enabled = False
        Catch ex As Exception

        End Try

        Play = False
        Pause = False
        LblErrors.Text = "0"
        LblTime.Text = "0"
        LblNextKey.Text = ""
        Timer1.Stop()

        LblPause.Visible = False

        LblNext.Visible = False
        PlayToolStripMenuItem.Text = "Play"
        PictureBox1.Image = Nothing


        NewTextToolStripMenuItem.Enabled = True

    End Sub

    Sub Typing_Stop()

        Timer1.Stop()
        Play = False
        Pause = True
        PlayToolStripMenuItem.Text = "Play"

    End Sub

    Sub Test(Key As Char)

        If Key = RichTextBox1.Text.Substring(Index, 1) Then
            ColorText(Color.Blue)
        Else
            ColorText(Color.Red)
            Beep()
            LblErrors.Text = LblErrors.Text + 1
        End If

    End Sub

    Sub ColorText(Col As Color)

        Dim I = Index

        RichTextBox1.Select(Index, 1)
        RichTextBox1.SelectionColor = Col
        '----
        Index += 1
        '----
        RichTextBox1.Select(Index, 1)
        '----
        RichTextBox1.SelectionColor = Color.Black


    End Sub

    Sub LoadPIC(Key As String)

        PictureBox1.Image = Nothing

        Try
            Select Case Key

                Case " "
                    Key = "Space"
                    PictureBox1.Image = My.Resources.space
                    Exit Select
                Case "a"
                    PictureBox1.Image = My.Resources.letter_a_icon
                    Exit Select
                Case "b"
                    PictureBox1.Image = My.Resources.letter_b_icon
                    Exit Select
                Case "c"
                    PictureBox1.Image = My.Resources.letter_c_icon
                    Exit Select
                Case "d"
                    PictureBox1.Image = My.Resources.letter_d_icon
                    Exit Select
                Case "e"
                    PictureBox1.Image = My.Resources.letter_e_icon
                    Exit Select
                Case "f"
                    PictureBox1.Image = My.Resources.letter_f_icon
                    Exit Select
                Case "g"
                    PictureBox1.Image = My.Resources.letter_g_icon
                    Exit Select
                Case "h"
                    PictureBox1.Image = My.Resources.letter_h_icon
                    Exit Select
                Case "i"
                    PictureBox1.Image = My.Resources.letter_i_icon
                    Exit Select
                Case "j"
                    PictureBox1.Image = My.Resources.letter_j_icon
                    Exit Select
                Case "k"
                    PictureBox1.Image = My.Resources.letter_k_icon
                    Exit Select
                Case "l"
                    PictureBox1.Image = My.Resources.letter_l_icon
                    Exit Select
                Case "m"
                    PictureBox1.Image = My.Resources.letter_m_icon
                    Exit Select
                Case "n"
                    PictureBox1.Image = My.Resources.letter_n_icon
                    Exit Select
                Case "o"
                    PictureBox1.Image = My.Resources.letter_o_icon
                    Exit Select
                Case "p"
                    PictureBox1.Image = My.Resources.letter_p_icon
                    Exit Select
                Case "q"
                    PictureBox1.Image = My.Resources.letter_q_icon
                    Exit Select
                Case "r"
                    PictureBox1.Image = My.Resources.letter_r_icon
                    Exit Select
                Case "s"
                    PictureBox1.Image = My.Resources.letter_s_icon
                    Exit Select
                Case "t"
                    PictureBox1.Image = My.Resources.letter_t_icon
                    Exit Select
                Case "u"
                    PictureBox1.Image = My.Resources.letter_u_icon
                    Exit Select
                Case "v"
                    PictureBox1.Image = My.Resources.letter_v_icon
                    Exit Select
                Case "w"
                    PictureBox1.Image = My.Resources.letter_w_icon
                    Exit Select
                Case "x"
                    PictureBox1.Image = My.Resources.letter_x_icon
                    Exit Select
                Case "y"
                    PictureBox1.Image = My.Resources.letter_y_icon
                    Exit Select
                Case "z"
                    PictureBox1.Image = My.Resources.letter_z_icon
                    Exit Select
                    '---------------------------------------------------------------------------
                Case "A"
                    PictureBox1.Image = My.Resources.letter_uppercase_A_icon
                    Exit Select
                Case "B"
                    PictureBox1.Image = My.Resources.letter_uppercase_B_icon
                    Exit Select
                Case "C"
                    PictureBox1.Image = My.Resources.letter_uppercase_C_icon
                    Exit Select
                Case "D"
                    PictureBox1.Image = My.Resources.letter_uppercase_D_icon
                    Exit Select
                Case "E"
                    PictureBox1.Image = My.Resources.letter_uppercase_E_icon
                    Exit Select
                Case "F"
                    PictureBox1.Image = My.Resources.letter_uppercase_F_icon
                    Exit Select
                Case "G"
                    PictureBox1.Image = My.Resources.letter_uppercase_G_icon
                    Exit Select
                Case "H"
                    PictureBox1.Image = My.Resources.letter_uppercase_H_icon
                    Exit Select
                Case "I"
                    PictureBox1.Image = My.Resources.letter_uppercase_I_icon
                    Exit Select
                Case "J"
                    PictureBox1.Image = My.Resources.letter_uppercase_J_icon
                    Exit Select
                Case "K"
                    PictureBox1.Image = My.Resources.letter_uppercase_K_icon
                    Exit Select
                Case "L"
                    PictureBox1.Image = My.Resources.letter_uppercase_L_icon
                    Exit Select
                Case "M"
                    PictureBox1.Image = My.Resources.letter_uppercase_M_icon
                    Exit Select
                Case "N"
                    PictureBox1.Image = My.Resources.letter_uppercase_N_icon
                    Exit Select
                Case "O"
                    PictureBox1.Image = My.Resources.letter_uppercase_O_icon
                    Exit Select
                Case "P"
                    PictureBox1.Image = My.Resources.letter_uppercase_P_icon
                    Exit Select
                Case "Q"
                    PictureBox1.Image = My.Resources.letter_uppercase_Q_icon
                    Exit Select
                Case "R"
                    PictureBox1.Image = My.Resources.letter_uppercase_R_icon
                    Exit Select
                Case "S"
                    PictureBox1.Image = My.Resources.letter_uppercase_S_icon
                    Exit Select
                Case "T"
                    PictureBox1.Image = My.Resources.letter_uppercase_T_icon
                    Exit Select
                Case "U"
                    PictureBox1.Image = My.Resources.letter_uppercase_U_icon
                    Exit Select
                Case "V"
                    PictureBox1.Image = My.Resources.letter_uppercase_V_icon
                    Exit Select
                Case "W"
                    PictureBox1.Image = My.Resources.letter_uppercase_W_icon
                    Exit Select
                Case "X"
                    PictureBox1.Image = My.Resources.letter_uppercase_X_icon
                    Exit Select
                Case "Y"
                    PictureBox1.Image = My.Resources.letter_uppercase_Y_icon
                    Exit Select
                Case "Z"
                    PictureBox1.Image = My.Resources.letter_uppercase_Z_icon
                    Exit Select

            End Select

            LblNextKey.Text = Key

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TypingGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs) 
        Me.Close()

    End Sub
End Class