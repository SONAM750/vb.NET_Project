Imports System.Data.OleDb
Public Class Homepage



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        tictactoe.Show()
        Me.Hide()
    End Sub

    Private Sub car_start_Click(sender As Object, e As EventArgs) Handles car_start.Click
        carrace.Show()
        Me.Hide()
    End Sub

    Private Sub start_rock_Click(sender As Object, e As EventArgs) Handles start_rock.Click
        rockpaper.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ponggame.Show()
        Me.Hide()

    End Sub

    Private Sub btnleaderboard_Click(sender As Object, e As EventArgs) Handles btnleaderboard.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\skk48_7oh2uuv\OneDrive\Desktop\finalgameapp\Database2.accdb")
        con.Open()
        Dim query As String = "select firstname As PlayerName , carrace_score As CarRace , pong_score As Pong, rockpaper_score As RockPaper from login ORDER BY carrace_score DESC, pong_score DESC, rockpaper_score DESC"
        Dim da As New OleDbDataAdapter(query, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        leaderboard.DataSource = dt
        leaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        leaderboard.Visible = True
    End Sub

    Private Sub btnexit1_Click(sender As Object, e As EventArgs) Handles btnexit1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class