Imports System.Data.OleDb
Public Class signup

    Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\skk48_7oh2uuv\OneDrive\Desktop\finalgameapp\Database2.accdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()


    End Sub

    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click

        con.Open()

        Dim checkCmd As New OleDbCommand("SELECT COUNT(*) FROM login WHERE firstname = @firstname OR email = @email", con)
        checkCmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
        checkCmd.Parameters.AddWithValue("@email", txt_email.Text)

        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("This username or email is already registered. Please use different details.", vbExclamation)
            con.Close()
            Exit Sub
        End If


        Dim cmd As New OleDb.OleDbCommand("insert into login([firstname],[lastname],[email],[password]) values(@firstname,@lastname,@email,@password)", con)
        Dim i As Integer
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
        cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
        cmd.Parameters.AddWithValue("@email", txt_email.Text)
        cmd.Parameters.AddWithValue("@password", txt_password.Text)
        i = cmd.ExecuteNonQuery
        If i > 0 Then
            MsgBox("new user create a account successfully!", vbInformation)
        Else
            MsgBox("new user create a account successfully!", vbCritical)
        End If
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_email.Clear()
        txt_password.Clear()
        Me.Dispose()
        con.Close()
        login.usercomboload()

    End Sub
End Class