﻿Imports IBM.Data.DB2

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
            Dim sex As String = ComboBoxSex.Text

            Dim DPid As Integer
            Dim StrDP As String
            Dim CmdDP As DB2Command
            Dim RdrDP As DB2DataReader

            Dim ALid As Integer
            Dim StrAL As String
            Dim CmdAL As DB2Command
            Dim RdrAL As DB2DataReader

            StrAL = "SELECT id FROM activity_lvl WHERE name = '" & ComboBoxAL.Text & "'"
            CmdAL = New DB2Command(StrAL, Globals.DBConnLogin)
            RdrAL = CmdAL.ExecuteReader

            If RdrAL.Read() Then
                ALid = RdrAL.GetInt32(0)
            Else
                Throw New Exception("No activity level found.")
            End If

            RdrAL.Close()

            StrDP = "SELECT id FROM diet_plan WHERE name = '" & ComboBoxDP.Text & "'"
            CmdDP = New DB2Command(StrDP, Globals.DBConnLogin)
            RdrDP = CmdDP.ExecuteReader

            If RdrDP.Read() Then
                DPid = RdrDP.GetInt32(0)
            Else
                Throw New Exception("No diet plan found.")
            End If

            RdrDP.Close()

            Dim insertVitalsQuery As String = "INSERT INTO account_vitals (account_id, weight, height, birthday, sex, activity_lvl_id, diet_plan_id) " &
                 "VALUES (@AccountId, @Weight, @Height, @Birthday, @Sex, @ALid, @DPid)"
            Using cmdVitals As New DB2Command(insertVitalsQuery, Globals.DBConnLogin)
                cmdVitals.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
                cmdVitals.Parameters.Add("@Weight", IBM.Data.DB2.DB2Type.Integer).Value = weight
                cmdVitals.Parameters.Add("@Height", IBM.Data.DB2.DB2Type.Integer).Value = height
                cmdVitals.Parameters.Add("@Birthday", IBM.Data.DB2.DB2Type.Date).Value = birthday
                cmdVitals.Parameters.Add("@Sex", IBM.Data.DB2.DB2Type.VarChar).Value = sex
                cmdVitals.Parameters.Add("@ALid", IBM.Data.DB2.DB2Type.Integer).Value = ALid
                cmdVitals.Parameters.Add("@DPid", IBM.Data.DB2.DB2Type.Integer).Value = DPid
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

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class