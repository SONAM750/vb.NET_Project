Imports System.Data.OleDb

Public Class ponggame
    Dim ball_X As Integer = 6
    Dim ball_Y As Integer = 4
    Dim score As Integer = 0
    Public currentUser As String = login.loggeduser
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Right AndAlso paddle.Right < 778 Then
            paddle.Left += 30
        End If
        If keyData = Keys.Left AndAlso paddle.Left > 0 Then
            paddle.Left -= 30
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ball_movement()
        Game_over()
    End Sub
    Private Sub ball_movement()
        ball.Left += ball_X
        ball.Top += ball_Y
        If ball.Left + ball.Width > ClientSize.Width OrElse ball.Left < 0 Then
            ball_X = -ball_X

        End If
        If ball.Top < 0 OrElse ball.Bounds.IntersectsWith(paddle.Bounds) Then
            ball_Y = -ball_Y
            score += 1
            labelscore.Text = "Score: " & score
        End If
    End Sub
    Private Sub Game_over()
        If ball.Top + ball.Height > ClientSize.Height Then
            Timer1.Stop()
            MessageBox.Show("Game over!!")
            ball.Location = New Point(339, 370)
            paddle.Location = New Point(289, 400)
            labelscore.Text = "Score: 0"
            SaveScore()
            Homepage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Timer1.Stop()
        Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Timer1.Start()
    End Sub

    Sub SaveScore()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\skk48_7oh2uuv\OneDrive\Desktop\finalgameapp\Database2.accdb")


        con.Open()
        Dim query As String = "UPDATE login SET pong_score = ? WHERE firstname = ?"
        Using cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", score)
            cmd.Parameters.AddWithValue("?", currentUser)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        End Using
    End Sub


End Class