Imports System.Data.OleDb
Public Class login
    Dim dr As OleDbDataReader
    Dim dt As DataTable
    Dim da As OleDbDataAdapter
    Dim islogin As Boolean
    Public Shared loggeduser As String


    Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\skk48_7oh2uuv\OneDrive\Desktop\finalgameapp\Database2.accdb")


    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub
    Sub usercomboload()
        con.Open()
        user_combo.Items.Clear()
        Dim cmd As New OleDbCommand("select * from login", con)
        dr = cmd.ExecuteReader
        While dr.Read
            user_combo.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub


    Private Sub username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_combo.SelectedIndexChanged
        con.Open()
        Dim cmd As New OleDbCommand("select * from login where firstname= @username", con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@username", user_combo.Text)
        da = New OleDbDataAdapter
        dt = New DataTable
        da.SelectCommand = cmd
        da.Fill(dt)

        con.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        con.Open()

        Dim cmd As New OleDbCommand("select * from login where firstname = @username AND password = @password", con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@username", user_combo.Text)
        cmd.Parameters.AddWithValue("@password", txtpassword.Text)
        Dim username As String = ""
        Dim password As String = ""
        dr = cmd.ExecuteReader
        If (dr.Read() = True) Then

            username = dr("firstname").ToString()
            loggeduser = dr("firstname").ToString()
            password = dr("password").ToString()

            MsgBox("login successfully !!")
            btngame.Visible = True

        Else
            MsgBox("wrong password", vbCritical)
        End If
        con.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usercomboload()
    End Sub

    Private Sub btngame_Click(sender As Object, e As EventArgs) Handles btngame.Click
        Homepage.Show()
        Me.Hide()
    End Sub


End Class