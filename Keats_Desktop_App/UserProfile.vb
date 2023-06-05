Imports IBM.Data.DB2
Public Class UserProfile

    Private Sub EditUserDetails()

    End Sub

    Private Sub EnableTextBoxes()
        Me.TextBox2.Enabled = True
        Me.TextBox1.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.TextBoxPh.Enabled = True
        Me.TextBoxSex.Enabled = True
        Me.TextBoxW.Enabled = True
        Me.TextBoxH.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.ComboBox2.Enabled = True
    End Sub

    Private Sub DisableTextBoxes()
        Me.TextBox2.Enabled = False
        Me.TextBox1.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.TextBoxPh.Enabled = False
        Me.TextBoxSex.Enabled = False
        Me.TextBoxW.Enabled = False
        Me.TextBoxH.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = False
    End Sub

    Private Sub DeleteUserProfile()

    End Sub

    Private Sub LoadAccount()
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader

        Dim Username As String
        Dim Password As String

        StrLoad = "Select username, password from account where id = " & Globals.UserAccountID
        CmdLoad = New DB2Command(StrLoad, Globals.DBConnLogin)
        RdrLoad = CmdLoad.ExecuteReader

        RdrLoad.Read()
        Username = RdrLoad.GetString(0)
        Password = RdrLoad.GetString(1)

        RdrLoad.Close()

        TextBoxUsername.Text = Username
        TextBoxPassw.Text = Password
    End Sub

    Private Sub LoadConsumer_Profile()
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader

        Dim FirstName As String
        Dim Surname As String
        Dim PhoneNo As String

        StrLoad = "Select name_first, name_last, phone_number from consumer_profile where account_id =" & Globals.UserAccountID
        CmdLoad = New DB2Command(StrLoad, Globals.DBConnLogin)
        RdrLoad = CmdLoad.ExecuteReader

        RdrLoad.Read()
        FirstName = RdrLoad.GetString(0)
        Surname = RdrLoad.GetString(1)
        PhoneNo = RdrLoad.GetString(2)

        RdrLoad.Close()

        TextBox2.Text = FirstName
        TextBox1.Text = Surname
        TextBoxPh.Text = PhoneNo
    End Sub

    Private Sub LoadAccount_vitals()
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader

        Dim Weight As Integer
        Dim Height As Integer
        Dim Birthday As Date
        Dim Sex As String
        Dim ALid As Integer
        Dim DPid As Integer
        Dim ALname As String
        Dim DPname As String

        StrLoad = "SELECT av.weight, av.height, av.birthday, av.sex, av.activity_lvl_id, av.diet_plan_id, al.name AS activity_level_name, dp.name AS diet_plan_name " &
                  "FROM account_vitals av " &
                  "JOIN activity_lvl al ON av.activity_lvl_id = al.id " &
                  "JOIN diet_plan dp ON av.diet_plan_id = dp.id " &
                  "WHERE av.account_id = " & Globals.UserAccountID

        CmdLoad = New DB2Command(StrLoad, Globals.DBConnLogin)
        RdrLoad = CmdLoad.ExecuteReader

        RdrLoad.Read()
        Weight = RdrLoad.GetInt16(0)
        Height = RdrLoad.GetInt16(1)
        Birthday = RdrLoad.GetDate(2)
        Sex = RdrLoad.GetString(3)
        ALid = RdrLoad.GetInt32(4)
        DPid = RdrLoad.GetInt32(5)
        ALname = RdrLoad.GetString(6)
        DPname = RdrLoad.GetString(7)

        RdrLoad.Close()

        DateTimePicker1.Value = Birthday
        TextBoxSex.Text = Sex
        TextBoxW.Text = Weight
        TextBoxH.Text = Height
        ComboBox1.Text = ALname
        ComboBox2.Text = DPname

    End Sub

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadAccount()
        Call LoadConsumer_Profile()
        Call LoadAccount_vitals()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Edit.Click

        If MsgBox("Are you sure you want to EDIT your profile details?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call EditUserDetails()

            Me.Edit.Enabled = False
            Me.SaveEdit.Enabled = True
            Me.Cancel.Enabled = True
            Me.Delete.Enabled = False
            Me.Back.Enabled = False
            Call EnableTextBoxes()

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SaveEdit.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click

        Me.Close()
        MainHomePage.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        If MsgBox("Are you sure you want to CANCEL EDITTING your profile details?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call EditUserDetails()

            Me.Edit.Enabled = True
            Me.SaveEdit.Enabled = False
            Me.Cancel.Enabled = False
            Me.Delete.Enabled = True
            Me.Back.Enabled = True
            Call DisableTextBoxes()

        End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Delete.Click

        If MsgBox("Are you sure you want to DELETE profile?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call DeleteUserProfile()
        End If

    End Sub

End Class