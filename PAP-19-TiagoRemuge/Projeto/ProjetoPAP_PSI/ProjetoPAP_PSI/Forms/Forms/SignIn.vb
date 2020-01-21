Public Class SignIn
    Private Sub User_MouseClick(sender As Object, e As MouseEventArgs) Handles User.MouseClick
        User.Clear()

    End Sub

    Private Sub Password_MouseClick(sender As Object, e As MouseEventArgs) Handles Password.MouseClick
        Password.Clear()
        Password.PasswordChar = "*"

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()

    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Dim F As New Funcionario
        F.Login(User.Text, Password.Text)

    End Sub
End Class