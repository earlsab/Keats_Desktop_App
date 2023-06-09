﻿Imports IBM.Data.DB2

Public Class MainHomePage
    Dim IntakeCount As Integer
    Dim CurrentDate As Date
    Private Sub CreateDailyNutrientEntry()

        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim StrInsert As String
        Dim CmdInsert As DB2Command

        Dim LatestEntryDate As Date
        Dim FirstEntryState As Boolean
        ' CREATION OF DAILY NUTRIENTS ENTRY
        FirstEntryState = False
        Try
            StrLoad = "select max(date_created) from daily_nutrients where account_id=" & Globals.UserAccountID
            CmdLoad = New DB2Command(StrLoad, Globals.DBConnLogin)
            RdrLoad = CmdLoad.ExecuteReader
            RdrLoad.Read()
            LatestEntryDate = RdrLoad.GetDate(0)


        Catch ex As Exception
            FirstEntryState = True
        End Try

        If DateDiff("d", LatestEntryDate, CurrentDate) > 0 Or FirstEntryState Then

            Dim birthDate As Date
            Dim weight, height, calorie_percentage, protein_percentage, fats_percentage, carbs_percentage As Integer
            Dim bmr_multiplier As Single
            Try
                StrLoad = "SELECT " _
                        & "account_vitals.weight, " _
                        & "account_vitals.height, " _
                        & "account_vitals.birthday, " _
                        & "activity_lvl.bmr_multiplier, " _
                        & "diet_plan.calorie_percentage, " _
                        & "diet_plan.protein_percentage, " _
                        & "diet_plan.fats_percentage, " _
                        & "diet_plan.carbs_percentage " _
                        & "FROM account_vitals " _
                    & "JOIN activity_lvl ON account_vitals.activity_lvl_id = activity_lvl.id " _
                    & "JOIN diet_plan ON account_vitals.diet_plan_id = diet_plan.id " _
                    & "WHERE account_vitals.account_id = " & Globals.UserAccountID & ";"
                CmdLoad = New DB2Command(StrLoad, Globals.DBConnLogin)
                RdrLoad = CmdLoad.ExecuteReader
                RdrLoad.Read()
                weight = Integer.Parse(RdrLoad.GetString(0))
                height = Integer.Parse(RdrLoad.GetString(1))
                birthDate = RdrLoad.GetDate(2)
                bmr_multiplier = Single.Parse(RdrLoad.GetString(3))
                calorie_percentage = Integer.Parse(RdrLoad.GetString(4))
                protein_percentage = Integer.Parse(RdrLoad.GetString(5))
                fats_percentage = Integer.Parse(RdrLoad.GetString(6))
                carbs_percentage = Integer.Parse(RdrLoad.GetString(7))
            Catch ex As Exception
                MsgBox(ex.ToString())
                FirstEntryState = True
            End Try
            Dim age As Integer = DateDiff(DateInterval.Year, birthDate, Today)
            Dim Bmr = ((10 * weight) + (6.25 * height) - (5 * age) + 5)
            Dim MaxCalories = (bmr_multiplier * Bmr) * (calorie_percentage * 0.01)
            Dim MaxProtein = (MaxCalories * (protein_percentage * 0.01) / 4)
            Dim MaxCarbs = (MaxCalories * (carbs_percentage * 0.01) / 4)
            Dim MaxFats = (MaxCalories * (fats_percentage * 0.01) / 9)
            Try
                StrInsert = "insert into daily_nutrients(account_id, date_created, calories, protein, carbs, fats," _
                & "max_calories, max_protein, max_carbs, max_fats, diet_plan_id, activity_lvl_id)" _
                & "values(@AccountId, @DateTimeValue, 0, 0, 0, 0, @MaxCalories, @maxProtein, @maxCarbs, @maxFats, 1, 1)"
                CmdInsert = New DB2Command(StrInsert, Globals.DBConnLogin)
                CmdInsert.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
                CmdInsert.Parameters.Add("@DateTimeValue", IBM.Data.DB2.DB2Type.DateTime).Value = DateTime.Now ' Assuming you want to use the current date and time
                CmdInsert.Parameters.Add("@MaxCalories", IBM.Data.DB2.DB2Type.Integer).Value = MaxCalories
                CmdInsert.Parameters.Add("@maxProtein", IBM.Data.DB2.DB2Type.Integer).Value = MaxProtein
                CmdInsert.Parameters.Add("@maxCarbs", IBM.Data.DB2.DB2Type.Integer).Value = MaxCarbs
                CmdInsert.Parameters.Add("@maxFats", IBM.Data.DB2.DB2Type.Integer).Value = MaxFats
                CmdInsert.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
        End If
    End Sub
    Public Sub PopulateDataGrid()
        Dim StrSum As String
        Dim row() As String

        Dim ingredientMappingID As Integer
        Dim ingredientNameID As Integer
        Dim ingredientKindID As Integer
        Dim ingredientPrepID As Integer
        Dim ingredientNutrientID As Integer

        Dim ingredientName As String
        Dim ingredientKind As String
        Dim ingredientPrep As String
        Dim ingredientNutrient As Integer
        Dim CmdSum As DB2Command
        Dim RdrSum As DB2DataReader
        Dim RdrSum2 As DB2DataReader
        Dim RdrSum3 As DB2DataReader

        Try
            StrSum = "Select * from intake where account_id=" & Globals.UserAccountID
            CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
            RdrSum = CmdSum.ExecuteReader
            Me.DataGridView1.Rows.Clear()

            Me.IntakeCount = 0
            While RdrSum.Read
                Me.IntakeCount += 1
                ' Order of Table
                ' 0 2ID
                ' 1 ACCOUNT_ID()
                ' 2 DATE_CREATED()
                ' 3 AMOUNT()
                ' 4 INGREDIENT_MAPPING_ID()

                ' Get details of the ingredient item.

                ingredientMappingID = RdrSum.GetInt32(4)
                Try
                    StrSum = "Select * from ingredient_mapping where id=" & ingredientMappingID
                    CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                    ' Order of Ingredient Mapping Table
                    ' ID()
                    ' INGREDIENT_ID()
                    ' INGREDIENT_VARIANT_ID() Part of meal
                    ' INGREDIENT_SUBVARIANT_ID() How it's cooked
                    ' NUTRIENT_ID()
                    RdrSum2 = CmdSum.ExecuteReader
                    RdrSum2.Read()
                    ingredientNameID = RdrSum2.GetInt32(1)
                    ingredientKindID = RdrSum2.GetInt32(2)
                    ingredientPrepID = RdrSum2.GetInt32(3)
                    ingredientNutrientID = RdrSum2.GetInt32(4)

                    ' Get Name
                    StrSum = "Select name from ingredient where id=" & ingredientNameID
                    CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                    RdrSum3 = CmdSum.ExecuteReader
                    RdrSum3.Read()
                    ingredientName = RdrSum3.GetString(0)

                    Try
                        ' Get Part (if applicable)
                        StrSum = "Select name from ingredient_variant where id=" & ingredientKindID
                        CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                        RdrSum3 = CmdSum.ExecuteReader
                        RdrSum3.Read()
                        ingredientKind = RdrSum3.GetString(0) + " " 'Adds a space if exists
                    Catch ex As Exception

                    End Try

                    Try
                        ' Get Prep Type (if Applicable)
                        StrSum = "Select name from ingredient_subvariant where id=" & ingredientPrepID
                        CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                        RdrSum3 = CmdSum.ExecuteReader
                        RdrSum3.Read()
                        ingredientPrep = RdrSum3.GetString(0) + " " 'Adds a space if exists
                    Catch ex As Exception

                    End Try

                    ' Get Nutrients
                    'ID()
                    'AMOUNT()
                    'SERVING_SIZE()
                    'CALORIES()
                    'PROTEIN()
                    'CARBS()
                    'FATS()
                    StrSum = "Select * from nutrient where id=" & ingredientNutrientID
                    CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                    RdrSum3 = CmdSum.ExecuteReader
                    RdrSum3.Read()
                    ingredientNutrient = RdrSum3.GetFloat(3)

                Catch ex As Exception
                    MsgBox("Unknown Food Item")
                End Try


                ingredientName = "" & ingredientPrep & "" & ingredientKind & "" & ingredientName & ""
                Dim nutrient = ingredientNutrient * (Integer.Parse(RdrSum.GetString(3)) / 100)
                row = New String() {RdrSum.GetString(2), ingredientName, RdrSum.GetString(3), nutrient, RdrSum.GetInt32(0)}
                If DateDiff("d", RdrSum.GetDateTime(2), CurrentDate) = 0 Then
                    Me.DataGridView1.Rows.Add(row)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub UpdateSummary()

        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader

        Me.MealsLoggedTextBox.Text = Me.IntakeCount
        Try
            StrStud = "SELECT calories, protein, carbs, fats, max_calories, max_protein, max_carbs, max_fats FROM daily_nutrients WHERE account_id = @AccountId AND Date_Created = @CurrentDate"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            CmdStud.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
            CmdStud.Parameters.Add("@CurrentDate", IBM.Data.DB2.DB2Type.Date).Value = DateTime.Now
            RdrStud = CmdStud.ExecuteReader
            While RdrStud.Read
                CaloriesTextBox.Text() = RdrStud.GetString(0)
                ProteinTextBox.Text() = RdrStud.GetString(1)
                CarbsTextBox.Text() = RdrStud.GetString(2)
                FatsTextBox.Text() = RdrStud.GetString(3)

                MaxCalories.Text = RdrStud.GetString(4)
                MaxProtein.Text = RdrStud.GetString(5)
                MaxCarbs.Text = RdrStud.GetString(6)
                MaxFats.Text = RdrStud.GetString(7)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Private Sub MainHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ID()
        'ACCOUNT_ID()
        'DATE_CREATED()
        'CALORIES()
        'PROTEIN()
        'CARBS()
        'FATS()
        'MAX_CALORIES()
        'MAX_PROTEIN()
        'MAX_CARBS()
        'MAX_FATS()
        'ACTIVITY_LVL_ID()
        'DIET_PLAN_ID()

        CurrentDate = DateAndTime.Today()


        Call CreateDailyNutrientEntry()

        ' TABLE POPULATE


        Try
            Call PopulateDataGrid()
            Call UpdateSummary()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim clickedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Globals.SelectedIntakeId = clickedRow.Cells(4).Value
            EditSpecificIntake.Show()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles AddMealButton.Click
        SearchIngredient.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MealsLoggedTextBox_TextChanged(sender As Object, e As EventArgs) Handles MealsLoggedTextBox.TextChanged

    End Sub

    Private Sub ProfileManager_Click(sender As Object, e As EventArgs) Handles ProfileManager.Click
        UserProfile.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ViewAllSummaries.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewIntakesAll.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MaxCalories_TextChanged(sender As Object, e As EventArgs) Handles MaxCalories.TextChanged

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        NewUserInformation.Close()
        NewUserRegistration.Close()
        SearchIngredient.Close()
        UserProfile.Close()
        ViewAllSummaries.Close()
        ViewIntakesAll.Close()
        ViewSummaryMeals.Close()
        IngredientDetails.Close()
        EditSpecificIntake.Close()
        LoginForm1.Show()
        Me.Close()
    End Sub
End Class