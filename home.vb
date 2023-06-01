Public Class home
    Private Sub empbtn_Click(sender As Object, e As EventArgs) Handles empbtn.Click
        employees.Show()
    End Sub

    Private Sub customerbtn_Click(sender As Object, e As EventArgs) Handles customerbtn.Click
        customers.Show()
    End Sub

    Private Sub prodbtn_Click(sender As Object, e As EventArgs) Handles prodbtn.Click
        products.Show()
    End Sub

    Private Sub categbtn_Click(sender As Object, e As EventArgs) Handles categbtn.Click
        categories.Show()
    End Sub

    Private Sub orderbtn_Click(sender As Object, e As EventArgs) Handles orderbtn.Click
        orders.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo)
        ' If user clicked Yes, proceed with logout '
        If confirmResult = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class