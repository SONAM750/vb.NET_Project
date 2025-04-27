Imports System.Reflection.Emit

Public Class tictactoe


    Private board(8) As String
    Private buttons As Button()
    Private currentPlayer As String = "X"
    Private gameActive As Boolean = False
    Private isTwoPlayerMode As Boolean = True
    Private playerXScore As Integer = 0
    Private Sub tictactoe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        buttons = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9}

        ResetBoard()
    End Sub
    Private Sub ResetBoard()
        For i As Integer = 0 To 8
            board(i) = ""
            buttons(i).Text = ""
            buttons(i).Enabled = True
        Next
        Label1.Text = "Tic-Tac-Toe: Player X's Turn"
        Label2.Text = ""
        currentPlayer = "X" ' X starts the game
        gameActive = True
    End Sub
    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If Not gameActive Then Exit Sub




        Dim clickedButton = DirectCast(sender, Button)
        Dim index = Array.IndexOf(buttons, clickedButton)


        If board(index) = "" Then
            board(index) = currentPlayer
            clickedButton.Text = currentPlayer
            clickedButton.Enabled = False


            If CheckWinner(currentPlayer) Then
                Label2.Text = "Player " & currentPlayer & " Wins!"
                EndGame()
                Exit Sub
            End If

            ' Check for a tie
            If Not board.Contains("") Then
                Label2.Text = "It's a Draw!"
                EndGame()
                Exit Sub
            End If


            currentPlayer = If(currentPlayer = "X", "O", "X")
            Label1.Text = "Player " & currentPlayer & "'s Turn"


            If Not isTwoPlayerMode AndAlso currentPlayer = "O" Then
                ComputerMove()
            End If
        End If
    End Sub


    Private Function CheckWinner(player As String) As Boolean
        Dim winConditions As Integer()() = {
            New Integer() {0, 1, 2}, New Integer() {3, 4, 5}, New Integer() {6, 7, 8},
            New Integer() {0, 3, 6}, New Integer() {1, 4, 7}, New Integer() {2, 5, 8},
            New Integer() {0, 4, 8}, New Integer() {2, 4, 6}
        }

        For Each condition As Integer() In winConditions
            If board(condition(0)) = player AndAlso board(condition(1)) = player AndAlso board(condition(2)) = player Then
                Return True
            End If
        Next

        Return False

    End Function


    Private Sub EndGame()
        gameActive = False
        For Each btn In buttons
            btn.Enabled = False
        Next
    End Sub
    Private Sub ComputerMove()
        Dim availableMoves As New List(Of Integer)

        For i As Integer = 0 To 8
            If board(i) = "" Then
                availableMoves.Add(i)
            End If
        Next

        If availableMoves.Count > 0 Then
            Dim rand As New Random()
            Dim idx As Integer = availableMoves(rand.Next(availableMoves.Count)) '.Next is instance of Random class
            board(idx) = "O"
            buttons(idx).Text = "O"
            buttons(idx).Enabled = False


            If CheckWinner("O") Then
                Label2.Text = "Computer Wins!"
                EndGame()
                Return
            End If



            If Not board.Contains("") Then
                Label2.Text = "It's a Draw!"
                EndGame()
            End If
            currentPlayer = "X"
            Label2.Text = "Player X's Turn"

        End If

    End Sub


    Private Sub BtnTwoPlayerMode_Click(sender As Object, e As EventArgs) Handles player.Click
        isTwoPlayerMode = True
        ResetBoard()
    End Sub

    ' Start Game for Player vs Computer
    Private Sub BtnPcStart_Click(sender As Object, e As EventArgs) Handles pcstart.Click
        isTwoPlayerMode = False
        ResetBoard()
        ComputerMove()
    End Sub
    Private Sub restart_Click(sender As Object, e As EventArgs) Handles restart.Click
        ResetBoard()
    End Sub

    Private Sub btnexit1_Click(sender As Object, e As EventArgs) Handles btnexit1.Click
        Homepage.Show()
        Me.Hide()
    End Sub
End Class