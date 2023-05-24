Imports IBM.Data.DB2
Public Class NewUserRegistration
    Private DbConnection As Common.DbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserIn As String
        UserIn = Globals.DBDatabase
        Me.Username.Text = UserIn
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
