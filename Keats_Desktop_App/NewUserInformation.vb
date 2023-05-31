Imports IBM.Data.DB2

Public Class NewUserInformation

    Private Sub TextBoxClear()
        Try

            NewUserRegistration.Username.Clear()
            NewUserRegistration.Password.Clear()
            NewUserRegistration.ConfirmPassword.Clear()
            NewUserRegistration.Username.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub NewUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label.Click

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim StrCancel As String
        Dim CmdCancel As DB2Command

        If MsgBox("Are you sure you want to cancel your registration?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            StrCancel = "Delete from account where username = '" & NewUserRegistration.Username.Text & "'"

            CmdCancel = New DB2Command(StrCancel, Globals.DBConnLogin)
            CmdCancel.ExecuteNonQuery()

            Call TextBoxClear()

            Me.Hide()
            LoginForm1.Show()

        Else



        End If
    End Sub
End Class