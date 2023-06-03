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
        TextBoxUsername.Text = NewUserRegistration.Username.Text
        TextBoxPassw.Text = NewUserRegistration.Password.Text
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
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConfirmRegistration.Click
        Dim NewWeight As String
        Dim NewHeight As String
        Dim NewPhoneNo As String
        Dim NewEmail As String
        Dim NewBDay As Date
        Dim StrNewUser As String
        Dim CmdNewUser As DB2Command
        Dim RdrNewUser As DB2DataReader

        Try
            NewWeight = TextBoxW.Text()
            NewHeight = TextBoxH.Text()
            NewPhoneNo = TextBoxPh.Text()
            NewEmail = TextBoxEm.Text()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBoxPassw_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassw.TextChanged

    End Sub

    Private Sub TextBoxUssername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged


    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class