Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Policy

Public Class rockpaper
    Const intRock As Integer = 2
    Const intPaper As Integer = 3
    Const intScissors As Integer = 1

    Dim intPlayerwins As Integer = 0
    Dim intcomputerwins As Integer = 0
    Public currentUser As String = login.loggeduser
    Public score As String = intPlayerwins

    Private Sub rockpaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show(generateRandom().ToString())
    End Sub
    Function generateRandom() As Integer
        Dim rand As New Random
        Dim intRandom As Integer = rand.Next(3) + 1
        Return intRandom
    End Function

    Sub Checkwinner(ByVal intPlayerchoice As Integer)
        Dim intcomputerChoice As Integer = generateRandom()


        'display computer choice image
        If intcomputerChoice = intRock Then
            Picomputer.BackgroundImage = Image.FromFile("C:\Users\skk48_7oh2uuv\OneDrive\Desktop\game2\signuplogin\signuplogin\Resources\rock.png")

        ElseIf intcomputerChoice = intPaper Then
            Picomputer.BackgroundImage = Image.FromFile("C:\Users\skk48_7oh2uuv\OneDrive\Desktop\game2\signuplogin\signuplogin\Resources\paper.png")

        Else
            Picomputer.BackgroundImage = Image.FromFile("C:\Users\skk48_7oh2uuv\OneDrive\Desktop\game2\signuplogin\signuplogin\Resources\scissors.png")
        End If
        'evaluate palyer choice
        If intPlayerchoice = intRock And intcomputerChoice = intScissors Then
            lblStatus.Text = "you wins!!🎉"
            intPlayerwins += 1
        ElseIf intPlayerchoice = intPaper And intcomputerChoice = intRock Then
            lblStatus.Text = "you wins!!🎉"
            intPlayerwins += 1
        ElseIf intPlayerchoice = intScissors And intcomputerChoice = intPaper Then
            lblStatus.Text = "you wins!!🎉"
            intPlayerwins += 1

        End If

        'if player loss
        If intcomputerChoice = intRock And intPlayerchoice = intScissors Then
            lblStatus.Text = "you lose"
            intcomputerwins += 1
        ElseIf intcomputerChoice = intPaper And intPlayerchoice = intRock Then
            lblStatus.Text = "you lose"
            intcomputerwins += 1
        ElseIf intcomputerChoice = intScissors And intPlayerchoice = intPaper Then
            lblStatus.Text = "you lose"
            intcomputerwins += 1
        End If
        If intcomputerChoice = intPlayerchoice Then
            lblStatus.Text = "tie"
        End If
        'Label1.Text = "Player: " & intPlayerwins & " Vs " & "computer: " & intcomputerwins
        Label1.Text = "Player: " & intPlayerwins & Environment.NewLine & "Computer: " & intcomputerwins

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Checkwinner(CInt(btn1.Text))
        SaveScore()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim intPlayerChoice As Integer = CInt(btn2.Text)
        Checkwinner(intPlayerChoice)
        SaveScore()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Checkwinner(CInt(btn3.Text))
        SaveScore()
    End Sub

    Sub SaveScore()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\skk48_7oh2uuv\OneDrive\Desktop\finalgameapp\Database2.accdb")


        con.Open()
        Dim query As String = "UPDATE login SET rockpaper_score = ? WHERE firstname = ?"
        Using cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", intPlayerwins)
            cmd.Parameters.AddWithValue("?", currentUser)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnsingup_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Homepage.Show()
        Me.Hide()
    End Sub
End Class