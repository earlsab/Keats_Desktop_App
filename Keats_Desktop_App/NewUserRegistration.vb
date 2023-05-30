Imports IBM.Data.DB2
Public Class NewUserRegistration

    Private Sub PopulateDataGrid()
        Dim StrStud As String
        Dim row As String()
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "Select * from student"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            Me.DataGridView1.Rows.Clear()
            While RdrStud.Read
                row = New String() {RdrStud.GetString(0), RdrStud.GetString(1), _
                                   RdrStud.GetString(2), RdrStud.GetString(3
                                                                           )}
                Me.DataGridView1.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
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
