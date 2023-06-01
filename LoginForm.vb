Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where username = '" _
                & .usernametxt.Text & "' and password = ('" _
                & .passwordtxt.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                Me.Hide()
                home.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub
End Class
