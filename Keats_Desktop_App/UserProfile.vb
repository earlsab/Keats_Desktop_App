Imports IBM.Data.DB2
Public Class UserProfile

    Private Sub EditUserDetails_Consumer()
        Dim StrEdit As String
        Dim CmdEdit As DB2Command

        StrEdit = "Update consumer_profile set name_first = '" & TextBox2.Text & "', " _
            & "name_last = '" & TextBox1.Text & "', " _
            & "phone_number = '" & TextBoxPh.Text & "', " _
            & "date_updated = current_timestamp " _
            & "where account_id = " & Globals.UserAccountID

        CmdEdit = New DB2Command(StrEdit, Globals.DBConnLogin)
        CmdEdit.ExecuteNonQuery()
    End Sub

    Private Sub EditUserDetails_Account()
        Dim DPid As Integer
        Dim StrDP As String
        Dim CmdDP As DB2Command
        Dim RdrDP As DB2DataReader

        Dim ALid As Integer
        Dim StrAL As String
        Dim CmdAL As DB2Command
        Dim RdrAL As DB2DataReader

        Dim weight = Integer.Parse(TextBoxW.Text)
        Dim Height = Integer.Parse(TextBoxH.Text)

        Dim StrEdit As String
        Dim CmdEdit As DB2Command

        StrAL = "Select id FROM activity_lvl where name = '" & ComboBox1.Text & "'"
        CmdAL = New DB2Command(StrAL, Globals.DBConnLogin)
        RdrAL = CmdAL.ExecuteReader

        RdrAL.Read()
        ALid = RdrAL.GetInt32(0)

        RdrAL.Close()

        StrDP = "Select id FROM diet_plan where name = '" & ComboBox2.Text & "'"
        CmdDP = New DB2Command(StrDP, Globals.DBConnLogin)
        RdrDP = CmdDP.ExecuteReader

        RdrDP.Read()
        DPid = RdrDP.GetInt32(0)

        RdrDP.Close()

        StrEdit = "Update account_vitals set birthday = '" & DateTimePicker1.Value & "', " _
            & "weight = " & weight & ", " _
            & "height = " & Height & ", " _
            & "activity_lvl_id = " & ALid & ", " _
            & "diet_plan_id = " & DPid & " " _
            & "where account_id = " & Globals.UserAccountID

        CmdEdit = New DB2Command(StrEdit, Globals.DBConnLogin)
        CmdEdit.ExecuteNonQuery()
    End Sub

    Private Sub RefreshTextBoxes()
        TextBox2.Refresh()
        TextBox1.Refresh()
        DateTimePicker1.Refresh()
        TextBoxPh.Refresh()
        TextBoxSex.Refresh()
        TextBoxW.Refresh()
        TextBoxH.Refresh()
        ComboBox1.Refresh()
        ComboBox2.Refresh()
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
        Dim StrDelete As String
        Dim CmdDelete As DB2Command
        Dim CheckDelete As Integer

        StrDelete = "Delete from consumer_profile where account_id = " & Globals.UserAccountID & "; " &
            "delete from intake where account_id = " & Globals.UserAccountID & "; " &
            "delete from daily_nutrients where account_id = " & Globals.UserAccountID & "; " &
            "delete from account_vitals where account_id = " & Globals.UserAccountID & "; " &
            "delete from account where id = " & Globals.UserAccountID
        CmdDelete = New DB2Command(StrDelete, Globals.DBConnLogin)
        CheckDelete = CmdDelete.ExecuteNonQuery()

        If CheckDelete > 0 Then
            MessageBox.Show("Delete was successful. Rows of data deleted: " & CheckDelete)
        Else
            MessageBox.Show("Delete not completed...")
        End If

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
        Call RefreshTextBoxes()
        Call LoadAccount()
        Call LoadConsumer_Profile()
        Call LoadAccount_vitals()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Edit.Click

        If MsgBox("Are you sure you want to EDIT your profile details?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Edit.Enabled = False
            Me.SaveEdit.Enabled = True
            Me.Cancel.Enabled = True
            Me.Delete.Enabled = False
            Me.Back.Enabled = False
            Call EnableTextBoxes()

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SaveEdit.Click
        If MsgBox("Are you sure you want to CONFIRM EDITTED DETAILS of your profile?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call EditUserDetails_Consumer()
            Call EditUserDetails_Account()

            Me.Edit.Enabled = True
            Me.SaveEdit.Enabled = False
            Me.Cancel.Enabled = False
            Me.Delete.Enabled = True
            Me.Back.Enabled = True
            Call DisableTextBoxes()
            Call RefreshTextBoxes()

            MessageBox.Show("New details now saved!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click

        Me.Close()
        MainHomePage.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        If MsgBox("Are you sure you want to CANCEL EDITTING your profile details?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Call RefreshTextBoxes()
            Me.Edit.Enabled = True
            Me.SaveEdit.Enabled = False
            Me.Cancel.Enabled = False
            Me.Delete.Enabled = True
            Me.Back.Enabled = True
            Call DisableTextBoxes()

            MessageBox.Show("Don't worry, your changes were not saved.")

        End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Delete.Click

        If MsgBox("WARNING: Are you sure you want to DELETE profile?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call DeleteUserProfile()
            Me.Close()
            LoginForm1.Show()

        End If

    End Sub

End Class