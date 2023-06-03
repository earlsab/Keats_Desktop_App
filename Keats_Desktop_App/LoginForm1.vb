Imports IBM.Data.DB2

Module Globals
    Public DBUser = "username"
    Public DBPassword = "password"
    Public DBDatabase = "keats2"
    Public DBConnLogin As Common.DbConnection

    Public SelectedIngredientId = 0
    Public SelectedIngredientMappingId = 0
End Module

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim VUid As String
        Dim VPass As String
        Dim StrLogin As String
        Dim CmdLogin As DB2Command
        Dim RdrLogin As DB2DataReader

        Try
            VUid = Me.UsernameTextBox.Text()
            VPass = Me.PasswordTextBox.Text()
            StrLogin = "Select * from account where username = '" & VUid & "' " _
                          & "and password='" & VPass & "'"
            CmdLogin = New DB2Command(StrLogin, Globals.DBConnLogin)
            RdrLogin = CmdLogin.ExecuteReader
            'This but checks if the code is there...
            If RdrLogin.HasRows Then
                'RdrLogin.Read()
                'FrmEnroll.TxtStudId.Text = RdrLogin.GetString(0)
                'MainHomePage.Show()
                SearchIngredient.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username/password..", MsgBoxStyle.Information)
                Me.UsernameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Me.UsernameTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub RegisterButton(sender As Object, e As EventArgs) Handles Register.Click
        NewUserRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Globals.DBConnLogin = New DB2Connection("server=localhost; database=" & DBDatabase _
 & ";" + _
"uid= " & DBUser & ";password=" & DBPassword & ";")
            Globals.DBConnLogin.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
