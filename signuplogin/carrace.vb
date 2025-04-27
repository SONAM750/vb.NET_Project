Imports System.Data.OleDb


Public Class carrace
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Private Sub carrace_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox7
        road(6) = PictureBox11
        road(7) = PictureBox12


    End Sub

    Private Sub roadmover_Tick(sender As Object, e As EventArgs) Handles roadmover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If score > 10 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 50 Then
            speed = 6
        End If
        If score > 50 And score < 70 Then
            speed = 7
        End If
        If score > 100 Then
            speed = 9
        End If
        Label1.Text = "speed " & speed
        If (car.Bounds.IntersectsWith(race1.Bounds)) Then
            endgame()
        End If
        If (car.Bounds.IntersectsWith(race2.Bounds)) Then
            endgame()
        End If
        If (car.Bounds.IntersectsWith(race3.Bounds)) Then
            endgame()
        End If



    End Sub


    Private Sub endgame()
        replay.Visible = True
        Label3.Visible = True
        roadmover.Stop()
        RaceMover1.Stop()
        RaceMover2.Stop()
        RaceMover3.Stop()
        SaveUserScore()
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub carrace_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick

        If (car.Location.X < 295) Then
            car.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick


        If (car.Location.X > 0) Then
            car.Left -= 5
        End If

    End Sub
    Private Sub carrace_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub RaceMover1_Tick(sender As Object, e As EventArgs) Handles RaceMover1.Tick

        race1.Top += speed / 2
        If race1.Top >= Me.Height Then
            score += 1
            Label2.Text = "score " & score
            race1.Top = -(Int(Math.Ceiling(Rnd() * 200)) + race1.Height)
            race1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If

    End Sub

    Private Sub RaceMover2_Tick(sender As Object, e As EventArgs) Handles RaceMover2.Tick
        race2.Top += speed / 3
        If race2.Top >= Me.Height Then
            score += 1
            Label2.Text = "score " & score
            race2.Top = -(Int(Math.Ceiling(Rnd() * 200)) + race2.Height)
            race2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        End If
    End Sub
    Private Sub RaceMover3_Tick(sender As Object, e As EventArgs) Handles RaceMover3.Tick
        race3.Top += speed * 1 / 2
        If race3.Top >= Me.Height Then
            score += 1
            Label2.Text = "score " & score
            race3.Top = -(Int(Math.Ceiling(Rnd() * 200)) + race3.Height)
            race3.Left = CInt(Math.Ceiling(Rnd() * 50)) + 180
        End If
    End Sub

    Private Sub replay_Click(sender As Object, e As EventArgs) Handles replay.Click
        score = 0
        speed = 3
        Controls.Clear()
        InitializeComponent()
        carrace_Load(e, e)
        roadmover.Start()
        RaceMover1.Start()
        RaceMover2.Start()
        RaceMover3.Start()

    End Sub

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\skk48_7oh2uuv\OneDrive\Desktop\finalgameapp\Database2.accdb"
    Public currentUser As String = login.loggeduser ' Store the logged-in user's name

    ' Function to store the score in the database
    Private Sub SaveUserScore()
        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()
                Dim query As String = "UPDATE login SET carrace_score = ? WHERE firstname = ?"
                Using cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", score)
                    cmd.Parameters.AddWithValue("?", currentUser)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Score saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update score. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

