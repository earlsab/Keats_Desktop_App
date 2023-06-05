Imports IBM.Data.DB2
Imports System.Collections.Generic

Public Class IngredientDetails
    Dim FirstIngredientVariantId As Integer
    Dim FirstIngredientSubvariantId As Integer
    Dim FirstIngredientMappingId As Integer
    Dim IngredientAmount As Integer = 100

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
                & "WHERE ingredient_mapping.ingredient_id = " & Globals.SelectedIngredientId & ");"
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
                & "WHERE ingredient_mapping.ingredient_id = " & Globals.SelectedIngredientId & " " _
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
    Private Sub RetrieveIngredient()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "select name FROM ingredient WHERE id = " & Globals.SelectedIngredientId
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
                & "WHERE ingredient_mapping.ingredient_id = " & Globals.SelectedIngredientId & " " _
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
         
        If Not Globals.SelectedIngredientId = 0 Then
            Call PopulateIngredientVariant()
            Call RetrieveIngredient()
            Call PopulateIngredientSubvariant()
            Call PopulateNutrients()
            AmountValue.Text() = IngredientAmount
        End If
    End Sub



    Private Sub InsertIntake()
        Dim StrStud As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Dim currentDate As Date = DateTime.Now
        Try
            StrStud = "INSERT INTO intake (account_id, date_created, ingredient_mapping_id, amount) " _
                & "VALUES (@AccountId, @DateTimeValue, @IngredientMappingId, @IngredientAmount);"

            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            CmdStud.Parameters.Add("@AccountId", IBM.Data.DB2.DB2Type.Integer).Value = Globals.UserAccountID
            CmdStud.Parameters.Add("@DateTimeValue", IBM.Data.DB2.DB2Type.DateTime).Value = DateTime.Now ' Assuming you want to use the current date and time
            CmdStud.Parameters.Add("@IngredientMappingId", IBM.Data.DB2.DB2Type.Integer).Value = FirstIngredientMappingId
            CmdStud.Parameters.Add("@IngredientAmount", IBM.Data.DB2.DB2Type.Decimal).Value = IngredientAmount

            CmdStud.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateSummaryTable()
        Dim StrStud As String
        Dim StrUpdate As String
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader

        Dim TargetUpdate As Integer
        Dim OldCalories As Single
        Dim OldProtein As Single
        Dim OldCarbs As Single
        Dim OldFats As Single
        ' ID
        'Calories() 3
        'Protein() 4
        'Carbs() 5
        'Fats() 6

        Try
            StrStud = "select id from daily_nutrients where account_id=" & Globals.UserAccountID & " order by date_created " _
            & "DESC OPTIMIZE FOR 1 ROW"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader

            RdrStud.Read()
            TargetUpdate = RdrStud.GetString(0)

            Dim Multiplier As Single = IngredientAmount / 100
            Calories = Calories * Multiplier
            Protein = Protein * Multiplier
            Carbs = Carbs * Multiplier
            Fats = Fats * Multiplier

            StrUpdate = "update daily_nutrients set " _
                & "calories = calories + " & Calories & ", " _
                & "protein = protein + " & Protein & ", " _
                & "carbs = carbs + " & Carbs & ", " _
                & "fats = fats + " & Fats & " " _
                & "where ID = " & TargetUpdate
            CmdStud = New DB2Command(StrUpdate, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
        Catch ex As Exception
            MsgBox("Error updating summary table")
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
        Me.Close()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Call InsertIntake()
        Call UpdateSummaryTable()
        Call MainHomePage.PopulateDataGrid()
        Call MainHomePage.UpdateSummary()
        MainHomePage.Show()
        SearchIngredient.Close()
        Me.Close()
    End Sub

    Private Sub CaloriesLabel_Click(sender As Object, e As EventArgs) Handles CaloriesLabel.Click

    End Sub

    Private Sub AmountValue_TextChanged(sender As Object, e As EventArgs) Handles AmountValue.TextChanged

    End Sub

    Private Sub IngredientSubvariant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IngredientSubvariant.CellContentClick

    End Sub

    Private Sub IngredientVariant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IngredientVariant.CellContentClick

    End Sub
End Class