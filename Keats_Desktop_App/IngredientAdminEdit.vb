Imports IBM.Data.DB2

Public Class IngredientAdminEdit
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


            StrStud = "select ingredient_mapping.ingredient_variant_id, ingredient_mapping.ingredient_subvariant_id, " _
                & " ingredient_variant.name, ingredient_subvariant.name" _
                & " FROM intake" _
                & " JOIN ingredient_mapping ON intake.ingredient_mapping_id = ingredient_mapping.id" _
                & " JOIN ingredient_variant ON ingredient_mapping.ingredient_variant_id = ingredient_variant.id" _
                & " JOIN ingredient_subvariant ON ingredient_mapping.ingredient_subvariant_id = ingredient_subvariant.id" _
                & " WHERE intake.id = " & Globals.SelectedIntakeId & "; "
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            While RdrStud.Read
                FirstIngredientVariantId = Integer.Parse(RdrStud.GetString(0))
                FirstIngredientSubvariantId = Integer.Parse(RdrStud.GetString(1))
                SelectedVariantValue.Text() = RdrStud.GetString(2)
                SelectedSubvariantValue.Text() = RdrStud.GetString(3)
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
            While RdrStud.Read
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
            While RdrStud.Read
                row = New String() {RdrStud.GetString(0), RdrStud.GetString(1)}
                IngredientSubvariant.Rows.Add(row)
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
    Private Sub PopulateDataGrid()
        Dim StrStud As String
        Dim row As String()
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "Select id, name from ingredient"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            SearchResult.Rows.Clear()
            While RdrStud.Read
                row = New String() {RdrStud.GetString(0), RdrStud.GetString(1)}
                SearchResult.Rows.Add(row)
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

    Private Sub SearchResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchResult.CellContentClick
        SearchResult.ColumnCount = 2
        Call PopulateDataGrid()

        ' Check if the click is on a valid row (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < SearchResult.Rows.Count Then
            ' Access the clicked row using the RowIndex property
            Dim clickedRow As DataGridViewRow = SearchResult.Rows(e.RowIndex)

            ' Access the data in the row using the Cells property
            ' Dim cellValue As Object = clickedRow.Cells(1).Value
            ' Replace columnIndex with the index of the desired column 
            Globals.SelectedIngredientId = clickedRow.Cells(0).Value
            Call RetrieveIngredientAndIntake()
            If Not FirstIngredientId = 0 Then
                Call PopulateIngredientVariant()
                Call PopulateIngredientSubvariant()
                Call PopulateNutrients()
                'AmountValue.Text() = IngredientAmount
            End If

            If Not Globals.SelectedIngredientId = 0 Then
                Call PopulateIngredientVariant()
                Call RetrieveIngredient()
                Call PopulateIngredientSubvariant()
                Call PopulateNutrients()
                AmountValue.Text() = IngredientAmount
            End If
        End If
    End Sub


    Private Sub IngredientAdminEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopulateDataGrid()

    End Sub

    Private Sub IngredientVariant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IngredientVariant.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        MainHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class