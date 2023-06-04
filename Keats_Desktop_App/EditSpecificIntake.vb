Imports IBM.Data.DB2
Public Class EditSpecificIntake
    ' Most code reused from Ingredient Details
    Dim FirstIngredientVariantId As Integer
    Dim FirstIngredientSubvariantId As Integer
    Dim FirstIngredientMappingId As Integer
    Dim FirstIngredientId As Integer = 0
    Dim IngredientAmount As Integer = 100
    Dim OldIngredientAmount As Integer = 100

    Dim Calories As Single
    Dim Protein As Single
    Dim Carbs As Single
    Dim Fats As Single

    Private Sub VariantCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IngredientVariant.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < IngredientVariant.Rows.Count Then
            Dim clickedRow As DataGridViewRow = IngredientVariant.Rows(e.RowIndex)
            FirstIngredientVariantId = clickedRow.Cells(0).Value
            SelectedVariantValue.Text() = clickedRow.Cells(1).Value
            Call PopulateIngredientSubvariant()
            Call PopulateNutrients()
        End If
    End Sub
    Private Sub SubvariantCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IngredientSubvariant.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < IngredientSubvariant.Rows.Count Then
            Dim clickedRow As DataGridViewRow = IngredientSubvariant.Rows(e.RowIndex)
            FirstIngredientSubvariantId = clickedRow.Cells(0).Value
            SelectedSubvariantValue.Text() = clickedRow.Cells(1).Value
            Call PopulateNutrients()
        End If
    End Sub


    Private Sub PopulateIngredientVariant()
        Dim StrStud As String
        Dim row As String()
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "select " _
                    & "ingredient_variant.id, ingredient_variant.name " _
                & "FROM ingredient_variant " _
                & "WHERE ingredient_variant.id IN ( " _
                & "SELECT ingredient_mapping.ingredient_variant_id " _
                & "FROM ingredient_mapping " _
                & "WHERE ingredient_mapping.ingredient_id = " & FirstIngredientId & ");"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            IngredientVariant.Rows.Clear()
            Dim variantCount = 0
            While RdrStud.Read
                If variantCount < 1 Then
                    FirstIngredientVariantId = RdrStud.GetInt32(0)
                    SelectedVariantValue.Text() = RdrStud.GetString(1)
                    variantCount = 1
                End If
                row = New String() {RdrStud.GetString(0), RdrStud.GetString(1)}
                IngredientVariant.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub PopulateIngredientSubvariant()
        Dim StrStud As String
        Dim row As String()
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "select ingredient_subvariant.id, ingredient_subvariant.name " _
                & "FROM ingredient_mapping " _
                & "JOIN ingredient_subvariant ON ingredient_mapping.ingredient_subvariant_id = ingredient_subvariant.id " _
                & "WHERE ingredient_mapping.ingredient_id = " & FirstIngredientId & " " _
                & "AND ingredient_mapping.ingredient_variant_id = " & FirstIngredientVariantId & ";"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            IngredientSubvariant.Rows.Clear()
            Dim subvariantCount = 0
            While RdrStud.Read
                If subvariantCount < 1 Then
                    FirstIngredientSubvariantId = RdrStud.GetInt32(0)
                    SelectedSubvariantValue.Text() = RdrStud.GetString(1)
                    subvariantCount = 1
                End If
                row = New String() {RdrStud.GetString(0), RdrStud.GetString(1)}
                IngredientSubvariant.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub RetrieveIngredientAndIntake()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "select intake.amount, ingredient_mapping.ingredient_id FROM intake" _
                & " JOIN ingredient_mapping ON intake.ingredient_mapping_id = ingredient_mapping.id" _
                & " WHERE intake.id = " & Globals.SelectedIntakeId & "; "
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            While RdrStud.Read
                IngredientAmount = Integer.Parse(RdrStud.GetString(0))
                OldIngredientAmount = Integer.Parse(RdrStud.GetString(0))
                FirstIngredientId = Integer.Parse(RdrStud.GetString(1))
            End While


            StrStud = "select name FROM ingredient WHERE id = " & FirstIngredientId
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            While RdrStud.Read
                SelectedIngredientValue.Text() = RdrStud.GetString(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub PopulateNutrients()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "select nutrient.calories, nutrient.protein, nutrient.carbs, nutrient.fats, ingredient_mapping.id " _
                & "FROM ingredient_mapping " _
                & "JOIN nutrient ON ingredient_mapping.nutrient_id = nutrient.id " _
                & "WHERE ingredient_mapping.ingredient_id = " & FirstIngredientId & " " _
                & "AND ingredient_mapping.ingredient_variant_id = " & FirstIngredientVariantId & " " _
                & "AND ingredient_mapping.ingredient_subvariant_id = " & FirstIngredientSubvariantId & ";"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            While RdrStud.Read
                Dim Multiplier As Single = IngredientAmount / 100

                CaloriesValue.Text() = RdrStud.GetString(0) * Multiplier
                ProteinValue.Text() = RdrStud.GetString(1) * Multiplier
                CarbsValue.Text() = RdrStud.GetString(2) * Multiplier
                FatsValue.Text() = RdrStud.GetString(3) * Multiplier

                FirstIngredientMappingId = RdrStud.GetString(4)

                Calories = RdrStud.GetFloat(0)
                Protein = RdrStud.GetFloat(1)
                Carbs = RdrStud.GetFloat(2)
                Fats = RdrStud.GetFloat(3)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub IngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RetrieveIngredientAndIntake() 
        If Not FirstIngredientId = 0 Then 
            Call PopulateIngredientVariant()
            Call PopulateIngredientSubvariant()
            Call PopulateNutrients()
            AmountValue.Text() = IngredientAmount
        End If
    End Sub



    Private Sub UpdateIntake()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Dim currentDate As Date = DateTime.Now
        Try
            StrStud = "UPDATE intake SET amount =  " & IngredientAmount _
                & " WHERE id = " & Globals.SelectedIntakeId & ";"

            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            CmdStud.ExecuteNonQuery()
            MainHomePage.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateDailyNutrient()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Dim currentDate As Date = DateTime.Now
        Try
            StrStud = "UPDATE daily_nutrients SET calories = calories + @calories ," _
                & " protein = protein + @protein ," _
                & " carbs = carbs + @carbs ," _
                & " fats = fats + @fats " _
                & " WHERE account_id = @accountId AND date_created = @DateTimeValue;"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)

            Dim Multiplier As Single = OldIngredientAmount / 100
            Dim OldCal = Calories * Multiplier
            Dim OldProtein = Protein * Multiplier
            Dim OldCarbs = Carbs * Multiplier
            Dim OldFats = Fats * Multiplier

            Dim NewMultiplier As Single = IngredientAmount / 100
            Dim NewCal = Calories * Multiplier
            Dim NewProtein = Protein * Multiplier
            Dim NewCarbs = Carbs * Multiplier
            Dim NewFats = Fats * Multiplier
            MsgBox(NewCal - OldCal)
            CmdStud.Parameters.Add("@calories", IBM.Data.DB2.DB2Type.Integer).Value = NewCal - OldCal
            CmdStud.Parameters.Add("@protein", IBM.Data.DB2.DB2Type.Integer).Value = NewProtein - OldProtein
            CmdStud.Parameters.Add("@carbs", IBM.Data.DB2.DB2Type.Integer).Value = NewCarbs - OldCarbs
            CmdStud.Parameters.Add("@fats", IBM.Data.DB2.DB2Type.Integer).Value = NewFats - OldFats
            CmdStud.Parameters.Add("@accountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
            CmdStud.Parameters.Add("@dateTimeValue", IBM.Data.DB2.DB2Type.DateTime).Value = DateTime.Now
            CmdStud.ExecuteNonQuery()
            MainHomePage.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteIntake()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Dim currentDate As Date = DateTime.Now
        Try
            StrStud = "DELETE FROM intake WHERE id = " & Globals.SelectedIntakeId & ";"

            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            CmdStud.ExecuteNonQuery()
            MainHomePage.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeductDailyNutrient()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Dim currentDate As Date = DateTime.Now
        Try
            StrStud = "UPDATE daily_nutrients SET calories = calories - @calories ," _
                & " protein = protein - @protein ," _
                & " carbs = carbs - @carbs ," _
                & " fats = fats - @fats " _
                & " WHERE account_id = @accountId AND date_created = @DateTimeValue;"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)

            Dim Multiplier As Single = OldIngredientAmount / 100
            Dim OldCal = Calories * Multiplier
            Dim OldProtein = Protein * Multiplier
            Dim OldCarbs = Carbs * Multiplier
            Dim OldFats = Fats * Multiplier 
            CmdStud.Parameters.Add("@calories", IBM.Data.DB2.DB2Type.Integer).Value = OldCal
            CmdStud.Parameters.Add("@protein", IBM.Data.DB2.DB2Type.Integer).Value = OldProtein
            CmdStud.Parameters.Add("@carbs", IBM.Data.DB2.DB2Type.Integer).Value = OldCarbs
            CmdStud.Parameters.Add("@fats", IBM.Data.DB2.DB2Type.Integer).Value = OldFats
            CmdStud.Parameters.Add("@accountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
            CmdStud.Parameters.Add("@dateTimeValue", IBM.Data.DB2.DB2Type.DateTime).Value = DateTime.Now
            CmdStud.ExecuteNonQuery()
            MainHomePage.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'For disabling text input and only number input on amount
    Private Sub Amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountValue.KeyPress
        ' Check if the entered character is a valid number
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancel the key press event to prevent the character from being entered
            e.Handled = True
        End If
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            Dim digit As Integer
            If Asc(e.KeyChar) = 8 Then
                Try
                    digit = Integer.Parse(AmountValue.Text())
                    If AmountValue.Text.Length > 0 Then
                        digit = AmountValue.Text.Substring(0, AmountValue.Text.Length - 1)
                    End If
                Catch ex As Exception
                    digit = 0
                End Try
            Else
                digit = Integer.Parse(AmountValue.Text() + e.KeyChar.ToString())
            End If
            IngredientAmount = digit
            Dim Multiplier As Single = digit / 100
            CaloriesValue.Text() = Calories * Multiplier
            ProteinValue.Text() = Protein * Multiplier
            CarbsValue.Text() = Carbs * Multiplier
            FatsValue.Text() = Fats * Multiplier
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        MainHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub EditSpecificIntake_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IngredientVariant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IngredientVariant.CellContentClick

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Call UpdateIntake()
        Call UpdateDailyNutrient()
        Call MainHomePage.PopulateDataGrid()
        Call MainHomePage.UpdateSummary()
        Me.Close()
        MainHomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Delete.Click 
        Call DeleteIntake()
        Call DeductDailyNutrient()
        Call MainHomePage.PopulateDataGrid()
        Call MainHomePage.UpdateSummary()
        Me.Close()
        MainHomePage.Show()
    End Sub
End Class