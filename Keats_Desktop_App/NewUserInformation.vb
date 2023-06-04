Imports IBM.Data.DB2

Public Class NewUserInformation
    Dim activityLevelTable As New DataTable()
    Dim dietPlanTable As New DataTable()


    Dim firstname As String
    Dim surname As String
    Dim weight As Integer
    Dim height As Integer
    Dim phone As String
    Dim birthday As Date
    Dim sex As String


    Dim SelectedActivityLevelId As Integer
    Dim SelectedDietPlanId As Integer
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
        Dim row As String()

        Dim StrAL As String
        Dim CmdAL As DB2Command
        Dim RdrAL As DB2DataReader

        Dim StrDP As String
        Dim CmdDP As DB2Command
        Dim RdrDP As DB2DataReader

        TextBoxUsername.Text = NewUserRegistration.Username.Text
        TextBoxPassw.Text = NewUserRegistration.Password.Text
         
        DataGridViewAL.ColumnCount = 2
        StrAL = "Select id, name from activity_lvl"
        CmdAL = New DB2Command(StrAL, Globals.DBConnLogin)
        RdrAL = CmdAL.ExecuteReader

        DataGridViewAL.Rows.Clear()
        While RdrAL.Read
            row = New String() {RdrAL.GetString(0), RdrAL.GetString(1)}
            DataGridViewAL.Rows.Add(row)
        End While

        DataGridViewDP.ColumnCount = 2
        StrDP = "Select id, name from diet_plan"
        CmdDP = New DB2Command(StrDP, Globals.DBConnLogin)
        RdrDP = CmdDP.ExecuteReader

        DataGridViewDP.Rows.Clear() 
        While RdrDP.Read
            row = New String() {RdrDP.GetString(0), RdrDP.GetString(1)}
            DataGridViewDP.Rows.Add(row)
        End While

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
    Private Sub InsertAccountVitals()
        firstname = TextBox2.Text()
        surname = TextBox1.Text()
        weight = Integer.Parse(TextBoxW.Text)
        height = Integer.Parse(TextBoxH.Text)
        phone = TextBoxPh.Text()
        birthday = DateTimePicker1.Value
        sex = TextBoxSex.Text()

        DataGridViewAL.DataSource = activityLevelTable
        DataGridViewDP.DataSource = dietPlanTable 
        Try
            Dim StrInsert = "INSERT INTO account_vitals (account_id, weight, height, birthday, sex, activity_lvl_id, diet_plan_id) " & _
             "VALUES (@AccountId, @Weight, @Height, @Birthday, @Sex, @ActivityLevelId, @DietPlanId)"
            Dim cmdVitals = New DB2Command(StrInsert, Globals.DBConnLogin)
            cmdVitals.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
            cmdVitals.Parameters.Add("@Weight", IBM.Data.DB2.DB2Type.Integer).Value = weight
            cmdVitals.Parameters.Add("@Height", IBM.Data.DB2.DB2Type.Integer).Value = height
            cmdVitals.Parameters.Add("@Birthday", IBM.Data.DB2.DB2Type.Date).Value = birthday
            cmdVitals.Parameters.Add("@Sex", IBM.Data.DB2.DB2Type.VarChar).Value = sex
            cmdVitals.Parameters.Add("@ActivityLevelId", IBM.Data.DB2.DB2Type.Integer).Value = SelectedActivityLevelId
            cmdVitals.Parameters.Add("@DietPlanId", IBM.Data.DB2.DB2Type.Integer).Value = SelectedDietPlanId
            cmdVitals.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub ConsumerProfile()
        Dim vitalsId As Integer

        Dim Str = "SELECT id FROM account_vitals WHERE account_id  = '" & Globals.UserAccountID & "'"
        Dim CmdStr = New DB2Command(Str, Globals.DBConnLogin)
        Dim RdrStr = CmdStr.ExecuteReader
        While RdrStr.Read
            vitalsId = RdrStr.GetInt32(0)
        End While


        Try
            Dim StrInsert = "INSERT INTO consumer_profile(account_id, name_first, name_last, phone_number, date_updated, date_created, account_vitals_id) " &
            "VALUES (@AccountId, @FirstName, @LastName, @PhoneNumber, @DateUpdated, @DateCreated, @VitalsId)"
            Dim cmdProfile = New DB2Command(StrInsert, Globals.DBConnLogin)
            cmdProfile.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
            cmdProfile.Parameters.Add("@FirstName", IBM.Data.DB2.DB2Type.VarChar).Value = firstname
            cmdProfile.Parameters.Add("@LastName", IBM.Data.DB2.DB2Type.VarChar).Value = surname
            cmdProfile.Parameters.Add("@PhoneNumber", IBM.Data.DB2.DB2Type.VarChar).Value = phone
            cmdProfile.Parameters.Add("@DateUpdated", IBM.Data.DB2.DB2Type.Timestamp).Value = DateTime.Now
            cmdProfile.Parameters.Add("@DateCreated", IBM.Data.DB2.DB2Type.Timestamp).Value = DateTime.Now
            cmdProfile.Parameters.Add("@VitalsId", IBM.Data.DB2.DB2Type.Integer).Value = vitalsId
            cmdProfile.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConfirmRegistration.Click
        Try
            Call InsertAccountVitals()
            Call ConsumerProfile()
            TextBoxClear()
            MessageBox.Show("Registration successful!")
            Me.Close()
            MainHomePage.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
      

    Private Sub DataGridViewAL_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAL.CellClick

        ' Check if the click is on a valid row (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridViewAL.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridViewAL.Rows(e.RowIndex)
            SelectedActivityLevelId = selectedRow.Cells(0).Value
        End If 
    End Sub

    Private Sub DataGridViewDP_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDP.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridViewDP.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridViewDP.Rows(e.RowIndex)
            SelectedDietPlanId = selectedRow.Cells(0).Value
        End If 
    End Sub
End Class