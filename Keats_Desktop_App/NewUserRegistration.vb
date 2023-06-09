﻿Imports IBM.Data.DB2

Public Class NewUserRegistration

    Private Sub TextBoxClear()
        Try
            Me.Username.Clear()
            Me.Password.Clear()
            Me.ConfirmPassword.Clear()
            Me.Username.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Call TextBoxClear()
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim NewPass As String
        Dim NewUN As String
        Dim StrReg As String
        Dim StrCheck As String
        Dim CmdReg As DB2Command
        Dim RdrReg As DB2DataReader

        Try
            NewUN = Me.Username.Text()
            NewPass = Me.Password.Text()

            StrCheck = "Select * from account where username = '" & NewUN & "'"
            CmdReg = New DB2Command(StrCheck, Globals.DBConnLogin)
            RdrReg = CmdReg.ExecuteReader

            If RdrReg.HasRows() Then

                MsgBox("Username already exists!", MsgBoxStyle.Information)
                Call TextBoxClear()

            ElseIf NewUN = "" Or NewPass = "" Then

                MsgBox("Username or password fields are blank!", MsgBoxStyle.Information)
                Call TextBoxClear()

            Else

                If Me.Password.Text() = Me.ConfirmPassword.Text() Then

                    If MsgBox("Are you sure you want to register under the username " & NewUN & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        StrReg = "Insert into account(username, password) values('" & NewUN & "','" & NewPass & "')"

                        CmdReg = New DB2Command(StrReg, Globals.DBConnLogin)
                        CmdReg.ExecuteNonQuery()


                        Dim Str = "Select id from account where username = '" & NewUN & "'"
                        Dim CmdStr = New DB2Command(Str, Globals.DBConnLogin)
                        Dim RdrStr = CmdStr.ExecuteReader
                        While RdrStr.Read
                            Globals.UserAccountID = RdrStr.GetInt32(0)
                        End While
                        Me.Hide()
                        NewUserInformation.Show()

                    Else

                        Me.Username.Clear()
                        Me.Username.Focus()

                    End If
                Else

                    MsgBox("Password does not match!", MsgBoxStyle.Information)
                    Me.Password.Clear()
                    Me.ConfirmPassword.Clear()
                    Me.Password.Focus()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPassword.TextChanged

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class
