Imports IBM.Data.DB2

Public Class NewUserInformation
    Dim activityLevelTable As New DataTable()
    Dim dietPlanTable As New DataTable()

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

        DataGridViewAL.Refresh()
        DataGridViewDP.Refresh()

        Me.DataGridViewAL.ColumnCount = 2
        Me.DataGridViewAL.Columns(0).Name = "Level"
        Me.DataGridViewAL.Columns(1).Name = "Description"

        StrAL = "Select name, activity_lvl_desc from activity_lvl"
        CmdAL = New DB2Command(StrAL, Globals.DBConnLogin)
        RdrAL = CmdAL.ExecuteReader

        Me.DataGridViewAL.Rows.Clear()

        While RdrAL.Read
            row = New String() {RdrAL.GetString(0), RdrAL.GetString(1)}
            Me.DataGridViewAL.Rows.Add(row)
        End While

        Me.DataGridViewDP.ColumnCount = 2
        Me.DataGridViewDP.Columns(0).Name = "Plan"

        StrDP = "Select name from diet_plan"
        CmdDP = New DB2Command(StrDP, Globals.DBConnLogin)
        RdrDP = CmdDP.ExecuteReader

        Me.DataGridViewDP.Rows.Clear()

        While RdrDP.Read
            row = New String() {RdrDP.GetString(0)}
            Me.DataGridViewDP.Rows.Add(row)
        End While

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
        Try
            Dim firstname As String = TextBox2.Text
            Dim surname As String = TextBox1.Text
            Dim weight As Integer = Integer.Parse(TextBoxW.Text)
            Dim height As Integer = Integer.Parse(TextBoxH.Text)
            Dim phone As String = TextBoxPh.Text
            Dim birthday As Date = DateTimePicker1.Value
            Dim sex As String = TextBoxSex.Text

            DataGridViewAL.DataSource = activityLevelTable
            DataGridViewDP.DataSource = dietPlanTable

            Dim activityLevelId As Integer
            Dim dietPlanId As Integer

            If DataGridViewAL.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridViewAL.SelectedRows(0)
                activityLevelId = CInt(selectedRow.Cells("Activity Level").Value)
            End If

            If DataGridViewDP.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridViewDP.SelectedRows(0)
                dietPlanId = CInt(selectedRow.Cells("Diet Plan").Value)
            End If

            Dim insertVitalsQuery As String = "INSERT INTO account_vitals (account_id, weight, height, birthday, sex, activity_lvl_id, diet_plan_id) " &
                 "VALUES (@AccountId, @Weight, @Height, @Birthday, @Sex, @ActivityLevelId, @DietPlanId)"
            Using cmdVitals As New DB2Command(insertVitalsQuery, Globals.DBConnLogin)
                cmdVitals.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
                cmdVitals.Parameters.Add("@Weight", IBM.Data.DB2.DB2Type.Integer).Value = weight
                cmdVitals.Parameters.Add("@Height", IBM.Data.DB2.DB2Type.Integer).Value = height
                cmdVitals.Parameters.Add("@Birthday", IBM.Data.DB2.DB2Type.Date).Value = birthday
                cmdVitals.Parameters.Add("@Sex", IBM.Data.DB2.DB2Type.VarChar).Value = sex
                cmdVitals.Parameters.Add("@ActivityLevelId", IBM.Data.DB2.DB2Type.Integer).Value = activityLevelId
                cmdVitals.Parameters.Add("@DietPlanId", IBM.Data.DB2.DB2Type.Integer).Value = dietPlanId
                cmdVitals.ExecuteNonQuery()
            End Using

            Dim selectVitalsIdQuery As String = "SELECT id FROM account_vitals WHERE account_id = @AccountId"
            Dim vitalsId As Integer
            Using cmdSelectVitalsId As New DB2Command(selectVitalsIdQuery, Globals.DBConnLogin)
                cmdSelectVitalsId.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
                vitalsId = CInt(cmdSelectVitalsId.ExecuteScalar())
            End Using

            Dim insertProfileQuery As String = "INSERT INTO consumer_profile(account_id, name_first, name_last, phone_number, date_updated, date_created, account_vitals_id) " &
                "VALUES (@AccountId, @FirstName, @LastName, @PhoneNumber, @DateUpdated, @DateCreated, @VitalsId)"
            Using cmdProfile As New DB2Command(insertProfileQuery, Globals.DBConnLogin)
                cmdProfile.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
                cmdProfile.Parameters.Add("@FirstName", IBM.Data.DB2.DB2Type.VarChar).Value = firstname
                cmdProfile.Parameters.Add("@LastName", IBM.Data.DB2.DB2Type.VarChar).Value = surname
                cmdProfile.Parameters.Add("@PhoneNumber", IBM.Data.DB2.DB2Type.VarChar).Value = phone
                cmdProfile.Parameters.Add("@DateUpdated", IBM.Data.DB2.DB2Type.Timestamp).Value = DateTime.Now
                cmdProfile.Parameters.Add("@DateCreated", IBM.Data.DB2.DB2Type.Timestamp).Value = DateTime.Now
                cmdProfile.Parameters.Add("@VitalsId", IBM.Data.DB2.DB2Type.Integer).Value = vitalsId
                cmdProfile.ExecuteNonQuery()
            End Using

            TextBoxClear()
            MessageBox.Show("Registration successful!")

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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class